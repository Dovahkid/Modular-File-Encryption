using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Error003Encryption.Sdk;
using Error003AddonManager;

namespace Error003EncryptionGUI
{
    public partial class MainForm : Form
    {
        public static List<IAddon> Addons = null;

        static string FilePath = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            StartUpProcess();
        }

        void StartUpProcess()
        {
            try
            {
                Addons = AddonManager<IAddon>.ReadAddons();
            }
            catch (NoAddonsFoundException ex)
            {
                lblStatus.Text = ex.Message;
                return;
            }

            foreach (var addon in Addons)
            {
                lstEncryptionTypes.Items.Add(addon.name);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FilePath = ofd.FileName;
            lblInputFilePath.Text = FilePath;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string password;

            password = txtPassword.Text;

            foreach (var addon in Addons)
            {
                addon.FileEncrypt(FilePath, password);
            }
        }
    }
}
