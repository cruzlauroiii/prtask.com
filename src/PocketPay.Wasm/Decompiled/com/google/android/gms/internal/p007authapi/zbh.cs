namespace WillowMaze.Wasm.Decompiled;


public abstract class zbh : com.google.android.gms.internal.p007authapi.zbb : com.google.android.gms.internal.p007authapi.zbi {
    public zbh() {
        super("com.google.android.gms.auth.api.identity.internal.IAuthorizationCallback");
    }

    public static void LGlvxrdBaXpkXnNF(android.os.Parcel parcel) {
        com.google.android.gms.internal.p007authapi.zbc.zbb(parcel);
    }

    public static void LGlvxrdBaXpkXnNF(android.os.Parcel parcel, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LGlvxrdBaXpkXnNF(android.os.Parcel parcel, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LGlvxrdBaXpkXnNF(android.os.Parcel parcel, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable OBmUOLtFTWNxprpm(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static void OBmUOLtFTWNxprpm(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBmUOLtFTWNxprpm(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBmUOLtFTWNxprpm(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RHAnzugtpKnfeEKa(com.google.android.gms.internal.p007authapi.zbh zbhVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) {
        zbhVar.zbb(status, authorizationResult);
    }

    public static void RHAnzugtpKnfeEKa(com.google.android.gms.internal.p007authapi.zbh zbhVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RHAnzugtpKnfeEKa(com.google.android.gms.internal.p007authapi.zbh zbhVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RHAnzugtpKnfeEKa(com.google.android.gms.internal.p007authapi.zbh zbhVar, com.google.android.gms.common.api.Status status, com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable FNEMjQxSquskfbIS(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static void FNEMjQxSquskfbIS(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FNEMjQxSquskfbIS(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FNEMjQxSquskfbIS(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    protected override readonly bool Zba(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) fNEMjQxSquskfbIS(parcel, com.google.android.gms.common.api.Status.CREATOR);
        com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult = (com.google.android.gms.auth.api.identity.AuthorizationResult) OBmUOLtFTWNxprpm(parcel, com.google.android.gms.auth.api.identity.AuthorizationResult.CREATOR);
        LGlvxrdBaXpkXnNF(parcel);
        RHAnzugtpKnfeEKa(this, status, authorizationResult);
        return true;
    }
}

