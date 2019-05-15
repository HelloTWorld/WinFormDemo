using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace WinFormDemo.Data.DataTable
{
    public partial class DataTableForm : Form
    {
        OleDbConnection conn;
        private System.Data.DataTable _dataTable1 = new System.Data.DataTable();        

        public DataTableForm()
        {
            InitializeComponent();
            InitDB();
        }

        /// <summary>
        /// 从数据库加载表格并且赋值到控件的数据源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                DbConnect();
            if (conn.State == ConnectionState.Open)
            {
                string sql = "select * from ywry";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                adp.Fill(_dataTable1);
                dataGridView1.DataSource = _dataTable1;
            }
        }

        #region 连接数据库
        /// <summary>
        /// 初始化连接
        /// </summary>
        private void InitDB()
        {
            string connString = GetAppSettingsKeyValue("conString");
            conn = new OleDbConnection(connString);
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        private void DbConnect()
        {
            while (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    //MessageUtil.ShowError(ex.Message.ToString());
                    DialogResult result = MessageBox.Show(ex.Message.ToString(), "服务器连接失败", MessageBoxButtons.AbortRetryIgnore);
                    if (result == DialogResult.Ignore)
                        break;
                    else if (result == DialogResult.Abort)
                        this.Close();
                }
                finally
                {
                }
            }
        }

        /// <summary>
        /// 断开数据库连接
        /// </summary>
        private void DbDisconnect()
        {
            try
            {
                conn.Close();
                //Console.WriteLine(conn.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //MessageUtil.ShowError(ex.Message.ToString());
            }
            finally
            {
                //conn.Close();
            }
        }
        #endregion

        #region 通用方法
        /// <summary>
        /// 获取配置文件值
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string GetAppSettingsKeyValue(string keyName)
        {
            return ConfigurationManager.AppSettings.Get(keyName);
        }
        #endregion
    }
}
