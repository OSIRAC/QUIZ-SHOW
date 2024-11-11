using System;

namespace bilgi_yarışması_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        private void btns_Click(object sender, EventArgs e)
        {

            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btns.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lbls.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Çok kalabalık ve hareketli olan bir yer deyime göre hangisi gibi kaynıyordur?";
                btna.Text = "Köpek kulübesi";
                btnb.Text = "Hamster kafesi";
                btnc.Text = "Karınca yuvası";
                btnd.Text = "Kaplumbağa akvaryumu";
                label4.Text = "Karınca yuvası";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangisi şakalaşan çocukların \"Sana ne!\" diyen birine verdikleri bir cevaptır?";
                btna.Text = "Süt iç";
                btnb.Text = "Mısır patlat";
                btnc.Text = "Saman ye";
                btnd.Text = "Çay demle";
                label4.Text = "Saman ye";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Hangisi Tüm Tarihin En iyi Filmidir?";
                btna.Text = "Barbie";
                btnb.Text = "Oppenheimer";
                btnc.Text = "İnception";
                btnd.Text = "Dövüs klübü";
                label4.Text = "İnception";
                btns.Text = "SONUÇLAR";
            }
            if (soruno == 4)
            {

                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btns.Enabled = false;
                MessageBox.Show("Dogru:" + dogru + "\n" + "Yanlıs:" + yanlıs);

            }



        }

        private void btna_Click(object sender, EventArgs e)
        {

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }



        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }



        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }



        }

        private void btnd_Click(object sender, EventArgs e)
        {

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btns.Enabled = true;

            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlıs++;
                lbly.Text = yanlıs.ToString();
                pictureBox2.Visible = true;


            }

        }


    }
}