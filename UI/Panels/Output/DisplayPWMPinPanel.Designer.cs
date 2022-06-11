namespace MobiFlight.UI.Panels
{
    partial class DisplayPWMPinPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayPWMPinPanel));
            this.displayPWMPinComboBox = new System.Windows.Forms.ComboBox();
            this.singlePinSelectFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PinSelectContainer = new System.Windows.Forms.Panel();
            this.PinSelectPanel = new System.Windows.Forms.Panel();
            this.LabelPinSelectContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.singlePinSelectFlowLayoutPanel.SuspendLayout();
            this.PinSelectContainer.SuspendLayout();
            this.PinSelectPanel.SuspendLayout();
            this.LabelPinSelectContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPWMPinComboBox
            // 
            this.displayPWMPinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayPWMPinComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.displayPWMPinComboBox, "displayPWMPinComboBox");
            this.displayPWMPinComboBox.Name = "displayPWMPinComboBox";
            this.displayPWMPinComboBox.SelectedIndexChanged += new System.EventHandler(this.displayPWMPinComboBox_SelectedIndexChanged);
            // 
            // singlePinSelectFlowLayoutPanel
            // 
            this.singlePinSelectFlowLayoutPanel.Controls.Add(this.displayPWMPinComboBox);
            resources.ApplyResources(this.singlePinSelectFlowLayoutPanel, "singlePinSelectFlowLayoutPanel");
            this.singlePinSelectFlowLayoutPanel.Name = "singlePinSelectFlowLayoutPanel";
            // 
            // PinSelectContainer
            // 
            resources.ApplyResources(this.PinSelectContainer, "PinSelectContainer");
            this.PinSelectContainer.Controls.Add(this.PinSelectPanel);
            this.PinSelectContainer.Controls.Add(this.LabelPinSelectContainer);
            this.PinSelectContainer.Name = "PinSelectContainer";
            // 
            // PinSelectPanel
            // 
            this.PinSelectPanel.Controls.Add(this.singlePinSelectFlowLayoutPanel);
            resources.ApplyResources(this.PinSelectPanel, "PinSelectPanel");
            this.PinSelectPanel.Name = "PinSelectPanel";
            // 
            // LabelPinSelectContainer
            // 
            this.LabelPinSelectContainer.Controls.Add(this.label3);
            resources.ApplyResources(this.LabelPinSelectContainer, "LabelPinSelectContainer");
            this.LabelPinSelectContainer.Name = "LabelPinSelectContainer";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DisplayPWMPinPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PinSelectContainer);
            this.DoubleBuffered = true;
            this.Name = "DisplayPWMPinPanel";
            this.singlePinSelectFlowLayoutPanel.ResumeLayout(false);
            this.PinSelectContainer.ResumeLayout(false);
            this.PinSelectPanel.ResumeLayout(false);
            this.LabelPinSelectContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion               
        public System.Windows.Forms.ComboBox displayPWMPinComboBox;
        private System.Windows.Forms.FlowLayoutPanel singlePinSelectFlowLayoutPanel;
        private System.Windows.Forms.Panel PinSelectContainer;
        
        private System.Windows.Forms.Panel LabelPinSelectContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PinSelectPanel;
    }
}
