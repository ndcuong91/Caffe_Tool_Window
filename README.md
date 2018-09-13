# Caffe_Tool_Csharp
A tool that support training with Caffe on Window

PREPARE 
1. Create "Data" folder that include "train" and "val" folder. Each of these folder contains sub folders for each class and images within it.
2. Creat "train.txt", "val.txt" in "Data" folder with each line include path for each image and the class for this image. Example: 0/123.jpg 0
3. Prepare "train_val.prototxt", "solver.prototxt", "deploy.prototxt", "synset.prototxt" in "Data" folder 
  - "train_val.prototxt": model for training
  - "solver.prototxt": for config hyperparameters
  - "deploy.prototxt": model for testing
  - "synset.txt" contain class map 
4. Build Caffe-window here https://github.com/BVLC/caffe/tree/windows with x64-Release mode. After that, there are some .exe files in Build/x64/release. The program will use executable files in this folder

RUN
1. Config software, Create "models" folder in "Data" folder
2. Run "CreateLMDB", "MakeMeanImage" and "Train" to training
  
