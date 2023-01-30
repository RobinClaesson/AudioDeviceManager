using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Security.Cryptography.X509Certificates;

namespace AudioDeviceManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CoreAudioController _audioController;

        List<CoreAudioDevice> _audioDevices;
        List<CoreAudioDevice> _audioRecordingDevices;
        List<CoreAudioDevice> _audioPlaybackDevices;

        List<AudioDeviceControl> _recordingDeviceControls;
        List<AudioDeviceControl> _playbackDeviceControls;

        private void Form1_Load(object sender, EventArgs e)
        {
            _audioController = new CoreAudioController();

            GetAudioDevices();
            CreateDeviceControls();
        }

        private void GetAudioDevices()
        {
            _audioDevices = _audioController.GetDevices().Where(d => d.State == DeviceState.Active).OrderBy(d => d.Name).ToList();

            _audioRecordingDevices = _audioDevices.Where(d => d.IsCaptureDevice).ToList();
            _audioPlaybackDevices = _audioDevices.Where(d => d.IsPlaybackDevice).ToList();
        }

        private void CreateDeviceControls()
        {
            _recordingDeviceControls = new List<AudioDeviceControl>();
            _playbackDeviceControls = new List<AudioDeviceControl>();

            for (int i = 0; i < _audioPlaybackDevices.Count; i++)
            {
                var deviceControl = new AudioDeviceControl(_audioPlaybackDevices[i]);
                deviceControl.Top = OutputsLabel.Bottom + 10 + (deviceControl.Height + 5) * i;
                deviceControl.Width = outputDevicePanel.Width;
                deviceControl.RadioButton.Click += PlaybackRadioButtonChecked;
                _playbackDeviceControls.Add(deviceControl);
                outputDevicePanel.Controls.Add(deviceControl);
            }

            for(int i = 0; i < _audioRecordingDevices.Count; i++)
            {
                var deviceControl = new AudioDeviceControl(_audioRecordingDevices[i]);
                deviceControl.Top = InputsLabel.Bottom + 10 + (deviceControl.Height + 5) * i;
                deviceControl.Width = inputDevicePanel.Width;
                deviceControl.RadioButton.Click += RecordingRadioButtonChecked;

                _recordingDeviceControls.Add(deviceControl);
                inputDevicePanel.Controls.Add(deviceControl);
            }
        }

        private void ClearDeviceControls()
        {
            foreach (var deviceControl in _playbackDeviceControls)
            {
                deviceControl.Dispose();
            }
            _playbackDeviceControls.Clear();

            foreach (var deviceControl in _recordingDeviceControls)
            {
                deviceControl.Dispose();
            }
            _recordingDeviceControls.Clear();
        }

        public void RescanAudioDevices()
        {
            ClearDeviceControls();
            GetAudioDevices();
            CreateDeviceControls();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RescanAudioDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RescanAudioDevices();
        }

        private void PlaybackRadioButtonChecked(object sender, EventArgs e)
        {
            foreach (var deviceControl in _playbackDeviceControls)
            {
                if (deviceControl.RadioButton != sender)
                    deviceControl.RadioButton.Checked = false;
            }
        }

        private void RecordingRadioButtonChecked(object sender, EventArgs e)
        {
            foreach (var deviceControl in _recordingDeviceControls)
            {
                if (deviceControl.RadioButton != sender)
                    deviceControl.RadioButton.Checked = false;
            }
        }
    }
}