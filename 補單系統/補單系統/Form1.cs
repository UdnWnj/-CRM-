
using System.Data.SqlClient;
using System.IO;

namespace 補單系統
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string modiFier = TxtmodiFier.Text;
            //string pw = pAssWord.Text;
            string sE001 = TxtsE001.Text;
            string sE007 = TxtsE007.Text;
            string sE008 = TxtsE008.Text;
            string sE006 = TxtsE006.Text;
            string sE020 = TxtsE020.Text;
            string selectedType = cmbType.SelectedItem.ToString();

            //// 驗證 modiFier 和 pw 是否正確
            //if (!ValidateCredentials(modiFier, pw))
            //{
            //    MessageBox.Show("寫入人員或密碼不正確。");
            //    return;
            //}



            // 檢查必填欄位
            if (string.IsNullOrEmpty(modiFier) || string.IsNullOrEmpty(sE001))
            {
                MessageBox.Show("寫入人員、底稿單號，皆為必填。");
                return;
            }
            // 連接字串
            string connectionString = "Data Source=;Initial Catalog=MIS_DOM;User Id=;Password=

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                // 根據下拉選單的選擇執行相應的 SQL 語法
                if (selectedType == "顧問")
                {
                    // 執行顧問的 SQL 語法
                    string sqlConsultant = $"UPDATE MIS_DOM..PROSE SET SE007 = '{sE007}', SE008 = '{sE008}', SE026 = 'Y', MODIFIER = '{modiFier}' WHERE SE001 = '{sE001}' ";
                    if (!string.IsNullOrEmpty(sE006)) 
                    {
                        sqlConsultant += $"AND SE006 = '{sE006}'";
                    }
                    if (!string.IsNullOrEmpty(sE020))
                    {
                        sqlConsultant += $"AND SE020 = '{sE020}'";
                    }

                    string sqlConsultantFK = $"UPDATE MIS_DOM..PROFK SET FK013 = 'Y', MODIFIER = '{modiFier}' WHERE FK015 = '{sE001}' AND (SELECT COUNT(*) FROM MIS_DOM..PROSE WHERE SE001 = FK004  AND ISNULL(SE007, '') = '') = 0";

                    ExecuteSql(connection, sqlConsultant);
                    ExecuteSql(connection, sqlConsultantFK);
                }
                else if (selectedType == "個案")
                {
                    // 執行個案的 SQL 語法
                    string sqlCase = $"UPDATE MIS_DOM..MODSE SET SE007 = '{sE007}', SE008 = '{sE008}', SE026 = 'Y', MODIFIER = '{modiFier}' WHERE SE001 = '{sE001}' AND SE020 = '{sE020}'";
                    if (!string.IsNullOrEmpty(sE006))
                    {
                        sqlCase += $"AND SE006 = '{sE006}'";
                    }
                    if (!string.IsNullOrEmpty(sE020))
                    {
                        sqlCase += $"AND SE020 = '{sE020}'";
                    }


                    string sqlCaseFK = $"UPDATE MIS_DOM..MODFK SET FK009 = 'Y', MODIFIER = '{modiFier}' WHERE FK011 = '{sE001}' AND (SELECT COUNT(*) FROM MIS_DOM..MODSE WHERE SE001 = FK011  AND ISNULL(SE007, '') = '') = 0";

                    ExecuteSql(connection, sqlCase);
                    ExecuteSql(connection, sqlCaseFK);
                }

                connection.Close();
            }

            MessageBox.Show("更改已送出。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private bool ValidateCredentials(string modiFier, string pw)
        //{
        //    // 在此處實現你的密碼驗證邏輯
        //    // 可以比較解密後的密碼（decryptedPW）和提供的密碼（providedPW）
        //    // 這裡僅作示範，實際應用應使用安全的密碼驗證方法




        //    return true;
        //}



        private void ExecuteSql(SqlConnection connection, string sql)
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modiFier = TxtmodiFier.Text;
            string sE001 = TxtsE001.Text;

            // 檢查必填欄位
            if (string.IsNullOrEmpty(modiFier) || string.IsNullOrEmpty(sE001))
            {
                MessageBox.Show("寫入人員、底稿單號，皆為必填。");
                return;
            }

            // 連接字串
            string connectionString = "Data Source=;Initial Catalog=MIS_DOM;User Id=;Password=!@;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 根據下拉選單的選擇執行相應的 SQL 語法
                if (cmbType.SelectedItem != null)
                {
                    string selectedType = cmbType.SelectedItem.ToString();

                    if (selectedType == "顧問")
                    {
                        // 執行顧問的 SQL 語法
                        string sqlConsultantFK = $"UPDATE MIS_DOM..PROFK SET FK013 = 'Y' WHERE FK015 = '{sE001}'";

                        ExecuteSql(connection, sqlConsultantFK);
                    }
                    else if (selectedType == "個案")
                    {
                        // 執行個案的 SQL 語法
                        string sqlCaseFK = $"UPDATE MIS_DOM..MODFK SET FK009 = 'Y' WHERE FK011 = '{sE001}'";

                        ExecuteSql(connection, sqlCaseFK);
                    }
                }

                connection.Close();
            }

            MessageBox.Show("更改已送出。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
