using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Acct
{
    public class GradientPanel : Panel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var brush = new LinearGradientBrush(this.ClientRectangle,
                    Color.Gray, Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
