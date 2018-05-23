Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Drawing.Printing
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditControl
    Partial Public Class XtraForm1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("Grimm.docx")
        End Sub

        Private Sub btnPrinterSettings_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_PrinterSettings.ItemClick
'            #Region "#PrinterSettings"
            Dim printerSettings As New PrinterSettings()
            'Set the document pages to print:
            printerSettings.FromPage = 2
            printerSettings.ToPage = 3

            'Specify the number of copies:
            printerSettings.Copies = 2

            'Print the document: 
            richEditControl1.Print(printerSettings)
'            #End Region ' #PrinterSettings
        End Sub

        Private Sub btnPrintDefault_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_PrintDefault.ItemClick
            richEditControl1.Print()
        End Sub
    End Class
End Namespace