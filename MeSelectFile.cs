using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class FuncSelectFile {
        public string[] FindItem() {
            string[] res;
            using (OpenFileDialog OFD = new OpenFileDialog() {
                Filter = "CSV (Comma delimited)|*.csv|Excel Workbook(.xlsx)|*.xlsx|Excel 97-2003 Workbook (.xls)|*.xls|All files|*.*"
            }) {
                if (OFD.ShowDialog() == DialogResult.OK) {
                    string FileDirectory = OFD.FileName; // string with the Select file full directory/path location and name
                    string[] SplitPath = FileDirectory.Split('\\'); // string array with the directory/path spilt on each new directory
                    string FileName = SplitPath.Last(); // string with the Select file full name without the directory/path
                    string FilePath = Path.GetDirectoryName(FileDirectory); // string with the Select file full directory/path without the name
                    res = new string[] { FileDirectory, FileName, FilePath };
                    return res;
                } else {
                    res = new string[] { "Null" };
                    return res;
                }
            }
        }
    }
}

