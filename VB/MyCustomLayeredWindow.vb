Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Utils.Internal
Imports DevExpress.XtraBars

Namespace WindowsFormsApplication516
    Friend Class MyDXLayeredWindow
        Inherits DXLayeredWindowEx

        Private parent As Form
        Private ownerControl As Control
        Private image As Image
        Public Sub New(ByVal ownerControl As Control, ByVal image As Image)
            Me.image = image
            parent = ownerControl.FindForm()
            Me.ownerControl = ownerControl
            MyBase.Create(parent)
            Me.Size = Me.image.Size
            AddHandler parent.LocationChanged, AddressOf parent_LocationChanged
        End Sub

        Private Sub parent_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            Show()
        End Sub
        Public Sub Show()
            Dim p As Point = parent.PointToScreen(ownerControl.Location)
            p.Offset(ownerControl.Width - DrawRect.Width \ 2, DrawRect.Height \ -2)
            MyBase.Show(p)
            MyBase.Update()
        End Sub
        Protected ReadOnly Property DrawRect() As Rectangle
            Get
                Dim r As New Rectangle(Point.Empty, Size)
                Return r
            End Get
        End Property
        Protected Overrides ReadOnly Property hWndInsertAfter() As IntPtr
            Get
                Return New IntPtr(0)
            End Get
        End Property
        Protected Overrides Sub DrawCore(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache)
            cache.Graphics.Clear(Color.Transparent)
            cache.Graphics.DrawImage(image, DrawRect)
        End Sub
    End Class
    Friend Class MyBarDXLayeredWindow
        Inherits DXLayeredWindowEx

        Private parent As Form
        Private owner As BarItem
        Private image As Image
        Public Sub New(ByVal owner As BarItem, ByVal image As Image)
            Me.image = image
            parent = owner.Manager.Form.FindForm()
            Me.owner = owner
            MyBase.Create(parent)
            Me.Size = Me.image.Size
            AddHandler parent.LocationChanged, AddressOf parent_LocationChanged
        End Sub

        Private Sub parent_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            Show()
        End Sub
        Public Sub Show()
            Dim p As Point = parent.PointToScreen(parent.PointToClient(owner.Links(0).ScreenBounds.Location))
            p.Offset(owner.Links(0).Bounds.Width - (DrawRect.Width \ 2), DrawRect.Height \ -2)
            MyBase.Show(p)
            MyBase.Update()
        End Sub
        Protected Overrides ReadOnly Property hWndInsertAfter() As IntPtr
            Get
                Return New IntPtr(0)
            End Get
        End Property
        Protected ReadOnly Property DrawRect() As Rectangle
            Get
                Dim r As New Rectangle(Point.Empty, Size)
                Return r
            End Get
        End Property
        Protected Overrides Sub DrawCore(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache)
            cache.Graphics.Clear(Color.Transparent)
            cache.Graphics.DrawImage(image, DrawRect)
        End Sub
    End Class
End Namespace
