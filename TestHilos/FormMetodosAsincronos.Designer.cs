namespace TestHilos
{
    partial class FormMetodosAsincronos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            btnSincronico = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(173, 297);
            button1.Name = "button1";
            button1.Size = new Size(202, 72);
            button1.TabIndex = 0;
            button1.Text = "Traer alfajores asincrónico";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAsincronico_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(173, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(422, 229);
            listBox1.TabIndex = 1;
            // 
            // btnSincronico
            // 
            btnSincronico.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSincronico.Location = new Point(403, 297);
            btnSincronico.Name = "btnSincronico";
            btnSincronico.Size = new Size(192, 72);
            btnSincronico.TabIndex = 2;
            btnSincronico.Text = "Traer alfajores sincrónico";
            btnSincronico.UseVisualStyleBackColor = true;
            btnSincronico.Click += btnSincronico_Click;
            // 
            // FormMetodosAsincronos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSincronico);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "FormMetodosAsincronos";
            Text = "Sincronico y asincronico";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button btnSincronico;
    }
}