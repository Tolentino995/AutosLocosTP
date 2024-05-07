namespace VersionDelAuto0._2
{
    public partial class Form1 : Form
    {

        bool uLeft, uRight;

        int speed = 8;
        int puntos = 0;
        int vidas = 0;

        Random ranX = new Random();
        Random ranY = new Random();

        PictureBox Moneda = new PictureBox();
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {

            lblVidas.Text = "Vidas: " + vidas;
            lblPuntos.Text = "Puntos: " + puntos;

            if (uLeft == true && Jugador.Left > 0)
            {
                Jugador.Left -= 1;
            }
            if (uRight == true && Jugador.Left + Jugador.Width < this.ClientSize.Width)
            {
                Jugador.Left += 1;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstaculos")
                {
                    x.Top += speed;
                }

                if (x.Top + x.Height > this.ClientSize.Height)
                {
                    x.Top = ranY.Next(80, 300) * -1;
                    x.Left = ranX.Next(5, this.ClientSize.Width - x.Width);
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
            { 
                uLeft = true;
            }
            if (e.KeyCode == Keys.Right) 
            {
                uRight = true;
            }
        }

        private void KeysIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                uLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                uRight = false;
            }
        }

        private void RestartGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstaculos")
                {
                    x.Top = ranY.Next(80, 300) * -1;
                    x.Left = ranX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            Jugador.Left = this.ClientSize.Width / 2;
            Jugador.Image = Properties.Resources.Auto_de_usuari;

            puntos = 0;
            vidas = 3;
            speed = 8;

            uLeft = false;
            uRight = false;

            GameTimer.Start();

        }
    }
}
