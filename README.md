# Caffe_Tool_Csharp
A tool that support training with Caffe on Window

PREPARE 
1. Create "Data" folder that include "train" and "val" folder. In these folder already have image file and its label (txt) file
2. Prepare "train_val.prototxt", "solver.prototxt", "deploy.prototxt", "synset.prototxt" in "Data" folder
3. Build Caffe-window here https://github.com/BVLC/caffe/tree/windows. After that, there are some .exe files in Build/x64/Debug,
  Build/x64/release, Build/Debug, Build/Release

RUN
1. Config software as above folder's paths
2. Run "CreateLMDB", "MakeMeanImage" and "Train" to training
  
