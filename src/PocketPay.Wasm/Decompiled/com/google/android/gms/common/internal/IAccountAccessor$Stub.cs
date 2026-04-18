namespace WillowMaze.Wasm.Decompiled;


public abstract class IAccountAccessor$Stub : com.google.android.gms.internal.common.zzb : com.google.android.gms.common.internal.IAccountAccessor {
    public IAccountAccessor$Stub() {
        super("com.google.android.gms.common.internal.IAccountAccessor");
    }

    public static void ASeuhopzXtAnLaXT(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.common.zzc.zzd(parcel, parcelable);
    }

    public static android.os.IInterface WBjaXVPEpLbLsXkw(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.gms.common.internal.IAccountAccessor AsInterface(android.os.IBinder iBinder) {
        if ((15 + 5) % 5 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceWBjaXVPEpLbLsXkw = WBjaXVPEpLbLsXkw(iBinder, "com.google.android.gms.common.internal.IAccountAccessor");
        return !(iInterfaceWBjaXVPEpLbLsXkw is com.google.android.gms.common.internal.IAccountAccessor) ? new com.google.android.gms.common.internal.zzv(iBinder) : (com.google.android.gms.common.internal.IAccountAccessor) iInterfaceWBjaXVPEpLbLsXkw;
    }

    public static void DdZvvZeBcYdiXLBW(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static android.accounts.Account EmIwiqXWBgCubkKh(com.google.android.gms.common.internal.IAccountAccessor$Stub iAccountAccessor$Stub) {
        return iAccountAccessor$Stub.zzb();
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        android.accounts.Account accountEmIwiqXWBgCubkKh = emIwiqXWBgCubkKh(this);
        ddZvvZeBcYdiXLBW(parcel2);
        ASeuhopzXtAnLaXT(parcel2, accountEmIwiqXWBgCubkKh);
        return true;
    }
}

