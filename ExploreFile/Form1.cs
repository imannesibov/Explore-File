using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreFile
{
    public partial class Form1 : Form
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        bool isFile = false;
        string currentltSelectedItemName = "";


        public Form1()
        {
            InitializeComponent();
            iconList.ColorDepth = ColorDepth.Depth32Bit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFilesAndDirectories();
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentltSelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);

                }
                else
                {

                    fileAttr = File.GetAttributes(filePath);
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileexplorerview.Items.Add(files[i].Name);
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        fileexplorerview.Items.Add(dirs[i].Name);
                    }
                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();

                    string fileExtention = "";
                    fileexplorerview.Items.Clear();


                    bool check = false;
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtention = files[i].Extension.ToLower().Remove(0, 1);
                        //var Files = Directory.GetFiles(@"C:\Users\NXsi_qew2\Desktop\337920-files\png");
                        check = false;
                        foreach (var item in iconList.Images.Keys)
                        {
                            if (item.Contains(fileExtention))
                            {
                                fileexplorerview.Items.Add(files[i].Name, iconList.Images.IndexOfKey(item));
                                check = true;
                                break;
                            }


                        }
                        if (!check)
                        {
                            fileexplorerview.Items.Add(files[i].Name, 100);
                        }


                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        fileexplorerview.Items.Add(dirs[i].Name, 101);

                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentltSelectedItemName;
                }
            }
            catch (Exception)
            {

            }


        }
        public void loadButtonAction()
        {
            loadFilesAndDirectories();
            isFile = false;
        }


        private void goButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentltSelectedItemName = e.Item.Text;
            FileAttributes fileAttr = new FileAttributes(); ;
            try
            {
                fileAttr = File.GetAttributes(filePath + "/" + currentltSelectedItemName);
            }
            catch (Exception)
            {

            }

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }




        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ListView;
            string name = sender.ToString();
            switch (name)
            {
                case "Small":
                    {
                        fileexplorerview.View = View.SmallIcon;
                        break;
                    }
                case "Large":
                    {
                        fileexplorerview.View = View.LargeIcon;
                        break;
                    }
                case "Tiles":
                    {
                        fileexplorerview.View = View.Tile;
                        break;
                    }
                case "Details":
                    {
                        fileexplorerview.View = View.Details;
                        break;
                    }
                default:
                    break;
            }
        }

        private void fileexplorerview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void fileexplorerview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentltSelectedItemName = e.Item.Text;
            FileAttributes fileAttr = new FileAttributes(); ;
            try
            {
                fileAttr = File.GetAttributes(filePath + "/" + currentltSelectedItemName);
            }
            catch (Exception)
            {

            }

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePath = filePath + "/" + currentltSelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

    }
}
