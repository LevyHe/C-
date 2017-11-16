using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Byte[] test = new Byte[10]{0x30,0x39,0x38,0x37,0x36,0x35,0x34,0x33,0x32,0x31};
           
            uint res = CRCITU.GetCrc32(test);
        }
        byte[] Hexbufarry = new byte[] {0x30,0x31,0x32,0x33,0x34,0x35,0x36,0x37,0x38,0x39,0x41,0x42,0x43,0x44,0x45,0x46,0x61,0x62,0x63,0x64,0x65,0x66};//16进制字符数组

        static UInt16 value = 0;
        static Int32 length;

        #region CRC校验
        private static readonly UInt16[] wCRC16Table = { 
        0x0000, 0xC0C1, 0xC181, 0x0140, 0xC301, 0x03C0, 0x0280, 0xC241,
        0xC601, 0x06C0, 0x0780, 0xC741, 0x0500, 0xC5C1, 0xC481, 0x0440,
        0xCC01, 0x0CC0, 0x0D80, 0xCD41, 0x0F00, 0xCFC1, 0xCE81, 0x0E40, 
        0x0A00, 0xCAC1, 0xCB81, 0x0B40, 0xC901, 0x09C0, 0x0880, 0xC841,
        0xD801, 0x18C0, 0x1980, 0xD941, 0x1B00, 0xDBC1, 0xDA81, 0x1A40,  
        0x1E00, 0xDEC1, 0xDF81, 0x1F40, 0xDD01, 0x1DC0, 0x1C80, 0xDC41,
        0x1400, 0xD4C1, 0xD581, 0x1540, 0xD701, 0x17C0, 0x1680, 0xD641,
        0xD201, 0x12C0, 0x1380, 0xD341, 0x1100, 0xD1C1, 0xD081, 0x1040,
        0xF001, 0x30C0, 0x3180, 0xF141, 0x3300, 0xF3C1, 0xF281, 0x3240,
        0x3600, 0xF6C1, 0xF781, 0x3740, 0xF501, 0x35C0, 0x3480, 0xF441,   
        0x3C00, 0xFCC1, 0xFD81, 0x3D40, 0xFF01, 0x3FC0, 0x3E80, 0xFE41,
        0xFA01, 0x3AC0, 0x3B80, 0xFB41, 0x3900, 0xF9C1, 0xF881, 0x3840,
        0x2800, 0xE8C1, 0xE981, 0x2940, 0xEB01, 0x2BC0, 0x2A80, 0xEA41,
        0xEE01, 0x2EC0, 0x2F80, 0xEF41, 0x2D00, 0xEDC1, 0xEC81, 0x2C40,
        0xE401, 0x24C0, 0x2580, 0xE541, 0x2700, 0xE7C1, 0xE681, 0x2640,   
        0x2200, 0xE2C1, 0xE381, 0x2340, 0xE101, 0x21C0, 0x2080, 0xE041,
        0xA001, 0x60C0, 0x6180, 0xA141, 0x6300, 0xA3C1, 0xA281, 0x6240,
        0x6600, 0xA6C1, 0xA781, 0x6740, 0xA501, 0x65C0, 0x6480, 0xA441,
        0x6C00, 0xACC1, 0xAD81, 0x6D40, 0xAF01, 0x6FC0, 0x6E80, 0xAE41,
        0xAA01, 0x6AC0, 0x6B80, 0xAB41, 0x6900, 0xA9C1, 0xA881, 0x6840,   
        0x7800, 0xB8C1, 0xB981, 0x7940, 0xBB01, 0x7BC0, 0x7A80, 0xBA41,
        0xBE01, 0x7EC0, 0x7F80, 0xBF41, 0x7D00, 0xBDC1, 0xBC81, 0x7C40,
        0xB401, 0x74C0, 0x7580, 0xB541, 0x7700, 0xB7C1, 0xB681, 0x7640,
        0x7200, 0xB2C1, 0xB381, 0x7340, 0xB101, 0x71C0, 0x7080, 0xB041,
        0x5000, 0x90C1, 0x9181, 0x5140, 0x9301, 0x53C0, 0x5280, 0x9241,  
        0x9601, 0x56C0, 0x5780, 0x9741, 0x5500, 0x95C1, 0x9481, 0x5440,
        0x9C01, 0x5CC0, 0x5D80, 0x9D41, 0x5F00, 0x9FC1, 0x9E81, 0x5E40,
        0x5A00, 0x9AC1, 0x9B81, 0x5B40, 0x9901, 0x59C0, 0x5880, 0x9841,
        0x8801, 0x48C0, 0x4980, 0x8941, 0x4B00, 0x8BC1, 0x8A81, 0x4A40,
        0x4E00, 0x8EC1, 0x8F81, 0x4F40, 0x8D01, 0x4DC0, 0x4C80, 0x8C41,  
        0x4400, 0x84C1, 0x8581, 0x4540, 0x8701, 0x47C0, 0x4680, 0x8641,
        0x8201, 0x42C0, 0x4380, 0x8341, 0x4100, 0x81C1, 0x8081, 0x4040,
                };
        /// <summary>
        /// CRC效验
        /// </summary>
        /// <param name="pucFrame">效验数据</param>
        /// <param name="usLen">数据长度</param>
        /// <returns>效验结果</returns>
        public static int Crc16(int index, byte[] pDataIn, int iLenIn)
        {

            UInt16 wResult = 0xffff;
            UInt16 wTableNo = 0;
            for (int i = index; i < index + iLenIn; i++)
            {
                wTableNo = (UInt16)((wResult & 0xff) ^ (pDataIn[i] & 0xff));
                wResult = (UInt16)(((wResult >> 8) & 0xff) ^ wCRC16Table[wTableNo]);
            }

            return wResult;
        }
        #endregion

        private void Start_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                Result.Text = "转换错误";
                return;
            }

            if (rhex.Checked == true)
            {
                byte[] sbuf = StringToHexbyte(textBox.Text);
                if (sbuf.Length > 0)
                {
                    textBox.Clear();
                    for (int i = 0; i < sbuf.Length; i++)
                    {
                        textBox.Text += sbuf[i].ToString("X2") + " ";
                    }
                     value = (UInt16)Crc16(0, sbuf, sbuf.Length);
                     length = sbuf.Length;
                     if (HexRadio.Checked == true)
                     {
                         Result.Text = "0x" + value.ToString("X4");
                         bytesnum.Text = "0x" + sbuf.Length.ToString("X4");
                     }
                     else
                     {
                         Result.Text = value.ToString();
                         bytesnum.Text = sbuf.Length.ToString();
                     }
                }
                else
                {
                    textBox.Clear();
                    Result.Text = "转换错误";
                    return;
                }

            }
            else
            {
                string s = textBox.Text;
                byte[] buf = Encoding.ASCII.GetBytes(s);
                value = (UInt16)Crc16(0, buf, buf.Length);
                length = buf.Length;
                if (HexRadio.Checked == true)
                {
                    Result.Text = "0x" + value.ToString("X4");
                    bytesnum.Text ="0x"+ buf.Length.ToString("X4");
                }
                else
                {
                    Result.Text = value.ToString();
                    bytesnum.Text = buf.Length.ToString();
                }
               // bytesnum.Text = buf.Length.ToString();
            }
        }
        private void rhex_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "") return;
            if (rhex.Checked == true)
            {
                string s = textBox.Text;
                byte[] sbuf = Encoding.ASCII.GetBytes(s);
                textBox.Clear();
                for (int i = 0; i < sbuf.Length; i++)
                {
                    textBox.Text += sbuf[i].ToString("X2") + " ";
                }
            }
            else
            {

                byte[] sbuf = StringToHexbyte(textBox.Text);
                if (sbuf.Length > 0)
                {
                    textBox.Text= Encoding.ASCII.GetString(sbuf);
                }
                else
                {
                    textBox.Clear();
                    return;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private byte[] StringToHexbyte(string s)  //将字符串中的16进制数提取到byte缓存中
        {
            List<byte> list = new List<byte>();
            int tmp = 0;
            int count = 0;
            int index = 0;
            byte[] buf = Encoding.ASCII.GetBytes(s);
            for (int i = 0; i < buf.Length; i++)
            {
                index = Array.IndexOf(Hexbufarry, buf[i]);
                if (index > -1)
                {
                    count++;
                    if (count == 1)
                    {
                        tmp = ((index > 15) ? index - 6 : index);
                    }
                    else if (count == 2)
                    {
                        tmp = tmp << 4;
                        tmp += ((index > 15) ? index - 6 : index);
                        list.Add((byte)tmp);
                        tmp = 0;
                        count = 0;
                    }

                }
                else if (count == 1)
                {
                    list.Add((byte)tmp);
                    tmp = 0;
                    count = 0;
                }
            }
            if (count == 1)
            {
                list.Add((byte)tmp);
                tmp = 0;
                count = 0;
            }
            byte[] sbuf = list.ToArray();
            return sbuf;
        }

        private void HexRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Result.Text == "" || Result.Text == "转换错误") return;
            if (HexRadio.Checked == true)
            {
                Result.Text = "0x" + value.ToString("X4");
                bytesnum.Text ="0x"+ length.ToString("X4");
            }
            else
            {
                Result.Text = value.ToString();
                bytesnum.Text = length.ToString();
            }
        }


    }
}
