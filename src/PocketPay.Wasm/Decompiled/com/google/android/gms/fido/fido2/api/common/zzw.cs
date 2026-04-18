namespace WillowMaze.Wasm.Decompiled;


readonly class zzw : android.os.Parcelable$Creator {
    zzw() {
    }

    public static com.google.android.gms.fido.fido2.api.common.ErrorCode CxIIoinGFZLhAmtL(int i) {
        return com.google.android.gms.fido.fido2.api.common.ErrorCode.toErrorCode(i);
    }

    public static void CxIIoinGFZLhAmtL(int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxIIoinGFZLhAmtL(int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CxIIoinGFZLhAmtL(int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MqZbdsItpYyvFXtA(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void MqZbdsItpYyvFXtA(android.os.Parcel parcel, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MqZbdsItpYyvFXtA(android.os.Parcel parcel, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MqZbdsItpYyvFXtA(android.os.Parcel parcel, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return CxIIoinGFZLhAmtL(MqZbdsItpYyvFXtA(parcel));
        } catch (com.google.android.gms.fido.fido2.api.common.ErrorCode$UnsupportedErrorCodeException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.fido2.api.common.ErrorCode[i];
    }
}

