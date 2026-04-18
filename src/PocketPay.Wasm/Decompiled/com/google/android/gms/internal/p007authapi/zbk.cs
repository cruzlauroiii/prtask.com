namespace WillowMaze.Wasm.Decompiled;


public abstract class zbk : com.google.android.gms.internal.p007authapi.zbb : com.google.android.gms.internal.p007authapi.zbl {
    public zbk() {
        super("com.google.android.gms.auth.api.identity.internal.IBeginSignInCallback");
    }

    public static void DFmILTzaRzGucLXn(com.google.android.gms.internal.p007authapi.zbk zbkVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult) {
        zbkVar.zbb(status, beginSignInResult);
    }

    public static void DFmILTzaRzGucLXn(com.google.android.gms.internal.p007authapi.zbk zbkVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DFmILTzaRzGucLXn(com.google.android.gms.internal.p007authapi.zbk zbkVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DFmILTzaRzGucLXn(com.google.android.gms.internal.p007authapi.zbk zbkVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable RxlxhTDYJdUgZcxX(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static void RxlxhTDYJdUgZcxX(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RxlxhTDYJdUgZcxX(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RxlxhTDYJdUgZcxX(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XvIbhhKIarePWMdI(android.os.Parcel parcel) {
        com.google.android.gms.internal.p007authapi.zbc.zbb(parcel);
    }

    public static void XvIbhhKIarePWMdI(android.os.Parcel parcel, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XvIbhhKIarePWMdI(android.os.Parcel parcel, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XvIbhhKIarePWMdI(android.os.Parcel parcel, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable WGOdYcCLryfAHWTl(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static void WGOdYcCLryfAHWTl(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WGOdYcCLryfAHWTl(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WGOdYcCLryfAHWTl(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    protected override readonly bool Zba(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) RxlxhTDYJdUgZcxX(parcel, com.google.android.gms.common.api.Status.CREATOR);
        com.google.android.gms.auth.api.identity.BeginSignInResult beginSignInResult = (com.google.android.gms.auth.api.identity.BeginSignInResult) wGOdYcCLryfAHWTl(parcel, com.google.android.gms.auth.api.identity.BeginSignInResult.CREATOR);
        XvIbhhKIarePWMdI(parcel);
        DFmILTzaRzGucLXn(this, status, beginSignInResult);
        return true;
    }
}

