namespace TestHilos
{
    partial class FormHilos
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
            btnAlfajores = new Button();
            pictureBox1 = new PictureBox();
            lblDatos = new Label();
            lblPrecio = new Label();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAlfajores
            // 
            btnAlfajores.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlfajores.Location = new Point(25, 48);
            btnAlfajores.Name = "btnAlfajores";
            btnAlfajores.Size = new Size(148, 75);
            btnAlfajores.TabIndex = 0;
            btnAlfajores.Text = "Ver alfajores";
            btnAlfajores.UseVisualStyleBackColor = true;
            btnAlfajores.Click += btnAlfajores_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(205, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.Location = new Point(264, 350);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(0, 23);
            lblDatos.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(266, 391);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 19);
            lblPrecio.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(25, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(148, 75);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(btnCancelar);
            Controls.Add(lblPrecio);
            Controls.Add(lblDatos);
            Controls.Add(pictureBox1);
            Controls.Add(btnAlfajores);
            Name = "FormPrincipal";
            Text = "Alfajores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlfajores;
        private PictureBox pictureBox1;
        private Label lblDatos;
        private Label lblPrecio;
        private Button btnCancelar;
    }
}