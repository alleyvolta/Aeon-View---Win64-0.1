using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace Aeon_View___Win64_0._1
{
    public partial class AeonView : Form
    {
        public AeonView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("xmrig.exe");
            p.StartInfo.WorkingDirectory = @"E:\Downloads\xmrig-2.4.4-msvc-win64";
            p.StartInfo.CreateNoWindow = true;
            
            p.Start();
        }
    }
}
