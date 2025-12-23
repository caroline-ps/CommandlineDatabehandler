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
    }
}
