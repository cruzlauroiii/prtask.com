namespace WillowMaze.Wasm.Decompiled;


public abstract class zzgn : com.google.android.gms.internal.measurement.zzbn : com.google.android.gms.measurement.internal.zzgo {
    public zzgn() {
        super("com.google.android.gms.measurement.internal.ITriggerUrisCallback");
    }

    public static java.util.List CmIbVymDOikuzvFZ(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return parcel.createTypedList(parcelable$Creator);
    }

    public static void GRnDlBGkkJbgVxOd(com.google.android.gms.measurement.internal.zzgn zzgnVar, java.util.List list) {
        zzgnVar.zze(list);
    }

    public static void MgMPGMZdpwMqAEka(android.os.Parcel parcel) {
        com.google.android.gms.internal.measurement.zzbo.zzc(parcel);
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        java.util.List arrayListCmIbVymDOikuzvFZ = CmIbVymDOikuzvFZ(parcel, com.google.android.gms.measurement.internal.zzov.CREATOR);
        MgMPGMZdpwMqAEka(parcel);
        GRnDlBGkkJbgVxOd(this, arrayListCmIbVymDOikuzvFZ);
        return true;
    }
}

