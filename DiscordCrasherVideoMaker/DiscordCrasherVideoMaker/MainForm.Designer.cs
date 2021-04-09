
namespace DiscordCrasherVideoMaker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMaker = new System.Windows.Forms.TabControl();
            this.Disclaimer = new System.Windows.Forms.TabPage();
            this.buttonIUnderstand = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Maker = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.vidOutputPathLabel = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonVid2 = new System.Windows.Forms.Button();
            this.vid2PathLabel = new System.Windows.Forms.TextBox();
            this.vid1PathLabel = new System.Windows.Forms.TextBox();
            this.buttonVid1 = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.tabMaker.SuspendLayout();
            this.Disclaimer.SuspendLayout();
            this.Maker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMaker
            // 
            this.tabMaker.Controls.Add(this.Disclaimer);
            this.tabMaker.Controls.Add(this.Maker);
            this.tabMaker.Location = new System.Drawing.Point(13, 13);
            this.tabMaker.Name = "tabMaker";
            this.tabMaker.SelectedIndex = 0;
            this.tabMaker.Size = new System.Drawing.Size(278, 352);
            this.tabMaker.TabIndex = 0;
            // 
            // Disclaimer
            // 
            this.Disclaimer.Controls.Add(this.buttonIUnderstand);
            this.Disclaimer.Controls.Add(this.textBox1);
            this.Disclaimer.Location = new System.Drawing.Point(4, 29);
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Padding = new System.Windows.Forms.Padding(3);
            this.Disclaimer.Size = new System.Drawing.Size(270, 319);
            this.Disclaimer.TabIndex = 1;
            this.Disclaimer.Text = "Disclaimer";
            this.Disclaimer.UseVisualStyleBackColor = true;
            // 
            // buttonIUnderstand
            // 
            this.buttonIUnderstand.Location = new System.Drawing.Point(4, 287);
            this.buttonIUnderstand.Name = "buttonIUnderstand";
            this.buttonIUnderstand.Size = new System.Drawing.Size(263, 29);
            this.buttonIUnderstand.TabIndex = 1;
            this.buttonIUnderstand.Text = "I Understand";
            this.buttonIUnderstand.UseVisualStyleBackColor = true;
            this.buttonIUnderstand.Click += new System.EventHandler(this.buttonIUnderstand_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 277);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Maker
            // 
            this.Maker.Controls.Add(this.buttonHelp);
            this.Maker.Controls.Add(this.pictureBox1);
            this.Maker.Controls.Add(this.buttonCreate);
            this.Maker.Controls.Add(this.vidOutputPathLabel);
            this.Maker.Controls.Add(this.buttonOutput);
            this.Maker.Controls.Add(this.buttonVid2);
            this.Maker.Controls.Add(this.vid2PathLabel);
            this.Maker.Controls.Add(this.vid1PathLabel);
            this.Maker.Controls.Add(this.buttonVid1);
            this.Maker.Location = new System.Drawing.Point(4, 29);
            this.Maker.Name = "Maker";
            this.Maker.Padding = new System.Windows.Forms.Padding(3);
            this.Maker.Size = new System.Drawing.Size(270, 319);
            this.Maker.TabIndex = 0;
            this.Maker.Text = "Maker";
            this.Maker.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(135, 213);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(132, 29);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Create Video!";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // vidOutputPathLabel
            // 
            this.vidOutputPathLabel.Location = new System.Drawing.Point(4, 179);
            this.vidOutputPathLabel.Name = "vidOutputPathLabel";
            this.vidOutputPathLabel.ReadOnly = true;
            this.vidOutputPathLabel.Size = new System.Drawing.Size(263, 27);
            this.vidOutputPathLabel.TabIndex = 5;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(4, 143);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(263, 29);
            this.buttonOutput.TabIndex = 4;
            this.buttonOutput.Text = "Output Directory";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonVid2
            // 
            this.buttonVid2.Location = new System.Drawing.Point(4, 74);
            this.buttonVid2.Name = "buttonVid2";
            this.buttonVid2.Size = new System.Drawing.Size(263, 29);
            this.buttonVid2.TabIndex = 3;
            this.buttonVid2.Text = "Video 2";
            this.buttonVid2.UseVisualStyleBackColor = true;
            this.buttonVid2.Click += new System.EventHandler(this.buttonVid2_Click);
            // 
            // vid2PathLabel
            // 
            this.vid2PathLabel.Location = new System.Drawing.Point(4, 109);
            this.vid2PathLabel.Name = "vid2PathLabel";
            this.vid2PathLabel.ReadOnly = true;
            this.vid2PathLabel.Size = new System.Drawing.Size(263, 27);
            this.vid2PathLabel.TabIndex = 2;
            // 
            // vid1PathLabel
            // 
            this.vid1PathLabel.Location = new System.Drawing.Point(4, 40);
            this.vid1PathLabel.Name = "vid1PathLabel";
            this.vid1PathLabel.ReadOnly = true;
            this.vid1PathLabel.Size = new System.Drawing.Size(263, 27);
            this.vid1PathLabel.TabIndex = 1;
            // 
            // buttonVid1
            // 
            this.buttonVid1.Location = new System.Drawing.Point(4, 4);
            this.buttonVid1.Name = "buttonVid1";
            this.buttonVid1.Size = new System.Drawing.Size(263, 29);
            this.buttonVid1.TabIndex = 0;
            this.buttonVid1.Text = "Video 1";
            this.buttonVid1.UseVisualStyleBackColor = true;
            this.buttonVid1.Click += new System.EventHandler(this.buttonVid1_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(135, 287);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(131, 29);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 383);
            this.Controls.Add(this.tabMaker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Crasher Video Maker";
            this.tabMaker.ResumeLayout(false);
            this.Disclaimer.ResumeLayout(false);
            this.Disclaimer.PerformLayout();
            this.Maker.ResumeLayout(false);
            this.Maker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMaker;
        private System.Windows.Forms.TabPage Maker;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonVid2;
        private System.Windows.Forms.TextBox vid2PathLabel;
        private System.Windows.Forms.TextBox vid1PathLabel;
        private System.Windows.Forms.Button buttonVid1;
        private System.Windows.Forms.TabPage Disclaimer;
        private System.Windows.Forms.TextBox vidOutputPathLabel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonIUnderstand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

