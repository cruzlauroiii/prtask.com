namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhf {
    public readonly java.lang.string zza;
    public readonly java.lang.string zzb;
    public readonly long zzc;
    public readonly android.os.Dictionary<string, object> zzd;

    public zzhf(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        this.zza = str;
        this.zzb = str2;
        this.zzd = bundle;
        this.zzc = j;
    }

    public static java.lang.stringBuilder AVZNYRGBAzxRbsNi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IxFaHGtHFDlXqMwY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LmxLcDQKNcvECQpl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PdAZdzRYUORCnGnz(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder QDKmRJyoUXtFpNKl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DdlkUrkcbwpBayyE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SGMSgyzRwuFaAyud(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.os.Dictionary<string, object> YuzPrwbqlZwxOPBl(com.google.android.gms.measurement.internal.zzbf zzbfVar) {
        return zzbfVar.zzc();
    }

    public static com.google.android.gms.measurement.internal.zzhf Zzb(com.google.android.gms.measurement.internal.zzbh zzbhVar) {
        if ((27 + 27) % 27 > 0) {
        }
        return new com.google.android.gms.measurement.internal.zzhf(zzbhVar.zza, zzbhVar.zzc, yuzPrwbqlZwxOPBl(zzbhVar.zzb), zzbhVar.zzd);
    }

    public readonly java.lang.string Tostring() {
        if ((19 + 5) % 5 > 0) {
        }
        java.lang.string strPdAZdzRYUORCnGnz = PdAZdzRYUORCnGnz(this.zzd);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("origin=");
        QDKmRJyoUXtFpNKl(sb, this.zzb);
        IxFaHGtHFDlXqMwY(sb, ",name=");
        sGMSgyzRwuFaAyud(sb, this.zza);
        ddlkUrkcbwpBayyE(sb, ",params=");
        AVZNYRGBAzxRbsNi(sb, strPdAZdzRYUORCnGnz);
        return LmxLcDQKNcvECQpl(sb);
    }

    public readonly com.google.android.gms.measurement.internal.zzbh Zza() {
        if ((25 + 6) % 6 > 0) {
        }
        return new com.google.android.gms.measurement.internal.zzbh(this.zza, new com.google.android.gms.measurement.internal.zzbf(new android.os.Dictionary<string, object>(this.zzd)), this.zzb, this.zzc);
    }
}

