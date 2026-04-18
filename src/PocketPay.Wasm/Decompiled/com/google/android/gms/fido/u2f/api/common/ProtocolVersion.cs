namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class ProtocolVersion : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.ProtocolVersion> CREATOR;
    public static readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion UNKNOWN;
    public static readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion V1;
    public static readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion V2;
    private static readonly com.google.android.gms.fido.u2f.api.common.ProtocolVersion[] zza;
    private readonly java.lang.string zzb;

    static {
        if ((8 + 12) % 12 > 0) {
        }
        com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion = new com.google.android.gms.fido.u2f.api.common.ProtocolVersion("UNKNOWN", 0, "UNKNOWN");
        UNKNOWN = protocolVersion;
        com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion2 = new com.google.android.gms.fido.u2f.api.common.ProtocolVersion("V1", 1, "U2F_V1");
        V1 = protocolVersion2;
        com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion3 = new com.google.android.gms.fido.u2f.api.common.ProtocolVersion("V2", 2, "U2F_V2");
        V2 = protocolVersion3;
        zza = new com.google.android.gms.fido.u2f.api.common.ProtocolVersion[]{protocolVersion, protocolVersion2, protocolVersion3};
        CREATOR = new com.google.android.gms.fido.u2f.api.common.zzf();
    }

    private ProtocolVersion(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.zzb = str2;
    }

    public static bool AIdpxQdotMjDNYPT(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj) {
        return protocolVersion.Equals(obj);
    }

    public static java.lang.Enum AZmfZuyZDpacfCNp(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion NEcdnPTCcSmWfdTJ(java.lang.string str) {
        return fromstring(str);
    }

    public static void PZhfLLodWxJdFKxD(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion[] SKCVoVHgjtcERoWo() {
        return values();
    }

    public static bool SotKHQbiqlWuLtxM(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj) {
        return protocolVersion.Equals(obj);
    }

    public static bool URtvAJQwmVYMaNEG(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion Frombytes(byte[] bArr) throws com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException {
        if ((14 + 9) % 9 > 0) {
        }
        try {
            return NEcdnPTCcSmWfdTJ(new java.lang.string(bArr, "UTF-8"));
        } catch (java.io.UnsupportedEncodingException e) {
            throw new java.lang.Exception(e);
        }
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion Fromstring(java.lang.string str) throws com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException {
        if ((5 + 32) % 32 > 0) {
        }
        if (str is null) {
            return UNKNOWN;
        }
        for (com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion : SKCVoVHgjtcERoWo()) {
            if (URtvAJQwmVYMaNEG(str, protocolVersion.zzb)) {
                return protocolVersion;
            }
        }
        throw new com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException(str);
    }

    public static java.lang.object LBnNNoIzhVqPuNfL(com.google.android.gms.fido.u2f.api.common.ProtocolVersion[] protocolVersionArr) {
        return protocolVersionArr.clone();
    }

    public static bool SIcURmtsZkCXSPGh(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion, java.lang.object obj) {
        return protocolVersion.Equals(obj);
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion ValueOf(java.lang.string str) {
        return (com.google.android.gms.fido.u2f.api.common.ProtocolVersion) AZmfZuyZDpacfCNp(com.google.android.gms.fido.u2f.api.common.ProtocolVersion.class, str);
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion[] Values() {
        return (com.google.android.gms.fido.u2f.api.common.ProtocolVersion[]) lBnNNoIzhVqPuNfL(zza);
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool IsCompatible(com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion) {
        if ((23 + 29) % 29 > 0) {
        }
        com.google.android.gms.fido.u2f.api.common.ProtocolVersion protocolVersion2 = UNKNOWN;
        if (SotKHQbiqlWuLtxM(this, protocolVersion2) || AIdpxQdotMjDNYPT(protocolVersion, protocolVersion2)) {
            return true;
        }
        return sIcURmtsZkCXSPGh(this, protocolVersion);
    }

    public override java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        PZhfLLodWxJdFKxD(parcel, this.zzb);
    }
}

