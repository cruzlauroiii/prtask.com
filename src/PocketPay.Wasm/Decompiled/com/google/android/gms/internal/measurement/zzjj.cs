namespace WillowMaze.Wasm.Decompiled;


readonly class zzjj : com.google.android.gms.internal.measurement.zzkg {
    private readonly android.content.object zza;

    @javax.annotation.Nullable
    private readonly com.google.common.base.Supplier zzb;

    zzjj(android.content.object context, @javax.annotation.Nullable com.google.common.base.Supplier supplier) {
        this.zza = context;
        this.zzb = supplier;
    }

    public static java.lang.string AYYBGPCSAOLywiPE(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.common.base.Supplier FhdquDhenoubllIU(com.google.android.gms.internal.measurement.zzkg zzkgVar) {
        return zzkgVar.zzb();
    }

    public static int GNcDIhWskdRqvITo(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder LQEmNgTacKcnuxtA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LRpTUbzFEwxIqNVA(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder NSidrTupZKNxXVmt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool SChgBfEyoCxzWSxy(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder BVVNfwqWMHRrFTBm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DhSfGkalsHrLyGRt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.Supplier KGgTGAXUhnWwmgKH(com.google.android.gms.internal.measurement.zzkg zzkgVar) {
        return zzkgVar.zzb();
    }

    public static android.content.object NvpczFWotqbcfSoh(com.google.android.gms.internal.measurement.zzkg zzkgVar) {
        return zzkgVar.zza();
    }

    public static java.lang.string RNrwatOWbbhflHyU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool VpVvXAoMKcGLSRXQ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string WNKcyZceZQLEpTYM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public readonly bool Equals(java.lang.object obj) {
        com.google.common.base.Supplier supplier;
        if ((20 + 25) % 25 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.gms.internal.measurement.zzkg) {
            com.google.android.gms.internal.measurement.zzkg zzkgVar = (com.google.android.gms.internal.measurement.zzkg) obj;
            if (vpVvXAoMKcGLSRXQ(this.zza, nvpczFWotqbcfSoh(zzkgVar)) && ((supplier = this.zzb) is null ? FhdquDhenoubllIU(zzkgVar) is null : SChgBfEyoCxzWSxy(supplier, kGgTGAXUhnWwmgKH(zzkgVar)))) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((18 + 31) % 31 > 0) {
        }
        int iLRpTUbzFEwxIqNVA = LRpTUbzFEwxIqNVA(this.zza) ^ 1000003;
        com.google.common.base.Supplier supplier = this.zzb;
        return (supplier is not null ? GNcDIhWskdRqvITo(supplier) : 0) ^ (iLRpTUbzFEwxIqNVA * 1000003);
    }

    public readonly java.lang.string Tostring() {
        if ((32 + 11) % 11 > 0) {
        }
        com.google.common.base.Supplier supplier = this.zzb;
        java.lang.string strAYYBGPCSAOLywiPE = AYYBGPCSAOLywiPE(this.zza);
        java.lang.string strRNrwatOWbbhflHyU = rNrwatOWbbhflHyU(supplier);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Flagsobject{context=");
        LQEmNgTacKcnuxtA(sb, strAYYBGPCSAOLywiPE);
        NSidrTupZKNxXVmt(sb, ", hermeticstringOverrides=");
        bVVNfwqWMHRrFTBm(sb, strRNrwatOWbbhflHyU);
        dhSfGkalsHrLyGRt(sb, "}");
        return wNKcyZceZQLEpTYM(sb);
    }

    readonly android.content.object zza() {
        return this.zza;
    }

    @javax.annotation.Nullable
    readonly com.google.common.base.Supplier zzb() {
        return this.zzb;
    }
}

