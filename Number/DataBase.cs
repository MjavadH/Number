﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Number.Properties;
using static Number.Cdata;

namespace Number
{
    public partial class DataBase : Form
    {
        XmlDocument DataXML = new XmlDocument();
        public DataBase()
        {InitializeComponent();}
        /*------------------ func Start ------------------*/
        void DataGridSet()
        {
            try
            {
                DataXML.Load("Data.xml");
                XmlNodeList NumberNodes = DataXML.SelectNodes("//Numbers/Number");
                foreach (XmlNode NumberNode in NumberNodes)
                {
                    Number_data.Rows.Add(NumberNode.Attributes["Name"].Value, NumberNode.Attributes["Len"].Value, NumberNode.Attributes["Text"].Value, NumberNode.InnerText);
                }
            }
            catch (Exception) { }
        }
        void dataClear()
        {
            Number_data.ReadOnly = true;
            Number_data.ClearSelection();
            btnClear();
        }
        void Error(string ErText)
        {
            Animation.AddToQueue(ErrorText, Guna.UI2.AnimatorNS.AnimateMode.Show);
            ErrorText.Text = ErText;
            Time.Start();
        }
        void btnClear()
        {
            DeleteBTN.Visible = false;
            EditeBTN.Visible = false;
            panel_UpDown.Visible = false;
        }
        void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
        bool ResultT;
        void NameCheck()
        {
            ResultT = false;
            for (int i = 0; i < Number_data.Rows.Count; i++)
            {
                if ((string)Number_data.Rows[i].Cells[0].Value == NameTB.Text)
                {
                    ResultT = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        /*------------------ func End ------------------*/
        private void DataBase_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {this.BackColor = Settings.Default.Theme;}
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                AddBTN.ForeColor = Color.Black;
                AddBTN.BorderColor = Color.Black;
                AddBTN.Image = Resources.insert_row_black;
                SaveNumbers.ForeColor = Color.Black;
                SaveNumbers.BorderColor = Color.Black;
                SaveNumbers.Image = Resources.save_as_black;
                ReturnBTN.ForeColor = Color.Black;
                ReturnBTN.BorderColor = Color.Black;
                ReturnBTN.Image = Resources.return_black;
                DeleteBTN.ForeColor = Color.Black;
                DeleteBTN.BorderColor = Color.Black;
                DeleteBTN.Image = Resources.delete_row_black;
                EditeBTN.ForeColor = Color.Black;
                EditeBTN.BorderColor = Color.Black;
                EditeBTN.Image = Resources.edit_black;
                Cancel.ForeColor = Color.Black;
                Cancel.Image = Resources.cancel_black;
                Save.ForeColor = Color.Black;
                Save.Image = Resources.save_black;
                button_up.Image = Resources.slide_up_black;
                button_down.Image = Resources.slide_down_black;
                if (this.BackColor.R >= 250 && this.BackColor.G >= 250 && this.BackColor.B >= 250)
                {
                    TextTB.FillColor = Color.FromArgb(20, 25, 33);
                    TextTB.ForeColor = Color.FromArgb(250, 250, 250);
                    TextTB.BorderColor = Color.Black;
                    NameTB.FillColor = Color.FromArgb(20, 25, 33);
                    NameTB.ForeColor = Color.FromArgb(250, 250, 250);
                    NameTB.BorderColor = Color.Black;
                    lenTB.BackColor = Color.FromArgb(20, 25, 33);
                    lenTB.ForeColor = Color.White;
                }
                
            }
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            NameTB.Width = 195;
            NameTB.PlaceholderText = "نام شمارنده";
            TextTB.Width = 195;
            TextTB.PlaceholderText = "متن شمارنده";
            DataGridSet();
            dataClear();
        }
        /*------------------ Move Form Start ------------------*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void NumberForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*------------------ Move Form End ------------------*/
        /*------------------ DataBase Start ------------------*/
        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            NameCheck();
            if (!ResultT) NameTB.IconLeft = Resources.checkmark_Green;
            else NameTB.IconLeft = Resources.delete_red;

        }
        /*--------- Var ---------*/
        int indexC;
        int indexR;
        string oldVal;
        /*--------- Cell Click ---------*/
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DeleteBTN.Visible = true;
            EditeBTN.Visible = true;
            panel_UpDown.Visible = true;
            Save.Enabled = true;
        }
        /*--------- Delete ---------*/
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            Number_data.Rows.Remove(Number_data.Rows[Number_data.CurrentCell.RowIndex]);
            dataClear();
        }
        /*--------- Edit Start ---------*/
        private void EditeBTN_Click(object sender, EventArgs e)
        {
            indexR = Number_data.CurrentCell.RowIndex;
            indexC = Number_data.CurrentCell.ColumnIndex;
            if (indexC == 1)
            {
                Error("قسمت تعداد قابل ویرایش نیست!");
            }
            else
            {
                Number_data.ReadOnly = false;
                Number_data.BeginEdit(true);
                Save.Enabled = false;
                oldVal = (string)Number_data[indexC, indexR].Value;
                btnClear();
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Save.Enabled = true;
            dataClear();
            if (indexC == 3)
            {
                if (string.IsNullOrEmpty((string)Number_data.Rows[indexR].Cells[indexC].Value))
                {
                    Number_data[indexC, indexR].Value = oldVal;
                    Error("مقدار نباید خالی باشد");
                }
                else if (((string)Number_data.Rows[indexR].Cells[indexC].Value).StartsWith("-"))
                {
                    Number_data[indexC, indexR].Value = oldVal;
                    Error("مقدار وارد شده صحیح نمی باشد");
                }
                else
                {
                    try
                    {
                        int.Parse((string)Number_data.Rows[indexR].Cells[indexC].Value);
                        if ((string)Number_data.Rows[indexR].Cells[1].Value == "نامحدود")
                        {

                        }
                        else if (int.Parse((string)Number_data.Rows[indexR].Cells[indexC].Value) > 2147483647)
                        {
                            Number_data[indexC, indexR].Value = oldVal;
                            Error("مقداری که وارد کردید بیشتر از حد مجاز است");
                        }
                        else if (int.Parse((string)Number_data.Rows[indexR].Cells[1].Value) < int.Parse((string)Number_data.Rows[indexR].Cells[indexC].Value))
                        {
                            Number_data[indexC, indexR].Value = oldVal;
                            Error("مقداری که وارد کردید از تعداد بیشتر است");
                        }
                    }
                    catch (Exception)
                    {
                        Number_data[indexC, indexR].Value = oldVal;
                        Error("مقدار وارد شده غیر عادی میباشد");
                    }
                }

            }
            else if (indexC == 0)
            {
                try
                {
                    if (string.IsNullOrEmpty((string)Number_data.Rows[indexR].Cells[indexC].Value))
                    {
                        Number_data[indexC, indexR].Value = oldVal;
                        Error("مقدار نام نباید خالی باشد");
                    }
                    else
                    {
                        bool ResultT = false;
                        for (int i = 0; i < Number_data.Rows.Count; i++)
                        {
                            if ((string)Number_data[0, i].Value == (string)Number_data[0, indexR].Value)
                            {
                                if (Number_data[0, i] == Number_data[0, indexR]) continue;
                                else
                                {
                                    ResultT = true;
                                    break;
                                }
                            }
                            else continue;
                        }
                        if (ResultT == true)
                        {
                            Number_data[0, indexR].Value = oldVal;
                            Error("نام تکراری قابل قبول نیست");
                        }
                    }
                }
                catch (Exception){}
            }
        }
        /*--------- Edit end ---------*/
        /*--------- Error Animation ---------*/
        private void Time_Tick(object sender, EventArgs e)
        {
            Animation.AddToQueue(ErrorText, Guna.UI2.AnimatorNS.AnimateMode.Hide);
            Time.Stop();
        }
        /*------------------ DataBase End ------------------*/
        /*------------------  Add Data Start ------------------*/
        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || TextTB.Text == "")
            {
                Error("قسمت نام و متن نباید خالی باشد");
            }
            else
            {
                NameCheck();
                dataClear();
                if (!ResultT)
                {
                    if (button_limit.Checked)
                    {
                        Number_data.Rows.Add(NameTB.Text, "نامحدود", TextTB.Text, "0");
                    }
                    else Number_data.Rows.Add(NameTB.Text, lenTB.Text, TextTB.Text, "0");
                    NameTB.IconLeft = Resources.delete_red;
                }
                else
                {
                    Error("نام تکراری قابل قبول نیست");
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (button_limit.Checked)
            {
                lenTB.Enabled = false;
            }
            else lenTB.Enabled = true;
        }
        /*------------------  Add Data End ------------------*/
        /*------------------  BTN Start ------------------*/
        /*--------- Save Number to setting ---------*/
        public void SaveData_Click(object sender, EventArgs e)
        {
            if (sender.Equals("Save"))
            {
                try
                {
                    DataXML.Load("Data.xml");
                    XmlNodeList NumberNodes = DataXML.SelectNodes("//Numbers/Number");
                    foreach (XmlNode NumberNode in NumberNodes)
                    {
                        Number_data.Rows.Add(NumberNode.Attributes["Name"].Value, NumberNode.Attributes["Len"].Value, NumberNode.Attributes["Text"].Value, NumberNode.InnerText);
                    }
                }
                catch (Exception) { }
            }
            Save_Click(SaveNumbers, EventArgs.Empty);
            string result = Cdata.saveData();
            switch (result)
            {
                case "Suscess":
                    Alert("شمارنده ها ذخیره شدند");
                    break;
                case "Error":
                    Alert("مشکلی در ذخیره کردن پیش آمد لطفا مجدد تلاش کنید");
                    break;
            }
        }
        /*--------- Save ---------*/
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete("Data.xml");
            }
            catch (Exception){}
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Numbers");
            xmlDoc.AppendChild(rootNode);
            for (int i = 0; i < Number_data.Rows.Count; i++)
            {
                try
                {
                    /*افزودن*/
                    XmlNode NumberNode = xmlDoc.CreateElement("Number");
                    XmlAttribute attribute = xmlDoc.CreateAttribute("Name");
                    attribute.Value = (string)Number_data.Rows[i].Cells[0].Value;
                    XmlAttribute attribute2 = xmlDoc.CreateAttribute("Len");
                    attribute2.Value = (string)Number_data.Rows[i].Cells[1].Value;
                    XmlAttribute attribute3 = xmlDoc.CreateAttribute("Text");
                    attribute3.Value = (string)Number_data.Rows[i].Cells[2].Value;
                    NumberNode.Attributes.Append(attribute);
                    NumberNode.Attributes.Append(attribute2);
                    NumberNode.Attributes.Append(attribute3);
                    NumberNode.InnerText = (string)Number_data.Rows[i].Cells[3].Value;
                    rootNode.AppendChild(NumberNode);
                }
                catch (Exception)
                {
                    Error("خطا در ذخیره سازی لطفا مجدد تلاش فرمایید");
                }
                
            }
            xmlDoc.Save("Data.xml");
            if (sender != SaveNumbers)
            {
                this.Close();
            }
        }
        /*--------- Cancel ---------*/
        private void Cancel_Click(object sender, EventArgs e)
        { this.Close(); }
        private void button_MouseEnter(object sender, EventArgs e)
        { Cancel.FillColor = Color.FromArgb(249, 75, 66); }
        private void button_MouseLeave(object sender, EventArgs e)
        { Cancel.FillColor = Color.Empty; }
        /*--------- Return Number from setting ---------*/
        public void ReturnBTN_Click(object sender, EventArgs e)
        {
            string result = Cdata.LoadData();
            switch (result)
            {
                case "Suscess":
                    Alert("عملیات با موفقیت انجام شد");
                    for (int i = 0; i < Number_data.Rows.Count;)
                    {
                        Number_data.Rows.Remove(Number_data.Rows[i]);
                    }
                    DataGridSet();
                    break;
                case "Data Empty":
                    Alert("چیزی ذخیره نشده که بازگردانی شود");
                    break;
                case "Error":
                    Alert("مشکلی پیش آمد مجدد تلاش کنید");
                    break;
            }
        }
        /*--------- Move up & down btn  ---------*/
        private void button_up_Click(object sender, EventArgs e)
        {
            indexR = Number_data.CurrentCell.RowIndex;
            if (indexR > 0)
            {
                Number_data.Rows.InsertCopy(indexR, indexR - 1);

                Number_data.Rows[indexR - 1].Cells[0].Value = Number_data.Rows[indexR + 1].Cells[0].Value;
                Number_data.Rows[indexR - 1].Cells[1].Value = Number_data.Rows[indexR + 1].Cells[1].Value;
                Number_data.Rows[indexR - 1].Cells[2].Value = Number_data.Rows[indexR + 1].Cells[2].Value;
                Number_data.Rows[indexR - 1].Cells[3].Value = Number_data.Rows[indexR + 1].Cells[3].Value;

                Number_data.Rows.RemoveAt(indexR + 1);
                Number_data.ClearSelection();
                Error("");
            }

        }

        private void button_down_Click(object sender, EventArgs e)
        {
            indexR = Number_data.CurrentCell.RowIndex;
            if (indexR < Number_data.Rows.Count -1)
            {
                Number_data.Rows.InsertCopy(indexR, indexR + 2);

                Number_data.Rows[indexR + 2].Cells[0].Value = Number_data.Rows[indexR].Cells[0].Value;
                Number_data.Rows[indexR + 2].Cells[1].Value = Number_data.Rows[indexR].Cells[1].Value;
                Number_data.Rows[indexR + 2].Cells[2].Value = Number_data.Rows[indexR].Cells[2].Value;
                Number_data.Rows[indexR + 2].Cells[3].Value = Number_data.Rows[indexR].Cells[3].Value;

                Number_data.Rows.RemoveAt(indexR);
                Number_data.ClearSelection();
                Error("");
            }
        }
        /*------------------  BTN End ------------------*/
    }
}
