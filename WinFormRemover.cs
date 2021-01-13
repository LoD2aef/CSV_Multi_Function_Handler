using System;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    public partial class WinFormRemover : Form {
        public WinFormRemover() {
            InitializeComponent();
        }

        private void MainSelectFile_Click(object sender, EventArgs e) {
            FuncSelectFile sf = new FuncSelectFile();
            string[] FileDir = sf.FindItem(); // FileDirectory, FileName, FilePath
            if (FileDir[0] == "Null") {
                MessageBox.Show("File was not selected");
            } else {
                for (int i = 0; i <= FileDir.Length - 1; i++) {
                    MessageBox.Show(FileDir[i]);
                }
                FuncFileReader FFR = new FuncFileReader();
                string[] file = FFR.ReadLines(FileDir[0]);
                MessageBox.Show(file[0]);
            }
        }
    }
}
