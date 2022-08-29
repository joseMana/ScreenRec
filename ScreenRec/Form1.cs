using Argus.Audio.NAudio;
using ScreenRecorderLib;
using System;
using System.IO;
using System.Windows.Forms;
namespace ScreenRec
{
    public partial class Form1 : Form
    {
        public Recorder _screenRec;
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
            _screenRec.Record(Path.Combine(Path.GetTempPath(), $"{_recordingTitle}.mp4"));
            this.btnRecord.Text = "Stop";
        }
        public void EndRecording()
        {
            _screenRec.Stop();
            this.btnRecord.Text = "Start";
            this.txtRecordingTitle.Text = Guid.NewGuid().ToString();
        }
        private void InitializeRecorder()
        {
            _screenRec = Recorder.CreateRecorder();
            _screenRec.OnRecordingComplete += Rec_OnRecordingComplete;
            _screenRec.OnRecordingFailed += Rec_OnRecordingFailed;
            _screenRec.OnStatusChanged += Rec_OnStatusChanged;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.btnRecord.Text == "Stop")
                EndRecording();
        }
    }
}
