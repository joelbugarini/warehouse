using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Xps.Packaging;

namespace WarehouseManager
{
    public class Report
    {
        PrintDialog printDialog = new PrintDialog();
        FixedDocument document = new FixedDocument();
        FixedPage page = new FixedPage();
        PageContent pageContent = new PageContent();

        public Report()
        {
            document.DocumentPaginator.PageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
            page.Width = document.DocumentPaginator.PageSize.Width;
            page.Height = document.DocumentPaginator.PageSize.Height;
        }

        public void Generar(Object data, UserControl Page)
        {
                page.Children.Add(Page);
                                
                ((IAddChild)pageContent).AddChild(page);
                document.Pages.Add(pageContent);
                if (printDialog.ShowDialog() != true) return;
                printDialog.PrintDocument(document.DocumentPaginator, "document");

                Guardar();
        }

        public void Generar(Object data, UserControl headPage, UserControl footPage)
        {
            if (printDialog.ShowDialog() != true)
            {
                page.Children.Add(headPage);
                page.Children.Add(footPage);

                ((IAddChild)pageContent).AddChild(page);
                document.Pages.Add(pageContent);

                printDialog.PrintDocument(document.DocumentPaginator, "Document");
                return;
            }
        }

        public void Generar(Object data, UserControl headPage, List<UserControl> bodyPages, UserControl footPage)
        {
            if (printDialog.ShowDialog() != true)
            {
                page.Children.Add(headPage);
                foreach (UserControl Pagina in bodyPages) 
                {
                    page.Children.Add(Pagina);
                }
                page.Children.Add(footPage);

                ((IAddChild)pageContent).AddChild(page);
                document.Pages.Add(pageContent);

                printDialog.PrintDocument(document.DocumentPaginator, "DOCUMENT");
                return;
            }
        }

        public void Generar(Object data, List<UserControl> bodyPages)
        {
                
                foreach (UserControl Pagina in bodyPages)
                {
                    FixedPage page = new FixedPage();
                    PageContent pageContent = new PageContent();
                    page.Children.Add(Pagina);
                    ((IAddChild)pageContent).AddChild(page);
                    document.Pages.Add(pageContent);
                }

                
                if (printDialog.ShowDialog() != true) return;
                printDialog.PrintDocument(document.DocumentPaginator, "DOCUMENT");
                
            
        }

        public void Guardar()
        {
            // Configure save file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "MyReport"; // Default file name
            dlg.DefaultExt = ".xps"; // Default file extension
            dlg.Filter = "XPS Documents (.xps)|*.xps"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;

                //XpsDocument xpsd = new XpsDocument(filename, FileAccess.ReadWrite);
                //System.Windows.Xps.XpsDocumentWriter xw = XpsDocument.CreateXpsDocumentWriter(xpsd);
                //xw.Write(document);
                //xpsd.Close();
            }
        }
    }
}
