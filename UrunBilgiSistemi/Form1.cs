using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("UrunKodu");
            dt.Columns.Add("UrunAdi");
            dt.Columns.Add("UrunKategorisi");
            dt.Columns.Add("UrunMaliyeti");
            dt.Columns.Add("SatisFiyati");
            dt.Columns.Add("Adet");
            dt.Columns.Add("UrunBirimi");
            string[] kategoriler = new string[5] { "Kategori1", "Kategori 2", "Kategori 3", "Kategori 4", "Kategori 5", };
            cbKategori.Items.AddRange(kategoriler);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbKodu.Text == string.Empty)
                    MessageBox.Show("Ürün kodu boş geçilemez.");
                else if (tbAdi.Text == string.Empty)
                    MessageBox.Show("Ürün adı boş geçilemez.");
                else if (cbKategori.SelectedItem == null)
                    MessageBox.Show("Ürün kategorisi seçilmelidir.");
                else if (tbMaliyet.Text == string.Empty)
                    MessageBox.Show("Ürün maliyeti boş geçilemez.");
                else if (tbSatişFiyati.Text == string.Empty)
                    MessageBox.Show("Satış fiyatı boş geçilemez.");
                else if (tbAdet.Text == string.Empty)
                    MessageBox.Show("Adet boş geçilemez.");
                else if (cbBirim.SelectedItem == null)
                    MessageBox.Show("Birim seçilmelidir.");
                else
                {
                    DataRow dr1 = dt.NewRow();
                    dr1["UrunKodu"] = tbKodu.Text;
                    dr1["UrunAdi"] = tbAdi.Text;
                    dr1["UrunKategorisi"] = cbKategori.SelectedItem.ToString();
                    dr1["UrunMaliyeti"] = tbMaliyet.Text;
                    dr1["SatisFiyati"] = tbSatişFiyati.Text;
                    dr1["Adet"] = tbAdet.Text;
                    dr1["UrunBirimi"] = cbBirim.SelectedItem.ToString();
                    dt.Rows.Add(dr1);
                    dgUrunler.DataSource = dt;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sayı girişi yapılması gereken bir alana hatalı giriş yaptınız.");
            }
        }

        private void dgUrunler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUrunler.SelectedRows.Count > 0)
            {
                tbKodu.Text = dgUrunler.SelectedRows[0].Cells[0].Value.ToString();
                tbAdi.Text = dgUrunler.SelectedRows[0].Cells[1].Value.ToString();
                cbKategori.SelectedItem = dgUrunler.SelectedRows[0].Cells[2].Value.ToString();
                tbMaliyet.Text = dgUrunler.SelectedRows[0].Cells[3].Value.ToString();
                tbSatişFiyati.Text = dgUrunler.SelectedRows[0].Cells[4].Value.ToString();
                tbAdet.Text = dgUrunler.SelectedRows[0].Cells[5].Value.ToString();
                cbBirim.SelectedItem = dgUrunler.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgUrunler.SelectedRows.Count > 0)
            {
                if (tbKodu.Text == string.Empty)
                    MessageBox.Show("Ürün kodu boş geçilemez.");
                else if (tbAdi.Text == string.Empty)
                    MessageBox.Show("Ürün adı boş geçilemez.");
                else if (cbKategori.SelectedItem.ToString() == string.Empty)
                    MessageBox.Show("Ürün kategorisi seçilmelidir.");
                else if (tbMaliyet.Text == string.Empty)
                    MessageBox.Show("Ürün maliyeti boş geçilemez.");
                else if (tbSatişFiyati.Text == string.Empty)
                    MessageBox.Show("Satış fiyatı boş geçilemez.");
                else if (tbAdet.Text == string.Empty)
                    MessageBox.Show("Adet boş geçilemez.");
                else if (cbBirim.SelectedItem.ToString() == string.Empty)
                    MessageBox.Show("Birim seçilmelidir..");
                else
                {
                    int secilenIndex = dgUrunler.CurrentRow.Index;
                    DataRow drsecilmis = dt.Rows[secilenIndex];
                    drsecilmis["UrunKodu"] = tbKodu.Text;
                    drsecilmis["UrunAdi"] = tbAdi.Text;
                    drsecilmis["UrunKategorisi"] = cbKategori.SelectedItem.ToString();
                    drsecilmis["UrunMaliyeti"] = tbMaliyet.Text;
                    drsecilmis["SatisFiyati"] = tbSatişFiyati.Text;
                    drsecilmis["Adet"] = tbAdet.Text;
                    drsecilmis["UrunBirimi"] = cbBirim.SelectedItem.ToString();
                    dgUrunler.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgUrunler.SelectedRows.Count > 0)
            {
                int secilenIndex = dgUrunler.CurrentRow.Index;
                dt.Rows.RemoveAt(secilenIndex);
                dgUrunler.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçin.");
            }

        }

        private void btnToplamMaliyet_Click(object sender, EventArgs e)
        {
            double toplamMaliyet = 0;
            foreach (DataRow row in dt.Rows)
            {
                int urunMaliyeti = Convert.ToInt32(row["UrunMaliyeti"]) * Convert.ToInt32(row["Adet"]);
                toplamMaliyet += urunMaliyeti;
            }
            MessageBox.Show("Toplam maliyet : " + toplamMaliyet);
        }
    }
}
