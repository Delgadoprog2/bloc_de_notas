namespace Prog2BlocNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void aDELANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cOPIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pEGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        

        private void sELECTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void bORRARTODOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void cOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorFuente = colorDialog1.ShowDialog();

            if (colorFuente == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fUENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estiloFuente = fontDialog1.ShowDialog();
            if (estiloFuente == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void cOLORFONDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorFondo = new ColorDialog();
            if (colorFondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorFondo.Color;
            }
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StringReader abrir = new System.IO.StringReader(openFileDialog1.FileName);
            richTextBox1.Text = abrir.ReadToEnd();
            abrir.Close();
        }

        

        private void gUARDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.StreamWriter guardar = new System.IO.StreamWriter(saveFileDialog1.FileName);
            guardar.WriteLine(richTextBox1.Text);
            guardar.Close();
        }

        private void gUARDARCOMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar_como = new SaveFileDialog();
            System.IO.StreamWriter mystreamWriter = null;
            guardar_como.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|All files";
            guardar_como.CheckFileExists = true;
            guardar_como.Title = "Guardar Como";
            guardar_como.ShowDialog(this);
            try
            {
                mystreamWriter = System.IO.File.AppendText(guardar_como.FileName);
                mystreamWriter.Write(richTextBox1.Text);
                mystreamWriter.Flush();
            }
            catch (Exception)
            {

            }

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}