using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class SelectedProductUpdate : Form
    {
        public SelectedProductUpdate()
        {
            InitializeComponent();
        }
        public Product Product;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtİsim.Text.Length > 0)
            {
                if (txtFiyat.Text.Length > 0)
                {

                    if (txtAciklama.Text.Length > 0)
                    {
                        if (txtAgirlik.Text.Length > 0)
                        {
                            Product.Name = txtİsim.Text;
                            Product.Price = Convert.ToDouble(txtFiyat.Text);
                            Product.Description = txtAciklama.Text;
                            Product.Weight = Convert.ToDouble(txtAgirlik.Text);
                            Product.ProductUpdate();
                            MessageBox.Show("Ürün başarıyla güncellendi", "GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Executive frmItemUpdate = (Executive)Application.OpenForms["Executive"];
                            frmItemUpdate.lists();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ürün ağırlığı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün açıklaması boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün fiyatı boş bırakılamaz.", "EKSİK GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
