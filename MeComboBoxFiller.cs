using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaMut_Inactive_User_Filter {
    class FuncComboBoxFiller {
        private void ComboBoxFiller(int a, string[] SelectReadedFile) {
            try {
                string[] fileFields = SelectReadedFile[0].Split(';');
                //MainComparePoint.Items.Clear();
                //for (int i = 0; i < fileFields.Length; i++) {
                //    MainComparePoint.Items.Add(fileFields[i]);
                //}
            } catch (Exception ex) {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
