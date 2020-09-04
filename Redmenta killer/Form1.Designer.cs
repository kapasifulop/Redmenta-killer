using System.Windows.Forms;

namespace Redmenta_killer
{
    partial class mainwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.button1 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.randomise = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cur_delay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt.Location = new System.Drawing.Point(13, 13);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(775, 360);
            this.txt.TabIndex = 1;
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer_lbl.Location = new System.Drawing.Point(12, 393);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(101, 25);
            this.timer_lbl.TabIndex = 2;
            this.timer_lbl.Text = "Timer: 3s";
            // 
            // randomise
            // 
            this.randomise.AutoSize = true;
            this.randomise.Location = new System.Drawing.Point(119, 400);
            this.randomise.Name = "randomise";
            this.randomise.Size = new System.Drawing.Size(174, 17);
            this.randomise.TabIndex = 3;
            this.randomise.TabStop = true;
            this.randomise.Text = "randomise key press delay 1ms-";
            this.randomise.UseVisualStyleBackColor = true;
            this.randomise.CheckedChanged += new System.EventHandler(this.randomise_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "40";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_TextChanged);
            // 
            // cur_delay
            // 
            this.cur_delay.AutoSize = true;
            this.cur_delay.Location = new System.Drawing.Point(325, 403);
            this.cur_delay.Name = "cur_delay";
            this.cur_delay.Size = new System.Drawing.Size(0, 13);
            this.cur_delay.TabIndex = 5;
            this.cur_delay.Visible = false;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cur_delay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.randomise);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainwindow";
            this.Text = "Redmenta Killer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.RadioButton randomise;
        private System.Windows.Forms.TextBox textBox1;
        private Label cur_delay;
    }
}

