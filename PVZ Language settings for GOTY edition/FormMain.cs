using Microsoft.Win32;
using PVZ_Language_settings.Properties;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PVZ_Language_settings
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Charge la police d'ecriture.
            byte[] data = Resources.font;
            using (PrivateFontCollection collection = new PrivateFontCollection())
            {
                IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(data, 0);
                collection.AddMemoryFont(buffer, data.Length);
                Font current = this.Font;
                this.Font = new Font(collection.Families[0], current.Size, current.Style);
            }

            // Adapte la taille de la form en fonction de l'image de fond.
            Image? back = this.BackgroundImage;
            if (back != null)
            {
                Size client = this.ClientSize;
                Size adapted = new Size(
                    (this.Width - client.Width) + back.Width,
                    (this.Height - client.Height) + back.Height);
                this.Size = adapted;
            }

            // Pre-place le logo hors ecran.
            PictureBox logo = this.pictureBoxLogo;
            logo.Location = new Point(logo.Location.X, -logo.Height);

            // Change le label avec la version.
            string? version = FileVersionInfo.GetVersionInfo(
                Assembly.GetExecutingAssembly().Location).FileVersion;
            this.labelVersion.Text = $"Version {version}";
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            // Demarre la musique.
            (new SoundPlayer(Resources.music)).PlayLooping();
            this.timerLogo.Start();
        }

        private void timerLogo_Tick(object sender, EventArgs e)
        {
            // Anime le logo.
            PictureBox logo = this.pictureBoxLogo;
            Point coord = logo.Location;
            int marg = this.Padding.Top;

            if (coord.Y < marg)
            {
                // Deplace le logo.
                logo.Location = new Point(coord.X, coord.Y + 4);
            }
            else
            {
                // Definit la taille finale et arrete l'animation.
                logo.Location = new Point(coord.X, marg);
                this.timerLogo.Stop();
            }
        }

        private void linkLabelThanks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ouvre le site de celui qui a fait les fichiers de traduction.
            this.OpenUrl("http://shaklin.com");
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ouvre mon depot GitHub.
            this.OpenUrl("https://github.com/TheRake66");
        }

        private void buttonEn_Click(object sender, EventArgs e)
        {
            // Change la langue en anglais.
            this.ChangeLanguage(Resources.main_en);
        }

        private void buttonDe_Click(object sender, EventArgs e)
        {
            // Change la langue en allemand.
            this.ChangeLanguage(Resources.main_de);
        }

        private void buttonFr_Click(object sender, EventArgs e)
        {
            // Change la langue en francais.
            this.ChangeLanguage(Resources.main_fr);
        }

        private void buttonEs_Click(object sender, EventArgs e)
        {
            // Change la langue en espagnol.
            this.ChangeLanguage(Resources.main_es);
        }

        private void buttonIt_Click(object sender, EventArgs e)
        {
            // Change la langue en italien.
            this.ChangeLanguage(Resources.main_it);
        }

        private void OpenUrl(string url)
        {
            try
            {
                // Ouvre l'URL depuis le shell.
                (new Process()
                {
                    StartInfo = new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        FileName = url
                    }
                }).Start();
            }
            catch { }
        }

        private void ChangeLanguage(byte[] ressource)
        {
            // Demande ou est le dossier du jeu.
            using (FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "Choose the game installation folder (where the PlantsVsZombies.exe file is located).",
                UseDescriptionForTitle = true
            })
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        try
                        {
                            // Decompresse le fichier ZIP en ressource dans le dossier du jeu.
                            string zip = Path.Combine(path, "tmp.zip");
                            File.WriteAllBytes(zip, ressource);
                            ZipFile.ExtractToDirectory(zip, path, true);
                            File.Delete(zip);

                            // Message de fin.
                            MessageBox.Show("The language has been changed.", this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch (Exception error)
                        {
                            // Message d'erreur.
                            MessageBox.Show(error.Message, this.Text,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
        }
    }
}