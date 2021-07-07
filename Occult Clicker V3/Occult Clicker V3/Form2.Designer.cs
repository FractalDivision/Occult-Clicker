
namespace Occult_Clicker_V3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3loadsave = new System.Windows.Forms.Button();
            this.button2save = new System.Windows.Forms.Button();
            this.button_1000 = new System.Windows.Forms.Button();
            this.button_250 = new System.Windows.Forms.Button();
            this.button_100 = new System.Windows.Forms.Button();
            this.button_50 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_points = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3loadsave);
            this.groupBox1.Controls.Add(this.button2save);
            this.groupBox1.Controls.Add(this.button_1000);
            this.groupBox1.Controls.Add(this.button_250);
            this.groupBox1.Controls.Add(this.button_100);
            this.groupBox1.Controls.Add(this.button_50);
            this.groupBox1.Location = new System.Drawing.Point(539, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 442);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upgrades!";
            // 
            // button3loadsave
            // 
            this.button3loadsave.Location = new System.Drawing.Point(168, 336);
            this.button3loadsave.Name = "button3loadsave";
            this.button3loadsave.Size = new System.Drawing.Size(95, 60);
            this.button3loadsave.TabIndex = 8;
            this.button3loadsave.Text = "Load Save";
            this.button3loadsave.UseVisualStyleBackColor = true;
            this.button3loadsave.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2save
            // 
            this.button2save.Location = new System.Drawing.Point(6, 336);
            this.button2save.Name = "button2save";
            this.button2save.Size = new System.Drawing.Size(88, 60);
            this.button2save.TabIndex = 7;
            this.button2save.Text = "Save";
            this.button2save.UseVisualStyleBackColor = true;
            this.button2save.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_1000
            // 
            this.button_1000.Location = new System.Drawing.Point(0, 109);
            this.button_1000.Name = "button_1000";
            this.button_1000.Size = new System.Drawing.Size(264, 23);
            this.button_1000.TabIndex = 4;
            this.button_1000.Text = "1000 Souls";
            this.button_1000.UseVisualStyleBackColor = true;
            this.button_1000.Click += new System.EventHandler(this.button_1000_Click);
            // 
            // button_250
            // 
            this.button_250.Location = new System.Drawing.Point(0, 80);
            this.button_250.Name = "button_250";
            this.button_250.Size = new System.Drawing.Size(264, 23);
            this.button_250.TabIndex = 3;
            this.button_250.Text = "250 Souls";
            this.button_250.UseVisualStyleBackColor = true;
            this.button_250.Click += new System.EventHandler(this.button_250_Click);
            // 
            // button_100
            // 
            this.button_100.Location = new System.Drawing.Point(0, 51);
            this.button_100.Name = "button_100";
            this.button_100.Size = new System.Drawing.Size(264, 23);
            this.button_100.TabIndex = 2;
            this.button_100.Text = "100 Souls";
            this.button_100.UseVisualStyleBackColor = true;
            this.button_100.Click += new System.EventHandler(this.button_100_Click);
            // 
            // button_50
            // 
            this.button_50.Location = new System.Drawing.Point(0, 22);
            this.button_50.Name = "button_50";
            this.button_50.Size = new System.Drawing.Size(264, 23);
            this.button_50.TabIndex = 1;
            this.button_50.Text = "50 Souls";
            this.button_50.UseVisualStyleBackColor = true;
            this.button_50.Click += new System.EventHandler(this.button_50_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 337);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_points
            // 
            this.label_points.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_points.Location = new System.Drawing.Point(12, 12);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(355, 74);
            this.label_points.TabIndex = 8;
            this.label_points.Text = "";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_1000;
        private System.Windows.Forms.Button button_250;
        private System.Windows.Forms.Button button_100;
        private System.Windows.Forms.Button button_50;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2save;
        private System.Windows.Forms.Button button3loadsave;
        private System.Windows.Forms.RichTextBox label_points;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox labelpoints;
    }
}