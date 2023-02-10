using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCard
{
    public partial class SelectNSetting : Form
    {
        public SelectNSetting()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Visible)
            {
                Location = Add(Cursor.Position,new Point(-2,-2));
                var cards = GetSelectedCards(Location);
                if (cards.Count == 0)
                {
                    Cursor = Cursors.Cross;
                    notice.Text = "点击想设置的卡片";
                }
                else if (cards.Count > 1)
                {
                    Cursor = Cursors.No;
                    notice.Text = "请选择单张卡片";
                }
                else
                {
                    Cursor = Cursors.Hand;
                    notice.Text = cards.FirstOrDefault().Text;
                }
            }
        }

        private static Point Add(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        private List<CardWindow> GetSelectedCards(Point p)
        {
            List<CardWindow> results = new();
            foreach (var card in DefaultWindow.Cards)
            {
                if (ClientRectangle(card.Value).Contains(p))
                {
                    results.Add(card.Value);
                }
            }
            return results;
        }

        private Rectangle ClientRectangle(Control ctl)
        {
            return new Rectangle(ctl.Location.X,ctl.Location.Y,ctl.Width,ctl.Height);
        }

        private void SelectNSetting_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                this.Close();
                return;
            }
            var cards = GetSelectedCards(Location);
            if (cards.Count == 1)
            {
                cards.First().confcard.Show();
                this.Close();
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Location = Add(Cursor.Position, new Point(-2, -2));
            var cards = GetSelectedCards(Cursor.Position);
            if (cards.Count == 0) Cursor = Cursors.Cross;
            else if (cards.Count > 1) Cursor = Cursors.No;
            else Cursor = Cursors.Hand;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Location = Add(Cursor.Position, new Point(-2, -2));
            var cards = GetSelectedCards(Cursor.Position);
            if (cards.Count == 0) Cursor = Cursors.Cross;
            else if (cards.Count > 1) Cursor = Cursors.No;
            else Cursor = Cursors.Hand;
        }
    }
}
