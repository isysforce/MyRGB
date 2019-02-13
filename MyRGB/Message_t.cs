using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyRGB
{
    public enum Command_t : byte
    {
        InvalidMessage = 0,
        InvalidRequest,
        Ping,
        Pong,
        SetColor,
        SetColorAll,
        SetMode,
        ClearColor
    };

    [StructLayout(LayoutKind.Explicit)]
    unsafe struct Color_t
    {
        [FieldOffset(0)]
        public byte R;

        [FieldOffset(1)]
        public byte G;

        [FieldOffset(2)]
        public byte B;

        public override string ToString()
        {
            return $"R: {R} G: {G} B: {B}";
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    unsafe struct Message_t
    {
        public static ushort MESSAGE_MAGIC = 0xBEEF;

        [FieldOffset(0)]
        public ushort Magic;

        [FieldOffset(2)]
        public Command_t Command;

        [FieldOffset(3)]
        public ushort Zone;

        [FieldOffset(5)]
        public ushort Parameter0;

        [FieldOffset(7)]
        public ushort Parameter1;

        [FieldOffset(9)]
        public Color_t Color;

        //[FieldOffset(3)]
        //public byte FadeSpeed;

        //[FieldOffset(3)]
        //public byte R;

        //[FieldOffset(4)]
        //public byte G;

        //[FieldOffset(5)]
        //public byte B;

        public static bool MessageReady(SerialPort port)
        {
            Console.WriteLine($"BytesToRead: {port.BytesToRead}, {Marshal.SizeOf(typeof(Message_t))}");
            //for(int i = 0; i < port.BytesToRead; i++)
            //{
            //    Console.WriteLine($"{port.ReadByte():X2}");
            //}
            return port.BytesToRead >= Marshal.SizeOf(typeof(Message_t));
        }

        public unsafe static void ReadMessage(SerialPort port, ref Message_t msg)
        {
            byte[] data = new byte[Marshal.SizeOf(typeof(Message_t))];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)port.ReadByte();
            }

            fixed (byte* b = data)
            {
                msg = (Message_t)Marshal.PtrToStructure((IntPtr)b, typeof(Message_t));
            }
        }

        public unsafe static void WriteMessage(SerialPort port, ref Message_t msg)
        {
            byte[] data = new byte[Marshal.SizeOf(typeof(Message_t))];
            fixed (byte* b = data)
            {
                Marshal.StructureToPtr(msg, (IntPtr)b, true);
            }
            //Console.WriteLine($"Sending {data.Length} bytes..");
            //foreach (byte d in data)
            //{
            //    Console.Write($"{d:X2} ");
            //}
            //Console.WriteLine();
            try
            {
                port.Write(data, 0, data.Length);
            }
            catch
            {

            }

            //Console.WriteLine("[Success]");
        }
    };
}
