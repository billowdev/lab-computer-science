using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Week5
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        string[,] arrayName = new string[,] { {"63102105101","อุราระกะโอชาโก"}, {"63102105102","มิโดริยะอิสึคุ"}, {"63102105103","อิจิโกะ"},{"63102105104","ฮิบิกิ"},
                                            {"63102105105","ฮินาตะเฮียวกะ"},{"63102105106", "ซากุระฮารุโนะ"},{"63102105107","อากิฮิโระ"},{"63102105108","ฮายาโตะ"},{"63102105109","ฮารุโตะ"},
                                            {"63102105110","ฮารุโอ"},{"63102105111","ฮารุกิ"},{"63102105112","ริคุโอะ"},
                                            {"63102105113","ฮิโรกิ"},{"63102105114", "คัตสึโร่"},{"63102105115","คาซึฮิโระ"},{"63102105116","คาซึโอะ"},{"63102105117","มาซาชิ"},
                                            {"63102105118","เรียว"},{"63102105119","ทาดาโอะ"},{"63102105120","ทาดาชิ"},
                                            {"63102105121","โยชิโนริ"},{"63102105122","อาเคมิ"},{"63102105123","ชิฮารุ"},
                                            {"63102105124","โยชิโระ"},{"63102105125","อากิโกะ"},{"63102105126","โฮโนกะ"},
                                            {"63102105127","โยชิโอะ"},{"63102105128","อายาโกะ"},{"63102105129","โฮชิ"},
                                            {"63102105130","ยูอิจิ"},{"63102105131","อายะโนะ"},
                                            {"63102105132","อากิฮิโระ"},{"63102105133","สึบากิ"},{"63102105134","มากิ"},
                                            {"63102105135","ไดสุเกะ"},{"63102105136","คากาชิ"},{"63102105137","มิโดริ"},{"63102105138","ซาสึเกะ"},
                                            {"63102105139","ฮาชิโระ"},{"63102105140","ฮาจิม"},
                                            {"63102105141","ฮารุกิ"},{"63102105142","ชิซึโกะ"} };

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //int intArrayID;
                string strID = Convert.ToString(txtStudentID.Text[9]);
                string strValue = Convert.ToString(txtStudentID.Text[10]);
                int intValue = Convert.ToInt32(strValue);

                if (strID == "0")
                {
                    txtName.Text = ((txtStudentID.Text == arrayName[intValue - 1, 0] ? arrayName[intValue - 1, 1] : ""));
                    labelResult.Text = ("นักศึกษาที่ค้นพบ " + arrayName[intValue - 1, 0] + " " + arrayName[intValue - 1, 1]);
                }
                else if (strID == "1")
                {
                    string newValue = strID + strValue;
                    intValue = Convert.ToInt32(newValue);
                    txtName.Text = ((txtStudentID.Text == arrayName[intValue - 1, 0] ? arrayName[intValue - 1, 1] : ""));
                    labelResult.Text = ("นักศึกษาที่ค้นพบ "+arrayName[intValue - 1, 0] + " " + arrayName[intValue - 1, 1]);
                }
                else if (strID == "2")
                {
                    string newValue = strID + strValue;
                    intValue = Convert.ToInt32(newValue);
                    txtName.Text = ((txtStudentID.Text == arrayName[intValue - 1, 0] ? arrayName[intValue - 1, 1] : ""));
                    labelResult.Text = ("นักศึกษาที่ค้นพบ " + arrayName[intValue - 1, 0] + " " + arrayName[intValue - 1, 1]);
                }
                else if (strID == "3")
                {
                    string newValue = strID + strValue;
                    intValue = Convert.ToInt32(newValue);
                    txtName.Text = ((txtStudentID.Text == arrayName[intValue - 1, 0] ? arrayName[intValue - 1, 1] : ""));
                    labelResult.Text = ("นักศึกษาที่ค้นพบ " + arrayName[intValue - 1, 0] + " " + arrayName[intValue - 1, 1]);
                }
                else
                {
                    string newValue = strID + strValue;
                    intValue = Convert.ToInt32(newValue);
                    txtName.Text = ((txtStudentID.Text == arrayName[intValue - 1, 0] ? arrayName[intValue - 1, 1] : ""));
                    labelResult.Text = ("นักศึกษาที่ค้นพบ " + arrayName[intValue - 1, 0] + " " + arrayName[intValue - 1, 1]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("กรอกรหัสนักศึกษาไม่ถูกต้อง!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกเพียงแค่รหัสนักศึกษา", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
