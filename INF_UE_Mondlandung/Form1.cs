namespace INF_UE_Mondlandung
{
    public partial class Form1 : Form
    {
        private int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tiTimer1.Start();
        }

        private void tiTimer1_Tick(object sender, EventArgs e)
        {
            y += 8;


            //Image nach unten Bewegen
            if (pbRocket.Location.Y < 900)
                pbRocket.Location = new Point(pbRocket.Location.X, pbRocket.Location.Y + y);
            else
            {
                lblResult.Text = "" + y;

                tiTimer1.Stop();
            }

        }

        private void btBreak10_Click(object sender, EventArgs e)
        {
            y -= 10;
        }

        private void btBreak30_Click(object sender, EventArgs e)
        {
            y -= 30;
        }

        private void btBreak90_Click(object sender, EventArgs e)
        {
            y -= 90;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            pbRocket.Location = new Point(504,12);
            y = 0;
            lblResult.Text = ""; 
        }
    }
}
