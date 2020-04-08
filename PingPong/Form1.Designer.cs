namespace PingPong
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
            this.components = new System.ComponentModel.Container();
            this.pole = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.schet = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.noWin = new System.Windows.Forms.Label();
            this.pole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pole
            // 
            this.pole.Controls.Add(this.noWin);
            this.pole.Controls.Add(this.schet);
            this.pole.Controls.Add(this.pictureBox1);
            this.pole.Controls.Add(this.GamePanel);
            this.pole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pole.Location = new System.Drawing.Point(0, 0);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(630, 345);
            this.pole.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(286, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GamePanel.Location = new System.Drawing.Point(200, 299);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(218, 19);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            this.GamePanel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(802, 230);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // schet
            // 
            this.schet.AutoSize = true;
            this.schet.Location = new System.Drawing.Point(12, 9);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(71, 13);
            this.schet.TabIndex = 2;
            this.schet.Text = "Результат: 0";
            // 
            // noWin
            // 
            this.noWin.AutoSize = true;
            this.noWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noWin.Location = new System.Drawing.Point(217, 184);
            this.noWin.Name = "noWin";
            this.noWin.Size = new System.Drawing.Size(201, 32);
            this.noWin.TabIndex = 3;
            this.noWin.Text = "Вы Проирали!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 345);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pole.ResumeLayout(false);
            this.pole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pole;
        private System.Windows.Forms.Label schet;
        private System.Windows.Forms.Label noWin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

