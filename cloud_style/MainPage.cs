using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloud_style
{
	public partial class MainPage : Form
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
			//소켓 객체 생성

			IPEndPoint ep = new IPEndPoint(IPAddress.Any,8000);
			socket.Bind(ep);
			// 포트에 바인드 묶기

			socket.Listen(10);
			// 포트 기다리기 시작

			Socket clientSock = socket.Accept();
			// 연결을 받아들여 새 소켓 생성

			byte[] buff = new byte[8192];

			while (!Console.KeyAvailable)  //키를 누르면 종료
			{
				int n = clientSock.Receive(buff);

				string data = Encoding.UTF8.GetString(buff,0,n);
				Console.WriteLine(data);
				//소켓 수신

				clientSock.Send(buff,0,n,SocketFlags.None); 

			}

			clientSock.Close();
			socket.Close();



		}
	}
}
