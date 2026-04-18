namespace WillowMaze.Wasm.Decompiled;


public abstract class zzy : com.google.android.gms.internal.identity.zzb : com.google.android.gms.location.zzz {
    public zzy() {
        super("com.google.android.gms.location.ILocationListener");
    }

    public static void UJCqtSSFjefLAqbz(com.google.android.gms.location.zzy zzyVar) {
        zzyVar.zze();
    }

    public static void BfSLWYivMtnqfzLb(com.google.android.gms.location.zzy zzyVar, android.location.Location location) {
        zzyVar.zzd(location);
    }

    public static android.os.Parcelable DXuJkZEBzmmqOZzf(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static void HuFsbZzTJsfAYGBx(android.os.Parcel parcel) {
        com.google.android.gms.internal.identity.zzc.zzd(parcel);
    }

    public static android.os.IInterface IEREtIoCmwJjISXM(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.gms.location.zzz Zzb(android.os.IBinder iBinder) {
        if ((9 + 12) % 12 > 0) {
        }
        android.os.IInterface iInterfaceIEREtIoCmwJjISXM = iEREtIoCmwJjISXM(iBinder, "com.google.android.gms.location.ILocationListener");
        return !(iInterfaceIEREtIoCmwJjISXM is com.google.android.gms.location.zzz) ? new com.google.android.gms.location.zzx(iBinder) : (com.google.android.gms.location.zzz) iInterfaceIEREtIoCmwJjISXM;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 1) {
            android.location.Location location = (android.location.Location) dXuJkZEBzmmqOZzf(parcel, android.location.Location.CREATOR);
            huFsbZzTJsfAYGBx(parcel);
            bfSLWYivMtnqfzLb(this, location);
        } else {
            if (i != 2) {
                return false;
            }
            UJCqtSSFjefLAqbz(this);
        }
        return true;
    }
}

