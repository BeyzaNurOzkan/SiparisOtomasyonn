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
        List<Product> Products;
        Product Product;
        List<Users> User;
        Users Users;
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
                                Product.Name = txtÜrünAdi.Text;
                                Product.Description = txtAciklama.Text;
                                Product.Price = Convert.ToDouble(txtÜrünFiyat.Text);
                                Product.Weight = Convert.ToDouble(txtÜrünAğirliği.Text);
                                if (cbxVergi.SelectedIndex == 0)
                                    Tax = 0.01;
                                else if (cbxVergi.SelectedIndex == 1)
                                    Tax = 0.08;
                                else
                                    Tax = 0.18;
                                Product.Tax = Tax;
                                string target = Application.StartupPath + @"\Images\";
                                int ProductID = Product.maxProductID() + 1;
                                Product.ProductAdd();
                                for (int i = 0; i < 1; i++)
                                {
                                    if (PictureFileLocation[i] != null)
                                    {
                                        string newPictureFileName = "Product" + ProductID + "-" + Convert.ToInt32(i + 1) + ".png";
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
            MessageBox.Show("Ürün Kaydedildi.");

        }
        private void btnResimEkle_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog PictureFile = new OpenFileDialog();
            PictureBox pbPicture = new PictureBox();
            PictureFile.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;";
            if (PictureCount < 3)
            {
                if (PictureFile.ShowDialog() == DialogResult.OK)
                {
                    pbPicture.Name = "Pbpicture";
                    pbPicture.Tag = PictureCount;
                    pbPicture.Width = 130;
                    pbPicture.Height = 230;
                    PictureFileLocation[PictureCount] = PictureFile.FileName;
                    pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbPicture.ImageLocation = PictureFileLocation[PictureCount];
                    flowLayoutPanel1.Controls.Add(pbPicture);
                    PictureCount++;
                }
            }
            else
            {
                MessageBox.Show("En fazla 3 adet fotoğraf ekliyebilirsiniz.", "YANLIŞ GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnResimSil_Click_1(object sender, EventArgs e)
        {

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                PictureCount = 0;
                for (int i = 0; i < PictureFileLocation.Length; i++)
                {
                    PictureFileLocation[i] = null;
                }
            }
        }
        public void lists()
        {
            Product = new Product();
            Product.getProduct();
            Products = Product.Products;
            ProductTable.Items.Clear();
            ProductTable.View = View.Details;
            ProductTable.FullRowSelect = true;
            ProductTable.GridLines = true;
            ProductTable.Columns.Add("No", 50);
            ProductTable.Columns.Add("İsmi", 200);
            ProductTable.Columns.Add("Ağırlığı", 100);
            ProductTable.Columns.Add("Vergi Oranı", 100);
            ProductTable.Columns.Add("Açıklaması", 300);
            string Tax;
            for (int i = 0; i < Products.Count; i++)
            {

                if (Products[i].Tax == 0.01)
                    Tax = "%1";
                else if (Products[i].Tax == 0.08)
                    Tax = "%8";
                else
                    Tax = "%18";

                string[] row =
                {
                    Products[i].ID.ToString(),
                    Products[i].Name,
                    Products[i].Description,
                    Products[i].Weight.ToString()+" kg",
                    Tax
                };
                var listviewLine = new ListViewItem(row);
                ProductTable.Items.Add(listviewLine);
            }
        }
        public void userlists()
        {
            Users = new Users();
            Users.getUsers();
            User = Users.User;
            UserTable.Items.Clear();
            UserTable.View = View.Details;
            UserTable.FullRowSelect = true;
            UserTable.GridLines = true;
            UserTable.Columns.Add("No", 50);
            UserTable.Columns.Add("Adı Soyadı", 200);
            UserTable.Columns.Add("Kullanıcı Adı", 100);
            UserTable.Columns.Add("Şifresi", 100);
            UserTable.Columns.Add("Durumu", 200);
            string State;
            for (int i = 0; i < User.Count; i++)
            {
                if (User[i].State == true)
                    State = "Kullanıcı";
                else
                    State = "Yönetici";
                string[] row =
                {
                    User[i].UserID.ToString(),
                    User[i].Name,
                    User[i].UserName,
                    User[i].Password,
                    State
                };
                var listviewLine = new ListViewItem(row);
                UserTable.Items.Add(listviewLine);
            }
        }
        private void Executive_Load(object sender, EventArgs e)
        {
            lists();
            userlists();
        }

        private void pbFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ListViewItem product = ProductTable.SelectedItems[0];
            string ItemString = "Ürün Numarası = " + product.SubItems[0].Text + "\nÜrün İsmi = " + product.SubItems[1].Text + "\nÜrün Açıklaması = " + product.SubItems[2].Text + "\nÜrün Ağırlığı = " + product.SubItems[3].Text + "\nÜrün Vergi Oranı = " + product.SubItems[4].Text;
            if (MessageBox.Show(ItemString + "\n\nBu ürünü silmek istediğinize emin misiniz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (File.Exists(Application.StartupPath + @"\Images\Product" + product.SubItems[0].Text + "-" + Convert.ToInt32(i + 1) + ".png"))
                    {
                        File.Delete(Application.StartupPath + @"\Images\Product" + product.SubItems[0].Text + "-" + Convert.ToInt32(i + 1) + ".png");
                    }
                    else
                    {
                        break;
                    }

                }
                Product.ProductRemove(Convert.ToInt32(product.SubItems[0].Text));
                lists();
                MessageBox.Show("Ürün Başarıyla Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SelectedProductUpdate"] == null)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ID == Convert.ToInt32(ProductTable.SelectedItems[0].Text))
                    {
                        SelectedProductUpdate frmSelectedItemUpdate = new SelectedProductUpdate();
                        frmSelectedItemUpdate.Product = Products[i];
                        frmSelectedItemUpdate.MdiParent = Application.OpenForms["MainForm"];
                        frmSelectedItemUpdate.Show();

                    }
                }
            }
        }

        private void UserTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection lvc = this.UserTable.SelectedItems;
            foreach (ListViewItem item in lvc)
            {
                txtKullaniciAdi.Text = UserTable.SelectedItems[0].SubItems[2].Text.ToString();
                txtAdiSoyad.Text = UserTable.SelectedItems[0].SubItems[1].Text.ToString();
                txtSifre.Text = UserTable.SelectedItems[0].SubItems[3].Text.ToString();
                txtDurum.Text = UserTable.SelectedItems[0].SubItems[4].Text.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Length > 0)
            {
                if (txtAdiSoyad.Text.Length > 0)
                {

                    if (txtSifre.Text.Length > 0)
                    {
                        if (txtDurum.Text.Length > 0)
                        {
                            bool state = false;
                            if (txtDurum.Text == "Kullanıcı")
                                state = true;
                            Users.UserName = txtKullaniciAdi.Text;
                            Users.Name = txtAdiSoyad.Text;
                            Users.Password = txtSifre.Text;
                            Users.State =state;
                            Users.UserID =Convert.ToInt32( this.UserTable.SelectedItems[0].Text);
                            Users.UserUpdate();
                            MessageBox.Show("Kişi başarıyla güncellendi", "GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Executive frmItemUpdate = (Executive)Application.OpenForms["Executive"];
                            frmItemUpdate.lists();
                        }
                        else
                        {
                            MessageBox.Show("Durumu boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adı Soyadı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
