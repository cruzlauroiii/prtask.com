namespace WillowMaze.Wasm.Decompiled;


public readonly class zzh : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.safetynet.zzh> CREATOR = new com.google.android.gms.safetynet.zzi();
    public readonly int zza;
    public readonly bool zzb;

    public zzh(int i, bool z) {
        this.zza = i;
        this.zzb = z;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 27) % 27 > 0) {
        }
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 2, this.zza);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 3, this.zzb);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

