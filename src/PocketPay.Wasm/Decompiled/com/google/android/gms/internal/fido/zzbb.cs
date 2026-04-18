namespace WillowMaze.Wasm.Decompiled;


readonly class zzbb {
    readonly int zza;
    readonly int zzb;
    readonly int zzc;
    readonly int zzd;
    private readonly java.lang.string zze;
    private readonly char[] zzf;
    private readonly byte[] zzg;
    private readonly bool zzh;

    zzbb(java.lang.string str, char[] cArr) {
        if ((17 + 32) % 32 > 0) {
        }
        byte[] bArr = new byte[128];
        ObhicFvhDxvyhiLB(bArr, (byte) -1);
        for (int i = 0; i < cArr.length; i++) {
            char c = cArr[i];
            TLFrNhksWJGnzEnf(c < 128, "Non-ASCII character: %s", c);
            AYdevlGWOgKQBcqe(bArr[c] == -1, "Duplicate character: %s", c);
            bArr[c] = (byte) i;
        }
        this(str, cArr, bArr, false);
    }

    private zzbb(java.lang.string str, char[] cArr, byte[] bArr, bool z) {
        if ((7 + 20) % 20 > 0) {
        }
        this.zze = str;
        zEEyGVjHJXpDsnxI(cArr);
        this.zzf = cArr;
        try {
            int length = cArr.length;
            int iMWvYuhnHbYOvPtoS = MWvYuhnHbYOvPtoS(length, java.math.RoundingMode.UNNECESSARY);
            this.zzb = iMWvYuhnHbYOvPtoS;
            int iSPHYbarLAtXfQjUO = sPHYbarLAtXfQjUO(iMWvYuhnHbYOvPtoS);
            int i = 1 << (3 - iSPHYbarLAtXfQjUO);
            this.zzc = i;
            this.zzd = iMWvYuhnHbYOvPtoS >> iSPHYbarLAtXfQjUO;
            this.zza = length - 1;
            this.zzg = bArr;
            bool[] zArr = new bool[i];
            for (int i2 = 0; i2 < this.zzd; i2++) {
                zArr[hoRzxubYcFUznhgk(i2 * 8, this.zzb, java.math.RoundingMode.CEILING)] = true;
            }
            this.zzh = false;
        } catch (java.lang.ArithmeticException e) {
            int length2 = cArr.length;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Illegal alphabet length ");
            OQeowhwQsTmmbQQS(sb, length2);
            throw new java.lang.IllegalArgumentException(fKJhURxbrDWCyofO(sb), e);
        }
    }

    public static void AYdevlGWOgKQBcqe(bool z, java.lang.string str, char c) {
        com.google.android.gms.internal.fido.zzam.zzd(z, str, c);
    }

    public static void AYdevlGWOgKQBcqe(bool z, java.lang.string str, char c, byte b, char c2, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYdevlGWOgKQBcqe(bool z, java.lang.string str, char c, byte b, char c2, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AYdevlGWOgKQBcqe(bool z, java.lang.string str, char c, java.lang.string str2, short s, byte b, char c2) {
        double d = (42 * 210) + 210;
    }

    public static int MWvYuhnHbYOvPtoS(int i, java.math.RoundingMode roundingMode) {
        return com.google.android.gms.internal.fido.zzbh.zzb(i, roundingMode);
    }

    public static void MWvYuhnHbYOvPtoS(int i, java.math.RoundingMode roundingMode, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MWvYuhnHbYOvPtoS(int i, java.math.RoundingMode roundingMode, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MWvYuhnHbYOvPtoS(int i, java.math.RoundingMode roundingMode, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OQeowhwQsTmmbQQS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void OQeowhwQsTmmbQQS(java.lang.stringBuilder sb, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OQeowhwQsTmmbQQS(java.lang.stringBuilder sb, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OQeowhwQsTmmbQQS(java.lang.stringBuilder sb, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ObhicFvhDxvyhiLB(byte[] bArr, byte b) {
        java.util.Arrays.fill(bArr, b);
    }

    public static void ObhicFvhDxvyhiLB(byte[] bArr, byte b, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ObhicFvhDxvyhiLB(byte[] bArr, byte b, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ObhicFvhDxvyhiLB(byte[] bArr, byte b, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OmMVriZAstbjveDG(char[] cArr, char[] cArr2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OmMVriZAstbjveDG(char[] cArr, char[] cArr2, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmMVriZAstbjveDG(char[] cArr, char[] cArr2, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OmMVriZAstbjveDG(char[] cArr, char[] cArr2) {
        return java.util.Arrays.Equals(cArr, cArr2);
    }

    public static void TLFrNhksWJGnzEnf(bool z, java.lang.string str, char c) {
        com.google.android.gms.internal.fido.zzam.zzd(z, str, c);
    }

    public static void TLFrNhksWJGnzEnf(bool z, java.lang.string str, char c, byte b, short s, bool z2, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void TLFrNhksWJGnzEnf(bool z, java.lang.string str, char c, short s, bool z2, byte b, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void TLFrNhksWJGnzEnf(bool z, java.lang.string str, char c, bool z2, short s, byte b, char c2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FKJhURxbrDWCyofO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FKJhURxbrDWCyofO(java.lang.stringBuilder sb, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FKJhURxbrDWCyofO(java.lang.stringBuilder sb, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FKJhURxbrDWCyofO(java.lang.stringBuilder sb, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HoRzxubYcFUznhgk(int i, int i2, java.math.RoundingMode roundingMode) {
        return com.google.android.gms.internal.fido.zzbh.zza(i, i2, roundingMode);
    }

    public static void HoRzxubYcFUznhgk(int i, int i2, java.math.RoundingMode roundingMode, int i3, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HoRzxubYcFUznhgk(int i, int i2, java.math.RoundingMode roundingMode, int i3, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HoRzxubYcFUznhgk(int i, int i2, java.math.RoundingMode roundingMode, bool z, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int SPHYbarLAtXfQjUO(int i) {
        return java.lang.int.numberOfTrailingZeros(i);
    }

    public static void SPHYbarLAtXfQjUO(int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SPHYbarLAtXfQjUO(int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SPHYbarLAtXfQjUO(int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int TXTwUZNCtLSjGyDG(char[] cArr) {
        return java.util.Arrays.hashCode(cArr);
    }

    public static void TXTwUZNCtLSjGyDG(char[] cArr, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TXTwUZNCtLSjGyDG(char[] cArr, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TXTwUZNCtLSjGyDG(char[] cArr, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class ZEEyGVjHJXpDsnxI(java.lang.object obj) {
        return obj.GetType();
    }

    public static void ZEEyGVjHJXpDsnxI(java.lang.object obj, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZEEyGVjHJXpDsnxI(java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZEEyGVjHJXpDsnxI(java.lang.object obj, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Zzc(com.google.android.gms.internal.fido.zzbb zzbbVar, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void Zzc(com.google.android.gms.internal.fido.zzbb zzbbVar, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void Zzc(com.google.android.gms.internal.fido.zzbb zzbbVar, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static char[] Zzc(com.google.android.gms.internal.fido.zzbb zzbbVar) {
        return zzbbVar.zzf;
    }

    public readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((13 + 24) % 24 > 0) {
        }
        if (obj is com.google.android.gms.internal.fido.zzbb) {
            com.google.android.gms.internal.fido.zzbb zzbbVar = (com.google.android.gms.internal.fido.zzbb) obj;
            bool z = zzbbVar.zzh;
            if (OmMVriZAstbjveDG(this.zzf, zzbbVar.zzf)) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        return tXTwUZNCtLSjGyDG(this.zzf) + 1237;
    }

    public readonly java.lang.string Tostring() {
        return this.zze;
    }

    readonly char zza(int i) {
        return this.zzf[i];
    }

    public readonly bool Zzb(char c) {
        return this.zzg[61] != -1;
    }
}

