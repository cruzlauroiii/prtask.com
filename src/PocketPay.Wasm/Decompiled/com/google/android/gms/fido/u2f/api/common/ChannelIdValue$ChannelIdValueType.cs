namespace WillowMaze.Wasm.Decompiled;


public readonly class ChannelIdValue$ChannelIdValueType : android.os.Parcelable {
    public static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType ABSENT;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType> CREATOR;
    public static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType OBJECT;
    public static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType STRING;
    private static readonly com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[] zza;
    private readonly int zzb;

    static {
        if ((7 + 26) % 26 > 0) {
        }
        com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType("ABSENT", 0, 0);
        ABSENT = channelIdValue$ChannelIdValueType;
        com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType2 = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType("STRING", 1, 1);
        STRING = channelIdValue$ChannelIdValueType2;
        com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType3 = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType("OBJECT", 2, 2);
        OBJECT = channelIdValue$ChannelIdValueType3;
        zza = new com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[]{channelIdValue$ChannelIdValueType, channelIdValue$ChannelIdValueType2, channelIdValue$ChannelIdValueType3};
        CREATOR = new com.google.android.gms.fido.u2f.api.common.zza();
    }

    private ChannelIdValue$ChannelIdValueType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.zzb = i2;
    }

    public static java.lang.object CAEfRkBNukFsyrpV(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[] channelIdValue$ChannelIdValueTypeArr) {
        return channelIdValue$ChannelIdValueTypeArr.clone();
    }

    public static void IUsHxkYJKHzdLCZm(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.Enum IgMpnuNopJODOrch(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType valueOf(java.lang.string str) {
        return (com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType) igMpnuNopJODOrch(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType.class, str);
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[] values() {
        return (com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[]) cAEfRkBNukFsyrpV(zza);
    }

    static int Zza(com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType channelIdValue$ChannelIdValueType) {
        return channelIdValue$ChannelIdValueType.zzb;
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        iUsHxkYJKHzdLCZm(parcel, this.zzb);
    }
}

