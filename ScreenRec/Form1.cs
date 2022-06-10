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
        private void OnBtnRecordClick(object sender, EventArgs e)
        {
            if(this.btnRecord.Text == "Stop")
            {
                EndRecording();
                return;
            }

            _rec.SetOptions(new RecorderOptions
            {
                AudioOptions = new AudioOptions
                {
                    IsAudioEnabled = _isAudioEnabled,
                    IsInputDeviceEnabled = _isInputDeviceEnabled
                },
                VideoEncoderOptions = new VideoEncoderOptions
                {
                    Framerate = _frameRate
                }
            });

            StartRecording();
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
        }
        private void Rec_OnRecordingComplete(object sender, RecordingCompleteEventArgs e)
        {
            string path = e.FilePath;
            Console.WriteLine(path);
        }
        private void Rec_OnRecordingFailed(object sender, RecordingFailedEventArgs e)
        {
            string error = e.Error;
            Console.WriteLine(error);
        }
        private void Rec_OnStatusChanged(object sender, RecordingStatusEventArgs e)
        {
            RecorderStatus status = e.Status;
            Console.WriteLine(status.ToString());
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
