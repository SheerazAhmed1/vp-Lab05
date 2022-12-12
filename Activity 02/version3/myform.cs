using System;
using System.Windows.Forms;
namespace MyNameSpace
{
    public class myForm : Form
    {
        private Button btnLoad;
        private PictureBox pboxPhoto;
        public myForm()
        {
            this.Text = "My Form";

            btnLoad = new Button();
            btnLoad.Text = "&Load";
            btnLoad.Width = this.Width / 2;
            btnHeight = 20;
            btnLoad.Left = (this.Width - btnLoad.Width) / 2;
            btnLoad.Top = 50;
            btnLoad.UseMnemonic = true;
            btnLoad.Click += new System.EventHandler(this.onLoadClick);

            pboxPhoto = new PictureBox();
            pboxPhoto.BorderStyle = BorderStyle.Fixed3D;
            pboxPhoto.Width = this.Width / 2;
            pboxPhoto.Height = this.Height / 2;
            pboxPhoto.Left = (this.Width - pboxPhoto.Width) / 2;
            pboxPhoto.Top = (this.Height - pboxPhoto.Height) / 2;

            this.Controls.Add(btnLoad);
            this.Controls.Add(pboxPhoto);

        }

        public void OnLoadClick(object sender,System.EventArgs e)
        {
            this.pboxPhoto.ImageLocation = @"D:\vp-pics\1.jpg";
        }

        public static void Main(string[] args)
        {
            Application.Run(new myForm());
        }

    }





}