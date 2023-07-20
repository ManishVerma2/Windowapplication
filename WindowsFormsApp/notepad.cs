using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class notepad : Form
    {
        public notepad()
        {
            InitializeComponent();
        }
        string txt = "";
        private void menufile_click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi=(ToolStripMenuItem)sender;
            int tag=Convert.ToInt32(mi.Tag);
            if(tag==1)
            {
                if(rtbox.Text.Length>0)
                {
                    DialogResult dr = MessageBox.Show("Do you want to save the change", "Save Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(dr==DialogResult.OK)
                    {
                        saveFileDialog1.Filter = "All text files(*.txt)|*.txt|All rich text files(*.rtf)|*.rft";
                        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            rtbox.SaveFile(saveFileDialog1.FileName);
                            //string filepath = saveFileDialog1.FileName;
                            //File.WriteAllText(filepath,rtbox.Text);
                        }
                    }
                    else if(dr==DialogResult.Cancel)
                    {
                        MessageBox.Show("Unsave the project");
                    }
                }
                else
                {
                    MessageBox.Show("Nothing to Save");
                }
                rtbox.Text = "";
            }

            else if(tag==2)
            {
                openFileDialog1.Filter = "All text Files(*.txt)|*.txt|All rich text file(*.rft)|*.rft";
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    rtbox.LoadFile(openFileDialog1.FileName);
                }

            }

            else if(tag==3)
            {
                if(rtbox.Text.Length>0)
                { 
                    saveFileDialog1.Filter = "All text files(*.txt)|*.txt|All rich text files(*.rtf)|*.rft";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        rtbox.SaveFile(saveFileDialog1.FileName);          
                        //string filepath = saveFileDialog1.FileName;
                        //File.WriteAllText(filepath, rtbox.Text);
                    }
                    rtbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Nothing to Save");
                }
            }

            else if (tag == 4)
            {
                if (rtbox.Text.Length > 0)
                {
                    saveFileDialog1.Filter = "All text files(*.txt)|*.txt|All rich text files(*.rtf)|*.rft";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        rtbox.SaveFile(saveFileDialog1.FileName);
                        //string filepath = saveFileDialog1.FileName;
                        //File.WriteAllText(filepath, rtbox.Text);
                    }
                    rtbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Nothing to Save");
                }
            }
            else if(tag == 5)
            {
                PrinterSettings printersetting = new PrinterSettings();
                printersetting.Copies = 1;
                PageSettings pagesetting = new PageSettings();
                pagesetting.PrinterSettings = printersetting;
                pageSetupDialog1.PageSettings = pagesetting;
                pageSetupDialog1.ShowDialog();
            }
            else if(tag == 6)
            {
                printDialog1.ShowDialog();
            }
            else if(tag == 7)
            {
                this.Close();
            }
            else if(tag==8)
            {
                rtbox.Undo();
            }
            else if(tag == 9)
            {
                rtbox.Redo();
            }
            else if(tag == 10)
            {
                txt = rtbox.SelectedText;
                rtbox.SelectedText = "";
            }
            else if(tag == 11)
            {
                txt = rtbox.SelectedText;
            }
            else if(tag == 12)
            {
                rtbox.SelectedText = txt;
            }
            else if(tag == 13)
            {
                rtbox.SelectAll();
            }
            else if(tag == 14)
            {
                rtbox.SelectedText = txt;
                txt.Remove(0, txt.Length);
                txt = "";
            }
        }
    }
}
