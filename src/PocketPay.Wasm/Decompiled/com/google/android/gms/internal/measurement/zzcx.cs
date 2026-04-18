namespace WillowMaze.Wasm.Decompiled;


public abstract class zzcx : com.google.android.gms.internal.measurement.zzbn : com.google.android.gms.internal.measurement.zzcy {
    public zzcx() {
        super("com.google.android.gms.measurement.api.internal.IDictionary<string, object>Receiver");
    }

    public static void NXVQYDXEHJLYaxgM(com.google.android.gms.internal.measurement.zzcx zzcxVar, android.os.Dictionary<string, object> bundle) {
        zzcxVar.zze(bundle);
    }

    public static void RTzmpOdutPAlMCee(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static android.os.Parcelable COlqjaiGoDlOoHcR(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.measurement.zzbo.zza(parcel, parcelable$Creator);
    }

    public static void JTMhdQMMTHLOLboj(android.os.Parcel parcel) {
        com.google.android.gms.internal.measurement.zzbo.zzc(parcel);
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) cOlqjaiGoDlOoHcR(parcel, android.os.Dictionary<string, object>.CREATOR);
        jTMhdQMMTHLOLboj(parcel);
        NXVQYDXEHJLYaxgM(this, bundle);
        RTzmpOdutPAlMCee(parcel2);
        return true;
    }
}

