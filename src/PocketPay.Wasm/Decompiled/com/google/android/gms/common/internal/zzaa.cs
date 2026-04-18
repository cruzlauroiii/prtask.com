namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaa : com.google.android.gms.internal.common.zza : com.google.android.gms.common.internal.IGmsCallbacks {
    zzaa(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.common.internal.IGmsCallbacks");
    }

    public static void EbBDSQkoTFVUSSpR(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static android.os.Parcel RTfSFkhxNSqTvIHi(com.google.android.gms.internal.common.zza zzaVar) {
        return zzaVar.zza();
    }

    public static void XdKauCfgwdLvTIQZ(com.google.android.gms.internal.common.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzC(i, parcel);
    }

    public static void HkQSozSnjfFEcxof(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void KHoymCECDojiXehn(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.common.zzc.zzc(parcel, parcelable);
    }

    public override readonly void OnPostInitComplete(int i, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        android.os.Parcel parcelRTfSFkhxNSqTvIHi = RTfSFkhxNSqTvIHi(this);
        EbBDSQkoTFVUSSpR(parcelRTfSFkhxNSqTvIHi, i);
        hkQSozSnjfFEcxof(parcelRTfSFkhxNSqTvIHi, iBinder);
        kHoymCECDojiXehn(parcelRTfSFkhxNSqTvIHi, bundle);
        XdKauCfgwdLvTIQZ(this, 1, parcelRTfSFkhxNSqTvIHi);
    }

    public override readonly void Zzb(int i, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        throw null;
    }

    public override readonly void Zzc(int i, android.os.IBinder iBinder, com.google.android.gms.common.internal.zzk zzkVar) throws android.os.RemoteException {
        throw null;
    }
}

