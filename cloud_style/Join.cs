using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace cloud_style
{
	public partial class Join : Form
	{
		Login login = new Login();

		public Join()
		{
			InitializeComponent();
		}


		Login.CUBRID_connection CUBconn;

		private void Join_Load(object sender, EventArgs e)
		{
			CUBconn.Equals(login);

			try
			{
				CUBconn.xmlConfig = new XmlDocument();
				CUBconn.xmlConfig.Load(Application.StartupPath + "/CUBRID_CONN.xml"); // 큐브리드를 연결할 xml 파일을 가져옴.
				XmlNode dbConnectString = CUBconn.xmlConfig.SelectSingleNode("/DB_Connect");
				CUBconn.dbConnectString = dbConnectString.InnerText;


			}
			catch (Exception)
			{

				throw;
			}

		}

		private void DB_Connect()
		{
			try
			{
				if (!CUBconn.dbOpenState)
				{
					CUBconn.dbConn = new OdbcConnection(CUBconn.dbConnectString);    // db오픈이 안되어있으면 새로 연결할 커넥션을 만들어서 () 괄호안에 연결할 string을 넣어준다.
					CUBconn.dbConn.Open();
					CUBconn.dbOpenState = true;

					if (CUBconn.dbConn.State == ConnectionState.Closed) //
					{
						return;
					}
				}
			}
			catch (OdbcException)
			{
				throw;
			}
			catch (Exception)
			{

				throw;

			}
			finally { CUBconn.dbConn.Close(); }

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DB_Connect();
			string uNAME = textBox1.Text;
			string uID = textBox2.Text;
			string uPW = textBox3.Text;
			string sql = "INSERT INTO socket (name,id,pw) VALUES (?,?,?);";

			using (var con = new OdbcConnection(CUBconn.dbConnectString))
			{
				try
				{
					con.Open();

					using (var cmd = new OdbcCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@name", uNAME);
						cmd.Parameters.AddWithValue("@id", uID);
						cmd.Parameters.AddWithValue("@pw", uPW);

						cmd.ExecuteNonQuery();
						MessageBox.Show("회원가입을 축하드립니다!");
						this.Close();
					}
					login.Show();
				}
				catch (Exception)
				{

					throw;
				}
			}
		}
	}



}
