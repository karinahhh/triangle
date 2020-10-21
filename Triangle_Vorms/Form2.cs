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
		Label lbl1, lbl2, lbl3;
		TextBox txtA, txtB, txtC;
		PictureBox pic1;
		Button btn;
		ListBox lbox;

		public Form2()
		{
			this.Height = 500;
			this.Width = 600;
			this.Text = "Windows Form Triangle";

			lbl1 = new Label();
			lbl1.Text = "сторона 1";
			//lbl1.Size = new Size(20, 50);
			lbl1.Location = new Point(30, 120);
			this.Controls.Add(lbl1);

			lbl2 = new Label();
			lbl2.Text = "сторона 2";
			lbl2.Location = new Point(30, 160);
			this.Controls.Add(lbl2);

			lbl3 = new Label();
			lbl3.Text = "сторона 3";
			lbl3.Location = new Point(30, 200);
			this.Controls.Add(lbl3);

			txtA = new TextBox();
			txtA.Location = new Point(130, 120);
			this.Controls.Add(txtA);

			txtB = new TextBox();
			txtB.Location = new Point(130, 160);
			this.Controls.Add(txtB);

			txtC = new TextBox();
			txtC.Location = new Point(130, 200);
			this.Controls.Add(txtC);

			pic1 = new PictureBox();
			pic1.Image = Image.FromFile("tri.png");
			pic1.Location = new Point(30, 250);
			pic1.Size = new Size(200, 200);
			pic1.SizeMode = PictureBoxSizeMode.Zoom;
			pic1.BorderStyle = BorderStyle.FixedSingle;
			this.Controls.Add(pic1);

			btn = new Button();
			btn.Size = new Size(100, 40);
			btn.Location = new Point(260, 130);
			btn.Text = "Запустить";
			btn.Click += Btn_Click;
			this.Controls.Add(btn);

			lbox = new ListBox();
			lbox.Size = new Size(200, 200);
			lbox.Location = new Point(300, 200);
			this.Controls.Add(lbox);

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
			
		
		}
	}
}
