using System.Text;
using Android.Nfc;
using Android.Nfc.Tech;

namespace WillowMaze.App.Services;

internal sealed class EmvCardData
{
    public string? Pan { get; set; }
    public string? MaskedPan { get; set; }
    public string? Last4 { get; set; }
    public string? Expiry { get; set; }
    public string? CardholderName { get; set; }
    public string? CardBrand { get; set; }
    public string? AidHex { get; set; }
    public string? AidLabel { get; set; }
    public string? PpseResponseHex { get; set; }
    public string? GpoResponseHex { get; set; }
    public List<string> RecordHexes { get; set; } = [];
    public List<string> Log { get; set; } = [];
    public bool Success { get; set; }
    public string? Error { get; set; }
}

internal static class EmvCardReader
{
    private static readonly byte[] SelectPpse = BuildSelectApdu("325041592E5359532E4444463031");
    private static readonly byte[] SelectPse = BuildSelectApdu("315041592E5359532E4444463031");

    public static EmvCardData ReadCard(Tag tag)
    {
        var data = new EmvCardData();
        IsoDep? isoDep = null;

        try
        {
            isoDep = IsoDep.Get(tag);
            if (isoDep is null)
            {
                data.Error = "Card does not support IsoDep";
                data.Log.Add("No IsoDep tech available");
                return data;
            }

            isoDep.Connect();
            isoDep.Timeout = 5000;
            data.Log.Add($"Connected. MaxTransceiveLength={isoDep.MaxTransceiveLength}");

            var ppseResponse = Transceive(isoDep, SelectPpse, data, "SELECT PPSE");
            if (!IsSuccess(ppseResponse))
            {
                ppseResponse = Transceive(isoDep, SelectPse, data, "SELECT PSE");
            }

            data.PpseResponseHex = Convert.ToHexString(ppseResponse ?? []);

            var aids = ParseAidsFromPpse(ppseResponse, data);
            if (aids.Count == 0)
            {
                aids.AddRange(WellKnownAids());
                data.Log.Add("No AIDs from PPSE, trying well-known AIDs");
            }

            foreach (var aid in aids)
            {
                data.Log.Add($"Trying AID: {aid}");
                var selectAid = BuildSelectApdu(aid);
                var aidResponse = Transceive(isoDep, selectAid, data, $"SELECT AID {aid}");

                if (!IsSuccess(aidResponse))
                {
                    data.Log.Add($"AID {aid} not supported");
                    continue;
                }

                data.AidHex = aid;
                data.AidLabel = ParseAidLabel(aidResponse);
                data.CardBrand = DetectBrand(aid);
                data.Log.Add($"AID selected: {aid} ({data.CardBrand})");

                var pdol = ParsePdol(aidResponse);
                var gpoCommand = BuildGpoCommand(pdol);
                var gpoResponse = Transceive(isoDep, gpoCommand, data, "GET PROCESSING OPTIONS");
                data.GpoResponseHex = Convert.ToHexString(gpoResponse ?? []);

                if (IsSuccess(gpoResponse))
                {
                    var afls = ParseAfl(gpoResponse, data);
                    foreach (var (sfi, first, last) in afls)
                    {
                        for (var rec = first; rec <= last; rec++)
                        {
                            var readCmd = new byte[] { 0x00, 0xB2, (byte)rec, (byte)((sfi << 3) | 0x04), 0x00 };
                            var recResponse = Transceive(isoDep, readCmd, data, $"READ RECORD SFI={sfi} REC={rec}");
                            if (IsSuccess(recResponse))
                            {
                                data.RecordHexes.Add(Convert.ToHexString(recResponse));
                                ExtractCardData(recResponse, data);
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(data.Pan))
                {
                    for (var sfi = 1; sfi <= 10; sfi++)
                    {
                        for (var rec = 1; rec <= 5; rec++)
                        {
                            var readCmd = new byte[] { 0x00, 0xB2, (byte)rec, (byte)((sfi << 3) | 0x04), 0x00 };
                            var recResponse = Transceive(isoDep, readCmd, data, $"BRUTE READ SFI={sfi} REC={rec}");
                            if (IsSuccess(recResponse))
                            {
                                data.RecordHexes.Add(Convert.ToHexString(recResponse));
                                ExtractCardData(recResponse, data);
                            }

                            if (!string.IsNullOrEmpty(data.Pan)) break;
                        }

                        if (!string.IsNullOrEmpty(data.Pan)) break;
                    }
                }

                if (!string.IsNullOrEmpty(data.Pan))
                {
                    data.Success = true;
                    break;
                }
            }

            if (string.IsNullOrEmpty(data.Pan))
            {
                data.Log.Add("Could not extract PAN from any AID");
            }
        }
        catch (Exception ex)
        {
            data.Error = ex.Message;
            data.Log.Add($"Exception: {ex.Message}");
        }
        finally
        {
            try { isoDep?.Close(); } catch { }
        }

        return data;
    }

    private static byte[]? Transceive(IsoDep isoDep, byte[] command, EmvCardData data, string label)
    {
        try
        {
            var commandHex = Convert.ToHexString(command);
            data.Log.Add($">> {label}: {commandHex}");
            var response = isoDep.Transceive(command);
            var responseHex = Convert.ToHexString(response ?? []);
            data.Log.Add($"<< {label}: {responseHex}");
            return response;
        }
        catch (Exception ex)
        {
            data.Log.Add($"!! {label}: {ex.Message}");
            return null;
        }
    }

    private static bool IsSuccess(byte[]? response)
    {
        if (response is null || response.Length < 2) return false;
        return response[^2] == 0x90 && response[^1] == 0x00;
    }

    private static byte[] BuildSelectApdu(string aidHex)
    {
        var aidBytes = Convert.FromHexString(aidHex);
        var apdu = new byte[5 + aidBytes.Length + 1];
        apdu[0] = 0x00;
        apdu[1] = 0xA4;
        apdu[2] = 0x04;
        apdu[3] = 0x00;
        apdu[4] = (byte)aidBytes.Length;
        Buffer.BlockCopy(aidBytes, 0, apdu, 5, aidBytes.Length);
        apdu[^1] = 0x00;
        return apdu;
    }

    private static List<string> ParseAidsFromPpse(byte[]? response, EmvCardData data)
    {
        var aids = new List<string>();
        if (response is null || response.Length < 4) return aids;

        var hex = Convert.ToHexString(response);
        var idx = 0;
        while ((idx = hex.IndexOf("4F", idx, StringComparison.Ordinal)) >= 0)
        {
            if (idx + 4 > hex.Length) break;
            var lenStr = hex.Substring(idx + 2, 2);
            if (!int.TryParse(lenStr, System.Globalization.NumberStyles.HexNumber, null, out var len)) { idx += 2; continue; }
            if (idx + 4 + len * 2 > hex.Length) break;
            var aid = hex.Substring(idx + 4, len * 2);
            if (aid.Length >= 10 && !aids.Contains(aid))
            {
                aids.Add(aid);
                data.Log.Add($"PPSE AID found: {aid}");
            }
            idx += 4 + len * 2;
        }

        return aids;
    }

    private static string? ParseAidLabel(byte[]? response)
    {
        if (response is null) return null;
        var hex = Convert.ToHexString(response);
        var idx = hex.IndexOf("50", StringComparison.Ordinal);
        if (idx < 0 || idx + 4 > hex.Length) return null;
        if (!int.TryParse(hex.Substring(idx + 2, 2), System.Globalization.NumberStyles.HexNumber, null, out var len)) return null;
        if (idx + 4 + len * 2 > hex.Length) return null;
        return Encoding.ASCII.GetString(Convert.FromHexString(hex.Substring(idx + 4, len * 2)));
    }

    private static byte[]? ParsePdol(byte[]? response)
    {
        if (response is null) return null;
        var hex = Convert.ToHexString(response);
        var idx = hex.IndexOf("9F38", StringComparison.Ordinal);
        if (idx < 0) return null;
        if (idx + 6 > hex.Length) return null;
        if (!int.TryParse(hex.Substring(idx + 4, 2), System.Globalization.NumberStyles.HexNumber, null, out var len)) return null;
        if (idx + 6 + len * 2 > hex.Length) return null;
        return Convert.FromHexString(hex.Substring(idx + 6, len * 2));
    }

    private static byte[] BuildGpoCommand(byte[]? pdol)
    {
        if (pdol is null || pdol.Length == 0)
        {
            return [0x80, 0xA8, 0x00, 0x00, 0x02, 0x83, 0x00, 0x00];
        }

        var totalLen = 0;
        var i = 0;
        while (i < pdol.Length)
        {
            if (i + 1 < pdol.Length && (pdol[i] & 0x1F) == 0x1F) i++;
            i++;
            if (i < pdol.Length) { totalLen += pdol[i]; i++; }
        }

        var data = new byte[totalLen + 2];
        data[0] = 0x83;
        data[1] = (byte)totalLen;

        var cmd = new byte[5 + data.Length + 1];
        cmd[0] = 0x80;
        cmd[1] = 0xA8;
        cmd[2] = 0x00;
        cmd[3] = 0x00;
        cmd[4] = (byte)data.Length;
        Buffer.BlockCopy(data, 0, cmd, 5, data.Length);
        cmd[^1] = 0x00;
        return cmd;
    }

    private static List<(int Sfi, int First, int Last)> ParseAfl(byte[]? response, EmvCardData data)
    {
        var afls = new List<(int, int, int)>();
        if (response is null || response.Length < 4) return afls;

        var hex = Convert.ToHexString(response);

        int aflStart;
        if (hex.Contains("77"))
        {
            var idx94 = hex.IndexOf("94", StringComparison.Ordinal);
            if (idx94 < 0) return afls;
            if (!int.TryParse(hex.Substring(idx94 + 2, 2), System.Globalization.NumberStyles.HexNumber, null, out var aflLen94)) return afls;
            aflStart = idx94 + 4;
            var aflHex = hex.Substring(aflStart, aflLen94 * 2);
            ParseAflBytes(Convert.FromHexString(aflHex), afls, data);
        }
        else if (response.Length > 4 && response[2] == 0x80)
        {
            var aipLen = 2;
            var aflBytes = new byte[response.Length - 4 - aipLen - 2];
            if (aflBytes.Length > 0)
            {
                Buffer.BlockCopy(response, 4 + aipLen, aflBytes, 0, aflBytes.Length);
                ParseAflBytes(aflBytes, afls, data);
            }
        }

        return afls;
    }

    private static void ParseAflBytes(byte[] aflBytes, List<(int, int, int)> afls, EmvCardData data)
    {
        for (var i = 0; i + 3 < aflBytes.Length; i += 4)
        {
            var sfi = (aflBytes[i] >> 3) & 0x1F;
            var first = aflBytes[i + 1];
            var last = aflBytes[i + 2];
            if (sfi > 0 && first > 0 && last >= first)
            {
                afls.Add((sfi, first, last));
                data.Log.Add($"AFL: SFI={sfi} records {first}-{last}");
            }
        }
    }

    private static void ExtractCardData(byte[]? response, EmvCardData data)
    {
        if (response is null) return;
        var hex = Convert.ToHexString(response);

        if (string.IsNullOrEmpty(data.Pan))
        {
            var pan = FindTag(hex, "5A");
            if (pan is not null)
            {
                data.Pan = pan.TrimEnd('F');
                data.MaskedPan = MaskPan(data.Pan);
                data.Last4 = data.Pan.Length >= 4 ? data.Pan[^4..] : data.Pan;
                data.Log.Add($"PAN found (tag 5A): {data.MaskedPan}");
            }
        }

        if (string.IsNullOrEmpty(data.Pan))
        {
            var track2 = FindTag(hex, "57");
            if (track2 is not null)
            {
                var sep = track2.IndexOf('D');
                if (sep > 0)
                {
                    data.Pan = track2[..sep];
                    data.MaskedPan = MaskPan(data.Pan);
                    data.Last4 = data.Pan.Length >= 4 ? data.Pan[^4..] : data.Pan;
                    data.Expiry = track2.Substring(sep + 1, Math.Min(4, track2.Length - sep - 1));
                    data.Log.Add($"PAN from Track2 (tag 57): {data.MaskedPan} exp={data.Expiry}");
                }
            }
        }

        if (string.IsNullOrEmpty(data.Expiry))
        {
            var expiry = FindTag(hex, "5F24");
            if (expiry is not null && expiry.Length >= 4)
            {
                data.Expiry = expiry[..4];
                data.Log.Add($"Expiry (tag 5F24): {data.Expiry}");
            }
        }

        if (string.IsNullOrEmpty(data.CardholderName))
        {
            var name = FindTag(hex, "5F20");
            if (name is not null)
            {
                data.CardholderName = Encoding.ASCII.GetString(Convert.FromHexString(name)).Trim().TrimEnd('/');
                data.Log.Add($"Cardholder (tag 5F20): {data.CardholderName}");
            }
        }
    }

    private static string? FindTag(string hex, string tagHex)
    {
        var idx = hex.IndexOf(tagHex, StringComparison.OrdinalIgnoreCase);
        if (idx < 0) return null;
        var lenPos = idx + tagHex.Length;
        if (lenPos + 2 > hex.Length) return null;
        if (!int.TryParse(hex.Substring(lenPos, 2), System.Globalization.NumberStyles.HexNumber, null, out var len)) return null;
        var dataPos = lenPos + 2;
        if (dataPos + len * 2 > hex.Length) return null;
        return hex.Substring(dataPos, len * 2);
    }

    private static string MaskPan(string pan)
    {
        if (pan.Length <= 8) return "****" + pan[^4..];
        return pan[..6] + new string('*', pan.Length - 10) + pan[^4..];
    }

    private static string DetectBrand(string aid) => aid.ToUpperInvariant() switch
    {
        var a when a.StartsWith("A000000003") => "Visa",
        var a when a.StartsWith("A000000004") => "Mastercard",
        var a when a.StartsWith("A000000025") => "Amex",
        var a when a.StartsWith("A000000065") => "JCB",
        var a when a.StartsWith("A000000001") => "Diners",
        var a when a.StartsWith("A000000152") => "Discover",
        _ => "Unknown"
    };

    private static List<string> WellKnownAids() =>
    [
        "A0000000031010",
        "A0000000032010",
        "A0000000041010",
        "A0000000042010",
        "A00000002501",
        "A0000000651010",
        "A0000001523010",
        "A0000000043060"
    ];
}
