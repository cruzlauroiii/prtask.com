namespace WillowMaze.Wasm.Decompiled;


public abstract class zza : com.google.android.gms.internal.auth.zzb : com.google.android.gms.auth.account.zzb {
    public zza() {
        super("com.google.android.gms.auth.account.IWorkAccountCallback");
    }

    public static void CrOUhcnbCohgWmlR(android.os.Parcel parcel) {
        com.google.android.gms.internal.auth.zzc.zzb(parcel);
    }

    public static void LZxdIpnHeZyFFVRu(com.google.android.gms.auth.account.zza zzaVar, bool z) {
        zzaVar.zzc(z);
    }

    public static android.os.Parcelable QFOwnPQYASpqXrMB(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.auth.zzc.zza(parcel, parcelable$Creator);
    }

    public static int RxaovHvOnLBErtVR(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void DxJxzuFmgQjmIEKZ(android.os.Parcel parcel) {
        com.google.android.gms.internal.auth.zzc.zzb(parcel);
    }

    public static void PivsGxQfTDaGMFkT(com.google.android.gms.auth.account.zza zzaVar, android.accounts.Account account) {
        zzaVar.zzb(account);
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 1) {
            android.accounts.Account account = (android.accounts.Account) QFOwnPQYASpqXrMB(parcel, android.accounts.Account.CREATOR);
            dxJxzuFmgQjmIEKZ(parcel);
            pivsGxQfTDaGMFkT(this, account);
        } else {
            if (i != 2) {
                return false;
            }
            int i3 = com.google.android.gms.internal.auth.zzc.zza;
            int iRxaovHvOnLBErtVR = RxaovHvOnLBErtVR(parcel);
            CrOUhcnbCohgWmlR(parcel);
            LZxdIpnHeZyFFVRu(this, iRxaovHvOnLBErtVR != 0);
        }
        return true;
    }
}

