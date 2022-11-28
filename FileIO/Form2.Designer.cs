
namespace FileIO
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
            this.lblDeptId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btmBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.BtnJSONWrite = new System.Windows.Forms.Button();
            this.BtnJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(173, 94);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(49, 17);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "DeptId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dept Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(270, 103);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(281, 268);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(100, 22);
            this.textLocation.TabIndex = 4;
            this.textLocation.Text = "`";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(281, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(470, 45);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(95, 23);
            this.btnBinaryWrite.TabIndex = 6;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click_1);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(457, 160);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(125, 23);
            this.btnXMLWrite.TabIndex = 7;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(480, 260);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(102, 23);
            this.btnSOAPWrite.TabIndex = 8;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "JSON Write";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btmBinaryRead
            // 
            this.btmBinaryRead.Location = new System.Drawing.Point(614, 45);
            this.btmBinaryRead.Name = "btmBinaryRead";
            this.btmBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btmBinaryRead.TabIndex = 10;
            this.btmBinaryRead.Text = "Binary Read";
            this.btmBinaryRead.UseVisualStyleBackColor = true;
            this.btmBinaryRead.Click += new System.EventHandler(this.btmBinaryRead_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(625, 160);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(99, 23);
            this.btnXMLRead.TabIndex = 11;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(637, 265);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(75, 23);
            this.btnSOAPRead.TabIndex = 12;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(637, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(10, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // BtnJSONWrite
            // 
            this.BtnJSONWrite.Location = new System.Drawing.Point(490, 341);
            this.BtnJSONWrite.Name = "BtnJSONWrite";
            this.BtnJSONWrite.Size = new System.Drawing.Size(107, 23);
            this.BtnJSONWrite.TabIndex = 14;
            this.BtnJSONWrite.Text = "JSON Write";
            this.BtnJSONWrite.UseVisualStyleBackColor = true;
            this.BtnJSONWrite.Click += new System.EventHandler(this.BtnJSONWrite_Click);
            // 
            // BtnJSONRead
            // 
            this.BtnJSONRead.Location = new System.Drawing.Point(637, 353);
            this.BtnJSONRead.Name = "BtnJSONRead";
            this.BtnJSONRead.Size = new System.Drawing.Size(115, 23);
            this.BtnJSONRead.TabIndex = 15;
            this.BtnJSONRead.Text = "JSON Read";
            this.BtnJSONRead.UseVisualStyleBackColor = true;
            this.BtnJSONRead.Click += new System.EventHandler(this.BtnJSONRead_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnJSONRead);
            this.Controls.Add(this.BtnJSONWrite);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btmBinaryRead);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDeptId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btmBinaryRead;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button BtnJSONWrite;
        private System.Windows.Forms.Button BtnJSONRead;
    }
}