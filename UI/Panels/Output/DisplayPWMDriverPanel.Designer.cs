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
            resources.ApplyResources(this.pwmLabel, "pwmLabel");
            this.pwmLabel.Name = "pwmLabel";
            // 
            // PWMDriversAddressesComboBox
            // 
            this.PWMDriversAddressesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PWMDriversAddressesComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.PWMDriversAddressesComboBox, "PWMDriversAddressesComboBox");
            this.PWMDriversAddressesComboBox.Name = "PWMDriversAddressesComboBox";
            this.PWMDriversAddressesComboBox.SelectedIndexChanged += new System.EventHandler(this.PWMAddressesComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PWMDriversAddressesComboBox);
            this.panel1.Controls.Add(this.pwmLabel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // displayPWMPinPanel
            // 
            resources.ApplyResources(this.displayPWMPinPanel, "displayPWMPinPanel");
            this.displayPWMPinPanel.Name = "displayPWMPinPanel";
            this.displayPWMPinPanel.Load += new System.EventHandler(this.displayPWMPinPanel_Load);
            // 
            // DisplayPWMDriverPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayPWMPinPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayPWMDriverPanel";
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