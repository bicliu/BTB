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

        public static byte F2Bi(int i, float v)
        {
            var bytes = BitConverter.GetBytes(v);
            return bytes[i];
        }
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
