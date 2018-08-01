namespace R_Cluzzy.Analyze
{
    partial class PFCMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PFCMForm));
            this.RadarPlotCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.fcmCancelButton = new System.Windows.Forms.Button();
            this.plotcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.mapcheckBox = new System.Windows.Forms.CheckBox();
            this.removeDatakeyButton = new System.Windows.Forms.Button();
            this.addDatakeyButton = new System.Windows.Forms.Button();
            this.datakeyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datakeyListBox = new System.Windows.Forms.ListBox();
            this.maptextBox = new System.Windows.Forms.TextBox();
            this.kwonbox = new System.Windows.Forms.CheckBox();
            this.picheckBox = new System.Windows.Forms.CheckBox();
            this.xbcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_konsa = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.removeNameButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.selectedListBox = new System.Windows.Forms.ListBox();
            this.allvarListBox = new System.Windows.Forms.ListBox();
            this.moveFromButton = new System.Windows.Forms.Button();
            this.moveToButton = new System.Windows.Forms.Button();
            this.addNameButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_clus = new System.Windows.Forms.TextBox();
            this.listBox_distance = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_eta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_maxiter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_error = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_konsb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_konsk = new System.Windows.Forms.TextBox();
            this.shpDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadarPlotCheckBox
            // 
            this.RadarPlotCheckBox.AutoSize = true;
            this.RadarPlotCheckBox.ForeColor = System.Drawing.Color.Navy;
            this.RadarPlotCheckBox.Location = new System.Drawing.Point(258, 17);
            this.RadarPlotCheckBox.Name = "RadarPlotCheckBox";
            this.RadarPlotCheckBox.Size = new System.Drawing.Size(106, 17);
            this.RadarPlotCheckBox.TabIndex = 167;
            this.RadarPlotCheckBox.Text = "Show Radar Plot";
            this.RadarPlotCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessButton
            // 
            this.ProcessButton.BackColor = System.Drawing.Color.Transparent;
            this.ProcessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProcessButton.Location = new System.Drawing.Point(459, 413);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 165;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = false;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // fcmCancelButton
            // 
            this.fcmCancelButton.Location = new System.Drawing.Point(570, 413);
            this.fcmCancelButton.Name = "fcmCancelButton";
            this.fcmCancelButton.Size = new System.Drawing.Size(75, 23);
            this.fcmCancelButton.TabIndex = 166;
            this.fcmCancelButton.Text = "Cancel";
            this.fcmCancelButton.UseVisualStyleBackColor = true;
            // 
            // plotcheckBox
            // 
            this.plotcheckBox.AutoSize = true;
            this.plotcheckBox.ForeColor = System.Drawing.Color.Navy;
            this.plotcheckBox.Location = new System.Drawing.Point(138, 17);
            this.plotcheckBox.Name = "plotcheckBox";
            this.plotcheckBox.Size = new System.Drawing.Size(114, 17);
            this.plotcheckBox.TabIndex = 162;
            this.plotcheckBox.Text = "Show Clusters Plot";
            this.plotcheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.RadarPlotCheckBox);
            this.groupBox1.Controls.Add(this.mapcheckBox);
            this.groupBox1.Controls.Add(this.removeDatakeyButton);
            this.groupBox1.Controls.Add(this.addDatakeyButton);
            this.groupBox1.Controls.Add(this.plotcheckBox);
            this.groupBox1.Controls.Add(this.datakeyLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datakeyListBox);
            this.groupBox1.Controls.Add(this.maptextBox);
            this.groupBox1.Controls.Add(this.kwonbox);
            this.groupBox1.Controls.Add(this.picheckBox);
            this.groupBox1.Controls.Add(this.xbcheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(20, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 142);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validity Index";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(135, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 167;
            this.label4.Text = "Plot and Map";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // browseButton
            // 
            this.browseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseButton.Location = new System.Drawing.Point(267, 112);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 152;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // mapcheckBox
            // 
            this.mapcheckBox.AutoSize = true;
            this.mapcheckBox.ForeColor = System.Drawing.Color.Navy;
            this.mapcheckBox.Location = new System.Drawing.Point(138, 40);
            this.mapcheckBox.Name = "mapcheckBox";
            this.mapcheckBox.Size = new System.Drawing.Size(77, 17);
            this.mapcheckBox.TabIndex = 158;
            this.mapcheckBox.Text = "Show Map";
            this.mapcheckBox.UseVisualStyleBackColor = true;
            this.mapcheckBox.CheckedChanged += new System.EventHandler(this.mapcheckBox_CheckedChanged);
            // 
            // removeDatakeyButton
            // 
            this.removeDatakeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDatakeyButton.ForeColor = System.Drawing.Color.Navy;
            this.removeDatakeyButton.Location = new System.Drawing.Point(144, 109);
            this.removeDatakeyButton.Name = "removeDatakeyButton";
            this.removeDatakeyButton.Size = new System.Drawing.Size(29, 26);
            this.removeDatakeyButton.TabIndex = 157;
            this.removeDatakeyButton.Text = "<";
            this.removeDatakeyButton.UseVisualStyleBackColor = true;
            this.removeDatakeyButton.Click += new System.EventHandler(this.removeDatakeyButton_Click);
            // 
            // addDatakeyButton
            // 
            this.addDatakeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDatakeyButton.ForeColor = System.Drawing.Color.Navy;
            this.addDatakeyButton.Location = new System.Drawing.Point(144, 79);
            this.addDatakeyButton.Name = "addDatakeyButton";
            this.addDatakeyButton.Size = new System.Drawing.Size(29, 26);
            this.addDatakeyButton.TabIndex = 156;
            this.addDatakeyButton.Text = ">";
            this.addDatakeyButton.UseVisualStyleBackColor = true;
            this.addDatakeyButton.Click += new System.EventHandler(this.addDatakeyButton_Click);
            // 
            // datakeyLabel
            // 
            this.datakeyLabel.AutoSize = true;
            this.datakeyLabel.ForeColor = System.Drawing.Color.Navy;
            this.datakeyLabel.Location = new System.Drawing.Point(135, 62);
            this.datakeyLabel.Name = "datakeyLabel";
            this.datakeyLabel.Size = new System.Drawing.Size(84, 13);
            this.datakeyLabel.TabIndex = 154;
            this.datakeyLabel.Text = "Select Data Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(264, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Select Shapefile";
            // 
            // datakeyListBox
            // 
            this.datakeyListBox.FormattingEnabled = true;
            this.datakeyListBox.Location = new System.Drawing.Point(179, 79);
            this.datakeyListBox.Name = "datakeyListBox";
            this.datakeyListBox.Size = new System.Drawing.Size(82, 56);
            this.datakeyListBox.TabIndex = 153;
            // 
            // maptextBox
            // 
            this.maptextBox.Location = new System.Drawing.Point(267, 78);
            this.maptextBox.Name = "maptextBox";
            this.maptextBox.Size = new System.Drawing.Size(100, 20);
            this.maptextBox.TabIndex = 150;
            // 
            // kwonbox
            // 
            this.kwonbox.AutoSize = true;
            this.kwonbox.ForeColor = System.Drawing.Color.Navy;
            this.kwonbox.Location = new System.Drawing.Point(18, 65);
            this.kwonbox.Name = "kwonbox";
            this.kwonbox.Size = new System.Drawing.Size(82, 17);
            this.kwonbox.TabIndex = 91;
            this.kwonbox.Text = "Kwon Index";
            this.kwonbox.UseVisualStyleBackColor = true;
            this.kwonbox.CheckedChanged += new System.EventHandler(this.kwonbox_CheckedChanged);
            // 
            // picheckBox
            // 
            this.picheckBox.AutoSize = true;
            this.picheckBox.ForeColor = System.Drawing.Color.Navy;
            this.picheckBox.Location = new System.Drawing.Point(18, 19);
            this.picheckBox.Name = "picheckBox";
            this.picheckBox.Size = new System.Drawing.Size(93, 17);
            this.picheckBox.TabIndex = 81;
            this.picheckBox.Text = "Partition Index";
            this.picheckBox.UseVisualStyleBackColor = true;
            this.picheckBox.CheckedChanged += new System.EventHandler(this.picheckBox_CheckedChanged);
            // 
            // xbcheckBox
            // 
            this.xbcheckBox.AutoSize = true;
            this.xbcheckBox.ForeColor = System.Drawing.Color.Navy;
            this.xbcheckBox.Location = new System.Drawing.Point(18, 42);
            this.xbcheckBox.Name = "xbcheckBox";
            this.xbcheckBox.Size = new System.Drawing.Size(94, 17);
            this.xbcheckBox.TabIndex = 84;
            this.xbcheckBox.Text = "Xie Beni Index";
            this.xbcheckBox.UseVisualStyleBackColor = true;
            this.xbcheckBox.CheckedChanged += new System.EventHandler(this.xbcheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_m);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox_konsa);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(415, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 72);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameter  Probabilistic FCM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(86, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Fuzzifier (m) :";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(164, 22);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(87, 20);
            this.textBox_m.TabIndex = 109;
            this.textBox_m.Text = "2";
            this.textBox_m.TextChanged += new System.EventHandler(this.mtextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(89, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Variabel (A) :";
            // 
            // textBox_konsa
            // 
            this.textBox_konsa.Location = new System.Drawing.Point(164, 48);
            this.textBox_konsa.Name = "textBox_konsa";
            this.textBox_konsa.Size = new System.Drawing.Size(87, 20);
            this.textBox_konsa.TabIndex = 35;
            this.textBox_konsa.Text = "1";
            this.textBox_konsa.TextChanged += new System.EventHandler(this.textBox_att_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameLabel.Location = new System.Drawing.Point(230, 169);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(115, 13);
            this.nameLabel.TabIndex = 157;
            this.nameLabel.Text = "Observation Name ";
            // 
            // removeNameButton
            // 
            this.removeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeNameButton.ForeColor = System.Drawing.Color.Navy;
            this.removeNameButton.Location = new System.Drawing.Point(194, 255);
            this.removeNameButton.Name = "removeNameButton";
            this.removeNameButton.Size = new System.Drawing.Size(29, 26);
            this.removeNameButton.TabIndex = 159;
            this.removeNameButton.Text = "<";
            this.removeNameButton.UseVisualStyleBackColor = true;
            this.removeNameButton.Click += new System.EventHandler(this.removeNameButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(232, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 156;
            this.label6.Text = "Selected Variables";
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(233, 185);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(166, 134);
            this.nameListBox.TabIndex = 155;
            // 
            // selectedListBox
            // 
            this.selectedListBox.FormattingEnabled = true;
            this.selectedListBox.Location = new System.Drawing.Point(233, 45);
            this.selectedListBox.Name = "selectedListBox";
            this.selectedListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectedListBox.Size = new System.Drawing.Size(166, 121);
            this.selectedListBox.TabIndex = 154;
            // 
            // allvarListBox
            // 
            this.allvarListBox.FormattingEnabled = true;
            this.allvarListBox.Location = new System.Drawing.Point(20, 28);
            this.allvarListBox.Name = "allvarListBox";
            this.allvarListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.allvarListBox.Size = new System.Drawing.Size(160, 290);
            this.allvarListBox.TabIndex = 153;
            this.allvarListBox.SelectedIndexChanged += new System.EventHandler(this.allvarListBox_SelectedIndexChanged);
            // 
            // moveFromButton
            // 
            this.moveFromButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveFromButton.ForeColor = System.Drawing.Color.Navy;
            this.moveFromButton.Location = new System.Drawing.Point(194, 106);
            this.moveFromButton.Name = "moveFromButton";
            this.moveFromButton.Size = new System.Drawing.Size(29, 26);
            this.moveFromButton.TabIndex = 152;
            this.moveFromButton.Text = "<";
            this.moveFromButton.UseVisualStyleBackColor = true;
            this.moveFromButton.Click += new System.EventHandler(this.moveFromButton_Click);
            // 
            // moveToButton
            // 
            this.moveToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveToButton.ForeColor = System.Drawing.Color.Navy;
            this.moveToButton.Location = new System.Drawing.Point(194, 74);
            this.moveToButton.Name = "moveToButton";
            this.moveToButton.Size = new System.Drawing.Size(29, 26);
            this.moveToButton.TabIndex = 151;
            this.moveToButton.Text = ">";
            this.moveToButton.UseVisualStyleBackColor = true;
            this.moveToButton.Click += new System.EventHandler(this.moveToButton_Click);
            // 
            // addNameButton
            // 
            this.addNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameButton.ForeColor = System.Drawing.Color.Navy;
            this.addNameButton.Location = new System.Drawing.Point(194, 225);
            this.addNameButton.Name = "addNameButton";
            this.addNameButton.Size = new System.Drawing.Size(29, 26);
            this.addNameButton.TabIndex = 158;
            this.addNameButton.Text = ">";
            this.addNameButton.UseVisualStyleBackColor = true;
            this.addNameButton.Click += new System.EventHandler(this.addNameButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_clus);
            this.groupBox2.Controls.Add(this.listBox_distance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_eta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_maxiter);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_error);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_konsb);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox_konsk);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(415, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 212);
            this.groupBox2.TabIndex = 161;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameter  Possibilistic FCM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(40, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Number of Cluster (c) :";
            // 
            // textBox_clus
            // 
            this.textBox_clus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_clus.Location = new System.Drawing.Point(165, 178);
            this.textBox_clus.Name = "textBox_clus";
            this.textBox_clus.Size = new System.Drawing.Size(86, 19);
            this.textBox_clus.TabIndex = 119;
            this.textBox_clus.Text = "2";
            this.textBox_clus.TextChanged += new System.EventHandler(this.textBox_c_TextChanged);
            // 
            // listBox_distance
            // 
            this.listBox_distance.FormattingEnabled = true;
            this.listBox_distance.Items.AddRange(new object[] {
            "Euclidean",
            "Mahalanobis"});
            this.listBox_distance.Location = new System.Drawing.Point(164, 102);
            this.listBox_distance.Name = "listBox_distance";
            this.listBox_distance.Size = new System.Drawing.Size(87, 17);
            this.listBox_distance.TabIndex = 118;
            this.listBox_distance.SelectedIndexChanged += new System.EventHandler(this.listBox_distance_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(98, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Distance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(86, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Fuzzifier (η) :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_eta
            // 
            this.textBox_eta.Location = new System.Drawing.Point(164, 25);
            this.textBox_eta.Name = "textBox_eta";
            this.textBox_eta.Size = new System.Drawing.Size(87, 20);
            this.textBox_eta.TabIndex = 109;
            this.textBox_eta.Text = "2";
            this.textBox_eta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(14, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Maximum Iteration (maxiter) :";
            // 
            // textBox_maxiter
            // 
            this.textBox_maxiter.Location = new System.Drawing.Point(164, 128);
            this.textBox_maxiter.Name = "textBox_maxiter";
            this.textBox_maxiter.Size = new System.Drawing.Size(87, 20);
            this.textBox_maxiter.TabIndex = 111;
            this.textBox_maxiter.Text = "100";
            this.textBox_maxiter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(15, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "Expected Improvement (e) :";
            // 
            // textBox_error
            // 
            this.textBox_error.Location = new System.Drawing.Point(164, 154);
            this.textBox_error.Name = "textBox_error";
            this.textBox_error.Size = new System.Drawing.Size(87, 20);
            this.textBox_error.TabIndex = 113;
            this.textBox_error.Text = "0.00001";
            this.textBox_error.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(87, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Variabel (B) :";
            // 
            // textBox_konsb
            // 
            this.textBox_konsb.Location = new System.Drawing.Point(164, 49);
            this.textBox_konsb.Name = "textBox_konsb";
            this.textBox_konsb.Size = new System.Drawing.Size(87, 20);
            this.textBox_konsb.TabIndex = 35;
            this.textBox_konsb.Text = "1";
            this.textBox_konsb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(134, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "K :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox_konsk
            // 
            this.textBox_konsk.Location = new System.Drawing.Point(164, 74);
            this.textBox_konsk.Name = "textBox_konsk";
            this.textBox_konsk.Size = new System.Drawing.Size(87, 20);
            this.textBox_konsk.TabIndex = 39;
            this.textBox_konsk.Text = "3";
            this.textBox_konsk.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // shpDialog
            // 
            this.shpDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.shpDialog_FileOk);
            // 
            // PFCMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(741, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.fcmCancelButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.removeNameButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.selectedListBox);
            this.Controls.Add(this.allvarListBox);
            this.Controls.Add(this.moveFromButton);
            this.Controls.Add(this.moveToButton);
            this.Controls.Add(this.addNameButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PFCMForm";
            this.Text = "Possibilistic Fuzzy C Means";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RadarPlotCheckBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button fcmCancelButton;
        private System.Windows.Forms.CheckBox plotcheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox kwonbox;
        private System.Windows.Forms.CheckBox picheckBox;
        private System.Windows.Forms.CheckBox xbcheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_konsa;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button removeNameButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.ListBox selectedListBox;
        private System.Windows.Forms.ListBox allvarListBox;
        private System.Windows.Forms.Button moveFromButton;
        private System.Windows.Forms.Button moveToButton;
        private System.Windows.Forms.Button addNameButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_eta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_maxiter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_error;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_konsb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_konsk;
        private System.Windows.Forms.ListBox listBox_distance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_clus;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox mapcheckBox;
        private System.Windows.Forms.Button removeDatakeyButton;
        private System.Windows.Forms.Button addDatakeyButton;
        private System.Windows.Forms.Label datakeyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox datakeyListBox;
        private System.Windows.Forms.TextBox maptextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog shpDialog;
    }
}