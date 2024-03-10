using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders27_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable

            DataTable dt = new DataTable();
            dt.Columns.Add("OgrenciAdi");
            dt.Columns.Add("ogrenciSoyadi");
            dt.Columns.Add("ogrenciNumarasi");

            DataRow dr = dt.NewRow();
            dr["OgrenciAdi"] = "Mustafa";
            dr["ogrenciSoyadi"] = "Kösem";
            dr["ogrenciNumarasi"] = "1596";

            dt.Rows.Add(dr);
            dgOgrenciler.DataSource = dt;
            //MessageBox.Show(dt.Rows[0]["ogrenciSoyadi"].ToString());

            // Döngü ile veri ekleme
            for (int i = 0; i < 10; i++)
            {
                DataRow dr2 = dt.NewRow();
                dr2["OgrenciAdi"] = "Öğrenci adı" + i.ToString();
                dr2["ogrenciSoyadi"] = "Soyad" + i.ToString();
                dr2["ogrenciNumarasi"] = i.ToString();
                dt.Rows.Add(dr2);
            }
            dgOgrenciler.DataSource = dt;
            for (int i = 0; i < 10; i++)
            {
                DataRow dr3 = dt.NewRow();
                dr3["OgrenciAdi"] = "Öğrenci adı" + i.ToString();
                dr3["ogrenciSoyadi"] = "Soyad" + i.ToString();
                dr3["ogrenciNumarasi"] = i.ToString();
                dt.Rows.Add(dr3);
            }
            dgOgrenciler.DataSource = dt;



            foreach (DataRow drx in dt.Rows)
            {
                string ad = drx["OgrenciAdi"].ToString();
            }

        }

        private void dgOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOgrenciler.SelectedRows.Count > 0)
            {
                MessageBox.Show(dgOgrenciler.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
