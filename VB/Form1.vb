Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Utils.Internal
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication516

    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private layeredWindow As MyDXLayeredWindow
        Private layeredWindow1 As MyBarDXLayeredWindow
        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            layeredWindow = New MyDXLayeredWindow(simpleButton1, My.Resources.mail_16x16)
            layeredWindow.Show()

            layeredWindow1 = New MyBarDXLayeredWindow(barButtonItem1, My.Resources.mail_16x16)
            layeredWindow1.Show()

        End Sub
    End Class
End Namespace
