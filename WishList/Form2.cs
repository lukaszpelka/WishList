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
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            try
            {
                //Wish tempWish = FindWishByName(name);
                //trescLabel.Text = tempWish.Name;
                //cenaLabel.Text = tempWish.Price.toString();
                //priorytetLabel.Text = tempWish.Priority.toString();
                //dataDodaniaLabel.Text = tempWish.AddedTime.ToLongDateString() + " " + tempWish.AddedTime.ToShortTimeString();
                //opisRichTextBox.Text = tempWish.Description;
                trescLabel.Text = name;
            }
            catch (Exception e)
            {
                MessageBox.Show("Życzenie o podanej treści nie istnieje!", "Wish List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
