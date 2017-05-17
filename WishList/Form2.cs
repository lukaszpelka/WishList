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
                Wish tempWish = WishList.Wish.FindWishByName(name);
                if (tempWish != null)
                {
                    trescLabel.Text = tempWish.Name;
                    cenaLabel.Text = tempWish.Price.ToString();
                    priorytetLabel.Text = tempWish.Priority.ToString();
                    dataDodaniaLabel.Text = tempWish.AddedTime.ToLongDateString() + " " + tempWish.AddedTime.ToShortTimeString();
                    opisRichTextBox.Text = tempWish.Description;
                    opisRichTextBox.ReadOnly = true;
                    trescLabel.Text = name;
                }
                else
                    MessageBox.Show("Życzenie o podanej treści nie istnieje!", "Wish List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show("Życzenie o podanej treści nie istnieje!", "Wish List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
