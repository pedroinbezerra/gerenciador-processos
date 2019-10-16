using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Gerenciador_de_processos
{
    public partial class Form1 : Form
    {
        bool startStop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void ButtonMonitorar_Click(object sender, EventArgs e)
        {

            if (startStop == false)
            {
                startStop = true;
                timer1.Start();
                buttonMonitorar.Text = "Parar";
                numericUpDownNMaximoDeThreads.Enabled = false;
                textBoxProcesso.Enabled = false;
            }
            else
            {
                startStop = false;
                timer1.Stop();
                buttonMonitorar.Text = "Monitorar";
                numericUpDownNMaximoDeThreads.Enabled = true;
                textBoxProcesso.Enabled = true;
            }

        }

        decimal encerrados = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {   
            listBoxProcessos.Items.Clear();

            Process[] instancias = Process.GetProcessesByName(textBoxProcesso.Text);

            if (instancias.Length > numericUpDownNMaximoDeThreads.Value)
            {

                encerrados += numericUpDownNMaximoDeThreads.Value + 1;
                qtdProcessosEncerrados.Text = Convert.ToString(encerrados);

                foreach (Process process in instancias)
                {
                    process.Kill();
                }
                
            }

            labelQtdProcessos.Text = Convert.ToString(instancias.Length);

            for (int i = 0; i < instancias.Length; i++)
            {
                listBoxProcessos.Items.Add(instancias[i].ProcessName);
            }

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (textBoxProcesso.TextLength <= 0 || numericUpDownNMaximoDeThreads.Value < 1)
            {
                buttonMonitorar.Enabled = false;
            }
            else
            {
                buttonMonitorar.Enabled = true;
            }
        }
    }
}
