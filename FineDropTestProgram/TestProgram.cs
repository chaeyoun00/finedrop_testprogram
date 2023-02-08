using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Diagnostics;
using System.Security.Cryptography;

namespace FineDropTestProgram
{
    public partial class Form1 : Form
    {
        MqttClient mqttClient;

        int i;
        bool multiselected = false;

        public Timer[] timers = new Timer[1000];
        public Timer[] timerCount = new Timer[1000];
        public int[] timercheck = new int[1000];

        public Form1()
        {
            i = 1;
            InitializeComponent();

            TimerStartAt.Enabled = true;
            TimerStartAt.Tick += Timer_tick;

            FDCountBox.Text = "0";
            FDradioBattery3.Checked = true;

            ColumnHeader header = new ColumnHeader();
            header.Text = "Serial.No";
            header.Name = "col1";
            header.Width = 170;
            FDListView.Columns.Add(header);
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            FDStartAtBox.Text = DateTime.Now.ToString();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                mqttClient = new MqttClient(HOST.Text, Int16.Parse(PORT.Text), false, null, null, MqttSslProtocols.None); //보안접속 안함 / 1883  //192.168.50.100
                if (mqttClient.Connect(Guid.NewGuid().ToString(), ID.Text, PW.Text) == 0)
                {
                    Connect.BackColor = Color.LightGreen;
                    mqttClient.ConnectionClosed += Connection_ConnectionShutdown; //재연결
                    MessageBox.Show("Connected!");
                    FDCreateButton.Enabled = true; // 생성 버튼 활성화
                    FDFullDrop.Enabled = true;
                    FDBlock.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Connection Error!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!");
            }
        }

        private void Connection_ConnectionShutdown(object sender, EventArgs e)
        {
            MessageBox.Show("Connection broke!");
            Connect.BackColor = Color.Red;

            while (i == 1)
            {
                try
                {
                    mqttClient.Connect(Guid.NewGuid().ToString(), ID.Text, PW.Text);

                    MessageBox.Show("Reconnected!");
                    Connect.BackColor = Color.LightGreen;
                    break;
                }
                catch (Exception)
                {
                    MessageBox.Show("Reconnect failed!");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                mqttClient.Disconnect();
            }
            catch (Exception)
            {
                MessageBox.Show("End the program...");
            }

            i = 0; //재연결 시도 방지
        }

        private void FDRandomButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            string hex = null;

            for (int i = 0; i < 12; i++)
            {
                int randomIndex = rand.Next(16);
                hex += randomIndex.ToString("X");
            }
            FDSerialBox.Text = hex;
        }

        private void FDFullDrop_Click(object sender, EventArgs e)
        {
            FDIntervalBar.Value = 0;
            FDIntervalValueBox.Text = "0";
        }

        private void FDBlock_Click(object sender, EventArgs e)
        {
            FDIntervalBar.Value = Convert.ToInt32("FFFF", 16);
            FDIntervalValueBox.Text = "65535";
        }

        private void FDCreateButton_Click(object sender, EventArgs e)
        {

            if (FDnumericUpDown.Value == 0)
            {
                string serial = FDSerialBox.Text;
                char[] numbers = serial.ToCharArray();

                if (serial.Length != 12)
                {
                    MessageBox.Show("it is not 12 digits.");
                    return;
                }
                else
                {
                    foreach (char number in numbers)
                    {
                        if (Uri.IsHexDigit(number) == false)
                        {
                            MessageBox.Show("It contains values that are not hexadecimal.");
                            return;
                        }
                    }
                }

                for (int x = 0; x < FDListView.Items.Count; x++)
                {
                    if (FDListView.Items[x].SubItems[0].Text.Contains(serial))
                    {
                        MessageBox.Show("There is duplicate serial number.");
                        return;
                    }
                }

                string interval = FDIntervalBar.Value.ToString("X4");

                string battery = 3.ToString("X2");
                if (FDradioBattery0.Checked)
                {
                    battery = 0.ToString("X2");
                }
                else if (FDradioBattery1.Checked)
                {
                    battery = 1.ToString("X2");
                }
                else if (FDradioBattery2.Checked)
                {
                    battery = 2.ToString("X2");
                }
                else if (FDradioBattery3.Checked)
                {
                    battery = 3.ToString("X2");
                }

                string packet = serial + interval + "0000" + battery + "0000";

                string fullDrop = "0";

                string[] settings = new string[] { serial, DateTime.Now.ToString("yyyy-MM-dd tt hh:mm:ss"), packet, fullDrop };
                ListViewItem devieceInfrom = new ListViewItem(settings);
                FDListView.Items.Add(devieceInfrom);

                timers[FDListView.Items.Count - 1] = new Timer();
                timerCount[FDListView.Items.Count - 1] = new Timer();
                timercheck[FDListView.Items.Count - 1] = 0;
            }
            else
            {
                List<String> serial = new List<string>();

                for (int i = 0; i < FDnumericUpDown.Value; i++)
                {
                    Random rand = new Random();

                    string hex = null;
                    for (int j = 0; j < 12; j++)
                    {
                        int randomIndex = rand.Next(16);
                        hex += randomIndex.ToString("X");
                    }
                    serial.Add(hex);

                    if (serial.Count != serial.Distinct().Count())
                    {
                        i -= 1;
                        serial.Remove(hex);
                    }
                }

                string interval = FDIntervalBar.Value.ToString("X4");

                string battery = 3.ToString("X2");
                if (FDradioBattery0.Checked)
                {
                    battery = 0.ToString("X2");
                }
                else if (FDradioBattery1.Checked)
                {
                    battery = 1.ToString("X2");
                }
                else if (FDradioBattery2.Checked)
                {
                    battery = 2.ToString("X2");
                }
                else if (FDradioBattery3.Checked)
                {
                    battery = 3.ToString("X2");
                }

                for (int i = 0; i < FDnumericUpDown.Value; i++)
                {
                    string packet = serial[i] + interval + "0000" + battery + "0000";

                    string fullDrop = "0";

                    string[] settings = new string[] { serial[i], DateTime.Now.ToString("yyyy-MM-dd tt hh:mm:ss"), packet, fullDrop };
                    ListViewItem devieceInfrom = new ListViewItem(settings);
                    FDListView.Items.Add(devieceInfrom);

                    timers[FDListView.Items.Count - 1] = new Timer();
                    timerCount[FDListView.Items.Count - 1] = new Timer();
                    timercheck[FDListView.Items.Count - 1] = 0;
                }
            }

            FDSerialBox.Text = " ";
            FDnumericUpDown.Value = 0;
            FDIntervalBar.Value = 0;
            FDCountBox.Text = "0";
            FDradioBattery3.Checked = true;

            FDFullDrop.Enabled = true;
            FDBlock.Enabled = true;

            FDListView.View = View.Details;
        }

        private void FDEditButton_Click(object sender, EventArgs e)
        {
            string interval = FDIntervalBar.Value.ToString("X4");

            string battery = 3.ToString("X2");
            if (FDradioBattery0.Checked)
            {
                battery = 0.ToString("X2");
            }
            else if (FDradioBattery1.Checked)
            {
                battery = 1.ToString("X2");
            }
            else if (FDradioBattery2.Checked)
            {
                battery = 2.ToString("X2");
            }
            else if (FDradioBattery3.Checked)
            {
                battery = 3.ToString("X2");
            }

            if (multiselected)
            {
                for (int a = 0; a < FDListView.CheckedItems.Count; a++)
                {
                    string serial = FDListView.CheckedItems[a].SubItems[0].Text;
                    string packet = FDListView.CheckedItems[a].SubItems[2].Text;
                    string dropCount = packet.Substring(16, 4);
                    string packetCount = packet.Substring(22, 4);

                    if (interval == "0000")
                    {
                        packet = Encrypt(FDListView.CheckedItems[a].SubItems[2].Text);
                        FDListView.CheckedItems[0].SubItems[3].Text = "1";

                        Guid myuuid = Guid.NewGuid();
                        string messageID = "\"messageId\":\"" + myuuid.ToString() + "\",";
                        string messageType = "\"messageType\":\"beaconData\",";
                        string payload = "\"payload\":{\"data\":\"" + packet + "\"}";
                        string publishData = "{"+ messageID + messageType + payload + "}";
                        mqttClient.Publish("lighten/finedrop/" + serial + "/data", Encoding.UTF8.GetBytes(publishData));

                        MessageBox.Show("Full Drop has occurred.\n" + packet);
                        interval = "0001";
                    }
                    else
                    {
                        FDListView.CheckedItems[a].SubItems[3].Text = "0";
                    }

                    packet = FDListView.CheckedItems[a].SubItems[0].Text + interval + dropCount + battery + packetCount;
                    FDListView.CheckedItems[a].SubItems[2].Text = packet;
                }
            }
            else
            {
                string serial = FDListView.CheckedItems[0].SubItems[0].Text;
                string packet = FDListView.CheckedItems[0].SubItems[2].Text;
                string dropCount = packet.Substring(16, 4);
                string packetCount = packet.Substring(22, 4);

                if (interval == "0000")
                {
                    packet = Encrypt(FDListView.CheckedItems[0].SubItems[2].Text);
                    FDListView.CheckedItems[0].SubItems[3].Text = "1";

                    Guid myuuid = Guid.NewGuid();
                    string messageID = "\"messageId\":\"" + myuuid.ToString() + "\",";
                    string messageType = "\"messageType\":\"beaconData\",";
                    string payload = "\"payload\":{\"data\":\"" + packet + "\"}";
                    string publishData = "{" + messageID + messageType + payload + "}";
                    mqttClient.Publish("lighten/finedrop/" + serial + "/data", Encoding.UTF8.GetBytes(publishData));
                    MessageBox.Show("Full Drop has occurred.\n" + packet);
                    interval = "0001";
                }
                else
                {
                    FDListView.CheckedItems[0].SubItems[3].Text = "0";
                }

                FDListView.CheckedItems[0].SubItems[2].Text = FDListView.CheckedItems[0].SubItems[0].Text + interval + dropCount + battery + packetCount;
            }

            MessageBox.Show("Edit Complete!");

            TimerStartAt.Enabled = true;

            FDSerialBox.Text = "";
            FDSerialBox.ReadOnly = false;
            FDRandomButton.Enabled = true;
            FDIntervalBar.Value = 0;
            FDIntervalValueBox.Text = "0";
            FDCountBox.Text = "0";

            FDCheckBox.Checked = false;

            foreach (ListViewItem device in FDListView.Items)
            {
                device.Checked = false;
                device.Selected = false;
            }
        }

        private void FDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TimerStartAt.Enabled = true;

            FDIntervalBar.Value = 0;
            FDIntervalValueBox.Text = "0";
            FDCountBox.Text = "0";

            if (FDCheckBox.Checked == true)
            {
                foreach (ListViewItem device in FDListView.Items)
                {
                    device.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem device in FDListView.Items)
                {
                    device.Checked = false;
                }
            }
        }

        private void FDListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FDListView.SelectedItems.Count == 1)
            {
                TimerStartAt.Enabled = false;

                FDSerialBox.ReadOnly = true;
                FDRandomButton.Enabled = false;
                FDCreateButton.Enabled = false;

                FDEditButton.Enabled = false;

                int selectRow = FDListView.SelectedItems[0].Index;
                string packet = FDListView.Items[selectRow].SubItems[2].Text;

                string serialNum = FDListView.Items[selectRow].SubItems[0].Text;
                string startAt = FDListView.Items[selectRow].SubItems[1].Text;

                string interval = packet.Substring(12, 4);
                string count = packet.Substring(16, 4);
                string battery = packet.Substring(20, 2);

                FDSerialBox.Text = serialNum;
                FDIntervalBar.Value = Convert.ToInt32(interval, 16);
                FDIntervalValueBox.Text = Convert.ToString(FDIntervalBar.Value);
                FDCountBox.Text = Convert.ToString(Convert.ToInt32(count, 16));
                if (battery == "00")
                {
                    FDradioBattery0.Checked = true;
                }
                else if (battery == "01")
                {
                    FDradioBattery1.Checked = true;
                }
                else if (battery == "02")
                {
                    FDradioBattery2.Checked = true;
                }
                else if (battery == "03")
                {
                    FDradioBattery3.Checked = true;
                }
                FDStartAtBox.Text = startAt;
            }
            else
            {
                TimerStartAt.Enabled = true;

                FDSerialBox.Text = "";
                FDSerialBox.ReadOnly = false;
                FDRandomButton.Enabled = true;
                FDCreateButton.Enabled = true;

                FDIntervalBar.Value = 0;
                FDIntervalValueBox.Text = "0";

                FDCountBox.Text = "0";
                FDradioBattery3.Checked = true;
            }
        }

        private void FDListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem device = (ListViewItem)e.Item;

            if (FDListView.CheckedItems.Count == 1)
            {
                multiselected = false;

                TimerStartAt.Enabled = false;

                FDSerialBox.ReadOnly = true;
                FDRandomButton.Enabled = false;
                FDFullDrop.Enabled = true;
                FDBlock.Enabled = true;

                FDCreateButton.Enabled = false;
                FDEditButton.Enabled = false;

                int dropCount = Convert.ToInt32(FDListView.CheckedItems[0].SubItems[2].Text.Substring(16, 4), 16);
                if (dropCount > 20 || FDListView.CheckedItems[0].BackColor != Color.GreenYellow)
                {
                    FDEditButton.Enabled = true;
                }

                FDSerialBox.Text = device.SubItems[0].Text;
                string packet = device.SubItems[2].Text;
                string interval = packet.Substring(12, 4);
                string count = packet.Substring(16, 4);
                string battery = packet.Substring(20, 2);

                FDIntervalBar.Value = Convert.ToInt32(interval, 16);
                FDIntervalValueBox.Text = Convert.ToString(FDIntervalBar.Value);
                FDCountBox.Text = Convert.ToString(Convert.ToInt32(count, 16));
                if (battery == "00")
                {
                    FDradioBattery0.Checked = true;
                }
                else if (battery == "01")
                {
                    FDradioBattery1.Checked = true;
                }
                else if (battery == "02")
                {
                    FDradioBattery2.Checked = true;
                }
                else if (battery == "03")
                {
                    FDradioBattery3.Checked = true;
                }
                FDStartAtBox.Text = device.SubItems[1].Text;
            }
            else if (FDListView.CheckedItems.Count > 1)
            {
                multiselected = true;

                TimerStartAt.Enabled = false;

                FDSerialBox.Text = "다중 선택 중";
                FDSerialBox.ReadOnly = true;
                FDRandomButton.Enabled = false;

                FDFullDrop.Enabled = true;
                FDBlock.Enabled = true;

                FDCreateButton.Enabled = false;
                FDEditButton.Enabled = true;
            }
            else
            {
                multiselected = false;

                TimerStartAt.Enabled = true;

                FDSerialBox.Text = "";
                FDSerialBox.ReadOnly = false;
                FDRandomButton.Enabled = true;

                FDFullDrop.Enabled = true;
                FDBlock.Enabled = true;

                FDIntervalBar.Value = 0;
                FDIntervalValueBox.Text = "0";
                FDCountBox.Text = "0";
                FDradioBattery3.Checked = true;

                FDCreateButton.Enabled = true;
                FDEditButton.Enabled = false;
            }
        }

        private void FDOn_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (ListViewItem device in FDListView.Items)
            {
                if (device.Checked == true && device.SubItems[0].BackColor != Color.GreenYellow)
                {
                    int interval = Convert.ToInt32(device.SubItems[2].Text.Substring(12, 4), 16);
                    if (interval == 0)
                    {
                        if (check == 0)
                        {
                            MessageBox.Show("The initial interval value cannot be 0.");
                        }

                        if (multiselected)
                        {
                            check = 1;
                        }
                    }
                    else if (device.SubItems[0].BackColor != Color.GreenYellow)
                    {
                        device.SubItems[0].BackColor = Color.GreenYellow;
                        device.Checked = false;

                        string packetEncrypt = Encrypt(device.SubItems[0].Text + "00000000000000");

                        Guid myuuid = Guid.NewGuid();
                        string messageID = "\"messageId\":\"" + myuuid.ToString() + "\",";
                        string messageType = "\"messageType\":\"beaconData\",";
                        string payload = "\"payload\":{\"data\":\"" + packetEncrypt + "\"}";
                        string publishData = "{" + messageID + messageType + payload + "}";
                        mqttClient.Publish("lighten/finedrop/" + device.SubItems[0].Text + "/data", Encoding.UTF8.GetBytes(publishData));
                        timers[device.Index].Tick += (sender_, e_) => { TimerEventProcessor(device); };
                        timers[device.Index].Enabled = true;
                    }
                }
                device.Selected = false;
            }
            FDCheckBox.Checked = false;
        }

        private void FDOff_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem device in FDListView.Items)
            {
                if (device.Checked == true)
                {
                    device.SubItems[0].BackColor = Color.White;
                    device.Checked = false;

                    string serial = device.SubItems[0].Text;
                    device.SubItems[2].Text = serial + "0000" + "0000" + "03" + "0000";

                    timers[device.Index].Enabled = false;
                    timerCount[device.Index].Enabled = false;
                    timercheck[device.Index] = 0;
                }
                device.Selected = false;
            }
            FDCheckBox.Checked = false;
        }

        private void FDIntervalBar_Scroll(object sender, EventArgs e)
        {
            FDIntervalValueBox.Text = Convert.ToString(FDIntervalBar.Value);
        }

        private void TimerEventProcessor(ListViewItem device)
        {
            string packet = device.SubItems[2].Text;
            string serial = device.SubItems[0].Text;
            int dropCount = Convert.ToInt32(packet.Substring(16, 4), 16);
            int interval = Convert.ToInt32(packet.Substring(12, 4), 16);
            int packetCount = Convert.ToInt32(packet.Substring(22, 4), 16);

            if (dropCount <= 20)
            {
                timers[device.Index].Interval = interval * 100;

                string dropCountString = (dropCount + 1).ToString("X4");
                packet = packet.Remove(16, 4).Insert(16, dropCountString);
                device.SubItems[2].Text = packet;
            }
            else
            {
                timers[device.Index].Interval = 10000;
                if (timercheck[device.Index] == 0)
                {
                    timerCount[device.Index].Tick += (sender, e) => { TimerEventCount(device); };
                }
                timerCount[device.Index].Interval = interval * 100;
                timerCount[device.Index].Enabled = true;
                timercheck[device.Index] = 1;

                //MessageBox.Show(packet);

                string count = (packetCount + 1).ToString("X4");
                packet = packet.Remove(22, 4).Insert(22, count);
                device.SubItems[2].Text = packet;
            }

            string packetEncrypt = Encrypt(packet);
            Guid myuuid = Guid.NewGuid();
            string messageID = "\"messageId\":\"" + myuuid.ToString() + "\",";
            string messageType = "\"messageType\":\"beaconData\",";
            string payload = "\"payload\":{\"data\":\"" + packetEncrypt + "\"}";
            string publishData = "{" + messageID + messageType + payload + "}";
            mqttClient.Publish("lighten/finedrop/" + serial + "/data", Encoding.UTF8.GetBytes(publishData));
            Guid myuuid1 = Guid.NewGuid();
            string message1ID = "\"messageId\":\"" + myuuid1.ToString() + "\",";
            string message1Type = "\"messageType\":\"beaconData\",";
            string payload1 = "\"payload\":{\"data\":\"" + packetEncrypt + "\"}";
            string publishData1 = "{" + message1ID + message1Type + payload1 + "}";
            mqttClient.Publish("lighten/finedrop/" + serial + "/data", Encoding.UTF8.GetBytes(publishData1));
            Guid myuuid2 = Guid.NewGuid();
            string messageID2 = "\"messageId\":\"" + myuuid2.ToString() + "\",";
            string messageType2 = "\"messageType\":\"beaconData\",";
            string payload2 = "\"payload\":{\"data\":\"" + packetEncrypt + "\"}";
            string publishData2 = "{" + messageID2 + messageType2 + payload2 + "}";
            mqttClient.Publish("lighten/finedrop/" + serial + "/data", Encoding.UTF8.GetBytes(publishData2));
            Guid myuuid3 = Guid.NewGuid();
            string messageID3 = "\"messageId\":\"" + myuuid.ToString() + "\",";
            string messageType3 = "\"messageType\":\"beaconData\",";
            string payload3 = "\"payload\":{\"data\":\"" + packetEncrypt + "\"}";
            string publishData3 = "{" + messageID3 + messageType3 + payload3 + "}";
            mqttClient.Publish("lighten/finedrop/" + serial + "/data", Encoding.UTF8.GetBytes(publishData3));
        }

        private void TimerEventCount(ListViewItem device)
        {
            if (device.SubItems[3].Text == "0")
            {
                string packet = device.SubItems[2].Text;
                ushort dropCount = Convert.ToUInt16(packet.Substring(16, 4), 16);
                if (dropCount < 65535)
                {
                    dropCount += 1;
                }

                packet = packet.Remove(16, 4).Insert(16, dropCount.ToString("X4"));
                device.SubItems[2].Text = packet;
            }
        }

        private string Encrypt(string packet)
        {
            RijndaelManaged Cipher = new RijndaelManaged();
            Cipher.Mode = CipherMode.CBC;
            Cipher.KeySize = 128;

            byte[] key = MakeKey(packet.Substring(0, 12));
            Cipher.Key = key;
            Cipher.IV = key;

            byte[] encData = HexToByteArray(packet.Substring(12));
            ICryptoTransform encrypt = Cipher.CreateEncryptor(Cipher.Key, Cipher.IV);
            byte[] cipherBytes = encrypt.TransformFinalBlock(encData, 0, encData.Length);
            Cipher.Clear();

            string data = "";
            foreach (byte x in cipherBytes)
            {
                data += x.ToString("x2");
            }

            //MessageBox.Show(packet + "," + (packet.Substring(0, 12) + data).ToUpper());
            //MessageBox.Show(Decrypt(packet.Substring(0, 12) + data).ToUpper());
            return (packet.Substring(0, 12) + data).ToUpper();
        }

        private string Decrypt(string packet)
        {
            RijndaelManaged Cipher = new RijndaelManaged();
            Cipher.Mode = CipherMode.CBC;
            Cipher.KeySize = 128;

            byte[] key = MakeKey(packet.Substring(0, 12));
            Cipher.Key = key;
            Cipher.IV = key;

            byte[] encData = HexToByteArray(packet.Substring(12));
            ICryptoTransform encrypt = Cipher.CreateDecryptor(Cipher.Key, Cipher.IV);
            // 암호화 수행
            byte[] cipherBytes = encrypt.TransformFinalBlock(encData, 0, encData.Length);
            Cipher.Clear();

            string data = "";
            foreach (byte x in cipherBytes)
            {
                data += x.ToString("x2");
            }

            return data;
        }

        private byte[] MakeKey(string serial)
        {
            int[] serial_A = HexToIntArray(serial);
            int[] key = new int[] { 0x67, 0x20, 0x03, 0x22, 0x45, 0xFB, 0xC1, 0x7B, 0x9A, 0xCE, 0xFD, 0xA0, 0x97, 0x87, 0x16, 0x61 };

            byte mask = 0b111;
            int rotateCount = (serial_A[0] & mask);

            Array.Copy(serial_A, 0, key, rotateCount, 6);

            for (int i = rotateCount; i < rotateCount + 6; i++)
            {
                int tmp = serial_A[i - rotateCount];
                int j;
                for (j = 0; tmp != 0; j++)
                {
                    tmp &= tmp - 1;
                }
                if (j > 4) key[i] = UnsignedRotateR(serial_A[i - rotateCount], j);
                else key[i] = UnsignedRotateL(serial_A[i - rotateCount], j);
            }
            byte[] btKey = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                btKey[i] = (byte)key[i];
            }
            return btKey;
        }

        private int[] HexToIntArray(string serial)
        {
            int len = serial.Length;
            int[] data = new int[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                char character = serial[i];
                char character_A = serial[i + 1];
                data[i / 2] = (Convert.ToInt32(character.ToString(), 16) << 4) + Convert.ToInt32(character_A.ToString(), 16);
            }
            return data;
        }

        private byte[] HexToByteArray(string encData)
        {
            int len = encData.Length;
            byte[] data = new byte[len / 2];
            for (int i = 0; i < len; i += 2)
            {
                char character = encData[i];
                char character_A = encData[i + 1];
                data[i / 2] = Convert.ToByte((Convert.ToInt32(character.ToString(), 16) << 4) + Convert.ToInt32(character_A.ToString(), 16));
            }
            return data;
        }

        private byte UnsignedRotateR(int value, int rotateVal)
        {
            value >>= rotateVal;
            value &= 0b11111111;
            return (byte)value;
        }

        private byte UnsignedRotateL(int value, int rotateVal)
        {
            value <<= rotateVal;
            value &= 0b11111111;
            return (byte)value;
        }
    }
}
