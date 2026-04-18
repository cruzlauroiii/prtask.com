using Android.App;
using Android.Content;
using Android.Nfc.CardEmulators;
using Android.OS;
using WillowMaze.Wasm.Companion.Services;

namespace WillowMaze.Wasm.Companion.Platforms.Android;

[Service(Exported = true, Permission = "android.permission.BIND_NFC_SERVICE")]
[IntentFilter(new[] { "android.nfc.cardemulation.action.HOST_APDU_SERVICE" })]
[MetaData("android.nfc.cardemulation.host_apdu_service", Resource = "@xml/hce_service")]
public class CardEmulationService : HostApduService
{
    private static byte[]? StoredPpseResponse;
    private static byte[]? StoredAidResponse;
    private static byte[]? StoredGpoResponse;
    private static byte[][]? StoredRecords;
    private static byte[]? StoredAid;
    private static bool IsActive;
    private int RecordIndex;

    public static void LoadCard(EmvCardReader.CardData Card)
    {
        if (Card.Pan == null || Card.Track2 == null) return;
        var AidBytes = Card.Aid != null ? System.Convert.FromHexString(Card.Aid) : new byte[] { 0xA0, 0x00, 0x00, 0x00, 0x04, 0x10, 0x10 };
        StoredAid = AidBytes;

        var PpseEntry = BuildTlv(0x61, Concat(BuildTlv(0x4F, AidBytes), BuildTlv(0x87, new byte[] { 0x01 })));
        StoredPpseResponse = Concat(BuildTlv(0x6F, Concat(BuildTlv(0x84, System.Text.Encoding.ASCII.GetBytes("2PAY.SYS.DDF01")), BuildTlv(0xA5, PpseEntry))), new byte[] { 0x90, 0x00 });

        var Track2Bytes = Card.Track2;
        var PanBcd = System.Convert.FromHexString(Card.Pan + (Card.Pan.Length % 2 != 0 ? "F" : ""));
        var ExpiryBcd = Card.Expiry != null ? System.Convert.FromHexString(Card.Expiry) : new byte[] { 0x29, 0x12 };

        var FciData = Concat(BuildTlv(0x84, AidBytes), BuildTlv(0xA5, Concat(BuildTlv(0x50, System.Text.Encoding.ASCII.GetBytes(Card.Network ?? "Card")), new byte[] { 0x87, 0x01, 0x01 })));
        StoredAidResponse = Concat(BuildTlv(0x6F, FciData), new byte[] { 0x90, 0x00 });

        var GpoData = Concat(new byte[] { 0x82, 0x02, 0x19, 0x80 }, BuildTlv(0x94, new byte[] { 0x08, 0x01, 0x01, 0x00 }), BuildTlv(0x57, Track2Bytes), BuildTlv(0x5A, PanBcd), BuildTlv(0x5F, 0x24, ExpiryBcd));
        StoredGpoResponse = Concat(BuildTlv(0x77, GpoData), new byte[] { 0x90, 0x00 });

        StoredRecords = new[] { Concat(BuildTlv(0x70, Concat(BuildTlv(0x57, Track2Bytes), BuildTlv(0x5A, PanBcd), BuildTlv(0x5F, 0x24, ExpiryBcd))), new byte[] { 0x90, 0x00 }) };
        IsActive = true;
        global::Android.Util.Log.Info("HCE", "Card loaded for emulation: " + Card.MaskedPan);
    }

    public static void Deactivate() { IsActive = false; }

    public override byte[]? ProcessCommandApdu(byte[]? Apdu, Bundle? Extras)
    {
        if (!IsActive || Apdu == null || Apdu.Length < 4) return new byte[] { 0x6F, 0x00 };
        var Ins = Apdu[1];
        global::Android.Util.Log.Info("HCE", $"APDU: INS={Ins:X2} len={Apdu.Length} data={System.Convert.ToHexString(Apdu)}");

        if (Ins == 0xA4 && Apdu.Length > 5)
        {
            var DataLen = Apdu[4];
            var Data = new byte[DataLen];
            System.Array.Copy(Apdu, 5, Data, 0, DataLen);
            if (DataLen == 14 && Data[0] == 0x32)
            {
                global::Android.Util.Log.Info("HCE", "SELECT PPSE -> " + (StoredPpseResponse?.Length ?? 0) + " bytes");
                RecordIndex = 0;
                return StoredPpseResponse ?? new byte[] { 0x6A, 0x82 };
            }
            if (StoredAid != null && DataLen == StoredAid.Length)
            {
                global::Android.Util.Log.Info("HCE", "SELECT AID -> " + (StoredAidResponse?.Length ?? 0) + " bytes");
                return StoredAidResponse ?? new byte[] { 0x6A, 0x82 };
            }
        }

        if (Ins == 0xA8)
        {
            global::Android.Util.Log.Info("HCE", "GPO -> " + (StoredGpoResponse?.Length ?? 0) + " bytes");
            return StoredGpoResponse ?? new byte[] { 0x69, 0x85 };
        }

        if (Ins == 0xB2 && StoredRecords != null)
        {
            var Idx = RecordIndex < StoredRecords.Length ? RecordIndex : 0;
            RecordIndex++;
            global::Android.Util.Log.Info("HCE", $"READ RECORD [{Idx}] -> {StoredRecords[Idx].Length} bytes");
            return StoredRecords[Idx];
        }

        if (Ins == 0xAE)
        {
            global::Android.Util.Log.Info("HCE", "GENERATE AC -> returning ARQC stub");
            var Arqc = new byte[8]; new System.Random().NextBytes(Arqc);
            var AcData = Concat(BuildTlv(0x9F, 0x27, new byte[] { 0x80 }), BuildTlv(0x9F, 0x26, Arqc), BuildTlv(0x9F, 0x36, new byte[] { 0x00, 0x01 }));
            return Concat(BuildTlv(0x77, AcData), new byte[] { 0x90, 0x00 });
        }

        return new byte[] { 0x6D, 0x00 };
    }

    public override void OnDeactivated(DeactivationReason Reason)
    {
        global::Android.Util.Log.Info("HCE", $"Deactivated: {Reason}");
    }

    private static byte[] BuildTlv(byte Tag, byte[] Value)
    {
        var R = new byte[2 + Value.Length];
        R[0] = Tag; R[1] = (byte)Value.Length;
        System.Array.Copy(Value, 0, R, 2, Value.Length);
        return R;
    }

    private static byte[] BuildTlv(byte Tag1, byte Tag2, byte[] Value)
    {
        var R = new byte[3 + Value.Length];
        R[0] = Tag1; R[1] = Tag2; R[2] = (byte)Value.Length;
        System.Array.Copy(Value, 0, R, 3, Value.Length);
        return R;
    }

    private static byte[] Concat(params byte[][] Arrays)
    {
        var Len = 0;
        foreach (var A in Arrays) Len += A.Length;
        var R = new byte[Len];
        var Off = 0;
        foreach (var A in Arrays) { System.Array.Copy(A, 0, R, Off, A.Length); Off += A.Length; }
        return R;
    }
}
