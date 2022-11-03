using System.Media;

namespace SchlagDenTom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int number = 1+Int32.Parse(label2.Text.Replace("Du hast Tom schon ", "").Replace(" mal geschlagen.",""));
            label2.Text = "Du hast Tom schon "+number+" mal geschlagen.";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.Stream = Properties.Resources.gulp;
            player.Play();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}