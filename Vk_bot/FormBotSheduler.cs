using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vk_bot
{
    public partial class FormBotSheduler : Form
    {
        //КЛЮЧ ДОСТУПА СООБЩЕСТВА
        public string access_token;
        public FormBotSheduler()
        {
            InitializeComponent();
        }

        private void FormBotSheduler_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //При вкл. срабаотывает код, если выкл. то не работает
            if (checkBoxBS.Checked)
            {
                timerBotMess.Enabled = true;
                MessageBox.Show("Бот расписание включен!");
            }
            else
            {
                timerBotMess.Enabled = false;
                MessageBox.Show("Бот расписание выключен!");
            }
        }

        private void timerBotMess_Tick(object sender, EventArgs e, string address)
        {

        }

        private void timerBotMess_Tick(object sender, EventArgs e)
        {

            string ApiRequest;
            ApiRequest = "https://api.vk.com/method/messages.getConversations?"
                        + "count=20&"
                        + "filter=all&"
                        + "access_token=" + textBox3.Text + "&"
                        + "&v=5.199";
            WebClient client = new WebClient();
            string Answer = Encoding.UTF8.GetString(client.DownloadData(ApiRequest));

            botSchedule user = JsonConvert.DeserializeObject<botSchedule>(Answer);

            textBox1.Text = user.response.items[0].last_message.peer_id.ToString();

            //textBox3.Text = user.response.items[0].last_message.text;
            //textBox2.Text = textBox3.Text;



            if (user.response.items[0].last_message.text.ToLower().Contains(textBox6.Text.ToLower()))
            {
                string ApiRequest1;
                ApiRequest = "https://api.vk.com/method/messages.send?"
                            + "user_id=" + user.response.items[0].last_message.peer_id.ToString()
                            + "&random_id=0&"
                            + "message=" + textBox7.Text + "&"
                            + "access_token=" + textBox3.Text + "&"
                            + "&v=5.199";
                WebClient client1 = new WebClient();
                string Answer1 = Encoding.UTF8.GetString(client.DownloadData(ApiRequest));

                botSchedule user1 = JsonConvert.DeserializeObject<botSchedule>(Answer);
            }

            if (user.response.items[0].last_message.text.ToLower().Contains(textBox5.Text.ToLower()))
            {
                string ApiRequest1;
                ApiRequest = "https://api.vk.com/method/messages.send?"
                            + "user_id=" + user.response.items[0].last_message.peer_id.ToString()
                            + "&random_id=0&"
                            + "message=" + textBox4.Text + "&"
                            + "access_token=" + textBox3.Text + "&"
                            + "&v=5.199";
                WebClient client1 = new WebClient();
                string Answer1 = Encoding.UTF8.GetString(client.DownloadData(ApiRequest));

                botSchedule user1 = JsonConvert.DeserializeObject<botSchedule>(Answer);
            }


            //textBox1.Text = user.response.items[0].last_message.peer_id;

            if (user.response.items[0].conversation.unanswered == true)
            {
                string ApiRequest1;
                ApiRequest = "https://api.vk.com/method/messages.send?"
                            + "user_id=" + user.response.items[0].last_message.peer_id.ToString()
                            + "&random_id=0&"
                            + "message=" + textBox2.Text + "&"
                            + "access_token=" + textBox3.Text + "&"
                            + "&v=5.199";
                WebClient client1 = new WebClient();
                string Answer1 = Encoding.UTF8.GetString(client.DownloadData(ApiRequest));

                botSchedule user1 = JsonConvert.DeserializeObject<botSchedule>(Answer);
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
