using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {
        int[] vet = new int[500]; // vetor interno para a animação
        Preenchimento vetor_preencher = new Preenchimento();

        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(Pens.Brown, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) {
            int i = 0;
            int j = vet.Length - 1;
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet,i,j, panel));
        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this, 
                "Prática 5 2022/1 - Métodos de Ordenação\n\n" +
                "Desenvolvido por:\n72200367 - Daniel Batista Miranda\n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Apenas para fins didáticos.", 
                "Sobre o trabalho...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
            string tempFormato = comboBox1.Text;
            if (bgw.IsBusy != true) {
                if(tempFormato == "Aleatorio")Preenchimento.Aleatorio(vet, 300);
                else if (tempFormato == "Crescente") Preenchimento.Crescente(vet);
                else Preenchimento.Decrescente(vet);
                bgw.RunWorkerAsync(a);
            }
            else {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Prática 5 2022/1 - Métodos de Ordenação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Prática 5 2022/1 - Métodos de Ordenação",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) {

            string tempFormato = comboBox1.Text;
            string tempTamanho = comboBox2.Text.Replace(".", "");
            int[] vetor = new int[int.Parse(tempTamanho)];
            if (tempFormato == "Aleatorio") Preenchimento.Aleatorio(vetor, vet.Length);
            else if (tempFormato == "Crescente") Preenchimento.Crescente(vetor);
            else Preenchimento.Decrescente(vetor);
            // TODO (preenchimento inicial deverá ser escolhido pelo usuário)
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vetor.Length + 
                  "\nOrdenação inicial: " + vetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t +"",
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Selecao(vet, panel));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormOrdenacao_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex= 0;
            comboBox2.SelectedIndex = 0;

        }

        private void insercao_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void shellsort_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void heapsort_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void quicksort_Click(object sender, EventArgs e)
        {
        
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length - 1, panel));
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempFormato = comboBox1.Text;
            string tempTamanho = comboBox2.Text.Replace(".", "");
            int[] vetor = new int[int.Parse(tempTamanho)];
            if (tempFormato == "Aleatorio") Preenchimento.Aleatorio(vetor, vet.Length);
            else if (tempFormato == "Crescente") Preenchimento.Crescente(vetor);
            else Preenchimento.Decrescente(vetor);
            // TODO (preenchimento inicial deverá ser escolhido pelo usuário)
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.selecao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vetor.Length +
                  "\nOrdenação inicial: " + vetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t + "",
                  "Estatísticas do Método Seleção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempFormato = comboBox1.Text;
            string tempTamanho = comboBox2.Text.Replace(".", "");
            int[] vetor = new int[int.Parse(tempTamanho)];
            if (tempFormato == "Aleatorio") Preenchimento.Aleatorio(vetor, vet.Length);
            else if (tempFormato == "Crescente") Preenchimento.Crescente(vetor);
            else Preenchimento.Decrescente(vetor);
            // TODO (preenchimento inicial deverá ser escolhido pelo usuário)
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.insercao(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vetor.Length +
                  "\nOrdenação inicial: " + vetor +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t + "",
                  "Estatísticas do Método Inserção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
    }
}
