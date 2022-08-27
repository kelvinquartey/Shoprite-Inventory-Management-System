using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopriteInventoryManagement
{
    public partial class AddUsers : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NII\Documents\InventoryDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        String gender;
        String role;
         


        public AddUsers()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPword_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCpword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCreateUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPword.Checked == true)
            {
                textBoxPword.UseSystemPasswordChar = false;
                textBoxConfirmPword.UseSystemPasswordChar = false;
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void radioButtonSelections()
        {
            if (radioBtnMale.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            if (radioButtonAttendant.Checked == true)
            {
                role = "attendant";
            }
            else
            {
                role = "admin";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            radioButtonSelections();

            try
            {
                if(textBoxPword.Text != textBoxConfirmPword.Text )
                {
                    MessageBox.Show("Password did not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if(MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO UserTb(fullname,dob,gender,telephone,email,id,username,password,role)VALUES(@fullname,@dob,@gender,@telephone,@email,@id,@username,@password,@role)", con);
                    cmd.Parameters.AddWithValue("@fullname", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@dob", textBoxDOB.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@telephone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPword.Text);
                    cmd.Parameters.AddWithValue("@role", role);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("user has been successfully added");
                    Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                ManageUsers mu = new ManageUsers();
                mu.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Clear()
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxID.Clear();
            textBoxUsername.Clear();
            textBoxPword.Clear();
            textBoxConfirmPword.Clear();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
