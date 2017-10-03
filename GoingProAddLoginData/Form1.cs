using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace GoingProAddLoginData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LBLResults_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.LimeGreen,
                                                                       Color.White,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            if (TBLoginID.Text == "")
            {
                LBLResults.Text = "Login ID is required";
                return;
            }
            if (TBPassword.Text == "")
            {
                LBLResults.Text = "Password is required";
                return;
            }

            //Convert LoginInfo into JSon


            var thisinfo = JsonConvert.SerializeObject(new
            {
                Distric = TBDistrict.Text,
                Building = CBBuilding.Text,
                Login_ID = TBLoginID.Text,
                Login_Password = HashPassword(TBPassword.Text),
                First_Name = TBFirstName.Text,
                Last_Name = TBLastName.Text,
                Email = TBEmail.Text
            });

            // POST a JSON string

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://goingpro.azurewebsites.net/api/Logins");
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"application/json";

            var dataStream = new StreamWriter(request.GetRequestStream());

            using (dataStream)
            {
                dataStream.Write(thisinfo);
                dataStream.Flush();
                dataStream.Close();
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (response)
            {
                if (response.StatusCode != HttpStatusCode.Created)
                {
                    LBLResults.Text = "Error fetching data.  Server returned status code " + response.StatusCode;
                }
                else
                {
                    LBLResults.Text = "Information Added";
                }
            }
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            if (TBLoginID.Text == "")
            {
                LBLResults.Text = "Login ID is required";
                return;
            }
            if (TBPassword.Text == "")
            {
                LBLResults.Text = "Password is required";
                return;
            }

            //Fetch the stored value           
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://goingpro.azurewebsites.net/api/Logins?loginid=" + TBLoginID.Text);
            request.Method = "Get";
            //request.ContentType = @"application/json";
            request.Accept = @"application/json";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader getjson = new StreamReader(stream);

            String getcontent = getjson.ReadToEnd();

            using (response)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    LBLResults.Text = "Error fetching data.  Server returned status code " + response.StatusCode;
                }
                else
                {

                    //unhash password and check against TBPassword.Text
                    LoginInfo thisinfo = JsonConvert.DeserializeObject<LoginInfo>(getcontent);
                    if (!checkpassword(thisinfo.Login_Password, TBPassword.Text))
                    {
                        LBLResults.Text = "Login ID or Password Incorrect";
                    }
                    else
                    {

                        LBLLoginDBID.Text = Convert.ToString(thisinfo.login_db_id);
                        TBDistrict.Text = thisinfo.Distric;
                        CBBuilding.Text = thisinfo.Building;

                        TBFirstName.Text = thisinfo.First_Name;
                        TBLastName.Text = thisinfo.Last_Name;
                        TBEmail.Text = thisinfo.Email;
                    }


                }
            }

        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            if (TBLoginID.Text == "")
            {
                LBLResults.Text = "Login ID is required";
                return;
            }
            if (TBPassword.Text == "")
            {
                LBLResults.Text = "Password is required";
                return;
            }
            if (LBLLoginDBID.Text == "")
            {
                LBLResults.Text = "You must login first";
                return;
            }

            var thisinfo = JsonConvert.SerializeObject(new
            {

                Distric = TBDistrict.Text,
                Building = CBBuilding.Text,
                Login_ID = TBLoginID.Text,
                Login_Password = HashPassword(TBPassword.Text),
                First_Name = TBFirstName.Text,
                Last_Name = TBLastName.Text,
                Email = TBEmail.Text
            });
 
            //Fetch the stored value  
            long dbid = Convert.ToInt64(LBLLoginDBID.Text);         
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://goingpro.azurewebsites.net/api/Logins?id=" + dbid);
            request.Method = "PUT";
            request.ContentType = @"application/json";
            request.Accept = @"application/json";

       
            var dataStream = new StreamWriter(request.GetRequestStream());

            using (dataStream)
            {
                dataStream.Write(thisinfo);
                dataStream.Flush();
                dataStream.Close();
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (response)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    LBLResults.Text = "Error fetching data.  Server returned status code " + response.StatusCode;
                }
                else
                {
                    LBLResults.Text = "Information Updated";
                }
            }

 
        }
        public string HashPassword(string PW)
        {
            //Create the salt value with a cryptographic PRNG:
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //Create the Rfc2898DeriveBytes and get hash value
            var pbkdf2 = new Rfc2898DeriveBytes(TBPassword.Text, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            //Combine the salt and password bytes for later use
            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);

            //Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashbytes);
            return savedPasswordHash;
        }
        public bool checkpassword(string hashpw, string PW)
        {
 
            //Extract the bytes
            byte[] hashBytes = Convert.FromBase64String(hashpw);
            //Get the salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            //Compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(PW, salt, 10000);
            byte[] hashentered = pbkdf2.GetBytes(20);
            //Compare the hashentered to the hash retrieved from db
            bool PWAuthorized = true;
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hashentered[i])
                {
                    PWAuthorized = false;
                }
            }
            return PWAuthorized;
   
        }

        private void BTNaddLog_Click(object sender, EventArgs e)
        {
            var thisinfo = JsonConvert.SerializeObject(new
            {
                LogDateTime = DateTime.Now,
                District = "KentISD",
                Building = "KCTC",
                Student_ID = "12345",
                Student_First_Name = "Joe",
                Student_Last_Name = "No Name",
                Behavior = "Responsibility",
                Behavior_Location = "Hallway",
                Staff_Login_ID = "LFernandez"
        });

            // POST a JSON string

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://goingpro.azurewebsites.net/api/Behavior_Log");
            request.Method = "POST";
            request.ContentType = @"application/json";
            request.Accept = @"application/json";

            var dataStream = new StreamWriter(request.GetRequestStream());

            using (dataStream)
            {
                dataStream.Write(thisinfo);
                dataStream.Flush();
                dataStream.Close();
            }

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (response)
            {
                if (response.StatusCode != HttpStatusCode.Created)
                {
                    LBLResults.Text = "Error fetching data.  Server returned status code " + response.StatusCode;
                }
                else
                {
                    LBLResults.Text = "Log Information Added";
                }
            }

        }
    }

    public class LoginInfo
    {
        public long login_db_id { get; set; }
        public string Distric { get; set; }
        public string Building { get; set; }
        public string Login_ID { get; set; }
        public string Login_Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }

        public LoginInfo(long dbid, string Dis, string bldg, string ID, string PW, string First, string Last, string email)
        {
            this.login_db_id = dbid;
            this.Distric = Dis;
            this.Building = bldg;
            this.Login_ID = ID;
            this.Login_Password = PW;
            this.First_Name = First;
            this.Last_Name = Last;
            this.Email = email;
        }



    }


    public class BehaviorLogInfo
    {
        public long log_db_id { get; set; }
        public DateTime LogDateTime { get; set; }
        public string District { get; set; }
        public string Building { get; set; }
        public string Student_ID { get; set; }
        public string Student_First_Name { get; set; }
        public string Student_Last_Name { get; set; }
        public string Behavior { get; set; }
        public string Behavior_Location { get; set; }
        public string Staff_Login_ID { get; set; }

        public BehaviorLogInfo(long dbid, DateTime dt, string Dist, string bldg, string studid, string First, string Last, string behav, string behavLoc, string staffid)
        {
            this.log_db_id = dbid;
            this.LogDateTime = dt;
            this.District = Dist;
            this.Building = bldg;
            this.Student_ID = studid;
            this.Student_First_Name = First;
            this.Student_Last_Name = Last;
            this.Behavior = behav;
            this.Behavior_Location = behavLoc;
            this.Staff_Login_ID = staffid;
        }
    }


}

