using System.IO.Ports;

namespace SerialExample
{
    public partial class SerialExampleForm : Form
    {
        public SerialExampleForm()
        {
            InitializeComponent();
        }

        SerialPort _serialPort = new SerialPort();
        void SerialPortSetup()
        {
            _serialPort.Close();
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.None;

        }

        void SerialConnect()
        {
            _serialPort.Close();
            _serialPort.Open();

        }

        // Event Handlers Below Here---------------------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SerialPortSetup();
            SerialConnect();
        }
    }
}
