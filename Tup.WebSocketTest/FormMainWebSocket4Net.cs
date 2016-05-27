using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Newtonsoft.Json;
using Tup.Utilities;
using WebSocket4Net;

namespace Tup.WebSocketTest
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMainWebSocket4Net : Form
    {
        public FormMainWebSocket4Net()
        {
            InitializeComponent();
        }

        private WebSocket m_WebSocketClient = null;
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="senderx"></param>
        /// <param name="ex"></param>
        private void buttonConnent_Click(object senderx, EventArgs ex)
        {
            Disconnect();

            var path = string.Format(this.textBoxWSUrlFormat.Text, this.textBoxServer.Text, this.textBoxPort.Text);
            var cookies = ParseHeaders(this.textBoxCookie.Text);
            var customHeaderItems = ParseHeaders(this.textBoxQDHeader.Text);

            m_WebSocketClient = new WebSocket(path, "", cookies, customHeaderItems, null, null, WebSocketVersion.Rfc6455);

            m_WebSocketClient.Error += (sender, e) =>
            {
                LogHelper.Debug("--------------------Error-----------------------e:{0}", e);
                Console.WriteLine("--------------------Error-----------------------e:{0}", e);
            };

            m_WebSocketClient.Opened += (sender, e) =>
            {
                SetConnectStatus(true);
            };
            m_WebSocketClient.Closed += (sender, e) =>
            {
                LogHelper.Debug("--------------------Closed-----------------------e:{0}", e);
                Console.WriteLine("Connection closed. ");
                SetConnectStatus(false);
            };
            m_WebSocketClient.MessageReceived += OnReceive;

            ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    m_WebSocketClient.Open();
                }
                catch (Exception exx)
                {
                    Console.WriteLine(exx);
                }
            });
        }

        /// <summary>
        /// Event fired when a data is received from the Alchemy Websockets server instance.
        /// Parses data as JSON and calls the appropriate message or sends an error message.
        /// </summary>
        /// <param name="sender">The user's connection context</param>
        private void OnReceive(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine("---------------------Received Data-----------------------");

            try
            {
                Console.WriteLine("Received Data json :" + e.Message);

                this.Invoke(() =>
                {
                    this.textBoxOutput.Text = e.Message;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("OnReceive-Exception-ex:{0}", ex);
            }
        }

        /// <summary>
        /// 批量连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRepeatConnect_Click(object sender, EventArgs e)
        {
            var rCount = this.textBoxRepeatCount.Text;
            var repeatCount = 0;
            if (!int.TryParse(rCount, out repeatCount) || repeatCount <= 0)
                return;

            this.progressBarConnect.Minimum = 0;
            this.progressBarConnect.Maximum = repeatCount;

            var path = string.Format(this.textBoxWSUrlFormat.Text, this.textBoxServer.Text, this.textBoxPort.Text);
            var cookies = ParseHeaders(this.textBoxCookie.Text);
            var customHeaderItems = ParseHeaders(this.textBoxQDHeader.Text);
            ThreadPool.QueueUserWorkItem(_ =>
            {
                for (int i = 0; i < repeatCount; i++)
                {
                    CreateWebSocketClient(repeatCount, path, i, cookies, customHeaderItems);

                    Thread.Sleep(1);
                }
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repeatCount"></param>
        /// <param name="path"></param>
        /// <param name="i"></param>
        private void CreateWebSocketClient(int repeatCount, string path, int index,
            List<KeyValuePair<string, string>> cookies, List<KeyValuePair<string, string>> customHeaderItems)
        {
            WebSocket webSocketClient = new WebSocket(path, "",
                cookies, customHeaderItems, null, null, WebSocketVersion.Rfc6455);
            webSocketClient.Error += (sender, e) =>
            {
                LogHelper.Debug("--------------------Error-----------------------e:{0}", e);
                Console.WriteLine("--------------------Error-----------------------e:{0}", e);
            };

            webSocketClient.Opened += (sender, e) =>
            {
                SetConnectStatus(true, repeatCount);
            };
            webSocketClient.Closed += (sender, e) =>
            {
                LogHelper.Debug("--------------------Closed-----==------------------e:{0}", e);
                Console.WriteLine("--------------------Closed----==-------------------e:{0}", e);
                SetConnectStatus(false);
            };
            webSocketClient.MessageReceived += (sender, e) =>
            {
                LogHelper.Debug("--------------------RepeatConnect------------------------");
                LogHelper.Debug("Received Data From :{0}", e.Message);
                Console.WriteLine("Received Data From :{0}", e.Message);
            };
            try
            {
                webSocketClient.Open();
                LogHelper.Debug("__RepeatConnect-WebSocketClient-Connect_:{0}", index);
                Console.WriteLine("__RepeatConnect-WebSocketClient-Connect_:{0}", index);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            var message = this.textBoxMsg.Text;
            if (string.IsNullOrEmpty(message))
                return;

            this.SendMessage(message);
        }

        /// <summary>
        /// 连接状态
        /// </summary>
        private void SetConnectStatus(bool isConnect, int progressValue = 0)
        {
            this.Invoke(() =>
            {
                if (isConnect)
                {
                    this.labelConnectStatus.Text = "OnLine";
                    this.labelConnectStatus.BackColor = Color.Green;

                    this.panelConnect.Enabled = false;
                    this.panelSend.Enabled = true;
                    this.buttonDisconnect.Enabled = true;

                    this.progressBarConnect.Value = progressValue;
                }
                else
                {
                    this.labelConnectStatus.Text = "OffLine";
                    this.labelConnectStatus.BackColor = Color.IndianRed;
                    this.labelRegisterName.Text = string.Empty;

                    this.panelConnect.Enabled = true;
                    this.panelSend.Enabled = false;
                    this.buttonDisconnect.Enabled = false;
                }
            });
        }

        /// <summary>
        /// 解析 HTTP Header
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        private static List<KeyValuePair<string, string>> ParseHeaders(string txt)
        {
            var list = new List<KeyValuePair<string, string>>();
            if (string.IsNullOrEmpty(txt))
                return list;

            var aList = txt.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (aList.Length <= 0)
                return list;

            foreach (var item in aList)
            {
                var aItem = item.Split(':');
                if (aItem.Length != 2)
                {
                    Console.WriteLine("ParseHeaders-error:{0}", item);
                    continue;
                }

                list.Add(new KeyValuePair<string, string>(aItem[0], aItem[1]));
            }

            return list;
        }
        /// <summary>
        /// BeginInvoke
        /// </summary>
        /// <param name="action"></param>
        private void Invoke(Action action)
        {
            if (action != null)
                base.BeginInvoke(action);
        }
        /// <summary>
        /// Send Message
        /// </summary>
        /// <param name="data"></param>
        private void SendMessage(string data)
        {
            if (data == null)
                return;
            if (m_WebSocketClient == null)
                Disconnect();

            ThreadPool.QueueUserWorkItem(_ =>
            {
                try
                {
                    this.m_WebSocketClient.Send(data as string);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });
        }
        /// <summary>
        /// 断开链接
        /// </summary>
        private void Disconnect()
        {
            if (m_WebSocketClient != null)
            {
                try
                {
                    ThreadPool.QueueUserWorkItem(_ =>
                    {
                        m_WebSocketClient.Close();
                        m_WebSocketClient = null;

                        this.SetConnectStatus(false);
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
                this.SetConnectStatus(false);
        }
    }
}
