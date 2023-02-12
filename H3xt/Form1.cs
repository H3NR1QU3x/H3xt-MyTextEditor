using ModoEscuro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace H3xt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetColor();
        }

        private void SetColor()
        {
            richTextBox1.BackColor = ControladorDarkMode.corfundo;
            richTextBox1.ForeColor = ControladorDarkMode.corfonte;
            menuStrip1.BackColor = ControladorDarkMode.corpanel;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files |*.txt";
            ofd.Title = "Open a file...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files |*.txt";
            svf.Title = "Open a file...";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }


        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("H3xt is a very simple .txt editor. Application made just to learn how to use C#");
        }

        private void modoEscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControladorDarkMode.TrocarModo();
            SetColor();
        }

        private void personalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Editor de Texto feito por Henrique Milheiro (H3nr1qu3x)");
        }

        private void páginaNoGitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/H3NR1QU3x?tab=repositories");
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://h3nr1qu3x.github.io/website/");
        }

        private void sobreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editor de Texto feito por Henrique Milheiro (H3nr1qu3x)");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/H3NR1QU3x?tab=repositories");
        }

        private void websiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://h3nr1qu3x.github.io/website/");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void homemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SelectVoiceByHints(VoiceGender.Male);
            voz.SpeakAsync(richTextBox1.Text);
        }

        private void mulherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SelectVoiceByHints(VoiceGender.Female);
            voz.SpeakAsync(richTextBox1.Text);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) ;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
