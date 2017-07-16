namespace Caffe_Tool
{
    partial class CaffeTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDataFolder = new System.Windows.Forms.Button();
            this.buttonToolFolder = new System.Windows.Forms.Button();
            this.tbDataFolder = new System.Windows.Forms.TextBox();
            this.tbToolFolder = new System.Windows.Forms.TextBox();
            this.labelDataFolder = new System.Windows.Forms.Label();
            this.labelToolFolder = new System.Windows.Forms.Label();
            this.labelTrainVal = new System.Windows.Forms.Label();
            this.tbTrainVal = new System.Windows.Forms.TextBox();
            this.buttonTrainValConfig = new System.Windows.Forms.Button();
            this.labelSolver = new System.Windows.Forms.Label();
            this.tbSolver = new System.Windows.Forms.TextBox();
            this.buttonSolverConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeploy = new System.Windows.Forms.TextBox();
            this.buttonDeploy = new System.Windows.Forms.Button();
            this.buttonCreateLMDB = new System.Windows.Forms.Button();
            this.buttonMakeMeanImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSynset = new System.Windows.Forms.TextBox();
            this.buttonSynset = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDataFolder
            // 
            this.buttonDataFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataFolder.Location = new System.Drawing.Point(567, 11);
            this.buttonDataFolder.Name = "buttonDataFolder";
            this.buttonDataFolder.Size = new System.Drawing.Size(32, 23);
            this.buttonDataFolder.TabIndex = 0;
            this.buttonDataFolder.Text = "...";
            this.buttonDataFolder.UseVisualStyleBackColor = true;
            this.buttonDataFolder.Click += new System.EventHandler(this.buttonDataFolder_Click);
            // 
            // buttonToolFolder
            // 
            this.buttonToolFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToolFolder.Location = new System.Drawing.Point(567, 52);
            this.buttonToolFolder.Name = "buttonToolFolder";
            this.buttonToolFolder.Size = new System.Drawing.Size(32, 23);
            this.buttonToolFolder.TabIndex = 1;
            this.buttonToolFolder.Text = "...";
            this.buttonToolFolder.UseVisualStyleBackColor = true;
            this.buttonToolFolder.Click += new System.EventHandler(this.buttonToolFolder_Click);
            // 
            // tbDataFolder
            // 
            this.tbDataFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataFolder.Location = new System.Drawing.Point(100, 13);
            this.tbDataFolder.Name = "tbDataFolder";
            this.tbDataFolder.Size = new System.Drawing.Size(449, 21);
            this.tbDataFolder.TabIndex = 2;
            this.tbDataFolder.TextChanged += new System.EventHandler(this.tbDataFolder_TextChanged);
            // 
            // tbToolFolder
            // 
            this.tbToolFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToolFolder.Location = new System.Drawing.Point(100, 52);
            this.tbToolFolder.Name = "tbToolFolder";
            this.tbToolFolder.Size = new System.Drawing.Size(449, 21);
            this.tbToolFolder.TabIndex = 3;
            this.tbToolFolder.TextChanged += new System.EventHandler(this.tbToolFolder_TextChanged);
            // 
            // labelDataFolder
            // 
            this.labelDataFolder.AutoSize = true;
            this.labelDataFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFolder.Location = new System.Drawing.Point(12, 17);
            this.labelDataFolder.Name = "labelDataFolder";
            this.labelDataFolder.Size = new System.Drawing.Size(74, 16);
            this.labelDataFolder.TabIndex = 4;
            this.labelDataFolder.Text = "Data folder";
            // 
            // labelToolFolder
            // 
            this.labelToolFolder.AutoSize = true;
            this.labelToolFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToolFolder.Location = new System.Drawing.Point(12, 52);
            this.labelToolFolder.Name = "labelToolFolder";
            this.labelToolFolder.Size = new System.Drawing.Size(73, 16);
            this.labelToolFolder.TabIndex = 5;
            this.labelToolFolder.Text = "Tool folder";
            // 
            // labelTrainVal
            // 
            this.labelTrainVal.AutoSize = true;
            this.labelTrainVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainVal.Location = new System.Drawing.Point(13, 111);
            this.labelTrainVal.Name = "labelTrainVal";
            this.labelTrainVal.Size = new System.Drawing.Size(104, 16);
            this.labelTrainVal.TabIndex = 8;
            this.labelTrainVal.Text = "train_val.prototxt";
            // 
            // tbTrainVal
            // 
            this.tbTrainVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrainVal.Location = new System.Drawing.Point(159, 110);
            this.tbTrainVal.Name = "tbTrainVal";
            this.tbTrainVal.Size = new System.Drawing.Size(331, 21);
            this.tbTrainVal.TabIndex = 7;
            // 
            // buttonTrainValConfig
            // 
            this.buttonTrainValConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainValConfig.Location = new System.Drawing.Point(533, 110);
            this.buttonTrainValConfig.Name = "buttonTrainValConfig";
            this.buttonTrainValConfig.Size = new System.Drawing.Size(68, 23);
            this.buttonTrainValConfig.TabIndex = 6;
            this.buttonTrainValConfig.Text = "Config";
            this.buttonTrainValConfig.UseVisualStyleBackColor = true;
            this.buttonTrainValConfig.Click += new System.EventHandler(this.buttonTrainValConfig_Click);
            // 
            // labelSolver
            // 
            this.labelSolver.AutoSize = true;
            this.labelSolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolver.Location = new System.Drawing.Point(13, 151);
            this.labelSolver.Name = "labelSolver";
            this.labelSolver.Size = new System.Drawing.Size(91, 16);
            this.labelSolver.TabIndex = 11;
            this.labelSolver.Text = "solver.prototxt";
            // 
            // tbSolver
            // 
            this.tbSolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSolver.Location = new System.Drawing.Point(159, 150);
            this.tbSolver.Name = "tbSolver";
            this.tbSolver.Size = new System.Drawing.Size(331, 21);
            this.tbSolver.TabIndex = 10;
            // 
            // buttonSolverConfig
            // 
            this.buttonSolverConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolverConfig.Location = new System.Drawing.Point(533, 150);
            this.buttonSolverConfig.Name = "buttonSolverConfig";
            this.buttonSolverConfig.Size = new System.Drawing.Size(68, 23);
            this.buttonSolverConfig.TabIndex = 9;
            this.buttonSolverConfig.Text = "Config";
            this.buttonSolverConfig.UseVisualStyleBackColor = true;
            this.buttonSolverConfig.Click += new System.EventHandler(this.buttonSolverConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "deploy.prototxt";
            // 
            // tbDeploy
            // 
            this.tbDeploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeploy.Location = new System.Drawing.Point(159, 191);
            this.tbDeploy.Name = "tbDeploy";
            this.tbDeploy.Size = new System.Drawing.Size(331, 21);
            this.tbDeploy.TabIndex = 13;
            // 
            // buttonDeploy
            // 
            this.buttonDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeploy.Location = new System.Drawing.Point(533, 191);
            this.buttonDeploy.Name = "buttonDeploy";
            this.buttonDeploy.Size = new System.Drawing.Size(68, 23);
            this.buttonDeploy.TabIndex = 12;
            this.buttonDeploy.Text = "Config";
            this.buttonDeploy.UseVisualStyleBackColor = true;
            this.buttonDeploy.Click += new System.EventHandler(this.buttonDeploy_Click);
            // 
            // buttonCreateLMDB
            // 
            this.buttonCreateLMDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateLMDB.Location = new System.Drawing.Point(325, 275);
            this.buttonCreateLMDB.Name = "buttonCreateLMDB";
            this.buttonCreateLMDB.Size = new System.Drawing.Size(115, 53);
            this.buttonCreateLMDB.TabIndex = 15;
            this.buttonCreateLMDB.Text = "Create LMDB";
            this.buttonCreateLMDB.UseVisualStyleBackColor = true;
            this.buttonCreateLMDB.Click += new System.EventHandler(this.buttonCreateLMDB_Click);
            // 
            // buttonMakeMeanImage
            // 
            this.buttonMakeMeanImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeMeanImage.Location = new System.Drawing.Point(487, 275);
            this.buttonMakeMeanImage.Name = "buttonMakeMeanImage";
            this.buttonMakeMeanImage.Size = new System.Drawing.Size(115, 53);
            this.buttonMakeMeanImage.TabIndex = 16;
            this.buttonMakeMeanImage.Text = "Make Mean Image";
            this.buttonMakeMeanImage.UseVisualStyleBackColor = true;
            this.buttonMakeMeanImage.Click += new System.EventHandler(this.buttonMakeMeanImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "synset.txt";
            // 
            // tbSynset
            // 
            this.tbSynset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSynset.Location = new System.Drawing.Point(159, 229);
            this.tbSynset.Name = "tbSynset";
            this.tbSynset.Size = new System.Drawing.Size(331, 21);
            this.tbSynset.TabIndex = 18;
            // 
            // buttonSynset
            // 
            this.buttonSynset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSynset.Location = new System.Drawing.Point(533, 229);
            this.buttonSynset.Name = "buttonSynset";
            this.buttonSynset.Size = new System.Drawing.Size(68, 23);
            this.buttonSynset.TabIndex = 17;
            this.buttonSynset.Text = "Config";
            this.buttonSynset.UseVisualStyleBackColor = true;
            this.buttonSynset.Click += new System.EventHandler(this.buttonSynset_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.Location = new System.Drawing.Point(325, 360);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(115, 53);
            this.buttonTrain.TabIndex = 20;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(488, 360);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(115, 53);
            this.buttonTest.TabIndex = 21;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // CaffeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 441);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonTrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSynset);
            this.Controls.Add(this.buttonSynset);
            this.Controls.Add(this.buttonMakeMeanImage);
            this.Controls.Add(this.buttonCreateLMDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDeploy);
            this.Controls.Add(this.buttonDeploy);
            this.Controls.Add(this.labelSolver);
            this.Controls.Add(this.tbSolver);
            this.Controls.Add(this.buttonSolverConfig);
            this.Controls.Add(this.labelTrainVal);
            this.Controls.Add(this.tbTrainVal);
            this.Controls.Add(this.buttonTrainValConfig);
            this.Controls.Add(this.labelToolFolder);
            this.Controls.Add(this.labelDataFolder);
            this.Controls.Add(this.tbToolFolder);
            this.Controls.Add(this.tbDataFolder);
            this.Controls.Add(this.buttonToolFolder);
            this.Controls.Add(this.buttonDataFolder);
            this.Name = "CaffeTool";
            this.Text = "Caffe Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDataFolder;
        private System.Windows.Forms.Button buttonToolFolder;
        private System.Windows.Forms.TextBox tbDataFolder;
        private System.Windows.Forms.TextBox tbToolFolder;
        private System.Windows.Forms.Label labelDataFolder;
        private System.Windows.Forms.Label labelToolFolder;
        private System.Windows.Forms.Label labelTrainVal;
        private System.Windows.Forms.TextBox tbTrainVal;
        private System.Windows.Forms.Button buttonTrainValConfig;
        private System.Windows.Forms.Label labelSolver;
        private System.Windows.Forms.TextBox tbSolver;
        private System.Windows.Forms.Button buttonSolverConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDeploy;
        private System.Windows.Forms.Button buttonDeploy;
        private System.Windows.Forms.Button buttonCreateLMDB;
        private System.Windows.Forms.Button buttonMakeMeanImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSynset;
        private System.Windows.Forms.Button buttonSynset;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonTest;
    }
}