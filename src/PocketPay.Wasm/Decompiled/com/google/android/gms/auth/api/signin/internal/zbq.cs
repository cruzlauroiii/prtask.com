namespace WillowMaze.Wasm.Decompiled;


public abstract class zbq : com.google.android.gms.internal.p007authapi.zbb : com.google.android.gms.auth.api.signin.internal.zbr {
    public zbq() {
        super("com.google.android.gms.auth.api.signin.internal.ISignInCallbacks");
    }

    public static void BmtPwcXgdAHwpJlw(android.os.Parcel parcel) {
        com.google.android.gms.internal.p007authapi.zbc.zbb(parcel);
    }

    public static android.os.Parcelable GrVAxhiObPpktxVa(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static android.os.Parcelable HBncOgnIguucbjuk(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static void OigCaJCONdEuObbM(com.google.android.gms.auth.api.signin.internal.zbq zbqVar, com.google.android.gms.common.api.Status status) {
        zbqVar.zbc(status);
    }

    public static android.os.Parcelable UPKfhScafJNCuoei(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    public static void UtSJUGzUChexDOUI(com.google.android.gms.auth.api.signin.internal.zbq zbqVar, com.google.android.gms.common.api.Status status) {
        zbqVar.zbb(status);
    }

    public static void DIioUBTypwLYqmdo(android.os.Parcel parcel) {
        com.google.android.gms.internal.p007authapi.zbc.zbb(parcel);
    }

    public static void MOSDsJYNgpWbFAFb(com.google.android.gms.auth.api.signin.internal.zbq zbqVar, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Status status) {
        zbqVar.zbd(googleSignInAccount, status);
    }

    public static void UuBXhDXhkVYpMgeY(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static void VbbqyRnAPzryntRX(android.os.Parcel parcel) {
        com.google.android.gms.internal.p007authapi.zbc.zbb(parcel);
    }

    public static android.os.Parcelable YuGJaJckOwWddsGf(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.p007authapi.zbc.zba(parcel, parcelable$Creator);
    }

    protected override readonly bool Zba(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        switch (i) {
            case 101:
                com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount = (com.google.android.gms.auth.api.signin.GoogleSignInAccount) HBncOgnIguucbjuk(parcel, com.google.android.gms.auth.api.signin.GoogleSignInAccount.CREATOR);
                com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) UPKfhScafJNCuoei(parcel, com.google.android.gms.common.api.Status.CREATOR);
                BmtPwcXgdAHwpJlw(parcel);
                mOSDsJYNgpWbFAFb(this, googleSignInAccount, status);
                break;
            case 102:
                com.google.android.gms.common.api.Status status2 = (com.google.android.gms.common.api.Status) yuGJaJckOwWddsGf(parcel, com.google.android.gms.common.api.Status.CREATOR);
                dIioUBTypwLYqmdo(parcel);
                OigCaJCONdEuObbM(this, status2);
                break;
            case 103:
                com.google.android.gms.common.api.Status status3 = (com.google.android.gms.common.api.Status) GrVAxhiObPpktxVa(parcel, com.google.android.gms.common.api.Status.CREATOR);
                vbbqyRnAPzryntRX(parcel);
                UtSJUGzUChexDOUI(this, status3);
                break;
            default:
                return false;
        }
        uuBXhDXhkVYpMgeY(parcel2);
        return true;
    }
}

