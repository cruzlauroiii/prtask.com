using System.Text.RegularExpressions;
using PrTask.Domain.Constants;

namespace PrTask.Fingerprint;

public static partial class FingerprintRegex
{
    [GeneratedRegex(FingerprintConstants.AlreadyFingerprintedFilePattern)]
    public static partial Regex AlreadyFingerprintedFile();
}
