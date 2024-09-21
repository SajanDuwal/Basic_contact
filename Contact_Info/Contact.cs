using Contact_Info.contact_info_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Info
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        ContactClass contactClass = new ContactClass();

        int id = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load data in data grid
            DataTable dt = contactClass.Select();
            dgv_db_data.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contactClass.fName = et_fname.Text;
            contactClass.lName = et_lname.Text;
            contactClass.contact = et_contact.Text;
            contactClass.address = et_address.Text;
            contactClass.email = et_email.Text;
            contactClass.gender = cb_gender.Text;

            //insert into 

            bool success = contactClass.Insert(contactClass);
            if (success)
            {
                //success
                MessageBox.Show("New Contact inserted");
                clearField();
            }
            else
            {
                MessageBox.Show("FAiled to add New Contact. Try Again");
            }

            //load data in data grid
            DataTable dt = contactClass.Select();
            dgv_db_data.DataSource = dt;

        }

        public void clearField()
        {
            et_fname.Text = "";
            et_lname.Text = "";
            et_contact.Text = "";
            et_address.Text = "";
            et_email.Text = "";
            cb_gender.Text = "";
            et_search.Text = "";
        }

        private void dgv_db_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            contactClass.id = id;
            contactClass.fName = et_fname.Text;
            contactClass.lName = et_lname.Text;
            contactClass.contact = et_contact.Text;
            contactClass.address = et_address.Text;
            contactClass.email = et_email.Text;
            contactClass.gender = cb_gender.Text;
            bool success = false;
            success = contactClass.update(contactClass);
            if (success)
            {
                //success upadte
                MessageBox.Show(" Contact updated");
                clearField();
                //load data in data grid
                DataTable dt = contactClass.Select();
                dgv_db_data.DataSource = dt;
            }
            else
            {
                //failed to update
                MessageBox.Show("Failed to update Contact !!!");
                clearField();
            }

        }

        private void dgv_db_data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get all datafrom grid view to update in text boxes
            //iodentify the row on which mouse is clicked

            int rowIndex = e.RowIndex;

            id = int.Parse(dgv_db_data.Rows[rowIndex].Cells[0].Value.ToString());
            et_fname.Text = dgv_db_data.Rows[rowIndex].Cells[1].Value.ToString();
            et_lname.Text = dgv_db_data.Rows[rowIndex].Cells[2].Value.ToString();
            et_contact.Text = dgv_db_data.Rows[rowIndex].Cells[3].Value.ToString();
            et_address.Text = dgv_db_data.Rows[rowIndex].Cells[4].Value.ToString();
            et_email.Text = dgv_db_data.Rows[rowIndex].Cells[5].Value.ToString();
            cb_gender.Text = dgv_db_data.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            contactClass.id = id;

            bool success = false;
            success = contactClass.Delete(contactClass);
            if (success)
            {
                //success upadte
                MessageBox.Show(" Contact deleted");
                clearField();
                //load data in data grid
                DataTable dt = contactClass.Select();
                dgv_db_data.DataSource = dt;
            }
            else
            {
                //failed to update
                MessageBox.Show("Failed to delete !!!");
                clearField();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void et_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = et_search.Text;

            DataTable dt = new DataTable();
            dt = contactClass.search(keyword);
            dgv_db_data.DataSource = dt;
        }
    }
}
