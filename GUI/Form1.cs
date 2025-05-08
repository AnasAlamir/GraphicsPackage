namespace GUI
{
    public partial class Form1 : Form

    {
        List<PointF> originalShape = new List<PointF>();
        List<PointF> transformedShape = new List<PointF>();

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

            // Draw axes
            DDA.DrawLineAxis(g, new Point(0, centerY), new Point(panel1.ClientSize.Width, centerY));
            DDA.DrawLineAxis(g, new Point(centerX, 0), new Point(centerX, panel1.ClientSize.Height));

            // Draw the transformed shape if available
            if (transformedShape.Count == 4)
            {
                Pen pen = Pens.Black;
                for (int i = 0; i < 4; i++)
                {
                    PointF start = transformedShape[i];
                    PointF end = transformedShape[(i + 1) % 4];
                    Point s = new Point((int)(centerX + start.X), (int)(centerY - start.Y));
                    Point eP = new Point((int)(centerX + end.X), (int)(centerY - end.Y));
                    g.DrawLine(pen, s, eP);
                }
            }
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
                Ellipse elipse = new Ellipse();
                elipse.DrawEllipse(g, center, r1, r2, centerOfPanal);
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
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                float shx = float.Parse(textBox23.Text.Trim()); // X shear input
                transformedShape = Transform2D.ShearX(transformedShape, shx);
                panel1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Enter a valid shear X value.");
            }
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            originalShape.Clear();
            transformedShape.Clear();

            try
            {
                // Read all 8 values with clear parsing
                float x1 = float.Parse(textBox12.Text.Trim());
                float y1 = float.Parse(textBox16.Text.Trim());
                float x2 = float.Parse(textBox13.Text.Trim());
                float y2 = float.Parse(textBox17.Text.Trim());
                float x3 = float.Parse(textBox14.Text.Trim());
                float y3 = float.Parse(textBox18.Text.Trim());
                float x4 = float.Parse(textBox15.Text.Trim());
                float y4 = float.Parse(textBox19.Text.Trim());

                // Add points
                originalShape.Add(new PointF(x1, y1));
                originalShape.Add(new PointF(x2, y2));
                originalShape.Add(new PointF(x3, y3));
                originalShape.Add(new PointF(x4, y4));

                foreach (PointF pt in originalShape)
                    transformedShape.Add(new PointF(pt.X, pt.Y));

                panel1.Invalidate(); // redraw
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format: Use only numbers. If using decimals, use a dot (e.g. 12.5)");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Entered value is too large.");
            }
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                float dx = float.Parse(textBox20.Text);
                float dy = float.Parse(textBox21.Text);

                transformedShape = Transform2D.Translate(transformedShape, dx, dy);
                panel1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Enter valid values for translation.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                float sx = float.Parse(textBox20.Text.Trim()); // reuse translation X box
                float sy = float.Parse(textBox21.Text.Trim()); // reuse translation Y box

                transformedShape = Transform2D.Scale(transformedShape, sx, sy);

                panel1.Invalidate(); // redraw
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid scaling values.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                float angle = float.Parse(textBox22.Text.Trim()); // angle in degrees
                transformedShape = Transform2D.Rotate(transformedShape, angle);
                panel1.Invalidate(); // redraw
            }
            catch
            {
                MessageBox.Show("Please enter a valid angle.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            transformedShape = Transform2D.Reflect(transformedShape, "X");
            panel1.Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            transformedShape = Transform2D.Reflect(transformedShape, "Y");
            panel1.Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            transformedShape = Transform2D.Reflect(transformedShape, "Origin");
            panel1.Invalidate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                float shy = float.Parse(textBox24.Text.Trim()); // Y shear input
                transformedShape = Transform2D.ShearY(transformedShape, shy);
                panel1.Invalidate();
            }
            catch
            {
                MessageBox.Show("Enter a valid shear Y value.");
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }

}

    


