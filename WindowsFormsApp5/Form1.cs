using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        string drive;

        public Form1()
        {
            InitializeComponent();
        }

        private void getDriveInfoButton_Click(object sender, EventArgs e)
        {
            drivesListBox.Items.Clear();
            drivesListBox.Items.Add("====Drives Info====");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (!drive.IsReady) continue;
                drivesListBox.Items.Add(drive + "\t" + drive.TotalSize / 1024.0f / 1024 / 1024 + " GB");
            }
        }

        private void drivesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drivesListBox.SelectedIndex != -1)
            {
                string temp = drivesListBox.SelectedItem.ToString().Substring(0, 3);
                if (Environment.GetLogicalDrives().Contains(temp))
                {
                    drive = temp;
                    listFolders(new DirectoryInfo(drive));
                    pathLabel.Text = drive;
                }
            }
        }

        private void listFolders(DirectoryInfo directoryInfo)
        {
            foldersListBox.Items.Clear();
            DirectoryInfo[] folders = directoryInfo.GetDirectories();
            foreach (DirectoryInfo folder in folders)
            {
                if (folder.Attributes.HasFlag(FileAttributes.Hidden)) continue;
                foldersListBox.Items.Add(folder);
            }
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Attributes.HasFlag(FileAttributes.Hidden)) continue;
                foldersListBox.Items.Add(file);
            }
        }

        private void foldersListBox_DoubleClick(object sender, EventArgs e)
        {
            if (foldersListBox.SelectedIndex != -1)
            {
                string folder = foldersListBox.SelectedItem.ToString();
                if (new DirectoryInfo(pathLabel.Text + folder).Attributes.HasFlag(FileAttributes.Directory))
                {
                    pathLabel.Text = pathLabel.Text + folder + @"\";
                    listFolders(new DirectoryInfo(pathLabel.Text));
                }
                else
                {
                    System.Diagnostics.Process.Start(pathLabel.Text + folder);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (pathLabel.Text != drive && pathLabel.Text != "N/A")
            {
                string location = pathLabel.Text.Substring(0, pathLabel.Text.Length - 1);
                location = location.Substring(0, location.LastIndexOf(@"\") + 1);
                listFolders(new DirectoryInfo(location));
                pathLabel.Text = location;
            }
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(drive) && pathLabel.Text != "N/A")
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox("Enter folder Name", "Creating new folder", "New Folder");
                if (!String.IsNullOrEmpty(name))
                {
                    if (!Directory.Exists(pathLabel.Text + name))
                    {
                        try
                        {
                            Directory.CreateDirectory(pathLabel.Text + name);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        catch (PathTooLongException)
                        {
                            MessageBox.Show("Folder name too long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("FATAL ERROR!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                listFolders(new DirectoryInfo(pathLabel.Text));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (foldersListBox.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure? You will delete: " + pathLabel.Text + foldersListBox.SelectedItem.ToString(), "Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new DirectoryInfo(pathLabel.Text + foldersListBox.SelectedItem).Attributes.HasFlag(FileAttributes.Directory))
                    {
                        Directory.Delete(pathLabel.Text + foldersListBox.SelectedItem, true);
                    }
                    else
                    {
                        File.Delete(pathLabel.Text + foldersListBox.SelectedItem);
                    }
                    listFolders(new DirectoryInfo(pathLabel.Text));
                }
            }
        }

        private void foldersListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                backButton.PerformClick();//spaudziam mygtuka
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (foldersListBox.SelectedIndex != -1)
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox("Enter new folder Name", "Renaming new folder", foldersListBox.SelectedItem.ToString());
                if (!String.IsNullOrEmpty(name))
                {
                    if (new DirectoryInfo(pathLabel.Text + foldersListBox.SelectedItem).Attributes.HasFlag(FileAttributes.Directory))
                    {
                        Directory.Move(pathLabel.Text + foldersListBox.SelectedItem, pathLabel.Text + name);
                    }
                    else
                    {
                        File.Move(pathLabel.Text + foldersListBox.SelectedItem, pathLabel.Text + name);
                       
                    } 
                    listFolders(new DirectoryInfo(pathLabel.Text));
                }
            }

        }
    }
}
