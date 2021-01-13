using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class FuncFileWriter {
        private void Writer(string pathNameType, string[] fieldsMain) {
            try {
                using (StreamWriter file = new StreamWriter(pathNameType + ".CSV", true, Encoding.Default)) {
                    StringBuilder builder = new StringBuilder();
                    foreach (string value in fieldsMain) {
                        builder.Append(value);
                        builder.Append(';');
                    }
                    string fields = builder.ToString();
                                        file.WriteLine(fields);
                }
            } catch (Exception ex) {
                MessageBox.Show("error Excel File could not be created : " + ex.Message);
            }
        }
    }
}
