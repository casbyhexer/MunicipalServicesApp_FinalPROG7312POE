namespace MunicipalServicesApp
{
    partial class LocalEvents_AnnoucementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEvents_AnnoucementsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.lblEvents = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.RecommendationTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MunicipalServicesApp.Properties.Resources.filter2;
            this.pictureBox1.Location = new System.Drawing.Point(46, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(189, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Events And Announcements Form";
            // 
            // eventsListView
            // 
            this.eventsListView.BackColor = System.Drawing.SystemColors.InfoText;
            this.eventsListView.ForeColor = System.Drawing.SystemColors.Info;
            this.eventsListView.HideSelection = false;
            this.eventsListView.Location = new System.Drawing.Point(660, 136);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(121, 97);
            this.eventsListView.TabIndex = 3;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEvents.Location = new System.Drawing.Point(220, 136);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(387, 22);
            this.lblEvents.TabIndex = 4;
            this.lblEvents.Text = "Upcoming Events/Announcements:";
            this.lblEvents.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchTextBox.Location = new System.Drawing.Point(660, 263);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(121, 26);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSearch.Location = new System.Drawing.Point(407, 264);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(201, 22);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search Criteria:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.categoryComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "",
            "Community",
            "Festivity",
            "Community"});
            this.categoryComboBox.Location = new System.Drawing.Point(660, 318);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 28);
            this.categoryComboBox.TabIndex = 7;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCategory.Location = new System.Drawing.Point(404, 324);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(204, 22);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category Filter:";
            this.lblCategory.Click += new System.EventHandler(this.label3_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.datePicker.Location = new System.Drawing.Point(660, 378);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(269, 26);
            this.datePicker.TabIndex = 9;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDate.Location = new System.Drawing.Point(460, 381);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(148, 22);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date Filter:";
            this.lblDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.Location = new System.Drawing.Point(496, 438);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(660, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendations.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRecommendations.Location = new System.Drawing.Point(394, 499);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(214, 22);
            this.lblRecommendations.TabIndex = 15;
            this.lblRecommendations.Text = "Recommendations:";
            this.lblRecommendations.Click += new System.EventHandler(this.label5_Click);
            // 
            // RecommendationTextBox
            // 
            this.RecommendationTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.RecommendationTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.RecommendationTextBox.Location = new System.Drawing.Point(660, 499);
            this.RecommendationTextBox.Name = "RecommendationTextBox";
            this.RecommendationTextBox.Size = new System.Drawing.Size(100, 96);
            this.RecommendationTextBox.TabIndex = 16;
            this.RecommendationTextBox.Text = "";
            this.RecommendationTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LocalEvents_AnnoucementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 707);
            this.Controls.Add(this.RecommendationTextBox);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.eventsListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LocalEvents_AnnoucementsForm";
            this.Text = "LocalEvents_AnnoucementsForm";
            this.Load += new System.EventHandler(this.LocalEvents_AnnoucementsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.RichTextBox RecommendationTextBox;
    }
}