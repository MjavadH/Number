using System;
using System.Xml;

namespace Number
{
    class Cdata
    {

        public static XmlDocument DataXML = new XmlDocument();

        public static void CreateNew()
        {

            try
            {
                DataXML.Load("Data.xml");
            }
            catch (Exception)
            {
                XmlNode rootNode = DataXML.CreateElement("Numbers");
                DataXML.AppendChild(rootNode);
                /*------------------ شنبه ------------------*/
                XmlNode NumberNode = DataXML.CreateElement("Number");
                XmlAttribute attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز شنبه";
                XmlAttribute attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                XmlAttribute attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "یا رَبَّ الْعالَمین";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ یک شنبه ------------------*/
                NumberNode = DataXML.CreateElement("Number");
                attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز یک شنبه";
                attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "یا ذَالْجَلالِ وَالاِکْرام";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ دو شنبه ------------------*/
                NumberNode = DataXML.CreateElement("Number");
                attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز دو شنبه";
                attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "یا قاضِیَ الْحاجات";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ سه شنبه ------------------*/
                NumberNode = DataXML.CreateElement("Number");
                attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز سه شنبه";
                attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "یا اَرْحَمَ الرَّاحمین";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ چهار شنبه ------------------*/
                NumberNode = DataXML.CreateElement("Number");
                attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز چهار شنبه";
                attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "یا حَیُّ یا قَیّوم";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ پنج شنبه ------------------*/
                NumberNode = DataXML.CreateElement("Number");
                attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز پنج شنبه";
                attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "لا اِلهَ اِلاّ اللهُ الْمَلِکُ الْحَقٌّ الْمُبین";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ جمعه ------------------*/
                NumberNode = DataXML.CreateElement("Number");
                attribute = DataXML.CreateAttribute("Name");
                attribute.Value = "ذکر روز جمعه";
                attribute2 = DataXML.CreateAttribute("Len");
                attribute2.Value = "100";
                attribute3 = DataXML.CreateAttribute("Text");
                attribute3.Value = "اللَّهُمَّ صَلَّ عَلَی مُحَمَّدٍ واَلِ مُحَمَّدٍ وعَجَّلْ فَرَجَهُمْ";
                NumberNode.Attributes.Append(attribute);
                NumberNode.Attributes.Append(attribute2);
                NumberNode.Attributes.Append(attribute3);
                NumberNode.InnerText = "0";
                rootNode.AppendChild(NumberNode);
                /*------------------ ذخیره ------------------*/
                DataXML.Save("Data.xml");
            }
        }
        public static string Clear(string DText)
        {
            string Text = "0";
            try
            {
                DataXML.Load("Data.xml");
                XmlNodeList NumberNodes = DataXML.SelectNodes("//Numbers/Number");
                foreach (XmlNode NumberNode in NumberNodes)
                {
                    if (NumberNode.Attributes["Name"].Value == DText)
                    {
                        NumberNode.InnerText = "0";
                        DataXML.Save("Data.xml");
                        Text = NumberNode.InnerText;
                    }
                }
            }
            catch (Exception) { }
            return Text;
        }
    }
}
