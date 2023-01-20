using System.IO;

class FileAndDirectory
{
    public void LearnFilesAndFolders()
    {
        // Create a text file containing text "Hello world!"
        // @ = Verbatim character
        var folderPath = @"D:\Apps\.NET Training 6\.NET-Trainng-Bishnu\Fundamentals\TestFiles";
        var fullFilePath = @$"{folderPath}\test.txt";
        File.WriteAllText(fullFilePath, "Hello world!");

        var folder = @$"{folderPath}\test";
        Directory.CreateDirectory(folder);

        // Create a folder "A" somewhere and create a text file a.txt inside it.
        var folder1 = folderPath + "\\A";        
        Directory.CreateDirectory(folder1);
        File.WriteAllText(folder1 + "\\a.txt", "asfashk sdfkhalkf ah");

        // Create 10 folders with names Folder 1, Folder 2, Folder 3... Folder 10.

    }
}
