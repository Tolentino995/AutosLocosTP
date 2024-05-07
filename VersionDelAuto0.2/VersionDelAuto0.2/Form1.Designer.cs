namespace VersionDelAuto0._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Jugador = new PictureBox();
            lblPuntos = new Label();
            lblVidas = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Jugador).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Autos_encontra_del_usuaruio;
            pictureBox1.Location = new Point(242, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Obstaculos";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.Image = Properties.Resources.Piedra_;
            pictureBox2.Location = new Point(125, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "Obstaculos";
            // 
            // Jugador
            // 
            Jugador.BackColor = Color.Transparent;
            Jugador.Image = Properties.Resources.Auto_de_usuari;
            Jugador.Location = new Point(177, 377);
            Jugador.Name = "Jugador";
            Jugador.Size = new Size(85, 102);
            Jugador.SizeMode = PictureBoxSizeMode.StretchImage;
            Jugador.TabIndex = 2;
            Jugador.TabStop = false;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(395, 9);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(83, 21);
            lblPuntos.TabIndex = 3;
            lblPuntos.Text = "Puntos: 0";
            // 
            // lblVidas
            // 
            lblVidas.AutoSize = true;
            lblVidas.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidas.Location = new Point(395, 50);
            lblVidas.Name = "lblVidas";
            lblVidas.Size = new Size(72, 21);
            lblVidas.TabIndex = 4;
            lblVidas.Text = "Vidas: 3";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainGameTimer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PistaDeCarrera0_1;
            ClientSize = new Size(490, 511);
            Controls.Add(lblVidas);
            Controls.Add(lblPuntos);
            Controls.Add(Jugador);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeysIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Jugador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox Jugador;
        private Label lblPuntos;
        private Label lblVidas;
        private System.Windows.Forms.Timer GameTimer;
    }
}
