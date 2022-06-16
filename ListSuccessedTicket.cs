using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;

namespace TungMovie
{
	public partial class ListSuccessedTicket : Form
	{
		public ListSuccessedTicket()
		{
			InitializeComponent();
		}

		Ticket Tick = new Ticket();

		public void LoadDataGrid()
		{
            gridBookedTicket.AutoResizeColumns();
            gridBookedTicket.DataSource = Tick.getTicketListByUsername(UserStore.StoreUsername);
            gridBookedTicket.BackgroundColor = Color.White;
            gridBookedTicket.RowHeadersVisible = false;
        }

		private void ListSuccessedTicket_Load(object sender, EventArgs e)
		{
            LoadDataGrid();
		}



		private void btnPrint_Click_1(object sender, EventArgs e)
		{
            try
            {
                //Save location 
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = ".docx";
                saveFileDialog1.Filter = "Word|*.docx";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.InitialDirectory = @"C:\Desktop";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    object filename = saveFileDialog1.FileName;
                    //Create an instance for word  
                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                    //Set animation status for word application  
                    winword.ShowAnimation = false;

                    //Set status for word application is to be visible or not.  
                    winword.Visible = false;

                    //Create a missing variable for missing value  
                    object missing = System.Reflection.Missing.Value;

                    //Create a new document  
                    Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);


                    Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(missing);
                    para1.Range.InsertParagraph();
                    object styleHeading1 = "Title";
                    object styleHeading2 = "Normal";

                    para1.Range.set_Style(ref styleHeading1);
                    para1.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    para1.Range.Font.Color = WdColor.wdColorAqua;
                    para1.Range.Text = "Purchased Ticket\n\n";

                    para1.Range.set_Style(ref styleHeading2);
                    para1.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    para1.Range.Font.Color = WdColor.wdColorBlack;
                    para1.Range.Text = "Username: " + UserStore.StoreUsername.ToString() +"\n";
                    para1.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                    int rows = gridBookedTicket.Rows.Count;
                    int columns = gridBookedTicket.Columns.Count;

                    Microsoft.Office.Interop.Word.Paragraph para3 = document.Content.Paragraphs.Add(ref missing);
                    Table T = document.Tables.Add(para3.Range, rows, columns, ref missing, ref missing);

                    T.Borders.Enable = 1;

                    //Insert
                    for (int i = 1; i < T.Rows.Count; i++)
                    {
                        for (int j = 1; j < T.Columns.Count + 1; j++)
                        {
                            //Header 
                            T.Rows[1].Cells[j].Range.Text = gridBookedTicket.Columns[j - 1].HeaderText.ToString();
                            T.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            T.Rows[1].Cells[j].Range.Font.Size = 9;
                            T.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            T.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            T.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            T.Rows[i + 1].Cells[j].Range.Text = gridBookedTicket.Rows[i - 1].Cells[j - 1].Value.ToString();
                        }
                    }
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;
                    MessageBox.Show("Document created successfully !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
	}
}
