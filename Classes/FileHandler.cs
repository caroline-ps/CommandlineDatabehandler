using System.Data;
using System.Text.Json;
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

    //Here I test the helper method given in the assignment. 
    //It converts the json text into a list, then checks if a "json" list exists, if not it creates a new one. It then adds the new
      //element to the list and converts it to json. If something goes wrong, it throws an error insteaf of corrupting the file. 
    public void AppendJsonContent(string filePath, string newItemJson)
{
    string json = File.ReadAllText(filePath);
    try
    {
        var array = JsonSerializer.Deserialize<List<JsonElement>>(json);

        if (array == null)
            array = new List<JsonElement>();

        JsonElement newElement = JsonSerializer.Deserialize<JsonElement>(newItemJson);
        array.Add(newElement);

        string updatedJson = JsonSerializer.Serialize(array, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, updatedJson);
    }
    catch (JsonException)
    {
        throw new InvalidOperationException("An error occured!");
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