using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CartPlayer
{
    public partial class Form1 : Form
    {
        protected IrrKlang.ISoundEngine irrKlangEngine;
        protected IrrKlang.ISound audio1;
        protected IrrKlang.ISound audio2;
        protected IrrKlang.ISound audio3;

        public Form1()
        {
            InitializeComponent();
            // create irrklang sound engine
            irrKlangEngine = new IrrKlang.ISoundEngine();
        }

        private void btnCartStop1_Click(object sender, EventArgs e)
        {
            StopPlayer(1);
        }

        private void btnPlayAudio1_Click(object sender, EventArgs e)
        {
            PlayPlayer(1);
        }

       
        private void LoadAudio(String filename, Int32 playerNum)
        {
            switch (playerNum)
            {
                case 1:
                    // load new sound
                    chkboxCart1Loop.Checked = false;

                    audio1 = irrKlangEngine.Play2D(filename, false, true);
                    pbarCart1.Maximum = (int)audio1.PlayLength;
                    pbarCart1.Minimum = 0;
                    lblItemName1.Text = filename;
                    tmrCart1.Enabled = true;
                    btnPlayAudio1.Enabled = true;
                    break;
                case 2:
                    // load new sound
                    chkboxCart2Loop.Checked = false;

                    audio2 = irrKlangEngine.Play2D(filename, false, true);
                    pbarCart2.Maximum = (int)audio2.PlayLength;
                    pbarCart2.Minimum = 0;
                    lblItemName2.Text = filename;
                    tmrCart2.Enabled = true;
                    btnPlayAudio2.Enabled = true;
                    break;
                case 3:

                    // load new sound
                    chkboxCart3Loop.Checked = false;

                    audio3 = irrKlangEngine.Play2D(filename, false, true);
                    pbarCart3.Maximum = (int)audio3.PlayLength;
                    pbarCart3.Minimum = 0;
                    lblItemName3.Text = filename;
                    tmrCart3.Enabled = true;
                    btnPlayAudio3.Enabled = true;
                    break;
                default:
                    break;
            }
        }

       
        private string SecondstoHMS(int p)
        {
            int seconds = p / 1000;
            TimeSpan span = new TimeSpan(0, 0, seconds);
            int iHr = span.Hours;
            int iMn = span.Minutes;
            int iSec = span.Seconds;

            return ((iHr < 10 ? "0" : "") + iHr
             + ":" + (iMn < 10 ? "0" : "") + iMn
             + ":" + (iSec < 10 ? "0" : "") + iSec);
            
        }

        private void PlayPlayer(Int32 playerNum)
        {
            switch (playerNum)
            {
                case 1:
                    audio1.Paused = false;
                    btnLoadCart1.Enabled = false;
                    btnPlayAudio1.Enabled = false;
                    btnCartStop1.Enabled = true;
                    tmrCart1.Enabled = true;
                    break;
                case 2:
                    audio2.Paused = false;
                    btnLoadCart2.Enabled = false;
                    btnPlayAudio2.Enabled = false;
                    btnCartStop2.Enabled = true;
                    tmrCart2.Enabled = true;
                    break;
                case 3:
                    audio3.Paused = false;
                    btnLoadCart3.Enabled = false;
                    btnPlayAudio3.Enabled = false;
                    btnCartStop3.Enabled = true;
                    tmrCart3.Enabled = true;
                    break;
                default:
                    break;
            }

        }

        private void StopPlayer(Int32 playerNum)
        {
            switch (playerNum)
            {
                case 1:
                    audio1.Paused = true;
                    audio1.PlayPosition = 0;
                    btnLoadCart1.Enabled = true;
                    btnPlayAudio1.Enabled = true;
                    tmrCart1.Enabled = false;
                    pbarCart1.Value = 0;

                    lblTimingCart1.Text =
                           "Past: " + SecondstoHMS(0) +
                           "  --  Left: " + SecondstoHMS((int)audio1.PlayLength);
                    break;
                case 2:
                    audio2.Paused = true;
                    audio2.PlayPosition = 0;
                    btnLoadCart2.Enabled = true;
                    btnPlayAudio2.Enabled = true;
                    tmrCart2.Enabled = false;
                    pbarCart2.Value = 0;

                    lblTimingCart2.Text =
                           "Past: " + SecondstoHMS(0) +
                           "  --  Left: " + SecondstoHMS((int)audio2.PlayLength);
                    break;
                case 3:
                    audio3.Paused = true;
                    audio3.PlayPosition = 0;
                    btnLoadCart3.Enabled = true;
                    btnPlayAudio3.Enabled = true;
                    tmrCart3.Enabled = false;
                    pbarCart3.Value = 0;

                    lblTimingCart3.Text =
                           "Past: " + SecondstoHMS(0) +
                           "  --  Left: " + SecondstoHMS((int)audio3.PlayLength);
                    break;
                default:
                    break;
            }

        }

        private void chkboxCart1Loop_CheckedChanged(object sender, EventArgs e)
        {
            audio1.Looped = chkboxCart1Loop.Checked;
        }

        private void chkboxCart2Loop_CheckedChanged(object sender, EventArgs e)
        {
            audio2.Looped = chkboxCart2Loop.Checked;
        }

        private void chkboxCart3Loop_CheckedChanged(object sender, EventArgs e)
        {
            audio3.Looped = chkboxCart3Loop.Checked;
        }

        private void tmrCart1_Tick(object sender, EventArgs e)
        {
            pbarCart1.Value = (int)audio1.PlayPosition;
            lblTimingCart1.Text =
                "Past: " + SecondstoHMS((int)audio1.PlayPosition) +
                "  --  Left: " + SecondstoHMS((int)audio1.PlayLength - (int)audio1.PlayPosition);


            if (audio1.Finished)
            {
                StopPlayer(1);
            }
        }

        
        private void tmrCart2_Tick(object sender, EventArgs e)
        {
            pbarCart2.Value = (int)audio2.PlayPosition;
            lblTimingCart2.Text =
                "Past: " + SecondstoHMS((int)audio2.PlayPosition) +
                "  --  Left: " + SecondstoHMS((int)audio2.PlayLength - (int)audio2.PlayPosition);


            if (audio2.Finished)
            {
                StopPlayer(2);
            }
        }

        private void tmrCart3_Tick(object sender, EventArgs e)
        {
            pbarCart3.Value = (int)audio3.PlayPosition;
            lblTimingCart3.Text =
                "Past: " + SecondstoHMS((int)audio3.PlayPosition) +
                "  --  Left: " + SecondstoHMS((int)audio3.PlayLength - (int)audio3.PlayPosition);


            if (audio3.Finished)
            {
                StopPlayer(3);
            }
        }

        private void btnLoadCart1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                LoadAudio(openFileDialog1.FileName, 1);
            }
        }

        private void btnLoadCart2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                LoadAudio(openFileDialog1.FileName, 2);
            }
        }

        private void btnLoadCart3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                LoadAudio(openFileDialog1.FileName, 3);
            }
        }

        private void btnPlayAudio2_Click(object sender, EventArgs e)
        {
            PlayPlayer(2);
        }

        private void btnPlayAudio3_Click(object sender, EventArgs e)
        {
            PlayPlayer(3);
        }

        private void btnCartStop3_Click(object sender, EventArgs e)
        {
            StopPlayer(3);
        }

        private void btnCartStop2_Click(object sender, EventArgs e)
        {
            StopPlayer(2);
        }

    }

}
