namespace Vezba3._1a
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBoxColor = new PictureBox();
            colorDialog1 = new ColorDialog();
            groupBox2 = new GroupBox();
            radioButtonElipsa = new RadioButton();
            radioButtonPravougaonik = new RadioButton();
            radioButtonLinija = new RadioButton();
            groupBox3 = new GroupBox();
            listBoxDebljina = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColor).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(137, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 318);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxColor);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(112, 40);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boja";
            // 
            // pictureBoxColor
            // 
            pictureBoxColor.BackColor = Color.Black;
            pictureBoxColor.Location = new Point(37, 13);
            pictureBoxColor.Name = "pictureBoxColor";
            pictureBoxColor.Size = new Size(69, 21);
            pictureBoxColor.TabIndex = 0;
            pictureBoxColor.TabStop = false;
            pictureBoxColor.Click += pictureBoxColor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonElipsa);
            groupBox2.Controls.Add(radioButtonPravougaonik);
            groupBox2.Controls.Add(radioButtonLinija);
            groupBox2.Location = new Point(13, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(111, 109);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oblik";
            // 
            // radioButtonElipsa
            // 
            radioButtonElipsa.AutoSize = true;
            radioButtonElipsa.Location = new Point(12, 76);
            radioButtonElipsa.Name = "radioButtonElipsa";
            radioButtonElipsa.Size = new Size(55, 19);
            radioButtonElipsa.TabIndex = 2;
            radioButtonElipsa.Text = "Elipsa";
            radioButtonElipsa.UseVisualStyleBackColor = true;
            // 
            // radioButtonPravougaonik
            // 
            radioButtonPravougaonik.AutoSize = true;
            radioButtonPravougaonik.Location = new Point(11, 51);
            radioButtonPravougaonik.Name = "radioButtonPravougaonik";
            radioButtonPravougaonik.Size = new Size(98, 19);
            radioButtonPravougaonik.TabIndex = 1;
            radioButtonPravougaonik.Text = "Pravougaonik";
            radioButtonPravougaonik.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinija
            // 
            radioButtonLinija.AutoSize = true;
            radioButtonLinija.Checked = true;
            radioButtonLinija.Location = new Point(12, 26);
            radioButtonLinija.Name = "radioButtonLinija";
            radioButtonLinija.Size = new Size(53, 19);
            radioButtonLinija.TabIndex = 0;
            radioButtonLinija.TabStop = true;
            radioButtonLinija.Text = "Linija";
            radioButtonLinija.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxDebljina);
            groupBox3.Location = new Point(14, 170);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(108, 150);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Debljina";
            // 
            // listBoxDebljina
            // 
            listBoxDebljina.FormattingEnabled = true;
            listBoxDebljina.ItemHeight = 15;
            listBoxDebljina.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            listBoxDebljina.Location = new Point(12, 18);
            listBoxDebljina.Name = "listBoxDebljina";
            listBoxDebljina.Size = new Size(90, 109);
            listBoxDebljina.TabIndex = 0;
            listBoxDebljina.SelectedIndexChanged += listBoxDebljina_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 320);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxColor).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBoxColor;
        private ColorDialog colorDialog1;
        private GroupBox groupBox2;
        private RadioButton radioButtonElipsa;
        private RadioButton radioButtonPravougaonik;
        private RadioButton radioButtonLinija;
        private GroupBox groupBox3;
        private ListBox listBoxDebljina;
    }
}