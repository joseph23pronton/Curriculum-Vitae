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

namespace Curriculum_Vitae
{

    public partial class CV_GeneratedFormD : Form
    {
        public CV_GeneratedFormD
            (
                List<Certification> certifications,
                List<WorkExperience> workExperiences,
                List<Reference> references,
                string firstName,
                string lastName,
                string email,
                string contact,
                string address,
                string obj,
                string college,
                string shs,
                string jhs,
                string elem,
                string collegeyr,
                string shsyr,
                string jhsyr,
                string elemyr,
                string skills,
                Image img
            )
        {
            InitializeComponent();
            this.Text = "Jamaeca Dagonio";
            this.lblCertTitle.Name = "lblCertTitle";
            this.lblCert1.Name = "lblCert1";
            this.lblCert1.Text = "";
            pbImage.Image = img;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;


            if (certifications.Count > 0)
            {
                StringBuilder certText = new StringBuilder();
                foreach (var cert in certifications)
                {
                    certText.AppendLine($"{cert.CertificateName}");
                    certText.AppendLine($" {cert.Description}");
                    certText.AppendLine($" {cert.IssuingOrganization}");
                    certText.AppendLine($" {cert.DateIssued.ToShortDateString()}");
                    certText.AppendLine(); // extra spacing
                }
                lblCert1.Text = certText.ToString();
            }



            if (workExperiences.Count > 0)
            {
                StringBuilder workText = new StringBuilder();
                foreach (var workEx in workExperiences)
                {
                    workText.AppendLine($"{workEx.CompanyName}");
                    workText.AppendLine($"{workEx.JobTitle}");
                    workText.AppendLine($"{workEx.JobDescription}");
                    workText.AppendLine(); // extra spacing
                }
                lblWork1.Text = workText.ToString();
            }



            if (references.Count > 0)
            {
                StringBuilder refText = new StringBuilder();
                foreach (var reference in references)
                {
                    refText.AppendLine($"{reference.ReferenceName}");
                    refText.AppendLine($"{reference.ContactInformation}");
                    refText.AppendLine(); // extra spacing
                }
                lblRef1.Text = refText.ToString();
            }

            this.lblFirstName.Text = $"{firstName}";
            this.lblLastName.Text = $"{lastName}";
            this.lblEmail.Text = $"{email}";
            this.lblContact.Text = $"{contact}";
            this.lblHome.Text = $"{address}";
            this.lblObjective.Text = $"{obj}";
            this.lblCollege.Text = $"{college}";
            this.lblObjective.Text = $"{obj}";
            this.lblSenior.Text = $"{shs}";
            this.lblJunior.Text = $"{jhs}";
            this.lblElementary.Text = $"{elem}";
            this.lblCollegeYr.Text = $"{collegeyr}";
            this.lblShsyr.Text = $"{shsyr}";
            this.lblJhsyr.Text = $"{jhsyr}";
            this.lblElemyr.Text = $"{elemyr}";
            this.lblSkills.Text = $"{skills}";

        }


        private void CV_GeneratedFormD_Load(object sender, EventArgs e)
        {

        }


        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblCertTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblJunior_Click(object sender, EventArgs e)
        {

        }

        private void lblRef1_Click(object sender, EventArgs e)
        {

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }

}
