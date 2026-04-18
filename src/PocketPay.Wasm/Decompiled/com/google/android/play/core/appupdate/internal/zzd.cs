namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : com.google.android.play.core.appupdate.internal.zza : com.google.android.play.core.appupdate.internal.zzf {
    zzd(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.play.core.appupdate.protocol.IAppUpdateService");
    }

    public static void BUnrUrKuUVyacNmM(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void MadIXBcCSCruvpNP(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.play.core.appupdate.internal.zzc.zzc(parcel, parcelable);
    }

    public static void TsJboCNggYEmUwbD(com.google.android.play.core.appupdate.internal.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzb(i, parcel);
    }

    public static android.os.Parcel WQRraxGgXFdXQJpA(com.google.android.play.core.appupdate.internal.zza zzaVar) {
        return zzaVar.zza();
    }

    public static void XIRIqTgYCoEHEPHq(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.play.core.appupdate.internal.zzc.zzc(parcel, parcelable);
    }

    public static android.os.Parcel CpJOorfWUkZZTEIY(com.google.android.play.core.appupdate.internal.zza zzaVar) {
        return zzaVar.zza();
    }

    public static void DGVduTlLjdqwKyOT(com.google.android.play.core.appupdate.internal.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzb(i, parcel);
    }

    public static void MYjNULiFxBqcjgnh(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void TqZKERMWOapiGRgv(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void WdWBzXvSDofLubHr(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public override readonly void Zzc(java.lang.string str, android.os.Dictionary<string, object> bundle, com.google.android.play.core.appupdate.internal.zzh zzhVar) throws android.os.RemoteException {
        android.os.Parcel parcelWQRraxGgXFdXQJpA = WQRraxGgXFdXQJpA(this);
        BUnrUrKuUVyacNmM(parcelWQRraxGgXFdXQJpA, str);
        XIRIqTgYCoEHEPHq(parcelWQRraxGgXFdXQJpA, bundle);
        mYjNULiFxBqcjgnh(parcelWQRraxGgXFdXQJpA, zzhVar);
        TsJboCNggYEmUwbD(this, 3, parcelWQRraxGgXFdXQJpA);
    }

    public override readonly void Zzd(java.lang.string str, android.os.Dictionary<string, object> bundle, com.google.android.play.core.appupdate.internal.zzh zzhVar) throws android.os.RemoteException {
        android.os.Parcel parcelCpJOorfWUkZZTEIY = cpJOorfWUkZZTEIY(this);
        wdWBzXvSDofLubHr(parcelCpJOorfWUkZZTEIY, str);
        MadIXBcCSCruvpNP(parcelCpJOorfWUkZZTEIY, bundle);
        tqZKERMWOapiGRgv(parcelCpJOorfWUkZZTEIY, zzhVar);
        dGVduTlLjdqwKyOT(this, 2, parcelCpJOorfWUkZZTEIY);
    }
}

