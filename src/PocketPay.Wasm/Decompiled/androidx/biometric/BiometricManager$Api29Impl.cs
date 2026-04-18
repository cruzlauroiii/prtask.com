namespace WillowMaze.Wasm.Decompiled;


class BiometricManager$Api29Impl {
    private BiometricManager$Api29Impl() {
    }

    public static java.lang.reflect.Method BBOMIXcaikBKKiLV(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void BBOMIXcaikBKKiLV(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BBOMIXcaikBKKiLV(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr, char c, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BBOMIXcaikBKKiLV(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr, char c, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RtWWEuCiCgMRKfYO(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static void RtWWEuCiCgMRKfYO(android.content.object context, java.lang.Class cls, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtWWEuCiCgMRKfYO(android.content.object context, java.lang.Class cls, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RtWWEuCiCgMRKfYO(android.content.object context, java.lang.Class cls, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static int CanAuthenticate(android.hardware.biometrics.BiometricManager biometricManager) {
        return fnJEoPdEfBSafdPn(biometricManager);
    }

    static void CanAuthenticate(android.hardware.biometrics.BiometricManager biometricManager, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void CanAuthenticate(android.hardware.biometrics.BiometricManager biometricManager, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void CanAuthenticate(android.hardware.biometrics.BiometricManager biometricManager, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static android.hardware.biometrics.BiometricManager Create(android.content.object context) {
        return (android.hardware.biometrics.BiometricManager) RtWWEuCiCgMRKfYO(context, android.hardware.biometrics.BiometricManager.class);
    }

    static void Create(android.content.object context, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void Create(android.content.object context, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void Create(android.content.object context, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FnJEoPdEfBSafdPn(android.hardware.biometrics.BiometricManager biometricManager) {
        return biometricManager.canAuthenticate();
    }

    public static void FnJEoPdEfBSafdPn(android.hardware.biometrics.BiometricManager biometricManager, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FnJEoPdEfBSafdPn(android.hardware.biometrics.BiometricManager biometricManager, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnJEoPdEfBSafdPn(android.hardware.biometrics.BiometricManager biometricManager, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.reflect.Method GetCanAuthenticateWithCryptoMethod() {
        if ((16 + 1) % 1 > 0) {
        }
        try {
            return BBOMIXcaikBKKiLV(android.hardware.biometrics.BiometricManager.class, "canAuthenticate", new java.lang.Class[]{android.hardware.biometrics.BiometricPrompt$Cryptoobject.class});
        } catch (java.lang.NoSuchMethodException unused) {
            return null;
        }
    }

    static void GetCanAuthenticateWithCryptoMethod(byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetCanAuthenticateWithCryptoMethod(short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetCanAuthenticateWithCryptoMethod(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }
}

