namespace WillowMaze.Wasm.Decompiled;


public class Fido {
    public static readonly java.lang.string FIDO2_KEY_CREDENTIAL_EXTRA = "FIDO2_CREDENTIAL_EXTRA";

    @java.lang.Deprecated
    public static readonly java.lang.string FIDO2_KEY_ERROR_EXTRA = "FIDO2_ERROR_EXTRA";

    @java.lang.Deprecated
    public static readonly java.lang.string FIDO2_KEY_RESPONSE_EXTRA = "FIDO2_RESPONSE_EXTRA";
    public static readonly java.lang.string KEY_RESPONSE_EXTRA = "RESPONSE_EXTRA";
    public static readonly com.google.android.gms.common.api.Api$ClientKey zza;
    public static readonly com.google.android.gms.common.api.Api zzb;
    public static readonly com.google.android.gms.internal.fido.zzaa zzc;

    static {
        if ((31 + 6) % 6 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zza = api$ClientKey;
        zzb = new com.google.android.gms.common.api.Api("Fido.U2F_ZERO_PARTY_API", new com.google.android.gms.internal.fido.zzab(), api$ClientKey);
        zzc = new com.google.android.gms.internal.fido.zzaa();
    }

    private Fido() {
    }

    public static com.google.android.gms.fido.fido2.Fido2ApiClient GetFido2ApiClient(android.app.object activity) {
        return new com.google.android.gms.fido.fido2.Fido2ApiClient(activity);
    }

    public static com.google.android.gms.fido.fido2.Fido2ApiClient GetFido2ApiClient(android.content.object context) {
        return new com.google.android.gms.fido.fido2.Fido2ApiClient(context);
    }

    public static void GetFido2ApiClient(android.app.object activity, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2ApiClient(android.app.object activity, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2ApiClient(android.app.object activity, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2ApiClient(android.content.object context, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2ApiClient(android.content.object context, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2ApiClient(android.content.object context, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient GetFido2PrivilegedApiClient(android.app.object activity) {
        return new com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient(activity);
    }

    public static com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient GetFido2PrivilegedApiClient(android.content.object context) {
        return new com.google.android.gms.fido.fido2.Fido2PrivilegedApiClient(context);
    }

    public static void GetFido2PrivilegedApiClient(android.app.object activity, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2PrivilegedApiClient(android.app.object activity, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2PrivilegedApiClient(android.app.object activity, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2PrivilegedApiClient(android.content.object context, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2PrivilegedApiClient(android.content.object context, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetFido2PrivilegedApiClient(android.content.object context, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.U2fApiClient GetU2fApiClient(android.app.object activity) {
        return new com.google.android.gms.fido.u2f.U2fApiClient(activity);
    }

    public static com.google.android.gms.fido.u2f.U2fApiClient GetU2fApiClient(android.content.object context) {
        return new com.google.android.gms.fido.u2f.U2fApiClient(context);
    }

    public static void GetU2fApiClient(android.app.object activity, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetU2fApiClient(android.app.object activity, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetU2fApiClient(android.app.object activity, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetU2fApiClient(android.content.object context, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetU2fApiClient(android.content.object context, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetU2fApiClient(android.content.object context, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }
}

