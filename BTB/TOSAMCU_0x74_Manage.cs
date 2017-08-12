using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB
{
    class TOSAMCU_0x74_Manage
    {
        public byte[] pStrA6 = new byte[256];

        public TOSAMCU_0x74_Manage()
        { }

        //INT8U	FirstByte;						// A6H[0], 1byte
        public int FirstByte_Index { get { return 0; } }
        public byte FirstByte { get { return pStrA6[FirstByte_Index]; } set { pStrA6[FirstByte_Index] = value; } }
        //INT8U Reserved_byte_1;						// A6H[1], 1byte, input
        public int Reserved_byte_1_Index { get { return 1; } }
        public byte Reserved_byte_1 { get { return pStrA6[Reserved_byte_1_Index]; } set { pStrA6[Reserved_byte_1_Index] = value; } }
        /*
         * ...
         * */
        //float	LD_Current_Real;						// A6H[72~75], 4byte, unit V
        public int LD_Current_Real_Index { get { return 72; } }
        public float LD_Current_Real
        {
            get{ return MyFunc.Bs2F(pStrA6[LD_Current_Real_Index], pStrA6[LD_Current_Real_Index + 1], pStrA6[LD_Current_Real_Index + 2], pStrA6[LD_Current_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[LD_Current_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }
        //float	PD_Current_ADC_G_Real;						// A6H[76~79], 4byte, unit V
        public int PD_Current_ADC_G_Real_Index { get { return 76; } }
        public float PD_Current_ADC_G_Real
        {
            get { return MyFunc.Bs2F(pStrA6[PD_Current_ADC_G_Real_Index], pStrA6[PD_Current_ADC_G_Real_Index + 1], pStrA6[PD_Current_ADC_G_Real_Index + 2], pStrA6[PD_Current_ADC_G_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[PD_Current_ADC_G_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }
    }
}
