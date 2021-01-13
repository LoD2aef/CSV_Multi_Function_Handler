using System;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    public partial class WinFormRemover : Form {
        public WinFormRemover() {
            InitializeComponent();
        }

        private void MainSelectFile_Click(object sender, EventArgs e) {
            MeSelectFile MSF = new MeSelectFile(); // make a new instands of the MeSelectFile Class so i can called Method from it.
            string[] FileDir = MSF.FindItem(); // string array with the values of FileDirectory, FileName, FilePath. from FindItem
            if (FileDir[0] == "Null") { // check if string return with the value of Null then there was not selected a path.
                MessageBox.Show("File was not selected"); // Show MSG when no file was slected as a pop-up.
            } else {
                MainFileName.Text = FileDir[1]; // setting Textbox MainFileName to be the name of the file selected in the OpenFileDialog.
                MeFileReader FFR = new MeFileReader(); // making a new instand of the MeFileReader Class so i can called Method from it.
                string[] FileAllLinesRaw = FFR.ReadLines(FileDir[0]); // string array, with all rows as a new string in the array, Columns are in string spilt by (;)
                MeComboBoxFiller MCBF = new MeComboBoxFiller(); // making a new instand of the MeFileReader Class so i can called Method from it.
                MCBF.ComboBoxFiller(FileAllLinesRaw[0], MainComparePoint); // Populated ComboBox with first rows of data from the selected file.
            }
        }
    }
}
