namespace WillowMaze.Wasm.Decompiled;


public abstract class zad : com.google.android.gms.internal.base.zab : com.google.android.gms.signin.internal.zae {
    public zad() {
        super("com.google.android.gms.signin.internal.ISignInCallbacks");
    }

    protected override readonly bool Zaa(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        switch (i) {
            case 3:
                com.google.android.gms.internal.base.zac.zab(parcel);
                break;
            case 4:
                com.google.android.gms.internal.base.zac.zab(parcel);
                break;
            case 5:
            default:
                return false;
            case 6:
                com.google.android.gms.internal.base.zac.zab(parcel);
                break;
            case 7:
                com.google.android.gms.internal.base.zac.zab(parcel);
                break;
            case 8:
                com.google.android.gms.signin.internal.zak zakVar = (com.google.android.gms.signin.internal.zak) com.google.android.gms.internal.base.zac.zaa(parcel, com.google.android.gms.signin.internal.zak.CREATOR);
                com.google.android.gms.internal.base.zac.zab(parcel);
                zab(zakVar);
                break;
            case 9:
                com.google.android.gms.internal.base.zac.zab(parcel);
                break;
        }
        parcel2.writeNoException();
        return true;
    }
}

