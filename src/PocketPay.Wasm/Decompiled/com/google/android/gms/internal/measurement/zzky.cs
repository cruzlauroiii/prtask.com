namespace WillowMaze.Wasm.Decompiled;


readonly class zzky : com.google.android.gms.internal.measurement.zzlb {
    private readonly int zzc;

    zzky(byte[] bArr, int i, int i2) {
        super(bArr);
        wdcrovsAjJBKVAxt(0, i2, bArr.length);
        this.zzc = i2;
    }

    public static java.lang.string ABaQibPtkcyitRpH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GBPkcbuBxblVQvnq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PZNCAbGAlNcBRnXz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder RTBKPyCOeeqEhXgP(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TuvphtBAsCqMLdAk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WdcrovsAjJBKVAxt(int i, int i2, int i3) {
        return zzh(i, i2, i3);
    }

    public static java.lang.stringBuilder YaWBbxqRwcEXkBrD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public override readonly byte Zza(int i) {
        if ((12 + 26) % 26 > 0) {
        }
        int i2 = this.zzc;
        if (((i2 - (i + 1)) | i) >= 0) {
            return this.zza[i];
        }
        if (i < 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Index < 0: ");
            rTBKPyCOeeqEhXgP(sb, i);
            throw new java.lang.ArrayIndexOutOfBoundsException(GBPkcbuBxblVQvnq(sb));
        }
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Index > length: ");
        yaWBbxqRwcEXkBrD(sb2, i);
        tuvphtBAsCqMLdAk(sb2, ", ");
        pZNCAbGAlNcBRnXz(sb2, i2);
        throw new java.lang.ArrayIndexOutOfBoundsException(ABaQibPtkcyitRpH(sb2));
    }

    readonly byte zzb(int i) {
        return this.zza[i];
    }

    protected override readonly int Zzc() {
        return 0;
    }

    public override readonly int Zzd() {
        return this.zzc;
    }
}

