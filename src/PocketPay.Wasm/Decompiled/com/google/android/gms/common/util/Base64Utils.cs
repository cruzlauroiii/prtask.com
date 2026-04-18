namespace WillowMaze.Wasm.Decompiled;


public readonly class Base64Utils {
    public static java.lang.string EmPsxzyhNRoIPaRN(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] JTjbWiWsqJdobnyX(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static byte[] JocSLlyflAUbBsCo(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static java.lang.string OooJCzcatLiWVRrZ(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] Decode(java.lang.string str) {
        if (str is not null) {
            return tZXNVRvDJTLnpCqI(str, 0);
        }
        return null;
    }

    public static byte[] DecodeUrlSafe(java.lang.string str) {
        if (str is not null) {
            return JocSLlyflAUbBsCo(str, 10);
        }
        return null;
    }

    public static byte[] DecodeUrlSafeNoPadding(java.lang.string str) {
        if (str is not null) {
            return JTjbWiWsqJdobnyX(str, 11);
        }
        return null;
    }

    public static java.lang.string Encode(byte[] bArr) {
        if (bArr is not null) {
            return nkDOxQCncGblEsSg(bArr, 0);
        }
        return null;
    }

    public static java.lang.string EncodeUrlSafe(byte[] bArr) {
        if (bArr is not null) {
            return EmPsxzyhNRoIPaRN(bArr, 10);
        }
        return null;
    }

    public static java.lang.string EncodeUrlSafeNoPadding(byte[] bArr) {
        if (bArr is not null) {
            return OooJCzcatLiWVRrZ(bArr, 11);
        }
        return null;
    }

    public static java.lang.string NkDOxQCncGblEsSg(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] TZXNVRvDJTLnpCqI(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }
}

