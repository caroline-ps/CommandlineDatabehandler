namespace CommandlineDatabehandler;

class Program
{
    static void Main(string[] args)
    {
        //Create an instance of the class FileHandler. 
        FileHandler fileHandler = new FileHandler();
        //Calls the method ReadFileContent and gives the filepath in the current directory.
        //Method prints in the console the content of the json file (no parsing).
        fileHandler.ReadFileContent("./datasett.json");
        // fileHandler.AppendFileContent("./datasett.json", "This is an exercise made by Caroline");

        //Here I test the helper method given in the assignment to create a new json object. 
        //I use a verbatim string to pass the content in the right json format without breaking c# string rules.
        fileHandler.AppendJsonContent("./datasett.json", @"{
        ""Navn"": ""Eventyr"",
        ""Kategori"": ""Litteratur"",
        ""Beskrivelse"": ""Eventyr har vært en viktig del av norsk fortellertradisjon"",
        ""Farge"": ""Grønn""
    }");
    }
}
