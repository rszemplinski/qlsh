namespace QL.Core;

public interface ICommandOutput
{
    /**
     * Result output of the command.
     */
    public string Result { get; }

    /**
     * Error output of the command.
     */
    public string Error { get; }

    /**
     * Exit code of the command.
     */
    public int ExitCode { get; }
}

public interface IClient
{
    /**
     * Is the client running locally or remotely?
     */
    public SessionType Type { get; }
    
    /**
     * Execute a command on the client.
     */
    public Task<ICommandOutput> ExecuteCommandAsync(string command,
        CancellationToken cancellationToken = default);

    /**
     * Upload a file to the client.
     */
    public Task<bool> UploadFileAsync(string localPath, string remotePath,
        CancellationToken cancellationToken = default);
    
    /**
     * Upload a file to the client.
     */
    public Task<bool> UploadFileAsync(FileStream fileStream, string remotePath,
        CancellationToken cancellationToken = default);

    /**
     * Download a file from the client.
     */
    public Task<FileStream?> DownloadFileAsync(string remotePath, string localPath,
        CancellationToken cancellationToken = default);
    
    /**
     * Download a file from the client in a temporary location.
     */
    public Task<FileStream?> DownloadFileAsync(string remotePath,
        CancellationToken cancellationToken = default);

    /**
     * Check if tool is installed on the client.
     */
    public Task<bool> IsToolInstalledAsync(string toolName,
        CancellationToken cancellationToken = default);
}