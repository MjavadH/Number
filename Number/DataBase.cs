using System;
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
                    dataGridView1.Rows.Add(NumberNode.Attributes["Name"].Value, NumberNode.Attributes["Len"].Value, NumberNode.Attributes["Text"].Value, NumberNode.InnerText);
                }
            }
            catch (Exception) { }
        }
        void dataClear()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.ClearSelection();
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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((string)dataGridView1.Rows[i].Cells[0].Value == NameTB.Text)
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
            {this.BackColor = Settings.Default.LightTheme;}
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            NameTB.Width = 195;
            TextTB.Width = 195;
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
            Save.Enabled = true;
        }
        /*--------- Delete ---------*/
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]);
            dataClear();
        }
        /*--------- Edit Start ---------*/
        private void EditeBTN_Click(object sender, EventArgs e)
        {
            indexR = dataGridView1.CurrentCell.RowIndex;
            indexC = dataGridView1.CurrentCell.ColumnIndex;
            if (indexC == 1)
            {
                Error("قسمت تعداد قابل ویرایش نیست!");
            }
            else
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.BeginEdit(true);
                Save.Enabled = false;
                oldVal = (string)dataGridView1[indexC, indexR].Value;
                btnClear();
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Save.Enabled = true;
            dataClear();
            if (indexC == 3)
            {
                try
                {
                    int.Parse((string)dataGridView1.Rows[indexR].Cells[indexC].Value);
                    if (int.Parse((string)dataGridView1.Rows[indexR].Cells[indexC].Value) > 100000000)
                    {
                        dataGridView1[indexC, indexR].Value = oldVal;
                        Error("مقداری که وارد کردید بیشتر از حد مجاز است");
                    }
                    else if ((string)dataGridView1.Rows[indexR].Cells[1].Value == "نامحدود")
                    {

                    }
                    else if (int.Parse((string)dataGridView1.Rows[indexR].Cells[1].Value) < int.Parse((string)dataGridView1.Rows[indexR].Cells[indexC].Value))
                    {
                        dataGridView1[indexC, indexR].Value = oldVal;
                        Error("مقداری که وارد کردید از تعداد بیشتر است");
                    }
                }
                catch (Exception)
                {
                    dataGridView1[indexC, indexR].Value = oldVal;
                    Error("مقدار وارد شده غیر عادی میباشد");
                }
            }
            else if (indexC == 0)
            {
                try
                {
                    if (string.IsNullOrEmpty((string)dataGridView1.Rows[indexR].Cells[indexC].Value))
                    {
                        dataGridView1[indexC, indexR].Value = oldVal;
                        Error("مقدار نام نباید خالی باشد");
                    }
                    else
                    {
                        bool ResultT = false;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if ((string)dataGridView1[0, i].Value == (string)dataGridView1[0, indexR].Value)
                            {
                                if (dataGridView1[0, i] == dataGridView1[0, indexR]) continue;
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
                            dataGridView1[0, indexR].Value = oldVal;
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
                    if (infBox.Checked)
                    {
                        dataGridView1.Rows.Add(NameTB.Text, "نامحدود", TextTB.Text, "0");
                    }
                    else dataGridView1.Rows.Add(NameTB.Text, lenTB.Text, TextTB.Text, "0");
                }
                else
                {
                    Error("نام تکراری قابل قبول نیست");
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (infBox.Checked)
            {
                lenTB.Enabled = false;
            }
            else lenTB.Enabled = true;
        }
        /*------------------  Add Data End ------------------*/
        /*------------------  BTN Start ------------------*/
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
                        dataGridView1.Rows.Add(NumberNode.Attributes["Name"].Value, NumberNode.Attributes["Len"].Value, NumberNode.Attributes["Text"].Value, NumberNode.InnerText);
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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    /*افزودن*/
                    XmlNode NumberNode = xmlDoc.CreateElement("Number");
                    XmlAttribute attribute = xmlDoc.CreateAttribute("Name");
                    attribute.Value = (string)dataGridView1.Rows[i].Cells[0].Value;
                    XmlAttribute attribute2 = xmlDoc.CreateAttribute("Len");
                    attribute2.Value = (string)dataGridView1.Rows[i].Cells[1].Value;
                    XmlAttribute attribute3 = xmlDoc.CreateAttribute("Text");
                    attribute3.Value = (string)dataGridView1.Rows[i].Cells[2].Value;
                    NumberNode.Attributes.Append(attribute);
                    NumberNode.Attributes.Append(attribute2);
                    NumberNode.Attributes.Append(attribute3);
                    NumberNode.InnerText = (string)dataGridView1.Rows[i].Cells[3].Value;
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

        private void Cancel_Click(object sender, EventArgs e)
        { this.Close(); }
        private void button_MouseEnter(object sender, EventArgs e)
        { Cancel.FillColor = Color.FromArgb(249, 75, 66); }
        private void button_MouseLeave(object sender, EventArgs e)
        { Cancel.FillColor = Color.Empty; }
        /*------------------  BTN End ------------------*/
    }
}
