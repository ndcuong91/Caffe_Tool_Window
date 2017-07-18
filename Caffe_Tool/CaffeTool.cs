using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Caffe_Tool
{
    public partial class CaffeTool : Form
    {
        public string m_sTrainVal, m_sSolver, m_sDeploy, m_sSynset;
        public string m_sDataFolder, m_sToolFolder;
        List<string> m_vsFileNames;
        public CaffeTool()
        {
            InitializeComponent();
            //Init all textbox value
            tbDataFolder.Text = @"E:\2.Projects\15.DeepLearning\1.Images\data_test";
            tbToolFolder.Text = @"E:\2.Projects\15.DeepLearning\2.Codes\Caffe\caffe-windows_cudnn5\Build\x64\Debug";
            tbTrainVal.Text = @"E:\2.Projects\15.DeepLearning\1.Images\data_test\train_val.prototxt";
            tbSolver.Text = @"E:\2.Projects\15.DeepLearning\1.Images\data_test\solver.prototxt";
            tbDeploy.Text = @"E:\2.Projects\15.DeepLearning\1.Images\data_test\deploy.prototxt";
            tbSynset.Text = "";
        }

        private void buttonDataFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == DialogResult.OK)
                tbDataFolder.Text = openFolder.SelectedPath;
        }

        private void buttonToolFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == DialogResult.OK)
                tbToolFolder.Text = openFolder.SelectedPath;
        }

        private void buttonTrainValConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.prototxt | *.prototxt;";
            //openFile.Multiselect = true;
            if (openFile.ShowDialog() != DialogResult.OK) return;
            m_sTrainVal = openFile.FileName;
            tbTrainVal.Text = m_sTrainVal;
        }

        private void buttonSolverConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.prototxt | *.prototxt;";
            //openFile.Multiselect = true;
            if (openFile.ShowDialog() != DialogResult.OK) return;
            m_sSolver = openFile.FileName;
            tbSolver.Text = m_sSolver;
        }

        private void buttonDeploy_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.prototxt | *.prototxt;";
            //openFile.Multiselect = true;
            if (openFile.ShowDialog() != DialogResult.OK) return;
            m_sDeploy = openFile.FileName;
            tbDeploy.Text = m_sDeploy;
        }

        private void buttonSynset_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.txt | *.txt;";
            //openFile.Multiselect = true;
            if (openFile.ShowDialog() != DialogResult.OK) return;
            m_sSynset = openFile.FileName;
            tbSynset.Text = m_sSynset;
        }

        private void buttonCreateLMDB_Click(object sender, EventArgs e)
        {
            string sConvert = m_sToolFolder + "\\convert_imageset.exe";  // link to convert tool


            //Get Train Val list
            int nNumClasses = 2;
            string path = m_sDataFolder + "\\train.txt";
            path = m_sDataFolder + "\\val.txt";

            string sTemp;
            for (int i = 0; i < nNumClasses; i++)
            {
                string sTrainFolder = m_sDataFolder + "\\train\\" + i.ToString();


                string[] files = Directory.GetFiles(sTrainFolder);
                for (int j = 0; j < files.Length; j++)
                    files[j] = Path.GetFileName(files[j]);


                fnGetTrainList(i, files);

                string sValFolder = m_sDataFolder + "\\val\\" + i.ToString();

                files = Directory.GetFiles(sValFolder);
                for (int j = 0; j < files.Length; j++)
                    files[j] = Path.GetFileName(files[j]);


                fnGetValList(i, files);
            }

            //WRITE .BAT SCRIPT
            using (StreamWriter file = new StreamWriter(m_sDataFolder + "\\create_lmdb.bat"))  //write
            {
                bool bGray = false;

                string sValRoot, sTrainRoot;
                sValRoot = m_sDataFolder + "\\val\\ ";
                sTrainRoot = m_sDataFolder + "\\train\\ ";

                string sTrainText = m_sDataFolder + "\\train.txt ";
                string sTrainLMBD = m_sDataFolder + "\\train_lmdb";

                string script = "START /b \"\" \"" + sConvert + "\" -shuffle ";
                if (bGray)
                    script += "-gray ";

                //train
                script = script + sTrainRoot + sTrainText + sTrainLMBD;

                file.WriteLine(script);

                script = "START /b \"\" \"" + sConvert + "\" -shuffle ";

                if (bGray)
                    script += "-gray ";
                //val
                string sValText = m_sDataFolder + "\\val.txt ", sValLMBD = m_sDataFolder + "\\val_lmdb";
                script = script + sValRoot + sValText + sValLMBD;
                file.WriteLine(script);
            }

            //Run .BAT SCRIPT
            //system( path);
        }

        private void buttonMakeMeanImage_Click(object sender, EventArgs e)
        {
            /*Create mean image*/
            string sMean = m_sToolFolder + "\\compute_image_mean.exe";

            string sTrainLMBD = m_sDataFolder + "\\train_lmdb";

            string script = "START /b \"\" \"" + sMean + "\" " + sTrainLMBD + " " + m_sDataFolder + "\\mean.binaryproto";

            using (StreamWriter file = new StreamWriter(m_sDataFolder + "\\make_mean_image.bat"))  //write
            {
                file.WriteLine(script);
            }

            //system((LPCSTR)path);
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            string m_sCaffe = m_sToolFolder + "\\caffe.exe";
            string script = "START /b \"\" \"" + m_sCaffe + "\" train -solver=" + m_sSolver;
            using (StreamWriter file = new StreamWriter(m_sDataFolder + "\\train.bat"))  //write
            {
                file.WriteLine(script);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

        }



        void fnGetTrainList(int nClass, string[] files)   //Save train.txt
        {
            string temp;
            string path = m_sDataFolder + "\\train.txt";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                foreach (string line in files)
                {
                    temp = nClass.ToString() + "\\" + line + " " + nClass.ToString();
                    file.WriteLine(temp);
                }
            }
        }

        void fnGetValList(int nClass, string[] files)   //Save val.txt
        {
            string temp;
            string path = m_sDataFolder + "\\val.txt";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                foreach (string line in files)
                {
                    temp = nClass.ToString() + "\\" + line + " " + nClass.ToString();
                    file.WriteLine(temp);
                }
            }
        }

        private void tbDataFolder_TextChanged(object sender, EventArgs e)
        {
            m_sDataFolder = tbDataFolder.Text;
        }

        private void tbToolFolder_TextChanged(object sender, EventArgs e)
        {
            m_sToolFolder = tbToolFolder.Text;
        }

        private void tbSolver_TextChanged(object sender, EventArgs e)
        {
            m_sSolver = tbSolver.Text;
        }
    }
}