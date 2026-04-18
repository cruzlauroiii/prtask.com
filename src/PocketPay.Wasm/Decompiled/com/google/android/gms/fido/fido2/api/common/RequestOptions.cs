namespace WillowMaze.Wasm.Decompiled;


public abstract class RequestOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static void HeCVSjTORUaPhkrl(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HeCVSjTORUaPhkrl(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HeCVSjTORUaPhkrl(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] HeCVSjTORUaPhkrl(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelableSerializer.serializeTobytes(safeParcelable);
    }

    public abstract com.google.android.gms.fido.fido2.api.common.AuthenticationExtensions GetAuthenticationExtensions();

    public abstract byte[] GetChallenge();

    public abstract java.lang.int GetRequestId();

    public abstract java.lang.double GetTimeoutSeconds();

    public abstract com.google.android.gms.fido.fido2.api.common.TokenBinding GetTokenBinding();

    public byte[] SerializeTobytes() {
        return heCVSjTORUaPhkrl(this);
    }
}

