namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblItemCount = new Label();
            panel1 = new Panel();
            color_orange = new Button();
            label3 = new Label();
            btn_load = new Button();
            btn_save = new Button();
            btn_clear = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            label2 = new Label();
            color_blue = new Button();
            color_green = new Button();
            color_red = new Button();
            btn_hex = new Button();
            btn_tri = new Button();
            btn_circle = new Button();
            btn_rect = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblItemCount
            // 
            lblItemCount.AutoSize = true;
            lblItemCount.Location = new Point(20, 27);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(64, 15);
            lblItemCount.TabIndex = 0;
            lblItemCount.Text = "Çizim Şekli";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(color_orange);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_load);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(color_blue);
            panel1.Controls.Add(color_green);
            panel1.Controls.Add(color_red);
            panel1.Controls.Add(btn_hex);
            panel1.Controls.Add(btn_tri);
            panel1.Controls.Add(btn_circle);
            panel1.Controls.Add(btn_rect);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblItemCount);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(995, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 640);
            panel1.TabIndex = 1;
            // 
            // color_orange
            // 
            color_orange.BackColor = Color.Orange;
            color_orange.FlatAppearance.MouseDownBackColor = Color.Gray;
            color_orange.FlatAppearance.MouseOverBackColor = Color.Gray;
            color_orange.FlatStyle = FlatStyle.Flat;
            color_orange.Location = new Point(63, 216);
            color_orange.Name = "color_orange";
            color_orange.Size = new Size(35, 23);
            color_orange.TabIndex = 15;
            color_orange.UseVisualStyleBackColor = false;
            color_orange.Click += color_orange_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 368);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Dosya İşlemleri";
            // 
            // btn_load
            // 
            btn_load.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_load.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_load.FlatStyle = FlatStyle.Flat;
            btn_load.Location = new Point(20, 415);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(75, 23);
            btn_load.TabIndex = 14;
            btn_load.Text = "Yükle";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_save
            // 
            btn_save.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_save.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(20, 386);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 14;
            btn_save.Text = "Kaydet";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Location = new Point(20, 333);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.Location = new Point(20, 304);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(75, 23);
            btn_eraser.TabIndex = 12;
            btn_eraser.Text = "Eraser";
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.Location = new Point(20, 275);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(75, 23);
            btn_pencil.TabIndex = 11;
            btn_pencil.Text = "Pencil";
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 257);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Şekil İşlemleri";
            // 
            // color_blue
            // 
            color_blue.BackColor = Color.Blue;
            color_blue.FlatAppearance.MouseDownBackColor = Color.Gray;
            color_blue.FlatAppearance.MouseOverBackColor = Color.Gray;
            color_blue.FlatStyle = FlatStyle.Flat;
            color_blue.Location = new Point(18, 216);
            color_blue.Name = "color_blue";
            color_blue.Size = new Size(35, 23);
            color_blue.TabIndex = 8;
            color_blue.UseVisualStyleBackColor = false;
            color_blue.Click += color_blue_Click;
            // 
            // color_green
            // 
            color_green.BackColor = Color.Green;
            color_green.FlatAppearance.MouseDownBackColor = Color.Gray;
            color_green.FlatAppearance.MouseOverBackColor = Color.Gray;
            color_green.FlatStyle = FlatStyle.Flat;
            color_green.Location = new Point(63, 187);
            color_green.Name = "color_green";
            color_green.Size = new Size(35, 23);
            color_green.TabIndex = 7;
            color_green.UseVisualStyleBackColor = false;
            color_green.Click += color_green_Click;
            // 
            // color_red
            // 
            color_red.BackColor = Color.Red;
            color_red.FlatAppearance.MouseDownBackColor = Color.Gray;
            color_red.FlatAppearance.MouseOverBackColor = Color.Gray;
            color_red.FlatStyle = FlatStyle.Flat;
            color_red.Location = new Point(17, 187);
            color_red.Name = "color_red";
            color_red.Size = new Size(35, 23);
            color_red.TabIndex = 6;
            color_red.UseVisualStyleBackColor = false;
            color_red.Click += color_red_Click;
            // 
            // btn_hex
            // 
            btn_hex.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_hex.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_hex.FlatStyle = FlatStyle.Flat;
            btn_hex.Location = new Point(18, 136);
            btn_hex.Name = "btn_hex";
            btn_hex.Size = new Size(75, 23);
            btn_hex.TabIndex = 5;
            btn_hex.Text = "Hexagon";
            btn_hex.UseVisualStyleBackColor = true;
            btn_hex.Click += btn_hex_Click;
            // 
            // btn_tri
            // 
            btn_tri.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_tri.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_tri.FlatStyle = FlatStyle.Flat;
            btn_tri.Location = new Point(18, 107);
            btn_tri.Name = "btn_tri";
            btn_tri.Size = new Size(75, 23);
            btn_tri.TabIndex = 4;
            btn_tri.Text = "Triangle";
            btn_tri.UseVisualStyleBackColor = true;
            btn_tri.Click += btn_tri_Click;
            // 
            // btn_circle
            // 
            btn_circle.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_circle.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_circle.FlatStyle = FlatStyle.Flat;
            btn_circle.Location = new Point(17, 74);
            btn_circle.Name = "btn_circle";
            btn_circle.Size = new Size(75, 27);
            btn_circle.TabIndex = 3;
            btn_circle.Text = "Circle";
            btn_circle.UseVisualStyleBackColor = true;
            btn_circle.Click += btn_circle_Click;
            // 
            // btn_rect
            // 
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.Location = new Point(18, 45);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(75, 23);
            btn_rect.TabIndex = 2;
            btn_rect.Text = "Rectangle";
            btn_rect.UseVisualStyleBackColor = true;
            btn_rect.Click += btn_rect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 169);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Renk Seçimi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 640);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CASE 1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblItemCount;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button color_blue;
        private Button color_green;
        private Button color_red;
        private Button btn_hex;
        private Button btn_tri;
        private Button btn_circle;
        private Button btn_rect;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_clear;
        private Button btn_load;
        private Button btn_save;
        private Label label3;
        private Button color_orange;
    }
}