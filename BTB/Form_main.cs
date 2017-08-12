using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using INT8S = System.SByte;               //8bit
using INT8U = System.Byte;               //8bit
using INT16U = System.UInt16;              //16bit
using INT16S = System.Int16;              //16bit
using INT32U = System.UInt32;              //32bit
using INT32S = System.Int32;              //32bit 
 

namespace BTB
{
    public partial class Form_main : Form
    {
        [DllImport("CH341A_DLL.dll")]
        public static extern int I2C_HOST_INITIALIZATION_DLL(int iIndex);
        [DllImport("CH341A_DLL.dll")]
        public static extern int I2C_BYTE_WRITE_DLL(int iIndex, int device_addr, int rom_startaddress, byte rom_value, float T_wait);
        [DllImport("CH341A_DLL.dll")]
        public static extern int I2C_BYTEs_READ_DLL(int iIndex, int device_addr, int rom_startaddress, int rom_Length, ref byte rom_value_arr);
        [DllImport("CH341A_DLL.dll")]
        public static extern int I2C_4BYTEs_READ_DLL(int iIndex, int device_addr, int rom_startaddress, ref byte rom_value1, ref byte rom_value2, ref byte rom_value3, ref byte rom_value4);

        private List<int> _usbList;
        private int _USBHandle;
        private APDMCU_0x76_Manage my_uA6_APDMCU_0x76;
        private TOSAMCU_0x74_Manage my_uA6_TOSAMCU_0x74;
        private const int APDMCU = 0x76;
        private const int TOSAMCU = 0x74;
        private const string FLOAT_ACC = "F6";

        public Form_main()
        {
            InitializeComponent();
            _usbList = new List<int>();
            my_uA6_APDMCU_0x76 = new APDMCU_0x76_Manage();
            my_uA6_TOSAMCU_0x74 = new TOSAMCU_0x74_Manage();
        }

        private void btn_searchUSB_Click(object sender, EventArgs e)
        {
            int error;

            cbb_usblist.Items.Clear();
            _usbList.Clear();

            for (int i = 0; i < 255; i++)
            {
                error = I2C_HOST_INITIALIZATION_DLL(i);

                if(error != -1)
                {
                    cbb_usblist.Items.Add(String.Format("Host {0:D3}: 0x{1:X3}", cbb_usblist.Items.Count, i));
                    _usbList.Add(i);
                }
            }

            if(cbb_usblist.Items.Count == 0)
            {
                tb_show.Text += "没有找到USB设备!\r\n";
            }
            else
            {
                cbb_usblist.SelectedIndex = 0;
                _USBHandle = _usbList[0];
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectionStart = tb.Text.Length - 1;
            tb.ScrollToCaret();
        }

        private void cbb_usblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            _USBHandle = _usbList[cb.SelectedIndex];
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            int reg_add;
            int error;
            float T_wait = 0.1f;

            //reg_add = (int)(&my_uA6_APDMCU_0x76.sStrA6.RX_SHDN_Control) - (int)(&my_uA6_APDMCU_0x76.sStrA6.FirstByte);
            reg_add = my_uA6_APDMCU_0x76.RX_SHDN_Control_Index;

            if (btn_power.Text == "ON")
            {
                error = I2C_BYTE_WRITE_DLL(_USBHandle, APDMCU, reg_add, 0x00, T_wait);
                if(error != -1)
                {
                    btn_power.Text = "OFF";
                }
                else
                {
                    tb_show.Text += "turn off the APD supply voltage failed!\r\n";
                }
            }
            else
            {
                error = I2C_BYTE_WRITE_DLL(_USBHandle, APDMCU, reg_add, 0x01, T_wait);
                if (error != -1)
                {
                    btn_power.Text = "ON";
                }
                else
                {
                    tb_show.Text += "turn on the APD supply voltage failed!\r\n";
                }
            }
        }

        private void btn_get_LD_Click(object sender, EventArgs e)
        {
            int error;
            float vFloat;

            /*var bytes = BitConverter.GetBytes(0x3aa1be2b);
            float v1 = MyFunc.ToFloat(bytes[0], bytes[1], bytes[2], bytes[3]);

            tb_LD.Text = v1.ToString("F6");
            var v = BitConverter.ToSingle(bytes, 0);
            tb_PD.Text = v.ToString("F6");*/
            //Get the TOSA forwared voltage
            error = I2C_BYTEs_READ_DLL(_USBHandle, TOSAMCU, 0, 256, ref my_uA6_TOSAMCU_0x74.pStrA6[0]);
            vFloat = my_uA6_TOSAMCU_0x74.LD_Current_Real;
            if (error != -1)
            {
                tb_LD.Text = vFloat.ToString(FLOAT_ACC);
            }
            else
            {
                tb_show.Text += "cannot get LD Current!\r\n";
            }
        }

        private void btn_get_PD_Click(object sender, EventArgs e)
        {
            int error;
            float vPD_CurrentG;

            //Get the TOSA PD current
            error = I2C_BYTEs_READ_DLL(_USBHandle, TOSAMCU, 0, 256, ref my_uA6_TOSAMCU_0x74.pStrA6[0]);
            vPD_CurrentG = my_uA6_TOSAMCU_0x74.PD_Current_ADC_G_Real;
            if(error != -1)
            {
                tb_PD.Text = vPD_CurrentG.ToString(FLOAT_ACC);
            }
            else
            {
                tb_show.Text += "cannot get PD Current!\r\n";
            }
        }

        private void btn_get_ROPD_Click(object sender, EventArgs e)
        {
            int reg_add;
            int error;
            float vAPD_Current;

            //Get the APD working current
            reg_add = my_uA6_APDMCU_0x76.VAPD_I_G_Real_Index;
            error = I2C_4BYTEs_READ_DLL(_USBHandle, APDMCU, reg_add, ref my_uA6_APDMCU_0x76.pStrA6[reg_add], ref my_uA6_APDMCU_0x76.pStrA6[reg_add + 1], ref my_uA6_APDMCU_0x76.pStrA6[reg_add + 2], ref my_uA6_APDMCU_0x76.pStrA6[reg_add + 3]);
            vAPD_Current = my_uA6_APDMCU_0x76.VAPD_I_G_Real;
            if (error != -1)
            {
                tb_ROPD.Text = vAPD_Current.ToString(FLOAT_ACC);
            }
            else
            {
                tb_show.Text += "cannot get the VAPD Current!\r\n";
            }

            reg_add = my_uA6_APDMCU_0x76.VAPD_I_S_Real_Index;
            error = I2C_4BYTEs_READ_DLL(_USBHandle, APDMCU, reg_add, ref my_uA6_APDMCU_0x76.pStrA6[reg_add], ref my_uA6_APDMCU_0x76.pStrA6[reg_add + 1], ref my_uA6_APDMCU_0x76.pStrA6[reg_add + 2], ref my_uA6_APDMCU_0x76.pStrA6[reg_add + 3]);
            vAPD_Current = my_uA6_APDMCU_0x76.VAPD_I_S_Real;
            if (error != -1)
            {
                tb_ROPD_S.Text = vAPD_Current.ToString(FLOAT_ACC);
            }
            else
            {
                tb_show.Text += "cannot get the VAPD Current for small signal!\r\n";
            }
        }
    }



    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct strA6_APDMCU_0x76 //APD Control Circuit
    {
        public INT8U FirstByte;                        // A6H[0], 1byte
                                                       //="E"=clear flash￡?

        public INT8U Reserved_byte_1;                      // A6H[1], 1byte, input

        public INT8U FirmwareVersion;              // A6H[2], 1byte 										
        public INT8U CPLD_Version;                 // A6H[3], 1byte, input
        public INT16U Core_Voltage;                    // A6H[4~5], 2byte 							
        public INT16S Core_Temperature;                // A6H[6~7], 2byte
        public INT16S Core_5V_Voltage;         // A6H[8~9], 2byte

        public INT16U ADC_VAPD_nA_ADC_CH1;                     // A6H[10~11], 2byte //CASE ADC value, case voltage
        public INT16U ADC1_33V;                        // A6H[12~13], 2byte //1LSB = 0.1[mV]
        public INT16U ADC2_VAPD_V_ADC;             // A6H[14~15], 2byte  
        public INT16U ADC3_VAPD_I_G_ADC;           // A6H[16~17], 2byte  
        public INT16U ADC4_VAPD_I_S_ADC;               // A6H[18~19], 2byte 
        public INT16U DAC_VAPD_SET;                    // A6H[20~21], 2byte 
        public INT16U DAC1_33V;                        // A6H[22~23], 2byte //VOA DAC value
        public INT16U DAC2;                            // A6H[24~25], 2byte //33V DAC value
        public INT16U DAC3;                            // A6H[26~27], 2byte //USB DAC value


        public INT8U RX_SHDN_Control;          // A6H[28], 1byte, if 0x01, APD on, or else would be off
        public INT8U APD_VBR_Target_Current;       // A6H[29], 1byte, uA as the target
        public INT8U Rerserved30;                  // A6H[30], 1byte
        public APD_Vbr_Test_Control_Byte sAPD_Vbr_Test_Control_Byte;                   // A6H[31], 1byte

        public INT8U Vbr_test_STEP_LSB;                    //  A6H[32]for example: 54LSB is about 1V
        public INT8U Enable_Normal_APD_Voltage;                        // A6H[33] is reserved


        public INT16U Vbr_test_Current_Limitation;     //  A6H[34~35] ADC value from calibration data, default value is 0x0A
        public float APD_Voltage_Target;                   //  A6H[36~39] the LIV start current setting, public float

        public INT16U Vapd_target_DAC_ReadBack;                // A6H[40~41], 4byte

        public INT16U Vbr_Current_ADC_Original;        // A6H[42~43], 1byte 
        public INT16U Vbr_DAC_Original;                // A6H[44~45], 1byte
        public INT16U Vbr_Voltage_ADC_Original;        // A6H[46~47], 1byte 
        public INT8U Vbr_test_Result;                  //  A6H[48]for Vbr test result
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public INT8U Reserved49to63;                         //A6H[49~63], 1byte

        public float VAPD_V_Real;                      // A6H[64~67],4byte   coeff is A6H[188~191]
        public float VAPD_I_G_Real;                        // A6H[68~71], 4byte, unit V
        public float VAPD_I_S_Real;                        // A6H[72~75], 4byte, unit V

        public float Vbr_Value;                            //A6H[76~79], 4bytes

        public float Vbr_current_reading_back;         //A6H[80~83], 4bytes

        public INT16U APD_current_ADC_set_debug;               //A6H[84~85], 2bytes
        public INT16U APD_DACSTAT_set_debug;               //A6H[86~87], 2bytes
        public INT16U APD_Limiting_set_debug;              //A6H[88~89], 2bytes


        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        public INT8U Reserved90to122;          // A6H[90~122], 47byte

        public INT32U Password;                        // A6H[123~126]   
        public INT8U LUTIndex;                         // A6H[127] 

        //FLASH
        public INT8U CheckSumforPNSN;              // A6H[128], 1byte
        public INT8U SlaveAdd_A6;                  // A6H[129], 1byte
        public INT8U SlaveAdd_A0;                  // A6H[130], 1byte
        public INT8U SlaveAdd_A2;                  // A6H[131], 1byte

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public INT8U vendorPN;                 // A6H[132~147], 16byte
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public INT8U vendorSN;                   // A6H[148~163], 16byte
        public INT16U DAC_40V;                     //A6H[164~165], 2byte, this is the DAC for the 40V apd circuit
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public INT8U Reserved164to179;         // A6H[166~179], 14byte
        public float K_33I;                            // A6H[180~183], 4byte
        public float B_33I;                            // A6H[184~187], 4byte 

        public float VAPD_voltage_Coeff_K;                //A6H[188~191], 4byte
        public float VAPD_voltage_Coeff_Offset;         //A6H[192~195], 4byte

        public float VAPD_Current_G_Coeff_K;                //A6H[196~199], 4byte
        public float VAPD_Current_G_Coeff_Offset;         //A6H[200~203], 4byte

        public float VAPD_Current_S_Coeff_K;                //A6H[204~207], 4byte
        public float VAPD_Current_S_Coeff_Offset;         //A6H[208~211], 4byte
        public float VAPD_Value_step_Low_Voltage;                     //A6H[212~215], 4byte ADC????±?ò???step￡?Vapdμ??1±??ˉ?àéù￡???ì¨éè±?????é?á??μê?2?ò??ùμ??￡′?′|ê?10V~40V?μêy
        public float VAPD_Value_step_High_Voltage;                    //A6H[216~219], 4byte ADC????±?ò???step￡?Vapdμ??1±??ˉ?àéù￡???ì¨éè±?????é?á??μê?2?ò??ùμ??￡′?′|ê?40V ~70V?μêy

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public INT8U Reserved188to255;         // A6H[220~255], 36byte 
                                               //flash definition for calibration use from 188bytes
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct uA6_APD
    {
        [FieldOffset(0)]
        public strA6_APDMCU_0x76  sStrA6;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public INT8U pStrA6;
    }

}
