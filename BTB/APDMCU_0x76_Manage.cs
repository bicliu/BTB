using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB
{
    class APDMCU_0x76_Manage
    {
        public byte[] pStrA6 = new byte[255];

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
        public short ADC_VAPD_nA_ADC_CH1
        {
            get { return (short)(pStrA6[ADC_VAPD_nA_ADC_CH1_Index] + (pStrA6[ADC_VAPD_nA_ADC_CH1_Index + 1] << 8)); }
            set { pStrA6[ADC_VAPD_nA_ADC_CH1_Index] = (byte)value; pStrA6[ADC_VAPD_nA_ADC_CH1_Index + 1] = (byte)(value >> 8); }
        }
        //INT16U  ADC1_33V;						// A6H[12~13], 2byte //1LSB = 0.1[mV]
        public int ADC1_33V_Index { get { return 12; } }
        public short ADC1_33V
        {
            get { return (short)(pStrA6[ADC1_33V_Index] + (pStrA6[ADC1_33V_Index + 1] << 8)); }
            set { pStrA6[ADC1_33V_Index] = (byte)value; pStrA6[ADC1_33V_Index + 1] = (byte)(value >> 8); }
        }

    }

}
