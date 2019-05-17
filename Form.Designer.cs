namespace IconChanger
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.txtLink = new System.Windows.Forms.LinkLabel();
            this.txtCopy = new System.Windows.Forms.LinkLabel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ToggleLog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.txtLink.AutoSize = true;
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(12, 9);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(115, 31);
            this.txtLink.TabIndex = 0;
            this.txtLink.TabStop = true;
            this.txtLink.Text = "Icon IDs";
            this.txtLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TxtLink_LinkClicked);
            // 
            // txtCopy
            // 
            this.txtCopy.AutoSize = true;
            this.txtCopy.Location = new System.Drawing.Point(0, 85);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(74, 13);
            this.txtCopy.TabIndex = 1;
            this.txtCopy.TabStop = true;
            this.txtCopy.Text = "© AECX 2019";
            this.txtCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TxtCopy_LinkClicked);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 53);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 29);
            this.txtInput.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(218, 59);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(110, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(128, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 391);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // ToggleLog
            // 
            this.ToggleLog.AutoSize = true;
            this.ToggleLog.Location = new System.Drawing.Point(80, 84);
            this.ToggleLog.Name = "ToggleLog";
            this.ToggleLog.Size = new System.Drawing.Size(79, 17);
            this.ToggleLog.TabIndex = 6;
            this.ToggleLog.Text = "Debug Log";
            this.ToggleLog.UseVisualStyleBackColor = true;
            this.ToggleLog.CheckedChanged += new System.EventHandler(this.ToggleLog_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 101);
            this.Controls.Add(this.ToggleLog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.txtLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "League Icon Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel txtLink;
        private System.Windows.Forms.LinkLabel txtCopy;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox ToggleLog;
    }
}

