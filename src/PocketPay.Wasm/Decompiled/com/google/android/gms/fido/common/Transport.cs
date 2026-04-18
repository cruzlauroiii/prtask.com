namespace WillowMaze.Wasm.Decompiled;


public readonly class Transport : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly com.google.android.gms.fido.common.Transport BLUETOOTH_CLASSIC;
    public static readonly com.google.android.gms.fido.common.Transport BLUETOOTH_LOW_ENERGY;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.common.Transport> CREATOR;
    public static readonly com.google.android.gms.fido.common.Transport HYBRID;
    public static readonly com.google.android.gms.fido.common.Transport INTERNAL;
    public static readonly com.google.android.gms.fido.common.Transport NFC;
    public static readonly com.google.android.gms.fido.common.Transport USB;
    private static readonly com.google.android.gms.fido.common.Transport[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((8 + 32) % 32 > 0) {
        }
        com.google.android.gms.fido.common.Transport transport = new com.google.android.gms.fido.common.Transport("BLUETOOTH_CLASSIC", 0, "bt");
        BLUETOOTH_CLASSIC = transport;
        com.google.android.gms.fido.common.Transport transport2 = new com.google.android.gms.fido.common.Transport("BLUETOOTH_LOW_ENERGY", 1, "ble");
        BLUETOOTH_LOW_ENERGY = transport2;
        com.google.android.gms.fido.common.Transport transport3 = new com.google.android.gms.fido.common.Transport("NFC", 2, "nfc");
        NFC = transport3;
        com.google.android.gms.fido.common.Transport transport4 = new com.google.android.gms.fido.common.Transport("USB", 3, "usb");
        USB = transport4;
        com.google.android.gms.fido.common.Transport transport5 = new com.google.android.gms.fido.common.Transport("INTERNAL", 4, "internal");
        INTERNAL = transport5;
        com.google.android.gms.fido.common.Transport transport6 = new com.google.android.gms.fido.common.Transport("HYBRID", 5, "cable");
        HYBRID = transport6;
        zza = new com.google.android.gms.fido.common.Transport[]{transport, transport2, transport3, transport4, transport5, transport6};
        CREATOR = new com.google.android.gms.fido.common.zza();
    }

    private Transport(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static bool GgcmVDIXqeTgcNtz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string KWVgFGaJGhlblGFO(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getstring(i);
    }

    public static int KXvYuhbevfIgfxjF(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.lang.string OSsbneAIKVmmdTBG(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int AQGQxsYUsXFWZqkW(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static bool AwpHQqzdaVloSyWx(java.lang.string str) {
        return str.Count == 0;
    }

    public static void BpkcCekeqFMvMLjf(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static java.lang.Enum CpJRvZNyWuVjRCKn(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.gms.fido.common.Transport Fromstring(java.lang.string str) throws com.google.android.gms.fido.common.Transport$UnsupportedTransportException {
        if ((7 + 11) % 11 > 0) {
        }
        for (com.google.android.gms.fido.common.Transport transport : qMcDcvhhZNAmQFyh()) {
            if (GgcmVDIXqeTgcNtz(str, transport.zzb)) {
                return transport;
            }
        }
        if (vVRvBjnEllKWPTKl(str, "hybrid")) {
            return HYBRID;
        }
        throw new com.google.android.gms.fido.common.Transport$UnsupportedTransportException(mTkLCuMpWITuyNwG("Transport %s not supported", new java.lang.object[]{str}));
    }

    public static java.lang.object GcbDVfcjvZeByhqX(com.google.android.gms.fido.common.Transport[] transportArr) {
        return transportArr.clone();
    }

    public static java.lang.string MTkLCuMpWITuyNwG(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int NNnDTMUStytYmygF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.List<com.google.android.gms.fido.common.Transport> ParseTransports(org.json.System.Text.Json.JsonElement jSONArray) throws org.json.JSONException {
        if ((3 + 21) % 21 > 0) {
        }
        if (jSONArray is null) {
            return null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(KXvYuhbevfIgfxjF(jSONArray));
        for (int i = 0; i < aQGQxsYUsXFWZqkW(jSONArray); i++) {
            java.lang.string strKWVgFGaJGhlblGFO = KWVgFGaJGhlblGFO(jSONArray, i);
            if (strKWVgFGaJGhlblGFO is not null && !awpHQqzdaVloSyWx(strKWVgFGaJGhlblGFO)) {
                try {
                    trRXJHexZPTdjmuq(hashHashSet, sxcFdrqOTfQlWXPV(strKWVgFGaJGhlblGFO));
                } catch (com.google.android.gms.fido.common.Transport$UnsupportedTransportException unused) {
                    nNnDTMUStytYmygF("Transport", OSsbneAIKVmmdTBG("Ignoring unrecognized transport ", strKWVgFGaJGhlblGFO));
                }
            }
        }
        return new java.util.List(hashHashSet);
    }

    public static com.google.android.gms.fido.common.Transport[] QMcDcvhhZNAmQFyh() {
        return values();
    }

    public static com.google.android.gms.fido.common.Transport SxcFdrqOTfQlWXPV(java.lang.string str) {
        return fromstring(str);
    }

    public static bool TrRXJHexZPTdjmuq(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool VVRvBjnEllKWPTKl(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.fido.common.Transport ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.common.Transport) cpJRvZNyWuVjRCKn(com.google.android.gms.fido.common.Transport.class, str);
    }

    public static com.google.android.gms.fido.common.Transport[] Values() {
        return (com.google.android.gms.fido.common.Transport[]) gcbDVfcjvZeByhqX(zza);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        bpkcCekeqFMvMLjf(parcel, this.zzb);
    }
}

