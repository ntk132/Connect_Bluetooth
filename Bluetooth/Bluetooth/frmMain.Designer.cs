namespace Bluetooth
{
    partial class frmMain
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tbSendData = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btConnectControl = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.pnShow = new System.Windows.Forms.Panel();
            this.tbDataReading = new System.Windows.Forms.TextBox();
            this.lbReciveData = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSendData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParity = new System.Windows.Forms.TextBox();
            this.tbHandShake = new System.Windows.Forms.TextBox();
            this.tbDataBits = new System.Windows.Forms.TextBox();
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btShow = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btOpenFolderSource = new System.Windows.Forms.Button();
            this.cbCollect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpenFolderGraphic = new System.Windows.Forms.Button();
            this.pnControl.SuspendLayout();
            this.pnShow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(93, 10);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(257, 21);
            this.cbName.TabIndex = 0;
            this.cbName.TextChanged += new System.EventHandler(this.cbName_TextChanged);
            // 
            // tbSendData
            // 
            this.tbSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSendData.Location = new System.Drawing.Point(6, 31);
            this.tbSendData.Name = "tbSendData";
            this.tbSendData.Size = new System.Drawing.Size(246, 22);
            this.tbSendData.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(258, 28);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 25);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Gửi";
            this.btSend.UseVisualStyleBackColor = true;
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btConnectControl);
            this.pnControl.Controls.Add(this.lbState);
            this.pnControl.Controls.Add(this.lbTrangThai);
            this.pnControl.Location = new System.Drawing.Point(357, 295);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(365, 54);
            this.pnControl.TabIndex = 3;
            // 
            // btConnectControl
            // 
            this.btConnectControl.Location = new System.Drawing.Point(93, 3);
            this.btConnectControl.Name = "btConnectControl";
            this.btConnectControl.Size = new System.Drawing.Size(100, 25);
            this.btConnectControl.TabIndex = 2;
            this.btConnectControl.Text = "Kết nối";
            this.btConnectControl.UseVisualStyleBackColor = true;
            this.btConnectControl.Click += new System.EventHandler(this.btConnectControl_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(90, 32);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(62, 16);
            this.lbState.TabIndex = 1;
            this.lbState.Text = "trang thai";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(3, 34);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(71, 16);
            this.lbTrangThai.TabIndex = 0;
            this.lbTrangThai.Text = "Trạng thái:";
            // 
            // pnShow
            // 
            this.pnShow.Controls.Add(this.tbDataReading);
            this.pnShow.Controls.Add(this.lbReciveData);
            this.pnShow.Location = new System.Drawing.Point(12, 12);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(339, 275);
            this.pnShow.TabIndex = 4;
            // 
            // tbDataReading
            // 
            this.tbDataReading.Location = new System.Drawing.Point(6, 33);
            this.tbDataReading.Multiline = true;
            this.tbDataReading.Name = "tbDataReading";
            this.tbDataReading.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataReading.Size = new System.Drawing.Size(330, 239);
            this.tbDataReading.TabIndex = 1;
            // 
            // lbReciveData
            // 
            this.lbReciveData.AutoSize = true;
            this.lbReciveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReciveData.Location = new System.Drawing.Point(3, 9);
            this.lbReciveData.Name = "lbReciveData";
            this.lbReciveData.Size = new System.Drawing.Size(117, 16);
            this.lbReciveData.TabIndex = 0;
            this.lbReciveData.Text = "Dữ liệu nhận được:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSendData);
            this.panel1.Controls.Add(this.tbSendData);
            this.panel1.Controls.Add(this.btSend);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 56);
            this.panel1.TabIndex = 5;
            // 
            // lbSendData
            // 
            this.lbSendData.AutoSize = true;
            this.lbSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSendData.Location = new System.Drawing.Point(3, 12);
            this.lbSendData.Name = "lbSendData";
            this.lbSendData.Size = new System.Drawing.Size(70, 16);
            this.lbSendData.TabIndex = 3;
            this.lbSendData.Text = "Gửi dữ liệu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbParity);
            this.panel2.Controls.Add(this.tbHandShake);
            this.panel2.Controls.Add(this.tbDataBits);
            this.panel2.Controls.Add(this.tbBaudRate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbName);
            this.panel2.Location = new System.Drawing.Point(357, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 242);
            this.panel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hand shake:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data bits:";
            // 
            // tbParity
            // 
            this.tbParity.Location = new System.Drawing.Point(93, 130);
            this.tbParity.Name = "tbParity";
            this.tbParity.Size = new System.Drawing.Size(257, 20);
            this.tbParity.TabIndex = 6;
            // 
            // tbHandShake
            // 
            this.tbHandShake.Location = new System.Drawing.Point(93, 170);
            this.tbHandShake.Name = "tbHandShake";
            this.tbHandShake.Size = new System.Drawing.Size(257, 20);
            this.tbHandShake.TabIndex = 5;
            // 
            // tbDataBits
            // 
            this.tbDataBits.Location = new System.Drawing.Point(93, 90);
            this.tbDataBits.Name = "tbDataBits";
            this.tbDataBits.Size = new System.Drawing.Size(257, 20);
            this.tbDataBits.TabIndex = 4;
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Location = new System.Drawing.Point(93, 50);
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(257, 20);
            this.tbBaudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baud Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port name:";
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(450, 355);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(100, 25);
            this.btShow.TabIndex = 7;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(622, 355);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 25);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btOpenFolderSource
            // 
            this.btOpenFolderSource.Location = new System.Drawing.Point(164, 355);
            this.btOpenFolderSource.Name = "btOpenFolderSource";
            this.btOpenFolderSource.Size = new System.Drawing.Size(100, 25);
            this.btOpenFolderSource.TabIndex = 4;
            this.btOpenFolderSource.Text = "Open Folder Data";
            this.btOpenFolderSource.UseVisualStyleBackColor = true;
            this.btOpenFolderSource.Click += new System.EventHandler(this.btOpenFolderSource_Click);
            // 
            // cbCollect
            // 
            this.cbCollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCollect.FormattingEnabled = true;
            this.cbCollect.Location = new System.Drawing.Point(450, 7);
            this.cbCollect.Name = "cbCollect";
            this.cbCollect.Size = new System.Drawing.Size(257, 21);
            this.cbCollect.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chọn file:";
            // 
            // btOpenFolderGraphic
            // 
            this.btOpenFolderGraphic.Location = new System.Drawing.Point(12, 355);
            this.btOpenFolderGraphic.Name = "btOpenFolderGraphic";
            this.btOpenFolderGraphic.Size = new System.Drawing.Size(100, 25);
            this.btOpenFolderGraphic.TabIndex = 4;
            this.btOpenFolderGraphic.Text = "Folder Graphic";
            this.btOpenFolderGraphic.UseVisualStyleBackColor = true;
            this.btOpenFolderGraphic.Click += new System.EventHandler(this.btOpenFolderGraphic_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCollect);
            this.Controls.Add(this.btOpenFolderGraphic);
            this.Controls.Add(this.btOpenFolderSource);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.pnControl);
            this.Name = "frmMain";
            this.Text = "Giao tiếp Bluetooth";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.pnShow.ResumeLayout(false);
            this.pnShow.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox tbSendData;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btConnectControl;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.TextBox tbDataReading;
        private System.Windows.Forms.Label lbReciveData;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSendData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParity;
        private System.Windows.Forms.TextBox tbHandShake;
        private System.Windows.Forms.TextBox tbDataBits;
        private System.Windows.Forms.TextBox tbBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btOpenFolderSource;
        private System.Windows.Forms.ComboBox cbCollect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpenFolderGraphic;
    }
}

