namespace WillowMaze.Wasm.Decompiled;


readonly class zzf : android.os.Parcelable$Creator {
    zzf() {
    }

    public static java.lang.string AdBQHpNFzOWgCoKL(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void AdBQHpNFzOWgCoKL(android.os.Parcel parcel, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AdBQHpNFzOWgCoKL(android.os.Parcel parcel, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AdBQHpNFzOWgCoKL(android.os.Parcel parcel, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ProtocolVersion UaYklieZqEVwtdnA(java.lang.string str) {
        return com.google.android.gms.fido.u2f.api.common.ProtocolVersion.fromstring(str);
    }

    public static void UaYklieZqEVwtdnA(java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UaYklieZqEVwtdnA(java.lang.string str, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UaYklieZqEVwtdnA(java.lang.string str, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return uaYklieZqEVwtdnA(AdBQHpNFzOWgCoKL(parcel));
        } catch (com.google.android.gms.fido.u2f.api.common.ProtocolVersion$UnsupportedProtocolException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.u2f.api.common.ProtocolVersion[i];
    }
}

