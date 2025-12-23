using System.Data;

public class FileHandler : IFileHandler
{
    //This method is implemented in #Exercise 2
    public void AppendFileContent(string? filePath, string? content)
    {
        //The first two 'IFs' handle possible errors. 
        if (filePath == null)
        {
            Console.WriteLine("No file path has been given.");
        } else if (content == null)
        {
            Console.WriteLine("There is no content to append");
        } else
        //Here we append some text (no parsing) to the file at filepath location.
        //Then we print the whole file content to check if append worked as expected. 
        {
            File.AppendAllText(filePath, content);
            Console.WriteLine( File.ReadAllText(filePath));
        }
    }

//Checks if a file exists at the specified filepath. If it does, it writes the file content in the console. 
//If the file doesnt exist it prints an error message to the console and crashes the program.
    public void ReadFileContent(string? filePath)
    {
        //Checks if a filePath has been given, if not prints console message.
        if (filePath == null)
        {
            Console.WriteLine("No filepath has been given.");
        //Checks that a file exists at path location, if yes, prints content of file. 
        } else if (File.Exists(filePath))
        {
            Console.WriteLine( File.ReadAllText(filePath));
        } else
        //If it doesn't find any file at location, prints console message. 
        {
            Console.WriteLine("No file found at" + filePath);
            throw new FileNotFoundException();
        }
    }
}