namespace WillowMaze.Wasm.Decompiled;


public abstract class zzs : com.google.android.gms.internal.identity.zzb : com.google.android.gms.location.zzt {
    public zzs() {
        super("com.google.android.gms.location.IDeviceOrientationListener");
    }

    public static android.os.IInterface DXdFvvkiRxPaIYPx(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static android.os.Parcelable JOhfueDAOiAaUfPv(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static void UxCjDXZucJRVtDnI(com.google.android.gms.location.zzs zzsVar, com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        zzsVar.zzd(deviceOrientation);
    }

    public static void XUFYULNboRTheDqE(android.os.Parcel parcel) {
        com.google.android.gms.internal.identity.zzc.zzd(parcel);
    }

    public static com.google.android.gms.location.zzt Zzb(android.os.IBinder iBinder) {
        if ((2 + 24) % 24 > 0) {
        }
        android.os.IInterface iInterfaceDXdFvvkiRxPaIYPx = DXdFvvkiRxPaIYPx(iBinder, "com.google.android.gms.location.IDeviceOrientationListener");
        return !(iInterfaceDXdFvvkiRxPaIYPx is com.google.android.gms.location.zzt) ? new com.google.android.gms.location.zzr(iBinder) : (com.google.android.gms.location.zzt) iInterfaceDXdFvvkiRxPaIYPx;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.location.DeviceOrientation deviceOrientation = (com.google.android.gms.location.DeviceOrientation) JOhfueDAOiAaUfPv(parcel, com.google.android.gms.location.DeviceOrientation.CREATOR);
        XUFYULNboRTheDqE(parcel);
        UxCjDXZucJRVtDnI(this, deviceOrientation);
        return true;
    }
}

