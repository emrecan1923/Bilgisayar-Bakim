using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Linq;
using System.Collections.Generic;

namespace Bilgisayar_Bakım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool flag = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            flag = true;

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)

            {

                this.Location = Cursor.Position;

            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        private void button22_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\wu10.diagcab");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\WindowsFirewall.diagcab");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\SearchDiagnostic.diagcab");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\startmenu.diagcab");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\WinUSB.diagcab");
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsWeb",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsFileShare",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsInbound",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh int ip reset",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C msdt.exe /id NetworkDiagnosticsNetworkAdapter",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /flushdns",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /release&ipconfig / renew",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh winsock reset",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh winhttp reset proxy",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C netsh advfirewall reset",
                Verb = "runas",
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            listBox2.Items.Add(output);
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\microsoftaccountdiagnostic.diagcab");

        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\AppsDiagnostic.diagcab");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\Printerdiagnostic10.diagcab");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\onedrivets.diagcab");
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\winfilefolder.DiagCab");
        }



        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BilgisayarBakım\Cab\MicrosoftProgram_Install_and_Uninstall.meta.diagcab");
        }



        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string historyFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Google\Chrome\User Data\Default\History");

            if (File.Exists(historyFile))
            {
                try
                {
                    File.Delete(historyFile);
                    listBox1.Items.Add("Chrome geçmiş dosyası başarıyla temizlendi.");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("Chrome geçmiş dosyasını temizlerken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                listBox1.Items.Add("Chrome geçmiş dosyası bulunamadı.");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string historyFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera\\History");
            if (File.Exists(historyFile))
            {
                try
                {
                    File.Delete(historyFile);
                    listBox1.Items.Add("Opera geçmiş dosyası başarıyla temizlendi.");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("Opera geçmiş dosyasını temizlerken bir hata oluştu: " + ex.Message);
                }

            }
            else
            {
                listBox1.Items.Add("Opera geçmiş dosyası bulunamadı.");
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {

            string historyFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Opera Software\\Opera GX Stable\\History");
            try
            {
                if (File.Exists(historyFolder))
                {
                    File.Delete(historyFolder);
                    listBox1.Items.Add("Geçmiş başarıyla silindi.");
                }
                else
                {
                    listBox1.Items.Add("Geçmiş zaten silinmiş veya bulunamadı.");
                }
            }
            catch (IOException ex)
            {
                listBox1.Items.Add("Geçmiş silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string edgeHistoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default\History";
                File.Delete(edgeHistoryPath);
                listBox1.Items.Add("Edge tarayıcısının geçmişi başarıyla temizlendi.");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Hata oluştu: " + ex.Message);
            }


        }

        private void button23_Click(object sender, EventArgs e)
        {
            // Geçici dosyaları sil
            string tempFolderPath = Path.GetTempPath();
            DirectoryInfo tempDir = new DirectoryInfo(tempFolderPath);
            
            foreach (FileInfo file in tempDir.GetFiles())
            {
                file.Delete();
            }

       

            // Geçici İnternet dosyalarını sil
            string ieCachePath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            DirectoryInfo ieCacheDir = new DirectoryInfo(ieCachePath);
            foreach (FileInfo file in ieCacheDir.GetFiles())
            {
                file.Delete();
            }

            // Windows yükleme dosyalarını sil
            string HistoryPath = Environment.GetFolderPath(Environment.SpecialFolder.History);
            DirectoryInfo HistoryDir = new DirectoryInfo(HistoryPath);
            foreach (DirectoryInfo dir in HistoryDir.GetDirectories())
            {
                dir.Delete(true);
            }

            string RecentPath = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
            DirectoryInfo RecentDir = new DirectoryInfo(RecentPath);
            foreach (FileInfo file in RecentDir.GetFiles())
            {
                file.Delete();
            }

           
            string internetcachePath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            DirectoryInfo internetcachePathDir = new DirectoryInfo(internetcachePath);
            foreach (FileInfo file in internetcachePathDir.GetFiles())
            {
                file.Delete();
            }

            
            string browserCachePath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
            DirectoryInfo browserCacheDir = new DirectoryInfo(browserCachePath);
            foreach (FileInfo file in browserCacheDir.GetFiles())
            {
                file.Delete();
            }

            // Silme işleminin başarılı olduğunu göster
            listBox1.Items.Add("İstenmeyen dosyalar başarıyla silindi.");

        }
       
        private void button10_Click_1(object sender, EventArgs e)
        {
            // HKEY_CURRENT_USER anahtarındaki yazılım alt anahtarının altındaki tüm alt anahtarları temizle
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            string[] subKeyNames = key.GetSubKeyNames();
            foreach (string subKeyName in subKeyNames)
            {
                RegistryKey subKey = key.OpenSubKey(subKeyName, true);
                if (subKey.SubKeyCount == 0 && subKey.ValueCount == 0)
                {
                    // alt anahtarında alt anahtar ve değer yoksa alt anahtarı sil
                    key.DeleteSubKey(subKeyName);
                    listBox1.Items.Add(subKeyName);
                }
                subKey.Close();
            }
            key.Close();

            string softwareKey = @"SOFTWARE";
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            using (RegistryKey key1 = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string subKeyName in key1.GetSubKeyNames())
                {
                    using (RegistryKey subKey = key1.OpenSubKey(subKeyName))
                    {
                        string displayName = (string)subKey.GetValue("DisplayName");
                        string uninstallString = (string)subKey.GetValue("UninstallString");

                        if (string.IsNullOrEmpty(displayName) || string.IsNullOrEmpty(uninstallString))
                        {
                            continue;
                        }

                        if (!uninstallString.ToLower().Contains("uninstall"))
                        {
                            continue;
                        }

                        if (!Array.Exists(Registry.LocalMachine.OpenSubKey(softwareKey).GetSubKeyNames(), element => element == displayName))
                        {
                            continue;
                        }
                        Registry.LocalMachine.DeleteSubKeyTree(softwareKey + "\\" + displayName);
                    }
                }
            }
            MessageBox.Show("Kayıt defteri temizlendi.");

        }

        

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }    
}

