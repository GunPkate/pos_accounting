using POSAccount.Combo;
using POSAccount.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAccount.Forms
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        string table = "Product";
        string view = "V_Stocklist";
        private void fillGrid(string search)
        {
            try
            {
                string query = $"SELECT ProductID, CategoryID, CategoryName, Name, MffcDate, ExpDate, Quantity, SaleUnitPrice, PurchaseUnitPrice, Description  FROM {view}";
                if (!string.IsNullOrEmpty(search))
                {
                    query = $"SELECT ProductID, CategoryID, CategoryName, Name, MffcDate, ExpDate, Quantity, SaleUnitPrice, Description, PurchaseUnitPrice FROM {view}" + " WHERE ( Description+' '+ CategoryName+' '+ Name) like '%" + search.Trim() + "%'";
                }

                DataTable dt = Databaselayer.Select(query);
                dgvProduct.DataSource = dt;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        dgvProduct.Columns[0].Width = 80; //ProductID
                        dgvProduct.Columns[1].Visible = false; //, CategoryID,
                        dgvProduct.Columns[2].Width = 120; //  CategoryName,
                        dgvProduct.Columns[3].Width = 80; //  Name, 
                        dgvProduct.Columns[4].Width = 100; // MffcDate,
                        dgvProduct.Columns[5].Width = 100; //  ExpDate,
                        dgvProduct.Columns[6].Width = 80; //  Quantity,
                        dgvProduct.Columns[7].Width = 120; //  SaleUnitPrice, 
                        dgvProduct.Columns[8].Width = 80;  // PurchaseUnitPrice 
                        dgvProduct.Columns[9].Width = 80;  // Description, 
                    }
                }
            }
            catch (Exception)
            {
                dgvProduct.DataSource = null;
                throw;
            }
        }

        private void enabledComponent()
        {
            btnCancle.Visible = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnClear.Visible = false;
            dgvProduct.Visible = false;
        }

        private void resetComponent()
        {
            btnCancle.Visible = !true;
            btnUpdate.Visible = !true;
            btnSave.Visible = !false;
            btnClear.Visible = !false;
            dgvProduct.Visible = !false;
            fillGrid(string.Empty);
            FormClear();
        }

        private void FormClear() {
            txtProduct.Clear();
            txtDetail.Clear();
            txtSearch.Clear();
            txtSalePrice.Text = "0";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtProduct.Text.Trim().Length == 0)
                {
                    ep.SetError(txtProduct, "Enter Product Name");
                    txtProduct.Focus();
                    return;
                }
                if (cmbCat.SelectedIndex == 0)
                {
                    ep.SetError(cmbCat, "Please Select Category");
                    cmbCat.Focus();
                    return;
                }

                float saleUnitPrice = 0;
                float.TryParse(txtSalePrice.Text, out saleUnitPrice);

                string query = "SELECT * FROM Product WHERE CategoryID  = '" + cmbCat.SelectedValue + "' and Name = '" + txtProduct.Text.Trim() + "' and ProductID = '" + dgvProduct.Rows[dgvProduct.Rows[0].Index].Cells[0].Value + "'";
                DataTable existdt = Databaselayer.Select(query);
                if (existdt != null)
                {
                    if (existdt.Rows.Count > 0)
                    {
                        string updatequery = string.Format("UPDATE Product SET CategoryID = '{0}', Name = '{1}', MffcDate = '{2}', ExpDate = '{3}', SaleUnitPrice = '{4}',  Description = '{5}' where ProductID =  '{6}'",
                            cmbCat.SelectedValue, txtProduct.Text.Trim(), dateMFT.Value.ToString("yyyy/MM/dd"), dateEXP.Value.ToString("yyyy/MM/dd"), saleUnitPrice, txtDetail.Text, dgvProduct.Rows[dgvProduct.Rows[0].Index].Cells[0].Value);
                        bool result = Databaselayer.Update(updatequery);
                        if (result)
                        {
                            MessageBox.Show("Update Successfull");
                            resetComponent();
                        }
                        else
                        {
                            MessageBox.Show("Update Failed");
                        }
                    }
                }
                fillGrid("");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillGrid(txtSearch.Text.Trim());
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            fillGrid(string.Empty);
            ComboHelper.AllCategories(cmbCat);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCategory frm = new FormCategory();
            frm.ShowDialog();

            string selectvalue = cmbCat.SelectedValue.ToString();
            ComboHelper.AllCategories(cmbCat);
            cmbCat.SelectedValue = selectvalue;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            resetComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtProduct.Text.Trim().Length == 0)
                {
                    ep.SetError(txtProduct, "Enter Product Name");
                    txtProduct.Focus();
                    return;
                }
                if (cmbCat.SelectedIndex == 0)
                {
                    ep.SetError(cmbCat, "Please Select Category");
                    cmbCat.Focus();
                    return;
                }

                float saleUnitPrice = 0;
                float.TryParse(txtSalePrice.Text, out saleUnitPrice);

                DataTable existdt = Databaselayer.Select("SELECT * FROM Product WHERE CategoryID  = '" + cmbCat.SelectedValue + "' and Name = '" + txtProduct.Text.Trim() + "'");
                if (existdt != null)
                {
                    if (existdt.Rows.Count > 0)
                    {
                        ep.SetError(txtProduct, "Already Exist");
                        txtProduct.Focus();
                        txtProduct.SelectAll();
                        return;
                    }
                }

                string insertquery = string.Format("insert into Product( CategoryID, Name, MffcDate, ExpDate, SaleUnitPrice,  Description) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    cmbCat.SelectedValue, txtProduct.Text.Trim(), dateMFT.Value.ToString("yyyy/MM/dd"), dateEXP.Value.ToString("yyyy/MM/dd"), saleUnitPrice, txtDetail.Text.Trim());
                bool result = Databaselayer.Insert(insertquery);
                if (result)
                {
                    MessageBox.Show("Register Successfull");
                }
                else
                {
                    MessageBox.Show("Register Failed");
                }
                fillGrid("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProduct != null)
            {
                if (dgvProduct.Rows.Count > 0)
                {
                    if (dgvProduct.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Update selected item?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            //dgvProduct.Columns[1].Visible = false; //, CategoryID,
                            //dgvProduct.Columns[2].Width = 120; //  CategoryName,
                            //dgvProduct.Columns[3].Width = 80; //  Name, 
                            //dgvProduct.Columns[4].Width = 100; // MffcDate,
                            //dgvProduct.Columns[5].Width = 100; //  ExpDate,
                            //dgvProduct.Columns[6].Width = 80; //  Quantity,
                            //dgvProduct.Columns[7].Width = 120; //  SaleUnitPrice, 
                            //dgvProduct.Columns[8].Width = 80;  // PurchaseUnitPrice 
                            //dgvProduct.Columns[9].Width = 80;  // Description, 

                            txtProduct.Text = dgvProduct.Rows[dgvProduct.SelectedRows[0].Index].Cells[3].Value.ToString() ;
                            cmbCat.SelectedValue = dgvProduct.Rows[dgvProduct.SelectedRows[0].Index].Cells[1].Value.ToString() ;
                            dateMFT.Value = Convert.ToDateTime(dgvProduct.Rows[dgvProduct.SelectedRows[0].Index].Cells[4].Value.ToString());
                            dateEXP.Value = Convert.ToDateTime(dgvProduct.Rows[dgvProduct.SelectedRows[0].Index].Cells[5].Value.ToString());
                            txtSalePrice.Text = dgvProduct.Rows[dgvProduct.SelectedRows[0].Index].Cells[7].Value.ToString();
                            txtDetail.Text = dgvProduct.Rows[dgvProduct.SelectedRows[0].Index].Cells[9].Value.ToString();
                            enabledComponent();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select One Product");
                    }
                }
            }
        }
    }
}
