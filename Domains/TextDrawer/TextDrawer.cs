using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDrawer
{
	public partial class MainForm : Form
	{
		string text = "Nothing here yet";
		Font font;
		SolidBrush font_color;

		public MainForm()
		{
			InitializeComponent();
			font = new Font("Arial", 48);
			font_color = new SolidBrush(Color.Green);
			panel1.Paint += Panel1_Paint;
			this.Paint += MainForm_Paint;
		}
		private void Panel1_Paint(object sender, PaintEventArgs e) //Событие создание текста
		{
			if (text.Length > 0)
			{
				//1. Создаём картинку
				Image img = new Bitmap(panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);
				//2. Для того чтобы нарисовать создаём контекст устройства(сама картинка(img))
				Graphics imgDC = Graphics.FromImage(img);
				//3. Очищаем панель
				imgDC.Clear(BackColor);
				//4. Создаём текст
				imgDC.DrawString(text, font, font_color, ClientRectangle, new StringFormat(StringFormatFlags.NoFontFallback));
				//5. Отрисовываем текс по координатам
				e.Graphics.DrawImage(img, 0, 0);
			}
		}
		private void MainForm_Paint(object sender, PaintEventArgs e) // Событие отрисовки текста
		{ 
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));	
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e) // Событие изменения шрифта
		{
			//1. Cоздаём диалог изменения шрифта
			FontDialog font_dialog = new FontDialog();
			//2. Загружаем текущий шрифт в FontDialod
			font_dialog.Font = this.font;
			//3. Применяем новый шрифт
			if(font_dialog.ShowDialog() == DialogResult.OK)
				this.font = font_dialog.Font;
			//4. Принудительно вызываем событие отрисовки панели
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}
		
		private void fontColorToolStripMenuItem_Click(object sender, EventArgs e) // Событие изменения цвета
		{
			//1. Создаём диалог изменения цвета
			ColorDialog color_dialog = new ColorDialog();
			//2. Загружаем текущий цвет в ColorDialog
			color_dialog.Color = font_color.Color;
			//3. применяем новый цвет
			if (color_dialog.ShowDialog() == DialogResult.OK)
				this.font_color.Color = color_dialog.Color;
			//4. Принудительно вызываем событие отрисовки панели
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}
		public void SetText(string text)
		{
			this.text = text;
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}
		public void Move(Point new_location, int width)
		{
			this.Location = new_location;
			this.Width = width;
		}

	}
}
