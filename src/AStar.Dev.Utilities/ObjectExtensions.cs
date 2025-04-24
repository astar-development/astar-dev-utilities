using System.Text.Json;

namespace AStar.Dev.Utilities;

/// <summary>
///     The <see cref="ObjectExtensions" /> class contains some useful methods to enable various tasks
///     to be performed in a more fluid, English sentence, style
/// </summary>
public static class ObjectExtensions
{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web) { WriteIndented = true, };

    /// <summary>
    ///     The ToJson method, as you might expect, converts the supplied objectToJson to its JSON equivalent (using the
    ///     JsonSerializerDefaults.Web defaults with WriteIndented set to true)
    /// </summary>
    /// <param name="objectToJson">The objectToJson to convert to JSON</param>
    /// <returns>The JSON string of the objectToJson supplied</returns>
    public static string ToJson<T>(this T objectToJson)
        => JsonSerializer.Serialize(objectToJson, Options);
}
