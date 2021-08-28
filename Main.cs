using System;
using System.Windows.Forms;
using System.IO; //FileSystemWatcher
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net;
using Renci.SshNet;
using Renci.SshNet.Sftp;

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

        private void Main_Load(object sender, EventArgs e)
        {
            TextBox_path.Text = Properties.Settings.Default.Path;
            Autodelete.Checked = Properties.Settings.Default.AD;
            AutoStart.Checked = Properties.Settings.Default.AutoRun;
            WindowsRun.Checked = Properties.Settings.Default.WinStart;
            ST_Tray.Checked = Properties.Settings.Default.ST_Tray;
            if (Properties.Settings.Default.ST_Tray)
            {
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                Tray.Visible = true;
            }
            IP = new WebClient().DownloadString("http://ipinfo.io/ip").Trim();
            TextBox_URL.Text = "http://sad.bbforest.net/" + IP;
            ListBox($"[SAD] 현재 설정");
            ListBox($"    설정 폴더 : {TextBox_path.Text}");
            ListBox($"    윈도우 시작시 자동 실행 : {WindowsRun.Checked}");
            ListBox($"    시작시 자동 감시 : {AutoStart.Checked}");
            ListBox($"    시작시 트레이로 : {ST_Tray.Checked}");
            ListBox($"    업로드 후 삭제 : {Autodelete.Checked}");
            ListBox($"    업로드 URL : {TextBox_URL.Text}");
            if (AutoStart.Checked) RunSet();
        }

        private void Tray_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.ShowInTaskbar = true;
            Tray.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            RunSet();
        }

        private void RunSet()
        {
            Run = !Run;
            ListBox($"[SAD] 감시 상태 : {Run}");
            if (Run == true)
            {
                FileWatcher();
                this.Text = "SAD(전송 및 삭제, Send And Delete) 감시중";
            }
            else
            {
                watcher.EnableRaisingEvents = false;
                this.Text = "SAD(전송 및 삭제, Send And Delete)";
            }
        }

        private void Upload(string name, string link)
        {
            var protocol = new ConnectionInfo("Address", "ID", new PasswordAuthenticationMethod("ID", "PW"));
            var sftp = new SftpClient(protocol);
            // SFTP 서버 연결
            sftp.Connect();
            if (!ipf)
            {
                try
                {
                    sftp.CreateDirectory($"/upload/{IP}"); //폴더 생성 시도
                    using (var outfile = File.Create("index.html"))
                    {
                        sftp.DownloadFile("/upload/gal.html", outfile);
                        sftp.UploadFile(outfile, $"/upload/{IP}/index.html");
                    }
                }
                catch (Exception)
                {
                    ipf = true; //실패시 폴더가 이미 있는 것으로 간주
                }
            }
            using (var infile = File.Open(link, FileMode.Open))
            {
                sftp.UploadFile(infile, $"/upload/{IP}/{name}"); //업로드
            }
            sftp.Disconnect();
            ListBox($"[SAD] 업로드 완료 : {TextBox_URL.Text}/{name}");
            if(Autodelete.Checked) File.Delete(link); //자동삭제 체크시 삭제
        }

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
            ListBox($"[FILE] {e.ChangeType} : {e.Name}");
            if (e.ChangeType.ToString() == "Created") Upload(e.Name, e.FullPath);
        }

        private void TextBox_URL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox_URL.Text);
            MessageBox.Show("복사되었습니다!", "파란대나무숲 Sad :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Rename(object source, RenamedEventArgs e)
        {
            //string sub = e.FullPath.Replace(Properties.Settings.Default.Path, "");
            ListBox($"[FILE] 이름 변경 : {e.Name}");
        }

        private void Autodelete_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AD = Autodelete.Checked;
            Properties.Settings.Default.Save();
            ListBox($"[SAD] 업로드 후 삭제 : {Autodelete.Checked}");
        }

        private void ListBox(string msg)
        {
            this.Invoke(new Action(delegate () {
                listBox.Items.Add(msg);
                listBox.SelectedIndex = listBox.Items.Count - 1;
                listBox.SelectedIndex = -1;
            }));
        }

        private void UploadView_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TextBox_URL.Text);
        }

        private string IP;
        private Boolean Run = false, setup = false, ipf = false;

        private void AutoStart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoRun = AutoStart.Checked;
            Properties.Settings.Default.Save();
            ListBox($"[SAD] 시작시 자동 감시 : {AutoStart.Checked}");
        }

        private void WindowsRun_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WinStart = WindowsRun.Checked;
            Properties.Settings.Default.Save();
            ListBox($"[SAD] 윈도우 시작시 자동 실행 : {WindowsRun.Checked}");
            if (WindowsRun.Checked) AddStartupProgram("net.bbforest.sad", Application.ExecutablePath);
            else if (!WindowsRun.Checked) RemoveStartupProgram("net.bbforest.sad");
        }

        private static readonly string _startupRegPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private Microsoft.Win32.RegistryKey GetRegKey(string regPath, bool writable)
        {
            return Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regPath, writable);
        }

        public void AddStartupProgram(string programName, string executablePath)
        {
            using (var regKey = GetRegKey(_startupRegPath, true))
            {
                try
                {
                    // 키가 이미 등록돼 있지 않을때만 등록
                    if (regKey.GetValue(programName) == null)
                        regKey.SetValue(programName, executablePath);

                    regKey.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void ST_Tray_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ST_Tray = ST_Tray.Checked;
            Properties.Settings.Default.Save();
            ListBox($"[SAD] 시작시 트레이로 : {ST_Tray.Checked}");
        }

        private void Main_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                Tray.Visible = true;
            }
        }

        // 등록된 프로그램 제거
        public void RemoveStartupProgram(string programName)
        {
            using (var regKey = GetRegKey(_startupRegPath, true))
            {
                try
                {
                    // 키가 이미 존재할때만 제거
                    if (regKey.GetValue(programName) != null)
                        regKey.DeleteValue(programName, false);

                    regKey.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private FileSystemWatcher watcher = new FileSystemWatcher();
    }
}
