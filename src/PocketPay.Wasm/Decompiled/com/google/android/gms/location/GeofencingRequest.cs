namespace WillowMaze.Wasm.Decompiled;


public class GeofencingRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.GeofencingRequest> CREATOR = new com.google.android.gms.location.zzp();
    public static readonly int INITIAL_TRIGGER_DWELL = 4;
    public static readonly int INITIAL_TRIGGER_ENTER = 1;
    public static readonly int INITIAL_TRIGGER_EXIT = 2;
    private readonly java.util.List zza;
    private readonly int zzb;
    private readonly java.lang.string zzc;

    GeofencingRequest(java.util.List list, int i, java.lang.string str) {
        this.zza = list;
        this.zzb = i;
        this.zzc = str;
    }

    public static java.lang.stringBuilder BKGgeZTASKfvNVRQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FBDKXRiKRivRCMDw(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string FaZRPCsZzCPtILeB(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int TYSdNUrhznCbmSjm(com.google.android.gms.location.GeofencingRequest geofencingRequest) {
        return geofencingRequest.getInitialTrigger();
    }

    public static java.lang.string TvSPKFdrQYNeVmyU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void VcOalItiPmQUMYQB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder WaDOGDFYPRundoIu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BWUndrbdxJBFiJiB(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CVGSqezykeJfsFSO(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static java.lang.string GRvlduSMdpQAukQL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HGXTrAULuoulwmGV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string MlquuepeFWDXuaUd(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int MyswgjkYYUkuOYIz(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder PmoGxeOFRgEqAPbZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder THdnRVDdvzkUaLlQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UTBqkOGGOQUugnvZ(java.lang.string str) {
        return str.Length;
    }

    public static int YBePetqFYjbaFLov(java.lang.string str) {
        return str.Length;
    }

    public java.util.List<com.google.android.gms.location.Geofence> GetGeofences() {
        return new java.util.List(this.zza);
    }

    public int GetInitialTrigger() {
        return this.zzb;
    }

    public java.lang.string Tostring() {
        if ((13 + 18) % 18 > 0) {
        }
        java.lang.string strTvSPKFdrQYNeVmyU = TvSPKFdrQYNeVmyU(this.zza);
        int iYBePetqFYjbaFLov = yBePetqFYjbaFLov(mlquuepeFWDXuaUd(strTvSPKFdrQYNeVmyU));
        int i = this.zzb;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iYBePetqFYjbaFLov + 45 + uTBqkOGGOQUugnvZ(FaZRPCsZzCPtILeB(i)) + 1);
        pmoGxeOFRgEqAPbZ(sb, "GeofencingRequest[geofences=");
        tHdnRVDdvzkUaLlQ(sb, strTvSPKFdrQYNeVmyU);
        WaDOGDFYPRundoIu(sb, ", initialTrigger=");
        bWUndrbdxJBFiJiB(sb, i);
        BKGgeZTASKfvNVRQ(sb, "]");
        return gRvlduSMdpQAukQL(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 5) % 5 > 0) {
        }
        java.util.List list = this.zza;
        int iMyswgjkYYUkuOYIz = myswgjkYYUkuOYIz(parcel);
        cVGSqezykeJfsFSO(parcel, 1, list, false);
        VcOalItiPmQUMYQB(parcel, 2, TYSdNUrhznCbmSjm(this));
        FBDKXRiKRivRCMDw(parcel, 4, this.zzc, false);
        hGXTrAULuoulwmGV(parcel, iMyswgjkYYUkuOYIz);
    }
}

