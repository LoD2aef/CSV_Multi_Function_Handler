using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class MeSelectFile {
        public string[] FindItem() {
            string[] res;
            using (OpenFileDialog OFD = new OpenFileDialog() { // what kinda files can be selected by the OpenFileDialog
                Filter = "CSV (Comma delimited)|*.csv|Excel Workbook(.xlsx)|*.xlsx|Excel 97-2003 Workbook (.xls)|*.xls|All files|*.*"
            }) {
                if (OFD.ShowDialog() == DialogResult.OK) {
                    string FileDirectory = OFD.FileName; // string with the Select file full directory/path location and name.
                    string[] SplitPath = FileDirectory.Split('\\'); // string array with the directory/path spilt on each new directory.
                    string FileName = SplitPath.Last(); // string with the Select file full name without the directory/path.
                    string FilePath = Path.GetDirectoryName(FileDirectory); // string with the Select file full directory/path without the name.
                    res = new string[] { FileDirectory, FileName, FilePath }; // string array of the three strings that will be used later.
                    return res; // returns the string array
                } else { // if no file is selected
                    res = new string[] { "Null" }; // set string array first row to have the item Null
                    return res; // returns the string array
                }
            }
        }
    }
}

