using Timer = System.Windows.Forms.Timer;

namespace Activity03
{
    public partial class Form1 : Form
    {
        String Path = @"E:\\Computer Science\\Extra Semster\\VP\\Lab\\Lab04\\Vp_pics\\";
        string[] myar = new string[] { "1.jpg", "2.jpg", "3jpg", "4.jpg" };
        int i = 0;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.pictureBox1.ImageLocation = Path + myar[i];
            i++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == myar.Length) {
                i = 0;
                this.pictureBox1.ImageLocation = Path + myar[i];
            }
            else
            {
                this.pictureBox1.ImageLocation = Path + myar[i];
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i ==0)
            {
                i = myar.Length;
                this.pictureBox1.ImageLocation = Path + myar[i];
                i--;
            }
            else
            {
                this.pictureBox1.ImageLocation = Path + myar[i];
                i--;
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            timer.Interval = 1000;
            timer.Start();
            int length=myar.Length;

            while (length >= 0)
            {
                if (i == 0)
                {
                    i = myar.Length-1;
                    this.pictureBox1.ImageLocation = Path + myar[i];
                    i--;
                }
                else
                {
                    this.pictureBox1.ImageLocation = Path + myar[i];
                    i--;
                }

            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}