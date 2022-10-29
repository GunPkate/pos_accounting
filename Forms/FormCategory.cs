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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void fillGrid(string search) {
            try
            {
                string query = "SELECT CategoryID [ID], CategoryName [Category] FROM Category";
                if (!string.IsNullOrEmpty(search))
                {
                    query = "SELECT CategoryID [ID], CategoryName [Category] FROM Category" + " WHERE CategoryName like '%" + search.Trim() + "%'";
                }

                DataTable dt = Databaselayer.Select(query);
                dgvCat.DataSource = dt;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        dgvCat.Columns[0].Width = 80;
                        dgvCat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception)
            {
                dgvCat.DataSource = null;
                throw;
            }
        }

        private void enabledComponent() {
            btnCancle.Visible = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            btnClear.Visible = false;
            dgvCat.Visible = false;
        }

        private void resetComponent()
        {
            btnCancle.Visible = !true;
            btnUpdate.Visible = !true;
            btnSave.Visible = !false;
            btnClear.Visible = !false;
            dgvCat.Visible = !false;
            fillGrid(string.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtCategory.Text.Trim().Length == 0)
                {
                    ep.SetError(txtCategory, "Please Enter Category");
                    txtCategory.Focus();
                    return;
                }

                DataTable existdt = Databaselayer.Select("SELECT CategoryID, CategoryName FROM Category" + " WHERE CategoryName like '%" + txtCategory.Text.Trim() + "%'");
                if (existdt.Rows.Count > 0)
                {
                    ep.SetError(txtCategory, "Duplicated Data");
                    return;
                }

                string insert_query = string.Format("Insert Into Category (CategoryName) values ('{0}')", txtCategory.Text.Trim());
                bool result = Databaselayer.Insert(insert_query);
                if (result)
                {
                    MessageBox.Show("Category Registered");
                    fillGrid(string.Empty);
                    txtCategory.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillGrid(txtSearch.Text.Trim());
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            fillGrid(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            resetComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ep.Clear();
                if (txtCategory.Text.Trim().Length == 0)
                {
                    ep.SetError(txtCategory, "Please Enter Category");
                    txtCategory.Focus();
                    return;
                }

                DataTable existdt = Databaselayer.Select("SELECT CategoryID, CategoryName FROM Category" + " WHERE CategoryName like '%" + txtCategory.Text.Trim() + "%'  " );
                if (existdt.Rows.Count > 0 && dgvCat.Rows[dgvCat.SelectedRows[0].Index].Cells[0].Value != null)
                {
                    ep.SetError(txtCategory, "Duplicated Data");
                    return;
                }

                string update_query = string.Format("Update Category set CategoryName = '{0}' Where CategoryID = '{1}'", txtCategory.Text.Trim(), dgvCat.Rows[dgvCat.SelectedRows[0].Index].Cells[0].Value.ToString());
                bool result = Databaselayer.Update(update_query);
                if (result)
                {
                    MessageBox.Show("Updated");
                    txtCategory.Clear();
                    resetComponent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                return;
                throw;
            }
        }


        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvCat != null)
            {
                if (dgvCat.Rows.Count > 0)
                {
                    if (dgvCat.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Update Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txtCategory.Text = dgvCat.Rows[dgvCat.SelectedRows[0].Index].Cells[1].Value.ToString();
                            enabledComponent();
                        }
                        else
                        {
                            MessageBox.Show("Select an item");
                        }
                    }
                }
            }

        }
    }
}
