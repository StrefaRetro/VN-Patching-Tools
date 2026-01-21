using System.Text;

namespace Ws2Explorer;

/// <summary>
/// Provides an instance of the Shift-JIS encoding.
/// </summary>
public static class SjisEncoding
{
    /// <summary>
    /// Gets an instance of the input encoding.
    /// </summary>
    public static Encoding Encoding { get; }

    /// <summary>
    /// Gets an instance of the output encoding.
    /// </summary>
    public static Encoding OutputEncoding { get; }

    static SjisEncoding()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        // Use Windows-1250 for input reading (original game files).
        Encoding = Encoding.GetEncoding(1250);
        // Use UTF-16 LE for output writing as requested.
        OutputEncoding = Encoding.Unicode;
    }
}
