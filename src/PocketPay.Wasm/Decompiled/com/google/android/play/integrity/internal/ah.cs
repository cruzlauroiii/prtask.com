namespace WillowMaze.Wasm.Decompiled;


public readonly class ah {
    public static java.security.MessageDigest SoIXqaMhbTNDvLTi(java.lang.string str) {
        return java.security.MessageDigest.getInstance(str);
    }

    public static java.lang.string M284a(byte[] bArr) {
        try {
            java.security.MessageDigest messageDigestSoIXqaMhbTNDvLTi = SoIXqaMhbTNDvLTi("SHA-256");
            zyuHWIqKTmSCcAOW(messageDigestSoIXqaMhbTNDvLTi, bArr);
            return ulyGXAXQVMDKekRT(vNMjEGKXVlXsMJIb(messageDigestSoIXqaMhbTNDvLTi), 11);
        } catch (java.security.NoSuchAlgorithmException unused) {
            return "";
        }
    }

    public static java.lang.string UlyGXAXQVMDKekRT(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] VNMjEGKXVlXsMJIb(java.security.MessageDigest messageDigest) {
        return messageDigest.digest();
    }

    public static void ZyuHWIqKTmSCcAOW(java.security.MessageDigest messageDigest, byte[] bArr) {
        messageDigest.update(bArr);
    }
}

