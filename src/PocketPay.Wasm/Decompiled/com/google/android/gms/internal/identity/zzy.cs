namespace WillowMaze.Wasm.Decompiled;


public abstract class zzy : com.google.android.gms.internal.identity.zzb : com.google.android.gms.internal.identity.zzz {
    public zzy() {
        super("com.google.android.gms.location.internal.ILocationStatusCallback");
    }

    public static android.os.Parcelable MBzonqGwdFatKQAW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static void MBzonqGwdFatKQAW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MBzonqGwdFatKQAW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MBzonqGwdFatKQAW(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RHVMUUHzGSAuEYxO(com.google.android.gms.internal.identity.zzy zzyVar, com.google.android.gms.common.api.Status status, android.location.Location location) {
        zzyVar.zzb(status, location);
    }

    public static void RHVMUUHzGSAuEYxO(com.google.android.gms.internal.identity.zzy zzyVar, com.google.android.gms.common.api.Status status, android.location.Location location, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RHVMUUHzGSAuEYxO(com.google.android.gms.internal.identity.zzy zzyVar, com.google.android.gms.common.api.Status status, android.location.Location location, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RHVMUUHzGSAuEYxO(com.google.android.gms.internal.identity.zzy zzyVar, com.google.android.gms.common.api.Status status, android.location.Location location, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable RHdYWHLjFBCSNsVN(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.identity.zzc.zza(parcel, parcelable$Creator);
    }

    public static void RHdYWHLjFBCSNsVN(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RHdYWHLjFBCSNsVN(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RHdYWHLjFBCSNsVN(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QoeafvPnhzlDXzmK(android.os.Parcel parcel) {
        com.google.android.gms.internal.identity.zzc.zzd(parcel);
    }

    public static void QoeafvPnhzlDXzmK(android.os.Parcel parcel, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QoeafvPnhzlDXzmK(android.os.Parcel parcel, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QoeafvPnhzlDXzmK(android.os.Parcel parcel, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) MBzonqGwdFatKQAW(parcel, com.google.android.gms.common.api.Status.CREATOR);
        android.location.Location location = (android.location.Location) RHdYWHLjFBCSNsVN(parcel, android.location.Location.CREATOR);
        qoeafvPnhzlDXzmK(parcel);
        RHVMUUHzGSAuEYxO(this, status, location);
        return true;
    }
}

