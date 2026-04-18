namespace WillowMaze.Wasm.Decompiled;


readonly class zzat : android.os.Parcelable$Creator {
    zzat() {
    }

    public static com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus gWavJnvmBxbbeBcz(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus.fromstring(str);
    }

    public static void GWavJnvmBxbbeBcz(java.lang.string str, byte b, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GWavJnvmBxbbeBcz(java.lang.string str, int i, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWavJnvmBxbbeBcz(java.lang.string str, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GzUACzOehZVkzuAr(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void GzUACzOehZVkzuAr(android.os.Parcel parcel, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GzUACzOehZVkzuAr(android.os.Parcel parcel, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzUACzOehZVkzuAr(android.os.Parcel parcel, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return gWavJnvmBxbbeBcz(gzUACzOehZVkzuAr(parcel));
        } catch (com.google.android.gms.fido.fido2.api.common.TokenBinding$UnsupportedTokenBindingStatusException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.fido2.api.common.TokenBinding$TokenBindingStatus[i];
    }
}

