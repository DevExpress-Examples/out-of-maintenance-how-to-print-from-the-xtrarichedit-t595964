using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditControl
{
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            richEditControl1.LoadDocument("Grimm.docx");
        }

        private void btnPrinterSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region #PrinterSettings
            PrinterSettings printerSettings = new PrinterSettings();
            //Set the document pages to print:
            printerSettings.FromPage = 2;
            printerSettings.ToPage = 3;

            //Specify the number of copies:
            printerSettings.Copies = 2;

            //Print the document: 
            richEditControl1.Print(printerSettings);
            #endregion #PrinterSettings
        }

        private void btnPrintDefault_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            richEditControl1.Print();
        }
    }
}