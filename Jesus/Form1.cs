namespace Jesus //Jesus = good luck charm 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Label und Textbox Eingabe zusammenhang 
        {
            //Add Button 
            dgv.Rows.Add(txtboxName.Text, txtboxAdresse.Text, txtboxAbgabe.Text, txtboxAufgabe.Text, txtboxZeit.Text, txtboxVollständigkeit.Text + "%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Benedict Logo
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgv.CurrentRow.Cells["name"].Value = txtboxName.Text;
            dgv.CurrentRow.Cells["adresse"].Value = txtboxAdresse.Text;
            dgv.CurrentRow.Cells["abgabe"].Value = txtboxAbgabe.Text;
            dgv.CurrentRow.Cells["aufgabe"].Value = txtboxAufgabe.Text;
            dgv.CurrentRow.Cells["zeit"].Value = txtboxZeit.Text;
            dgv.CurrentRow.Cells["Vollständigkeit"].Value = txtboxVollständigkeit.Text + "%";
        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            dgv.Columns.Add(txtboxNameCol.Text, txtboxTextCol.Text);
        }

        private void dgv_SelectionqChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null) 
            {
                txtboxName.Text = dgv.CurrentRow.Cells["name"].Value.ToString();
                txtboxAdresse.Text = dgv.CurrentRow.Cells["adresse"].Value.ToString();
                txtboxAbgabe.Text = dgv.CurrentRow.Cells["abgabe"].Value.ToString();
                txtboxAufgabe.Text = dgv.CurrentRow.Cells["aufgabe"].Value.ToString();
                txtboxZeit.Text = dgv.CurrentRow.Cells["zeit"].Value.ToString();
                txtboxVollständigkeit.Text = dgv.CurrentRow.Cells["Vollständigkeit"].Value.ToString();
            }
        }
    }
}