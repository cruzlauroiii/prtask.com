namespace WillowMaze.Wasm.Decompiled;


public abstract class zaj : com.google.android.gms.internal.base.zab : com.google.android.gms.common.internal.service.zak {
    public zaj() {
        super("com.google.android.gms.common.internal.service.ICommonCallbacks");
    }

    public static void SNgBMptNmOAHadoQ(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    public static int XCPjSxrgpNTrMZGj(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void MMvxmIoDKDlKBksL(com.google.android.gms.common.internal.service.zaj zajVar, int i) {
        zajVar.zab(i);
    }

    protected override readonly bool Zaa(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        int iXCPjSxrgpNTrMZGj = XCPjSxrgpNTrMZGj(parcel);
        SNgBMptNmOAHadoQ(parcel);
        mMvxmIoDKDlKBksL(this, iXCPjSxrgpNTrMZGj);
        return true;
    }
}

