
namespace CrnaRupa
{
    partial class CrnaRupa
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
            this.components = new System.ComponentModel.Container();
            this.panIgra = new System.Windows.Forms.Panel();
            this.pbSkrivenaRupa = new System.Windows.Forms.PictureBox();
            this.pbRupa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojPropustenihKuglica = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.TimerIgra = new System.Windows.Forms.Timer(this.components);
            this.panIgra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkrivenaRupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRupa)).BeginInit();
            this.SuspendLayout();
            // 
            // panIgra
            // 
            this.panIgra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panIgra.Controls.Add(this.pbRupa);
            this.panIgra.Controls.Add(this.pbSkrivenaRupa);
            this.panIgra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panIgra.Location = new System.Drawing.Point(12, 45);
            this.panIgra.Name = "panIgra";
            this.panIgra.Size = new System.Drawing.Size(700, 700);
            this.panIgra.TabIndex = 0;
            // 
            // pbSkrivenaRupa
            // 
            this.pbSkrivenaRupa.BackColor = System.Drawing.Color.Maroon;
            this.pbSkrivenaRupa.Location = new System.Drawing.Point(298, 304);
            this.pbSkrivenaRupa.Name = "pbSkrivenaRupa";
            this.pbSkrivenaRupa.Size = new System.Drawing.Size(70, 70);
            this.pbSkrivenaRupa.TabIndex = 1;
            this.pbSkrivenaRupa.TabStop = false;
            this.pbSkrivenaRupa.Tag = "rupa";
            // 
            // pbRupa
            // 
            this.pbRupa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbRupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRupa.Location = new System.Drawing.Point(283, 290);
            this.pbRupa.Name = "pbRupa";
            this.pbRupa.Size = new System.Drawing.Size(100, 100);
            this.pbRupa.TabIndex = 0;
            this.pbRupa.TabStop = false;
            this.pbRupa.Tag = "rupa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propušteno Kugli:";
            // 
            // lblBrojPropustenihKuglica
            // 
            this.lblBrojPropustenihKuglica.AutoSize = true;
            this.lblBrojPropustenihKuglica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojPropustenihKuglica.Location = new System.Drawing.Point(144, 26);
            this.lblBrojPropustenihKuglica.Name = "lblBrojPropustenihKuglica";
            this.lblBrojPropustenihKuglica.Size = new System.Drawing.Size(16, 16);
            this.lblBrojPropustenihKuglica.TabIndex = 2;
            this.lblBrojPropustenihKuglica.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(219, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPause.Location = new System.Drawing.Point(320, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(422, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // TimerIgra
            // 
            this.TimerIgra.Interval = 40;
            this.TimerIgra.Tick += new System.EventHandler(this.TimerIgra_Tick);
            // 
            // CrnaRupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 749);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBrojPropustenihKuglica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panIgra);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrnaRupa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrnaRupa";
            this.panIgra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSkrivenaRupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panIgra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPropustenihKuglica;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbRupa;
        private System.Windows.Forms.Timer TimerIgra;
        private System.Windows.Forms.PictureBox pbSkrivenaRupa;
    }
}