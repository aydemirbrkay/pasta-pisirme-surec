namespace pisirme_surec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Ýlk progressBar 100 olana kadar artýr
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else if (progressBar1.Value == 100 && progressBar2.Value < 100)
            {
                this.BackgroundImage = Properties.Resources.image2; 
                progressBar2.Value += 5;
            }
            else if (progressBar2.Value == 100 && progressBar3.Value < 100)
            {
                progressBar3.Value += 20;
            }
            else if (progressBar3.Value == 100 && progressBar4.Value < 100)
            {
                this.BackgroundImage = Properties.Resources.image3;
                progressBar4.Value += 1;
            }

            // Tüm progressBar'lar dolduðunda timer'ý durdur
            if (progressBar1.Value == 100 && progressBar2.Value == 100 && progressBar3.Value == 100 && progressBar4.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Pastaniz Pisti");
            }
        }
    }
}
