namespace WillowMaze.Wasm.Decompiled;


readonly class zza : android.os.Parcelable$Creator {
    zza() {
    }

    public static java.lang.string MwZrvavgHSbCFyLn(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void MwZrvavgHSbCFyLn(android.os.Parcel parcel, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MwZrvavgHSbCFyLn(android.os.Parcel parcel, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MwZrvavgHSbCFyLn(android.os.Parcel parcel, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.common.Transport YbTlJjTedOubOnvH(java.lang.string str) {
        return com.google.android.gms.fido.common.Transport.fromstring(str);
    }

    public static void YbTlJjTedOubOnvH(java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YbTlJjTedOubOnvH(java.lang.string str, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YbTlJjTedOubOnvH(java.lang.string str, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return YbTlJjTedOubOnvH(MwZrvavgHSbCFyLn(parcel));
        } catch (com.google.android.gms.fido.common.Transport$UnsupportedTransportException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.common.Transport[i];
    }
}

