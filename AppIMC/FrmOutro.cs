using AppIMC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace AppIMC
{
    public partial class FrmOutro : Form
    {
        public FrmOutro()
        {
            InitializeComponent();
        }

        private void FrmOutro_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\ra2557038\Downloads\vlc-record-2020-04-05-08h19m15s-parry-gripp-boonebum-.wav");
            simpleSound.Play();
        }

        private void FrmOutro_Resize(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutro));
            Random r = new Random();
            PictureBox[] tacos = new PictureBox[100];
            for (int i = 0; i < tacos.Length; i++)
            {
                tacos[i] = new PictureBox();
                tacos[i].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                tacos[i].Image = (Image)resources.GetObject("tacos[i].Image");
                tacos[i].Location = new Point(r.Next(0, this.Size.Width), r.Next(0, this.Size.Height));
                tacos[i].Name = "tacos[i]";
                tacos[i].Size = new Size(500, 100);
                tacos[i].TabIndex = 0;
                tacos[i].TabStop = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
