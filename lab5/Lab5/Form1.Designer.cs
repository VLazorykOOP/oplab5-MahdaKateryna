using System.Drawing;
using System.Windows.Forms;
using System;

namespace ShapeDrawingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtX1;
        private TextBox txtY1;
        private TextBox txtX2;
        private TextBox txtY2;
        private TextBox txtX3;
        private TextBox txtY3;
        private TextBox txtX4;
        private TextBox txtY4;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtK;
        private Button btnDraw;
        private PictureBox pictureBox;
        private RadioButton rbBezier;
        private RadioButton rbArchimedeanTree;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.txtX4 = new System.Windows.Forms.TextBox();
            this.txtY4 = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rbBezier = new System.Windows.Forms.RadioButton();
            this.rbArchimedeanTree = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(10, 42);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 0;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(120, 42);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 20);
            this.txtY1.TabIndex = 1;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(10, 97);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 20);
            this.txtX2.TabIndex = 2;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(120, 97);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 20);
            this.txtY2.TabIndex = 3;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(10, 149);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(100, 20);
            this.txtX3.TabIndex = 4;
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(120, 149);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(100, 20);
            this.txtY3.TabIndex = 5;
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(10, 208);
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(100, 20);
            this.txtX4.TabIndex = 6;
            // 
            // txtY4
            // 
            this.txtY4.Location = new System.Drawing.Point(120, 208);
            this.txtY4.Name = "txtY4";
            this.txtY4.Size = new System.Drawing.Size(100, 20);
            this.txtY4.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 303);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 8;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(122, 303);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 9;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(61, 345);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(108, 20);
            this.txtK.TabIndex = 10;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 252);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(210, 30);
            this.btnDraw.TabIndex = 11;
            this.btnDraw.Text = "Draw";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(226, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(586, 434);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // rbBezier
            // 
            this.rbBezier.AutoSize = true;
            this.rbBezier.Checked = true;
            this.rbBezier.Location = new System.Drawing.Point(10, 386);
            this.rbBezier.Name = "rbBezier";
            this.rbBezier.Size = new System.Drawing.Size(85, 17);
            this.rbBezier.TabIndex = 13;
            this.rbBezier.TabStop = true;
            this.rbBezier.Text = "Bezier Curve";
            // 
            // rbArchimedeanTree
            // 
            this.rbArchimedeanTree.AutoSize = true;
            this.rbArchimedeanTree.Location = new System.Drawing.Point(108, 386);
            this.rbArchimedeanTree.Name = "rbArchimedeanTree";
            this.rbArchimedeanTree.Size = new System.Drawing.Size(112, 17);
            this.rbArchimedeanTree.TabIndex = 14;
            this.rbArchimedeanTree.Text = "Archimedean Tree";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(814, 458);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.txtY3);
            this.Controls.Add(this.txtX4);
            this.Controls.Add(this.txtY4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.rbBezier);
            this.Controls.Add(this.rbArchimedeanTree);
            this.Name = "Form1";
            this.Text = "Shape Drawing App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
