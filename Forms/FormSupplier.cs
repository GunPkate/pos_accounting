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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void fillGrid(string search)
        {
            try
            {
                string query = "SELECT SupplierID, SupplierName, ContactNo, Address, Email, Description  FROM Supplier";
                if (!string.IsNullOrEmpty(search))
                {
                    query = "SELECT SupplierID, SupplierName, ContactNo, Address, Email, Description  FROM Supplier" + " WHERE ( Description+' '+ SupplierName+' '+ ContactNo + ' '+ Address) like '%" + search.Trim() + "%'";
                }

                DataTable dt = Databaselayer.Select(query);
                dgvSupplier.DataSource = dt;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        dgvSupplier.Columns[0].Width = 80;        //SupplierID, 
                        dgvSupplier.Columns[1].Width = 120;   //SupplierName,
                        dgvSupplier.Columns[2].Width = 150;        //ContactNo, 
                        dgvSupplier.Columns[3].Width = 100;         //Address, 
                        dgvSupplier.Columns[4].Width = 100;        //Email, 
                        dgvSupplier.Columns[5].Width = 200;        //Description 
                    }
                }
            }
            catch (Exception)
            {
                dgvSupplier.DataSource = null;
                throw;
            }
        }

        private void enabledComponent()
        {
            btnCancle.Visible = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnClear.Visible = false;
            dgvSupplier.Visible = false;
        }

        private void resetComponent()
        {
            btnCancle.Visible = !true;
            btnUpdate.Visible = !true;
            btnSave.Visible = !false;
            btnClear.Visible = !false;
            dgvSupplier.Visible = !false;
            fillGrid(string.Empty);
            FormClear();
        }

        private void FormClear()
        {
            txtSupplier.Clear();
            txtDetail.Clear();
            txtSearch.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            fillGrid(String.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillGrid(txtSearch.Text.Trim());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtSupplier.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSupplier, "Enter Supplier");
                    txtSupplier.Focus();
                    return;
                }

                if (txtContact.Text.Trim().Length == 0)
                {
                    ep.SetError(txtContact, "Enter Contact No");
                    txtContact.Focus();
                    return;
                }

                if (txtAddress.Text.Trim().Length == 0)
                {
                    ep.SetError(txtAddress, "Enter Address");
                }

                DataTable dt = Databaselayer.Select("Select * from Supplier where SupplierName = '" + txtSupplier.Text.Trim() + "' and ContactNo '" + txtContact.Text.Trim() + 
                    " ' and SupplierID != '"+ dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[0].Value+"'");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtSupplier, "Already Exist");
                        txtSupplier.Focus();
                        txtSupplier.SelectAll();
                        return;
                    }
                }

                string updatequery = string.Format("Update Supplier set SupplierName = '{0}', ContactNo= '{1}', Address= '{2}', Email= '{3}', Description= '{4}' where SupplierID = '{5}' ",
                    txtSupplier.Text.Trim(), txtContact.Text.Trim(), txtAddress.Text.Trim(), txtEmail.Text.Trim(), txtDetail.Text.Trim(), dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[0].Value);
                bool result = Databaselayer.Insert(updatequery);
                if (result == true)
                {
                    MessageBox.Show("Registered");
                    resetComponent();
                }
                else { MessageBox.Show("Data not corrected"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            resetComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtSupplier.Text.Trim().Length == 0)
                {
                    ep.SetError(txtSupplier, "Enter Supplier");
                    txtSupplier.Focus();
                    return;
                }

                if (txtContact.Text.Trim().Length < 11)
                {
                    ep.SetError(txtContact, "Enter Contact No");
                    txtContact.Focus();
                    return;
                }

                if (txtAddress.Text.Trim().Length < 11)
                {
                    ep.SetError(txtAddress, "Enter Address");
                }

                DataTable dt = Databaselayer.Select("Select * from Supplier where SupplierName = '" + txtSupplier.Text.Trim() + "' and ContactNo '" + txtContact.Text.Trim() + " ' ");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtSupplier, "Already Exist");
                        txtSupplier.Focus();
                        txtSupplier.SelectAll();
                        return;
                    }
                }

                string insertquery = string.Format("Insert Into Supplier ( SupplierName, ContactNo, Address, Email, Description ) values ('{0}','{1}','{2}','{3}','{4}')", 
                    txtSupplier.Text.Trim(), txtContact.Text.Trim(), txtAddress.Text.Trim(), txtEmail.Text.Trim(), txtDetail.Text.Trim());
                bool result = Databaselayer.Insert(insertquery);
                if (result == true)
                {
                    MessageBox.Show("Registered");
                    resetComponent();
                }
                else { MessageBox.Show("Data not corrected"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSupplier != null)
            {
                if (dgvSupplier.Rows.Count > 0)
                {
                    if (dgvSupplier.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Update selected item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //dgvProduct.Columns[0].Width = 80;        //SupplierID, 
                            //dgvProduct.Columns[1].Width = 120;   //SupplierName,
                            //dgvProduct.Columns[2].Width = 150;        //ContactNo, 
                            //dgvProduct.Columns[3].Width = 100;         //Address, 
                            //dgvProduct.Columns[4].Width = 100;        //Email, 
                            //dgvProduct.Columns[5].Width = 200;        //Description 

                            txtSupplier.Text = dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[1].Value.ToString();
                            txtContact.Text = dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[2].Value.ToString();
                            txtAddress.Text = dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[3].Value.ToString();
                            txtEmail.Text = dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[4].Value.ToString();
                            txtDetail.Text = dgvSupplier.Rows[dgvSupplier.SelectedRows[0].Index].Cells[5].Value.ToString();


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
