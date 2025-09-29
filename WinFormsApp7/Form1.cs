namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
         
        }
        private void UpdateGrid()
        {
            dgvDictionary.Rows.Clear();
            for (int i = 0; i < Program.words.Count; i++)
                dgvDictionary.Rows.Add(Program.words[i], Program.meanings[i]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Program.words.Add(f.txtWord.Text.Trim());
                Program.meanings.Add(f.txtMeaning.Text.Trim());
                UpdateGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDictionary.CurrentRow != null)
            {
                int i = dgvDictionary.CurrentRow.Index;
                Program.words.RemoveAt(i);
                Program.meanings.RemoveAt(i);
                UpdateGrid();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower(); 

            dgvDictionary.Rows.Clear(); 

            for (int i = 0; i < Program.words.Count; i++)
            {
                if (Program.words[i].ToLower().Contains(searchText))
                {
                    dgvDictionary.Rows.Add(Program.words[i], Program.meanings[i]);
                }
            }

            if (dgvDictionary.Rows.Count == 0)
            {
                MessageBox.Show("Слів немає'");
            }
        }

    }
}
