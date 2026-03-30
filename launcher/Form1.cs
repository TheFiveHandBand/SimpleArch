//For automatic Database and Core Info install
using System.Net.Http;
using System.IO.Compression;
//
using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleArchLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Select your games folder";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtGamePath.Text = folderDialog.SelectedPath;
            }
        }

        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGamePath.Text))
            {
                MessageBox.Show("Please select your games folder first!", "SimpleArch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save path to RetroArch config
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "retroarch.cfg");
            File.AppendAllText(configPath, $"\nrgui_browser_directory = \"{txtGamePath.Text}\"");
            File.AppendAllText(configPath, $"\nmenu_driver = \"xmb\"");

            // Automatic install of Database and Core Info Files
            using (var client = new HttpClient())
            {
                // Download and save databases
                string dbZip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.zip");
                using (var stream = await client.GetStreamAsync("http://buildbot.libretro.com/assets/frontend/database-rdb.zip"))
                using (var fileStream = new FileStream(dbZip, FileMode.Create))
                {
                    await stream.CopyToAsync(fileStream);
                }
                ZipFile.ExtractToDirectory(dbZip, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database", "rdb"), true);
                File.Delete(dbZip);

                // Download and save core info
                string infoZip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "info.zip");
                using (var stream = await client.GetStreamAsync("http://buildbot.libretro.com/assets/frontend/info.zip"))
                using (var fileStream = new FileStream(infoZip, FileMode.Create))
                {
                    await stream.CopyToAsync(fileStream);
                }
                ZipFile.ExtractToDirectory(infoZip, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "info"), true);
                File.Delete(infoZip);
            }
            //

            // Mark first run as complete
            string firstRunPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "firstrun.complete");
            File.WriteAllText(firstRunPath, "done");

            // Message instructing user to import their library via Retroarch frontend using added filepath present in retroarch.cfg
            MessageBox.Show("SimpleArch has been setup!\n\nTo add your games in SimpleArch select:\n\n" +
                "Playlist > Import Content > Scan Directory > Scan this directory\n\n" +
                "Please select OK to launch", "SimpleArch Setup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Launch SimpleArch
            System.Diagnostics.Process.Start("SimpleArch-core.exe");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Skip setup if already completed
            string firstRunPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "firstrun.complete");
            if (File.Exists(firstRunPath))
            {
                System.Diagnostics.Process.Start("SimpleArch-core.exe");
                Application.Exit();
            }
        }
    }
}
