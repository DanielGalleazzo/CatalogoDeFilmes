namespace CatalogoDeFilmesWF
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
            txtNomeDoFilme = new TextBox();
            button1 = new Button();
            lblNomeFilme = new Label();
            lblSinopse = new Label();
            lblNota = new Label();
            lblData = new Label();
            lblAdulto = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeDoFilme
            // 
            txtNomeDoFilme.Location = new Point(290, 12);
            txtNomeDoFilme.Name = "txtNomeDoFilme";
            txtNomeDoFilme.Size = new Size(167, 23);
            txtNomeDoFilme.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(290, 52);
            button1.Name = "button1";
            button1.Size = new Size(167, 105);
            button1.TabIndex = 1;
            button1.Text = "Ver informações";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNomeFilme
            // 
            lblNomeFilme.AutoSize = true;
            lblNomeFilme.Location = new Point(34, 52);
            lblNomeFilme.Name = "lblNomeFilme";
            lblNomeFilme.Size = new Size(90, 15);
            lblNomeFilme.TabIndex = 2;
            lblNomeFilme.Text = "Nome do filme:";
            // 
            // lblSinopse
            // 
            lblSinopse.AutoSize = true;
            lblSinopse.Location = new Point(34, 235);
            lblSinopse.Name = "lblSinopse";
            lblSinopse.Size = new Size(48, 15);
            lblSinopse.TabIndex = 3;
            lblSinopse.Text = "Sinopse";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(34, 142);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(0, 15);
            lblNota.TabIndex = 4;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(34, 97);
            lblData.Name = "lblData";
            lblData.Size = new Size(113, 15);
            lblData.TabIndex = 5;
            lblData.Text = "Data de lançamento";
            // 
            // lblAdulto
            // 
            lblAdulto.AutoSize = true;
            lblAdulto.Location = new Point(34, 180);
            lblAdulto.Name = "lblAdulto";
            lblAdulto.Size = new Size(0, 15);
            lblAdulto.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(221, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 204);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 399);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 8;
            label1.Text = "Link da imagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAdulto);
            Controls.Add(lblData);
            Controls.Add(lblNota);
            Controls.Add(lblSinopse);
            Controls.Add(lblNomeFilme);
            Controls.Add(button1);
            Controls.Add(txtNomeDoFilme);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeDoFilme;
        private Button button1;
        private Label lblNomeFilme;
        private Label lblSinopse;
        private Label lblNota;
        private Label lblData;
        private Label lblAdulto;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
