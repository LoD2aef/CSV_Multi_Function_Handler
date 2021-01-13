using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace MaMut_Inactive_User_Filter {
    class FileReader {
        public string[] ReadLines(string filePath) {
            try {
                if (Path.GetExtension(filePath) == ".csv") {
                    string[] lines = File.ReadAllLines(filePath, Encoding.Default);
                    return lines;
                } else {
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read)) {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream)) {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration() {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            DataTable dt = result.Tables[0];
                            List<string> list = new List<string>();
                            string[] stringColumns = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
                            string oneColumn = string.Join(";", stringColumns);
                            list.Add(oneColumn);
                            for (int i = 0; i < dt.Rows.Count; i++) {
                                string[] stringRows = dt.Rows[i].ItemArray.Select(x => x.ToString()).ToArray();
                                string oneRow = string.Join(";", stringRows);
                                list.Add(oneRow);
                            }
                            string[] lines = list.ToArray();
                            return lines;
                        }
                    }
                }
            } catch (Exception ex) {
                throw new ApplicationException("error :", ex);
            }
        }
    }
}
