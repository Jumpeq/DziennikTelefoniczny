using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
namespace DziennikTelefoniczny
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.DziennikTelefoniczny' table. You can move, or remove it, as needed.
            this.dziennikTelefonicznyTableAdapter.Fill(this.appData.DziennikTelefoniczny);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtTelefon.Enabled = value;
            txtImie.Enabled = value;
            txtEmail.Enabled = value;
            txtAdres.Enabled = value;
        }
        private void txtTelefon_Click(object sender, EventArgs e)
        {

        }

        private void Nowy_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.DziennikTelefoniczny.AddDziennikTelefonicznyRow(appData.DziennikTelefoniczny.NewDziennikTelefonicznyRow());
                dziennikTelefonicznyBindingSource.MoveLast();
                txtTelefon.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.DziennikTelefoniczny.RejectChanges();
            }
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtTelefon.Focus();
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            Edit(false);
            dziennikTelefonicznyBindingSource.ResetBindings(false);
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                dziennikTelefonicznyBindingSource.EndEdit();
                dziennikTelefonicznyTableAdapter.Update(appData.DziennikTelefoniczny);
                dataGridView1.Refresh();
                txtTelefon.Focus();
                MessageBox.Show("Twoje dane zostały zapisane pomyślnie.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.DziennikTelefoniczny.RejectChanges();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13) //enter
            {
                if(MessageBox.Show("Czy jesteś pewien by usunąć ten zapis?","Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    dziennikTelefonicznyBindingSource.RemoveCurrent();
                }
            }
        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Czy jesteś pewien by usunąć ten zapis?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dziennikTelefonicznyBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
