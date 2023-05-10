using System.Windows.Forms;

namespace MobiFlight.UI.Panels
{
    sealed partial class DisplayPWMPinPanel
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayPWMPinPanel));
            this.displayPWMPinComboBox = new System.Windows.Forms.ComboBox();
            this.PinSelectContainer = new System.Windows.Forms.Panel();
            this.PinSelectPanel = new System.Windows.Forms.Panel();
            this.singlePinSelectFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelPinSelectContainer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tickRight = new System.Windows.Forms.Label();
            this.tickLeft = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PWMUpper = new System.Windows.Forms.NumericUpDown();
            this.PWMLower = new System.Windows.Forms.NumericUpDown();
            this.SimUpper = new System.Windows.Forms.NumericUpDown();
            this.SimLower = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PinSelectContainer.SuspendLayout();
            this.PinSelectPanel.SuspendLayout();
            this.singlePinSelectFlowLayoutPanel.SuspendLayout();
            this.LabelPinSelectContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWMUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWMLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimLower)).BeginInit();
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
            // PinSelectPanel
            // 
            this.PinSelectPanel.Controls.Add(this.singlePinSelectFlowLayoutPanel);
            resources.ApplyResources(this.PinSelectPanel, "PinSelectPanel");
            this.PinSelectPanel.Name = "PinSelectPanel";
            this.PinSelectPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PinSelectPanel_Paint);
            // 
            // singlePinSelectFlowLayoutPanel
            // 
            this.singlePinSelectFlowLayoutPanel.Controls.Add(this.displayPWMPinComboBox);
            resources.ApplyResources(this.singlePinSelectFlowLayoutPanel, "singlePinSelectFlowLayoutPanel");
            this.singlePinSelectFlowLayoutPanel.Name = "singlePinSelectFlowLayoutPanel";
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
            this.panel1.Controls.Add(this.buttonMove);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tickRight);
            this.panel1.Controls.Add(this.tickLeft);
            this.panel1.Controls.Add(this.trackBar1);
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
            // buttonMove
            // 
            resources.ApplyResources(this.buttonMove, "buttonMove");
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tickRight
            // 
            resources.ApplyResources(this.tickRight, "tickRight");
            this.tickRight.Name = "tickRight";
            // 
            // tickLeft
            // 
            resources.ApplyResources(this.tickLeft, "tickLeft");
            this.tickLeft.Name = "tickLeft";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Maximum = 99;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
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
            this.PWMUpper.Maximum = new decimal(new int[] { 4095, 0, 0, 0 });
            this.PWMUpper.Name = "PWMUpper";
            this.PWMUpper.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // PWMLower
            // 
            resources.ApplyResources(this.PWMLower, "PWMLower");
            this.PWMLower.Maximum = new decimal(new int[] { 4095, 0, 0, 0 });
            this.PWMLower.Name = "PWMLower";
            this.PWMLower.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // SimUpper
            // 
            resources.ApplyResources(this.SimUpper, "SimUpper");
            this.SimUpper.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            this.SimUpper.Minimum = new decimal(new int[] { 2147483647, 0, 0, -2147483648 });
            this.SimUpper.Name = "SimUpper";
            this.SimUpper.Value = new decimal(new int[] { 100, 0, 0, 0 });
            this.SimUpper.TextChanged += new System.EventHandler(this.SimUpper_TextChanged);
            this.SimUpper.ValueChanged += new System.EventHandler(this.SimUpper_TextChanged);
            // 
            // SimLower
            // 
            resources.ApplyResources(this.SimLower, "SimLower");
            this.SimLower.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            this.SimLower.Minimum = new decimal(new int[] { 2147483647, 0, 0, -2147483648 });
            this.SimLower.Name = "SimLower";
            this.SimLower.TextChanged += new System.EventHandler(this.SimLower_TextChanged);
            this.SimLower.ValueChanged += new System.EventHandler(this.SimLower_TextChanged);
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
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // DisplayPWMPinPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PinSelectContainer);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DisplayPWMPinPanel";
            this.PinSelectContainer.ResumeLayout(false);
            this.PinSelectPanel.ResumeLayout(false);
            this.singlePinSelectFlowLayoutPanel.ResumeLayout(false);
            this.LabelPinSelectContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWMUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWMLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimLower)).EndInit();
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
        private System.Windows.Forms.NumericUpDown PWMUpper;
        private System.Windows.Forms.NumericUpDown PWMLower;
        private System.Windows.Forms.NumericUpDown SimUpper;
        private System.Windows.Forms.NumericUpDown SimLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PinSelectPanel;
        private System.Windows.Forms.FlowLayoutPanel singlePinSelectFlowLayoutPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label tickLeft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tickRight;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonMove;
        

        
    }
}
