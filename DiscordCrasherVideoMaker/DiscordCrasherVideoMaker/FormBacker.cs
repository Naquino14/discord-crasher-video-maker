using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordCrasherVideoMaker
{   public class FormBacker
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private TextBox vid1PathLabel;
        private TextBox vid2PathLabel;
        private TextBox vidOutputPathLabel;
        private Button buttonCreate;

        private string vid1Path;
        private string vid2Path;
        private string vid2NewPath = "tempp\\vid2N.mp4";
        private string outputVidPath;

        private string localDir = "tempp";
        private string textFile = "tempp\\vids.txt";

        public void Initialize(
            TextBox _vid1PathLabel,
            TextBox _vid2PathLabel,
            TextBox _vidOutputPathLabel,
            Button _buttonCreate
            )
        {
            vid1PathLabel = _vid1PathLabel;
            vid2PathLabel = _vid2PathLabel;
            vidOutputPathLabel = _vidOutputPathLabel;
            buttonCreate = _buttonCreate;

            openFileDialog.Filter = "MP4 files (*.mp4)|*.mp4";
            DisposeTemp();
        }

        public void IUnderstandOnClick() => buttonCreate.Enabled = true;

        public void Vid1OnClick()
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    vid1Path = openFileDialog.FileName;
                else
                    return;
                vid1PathLabel.Text = vid1Path;
                Process.Start("cmd.exe", "/c copy \"" + vid1Path + "\" \"" + localDir + "\"");
                Thread.Sleep(2000);
                string[] files = Directory.GetFiles(localDir);
                if (files != null)
                    foreach (string file in files)
                        if (!file.Contains("vid2"))
                            File.Move(file, localDir + "\\vid1.mp4");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Vid2OnClick()
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    vid2Path = openFileDialog.FileName;
                else
                    return;
                vid2PathLabel.Text = vid2Path;
                Process.Start("cmd.exe", "/c copy \"" + vid2Path + "\" \"" + localDir + "\"");
                Thread.Sleep(2000);
                string[] files = Directory.GetFiles(localDir);
                if (files != null)
                    foreach (string file in files)
                        if (!file.Contains("vid1"))
                            File.Move(file, localDir + "\\vid2.mp4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OutputOnClick()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                outputVidPath = folderBrowserDialog.SelectedPath;
            else
                return;
            vidOutputPathLabel.Text = outputVidPath;
        }

        public void CreateVideoOnClick()
        {
            if (vid1PathLabel.Text == null && vid2PathLabel == null && vidOutputPathLabel == null) {
                MessageBox.Show("You must define all fields before making the video.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            Process.Start("ffmpeg.exe", "-i \"" + vid2Path + "\" -pix_fmt yuv444p \"" + vid2NewPath + "\"");
            Thread.Sleep(6000);
            string[] text =
            {
                "file tempp/vid1.mp4", 
                "file tempp/vid2N.mp4"
            };
            File.WriteAllLines(textFile, text);
            string[] files = Directory.GetFiles(localDir);
            if (files.Length != 4)
            {
                DialogResult dialogResult = MessageBox.Show("A file is missing from the temp folder, please restart the application.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                    Application.Exit();
                return;
            }
            Process.Start("ffmpeg.exe", "-f concat -i \"" + textFile + "\" -codec copy \"" + outputVidPath + "\\output.mp4\"");
            MessageBox.Show("Video Created successfully, happy trolling!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisposeTemp();
        }

        public void HelpOnClick() => Process.Start("https://github.com/naquino14/discord-crasher-video-maker");

        public void DisposeTemp()
        {
            string[] temporaryFiles = Directory.GetFiles(localDir);
            if (temporaryFiles != null)
                foreach (string file in temporaryFiles)
                    File.Delete(file);
        }
    }
}
