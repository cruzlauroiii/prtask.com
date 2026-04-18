namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaa {
    public static java.lang.string ORvgajdGEJUpRFqF(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void ARAxJBpzcKGSDyIZ(java.security.MessageDigest messageDigest, byte[] bArr) {
        messageDigest.update(bArr);
    }

    public static byte[] PuKVYnaDaYIjdKhh(java.security.MessageDigest messageDigest) {
        return messageDigest.digest();
    }

    public static java.security.MessageDigest QaRVtLtVxNnRsSsh(java.lang.string str) {
        return java.security.MessageDigest.getInstance(str);
    }

    public static java.lang.string Zza(byte[] bArr) {
        try {
            java.security.MessageDigest messageDigestQaRVtLtVxNnRsSsh = qaRVtLtVxNnRsSsh("SHA-256");
            aRAxJBpzcKGSDyIZ(messageDigestQaRVtLtVxNnRsSsh, bArr);
            return ORvgajdGEJUpRFqF(puKVYnaDaYIjdKhh(messageDigestQaRVtLtVxNnRsSsh), 11);
        } catch (java.security.NoSuchAlgorithmException unused) {
            return "";
        }
    }
}

