using Android.Nfc;
using Android.Nfc.Tech;

namespace PocketPay.Companion.Services;

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

    public static CardData? ReadCard(Tag Tag, decimal Amount = 1.00m)
    {
        var Iso = IsoDep.Get(Tag);
        if (Iso == null) return null;

        try
        {
            Iso.Connect();
            Iso.Timeout = 5000;

            var PpseResponse = Iso.Transceive(SelectPpse);
            if (!IsSuccess(PpseResponse)) return null;

            var Aids = ExtractAids(PpseResponse!);
            Android.Util.Log.Info("Companion", $"NFC: Found {Aids.Count} AIDs");

            byte[]? AidResponse = null;
            byte[]? SelectedAid = null;
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
                        SelectedAid = Aid;
                        Android.Util.Log.Info("Companion", $"NFC: Selected AID {ToHex(Aid)} ({CardNetwork})");
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

            if (AidResponse == null || !IsSuccess(AidResponse)) return null;

            var GpoResponse = Iso.Transceive(GpoNoPdol);
            if (!IsSuccess(GpoResponse))
            {
                Android.Util.Log.Info("Companion", "NFC: GPO without PDOL failed, trying with PDOL");
                var Pdol = FindTag(AidResponse, 0x9F, 0x38);
                if (Pdol != null)
                {
                    var GpoWithPdol = BuildGpoWithPdol(Pdol);
                    GpoResponse = Iso.Transceive(GpoWithPdol);
                }
            }

            if (GpoResponse == null || !IsSuccess(GpoResponse)) return null;

            var Afl = FindTag(GpoResponse, 0x94);
            if (Afl == null)
            {
                var Template = FindTag(GpoResponse, 0x77);
                if (Template != null)
                {
                    Afl = FindTag(Template, 0x94);
                }
            }

            var Card = new CardData { Network = CardNetwork, Aid = SelectedAid != null ? ToHex(SelectedAid) : null, Amount = Amount };

            ExtractFromTlv(GpoResponse, Card);

            if (Afl != null)
            {
                for (var I = 0; I < Afl.Length; I += 4)
                {
                    var Sfi = (Afl[I] >> 3) & 0x1F;
                    var First = Afl[I + 1];
                    var Last = Afl[I + 2];

                    for (var Rec = First; Rec <= Last; Rec++)
                    {
                        var ReadCmd = new byte[] { 0x00, 0xB2, (byte)Rec, (byte)((Sfi << 3) | 4), 0x00 };
                        var RecResponse = Iso.Transceive(ReadCmd);
                        if (IsSuccess(RecResponse))
                        {
                            ExtractFromTlv(RecResponse!, Card);
                        }
                    }
                }
            }

            var Cdol1 = FindTag(GpoResponse, 0x8C);
            if (Cdol1 == null)
            {
                for (var I = 0; I < Afl?.Length; I += 4)
                {
                    var RecSfi = (Afl[I] >> 3) & 0x1F;
                    var RecFirst = Afl[I + 1];
                    var RecLast = Afl[I + 2];
                    for (var Rec = RecFirst; Rec <= RecLast && Cdol1 == null; Rec++)
                    {
                        var ReadCmd = new byte[] { 0x00, 0xB2, (byte)Rec, (byte)((RecSfi << 3) | 4), 0x00 };
                        var RecResp = Iso.Transceive(ReadCmd);
                        if (IsSuccess(RecResp))
                        {
                            Cdol1 = FindTag(RecResp!, 0x8C);
                        }
                    }
                }
            }

            if (Cdol1 != null)
            {
                var GenAcData = BuildCdolData(Cdol1, Card.Amount);
                var GenAcCmd = new byte[5 + GenAcData.Length];
                GenAcCmd[0] = 0x80;
                GenAcCmd[1] = 0xAE;
                GenAcCmd[2] = 0x80;
                GenAcCmd[3] = 0x00;
                GenAcCmd[4] = (byte)GenAcData.Length;
                System.Array.Copy(GenAcData, 0, GenAcCmd, 5, GenAcData.Length);

                Android.Util.Log.Info("Companion", $"NFC: GENERATE AC ({GenAcData.Length} bytes CDOL data)");
                var GenAcResponse = Iso.Transceive(GenAcCmd);

                if (IsSuccess(GenAcResponse))
                {
                    Android.Util.Log.Info("Companion", "NFC: GENERATE AC success");
                    var Arqc = FindTag(GenAcResponse!, 0x9F, 0x26);
                    var Cid = FindTag(GenAcResponse!, 0x9F, 0x27);
                    var Iad = FindTag(GenAcResponse!, 0x9F, 0x10);
                    var AtcTag = FindTag(GenAcResponse!, 0x9F, 0x36);

                    if (Arqc != null) Card.Arqc = ToHex(Arqc);
                    if (Cid != null)
                    {
                        Card.CryptogramInfoData = ToHex(Cid);
                        var CidByte = Cid[0];
                        var CryptoType = (CidByte >> 6) & 0x03;
                        Android.Util.Log.Info("Companion", $"NFC: Cryptogram type: {CryptoType switch { 2 => "ARQC", 1 => "TC", 0 => "AAC", _ => "Unknown" }}");
                    }
                    if (Iad != null) Card.IssuerApplicationData = ToHex(Iad);
                    if (AtcTag != null) Card.Atc = ToHex(AtcTag);

                    var AipTag = FindTag(GpoResponse!, 0x82);
                    if (AipTag != null) Card.Aip = ToHex(AipTag);

                    Card.IccDataHex = BuildIccData(Card, GenAcResponse!);
                }
                else
                {
                    Android.Util.Log.Info("Companion", "NFC: GENERATE AC failed, card may require online PIN");
                }
            }

            if (string.IsNullOrEmpty(Card.Pan) && Card.Track2 != null)
            {
                var Track2Hex = ToHex(Card.Track2);
                var SepIdx = Track2Hex.IndexOf('D');
                if (SepIdx > 0)
                {
                    Card.Pan = Track2Hex[..SepIdx].TrimEnd('F');
                    if (SepIdx + 4 <= Track2Hex.Length)
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
            Android.Util.Log.Info("Companion", $"NFC: Card read - {Card.MaskedPan} {Card.Network} exp:{Card.Expiry}");

            Iso.Close();
            return Card;
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"NFC read error: {Ex.Message}");
            try { Iso.Close(); } catch { }
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
    }

    private static System.Collections.Generic.List<byte[]> ExtractAids(byte[] PpseResponse)
    {
        var Aids = new System.Collections.Generic.List<byte[]>();
        var I = 0;
        while (I < PpseResponse.Length - 2)
        {
            if (PpseResponse[I] == 0x4F && I + 1 < PpseResponse.Length)
            {
                var Len = PpseResponse[I + 1];
                if (I + 2 + Len <= PpseResponse.Length)
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
        var DataLen = 0;
        for (var I = 0; I < Pdol.Length;)
        {
            if ((Pdol[I] & 0x1F) == 0x1F) I++;
            I++;
            if (I < Pdol.Length) DataLen += Pdol[I];
            I++;
        }

        var PdolData = new byte[DataLen];
        var Cmd = new byte[7 + DataLen];
        Cmd[0] = 0x80;
        Cmd[1] = 0xA8;
        Cmd[2] = 0x00;
        Cmd[3] = 0x00;
        Cmd[4] = (byte)(2 + DataLen);
        Cmd[5] = 0x83;
        Cmd[6] = (byte)DataLen;
        System.Array.Copy(PdolData, 0, Cmd, 7, DataLen);
        return Cmd;
    }

    private static byte[]? FindTag(byte[] Data, byte Tag1, byte Tag2 = 0)
    {
        for (var I = 0; I < Data.Length - 2;)
        {
            var IsMultiByte = (Data[I] & 0x1F) == 0x1F;
            byte T1 = Data[I];
            byte T2 = 0;
            I++;
            if (IsMultiByte && I < Data.Length)
            {
                T2 = Data[I];
                I++;
            }

            if (I >= Data.Length) break;
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

            if (I + Len > Data.Length) break;

            if (Tag2 == 0 && T1 == Tag1 && !IsMultiByte)
            {
                var Val = new byte[Len];
                System.Array.Copy(Data, I, Val, 0, Len);
                return Val;
            }

            if (Tag2 != 0 && T1 == Tag1 && T2 == Tag2)
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
                if (Found != null) return Found;
            }

            I += Len;
        }

        return null;
    }

    private static string IdentifyNetwork(byte[] Aid)
    {
        if (Aid.Length >= 5 && Aid[0] == 0xA0 && Aid[1] == 0x00 && Aid[2] == 0x00 && Aid[3] == 0x00)
        {
            if (Aid[4] == 0x03) return "Visa";
            if (Aid[4] == 0x04) return "Mastercard";
            if (Aid[4] == 0x25) return "AMEX";
            if (Aid[4] == 0x65) return "JCB";
        }

        return "Unknown";
    }

    private static byte[] BuildCdolData(byte[] Cdol, decimal Amount)
    {
        var Data = new System.Collections.Generic.List<byte>();
        var I = 0;
        while (I < Cdol.Length)
        {
            var Tag1 = Cdol[I++];
            var Tag2 = (byte)0;
            if ((Tag1 & 0x1F) == 0x1F && I < Cdol.Length) Tag2 = Cdol[I++];
            if (I >= Cdol.Length) break;
            var Len = Cdol[I++];

            if (Tag1 == 0x9F && Tag2 == 0x02)
            {
                var AmtBcd = ((long)(Amount * 100)).ToString("D12");
                for (var J = 0; J < AmtBcd.Length; J += 2)
                    Data.Add((byte)((AmtBcd[J] - '0') * 16 + (AmtBcd[J + 1] - '0')));
            }
            else if (Tag1 == 0x9F && Tag2 == 0x03)
            {
                for (var J = 0; J < Len; J++) Data.Add(0x00);
            }
            else if (Tag1 == 0x9F && Tag2 == 0x1A)
            {
                Data.Add(0x06); Data.Add(0x08);
            }
            else if (Tag1 == 0x5F && Tag2 == 0x2A)
            {
                Data.Add(0x06); Data.Add(0x08);
            }
            else if (Tag1 == 0x9A)
            {
                var Now = System.DateTime.UtcNow;
                Data.Add((byte)(((Now.Year % 100) / 10 * 16) + (Now.Year % 10)));
                Data.Add((byte)((Now.Month / 10 * 16) + (Now.Month % 10)));
                Data.Add((byte)((Now.Day / 10 * 16) + (Now.Day % 10)));
            }
            else if (Tag1 == 0x9C)
            {
                Data.Add(0x00);
            }
            else if (Tag1 == 0x9F && Tag2 == 0x37)
            {
                var Rng = new byte[Len];
                System.Security.Cryptography.RandomNumberGenerator.Fill(Rng);
                Data.AddRange(Rng);
            }
            else if (Tag1 == 0x9F && Tag2 == 0x35)
            {
                Data.Add(0x22);
            }
            else if (Tag1 == 0x9F && Tag2 == 0x45)
            {
                for (var J = 0; J < Len; J++) Data.Add(0x00);
            }
            else if (Tag1 == 0x9F && Tag2 == 0x34)
            {
                for (var J = 0; J < Len; J++) Data.Add(0x00);
            }
            else if (Tag1 == 0x9F && Tag2 == 0x66)
            {
                Data.Add(0x26); Data.Add(0x80); Data.Add(0x00); Data.Add(0x00);
                for (var J = 4; J < Len; J++) Data.Add(0x00);
            }
            else if (Tag1 == 0x95)
            {
                for (var J = 0; J < Len; J++) Data.Add(0x00);
            }
            else
            {
                for (var J = 0; J < Len; J++) Data.Add(0x00);
            }
        }

        return Data.ToArray();
    }

    private static string BuildIccData(CardData Card, byte[] GenAcResponse)
    {
        var Sb = new System.Text.StringBuilder();

        void AppendTlv(byte T1, byte T2, string? HexValue)
        {
            if (string.IsNullOrEmpty(HexValue)) return;
            var Bytes = System.Convert.FromHexString(HexValue);
            Sb.Append(T1.ToString("X2"));
            if (T2 != 0) Sb.Append(T2.ToString("X2"));
            Sb.Append(Bytes.Length.ToString("X2"));
            Sb.Append(HexValue);
        }

        AppendTlv(0x9F, 0x26, Card.Arqc);
        AppendTlv(0x9F, 0x27, Card.CryptogramInfoData);
        AppendTlv(0x9F, 0x10, Card.IssuerApplicationData);
        AppendTlv(0x9F, 0x36, Card.Atc);
        AppendTlv(0x9F, 0x37, ToHex(System.Security.Cryptography.RandomNumberGenerator.GetBytes(4)));

        var Now = System.DateTime.UtcNow;
        var DateBcd = $"{Now.Year % 100:D2}{Now.Month:D2}{Now.Day:D2}";
        Sb.Append("9A03").Append(DateBcd);
        Sb.Append("9C0100");

        var AmtHex = ((long)(Card.Amount * 100)).ToString("D12");
        Sb.Append("9F0206").Append(AmtHex);
        Sb.Append("9F030600000000000000");
        Sb.Append("9F1A020608");
        Sb.Append("5F2A020608");

        if (!string.IsNullOrEmpty(Card.Aip))
        {
            Sb.Append("82").Append((Card.Aip.Length / 2).ToString("X2")).Append(Card.Aip);
        }

        if (!string.IsNullOrEmpty(Card.Aid))
        {
            Sb.Append("84").Append((Card.Aid.Length / 2).ToString("X2")).Append(Card.Aid);
        }

        Sb.Append("9F3303E0F0C8");
        Sb.Append("9F3503220000".AsSpan(0, 8));
        Sb.Append("9F34030000");

        var Tvr = Card.Tvr ?? "0000000000";
        Sb.Append("9505").Append(Tvr);

        return Sb.ToString();
    }

    private static bool IsSuccess(byte[]? Response) =>
        Response is { Length: >= 2 } && Response[^2] == 0x90 && Response[^1] == 0x00;

    private static string MaskPan(string Pan) =>
        Pan.Length > 8 ? $"{Pan[..4]}{"".PadLeft(Pan.Length - 8, '*')}{Pan[^4..]}" : Pan;

    private static string ToHex(byte[] Bytes) =>
        System.Convert.ToHexString(Bytes);

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
        public string? CryptogramInfoData { get; set; }
        public string? IssuerApplicationData { get; set; }
        public string? Aip { get; set; }
        public string? Tvr { get; set; }
        public string? IccDataHex { get; set; }
        public string? Aid { get; set; }
        public decimal Amount { get; set; }
    }
}
