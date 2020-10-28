using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorms
{
	public partial class Form2 : Form
	{
		Label lbl1, lbl2, lbl3, lbl4;
		TextBox txtA, txtB, txtC, txtH;
		PictureBox pic1;
		Button btn, btn2, btn3, btn4, btn5;
		ListBox lbox;

		Graphics gr;
		Pen p= new Pen(Brushes.Black, 2);
		Panel panel1;

		public Form2()
		{
			this.Height = 500;
			this.Width = 600;
			this.Text = "Windows Form Triangle";

			panel1 = new Panel();
			panel1.Size = new Size(200, 100);
			panel1.Location = new Point(400, 90);
			this.Controls.Add(panel1);

			lbl1 = new Label();
			lbl1.Text = "сторона 1";
			//lbl1.Size = new Size(20, 50);
			lbl1.Location = new Point(30, 100);
			this.Controls.Add(lbl1);

			lbl2 = new Label();
			lbl2.Text = "сторона 2";
			lbl2.Location = new Point(30, 140);
			this.Controls.Add(lbl2);

			lbl3 = new Label();
			lbl3.Text = "сторона 3";
			lbl3.Location = new Point(30, 180);
			this.Controls.Add(lbl3);

			lbl4 = new Label();
			lbl4.Text = "сторона H";
			lbl4.Location = new Point(30, 220);
			this.Controls.Add(lbl4);

			txtA = new TextBox();
			txtA.Location = new Point(130, 100);
			this.Controls.Add(txtA);

			txtB = new TextBox();
			txtB.Location = new Point(130, 140);
			this.Controls.Add(txtB);

			txtC = new TextBox();
			txtC.Location = new Point(130, 180);
			this.Controls.Add(txtC);

			txtH = new TextBox();
			txtH.Location = new Point(130, 220);
			this.Controls.Add(txtH);

			

			btn = new Button();
			btn.Size = new Size(100, 40);
			btn.Location = new Point(180, 30);
			btn.Text = "Запустить";
			btn.Click += Btn_Click;
			this.Controls.Add(btn);


			//BUTTON DRAW
			btn2 = new Button();
			btn2.Size = new Size(100, 40);
			btn2.Location = new Point(20, 30);
			btn2.Text = "Draw";
			btn2.Click += Btn2_Click;
			this.Controls.Add(btn2);


			lbox = new ListBox();
			lbox.Size = new Size(200, 200);
			lbox.Location = new Point(250, 250);
			this.Controls.Add(lbox);


			


			gr = panel1.CreateGraphics();
		}

		private void Btn2_Click(object sender, EventArgs e)
		{
			btn3 = new Button();
			btn3.Size = new Size(80, 40);
			btn3.Location = new Point(250, 100);
			btn3.Text = "равносторонний";
			btn3.Click += Btn3_Click;
			this.Controls.Add(btn3);

			btn4 = new Button();
			btn4.Size = new Size(80, 40);
			btn4.Location = new Point(250, 150);
			btn4.Text = "равнобедренный";
			btn4.Click += Btn4_Click;
			this.Controls.Add(btn4);

			btn5 = new Button();
			btn5.Size = new Size(80, 40);
			btn5.Location = new Point(250, 200);
			btn5.Text = "разносторонний";
			btn5.Click += Btn5_Click;
			this.Controls.Add(btn5);
		}

		private void Btn5_Click(object sender, EventArgs e)
		{
			panel1.Refresh();
			Point p1 = new Point(25, 25);
			Point p2 = new Point(170, 45);
			Point p3 = new Point(45, 90);
			gr.DrawLine(p, p1, p2);
			gr.DrawLine(p, p2, p3);
			gr.DrawLine(p, p3, p1);
			
		}

		private void Btn4_Click(object sender, EventArgs e)
		{
			panel1.Refresh();
			Point p1 = new Point(5, 80);
			Point p2 = new Point(150, 80);
			Point p3 = new Point(75, 30);
			gr.DrawLine(p, p1, p2);
			gr.DrawLine(p, p2, p3);
			gr.DrawLine(p, p3, p1);
		}

		private void Btn3_Click(object sender, EventArgs e)
		{
			panel1.Refresh();
			Point p1 = new Point(40, 90);
			Point p2 = new Point(150, 90);
			Point p3 = new Point(95, 5);
			gr.DrawLine(p, p1, p2);
			gr.DrawLine(p, p2, p3);
			gr.DrawLine(p, p3, p1);
		}

		private void Btn_Click(object sender, EventArgs e)
		{
			double a, b, c;
			if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
			{
				a = 0;
				b = 0;
				c = 0;
			}
			else
			{
				a = Convert.ToDouble(txtA.Text);
				b = Convert.ToDouble(txtB.Text);
				c = Convert.ToDouble(txtC.Text);
			}
			Triangl triang = new Triangl(a, b, c);
			lbox.Items.Add("Сторона A : "+ txtA.Text);
			lbox.Items.Add("Сторона B : " + txtB.Text);
			lbox.Items.Add("Сторона C : " + txtC.Text);
			if (triang.ExistTriangl)
			{
				lbox.Items.Add("Не существует");
			}
			else 
			{
				lbox.Items.Add("Существует");
				lbox.Items.Add("Периметр : " + triang.Perimetr());
				lbox.Items.Add("Площадь : " + triang.Surface());
				lbox.Items.Add("Высота : " + triang.heightt());
			}
			
			

			if ((txtA.Text == txtB.Text) && (txtB.Text == txtC.Text) && (txtC.Text == txtA.Text)) // равносторонний
			{
				panel1.Refresh();
				

				Point p1 = new Point(40, 90);
				Point p2 = new Point(150, 90);
				Point p3 = new Point(95, 5);
				gr.DrawLine(p, p1, p2);
				gr.DrawLine(p, p2, p3);
				gr.DrawLine(p, p3, p1);

				pic1 = new PictureBox();
				pic1.Image = Image.FromFile("ravn.png");
				pic1.Location = new Point(30, 250);
				pic1.Size = new Size(200, 200);
				pic1.SizeMode = PictureBoxSizeMode.Zoom;
				pic1.BorderStyle = BorderStyle.FixedSingle;
				this.Controls.Add(pic1);
			}
			else if ((txtA.Text == txtB.Text) || (txtB.Text == txtC.Text) || (txtC.Text == txtA.Text)) // равнобедренный
			{
				panel1.Refresh();
				

				Point p1 = new Point(5, 80);
				Point p2 = new Point(150, 80);
				Point p3 = new Point(75, 30);
				gr.DrawLine(p, p1, p2);
				gr.DrawLine(p, p2, p3);
				gr.DrawLine(p, p3, p1);

				pic1 = new PictureBox();
				pic1.Image = Image.FromFile("tri.png");
				pic1.Location = new Point(30, 250);
				pic1.Size = new Size(200, 200);
				pic1.SizeMode = PictureBoxSizeMode.Zoom;
				pic1.BorderStyle = BorderStyle.FixedSingle;
				this.Controls.Add(pic1);
			}
			else//разносторонний
			{
				panel1.Refresh();
				pic1.Refresh();
				Point p1 = new Point(25, 25);
				Point p2 = new Point(170, 45);
				Point p3 = new Point(45, 90);
				gr.DrawLine(p, p1, p2);
				gr.DrawLine(p, p2, p3);
				gr.DrawLine(p, p3, p1);

				pic1 = new PictureBox();
				pic1.Image = Image.FromFile("razn.jpg");
				pic1.Location = new Point(30, 250);
				pic1.Size = new Size(200, 200);
				pic1.SizeMode = PictureBoxSizeMode.Zoom;
				pic1.BorderStyle = BorderStyle.FixedSingle;
				this.Controls.Add(pic1);
			}

			
		}
	}
}
