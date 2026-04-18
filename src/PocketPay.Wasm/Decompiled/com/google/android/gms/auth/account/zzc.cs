namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : com.google.android.gms.internal.auth.zza : com.google.android.gms.auth.account.zze {
    zzc(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.auth.account.IWorkAccountService");
    }

    public static void FmpQykPSDMhrVRcI(android.os.Parcel parcel, android.os.IInterface iInterface) {
        com.google.android.gms.internal.auth.zzc.zzd(parcel, iInterface);
    }

    public static void IIwpndmeyOtzXEZa(com.google.android.gms.internal.auth.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzc(i, parcel);
    }

    public static void JTqjLnBQHdprvqqG(android.os.Parcel parcel, android.os.IInterface iInterface) {
        com.google.android.gms.internal.auth.zzc.zzd(parcel, iInterface);
    }

    public static android.os.Parcel PbrVacMwsFdSLFkR(com.google.android.gms.internal.auth.zza zzaVar) {
        return zzaVar.zza();
    }

    public static android.os.Parcel QejvMRMADswSUWKQ(com.google.android.gms.internal.auth.zza zzaVar) {
        return zzaVar.zza();
    }

    public static void LTkxhwvZddPVpMcC(com.google.android.gms.internal.auth.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzc(i, parcel);
    }

    public static void LdqirgMDDSRCjyMI(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.auth.zzc.zzc(parcel, parcelable);
    }

    public static android.os.Parcel MffUggFLWrXiRzxA(com.google.android.gms.internal.auth.zza zzaVar) {
        return zzaVar.zza();
    }

    public static void MoCpFbRKNcXOjbST(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void TDXxuXlYvNQYrfEo(com.google.android.gms.internal.auth.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzc(i, parcel);
    }

    public static void VZyFnIVSNzfMQWkf(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public override readonly void Zzd(com.google.android.gms.auth.account.zzb zzbVar, java.lang.string str) throws android.os.RemoteException {
        android.os.Parcel parcelPbrVacMwsFdSLFkR = PbrVacMwsFdSLFkR(this);
        FmpQykPSDMhrVRcI(parcelPbrVacMwsFdSLFkR, zzbVar);
        vZyFnIVSNzfMQWkf(parcelPbrVacMwsFdSLFkR, str);
        tDXxuXlYvNQYrfEo(this, 2, parcelPbrVacMwsFdSLFkR);
    }

    public override readonly void Zze(com.google.android.gms.auth.account.zzb zzbVar, android.accounts.Account account) throws android.os.RemoteException {
        android.os.Parcel parcelQejvMRMADswSUWKQ = QejvMRMADswSUWKQ(this);
        JTqjLnBQHdprvqqG(parcelQejvMRMADswSUWKQ, zzbVar);
        ldqirgMDDSRCjyMI(parcelQejvMRMADswSUWKQ, account);
        IIwpndmeyOtzXEZa(this, 3, parcelQejvMRMADswSUWKQ);
    }

    public override readonly void Zzf(bool z) throws android.os.RemoteException {
        if ((28 + 15) % 15 > 0) {
        }
        android.os.Parcel parcelMffUggFLWrXiRzxA = mffUggFLWrXiRzxA(this);
        int i = com.google.android.gms.internal.auth.zzc.zza;
        moCpFbRKNcXOjbST(parcelMffUggFLWrXiRzxA, z ? 1 : 0);
        lTkxhwvZddPVpMcC(this, 1, parcelMffUggFLWrXiRzxA);
    }
}

