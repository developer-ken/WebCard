using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WebCard
{
    public partial class DefaultWindow : Form
    {
        const string ConfigFile = "config.json";
        public static Dictionary<string, CardWindow> Cards = new();
        public DefaultWindow()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void DefaultWindow_Load(object sender, EventArgs e)
        {
            if (File.Exists(ConfigFile))
            {
                JObject jb = JObject.Parse(File.ReadAllText(ConfigFile));
                foreach (var item in jb)
                {
                    try
                    {
                        string uuid = item.Key;
                        string url = item.Value.Value<string>("Url");
                        double opa = item.Value.Value<double>("Opacity");
                        int w = item.Value.Value<int>("Width");
                        int h = item.Value.Value<int>("Height");
                        int x = item.Value.Value<int>("X");
                        int y = item.Value.Value<int>("Y");
                        bool clickth = item.Value.Value<bool>("ClickThrough");
                        FormWindowState state = (FormWindowState)item.Value.Value<int>("WindowState");

                        if (!Screen.AllScreens.CanDisplay(new Rectangle(x, y, w, h)))
                        {
                            x = Screen.PrimaryScreen.WorkingArea.X;
                            y = Screen.PrimaryScreen.WorkingArea.Y;
                        }

                        var card = new CardWindow(url, uuid);
                        card.WindowState = state;
                        card.OnCardClose += OnCardClosed;
                        card.OnConfChanged += Card_OnConfChanged;
                        card.DesiredOpacity = opa;
                        card.IsClickThrough = clickth;
                        card.Opacity = opa;
                        card.Size = new Size(w, h);
                        card.Location = new Point(x, y);
                        Cards.Add(uuid, card);
                        card.Show();
                    }
                    catch
                    {

                    }
                }
            }
            Hide();
        }

        private void Card_OnConfChanged(string obj)
        {
            SaveConfig();
        }

        private void OnCardClosed(string uuid)
        {
            Cards.Remove(uuid);
            SaveConfig();
        }

        public static void SaveConfig()
        {
            JObject jb = new JObject();
            foreach (var card in Cards)
            {
                JObject ijb = new JObject();
                ijb.Add("Url", card.Value.Url);
                ijb.Add("Opacity", card.Value.DesiredOpacity);
                ijb.Add("Width", card.Value.Width);
                ijb.Add("Height", card.Value.Height);
                ijb.Add("X", card.Value.Location.X);
                ijb.Add("Y", card.Value.Location.Y);
                ijb.Add("WindowState", (int)card.Value.WindowState);
                ijb.Add("ClickThrough", card.Value.IsClickThrough);

                jb.Add(card.Key, ijb);
            }
            File.WriteAllText(ConfigFile, jb.ToString());
        }

        private void DefaultWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void 新建卡片CToolStripMenuItem_Click(object sender, EventArgs e) => CreateCard();

        private void CreateCard()
        {
            var card = new CardWindow("https://www.bing.com/", Guid.NewGuid().ToString());
            card.OnCardClose += OnCardClosed;
            card.OnConfChanged += Card_OnConfChanged;
            card.Show();
            card.confcard.Show();
            Cards.Add(card.UUID, card);
            SaveConfig();
        }

        private void 彻底退出QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            SaveConfig();
            Process.GetCurrentProcess().Kill();
        }

        private void 卡片设置OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectNSetting sns = new SelectNSetting();
            sns.Show();
        }

        private void notifybarMenu_Opened(object sender, EventArgs e)
        {
            卡片设置OToolStripMenuItem.Enabled = Cards.Count > 0;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {

                SelectNSetting sns = new SelectNSetting();
                sns.Show();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                CreateCard();
            }
        }
    }
}
