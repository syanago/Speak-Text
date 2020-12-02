using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using NAudio.Wave;
using NAudio.Lame;
using System.Collections.ObjectModel;
using System.Speech.AudioFormat;
namespace Speak_Text
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synthesizer;
        string fileName, dirName, sonoText, sonoName, choosedVoice;
        

        Excel.Application excel;
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            play.Enabled = true;
            pause.Enabled = false;
            resume.Enabled = false;
            stop.Enabled = false;
            synthesizer = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                VoiceInfo info = voice.VoiceInfo;
                cmbVoix.Items.Add(info.Name);
            }

        }
       

        private void CmbVoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            choosedVoice = cmbVoix.SelectedItem.ToString();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (textForSono.Text != "")
            {
                if (synthesizer != null)
                {
                    synthesizer.Dispose();
                }
                
                synthesizer = new SpeechSynthesizer();
                if (choosedVoice != null)
                {
                    synthesizer.SelectVoice(choosedVoice);
                }
                synthesizer.SpeakAsync(textForSono.Text);
                pause.Enabled = true;
                resume.Enabled = false;
                stop.Enabled = true;
            }
        }
        private void Pause_Click(object sender, EventArgs e)
        {
           if (synthesizer != null)
           {
                synthesizer.Pause();
           }
           play.Enabled = true;
           pause.Enabled = false;
           resume.Enabled = true;
           stop.Enabled = false;
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
            {
                synthesizer.Resume();
            }
            play.Enabled = false;
            pause.Enabled = true;
            resume.Enabled = false;
            stop.Enabled = true;

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
            {
                synthesizer.Dispose();
            }
            play.Enabled = true;
            pause.Enabled = false;
            resume.Enabled = false;
            stop.Enabled = false;
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName + ".wav";
                logBox.Text += "\nSauvegarde du fichier: " + fileName;
                if (textForSono.Text != "")
                {
                    if (synthesizer != null)
                    {
                        synthesizer.Dispose();
                    }

                    if (choosedVoice != "")
                    {
                        logBox.Text += "Choisissez une voix!";
                    }
                    CreateWav(textForSono.Text, fileName, choosedVoice);
                }
            }
        }

        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                logBox.Text = "Fichier source: " + fileName;
            }
            
        }

       

        private void BtnChooseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                dirName = folderBrowser.SelectedPath;
                logBox.Text += "\nDossier de destination: " + dirName;
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            Object misValue = System.Reflection.Missing.Value;
            if(File.Exists(@fileName) && Directory.Exists (dirName))
            {
                excel = new Excel.Application();
                if (excel == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }
                workbook = excel.Workbooks.Open(fileName, misValue);

                //workbook = excel.Workbooks.Open(fileName, 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                logBox.Text += "\n Ouverture du fichier source: " + fileName;
                worksheet = workbook.ActiveSheet;
                
                Excel.Range usedRange = worksheet.UsedRange;
                int lastUsedRow = usedRange.Row + usedRange.Rows.Count - 1;
                logBox.Text += "\n" + lastUsedRow;
                
                /*
                for (int i =1; i<= lastUsedRow; i++)
                {
                    if(worksheet.Cells[i, 2].Value2 != null && worksheet.Cells[i,3].Value2 != null)
                    {
                        sonoText = worksheet.Cells[i, 2].Value.ToString();
                        sonoName = dirName + @"\" + worksheet.Cells[i, 3].Value.ToString() + ".wav";
                        logBox.Text += "\n" + sonoText;
                        if (choosedVoice != null)
                        {
                            CreateWav(sonoText, sonoName, choosedVoice);
                        }
                        else
                        {
                            logBox.Text += "\nChoisissez une voix";
                            workbook.Close();
                        }
                    }
                    else
                    {
                        logBox.Text += "\n" + worksheet.Cells[i, 2];
                        Excel.Range row = worksheet.Rows.EntireRow;
                        row.Interior.Color = System.Drawing.Color.Red;
                        
                    }
                }*/

                int i = 1;
                foreach(Excel.Range row in worksheet.Rows)
                {
                    if (row.Cells[i, 2].Value2 != null && row.Cells[i, 3].Value2 != null)
                    {
                        sonoText = row.Cells[i, 2].Value.ToString();
                        sonoName = dirName + @"\" + row.Cells[i, 3].Value.ToString() + ".wav";
                        logBox.Text += "\n" + sonoText;
                        if (choosedVoice != null)
                        {
                            CreateWav(sonoText, sonoName, choosedVoice);
                        }
                        else
                        {
                            logBox.Text += "\nChoisissez une voix";
                            return;
                            
                        }
                    }
                    else
                    {
                        logBox.Text += "\n" + worksheet.Cells[i, 2];
                        row.Interior.Color = System.Drawing.Color.Red;
                    }
                    i++;
                    logBox.Text += "\nFin Traitement de la ligne" + i +" " + row.Cells[i, 2].Value.ToString();

                }
                workbook.Save();
                workbook.Close();
                excel.Quit();
                logBox.Text += "\nFin de fichier";
            }
            else
            {
                logBox.Text += "\nAucune action possible.Choisissez un fichier excel et un repertoire";
            }

            workbook.Close();
            excel.Quit();
        }

        private void CreateWav(string sonoText, string sonoName, string choosedVoice)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoice(choosedVoice);
            synthesizer.SetOutputToWaveFile(sonoName);
            // synthesizer.SetOutputToWaveStream(MemoryStream wavStrea);
            synthesizer.Speak(sonoText);
            synthesizer.Dispose();
            // Mp3Convert(dirName + @"\" + sonoName + ".wav");
            
        }

        /*private void Mp3Convert(string waveFile)
 {
     WaveFileReader wavReader = new WaveFileReader(waveFile);
     LameMP3FileWriter mp3Writer = new LameMP3FileWriter(dirName + @"\" + sonoName + ".mp3", wavReader.WaveFormat, 128);
     wavReader.CopyTo(mp3Writer);
     wavReader.Dispose();
     mp3Writer.Dispose();



 }*/
    }

        
    }
