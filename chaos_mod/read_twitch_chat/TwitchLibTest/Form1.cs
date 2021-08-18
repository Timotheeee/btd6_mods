using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace TwitchLibTest
{
    public partial class Form1 : Form
    {


        //static string chatFile = @"C:\Program Files (x86)\Steam\steamapps\common\BloonsTD6\twitchchat.txt";
        string chat = "";
        TwitchClient client;
        ConnectionCredentials credentials;
        WebSocketClient customClient;

        public Form1()
        {
            InitializeComponent();
            textBox1.Lines = "btdisab".Split('§');
            textBox2.Lines = "oauth:".Split('§');
            textBox3.Lines = @"C:\Program Files (x86)\Steam\steamapps\common\BloonsTD6\".Split('§');

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(textBox3.Lines[0] + "twitchchat.txt", "");
            } catch
            {
                labelerror.Text = "invalid btd6 directory";
            }
            

            credentials = new ConnectionCredentials(textBox1.Lines[0], textBox2.Lines[0]);//https://twitchapps.com/tmi/
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, textBox1.Lines[0]);


            client.OnMessageReceived += Client_OnMessageReceived;


            client.Connect();
            Console.WriteLine("connected");
            labelerror.Text = "connected";
        }

        
        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            Console.WriteLine("received message:");
            Console.WriteLine(e.ChatMessage.Message);
            chat += e.ChatMessage.Message + "\n";
            //Console.WriteLine(e.ChatMessage.DisplayName);
            try
            {
                File.WriteAllText(textBox3.Lines[0] + "twitchchat.txt", chat);
            } catch
            {

            }
            
        }


    }
}
