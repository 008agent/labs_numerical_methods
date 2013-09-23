namespace lab2_splains
{
    partial class f_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_main = new System.Windows.Forms.Panel();
            this.p_paint = new System.Windows.Forms.Panel();
            this.p_controls = new System.Windows.Forms.Panel();
            this.bDraw = new System.Windows.Forms.Button();
            this.bBuild = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.b_setN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lErrors = new System.Windows.Forms.Label();
            this.p_main.SuspendLayout();
            this.p_controls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_main
            // 
            this.p_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_main.Controls.Add(this.p_paint);
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(0, 0);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(960, 580);
            this.p_main.TabIndex = 0;
            // 
            // p_paint
            // 
            this.p_paint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p_paint.Location = new System.Drawing.Point(0, 0);
            this.p_paint.Name = "p_paint";
            this.p_paint.Size = new System.Drawing.Size(810, 548);
            this.p_paint.TabIndex = 0;
            this.p_paint.Click += new System.EventHandler(this.p_paint_Click);
            // 
            // p_controls
            // 
            this.p_controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_controls.Controls.Add(this.bDraw);
            this.p_controls.Controls.Add(this.bBuild);
            this.p_controls.Controls.Add(this.tbN);
            this.p_controls.Controls.Add(this.b_setN);
            this.p_controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_controls.Location = new System.Drawing.Point(817, 0);
            this.p_controls.Name = "p_controls";
            this.p_controls.Size = new System.Drawing.Size(143, 580);
            this.p_controls.TabIndex = 1;
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(12, 98);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(119, 23);
            this.bDraw.TabIndex = 3;
            this.bDraw.Text = "draw";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // bBuild
            // 
            this.bBuild.Location = new System.Drawing.Point(12, 69);
            this.bBuild.Name = "bBuild";
            this.bBuild.Size = new System.Drawing.Size(123, 23);
            this.bBuild.TabIndex = 2;
            this.bBuild.Text = "buildSpline";
            this.bBuild.UseVisualStyleBackColor = true;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(12, 43);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(123, 20);
            this.tbN.TabIndex = 1;
            this.tbN.Text = "3";
            this.tbN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbN.TextChanged += new System.EventHandler(this.tbN_TextChanged);
            // 
            // b_setN
            // 
            this.b_setN.Location = new System.Drawing.Point(12, 12);
            this.b_setN.Name = "b_setN";
            this.b_setN.Size = new System.Drawing.Size(123, 25);
            this.b_setN.TabIndex = 0;
            this.b_setN.Text = "setN";
            this.b_setN.UseVisualStyleBackColor = true;
            this.b_setN.Click += new System.EventHandler(this.b_setN_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lErrors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 25);
            this.panel1.TabIndex = 2;
            // 
            // lErrors
            // 
            this.lErrors.AutoSize = true;
            this.lErrors.Location = new System.Drawing.Point(3, 3);
            this.lErrors.Name = "lErrors";
            this.lErrors.Size = new System.Drawing.Size(120, 13);
            this.lErrors.TabIndex = 5;
            this.lErrors.Text = "here will be current error";
            this.lErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_controls);
            this.Controls.Add(this.p_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "f_main";
            this.Text = "f_main";
            this.Load += new System.EventHandler(this.f_main_Load);
            this.p_main.ResumeLayout(false);
            this.p_controls.ResumeLayout(false);
            this.p_controls.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.Panel p_controls;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button b_setN;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Button bBuild;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lErrors;
        private System.Windows.Forms.Panel p_paint;
    }
}

