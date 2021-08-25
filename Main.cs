using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //FileSystemWatcher
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Send_And_Delete
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string SelectFolder() //폴더 선택
        {
            string Path = "";
            CommonOpenFileDialog SF = new CommonOpenFileDialog();
            SF.IsFolderPicker = true; //폴더 지정
            SF.Title = "보낼 파일들이 있는 폴더";
            if (SF.ShowDialog() == CommonFileDialogResult.Ok) Path = SF.FileName; //폴더가 정상적으로 선택됐으면 지정
            return Path;
        }

        private void TextBox_path_Click(object sender, EventArgs e)
        {
            TextBox_path.Text = SelectFolder();
            Properties.Settings.Default.Path = TextBox_path.Text;
            Properties.Settings.Default.Save();
            Tray.Visible = true;
            Tray.ShowBalloonTip(2000, "SAD", "슬퍼요", ToolTipIcon.Info);
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TrayMenu_Open(object sender, EventArgs e)
        {
            this.Show();
        }

        private void TrayMenu_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TextBox_path.Text = Properties.Settings.Default.Path;
        }

        private void Tray_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Left) this.Show();
        }
    }
}
