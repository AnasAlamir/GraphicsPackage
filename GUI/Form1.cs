namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            int centerX = panel1.ClientRectangle.Right / 2;
            int centerY = panel1.ClientRectangle.Height / 2;
            Point center = new Point(centerX, centerY);
            Graphics g = panel1.CreateGraphics();
            try
            {
                int x0 = Convert.ToInt32(textBox1.Text);
                int y0 = Convert.ToInt32(textBox2.Text);
                int x1 = Convert.ToInt32(textBox3.Text);
                int y1 = Convert.ToInt32(textBox4.Text);
                Point p0 = new Point(x0, y0);
                Point p1 = new Point(x1, y1);
                DDA.DrawLine(g, p0, p1, center);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values for coordinates.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The entered values are too large.");
            }
            finally
            {
                g.Dispose();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int centerX = panel1.ClientRectangle.Right / 2;
            int centerY = panel1.ClientRectangle.Height / 2;

            // Draw X-axis
            DDA.DrawLineAxis(g, new Point(0, centerY), new Point(panel1.ClientSize.Width, centerY));

            // Draw Y-axis
            DDA.DrawLineAxis(g, new Point(centerX, 0), new Point(centerX, panel1.ClientSize.Height));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Refresh();
            int centerX = panel1.ClientRectangle.Right / 2;
            int centerY = panel1.ClientRectangle.Height / 2;
            Point center = new Point(centerX, centerY);
            Graphics g = panel1.CreateGraphics();
            try
            {
                int x0 = Convert.ToInt32(textBox1.Text);
                int y0 = Convert.ToInt32(textBox2.Text);
                int x1 = Convert.ToInt32(textBox3.Text);
                int y1 = Convert.ToInt32(textBox4.Text);
                Point p0 = new Point(x0, y0);
                Point p1 = new Point(x1, y1);
                Bresenham.DrawLine(g, p0, p1, center);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values for coordinates.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The entered values are too large.");
            }
            finally
            {
                g.Dispose();
            }
        }
    }

}
