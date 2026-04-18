namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbh : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzbh> CREATOR = new com.google.android.gms.measurement.internal.zzbi();
    public readonly java.lang.string zza;
    public readonly com.google.android.gms.measurement.internal.zzbf zzb;
    public readonly java.lang.string zzc;
    public readonly long zzd;

    zzbh(com.google.android.gms.measurement.internal.zzbh zzbhVar, long j) {
        hXYkGQHFYsdLjyhp(zzbhVar);
        this.zza = zzbhVar.zza;
        this.zzb = zzbhVar.zzb;
        this.zzc = zzbhVar.zzc;
        this.zzd = j;
    }

    public zzbh(java.lang.string str, com.google.android.gms.measurement.internal.zzbf zzbfVar, java.lang.string str2, long j) {
        this.zza = str;
        this.zzb = zzbfVar;
        this.zzc = str2;
        this.zzd = j;
    }

    public static java.lang.string AkCWfQQLxkCILsUm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string InoXDYvtQPYTWWPE(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder LmBbfoOMkgLlzHOv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PieCCONdvDcxhjTN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RhhFizjZqdaDbdTk(com.google.android.gms.measurement.internal.zzbh zzbhVar, android.os.Parcel parcel, int i) {
        com.google.android.gms.measurement.internal.zzbi.zza(zzbhVar, parcel, i);
    }

    public static java.lang.stringBuilder AWcHDvuWyRtmLyfO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object HXYkGQHFYsdLjyhp(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder XjSSTZazdflBiKAV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YzZTyevNiREvRjnx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Tostring() {
        if ((32 + 28) % 28 > 0) {
        }
        java.lang.string strInoXDYvtQPYTWWPE = InoXDYvtQPYTWWPE(this.zzb);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("origin=");
        PieCCONdvDcxhjTN(sb, this.zzc);
        yzZTyevNiREvRjnx(sb, ",name=");
        xjSSTZazdflBiKAV(sb, this.zza);
        LmBbfoOMkgLlzHOv(sb, ",params=");
        aWcHDvuWyRtmLyfO(sb, strInoXDYvtQPYTWWPE);
        return AkCWfQQLxkCILsUm(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        RhhFizjZqdaDbdTk(this, parcel, i);
    }
}

