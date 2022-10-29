using POSAccount.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAccount.Combo
{
    class ComboHelper
    {
        public static void AllCategories(ComboBox cmb) {
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryID");
            dt.Columns.Add("CategoryName");
            dt.Rows.Add("0", "--Select--");
            try
            {
                DataTable categorydt = Databaselayer.Select("Select CategoryID, CategoryName from Category Order By CategoryName ASC");
                if (categorydt != null)
                {
                    if (categorydt.Rows.Count > 0) {
                        foreach (DataRow item in categorydt.Rows) {
                            dt.Rows.Add(item[0].ToString(), item[1].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw; 
            }

            cmb.DataSource = dt;
            cmb.DisplayMember = "CategoryName";
            cmb.ValueMember = "CategoryID";
        }
    }
}
