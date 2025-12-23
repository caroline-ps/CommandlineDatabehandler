using System.Data;

public class FileHandler : IFileHandler
{
    //This method is implemented in #Exercise 2
    public void AppendFileContent(string? filePath, string? content)
    {
        throw new NotImplementedException();
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