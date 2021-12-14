namespace AntiAFK
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_Start = new System.Windows.Forms.Button();
            this.txtbox_ProcessName = new System.Windows.Forms.TextBox();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.txtbox_Log = new System.Windows.Forms.TextBox();
            this.lbl_ProcessNameLbl = new System.Windows.Forms.Label();
            this.lbl_PidLabel = new System.Windows.Forms.Label();
            this.lbl_ProcessLbl = new System.Windows.Forms.Label();
            this.lbl_Pid = new System.Windows.Forms.Label();
            this.lbl_Process = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.radiobtn_op1 = new System.Windows.Forms.RadioButton();
            this.radiobtn_op2 = new System.Windows.Forms.RadioButton();
            this.panel_Options = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(175, 74);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(97, 75);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txtbox_ProcessName
            // 
            this.txtbox_ProcessName.Location = new System.Drawing.Point(175, 12);
            this.txtbox_ProcessName.Name = "txtbox_ProcessName";
            this.txtbox_ProcessName.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ProcessName.TabIndex = 1;
            this.txtbox_ProcessName.Text = "ffxiv_dx11";
            // 
            // btn_Attach
            // 
            this.btn_Attach.Location = new System.Drawing.Point(12, 12);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(75, 59);
            this.btn_Attach.TabIndex = 2;
            this.btn_Attach.Text = "Find";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // txtbox_Log
            // 
            this.txtbox_Log.Location = new System.Drawing.Point(12, 230);
            this.txtbox_Log.Multiline = true;
            this.txtbox_Log.Name = "txtbox_Log";
            this.txtbox_Log.ReadOnly = true;
            this.txtbox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_Log.Size = new System.Drawing.Size(263, 69);
            this.txtbox_Log.TabIndex = 3;
            // 
            // lbl_ProcessNameLbl
            // 
            this.lbl_ProcessNameLbl.AutoSize = true;
            this.lbl_ProcessNameLbl.Location = new System.Drawing.Point(93, 15);
            this.lbl_ProcessNameLbl.Name = "lbl_ProcessNameLbl";
            this.lbl_ProcessNameLbl.Size = new System.Drawing.Size(76, 13);
            this.lbl_ProcessNameLbl.TabIndex = 4;
            this.lbl_ProcessNameLbl.Text = "Process Name";
            // 
            // lbl_PidLabel
            // 
            this.lbl_PidLabel.AutoSize = true;
            this.lbl_PidLabel.Location = new System.Drawing.Point(93, 39);
            this.lbl_PidLabel.Name = "lbl_PidLabel";
            this.lbl_PidLabel.Size = new System.Drawing.Size(28, 13);
            this.lbl_PidLabel.TabIndex = 5;
            this.lbl_PidLabel.Text = "PID:";
            // 
            // lbl_ProcessLbl
            // 
            this.lbl_ProcessLbl.AutoSize = true;
            this.lbl_ProcessLbl.Location = new System.Drawing.Point(93, 58);
            this.lbl_ProcessLbl.Name = "lbl_ProcessLbl";
            this.lbl_ProcessLbl.Size = new System.Drawing.Size(48, 13);
            this.lbl_ProcessLbl.TabIndex = 6;
            this.lbl_ProcessLbl.Text = "Process:";
            // 
            // lbl_Pid
            // 
            this.lbl_Pid.AutoSize = true;
            this.lbl_Pid.Location = new System.Drawing.Point(175, 39);
            this.lbl_Pid.Name = "lbl_Pid";
            this.lbl_Pid.Size = new System.Drawing.Size(10, 13);
            this.lbl_Pid.TabIndex = 7;
            this.lbl_Pid.Text = "-";
            // 
            // lbl_Process
            // 
            this.lbl_Process.AutoSize = true;
            this.lbl_Process.Location = new System.Drawing.Point(175, 58);
            this.lbl_Process.Name = "lbl_Process";
            this.lbl_Process.Size = new System.Drawing.Size(10, 13);
            this.lbl_Process.TabIndex = 8;
            this.lbl_Process.Text = "-";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(175, 155);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(97, 69);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(13, 126);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(156, 23);
            this.btn_Test.TabIndex = 10;
            this.btn_Test.Text = "JUMP TEST";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // radiobtn_op1
            // 
            this.radiobtn_op1.AutoSize = true;
            this.radiobtn_op1.Checked = true;
            this.radiobtn_op1.Location = new System.Drawing.Point(3, 3);
            this.radiobtn_op1.Name = "radiobtn_op1";
            this.radiobtn_op1.Size = new System.Drawing.Size(106, 17);
            this.radiobtn_op1.TabIndex = 0;
            this.radiobtn_op1.TabStop = true;
            this.radiobtn_op1.Text = "Press A / D Keys";
            this.radiobtn_op1.UseVisualStyleBackColor = true;
            // 
            // radiobtn_op2
            // 
            this.radiobtn_op2.AutoSize = true;
            this.radiobtn_op2.Location = new System.Drawing.Point(3, 19);
            this.radiobtn_op2.Name = "radiobtn_op2";
            this.radiobtn_op2.Size = new System.Drawing.Size(128, 17);
            this.radiobtn_op2.TabIndex = 1;
            this.radiobtn_op2.Text = "Press Num 4 / 6 Keys";
            this.radiobtn_op2.UseVisualStyleBackColor = true;
            // 
            // panel_Options
            // 
            this.panel_Options.Controls.Add(this.radiobtn_op2);
            this.panel_Options.Controls.Add(this.radiobtn_op1);
            this.panel_Options.Location = new System.Drawing.Point(13, 77);
            this.panel_Options.Name = "panel_Options";
            this.panel_Options.Size = new System.Drawing.Size(156, 43);
            this.panel_Options.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.picturebox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(51, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 69);
            this.panel1.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.panel_Options);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lbl_Process);
            this.Controls.Add(this.lbl_Pid);
            this.Controls.Add(this.lbl_ProcessLbl);
            this.Controls.Add(this.lbl_PidLabel);
            this.Controls.Add(this.lbl_ProcessNameLbl);
            this.Controls.Add(this.txtbox_Log);
            this.Controls.Add(this.btn_Attach);
            this.Controls.Add(this.txtbox_ProcessName);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "AntiAFK";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_Options.ResumeLayout(false);
            this.panel_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txtbox_ProcessName;
        private System.Windows.Forms.Button btn_Attach;
        private System.Windows.Forms.TextBox txtbox_Log;
        private System.Windows.Forms.Label lbl_ProcessNameLbl;
        private System.Windows.Forms.Label lbl_PidLabel;
        private System.Windows.Forms.Label lbl_ProcessLbl;
        private System.Windows.Forms.Label lbl_Pid;
        private System.Windows.Forms.Label lbl_Process;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.RadioButton radiobtn_op1;
        private System.Windows.Forms.RadioButton radiobtn_op2;
        private System.Windows.Forms.Panel panel_Options;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

