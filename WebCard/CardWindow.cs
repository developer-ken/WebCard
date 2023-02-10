using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace WebCard
{
    public partial class CardWindow : Form
    {
        public Uri Url { get => webview.Source; set => webview.Source = value; }
        public string UUID;
        public event Action<string>? OnCardClose;
        public event Action<string>? OnConfChanged;
        public double DesiredOpacity;
        public bool IsClickThrough
        {
            get => clickthrough;
            set
            {
                WinApi.SetPenetrate(Handle, value, (int)(DesiredOpacity * 100)); clickthrough = value;
            }
        }

        private bool clickthrough;

        Point mouseLocalPoint;
        bool mouseMoveFollow = false;
        bool mouseResizeFollow = false;
        public ConfCardForm confcard = new ConfCardForm();

        public CardWindow(string url, string uuid)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            DesiredOpacity = Opacity;
            UUID = uuid;
            Url = new Uri(url);
            webview.SourceChanged += Webview_SourceChanged;
            webview.CoreWebView2InitializationCompleted += Webview_CoreWebView2InitializationCompleted;
        }

        private void Webview_CoreWebView2InitializationCompleted(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            webview.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
            webview.CoreWebView2.FaviconChanged += CoreWebView2_FaviconChanged;
            webview.CoreWebView2.FrameNavigationStarting += CoreWebView2_FrameNavigationStarting;
            webview.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void CoreWebView2_NewWindowRequested(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
            if (Url.ToString() != e.Uri) Url = new Uri(e.Uri);
        }

        private void CoreWebView2_FrameNavigationStarting(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
        }

        private void CoreWebView2_FaviconChanged(object? sender, object e)
        {
            var faviconpath = webview.CoreWebView2.FaviconUri;
            try
            {
                using (var sm = System.Net.WebRequest.Create(faviconpath).GetResponse().GetResponseStream())
                {
                    MemoryStream ms = new MemoryStream();
                    sm.CopyTo(ms);
                    ms.Seek(0, SeekOrigin.Begin);
                    Icon = new Icon(ms);
                    sm.Close();
                    ms.Close();
                }
            }
            catch { }
        }

        private void CoreWebView2_DocumentTitleChanged(object? sender, object e)
        {
            Text = webview.CoreWebView2.DocumentTitle + " - WebCard";
        }

        private void Webview_SourceChanged(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            confcard.urlbox.Text = Url.ToString();
            OnConfChanged?.Invoke(UUID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            confcard.uuidb.Text = UUID;
            confcard.urlbox.Text = Url.ToString();
            confcard.mopc.Value = (int)(100 - (Opacity * 100));
            confcard.topmost.Checked = TopMost;
            confcard.clickthrough.Checked = IsClickThrough;
            confcard.gobutton.Click += (a, b) =>
            {
                try
                {
                    Url = new Uri(confcard.urlbox.Text);
                }
                catch
                {
                    confcard.urlbox.Text = Url.ToString();
                }
            };
            confcard.mopc.ValueChanged += (a, b) =>
            {
                DesiredOpacity = (100 - confcard.mopc.Value) / 100f;
                Opacity = DesiredOpacity;
            };
            confcard.mopc.MouseLeave += (a, b) =>
            {
                OnConfChanged?.Invoke(UUID);
            };
            confcard.topmost.CheckedChanged += (a, b) =>
            {
                TopMost = confcard.topmost.Checked; OnConfChanged?.Invoke(UUID);
            };
            confcard.clickthrough.CheckedChanged += (a, b) =>
            {
                IsClickThrough = confcard.clickthrough.Checked;
                Opacity = DesiredOpacity; OnConfChanged?.Invoke(UUID);
            };
        }

        private void Minsize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void CardWindow_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void movepannel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocalPoint = PointToClient(Cursor.Position);
            mouseMoveFollow = true;
        }

        private void movepannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMoveFollow)
            {
                Location = Cursor.Position.Minus(mouseLocalPoint);
            }
        }

        private void movepannel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMoveFollow = false;
            OnConfChanged?.Invoke(UUID);
        }

        private void resizePannel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocalPoint = PointToClient(Cursor.Position);
            mouseResizeFollow = true;
        }

        private void resizePannel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseResizeFollow = false;
            OnConfChanged?.Invoke(UUID);
        }

        private void resizePannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseResizeFollow)
            {
                var sizeChange = PointToClient(Cursor.Position).Minus(mouseLocalPoint);
                mouseLocalPoint = PointToClient(Cursor.Position);
                Size += new Size(sizeChange);
            }
        }

        private void movepannel_MouseClick(object sender, MouseEventArgs e)
        {
            confcard.Show();
        }

        private void CardWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            confcard.Close();
            OnCardClose?.Invoke(UUID);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (confcard.Visible && !confcard.ContainsFocus && webview.ContainsFocus)
            {
                confcard.Focus();
            }
        }
    }
}