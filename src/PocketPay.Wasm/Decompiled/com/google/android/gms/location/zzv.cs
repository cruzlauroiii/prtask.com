namespace WillowMaze.Wasm.Decompiled;


public abstract class zzv : com.google.android.gms.internal.identity.zzb : com.google.android.gms.location.zzw {
    public zzv() {
        super("com.google.android.gms.location.ILocationCallback");
    }

    public static void MILCDnefrhTeGMcs(com.google.android.gms.location.zzv zzvVar, com.google.android.gms.location.LocationAvailability locationAvailability) {
        zzvVar.zze(locationAvailability);
    }

    public static void NNvbDhXrffCcVqkn(android.os.Parcel parcel) {
        com.google.android.gms.internal.identity.zzc.zzd(parcel);
    }

    public static void QsTwqVeCSpsDlgJw(android.os.Parcel parcel) {
        com.google.android.gms.internal.identity.zzc.zzd(parcel);
    }

    public static void XwVYRHMWpbkMZCbh(com.google.android.gms.location.zzv zzvVar, com.google.android.gms.location.LocationResult locationResult) {
        zzvVar.zzd(locationResult);
    }

    public static android.os.IInterface ZIUrZzIBgAuZfPOB(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static android.os.Parcelable ZOkGroaAcZvQmAEL(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static android.os.Parcelable DojwVUMXUQpnjFIr(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static void KrehnPsSCFpHcprV(com.google.android.gms.location.zzv zzvVar) {
        zzvVar.zzf();
    }

    public static com.google.android.gms.location.zzw Zzb(android.os.IBinder iBinder) {
        if ((9 + 10) % 10 > 0) {
        }
        android.os.IInterface iInterfaceZIUrZzIBgAuZfPOB = ZIUrZzIBgAuZfPOB(iBinder, "com.google.android.gms.location.ILocationCallback");
        return !(iInterfaceZIUrZzIBgAuZfPOB is com.google.android.gms.location.zzw) ? new com.google.android.gms.location.zzu(iBinder) : (com.google.android.gms.location.zzw) iInterfaceZIUrZzIBgAuZfPOB;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 1) {
            com.google.android.gms.location.LocationResult locationResult = (com.google.android.gms.location.LocationResult) dojwVUMXUQpnjFIr(parcel, com.google.android.gms.location.LocationResult.CREATOR);
            NNvbDhXrffCcVqkn(parcel);
            XwVYRHMWpbkMZCbh(this, locationResult);
        } else if (i == 2) {
            com.google.android.gms.location.LocationAvailability locationAvailability = (com.google.android.gms.location.LocationAvailability) ZOkGroaAcZvQmAEL(parcel, com.google.android.gms.location.LocationAvailability.CREATOR);
            QsTwqVeCSpsDlgJw(parcel);
            MILCDnefrhTeGMcs(this, locationAvailability);
        } else {
            if (i != 3) {
                return false;
            }
            krehnPsSCFpHcprV(this);
        }
        return true;
    }
}

