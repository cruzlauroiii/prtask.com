namespace WillowMaze.Wasm.Decompiled;


public abstract class zzdd : com.google.android.gms.internal.measurement.zzbn : com.google.android.gms.internal.measurement.zzde {
    public zzdd() {
        super("com.google.android.gms.measurement.api.internal.IEventHandlerProxy");
    }

    public static long CHRubEZDlQkDEChe(android.os.Parcel parcel) {
        if ((8 + 18) % 18 > 0) {
        }
        return parcel.readlong();
    }

    public static java.lang.string EozZUfdqiePOQClO(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void GUiLVOZdNsfTXUIf(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static java.lang.string RYnoDDIXNOJlNNGZ(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void XZkCBuRgEGoFstzU(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    public static android.os.Parcelable DYLTKKMDPAOxNTgV(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.measurement.zzbo.zza(parcel, parcelable$Creator);
    }

    public static void KAlIpYxRQsXgMWoO(com.google.android.gms.internal.measurement.zzdd zzddVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        zzddVar.zzf(str, str2, bundle, j);
    }

    public static int MadRlkYmNcnjjbQg(com.google.android.gms.internal.measurement.zzdd zzddVar) {
        return zzddVar.zze();
    }

    public static void QsBGBnfudjkTtzHM(android.os.Parcel parcel) {
        com.google.android.gms.internal.measurement.zzbo.zzc(parcel);
    }

    public static void TNWHXLxxHGVGivDt(android.os.Parcel parcel) {
        parcel.writeNoException();
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((22 + 4) % 4 > 0) {
        }
        if (i == 1) {
            java.lang.string strEozZUfdqiePOQClO = EozZUfdqiePOQClO(parcel);
            java.lang.string strRYnoDDIXNOJlNNGZ = RYnoDDIXNOJlNNGZ(parcel);
            android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) dYLTKKMDPAOxNTgV(parcel, android.os.Dictionary<string, object>.CREATOR);
            long jCHRubEZDlQkDEChe = CHRubEZDlQkDEChe(parcel);
            qsBGBnfudjkTtzHM(parcel);
            kAlIpYxRQsXgMWoO(this, strEozZUfdqiePOQClO, strRYnoDDIXNOJlNNGZ, bundle, jCHRubEZDlQkDEChe);
            XZkCBuRgEGoFstzU(parcel2);
        } else {
            if (i != 2) {
                return false;
            }
            int iMadRlkYmNcnjjbQg = madRlkYmNcnjjbQg(this);
            tNWHXLxxHGVGivDt(parcel2);
            GUiLVOZdNsfTXUIf(parcel2, iMadRlkYmNcnjjbQg);
        }
        return true;
    }
}

