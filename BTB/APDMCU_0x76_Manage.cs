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
            vendorPN.array_set(ref pStrA6, vendorPN_Index, 16);
            vendorSN.array_set(ref pStrA6, vendorSN_Index, 16);
            Reserved164to179.array_set(ref pStrA6, Reserved164to179_Index, 14);
            Reserved188to255.array_set(ref pStrA6, Reserved188to255_Index, 36);
            Reserved49to63.array_set(ref pStrA6, Reserved49to63_Index, 15);
            Reserved90to122.array_set(ref pStrA6, Reserved90to122_Index, 33);
            sAPD_Vbr_Test_Control_Byte.getkey = new FUNC_GetBit(sAPD_Vbr_Test_Control_Byte_Get);
            sAPD_Vbr_Test_Control_Byte.setkey = new FUNC_SetBit(sAPD_Vbr_Test_Control_Byte_setbit);
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
        public APD_Vbr_Test_Control_Byte sAPD_Vbr_Test_Control_Byte = new APD_Vbr_Test_Control_Byte();
        /*public byte sAPD_Vbr_Test_Control_Byte
        {
            get { return pStrA6[sAPD_Vbr_Test_Control_Byte_Index]; }
            set { pStrA6[sAPD_Vbr_Test_Control_Byte_Index] = value; }
        }*/
        private void sAPD_Vbr_Test_Control_Byte_setbit(byte x, int i)
        {
            if (i < 0 || i > 4)
                return;
            if (i < 4)
            {
                pStrA6[sAPD_Vbr_Test_Control_Byte_Index] &= (byte)(~(1 << i));
                pStrA6[sAPD_Vbr_Test_Control_Byte_Index] |= (byte)((x & 1) << i);
            }
            else
            {
                pStrA6[sAPD_Vbr_Test_Control_Byte_Index] &= (byte)(~(0xF << i));
                pStrA6[sAPD_Vbr_Test_Control_Byte_Index] |= (byte)((x & 0xF) << i);
            }
        }
        private byte sAPD_Vbr_Test_Control_Byte_Get() { return pStrA6[sAPD_Vbr_Test_Control_Byte_Index]; }

        //INT8U	Vbr_test_STEP_LSB;					//  A6H[32]for example: 54LSB is about 1V
        public int Vbr_test_STEP_LSB_Index { get { return 32; } }
        public byte Vbr_test_STEP_LSB { get { return pStrA6[Vbr_test_STEP_LSB_Index]; } set { pStrA6[Vbr_test_STEP_LSB_Index] = value; } }

        //INT8U	Enable_Normal_APD_Voltage;						// A6H[33] is reserved 
        public int Enable_Normal_APD_Voltage_Index { get { return 33; } }
        public byte Enable_Normal_APD_Voltage { get { return pStrA6[Enable_Normal_APD_Voltage_Index]; } set { pStrA6[Enable_Normal_APD_Voltage_Index] = value; } }

        //INT16U	Vbr_test_Current_Limitation;		//  A6H[34~35] ADC value from calibration data, default value is 0x0A
        public int Vbr_test_Current_Limitation_Index { get { return 34; } }
        public ushort Vbr_test_Current_Limitation
        {
            get { return (ushort)(pStrA6[Vbr_test_Current_Limitation_Index] + (pStrA6[Vbr_test_Current_Limitation_Index + 1] << 8)); }
            set { pStrA6[Vbr_test_Current_Limitation_Index] = (byte)value; pStrA6[Vbr_test_Current_Limitation_Index + 1] = (byte)(value >> 8); }
        }

        //float       APD_Voltage_Target;					//  A6H[36~39] the LIV start current setting, float
        public int APD_Voltage_Target_Index { get { return 36; } }
        public float APD_Voltage_Target
        {
            get { return MyFunc.Bs2F(pStrA6[APD_Voltage_Target_Index], pStrA6[APD_Voltage_Target_Index + 1], pStrA6[APD_Voltage_Target_Index + 2], pStrA6[APD_Voltage_Target_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[APD_Voltage_Target_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //INT16U   Vapd_target_DAC_ReadBack;				// A6H[40~41], 4byte
        public int Vapd_target_DAC_ReadBack_Index { get { return 40; } }
        public ushort Vapd_target_DAC_ReadBack
        {
            get { return (ushort)(pStrA6[Vapd_target_DAC_ReadBack_Index] + (pStrA6[Vapd_target_DAC_ReadBack_Index + 1] << 8)); }
            set { pStrA6[Vapd_target_DAC_ReadBack_Index] = (byte)value; pStrA6[Vapd_target_DAC_ReadBack_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U   Vbr_Current_ADC_Original;		// A6H[42~43], 2byte
        public int Vbr_Current_ADC_Original_Index { get { return 42; } }
        public ushort Vbr_Current_ADC_Original
        {
            get { return (ushort)(pStrA6[Vbr_Current_ADC_Original_Index] + (pStrA6[Vbr_Current_ADC_Original_Index + 1] << 8)); }
            set { pStrA6[Vbr_Current_ADC_Original_Index] = (byte)value; pStrA6[Vbr_Current_ADC_Original_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U	Vbr_DAC_Original;				// A6H[44~45], 2byte
        public int Vbr_DAC_Original_Index { get { return 44; } }
        public ushort Vbr_DAC_Original
        {
            get { return (ushort)(pStrA6[Vbr_DAC_Original_Index] + (pStrA6[Vbr_DAC_Original_Index + 1] << 8)); }
            set { pStrA6[Vbr_DAC_Original_Index] = (byte)value; pStrA6[Vbr_DAC_Original_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U   Vbr_Voltage_ADC_Original;		// A6H[46~47], 2byte
        public int Vbr_Voltage_ADC_Original_Index { get { return 46; } }
        public ushort Vbr_Voltage_ADC_Original
        {
            get { return (ushort)(pStrA6[Vbr_Voltage_ADC_Original_Index] + (pStrA6[Vbr_Voltage_ADC_Original_Index + 1] << 8)); }
            set { pStrA6[Vbr_Voltage_ADC_Original_Index] = (byte)value; pStrA6[Vbr_Voltage_ADC_Original_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U	Vbr_test_Result;					//  A6H[48]for Vbr test result
        public int Vbr_test_Result_Index { get { return 48; } }
        public byte Vbr_test_Result { get { return pStrA6[Vbr_test_Result_Index]; } set { pStrA6[Vbr_test_Result_Index] = value; } }

        //INT8U Reserved49to63[15];                         //A6H[49~63], 15byte
        public int Reserved49to63_Index { get { return 49; } }
        public Array_Interval Reserved49to63 = new Array_Interval();

        //float	VAPD_V_Real;						// A6H[64~67],4byte   coeff is A6H[188~191]
        public int VAPD_V_Real_Index { get { return 64; } }
        public float VAPD_V_Real
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_V_Real_Index], pStrA6[VAPD_V_Real_Index + 1], pStrA6[VAPD_V_Real_Index + 2], pStrA6[VAPD_V_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_V_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

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

        //float   Vbr_Value;							//A6H[76~79], 4bytes
        public int Vbr_Value_Index { get { return 76; } }
        public float Vbr_Value
        {
            get { return MyFunc.Bs2F(pStrA6[Vbr_Value_Index], pStrA6[Vbr_Value_Index + 1], pStrA6[Vbr_Value_Index + 2], pStrA6[Vbr_Value_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[Vbr_Value_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float   Vbr_current_reading_back;			//A6H[80~83], 4bytes
        public int Vbr_current_reading_back_Index { get { return 80; } }
        public float Vbr_current_reading_back
        {
            get { return MyFunc.Bs2F(pStrA6[Vbr_current_reading_back_Index], pStrA6[Vbr_current_reading_back_Index + 1], pStrA6[Vbr_current_reading_back_Index + 2], pStrA6[Vbr_current_reading_back_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[Vbr_current_reading_back_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float   TIA_Current;			                  //A6H[84~87], 4bytes
        public int TIA_Current_Index { get { return 84; } }
        public float TIA_Current
        {
            get { return MyFunc.Bs2F(pStrA6[TIA_Current_Index], pStrA6[TIA_Current_Index + 1], pStrA6[TIA_Current_Index + 2], pStrA6[TIA_Current_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[TIA_Current_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //INT16U  APD_Limiting_set_debug;				//A6H[88~89], 2bytes
        public int APD_Limiting_set_debug_Index { get { return 88; } }
        public ushort APD_Limiting_set_debug
        {
            get { return (ushort)(pStrA6[APD_Limiting_set_debug_Index] + (pStrA6[APD_Limiting_set_debug_Index + 1] << 8)); }
            set { pStrA6[APD_Limiting_set_debug_Index] = (byte)value; pStrA6[APD_Limiting_set_debug_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U	Reserved90to122[33];			// A6H[90~122], 33byte
        public int Reserved90to122_Index { get { return 90; } }
        public Array_Interval Reserved90to122 = new Array_Interval();

        //INT32U  Password;                 		// A6H[123~126]
        public int Password_Index { get { return 123; } }
        public UInt32 Password
        {
            get { return MyFunc.Bs2U32(pStrA6[Password_Index], pStrA6[Password_Index + 1], pStrA6[Password_Index + 2], pStrA6[Password_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[Password_Index + i] = MyFunc.U322Bi(i, value);
            }
        }

        //INT8U   LUTIndex;                  		// A6H[127]
        public int LUTIndex_Index { get { return 127; } }
        public byte LUTIndex { get { return pStrA6[LUTIndex_Index]; } set { pStrA6[LUTIndex_Index] = value; } }

        //INT8U	CheckSumforPNSN;				// A6H[128], 1byte
        public int CheckSumforPNSN_Index { get { return 128; } }
        public byte CheckSumforPNSN { get { return pStrA6[CheckSumforPNSN_Index]; } set { pStrA6[CheckSumforPNSN_Index] = value; } }

        //INT8U	SlaveAdd_A6;					// A6H[129], 1byte
        public int SlaveAdd_A6_Index { get { return 129; } }
        public byte SlaveAdd_A6 { get { return pStrA6[SlaveAdd_A6_Index]; } set { pStrA6[SlaveAdd_A6_Index] = value; } }

        //INT8U	SlaveAdd_A0;					// A6H[130], 1byte
        public int SlaveAdd_A0_Index { get { return 130; } }
        public byte SlaveAdd_A0 { get { return pStrA6[SlaveAdd_A0_Index]; } set { pStrA6[SlaveAdd_A0_Index] = value; } }

        //INT8U	SlaveAdd_A2;					// A6H[131], 1byte
        public int SlaveAdd_A2_Index { get { return 131; } }
        public byte SlaveAdd_A2 { get { return pStrA6[SlaveAdd_A2_Index]; } set { pStrA6[SlaveAdd_A2_Index] = value; } }

        //INT8U   vendorPN[16];		            // A6H[132~147], 16byte
        public int vendorPN_Index { get { return 132; } }
        public Array_Interval vendorPN = new Array_Interval();

        //INT8U   vendorSN[16];                   // A6H[148~163], 16byte
        public int vendorSN_Index { get { return 148; } }
        public Array_Interval vendorSN = new Array_Interval();

        //INT16U  DAC_40V;						//A6H[164~165], 2byte, this is the DAC for the 40V apd circuit
        public int DAC_40V_Index { get { return 164; } }
        public ushort DAC_40V
        {
            get { return (ushort)(pStrA6[DAC_40V_Index] + (pStrA6[DAC_40V_Index + 1] << 8)); }
            set { pStrA6[DAC_40V_Index] = (byte)value; pStrA6[DAC_40V_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U   Reserved164to179[14];	    	// A6H[166~179], 14byte 
        public int Reserved164to179_Index { get { return 166; } }
        public Array_Interval Reserved164to179 = new Array_Interval();

        //float	K_33I;							// A6H[180~183], 4byte
        public int K_33I_Index { get { return 180; } }
        public float K_33I
        {
            get { return MyFunc.Bs2F(pStrA6[K_33I_Index], pStrA6[K_33I_Index + 1], pStrA6[K_33I_Index + 2], pStrA6[K_33I_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[K_33I_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	B_33I;							// A6H[184~187], 4byte
        public int B_33I_Index { get { return 184; } }
        public float B_33I
        {
            get { return MyFunc.Bs2F(pStrA6[B_33I_Index], pStrA6[B_33I_Index + 1], pStrA6[B_33I_Index + 2], pStrA6[B_33I_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[B_33I_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_voltage_Coeff_K;                //A6H[188~191], 4byte
        public int VAPD_voltage_Coeff_K_Index { get { return 188; } }
        public float VAPD_voltage_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_voltage_Coeff_K_Index], pStrA6[VAPD_voltage_Coeff_K_Index + 1], pStrA6[VAPD_voltage_Coeff_K_Index + 2], pStrA6[VAPD_voltage_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_voltage_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_voltage_Coeff_Offset;         //A6H[192~195], 4byte
        public int VAPD_voltage_Coeff_Offset_Index { get { return 192; } }
        public float VAPD_voltage_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_voltage_Coeff_Offset_Index], pStrA6[VAPD_voltage_Coeff_Offset_Index + 1], pStrA6[VAPD_voltage_Coeff_Offset_Index + 2], pStrA6[VAPD_voltage_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_voltage_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_Current_G_Coeff_K;                //A6H[196~199], 4byte
        public int VAPD_Current_G_Coeff_K_Index { get { return 196; } }
        public float VAPD_Current_G_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_Current_G_Coeff_K_Index], pStrA6[VAPD_Current_G_Coeff_K_Index + 1], pStrA6[VAPD_Current_G_Coeff_K_Index + 2], pStrA6[VAPD_Current_G_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_Current_G_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_Current_G_Coeff_Offset;         //A6H[200~203], 4byte
        public int VAPD_Current_G_Coeff_Offset_Index { get { return 200; } }
        public float VAPD_Current_G_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_Current_G_Coeff_Offset_Index], pStrA6[VAPD_Current_G_Coeff_Offset_Index + 1], pStrA6[VAPD_Current_G_Coeff_Offset_Index + 2], pStrA6[VAPD_Current_G_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_Current_G_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_Current_S_Coeff_K;                //A6H[204~207], 4byte
        public int VAPD_Current_S_Coeff_K_Index { get { return 204; } }
        public float VAPD_Current_S_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_Current_S_Coeff_K_Index], pStrA6[VAPD_Current_S_Coeff_K_Index + 1], pStrA6[VAPD_Current_S_Coeff_K_Index + 2], pStrA6[VAPD_Current_S_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_Current_S_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_Current_S_Coeff_Offset;         //A6H[208~211], 4byte
        public int VAPD_Current_S_Coeff_Offset_Index { get { return 208; } }
        public float VAPD_Current_S_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_Current_S_Coeff_Offset_Index], pStrA6[VAPD_Current_S_Coeff_Offset_Index + 1], pStrA6[VAPD_Current_S_Coeff_Offset_Index + 2], pStrA6[VAPD_Current_S_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_Current_S_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_Value_step_Low_Voltage;					   //A6H[212~215], 4byte
        public int VAPD_Value_step_Low_Voltage_Index { get { return 212; } }
        public float VAPD_Value_step_Low_Voltage
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_Value_step_Low_Voltage_Index], pStrA6[VAPD_Value_step_Low_Voltage_Index + 1], pStrA6[VAPD_Value_step_Low_Voltage_Index + 2], pStrA6[VAPD_Value_step_Low_Voltage_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_Value_step_Low_Voltage_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float VAPD_Value_step_High_Voltage;					   //A6H[216~219], 4byte
        public int VAPD_Value_step_High_Voltage_Index { get { return 216; } }
        public float VAPD_Value_step_High_Voltage
        {
            get { return MyFunc.Bs2F(pStrA6[VAPD_Value_step_High_Voltage_Index], pStrA6[VAPD_Value_step_High_Voltage_Index + 1], pStrA6[VAPD_Value_step_High_Voltage_Index + 2], pStrA6[VAPD_Value_step_High_Voltage_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VAPD_Value_step_High_Voltage_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //INT8U   Reserved188to255[36];			// A6H[220~255], 36byte
        public int Reserved188to255_Index { get { return 166; } }
        public Array_Interval Reserved188to255 = new Array_Interval();

    }

}



