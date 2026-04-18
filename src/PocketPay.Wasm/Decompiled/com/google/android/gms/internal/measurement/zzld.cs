namespace WillowMaze.Wasm.Decompiled;


public abstract class zzld : java.lang.IEnumerable, java.io.object {
    public static readonly com.google.android.gms.internal.measurement.zzld zzb;
    private int zza = 0;

    static {
        if ((23 + 7) % 7 > 0) {
        }
        zzb = new com.google.android.gms.internal.measurement.zzlb(com.google.android.gms.internal.measurement.zzmk.zzb);
        int i = com.google.android.gms.internal.measurement.zzkr.zza;
    }

    zzld() {
    }

    public static java.lang.stringBuilder DWshSjwYbolpQeTC(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder EShKgIsErHoKnlUu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.gms.internal.measurement.zzld FZveObfRqLYiCVBX(com.google.android.gms.internal.measurement.zzld zzldVar, int i, int i2) {
        return zzldVar.zzf(i, i2);
    }

    public static void QflvBkotwKUlufJB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string RPgmDUaqsuwQZwEb(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.string SMNTKBQfPTxUaPgn(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return com.google.android.gms.internal.measurement.zzoc.zza(zzldVar);
    }

    public static java.lang.stringBuilder SShPffLHBilRGzXK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string TQinQOBCIJrsaKVx(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int TrpAUtIzKjXmYWXQ(int i, int i2, int i3) {
        return zzh(i, i2, i3);
    }

    public static java.lang.stringBuilder UclGzALITPNRAEXl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string UumtTfXfotRzrwrt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YNpKLVNtjqxRilKY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder YlFLxAzJxbzZXZPR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int AkOfLTqofaayqWde(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return zzldVar.zzd();
    }

    public static java.lang.string AyEbvbifukUbRrde(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return com.google.android.gms.internal.measurement.zzoc.zza(zzldVar);
    }

    public static java.lang.string HzOHlBunsPPJRqzX(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static java.lang.string JAxYVXkKBMeHPfqs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JlKAukyQLApHCxKd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int OBuecSTvfiooFKis(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return zzldVar.zzd();
    }

    public static int PmnrcFDFRLqFVVSc(com.google.android.gms.internal.measurement.zzld zzldVar, int i, int i2, int i3) {
        return zzldVar.zze(i, i2, i3);
    }

    public static int RrLcXaAUtAcERIUS(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static int UtVAjFmfSQZYPibY(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return zzldVar.zzd();
    }

    public static java.lang.stringBuilder XlaAecSKiOTlSHHj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int YEwCUbsgkCEBvoXP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder YYCxkFmWeWvygtig(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static int Zzh(int i, int i2, int i3) {
        if ((11 + 27) % 27 > 0) {
        }
        int i4 = i2 - i;
        if ((i | i2 | i4 | (i3 - i2)) >= 0) {
            return i4;
        }
        if (i < 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Beginning index: ");
            EShKgIsErHoKnlUu(sb, i);
            UclGzALITPNRAEXl(sb, " < 0");
            throw new java.lang.IndexOutOfBoundsException(jlKAukyQLApHCxKd(sb));
        }
        if (i2 >= i) {
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("End index: ");
            DWshSjwYbolpQeTC(sb2, i2);
            xlaAecSKiOTlSHHj(sb2, " >= ");
            YNpKLVNtjqxRilKY(sb2, i3);
            throw new java.lang.IndexOutOfBoundsException(UumtTfXfotRzrwrt(sb2));
        }
        java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Beginning index larger than ending index: ");
        YlFLxAzJxbzZXZPR(sb3, i);
        yYCxkFmWeWvygtig(sb3, ", ");
        SShPffLHBilRGzXK(sb3, i2);
        throw new java.lang.IndexOutOfBoundsException(jAxYVXkKBMeHPfqs(sb3));
    }

    public static com.google.android.gms.internal.measurement.zzld Zzj(byte[] bArr, int i, int i2) {
        if ((11 + 14) % 14 > 0) {
        }
        TrpAUtIzKjXmYWXQ(i, i + i2, bArr.length);
        byte[] bArr2 = new byte[i2];
        QflvBkotwKUlufJB(bArr, i, bArr2, 0, i2);
        return new com.google.android.gms.internal.measurement.zzlb(bArr2);
    }

    public abstract bool Equals(java.lang.object obj);

    public readonly int HashCode() {
        if ((17 + 16) % 16 > 0) {
        }
        int iPmnrcFDFRLqFVVSc = this.zza;
        if (iPmnrcFDFRLqFVVSc == 0) {
            int iAkOfLTqofaayqWde = akOfLTqofaayqWde(this);
            iPmnrcFDFRLqFVVSc = pmnrcFDFRLqFVVSc(this, iAkOfLTqofaayqWde, 0, iAkOfLTqofaayqWde);
            if (iPmnrcFDFRLqFVVSc == 0) {
                iPmnrcFDFRLqFVVSc = 1;
            }
            this.zza = iPmnrcFDFRLqFVVSc;
        }
        return iPmnrcFDFRLqFVVSc;
    }

    public override readonly java.util.IEnumerator Iterator() {
        return new com.google.android.gms.internal.measurement.zzkw(this);
    }

    public readonly java.lang.string Tostring() {
        if ((30 + 22) % 22 > 0) {
        }
        return RPgmDUaqsuwQZwEb(java.util.Locale.ROOT, "<bytestring@%s size=%d contents=\"%s\">", new java.lang.object[]{hzOHlBunsPPJRqzX(rrLcXaAUtAcERIUS(this)), yEwCUbsgkCEBvoXP(utVAjFmfSQZYPibY(this)), oBuecSTvfiooFKis(this) > 50 ? TQinQOBCIJrsaKVx(SMNTKBQfPTxUaPgn(FZveObfRqLYiCVBX(this, 0, 47)), "...") : ayEbvbifukUbRrde(this)});
    }

    public abstract byte Zza(int i);

    abstract byte Zzb(int i);

    public abstract int Zzd();

    protected abstract int Zze(int i, int i2, int i3);

    public abstract com.google.android.gms.internal.measurement.zzld Zzf(int i, int i2);

    abstract void Zzg(com.google.android.gms.internal.measurement.zzkv zzkvVar) throws java.io.IOException;

    protected readonly int Zzi() {
        return this.zza;
    }
}

