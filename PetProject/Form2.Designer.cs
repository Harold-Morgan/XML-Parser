namespace PetProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }












        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelNameObject2 = new System.Windows.Forms.Label();
            this.labelDesc2 = new System.Windows.Forms.Label();
            this.buttonParse = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 34);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelNameObject2
            // 
            this.labelNameObject2.AutoSize = true;
            this.labelNameObject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNameObject2.Location = new System.Drawing.Point(235, 13);
            this.labelNameObject2.Name = "labelNameObject2";
            this.labelNameObject2.Size = new System.Drawing.Size(45, 24);
            this.labelNameObject2.TabIndex = 13;
            this.labelNameObject2.Text = " //////";
            // 
            // labelDesc2
            // 
            this.labelDesc2.AutoSize = true;
            this.labelDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDesc2.Location = new System.Drawing.Point(116, 13);
            this.labelDesc2.Name = "labelDesc2";
            this.labelDesc2.Size = new System.Drawing.Size(113, 24);
            this.labelDesc2.TabIndex = 12;
            this.labelDesc2.Text = "Current File:";
            // 
            // buttonParse
            // 
            this.buttonParse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonParse.Location = new System.Drawing.Point(12, 52);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(105, 53);
            this.buttonParse.TabIndex = 15;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = false;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(12, 114);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(767, 440);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(345, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Output:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCopy.Location = new System.Drawing.Point(674, 40);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(105, 65);
            this.buttonCopy.TabIndex = 20;
            this.buttonCopy.Text = "Copy output";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonUpload.Location = new System.Drawing.Point(563, 40);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(105, 65);
            this.buttonUpload.TabIndex = 21;
            this.buttonUpload.Text = "Upload to DataBase";
            this.buttonUpload.UseVisualStyleBackColor = false;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.buttonParse);
            this.Controls.Add(this.labelNameObject2);
            this.Controls.Add(this.labelDesc2);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelNameObject2;
        private System.Windows.Forms.Label labelDesc2;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonUpload;
    }
}