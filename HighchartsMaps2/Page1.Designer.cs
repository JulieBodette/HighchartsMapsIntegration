namespace HighchartsMaps2
{
    partial class Page1
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            Wisej.Web.Widget.Package package5 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package6 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package7 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package8 = new Wisej.Web.Widget.Package();
            this.widget1 = new Wisej.Web.Widget();
            this.label1 = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.button6 = new Wisej.Web.Button();
            this.button7 = new Wisej.Web.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button8 = new Wisej.Web.Button();
            this.button9 = new Wisej.Web.Button();
            this.textBox2 = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.widget1.InitScript = resources.GetString("widget1.InitScript");
            this.widget1.Location = new System.Drawing.Point(248, 114);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package5.Name = "highmaps";
            package5.Source = "https://code.highcharts.com/maps/highmaps.js";
            package6.Name = "data.";
            package6.Source = "https://code.highcharts.com/maps/modules/data.js";
            package7.Name = "exporting";
            package7.Source = "https://code.highcharts.com/maps/modules/exporting.js";
            package8.Name = "accessibility";
            package8.Source = "https://code.highcharts.com/maps/modules/accessibility.js";
            this.widget1.Packages.Add(package5);
            this.widget1.Packages.Add(package6);
            this.widget1.Packages.Add(package7);
            this.widget1.Packages.Add(package8);
            this.widget1.Size = new System.Drawing.Size(751, 492);
            this.widget1.TabIndex = 0;
            this.widget1.Text = "widget1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highcharts Maps Integration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1045, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Australia";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1045, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Arctic";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1045, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "south america";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1045, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "change title";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1045, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "Africa";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.LabelText = "Type new title here";
            this.textBox1.Location = new System.Drawing.Point(1045, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 53);
            this.textBox1.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1038, 490);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 36);
            this.button6.TabIndex = 8;
            this.button6.Text = "make continents red";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1038, 552);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "make continents green";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1045, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 37);
            this.button8.TabIndex = 10;
            this.button8.Text = "auto switch continents";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1045, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 37);
            this.button9.TabIndex = 11;
            this.button9.Text = "north america";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox2.Location = new System.Drawing.Point(825, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 30);
            this.textBox2.TabIndex = 12;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widget1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1215, 573);
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Widget widget1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button button5;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Button button6;
        private Wisej.Web.Button button7;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Wisej.Web.Button button8;
        private Wisej.Web.Button button9;
        private Wisej.Web.TextBox textBox2;
    }
}
