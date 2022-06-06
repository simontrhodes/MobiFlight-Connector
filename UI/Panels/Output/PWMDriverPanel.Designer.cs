namespace MobiFlight.UI.Panels
{
    partial class PWMDriverPanel
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

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PWMDriverPanel));
            this.label = new System.Windows.Forms.Label();
            this.PWMDriversAddressesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // PWMDriversAddressesComboBox
            // 
            this.PWMDriversAddressesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PWMDriversAddressesComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.PWMDriversAddressesComboBox, "PWMDriversAddressesComboBox");
            this.PWMDriversAddressesComboBox.Name = "PWMDriversAddressesComboBox";
            this.PWMDriversAddressesComboBox.SelectedIndexChanged += new System.EventHandler(this.PWMAddressesComboBox_SelectedIndexChanged);
            // 
            // PWMDriverPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.PWMDriversAddressesComboBox);
            this.Name = "PWMDriverPanel";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.ComboBox PWMDriversAddressesComboBox;
    }
}