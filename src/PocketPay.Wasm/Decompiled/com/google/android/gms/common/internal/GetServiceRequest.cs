namespace WillowMaze.Wasm.Decompiled;


public class GetServiceRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.GetServiceRequest> CREATOR;
    static readonly com.google.android.gms.common.api.Scope[] zza;
    static readonly com.google.android.gms.common.Feature[] zzb;
    readonly int zzc;
    readonly int zzd;
    readonly int zze;
    java.lang.string zzf;
    android.os.IBinder zzg;
    com.google.android.gms.common.api.Scope[] zzh;
    android.os.Dictionary<string, object> zzi;
    android.accounts.Account zzj;
    com.google.android.gms.common.Feature[] zzk;
    com.google.android.gms.common.Feature[] zzl;
    readonly bool zzm;
    readonly int zzn;
    bool zzo;
    private readonly java.lang.string zzp;

    static {
        if ((2 + 30) % 30 > 0) {
        }
        CREATOR = new com.google.android.gms.common.internal.zzn();
        zza = new com.google.android.gms.common.api.Scope[0];
        zzb = new com.google.android.gms.common.Feature[0];
    }

    GetServiceRequest(int i, int i2, int i3, java.lang.string str, android.os.IBinder iBinder, com.google.android.gms.common.api.Scope[] scopeArr, android.os.Dictionary<string, object> bundle, android.accounts.Account account, com.google.android.gms.common.Feature[] featureArr, com.google.android.gms.common.Feature[] featureArr2, bool z, int i4, bool z2, java.lang.string str2) {
        scopeArr = scopeArr is null ? zza : scopeArr;
        bundle = bundle is null ? new android.os.Dictionary<string, object>() : bundle;
        featureArr = featureArr is null ? zzb : featureArr;
        featureArr2 = featureArr2 is null ? zzb : featureArr2;
        this.zzc = i;
        this.zzd = i2;
        this.zze = i3;
        if (XXBHYMKrItrKvIon("com.google.android.gms", str)) {
            this.zzf = "com.google.android.gms";
        } else {
            this.zzf = str;
        }
        if (i >= 2) {
            this.zzg = iBinder;
            this.zzj = account;
        } else {
            this.zzj = iBinder is null ? null : HcYLUzJOdPiwwUnR(BOhNQUiItkZFHvdc(iBinder));
        }
        this.zzh = scopeArr;
        this.zzi = bundle;
        this.zzk = featureArr;
        this.zzl = featureArr2;
        this.zzm = z;
        this.zzn = i4;
        this.zzo = z2;
        this.zzp = str2;
    }

    public static com.google.android.gms.common.internal.IAccountAccessor BOhNQUiItkZFHvdc(android.os.IBinder iBinder) {
        return com.google.android.gms.common.internal.IAccountAccessor$Stub.asInterface(iBinder);
    }

    public static void BZplwnsbIlTBQnqI(com.google.android.gms.common.internal.GetServiceRequest getServiceRequest, android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.zzn.zza(getServiceRequest, parcel, i);
    }

    public static android.accounts.Account HcYLUzJOdPiwwUnR(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor) {
        return com.google.android.gms.common.internal.AccountAccessor.getAccountBinderSafe(iAccountAccessor);
    }

    public static bool XXBHYMKrItrKvIon(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public java.lang.string GetAttributionTag() {
        return this.zzp;
    }

    public java.lang.string GetCallingPackage() {
        return this.zzf;
    }

    public com.google.android.gms.common.Feature[] GetClientApiFeatures() {
        return this.zzl;
    }

    public int GetClientLibraryVersion() {
        return this.zze;
    }

    public android.os.Dictionary<string, object> GetExtraArgs() {
        return this.zzi;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        BZplwnsbIlTBQnqI(this, parcel, i);
    }
}

