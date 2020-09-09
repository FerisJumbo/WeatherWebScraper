namespace WeatherWebScrapper
{
    partial class WeatherWebScraper
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
            this.btnScrape = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbxToday = new System.Windows.Forms.GroupBox();
            this.txtbxMoonPhase = new System.Windows.Forms.TextBox();
            this.txtbxTofD = new System.Windows.Forms.TextBox();
            this.txtbxWCHI = new System.Windows.Forms.TextBox();
            this.txtbxMoonRS = new System.Windows.Forms.TextBox();
            this.txtbxCurrentTemp = new System.Windows.Forms.TextBox();
            this.txtbxDew = new System.Windows.Forms.TextBox();
            this.txtbxSunRS = new System.Windows.Forms.TextBox();
            this.txtbxWindSD = new System.Windows.Forms.TextBox();
            this.txtbxPressure = new System.Windows.Forms.TextBox();
            this.txtbxCloudCover = new System.Windows.Forms.TextBox();
            this.txtbxRecLow = new System.Windows.Forms.TextBox();
            this.txtbxHigh = new System.Windows.Forms.TextBox();
            this.txtbxRecHigh = new System.Windows.Forms.TextBox();
            this.txtbxLow = new System.Windows.Forms.TextBox();
            this.btnBranson = new System.Windows.Forms.Button();
            this.btnNaples = new System.Windows.Forms.Button();
            this.radPresets = new System.Windows.Forms.RadioButton();
            this.radCustomURL = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtbxCustomURL = new System.Windows.Forms.TextBox();
            this.btnVisitWeb = new System.Windows.Forms.Button();
            this.radMetrics = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.gbxUnits = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbxDEBUG = new System.Windows.Forms.TextBox();
            this.numIndexError = new System.Windows.Forms.NumericUpDown();
            this.btnHutch = new System.Windows.Forms.Button();
            this.btnNextDayFore = new System.Windows.Forms.Button();
            this.gbxToday.SuspendLayout();
            this.gbxUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(541, 66);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(161, 57);
            this.btnScrape.TabIndex = 1;
            this.btnScrape.Text = "Scrape!";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "High Temp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Low Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Record High:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Record Low:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cloud Cover:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pressure:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Wind Speed/Direction:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dew Point:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Current Temp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Wind Chill/Heat Index:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Time of Day:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Sun Rise/Set:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Moon Rise/Set:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Moon Phase:";
            // 
            // gbxToday
            // 
            this.gbxToday.Controls.Add(this.txtbxMoonPhase);
            this.gbxToday.Controls.Add(this.txtbxTofD);
            this.gbxToday.Controls.Add(this.txtbxWCHI);
            this.gbxToday.Controls.Add(this.txtbxMoonRS);
            this.gbxToday.Controls.Add(this.txtbxCurrentTemp);
            this.gbxToday.Controls.Add(this.txtbxDew);
            this.gbxToday.Controls.Add(this.label14);
            this.gbxToday.Controls.Add(this.txtbxSunRS);
            this.gbxToday.Controls.Add(this.txtbxWindSD);
            this.gbxToday.Controls.Add(this.txtbxPressure);
            this.gbxToday.Controls.Add(this.label13);
            this.gbxToday.Controls.Add(this.txtbxCloudCover);
            this.gbxToday.Controls.Add(this.label1);
            this.gbxToday.Controls.Add(this.txtbxRecLow);
            this.gbxToday.Controls.Add(this.label12);
            this.gbxToday.Controls.Add(this.label11);
            this.gbxToday.Controls.Add(this.txtbxHigh);
            this.gbxToday.Controls.Add(this.txtbxRecHigh);
            this.gbxToday.Controls.Add(this.label2);
            this.gbxToday.Controls.Add(this.label10);
            this.gbxToday.Controls.Add(this.txtbxLow);
            this.gbxToday.Controls.Add(this.label9);
            this.gbxToday.Controls.Add(this.label3);
            this.gbxToday.Controls.Add(this.label4);
            this.gbxToday.Controls.Add(this.label8);
            this.gbxToday.Controls.Add(this.label5);
            this.gbxToday.Controls.Add(this.label7);
            this.gbxToday.Controls.Add(this.label6);
            this.gbxToday.Location = new System.Drawing.Point(12, 12);
            this.gbxToday.Name = "gbxToday";
            this.gbxToday.Size = new System.Drawing.Size(482, 210);
            this.gbxToday.TabIndex = 20;
            this.gbxToday.TabStop = false;
            this.gbxToday.Text = "Today\'s Forecast";
            // 
            // txtbxMoonPhase
            // 
            this.txtbxMoonPhase.Location = new System.Drawing.Point(365, 173);
            this.txtbxMoonPhase.Name = "txtbxMoonPhase";
            this.txtbxMoonPhase.Size = new System.Drawing.Size(100, 20);
            this.txtbxMoonPhase.TabIndex = 33;
            this.txtbxMoonPhase.DoubleClick += new System.EventHandler(this.txtbxMoonPhase_DoubleClick);
            // 
            // txtbxTofD
            // 
            this.txtbxTofD.Location = new System.Drawing.Point(365, 95);
            this.txtbxTofD.Name = "txtbxTofD";
            this.txtbxTofD.Size = new System.Drawing.Size(100, 20);
            this.txtbxTofD.TabIndex = 30;
            this.txtbxTofD.DoubleClick += new System.EventHandler(this.txtbxTofD_DoubleClick);
            // 
            // txtbxWCHI
            // 
            this.txtbxWCHI.Location = new System.Drawing.Point(365, 69);
            this.txtbxWCHI.Name = "txtbxWCHI";
            this.txtbxWCHI.Size = new System.Drawing.Size(100, 20);
            this.txtbxWCHI.TabIndex = 29;
            this.txtbxWCHI.DoubleClick += new System.EventHandler(this.txtbxWCHI_DoubleClick);
            // 
            // txtbxMoonRS
            // 
            this.txtbxMoonRS.Location = new System.Drawing.Point(365, 147);
            this.txtbxMoonRS.Name = "txtbxMoonRS";
            this.txtbxMoonRS.Size = new System.Drawing.Size(100, 20);
            this.txtbxMoonRS.TabIndex = 32;
            this.txtbxMoonRS.DoubleClick += new System.EventHandler(this.txtbxMoonRS_DoubleClick);
            // 
            // txtbxCurrentTemp
            // 
            this.txtbxCurrentTemp.Location = new System.Drawing.Point(365, 43);
            this.txtbxCurrentTemp.Name = "txtbxCurrentTemp";
            this.txtbxCurrentTemp.Size = new System.Drawing.Size(100, 20);
            this.txtbxCurrentTemp.TabIndex = 28;
            this.txtbxCurrentTemp.DoubleClick += new System.EventHandler(this.txtbxCurrentTemp_DoubleClick);
            // 
            // txtbxDew
            // 
            this.txtbxDew.Location = new System.Drawing.Point(365, 17);
            this.txtbxDew.Name = "txtbxDew";
            this.txtbxDew.Size = new System.Drawing.Size(100, 20);
            this.txtbxDew.TabIndex = 27;
            this.txtbxDew.DoubleClick += new System.EventHandler(this.txtbxDew_DoubleClick);
            // 
            // txtbxSunRS
            // 
            this.txtbxSunRS.Location = new System.Drawing.Point(365, 121);
            this.txtbxSunRS.Name = "txtbxSunRS";
            this.txtbxSunRS.Size = new System.Drawing.Size(100, 20);
            this.txtbxSunRS.TabIndex = 31;
            this.txtbxSunRS.DoubleClick += new System.EventHandler(this.txtbxSunRS_DoubleClick);
            // 
            // txtbxWindSD
            // 
            this.txtbxWindSD.Location = new System.Drawing.Point(135, 173);
            this.txtbxWindSD.Name = "txtbxWindSD";
            this.txtbxWindSD.Size = new System.Drawing.Size(100, 20);
            this.txtbxWindSD.TabIndex = 26;
            this.txtbxWindSD.DoubleClick += new System.EventHandler(this.txtbxWindSD_DoubleClick);
            // 
            // txtbxPressure
            // 
            this.txtbxPressure.Location = new System.Drawing.Point(135, 147);
            this.txtbxPressure.Name = "txtbxPressure";
            this.txtbxPressure.Size = new System.Drawing.Size(100, 20);
            this.txtbxPressure.TabIndex = 25;
            this.txtbxPressure.DoubleClick += new System.EventHandler(this.txtbxPressure_DoubleClick);
            // 
            // txtbxCloudCover
            // 
            this.txtbxCloudCover.Location = new System.Drawing.Point(135, 121);
            this.txtbxCloudCover.Name = "txtbxCloudCover";
            this.txtbxCloudCover.Size = new System.Drawing.Size(100, 20);
            this.txtbxCloudCover.TabIndex = 24;
            this.txtbxCloudCover.DoubleClick += new System.EventHandler(this.txtbxCloudCover_DoubleClick);
            // 
            // txtbxRecLow
            // 
            this.txtbxRecLow.Location = new System.Drawing.Point(135, 95);
            this.txtbxRecLow.Name = "txtbxRecLow";
            this.txtbxRecLow.Size = new System.Drawing.Size(100, 20);
            this.txtbxRecLow.TabIndex = 23;
            this.txtbxRecLow.DoubleClick += new System.EventHandler(this.txtbxRecLow_DoubleClick);
            // 
            // txtbxHigh
            // 
            this.txtbxHigh.Location = new System.Drawing.Point(135, 17);
            this.txtbxHigh.Name = "txtbxHigh";
            this.txtbxHigh.Size = new System.Drawing.Size(100, 20);
            this.txtbxHigh.TabIndex = 3;
            this.txtbxHigh.DoubleClick += new System.EventHandler(this.txtbxHigh_DoubleClick);
            // 
            // txtbxRecHigh
            // 
            this.txtbxRecHigh.Location = new System.Drawing.Point(135, 69);
            this.txtbxRecHigh.Name = "txtbxRecHigh";
            this.txtbxRecHigh.Size = new System.Drawing.Size(100, 20);
            this.txtbxRecHigh.TabIndex = 22;
            this.txtbxRecHigh.DoubleClick += new System.EventHandler(this.txtbxRecHigh_DoubleClick);
            // 
            // txtbxLow
            // 
            this.txtbxLow.Location = new System.Drawing.Point(135, 43);
            this.txtbxLow.Name = "txtbxLow";
            this.txtbxLow.Size = new System.Drawing.Size(100, 20);
            this.txtbxLow.TabIndex = 21;
            this.txtbxLow.DoubleClick += new System.EventHandler(this.txtbxLow_DoubleClick);
            // 
            // btnBranson
            // 
            this.btnBranson.Location = new System.Drawing.Point(500, 129);
            this.btnBranson.Name = "btnBranson";
            this.btnBranson.Size = new System.Drawing.Size(202, 23);
            this.btnBranson.TabIndex = 21;
            this.btnBranson.Text = "Branson, MO";
            this.btnBranson.UseVisualStyleBackColor = true;
            this.btnBranson.Click += new System.EventHandler(this.btnBranson_Click);
            // 
            // btnNaples
            // 
            this.btnNaples.Location = new System.Drawing.Point(500, 158);
            this.btnNaples.Name = "btnNaples";
            this.btnNaples.Size = new System.Drawing.Size(202, 23);
            this.btnNaples.TabIndex = 22;
            this.btnNaples.Text = "Naples, FL";
            this.btnNaples.UseVisualStyleBackColor = true;
            this.btnNaples.Click += new System.EventHandler(this.btnNaples_Click);
            // 
            // radPresets
            // 
            this.radPresets.AutoSize = true;
            this.radPresets.Checked = true;
            this.radPresets.Location = new System.Drawing.Point(609, 216);
            this.radPresets.Name = "radPresets";
            this.radPresets.Size = new System.Drawing.Size(82, 17);
            this.radPresets.TabIndex = 23;
            this.radPresets.TabStop = true;
            this.radPresets.Text = "Use Presets";
            this.radPresets.UseVisualStyleBackColor = true;
            this.radPresets.CheckedChanged += new System.EventHandler(this.radPresets_CheckedChanged);
            // 
            // radCustomURL
            // 
            this.radCustomURL.AutoSize = true;
            this.radCustomURL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radCustomURL.Location = new System.Drawing.Point(518, 216);
            this.radCustomURL.Name = "radCustomURL";
            this.radCustomURL.Size = new System.Drawing.Size(85, 17);
            this.radCustomURL.TabIndex = 24;
            this.radCustomURL.Text = "Custom URL";
            this.radCustomURL.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(246, 251);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 13);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Must be a Weather Underground Website!";
            // 
            // txtbxCustomURL
            // 
            this.txtbxCustomURL.Location = new System.Drawing.Point(12, 228);
            this.txtbxCustomURL.Name = "txtbxCustomURL";
            this.txtbxCustomURL.Size = new System.Drawing.Size(442, 20);
            this.txtbxCustomURL.TabIndex = 26;
            // 
            // btnVisitWeb
            // 
            this.btnVisitWeb.Location = new System.Drawing.Point(12, 251);
            this.btnVisitWeb.Name = "btnVisitWeb";
            this.btnVisitWeb.Size = new System.Drawing.Size(219, 23);
            this.btnVisitWeb.TabIndex = 27;
            this.btnVisitWeb.Text = "Go";
            this.btnVisitWeb.UseVisualStyleBackColor = true;
            this.btnVisitWeb.Click += new System.EventHandler(this.btnVisitWeb_Click);
            // 
            // radMetrics
            // 
            this.radMetrics.AutoSize = true;
            this.radMetrics.Location = new System.Drawing.Point(109, 19);
            this.radMetrics.Name = "radMetrics";
            this.radMetrics.Size = new System.Drawing.Size(54, 17);
            this.radMetrics.TabIndex = 29;
            this.radMetrics.Text = "Metric";
            this.radMetrics.UseVisualStyleBackColor = true;
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radEnglish.Checked = true;
            this.radEnglish.Location = new System.Drawing.Point(44, 19);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 28;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // gbxUnits
            // 
            this.gbxUnits.Controls.Add(this.radEnglish);
            this.gbxUnits.Controls.Add(this.radMetrics);
            this.gbxUnits.Location = new System.Drawing.Point(500, 12);
            this.gbxUnits.Name = "gbxUnits";
            this.gbxUnits.Size = new System.Drawing.Size(202, 48);
            this.gbxUnits.TabIndex = 30;
            this.gbxUnits.TabStop = false;
            this.gbxUnits.Text = "Units";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 366);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "DEBUG:";
            // 
            // txtbxDEBUG
            // 
            this.txtbxDEBUG.Location = new System.Drawing.Point(63, 335);
            this.txtbxDEBUG.Multiline = true;
            this.txtbxDEBUG.Name = "txtbxDEBUG";
            this.txtbxDEBUG.Size = new System.Drawing.Size(308, 77);
            this.txtbxDEBUG.TabIndex = 32;
            // 
            // numIndexError
            // 
            this.numIndexError.Location = new System.Drawing.Point(500, 86);
            this.numIndexError.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIndexError.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numIndexError.Name = "numIndexError";
            this.numIndexError.Size = new System.Drawing.Size(35, 20);
            this.numIndexError.TabIndex = 33;
            // 
            // btnHutch
            // 
            this.btnHutch.Location = new System.Drawing.Point(500, 187);
            this.btnHutch.Name = "btnHutch";
            this.btnHutch.Size = new System.Drawing.Size(202, 23);
            this.btnHutch.TabIndex = 34;
            this.btnHutch.Text = "Hutchinson, MN";
            this.btnHutch.UseVisualStyleBackColor = true;
            this.btnHutch.Click += new System.EventHandler(this.btnHutch_Click);
            // 
            // btnNextDayFore
            // 
            this.btnNextDayFore.Location = new System.Drawing.Point(12, 418);
            this.btnNextDayFore.Name = "btnNextDayFore";
            this.btnNextDayFore.Size = new System.Drawing.Size(449, 21);
            this.btnNextDayFore.TabIndex = 34;
            this.btnNextDayFore.Text = "Copy Next Day\'s Forecast";
            this.btnNextDayFore.UseVisualStyleBackColor = true;
            // 
            // WeatherWebScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 285);
            this.Controls.Add(this.btnNextDayFore);
            this.Controls.Add(this.btnHutch);
            this.Controls.Add(this.numIndexError);
            this.Controls.Add(this.txtbxDEBUG);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gbxUnits);
            this.Controls.Add(this.btnVisitWeb);
            this.Controls.Add(this.txtbxCustomURL);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.radCustomURL);
            this.Controls.Add(this.radPresets);
            this.Controls.Add(this.btnNaples);
            this.Controls.Add(this.btnBranson);
            this.Controls.Add(this.gbxToday);
            this.Controls.Add(this.btnScrape);
            this.Name = "WeatherWebScraper";
            this.Text = "WWS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeatherWebScraper_FormClosing);
            this.Load += new System.EventHandler(this.WeatherWebScraper_Load);
            this.gbxToday.ResumeLayout(false);
            this.gbxToday.PerformLayout();
            this.gbxUnits.ResumeLayout(false);
            this.gbxUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbxToday;
        private System.Windows.Forms.TextBox txtbxHigh;
        private System.Windows.Forms.TextBox txtbxRecHigh;
        private System.Windows.Forms.TextBox txtbxLow;
        private System.Windows.Forms.TextBox txtbxRecLow;
        private System.Windows.Forms.TextBox txtbxCloudCover;
        private System.Windows.Forms.TextBox txtbxWindSD;
        private System.Windows.Forms.TextBox txtbxPressure;
        private System.Windows.Forms.TextBox txtbxMoonPhase;
        private System.Windows.Forms.TextBox txtbxTofD;
        private System.Windows.Forms.TextBox txtbxWCHI;
        private System.Windows.Forms.TextBox txtbxMoonRS;
        private System.Windows.Forms.TextBox txtbxCurrentTemp;
        private System.Windows.Forms.TextBox txtbxDew;
        private System.Windows.Forms.TextBox txtbxSunRS;
        private System.Windows.Forms.Button btnBranson;
        private System.Windows.Forms.Button btnNaples;
        private System.Windows.Forms.RadioButton radPresets;
        private System.Windows.Forms.RadioButton radCustomURL;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtbxCustomURL;
        private System.Windows.Forms.Button btnVisitWeb;
        private System.Windows.Forms.RadioButton radMetrics;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.GroupBox gbxUnits;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbxDEBUG;
        private System.Windows.Forms.NumericUpDown numIndexError;
        private System.Windows.Forms.Button btnHutch;
        private System.Windows.Forms.Button btnNextDayFore;
    }
}

