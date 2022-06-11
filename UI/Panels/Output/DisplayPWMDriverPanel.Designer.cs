namespace MobiFlight.UI.Panels
{
   
    partial class DisplayPWMDriverPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayPWMDriverPanel));
            this.pwmLabel = new System.Windows.Forms.Label();
            this.PWMDriversAddressesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayPWMPinPanel = new MobiFlight.UI.Panels.DisplayPWMPinPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pwmLabel
            // 
            this.pwmLabel.Location = new System.Drawing.Point(0, 6);
            this.pwmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pwmLabel.Name = "pwmLabel";
            this.pwmLabel.Size = new System.Drawing.Size(92, 18);
            this.pwmLabel.TabIndex = 0;
            this.pwmLabel.Text = "PWM Driver";
            this.pwmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // PWMDriversAddressesComboBox
            // 
            this.PWMDriversAddressesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PWMDriversAddressesComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.PWMDriversAddressesComboBox, "PWMDriversAddressesComboBox");
            this.PWMDriversAddressesComboBox.Name = "PWMDriversAddressesComboBox";
            this.PWMDriversAddressesComboBox.SelectedIndexChanged += new System.EventHandler(this.PWMAddressesComboBox_SelectedIndexChanged);
            this.PWMDriversAddressesComboBox.Location = new System.Drawing.Point(101, 7);
            this.PWMDriversAddressesComboBox.MaximumSize = new System.Drawing.Size(134, 0);
            this.PWMDriversAddressesComboBox.MinimumSize = new System.Drawing.Size(35, 0);
            this.PWMDriversAddressesComboBox.Size = new System.Drawing.Size(134, 21);
            this.PWMDriversAddressesComboBox.TabIndex = 66;
            
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PWMDriversAddressesComboBox);
            this.panel1.Controls.Add(this.pwmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 36);
            this.panel1.TabIndex = 68;

            // 
            // displayPWMPinPanel
            // 
            this.displayPWMPinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPWMPinPanel.Location = new System.Drawing.Point(0, 36);
            this.displayPWMPinPanel.Name = "displayPWMPinPanel";
            this.displayPWMPinPanel.Size = new System.Drawing.Size(371, 238);
            this.displayPWMPinPanel.TabIndex = 67;

            // 
            // DisplayPWMDriverPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.displayPWMPinPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DisplayPWMDriverPanel";
            this.Size = new System.Drawing.Size(371, 274);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label pwmLabel;
        public System.Windows.Forms.ComboBox PWMDriversAddressesComboBox;
        private System.Windows.Forms.Panel panel1;
        private DisplayPWMPinPanel displayPWMPinPanel;
        
        
    }
}