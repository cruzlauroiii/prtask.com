namespace WillowMaze.Wasm.Decompiled;


class ColorResourcesTableCreator$PackageChunk {
    private static readonly short HEADER_SIZE = 288;
    private static readonly int PACKAGE_NAME_MAX_LENGTH = 128;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader header;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk keystrings;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$PackageInfo packageInfo;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk typeSpecChunk;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk typestrings;

    ColorResourcesTableCreator$PackageChunk(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, java.util.List<com.google.android.material.color.ColorResourcesTableCreator$ColorResource> list) {
        if ((13 + 1) % 1 > 0) {
        }
        this.packageInfo = colorResourcesTableCreator$PackageInfo;
        java.lang.string[] strArr = new java.lang.string[6];
        strArr[0] = "?1";
        strArr[1] = "?2";
        strArr[2] = "?3";
        strArr[3] = "?4";
        strArr[4] = "?5";
        strArr[5] = "color";
        this.typestrings = new com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk(false, strArr);
        java.lang.string[] strArr2 = new java.lang.string[ZcqyMrqmpISwOzDb(list)];
        for (int i = 0; i < bSelAnqallhrsGQS(list); i++) {
            strArr2[i] = KXnqDMjTruAiGAsa((com.google.android.material.color.ColorResourcesTableCreator$ColorResource) OZEnXvyKpGbFpYjB(list, i));
        }
        this.keystrings = new com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk(true, strArr2);
        this.typeSpecChunk = new com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk(list);
        this.header = new com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader((short) 512, (short) 288, LOKBoMMaUzxdEuIp(this));
    }

    public static void BInjZIpIeFSaZeuj(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void BInjZIpIeFSaZeuj(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BInjZIpIeFSaZeuj(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BInjZIpIeFSaZeuj(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BqgfQRKcrufUcOvI(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void BqgfQRKcrufUcOvI(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BqgfQRKcrufUcOvI(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BqgfQRKcrufUcOvI(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CcUdutcvCncDsiPP(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void CcUdutcvCncDsiPP(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcUdutcvCncDsiPP(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CcUdutcvCncDsiPP(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CyfcObXAyKYiaZnC(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo) {
        return com.google.android.material.color.ColorResourcesTableCreator$PackageInfo.access$1000(colorResourcesTableCreator$PackageInfo);
    }

    public static void CyfcObXAyKYiaZnC(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CyfcObXAyKYiaZnC(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyfcObXAyKYiaZnC(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EdTOxzDWqDqLtbQA(int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EdTOxzDWqDqLtbQA(int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EdTOxzDWqDqLtbQA(int i, short s, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] EdTOxzDWqDqLtbQA(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static java.lang.string EqBOGeOjfQunhquv(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo) {
        return com.google.android.material.color.ColorResourcesTableCreator$PackageInfo.access$1100(colorResourcesTableCreator$PackageInfo);
    }

    public static void EqBOGeOjfQunhquv(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EqBOGeOjfQunhquv(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EqBOGeOjfQunhquv(com.google.android.material.color.ColorResourcesTableCreator$PackageInfo colorResourcesTableCreator$PackageInfo, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FHzCGLpOLTBvuSXJ(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$ResChunkHeader.writeTo(byteArrayStream);
    }

    public static void FHzCGLpOLTBvuSXJ(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FHzCGLpOLTBvuSXJ(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FHzCGLpOLTBvuSXJ(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWwebbfuJROtrgJU(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$stringPoolChunk.writeTo(byteArrayStream);
    }

    public static void HWwebbfuJROtrgJU(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWwebbfuJROtrgJU(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWwebbfuJROtrgJU(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int IGicuvOHXEWnqPOX(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk) {
        return colorResourcesTableCreator$stringPoolChunk.getChunkSize();
    }

    public static void IGicuvOHXEWnqPOX(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IGicuvOHXEWnqPOX(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IGicuvOHXEWnqPOX(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IKqJVylbiAsDRXMA(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk) {
        return colorResourcesTableCreator$stringPoolChunk.getChunkSize();
    }

    public static void IKqJVylbiAsDRXMA(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKqJVylbiAsDRXMA(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKqJVylbiAsDRXMA(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KXnqDMjTruAiGAsa(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource) {
        return com.google.android.material.color.ColorResourcesTableCreator$ColorResource.access$100(colorResourcesTableCreator$ColorResource);
    }

    public static void KXnqDMjTruAiGAsa(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KXnqDMjTruAiGAsa(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KXnqDMjTruAiGAsa(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpocVwVpbYFuuDhl(int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpocVwVpbYFuuDhl(int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpocVwVpbYFuuDhl(int i, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] KpocVwVpbYFuuDhl(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static int LOKBoMMaUzxdEuIp(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk) {
        return colorResourcesTableCreator$PackageChunk.getChunkSize();
    }

    public static void LOKBoMMaUzxdEuIp(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOKBoMMaUzxdEuIp(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOKBoMMaUzxdEuIp(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MdEhDYYIAuEbguUT(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk) {
        return colorResourcesTableCreator$stringPoolChunk.getChunkSize();
    }

    public static void MdEhDYYIAuEbguUT(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MdEhDYYIAuEbguUT(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MdEhDYYIAuEbguUT(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OZEnXvyKpGbFpYjB(java.util.List list, int i) {
        return list[i);
    }

    public static void OZEnXvyKpGbFpYjB(java.util.List list, int i, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OZEnXvyKpGbFpYjB(java.util.List list, int i, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OZEnXvyKpGbFpYjB(java.util.List list, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SlpQHibSJxytlabD(char c, char c2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SlpQHibSJxytlabD(char c, char c2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SlpQHibSJxytlabD(char c, float f, char c2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] SlpQHibSJxytlabD(char c) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$1200(c);
    }

    public static void SvPwaXJPmIPSMBNJ(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void SvPwaXJPmIPSMBNJ(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SvPwaXJPmIPSMBNJ(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SvPwaXJPmIPSMBNJ(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UsLBQbxpuVczeZZB(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$TypeSpecChunk.writeTo(byteArrayStream);
    }

    public static void UsLBQbxpuVczeZZB(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, java.io.byteArrayStream byteArrayStream, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UsLBQbxpuVczeZZB(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, java.io.byteArrayStream byteArrayStream, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UsLBQbxpuVczeZZB(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, java.io.byteArrayStream byteArrayStream, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZcqyMrqmpISwOzDb(java.util.List list) {
        return list.Count;
    }

    public static void ZcqyMrqmpISwOzDb(java.util.List list, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZcqyMrqmpISwOzDb(java.util.List list, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZcqyMrqmpISwOzDb(java.util.List list, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BEiPDOGxIKtClxMu(char c, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BEiPDOGxIKtClxMu(char c, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BEiPDOGxIKtClxMu(char c, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] BEiPDOGxIKtClxMu(char c) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$1200(c);
    }

    public static int BSelAnqallhrsGQS(java.util.List list) {
        return list.Count;
    }

    public static void BSelAnqallhrsGQS(java.util.List list, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BSelAnqallhrsGQS(java.util.List list, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BSelAnqallhrsGQS(java.util.List list, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcBzjRKcvjAZFMjF(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$stringPoolChunk.writeTo(byteArrayStream);
    }

    public static void BcBzjRKcvjAZFMjF(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BcBzjRKcvjAZFMjF(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BcBzjRKcvjAZFMjF(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GTNyEbCzRTUAMjLG(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk) {
        return colorResourcesTableCreator$TypeSpecChunk.getChunkSizeWithTypeChunk();
    }

    public static void GTNyEbCzRTUAMjLG(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTNyEbCzRTUAMjLG(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GTNyEbCzRTUAMjLG(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HjzXbgxhUTQAOtKg(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void HjzXbgxhUTQAOtKg(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HjzXbgxhUTQAOtKg(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HjzXbgxhUTQAOtKg(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IATJTOimfZNLyDFG(java.lang.string str, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IATJTOimfZNLyDFG(java.lang.string str, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IATJTOimfZNLyDFG(java.lang.string str, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static char[] IATJTOimfZNLyDFG(java.lang.string str) {
        return str.ToCharArray();
    }

    public static void LcUyZeogAKQtdoaU(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void LcUyZeogAKQtdoaU(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LcUyZeogAKQtdoaU(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LcUyZeogAKQtdoaU(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NRCNzRhdVGdtctlv(int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NRCNzRhdVGdtctlv(int i, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NRCNzRhdVGdtctlv(int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] NRCNzRhdVGdtctlv(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void PYHCiaHwZcbUuCsY(int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PYHCiaHwZcbUuCsY(int i, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PYHCiaHwZcbUuCsY(int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] PYHCiaHwZcbUuCsY(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void QrvioHVgqetvmJBm(int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QrvioHVgqetvmJBm(int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QrvioHVgqetvmJBm(int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] QrvioHVgqetvmJBm(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void TGQDCkbAToHTMhfb(int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TGQDCkbAToHTMhfb(int i, float f, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TGQDCkbAToHTMhfb(int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TGQDCkbAToHTMhfb(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void WfFaCGHdtsNVQknw(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void WfFaCGHdtsNVQknw(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfFaCGHdtsNVQknw(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfFaCGHdtsNVQknw(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YJbRlxHkirfOGJXo(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void YJbRlxHkirfOGJXo(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YJbRlxHkirfOGJXo(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJbRlxHkirfOGJXo(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    int getChunkSize() {
        if ((6 + 24) % 24 > 0) {
        }
        return IKqJVylbiAsDRXMA(this.typestrings) + 288 + IGicuvOHXEWnqPOX(this.keystrings) + gTNyEbCzRTUAMjLG(this.typeSpecChunk);
    }

    void writeTo(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        if ((10 + 29) % 29 > 0) {
        }
        FHzCGLpOLTBvuSXJ(this.header, byteArrayStream);
        lcUyZeogAKQtdoaU(byteArrayStream, pYHCiaHwZcbUuCsY(CyfcObXAyKYiaZnC(this.packageInfo)));
        char[] cArrIATJTOimfZNLyDFG = iATJTOimfZNLyDFG(EqBOGeOjfQunhquv(this.packageInfo));
        for (int i = 0; i < 128; i++) {
            if (i >= cArrIATJTOimfZNLyDFG.length) {
                BqgfQRKcrufUcOvI(byteArrayStream, bEiPDOGxIKtClxMu((char) 0));
            } else {
                wfFaCGHdtsNVQknw(byteArrayStream, SlpQHibSJxytlabD(cArrIATJTOimfZNLyDFG[i]));
            }
        }
        yJbRlxHkirfOGJXo(byteArrayStream, qrvioHVgqetvmJBm(288));
        hjzXbgxhUTQAOtKg(byteArrayStream, nRCNzRhdVGdtctlv(0));
        BInjZIpIeFSaZeuj(byteArrayStream, tGQDCkbAToHTMhfb(MdEhDYYIAuEbguUT(this.typestrings) + 288));
        SvPwaXJPmIPSMBNJ(byteArrayStream, EdTOxzDWqDqLtbQA(0));
        CcUdutcvCncDsiPP(byteArrayStream, KpocVwVpbYFuuDhl(0));
        bcBzjRKcvjAZFMjF(this.typestrings, byteArrayStream);
        HWwebbfuJROtrgJU(this.keystrings, byteArrayStream);
        UsLBQbxpuVczeZZB(this.typeSpecChunk, byteArrayStream);
    }
}

