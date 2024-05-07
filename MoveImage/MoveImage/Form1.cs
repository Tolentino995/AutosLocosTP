namespace MoveImage
{
    public partial class Form1 : Form
    { 
        Image autoc;
        bool cLeft, cRight, cTop, cBottom;
        int speed = 20;
        int possitionX = 90;
        int possitionY = 100;
        int height = 50;
        int width = 50;


        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile("PistaDeCarrera0.1.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            autoc = Image.FromFile("Caratula Logo C#.png");
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            if (cLeft && possitionX > 0) 
            {
                possitionX -= speed;
            }
            if (cRight && possitionX + width < this.ClientSize.Width)
            {
                possitionX += speed;
            }
            if (cTop && possitionY > 0)
            {
                possitionY -= speed;
            }
            if (cBottom && possitionY + height < this.ClientSize.Height)
            {
                possitionY += speed;
            }

            this.Invalidate();

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                cLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                cRight = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                cTop = true;
            }
            else if(e.KeyCode == Keys.Down)
            {
                cBottom = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                cLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                cRight = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                cTop = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                cBottom = false;
            }
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            Canvas.DrawImage(autoc, possitionX, possitionY, width, height);

        }

    }
}
