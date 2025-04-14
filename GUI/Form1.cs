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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            int centerX = panel1.ClientRectangle.Right / 2;
            int centerY = panel1.ClientRectangle.Height / 2;
            Point centerOfPanal = new Point(centerX, centerY);
            Graphics g = panel1.CreateGraphics();
            try
            {
                int radius = Convert.ToInt32(textBox7.Text);
                int xCenter = Convert.ToInt32(textBox5.Text);
                int yCenter = Convert.ToInt32(textBox6.Text);
                Point center = new Point(xCenter, yCenter);
                Circle circle = new Circle();
                circle.DrawCircle(g, radius, center, centerOfPanal);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            int centerX = panel1.ClientRectangle.Right / 2;
            int centerY = panel1.ClientRectangle.Height / 2;
            Point centerOfPanal = new Point(centerX, centerY);
            Graphics g = panel1.CreateGraphics();
            try
            {
                int r1 = Convert.ToInt32(textBox8.Text);
                int r2 = Convert.ToInt32(textBox11.Text);
                int xCenter = Convert.ToInt32(textBox9.Text);
                int yCenter = Convert.ToInt32(textBox10.Text);
                Point center = new Point(xCenter, yCenter);
                Elipse elipse = new Elipse();
                elipse.DrawElipse(g, center, r1, r2, centerOfPanal);
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
