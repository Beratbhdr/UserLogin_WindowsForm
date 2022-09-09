using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıGiris
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            if (txt_usercode.Text == "" && txt_passcode.Text == "")
            {
                MessageBox.Show("Cannot be blank! (Bu Alan Boş Geçilemez!)");
            }
                if (txt_usercode.Text == "berat" && txt_passcode.Text == "123")
                {
                    MessageBox.Show("login Successfull.. (Giriş Başarılı.)");
                }
                else if(txt_usercode.Text !="berat" || txt_passcode.Text !="123")
                {
                MessageBox.Show("Wrong username or password!!! (Hatalı kullanıcı adı veya şifre!!! )");
                }
            
        }
    }
}
