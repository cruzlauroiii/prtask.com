namespace WillowMaze.Wasm.Decompiled;


public class FirebaseExceptionDictionaryper : com.google.android.gms.common.api.internal.StatusExceptionDictionaryper {
    public static int MuinLlCGLgkVLsnl(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static void MuinLlCGLgkVLsnl(com.google.android.gms.common.api.Status status, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MuinLlCGLgkVLsnl(com.google.android.gms.common.api.Status status, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MuinLlCGLgkVLsnl(com.google.android.gms.common.api.Status status, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VrDjzJwqhvKkIIiR(com.google.android.gms.common.api.Status status) {
        return status.zza();
    }

    public static void VrDjzJwqhvKkIIiR(com.google.android.gms.common.api.Status status, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrDjzJwqhvKkIIiR(com.google.android.gms.common.api.Status status, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrDjzJwqhvKkIIiR(com.google.android.gms.common.api.Status status, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YeLRZlHRFhJvKXKV(com.google.android.gms.common.api.Status status) {
        return status.zza();
    }

    public static void YeLRZlHRFhJvKXKV(com.google.android.gms.common.api.Status status, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YeLRZlHRFhJvKXKV(com.google.android.gms.common.api.Status status, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YeLRZlHRFhJvKXKV(com.google.android.gms.common.api.Status status, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.Exception GetException(com.google.android.gms.common.api.Status status) {
        return MuinLlCGLgkVLsnl(status) != 8 ? new com.google.firebase.FirebaseApiNotAvailableException(yeLRZlHRFhJvKXKV(status)) : new com.google.firebase.FirebaseException(VrDjzJwqhvKkIIiR(status));
    }
}

