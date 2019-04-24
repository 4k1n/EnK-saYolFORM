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
    public partial class Bul : Form
    {
        public Bul()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            


            int sonsuz = EnKisayaYolGiris.mesafetoplami+1;
            int N = EnKisayaYolGiris.dugumsayisi;
            int[,] D = new int[N, N];
            int[,] S = new int[N, N];

            int cek = 0;
            int K = 0;


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    if (i == j)
                    {
                        D[i, j] = 0;
                    }
                    else if (i > j)
                    {
                        D[i, j] = D[j, i];
                    }
                    else
                    {
                        string deger = EnKisayaYolGiris.mesafeler[cek];

                        if (deger == String.Empty || deger == "-")
                        {
                            D[i, j] = sonsuz;
                        }
                        else
                        {
                            D[i, j] = Convert.ToInt32(deger);
                        }
                        cek++;
                    }
                }
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        S[i, j] = 0;
                    }
                    else
                    {
                        S[i, j] = j + 1;
                    }
                }
            }


            while (K <= (N - 1))
            {
                for (int i = 0; i < N; i++)
                {
                    if (K == i)
                    {
                        continue;
                    }

                    for (int j = 0; j < N; j++)
                    {
                        if (K == j)
                        {
                            continue;
                        }

                        int hucre = D[i, j];
                        int karsilastirilanDeger = D[i, K] + D[K, j];

                        if (karsilastirilanDeger < hucre)
                        {
                            D[i, j] = karsilastirilanDeger;
                            S[i, j] = K + 1;
                        }
                    }
                }
                K++;
            }

                int baslangicDogumu;
                int varisDugumu;
                bool rotaKontrol = true;

                List<int> hedefYol = new List<int>();

              
                baslangicDogumu = Convert.ToInt32(textBox1.Text);

                varisDugumu = Convert.ToInt32(textBox2.Text);

                hedefYol.Add(baslangicDogumu);
                hedefYol.Add(varisDugumu);

                if (baslangicDogumu != varisDugumu)
                {
                    while (rotaKontrol)
                    {
                        int listeBoyu = hedefYol.Count();

                        for (int i = 0; i < listeBoyu - 1; i++)
                        {
                            int x = (hedefYol[i] - 1);
                            int y = (hedefYol[i + 1] - 1);
                            int deger = S[x, y];

                            if (deger != hedefYol[i + 1])
                            {
                                hedefYol.Insert(i + 1, deger);
                                break;
                            }
                            else if (i == (listeBoyu - 2) && deger == hedefYol[i + 1])
                            {
                                rotaKontrol = false;
                                break;
                            }
                        }
                    }
                }

                sonucgosterim(true);
                this.Size = new Size(351,201);

            label3.Text = baslangicDogumu + ". düğümden " + varisDugumu + ". düğüme en kısa yol";
            label4.Text="İzlediği Yol = " + string.Join("->", hedefYol.ToArray());
            label5.Text = "Mesafe = "+D[baslangicDogumu - 1, varisDugumu - 1].ToString();


        }
        void sonucgosterim(bool gosterim)
        {
            label3.Visible = label4.Visible = label5.Visible = gosterim;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(351,126);
            sonucgosterim(false);

        }
    }
}
