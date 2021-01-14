using System;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class MeComboBoxFiller {
        public void ComboBoxFiller(string SelectReadedFile, ComboBox CoBo) { // take the row string and the target ComboBox 
            try { // error handling
                string[] fileFields = SelectReadedFile.Split(';'); // spilt the string to a string array with each column as a index
                CoBo.Items.Clear(); // clear the target ComboBox so that there is no duplicate data
                for (int i = 0; i < fileFields.Length; i++) { // run through the column string array
                    CoBo.Items.Add(fileFields[i]); // adding each column to the ComboBox to be selected
                }
                CoBo.SelectedIndex = 0; // set the ComboBox to display and seleced the first column
            } catch (Exception ex) { // error catcher
                MessageBox.Show("Error with filling ComboBox : " + ex.Message); // error MSG
            }
        }
    }
}
