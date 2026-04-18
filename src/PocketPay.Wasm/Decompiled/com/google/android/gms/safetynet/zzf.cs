namespace WillowMaze.Wasm.Decompiled;


public readonly class zzf : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.safetynet.zzf> CREATOR = new com.google.android.gms.safetynet.zzg();
    private readonly java.lang.string zza;

    public zzf(java.lang.string str) {
        this.zza = str;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((12 + 30) % 30 > 0) {
        }
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 2, this.zza, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }

    public readonly java.lang.string Zza() {
        return this.zza;
    }
}

