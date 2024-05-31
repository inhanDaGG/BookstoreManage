namespace BookstoreManage
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }
        int Startops = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Startops += 1;
            Myprogress.Value = Startops;
            PercentageLbl.Text = Startops + " %";
            if (Myprogress.Value == 100)
            { 
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
    }
}
