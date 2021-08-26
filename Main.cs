using System;
using System.Windows.Forms;
using System.IO; //FileSystemWatcher
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net;

namespace Send_And_Delete
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string SelectFolder() //폴더 선택
        {
            CommonOpenFileDialog SF = new CommonOpenFileDialog();
            SF.IsFolderPicker = true; //폴더 지정
            SF.Title = "보낼 파일들이 있는 폴더";
            if (SF.ShowDialog() == CommonFileDialogResult.Ok) return SF.FileName; //폴더가 정상적으로 선택됐으면 지정
            return Properties.Settings.Default.Path;
        }

        private void TextBox_path_Click(object sender, EventArgs e)
        {
            if (!Run)
            {
                TextBox_path.Text = SelectFolder();
                Properties.Settings.Default.Path = TextBox_path.Text;
                Properties.Settings.Default.Save();
            }
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
            TextBox_URL.Text = "http://sad.bbforest.net/" + new WebClient().DownloadString("http://ipinfo.io/ip").Trim();
        }

        private void Tray_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Left) this.Show();
        }

        private Boolean Run = false, setup = false;

        private void Button_start_Click(object sender, EventArgs e)
        {
            Run = !Run;
            listBox.Items.Add(Run);
            if (Run == true) FileWatcher();
            else watcher.EnableRaisingEvents = false;
        }

        private FileSystemWatcher watcher = new FileSystemWatcher();

        private void FileWatcher()
        {
            if (setup == false)
            {
                setup = true;
                watcher.Path = Properties.Settings.Default.Path;
                watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size;
                watcher.Filter = "*.*";
                watcher.IncludeSubdirectories = true;
                watcher.Created += new FileSystemEventHandler(Event);
                watcher.Changed += new FileSystemEventHandler(Event);
                watcher.Deleted += new FileSystemEventHandler(Event);
                watcher.Renamed += new RenamedEventHandler(Rename);
            }
            watcher.EnableRaisingEvents = true;
        }

        private void Event(object source, FileSystemEventArgs e)
        {
            this.Invoke(new Action(delegate () { listBox.Items.Add($"{e.ChangeType}{e.FullPath}"); }));
            
        }

        private void TextBox_URL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox_URL.Text);
            MessageBox.Show("복사되었습니다!", "파란대나무숲 Sad :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Rename(object source, RenamedEventArgs e)
        {
            string sub = e.FullPath.Replace(Properties.Settings.Default.Path, "");
            this.Invoke(new Action(delegate () { listBox.Items.Add($"{e.Name}{sub}"); }));
        }
    }
}
