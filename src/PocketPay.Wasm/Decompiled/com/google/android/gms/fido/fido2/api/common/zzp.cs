namespace WillowMaze.Wasm.Decompiled;


readonly class zzp : android.os.Parcelable$Creator {
    zzp() {
    }

    public static com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier NyzVDLRGwJRoIxVt(int i) {
        return com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier.fromCoseValue(i);
    }

    public static void NyzVDLRGwJRoIxVt(int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NyzVDLRGwJRoIxVt(int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyzVDLRGwJRoIxVt(int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AYpZtLUTCsEElnQf(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void AYpZtLUTCsEElnQf(android.os.Parcel parcel, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AYpZtLUTCsEElnQf(android.os.Parcel parcel, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AYpZtLUTCsEElnQf(android.os.Parcel parcel, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        try {
            return NyzVDLRGwJRoIxVt(aYpZtLUTCsEElnQf(parcel));
        } catch (com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier$UnsupportedAlgorithmIdentifierException e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier[i];
    }
}

