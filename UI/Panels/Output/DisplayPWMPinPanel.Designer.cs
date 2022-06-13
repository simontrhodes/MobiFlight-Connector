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
            this.PinSelectContainer = new System.Windows.Forms.Panel();
            this.LabelPinSelectContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PWMUpper = new System.Windows.Forms.TextBox();
            this.PWMLower = new System.Windows.Forms.TextBox();
            this.SimUpper = new System.Windows.Forms.TextBox();
            this.SimLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.singlePinSelectFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PinSelectPanel = new System.Windows.Forms.Panel();
            this.PinSelectContainer.SuspendLayout();
            this.LabelPinSelectContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.singlePinSelectFlowLayoutPanel.SuspendLayout();
            this.PinSelectPanel.SuspendLayout();
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
            // PinSelectContainer
            // 
            resources.ApplyResources(this.PinSelectContainer, "PinSelectContainer");
            this.PinSelectContainer.Controls.Add(this.PinSelectPanel);
            this.PinSelectContainer.Controls.Add(this.LabelPinSelectContainer);
            this.PinSelectContainer.Name = "PinSelectContainer";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PWMUpper);
            this.panel1.Controls.Add(this.PWMLower);
            this.panel1.Controls.Add(this.SimUpper);
            this.panel1.Controls.Add(this.SimLower);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // PWMUpper
            // 
            resources.ApplyResources(this.PWMUpper, "PWMUpper");
            this.PWMUpper.Name = "PWMUpper";
            // 
            // PWMLower
            // 
            resources.ApplyResources(this.PWMLower, "PWMLower");
            this.PWMLower.Name = "PWMLower";
            // 
            // SimUpper
            // 
            resources.ApplyResources(this.SimUpper, "SimUpper");
            this.SimUpper.Name = "SimUpper";
            // 
            // SimLower
            // 
            resources.ApplyResources(this.SimLower, "SimLower");
            this.SimLower.Name = "SimLower";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // singlePinSelectFlowLayoutPanel
            // 
            this.singlePinSelectFlowLayoutPanel.Controls.Add(this.displayPWMPinComboBox);
            resources.ApplyResources(this.singlePinSelectFlowLayoutPanel, "singlePinSelectFlowLayoutPanel");
            this.singlePinSelectFlowLayoutPanel.Name = "singlePinSelectFlowLayoutPanel";
            // 
            // PinSelectPanel
            // 
            this.PinSelectPanel.Controls.Add(this.singlePinSelectFlowLayoutPanel);
            resources.ApplyResources(this.PinSelectPanel, "PinSelectPanel");
            this.PinSelectPanel.Name = "PinSelectPanel";
            // 
            // DisplayPWMPinPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PinSelectContainer);
            this.DoubleBuffered = true;
            this.Name = "DisplayPWMPinPanel";
            this.PinSelectContainer.ResumeLayout(false);
            this.LabelPinSelectContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.singlePinSelectFlowLayoutPanel.ResumeLayout(false);
            this.PinSelectPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion               
        public System.Windows.Forms.ComboBox displayPWMPinComboBox;
        private System.Windows.Forms.Panel PinSelectContainer;
        
        private System.Windows.Forms.Panel LabelPinSelectContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PWMUpper;
        private System.Windows.Forms.TextBox PWMLower;
        private System.Windows.Forms.TextBox SimUpper;
        private System.Windows.Forms.TextBox SimLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PinSelectPanel;
        private System.Windows.Forms.FlowLayoutPanel singlePinSelectFlowLayoutPanel;
    }
}
