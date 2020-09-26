//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MaxSumFinder
//{
//    class FileSelectorGUI
//    {
//        public void SelectFile()
//        {
//            FolderBrowserDialog fbd = new FolderBrowserDialog();
//            Console.WriteLine("Hello Please select the file ...");
//            OpenFileDialog openFileDialog1 = new OpenFileDialog();

//            openFileDialog1.InitialDirectory = "c:\\";
//            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
//            openFileDialog1.FilterIndex = 2;
//            openFileDialog1.RestoreDirectory = true;

//            if (openFileDialog1.ShowDialog() == DialogResult.OK)
//            {

//                string file = openFileDialog1.FileName;
//                Console.WriteLine(" FILE NAME : \t " + file); // full path
//                Console.WriteLine(System.IO.Path.GetFileName(file)); // file name
//                Console.ReadLine();
//            }
//        }
//    }
//}
