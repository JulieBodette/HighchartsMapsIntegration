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
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package2 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package3 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package4 = new Wisej.Web.Widget.Package();
            this.widget1 = new Wisej.Web.Widget();
            this.label1 = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button9 = new Wisej.Web.Button();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox4 = new Wisej.Web.TextBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.widget1.InitScript = resources.GetString("widget1.InitScript");
            this.widget1.Location = new System.Drawing.Point(248, 114);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "highmaps";
            package1.Source = "https://code.highcharts.com/maps/highmaps.js";
            package2.Name = "data.";
            package2.Source = "https://code.highcharts.com/maps/modules/data.js";
            package3.Name = "exporting";
            package3.Source = "https://code.highcharts.com/maps/modules/exporting.js";
            package4.Name = "accessibility";
            package4.Source = "https://code.highcharts.com/maps/modules/accessibility.js";
            this.widget1.Packages.Add(package1);
            this.widget1.Packages.Add(package2);
            this.widget1.Packages.Add(package3);
            this.widget1.Packages.Add(package4);
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
            this.button1.Location = new System.Drawing.Point(1049, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Australia";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1049, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Arctic";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1053, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "South America";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1049, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "change title";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1049, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "Africa";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.LabelText = "Type new title here";
            this.textBox1.Location = new System.Drawing.Point(1049, 472);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 53);
            this.textBox1.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1049, 349);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 37);
            this.button9.TabIndex = 11;
            this.button9.Text = "North America";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox2.LabelText = "Maximum color";
            this.textBox2.Location = new System.Drawing.Point(64, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 53);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox3.LabelText = "Minimum color";
            this.textBox3.Location = new System.Drawing.Point(64, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 53);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox4.LabelText = "Hover color";
            this.textBox4.Location = new System.Drawing.Point(64, 307);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 53);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.Location = new System.Drawing.Point(64, 485);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Auto-rotate";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.LabelText = "Jump to Location";
            this.comboBox1.Location = new System.Drawing.Point(1049, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 53);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedItemChanged += new System.EventHandler(this.comboBox1_SelectedItemChanged);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widget1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(685, 651);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Wisej.Web.Button button9;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.CheckBox checkBox1;
        private Wisej.Web.ComboBox comboBox1;
    }
}
