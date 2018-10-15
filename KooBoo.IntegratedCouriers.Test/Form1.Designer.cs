namespace KooBoo.IntegratedCouriers.Test
{
    partial class Form1
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnGetTowns = new System.Windows.Forms.Button();
            this.btnSearchTowns = new System.Windows.Forms.Button();
            this.btnGetSuburbs = new System.Windows.Forms.Button();
            this.btnGetLocationTypes = new System.Windows.Forms.Button();
            this.btnGetServices = new System.Windows.Forms.Button();
            this.btnGetAddress = new System.Windows.Forms.Button();
            this.btnGetAddresses = new System.Windows.Forms.Button();
            this.btnGetContacts = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnGetPOD = new System.Windows.Forms.Button();
            this.btnGetParcelImages = new System.Windows.Forms.Button();
            this.btnGetParcelImage = new System.Windows.Forms.Button();
            this.btnGetColliveryStatus = new System.Windows.Forms.Button();
            this.btnGetParcelTypes = new System.Windows.Forms.Button();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.btnValidateCollivery = new System.Windows.Forms.Button();
            this.btnAddCollivery = new System.Windows.Forms.Button();
            this.btnAcceptCollivery = new System.Windows.Forms.Button();
            this.btnCancelCollivery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "api@collivery.co.za";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(95, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(266, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "api123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 181);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(658, 248);
            this.txtResult.TabIndex = 4;
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(15, 68);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.TabIndex = 5;
            this.btnAuth.Text = "Authenticate";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnGetTowns
            // 
            this.btnGetTowns.Location = new System.Drawing.Point(96, 68);
            this.btnGetTowns.Name = "btnGetTowns";
            this.btnGetTowns.Size = new System.Drawing.Size(75, 23);
            this.btnGetTowns.TabIndex = 6;
            this.btnGetTowns.Text = "Get Towns";
            this.btnGetTowns.UseVisualStyleBackColor = true;
            this.btnGetTowns.Click += new System.EventHandler(this.btnGetTowns_Click);
            // 
            // btnSearchTowns
            // 
            this.btnSearchTowns.Location = new System.Drawing.Point(177, 68);
            this.btnSearchTowns.Name = "btnSearchTowns";
            this.btnSearchTowns.Size = new System.Drawing.Size(91, 23);
            this.btnSearchTowns.TabIndex = 7;
            this.btnSearchTowns.Text = "Search Towns";
            this.btnSearchTowns.UseVisualStyleBackColor = true;
            this.btnSearchTowns.Click += new System.EventHandler(this.btnSearchTowns_Click);
            // 
            // btnGetSuburbs
            // 
            this.btnGetSuburbs.Location = new System.Drawing.Point(274, 68);
            this.btnGetSuburbs.Name = "btnGetSuburbs";
            this.btnGetSuburbs.Size = new System.Drawing.Size(91, 23);
            this.btnGetSuburbs.TabIndex = 8;
            this.btnGetSuburbs.Text = "Get Suburbs";
            this.btnGetSuburbs.UseVisualStyleBackColor = true;
            this.btnGetSuburbs.Click += new System.EventHandler(this.btnGetSuburbs_Click);
            // 
            // btnGetLocationTypes
            // 
            this.btnGetLocationTypes.Location = new System.Drawing.Point(371, 68);
            this.btnGetLocationTypes.Name = "btnGetLocationTypes";
            this.btnGetLocationTypes.Size = new System.Drawing.Size(108, 23);
            this.btnGetLocationTypes.TabIndex = 9;
            this.btnGetLocationTypes.Text = "Get Location Types";
            this.btnGetLocationTypes.UseVisualStyleBackColor = true;
            this.btnGetLocationTypes.Click += new System.EventHandler(this.btnGetLocationTypes_Click);
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(485, 68);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(91, 23);
            this.btnGetServices.TabIndex = 10;
            this.btnGetServices.Text = "Get Services";
            this.btnGetServices.UseVisualStyleBackColor = true;
            this.btnGetServices.Click += new System.EventHandler(this.btnGetServices_Click);
            // 
            // btnGetAddress
            // 
            this.btnGetAddress.Location = new System.Drawing.Point(582, 68);
            this.btnGetAddress.Name = "btnGetAddress";
            this.btnGetAddress.Size = new System.Drawing.Size(91, 23);
            this.btnGetAddress.TabIndex = 11;
            this.btnGetAddress.Text = "Get Address";
            this.btnGetAddress.UseVisualStyleBackColor = true;
            this.btnGetAddress.Click += new System.EventHandler(this.btnGetAddress_Click);
            // 
            // btnGetAddresses
            // 
            this.btnGetAddresses.Location = new System.Drawing.Point(15, 97);
            this.btnGetAddresses.Name = "btnGetAddresses";
            this.btnGetAddresses.Size = new System.Drawing.Size(91, 23);
            this.btnGetAddresses.TabIndex = 12;
            this.btnGetAddresses.Text = "Get Addresses";
            this.btnGetAddresses.UseVisualStyleBackColor = true;
            this.btnGetAddresses.Click += new System.EventHandler(this.btnGetAddresses_Click);
            // 
            // btnGetContacts
            // 
            this.btnGetContacts.Location = new System.Drawing.Point(112, 97);
            this.btnGetContacts.Name = "btnGetContacts";
            this.btnGetContacts.Size = new System.Drawing.Size(77, 23);
            this.btnGetContacts.TabIndex = 13;
            this.btnGetContacts.Text = "Get Contacts";
            this.btnGetContacts.UseVisualStyleBackColor = true;
            this.btnGetContacts.Click += new System.EventHandler(this.btnGetContacts_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(195, 97);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(81, 23);
            this.btnAddAddress.TabIndex = 14;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(282, 97);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(79, 23);
            this.btnAddContact.TabIndex = 15;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnGetPOD
            // 
            this.btnGetPOD.Location = new System.Drawing.Point(367, 97);
            this.btnGetPOD.Name = "btnGetPOD";
            this.btnGetPOD.Size = new System.Drawing.Size(58, 23);
            this.btnGetPOD.TabIndex = 16;
            this.btnGetPOD.Text = "Get POD";
            this.btnGetPOD.UseVisualStyleBackColor = true;
            this.btnGetPOD.Click += new System.EventHandler(this.btnGetPOD_Click);
            // 
            // btnGetParcelImages
            // 
            this.btnGetParcelImages.Location = new System.Drawing.Point(431, 97);
            this.btnGetParcelImages.Name = "btnGetParcelImages";
            this.btnGetParcelImages.Size = new System.Drawing.Size(129, 23);
            this.btnGetParcelImages.TabIndex = 17;
            this.btnGetParcelImages.Text = "Get list of parcel images";
            this.btnGetParcelImages.UseVisualStyleBackColor = true;
            this.btnGetParcelImages.Click += new System.EventHandler(this.btnGetParcelImages_Click);
            // 
            // btnGetParcelImage
            // 
            this.btnGetParcelImage.Location = new System.Drawing.Point(15, 126);
            this.btnGetParcelImage.Name = "btnGetParcelImage";
            this.btnGetParcelImage.Size = new System.Drawing.Size(103, 23);
            this.btnGetParcelImage.TabIndex = 18;
            this.btnGetParcelImage.Text = "Get Parcel Image";
            this.btnGetParcelImage.UseVisualStyleBackColor = true;
            this.btnGetParcelImage.Click += new System.EventHandler(this.btnGetParcelImage_Click);
            // 
            // btnGetColliveryStatus
            // 
            this.btnGetColliveryStatus.Location = new System.Drawing.Point(124, 126);
            this.btnGetColliveryStatus.Name = "btnGetColliveryStatus";
            this.btnGetColliveryStatus.Size = new System.Drawing.Size(108, 23);
            this.btnGetColliveryStatus.TabIndex = 19;
            this.btnGetColliveryStatus.Text = "Get Collivery Status";
            this.btnGetColliveryStatus.UseVisualStyleBackColor = true;
            this.btnGetColliveryStatus.Click += new System.EventHandler(this.btnGetColliveryStatus_Click);
            // 
            // btnGetParcelTypes
            // 
            this.btnGetParcelTypes.Location = new System.Drawing.Point(238, 126);
            this.btnGetParcelTypes.Name = "btnGetParcelTypes";
            this.btnGetParcelTypes.Size = new System.Drawing.Size(108, 23);
            this.btnGetParcelTypes.TabIndex = 20;
            this.btnGetParcelTypes.Text = "Get Parcel Types";
            this.btnGetParcelTypes.UseVisualStyleBackColor = true;
            this.btnGetParcelTypes.Click += new System.EventHandler(this.btnGetParcelTypes_Click);
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Location = new System.Drawing.Point(352, 126);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(73, 23);
            this.btnGetPrice.TabIndex = 21;
            this.btnGetPrice.Text = "Get Price";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // btnValidateCollivery
            // 
            this.btnValidateCollivery.Location = new System.Drawing.Point(431, 126);
            this.btnValidateCollivery.Name = "btnValidateCollivery";
            this.btnValidateCollivery.Size = new System.Drawing.Size(98, 23);
            this.btnValidateCollivery.TabIndex = 22;
            this.btnValidateCollivery.Text = "Validate Collivery";
            this.btnValidateCollivery.UseVisualStyleBackColor = true;
            this.btnValidateCollivery.Click += new System.EventHandler(this.btnValidateCollivery_Click);
            // 
            // btnAddCollivery
            // 
            this.btnAddCollivery.Location = new System.Drawing.Point(535, 126);
            this.btnAddCollivery.Name = "btnAddCollivery";
            this.btnAddCollivery.Size = new System.Drawing.Size(98, 23);
            this.btnAddCollivery.TabIndex = 23;
            this.btnAddCollivery.Text = "Add Collivery";
            this.btnAddCollivery.UseVisualStyleBackColor = true;
            this.btnAddCollivery.Click += new System.EventHandler(this.btnAddCollivery_Click);
            // 
            // btnAcceptCollivery
            // 
            this.btnAcceptCollivery.Location = new System.Drawing.Point(566, 97);
            this.btnAcceptCollivery.Name = "btnAcceptCollivery";
            this.btnAcceptCollivery.Size = new System.Drawing.Size(98, 23);
            this.btnAcceptCollivery.TabIndex = 24;
            this.btnAcceptCollivery.Text = "Accept Collivery";
            this.btnAcceptCollivery.UseVisualStyleBackColor = true;
            this.btnAcceptCollivery.Click += new System.EventHandler(this.btnAcceptCollivery_Click);
            // 
            // btnCancelCollivery
            // 
            this.btnCancelCollivery.Location = new System.Drawing.Point(15, 155);
            this.btnCancelCollivery.Name = "btnCancelCollivery";
            this.btnCancelCollivery.Size = new System.Drawing.Size(98, 23);
            this.btnCancelCollivery.TabIndex = 25;
            this.btnCancelCollivery.Text = "Cancel Collivery";
            this.btnCancelCollivery.UseVisualStyleBackColor = true;
            this.btnCancelCollivery.Click += new System.EventHandler(this.btnCancelCollivery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 444);
            this.Controls.Add(this.btnCancelCollivery);
            this.Controls.Add(this.btnAcceptCollivery);
            this.Controls.Add(this.btnAddCollivery);
            this.Controls.Add(this.btnValidateCollivery);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.btnGetParcelTypes);
            this.Controls.Add(this.btnGetColliveryStatus);
            this.Controls.Add(this.btnGetParcelImage);
            this.Controls.Add(this.btnGetParcelImages);
            this.Controls.Add(this.btnGetPOD);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.btnGetContacts);
            this.Controls.Add(this.btnGetAddresses);
            this.Controls.Add(this.btnGetAddress);
            this.Controls.Add(this.btnGetServices);
            this.Controls.Add(this.btnGetLocationTypes);
            this.Controls.Add(this.btnGetSuburbs);
            this.Controls.Add(this.btnSearchTowns);
            this.Controls.Add(this.btnGetTowns);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnGetTowns;
        private System.Windows.Forms.Button btnSearchTowns;
        private System.Windows.Forms.Button btnGetSuburbs;
        private System.Windows.Forms.Button btnGetLocationTypes;
        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.Button btnGetAddress;
        private System.Windows.Forms.Button btnGetAddresses;
        private System.Windows.Forms.Button btnGetContacts;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnGetPOD;
        private System.Windows.Forms.Button btnGetParcelImages;
        private System.Windows.Forms.Button btnGetParcelImage;
        private System.Windows.Forms.Button btnGetColliveryStatus;
        private System.Windows.Forms.Button btnGetParcelTypes;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Button btnValidateCollivery;
        private System.Windows.Forms.Button btnAddCollivery;
        private System.Windows.Forms.Button btnAcceptCollivery;
        private System.Windows.Forms.Button btnCancelCollivery;
    }
}

