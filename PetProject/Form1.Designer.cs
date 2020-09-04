namespace PetProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.tbxIn = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelNameObject = new System.Windows.Forms.Label();
            this.buttonGoForm2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML parser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.YellowGreen;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(632, 107);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(140, 68);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // tbxIn
            // 
            this.tbxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxIn.Location = new System.Drawing.Point(3, 107);
            this.tbxIn.Multiline = true;
            this.tbxIn.Name = "tbxIn";
            this.tbxIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxIn.Size = new System.Drawing.Size(619, 449);
            this.tbxIn.TabIndex = 3;
            this.tbxIn.TextChanged += new System.EventHandler(this.tbxIn_TextChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDesc.Location = new System.Drawing.Point(28, 71);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(113, 24);
            this.labelDesc.TabIndex = 10;
            this.labelDesc.Text = "Current File:";
            // 
            // labelNameObject
            // 
            this.labelNameObject.AutoSize = true;
            this.labelNameObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNameObject.Location = new System.Drawing.Point(160, 71);
            this.labelNameObject.Name = "labelNameObject";
            this.labelNameObject.Size = new System.Drawing.Size(0, 24);
            this.labelNameObject.TabIndex = 11;
            // 
            // buttonGoForm2
            // 
            this.buttonGoForm2.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGoForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoForm2.Location = new System.Drawing.Point(632, 487);
            this.buttonGoForm2.Name = "buttonGoForm2";
            this.buttonGoForm2.Size = new System.Drawing.Size(140, 69);
            this.buttonGoForm2.TabIndex = 12;
            this.buttonGoForm2.Text = "File is ok, go next!";
            this.buttonGoForm2.UseVisualStyleBackColor = false;
            this.buttonGoForm2.Click += new System.EventHandler(this.buttonGoForm2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.openButton);
            this.panel1.Controls.Add(this.tbxIn);
            this.panel1.Controls.Add(this.labelNameObject);
            this.panel1.Controls.Add(this.buttonGoForm2);
            this.panel1.Controls.Add(this.labelDesc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 571);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(628, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 80);
            this.label2.TabIndex = 13;
            this.label2.Text = "Here you can \r\nchange XML text\r\n(It will be impossible\r\n later on next step)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(821, 595);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox tbxIn;
        private System.Windows.Forms.Label labelDesc;
        public System.Windows.Forms.Label labelNameObject;
        private System.Windows.Forms.Button buttonGoForm2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

