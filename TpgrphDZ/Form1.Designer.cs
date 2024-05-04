namespace TpgrphDZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBoxInput = new RichTextBox();
            buttonRun = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonCopy = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Location = new Point(0, 128);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(400, 188);
            richTextBoxInput.TabIndex = 0;
            richTextBoxInput.Text = "";
            richTextBoxInput.TextChanged += richTextBoxInput_TextChanged;
            // 
            // buttonRun
            // 
            buttonRun.BackColor = Color.DarkGray;
            buttonRun.Location = new Point(0, 332);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(98, 28);
            buttonRun.TabIndex = 1;
            buttonRun.Text = "Редактировать";
            buttonRun.UseVisualStyleBackColor = false;
            buttonRun.Click += buttonRun_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 395);
            label1.Name = "label1";
            label1.Size = new Size(400, 215);
            label1.TabIndex = 2;
            label1.Text = "...";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(0, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 26);
            textBox1.TabIndex = 3;
            textBox1.Text = "Введите исходный текст ";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(557, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 22);
            textBox2.TabIndex = 4;
            textBox2.Text = "Что изменится? ";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(506, 164);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 254);
            textBox3.TabIndex = 5;
            textBox3.Text = resources.GetString("textBox3.Text");
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(300, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 32);
            textBox4.TabIndex = 6;
            textBox4.Text = "ПРИВЕТ!";
            // 
            // buttonCopy
            // 
            buttonCopy.BackColor = Color.DarkGray;
            buttonCopy.Location = new Point(0, 631);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(98, 28);
            buttonCopy.TabIndex = 7;
            buttonCopy.Text = "Копировать";
            buttonCopy.UseVisualStyleBackColor = false;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Location = new Point(97, 662);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(541, 496);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 351);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(167, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(368, 409);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 756);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(buttonCopy);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonRun);
            Controls.Add(richTextBoxInput);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox richTextBoxInput;
        private Button buttonRun;
        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonCopy;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
