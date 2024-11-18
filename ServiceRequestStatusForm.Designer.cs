namespace MunicipalServicesApp
{
    partial class ServiceRequestStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestStatusForm));
            this.lblServiceRequestStatus = new System.Windows.Forms.Label();
            this.lblServiceRequests = new System.Windows.Forms.Label();
            this.listViewServiceRequests = new System.Windows.Forms.ListView();
            this.txtSearchAndTrack = new System.Windows.Forms.TextBox();
            this.btnSearchAndTrack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddRequestToHeap = new System.Windows.Forms.Button();
            this.btnExtractMax = new System.Windows.Forms.Button();
            this.btnAddVertex = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.btnDisplayGraph = new System.Windows.Forms.Button();
            this.btnCloseGraph = new System.Windows.Forms.Button();
            this.txtRequestId = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblEnterStatus = new System.Windows.Forms.Label();
            this.lblEnterPriority = new System.Windows.Forms.Label();
            this.btnInsertRequest = new System.Windows.Forms.Button();
            this.btnSearchRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceRequestStatus
            // 
            this.lblServiceRequestStatus.AutoSize = true;
            this.lblServiceRequestStatus.Font = new System.Drawing.Font("Algerian", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceRequestStatus.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblServiceRequestStatus.Location = new System.Drawing.Point(274, 74);
            this.lblServiceRequestStatus.Name = "lblServiceRequestStatus";
            this.lblServiceRequestStatus.Size = new System.Drawing.Size(649, 45);
            this.lblServiceRequestStatus.TabIndex = 3;
            this.lblServiceRequestStatus.Text = "Service Request Status Form";
            // 
            // lblServiceRequests
            // 
            this.lblServiceRequests.AutoSize = true;
            this.lblServiceRequests.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceRequests.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblServiceRequests.Location = new System.Drawing.Point(209, 405);
            this.lblServiceRequests.Name = "lblServiceRequests";
            this.lblServiceRequests.Size = new System.Drawing.Size(261, 22);
            this.lblServiceRequests.TabIndex = 5;
            this.lblServiceRequests.Text = "Service Requests List:";
            // 
            // listViewServiceRequests
            // 
            this.listViewServiceRequests.BackColor = System.Drawing.SystemColors.InfoText;
            this.listViewServiceRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewServiceRequests.ForeColor = System.Drawing.SystemColors.Info;
            this.listViewServiceRequests.HideSelection = false;
            this.listViewServiceRequests.Location = new System.Drawing.Point(529, 405);
            this.listViewServiceRequests.Name = "listViewServiceRequests";
            this.listViewServiceRequests.Size = new System.Drawing.Size(515, 116);
            this.listViewServiceRequests.TabIndex = 6;
            this.listViewServiceRequests.UseCompatibleStateImageBehavior = false;
            this.listViewServiceRequests.View = System.Windows.Forms.View.Details;
            this.listViewServiceRequests.SelectedIndexChanged += new System.EventHandler(this.listViewServiceRequests_SelectedIndexChanged);
            // 
            // txtSearchAndTrack
            // 
            this.txtSearchAndTrack.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtSearchAndTrack.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSearchAndTrack.Location = new System.Drawing.Point(529, 154);
            this.txtSearchAndTrack.Name = "txtSearchAndTrack";
            this.txtSearchAndTrack.Size = new System.Drawing.Size(515, 26);
            this.txtSearchAndTrack.TabIndex = 7;
            this.txtSearchAndTrack.TextChanged += new System.EventHandler(this.txtSearchAndTrack_TextChanged);
            // 
            // btnSearchAndTrack
            // 
            this.btnSearchAndTrack.BackColor = System.Drawing.Color.Black;
            this.btnSearchAndTrack.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAndTrack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSearchAndTrack.Location = new System.Drawing.Point(251, 155);
            this.btnSearchAndTrack.Name = "btnSearchAndTrack";
            this.btnSearchAndTrack.Size = new System.Drawing.Size(218, 26);
            this.btnSearchAndTrack.TabIndex = 8;
            this.btnSearchAndTrack.Text = "Search And Track";
            this.btnSearchAndTrack.UseVisualStyleBackColor = false;
            this.btnSearchAndTrack.Click += new System.EventHandler(this.btnSearchAndTrack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBack.Location = new System.Drawing.Point(371, 670);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 29);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "go back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackColor = System.Drawing.Color.Black;
            this.btnAddRequest.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequest.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddRequest.Location = new System.Drawing.Point(668, 186);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(227, 29);
            this.btnAddRequest.TabIndex = 13;
            this.btnAddRequest.Text = "ADD BST Request";
            this.btnAddRequest.UseVisualStyleBackColor = false;
            this.btnAddRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Request ID:";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status:";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Priority:";
            this.columnHeader3.Width = 100;
            // 
            // btnAddRequestToHeap
            // 
            this.btnAddRequestToHeap.BackColor = System.Drawing.Color.Black;
            this.btnAddRequestToHeap.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequestToHeap.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddRequestToHeap.Location = new System.Drawing.Point(529, 348);
            this.btnAddRequestToHeap.Name = "btnAddRequestToHeap";
            this.btnAddRequestToHeap.Size = new System.Drawing.Size(229, 29);
            this.btnAddRequestToHeap.TabIndex = 14;
            this.btnAddRequestToHeap.Text = "ADD Heap Request";
            this.btnAddRequestToHeap.UseVisualStyleBackColor = false;
            this.btnAddRequestToHeap.Click += new System.EventHandler(this.btnAddRequestToHeap_Click);
            // 
            // btnExtractMax
            // 
            this.btnExtractMax.BackColor = System.Drawing.Color.Black;
            this.btnExtractMax.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractMax.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExtractMax.Location = new System.Drawing.Point(799, 348);
            this.btnExtractMax.Name = "btnExtractMax";
            this.btnExtractMax.Size = new System.Drawing.Size(245, 29);
            this.btnExtractMax.TabIndex = 15;
            this.btnExtractMax.Text = "Extract Heap Max";
            this.btnExtractMax.UseVisualStyleBackColor = false;
            this.btnExtractMax.Click += new System.EventHandler(this.btnExtractMax_Click);
            // 
            // btnAddVertex
            // 
            this.btnAddVertex.BackColor = System.Drawing.Color.Black;
            this.btnAddVertex.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVertex.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddVertex.Location = new System.Drawing.Point(529, 558);
            this.btnAddVertex.Name = "btnAddVertex";
            this.btnAddVertex.Size = new System.Drawing.Size(229, 29);
            this.btnAddVertex.TabIndex = 16;
            this.btnAddVertex.Text = "ADD Vertex Request";
            this.btnAddVertex.UseVisualStyleBackColor = false;
            this.btnAddVertex.Click += new System.EventHandler(this.btnAddVertex_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.BackColor = System.Drawing.Color.Black;
            this.btnAddEdge.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEdge.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAddEdge.Location = new System.Drawing.Point(799, 558);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(245, 29);
            this.btnAddEdge.TabIndex = 17;
            this.btnAddEdge.Text = "Add Edge Dependency";
            this.btnAddEdge.UseVisualStyleBackColor = false;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // btnDisplayGraph
            // 
            this.btnDisplayGraph.BackColor = System.Drawing.Color.Black;
            this.btnDisplayGraph.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayGraph.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDisplayGraph.Location = new System.Drawing.Point(268, 600);
            this.btnDisplayGraph.Name = "btnDisplayGraph";
            this.btnDisplayGraph.Size = new System.Drawing.Size(201, 29);
            this.btnDisplayGraph.TabIndex = 19;
            this.btnDisplayGraph.Text = "Display Graph";
            this.btnDisplayGraph.UseVisualStyleBackColor = false;
            this.btnDisplayGraph.Click += new System.EventHandler(this.btnDisplayGraph_Click);
            // 
            // btnCloseGraph
            // 
            this.btnCloseGraph.BackColor = System.Drawing.Color.Black;
            this.btnCloseGraph.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseGraph.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnCloseGraph.Location = new System.Drawing.Point(268, 635);
            this.btnCloseGraph.Name = "btnCloseGraph";
            this.btnCloseGraph.Size = new System.Drawing.Size(201, 29);
            this.btnCloseGraph.TabIndex = 20;
            this.btnCloseGraph.Text = "Close Graph";
            this.btnCloseGraph.UseVisualStyleBackColor = false;
            this.btnCloseGraph.Click += new System.EventHandler(this.btnCloseGraph_Click);
            // 
            // txtRequestId
            // 
            this.txtRequestId.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtRequestId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRequestId.Location = new System.Drawing.Point(529, 227);
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.Size = new System.Drawing.Size(190, 26);
            this.txtRequestId.TabIndex = 21;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.txtStatus.Location = new System.Drawing.Point(529, 262);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(190, 26);
            this.txtStatus.TabIndex = 22;
            // 
            // txtPriority
            // 
            this.txtPriority.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtPriority.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPriority.Location = new System.Drawing.Point(529, 300);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(190, 26);
            this.txtPriority.TabIndex = 23;
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRequestID.Location = new System.Drawing.Point(264, 228);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(206, 22);
            this.lblRequestID.TabIndex = 24;
            this.lblRequestID.Text = "Enter Request ID:";
            // 
            // lblEnterStatus
            // 
            this.lblEnterStatus.AutoSize = true;
            this.lblEnterStatus.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterStatus.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEnterStatus.Location = new System.Drawing.Point(302, 262);
            this.lblEnterStatus.Name = "lblEnterStatus";
            this.lblEnterStatus.Size = new System.Drawing.Size(167, 22);
            this.lblEnterStatus.TabIndex = 25;
            this.lblEnterStatus.Text = "Enter Status:";
            // 
            // lblEnterPriority
            // 
            this.lblEnterPriority.AutoSize = true;
            this.lblEnterPriority.Font = new System.Drawing.Font("Algerian", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPriority.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblEnterPriority.Location = new System.Drawing.Point(286, 297);
            this.lblEnterPriority.Name = "lblEnterPriority";
            this.lblEnterPriority.Size = new System.Drawing.Size(183, 22);
            this.lblEnterPriority.TabIndex = 26;
            this.lblEnterPriority.Text = "Enter Priority:";
            // 
            // btnInsertRequest
            // 
            this.btnInsertRequest.BackColor = System.Drawing.Color.Black;
            this.btnInsertRequest.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertRequest.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnInsertRequest.Location = new System.Drawing.Point(817, 227);
            this.btnInsertRequest.Name = "btnInsertRequest";
            this.btnInsertRequest.Size = new System.Drawing.Size(227, 29);
            this.btnInsertRequest.TabIndex = 27;
            this.btnInsertRequest.Text = " insert AVL Request";
            this.btnInsertRequest.UseVisualStyleBackColor = false;
            this.btnInsertRequest.Click += new System.EventHandler(this.btnInsertRequest_Click);
            // 
            // btnSearchRequest
            // 
            this.btnSearchRequest.BackColor = System.Drawing.Color.Black;
            this.btnSearchRequest.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRequest.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSearchRequest.Location = new System.Drawing.Point(817, 262);
            this.btnSearchRequest.Name = "btnSearchRequest";
            this.btnSearchRequest.Size = new System.Drawing.Size(227, 29);
            this.btnSearchRequest.TabIndex = 28;
            this.btnSearchRequest.Text = "Search AVL Request";
            this.btnSearchRequest.UseVisualStyleBackColor = false;
            this.btnSearchRequest.Click += new System.EventHandler(this.btnSearchRequest_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.BackColor = System.Drawing.Color.Black;
            this.btnDeleteRequest.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRequest.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnDeleteRequest.Location = new System.Drawing.Point(817, 297);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(227, 29);
            this.btnDeleteRequest.TabIndex = 29;
            this.btnDeleteRequest.Text = "Delete AVL Request";
            this.btnDeleteRequest.UseVisualStyleBackColor = false;
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 887);
            this.Controls.Add(this.btnDeleteRequest);
            this.Controls.Add(this.btnSearchRequest);
            this.Controls.Add(this.btnInsertRequest);
            this.Controls.Add(this.lblEnterPriority);
            this.Controls.Add(this.lblEnterStatus);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtRequestId);
            this.Controls.Add(this.btnCloseGraph);
            this.Controls.Add(this.btnDisplayGraph);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnAddVertex);
            this.Controls.Add(this.btnExtractMax);
            this.Controls.Add(this.btnAddRequestToHeap);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchAndTrack);
            this.Controls.Add(this.txtSearchAndTrack);
            this.Controls.Add(this.listViewServiceRequests);
            this.Controls.Add(this.lblServiceRequests);
            this.Controls.Add(this.lblServiceRequestStatus);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatusForm";
            this.Load += new System.EventHandler(this.ServiceRequestStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblServiceRequestStatus;
        private System.Windows.Forms.Label lblServiceRequests;
        private System.Windows.Forms.ListView listViewServiceRequests;
        private System.Windows.Forms.TextBox txtSearchAndTrack;
        private System.Windows.Forms.Button btnSearchAndTrack;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddRequestToHeap;
        private System.Windows.Forms.Button btnExtractMax;
        private System.Windows.Forms.Button btnAddVertex;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Button btnDisplayGraph;
        private System.Windows.Forms.Button btnCloseGraph;
        private System.Windows.Forms.TextBox txtRequestId;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblEnterStatus;
        private System.Windows.Forms.Label lblEnterPriority;
        private System.Windows.Forms.Button btnInsertRequest;
        private System.Windows.Forms.Button btnSearchRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
    }
}