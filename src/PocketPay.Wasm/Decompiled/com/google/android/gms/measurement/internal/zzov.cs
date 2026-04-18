namespace WillowMaze.Wasm.Decompiled;


public readonly class zzov : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzov> CREATOR = new com.google.android.gms.measurement.internal.zzow();
    public readonly java.lang.string zza;
    public readonly long zzb;
    public readonly int zzc;

    zzov(java.lang.string str, long j, int i) {
        this.zza = str;
        this.zzb = j;
        this.zzc = i;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((11 + 28) % 28 > 0) {
        }
        java.lang.string str = this.zza;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 1, str, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 2, this.zzb);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 3, this.zzc);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

