Namespace WindowsFormsApplication516
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(153, 167)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(139, 40)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Inbox"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(442, 142)
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Inbox"
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(442, 219)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Controls.Add(Me.simpleButton1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace

