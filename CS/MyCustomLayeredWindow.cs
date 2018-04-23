using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Internal;
using DevExpress.XtraBars;

namespace WindowsFormsApplication516 {
    class MyDXLayeredWindow : DXLayeredWindowEx {
        Form parent;
        Control ownerControl;
        Image image;
        public MyDXLayeredWindow(Control ownerControl, Image image) {
            this.image = image;
            parent = ownerControl.FindForm();
            this.ownerControl = ownerControl;
            base.Create(parent);
            this.Size = this.image.Size;
            parent.LocationChanged += parent_LocationChanged;
        }

        void parent_LocationChanged(object sender, EventArgs e) {
            Show();
        }
        public void Show() {
            Point p = parent.PointToScreen(ownerControl.Location);
            p.Offset(ownerControl.Width - DrawRect.Width / 2, DrawRect.Height / -2);
            base.Show(p);
            base.Update();
        }
        protected Rectangle DrawRect {
            get {
                Rectangle r = new Rectangle(Point.Empty, Size);
                return r;
            }
        }
        protected override IntPtr hWndInsertAfter {
            get {
                return new IntPtr(0);
            }
        }
        protected override void DrawCore(DevExpress.Utils.Drawing.GraphicsCache cache) {
            cache.Graphics.Clear(Color.Transparent);
            cache.Graphics.DrawImage(image, DrawRect);
        }
    }
    class MyBarDXLayeredWindow : DXLayeredWindowEx {
        Form parent;
        BarItem owner;
        Image image;
        public MyBarDXLayeredWindow(BarItem owner, Image image) {
            this.image = image;
            parent = owner.Manager.Form.FindForm();
            this.owner = owner;
            base.Create(parent);
            this.Size = this.image.Size;
            parent.LocationChanged += parent_LocationChanged;
        }

        void parent_LocationChanged(object sender, EventArgs e) {
            Show();
        }
        public void Show() {
            Point p = parent.PointToScreen(parent.PointToClient(owner.Links[0].ScreenBounds.Location));
            p.Offset(owner.Links[0].Bounds.Width - (DrawRect.Width / 2), DrawRect.Height / -2);
            base.Show(p);
            base.Update();
        }
        protected override IntPtr hWndInsertAfter {
            get {
                return new IntPtr(0);
            }
        }
        protected Rectangle DrawRect {
            get {
                Rectangle r = new Rectangle(Point.Empty, Size);
                return r;
            }
        }
        protected override void DrawCore(DevExpress.Utils.Drawing.GraphicsCache cache) {
            cache.Graphics.Clear(Color.Transparent);
            cache.Graphics.DrawImage(image, DrawRect);
        }
    }
}
