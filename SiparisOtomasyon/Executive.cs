using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class Executive : Form
    {
        public Executive()
        {
            InitializeComponent();
        }
        string[] PictureFileLocation = new string[3];
        Item Item = new Item();
        int PictureCount = 0;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtÜrünAdi.Text.Length > 0)
            {
                if (txtÜrünFiyat.Text.Length > 0)
                {
                    if (txtÜrünAğirliği.Text.Length > 0)
                    {
                        if (cbxVergi.Text != "")
                        {
                            if (flowLayoutPanel1.Controls.Count > 0)
                            {


                                double Tax;
                                Item.Name = txtÜrünAdi.Text;
                                Item.Price = Convert.ToDouble(txtÜrünFiyat.Text);
                                Item.Weight = Convert.ToDouble(txtÜrünAğirliği.Text);
                                if (cbxVergi.SelectedIndex == 0)
                                    Tax = 0.03;
                                else if (cbxVergi.SelectedIndex == 1)
                                    Tax = 0.10;
                                else
                                    Tax = 0.20;
                                Item.Tax = Tax;
                                string target = Application.StartupPath + @"\Images\";
                                int ItemID = Item.maxItemID() + 1;
                                Item.ItemAdd();
                                for (int i = 0; i < 3; i++)
                                {
                                    if (PictureFileLocation[i] != null)
                                    {
                                        string newPictureFileName = "Item" + ItemID + "-" + Convert.ToInt32(i + 1) + ".png";
                                        File.Copy(PictureFileLocation[i], target + newPictureFileName);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("En az 1 tane ürün fotoğrafı ekleyiniz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen vergi seçiniz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün ağırlığı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün fiyatı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ürün ismi boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
