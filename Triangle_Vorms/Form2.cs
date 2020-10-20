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
		TextBox txt1, txt2, txt3;
		PictureBox pic1;

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

			txt1 = new TextBox();
			txt1.Location = new Point(130, 120);
			this.Controls.Add(txt1);

			txt2 = new TextBox();
			txt2.Location = new Point(130, 160);
			this.Controls.Add(txt2);

			txt3 = new TextBox();
			txt3.Location = new Point(130, 200);
			this.Controls.Add(txt3);

			pic1 = new PictureBox();
			//pic1.Image = Image.FromFile("tri.png");
			pic1.Location = new Point(340, 300);
			pic1.Size = new Size(1000, 1000);
			pic1.SizeMode = PictureBoxSizeMode.Zoom;
			pic1.BorderStyle = BorderStyle.FixedSingle;
			this.Controls.Add(pic1);

		}
	}
}
