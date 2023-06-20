using System;
using System.Diagnostics;
using System.IO.Ports;

namespace proyectoEDII
{
    public partial class Form1 : Form
    {
        //SerialPort _puertoEntrada = new SerialPort();
        SerialPort puertoSalida;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializar();
        }

        private void inicializar()
        {
            //Coloca los puertos de salida/escritura y entrada/lectura
            var puertos = SerialPort.GetPortNames();

            this.txtPuertos.Items.Clear();
            this.txtPuertos.Items.AddRange(puertos);
            
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                string indata = sp.ReadExisting();
                if (indata == "1" || indata == "2" || indata == "3" || indata == "4")
                {
                    this.txtPisoActual.Text = indata;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo leer el puerto {sp.PortName}:{ex.Message}");
            }
        }

        private void btnPiso1_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("A");
        }

        private void btnPiso2_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("B");
        }

        private void btnPiso3_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("C");
        }

        private void btnPiso4_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("D");
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("E");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("F");
        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            puertoSalida.Write("O");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (puertoSalida.IsOpen)
            {
                puertoSalida.Close();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            puertoSalida = new SerialPort();
            puertoSalida.PortName = txtPuertos.Text;
            puertoSalida.BaudRate = 9600;
            puertoSalida.Open();
            puertoSalida.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
    }
}