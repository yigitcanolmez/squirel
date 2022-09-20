using Squirrel;
using System.Diagnostics;

namespace squirel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForUpdates();
        }
        private async Task CheckForUpdates()
        {
            try
            {
                using (var manager = await UpdateManager.GitHubUpdateManager("d"))
                {
                    var release = await manager.UpdateApp();
                }
            }
            catch (Exception)
            {

                Debug.WriteLine("failed to update.!");
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}