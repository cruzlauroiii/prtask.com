// Licensed to PrTask under the MIT License.

namespace PrTask.USearch;

/// <summary>
/// Exception thrown when a USearch native operation fails.
/// </summary>
public sealed class USearchException : InvalidOperationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="USearchException"/> class.
    /// </summary>
    /// <param name="message">The error message from the native library.</param>
    public USearchException(string message)
        : base(message)
    {
    }
}
