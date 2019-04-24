using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnKısaYolFORM
{
    public partial class EnKisayaYolGiris : Form
    {
        public EnKisayaYolGiris()
        {
            InitializeComponent();
        }

        void durum(bool gosterim)
        {
            dataGridView1.Visible = button2.Visible = button3.Visible = gosterim;

            if (gosterim)
            {
                this.Size = new Size(389,339);
                this.AcceptButton = button2;
                textBox1.Enabled = false;
                button1.Enabled = false;

            }
            else
            {
                this.Size = new Size(389,100);
                this.AcceptButton = button1;
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            durum(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            durum(true);

            DataTable tbl = new DataTable("Tablo");
            tbl.Columns.Add("Dügüm 1");
            tbl.Columns.Add("Dügüm 2");
            tbl.Columns.Add("Mesafe");

            for (int i = 1; i <= Convert.ToInt32( textBox1.Text ); i++)
            {
                for (int j = 1; j <= Convert.ToInt32(textBox1.Text); j++)
                {
                    if (i!=j && i<j)
                    {
                        tbl.Rows.Add(i, j, "-");
                    }
                }
            }

            DataSet ds = new DataSet("YeniDataSet");
            ds.Tables.Add(tbl);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tablo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            durum(false);
        }

        public static int dugumsayisi;
        public static int mesafetoplami;

        public static string[] mesafeler;

        private void button2_Click(object sender, EventArgs e)
        {
            mesafeler = new string[dataGridView1.Rows.Count]; 

            dugumsayisi = Convert.ToInt32(textBox1.Text);
          

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               mesafeler[i]= Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);

               if (mesafeler[i] != "-")
               {
                   mesafetoplami += Convert.ToInt32(mesafeler[i]);
               }
            }

            MessageBox.Show("Veriler Kaydedilmiştir.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bul frm = new Bul();
            frm.ShowDialog();
        }
    }
}
