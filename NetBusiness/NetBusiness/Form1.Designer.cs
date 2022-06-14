
namespace NetBusiness
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
            this.learn_btn = new System.Windows.Forms.Button();
            this.sponsor_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.runner_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // learn_btn
            // 
            this.learn_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.learn_btn.Location = new System.Drawing.Point(227, 159);
            this.learn_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.learn_btn.Name = "learn_btn";
            this.learn_btn.Size = new System.Drawing.Size(230, 60);
            this.learn_btn.TabIndex = 2;
            this.learn_btn.Text = "Я хочу узнать больше о событии";
            this.learn_btn.UseVisualStyleBackColor = true;
            // 
            // sponsor_btn
            // 
            this.sponsor_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor_btn.Location = new System.Drawing.Point(227, 89);
            this.sponsor_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.sponsor_btn.Name = "sponsor_btn";
            this.sponsor_btn.Size = new System.Drawing.Size(230, 60);
            this.sponsor_btn.TabIndex = 1;
            this.sponsor_btn.Text = "Я хочу стать спонсором бегуна";
            this.sponsor_btn.UseVisualStyleBackColor = true;
            this.sponsor_btn.Click += new System.EventHandler(this.sponsor_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 161);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = "Today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 74);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARATHON SKILLS 2018";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 34);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "TimeToStart";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(600, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.runner_btn);
            this.panel4.Controls.Add(this.sponsor_btn);
            this.panel4.Controls.Add(this.learn_btn);
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 265);
            this.panel4.TabIndex = 4;
            // 
            // runner_btn
            // 
            this.runner_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.runner_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runner_btn.Location = new System.Drawing.Point(227, 19);
            this.runner_btn.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.runner_btn.Name = "runner_btn";
            this.runner_btn.Size = new System.Drawing.Size(230, 60);
            this.runner_btn.TabIndex = 0;
            this.runner_btn.Text = "Я хочу стать бегуном";
            this.runner_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "NetBusiness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button learn_btn;
        private System.Windows.Forms.Button sponsor_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button runner_btn;
    }
}

