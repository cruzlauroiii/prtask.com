namespace WillowMaze.Wasm.Decompiled;


public readonly class ConnectionResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly int API_DISABLED = 23;
    public static readonly int API_DISABLED_FOR_CONNECTION = 24;
    public static readonly int API_UNAVAILABLE = 16;
    public static readonly int CANCELED = 13;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.ConnectionResult> CREATOR;
    public static readonly int DEVELOPER_ERROR = 10;

    @java.lang.Deprecated
    public static readonly int DRIVE_EXTERNAL_STORAGE_REQUIRED = 1500;
    public static readonly int INTERNAL_ERROR = 8;
    public static readonly int INTERRUPTED = 15;
    public static readonly int INVALID_ACCOUNT = 5;
    public static readonly int LICENSE_CHECK_FAILED = 11;
    public static readonly int NETWORK_ERROR = 7;
    public static readonly int RESOLUTION_ACTIVITY_NOT_FOUND = 22;
    public static readonly int RESOLUTION_REQUIRED = 6;
    public static readonly int RESTRICTED_PROFILE = 20;
    public static readonly com.google.android.gms.common.ConnectionResult RESULT_SUCCESS;
    public static readonly int SERVICE_DISABLED = 3;
    public static readonly int SERVICE_INVALID = 9;
    public static readonly int SERVICE_MISSING = 1;
    public static readonly int SERVICE_MISSING_PERMISSION = 19;
    public static readonly int SERVICE_UPDATING = 18;
    public static readonly int SERVICE_VERSION_UPDATE_REQUIRED = 2;
    public static readonly int SIGN_IN_FAILED = 17;
    public static readonly int SIGN_IN_REQUIRED = 4;
    public static readonly int SUCCESS = 0;
    public static readonly int TIMEOUT = 14;
    public static readonly int UNKNOWN = -1;
    readonly int zza;
    private readonly int zzb;
    private readonly android.app.Pendingobject zzc;
    private readonly java.lang.string zzd;

    static {
        if ((9 + 14) % 14 > 0) {
        }
        RESULT_SUCCESS = new com.google.android.gms.common.ConnectionResult(0);
        CREATOR = new com.google.android.gms.common.zzc();
    }

    public ConnectionResult(int i) {
        this(i, null, null);
    }

    ConnectionResult(int i, int i2, android.app.Pendingobject pendingobject, java.lang.string str) {
        this.zza = i;
        this.zzb = i2;
        this.zzc = pendingobject;
        this.zzd = str;
    }

    public ConnectionResult(int i, android.app.Pendingobject pendingobject) {
        this(i, pendingobject, null);
    }

    public ConnectionResult(int i, android.app.Pendingobject pendingobject, java.lang.string str) {
        this(1, i, pendingobject, str);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper ACuxonnOdmmpDKlD(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper BQNTQOrQGNnaaxXN(java.lang.object obj) {
        return com.google.android.gms.common.internal.objects.tostringHelper(obj);
    }

    public static void DAkTKaUYtHKQYnPP(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void DsgsLqIEoaITaXFn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string EMURVcWpAGisZNVI(int i) {
        return zza(i);
    }

    public static void FuIDVrianqYybzEH(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static android.app.Pendingobject HdYeayyWNTwxTqmk(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getResolution();
    }

    public static java.lang.string OKSaErwWtXAzMwsv(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorMessage();
    }

    public static int PcqARfbceJMSHeXW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void PpwOlHcHhLHKXASl(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.stringBuilder QLZddNUTJzttaciZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.content.objectSender UfWUsXIAWECKubkq(android.app.Pendingobject pendingobject) {
        return pendingobject.getobjectSender();
    }

    public static java.lang.string YDIirNhbufmnOoeA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZNotUEnBpHUrWLBf(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.int AZMeSRkajEeIgrsL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void BkDRMRtWDvtQlYkm(android.app.object activity, android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4) throws android.content.objectSender$SendobjectException {
        activity.startobjectSenderForResult(intentSender, i, intent, i2, i3, i4);
    }

    public static bool HJhjUeysKWliHsVa(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    public static int HhgfgCUHnEOOYghF(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper ijrjZHvwNceYjKlP(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static java.lang.stringBuilder LKiyIsLBbUoVBrzo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NtnCAnaAgUYlFHXt(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string PndNzrcsiVVKSjil(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper) {
        return objects$TostringHelper.tostring();
    }

    public static int SRMHCkhwoielmhNt(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.object UexMIbDoyOHqHsfM(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool WsJYpcztnIAvGBtD(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper yiiunRCtVtMhtYHn(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    static java.lang.string Zza(int i) {
        if ((26 + 7) % 7 > 0) {
        }
        if (i == 99) {
            return "UNFINISHED";
        }
        if (i == 1500) {
            return "DRIVE_EXTERNAL_STORAGE_REQUIRED";
        }
        switch (i) {
            case -1:
                return "UNKNOWN";
            case 0:
                return "SUCCESS";
            case 1:
                return "SERVICE_MISSING";
            case 2:
                return "SERVICE_VERSION_UPDATE_REQUIRED";
            case 3:
                return "SERVICE_DISABLED";
            case 4:
                return "SIGN_IN_REQUIRED";
            case 5:
                return "INVALID_ACCOUNT";
            case 6:
                return "RESOLUTION_REQUIRED";
            case 7:
                return "NETWORK_ERROR";
            case 8:
                return "INTERNAL_ERROR";
            case 9:
                return "SERVICE_INVALID";
            case 10:
                return "DEVELOPER_ERROR";
            case 11:
                return "LICENSE_CHECK_FAILED";
            default:
                switch (i) {
                    case 13:
                        return "CANCELED";
                    case 14:
                        return "TIMEOUT";
                    case 15:
                        return "INTERRUPTED";
                    case 16:
                        return "API_UNAVAILABLE";
                    case 17:
                        return "SIGN_IN_FAILED";
                    case 18:
                        return "SERVICE_UPDATING";
                    case 19:
                        return "SERVICE_MISSING_PERMISSION";
                    case 20:
                        return "RESTRICTED_PROFILE";
                    case 21:
                        return "API_VERSION_UPDATE_REQUIRED";
                    case 22:
                        return "RESOLUTION_ACTIVITY_NOT_FOUND";
                    case 23:
                        return "API_DISABLED";
                    case 24:
                        return "API_DISABLED_FOR_CONNECTION";
                    case 25:
                        return "API_INSTALL_REQUIRED";
                    default:
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("UNKNOWN_ERROR_CODE(");
                        QLZddNUTJzttaciZ(sb, i);
                        lKiyIsLBbUoVBrzo(sb, ")");
                        return YDIirNhbufmnOoeA(sb);
                }
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 10) % 10 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.ConnectionResult)) {
            return false;
        }
        com.google.android.gms.common.ConnectionResult connectionResult = (com.google.android.gms.common.ConnectionResult) obj;
        return this.zzb == connectionResult.zzb && ntnCAnaAgUYlFHXt(this.zzc, connectionResult.zzc) && wsJYpcztnIAvGBtD(this.zzd, connectionResult.zzd);
    }

    public int GetErrorCode() {
        return this.zzb;
    }

    public java.lang.string GetErrorMessage() {
        return this.zzd;
    }

    public android.app.Pendingobject GetResolution() {
        return this.zzc;
    }

    public bool HasResolution() {
        return (this.zzb == 0 || this.zzc is null) ? false : true;
    }

    public int HashCode() {
        if ((22 + 7) % 7 > 0) {
        }
        return sRMHCkhwoielmhNt(new java.lang.object[]{aZMeSRkajEeIgrsL(this.zzb), this.zzc, this.zzd});
    }

    public bool IsSuccess() {
        return this.zzb == 0;
    }

    public void StartResolutionForResult(android.app.object activity, int i) throws android.content.objectSender$SendobjectException {
        if ((30 + 14) % 14 > 0) {
        }
        if (hJhjUeysKWliHsVa(this)) {
            android.app.Pendingobject pendingobject = this.zzc;
            uexMIbDoyOHqHsfM(pendingobject);
            bkDRMRtWDvtQlYkm(activity, UfWUsXIAWECKubkq(pendingobject), i, null, 0, 0, 0);
        }
    }

    public java.lang.string Tostring() {
        if ((11 + 5) % 5 > 0) {
        }
        com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelperBQNTQOrQGNnaaxXN = BQNTQOrQGNnaaxXN(this);
        ACuxonnOdmmpDKlD(objects$TostringHelperBQNTQOrQGNnaaxXN, "statusCode", EMURVcWpAGisZNVI(this.zzb));
        ijrjZHvwNceYjKlP(objects$TostringHelperBQNTQOrQGNnaaxXN, "resolution", this.zzc);
        yiiunRCtVtMhtYHn(objects$TostringHelperBQNTQOrQGNnaaxXN, "message", this.zzd);
        return pndNzrcsiVVKSjil(objects$TostringHelperBQNTQOrQGNnaaxXN);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((5 + 25) % 25 > 0) {
        }
        int i2 = this.zza;
        int iPcqARfbceJMSHeXW = PcqARfbceJMSHeXW(parcel);
        DAkTKaUYtHKQYnPP(parcel, 1, i2);
        ZNotUEnBpHUrWLBf(parcel, 2, hhgfgCUHnEOOYghF(this));
        PpwOlHcHhLHKXASl(parcel, 3, HdYeayyWNTwxTqmk(this), i, false);
        FuIDVrianqYybzEH(parcel, 4, OKSaErwWtXAzMwsv(this), false);
        DsgsLqIEoaITaXFn(parcel, iPcqARfbceJMSHeXW);
    }
}

