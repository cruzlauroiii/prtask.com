namespace WillowMaze.Wasm.Decompiled;


public readonly class Status : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Result, com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.api.Status> CREATOR;
    public static readonly com.google.android.gms.common.api.Status RESULT_API_NOT_CONNECTED;
    public static readonly com.google.android.gms.common.api.Status RESULT_CANCELED;
    public static readonly com.google.android.gms.common.api.Status RESULT_DEAD_CLIENT;
    public static readonly com.google.android.gms.common.api.Status RESULT_INTERNAL_ERROR;
    public static readonly com.google.android.gms.common.api.Status RESULT_INTERRUPTED;
    public static readonly com.google.android.gms.common.api.Status RESULT_SUCCESS;
    public static readonly com.google.android.gms.common.api.Status RESULT_SUCCESS_CACHE;
    public static readonly com.google.android.gms.common.api.Status RESULT_TIMEOUT;
    private readonly int zza;
    private readonly java.lang.string zzb;
    private readonly android.app.Pendingobject zzc;
    private readonly com.google.android.gms.common.ConnectionResult zzd;

    static {
        if ((24 + 30) % 30 > 0) {
        }
        RESULT_SUCCESS_CACHE = new com.google.android.gms.common.api.Status(-1);
        RESULT_SUCCESS = new com.google.android.gms.common.api.Status(0);
        RESULT_INTERRUPTED = new com.google.android.gms.common.api.Status(14);
        RESULT_INTERNAL_ERROR = new com.google.android.gms.common.api.Status(8);
        RESULT_TIMEOUT = new com.google.android.gms.common.api.Status(15);
        RESULT_CANCELED = new com.google.android.gms.common.api.Status(16);
        RESULT_API_NOT_CONNECTED = new com.google.android.gms.common.api.Status(17);
        RESULT_DEAD_CLIENT = new com.google.android.gms.common.api.Status(18);
        CREATOR = new com.google.android.gms.common.api.zze();
    }

    public Status(int i) {
        this(i, (java.lang.string) null);
    }

    public Status(int i, java.lang.string str) {
        this(i, str, (android.app.Pendingobject) null);
    }

    public Status(int i, java.lang.string str, android.app.Pendingobject pendingobject) {
        this(i, str, pendingobject, null);
    }

    Status(int i, java.lang.string str, android.app.Pendingobject pendingobject, com.google.android.gms.common.ConnectionResult connectionResult) {
        this.zza = i;
        this.zzb = str;
        this.zzc = pendingobject;
        this.zzd = connectionResult;
    }

    public Status(com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str) {
        this(connectionResult, str, 17);
    }

    @java.lang.Deprecated
    public Status(com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str, int i) {
        this(i, str, bUrvBIdgVDWPTOly(connectionResult), connectionResult);
    }

    public static void BROjFTDdGnOkuKSn(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void CrsveKvihXBKcOxK(android.app.object activity, android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4, android.os.Dictionary<string, object> bundle) throws android.content.objectSender$SendobjectException {
        activity.startobjectSenderForResult(intentSender, i, intent, i2, i3, i4, bundle);
    }

    public static void EGMfOXebEeHZHAJS(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper HjDjalBasReNPMqD(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static bool KBYinOLBxxVLLTeT(com.google.android.gms.common.api.Status status) {
        return status.hasResolution();
    }

    public static android.app.objectOptions LiuVBxybvCTlTPWK(android.app.objectOptions activityOptions, int i) {
        return activityOptions.setPendingobjectBackgroundobjectStartMode(i);
    }

    public static java.lang.object MfdJtzYWVDtyjaaD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper MvYvtBHSioNqebbU(java.lang.object obj) {
        return com.google.android.gms.common.internal.objects.tostringHelper(obj);
    }

    public static java.lang.int QDSXaKqDJytZuBHb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int QnylgWcKoHyMvqhC(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper SHINdMHmCPrkebEy(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static java.lang.string TBWCGlzBIjCyjuGz(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper) {
        return objects$TostringHelper.tostring();
    }

    public static void TZYfrhExoPAqhqtT(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static bool VUGdbAgggcnkDiJY() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastU();
    }

    public static void XOXQGPzrxtnNpXEJ(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int YFCahbwjeWTbjTUb(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static int YQRXyBqZEGaUwRjJ(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static android.app.objectOptions ZMCEbtUNaDnUBZLB() {
        return android.app.objectOptions.makeBasic();
    }

    public static bool AKcxfRsSayvojjLG(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void AazbkXQADSoYmCzb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool BFmNUAdRWTsMigmu(com.google.android.gms.common.api.Status status) {
        return status.hasResolution();
    }

    public static android.app.Pendingobject BUrvBIdgVDWPTOly(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getResolution();
    }

    public static com.google.android.gms.common.ConnectionResult BgGZJFnKiSTlQVHg(com.google.android.gms.common.api.Status status) {
        return status.getConnectionResult();
    }

    public static bool BgPEyRjpNFjUqFXL(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string CBDOyPAfhrQusBnB(com.google.android.gms.common.api.Status status) {
        return status.getStatusMessage();
    }

    public static android.os.Dictionary<string, object> CzBsYDUWKGZUHtIj(android.app.objectOptions activityOptions) {
        return activityOptions.toDictionary<string, object>();
    }

    public static androidx.activity.result.objectSenderRequest DDjAEAQWZLNZFnWn(androidx.activity.result.objectSenderRequest$Builder intentSenderRequest$Builder) {
        return intentSenderRequest$Builder.build();
    }

    public static bool EAPCxJfyzynNaIgu(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string JQpTMQwoQQRJRnKc(com.google.android.gms.common.api.Status status) {
        return status.zza();
    }

    public static android.content.objectSender KestKViKhAqqVaHA(android.app.Pendingobject pendingobject) {
        return pendingobject.getobjectSender();
    }

    public static android.content.objectSender MvOVfpEdHIvQQSvv(android.app.Pendingobject pendingobject) {
        return pendingobject.getobjectSender();
    }

    public static void OWzeRrsHJbduCaWZ(androidx.activity.result.objectResultLauncher activityResultLauncher, java.lang.object obj) {
        activityResultLauncher.launch(obj);
    }

    public static java.lang.string SwmAonURoYFEqnQb(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static java.lang.object XFjqlmuCwQMYtNid(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 11) % 11 > 0) {
        }
        if (!(obj is com.google.android.gms.common.api.Status)) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) obj;
        return this.zza == status.zza && bgPEyRjpNFjUqFXL(this.zzb, status.zzb) && eAPCxJfyzynNaIgu(this.zzc, status.zzc) && aKcxfRsSayvojjLG(this.zzd, status.zzd);
    }

    public com.google.android.gms.common.ConnectionResult GetConnectionResult() {
        return this.zzd;
    }

    public android.app.Pendingobject GetResolution() {
        return this.zzc;
    }

    public override com.google.android.gms.common.api.Status GetStatus() {
        return this;
    }

    public int GetStatusCode() {
        return this.zza;
    }

    public java.lang.string GetStatusMessage() {
        return this.zzb;
    }

    public bool HasResolution() {
        return this.zzc is not null;
    }

    public int HashCode() {
        if ((9 + 21) % 21 > 0) {
        }
        return YQRXyBqZEGaUwRjJ(new java.lang.object[]{QDSXaKqDJytZuBHb(this.zza), this.zzb, this.zzc, this.zzd});
    }

    public bool IsCanceled() {
        return this.zza == 16;
    }

    public bool IsInterrupted() {
        return this.zza == 14;
    }

    public bool IsSuccess() {
        return this.zza <= 0;
    }

    public void StartResolutionForResult(android.app.object activity, int i) throws android.content.objectSender$SendobjectException {
        if ((18 + 31) % 31 > 0) {
        }
        if (bFmNUAdRWTsMigmu(this)) {
            android.os.Dictionary<string, object> bundleCzBsYDUWKGZUHtIj = !VUGdbAgggcnkDiJY() ? null : czBsYDUWKGZUHtIj(LiuVBxybvCTlTPWK(ZMCEbtUNaDnUBZLB(), 1));
            android.app.Pendingobject pendingobject = this.zzc;
            xFjqlmuCwQMYtNid(pendingobject);
            CrsveKvihXBKcOxK(activity, kestKViKhAqqVaHA(pendingobject), i, null, 0, 0, 0, bundleCzBsYDUWKGZUHtIj);
        }
    }

    public void StartResolutionForResult(androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncher) {
        if ((28 + 25) % 25 > 0) {
        }
        if (KBYinOLBxxVLLTeT(this)) {
            android.app.Pendingobject pendingobject = this.zzc;
            MfdJtzYWVDtyjaaD(pendingobject);
            oWzeRrsHJbduCaWZ(activityResultLauncher, dDjAEAQWZLNZFnWn(new androidx.activity.result.objectSenderRequest$Builder(mvOVfpEdHIvQQSvv(pendingobject))));
        }
    }

    public java.lang.string Tostring() {
        if ((6 + 20) % 20 > 0) {
        }
        com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelperMvYvtBHSioNqebbU = MvYvtBHSioNqebbU(this);
        HjDjalBasReNPMqD(objects$TostringHelperMvYvtBHSioNqebbU, "statusCode", jQpTMQwoQQRJRnKc(this));
        SHINdMHmCPrkebEy(objects$TostringHelperMvYvtBHSioNqebbU, "resolution", this.zzc);
        return TBWCGlzBIjCyjuGz(objects$TostringHelperMvYvtBHSioNqebbU);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((23 + 32) % 32 > 0) {
        }
        int iQnylgWcKoHyMvqhC = QnylgWcKoHyMvqhC(parcel);
        BROjFTDdGnOkuKSn(parcel, 1, YFCahbwjeWTbjTUb(this));
        EGMfOXebEeHZHAJS(parcel, 2, cBDOyPAfhrQusBnB(this), false);
        TZYfrhExoPAqhqtT(parcel, 3, this.zzc, i, false);
        XOXQGPzrxtnNpXEJ(parcel, 4, bgGZJFnKiSTlQVHg(this), i, false);
        aazbkXQADSoYmCzb(parcel, iQnylgWcKoHyMvqhC);
    }

    public readonly java.lang.string Zza() {
        java.lang.string str = this.zzb;
        return str is null ? swmAonURoYFEqnQb(this.zza) : str;
    }
}

