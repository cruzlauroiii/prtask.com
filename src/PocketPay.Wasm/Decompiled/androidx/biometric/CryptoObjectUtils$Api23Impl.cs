namespace WillowMaze.Wasm.Decompiled;


class CryptoobjectUtils$Api23Impl {
    private CryptoobjectUtils$Api23Impl() {
    }

    public static android.security.keystore.KeyGenParameterSpec$Builder QLJXCGsDCsDTwgLk(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder, java.lang.string[] strArr) {
        return keyGenParameterSpec$Builder.setEncryptionPaddings(strArr);
    }

    public static android.security.keystore.KeyGenParameterSpec ZydHXookkdmxYtwc(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        return keyGenParameterSpec$Builder.build();
    }

    static android.security.keystore.KeyGenParameterSpec BuildKeyGenParameterSpec(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        return ZydHXookkdmxYtwc(keyGenParameterSpec$Builder);
    }

    static android.security.keystore.KeyGenParameterSpec$Builder createKeyGenParameterSpecBuilder(java.lang.string str, int i) {
        return new android.security.keystore.KeyGenParameterSpec$Builder(str, i);
    }

    static void InitKeyGenerator(javax.crypto.KeyGenerator keyGenerator, android.security.keystore.KeyGenParameterSpec keyGenParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        oWBcqqoHNsfGmUsR(keyGenerator, keyGenParameterSpec);
    }

    public static void OWBcqqoHNsfGmUsR(javax.crypto.KeyGenerator keyGenerator, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        keyGenerator.init(algorithmParameterSpec);
    }

    static void SetBlockModeCBC(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        if ((27 + 10) % 10 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "CBC";
        tYvpBzYiuyYEvwtt(keyGenParameterSpec$Builder, strArr);
    }

    static void SetEncryptionPaddingPKCS7(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        if ((32 + 23) % 23 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "PKCS7Padding";
        QLJXCGsDCsDTwgLk(keyGenParameterSpec$Builder, strArr);
    }

    public static android.security.keystore.KeyGenParameterSpec$Builder tYvpBzYiuyYEvwtt(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder, java.lang.string[] strArr) {
        return keyGenParameterSpec$Builder.setBlockModes(strArr);
    }
}

