using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Curriculum_Vitae.CV_FormD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Curriculum_Vitae
{
    public partial class CV_FormD : Form
    {
        public CV_FormD()
        {
            InitializeComponent();
        }

        private void CV_FormD_Load(object sender, EventArgs e)
        {
            this.Text = "Input Form";

            lblUserInfo.ForeColor = Color.White;


            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }

            listViewReferences.Visible = false;
            listViewWorkExperience.Visible = false;
            listViewCertifications.Visible = false;
            btnEditCert.Visible = false;
            btnDeleteCert.Visible = false;
            btnEditWorkEx.Visible = false;
            btnDeleteWorkEx.Visible = false;
            btnEditRef.Visible = false;
            btnDeleteRef.Visible = false;



            /*---------------CERTIFICATIONS-------------*/
            listViewCertifications.View = View.Details;
            listViewCertifications.FullRowSelect = true;
            listViewCertifications.GridLines = true;

            listViewCertifications.Columns.Add("Certificate Name", 150);
            listViewCertifications.Columns.Add("Description", 200);
            listViewCertifications.Columns.Add("Issuing Organization", 150);
            listViewCertifications.Columns.Add("Date Issued", 100);

            /*---------------WORK EXPERIENCE-------------*/
            listViewWorkExperience.View = View.Details;
            listViewWorkExperience.FullRowSelect = true;
            listViewWorkExperience.GridLines = true;

            listViewWorkExperience.Columns.Add("Company Name", 100);
            listViewWorkExperience.Columns.Add("Job Title", 100);
            listViewWorkExperience.Columns.Add("Job Description", 300);

            /*---------------REFERENCES-------------*/
            listViewReferences.View = View.Details;
            listViewReferences.FullRowSelect = true;
            listViewReferences.GridLines = true;

            listViewReferences.Columns.Add("Reference Name", 100);
            listViewReferences.Columns.Add("Contacts", 100);
        }

        /*--------------CERTIFICATION LIST VIEW---------------*/
        private List<Certification> certifications = new List<Certification>();
        public class Certification
        {
            public string CertificateName { get; set; }
            public string Description { get; set; }
            public string IssuingOrganization { get; set; }
            public DateTime DateIssued { get; set; }
        }

        /*--------------WORK EXPERIENCE LIST VIEW---------------*/
        private List<WorkExperience> workExperiences = new List<WorkExperience>();

        public class WorkExperience
        {

            public string CompanyName { get; set; }
            public string JobTitle { get; set; }
            public string JobDescription { get; set; }
        }

        /*--------------REFERENCE LIST VIEW---------------*/
        private List<Reference> references = new List<Reference>();

        public class Reference
        {
            public string ReferenceName { get; set; }
            public string ContactInformation { get; set; }
        }



        private void dtpDateIssued_Paint(object sender, PaintEventArgs e)
        {

        }

        /*--------------ADD NEW CERTIFICATION---------------*/
        private void btnAddCertification_Click(object sender, EventArgs e)
        {
            Certification cert = new Certification()
            {
                CertificateName = txtCertificateName.Text,
                Description = txtDescription.Text,
                IssuingOrganization = txtIssuingOrg.Text,
                DateIssued = dtpDateIssue.Value
            };

            certifications.Add(cert);
            listViewCertifications.Visible = true;
            btnEditCert.Visible = true;
            btnDeleteCert.Visible = true;



            listViewCertifications.Items.Add(new ListViewItem(new[]
            {
        cert.CertificateName,
        cert.Description,
        cert.IssuingOrganization,
        cert.DateIssued.ToShortDateString()
    }));


            txtCertificateName.Clear();
            txtDescription.Clear();
            txtIssuingOrg.Clear();
            dtpDateIssue.Value = DateTime.Now;
        }


        /*--------------ADD NEW WORK EXPERIENCE---------------*/
        private void btnAddWorkEx_Click(object sender, EventArgs e)
        {
            WorkExperience workEx = new WorkExperience()
            {
                CompanyName = txtCompanyName.Text,
                JobTitle = txtJobTitle.Text,
                JobDescription = txtJobDescription.Text
            };

            workExperiences.Add(workEx);

            listViewWorkExperience.Visible = true;
            btnEditWorkEx.Visible = true;
            btnDeleteWorkEx.Visible = true;



            listViewWorkExperience.Items.Add(new ListViewItem(new[]
            {
        workEx.CompanyName,
        workEx.JobTitle,
        workEx.JobDescription
    }));


            txtCompanyName.Clear();
            txtJobTitle.Clear();
            txtJobDescription.Clear();
        }

        /*----------------------ADD NEW REFERENCE-------------------*/
        private void btnAddNewReference_Click(object sender, EventArgs e)
        {
            Reference reference = new Reference()
            {
                ReferenceName = txtReferenceName.Text,
                ContactInformation = txtContactInformation.Text,
            };

            references.Add(reference);

            listViewReferences.Visible = true;
            btnEditRef.Visible = true;
            btnDeleteRef.Visible = true;



            listViewReferences.Items.Add(new ListViewItem(new[]
            {
        reference.ReferenceName,
        reference.ContactInformation

    }));


            txtReferenceName.Clear();
            txtContactInformation.Clear();
        }


        /*-----------------Select row from certifications list view----*/

        private void listViewCertifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCertifications.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCertifications.SelectedItems[0];

                txtCertificateName.Text = selectedItem.SubItems[0].Text;
                txtDescription.Text = selectedItem.SubItems[1].Text;
                txtIssuingOrg.Text = selectedItem.SubItems[2].Text;
                dtpDateIssue.Value = DateTime.TryParse(selectedItem.SubItems[3].Text, out DateTime date)
                                     ? date
                                     : DateTime.Now;
            }
        }

        /*----------------------Edit certifications------------------*/
        private void btnEditCert_Click(object sender, EventArgs e)
        {
            if (listViewCertifications.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewCertifications.SelectedIndices[0];
             


                // Update the list
                certifications[selectedIndex] = new Certification
                {
                    CertificateName = txtCertificateName.Text,
                    Description = txtDescription.Text,
                    IssuingOrganization = txtIssuingOrg.Text,
                    DateIssued = dtpDateIssue.Value
                };

                // Update the ListView
                var selectedItem = listViewCertifications.Items[selectedIndex];
                selectedItem.SubItems[0].Text = txtCertificateName.Text;
                selectedItem.SubItems[1].Text = txtDescription.Text;
                selectedItem.SubItems[2].Text = txtIssuingOrg.Text;
                selectedItem.SubItems[3].Text = dtpDateIssue.Value.ToShortDateString();

                MessageBox.Show("Certification updated successfully.");
            }
        }
        /*----------------------Delete certifications------------------*/
        private void btnDeleteCert_Click(object sender, EventArgs e)
        {
            if (listViewCertifications.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewCertifications.SelectedIndices[0];
     


                // Remove from the list and ListView
                certifications.RemoveAt(selectedIndex);
                listViewCertifications.Items.RemoveAt(selectedIndex);

                // Clear input fields
                txtCertificateName.Clear();
                txtDescription.Clear();
                txtIssuingOrg.Clear();
                dtpDateIssue.Value = DateTime.Now;

                MessageBox.Show("Certification deleted successfully.");
            }
        }
        /*----------------------Select row from work ex list view--------*/
        private void listViewWorkExperience_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorkExperience.SelectedItems.Count > 0)
            {
                var selectedItem = listViewWorkExperience.SelectedItems[0];

                txtCompanyName.Text = selectedItem.SubItems[0].Text;
                txtJobTitle.Text = selectedItem.SubItems[1].Text;
                txtJobDescription.Text = selectedItem.SubItems[2].Text;
            }
        }



        /*----------------------Edit work ex------------------*/
        private void btnEditWorkEx_Click(object sender, EventArgs e)
        {
            if (listViewWorkExperience.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewWorkExperience.SelectedIndices[0];


                // Update the list
                workExperiences[selectedIndex] = new WorkExperience
                {
                    CompanyName = txtCompanyName.Text,
                    JobTitle = txtJobTitle.Text,
                    JobDescription = txtJobDescription.Text
                };

                // Update the ListView
                var selectedItem = listViewWorkExperience.Items[selectedIndex];
                selectedItem.SubItems[0].Text = txtCompanyName.Text;
                selectedItem.SubItems[1].Text = txtJobTitle.Text;
                selectedItem.SubItems[2].Text = txtJobDescription.Text;

                MessageBox.Show("Work Experience updated successfully.");
            }
        }



        /*----------------------Delete work ex------------------*/
        private void btnDeleteWorkEx_Click(object sender, EventArgs e)
        {
            if (listViewWorkExperience.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewWorkExperience.SelectedIndices[0];
               


                // Remove from the list and ListView
                workExperiences.RemoveAt(selectedIndex);
                listViewWorkExperience.Items.RemoveAt(selectedIndex);

                // Clear input fields
                txtCompanyName.Clear();
                txtJobTitle.Clear();
                txtJobDescription.Clear();
             
                MessageBox.Show(" Work Experience deleted successfully.");
            }
        }

        /*----------------------Select row from reference list view--------*/

        private void listViewReferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReferences.SelectedItems.Count > 0)
            {
                var selectedItem = listViewReferences.SelectedItems[0];

                txtReferenceName.Text = selectedItem.SubItems[0].Text;
                txtContactInformation.Text = selectedItem.SubItems[1].Text;
            }
        }


        /*----------------------edit reference list view--------*/
        private void btnEditRef_Click(object sender, EventArgs e)
        {
            if (listViewReferences.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewReferences.SelectedIndices[0];

                // Update the list
                references[selectedIndex] = new Reference
                {
                    ReferenceName = txtReferenceName.Text,
                    ContactInformation = txtContactInformation.Text
                };

                // Update the ListView
                var selectedItem = listViewReferences.Items[selectedIndex];
                selectedItem.SubItems[0].Text = txtReferenceName.Text;
                selectedItem.SubItems[1].Text = txtContactInformation.Text;

                MessageBox.Show("References updated successfully.");
            }
        }

        /*----------------------delete reference list view--------*/
        private void btnDeleteRef_Click(object sender, EventArgs e)
        {
            if (listViewReferences.SelectedItems.Count > 0)
            {
                var selectedIndex = listViewReferences.SelectedIndices[0];

                // Remove from the list and ListView
                references.RemoveAt(selectedIndex);
                listViewReferences.Items.RemoveAt(selectedIndex);

                // Clear input fields
                txtReferenceName.Clear();
                txtContactInformation.Clear();
              

                MessageBox.Show(" Reference deleted successfully.");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void generate_btn_Click(object sender, EventArgs e)
      
        {
            string firstName = fn_tb.Text;
            string lastName = ln_tb.Text;
            string email = email_tb.Text;
            string contact = contact_tb.Text;
            string address = street_tb.Text + " " + brgy_tb.Text + " " + zip_tb.Text + " " + city_tb.Text;
            string obj = txtObjectives.Text;
            string college = college_tb.Text;
            string shs = shs_tb.Text;
            string jhs = jhs_tb.Text;
            string elem = elem_tb.Text;
            string collegeyr = collegeyr_tb.Text;
            string shsyr = shsyr_tb.Text;
            string jhsyr = jhsyr_tb.Text;
            string elemyr = elemyr_tb.Text;
            string skills = skills_tb.Text;

            if (pbImage.Image != null)
            {
                var generatedFormD = new CV_GeneratedFormD(
                    certifications,
                    workExperiences,
                    references,
                    firstName,
                    lastName,
                    email,
                    contact,
                    address,
                    obj,
                    college,
                    shs,
                    jhs,
                    elem,
                    collegeyr,
                    shsyr,
                    jhsyr,
                    elemyr,
                    skills,
                    pbImage.Image);

                generatedFormD.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please insert an image first.");
            }
        
        }

        private void fn_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(ofd.FileName);
                    pbImage.SizeMode = PictureBoxSizeMode.Zoom; // Makes it fit nicely
                }
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Session.LoggedInUser = null;
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
}
