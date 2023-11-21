namespace Vezba3._1a
{
    public partial class Form1 : Form
    {
        int px, py;
        Graphics gr;
        Pen olovka;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() ==
                DialogResult.OK)
            {
                pictureBoxColor.BackColor =
                    colorDialog1.Color;
                olovka.Color = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            olovka = new Pen(Color.Black, 1);
            listBoxDebljina.SelectedIndex = 0;
        }

        /// <summary>
        /// Draws a line, rectangle or ellipse based on the selected radio button and color.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The MouseEventArgs instance containing the event data.</param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonLinija.Checked)
                    gr.DrawLine(olovka,
                        px, py, e.X, e.Y);
                if (radioButtonPravougaonik.Checked)
                    gr.DrawRectangle(olovka,
                        Math.Min(px, e.X), Math.Min(py, e.Y),
                        Math.Abs(e.X - px), Math.Abs(e.Y - py));
                if (radioButtonElipsa.Checked)
                    gr.DrawEllipse(olovka,
                       Math.Min(px, e.X), Math.Min(py, e.Y),
                        Math.Abs(e.X - px), Math.Abs(e.Y - py));
            }

        }

        /// <summary>
        /// Handles the MouseDown event of the pictureBox1 control.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The MouseEventArgs instance containing the event data.</param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                px = e.X;
                py = e.Y;
            }
        }

        private void listBoxDebljina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxDebljina.SelectedIndex >= 0)
                olovka.Width = 
                    Convert.ToInt32(listBoxDebljina.SelectedItem);
        }
    }
}