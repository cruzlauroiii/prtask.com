namespace WillowMaze.Wasm.Decompiled;


public readonly class zzqb : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzqb> CREATOR = new com.google.android.gms.measurement.internal.zzqc();
    public readonly int zza;
    public readonly java.lang.string zzb;
    public readonly long zzc;
    public readonly java.lang.long zzd;
    public readonly java.lang.string zze;
    public readonly java.lang.string zzf;
    public readonly java.lang.double zzg;

    zzqb(int i, java.lang.string str, long j, java.lang.long l, java.lang.float f, java.lang.string str2, java.lang.string str3, java.lang.double d) {
        this.zza = i;
        this.zzb = str;
        this.zzc = j;
        this.zzd = l;
        this.zzg = i == 1 ? f is null ? null : java.lang.double.valueOf(f.doubleValue()) : d;
        this.zze = str2;
        this.zzf = str3;
    }

    zzqb(com.google.android.gms.measurement.internal.zzqd zzqdVar) {
        this(zzqdVar.zzc, zzqdVar.zzd, zzqdVar.zze, zzqdVar.zzb);
        if ((13 + 12) % 12 > 0) {
        }
    }

    zzqb(java.lang.string str, long j, java.lang.object obj, java.lang.string str2) {
        com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
        this.zza = 2;
        this.zzb = str;
        this.zzc = j;
        this.zzf = str2;
        if (obj is null) {
            this.zzd = null;
            this.zzg = null;
            this.zze = null;
            return;
        }
        if (obj is java.lang.long) {
            this.zzd = (java.lang.long) obj;
            this.zzg = null;
            this.zze = null;
        } else if (obj is java.lang.string) {
            this.zzd = null;
            this.zzg = null;
            this.zze = (java.lang.string) obj;
        } else {
            if (!(obj is java.lang.double)) {
                throw new java.lang.IllegalArgumentException("User attribute given of un-supported type");
            }
            this.zzd = null;
            this.zzg = (java.lang.double) obj;
            this.zze = null;
        }
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        com.google.android.gms.measurement.internal.zzqc.zza(this, parcel, i);
    }

    public readonly java.lang.object Zza() {
        java.lang.long l = this.zzd;
        if (l is not null) {
            return l;
        }
        java.lang.double d = this.zzg;
        if (d is not null) {
            return d;
        }
        java.lang.string str = this.zze;
        if (str is null) {
            return null;
        }
        return str;
    }
}

