using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BTB
{
    class MyFunc
    {
        public static float Bs2F(byte b1, byte b2, byte b3, byte b4)
        {
            byte[] bytes = { b1,b2,b3,b4 };
            var v = BitConverter.ToSingle(bytes, 0);
            return v;
        }

        public static byte F2Bi(int index, float value)
        {
            var bytes = BitConverter.GetBytes(value);
            return bytes[index];
        }

        public static UInt32 Bs2U32(byte b1, byte b2, byte b3, byte b4)
        {
            return (UInt32)(b1 + (b2 << 8) + (b3 << 16) + (b4 << 24));
        }

        public static byte U322Bi(int index, UInt32 value)
        {
            UInt32 m = (UInt32)(0xf << (index * 8));
            return (byte)((m & value) >> (index * 8));
        }
    }

    class Array_Interval
    {
        private byte[] array_base;
        private int index_start;
        private int interval_count;
        public void array_set(ref byte[] array, int istart, int count)
        {
            array_base = array;
            index_start = istart;
            interval_count = count;
        }

        public byte this[int i]
        {
            get
            {
                if (i < 0 || i >= interval_count)
                {
                    return 0;
                }
                return array_base[i + index_start];
            }
            set
            {
                if (i < 0 || i >= interval_count)
                    return;
                array_base[i + index_start] = value;
            }
        }
    }

    delegate void FUNC_SetBit(byte x, int i);
    delegate byte FUNC_GetBit();

    //[StructLayout(LayoutKind.Sequential)]
    class APD_Vbr_Test_Control_Byte
    {
        public FUNC_SetBit setkey;
        public FUNC_GetBit getkey;
        public byte Start_Stop_Vbr_test { set { setkey(value, 0); } get { return (byte)((getkey() >> 0) & 1); } }
        public byte Manual_Auto_Control { set { setkey(value, 1); } get { return (byte)((getkey() >> 1) & 1); } }
        public byte Vbt_Test_Done { set { setkey(value, 2); } get { return (byte)((getkey() >> 2) & 1); } }
        public byte Vapd_Setting_Done { set { setkey(value, 3); } get { return (byte)((getkey() >> 3) & 1); } }
        public byte Reserved1 { set { setkey(value, 4); } get { return (byte)((getkey() >> 4) & 0xF); } }
    }

    class LIV_Control_Byte
    {
        public FUNC_SetBit setkey;
        public FUNC_GetBit getkey;
        public byte Manual_Auto_Control { set { setkey(value, 0); } get { return (byte)((getkey() >> 0) & 1); } }
        public byte Start_Stop_LIV { set { setkey(value, 1); } get { return (byte)((getkey() >> 1) & 1); } }
        public byte LIV_Done { set { setkey(value, 2); } get { return (byte)((getkey() >> 2) & 1); } }
        public byte Reserved1 { set { setkey(value, 3); } get { return (byte)((getkey() >> 3) & 0x1F); } }
    }

    /*[StructLayout(LayoutKind.Explicit)]
    public struct BYTE_FLOAT
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] bArray;
        [FieldOffset(0)]
        public float fValue;
    }*/
}

