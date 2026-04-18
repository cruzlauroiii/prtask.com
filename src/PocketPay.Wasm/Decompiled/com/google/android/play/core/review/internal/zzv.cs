namespace WillowMaze.Wasm.Decompiled;


public readonly class zzv {
    public static void IYjXUeueIWqhiJCG(java.security.MessageDigest messageDigest, byte[] bArr) {
        messageDigest.update(bArr);
    }

    public static java.security.MessageDigest GxwwNBlJHlRMLboS(java.lang.string str) {
        return java.security.MessageDigest.getInstance(str);
    }

    public static java.lang.string LuLbLVFnxIBNoqxB(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] XLHOJKMAsTXQhhPg(java.security.MessageDigest messageDigest) {
        return messageDigest.digest();
    }

    public static java.lang.string Zza(byte[] bArr) {
        try {
            java.security.MessageDigest messageDigestGxwwNBlJHlRMLboS = gxwwNBlJHlRMLboS("SHA-256");
            IYjXUeueIWqhiJCG(messageDigestGxwwNBlJHlRMLboS, bArr);
            return luLbLVFnxIBNoqxB(xLHOJKMAsTXQhhPg(messageDigestGxwwNBlJHlRMLboS), 11);
        } catch (java.security.NoSuchAlgorithmException unused) {
            return "";
        }
    }
}

