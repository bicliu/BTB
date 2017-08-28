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
        {
            sLIV_Control_Byte.setkey = new FUNC_SetBit(sLIV_Control_Byte_setbit);
            sLIV_Control_Byte.getkey = new FUNC_GetBit(sLIV_Control_Byte_Get);

            reserved38to39.array_set(ref pStrA6, reserved38to39_Index, 2);
            Reserved61to63.array_set(ref pStrA6, Reserved61to63_Index, 3);
            Reserved86to122.array_set(ref pStrA6, Reserved86to122_Index, 37);
            vendorPN.array_set(ref pStrA6, vendorPN_Index, 16);
            vendorSN.array_set(ref pStrA6, vendorSN_Index, 16);
            Reserved240to255.array_set(ref pStrA6, Reserved240to255_Index, 16);
        }

        //INT8U	FirstByte;						// A6H[0], 1byte
        public int FirstByte_Index { get { return 0; } }
        public byte FirstByte { get { return pStrA6[FirstByte_Index]; } set { pStrA6[FirstByte_Index] = value; } }

        //INT8U Reserved1;						// A6H[1], 1byte, input
        public int Reserved1_Index { get { return 1; } }
        public byte Reserved1 { get { return pStrA6[Reserved1_Index]; } set { pStrA6[Reserved1_Index] = value; } }

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

        //INT16S	MAX6610_Temperature;			// A6H[8~9], 2byte
        public int MAX6610_Temperature_Index { get { return 8; } }
        public short MAX6610_Temperature
        {
            get { return (short)(pStrA6[MAX6610_Temperature_Index] + (pStrA6[MAX6610_Temperature_Index + 1] << 8)); }
            set { pStrA6[MAX6610_Temperature_Index] = (byte)value; pStrA6[MAX6610_Temperature_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  ADC0_Pav_ADC_S;				// A6H[10~11], 2byte //TOSA optical power rawl ADC value
        public int ADC0_Pav_ADC_S_Index { get { return 10; } }
        public ushort ADC0_Pav_ADC_S
        {
            get { return (ushort)(pStrA6[ADC0_Pav_ADC_S_Index] + (pStrA6[ADC0_Pav_ADC_S_Index + 1] << 8)); }
            set { pStrA6[ADC0_Pav_ADC_S_Index] = (byte)value; pStrA6[ADC0_Pav_ADC_S_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  ADC1_Pav_ADC_G;				// A6H[12~13], 2byte //TOSA optical power rawl ADC value
        public int ADC1_Pav_ADC_G_Index { get { return 12; } }
        public ushort ADC1_Pav_ADC_G
        {
            get { return (ushort)(pStrA6[ADC1_Pav_ADC_G_Index] + (pStrA6[ADC1_Pav_ADC_G_Index + 1] << 8)); }
            set { pStrA6[ADC1_Pav_ADC_G_Index] = (byte)value; pStrA6[ADC1_Pav_ADC_G_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  ADC2_LD_Current_ADC;				// A6H[14~15], 2byte
        public int ADC2_LD_Current_ADC_Index { get { return 14; } }
        public ushort ADC2_LD_Current_ADC
        {
            get { return (ushort)(pStrA6[ADC2_LD_Current_ADC_Index] + (pStrA6[ADC2_LD_Current_ADC_Index + 1] << 8)); }
            set { pStrA6[ADC2_LD_Current_ADC_Index] = (byte)value; pStrA6[ADC2_LD_Current_ADC_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  ADC3_PD_Current_ADC_G;			// A6H[16~17], 2byte
        public int ADC3_PD_Current_ADC_G_Index { get { return 16; } }
        public ushort ADC3_PD_Current_ADC_G
        {
            get { return (ushort)(pStrA6[ADC3_PD_Current_ADC_G_Index] + (pStrA6[ADC3_PD_Current_ADC_G_Index + 1] << 8)); }
            set { pStrA6[ADC3_PD_Current_ADC_G_Index] = (byte)value; pStrA6[ADC3_PD_Current_ADC_G_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  ADC_LD_Forward_Voltage;				// A6H[18~19], 2byte
        public int ADC_LD_Forward_Voltage_Index { get { return 18; } }
        public ushort ADC_LD_Forward_Voltage
        {
            get { return (ushort)(pStrA6[ADC_LD_Forward_Voltage_Index] + (pStrA6[ADC_LD_Forward_Voltage_Index + 1] << 8)); }
            set { pStrA6[ADC_LD_Forward_Voltage_Index] = (byte)value; pStrA6[ADC_LD_Forward_Voltage_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  DAC0_VAPD_SET;					// A6H[20~21], 2byte
        public int DAC0_VAPD_SET_Index { get { return 20; } }
        public ushort DAC0_VAPD_SET
        {
            get { return (ushort)(pStrA6[DAC0_VAPD_SET_Index] + (pStrA6[DAC0_VAPD_SET_Index + 1] << 8)); }
            set { pStrA6[DAC0_VAPD_SET_Index] = (byte)value; pStrA6[DAC0_VAPD_SET_Index + 1] = (byte)(value >> 8); }
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

        //INT16U  DAC3_SIG_GEN_DAC;				// A6H[26~27], 2byte //DAC for LD forward current setting
        public int DAC3_SIG_GEN_DAC_Index { get { return 26; } }
        public ushort DAC3_SIG_GEN_DAC
        {
            get { return (ushort)(pStrA6[DAC3_SIG_GEN_DAC_Index] + (pStrA6[DAC3_SIG_GEN_DAC_Index + 1] << 8)); }
            set { pStrA6[DAC3_SIG_GEN_DAC_Index] = (byte)value; pStrA6[DAC3_SIG_GEN_DAC_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U   TX_DisableLIV_SHDN_Control;			// A6H[28], 1byte, if 0x01, trun off voltage, or else would be on
        public int TX_DisableLIV_SHDN_Control_Index { get { return 28; } }
        public byte TX_DisableLIV_SHDN_Control { get { return pStrA6[TX_DisableLIV_SHDN_Control_Index]; } set { pStrA6[TX_DisableLIV_SHDN_Control_Index] = value; } }

        //INT8U   LIV_PD_SHDN_Control;			// A6H[29], 1byte, if 0x01, trun off voltage, or else would be on
        public int LIV_PD_SHDN_Control_Index { get { return 29; } }
        public byte LIV_PD_SHDN_Control { get { return pStrA6[LIV_PD_SHDN_Control_Index]; } set { pStrA6[LIV_PD_SHDN_Control_Index] = value; } }

        //INT8U   reserved30to30[1] ;					// A6H[30~30], 1byte 
        public int reserved30to30_Index { get { return 30; } }
        public byte reserved30to30 { get { return pStrA6[reserved30to30_Index]; } set { pStrA6[reserved30to30_Index] = value; } }

        //struct  LIV_Control_Byte sLIV_Control_Byte;		// A6H[31], 1byte
        public int sLIV_Control_Byte_Index { get { return 31; } }
        public LIV_Control_Byte sLIV_Control_Byte = new LIV_Control_Byte();
        private void sLIV_Control_Byte_setbit(byte x, int i)
        {
            if (i < 0 || i > 3)
                return;
            if (i < 3)
            {
                pStrA6[sLIV_Control_Byte_Index] &= (byte)(~(1 << i));
                pStrA6[sLIV_Control_Byte_Index] |= (byte)((x & 1) << i);
            }
            else
            {
                pStrA6[sLIV_Control_Byte_Index] &= (byte)(~(0x1F << i));
                pStrA6[sLIV_Control_Byte_Index] |= (byte)((x & 0x1F) << i);
            }
        }
        private byte sLIV_Control_Byte_Get() { return pStrA6[sLIV_Control_Byte_Index]; }

        //INT8U	LIV_STEP_LSB;					//  A6H[32]for example: 16LSB is 0.976mA
        public int LIV_STEP_LSB_Index { get { return 32; } }
        public byte LIV_STEP_LSB { get { return pStrA6[LIV_STEP_LSB_Index]; } set { pStrA6[LIV_STEP_LSB_Index] = value; } }

        //INT8U	LIV_STEPs;					    //  A6H[33] test POINTs, for examples 40points 
        public int LIV_STEPs_Index { get { return 33; } }
        public byte LIV_STEPs { get { return pStrA6[LIV_STEPs_Index]; } set { pStrA6[LIV_STEPs_Index] = value; } }

        //INT16U	Start_Current;					//  A6H[34~35] the LIV start current setting
        public int Start_Current_Index { get { return 34; } }
        public ushort Start_Current
        {
            get { return (ushort)(pStrA6[Start_Current_Index] + (pStrA6[Start_Current_Index + 1] << 8)); }
            set { pStrA6[Start_Current_Index] = (byte)value; pStrA6[Start_Current_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U	dealy_sampling_time;			//  A6H[36~37] delay for sampling
        public int dealy_sampling_time_Index { get { return 36; } }
        public ushort dealy_sampling_time
        {
            get { return (ushort)(pStrA6[dealy_sampling_time_Index] + (pStrA6[dealy_sampling_time_Index + 1] << 8)); }
            set { pStrA6[dealy_sampling_time_Index] = (byte)value; pStrA6[dealy_sampling_time_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U   reserved38to39[2];				// A6H[38~39], 2byte
        public int reserved38to39_Index { get { return 38; } }
        public Array_Interval reserved38to39 = new Array_Interval();

        //INT8U   TX_Disable;						// A6H[40], 1byte  for debug use, if 0x10: debug mode
        public int TX_Disable_Index { get { return 40; } }
        public byte TX_Disable { get { return pStrA6[TX_Disable_Index]; } set { pStrA6[TX_Disable_Index] = value; } }

        //INT8U	RSSI_polarity;					// A6H[41], 1byte
        public int RSSI_polarity_Index { get { return 41; } }
        public byte RSSI_polarity { get { return pStrA6[RSSI_polarity_Index]; } set { pStrA6[RSSI_polarity_Index] = value; } }

        //INT16U	RSSI_PW;						// A6H[42~43], 2byte 
        public int RSSI_PW_Index { get { return 42; } }
        public ushort RSSI_PW
        {
            get { return (ushort)(pStrA6[RSSI_PW_Index] + (pStrA6[RSSI_PW_Index + 1] << 8)); }
            set { pStrA6[RSSI_PW_Index] = (byte)value; pStrA6[RSSI_PW_Index + 1] = (byte)(value >> 8); }
        }

        //INT16U  Tune_VTR_MON;					// A6H[44~45], 2byte //1LSB = 0.1[mV]
        public int Tune_VTR_MON_Index { get { return 44; } }
        public ushort Tune_VTR_MON
        {
            get { return (ushort)(pStrA6[Tune_VTR_MON_Index] + (pStrA6[Tune_VTR_MON_Index + 1] << 8)); }
            set { pStrA6[Tune_VTR_MON_Index] = (byte)value; pStrA6[Tune_VTR_MON_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U   VTRAdj_loop;					// A6H[46],    1byte 
        public int VTRAdj_loop_Index { get { return 46; } }
        public byte VTRAdj_loop { get { return pStrA6[VTRAdj_loop_Index]; } set { pStrA6[VTRAdj_loop_Index] = value; } }

        //INT8U   VTRAdj_en;						// A6H[47],   1byte
        public int VTRAdj_en_Index { get { return 47; } }
        public byte VTRAdj_en { get { return pStrA6[VTRAdj_en_Index]; } set { pStrA6[VTRAdj_en_Index] = value; } }

        //float	VTR_expect;						// A6H[48~51],4byte
        public int VTR_expect_Index { get { return 48; } }
        public float VTR_expect
        {
            get { return MyFunc.Bs2F(pStrA6[VTR_expect_Index], pStrA6[VTR_expect_Index + 1], pStrA6[VTR_expect_Index + 2], pStrA6[VTR_expect_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VTR_expect_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	VCASEtoVCC;						// A6H[52~55], 4byte, unit V 
        public int VCASEtoVCC_Index { get { return 52; } }
        public float VCASEtoVCC
        {
            get { return MyFunc.Bs2F(pStrA6[VCASEtoVCC_Index], pStrA6[VCASEtoVCC_Index + 1], pStrA6[VCASEtoVCC_Index + 2], pStrA6[VCASEtoVCC_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VCASEtoVCC_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	VCASEtoNC;						// A6H[56~59], 4byte, unit V
        public int VCASEtoNC_Index { get { return 56; } }
        public float VCASEtoNC
        {
            get { return MyFunc.Bs2F(pStrA6[VCASEtoNC_Index], pStrA6[VCASEtoNC_Index + 1], pStrA6[VCASEtoNC_Index + 2], pStrA6[VCASEtoNC_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[VCASEtoNC_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //INT8U   CASEShortErrorCode;				// A6H[60], 1byte
        public int CASEShortErrorCode_Index { get { return 60; } }
        public byte CASEShortErrorCode { get { return pStrA6[CASEShortErrorCode_Index]; } set { pStrA6[CASEShortErrorCode_Index] = value; } }

        //INT8U Reserved61to63[3];                         //A6H[61~63], 3byte
        public int Reserved61to63_Index { get { return 61; } }
        public Array_Interval Reserved61to63 = new Array_Interval();

        //float	Pav_ADC_S_Real;						// A6H[64~67],4byte   coeff is A6H[188~191] 
        public int Pav_ADC_S_Real_Index { get { return 64; } }
        public float Pav_ADC_S_Real
        {
            get { return MyFunc.Bs2F(pStrA6[Pav_ADC_S_Real_Index], pStrA6[Pav_ADC_S_Real_Index + 1], pStrA6[Pav_ADC_S_Real_Index + 2], pStrA6[Pav_ADC_S_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[Pav_ADC_S_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	Pav_ADC_G_Real;						// A6H[68~71], 4byte, unit V
        public int Pav_ADC_G_Real_Index { get { return 68; } }
        public float Pav_ADC_G_Real
        {
            get { return MyFunc.Bs2F(pStrA6[Pav_ADC_G_Real_Index], pStrA6[Pav_ADC_G_Real_Index + 1], pStrA6[Pav_ADC_G_Real_Index + 2], pStrA6[Pav_ADC_G_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[Pav_ADC_G_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

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

        //float	LD_Forward_Voltage_Real;						// A6H[80~83], 4byte, unit V
        public int LD_Forward_Voltage_Real_Index { get { return 80; } }
        public float LD_Forward_Voltage_Real
        {
            get { return MyFunc.Bs2F(pStrA6[LD_Forward_Voltage_Real_Index], pStrA6[LD_Forward_Voltage_Real_Index + 1], pStrA6[LD_Forward_Voltage_Real_Index + 2], pStrA6[LD_Forward_Voltage_Real_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[LD_Forward_Voltage_Real_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //INT16U LD_wavelength;                                           //A6H[84~85]
        public int LD_wavelength_Index { get { return 84; } }
        public ushort LD_wavelength
        {
            get { return (ushort)(pStrA6[LD_wavelength_Index] + (pStrA6[LD_wavelength_Index + 1] << 8)); }
            set { pStrA6[LD_wavelength_Index] = (byte)value; pStrA6[LD_wavelength_Index + 1] = (byte)(value >> 8); }
        }

        //INT8U	Reserved86to122[37];			// A6H[86~122], 37byte
        public int Reserved86to122_Index { get { return 86; } }
        public Array_Interval Reserved86to122 = new Array_Interval();

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

        //float	ADC0_Pav_ADC_S_1490_Coeff_K;							// A6H[164~167], 4byte 
        public int ADC0_Pav_ADC_S_1490_Coeff_K_Index { get { return 164; } }
        public float ADC0_Pav_ADC_S_1490_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC0_Pav_ADC_S_1490_Coeff_K_Index], pStrA6[ADC0_Pav_ADC_S_1490_Coeff_K_Index + 1], pStrA6[ADC0_Pav_ADC_S_1490_Coeff_K_Index + 2], pStrA6[ADC0_Pav_ADC_S_1490_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC0_Pav_ADC_S_1490_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	ADC0_Pav_ADC_S_1490_Coeff_Offset;							// A6H[168~171], 4byte
        public int ADC0_Pav_ADC_S_1490_Coeff_Offset_Index { get { return 168; } }
        public float ADC0_Pav_ADC_S_1490_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC0_Pav_ADC_S_1490_Coeff_Offset_Index], pStrA6[ADC0_Pav_ADC_S_1490_Coeff_Offset_Index + 1], pStrA6[ADC0_Pav_ADC_S_1490_Coeff_Offset_Index + 2], pStrA6[ADC0_Pav_ADC_S_1490_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC0_Pav_ADC_S_1490_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	ADC1_Pav_ADC_G_1490_Coeff_K;							// A6H[172~175], 4byte
        public int ADC1_Pav_ADC_G_1490_Coeff_K_Index { get { return 172; } }
        public float ADC1_Pav_ADC_G_1490_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC1_Pav_ADC_G_1490_Coeff_K_Index], pStrA6[ADC1_Pav_ADC_G_1490_Coeff_K_Index + 1], pStrA6[ADC1_Pav_ADC_G_1490_Coeff_K_Index + 2], pStrA6[ADC1_Pav_ADC_G_1490_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC1_Pav_ADC_G_1490_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	ADC1_Pav_ADC_G_1490_Coeff_Offset;							// A6H[176~179], 4byte
        public int ADC1_Pav_ADC_G_1490_Coeff_Offset_Index { get { return 176; } }
        public float ADC1_Pav_ADC_G_1490_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC1_Pav_ADC_G_1490_Coeff_Offset_Index], pStrA6[ADC1_Pav_ADC_G_1490_Coeff_Offset_Index + 1], pStrA6[ADC1_Pav_ADC_G_1490_Coeff_Offset_Index + 2], pStrA6[ADC1_Pav_ADC_G_1490_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC1_Pav_ADC_G_1490_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	ADC0_Pav_ADC_S_1550_Coeff_K;							// A6H[180~183], 4byte
        public int ADC0_Pav_ADC_S_1550_Coeff_K_Index { get { return 180; } }
        public float ADC0_Pav_ADC_S_1550_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC0_Pav_ADC_S_1550_Coeff_K_Index], pStrA6[ADC0_Pav_ADC_S_1550_Coeff_K_Index + 1], pStrA6[ADC0_Pav_ADC_S_1550_Coeff_K_Index + 2], pStrA6[ADC0_Pav_ADC_S_1550_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC0_Pav_ADC_S_1550_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float	ADC0_Pav_ADC_S_1550_Coeff_Offset;							// A6H[184~187], 4byte
        public int ADC0_Pav_ADC_S_1550_Coeff_Offset_Index { get { return 184; } }
        public float ADC0_Pav_ADC_S_1550_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC0_Pav_ADC_S_1550_Coeff_Offset_Index], pStrA6[ADC0_Pav_ADC_S_1550_Coeff_Offset_Index + 1], pStrA6[ADC0_Pav_ADC_S_1550_Coeff_Offset_Index + 2], pStrA6[ADC0_Pav_ADC_S_1550_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC0_Pav_ADC_S_1550_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC0_Pav_ADC_S_1310_Coeff_K;                //A6H[188~191], 4byte
        public int ADC0_Pav_ADC_S_1310_Coeff_K_Index { get { return 188; } }
        public float ADC0_Pav_ADC_S_1310_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC0_Pav_ADC_S_1310_Coeff_K_Index], pStrA6[ADC0_Pav_ADC_S_1310_Coeff_K_Index + 1], pStrA6[ADC0_Pav_ADC_S_1310_Coeff_K_Index + 2], pStrA6[ADC0_Pav_ADC_S_1310_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC0_Pav_ADC_S_1310_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC0_Pav_ADC_S_1310_Coeff_Offset;         //A6H[192~195], 4byte
        public int ADC0_Pav_ADC_S_1310_Coeff_Offset_Index { get { return 192; } }
        public float ADC0_Pav_ADC_S_1310_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC0_Pav_ADC_S_1310_Coeff_Offset_Index], pStrA6[ADC0_Pav_ADC_S_1310_Coeff_Offset_Index + 1], pStrA6[ADC0_Pav_ADC_S_1310_Coeff_Offset_Index + 2], pStrA6[ADC0_Pav_ADC_S_1310_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC0_Pav_ADC_S_1310_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC1_Pav_ADC_G_1310_Coeff_K;                //A6H[196~199], 4byte
        public int ADC1_Pav_ADC_G_1310_Coeff_K_Index { get { return 196; } }
        public float ADC1_Pav_ADC_G_1310_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC1_Pav_ADC_G_1310_Coeff_K_Index], pStrA6[ADC1_Pav_ADC_G_1310_Coeff_K_Index + 1], pStrA6[ADC1_Pav_ADC_G_1310_Coeff_K_Index + 2], pStrA6[ADC1_Pav_ADC_G_1310_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC1_Pav_ADC_G_1310_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC1_Pav_ADC_G_1310_Coeff_Offset;         //A6H[200~203], 4byte
        public int ADC1_Pav_ADC_G_1310_Coeff_Offset_Index { get { return 200; } }
        public float ADC1_Pav_ADC_G_1310_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC1_Pav_ADC_G_1310_Coeff_Offset_Index], pStrA6[ADC1_Pav_ADC_G_1310_Coeff_Offset_Index + 1], pStrA6[ADC1_Pav_ADC_G_1310_Coeff_Offset_Index + 2], pStrA6[ADC1_Pav_ADC_G_1310_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC1_Pav_ADC_G_1310_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC2_LD_Current_ADC_Coeff_K;                //A6H[204~207], 4byte
        public int ADC2_LD_Current_ADC_Coeff_K_Index { get { return 204; } }
        public float ADC2_LD_Current_ADC_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC2_LD_Current_ADC_Coeff_K_Index], pStrA6[ADC2_LD_Current_ADC_Coeff_K_Index + 1], pStrA6[ADC2_LD_Current_ADC_Coeff_K_Index + 2], pStrA6[ADC2_LD_Current_ADC_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC2_LD_Current_ADC_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC2_LD_Current_ADC_Coeff_Offset;         //A6H[208~211], 4byte
        public int ADC2_LD_Current_ADC_Coeff_Offset_Index { get { return 208; } }
        public float ADC2_LD_Current_ADC_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC2_LD_Current_ADC_Coeff_Offset_Index], pStrA6[ADC2_LD_Current_ADC_Coeff_Offset_Index + 1], pStrA6[ADC2_LD_Current_ADC_Coeff_Offset_Index + 2], pStrA6[ADC2_LD_Current_ADC_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC2_LD_Current_ADC_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC3_PD_Current_ADC_G_Coeff_K;                //A6H[212~205], 4byte
        public int ADC3_PD_Current_ADC_G_Coeff_K_Index { get { return 212; } }
        public float ADC3_PD_Current_ADC_G_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC3_PD_Current_ADC_G_Coeff_K_Index], pStrA6[ADC3_PD_Current_ADC_G_Coeff_K_Index + 1], pStrA6[ADC3_PD_Current_ADC_G_Coeff_K_Index + 2], pStrA6[ADC3_PD_Current_ADC_G_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC3_PD_Current_ADC_G_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC3_PD_Current_ADC_GCoeff_Offset;         //A6H[216~219], 4byte
        public int ADC3_PD_Current_ADC_GCoeff_Offset_Index { get { return 216; } }
        public float ADC3_PD_Current_ADC_GCoeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC3_PD_Current_ADC_GCoeff_Offset_Index], pStrA6[ADC3_PD_Current_ADC_GCoeff_Offset_Index + 1], pStrA6[ADC3_PD_Current_ADC_GCoeff_Offset_Index + 2], pStrA6[ADC3_PD_Current_ADC_GCoeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC3_PD_Current_ADC_GCoeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC_Forward_Voltage_Coeff_K;                //A6H[220~223], 4byte
        public int ADC_Forward_Voltage_Coeff_K_Index { get { return 68; } }
        public float ADC_Forward_Voltage_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC_Forward_Voltage_Coeff_K_Index], pStrA6[ADC_Forward_Voltage_Coeff_K_Index + 1], pStrA6[ADC_Forward_Voltage_Coeff_K_Index + 2], pStrA6[ADC_Forward_Voltage_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC_Forward_Voltage_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC_Forward_Voltage_Coeff_Offset;         //A6H[224~227], 4byte
        public int ADC_Forward_Voltage_Coeff_Offset_Index { get { return 224; } }
        public float ADC_Forward_Voltage_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC_Forward_Voltage_Coeff_Offset_Index], pStrA6[ADC_Forward_Voltage_Coeff_Offset_Index + 1], pStrA6[ADC_Forward_Voltage_Coeff_Offset_Index + 2], pStrA6[ADC_Forward_Voltage_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC_Forward_Voltage_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC1_Pav_ADC_G_1550_Coeff_K;                                 // A6H[228~231], 4byte
        public int ADC1_Pav_ADC_G_1550_Coeff_K_Index { get { return 228; } }
        public float ADC1_Pav_ADC_G_1550_Coeff_K
        {
            get { return MyFunc.Bs2F(pStrA6[ADC1_Pav_ADC_G_1550_Coeff_K_Index], pStrA6[ADC1_Pav_ADC_G_1550_Coeff_K_Index + 1], pStrA6[ADC1_Pav_ADC_G_1550_Coeff_K_Index + 2], pStrA6[ADC1_Pav_ADC_G_1550_Coeff_K_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC1_Pav_ADC_G_1550_Coeff_K_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float ADC1_Pav_ADC_G_1550_Coeff_Offset;                         // A6H[232~235], 4byte
        public int ADC1_Pav_ADC_G_1550_Coeff_Offset_Index { get { return 232; } }
        public float ADC1_Pav_ADC_G_1550_Coeff_Offset
        {
            get { return MyFunc.Bs2F(pStrA6[ADC1_Pav_ADC_G_1550_Coeff_Offset_Index], pStrA6[ADC1_Pav_ADC_G_1550_Coeff_Offset_Index + 1], pStrA6[ADC1_Pav_ADC_G_1550_Coeff_Offset_Index + 2], pStrA6[ADC1_Pav_ADC_G_1550_Coeff_Offset_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[ADC1_Pav_ADC_G_1550_Coeff_Offset_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //float Pav_gate_in_dBm;   // A6H[236~239], 4byte
        public int Pav_gate_in_dBm_Index { get { return 236; } }
        public float Pav_gate_in_dBm
        {
            get { return MyFunc.Bs2F(pStrA6[Pav_gate_in_dBm_Index], pStrA6[Pav_gate_in_dBm_Index + 1], pStrA6[Pav_gate_in_dBm_Index + 2], pStrA6[Pav_gate_in_dBm_Index + 3]); }
            set
            {
                for (int i = 0; i < 4; i++)
                    pStrA6[Pav_gate_in_dBm_Index + i] = MyFunc.F2Bi(i, value);
            }
        }

        //INT8U Reserved240to255[16];			// A6H[240~255], 16byte
        public int Reserved240to255_Index { get { return 240; } }
        public Array_Interval Reserved240to255 = new Array_Interval();
    }
}


