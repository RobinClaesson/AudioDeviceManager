using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AudioDeviceManager
{
    public class AudioDeviceControl : Control
    {
        public CoreAudioDevice AudioDevice { get; private set; }
        public Icon Icon { get; private set; }
        public RadioButton RadioButton { get; private set; }
       

        private Color _notDefaultColor = Color.LightGray;
        private Color _isDefaultColor = Color.MediumSeaGreen;
        private bool _flip = false;

        public AudioDeviceControl(CoreAudioDevice coreAudioDevice)
        {
            Width = 200;
            Height = 50;

            AudioDevice = coreAudioDevice;

            if (AudioDevice.Icon == DeviceIcon.Unknown)
            {
                Icon = new Icon(AudioDevice.IconPath);
            }
            else
            {
                var split = AudioDevice.IconPath.LastIndexOf(',');

                var path = AudioDevice.IconPath.Substring(0, split);
                var number = int.Parse(AudioDevice.IconPath.Substring(split + 1));

                Icon = IconExtractor.Extract(path, number, true);
            }

            RadioButton = new RadioButton();
            RadioButton.Left = 50;
            RadioButton.Top = 25 - RadioButton.Height / 2;
            RadioButton.BackColor = Color.Transparent;
            RadioButton.Text = AudioDevice.Name;
            RadioButton.Name = $"{AudioDevice.Name}RadioButton";
            Controls.Add(RadioButton);

            var rightClickMenu = new ContextMenuStrip();

            var setDefaultItem = new ToolStripMenuItem("Set &Default");
            setDefaultItem.Click += (s, e) => SetDefaultClicked();
            rightClickMenu.Items.Add(setDefaultItem);

            ContextMenuStrip = rightClickMenu;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush bgBrush = AudioDevice.IsDefaultDevice ? new SolidBrush(_isDefaultColor) : new SolidBrush(_notDefaultColor);

            if (_flip)
            {
                e.Graphics.FillRectangle(bgBrush, 0, 0, Width, Height);
                e.Graphics.DrawIcon(Icon, new Rectangle(Width - 45, Height - 45, 40, 40));
            }
            else
            {
                e.Graphics.FillRectangle(bgBrush, 0, 0, Width, Height);
                e.Graphics.DrawIcon(Icon, new Rectangle(5, 5, 40, 40));
            }
            bgBrush.Dispose();
        }

        private void SetDefaultClicked()
        {
            AudioDevice.SetAsDefault();
            AudioDevice.SetAsDefaultCommunications();
            Parent.Refresh();
        }

        public void SetFlip(bool flip)
        {
            _flip = flip;
            if(flip)
            {
                RadioButton.Left = Width - 50 - RadioButton.Width;
                RadioButton.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                RadioButton.Left = 50;
                RadioButton.RightToLeft = RightToLeft.No;
            }
        }
    }
}
