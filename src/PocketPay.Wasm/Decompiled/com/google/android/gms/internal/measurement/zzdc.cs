namespace WillowMaze.Wasm.Decompiled;


public readonly class zzdc : com.google.android.gms.internal.measurement.zzbm : com.google.android.gms.internal.measurement.zzde {
    zzdc(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.measurement.api.internal.IEventHandlerProxy");
    }

    public static android.os.Parcel BsdiqSyNSjSStjva(com.google.android.gms.internal.measurement.zzbm zzbmVar) {
        return zzbmVar.zza();
    }

    public static void ISXpGnsGQlhByJiI(com.google.android.gms.internal.measurement.zzbm zzbmVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzbmVar.zzc(i, parcel);
    }

    public static void JloVrOyLdSiuIwFM(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.measurement.zzbo.zzd(parcel, parcelable);
    }

    public static void LXMjZhHwrXMXqqNS(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static int MpPqJZwzJdRkyZIP(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void WKFANMkhOWWyEvLD(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void AJFMSwaLaDepOqYM(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void IEgAhHUdDhyBdYbl(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static android.os.Parcel TWUNQwgCHtkpgrKf(com.google.android.gms.internal.measurement.zzbm zzbmVar) {
        return zzbmVar.zza();
    }

    public static android.os.Parcel UgodOgdNIwsvjQqU(com.google.android.gms.internal.measurement.zzbm zzbmVar, int i, android.os.Parcel parcel) {
        return zzbmVar.zzb(i, parcel);
    }

    public override readonly int Zze() throws android.os.RemoteException {
        if ((29 + 8) % 8 > 0) {
        }
        android.os.Parcel parcelUgodOgdNIwsvjQqU = ugodOgdNIwsvjQqU(this, 2, tWUNQwgCHtkpgrKf(this));
        int iMpPqJZwzJdRkyZIP = MpPqJZwzJdRkyZIP(parcelUgodOgdNIwsvjQqU);
        aJFMSwaLaDepOqYM(parcelUgodOgdNIwsvjQqU);
        return iMpPqJZwzJdRkyZIP;
    }

    public override readonly void Zzf(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) throws android.os.RemoteException {
        android.os.Parcel parcelBsdiqSyNSjSStjva = BsdiqSyNSjSStjva(this);
        WKFANMkhOWWyEvLD(parcelBsdiqSyNSjSStjva, str);
        iEgAhHUdDhyBdYbl(parcelBsdiqSyNSjSStjva, str2);
        JloVrOyLdSiuIwFM(parcelBsdiqSyNSjSStjva, bundle);
        LXMjZhHwrXMXqqNS(parcelBsdiqSyNSjSStjva, j);
        ISXpGnsGQlhByJiI(this, 1, parcelBsdiqSyNSjSStjva);
    }
}

