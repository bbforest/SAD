
namespace Send_And_Delete
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TextBox_path = new System.Windows.Forms.TextBox();
            this.Button_start = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Menubar = new System.Windows.Forms.MenuStrip();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadView = new System.Windows.Forms.ToolStripMenuItem();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_URL = new System.Windows.Forms.TextBox();
            this.Autodelete = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.WindowsRun = new System.Windows.Forms.CheckBox();
            this.ST_Tray = new System.Windows.Forms.CheckBox();
            this.ver = new System.Windows.Forms.Label();
            this.Menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_path
            // 
            this.TextBox_path.Location = new System.Drawing.Point(393, 27);
            this.TextBox_path.Name = "TextBox_path";
            this.TextBox_path.ReadOnly = true;
            this.TextBox_path.Size = new System.Drawing.Size(338, 21);
            this.TextBox_path.TabIndex = 2;
            this.TextBox_path.Text = "폴더 경로를 지정하세요.(클릭시 팝업)";
            this.TextBox_path.Click += new System.EventHandler(this.TextBox_path_Click);
            // 
            // Button_start
            // 
            this.Button_start.Location = new System.Drawing.Point(737, 26);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(75, 23);
            this.Button_start.TabIndex = 3;
            this.Button_start.Text = "감시";
            this.Button_start.UseVisualStyleBackColor = true;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // Menubar
            // 
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info,
            this.UploadView});
            this.Menubar.Location = new System.Drawing.Point(0, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Size = new System.Drawing.Size(818, 24);
            this.Menubar.TabIndex = 0;
            this.Menubar.Text = "menuStrip1";
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(43, 20);
            this.Info.Text = "정보";
            // 
            // UploadView
            // 
            this.UploadView.Name = "UploadView";
            this.UploadView.Size = new System.Drawing.Size(79, 20);
            this.UploadView.Text = "업로드확인";
            this.UploadView.Click += new System.EventHandler(this.UploadView_Click);
            // 
            // Tray
            // 
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "SAD";
            this.Tray.Click += new System.EventHandler(this.Tray_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(12, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(375, 364);
            this.listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "파일이 저장될 URL(클릭시 복사)";
            // 
            // TextBox_URL
            // 
            this.TextBox_URL.Location = new System.Drawing.Point(582, 51);
            this.TextBox_URL.Name = "TextBox_URL";
            this.TextBox_URL.ReadOnly = true;
            this.TextBox_URL.Size = new System.Drawing.Size(229, 21);
            this.TextBox_URL.TabIndex = 5;
            this.TextBox_URL.Text = "http://sad.bbforest.net/";
            this.TextBox_URL.Click += new System.EventHandler(this.TextBox_URL_Click);
            // 
            // Autodelete
            // 
            this.Autodelete.AutoSize = true;
            this.Autodelete.Location = new System.Drawing.Point(396, 75);
            this.Autodelete.Name = "Autodelete";
            this.Autodelete.Size = new System.Drawing.Size(104, 16);
            this.Autodelete.TabIndex = 6;
            this.Autodelete.Text = "업로드 후 삭제";
            this.Autodelete.UseVisualStyleBackColor = true;
            this.Autodelete.Click += new System.EventHandler(this.Autodelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(390, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 216);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(396, 97);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(168, 16);
            this.AutoStart.TabIndex = 7;
            this.AutoStart.Text = "프로그램 실행시 자동 동작";
            this.AutoStart.UseVisualStyleBackColor = true;
            this.AutoStart.Click += new System.EventHandler(this.AutoStart_Click);
            // 
            // WindowsRun
            // 
            this.WindowsRun.AutoSize = true;
            this.WindowsRun.Location = new System.Drawing.Point(396, 119);
            this.WindowsRun.Name = "WindowsRun";
            this.WindowsRun.Size = new System.Drawing.Size(152, 16);
            this.WindowsRun.TabIndex = 8;
            this.WindowsRun.Text = "윈도우 실행시 자동시작";
            this.WindowsRun.UseVisualStyleBackColor = true;
            this.WindowsRun.Click += new System.EventHandler(this.WindowsRun_Click);
            // 
            // ST_Tray
            // 
            this.ST_Tray.AutoSize = true;
            this.ST_Tray.Location = new System.Drawing.Point(396, 141);
            this.ST_Tray.Name = "ST_Tray";
            this.ST_Tray.Size = new System.Drawing.Size(112, 16);
            this.ST_Tray.TabIndex = 9;
            this.ST_Tray.Text = "시작시 트레이로";
            this.ST_Tray.UseVisualStyleBackColor = true;
            this.ST_Tray.Click += new System.EventHandler(this.ST_Tray_Click);
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ver.Location = new System.Drawing.Point(404, 372);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(59, 18);
            this.ver.TabIndex = 11;
            this.ver.Text = "0.0.0.0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 399);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.ST_Tray);
            this.Controls.Add(this.WindowsRun);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Autodelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.TextBox_URL);
            this.Controls.Add(this.TextBox_path);
            this.Controls.Add(this.Menubar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menubar;
            this.Name = "Main";
            this.Text = "SAD(전송 및 삭제, Send And Delete)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Move += new System.EventHandler(this.Main_Move);
            this.Menubar.ResumeLayout(false);
            this.Menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_path;
        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip Menubar;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_URL;
        private System.Windows.Forms.CheckBox Autodelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem UploadView;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.Windows.Forms.CheckBox WindowsRun;
        private System.Windows.Forms.CheckBox ST_Tray;
        private System.Windows.Forms.Label ver;
    }
}

