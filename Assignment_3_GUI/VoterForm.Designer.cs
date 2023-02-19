namespace Assignment_3_GUI
{
    partial class VoterForm
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJobStatus = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddVoter = new System.Windows.Forms.Button();
            this.btnDeleteVoter = new System.Windows.Forms.Button();
            this.btnGetVoterById = new System.Windows.Forms.Button();
            this.btnGetAllVoters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Voter CRUD Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Religion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nationality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "phoneNumber";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(910, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(910, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "jobStatus";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(910, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "MaritalStatus";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.Location = new System.Drawing.Point(153, 153);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 30);
            this.txtId.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAddress.Location = new System.Drawing.Point(153, 413);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 30);
            this.txtAddress.TabIndex = 4;
            // 
            // txtDob
            // 
            this.txtDob.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDob.Location = new System.Drawing.Point(410, 239);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(173, 30);
            this.txtDob.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAge.Location = new System.Drawing.Point(153, 331);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(173, 30);
            this.txtAge.TabIndex = 3;
            // 
            // txtReligion
            // 
            this.txtReligion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtReligion.Location = new System.Drawing.Point(410, 332);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(173, 30);
            this.txtReligion.TabIndex = 7;
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNationality.Location = new System.Drawing.Point(731, 154);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(173, 30);
            this.txtNationality.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCountry.Location = new System.Drawing.Point(731, 244);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(173, 30);
            this.txtCountry.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhone.Location = new System.Drawing.Point(731, 335);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(173, 30);
            this.txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Location = new System.Drawing.Point(1036, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 30);
            this.txtEmail.TabIndex = 12;
            // 
            // txtJobStatus
            // 
            this.txtJobStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtJobStatus.Location = new System.Drawing.Point(1036, 244);
            this.txtJobStatus.Name = "txtJobStatus";
            this.txtJobStatus.Size = new System.Drawing.Size(173, 30);
            this.txtJobStatus.TabIndex = 13;
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaritalStatus.Location = new System.Drawing.Point(1036, 335);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(173, 30);
            this.txtMaritalStatus.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCity.Location = new System.Drawing.Point(410, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 30);
            this.txtCity.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGender.Location = new System.Drawing.Point(410, 414);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(173, 30);
            this.txtGender.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.Location = new System.Drawing.Point(153, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 30);
            this.txtName.TabIndex = 2;
            // 
            // btnAddVoter
            // 
            this.btnAddVoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddVoter.Location = new System.Drawing.Point(124, 547);
            this.btnAddVoter.Name = "btnAddVoter";
            this.btnAddVoter.Size = new System.Drawing.Size(200, 40);
            this.btnAddVoter.TabIndex = 28;
            this.btnAddVoter.Text = "Add Voter";
            this.btnAddVoter.UseVisualStyleBackColor = false;
            this.btnAddVoter.Click += new System.EventHandler(this.btnAddVoter_Click_1);
            // 
            // btnDeleteVoter
            // 
            this.btnDeleteVoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteVoter.Location = new System.Drawing.Point(403, 547);
            this.btnDeleteVoter.Name = "btnDeleteVoter";
            this.btnDeleteVoter.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteVoter.TabIndex = 29;
            this.btnDeleteVoter.Text = "Delete Voter by ID";
            this.btnDeleteVoter.UseVisualStyleBackColor = false;
            this.btnDeleteVoter.Click += new System.EventHandler(this.btnDeleteVoter_Click);
            // 
            // btnGetVoterById
            // 
            this.btnGetVoterById.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetVoterById.Location = new System.Drawing.Point(682, 547);
            this.btnGetVoterById.Name = "btnGetVoterById";
            this.btnGetVoterById.Size = new System.Drawing.Size(200, 40);
            this.btnGetVoterById.TabIndex = 30;
            this.btnGetVoterById.Text = "Search by ID";
            this.btnGetVoterById.UseVisualStyleBackColor = false;
            this.btnGetVoterById.Click += new System.EventHandler(this.btnGetVoterById_Click_1);
            // 
            // btnGetAllVoters
            // 
            this.btnGetAllVoters.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetAllVoters.Location = new System.Drawing.Point(961, 547);
            this.btnGetAllVoters.Name = "btnGetAllVoters";
            this.btnGetAllVoters.Size = new System.Drawing.Size(200, 40);
            this.btnGetAllVoters.TabIndex = 31;
            this.btnGetAllVoters.Text = "Get All Voters List";
            this.btnGetAllVoters.UseVisualStyleBackColor = false;
            this.btnGetAllVoters.Click += new System.EventHandler(this.btnGetAllVoters_Click_1);
            // 
            // VoterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.btnGetAllVoters);
            this.Controls.Add(this.btnGetVoterById);
            this.Controls.Add(this.btnDeleteVoter);
            this.Controls.Add(this.btnAddVoter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.txtJobStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment_3_GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJobStatus;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddVoter;
        private System.Windows.Forms.Button btnDeleteVoter;
        private System.Windows.Forms.Button btnGetVoterById;
        private System.Windows.Forms.Button btnGetAllVoters;
    }
}

