using System;
using System.Windows.Forms;

namespace Santiago_BSIT_WM_202_Lesson3Activity
{
    public partial class EnrollmentForm : Form
    {
        const double LECTURE_FEE = 1500.00;
        const double LAB_FEE = 2500.00;
        const double CISCO_FEE = 4500.00;
        const double EXAM_BOOKLET_FEE = 450.00;
        const double SAP_FEE = 2000.00;
        const double DOWNPAYMENT = 8000.00;

        public EnrollmentForm()
        {
            InitializeComponent();
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            cboProgram.Items.Add("BS Information Technology");  // Question 2a: Write are the codes in assigning Program combobox contents value with the following: BS Information Technology, BS Computer Engineering, BS Electrical Engineering, BS Computer Science, BS Mechanical Engineering, and BS Industrial Engineering.
            cboProgram.Items.Add("BS Computer Engineering");
            cboProgram.Items.Add("BS Electrical Engineering");
            cboProgram.Items.Add("BS Computer Science");
            cboProgram.Items.Add("BS Mechanical Engineering");
            cboProgram.Items.Add("BS Industrial Engineering");

            cboYearLevel.Items.Add("1st Year");
            cboYearLevel.Items.Add("2nd Year");
            cboYearLevel.Items.Add("3rd Year");
            cboYearLevel.Items.Add("4th Year");

            cboScholar.Items.Add("None");
            cboScholar.Items.Add("Full Scholar");
            cboScholar.Items.Add("Half Scholar");

            cboMode.Items.Add("Regular");
            cboMode.Items.Add("Irregular");
        }

        private void btnComputeFees_Click(object sender, EventArgs e)
        {
            int totalLecUnits = 0;
            int totalLabUnits = 0;
            int totalCredUnits = 0;

            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                if (row.IsNewRow) continue;

                int lec = 0, lab = 0;
                int.TryParse(row.Cells["colLecUnits"].Value?.ToString(), out lec);
                int.TryParse(row.Cells["colLabUnits"].Value?.ToString(), out lab);

                totalLecUnits += lec;
                totalLabUnits += lab;
                totalCredUnits += lec + lab;
            }

            txtTotalCredUnits.Text = totalCredUnits.ToString(); // Question 2b:b. Write the codes to display the total credit units in the TotalCreditUnitTextBox.

            // i. Total Tuition Fee
            double totalTuitionFee = totalLecUnits * LECTURE_FEE;

            // k. Computer Lab Fee
            double comLabFee = totalLabUnits * LAB_FEE;

            // j. Miscellaneous Fees
            double totalMiscFee = comLabFee + CISCO_FEE + SAP_FEE + EXAM_BOOKLET_FEE;

            // l. Total Tuition and Fees
            double totalTuitionAndFees = totalTuitionFee + totalMiscFee;

            // m. Downpayment
            double remaining = totalTuitionAndFees - DOWNPAYMENT;
            double installment = remaining / 3;

            txtTotalTuitionFee.Text = totalTuitionFee.ToString("F2");
            txtMiscFee.Text = totalMiscFee.ToString("F2");
            txtComLabFee.Text = comLabFee.ToString("F2");
            txtSapFee.Text = SAP_FEE.ToString("F2");
            txtCiscoFee.Text = CISCO_FEE.ToString("F2");
            txtExamBookletFee.Text = EXAM_BOOKLET_FEE.ToString("F2");
            txtTotalOtherFee.Text = totalMiscFee.ToString("F2");
            txtTotalTuitionAndFees.Text = totalTuitionAndFees.ToString("F2");
            txtModeOfPayment.Text = "Installment";
            txtDownpayment.Text = DOWNPAYMENT.ToString("F2");
            txt1stInstallment.Text = installment.ToString("F2");
            txt2ndInstallment.Text = installment.ToString("F2");
            txt3rdInstallment.Text = installment.ToString("F2");
            txtAmountDue.Text = DOWNPAYMENT.ToString("F2");
            txtGrandTotal.Text = totalTuitionAndFees.ToString("F2");
            txtDiscount.Text = "0.00";
        }

        private void btnClearStudentInfo_Click(object sender, EventArgs e)  // Question 2c: Write the codes to clear all TextBoxes under the schedule of courses group after clicking the Clear Student Information button.
        {
            dgvSchedule.Rows.Clear();
            txtTotalCredUnits.Text = "";
            txtTotalTuitionFee.Text = "";
            txtMiscFee.Text = "";
            txtComLabFee.Text = "";
            txtSapFee.Text = "";
            txtCiscoFee.Text = "";
            txtExamBookletFee.Text = "";
            txtTotalOtherFee.Text = "";
            txtTotalTuitionAndFees.Text = "";
            txtModeOfPayment.Text = "";
            txtDownpayment.Text = "";
            txt1stInstallment.Text = "";
            txt2ndInstallment.Text = "";
            txt3rdInstallment.Text = "";
            txtAmountDue.Text = "";
            txtGrandTotal.Text = "";
            txtDiscount.Text = "";
        }

        private void btnClearSchedule_Click(object sender, EventArgs e) //Question 2d:  Write the codes to clear all TextBoxes under the Student Information group after clicking the Clear Schedule of Courses button.
        {
            txtStudentName.Text = "";
            txtStudentNo.Text = "";
            cboProgram.SelectedIndex = -1;
            cboYearLevel.SelectedIndex = -1;
            cboScholar.SelectedIndex = -1;
            cboMode.SelectedIndex = -1;
            dtpEnrolled.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}