
namespace BridgeSimulator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_alarm = new System.Windows.Forms.Label();
            this.tb_wf = new System.Windows.Forms.TextBox();
            this.tb_wr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.gb_options = new System.Windows.Forms.GroupBox();
            this.bt_change = new System.Windows.Forms.Button();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.rb_V = new System.Windows.Forms.RadioButton();
            this.rb_w = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 900);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(1032, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length of the car (meters):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(1032, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight on the front of the car (kN):";
            // 
            // tb_length
            // 
            this.tb_length.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_length.Location = new System.Drawing.Point(1292, 107);
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(104, 36);
            this.tb_length.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(1032, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight on the rear of the car (kN):";
            // 
            // label_alarm
            // 
            this.label_alarm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_alarm.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_alarm.ForeColor = System.Drawing.SystemColors.Control;
            this.label_alarm.Location = new System.Drawing.Point(1032, 12);
            this.label_alarm.Name = "label_alarm";
            this.label_alarm.Size = new System.Drawing.Size(360, 70);
            this.label_alarm.TabIndex = 7;
            this.label_alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_wf
            // 
            this.tb_wf.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_wf.Location = new System.Drawing.Point(1371, 187);
            this.tb_wf.Name = "tb_wf";
            this.tb_wf.Size = new System.Drawing.Size(104, 36);
            this.tb_wf.TabIndex = 8;
            // 
            // tb_wr
            // 
            this.tb_wr.Font = new System.Drawing.Font("新細明體", 12F);
            this.tb_wr.Location = new System.Drawing.Point(1363, 267);
            this.tb_wr.Name = "tb_wr";
            this.tb_wr.Size = new System.Drawing.Size(104, 36);
            this.tb_wr.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(1032, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Valid input is in the range [4, 8].)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(1032, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "(Valid input is in the range [0, 20].)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(1032, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "(Valid input is in the range [0, 20].)";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("新細明體", 12F);
            this.bt_start.Location = new System.Drawing.Point(1036, 359);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(142, 59);
            this.bt_start.TabIndex = 13;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // gb_options
            // 
            this.gb_options.Controls.Add(this.bt_change);
            this.gb_options.Controls.Add(this.rb_all);
            this.gb_options.Controls.Add(this.rb_M);
            this.gb_options.Controls.Add(this.rb_V);
            this.gb_options.Controls.Add(this.rb_w);
            this.gb_options.Font = new System.Drawing.Font("新細明體", 12F);
            this.gb_options.Location = new System.Drawing.Point(1036, 453);
            this.gb_options.Name = "gb_options";
            this.gb_options.Size = new System.Drawing.Size(259, 280);
            this.gb_options.TabIndex = 14;
            this.gb_options.TabStop = false;
            this.gb_options.Text = "Options";
            // 
            // bt_change
            // 
            this.bt_change.Font = new System.Drawing.Font("新細明體", 12F);
            this.bt_change.Location = new System.Drawing.Point(25, 194);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(142, 59);
            this.bt_change.TabIndex = 15;
            this.bt_change.Text = "Update";
            this.bt_change.UseVisualStyleBackColor = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(25, 47);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(180, 28);
            this.rb_all.TabIndex = 3;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "Show all graphs";
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(25, 149);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(219, 28);
            this.rb_M.TabIndex = 2;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "Only the M-x Graph";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // rb_V
            // 
            this.rb_V.AutoSize = true;
            this.rb_V.Location = new System.Drawing.Point(25, 115);
            this.rb_V.Name = "rb_V";
            this.rb_V.Size = new System.Drawing.Size(215, 28);
            this.rb_V.TabIndex = 1;
            this.rb_V.TabStop = true;
            this.rb_V.Text = "Only the V-x Graph";
            this.rb_V.UseVisualStyleBackColor = true;
            // 
            // rb_w
            // 
            this.rb_w.AutoSize = true;
            this.rb_w.Location = new System.Drawing.Point(25, 81);
            this.rb_w.Name = "rb_w";
            this.rb_w.Size = new System.Drawing.Size(215, 28);
            this.rb_w.TabIndex = 0;
            this.rb_w.TabStop = true;
            this.rb_w.Text = "Only the w-x Graph";
            this.rb_w.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bt_stop
            // 
            this.bt_stop.Font = new System.Drawing.Font("新細明體", 12F);
            this.bt_stop.Location = new System.Drawing.Point(1196, 359);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(142, 59);
            this.bt_stop.TabIndex = 16;
            this.bt_stop.Text = "Pause";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_continue
            // 
            this.bt_continue.Font = new System.Drawing.Font("新細明體", 12F);
            this.bt_continue.Location = new System.Drawing.Point(1356, 359);
            this.bt_continue.Name = "bt_continue";
            this.bt_continue.Size = new System.Drawing.Size(142, 59);
            this.bt_continue.TabIndex = 17;
            this.bt_continue.Text = "Continue";
            this.bt_continue.UseVisualStyleBackColor = true;
            this.bt_continue.Click += new System.EventHandler(this.bt_continue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 924);
            this.Controls.Add(this.bt_continue);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.gb_options);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_wr);
            this.Controls.Add(this.tb_wf);
            this.Controls.Add(this.label_alarm);
            this.Controls.Add(this.tb_length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bridge Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_options.ResumeLayout(false);
            this.gb_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_alarm;
        private System.Windows.Forms.TextBox tb_wf;
        private System.Windows.Forms.TextBox tb_wr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.GroupBox gb_options;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.RadioButton rb_V;
        private System.Windows.Forms.RadioButton rb_w;
        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_continue;
    }
}

