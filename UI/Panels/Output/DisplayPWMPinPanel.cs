using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobiFlight.UI.Panels
{
    public sealed partial class DisplayPWMPinPanel : UserControl
    {
        public DisplayPWMPinPanel()
        {
            InitializeComponent();
            singlePinSelectFlowLayoutPanel.Visible = true;
            PinSelectContainer.Height = singlePinSelectFlowLayoutPanel.Height;
            panel1.Visible = true;
        }

        public event EventHandler<MoveTriggeredEventArgs> OnMoveTriggered;

        internal void SyncFromConfig(OutputConfigItem config)
        {
            var pin = config.PWMDriver.Pin;
            if (string.IsNullOrEmpty(pin))
                return;

            if (!ComboBoxHelper.SetSelectedItem(displayPWMPinComboBox, pin))
                Log.Instance.log("_syncConfigToForm : Exception on selecting item in PWMDriver Pin ComboBox",
                    LogSeverity.Error);

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

        internal OutputConfigItem SyncToConfig(OutputConfigItem config)
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
            var min = (int)SimLower.Value;
            var max = (int)SimUpper.Value;

            if (min > max)
            {
                MessageBox.Show(ProjectMessages.ProjectMessages
                    .DisplayPWMPinPanel_SetTrackBar_Sim_lower_less_than_sim_upper_);
                return;
            }

            int moveValue;
            tickLeft.Text = min.ToString();
            tickRight.Text = max.ToString();

            trackBar1.Minimum = min;
            trackBar1.Maximum = max;
            if (max - min != 0)
                moveValue = min + (max - min) / 2;
            else
                moveValue = min;

            trackBar1.Value = moveValue;
        }

        private void displayPWMPinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = ((ComboBox)sender).SelectedItem.ToString();
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

        
        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (OnMoveTriggered == null)
                return;

            var eventArgs = new MoveTriggeredEventArgs
            {
                Pin = displayPWMPinComboBox.Text,
                SimLower = int.Parse(SimLower.Value.ToString()),
                SimUpper = int.Parse(SimUpper.Value.ToString()),
                PWMLower = int.Parse(PWMLower.Value.ToString()),
                PWMUpper = int.Parse(PWMUpper.Value.ToString()),
                Move = trackBar1.Value.ToString()
            };

            OnMoveTriggered(this, eventArgs);
            
        }


       
    }

    public class MoveTriggeredEventArgs
    {
        public string Pin { get; set; }
        public int SimLower { get; set; }
        public int SimUpper { get; set; }
        public int PWMLower { get; set; }
        public int PWMUpper { get; set; }
        public string Move { get; set; }
    }
}