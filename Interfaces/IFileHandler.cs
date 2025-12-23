public interface IFileHandler
{
    /// <summary>
    /// Read the content of a given file. The file will be opened when it's path is given as a argument to this method.
    /// example: FileHandler.ReadFileContent("some-file.json");
    /// </summary>
    /// <param name="filePath">the path of the file to open</param>
    void ReadFileContent(string? filePath);
    /// <summary>
    /// Writes the user input (content) at the end of the file specified at (filePath).
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="content">content to write to a file, this will append the written changes at the end of the file</param>
    void AppendFileContent(string? filePath, string? content);
}