using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class MeComboBoxFiller {
        public void ComboBoxFiller(string SelectReadedFile, ComboBox CoBo) {
            try {
                string[] fileFields = SelectReadedFile.Split(';');
                CoBo.Items.Clear();
                for (int i = 0; i < fileFields.Length; i++) {
                    CoBo.Items.Add(fileFields[i]);
                }
                CoBo.SelectedIndex = 0;
            } catch (Exception ex) {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
