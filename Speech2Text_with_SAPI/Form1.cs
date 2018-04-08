using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Threading;
using System.Speech.Synthesis;

namespace App
{
    public partial class SpeechToText : Form
    {
        public SpeechRecognitionEngine recognizer;
        public Grammar grammar;
        public Thread RecThread;
        public Boolean RecognizerState = true;
        public SpeechToText()
        {
            InitializeComponent();
        }

        private void SpeechToText_Load(object sender, EventArgs e)
        {
            // here first we need to setup grammar rules
            GrammarBuilder build = new GrammarBuilder();
            build.AppendDictation();
            grammar = new Grammar(build);


            // here we will initialize the the recognizer and setup it events
            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(grammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            // here we will initialize the recognizer thread
            RecognizerState = true;
            RecThread = new Thread(new ThreadStart(RecThreadFunction));
            RecThread.Start();
        }

        private void RecThreadFunction()
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            while (true)
            {
                try
                {
                    recognizer.Recognize();
                }
                catch
                {

                }
            }
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // throw new NotImplementedException();
            //throw new NotImplementedException();
            //recognizer recognize the speech
            if (!RecognizerState)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                textBox1.Text += ("" + e.Result.Text.ToLower());
            });
        }

        private void Enablebtn_Click(object sender, EventArgs e)
        {
            RecognizerState = true;
        }

        private void Diablebtn_Click(object sender, EventArgs e)
        {
            RecognizerState = false;
        }

        private void SpeechToText_FormClosing(object sender, FormClosingEventArgs e)
        {
            RecThread.Abort();
            RecThread = null;

            recognizer.UnloadAllGrammars();
            recognizer.Dispose();
            grammar = null;
        }
    }
}
