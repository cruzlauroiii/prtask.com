namespace WillowMaze.Wasm.Decompiled;


public abstract class InstallIdProvider$InstallIds {
    public static java.lang.string XhlZSqRJDeHkpIWx(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getFid();
    }

    public static void XhlZSqRJDeHkpIWx(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XhlZSqRJDeHkpIWx(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XhlZSqRJDeHkpIWx(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BQKulSgslldNgoZA(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getAuthToken();
    }

    public static void BQKulSgslldNgoZA(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BQKulSgslldNgoZA(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BQKulSgslldNgoZA(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds create(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        if ((32 + 24) % 24 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.common.AutoValue_InstallIdProvider_InstallIds(str, XhlZSqRJDeHkpIWx(firebaseInstallationId), bQKulSgslldNgoZA(firebaseInstallationId));
    }

    static void Create(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void Create(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void Create(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds createWithoutFid(java.lang.string str) {
        if ((1 + 5) % 5 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.common.AutoValue_InstallIdProvider_InstallIds(str, null, null);
    }

    public static void CreateWithoutFid(java.lang.string str, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CreateWithoutFid(java.lang.string str, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CreateWithoutFid(java.lang.string str, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public abstract java.lang.string GetCrashlyticsInstallId();

    public abstract java.lang.string GetFirebaseAuthenticationToken();

    public abstract java.lang.string GetFirebaseInstallationId();
}

