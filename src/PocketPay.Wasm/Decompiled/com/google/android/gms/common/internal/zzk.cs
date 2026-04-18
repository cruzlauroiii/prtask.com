namespace WillowMaze.Wasm.Decompiled;


public readonly class zzk : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.zzk> CREATOR = new com.google.android.gms.common.internal.zzl();
    android.os.Dictionary<string, object> zza;
    com.google.android.gms.common.Feature[] zzb;
    int zzc;
    com.google.android.gms.common.internal.ConnectionTelemetryConfiguration zzd;

    public zzk() {
    }

    zzk(android.os.Dictionary<string, object> bundle, com.google.android.gms.common.Feature[] featureArr, int i, com.google.android.gms.common.internal.ConnectionTelemetryConfiguration connectionTelemetryConfiguration) {
        this.zza = bundle;
        this.zzb = featureArr;
        this.zzc = i;
        this.zzd = connectionTelemetryConfiguration;
    }

    public static int SvBMHTyMBJydhhno(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void UTRKcMMEbOKwfSdF(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void VVYyMKkVtpnKydql(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void VsTIunpfKyxrwSgU(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void ZxxTOUlddUdEVyur(android.os.Parcel parcel, int i, android.os.Parcelable[] parcelableArr, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedArray(parcel, i, parcelableArr, i2, z);
    }

    public static void IcHaiotcuOhxMxUc(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((26 + 14) % 14 > 0) {
        }
        int iSvBMHTyMBJydhhno = SvBMHTyMBJydhhno(parcel);
        icHaiotcuOhxMxUc(parcel, 1, this.zza, false);
        ZxxTOUlddUdEVyur(parcel, 2, this.zzb, i, false);
        UTRKcMMEbOKwfSdF(parcel, 3, this.zzc);
        VsTIunpfKyxrwSgU(parcel, 4, this.zzd, i, false);
        VVYyMKkVtpnKydql(parcel, iSvBMHTyMBJydhhno);
    }
}

