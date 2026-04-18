namespace WillowMaze.Wasm.Decompiled;


public readonly class zzpa : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzpa> CREATOR = new com.google.android.gms.measurement.internal.zzpb();
    public readonly long zza;
    public byte[] zzb;
    public readonly java.lang.string zzc;
    public readonly android.os.Dictionary<string, object> zzd;
    public readonly int zze;
    public readonly long zzf;
    public java.lang.string zzg;

    zzpa(long j, byte[] bArr, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, long j2, java.lang.string str2) {
        this.zza = j;
        this.zzb = bArr;
        this.zzc = str;
        this.zzd = bundle;
        this.zze = i;
        this.zzf = j2;
        this.zzg = str2;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 24) % 24 > 0) {
        }
        long j = this.zza;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 1, j);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, 2, this.zzb, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 3, this.zzc, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, 4, this.zzd, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 5, this.zze);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 6, this.zzf);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 7, this.zzg, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

