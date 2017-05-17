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
                priority = Convert.ToInt32(numericUpDown.Value);

                Wish tempwish = new Wish(name, description, priority, price, DateTime.Now);

                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
                rssDoc.Load("Wishes.xml");
                XmlNode node = rssDoc.CreateNode(XmlNodeType.Element, "wish", null);

                XmlNode nodeTresc = rssDoc.CreateElement("name");
                nodeTresc.InnerText = tempwish.Name;
                node.AppendChild(nodeTresc);
                rssDoc.DocumentElement.AppendChild(node);

                XmlNode nodeCena = rssDoc.CreateElement("description");
                nodeCena.InnerText = tempwish.Description;
                node.AppendChild(nodeCena);
                rssDoc.DocumentElement.AppendChild(node);

                XmlNode nodePriorytet = rssDoc.CreateElement("priority");
                nodePriorytet.InnerText = tempwish.Priority.ToString();
                node.AppendChild(nodePriorytet);
                rssDoc.DocumentElement.AppendChild(node);

                XmlNode nodeOpis = rssDoc.CreateElement("price");
                nodeOpis.InnerText = tempwish.Price.ToString();
                node.AppendChild(nodeOpis);
                rssDoc.DocumentElement.AppendChild(node);

                XmlNode nodeData = rssDoc.CreateElement("addedTime");
                nodeData.InnerText = tempwish.AddedTime.ToString("yyyy-MM-dd, HH:mm");
                node.AppendChild(nodeData);
                rssDoc.DocumentElement.AppendChild(node);

                rssDoc.Save("rss.xml");

                //Form1 f = new Form1();
                //f.LoadListView();

                this.Close();
            }
        }

        private void wyczyscButton_Click(object sender, EventArgs e)
        {
            trescTextBox.Text = string.Empty;
            cenaTextBox.Text = string.Empty;
            numericUpDown.Value = 5;
            opisRichTextBox.Text = string.Empty;
            errorLabel.Visible = false;
            errorLabel.Text = "Wystąpił błąd w polu ";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamknąć bez zapisywania?", "Wish List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
