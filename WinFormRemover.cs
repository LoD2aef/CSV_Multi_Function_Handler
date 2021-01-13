using System;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    public partial class WinFormRemover : Form {
        public WinFormRemover() {
            InitializeComponent();
        }

        private void MainSelectFile_Click(object sender, EventArgs e) {
            SelectFile sf = new SelectFile();
            sf.FindItem();
        }
    }
}
