using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unclassified.Drawing;
using System.Threading;

namespace MyRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource aaaaa = new BindingSource();
        static Message_t msgOut = new Message_t();

        private void Form1_Load(object sender, EventArgs e)
        {
            msgOut.Magic = Message_t.MESSAGE_MAGIC;
            Thread communicateThread = new Thread(CommunicateTask);

            for (int i = 0; i < 8; i++)
            {
                Zone_t zone = new Zone_t();
                ZoneMode_t mode = new ZoneMode_t();

                mode.Name = Mode_t.Theaterchase;

                mode.StaticColor = new ColorWheel_t();
                mode.TheaterChaseColor = new ColorWheel_t();
                mode.WipeColor = new ColorWheel_t();

                zone.ID = i + 1;
                zone.Name = $"Zone {zone.ID}";
                zone.Mode = mode;

                RadioButton radio = new RadioButton();
                radio.Name = $"zoneRadio{i + 1}";
                radio.Text = zone.Name;
                radio.AutoSize = true;
                radio.CheckedChanged += ZoneChanged;
                radio.Tag = zone;

                if (i == 0) radio.Checked = true;

                flowLayoutPanel1.Controls.Add(radio);
            }

            //GetArduinoPort();
            communicateThread.Start();

            //modeCombo.SelectedIndex = 0;
            //rgbModeCombo.SelectedIndex = 0;

        }

        private static Zone_t currentZone = null;

        private void ZoneChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                currentZone = radio.Tag as Zone_t;
                tabControl1.SelectedIndex = (int)currentZone.Mode.Name;

                staticColorWheel.DataBindings.Clear();
                staticColorWheel.DataBindings.Add(new Binding("HSL", currentZone.Mode.StaticColor, "HSL", false, DataSourceUpdateMode.OnPropertyChanged));

                theaterChaseDelayNum.DataBindings.Clear();
                theaterChaseDelayNum.DataBindings.Add(new Binding("Value", currentZone.Mode, "TheaterChaseDelay"));

                theaterColorWheel.DataBindings.Clear();
                theaterColorWheel.DataBindings.Add(new Binding("HSL", currentZone.Mode.TheaterChaseColor, "HSL", false, DataSourceUpdateMode.OnPropertyChanged));


                var theaterChaseStaticBinding = new Binding("Checked", currentZone.Mode, "TheaterChaseRainbow");
                theaterChaseStaticBinding.Format += (s, args) => args.Value = ((bool)args.Value) == false;
                theaterChaseStaticBinding.Parse += (s, args) => args.Value = !(bool)args.Value;
                theaterChaseStaticRadio.DataBindings.Clear();
                theaterChaseStaticRadio.DataBindings.Add(theaterChaseStaticBinding);


                theaterChaseRainbowRadio.DataBindings.Clear();
                theaterChaseRainbowRadio.DataBindings.Add(new Binding("Checked", currentZone.Mode, "TheaterChaseRainbow"));

                rainbowDelayNum.DataBindings.Clear();
                rainbowDelayNum.DataBindings.Add(new Binding("Value", currentZone.Mode, "RainbowDelay"));

                rainbowCycleCb.DataBindings.Clear();
                rainbowCycleCb.DataBindings.Add(new Binding("Checked", currentZone.Mode, "RainbowCycle"));

                wipeColorWheel.DataBindings.Clear();
                wipeColorWheel.DataBindings.Add(new Binding("HSL", currentZone.Mode.WipeColor, "HSL", false, DataSourceUpdateMode.OnPropertyChanged));

                wipeDelayNum.DataBindings.Clear();
                wipeDelayNum.DataBindings.Add(new Binding("Value", currentZone.Mode, "WipeDelay"));
            }
        }



        private void colorWheel1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetArduinoPort();
        }

        static void SendData()
        {
            if (p != null && p.IsOpen)
            {
                Message_t.WriteMessage(p, ref msgOut);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZoneMode_t mode = currentZone.Mode as ZoneMode_t;
            mode.Name = Mode_t.Static;

            msgOut.Command = Command_t.SetMode;
            msgOut.Zone = (ushort)currentZone.ID;
            msgOut.Parameter0 = 0;
            msgOut.Parameter1 = (ushort)((ushort)mode.Name << 8);

            mode.StaticColor.ToColor_t(ref msgOut.Color);

            SendData();
        }

        private void staticColorWheel_HSLChanged(object sender, EventArgs e)
        {
            if (staticLiveCheck.Checked)
            {
                ZoneMode_t mode = currentZone.Mode as ZoneMode_t;
                mode.Name = Mode_t.Static;

                msgOut.Command = Command_t.SetMode;
                msgOut.Zone = (ushort)currentZone.ID;
                msgOut.Parameter0 = 0;
                msgOut.Parameter1 = (ushort)((ushort)mode.Name << 8);

                mode.StaticColor.ToColor_t(ref msgOut.Color);

                SendData();
                Console.WriteLine(mode.StaticColor.ToString());
            }
        }

        private void applyMode2Btn_Click(object sender, EventArgs e)
        {
            ZoneMode_t mode = currentZone.Mode as ZoneMode_t;
            mode.Name = Mode_t.Theaterchase;

            msgOut.Command = Command_t.SetMode;
            msgOut.Zone = (ushort)currentZone.ID;
            msgOut.Parameter0 = (ushort)mode.TheaterChaseDelay;
            msgOut.Parameter1 = (ushort)((ushort)mode.Name << 8 | (mode.TheaterChaseRainbow ? 1:0));

            mode.TheaterChaseColor.ToColor_t(ref msgOut.Color);
            
            SendData();
        }

        private void rainbowApplyBtn_Click(object sender, EventArgs e)
        {
            ZoneMode_t mode = currentZone.Mode as ZoneMode_t;
            mode.Name = Mode_t.Rainbow;
            msgOut.Zone = (ushort)currentZone.ID;
            msgOut.Command = Command_t.SetMode;

            msgOut.Parameter0 = (ushort)mode.RainbowDelay;
            msgOut.Parameter1 = (ushort)((ushort)mode.Name << 8 | (mode.RainbowCycle ? 1 : 0));

            SendData();
        }

        private void wipeApply_Click(object sender, EventArgs e)
        {

            ZoneMode_t mode = currentZone.Mode as ZoneMode_t;

            mode.Name = Mode_t.Wipe;

            msgOut.Command = Command_t.SetMode;
            msgOut.Zone = (ushort)currentZone.ID;
            msgOut.Parameter0 = (ushort)mode.WipeDelay;
            msgOut.Parameter1 = (ushort)((ushort)mode.Name << 8 | 0);
            mode.WipeColor.ToColor_t(ref msgOut.Color);
            SendData();

        }

        private void audioApplyBtn_Click(object sender, EventArgs e)
        {
            ZoneMode_t mode = currentZone.Mode as ZoneMode_t;

            mode.Name = Mode_t.Audio;

            msgOut.Command = Command_t.SetMode;
            msgOut.Zone = (ushort)currentZone.ID;
            //msgOut.Parameter0 = (ushort)mode.WipeDelay;
            msgOut.Parameter1 = (ushort)((ushort)mode.Name << 8 | 0);
            //mode.WipeColor.ToColor_t(ref msgOut.Color);
            SendData();
        }

        private void clearColorBtn_Click(object sender, EventArgs e)
        {
            msgOut.Command = Command_t.ClearColor;
            if (p != null && p.IsOpen)
            {
                Message_t.WriteMessage(p, ref msgOut);
            }
        }


        static void CommunicateTask()
        {
            Message_t msgOut = new Message_t();
            msgOut.Magic = Message_t.MESSAGE_MAGIC;
            msgOut.Command = Command_t.SetColorAll;
            while (true)
            {
                if (currentZone.Mode != null)
                {
                    ZoneMode_t mode = currentZone.Mode as ZoneMode_t;
                    mode.Name = Mode_t.Static;

                    msgOut.Command = Command_t.SetMode;
                    msgOut.Parameter1 = (ushort)((ushort)currentZone.ID << 8 | (byte)mode.Name);

                    mode.StaticColor.ToColor_t(ref msgOut.Color);

                    //SendData();
                }
            
                

                


                Thread.Sleep(500);
            }
        }


        static SerialPort p = null;
        string port = "COM10";
        private void button1_Click(object sender, EventArgs e)
        {
            if (p == null)
            {
                p = new SerialPort(port, 9600);
                p.WriteTimeout = 100;
                p.DtrEnable = false;
                try
                {
                    Console.Write($"Open {port}...");
                    p.Open();
                    Console.WriteLine($"[Success]");
                    button1.Text = "Disconnect";
                }
                catch
                {
                    Console.WriteLine($"[Fail!]");
                    try
                    {
                        p.Close();
                    }
                    catch
                    {

                    }
                    p = null;
                }
            }
            else
            {
                button1.Text = "Connect";
                try
                {
                    p.Close();
                }
                catch
                {

                }
                p = null;
            }

        }

        private static SerialPort GetArduinoPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                if (port != "COM12") continue;
                SerialPort p = new SerialPort(port, 9600);
                p.DtrEnable = false;
                //p.WriteTimeout = 1000;
                //Prepare messages
                Message_t msgIn = new Message_t();
                //Message_t msgOut = new Message_t();
                msgOut.Magic = Message_t.MESSAGE_MAGIC;
                msgOut.Command = Command_t.Ping;

                try
                {
                    try
                    {
                        p.Close();
                    }
                    catch
                    {

                    }
                    Console.Write($"Open {port}...");
                    p.Open();
                    Console.WriteLine($"[Success]");
                    //Write ping-message
                    Message_t.WriteMessage(p, ref msgOut);
                    //Console.WriteLine($"Send ping...");

                    //Wait about a second for the arduino to reply
                    Thread.Sleep(1000);

                    //No response within a second, go check the next port
                    if (!Message_t.MessageReady(p))
                    {
                        Console.WriteLine($"No response!");
                        try
                        {
                            p.Close();
                        }
                        catch
                        {

                        }
                        continue;

                    }

                    //Read message from serial, check for valid magic and reponse
                    Message_t.ReadMessage(p, ref msgIn);
                    if (msgIn.Magic != Message_t.MESSAGE_MAGIC)
                    {
                        Console.WriteLine($"Invalid Megic!");
                        try
                        {
                            p.Close();
                        }
                        catch
                        {

                        }
                        continue;
                    }

                    if (msgIn.Command != Command_t.Pong)
                    {
                        Console.WriteLine($"Response error: {msgIn.Command}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Response OK: {msgIn.Command}");
                    }

                    return p;
                }
                catch
                {
                    Console.WriteLine($"[Fail!]");
                    //Close port in case we ran into any exception (should never happen though)
                    //p.Close();
                }
                try
                {
                    p.Close();
                }
                catch
                {

                }

            }
            return null;
        }

        
    }

}
