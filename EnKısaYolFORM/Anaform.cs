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
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        string[] kisiler = { "olivia", "john", "jack", "celine", "chloe", "winston" };
        int bfsmaliyet = 0;
        int[] dijkstramaliyet = new int[15];
        string[] primlist = new string[6];
        int[] kimden = { 2, 2, 2, 1, 1, 4, 4, 4, 3, 5 };
        int[] kime = { 1, 4, 3, 5, 4, 3, 6, 5, 6, 6 };
        int[] uzunluk = { 12, 7, 9, 5, 8, 4, 16, 6, 15, 10 };
        int[] dolasilan = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int[,] SosyalAg = new int[6, 6];
        int sayac = 0;
        int tempsayac = 11;
        int[] q = new int[6];


        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < uzunluk.Length; i++)
            {
                MessageBox.Show("Kod Adı-->" + kimden[i] + Environment.NewLine + "Kod Adı-->" + kime[i] + Environment.NewLine + "Uzunluk-->" + uzunluk[i] + Environment.NewLine);
            }
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            SosyalAg[0, 0] = 0; SosyalAg[1, 1] = 0; SosyalAg[2, 2] = 0; SosyalAg[3, 3] = 0; SosyalAg[4, 4] = 0; SosyalAg[5, 5] = 0;
            SosyalAg[0, 1] = 12; SosyalAg[0, 2] = 8; SosyalAg[0, 3] = 5; SosyalAg[1, 0] = 12; SosyalAg[1, 2] = 7; SosyalAg[1, 4] = 9;
            SosyalAg[2, 0] = 8; SosyalAg[2, 1] = 7; SosyalAg[2, 3] = 6; SosyalAg[2, 4] = 4; SosyalAg[2, 5] = 16; SosyalAg[3, 0] = 5;
            SosyalAg[3, 2] = 6; SosyalAg[3, 5] = 10; SosyalAg[4, 1] = 9; SosyalAg[4, 2] = 4; SosyalAg[4, 5] = 15; SosyalAg[5, 2] = 6;
            SosyalAg[5, 3] = 10; SosyalAg[5, 4] = 15; SosyalAg[0, 4] = 0; SosyalAg[0, 5] = 0; SosyalAg[1, 3] = 0; SosyalAg[1, 5] = 0;
            SosyalAg[3, 1] = 0; SosyalAg[3, 4] = 0; SosyalAg[4, 0] = 0; SosyalAg[4, 3] = 0; SosyalAg[5, 1] = 0; SosyalAg[5, 0] = 0;
            //olivia john jack celine chloe winston
            //olivia    0     1    1     1      0      0
            //john      1     0    1     0      1      0
            //jack      1     1    0     1      1      1
            //celine    1     0    1     0      0      1
            //chloe     0     1    1     0      0      1
            //winston   0     0    1     1      1      0



            //olivia --> 1
            //john --> 2
            //chloe --> 3
            //jack --> 4
            //celine --> 5
            //winston --> 6

            // john      olivia    12   --> 2    1   12
            // john      jack      7    --> 2    4   7
            // john      chloe     9    --> 2    3   9
            // olivia    celine    5    --> 1    5   5
            // olivia    jack      8    --> 1    4   8
            // jack      chloe     4    --> 4    3   4
            // jack      winston   16   --> 4    6   16
            // jack      celine    6    --> 4    5   6
            // chloe     winston   15   --> 3    6   15
            // celine    winston   10   --> 5    6   10

            int tempUzunluk = 0;
            int tempKime = 0;
            int tempKimden = 0;
            for (int i = 0; i < uzunluk.Length; i++)
            {
                for (int j = 0; j < uzunluk.Length - 1; j++)
                {
                    if (uzunluk[j] > uzunluk[j + 1])
                    {
                        tempUzunluk = uzunluk[j];
                        uzunluk[j] = uzunluk[j + 1];
                        uzunluk[j + 1] = tempUzunluk;

                        tempKimden = kimden[j];
                        kimden[j] = kimden[j + 1];
                        kimden[j + 1] = tempKimden;

                        tempKime = kime[j];
                        kime[j] = kime[j + 1];
                        kime[j + 1] = tempKime;
                    }
                }
            }

        }


        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                int j = 0;
                for (j = j + i; j < 6; j++)
                {
                    if (SosyalAg[i, j] != 0)
                    {
                        MessageBox.Show(Convert.ToString(kisiler[i] + "-->" + kisiler[j] + " " + ":" + SosyalAg[i, j]));
                        sayac += SosyalAg[i, j];

                    }
                }
            }
        }

        private void btnGenislik_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                int j = 0;
                for (j = j + i; j < 6; j++)
                {
                    if (SosyalAg[i, j] != 0)
                    {
                        MessageBox.Show(Convert.ToString(kisiler[i] + "-->" + kisiler[j] + SosyalAg[i, j]));
                    }
                }
            }
        }

        private void btnGenislik_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                int j = 0;
                for (j = j + i; j < 6; j++)
                {
                    if (SosyalAg[i, j] != 0)
                    {
                        MessageBox.Show(Convert.ToString(kisiler[i] + "-->" + kisiler[j] + SosyalAg[i, j]));
                    }
                }
            }
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            int a = 0;
            bool durum = true;
            primlist[0] = kisiler[0];
            for (int i = 0; i < 6; i++)
            {
                int j = 0;
                for (j = j + i; j < 6; j++)
                {
                    if (SosyalAg[i, j] != 0)
                    {
                        sayac = SosyalAg[i, j];

                        for (int k = 0; k < 6; k++)
                        {
                            if (j == q[k])
                            {
                                durum = false;
                            }
                        }

                        if (durum)
                        {
                            if (sayac > tempsayac)
                            {
                                sayac = tempsayac;
                            }
                            else
                            {
                                tempsayac = sayac;
                                q[a] = i;
                            }
                            primlist[i + 1] = kisiler[j];
                        }

                    }
                }
                a++;
            }
            MessageBox.Show(Convert.ToString(primlist[0] + primlist[1] + primlist[2] + primlist[3] + primlist[4] + primlist[5]));

        }

        private void btnKruksal_Click(object sender, EventArgs e)
        {
            int toplamMaliyet = 0;
            for (int j = 0; j < uzunluk.Length; j++)
            {
                if (dolasilan[kime[j]] == 0 || dolasilan[kimden[j]] == 0)
                {
                    MessageBox.Show("Kod Adı-->" + kimden[j] + "  Kod Adı-->" + kime[j] + "  Uzunluk-->" + uzunluk[j]);
                    toplamMaliyet += uzunluk[j];
                    dolasilan[kime[j]] = 1;
                    dolasilan[kimden[j]] = 1;
                }
            }
        }

        private void btnEdmonds_Click(object sender, EventArgs e)
        {
            if (cmbKime.Text == cmbKimden.Text)
                MessageBox.Show("Farklı rota seçiniz.");

            else
            {

            }
        }

        private void btnFordFulkerson_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < uzunluk.Length; i++)
            {
                MessageBox.Show("Kod Adı-->" + kimden[i] + Environment.NewLine + "Kod Adı-->" + kime[i] + Environment.NewLine + "Uzunluk-->" + uzunluk[i] + Environment.NewLine);
            }
        }

        private void btnDijkstra_Click_1(object sender, EventArgs e)
        {
            EnKisayaYolGiris frm = new EnKisayaYolGiris();
            frm.ShowDialog();
        }
    }
}
