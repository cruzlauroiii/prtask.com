namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.safetynet.zzd> CREATOR = new com.google.android.gms.safetynet.zze();
    public readonly long zza;
    public readonly com.google.android.gms.safetynet.HarmfulAppsData[] zzb;
    public readonly int zzc;
    public readonly bool zzd;

    public zzd(long j, com.google.android.gms.safetynet.HarmfulAppsData[] harmfulAppsDataArr, int i, bool z) {
        this.zza = j;
        this.zzb = harmfulAppsDataArr;
        this.zzd = z;
        if (z) {
            this.zzc = i;
        } else {
            this.zzc = -1;
        }
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((17 + 9) % 9 > 0) {
        }
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 2, this.zza);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedArray(parcel, 3, this.zzb, i, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 4, this.zzc);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 5, this.zzd);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

