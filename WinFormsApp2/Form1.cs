using System;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        
        List<PictureBox> items = new List<PictureBox>();
        bool Dragging;
        int xPos;
        int yPos;

        int index = 0;
        int indexcol = 0;

        int x, y, sX, sY, cX, cY;

        Color col = Color.Black;



        public Form1()
        {
            InitializeComponent();
        }
        private void MakePictureBox()
        {
            PictureBox newPic = new PictureBox();
            newPic.Height = 2 * Math.Abs(sY);
            newPic.Width = 2 * Math.Abs(sX);

            if (indexcol == 1)
            {
                newPic.BackColor = Color.Red;
            }
            if (indexcol == 2) { newPic.BackColor = Color.Green; }
            if (indexcol == 3) { newPic.BackColor = Color.Blue; }
            if (indexcol == 4) { newPic.BackColor = Color.Orange; }

            newPic.Paint += NewPic_Paint;

            newPic.Location = new Point(cX - Math.Abs(sX), cY - Math.Abs(sY));
            newPic.Click += NewPic_Click;

            newPic.MouseUp += NewPic_MouseUp;
            newPic.MouseDown += NewPic_MouseDown;
            newPic.MouseMove += NewPic_MouseMove;

            items.Add(newPic);
            this.Controls.Add(newPic);

        }

        private void NewPic_MouseMove(object? sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null && index == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                   
                    if (e.Y + c.Top - yPos > 0 && e.Y + c.Top - yPos < this.ClientSize.Height - c.Height)
                    {
                        c.Top = e.Y + c.Top - yPos;
                    }
                    if (e.X + c.Left - xPos > 0 && e.X + c.Left - xPos < this.ClientSize.Width - c.Width - 125)
                    {
                        c.Left = e.X + c.Left - xPos;
                    }

                }

            }
        }

        private void NewPic_MouseDown(object? sender, MouseEventArgs e)
        {
            Dragging = true;
            xPos = e.X;
            yPos = e.Y;
        }

        private void NewPic_MouseUp(object? sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void NewPic_Paint(object? sender, PaintEventArgs e)
        {
            PictureBox temPic = sender as PictureBox;

            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            if (index == 3)
            {
                temPic.Name = "rect";
                Rectangle pathRect = new Rectangle(0, 0, temPic.Width, temPic.Height);
                obj.AddRectangle(pathRect);
            }
            if (index == 4)
            {
                temPic.Name = "circ";
                obj.AddEllipse(0, 0, temPic.Width, temPic.Height);
            }
            if (index == 5)
            {
                temPic.Name = "tri";
                Point[] Arr =
             {
                 new Point(temPic.Width/2,0),
                 new Point(0, temPic.Height),
                 new Point(temPic.Width, temPic.Height)
             };
                obj.AddPolygon(Arr);
            }
            if (index == 6)
            {
                temPic.Name = "hex";
                Point[] Arr =
             {
                 new Point(temPic.Width/4,0),
                 new Point(3*(temPic.Width/4),0),
                 new Point(temPic.Width, temPic.Height/2),
                 new Point(3*(temPic.Width/4), temPic.Height),
                 new Point(temPic.Width/4, temPic.Height),
                 new Point(0, temPic.Height/2)
             };
                obj.AddPolygon(Arr);
            }

            Region rg = new Region(obj);
            temPic.Region = rg;
        }
        private void NewPic_Click(object sender, EventArgs e)
        {

            if (index == 2)
            {
                PictureBox temPic = sender as PictureBox;

                items.Remove(temPic);
                this.Controls.Remove(temPic);

            }


        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_tri_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_hex_Click(object sender, EventArgs e)
        {
            index = 6;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            cX = e.X;
            cY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            sX = x - cX;
            sY = y - cY;

            if (index >= 3 && index <= 6 && indexcol > 0 && indexcol <= 4)
            {
                MakePictureBox();
            }


        }

        private void color_red_Click(object sender, EventArgs e)
        {

            indexcol = 1;
        }

        private void color_green_Click(object sender, EventArgs e)
        {
            indexcol = 2;

        }

        private void color_blue_Click(object sender, EventArgs e)
        {
            indexcol = 3;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {

                items.Clear();

                foreach (Control control in this.Controls)
                {

                    if (control is PictureBox)
                    {

                        this.Controls.Remove(control);
                    }
                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<string> termsList = new List<string>();

            foreach (Control control in this.Controls)
            {

                if (control is PictureBox)
                {
     
                    termsList.Add(control.Location.ToString());
                    termsList.Add(control.Width.ToString());
                    termsList.Add(control.Height.ToString());
                    termsList.Add(control.BackColor.ToString());
                    termsList.Add(control.Name.ToString());


                }
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyasý|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                foreach (String s in termsList)
                    Kayit.WriteLine(s);
                Kayit.Close();
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daha eklenmedi");
            /*
             * PictureBox newPic = new PictureBox();
            newPic.Height = lX;
            newPic.Width = lY;
            /////
            if (indexcol == 1)
            {
                newPic.BackColor = Color.Red;
            }
            if (indexcol == 2) { newPic.BackColor = Color.Green; }
            if (indexcol == 3) { newPic.BackColor = Color.Blue; }

            //newPic.BackColor = col;

            newPic.Paint += NewPic_Paint;
            //int x = rand.Next(10, this.ClientSize.Width - newPic.Width);
            //int y = rand.Next(10, this.ClientSize.Height - newPic.Height);

            newPic.Location = new Point(cX, cY);
            newPic.Click += NewPic_Click;

            newPic.MouseUp += NewPic_MouseUp;
            newPic.MouseDown += NewPic_MouseDown;
            newPic.MouseMove += NewPic_MouseMove;

            items.Add(newPic);
            this.Controls.Add(newPic);
            */
        }

        private void color_orange_Click(object sender, EventArgs e)
        {
            indexcol = 4;
        }
    }
}