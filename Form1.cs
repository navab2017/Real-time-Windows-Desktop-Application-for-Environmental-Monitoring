using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] tem1 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] tem2 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] tem3 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] tem4 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] hum1 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] hum2 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] hum3 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        string[] hum4 = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };



        string RxString1;
        string[] ArduinoData1 = null;
        string RxString2;
        string[] ArduinoData2 = null;
        string RxString3;
        string[] ArduinoData3 = null;
        string RxString4;
        string[] ArduinoData4 = null;

        string d1;
        string d2;
        string d3;
        string d4;
        string d5;
        string d6;
        string d7;
        string d8;

        string d11="";
        string d12 = "";
        string d13 = "";
        string d14 = "";
        string d15 = "";
        string d16 = "";
        string d17 = "";
        string d18 = "";


        string d21 = "";
        string d22 = "";
        string d23 = "";
        string d24 = "";
        string d25 = "";
        string d26 = "";
        string d27 = "";
        string d28 = "";

        string d31 = "";
        string d32 = "";
        string d33 = "";
        string d34 = "";
        string d35 = "";
        string d36 = "";
        string d37 = "";
        string d38 = "";

        string d41 = "";
        string d42 = "";
        string d43 = "";
        string d44 = "";
        string d45 = "";
        string d46 = "";
        string d47 = "";
        string d48 = "";

        int voicesen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
            RxString1 = serialPort1.ReadLine();
            ArduinoData1 = RxString1.Split(',', '\n', '\r');

            if (ArduinoData1.Count() == 8)
            {
                try
                {
                    d1 = ArduinoData1[0];
                    d2 = ArduinoData1[1];
                    d3 = ArduinoData1[2];
                    d4 = ArduinoData1[3];
                    d5 = ArduinoData1[4];
                    d6 = ArduinoData1[5];
                    d7 = ArduinoData1[6];
                    d8 = DateTime.Now.ToString();

                    if (d1 == "n1")
                    {
                        d11 = d2;
                        d12 = d3;
                        d13 = d4;
                        d14 = d5;
                        d15 = d6;
                        d16 = d7;
                        d17 = d8;
                    }
                    if (d1 == "n2")
                    {
                        d21 = d2;
                        d22 = d3;
                        d23 = d4;
                        d24 = d5;
                        d25 = d6;
                        d26 = d7;
                        d27 = d8;
                    }
                    if (d1 == "n3")
                    {
                        d31 = d2;
                        d32 = d3;
                        d33 = d4;
                        d34 = d5;
                        d35 = d6;
                        d36 = d7;
                        d37 = d8;
                    }
                    if (d1 == "n4")
                    {
                        d41 = d2;
                        d42 = d3;
                        d43 = d4;
                        d44 = d5;
                        d45 = d6;
                        d46 = d7;
                        d47 = d8;
                    }
                }
                catch { }
            }
                        }
            catch
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort2.Open();
            serialPort3.Open();
            serialPort4.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = "";
            string text = "";

            string aa = "0";
            if (d11 == "") d11 = "0";
            if (d12 == "") d12 = "0";
            if (d13 == "") d13 = "0";
            if (d14 == "") d14 = "0";
            if (d15 == "") d15 = "0";
            if (d16 == "") d16 = "0";
            if (d17 == "") d17 = "0";

            if (d21 == "") d21 = "0";
            if (d22 == "") d22 = "0";
            if (d23 == "") d23 = "0";
            if (d24 == "") d24 = "0";
            if (d25 == "") d25 = "0";
            if (d26 == "") d26 = "0";
            if (d27 == "") d27 = "0";

            if (d31 == "") d31 = "0";
            if (d32 == "") d32 = "0";
            if (d33 == "") d33 = "0";
            if (d34 == "") d34 = "0";
            if (d35 == "") d35 = "0";
            if (d36 == "") d36 = "0";
            if (d37 == "") d37 = "0";

            if (d41 == "") d41 = "0";
            if (d42 == "") d42 = "0";
            if (d43 == "") d43 = "0";
            if (d44 == "") d44 = "0";
            if (d45 == "") d45 = "0";
            if (d46 == "") d46 = "0";
            if (d47 == "") d47 = "0";



            textBox1.Text = d17;
            textBox2.Text = d11;
            textBox3.Text = d12;
            textBox4.Text = d13;
            textBox5.Text = d14;
            if (IsBitSet(Convert.ToByte(d15), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            textBox6.Text = aa;
            if (IsBitSet(Convert.ToByte(d15), 1))
            {
                aa = "1";

                string[] file4 = File.ReadAllLines("mode.txt");
                if (file4[0] != "0")
                {
                    if (voicesen < 10) voicesen = voicesen + 1;
                    if (voicesen > 3)
                    {
                        if (voicesen < 10)
                        {
                            voicesen = 11;
                            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
                            path = path + "\\data1.txt";
                            text = file4[0];
                            System.IO.File.AppendAllText(@path, text);
                        }
                    }
                }
            }
            else
            {
                aa = "0";
                voicesen = 0;
            }
            textBox29.Text = aa;
            textBox7.Text = d16;

            textBox8.Text = d27;
            textBox9.Text = d21;
            textBox11.Text = d22;
            textBox13.Text = d23;
            textBox14.Text = d24;
            if (IsBitSet(Convert.ToByte(d25), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            textBox12.Text = aa;
            if (IsBitSet(Convert.ToByte(d25), 1))
            {
                aa = "1";

            }
            else
            {
                aa = "0";
            }
            textBox30.Text = aa; 
            textBox10.Text = d26;

            textBox15.Text = d37;
            textBox16.Text = d31;
            textBox18.Text = d32;
            textBox20.Text = d33;
            textBox21.Text = d34;
            if (IsBitSet(Convert.ToByte(d35), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            textBox19.Text = aa;
            if (IsBitSet(Convert.ToByte(d35), 1))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            textBox31.Text = aa; 
            textBox17.Text = d36;

            textBox22.Text = d47;
            textBox23.Text = d41;
            textBox25.Text = d42;
            textBox27.Text = d43;
            textBox28.Text = d44;
            if (IsBitSet(Convert.ToByte(d45), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            textBox26.Text = aa;
            if (IsBitSet(Convert.ToByte(d45), 1))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            textBox32.Text = aa;
            textBox24.Text = d46;

            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            //path = "C:\\xampp\\htdocs\\log.txt";
            path = path+"\\log.txt";

            text = "1- Last Update : \t" + d17 + "\t Temp = " + d13 + "\t H = " + d14 + "\t";
            if (d15 == "0") text = text + " SEN1 = 0 \t SEN2 = 0 ";
            if (d15 == "1") text = text + " SEN1 = 0 \t SEN2 = 1 ";
            if (d15 == "2") text = text + " SEN1 = 1 \t SEN2 = 0 ";
            if (d15 == "3") text = text + " SEN1 = 1 \t SEN2 = 1 ";
            text = text + "\t Lat =" + d11 + "\t Lon =" + d12 + Environment.NewLine;

            text = text + "2- Last Update : \t" + d27 + "\t Temp = " + d23 + "\t H = " + d24 + "\t";
            if (d25 == "0") text = text + " SEN1 = 0 \t SEN2 = 0 ";
            if (d25 == "1") text = text + " SEN1 = 0 \t SEN2 = 1 ";
            if (d25 == "2") text = text + " SEN1 = 1 \t SEN2 = 0 ";
            if (d25 == "3") text = text + " SEN1 = 1 \t SEN2 = 1 ";
            text = text + "\t Lat =" + d21 + "\t Lon =" + d22 + Environment.NewLine;
            
            text = text + "3- Last Update : \t" + d37 + "\t Temp = " + d33 + "\t H = " + d34 + "\t";
            if (d35 == "0") text = text + " SEN1 = 0 \t SEN2 = 0 ";
            if (d35 == "1") text = text + " SEN1 = 0 \t SEN2 = 1 ";
            if (d35 == "2") text = text + " SEN1 = 1 \t SEN2 = 0 ";
            if (d35 == "3") text = text + " SEN1 = 1 \t SEN2 = 1 ";
            text = text + "\t Lat =" + d31 + "\t Lon =" + d32 + Environment.NewLine;
            
            text = text + "4- Last Update : \t" + d47 + "\t Temp = " + d44 + "\t H = " + d44 + "\t";
            if (d45 == "0") text = text + " SEN1 = 0 \t SEN2 = 0 ";
            if (d45 == "1") text = text + " SEN1 = 0 \t SEN2 = 1 ";
            if (d45 == "2") text = text + " SEN1 = 1 \t SEN2 = 0 ";
            if (d45 == "3") text = text + " SEN1 = 1 \t SEN2 = 1 ";
            text = text + "\t Lat =" + d41 + "\t Lon =" + d42 + Environment.NewLine;
            
            text=text+Environment.NewLine;

            System.IO.File.AppendAllText(@path, text);


            for (int ii = 0; ii < 9; ii++)
            {
                tem1[ii] = tem1[ii + 1];
                tem2[ii] = tem2[ii + 1];
                tem3[ii] = tem3[ii + 1];
                tem4[ii] = tem4[ii + 1];
            }
            tem1[9] = d13;
            tem2[9] = d23;
            tem3[9] = d33;
            tem4[9] = d43;

            for (int ii = 0; ii < 9; ii++)
            {
                hum1[ii] = hum1[ii + 1];
                hum2[ii] = hum2[ii + 1];
                hum3[ii] = hum3[ii + 1];
                hum4[ii] = hum4[ii + 1];
            }
            hum1[9] = d13;
            hum2[9] = d23;
            hum3[9] = d33;
            hum4[9] = d43;


 //////TEMP
            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            path = path + "\\at.txt";
            text="data: [";
            text=text+tem1[0]+",";
            text=text+tem1[1]+",";
            text=text+tem1[2]+",";
            text=text+tem1[3]+",";
            text=text+tem1[4]+",";
            text=text+tem1[5]+",";
            text=text+tem1[6]+",";
            text=text+tem1[7]+",";
            text=text+tem1[8]+",";
            text=text+tem1[9]+"]"+ Environment.NewLine;
            text=text+"}, {name: 'node2',data: [";
            text=text+tem2[0]+",";
            text=text+tem2[1]+",";
            text=text+tem2[2]+",";
            text=text+tem2[3]+",";
            text=text+tem2[4]+",";
            text=text+tem2[5]+",";
            text=text+tem2[6]+",";
            text=text+tem2[7]+",";
            text=text+tem2[8]+",";
            text=text+tem2[9]+"]"+ Environment.NewLine;
            text=text+"}, {name: 'node3',data: [";
            text=text+tem3[0]+",";
            text=text+tem3[1]+",";
            text=text+tem3[2]+",";
            text=text+tem3[3]+",";
            text=text+tem3[4]+",";
            text=text+tem3[5]+",";
            text=text+tem3[6]+",";
            text=text+tem3[7]+",";
            text=text+tem3[8]+",";
            text=text+tem3[9]+"]"+ Environment.NewLine;
            text=text+"}, {name: 'node4',data: [";
            text=text+tem4[0]+",";
            text=text+tem4[1]+",";
            text=text+tem4[2]+",";
            text=text+tem4[3]+",";
            text=text+tem4[4]+",";
            text=text+tem4[5]+",";
            text=text+tem4[6]+",";
            text=text+tem4[7]+",";
            text=text+tem4[8]+",";
            text=text+tem4[9]+"]"+ Environment.NewLine;
            System.IO.File.WriteAllText(@path, text);
            string[] file1 = File.ReadAllLines("a1t.txt");
            string[] file2 = File.ReadAllLines("at.txt");
            using (StreamWriter writer = File.CreateText(@"at1.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }
            file1 = File.ReadAllLines("at1.txt");
            file2 = File.ReadAllLines("a2t.txt");
            using (StreamWriter writer = File.CreateText(@"tem-chart\index.htm"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }




//////HUM
            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            path = path + "\\ah.txt";
            text = "data: [";
            text = text + hum1[0] + ",";
            text = text + hum1[1] + ",";
            text = text + hum1[2] + ",";
            text = text + hum1[3] + ",";
            text = text + hum1[4] + ",";
            text = text + hum1[5] + ",";
            text = text + hum1[6] + ",";
            text = text + hum1[7] + ",";
            text = text + hum1[8] + ",";
            text = text + hum1[9] + "]" + Environment.NewLine;
            text = text + "}, {name: 'node2',data: [";
            text = text + hum2[0] + ",";
            text = text + hum2[1] + ",";
            text = text + hum2[2] + ",";
            text = text + hum2[3] + ",";
            text = text + hum2[4] + ",";
            text = text + hum2[5] + ",";
            text = text + hum2[6] + ",";
            text = text + hum2[7] + ",";
            text = text + hum2[8] + ",";
            text = text + hum2[9] + "]" + Environment.NewLine;
            text = text + "}, {name: 'node3',data: [";
            text = text + hum3[0] + ",";
            text = text + hum3[1] + ",";
            text = text + hum3[2] + ",";
            text = text + hum3[3] + ",";
            text = text + hum3[4] + ",";
            text = text + hum3[5] + ",";
            text = text + hum3[6] + ",";
            text = text + hum3[7] + ",";
            text = text + hum3[8] + ",";
            text = text + hum3[9] + "]" + Environment.NewLine;
            text = text + "}, {name: 'node4',data: [";
            text = text + hum4[0] + ",";
            text = text + hum4[1] + ",";
            text = text + hum4[2] + ",";
            text = text + hum4[3] + ",";
            text = text + hum4[4] + ",";
            text = text + hum4[5] + ",";
            text = text + hum4[6] + ",";
            text = text + hum4[7] + ",";
            text = text + hum4[8] + ",";
            text = text + hum4[9] + "]" + Environment.NewLine;
            System.IO.File.WriteAllText(@path, text);
            file1 = File.ReadAllLines("a1h.txt");
            file2 = File.ReadAllLines("ah.txt");
            using (StreamWriter writer = File.CreateText(@"ah1.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }
            file1 = File.ReadAllLines("ah1.txt");
            file2 = File.ReadAllLines("a2h.txt");
            using (StreamWriter writer = File.CreateText(@"hum-chart\index.htm"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }

//////ALL
            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            path = path + "\\a.txt";

            text = "<html>" + Environment.NewLine;
            text = text + "<script type=\"text/javascript\">" + Environment.NewLine;
    
            /* temp variable */
            text = text + "var rpi_dht22_11_temp =" + d13 + ";" + Environment.NewLine;
            text = text + "var rpi_dht22_13_temp =" + d23 + ";" + Environment.NewLine;
            text = text + "var rpi_dht22_15_temp =" + d33 + ";" + Environment.NewLine;
            text = text + "var rpi_dht22_17_temp =" + d43 + ";" + Environment.NewLine;

            /* humidity variable */
            text = text + "var rpi_dht22_11_hum =" + d14 + ";" + Environment.NewLine;
            text = text + "var rpi_dht22_13_hum =" + d24 + ";" + Environment.NewLine;
            text = text + "var rpi_dht22_15_hum =" + d34 + ";" + Environment.NewLine;
            text = text + "var rpi_dht22_17_hum =" + d44 + ";" + Environment.NewLine;
   
            // GPS lat and lon variable 
            text = text + "var lat_node1=" + d11 + ";" + Environment.NewLine;
            text = text + "var lat_node2=" + d21 + ";" + Environment.NewLine;
            text = text + "var lat_node3=" + d31 + ";" + Environment.NewLine;
            text = text + "var lat_node4=" + d41 + ";" + Environment.NewLine;
            text = text + "var lon_node1=" + d12 + ";" + Environment.NewLine;
            text = text + "var lon_node2=" + d22 + ";" + Environment.NewLine;
            text = text + "var lon_node3=" + d32 + ";" + Environment.NewLine;
            text = text + "var lon_node4=" + d42 + ";" + Environment.NewLine;
    
            // battery usage variable 
            text = text + "var batt_node1=" + d16 + ";" + Environment.NewLine;
            text = text + "var batt_node2=" + d26 + ";" + Environment.NewLine;
            text = text + "var batt_node3=" + d36 + ";" + Environment.NewLine;
            text = text + "var batt_node4=" + d46 + ";" + Environment.NewLine;
   
            // water test allarm variable 
            if (IsBitSet(Convert.ToByte(d15), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var watertest1_allarm=" + aa + ";" + Environment.NewLine;
            if (IsBitSet(Convert.ToByte(d25), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var watertest2_allarm=" + aa + ";" + Environment.NewLine;
            if (IsBitSet(Convert.ToByte(d35), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var watertest3_allarm=" + aa + ";" + Environment.NewLine;
            if (IsBitSet(Convert.ToByte(d45), 0))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var watertest4_allarm=" + aa + ";" + Environment.NewLine;
  
            // voice allarm variable 
            if (IsBitSet(Convert.ToByte(d15), 1))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var voice1_allarm=" + aa + ";" + Environment.NewLine;
            if (IsBitSet(Convert.ToByte(d25), 1))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var voice2_allarm=" + aa + ";" + Environment.NewLine;
            if (IsBitSet(Convert.ToByte(d35), 1))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var voice3_allarm=" + aa + ";" + Environment.NewLine;
            if (IsBitSet(Convert.ToByte(d45), 1))
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
            text = text + "var voice4_allarm=" + aa + ";" + Environment.NewLine;

            text = text + "var last_up_node1 = \"" + d17 + "\";" + Environment.NewLine;
            text = text + "var last_up_node2 = \"" + d27 + "\";" + Environment.NewLine;
            text = text + "var last_up_node3 = \"" + d37 + "\";" + Environment.NewLine;
            text = text + "var last_up_node4 = \"" + d47 + "\";" + Environment.NewLine;

            System.IO.File.WriteAllText(@path, text);


            file1 = File.ReadAllLines("a.txt");
            file2 = File.ReadAllLines("b.txt");
            using (StreamWriter writer = File.CreateText(@"cc.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }





            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            path = path + "\\c.txt";
            text = "<a href=\"https://maps.google.com/maps?q=" + d11 + "," + d12 +"\""+ Environment.NewLine;
            text = text + "class=\"btn-push navy\"> Location</a>";
            text = text + "</td>";
            text = text + "<td>";
            text = text + "<a href=\"https://maps.google.com/maps?q=" + d21 + "," + d22 + "\"" + Environment.NewLine;
            text = text + "class=\"btn-push navy\"> Location</a>";
            text = text + "</td>";
            text = text + "<td>";
            text = text + "<a href=\"https://maps.google.com/maps?q=" + d31 + "," + d32 + "\"" + Environment.NewLine;
            text = text + "class=\"btn-push navy\"> Location</a>";
            text = text + "</td>";
            text = text + "<td>";
            text = text + "<a href=\"https://maps.google.com/maps?q=" + d41 + "," + d42 + "\"" + Environment.NewLine;
            System.IO.File.WriteAllText(@path, text);








            file1 = File.ReadAllLines("cc.txt");
            file2 = File.ReadAllLines("c.txt");
            using (StreamWriter writer = File.CreateText(@"dd.txt"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }



            file1 = File.ReadAllLines("dd.txt");
            file2 = File.ReadAllLines("d.txt");
            using (StreamWriter writer = File.CreateText(@"index.php"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }


            /////////////////////////////
            path = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            path = path + "\\gp.txt";
            text = "<html>" + Environment.NewLine;
            text = text + "<script>" + Environment.NewLine;
            text = text + "var lat_node1=" + d11 + ";" + Environment.NewLine;
            text = text + "var lat_node2=" + d21 + ";" + Environment.NewLine;
            text = text + "var lat_node3=" + d31 + ";" + Environment.NewLine;
            text = text + "var lat_node4=" + d41 + ";" + Environment.NewLine;
            text = text + "var lon_node1=" + d12 + ";" + Environment.NewLine;
            text = text + "var lon_node2=" + d22 + ";" + Environment.NewLine;
            text = text + "var lon_node3=" + d32 + ";" + Environment.NewLine;
            text = text + "var lon_node4=" + d42 + ";" + Environment.NewLine;
            System.IO.File.WriteAllText(@path, text);

            file1 = File.ReadAllLines("gp.txt");
            file2 = File.ReadAllLines("gps.txt");
            using (StreamWriter writer = File.CreateText(@"gps.php"))
            {
                int lineNum = 0;
                while (lineNum < file1.Length)
                {
                    if (lineNum < file1.Length)
                        writer.WriteLine(file1[lineNum]);
                    lineNum++;
                }

                lineNum = 0;
                while (lineNum < file2.Length)
                {
                    if (lineNum < file2.Length)
                        writer.WriteLine(file2[lineNum]);
                    lineNum++;
                }
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
            RxString2 = serialPort2.ReadLine();
            ArduinoData2 = RxString2.Split(',', '\n', '\r');

            if (ArduinoData2.Count() == 8)
            {
                try
                {
                    d1 = ArduinoData2[0];
                    d2 = ArduinoData2[1];
                    d3 = ArduinoData2[2];
                    d4 = ArduinoData2[3];
                    d5 = ArduinoData2[4];
                    d6 = ArduinoData2[5];
                    d7 = ArduinoData2[6];
                    d8 = DateTime.Now.ToString();

                    if (d1 == "n1")
                    {
                        d11 = d2;
                        d12 = d3;
                        d13 = d4;
                        d14 = d5;
                        d15 = d6;
                        d16 = d7;
                        d17 = d8;
                    }
                    if (d1 == "n2")
                    {
                        d21 = d2;
                        d22 = d3;
                        d23 = d4;
                        d24 = d5;
                        d25 = d6;
                        d26 = d7;
                        d27 = d8;
                    }
                    if (d1 == "n3")
                    {
                        d31 = d2;
                        d32 = d3;
                        d33 = d4;
                        d34 = d5;
                        d35 = d6;
                        d36 = d7;
                        d37 = d8;
                    }
                    if (d1 == "n4")
                    {
                        d41 = d2;
                        d42 = d3;
                        d43 = d4;
                        d44 = d5;
                        d45 = d6;
                        d46 = d7;
                        d47 = d8;
                    }
                }
                catch { }
            }
                        }
            catch
            {
            }
        }

        private void serialPort4_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                RxString4 = serialPort4.ReadLine();
                ArduinoData4 = RxString4.Split(',', '\n', '\r');

                if (ArduinoData4.Count() == 8)
                {
                    try
                    {
                        d1 = ArduinoData4[0];
                        d2 = ArduinoData4[1];
                        d3 = ArduinoData4[2];
                        d4 = ArduinoData4[3];
                        d5 = ArduinoData4[4];
                        d6 = ArduinoData4[5];
                        d7 = ArduinoData4[6];
                        d8 = DateTime.Now.ToString();

                        if (d1 == "n1")
                        {
                            d11 = d2;
                            d12 = d3;
                            d13 = d4;
                            d14 = d5;
                            d15 = d6;
                            d16 = d7;
                            d17 = d8;
                        }
                        if (d1 == "n2")
                        {
                            d21 = d2;
                            d22 = d3;
                            d23 = d4;
                            d24 = d5;
                            d25 = d6;
                            d26 = d7;
                            d27 = d8;
                        }
                        if (d1 == "n3")
                        {
                            d31 = d2;
                            d32 = d3;
                            d33 = d4;
                            d34 = d5;
                            d35 = d6;
                            d36 = d7;
                            d37 = d8;
                        }
                        if (d1 == "n4")
                        {
                            d41 = d2;
                            d42 = d3;
                            d43 = d4;
                            d44 = d5;
                            d45 = d6;
                            d46 = d7;
                            d47 = d8;
                        }
                    }
                    catch { }
                }
            }
            catch
            {
            }
        }

        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            try
            {
                RxString3 = serialPort3.ReadLine();
                ArduinoData3 = RxString3.Split(',', '\n', '\r');

                if (ArduinoData3.Count() == 8)
                {
                    try
                    {
                        d1 = ArduinoData3[0];
                        d2 = ArduinoData3[1];
                        d3 = ArduinoData3[2];
                        d4 = ArduinoData3[3];
                        d5 = ArduinoData3[4];
                        d6 = ArduinoData3[5];
                        d7 = ArduinoData3[6];
                        d8 = DateTime.Now.ToString();

                        if (d1 == "n1")
                        {
                            d11 = d2;
                            d12 = d3;
                            d13 = d4;
                            d14 = d5;
                            d15 = d6;
                            d16 = d7;
                            d17 = d8;
                        }
                        if (d1 == "n2")
                        {
                            d21 = d2;
                            d22 = d3;
                            d23 = d4;
                            d24 = d5;
                            d25 = d6;
                            d26 = d7;
                            d27 = d8;
                        }
                        if (d1 == "n3")
                        {
                            d31 = d2;
                            d32 = d3;
                            d33 = d4;
                            d34 = d5;
                            d35 = d6;
                            d36 = d7;
                            d37 = d8;
                        }
                        if (d1 == "n4")
                        {
                            d41 = d2;
                            d42 = d3;
                            d43 = d4;
                            d44 = d5;
                            d45 = d6;
                            d46 = d7;
                            d47 = d8;
                        }
                    }
                    catch { }
                }
            }
            catch
            {
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string para = "-t waveaudio −d C:\\xampp\\htdocs\\" + string.Format("wave{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now) + "LAT" + d1 + "LON" + d2 + "TEMP" + d4 + "H" + d5 + ".wav trim 0 59";
            //Process p = Process.Start("sox", para);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            serialPort1.Close();
            serialPort2.Close();
            serialPort3.Close();
            serialPort4.Close();

            Application.Exit();


        }

        bool IsBitSet(byte b, byte nPos)
        {
            return new BitArray(new[] { b })[nPos];
        }
    }
}
