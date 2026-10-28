namespace be_service.Models;

public class ChatStreamEvent
{
    public string Event { get; set; } = string.Empty;
    public object? Data { get; set; }

    public static ChatStreamEvent Metadata(List<string> sources, List<RetrievedChunk> retrievedChunks) =>
        new()
        {
            Event = "metadata",
            Data = new
            {
                sources,
                retrievedChunks
            }
        };

    public static ChatStreamEvent Chunk(string text) =>
        new()
        {
            Event = "chunk",
            Data = new
            {
                text
            }
        };

    public static ChatStreamEvent Done(string answer, List<string> sources, List<RetrievedChunk> retrievedChunks) =>
        new()
        {
            Event = "done",
            Data = new
            {
                answer,
                sources,
                retrievedChunks
            }
        };

    public static ChatStreamEvent Error(string message, string? detail = null) =>
        new()
        {
            Event = "error",
            Data = new
            {
                error = message,
                detail
            }
        };
}
