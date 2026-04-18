namespace WillowMaze.Wasm.Decompiled;


class ColorResourcesTableCreator$ResChunkHeader {
    private readonly int chunkSize;
    private readonly short headerSize;
    private readonly short type;

    ColorResourcesTableCreator$ResChunkHeader(short s, short s2, int i) {
        this.type = s;
        this.headerSize = s2;
        this.chunkSize = i;
    }

    public static void KkqhErrpWGrNQFYg(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void KkqhErrpWGrNQFYg(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KkqhErrpWGrNQFYg(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KkqhErrpWGrNQFYg(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QAbIsbXBaVSmHuAk(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void QAbIsbXBaVSmHuAk(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QAbIsbXBaVSmHuAk(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QAbIsbXBaVSmHuAk(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LvGKQNGjLDTNbbTU(short s, float f, short s2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LvGKQNGjLDTNbbTU(short s, int i, java.lang.string str, short s2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LvGKQNGjLDTNbbTU(short s, java.lang.string str, int i, float f, short s2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] LvGKQNGjLDTNbbTU(short s) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$600(s);
    }

    public static void NtNEuYVEJbyOIgbO(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void NtNEuYVEJbyOIgbO(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NtNEuYVEJbyOIgbO(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NtNEuYVEJbyOIgbO(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TrlVaXvETiApkZmd(short s, int i, short s2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TrlVaXvETiApkZmd(short s, int i, short s2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TrlVaXvETiApkZmd(short s, short s2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TrlVaXvETiApkZmd(short s) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$600(s);
    }

    public static void WZjWszVdlxEEDRAB(int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WZjWszVdlxEEDRAB(int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WZjWszVdlxEEDRAB(int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] WZjWszVdlxEEDRAB(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    void writeTo(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        ntNEuYVEJbyOIgbO(byteArrayStream, lvGKQNGjLDTNbbTU(this.type));
        KkqhErrpWGrNQFYg(byteArrayStream, trlVaXvETiApkZmd(this.headerSize));
        QAbIsbXBaVSmHuAk(byteArrayStream, wZjWszVdlxEEDRAB(this.chunkSize));
    }
}

