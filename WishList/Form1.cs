using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            LoadListView();
        }

        private void LoadListView()
        {
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(500, 300));

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.Ascending;

            var WishList = Wish.GetAllWishes();
            foreach (var item in WishList)
            {
                ListViewItem tempItem = new ListViewItem(item.Name);
                tempItem.SubItems.Add(item.Price.ToString());
                tempItem.SubItems.Add(item.Priority.ToString());
                tempItem.SubItems.Add(item.AddedTime.ToLongDateString() + ", " + item.AddedTime.ToShortTimeString());
                listView1.Items.Add(tempItem);
            }

            listView1.Columns.Add("Treść życzenia", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Cena", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Priorytet", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Data dodania", -2, HorizontalAlignment.Left);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Wish w = new Wish();
            //label1.Text = w.Name + " " + w.Description + " "+ w.Price.ToString() + " "+w.Priority.ToString()+" " + w.AddedTime.ToLongDateString() +" " + w.AddedTime.ToShortTimeString();
            var WishList = Wish.GetAllWishes();
            int startingX = 13;
            int startingY = 13;
            int controlHeight = 23;
            int i = 1;
            foreach (var item in WishList)
            {
                Label l = new Label();
                l.Text = item.Name + " " + item.Description + " " + item.Price.ToString() + " " + item.Priority.ToString() + " " + item.AddedTime.ToLongDateString() + ", " + item.AddedTime.ToShortTimeString();
                l.Location = new System.Drawing.Point(startingX, startingY + i * controlHeight);
                l.Size = new System.Drawing.Size(500, 23);

                this.Controls.Add(l);
                i++;
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Price.ToString() + " " + item.Priority.ToString() + " " + item.AddedTime.ToLongDateString() + ", " + item.AddedTime.ToShortTimeString());
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string selectedName = listView1.SelectedItems[0].Text;
            Console.WriteLine(selectedName);
            Form2 form2 = new Form2(selectedName);
            form2.ShowDialog();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        
        //todo
        //ogarnac czytanie z xmla
        //ogarnac findwishbyname


    }
}