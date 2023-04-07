using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Xml;

namespace cloud_style
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();

		}

		public struct CUBRID_connection //서버 연결할 데이터 설정하기
		{
			public XmlDocument xmlConfig;
			public string dbConnectString;
			public OdbcConnection dbConn;
			public bool dbOpenState;

		}

		public CUBRID_connection CUBconn = new CUBRID_connection();

		private void Form1_Load(object sender, EventArgs e)
		{
			//DB랑 연동 해야해
			// 큐브리드랑 연결할 xml 셋팅 메서드를 만들고 호출한다. 거기에 struct CUBRID_Connection의 객체를 넣어주는거야.

			{
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
			string uID = textBox1.Text;
			string uPW = textBox2.Text;
			string sql = "select * from socket Where id=? and pw=?;";

			using (var con = new OdbcConnection(CUBconn.dbConnectString))
			{
				try
				{
					con.Open();

					using (var cmd = new OdbcCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@id", uID);
						//cmd.Parameters[0].Value = uPW;
						cmd.Parameters.AddWithValue("@pw", uPW);



						using (OdbcDataReader reader = cmd.ExecuteReader())
						{

							while (reader.Read())
							{
								Console.WriteLine(reader.GetString(0));
								MessageBox.Show(reader.GetString(0) + "님 로그인 되었습니다.");
								Console.WriteLine(reader.GetString(1));
							}
							reader.Close();
						}

						DataSet ds = new DataSet();     //데이터 저장
						MainPage form2 = new MainPage();      //새로운 윈도우 폼
						OdbcDataAdapter adapter = new OdbcDataAdapter(); // Odbc 데이터 어댑터

						try
						{
							cmd.Connection = con;

							if (CUBconn.dbOpenState)   //만약 true면
							{
								adapter.SelectCommand = cmd;
								con.Close();      //연결은 끊고
								adapter.Fill(ds); //adapter에게 채운다.

								adapter.DeleteCommand = cmd;

								if (ds.Tables.Count != 0)      // 접속했는데 테이블의 수가 0이 아니면
								{
									if (ds.Tables[0].Rows.Count > 0)  //
									{

										Console.WriteLine("로그인 되었습니다.");
										form2.Show();
										Hide();

									}
									else
									{
										MessageBox.Show("아이디와 비밀번호를 확인하세요");
										return;
									}


								}
								else if (ds.Tables.Count == 0)
								{
									MessageBox.Show("회원가입을 해주세요");
									Close();
									Join join = new Join();
									join.Show();
								}

							}
							else
							{
								MessageBox.Show("연결을 확인하세요");
							}
						}
						catch (OdbcException)
						{
							MessageBox.Show("연결을 확인해주세요");
						}
						catch (Exception)
						{

							throw;
						}


					}
				}
				catch (Exception)
				{

					throw;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

			DialogResult result = MessageBox.Show("회원가입 하시겠습니까?", "회원가입", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			//MessageBox.Show("회원가입 하시겠습니까?","회원가입",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
			Join join = new Join();
			
			if (result == DialogResult.Yes)
			{
			join.Show();
			Hide();

			}else if (result == DialogResult.No)
			{
				return;
			}else if (result == DialogResult.Cancel) {
				return;
			}
			else
			{
				return;
			}
		}
	}

}
