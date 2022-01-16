using Microsoft.Office.Interop.Word;

namespace FileReader
{
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            richTextBoxFileData.Clear();
            txtPath.Clear();

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
                Microsoft.Office.Interop.Word.Application app = new();
                Document doc = app.Documents.Open(txtPath.Text);
                string text = doc.Content.Text;
                richTextBoxFileData.Text = text;
                app.Quit();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            richTextBoxFileData.Clear();    
            txtPath.Clear();    
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }
    }
}