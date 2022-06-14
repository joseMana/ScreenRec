using ScreenRecorderLib;
using System;
using System.IO;
using System.Windows.Forms;
namespace ScreenRec
{
    public partial class Form1 : Form
    {
        public Recorder _rec;
        private string _recordingTitle;
        private bool _isAudioEnabled = true;
        private bool _isInputDeviceEnabled = true;
        private int _frameRate = 35;

        public Form1()
        {
            InitializeComponent();
            InitializeRecorder();
        }

        public void StartRecording()
        {
            _rec.Record(Path.Combine(Path.GetTempPath(), $"{_recordingTitle}.mp4"));
            this.btnRecord.Text = "Stop";
        }
        public void EndRecording()
        {
            _rec.Stop();
            this.btnRecord.Text = "Start";
            this.txtRecordingTitle.Text = Guid.NewGuid().ToString();
        }
        private void InitializeRecorder()
        {
            _rec = Recorder.CreateRecorder();
            _rec.OnRecordingComplete += Rec_OnRecordingComplete;
            _rec.OnRecordingFailed += Rec_OnRecordingFailed;
            _rec.OnStatusChanged += Rec_OnStatusChanged;
        }
    }
}
