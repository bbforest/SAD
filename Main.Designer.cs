
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
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_URL = new System.Windows.Forms.TextBox();
            this.Menubar.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_path
            // 
            this.TextBox_path.Location = new System.Drawing.Point(12, 27);
            this.TextBox_path.Name = "TextBox_path";
            this.TextBox_path.ReadOnly = true;
            this.TextBox_path.Size = new System.Drawing.Size(364, 21);
            this.TextBox_path.TabIndex = 0;
            this.TextBox_path.Text = "폴더 경로를 지정하세요.(클릭시 팝업)";
            this.TextBox_path.Click += new System.EventHandler(this.TextBox_path_Click);
            // 
            // Button_start
            // 
            this.Button_start.Location = new System.Drawing.Point(382, 27);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(75, 23);
            this.Button_start.TabIndex = 1;
            this.Button_start.Text = "Button_start";
            this.Button_start.UseVisualStyleBackColor = true;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // Menubar
            // 
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.Menubar.Location = new System.Drawing.Point(0, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Size = new System.Drawing.Size(800, 24);
            this.Menubar.TabIndex = 2;
            this.Menubar.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "SAD";
            this.Tray.Visible = true;
            this.Tray.Click += new System.EventHandler(this.Tray_Click);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기OpenToolStripMenuItem,
            this.종료ExitToolStripMenuItem});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // 열기OpenToolStripMenuItem
            // 
            this.열기OpenToolStripMenuItem.Name = "열기OpenToolStripMenuItem";
            this.열기OpenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.열기OpenToolStripMenuItem.Text = "열기(Open)";
            this.열기OpenToolStripMenuItem.Click += new System.EventHandler(this.TrayMenu_Open);
            // 
            // 종료ExitToolStripMenuItem
            // 
            this.종료ExitToolStripMenuItem.Name = "종료ExitToolStripMenuItem";
            this.종료ExitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.종료ExitToolStripMenuItem.Text = "종료(Exit)";
            this.종료ExitToolStripMenuItem.Click += new System.EventHandler(this.TrayMenu_Exit);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(12, 77);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(695, 160);
            this.listBox.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(695, 217);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "파일이 저장될 URL(클릭시 복사)";
            // 
            // TextBox_URL
            // 
            this.TextBox_URL.Location = new System.Drawing.Point(200, 52);
            this.TextBox_URL.Name = "TextBox_URL";
            this.TextBox_URL.ReadOnly = true;
            this.TextBox_URL.Size = new System.Drawing.Size(293, 21);
            this.TextBox_URL.TabIndex = 0;
            this.TextBox_URL.Text = "http://sad.bbforest.net/";
            this.TextBox_URL.Click += new System.EventHandler(this.TextBox_URL_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.TextBox_URL);
            this.Controls.Add(this.TextBox_path);
            this.Controls.Add(this.Menubar);
            this.MainMenuStrip = this.Menubar;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menubar.ResumeLayout(false);
            this.Menubar.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_path;
        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip Menubar;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem 열기OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ExitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_URL;
    }
}

