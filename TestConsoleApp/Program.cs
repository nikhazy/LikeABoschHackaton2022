// See https://aka.ms/new-console-template for more information

using DataHandling;


string directoryPath = @"C:\Users\nikha\Downloads\SW Challenge 2022 - dataset\PSA_ADAS_W3_FC_2022-09-01_14-49_0054.MF4\";

FileHandler handler = new FileHandler();

handler.ReadAllFilesInFolder(directoryPath);