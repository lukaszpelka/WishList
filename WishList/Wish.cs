using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WishList
{
    class Wish
    {
        public string Name;
        public string Description;
        public int Priority;
        public double Price;
        public DateTime AddedTime;
        private string DatePattern = "yyyy-MM-dd, HH:mm";
        public Wish()
        {
            Name = string.Empty;
            Description = string.Empty;
            Priority = 0;
            Price = 0.0;
            DateTime.TryParseExact("1980-01-01, 00:00", DatePattern, null, DateTimeStyles.None, out AddedTime);
        }

        public Wish(string _Name, string _Description, int _Priority, double _Price, DateTime _AddedTime)
        {
            Name = _Name;
            Description = _Description;
            Priority = _Priority;
            Price = _Price;
            AddedTime = _AddedTime;
        }

        public static List<Wish> GetAllWishes()
        {
            List<Wish> tempWishList = new List<Wish>();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
            rssDoc.Load("Wishes.xml");
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("wishes/wish");
            System.Xml.XmlNode rssNode;
            
            Wish tempWish = new Wish();
            int index = 0;
            foreach (var wish in rssItems)
            {
                rssNode = rssItems.Item(index).SelectSingleNode("name");
                if (rssNode != null)
                {
                    tempWish.Name = rssNode.InnerText;
                }
                else
                {
                    tempWish.Name = string.Empty;
                }

                rssNode = rssItems.Item(index).SelectSingleNode("description");
                if (rssNode != null)
                {
                    tempWish.Description = rssNode.InnerText;
                }
                else
                {
                    tempWish.Description = string.Empty;
                }

                rssNode = rssItems.Item(index).SelectSingleNode("priority");
                if (rssNode != null)
                {
                    if (!int.TryParse(rssNode.InnerText, out tempWish.Priority))
                        tempWish.Priority = 0;
                }
                else
                {
                    tempWish.Priority = 0;
                }

                rssNode = rssItems.Item(index).SelectSingleNode("price");
                if (rssNode != null)
                {
                    if (!double.TryParse(rssNode.InnerText, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out tempWish.Price) &&
                        !double.TryParse(rssNode.InnerText, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out tempWish.Price) &&
                        !double.TryParse(rssNode.InnerText, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out tempWish.Price))
                        tempWish.Price = 0.0;
                }
                else
                {
                    tempWish.Price = 0.0;
                }

                rssNode = rssItems.Item(index).SelectSingleNode("addedTime");
                if (rssNode != null)
                {
                    DateTime.TryParseExact(rssNode.InnerText, tempWish.DatePattern, null, DateTimeStyles.None, out tempWish.AddedTime);
                }
                else
                {
                    DateTime.TryParseExact("1980-01-01, 00:00", tempWish.DatePattern, null, DateTimeStyles.None, out tempWish.AddedTime);
                }
                index++;
                tempWishList.Add(tempWish);
            }
            return tempWishList;
        }

        public static Wish FindWishByName(string name)
        {
            var tempList = GetAllWishes();
            foreach (var wish in tempList)
            {
                if (wish.Name == name)
                    return wish;
            }
            return null;
        }
    }
}
