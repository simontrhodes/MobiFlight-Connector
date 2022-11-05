using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels
{
    public partial class DisplayPWMPinPanel : UserControl
    {
        public event EventHandler<MoveTriggeredEventArgs> OnMoveTriggered;

        public DisplayPWMPinPanel()
        {
            InitializeComponent();
            singlePinSelectFlowLayoutPanel.Visible = true;
            PinSelectContainer.Height = singlePinSelectFlowLayoutPanel.Height;
            panel1.Visible = true;
        }

        internal void syncFromConfig(OutputConfigItem config)
        {
            string pin = config.PWMDriver.Pin;
            if (string.IsNullOrEmpty(pin))
                return;

            if (!ComboBoxHelper.SetSelectedItem(displayPWMPinComboBox, pin))
                Log.Instance.log("_syncConfigToForm : Exception on selecting item in PWMDriver Pin ComboBox", LogSeverity.Error);

            if (string.IsNullOrEmpty(config.PWMDriver.SimLower) ||
                string.IsNullOrEmpty(config.PWMDriver.SimUpper) ||
                string.IsNullOrEmpty(config.PWMDriver.PWMLower) ||
                string.IsNullOrEmpty(config.PWMDriver.PWMUpper))
                return;

            SimLower.Value = int.Parse(config.PWMDriver.SimLower);
            SimUpper.Value = int.Parse(config.PWMDriver.SimUpper);
            PWMLower.Value = int.Parse(config.PWMDriver.PWMLower);
            PWMUpper.Value = int.Parse(config.PWMDriver.PWMUpper);
            SetTrackBar();
            
        }

        virtual internal OutputConfigItem syncToConfig(OutputConfigItem config)
        {
            if (displayPWMPinComboBox.Text != null)
            {
                config.PWMDriver.Pin = displayPWMPinComboBox.Text;
                config.PWMDriver.SimLower = SimLower.Value.ToString();
                config.PWMDriver.SimUpper = SimUpper.Value.ToString();
                config.PWMDriver.PWMLower = PWMLower.Value.ToString();
                config.PWMDriver.PWMUpper = PWMUpper.Value.ToString();
            }
            return config;
        }

        internal void SetPins(List<ListItem> pins)
        {
            displayPWMPinComboBox.DataSource = new List<ListItem>(pins);
            displayPWMPinComboBox.DisplayMember = "Label";
            displayPWMPinComboBox.ValueMember = "Value";

            if (pins.Count > 0)
                displayPWMPinComboBox.SelectedIndex = 0;

            displayPWMPinComboBox.Enabled = pins.Count > 0;
            displayPWMPinComboBox.Width = displayPWMPinComboBox.MinimumSize.Width;

        }

               
       private void SetTrackBar()
        {
            int Min = (int) SimLower.Value;
            int Max = (int) SimUpper.Value;
            
            if(Min>Max)
            {
                MessageBox.Show("Sim range lower value must be less than sim range upper value.");
                return;
            }

            int moveValue;
            tickLeft.Text = Min.ToString();
            tickRight.Text = Max.ToString();

            trackBar1.Minimum = Min;
            trackBar1.Maximum = Max;
            if((Max - Min)!=0)
                moveValue = Min + ((Max - Min) / 2);
            else
                moveValue = Min;
            
            trackBar1.Value = moveValue;
        }

        private void displayPWMPinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = (sender as ComboBox).SelectedItem.ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PinSelectPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
        }

        private void SimLower_TextChanged(object sender, EventArgs e) 
        {
            SetTrackBar();
        }

        private void SimUpper_TextChanged(object sender, EventArgs e)
        {
            SetTrackBar();
        }

        public void buttonMove_Click(object sender, EventArgs e)
        {
            if (OnMoveTriggered == null)
                return;
            
            MoveTriggeredEventArgs eventArgs = new MoveTriggeredEventArgs();

            eventArgs.Pin = displayPWMPinComboBox.Text;
            eventArgs.SimLower = (int) SimLower.Value;
            eventArgs.SimUpper = (int)SimUpper.Value;
            eventArgs.PWMLower = (int)PWMLower.Value;
            eventArgs.PWMUpper = (int)PWMUpper.Value;
            eventArgs.Move = trackBar1.Value;
            OnMoveTriggered(this, eventArgs);
            
        }

    }
    public class MoveTriggeredEventArgs 
    {
        public String Pin { get; set; }
        public int SimLower { get; set; }
        public int SimUpper { get; set; }
        public int PWMLower { get; set; }
        public int PWMUpper { get; set; }
        public int Move { get; set; }
    }
}
