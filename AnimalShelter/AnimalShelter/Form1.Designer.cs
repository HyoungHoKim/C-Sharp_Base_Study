namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCust = new System.Windows.Forms.Button();
            this.CustDetailPanel = new System.Windows.Forms.Panel();
            this.CustIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustDetail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustNewDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustNewAdr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustNewBir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CustNewLN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustNewFN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPatInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CustDetailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustList)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCust
            // 
            this.CreateCust.Location = new System.Drawing.Point(159, 345);
            this.CreateCust.Name = "CreateCust";
            this.CreateCust.Size = new System.Drawing.Size(111, 24);
            this.CreateCust.TabIndex = 0;
            this.CreateCust.Text = "입장자 생성";
            this.CreateCust.UseVisualStyleBackColor = true;
            this.CreateCust.Click += new System.EventHandler(this.CreateCust_Click);
            // 
            // CustDetailPanel
            // 
            this.CustDetailPanel.Controls.Add(this.CusPatInfo);
            this.CustDetailPanel.Controls.Add(this.label12);
            this.CustDetailPanel.Controls.Add(this.CustIsQualified);
            this.CustDetailPanel.Controls.Add(this.label2);
            this.CustDetailPanel.Controls.Add(this.CustDetail);
            this.CustDetailPanel.Controls.Add(this.label6);
            this.CustDetailPanel.Controls.Add(this.CustAddress);
            this.CustDetailPanel.Controls.Add(this.label5);
            this.CustDetailPanel.Controls.Add(this.CustAge);
            this.CustDetailPanel.Controls.Add(this.label4);
            this.CustDetailPanel.Controls.Add(this.CustFullName);
            this.CustDetailPanel.Controls.Add(this.label3);
            this.CustDetailPanel.Location = new System.Drawing.Point(671, 33);
            this.CustDetailPanel.Name = "CustDetailPanel";
            this.CustDetailPanel.Size = new System.Drawing.Size(198, 387);
            this.CustDetailPanel.TabIndex = 1;
            // 
            // CustIsQualified
            // 
            this.CustIsQualified.AutoSize = true;
            this.CustIsQualified.Location = new System.Drawing.Point(121, 74);
            this.CustIsQualified.Name = "CustIsQualified";
            this.CustIsQualified.Size = new System.Drawing.Size(45, 15);
            this.CustIsQualified.TabIndex = 11;
            this.CustIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "입양 가능? : ";
            // 
            // CustDetail
            // 
            this.CustDetail.AutoSize = true;
            this.CustDetail.Location = new System.Drawing.Point(121, 124);
            this.CustDetail.Name = "CustDetail";
            this.CustDetail.Size = new System.Drawing.Size(45, 15);
            this.CustDetail.TabIndex = 9;
            this.CustDetail.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "설명 :  ";
            // 
            // CustAddress
            // 
            this.CustAddress.AutoSize = true;
            this.CustAddress.Location = new System.Drawing.Point(121, 99);
            this.CustAddress.Name = "CustAddress";
            this.CustAddress.Size = new System.Drawing.Size(45, 15);
            this.CustAddress.TabIndex = 7;
            this.CustAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소 :  ";
            // 
            // CustAge
            // 
            this.CustAge.AutoSize = true;
            this.CustAge.Location = new System.Drawing.Point(121, 50);
            this.CustAge.Name = "CustAge";
            this.CustAge.Size = new System.Drawing.Size(45, 15);
            this.CustAge.TabIndex = 5;
            this.CustAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이 : ";
            // 
            // CustFullName
            // 
            this.CustFullName.AutoSize = true;
            this.CustFullName.Location = new System.Drawing.Point(121, 21);
            this.CustFullName.Name = "CustFullName";
            this.CustFullName.Size = new System.Drawing.Size(45, 15);
            this.CustFullName.TabIndex = 3;
            this.CustFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름 : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CustNewDesc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CreateCust);
            this.panel1.Controls.Add(this.CustNewAdr);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CustNewBir);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CustNewLN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CustNewFN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(395, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 384);
            this.panel1.TabIndex = 2;
            // 
            // CustNewDesc
            // 
            this.CustNewDesc.Location = new System.Drawing.Point(69, 144);
            this.CustNewDesc.Multiline = true;
            this.CustNewDesc.Name = "CustNewDesc";
            this.CustNewDesc.Size = new System.Drawing.Size(201, 195);
            this.CustNewDesc.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "설명 : ";
            // 
            // CustNewAdr
            // 
            this.CustNewAdr.Location = new System.Drawing.Point(69, 113);
            this.CustNewAdr.Name = "CustNewAdr";
            this.CustNewAdr.Size = new System.Drawing.Size(201, 25);
            this.CustNewAdr.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "주소 : ";
            // 
            // CustNewBir
            // 
            this.CustNewBir.Location = new System.Drawing.Point(69, 82);
            this.CustNewBir.Name = "CustNewBir";
            this.CustNewBir.Size = new System.Drawing.Size(201, 25);
            this.CustNewBir.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "생일 : ";
            // 
            // CustNewLN
            // 
            this.CustNewLN.Location = new System.Drawing.Point(69, 51);
            this.CustNewLN.Name = "CustNewLN";
            this.CustNewLN.Size = new System.Drawing.Size(201, 25);
            this.CustNewLN.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "이름 : ";
            // 
            // CustNewFN
            // 
            this.CustNewFN.Location = new System.Drawing.Point(69, 20);
            this.CustNewFN.Name = "CustNewFN";
            this.CustNewFN.Size = new System.Drawing.Size(201, 25);
            this.CustNewFN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "성 : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CustList);
            this.panel2.Location = new System.Drawing.Point(13, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 384);
            this.panel2.TabIndex = 3;
            // 
            // CustList
            // 
            this.CustList.AllowUserToAddRows = false;
            this.CustList.AllowUserToDeleteRows = false;
            this.CustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CustList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustList.Location = new System.Drawing.Point(0, 0);
            this.CustList.MultiSelect = false;
            this.CustList.Name = "CustList";
            this.CustList.RowTemplate.Height = 27;
            this.CustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustList.Size = new System.Drawing.Size(361, 384);
            this.CustList.TabIndex = 0;
            this.CustList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입양가능";
            this.Column3.Name = "Column3";
            // 
            // CusPatInfo
            // 
            this.CusPatInfo.AutoSize = true;
            this.CusPatInfo.Location = new System.Drawing.Point(121, 156);
            this.CusPatInfo.Name = "CusPatInfo";
            this.CusPatInfo.Size = new System.Drawing.Size(45, 15);
            this.CusPatInfo.TabIndex = 13;
            this.CusPatInfo.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "펫 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustDetailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CustDetailPanel.ResumeLayout(false);
            this.CustDetailPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCust;
        private System.Windows.Forms.Panel CustDetailPanel;
        private System.Windows.Forms.Label CustAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CustAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CustFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CustDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CustIsQualified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CustNewDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CustNewAdr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustNewBir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustNewLN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustNewFN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView CustList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label CusPatInfo;
        private System.Windows.Forms.Label label12;
    }
}

