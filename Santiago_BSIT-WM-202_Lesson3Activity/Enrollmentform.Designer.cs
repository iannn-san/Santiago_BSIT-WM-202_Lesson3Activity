namespace Santiago_BSIT_WM_202_Lesson3Activity
{
    partial class EnrollmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblDateEnrolled = new System.Windows.Forms.Label();
            this.lblScholar = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.cboYearLevel = new System.Windows.Forms.ComboBox();
            this.cboScholar = new System.Windows.Forms.ComboBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.dtpEnrolled = new System.Windows.Forms.DateTimePicker();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.lblTotalCredUnits = new System.Windows.Forms.Label();
            this.txtTotalCredUnits = new System.Windows.Forms.TextBox();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.grpFees = new System.Windows.Forms.GroupBox();
            this.lblTotalTuitionFee = new System.Windows.Forms.Label();
            this.txtTotalTuitionFee = new System.Windows.Forms.TextBox();
            this.lblMiscFee = new System.Windows.Forms.Label();
            this.txtMiscFee = new System.Windows.Forms.TextBox();
            this.lblOtherFees = new System.Windows.Forms.Label();
            this.lblComLabFee = new System.Windows.Forms.Label();
            this.txtComLabFee = new System.Windows.Forms.TextBox();
            this.lblSapFee = new System.Windows.Forms.Label();
            this.txtSapFee = new System.Windows.Forms.TextBox();
            this.lblCiscoFee = new System.Windows.Forms.Label();
            this.txtCiscoFee = new System.Windows.Forms.TextBox();
            this.lblExamBookletFee = new System.Windows.Forms.Label();
            this.txtExamBookletFee = new System.Windows.Forms.TextBox();
            this.lblTotalOtherFee = new System.Windows.Forms.Label();
            this.txtTotalOtherFee = new System.Windows.Forms.TextBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalTuitionAndFees = new System.Windows.Forms.Label();
            this.txtTotalTuitionAndFees = new System.Windows.Forms.TextBox();
            this.lblModeOfPayment = new System.Windows.Forms.Label();
            this.txtModeOfPayment = new System.Windows.Forms.TextBox();
            this.lblInstallmentCharge = new System.Windows.Forms.Label();
            this.lblDownpayment = new System.Windows.Forms.Label();
            this.txtDownpayment = new System.Windows.Forms.TextBox();
            this.lbl1stInstallment = new System.Windows.Forms.Label();
            this.txt1stInstallment = new System.Windows.Forms.TextBox();
            this.lbl2ndInstallment = new System.Windows.Forms.Label();
            this.txt2ndInstallment = new System.Windows.Forms.TextBox();
            this.lbl3rdInstallment = new System.Windows.Forms.Label();
            this.txt3rdInstallment = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnComputeFees = new System.Windows.Forms.Button();
            this.btnClearStudentInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearSchedule = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.grpStudentInfo.SuspendLayout();
            this.grpSchedule.SuspendLayout();
            this.grpFees.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
           
            this.lblStudentName.Location = new System.Drawing.Point(10, 28); 
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(90, 20);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
    
            this.lblStudentNo.Location = new System.Drawing.Point(540, 28); 
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(80, 20);
            this.lblStudentNo.TabIndex = 2;
            this.lblStudentNo.Text = "Student No.:";
             
            this.lblProgram.Location = new System.Drawing.Point(10, 58); 
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(90, 20);
            this.lblProgram.TabIndex = 4;
            this.lblProgram.Text = "Program:";
           
            this.lblYearLevel.Location = new System.Drawing.Point(540, 58); 
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(80, 20);
            this.lblYearLevel.TabIndex = 6;
            this.lblYearLevel.Text = "Year Level:";
            
            this.lblDateEnrolled.Location = new System.Drawing.Point(10, 88); 
            this.lblDateEnrolled.Name = "lblDateEnrolled";
            this.lblDateEnrolled.Size = new System.Drawing.Size(90, 20);
            this.lblDateEnrolled.TabIndex = 8;
            this.lblDateEnrolled.Text = "Date Enrolled:";
             
            this.lblScholar.Location = new System.Drawing.Point(540, 88);
            this.lblScholar.Name = "lblScholar";
            this.lblScholar.Size = new System.Drawing.Size(80, 20);
            this.lblScholar.TabIndex = 10;
            this.lblScholar.Text = "Scholar:";
            
            this.lblMode.Location = new System.Drawing.Point(785, 88);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(45, 20);
            this.lblMode.TabIndex = 12;
            this.lblMode.Text = "Mode:";
            
            this.txtStudentName.Location = new System.Drawing.Point(105, 25);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(220, 29);
            this.txtStudentName.TabIndex = 1;
            
            this.txtStudentNo.Location = new System.Drawing.Point(625, 25);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(220, 29);
            this.txtStudentNo.TabIndex = 3;
            
            this.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgram.Location = new System.Drawing.Point(105, 55);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(220, 32);
            this.cboProgram.TabIndex = 5;
             
            this.cboYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearLevel.Location = new System.Drawing.Point(625, 55);
            this.cboYearLevel.Name = "cboYearLevel";
            this.cboYearLevel.Size = new System.Drawing.Size(220, 32);
            this.cboYearLevel.TabIndex = 7;
            
            this.cboScholar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScholar.Location = new System.Drawing.Point(625, 85);
            this.cboScholar.Name = "cboScholar";
            this.cboScholar.Size = new System.Drawing.Size(150, 32);
            this.cboScholar.TabIndex = 11;
            
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.Location = new System.Drawing.Point(830, 85);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(120, 32);
            this.cboMode.TabIndex = 13;
             
            this.dtpEnrolled.Location = new System.Drawing.Point(105, 85);
            this.dtpEnrolled.Name = "dtpEnrolled";
            this.dtpEnrolled.Size = new System.Drawing.Size(220, 29);
            this.dtpEnrolled.TabIndex = 9;
            
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvSchedule.Location = new System.Drawing.Point(10, 20);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 72;
            this.dgvSchedule.Size = new System.Drawing.Size(995, 200);
            this.dgvSchedule.TabIndex = 0;
             
            this.lblTotalCredUnits.Location = new System.Drawing.Point(10, 232);
            this.lblTotalCredUnits.Name = "lblTotalCredUnits";
            this.lblTotalCredUnits.Size = new System.Drawing.Size(115, 20);
            this.lblTotalCredUnits.TabIndex = 1;
            this.lblTotalCredUnits.Text = "Total Cred. Units:";
             
            this.txtTotalCredUnits.Location = new System.Drawing.Point(130, 230);
            this.txtTotalCredUnits.Name = "txtTotalCredUnits";
            this.txtTotalCredUnits.ReadOnly = true;
            this.txtTotalCredUnits.Size = new System.Drawing.Size(80, 29);
            this.txtTotalCredUnits.TabIndex = 2;
             
            this.grpStudentInfo.Controls.Add(this.lblStudentName);
            this.grpStudentInfo.Controls.Add(this.txtStudentName);
            this.grpStudentInfo.Controls.Add(this.lblStudentNo);
            this.grpStudentInfo.Controls.Add(this.txtStudentNo);
            this.grpStudentInfo.Controls.Add(this.lblProgram);
            this.grpStudentInfo.Controls.Add(this.cboProgram);
            this.grpStudentInfo.Controls.Add(this.lblYearLevel);
            this.grpStudentInfo.Controls.Add(this.cboYearLevel);
            this.grpStudentInfo.Controls.Add(this.lblDateEnrolled);
            this.grpStudentInfo.Controls.Add(this.dtpEnrolled);
            this.grpStudentInfo.Controls.Add(this.lblScholar);
            this.grpStudentInfo.Controls.Add(this.cboScholar);
            this.grpStudentInfo.Controls.Add(this.lblMode);
            this.grpStudentInfo.Controls.Add(this.cboMode);
            this.grpStudentInfo.Location = new System.Drawing.Point(10, 34);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(1020, 120);
            this.grpStudentInfo.TabIndex = 0;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Student Information";
             
            this.grpSchedule.Controls.Add(this.dgvSchedule);
            this.grpSchedule.Controls.Add(this.lblTotalCredUnits);
            this.grpSchedule.Controls.Add(this.txtTotalCredUnits);
            this.grpSchedule.Location = new System.Drawing.Point(10, 185);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(1020, 270);
            this.grpSchedule.TabIndex = 1;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Schedule of Course(s)";
             
            this.grpFees.Controls.Add(this.lblTotalTuitionFee);
            this.grpFees.Controls.Add(this.txtTotalTuitionFee);
            this.grpFees.Controls.Add(this.lblMiscFee);
            this.grpFees.Controls.Add(this.txtMiscFee);
            this.grpFees.Controls.Add(this.lblOtherFees);
            this.grpFees.Controls.Add(this.lblComLabFee);
            this.grpFees.Controls.Add(this.txtComLabFee);
            this.grpFees.Controls.Add(this.lblSapFee);
            this.grpFees.Controls.Add(this.txtSapFee);
            this.grpFees.Controls.Add(this.lblCiscoFee);
            this.grpFees.Controls.Add(this.txtCiscoFee);
            this.grpFees.Controls.Add(this.lblExamBookletFee);
            this.grpFees.Controls.Add(this.txtExamBookletFee);
            this.grpFees.Controls.Add(this.lblTotalOtherFee);
            this.grpFees.Controls.Add(this.txtTotalOtherFee);
            this.grpFees.Location = new System.Drawing.Point(10, 490);
            this.grpFees.Name = "grpFees";
            this.grpFees.Size = new System.Drawing.Size(420, 245);
            this.grpFees.TabIndex = 2;
            this.grpFees.TabStop = false;
            this.grpFees.Text = "Fees";
             
            this.lblTotalTuitionFee.Location = new System.Drawing.Point(10, 28);
            this.lblTotalTuitionFee.Name = "lblTotalTuitionFee";
            this.lblTotalTuitionFee.Size = new System.Drawing.Size(120, 20);
            this.lblTotalTuitionFee.TabIndex = 0;
            this.lblTotalTuitionFee.Text = "Total Tuition Fee:";
             
            this.txtTotalTuitionFee.Location = new System.Drawing.Point(150, 25);
            this.txtTotalTuitionFee.Name = "txtTotalTuitionFee";
            this.txtTotalTuitionFee.ReadOnly = true;
            this.txtTotalTuitionFee.Size = new System.Drawing.Size(150, 29);
            this.txtTotalTuitionFee.TabIndex = 1;
             
            this.lblMiscFee.Location = new System.Drawing.Point(10, 58);
            this.lblMiscFee.Name = "lblMiscFee";
            this.lblMiscFee.Size = new System.Drawing.Size(120, 20);
            this.lblMiscFee.TabIndex = 2;
            this.lblMiscFee.Text = "Miscellaneous Fees:";
             
            this.txtMiscFee.Location = new System.Drawing.Point(150, 55);
            this.txtMiscFee.Name = "txtMiscFee";
            this.txtMiscFee.ReadOnly = true;
            this.txtMiscFee.Size = new System.Drawing.Size(150, 29);
            this.txtMiscFee.TabIndex = 3;
             
            this.lblOtherFees.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblOtherFees.Location = new System.Drawing.Point(10, 88);
            this.lblOtherFees.Name = "lblOtherFees";
            this.lblOtherFees.Size = new System.Drawing.Size(130, 20);
            this.lblOtherFees.TabIndex = 4;
            this.lblOtherFees.Text = "Other School Fees:";
             
            this.lblComLabFee.Location = new System.Drawing.Point(10, 113);
            this.lblComLabFee.Name = "lblComLabFee";
            this.lblComLabFee.Size = new System.Drawing.Size(130, 20);
            this.lblComLabFee.TabIndex = 5;
            this.lblComLabFee.Text = "  Com. Lab. Fee:";
            
            this.txtComLabFee.Location = new System.Drawing.Point(150, 110);
            this.txtComLabFee.Name = "txtComLabFee";
            this.txtComLabFee.ReadOnly = true;
            this.txtComLabFee.Size = new System.Drawing.Size(150, 29);
            this.txtComLabFee.TabIndex = 6;
            
            this.lblSapFee.Location = new System.Drawing.Point(10, 141);
            this.lblSapFee.Name = "lblSapFee";
            this.lblSapFee.Size = new System.Drawing.Size(130, 20);
            this.lblSapFee.TabIndex = 7;
            this.lblSapFee.Text = "  SAP Fee:";
             
            this.txtSapFee.Location = new System.Drawing.Point(150, 138);
            this.txtSapFee.Name = "txtSapFee";
            this.txtSapFee.ReadOnly = true;
            this.txtSapFee.Size = new System.Drawing.Size(150, 29);
            this.txtSapFee.TabIndex = 8;
             
            this.lblCiscoFee.Location = new System.Drawing.Point(10, 169);
            this.lblCiscoFee.Name = "lblCiscoFee";
            this.lblCiscoFee.Size = new System.Drawing.Size(130, 20);
            this.lblCiscoFee.TabIndex = 9;
            this.lblCiscoFee.Text = "  CISCO Lab Fee:";
             
            this.txtCiscoFee.Location = new System.Drawing.Point(150, 166);
            this.txtCiscoFee.Name = "txtCiscoFee";
            this.txtCiscoFee.ReadOnly = true;
            this.txtCiscoFee.Size = new System.Drawing.Size(150, 29);
            this.txtCiscoFee.TabIndex = 10;
             
            this.lblExamBookletFee.Location = new System.Drawing.Point(10, 197);
            this.lblExamBookletFee.Name = "lblExamBookletFee";
            this.lblExamBookletFee.Size = new System.Drawing.Size(130, 20);
            this.lblExamBookletFee.TabIndex = 11;
            this.lblExamBookletFee.Text = "  Exam Booklet Fee:";
             
            this.txtExamBookletFee.Location = new System.Drawing.Point(150, 194);
            this.txtExamBookletFee.Name = "txtExamBookletFee";
            this.txtExamBookletFee.ReadOnly = true;
            this.txtExamBookletFee.Size = new System.Drawing.Size(150, 29);
            this.txtExamBookletFee.TabIndex = 12;
            
            this.lblTotalOtherFee.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalOtherFee.Location = new System.Drawing.Point(10, 218);
            this.lblTotalOtherFee.Name = "lblTotalOtherFee";
            this.lblTotalOtherFee.Size = new System.Drawing.Size(130, 20);
            this.lblTotalOtherFee.TabIndex = 13;
            this.lblTotalOtherFee.Text = "Total Oth. Fee:";
             
            this.txtTotalOtherFee.Location = new System.Drawing.Point(150, 215);
            this.txtTotalOtherFee.Name = "txtTotalOtherFee";
            this.txtTotalOtherFee.ReadOnly = true;
            this.txtTotalOtherFee.Size = new System.Drawing.Size(150, 29);
            this.txtTotalOtherFee.TabIndex = 14;
             
            this.grpPayment.Controls.Add(this.lblTotalTuitionAndFees);
            this.grpPayment.Controls.Add(this.txtTotalTuitionAndFees);
            this.grpPayment.Controls.Add(this.lblModeOfPayment);
            this.grpPayment.Controls.Add(this.txtModeOfPayment);
            this.grpPayment.Controls.Add(this.lblInstallmentCharge);
            this.grpPayment.Controls.Add(this.lblDownpayment);
            this.grpPayment.Controls.Add(this.txtDownpayment);
            this.grpPayment.Controls.Add(this.lbl1stInstallment);
            this.grpPayment.Controls.Add(this.txt1stInstallment);
            this.grpPayment.Controls.Add(this.lbl2ndInstallment);
            this.grpPayment.Controls.Add(this.txt2ndInstallment);
            this.grpPayment.Controls.Add(this.lbl3rdInstallment);
            this.grpPayment.Controls.Add(this.txt3rdInstallment);
            this.grpPayment.Controls.Add(this.lblAmountDue);
            this.grpPayment.Controls.Add(this.txtAmountDue);
            this.grpPayment.Controls.Add(this.lblGrandTotal);
            this.grpPayment.Controls.Add(this.txtGrandTotal);
            this.grpPayment.Controls.Add(this.lblDiscount);
            this.grpPayment.Controls.Add(this.txtDiscount);
            this.grpPayment.Location = new System.Drawing.Point(440, 490);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(590, 245);
            this.grpPayment.TabIndex = 3;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
             
            this.lblTotalTuitionAndFees.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalTuitionAndFees.Location = new System.Drawing.Point(10, 28);
            this.lblTotalTuitionAndFees.Name = "lblTotalTuitionAndFees";
            this.lblTotalTuitionAndFees.Size = new System.Drawing.Size(175, 20);
            this.lblTotalTuitionAndFees.TabIndex = 0;
            this.lblTotalTuitionAndFees.Text = "TOTAL TUITION AND FEES:";
             
            this.txtTotalTuitionAndFees.Location = new System.Drawing.Point(190, 25);
            this.txtTotalTuitionAndFees.Name = "txtTotalTuitionAndFees";
            this.txtTotalTuitionAndFees.ReadOnly = true;
            this.txtTotalTuitionAndFees.Size = new System.Drawing.Size(150, 29);
            this.txtTotalTuitionAndFees.TabIndex = 1;
             
            this.lblModeOfPayment.Location = new System.Drawing.Point(10, 58);
            this.lblModeOfPayment.Name = "lblModeOfPayment";
            this.lblModeOfPayment.Size = new System.Drawing.Size(120, 20);
            this.lblModeOfPayment.TabIndex = 2;
            this.lblModeOfPayment.Text = "Mode of Payment:";
             
            this.txtModeOfPayment.Location = new System.Drawing.Point(190, 55);
            this.txtModeOfPayment.Name = "txtModeOfPayment";
            this.txtModeOfPayment.ReadOnly = true;
            this.txtModeOfPayment.Size = new System.Drawing.Size(150, 29);
            this.txtModeOfPayment.TabIndex = 3;
            
            this.lblInstallmentCharge.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblInstallmentCharge.Location = new System.Drawing.Point(10, 88);
            this.lblInstallmentCharge.Name = "lblInstallmentCharge";
            this.lblInstallmentCharge.Size = new System.Drawing.Size(130, 20);
            this.lblInstallmentCharge.TabIndex = 4;
            this.lblInstallmentCharge.Text = "Installment Charge:";
             
            this.lblDownpayment.Location = new System.Drawing.Point(10, 113);
            this.lblDownpayment.Name = "lblDownpayment";
            this.lblDownpayment.Size = new System.Drawing.Size(130, 20);
            this.lblDownpayment.TabIndex = 5;
            this.lblDownpayment.Text = "  Downpayment:";
             
            this.txtDownpayment.Location = new System.Drawing.Point(190, 110);
            this.txtDownpayment.Name = "txtDownpayment";
            this.txtDownpayment.ReadOnly = true;
            this.txtDownpayment.Size = new System.Drawing.Size(150, 29);
            this.txtDownpayment.TabIndex = 6;
            
            this.lbl1stInstallment.Location = new System.Drawing.Point(10, 141);
            this.lbl1stInstallment.Name = "lbl1stInstallment";
            this.lbl1stInstallment.Size = new System.Drawing.Size(130, 20);
            this.lbl1stInstallment.TabIndex = 7;
            this.lbl1stInstallment.Text = "  1st Installment:";
            
            this.txt1stInstallment.Location = new System.Drawing.Point(190, 138);
            this.txt1stInstallment.Name = "txt1stInstallment";
            this.txt1stInstallment.ReadOnly = true;
            this.txt1stInstallment.Size = new System.Drawing.Size(150, 29);
            this.txt1stInstallment.TabIndex = 8;
             
            this.lbl2ndInstallment.Location = new System.Drawing.Point(10, 169);
            this.lbl2ndInstallment.Name = "lbl2ndInstallment";
            this.lbl2ndInstallment.Size = new System.Drawing.Size(130, 20);
            this.lbl2ndInstallment.TabIndex = 9;
            this.lbl2ndInstallment.Text = "  2nd Installment:";
            
            this.txt2ndInstallment.Location = new System.Drawing.Point(190, 166);
            this.txt2ndInstallment.Name = "txt2ndInstallment";
            this.txt2ndInstallment.ReadOnly = true;
            this.txt2ndInstallment.Size = new System.Drawing.Size(150, 29);
            this.txt2ndInstallment.TabIndex = 10;
             
            this.lbl3rdInstallment.Location = new System.Drawing.Point(10, 197);
            this.lbl3rdInstallment.Name = "lbl3rdInstallment";
            this.lbl3rdInstallment.Size = new System.Drawing.Size(130, 20);
            this.lbl3rdInstallment.TabIndex = 11;
            this.lbl3rdInstallment.Text = "  3rd Installment:";
             
            this.txt3rdInstallment.Location = new System.Drawing.Point(190, 194);
            this.txt3rdInstallment.Name = "txt3rdInstallment";
            this.txt3rdInstallment.ReadOnly = true;
            this.txt3rdInstallment.Size = new System.Drawing.Size(150, 29);
            this.txt3rdInstallment.TabIndex = 12;
            
            this.lblAmountDue.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblAmountDue.Location = new System.Drawing.Point(360, 28);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(95, 20);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.Text = "AMOUNT DUE:";
            
            this.txtAmountDue.Location = new System.Drawing.Point(460, 25);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(120, 29);
            this.txtAmountDue.TabIndex = 14;
            
            this.lblGrandTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.Location = new System.Drawing.Point(360, 58);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(95, 20);
            this.lblGrandTotal.TabIndex = 15;
            this.lblGrandTotal.Text = "GRAND TOTAL:";
             
            this.txtGrandTotal.Location = new System.Drawing.Point(460, 55);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(120, 29);
            this.txtGrandTotal.TabIndex = 16;
            
            this.lblDiscount.Location = new System.Drawing.Point(360, 88);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(95, 20);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "Discount:";
            
            this.txtDiscount.Location = new System.Drawing.Point(460, 85);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(120, 29);
            this.txtDiscount.TabIndex = 18;
             
            this.btnComputeFees.Location = new System.Drawing.Point(10, 745);
            this.btnComputeFees.Name = "btnComputeFees";
            this.btnComputeFees.Size = new System.Drawing.Size(160, 35);
            this.btnComputeFees.TabIndex = 4;
            this.btnComputeFees.Text = "COMPUTE FEES";
            this.btnComputeFees.Click += new System.EventHandler(this.btnComputeFees_Click);
             
            this.btnClearStudentInfo.Location = new System.Drawing.Point(180, 745);
            this.btnClearStudentInfo.Name = "btnClearStudentInfo";
            this.btnClearStudentInfo.Size = new System.Drawing.Size(210, 35);
            this.btnClearStudentInfo.TabIndex = 5;
            this.btnClearStudentInfo.Text = "CLEAR STUDENT INFORMATION";
            this.btnClearStudentInfo.Click += new System.EventHandler(this.btnClearStudentInfo_Click);
            
            this.btnExit.Location = new System.Drawing.Point(10, 787);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
             
            this.btnClearSchedule.Location = new System.Drawing.Point(180, 787);
            this.btnClearSchedule.Name = "btnClearSchedule";
            this.btnClearSchedule.Size = new System.Drawing.Size(210, 35);
            this.btnClearSchedule.TabIndex = 7;
            this.btnClearSchedule.Text = "CLEAR SCHEDULE OF COURSES";
            this.btnClearSchedule.Click += new System.EventHandler(this.btnClearSchedule_Click);
             
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 175;
             
            this.dataGridViewTextBoxColumn2.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 175;
             
            this.dataGridViewTextBoxColumn3.HeaderText = "Section";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 175;
             
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            
            this.dataGridViewTextBoxColumn5.HeaderText = "Lec. Units";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 175;
             
            this.dataGridViewTextBoxColumn6.HeaderText = "Lab. Units";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
             
            this.dataGridViewTextBoxColumn7.HeaderText = "Cred. Units";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 175;
             
            this.dataGridViewTextBoxColumn8.HeaderText = "Time";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 175;
            
            this.dataGridViewTextBoxColumn9.HeaderText = "Day";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 175;
            
            this.dataGridViewTextBoxColumn10.HeaderText = "Room";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 175;
            
            this.ClientSize = new System.Drawing.Size(1058, 838);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.grpFees);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.btnComputeFees);
            this.Controls.Add(this.btnClearStudentInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearSchedule);
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Enrollment - Santiago BSIT-WM-202";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.grpFees.ResumeLayout(false);
            this.grpFees.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.ComboBox cboYearLevel;
        private System.Windows.Forms.DateTimePicker dtpEnrolled;
        private System.Windows.Forms.ComboBox cboScholar;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.TextBox txtTotalCredUnits;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.GroupBox grpFees;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.TextBox txtTotalTuitionFee;
        private System.Windows.Forms.TextBox txtMiscFee;
        private System.Windows.Forms.TextBox txtComLabFee;
        private System.Windows.Forms.TextBox txtSapFee;
        private System.Windows.Forms.TextBox txtCiscoFee;
        private System.Windows.Forms.TextBox txtExamBookletFee;
        private System.Windows.Forms.TextBox txtTotalOtherFee;
        private System.Windows.Forms.TextBox txtTotalTuitionAndFees;
        private System.Windows.Forms.TextBox txtModeOfPayment;
        private System.Windows.Forms.TextBox txtDownpayment;
        private System.Windows.Forms.TextBox txt1stInstallment;
        private System.Windows.Forms.TextBox txt2ndInstallment;
        private System.Windows.Forms.TextBox txt3rdInstallment;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnComputeFees;
        private System.Windows.Forms.Button btnClearStudentInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearSchedule;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblDateEnrolled;
        private System.Windows.Forms.Label lblScholar;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblTotalCredUnits;
        private System.Windows.Forms.Label lblTotalTuitionFee;
        private System.Windows.Forms.Label lblMiscFee;
        private System.Windows.Forms.Label lblOtherFees;
        private System.Windows.Forms.Label lblComLabFee;
        private System.Windows.Forms.Label lblSapFee;
        private System.Windows.Forms.Label lblCiscoFee;
        private System.Windows.Forms.Label lblExamBookletFee;
        private System.Windows.Forms.Label lblTotalOtherFee;
        private System.Windows.Forms.Label lblTotalTuitionAndFees;
        private System.Windows.Forms.Label lblModeOfPayment;
        private System.Windows.Forms.Label lblInstallmentCharge;
        private System.Windows.Forms.Label lblDownpayment;
        private System.Windows.Forms.Label lbl1stInstallment;
        private System.Windows.Forms.Label lbl2ndInstallment;
        private System.Windows.Forms.Label lbl3rdInstallment;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblDiscount;
    }
}