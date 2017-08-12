using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BTB
{
    class APDMCU_0x76_Manage
    {
        public byte[] pStrA6 = new byte[256];

        public APDMCU_0x76_Manage()
        {

        }
        //INT8U	FirstByte;						// A6H[0], 1byte
        public int FirstByte_Index { get { return 0; } }
        public byte FirstByte { get { return pStrA6[FirstByte_Index]; } set { pStrA6[FirstByte_Index] = value; } }
        //INT8U Reserved_byte_1;						// A6H[1], 1byte, input
        public int Reserved_byte_1_Index { get { return 1; } }
        public byte Reserved_byte_1 { get { return pStrA6[Reserved_byte_1_Index]; } set { pStrA6[Reserved_byte_1_Index] = value; } }
        //INT8U	FirmwareVersion;				// A6H[2], 1byte
        public int FirmwareVersion_Index { get { return 2; } }
        public byte FirmwareVersion { get { return pStrA6[FirmwareVersion_Index]; } set { pStrA6[FirmwareVersion_Index] = value; } }
        //INT8U	CPLD_Version;					// A6H[3], 1byte, input
        public int CPLD_Version_Index { get { return 3; } }
        public byte CPLD_Version { get { return pStrA6[CPLD_Version_Index]; } set { pStrA6[CPLD_Version_Index] = value; } }
        //INT16U	Core_Voltage;					// A6H[4~5], 2byte
        public int Core_Voltage_Index { get { return 4; } }
        public ushort Core_Voltage
        {
            get { return (ushort)(pStrA6[Core_Voltage_Index] + (pStrA6[Core_Voltage_Index + 1] << 8)); }
            set { pStrA6[Core_Voltage_Index] = (byte)value; pStrA6[Core_Voltage_Index + 1] = (byte)(value >> 8); }
        }
        //INT16S	Core_Temperature;				// A6H[6~7], 2byte
        public int Core_Temperature_Index { get { return 6; } }
        public short Core_Temperature
        {
            get { return (short)(pStrA6[Core_Temperature_Index] + (pStrA6[Core_Temperature_Index + 1] << 8)); }
            set { pStrA6[Core_Temperature_Index] = (byte)value; pStrA6[Core_Temperature_Index + 1] = (byte)(value >> 8); }
        }
        //INT16S	Core_5V_Voltage;			// A6H[8~9], 2byte
        public int Core_5V_Voltage_Index { get { return 8; } }
        public short Core_5V_Voltage
        {
            get { return (short)(pStrA6[Core_5V_Voltage_Index] + (pStrA6[Core_5V_Voltage_Index + 1] << 8)); }
            set { pStrA6[Core_5V_Voltage_Index] = (byte)value; pStrA6[Core_5V_Voltage_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  ADC_VAPD_nA_ADC_CH1;						// A6H[10~11], 2byte //CASE ADC value, case voltage
        public int ADC_VAPD_nA_ADC_CH1_Index { get { return 10; } }
        public ushort ADC_VAPD_nA_ADC_CH1
        {
            get { return (ushort)(pStrA6[ADC_VAPD_nA_ADC_CH1_Index] + (pStrA6[ADC_VAPD_nA_ADC_CH1_Index + 1] << 8)); }
            set { pStrA6[ADC_VAPD_nA_ADC_CH1_Index] = (byte)value; pStrA6[ADC_VAPD_nA_ADC_CH1_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  ADC1_33V;						// A6H[12~13], 2byte //1LSB = 0.1[mV]
        public int ADC1_33V_Index { get { return 12; } }
        public ushort ADC1_33V
        {
            get { return (ushort)(pStrA6[ADC1_33V_Index] + (pStrA6[ADC1_33V_Index + 1] << 8)); }
            set { pStrA6[ADC1_33V_Index] = (byte)value; pStrA6[ADC1_33V_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U ADC2_VAPD_V_ADC;				// A6H[14~15], 2byte 
        public int ADC2_VAPD_V_ADC_Index { get { return 14; } }
        public ushort ADC2_VAPD_V_ADC
        {
            get { return (ushort)(pStrA6[ADC2_VAPD_V_ADC_Index] + (pStrA6[ADC2_VAPD_V_ADC_Index + 1] << 8)); }
            set { pStrA6[ADC2_VAPD_V_ADC_Index] = (byte)value; pStrA6[ADC2_VAPD_V_ADC_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  ADC3_VAPD_I_G_ADC;			// A6H[16~17], 2byte  
        public int ADC3_VAPD_I_G_ADC_Index { get { return 16; } }
        public ushort ADC3_VAPD_I_G_ADC
        {
            get { return (ushort)(pStrA6[ADC3_VAPD_I_G_ADC_Index] + (pStrA6[ADC3_VAPD_I_G_ADC_Index + 1] << 8)); }
            set { pStrA6[ADC3_VAPD_I_G_ADC_Index] = (byte)value; pStrA6[ADC3_VAPD_I_G_ADC_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  ADC4_VAPD_I_S_ADC;				// A6H[18~19], 2byte
        public int ADC4_VAPD_I_S_ADC_Index { get { return 18; } }
        public ushort ADC4_VAPD_I_S_ADC
        {
            get { return (ushort)(pStrA6[ADC4_VAPD_I_S_ADC_Index] + (pStrA6[ADC4_VAPD_I_S_ADC_Index + 1] << 8)); }
            set { pStrA6[ADC4_VAPD_I_S_ADC_Index] = (byte)value; pStrA6[ADC4_VAPD_I_S_ADC_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  DAC_VAPD_SET;					// A6H[20~21], 2byte
        public int DAC_VAPD_SET_Index { get { return 20; } }
        public ushort DAC_VAPD_SET
        {
            get { return (ushort)(pStrA6[DAC_VAPD_SET_Index] + (pStrA6[DAC_VAPD_SET_Index + 1] << 8)); }
            set { pStrA6[DAC_VAPD_SET_Index] = (byte)value; pStrA6[DAC_VAPD_SET_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  DAC1_33V;						// A6H[22~23], 2byte //VOA DAC value
        public int DAC1_33V_Index { get { return 22; } }
        public ushort DAC1_33V
        {
            get { return (ushort)(pStrA6[DAC1_33V_Index] + (pStrA6[DAC1_33V_Index + 1] << 8)); }
            set { pStrA6[DAC1_33V_Index] = (byte)value; pStrA6[DAC1_33V_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U DAC2;							// A6H[24~25], 2byte //33V DAC value
        public int DAC2_Index { get { return 24; } }
        public ushort DAC2
        {
            get { return (ushort)(pStrA6[DAC2_Index] + (pStrA6[DAC2_Index + 1] << 8)); }
            set { pStrA6[DAC2_Index] = (byte)value; pStrA6[DAC2_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  DAC3;							// A6H[26~27], 2byte //USB DAC value
        public int DAC3_Index { get { return 26; } }
        public ushort DAC3
        {
            get { return (ushort)(pStrA6[DAC3_Index] + (pStrA6[DAC3_Index + 1] << 8)); }
            set { pStrA6[DAC3_Index] = (byte)value; pStrA6[DAC3_Index + 1] = (byte)(value >> 8); }
        }
        //INT8U   RX_SHDN_Control;			// A6H[28], 1byte, if 0x01, APD on, or else would be off
        public int RX_SHDN_Control_Index { get { return 28; } }
        public byte RX_SHDN_Control { get { return pStrA6[RX_SHDN_Control_Index]; } set { pStrA6[RX_SHDN_Control_Index] = value; } }
        //INT8U   APD_VBR_Target_Current;		// A6H[29], 1byte, uA as the target
        public int APD_VBR_Target_Current_Index { get { return 29; } }
        public byte APD_VBR_Target_Current { get { return pStrA6[APD_VBR_Target_Current_Index]; } set { pStrA6[APD_VBR_Target_Current_Index] = value; } }
        //INT8U Rerserved30;					// A6H[30], 1byte
        public int Rerserved30_Index { get { return 30; } }
        public byte Rerserved30 { get { return pStrA6[Rerserved30_Index]; } set { pStrA6[Rerserved30_Index] = value; } }
        //struct  APD_Vbr_Test_Control_Byte sAPD_Vbr_Test_Control_Byte;					// A6H[31], 1byte
        public int sAPD_Vbr_Test_Control_Byte_Index { get { return 31; } }
        /*public APD_Vbr_Test_Control_Byte sAPD_Vbr_Test_Control_Byte
        {
            get { return pStrA6[sAPD_Vbr_Test_Control_Byte_Index]; }
            set { pStrA6[sAPD_Vbr_Test_Control_Byte_Index] = value.Ctrl_Byte; }
        }*/
        /*
         * ...
         * */
        //float	VAPD_I_G_Real;						// A6H[68~71], 4byte, unit V
        public int VAPD_I_G_Real_Index { get { return 68; } }
        public float VAPD_I_G_Real
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_I_G_Real_Index], pStrA6[VAPD_I_G_Real_Index + 1], pStrA6[VAPD_I_G_Real_Index + 2], pStrA6[VAPD_I_G_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_I_G_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }
        //float	VAPD_I_S_Real;						// A6H[72~75], 4byte, unit V
        public int VAPD_I_S_Real_Index { get { return 72; } }
        public float VAPD_I_S_Real
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_I_S_Real_Index], pStrA6[VAPD_I_S_Real_Index + 1], pStrA6[VAPD_I_S_Real_Index + 2], pStrA6[VAPD_I_S_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_I_S_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct APD_Vbr_Test_Control_Byte
    {
        /*byte Start_Stop_Vbr_test:1;    //Auto Clear after the Vbr test is stoped. 1: start Vbr, and will be auto clear to zero when Vbr test starts.
        byte Manual_Auto_Control :1 ;
        byte Vbt_Test_Done:1;  //done: 0; 1: is in process
        byte Vapd_Setting_Done :1;
        byte Reserved1:4;*/
        private byte  key;
        public byte Start_Stop_Vbr_test { set { key |= (byte)((value & 1) << 0); } get { return (byte)((key >> 0) & 1); } }
        public byte Manual_Auto_Control { set { key |= (byte)((value & 1) << 1); } get { return (byte)((key >> 1) & 1); } }
        public byte Vbt_Test_Done { set { key |= (byte)((value & 1) << 2); } get { return (byte)((key >> 0) & 2); } }
        public byte Vapd_Setting_Done { set { key |= (byte)((value & 1) << 3); } get { return (byte)((key >> 3) & 1); } }
        public byte Reserved1 { set { key |= (byte)((value & 0xF) << 4); } get { return (byte)((key >> 4) & 0xF); } }
        public byte Ctrl_Byte { get { return key; } }
    }

}
