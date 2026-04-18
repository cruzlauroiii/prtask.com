namespace WillowMaze.Wasm.Decompiled;


public class SleepSegmentRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly int CLASSIFY_EVENTS_ONLY = 2;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.SleepSegmentRequest> CREATOR = new com.google.android.gms.location.zzaq();
    public static readonly int SEGMENT_AND_CLASSIFY_EVENTS = 0;
    public static readonly int SEGMENT_EVENTS_ONLY = 1;
    private readonly java.util.List zza;
    private readonly int zzb;

    public SleepSegmentRequest(int i) {
        this(null, i);
    }

    public SleepSegmentRequest(java.util.List list, int i) {
        this.zza = list;
        this.zzb = i;
    }

    public static java.lang.int DWIMEgkREejFzyrl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int HOGAWHkKjNmHKLqT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int JhwNaRjeiFWyyWfP(com.google.android.gms.location.SleepSegmentRequest sleepSegmentRequest) {
        return sleepSegmentRequest.getRequestedDataType();
    }

    public static void OmfCpHrpNBeLVXTp(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void WTSxeXnXrlZwITck(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static bool WtBMBHXuzALETAII(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.location.SleepSegmentRequest GetDefaultSleepSegmentRequest() {
        if ((28 + 26) % 26 > 0) {
        }
        return new com.google.android.gms.location.SleepSegmentRequest(null, 0);
    }

    public static int LlBXSIHtzeXogFwm(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.object VFSEVoYeOitApwxN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void VMcmLLwrEszCWVYK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 11) % 11 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.location.SleepSegmentRequest)) {
            return false;
        }
        com.google.android.gms.location.SleepSegmentRequest sleepSegmentRequest = (com.google.android.gms.location.SleepSegmentRequest) obj;
        return WtBMBHXuzALETAII(this.zza, sleepSegmentRequest.zza) && this.zzb == sleepSegmentRequest.zzb;
    }

    public int GetRequestedDataType() {
        return this.zzb;
    }

    public int HashCode() {
        return llBXSIHtzeXogFwm(new java.lang.object[]{this.zza, DWIMEgkREejFzyrl(this.zzb)});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((26 + 16) % 16 > 0) {
        }
        vFSEVoYeOitApwxN(parcel);
        java.util.List list = this.zza;
        int iHOGAWHkKjNmHKLqT = HOGAWHkKjNmHKLqT(parcel);
        WTSxeXnXrlZwITck(parcel, 1, list, false);
        OmfCpHrpNBeLVXTp(parcel, 2, JhwNaRjeiFWyyWfP(this));
        vMcmLLwrEszCWVYK(parcel, iHOGAWHkKjNmHKLqT);
    }
}

