using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class MeFileWriter {
        private void Writer(string pathNameType, string[] fieldsMain) { // create and write to file, only write as CSV. string Array
            try { // error handle
                using (StreamWriter file = new StreamWriter(pathNameType + ".CSV", true, Encoding.Default)) { // file writer
                    StringBuilder builder = new StringBuilder(); // a new StringBuilder to make the string to be write.
                    foreach (string value in fieldsMain) { // spilt the string array of columns into single strings with column value.
                        builder.Append(value); // append the column value to the csv file.
                        builder.Append(';'); // append the indicator for a new column. 
                    }
                    string fields = builder.ToString(); // the StringBuild to normal string.
                    file.WriteLine(fields); // write the string line to the csv file.
                }
            } catch (Exception ex) { // error MSG
                MessageBox.Show("error Excel File could not be created/written. Type string array Error " + ex.Message);
            }
        }
        private void Writer(string pathNameType, string stringline) { // create and write to file, only write as CSV. string
            try { // error handle
                using (StreamWriter file = new StreamWriter(pathNameType + ".CSV", true, Encoding.Default)) { // file writer
                    file.WriteLine(stringline); // write the string line to the csv file.
                }
            } catch (Exception ex) { // error MSG
                MessageBox.Show("error Excel File could not be created/written. Type string Error : " + ex.Message);
            }
        }
    }
}
