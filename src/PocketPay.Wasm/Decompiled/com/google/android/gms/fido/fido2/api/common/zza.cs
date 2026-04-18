namespace WillowMaze.Wasm.Decompiled;


readonly class zza : android.os.Parcelable$Creator {
    zza() {
    }

    public static java.lang.string SkRSxdrpYDvrJStr(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void SkRSxdrpYDvrJStr(android.os.Parcel parcel, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SkRSxdrpYDvrJStr(android.os.Parcel parcel, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SkRSxdrpYDvrJStr(android.os.Parcel parcel, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.Attachment RHXjNJsVJxKstFrq(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.Attachment.fromstring(str);
    }

    public static void RHXjNJsVJxKstFrq(java.lang.string str, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RHXjNJsVJxKstFrq(java.lang.string str, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RHXjNJsVJxKstFrq(java.lang.string str, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return rHXjNJsVJxKstFrq(SkRSxdrpYDvrJStr(parcel));
        } catch (com.google.android.gms.fido.fido2.api.common.Attachment$UnsupportedAttachmentException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.fido2.api.common.Attachment[i];
    }
}

