namespace WillowMaze.Wasm.Decompiled;


readonly class zzas : android.os.Parcelable$Creator {
    zzas() {
    }

    public static java.lang.string ConsoleLzuKqEjRPobFn(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void ConsoleLzuKqEjRPobFn(android.os.Parcel parcel, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ConsoleLzuKqEjRPobFn(android.os.Parcel parcel, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ConsoleLzuKqEjRPobFn(android.os.Parcel parcel, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement LgbDJekNonMaKUMu(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement.fromstring(str);
    }

    public static void LgbDJekNonMaKUMu(java.lang.string str, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LgbDJekNonMaKUMu(java.lang.string str, java.lang.string str2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LgbDJekNonMaKUMu(java.lang.string str, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        java.lang.string strConsoleLzuKqEjRPobFn = ConsoleLzuKqEjRPobFn(parcel);
        if (strConsoleLzuKqEjRPobFn is null) {
            strConsoleLzuKqEjRPobFn = "";
        }
        try {
            return lgbDJekNonMaKUMu(strConsoleLzuKqEjRPobFn);
        } catch (com.google.android.gms.fido.fido2.api.common.C0262x11efcb6 e) {
            throw new java.lang.Exception(e);
        }
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.fido.fido2.api.common.ResidentKeyRequirement[i];
    }
}

