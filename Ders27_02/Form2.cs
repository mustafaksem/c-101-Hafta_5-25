using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders27_02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // bir datatable oluşturalım 10 satır olsun.
            //öğrenci adı, öğrenci soyadı, okul numarası (1-1000 arası rastgele), tc no (11 hane)
            // satır başına tıklandığında ögrenci adı, soyadı okul numarası ve tc nosu 4 farklı labelde yazsın

            DataTable dt = new DataTable();
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("OkulNo");
            dt.Columns.Add("TCNo");

            Random random = new Random();
            string[] tcNoListesi = new string[10];

            for (int i = 1; i <= 10; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Ad"] = "Öğrenci" + i;
                dr["Soyad"] = "Soyad" + i;
                dr["OkulNo"] = random.Next(1, 1000);
                string tcNo = "";
                for (int j = 0; j < 11; j++)
                {
                    tcNo += random.Next(0, 10).ToString();
                }
                dr["TCNo"] = tcNo;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblOgrenciAdi.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lblSoyad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lblOgrenciNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lblTCNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}

