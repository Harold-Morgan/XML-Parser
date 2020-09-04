using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace PetProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Form f = Application.OpenForms["Form1"];
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            labelNameObject2.Text = string.Empty;
            labelNameObject2.Text = ((Form1)f).labelNameObject.Text;
            if (labelNameObject2.Text!="Choose a file")
            {
                labelNameObject2.BackColor = Color.LightGreen;
            }
            
        }
         
        private void buttonBack_Click(object sender, EventArgs e)
        {
            labelNameObject2.Text = string.Empty;
            Close();
            Form f = Application.OpenForms["Form1"];
            ((Form1)f).Activate();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
             
            try
            {
                XElement docWeekSales = XElement.Parse(DataBank.XMLstring);
                XElement weekSL = docWeekSales.Element("WeekSale-Lines");
                IEnumerable<XElement> lines = weekSL.Elements();
                foreach (var line in lines)
                {//ниже всё с привязкой к классу. можно потом сделать сериализацию Line
                    Line Brick = new Line();
                    string saleNumber = line.Element("SaleNumber").Value;
                    string saleDate = line.Element("SaleDate").Value;
                    string saleItemCode = line.Element("SaleItemCode").Value;
                    string saleQuantity = line.Element("SaleQuantity").Value;
                    string salePrice = line.Element("SalePrice").Value;
                    Brick.SaleNumber = saleNumber;
                    Brick.SaleDate = saleDate;
                    Brick.SaleItemCode = saleItemCode;
                    Brick.SaleQuantity = saleQuantity;
                    Brick.SalePrice = salePrice;
                    richTextBox2.Text += Brick.SaleNumber + "\n";
                    richTextBox2.Text += Brick.SaleDate + "\n";
                    richTextBox2.Text += Brick.SaleItemCode + "\n";
                    richTextBox2.Text += Brick.SaleQuantity + "\n";
                    richTextBox2.Text += Brick.SalePrice + "\n";
                    richTextBox2.Text += "\n\n";
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != string.Empty)
            {
                Clipboard.SetText(richTextBox2.Text);
            }
            else
            {
                MessageBox.Show("Nothing to copy");
            }

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

        }
    }
}
