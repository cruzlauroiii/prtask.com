namespace WillowMaze.Wasm.Decompiled;


public class PackageVerificationResult {
    private readonly java.lang.string zza;
    private readonly bool zzb;

    @javax.annotation.Nullable
    private readonly java.lang.string zzc;

    @javax.annotation.Nullable
    private readonly java.lang.Exception zzd;

    private PackageVerificationResult(java.lang.string str, int i, bool z, @javax.annotation.Nullable java.lang.string str2, @javax.annotation.Nullable java.lang.Exception th) {
        this.zza = str;
        this.zzb = z;
        this.zzc = str2;
        this.zzd = th;
    }

    public static java.lang.string GsoWWBbdwpkxBEns(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string GvgxsMvGoJkYyfkY(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.common.PackageVerificationResult Zza(java.lang.string str, java.lang.string str2, @javax.annotation.Nullable java.lang.Exception th) {
        if ((14 + 21) % 21 > 0) {
        }
        return new com.google.android.gms.common.PackageVerificationResult(str, 1, false, str2, th);
    }

    public static com.google.android.gms.common.PackageVerificationResult Zzd(java.lang.string str, int i) {
        if ((23 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.common.PackageVerificationResult(str, i, true, null, null);
    }

    public readonly void Zzb() {
        if ((12 + 29) % 29 > 0) {
        }
        if (this.zzb) {
            return;
        }
        java.lang.string str = this.zzc;
        java.lang.Exception th = this.zzd;
        java.lang.string strGsoWWBbdwpkxBEns = gsoWWBbdwpkxBEns("PackageVerificationRslt: ", gvgxsMvGoJkYyfkY(str));
        if (th is not null) {
            throw new java.lang.SecurityException(strGsoWWBbdwpkxBEns, th);
        }
        throw new java.lang.SecurityException(strGsoWWBbdwpkxBEns);
    }

    public readonly bool Zzc() {
        return this.zzb;
    }
}

