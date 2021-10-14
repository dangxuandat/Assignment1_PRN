using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class MemberForm : Form
    {
        private IMemberRepository memberRepository;
        private MemberObject _currentMember;
        private frmLogin loginForm;
        public MemberForm(MemberObject currentMember, frmLogin form)
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
            _currentMember = currentMember;
            loginForm = form;
        }

        private void RefreshData(MemberObject member)
        {
            tbMemberId.Text = member.MemberId.ToString();
            tbMemberEmail.Text = member.Email;
            tbMemberPassword.Text = member.Password;
            tbMemberName.Text = member.MemberName;
            tbMemberCity.Text = member.City.ToUpper();
            tbMemberCountry.Text = member.Country.ToUpper();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            RefreshData(_currentMember);
            tbMemberId.ReadOnly = true;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var MemberId = Convert.ToInt32(tbMemberId.Text);
                var MemberName = tbMemberName.Text.ToUpper() == "" ? null : tbMemberName.Text;
                var MemberPassword = tbMemberPassword.Text == "" ? null : tbMemberPassword.Text;
                var MemberEmail = tbMemberEmail.Text == "" ? null : tbMemberEmail.Text;
                var MemberCity = tbMemberCity.Text.ToUpper() == "" ? null : tbMemberCity.Text.ToUpper();
                var MemberCountry = tbMemberCountry.Text.ToUpper() == "" ? null : tbMemberCountry.Text.ToUpper();
                memberRepository.UpdateMember(new MemberObject
                {
                    MemberId = MemberId,
                    MemberName = MemberName,
                    Password = MemberPassword,
                    Email = MemberEmail,
                    City = MemberCity,
                    Country = MemberCountry
                });
                RefreshData(memberRepository.GetMemberByID(MemberId));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}
