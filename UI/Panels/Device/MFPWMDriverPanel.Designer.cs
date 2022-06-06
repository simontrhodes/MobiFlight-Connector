namespace MobiFlight.UI.Panels.Settings.Device
{
    partial class MFPWMDriverPanel
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

        #region Vom Komponenten-Designer generierter Code


        #endregion

        private System.Windows.Forms.GroupBox PWMDriverSettingsGroupBox;
        private System.Windows.Forms.GroupBox NameGroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox AddressComboBox;


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFPWMDriverPanel));
            this.PWMDriverSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PWMDriverSettingsGroupBox.SuspendLayout();
            this.NameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PWMDriverSettingsGroupBox
            // 
            this.PWMDriverSettingsGroupBox.Controls.Add(this.AddressComboBox);
            this.PWMDriverSettingsGroupBox.Controls.Add(this.label1);
            resources.ApplyResources(this.PWMDriverSettingsGroupBox, "PWMDriverSettingsGroupBox");
            this.PWMDriverSettingsGroupBox.Name = "PWMDriverSettingsGroupBox";
            this.PWMDriverSettingsGroupBox.TabStop = false;
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("AddressComboBox.AutoCompleteCustomSource"),
            resources.GetString("AddressComboBox.AutoCompleteCustomSource1"),
            resources.GetString("AddressComboBox.AutoCompleteCustomSource2"),
            resources.GetString("AddressComboBox.AutoCompleteCustomSource3")});
            this.AddressComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Items.AddRange(new object[] {
            resources.GetString("AddressComboBox.Items"),
            resources.GetString("AddressComboBox.Items1"),
            resources.GetString("AddressComboBox.Items2"),
            resources.GetString("AddressComboBox.Items3")});
            resources.ApplyResources(this.AddressComboBox, "AddressComboBox");
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.SelectedValueChanged += new System.EventHandler(this.AddressComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.Controls.Add(this.NameTextBox);
            resources.ApplyResources(this.NameGroupBox, "NameGroupBox");
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.TabStop = false;
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.TextChanged += new System.EventHandler(this.value_Changed);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MFPWMDriverPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.NameGroupBox);
            this.Controls.Add(this.PWMDriverSettingsGroupBox);
            this.Name = "MFPWMDriverPanel";
            this.PWMDriverSettingsGroupBox.ResumeLayout(false);
            this.PWMDriverSettingsGroupBox.PerformLayout();
            this.NameGroupBox.ResumeLayout(false);
            this.NameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }




    }

}

