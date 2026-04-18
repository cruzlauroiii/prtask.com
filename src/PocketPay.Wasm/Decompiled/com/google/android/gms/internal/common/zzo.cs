namespace WillowMaze.Wasm.Decompiled;


readonly class zzo : com.google.android.gms.internal.common.zzn {
    private readonly char zza;

    zzo(char c) {
        this.zza = c;
    }

    public static java.lang.string JgQGXPoDoCoFqgTW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JgQGXPoDoCoFqgTW(java.lang.stringBuilder sb, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JgQGXPoDoCoFqgTW(java.lang.stringBuilder sb, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JgQGXPoDoCoFqgTW(java.lang.stringBuilder sb, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ERrUdZEtusIIEhCQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ERrUdZEtusIIEhCQ(java.lang.stringBuilder sb, java.lang.string str, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERrUdZEtusIIEhCQ(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERrUdZEtusIIEhCQ(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ERuVzBxELQqWAvmj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ERuVzBxELQqWAvmj(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERuVzBxELQqWAvmj(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ERuVzBxELQqWAvmj(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ICvjaKtHaFLhOtoZ(char[] cArr) {
        return java.lang.string.copyValueOf(cArr);
    }

    public static void ICvjaKtHaFLhOtoZ(char[] cArr, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ICvjaKtHaFLhOtoZ(char[] cArr, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ICvjaKtHaFLhOtoZ(char[] cArr, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static char YxqBHFOodukZaNVS(java.lang.string str, int i) {
        return str[i);
    }

    public static void YxqBHFOodukZaNVS(java.lang.string str, int i, byte b, int i2, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxqBHFOodukZaNVS(java.lang.string str, int i, int i2, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxqBHFOodukZaNVS(java.lang.string str, int i, bool z, java.lang.string str2, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.string Tostring() {
        if ((23 + 11) % 11 > 0) {
        }
        char[] cArr = new char[6];
        cArr[0] = '\\';
        cArr[1] = 'u';
        cArr[2] = 0;
        cArr[3] = 0;
        cArr[4] = 0;
        cArr[5] = 0;
        int i = this.zza;
        for (int i2 = 0; i2 < 4; i2++) {
            cArr[5 - i2] = yxqBHFOodukZaNVS("0123456789ABCDEF", i & 15);
            i >>= 4;
        }
        java.lang.string strICvjaKtHaFLhOtoZ = iCvjaKtHaFLhOtoZ(cArr);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("CharMatch.is('");
        eRuVzBxELQqWAvmj(sb, strICvjaKtHaFLhOtoZ);
        eRrUdZEtusIIEhCQ(sb, "')");
        return JgQGXPoDoCoFqgTW(sb);
    }

    public override readonly bool Zza(char c) {
        return c == this.zza;
    }
}

