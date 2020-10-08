namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.color = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Massage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.save_data = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(694, 40);
            this.color.Margin = new System.Windows.Forms.Padding(4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(127, 29);
            this.color.TabIndex = 0;
            this.color.Text = "Колір форми";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.massageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // massageToolStripMenuItem
            // 
            this.massageToolStripMenuItem.Name = "massageToolStripMenuItem";
            this.massageToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.massageToolStripMenuItem.Text = "Message";
            this.massageToolStripMenuItem.Click += new System.EventHandler(this.massageToolStripMenuItem_Click);
            // 
            // Massage
            // 
            this.Massage.Location = new System.Drawing.Point(694, 76);
            this.Massage.Name = "Massage";
            this.Massage.Size = new System.Drawing.Size(127, 29);
            this.Massage.TabIndex = 2;
            this.Massage.Text = "Повідомлення";
            this.Massage.UseVisualStyleBackColor = true;
            this.Massage.Click += new System.EventHandler(this.Massage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(693, 413);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 29);
            this.exit.TabIndex = 5;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(693, 378);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(127, 29);
            this.next.TabIndex = 6;
            this.next.Text = "Наступна";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // save_data
            // 
            this.save_data.AutoSize = true;
            this.save_data.Location = new System.Drawing.Point(645, 40);
            this.save_data.Name = "save_data";
            this.save_data.Size = new System.Drawing.Size(0, 20);
            this.save_data.TabIndex = 7;
            this.save_data.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 452);
            this.Controls.Add(this.save_data);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Massage);
            this.Controls.Add(this.color);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виконав Світличний Є.С. гр. П-71";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button color;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem massageToolStripMenuItem;
        private System.Windows.Forms.Button Massage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label save_data;
    }
}

