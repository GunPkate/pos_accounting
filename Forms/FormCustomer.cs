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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void fillGrid(string search)
        {
            try
            {
                string query = "SELECT CustomerID, CustomerName, ContactNo, Address, Email  FROM Customer";
                if (!string.IsNullOrEmpty(search))
                {
                    query = "SELECT CustomerID, CustomerName, ContactNo, Address, Email  FROM Customer" + " WHERE ( Description+' '+ CustomerName+' '+ ContactNo + ' '+ Address) like '%" + search.Trim() + "%'";
                }

                DataTable dt = Databaselayer.Select(query);
                dgvCustomer.DataSource = dt;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        dgvCustomer.Columns[0].Width = 80;        //CustomerID, 
                        dgvCustomer.Columns[1].Width = 120;   //CustomerName,
                        dgvCustomer.Columns[2].Width = 150;        //ContactNo, 
                        dgvCustomer.Columns[3].Width = 100;         //Address, 
                        dgvCustomer.Columns[4].Width = 100;        //Email, 
                    }
                }
            }
            catch (Exception)
            {
                dgvCustomer.DataSource = null;
                throw;
            }
        }

        private void enabledComponent()
        {
            btnCancle.Visible = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnClear.Visible = false;
            dgvCustomer.Visible = false;
        }

        private void resetComponent()
        {
            btnCancle.Visible = !true;
            btnUpdate.Visible = !true;
            btnSave.Visible = !false;
            btnClear.Visible = !false;
            dgvCustomer.Visible = !false;
            fillGrid(string.Empty);
            FormClear();
        }

        private void FormClear()
        {
            txtCustomer.Clear();
            txtSearch.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
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
                if (txtCustomer.Text.Trim().Length == 0)
                {
                    ep.SetError(txtCustomer, "Enter Customer");
                    txtCustomer.Focus();
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

                DataTable dt = Databaselayer.Select("Select * from Customer where CustomerName = '" + txtCustomer.Text.Trim() + "' and ContactNo '" + txtContact.Text.Trim() +
                    " ' and CustomerID != '" + dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[0].Value + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtCustomer, "Already Exist");
                        txtCustomer.Focus();
                        txtCustomer.SelectAll();
                        return;
                    }
                }

                string updatequery = string.Format("Update Customer set CustomerName = '{0}', ContactNo= '{1}', Address= '{2}', Email= '{3}'  where CustomerID = '{4}' ",
                    txtCustomer.Text.Trim(), txtContact.Text.Trim(), txtAddress.Text.Trim(), txtEmail.Text.Trim(),  dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[0].Value);
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
                if (txtCustomer.Text.Trim().Length == 0)
                {
                    ep.SetError(txtCustomer, "Enter Customer");
                    txtCustomer.Focus();
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

                DataTable dt = Databaselayer.Select("Select * from Customer where CustomerName = '" + txtCustomer.Text.Trim() + "' and ContactNo '" + txtContact.Text.Trim() + " ' ");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(txtCustomer, "Already Exist");
                        txtCustomer.Focus();
                        txtCustomer.SelectAll();
                        return;
                    }
                }

                string insertquery = string.Format("Insert Into Customer ( CustomerName, ContactNo, Address, Email ) values ('{0}','{1}','{2}','{3}')",
                    txtCustomer.Text.Trim(), txtContact.Text.Trim(), txtAddress.Text.Trim(), txtEmail.Text.Trim() );
                bool result = Databaselayer.Insert(insertquery);
                if (result == true)
                {
                    MessageBox.Show("Registered");
                    resetComponent();
                }
                else { MessageBox.Show("Data not corrected"); }
                fillGrid("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
                throw;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCustomer != null)
            {
                if (dgvCustomer.Rows.Count > 0)
                {
                    if (dgvCustomer.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Update selected item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //dgvProduct.Columns[0].Width = 80;        //CustomerID, 
                            //dgvProduct.Columns[1].Width = 120;   //CustomerName,
                            //dgvProduct.Columns[2].Width = 150;        //ContactNo, 
                            //dgvProduct.Columns[3].Width = 100;         //Address, 
                            //dgvProduct.Columns[4].Width = 100;        //Email, 

                            txtCustomer.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[1].Value.ToString();
                            txtContact.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[2].Value.ToString();
                            txtAddress.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[3].Value.ToString();
                            txtEmail.Text = dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[4].Value.ToString();

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
