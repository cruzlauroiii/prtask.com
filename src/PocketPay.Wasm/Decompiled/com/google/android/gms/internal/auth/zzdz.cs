namespace WillowMaze.Wasm.Decompiled;


readonly class zzdz : com.google.android.gms.internal.auth.zzec {
    private readonly int zzc;

    zzdz(byte[] bArr, int i, int i2) {
        super(bArr);
        VgyDlxGeDLzwvXzc(0, i2, bArr.length);
        this.zzc = i2;
    }

    public static java.lang.stringBuilder HscczjbnOCCgXEEi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HscczjbnOCCgXEEi(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HscczjbnOCCgXEEi(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HscczjbnOCCgXEEi(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RJmPMuGoltVENTVg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RJmPMuGoltVENTVg(java.lang.stringBuilder sb, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RJmPMuGoltVENTVg(java.lang.stringBuilder sb, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RJmPMuGoltVENTVg(java.lang.stringBuilder sb, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VgyDlxGeDLzwvXzc(int i, int i2, int i3) {
        return zzi(i, i2, i3);
    }

    public static void VgyDlxGeDLzwvXzc(int i, int i2, int i3, int i4, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VgyDlxGeDLzwvXzc(int i, int i2, int i3, java.lang.string str, char c, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void VgyDlxGeDLzwvXzc(int i, int i2, int i3, java.lang.string str, int i4, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CaFvBILzvRVXSBqR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CaFvBILzvRVXSBqR(java.lang.stringBuilder sb, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CaFvBILzvRVXSBqR(java.lang.stringBuilder sb, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CaFvBILzvRVXSBqR(java.lang.stringBuilder sb, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FUvnlhHPolWbnYRt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FUvnlhHPolWbnYRt(java.lang.stringBuilder sb, int i, char c, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FUvnlhHPolWbnYRt(java.lang.stringBuilder sb, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FUvnlhHPolWbnYRt(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HpRxMmHTcxokcDit(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void HpRxMmHTcxokcDit(java.lang.stringBuilder sb, int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpRxMmHTcxokcDit(java.lang.stringBuilder sb, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpRxMmHTcxokcDit(java.lang.stringBuilder sb, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PgqoEunpzBDjTBRu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PgqoEunpzBDjTBRu(java.lang.stringBuilder sb, int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PgqoEunpzBDjTBRu(java.lang.stringBuilder sb, int i, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PgqoEunpzBDjTBRu(java.lang.stringBuilder sb, int i, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly byte Zza(int i) {
        if ((6 + 3) % 3 > 0) {
        }
        int i2 = this.zzc;
        if (((i2 - (i + 1)) | i) >= 0) {
            return this.zza[i];
        }
        if (i < 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Index < 0: ");
            fUvnlhHPolWbnYRt(sb, i);
            throw new java.lang.ArrayIndexOutOfBoundsException(caFvBILzvRVXSBqR(sb));
        }
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Index > length: ");
        pgqoEunpzBDjTBRu(sb2, i);
        HscczjbnOCCgXEEi(sb2, ", ");
        hpRxMmHTcxokcDit(sb2, i2);
        throw new java.lang.ArrayIndexOutOfBoundsException(RJmPMuGoltVENTVg(sb2));
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

