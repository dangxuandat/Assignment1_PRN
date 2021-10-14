using System;
using System.IO;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;
using Newtonsoft.Json;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private IMemberRepository memberRepository;
        private AdminObject admin;
        public frmLogin()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }

        

        private void btLogin_Click(object sender, EventArgs e)
        {
            var Email = tbEmail.Text;
            var Password = tbPassword.Text;
            if (String.IsNullOrEmpty(Email) || String.IsNullOrWhiteSpace(Email)
                                            || String.IsNullOrEmpty(Password) || String.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter Email and Password!!");
            }
            else
            {
                if (Email.Equals(admin.adminEmail) && Password.Equals(admin.adminPassword))
                {
                    this.Hide(); //just hide the form and pass the sender and eventArgs to AdminForm then
                    //let adminform'close event closes this form
                    frmMemberManager AdminForm = new frmMemberManager();
                    AdminForm.Closed += (sender, e) => this.Close();
                    AdminForm.Show();
                }

                var currentMember = memberRepository.GetMemberByEmailAndPassword(Email, Password);
                if (currentMember != null) // login successfully
                {
                    tbEmail.Clear();
                    tbPassword.Clear();
                    this.Hide();
                    MemberForm memberForm = new MemberForm(currentMember,this);
                    memberForm.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Email or Password!!!");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //install Json Framework to read file json then convert to admin object 
            using StreamReader streamReader = new StreamReader(@"C:\Users\Admin\Desktop\Ass01Solution_SE150699\appsettings.json");
            string json = streamReader.ReadToEnd(); 
            admin = JsonConvert.DeserializeObject<AdminObject>(json);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
