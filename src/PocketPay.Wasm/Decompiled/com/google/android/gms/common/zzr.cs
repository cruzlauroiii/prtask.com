namespace WillowMaze.Wasm.Decompiled;


public readonly class zzr : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.zzr> CREATOR = new com.google.android.gms.common.zzb();
    private readonly bool zza;
    private readonly bool zzb;

    zzr(bool z, bool z2) {
        this.zza = z;
        this.zzb = z2;
    }

    public static void AFvxFgAUWZSmwGbx(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void JDxKufBTxcpjtjxF(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void AkrNXTepeXJVehNg(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int ZnjEORKGSQEpCkaZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((10 + 18) % 18 > 0) {
        }
        int iZnjEORKGSQEpCkaZ = znjEORKGSQEpCkaZ(parcel);
        JDxKufBTxcpjtjxF(parcel, 1, this.zza);
        akrNXTepeXJVehNg(parcel, 2, this.zzb);
        AFvxFgAUWZSmwGbx(parcel, iZnjEORKGSQEpCkaZ);
    }
}

