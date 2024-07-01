using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeDrawingApp
{
    public partial class Form1 : Form
    {
        private int A, B, K;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (rbBezier.Checked)
            {
                // Draw Bézier curve task
                DrawBezierCurve();
            }
            else if (rbArchimedeanTree.Checked)
            {
                // Draw Archimedean tree fractal task
                DrawArchimedeanTree();
            }
        }

        private void DrawBezierCurve()
        {
            // Read coordinates from text boxes
            PointF p1 = new PointF(float.Parse(txtX1.Text), float.Parse(txtY1.Text));
            PointF p2 = new PointF(float.Parse(txtX2.Text), float.Parse(txtY2.Text));
            PointF p3 = new PointF(float.Parse(txtX3.Text), float.Parse(txtY3.Text));
            PointF p4 = new PointF(float.Parse(txtX4.Text), float.Parse(txtY4.Text));

            // Draw Bézier curve
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Black, 2);

                // Draw Bézier curve
                g.DrawBezier(pen, p1, p2, p3, p4);
            }
            pictureBox.Image = bmp;
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrawArchimedeanTree()
        {
            // Read values of A, B, K from text boxes
            A = int.Parse(txtA.Text);
            B = int.Parse(txtB.Text);
            K = int.Parse(txtK.Text);

            // Create a new Bitmap to draw the fractal
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); // Clear the bitmap with white background

                // Draw Archimedean tree fractal
                DrawArchimedeanTreeRecursive(g, pictureBox.Width / 2, pictureBox.Height - 50, A, B, K);
            }

            // Assign the bitmap to PictureBox.Image
            pictureBox.Image = bmp;
        }

        private void DrawArchimedeanTreeRecursive(Graphics g, int startX, int startY, int width, int height, int level)
        {
            if (level == 0)
                return;

            Pen pen = new Pen(Color.Black);

            int endX1 = startX - width / 2;
            int endX2 = startX + width / 2;
            int endY = startY - height;

            // Draw lines on the graphics object
            g.DrawLine(pen, startX, startY, endX1, endY);
            g.DrawLine(pen, startX, startY, endX2, endY);

            // Recursively draw branches
            DrawArchimedeanTreeRecursive(g, endX1, endY, width * A / 100, height * B / 100, level - 1);
            DrawArchimedeanTreeRecursive(g, endX2, endY, width * A / 100, height * B / 100, level - 1);

            pen.Dispose(); // Dispose the Pen object
        }

    }
}
