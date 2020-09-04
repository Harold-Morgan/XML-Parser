using System;
using System.IO;
using System.Windows.Forms;


namespace PetProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            labelNameObject.Text = "Choose a file";
        }

        public string xmlString = "";


        private void SetText(string text)
        {
            tbxIn.Text = text;
        }

        private void tbxIn_TextChanged(object sender, EventArgs e)
        {
            xmlString = tbxIn.Text;
        }


        // CHECKED оставляем (открытие файла XML, смена лэйблов)
        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML Files (*.xml)|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var reader = new StreamReader(ofd.FileName);
                    SetText(reader.ReadToEnd());
                    xmlString = tbxIn.Text;
                    Label labelName = new Label();
                    labelName = labelNameObject;
                    labelName.Text = string.Empty;
                    labelName.BackColor = System.Drawing.Color.LightGreen;
                    labelName.AutoSize = true;
                    labelName.Text = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("Choose an XML type file ");
                }
            }
        }

        private void buttonGoForm2_Click(object sender, EventArgs e)
        {
            SetText(xmlString);
            DataBank.XMLstring = xmlString;
            Form F2 = new Form2();
            F2.ShowDialog();

        }
    }
}
