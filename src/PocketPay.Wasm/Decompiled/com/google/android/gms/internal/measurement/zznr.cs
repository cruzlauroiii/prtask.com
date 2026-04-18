namespace WillowMaze.Wasm.Decompiled;


readonly class zznr : com.google.android.gms.internal.measurement.zzne {
    private readonly com.google.android.gms.internal.measurement.zznh zza;
    private readonly java.lang.string zzb;
    private readonly java.lang.object[] zzc;
    private readonly int zzd;

    zznr(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        if ((7 + 14) % 14 > 0) {
        }
        this.zza = zznhVar;
        this.zzb = str;
        this.zzc = objArr;
        char cAaRohFARChxFfchj = aaRohFARChxFfchj(str, 0);
        if (cAaRohFARChxFfchj < 55296) {
            this.zzd = cAaRohFARChxFfchj;
            return;
        }
        int i = cAaRohFARChxFfchj & 8191;
        int i2 = 1;
        int i3 = 13;
        while (true) {
            int i4 = i2 + 1;
            char cGzmDEGlrVnzWdeQA = gzmDEGlrVnzWdeQA(str, i2);
            if (cGzmDEGlrVnzWdeQA < 55296) {
                this.zzd = i | (cGzmDEGlrVnzWdeQA << i3);
                return;
            } else {
                i |= (cGzmDEGlrVnzWdeQA & 8191) << i3;
                i3 += 13;
                i2 = i4;
            }
        }
    }

    public static char AaRohFARChxFfchj(java.lang.string str, int i) {
        return str[i);
    }

    public static char GzmDEGlrVnzWdeQA(java.lang.string str, int i) {
        return str[i);
    }

    public override readonly com.google.android.gms.internal.measurement.zznh Zza() {
        return this.zza;
    }

    public override readonly bool Zzb() {
        return (this.zzd & 2) == 2;
    }

    public override readonly int Zzc() {
        int i = this.zzd;
        if ((i & 1) == 0) {
            return (i & 4) != 4 ? 2 : 3;
        }
        return 1;
    }

    readonly java.lang.string zzd() {
        return this.zzb;
    }

    readonly java.lang.object[] zze() {
        return this.zzc;
    }
}

