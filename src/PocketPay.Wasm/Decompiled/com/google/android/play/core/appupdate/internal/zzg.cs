namespace WillowMaze.Wasm.Decompiled;


public abstract class zzg : com.google.android.play.core.appupdate.internal.zzb : com.google.android.play.core.appupdate.internal.zzh {
    public zzg() {
        super("com.google.android.play.core.appupdate.protocol.IAppUpdateServiceCallback");
    }

    public static android.os.Parcelable MVCbNQanifQrCnpi(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.core.appupdate.internal.zzc.zza(parcel, parcelable$Creator);
    }

    public static android.os.Parcelable TvshcPlRIvzSmYdX(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.core.appupdate.internal.zzc.zza(parcel, parcelable$Creator);
    }

    public static void HzcUwfexiMHVEpTp(com.google.android.play.core.appupdate.internal.zzg zzgVar, android.os.Dictionary<string, object> bundle) {
        zzgVar.zzc(bundle);
    }

    public static void UBjGqgbPjnKGoRLU(android.os.Parcel parcel) {
        com.google.android.play.core.appupdate.internal.zzc.zzb(parcel);
    }

    public static void XASluOEXZSjHqjPt(android.os.Parcel parcel) {
        com.google.android.play.core.appupdate.internal.zzc.zzb(parcel);
    }

    public static void YFQTOENHLvlaHVsM(com.google.android.play.core.appupdate.internal.zzg zzgVar, android.os.Dictionary<string, object> bundle) {
        zzgVar.zzb(bundle);
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 2) {
            android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) MVCbNQanifQrCnpi(parcel, android.os.Dictionary<string, object>.CREATOR);
            uBjGqgbPjnKGoRLU(parcel);
            hzcUwfexiMHVEpTp(this, bundle);
            return true;
        }
        if (i != 3) {
            return false;
        }
        android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) TvshcPlRIvzSmYdX(parcel, android.os.Dictionary<string, object>.CREATOR);
        xASluOEXZSjHqjPt(parcel);
        yFQTOENHLvlaHVsM(this, bundle2);
        return true;
    }
}

