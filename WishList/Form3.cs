using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WishList
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            errorLabel.Visible = false;
            errorLabel.Text = "Wystąpił błąd w polu: ";
        }



        private void dodajButton_Click(object sender, EventArgs e)
        {
            string name= "";
            int priority = 0;
            double price = 0.0;
            string description = "";
            bool go = false;
            errorLabel.Text = "Wystąpił błąd w polu: ";
            if (trescTextBox.Text == string.Empty)
            {
                errorLabel.Visible = true;
                errorLabel.Text += "treść.";
            }
            else if (!int.TryParse(priorytetTextBox.Text, out priority) || priorytetTextBox.Text == string.Empty)
            {
                errorLabel.Visible = true;
                errorLabel.Text += "priorytet.";
            }
            else if ((!double.TryParse(cenaTextBox.Text, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out price) &&
                    !double.TryParse(cenaTextBox.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out price) &&
                    !double.TryParse(cenaTextBox.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out price)) || cenaTextBox.Text == string.Empty)
            {
                errorLabel.Visible = true;
                errorLabel.Text += "cena.";
            }
            else
            {
                errorLabel.Visible = false;
                name = trescTextBox.Text;
                description = opisRichTextBox.Text;
            }     
            Wish tempwish = new Wish(name, description, priority, price, DateTime.Now);
            //this.Close();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
            rssDoc.Load("Wishes.xml");
            XmlNode node = rssDoc.CreateNode(XmlNodeType.Element, "wish", null);
            XmlNode nodeTresc = rssDoc.CreateElement("name");
            nodeTresc.InnerText = tempwish.Name;
            node.AppendChild(nodeTresc);
            rssDoc.DocumentElement.AppendChild(node);

            XmlNode nodeCena = rssDoc.CreateElement("description");
            nodeTresc.InnerText = tempwish.Description;
            node.AppendChild(nodeCena);
            rssDoc.DocumentElement.AppendChild(node);

            XmlNode nodePriorytet = rssDoc.CreateElement("priority");
            nodeTresc.InnerText = tempwish.Priority.ToString();
            node.AppendChild(nodePriorytet);
            rssDoc.DocumentElement.AppendChild(node);

            XmlNode nodeOpis = rssDoc.CreateElement("price");
            nodeTresc.InnerText = tempwish.Price.ToString();
            node.AppendChild(nodeOpis);
            rssDoc.DocumentElement.AppendChild(node);

            XmlNode nodeData = rssDoc.CreateElement("addedTime");
            nodeTresc.InnerText = tempwish.AddedTime.ToString("yyyy-MM-dd, HH:mm");
            node.AppendChild(nodeData);
            rssDoc.DocumentElement.AppendChild(node);

            rssDoc.Save("rss.xml");


        }

        private void wyczyscButton_Click(object sender, EventArgs e)
        {
            trescTextBox.Text = string.Empty;
            cenaTextBox.Text = string.Empty;
            priorytetTextBox.Text = string.Empty;
            opisRichTextBox.Text = string.Empty;
            errorLabel.Visible = false;
            errorLabel.Text = "Wystąpił błąd w polu ";
        }
    }
}
