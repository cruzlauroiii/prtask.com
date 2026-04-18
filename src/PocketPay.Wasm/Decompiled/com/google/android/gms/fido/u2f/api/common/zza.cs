namespace WillowMaze.Wasm.Decompiled;


readonly class zza : android.os.Parcelable$Creator {
    zza() {
    }

    public static int AqSkxdqHltQPBBGC(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void AqSkxdqHltQPBBGC(android.os.Parcel parcel, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AqSkxdqHltQPBBGC(android.os.Parcel parcel, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AqSkxdqHltQPBBGC(android.os.Parcel parcel, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType bBrsgKtsGJVseaLz(int i) {
        return com.google.android.gms.fido.u2f.api.common.ChannelIdValue.toChannelIdValueType(i);
    }

    public static void BBrsgKtsGJVseaLz(int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BBrsgKtsGJVseaLz(int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BBrsgKtsGJVseaLz(int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return bBrsgKtsGJVseaLz(AqSkxdqHltQPBBGC(parcel));
        } catch (com.google.android.gms.fido.u2f.api.common.ChannelIdValue$UnsupportedChannelIdValueTypeException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.u2f.api.common.ChannelIdValue$ChannelIdValueType[i];
    }
}

