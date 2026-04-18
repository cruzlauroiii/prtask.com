using Android.Nfc;
using Android.Nfc.Tech;

namespace WillowMaze.Wasm.Companion.Services;

public sealed class EmvCardReader
{
    private static readonly byte[] SelectPpse =
    [
        0x00, 0xA4, 0x04, 0x00, 0x0E,
        0x32, 0x50, 0x41, 0x59, 0x2E, 0x53, 0x59, 0x53,
        0x2E, 0x44, 0x44, 0x46, 0x30, 0x31, 0x00,
    ];

    private static readonly byte[] SelectVisa =
    [
        0x00, 0xA4, 0x04, 0x00, 0x07,
        0xA0, 0x00, 0x00, 0x00, 0x03, 0x10, 0x10, 0x00,
    ];

    private static readonly byte[] SelectMastercard =
    [
        0x00, 0xA4, 0x04, 0x00, 0x07,
        0xA0, 0x00, 0x00, 0x00, 0x04, 0x10, 0x10, 0x00,
    ];

    private static readonly byte[] GpoNoPdol =
    [
        0x80, 0xA8, 0x00, 0x00, 0x02, 0x83, 0x00, 0x00,
    ];

    public static CardData? LastCard { get; private set; }

    public static CardData? ReadCard(Tag Tag)
    {
        var Iso = IsoDep.Get(Tag);
        if (Iso == null)
        {
            return null;
        }

        try
        {
            Iso.Connect();
            Iso.Timeout = 5000;
            Android.Util.Log.Info("Companion", $"IsoDep connected, maxTransceiveLength={Iso.MaxTransceiveLength}");

            var PpseResponse = Iso.Transceive(SelectPpse);
            Android.Util.Log.Info("Companion", "PPSE: " + (IsSuccess(PpseResponse) ? "OK" : "FAIL") + " len=" + PpseResponse?.Length);
            if (!IsSuccess(PpseResponse))
            {
                return null;
            }

            var Aids = ExtractAids(PpseResponse!);
            Android.Util.Log.Info("Companion", "AIDs found: " + Aids.Count);
            byte[]? AidResponse = null;
            var CardNetwork = "Unknown";

            if (Aids.Count > 0)
            {
                foreach (var Aid in Aids)
                {
                    var SelectAid = BuildSelectApdu(Aid);
                    AidResponse = Iso.Transceive(SelectAid);
                    if (IsSuccess(AidResponse))
                    {
                        CardNetwork = IdentifyNetwork(Aid);
                        break;
                    }
                }
            }
            else
            {
                AidResponse = Iso.Transceive(SelectVisa);
                if (IsSuccess(AidResponse))
                {
                    CardNetwork = "Visa";
                }
                else
                {
                    AidResponse = Iso.Transceive(SelectMastercard);
                    if (IsSuccess(AidResponse))
                    {
                        CardNetwork = "Mastercard";
                    }
                }
            }

            Android.Util.Log.Info("Companion", "AID select: " + CardNetwork + " response=" + (AidResponse != null ? ToHex(AidResponse) : "null"));
            if (AidResponse == null || !IsSuccess(AidResponse))
            {
                Android.Util.Log.Warn("Companion", "AID selection failed");
                return null;
            }

            var Pdol = FindTag(AidResponse, 0x9F, 0x38);
            byte[]? GpoResponse;
            if (Pdol != null)
            {
                Android.Util.Log.Info("Companion", "PDOL found (" + Pdol.Length + " bytes), building GPO with values");
                GpoResponse = Iso.Transceive(BuildGpoWithPdol(Pdol));
            }
            else
            {
                Android.Util.Log.Info("Companion", "No PDOL, using GPO without PDOL");
                GpoResponse = Iso.Transceive(GpoNoPdol);
            }
            Android.Util.Log.Info("Companion", "GPO: " + (IsSuccess(GpoResponse) ? "OK" : "FAIL") + " response=" + (GpoResponse != null ? ToHex(GpoResponse) : "null"));

            if (GpoResponse == null || !IsSuccess(GpoResponse))
            {
                return null;
            }

            var Afl = FindTag(GpoResponse, 0x94);
            if (Afl == null)
            {
                var Template = FindTag(GpoResponse, 0x77);
                if (Template != null)
                {
                    Afl = FindTag(Template, 0x94);
                }
            }

            var Card = new CardData { Network = CardNetwork };
            ExtractFromTlv(GpoResponse, Card);

            if (Afl != null)
            {
                for (var I = 0; I < Afl.Length; I += 4)
                {
                    var Sfi = (byte)((Afl[I] >> 3) & 0x1F);
                    var First = Afl[I + 1];
                    var Last = Afl[I + 2];
                    for (var Rec = First; Rec <= Last; Rec++)
                    {
                        var RecByte = Convert.ToByte(Rec);
                        var SfiByte = Convert.ToByte((Sfi << 3) | 4);
                        var ReadCmd = new byte[] { 0x00, 0xB2, RecByte, SfiByte, 0x00 };
                        var RecResponse = Iso.Transceive(ReadCmd);
                        if (IsSuccess(RecResponse))
                        {
                            ExtractFromTlv(RecResponse!, Card);
                        }
                    }
                }
            }

            var SelectedAid = Aids.Count > 0 ? Aids[0] : Array.Empty<byte>();
            Card.Aid = ToHex(SelectedAid);

            var Cdol1Data = BuildCdol1(100, 608);
            var GenAcCmd = new byte[5 + Cdol1Data.Length];
            GenAcCmd[0] = 0x80;
            GenAcCmd[1] = 0xAE;
            GenAcCmd[2] = 0x80;
            GenAcCmd[3] = 0x00;
            GenAcCmd[4] = (byte)Cdol1Data.Length;
            System.Array.Copy(Cdol1Data, 0, GenAcCmd, 5, Cdol1Data.Length);
            var AcResponse = Iso.Transceive(GenAcCmd);
            if (IsSuccess(AcResponse))
            {
                Card.GenerateAcResponse = AcResponse;
                Card.Cdol1 = Cdol1Data;
                ExtractFromTlv(AcResponse!, Card);
                Android.Util.Log.Info("Companion", $"GENERATE AC: CID={Card.Cid} ARQC={Card.Arqc} ATC={Card.Atc}");
            }
            else
            {
                Android.Util.Log.Warn("Companion", $"GENERATE AC failed: {(AcResponse != null ? ToHex(AcResponse) : "null")}");
            }

            if (string.IsNullOrEmpty(Card.Pan) && Card.Track2 != null)
            {
                var Track2Hex = ToHex(Card.Track2);
                var SepIdx = Track2Hex.IndexOf('D');
                if (SepIdx > 0)
                {
                    Card.Pan = Track2Hex[..SepIdx].TrimEnd('F');
                    if ((SepIdx + 4) <= Track2Hex.Length)
                    {
                        Card.Expiry = Track2Hex.Substring(SepIdx + 1, 4);
                    }
                }
            }

            if (!string.IsNullOrEmpty(Card.Pan))
            {
                Card.MaskedPan = MaskPan(Card.Pan);
            }

            LastCard = Card;
            Iso.Close();
            return Card;
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"NFC read error: {Ex.Message}");
            try { Iso.Close(); } catch (Exception) { /* Best-effort cleanup */ }
            return null;
        }
    }

    private static void ExtractFromTlv(byte[] Data, CardData Card)
    {
        var Pan = FindTag(Data, 0x5A);
        if (Pan != null && Card.PanRaw == null)
        {
            Card.PanRaw = Pan;
            Card.Pan = ToHex(Pan).TrimEnd('F');
        }
        var Expiry = FindTag(Data, 0x5F, 0x24);
        if (Expiry != null && string.IsNullOrEmpty(Card.Expiry))
        {
            Card.Expiry = ToHex(Expiry)[..4];
        }
        var Name = FindTag(Data, 0x5F, 0x20);
        if (Name != null && string.IsNullOrEmpty(Card.CardholderName))
        {
            Card.CardholderName = System.Text.Encoding.ASCII.GetString(Name).Trim();
        }
        var Track2 = FindTag(Data, 0x57);
        if (Track2 != null && Card.Track2 == null)
        {
            Card.Track2 = Track2;
        }
        var Atc = FindTag(Data, 0x9F, 0x36);
        if (Atc != null)
        {
            Card.Atc = ToHex(Atc);
        }
        var Arqc = FindTag(Data, 0x9F, 0x26);
        if (Arqc != null)
        {
            Card.Arqc = ToHex(Arqc);
        }
        var Cid = FindTag(Data, 0x9F, 0x27);
        if (Cid != null)
        {
            Card.Cid = ToHex(Cid);
        }
        var Iad = FindTag(Data, 0x9F, 0x10);
        if (Iad != null)
        {
            Card.Iad = ToHex(Iad);
        }
    }

    private static System.Collections.Generic.IReadOnlyList<byte[]> ExtractAids(byte[] PpseResponse)
    {
        var Aids = new System.Collections.Generic.List<byte[]>();
        var I = 0;
        while (I < PpseResponse.Length - 2)
        {
            if (PpseResponse[I] == 0x4F && (I + 1) < PpseResponse.Length)
            {
                var Len = PpseResponse[I + 1];
                if ((I + 2 + Len) <= PpseResponse.Length)
                {
                    var Aid = new byte[Len];
                    System.Array.Copy(PpseResponse, I + 2, Aid, 0, Len);
                    Aids.Add(Aid);
                    I += 2 + Len;
                    continue;
                }
            }
            I++;
        }
        return Aids;
    }

    private static byte[] BuildSelectApdu(byte[] Aid)
    {
        var Apdu = new byte[6 + Aid.Length];
        Apdu[0] = 0x00;
        Apdu[1] = 0xA4;
        Apdu[2] = 0x04;
        Apdu[3] = 0x00;
        Apdu[4] = (byte)Aid.Length;
        System.Array.Copy(Aid, 0, Apdu, 5, Aid.Length);
        Apdu[^1] = 0x00;
        return Apdu;
    }

    private static byte[] BuildGpoWithPdol(byte[] Pdol)
    {
        using var DataMs = new System.IO.MemoryStream();
        var I = 0;
        while (I < Pdol.Length)
        {
            int Tag;
            if ((Pdol[I] & 0x1F) == 0x1F) { Tag = (Pdol[I] << 8) | Pdol[I + 1]; I += 2; }
            else { Tag = Pdol[I]; I++; }
            var Len = Pdol[I]; I++;
            var Val = new byte[Len];
            switch (Tag)
            {
                case 0x9F66: Val = new byte[] { 0x26, 0x00, 0x00, 0x00 }; break;
                case 0x9F02: Val = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 }; break;
                case 0x9F03: break;
                case 0x9F1A: Val = new byte[] { 0x06, 0x08 }; break;
                case 0x9500: case 0x95: break;
                case 0x5F2A: Val = new byte[] { 0x06, 0x08 }; break;
                case 0x9A: var D = System.DateTime.UtcNow; Val = HexToBytes(D.ToString("yyMMdd")); break;
                case 0x9C: Val = new byte[] { 0x00 }; break;
                case 0x9F37: Val = System.Security.Cryptography.RandomNumberGenerator.GetBytes(4); break;
            }
            if (Val.Length != Len) Val = new byte[Len];
            DataMs.Write(Val, 0, Val.Length);
        }
        var PdolData = DataMs.ToArray();
        var Cmd = new byte[7 + PdolData.Length];
        Cmd[0] = 0x80;
        Cmd[1] = 0xA8;
        Cmd[2] = 0x00;
        Cmd[3] = 0x00;
        Cmd[4] = (byte)(2 + PdolData.Length);
        Cmd[5] = 0x83;
        Cmd[6] = (byte)PdolData.Length;
        System.Array.Copy(PdolData, 0, Cmd, 7, PdolData.Length);
        Android.Util.Log.Info("Companion", "GPO APDU: " + ToHex(Cmd));
        return Cmd;
    }

    private static byte[]? FindTag(byte[] Data, byte Tag1, byte Tag2 = 0)
    {
        for (var I = 0; I < Data.Length - 2;)
        {
            var IsMultiByte = (Data[I] & 0x1F) == 0x1F;
            var T1 = Data[I];
            byte T2 = 0;
            I++;
            if (IsMultiByte && I < Data.Length)
            {
                T2 = Data[I];
                I++;
            }
            if (I >= Data.Length)
            {
                break;
            }
            var Len = Data[I++];
            if (Len == 0x81 && I < Data.Length)
            {
                Len = Data[I++];
            }
            else if (Len == 0x82 && I + 1 < Data.Length)
            {
                Len = (byte)((Data[I] << 8) | Data[I + 1]);
                I += 2;
            }
            if (I + Len > Data.Length)
            {
                break;
            }
            if ((Tag2 == 0 && T1 == Tag1 && !IsMultiByte) || (Tag2 != 0 && T1 == Tag1 && T2 == Tag2))
            {
                var Val = new byte[Len];
                System.Array.Copy(Data, I, Val, 0, Len);
                return Val;
            }
            if (T1 is 0x70 or 0x77 or 0x61 or 0x6F or 0xA5)
            {
                var Nested = new byte[Len];
                System.Array.Copy(Data, I, Nested, 0, Len);
                var Found = FindTag(Nested, Tag1, Tag2);
                if (Found != null)
                {
                    return Found;
                }
            }
            I += Len;
        }
        return null;
    }

    private static byte[] BuildCdol1(long AmountCents, int CurrencyCode)
    {
        var Now = System.DateTime.UtcNow;
        var Rng = new System.Random();
        var UnpredNum = new byte[4];
        Rng.NextBytes(UnpredNum);
        using var Ms = new System.IO.MemoryStream();
        var AmtBcd = AmountCents.ToString("D12");
        Ms.Write(HexToBytes(AmtBcd), 0, 6);
        Ms.Write(new byte[6], 0, 6);
        var CcBcd = CurrencyCode.ToString("D4");
        Ms.Write(HexToBytes(CcBcd), 0, 2);
        var DateBcd = Now.ToString("yyMMdd");
        Ms.Write(HexToBytes(DateBcd), 0, 3);
        Ms.WriteByte(0x00);
        Ms.Write(new byte[] { 0x26, 0x80, 0x00, 0x00 }, 0, 4);
        Ms.Write(UnpredNum, 0, 4);
        return Ms.ToArray();
    }

    private static byte[] HexToBytes(string Hex)
    {
        var Bytes = new byte[Hex.Length / 2];
        for (var I = 0; I < Bytes.Length; I++)
        {
            Bytes[I] = System.Convert.ToByte(Hex.Substring(I * 2, 2), 16);
        }
        return Bytes;
    }

    private static string IdentifyNetwork(byte[] Aid)
    {
        if (Aid.Length >= 5 && Aid[0] == 0xA0 && Aid[1] == 0x00 && Aid[2] == 0x00 && Aid[3] == 0x00)
        {
            return Aid[4] switch
            {
                0x03 => "Visa",
                0x04 => "Mastercard",
                0x25 => "AMEX",
                0x65 => "JCB",
                _ => "Unknown",
            };
        }
        return "Unknown";
    }

    private static bool IsSuccess(byte[]? Response) => Response is { Length: >= 2 } && Response[^2] == 0x90 && Response[^1] == 0x00;
    private static string MaskPan(string Pan) => Pan.Length > 8 ? string.Concat(Pan.AsSpan(0, 4), new string('*', Pan.Length - 8), Pan.AsSpan(Pan.Length - 4)) : Pan;
    private static string ToHex(byte[] Bytes) => System.Convert.ToHexString(Bytes);

    public sealed class CardData
    {
        public string? Pan { get; set; }
        public string? MaskedPan { get; set; }
        public byte[]? PanRaw { get; set; }
        public string? Expiry { get; set; }
        public string? CardholderName { get; set; }
        public byte[]? Track2 { get; set; }
        public string? Network { get; set; }
        public string? Atc { get; set; }
        public string? Arqc { get; set; }
        public string? Cid { get; set; }
        public string? Iad { get; set; }
        public byte[]? Cdol1 { get; set; }
        public byte[]? GenerateAcResponse { get; set; }
        public string? Aid { get; set; }
    }
}
