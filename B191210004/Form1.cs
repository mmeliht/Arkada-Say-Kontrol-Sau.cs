/*************************************************************************************************************************
 **
 **                                             	SAKARYA ÜNİVERSİTESİ
 **                                        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
 **	                                             2019-2020 BAHAR DÖNEMİ
 **    
 **
 **
 **
 **                                            ÖDEV NUMARASI..........: 2
 **                                            ÖĞRENCİ ADI............: Mustafa Melih TÜFEKCİOĞLU
 **                                            ÖĞRENCİ NUMARASI.......: B191210004
 **                                            DERSİN ALINDIĞI GRUP...: 1.Öğretim B grubu
 **
 **
 **
 ***************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210004
{
    public partial class Form1 : Form
    {
        private Button btnArkadas;
        private Button btnSon;

        private Label lblX;               //sayi girişiolacak yerdeki x.
        private Label lblY;               //sayi girişi olacak yerdeki y.
        private Label lblX2;              //islemin üstüdeki x.
        private Label lblY2;              //islemin üstündeki y.
        private Label lblToplam;

        private TextBox txtSayiX;
        private TextBox txtSayiY;
        private TextBox txtXtop;
        private TextBox txtYtop;

        private ListBox lstX;
        private ListBox lstY;

        private int sayiX;
        private int sayiY;
        private int Xbolum = 0;
        private int Ybolum = 0;

        public Form1()
        {
            Height = 300;
            Width = 400;
            Text = "Arkadas Sayilar";


            lblX = new Label();
            lblX.Text = "X";
            Controls.Add(lblX);
            lblX.SetBounds(0, 10, 20, 20);

            lblY = new Label();
            lblY.Text = "Y";
            Controls.Add(lblY);
            lblY.SetBounds(0, 40, 20, 20);


            txtSayiX = new TextBox();
            Controls.Add(txtSayiX);
            txtSayiX.SetBounds(30, 10, 100, 0);

            txtSayiY = new TextBox();
            Controls.Add(txtSayiY);
            txtSayiY.SetBounds(30, 40, 100, 0);


            btnArkadas = new Button();
            btnArkadas.Text = "Arkadaş mı?";
            Controls.Add(btnArkadas);
            btnArkadas.SetBounds(30, 100, 100, 50);
            btnArkadas.MouseClick += BtnArkadas_MouseClick;

            btnSon = new Button();
            btnSon.Text = "Son";
            Controls.Add(btnSon);
            btnSon.SetBounds(150, 100, 100, 50);
            btnSon.MouseClick += BtnSon_MouseClick;
        }

        private void BtnArkadas_MouseClick(object sender, MouseEventArgs e)
        {
            this.Height = 400;
            this.Width = 700;


            lblX2 = new Label();
            lblX2.Text = "X";
            Controls.Add(lblX2);
            lblX2.SetBounds(450, 0, 20, 20);

            lblY2 = new Label();
            lblY2.Text = "Y";
            Controls.Add(lblY2);
            lblY2.SetBounds(600, 0, 20, 20);

            lblToplam = new Label();
            lblToplam.Text = "TOPLAMLAR";
            Controls.Add(lblToplam);
            lblToplam.SetBounds(300, 225, 100, 100);


            lstX = new ListBox();
            Controls.Add(lstX);
            lstX.SetBounds(410, 30, 100, 200);

            lstY = new ListBox();
            Controls.Add(lstY);
            lstY.SetBounds(560, 30, 100, 200);


            txtXtop = new TextBox();
            Controls.Add(txtXtop);
            txtXtop.SetBounds(410, 220, 100, 50);

            txtYtop = new TextBox();
            Controls.Add(txtYtop);
            txtYtop.SetBounds(560, 220, 100, 50);

            Islemler();
        }
        private void Islemler()
        {
            sayiX = Convert.ToInt32(txtSayiX.Text);
            sayiY = Convert.ToInt32(txtSayiY.Text);

            for (int i = 1; i < sayiX; i++)
            {
                //1'den girilen sayıya kadar olan sayıları, girilen sayıya bölüyo ve eğer kalan sıfırsa listbox'a yazıyo.
                if (sayiX % i == 0)
                {
                    lstX.Items.Add(i.ToString());
                    Xbolum += i;
                }
            }

            for (int i = 1; i < sayiY; i++)
            {
                if (sayiY % i == 0)
                {
                    lstY.Items.Add(i.ToString());
                    Ybolum += i;
                }
            }
            txtXtop.Text = Xbolum.ToString();
            txtYtop.Text = Ybolum.ToString();
        }
        private void BtnSon_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }

}

