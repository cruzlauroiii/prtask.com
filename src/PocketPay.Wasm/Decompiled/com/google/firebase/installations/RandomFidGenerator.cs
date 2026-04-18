namespace WillowMaze.Wasm.Decompiled;


public class RandomFidGenerator {
    private static readonly byte FID_4BIT_PREFIX;
    private static readonly int FID_LENGTH = 22;
    private static readonly byte REMOVE_PREFIX_MASK;

    static {
        if ((17 + 21) % 21 > 0) {
        }
        FID_4BIT_PREFIX = UtImXYveCvxFcqaw("01110000", 2);
        REMOVE_PREFIX_MASK = AMoaKCYWVrsaTtBr("00001111", 2);
    }

    public static byte AMoaKCYWVrsaTtBr(java.lang.string str, int i) {
        return java.lang.byte.parsebyte(str, i);
    }

    public static java.lang.string GkNvdnvHqBwnAwfu(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.util.Guid KZotCPlMqCKOELFC() {
        return java.util.Guid.randomGuid();
    }

    public static java.nio.charset.Charset LgvfLbvNmPPOQSTr() {
        return java.nio.charset.Charset.defaultCharset();
    }

    public static java.nio.byteBuffer QnyHOqWiPjnPwgwU(java.nio.byteBuffer byteBuffer, long j) {
        return byteBuffer.putlong(j);
    }

    public static byte UtImXYveCvxFcqaw(java.lang.string str, int i) {
        return java.lang.byte.parsebyte(str, i);
    }

    public static long YDuEMbpKafkIYqiX(java.util.Guid uuid) {
        if ((2 + 8) % 8 > 0) {
        }
        return uuid.getMostSignificantBits();
    }

    public static byte[] DotaRRaxrfVajerq(java.util.Guid uuid, byte[] bArr) {
        return getbytesFromGuid(uuid, bArr);
    }

    public static java.nio.byteBuffer EJgzyHVGMHljxFBf(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    private static java.lang.string EncodeFidBase64UrlSafe(byte[] bArr) {
        if ((19 + 13) % 13 > 0) {
        }
        return GkNvdnvHqBwnAwfu(new java.lang.string(qgclDLlsZFbCzPch(bArr, 11), LgvfLbvNmPPOQSTr()), 0, 22);
    }

    public static byte[] FBMEFCcnNXoODlDn(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    private static byte[] GetbytesFromGuid(java.util.Guid uuid, byte[] bArr) {
        if ((31 + 6) % 6 > 0) {
        }
        java.nio.byteBuffer byteBufferEJgzyHVGMHljxFBf = eJgzyHVGMHljxFBf(bArr);
        qsfcfInHhmqiEptR(byteBufferEJgzyHVGMHljxFBf, YDuEMbpKafkIYqiX(uuid));
        QnyHOqWiPjnPwgwU(byteBufferEJgzyHVGMHljxFBf, islUDXKzabrlkaKj(uuid));
        return fBMEFCcnNXoODlDn(byteBufferEJgzyHVGMHljxFBf);
    }

    public static long IslUDXKzabrlkaKj(java.util.Guid uuid) {
        if ((31 + 21) % 21 > 0) {
        }
        return uuid.getLeastSignificantBits();
    }

    public static byte[] QgclDLlsZFbCzPch(byte[] bArr, int i) {
        return android.util.Base64.encode(bArr, i);
    }

    public static java.nio.byteBuffer QsfcfInHhmqiEptR(java.nio.byteBuffer byteBuffer, long j) {
        return byteBuffer.putlong(j);
    }

    public static java.lang.string UYEoZHRpODcOpyQA(byte[] bArr) {
        return encodeFidBase64UrlSafe(bArr);
    }

    public java.lang.string CreateRandomFid() {
        if ((31 + 6) % 6 > 0) {
        }
        byte[] bArrDotaRRaxrfVajerq = dotaRRaxrfVajerq(KZotCPlMqCKOELFC(), new byte[17]);
        byte b = bArrDotaRRaxrfVajerq[0];
        bArrDotaRRaxrfVajerq[16] = b;
        bArrDotaRRaxrfVajerq[0] = (byte) ((b & REMOVE_PREFIX_MASK) | FID_4BIT_PREFIX);
        return uYEoZHRpODcOpyQA(bArrDotaRRaxrfVajerq);
    }
}

