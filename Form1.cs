using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_noelDOM
{
    public partial class GUI : Form
    {
        private SerialPort _serialPort;
        private delegate void SetTextDeleg(string text);

        public GUI()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "115200"; /* Default Baudrate */
            Label_pos.Text = "0";
            Btn_conect.Enabled = false;
            Track_Bar_Servo.Enabled = false;
            btn_send_data.Enabled = false;
        }

        private void Btn_load_porst_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); 
            string[] serial_ports = SerialPort.GetPortNames(); 

            foreach (string port in serial_ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.Text = port;
            }
            Btn_conect.Enabled = true;
        }

        private void Btn_conect_Click(object sender, EventArgs e)
        {
            if (Btn_conect.Text == "Connect")
            {
                Btn_conect.Text = "Disconnect";
                _serialPort = new SerialPort(comboBox1.Text, Convert.ToInt32(comboBox2.Text), Parity.None, 8, StopBits.One);
                _serialPort.Handshake = Handshake.None;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(Serial_data);
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 10;
                try
                {
                    _serialPort.Open();
                    Track_Bar_Servo.Enabled = true;
                    btn_send_data.Enabled = true;

                }
                catch (Exception)
                {
                    Btn_conect.Text = "Connect";
                    MessageBox.Show("Error: " + comboBox1.Text + " (Port busy)");
                 
                }

            }
            else if (Btn_conect.Text == "Disconnect")
            {
                Btn_conect.Text = "Connect";
                _serialPort.Close();
            }
        }

        private void Serial_data(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1);

            try
            {

             
                string data = _serialPort.ReadLine();
                this.BeginInvoke(new SetTextDeleg(Gui_data), new object[] { data });

            }

            catch (Exception) /* Serial error handler */
            {

            }
        }

        private void Gui_data(string data)
        {
            Console.Write(data);
      
        }

        private void btn_send_data_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(Text_box_send_data.Text);
        }

        private void Track_Bar_Servo_ValueChanged(object sender, EventArgs e)
        {
            Label_pos.Text = Track_Bar_Servo.Value.ToString();
            _serialPort.WriteLine(Track_Bar_Servo.Value.ToString());
        }
    }
}
