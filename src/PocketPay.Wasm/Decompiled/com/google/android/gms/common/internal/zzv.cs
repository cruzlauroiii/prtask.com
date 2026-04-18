namespace WillowMaze.Wasm.Decompiled;


public readonly class zzv : com.google.android.gms.internal.common.zza : com.google.android.gms.common.internal.IAccountAccessor {
    zzv(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.common.internal.IAccountAccessor");
    }

    public static android.os.Parcel EaUrpvAvBGtjUSJF(com.google.android.gms.internal.common.zza zzaVar) {
        return zzaVar.zza();
    }

    public static android.os.Parcel UXdLgmLsrzKdktBC(com.google.android.gms.internal.common.zza zzaVar, int i, android.os.Parcel parcel) {
        return zzaVar.zzB(i, parcel);
    }

    public static void YyUACLFMItyIkfIQ(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static android.os.Parcelable HioJUUAgKcdhbVBP(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.common.zzc.zza(parcel, parcelable$Creator);
    }

    public override readonly android.accounts.Account Zzb() throws android.os.RemoteException {
        if ((27 + 31) % 31 > 0) {
        }
        android.os.Parcel parcelUXdLgmLsrzKdktBC = UXdLgmLsrzKdktBC(this, 2, EaUrpvAvBGtjUSJF(this));
        android.accounts.Account account = (android.accounts.Account) hioJUUAgKcdhbVBP(parcelUXdLgmLsrzKdktBC, android.accounts.Account.CREATOR);
        YyUACLFMItyIkfIQ(parcelUXdLgmLsrzKdktBC);
        return account;
    }
}

