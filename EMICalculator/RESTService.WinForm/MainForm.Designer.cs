namespace RESTService.WinForm
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxRequest = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxResponse = new System.Windows.Forms.RichTextBox();
            this.labelLastServed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxRequest, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxResponse, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLastServed, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Received";
            // 
            // richTextBoxRequest
            // 
            this.richTextBoxRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRequest.Location = new System.Drawing.Point(3, 23);
            this.richTextBoxRequest.Name = "richTextBoxRequest";
            this.richTextBoxRequest.Size = new System.Drawing.Size(502, 97);
            this.richTextBoxRequest.TabIndex = 1;
            this.richTextBoxRequest.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Response Sent";
            // 
            // richTextBoxResponse
            // 
            this.richTextBoxResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResponse.Location = new System.Drawing.Point(3, 146);
            this.richTextBoxResponse.Name = "richTextBoxResponse";
            this.richTextBoxResponse.Size = new System.Drawing.Size(502, 97);
            this.richTextBoxResponse.TabIndex = 3;
            this.richTextBoxResponse.Text = "";
            // 
            // labelLastServed
            // 
            this.labelLastServed.AutoSize = true;
            this.labelLastServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastServed.Location = new System.Drawing.Point(3, 251);
            this.labelLastServed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelLastServed.Name = "labelLastServed";
            this.labelLastServed.Size = new System.Drawing.Size(120, 20);
            this.labelLastServed.TabIndex = 4;
            this.labelLastServed.Text = "Last Served : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 277);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "UWP DesktopBridge : WCF REST Server";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxResponse;
        private System.Windows.Forms.Label labelLastServed;
    }
}

