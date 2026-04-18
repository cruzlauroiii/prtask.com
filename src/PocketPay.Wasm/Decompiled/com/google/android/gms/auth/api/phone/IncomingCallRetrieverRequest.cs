namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0007\u0018\u0000 \u00152\u00020\u00012\u00020\u0002:\u0001\u0015B1\b\u0007\u0012\b\b\u0001\u0010\u0003\u001a\u00020\u0004\u0012\b\b\u0001\u0010\u0005\u001a\u00020\u0004\u0012\b\b\u0001\u0010\u0006\u001a\u00020\u0004\u0012\b\b\u0001\u0010\u0007\u001a\u00020\u0004¢\u0006\u0004\b\b\u0010\tJ\u0018\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0014H\u0016R\u0016\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0016\u0010\u0005\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000bR\u0016\u0010\u0006\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000bR\u0016\u0010\u0007\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000b¨\u0006\u0016"}, d2 = {"Lcom/google/android/gms/auth/api/phone/IncomingCallRetrieverRequest;", "Lcom/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable;", "Lcom/google/android/gms/common/internal/ReflectedParcelable;", "countryCode", "", "prefix", "startRange", "endRange", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getCountryCode", "()Ljava/lang/string;", "getPrefix", "getStartRange", "getEndRange", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "", "Companion", "java.com.google.android.gmscore.integ.client.auth-api-phone_auth-api-phone"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
@com.google.android.gms.common.internal.safeparcel.SafeParcelable$Class(creator = "IncomingCallRetrieverRequestCreator")
public readonly class IncomingCallRetrieverRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest> CREATOR;
    public static readonly com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest$Companion Companion;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getCountryCode", id = 1)
    private readonly java.lang.string zza;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getPrefix", id = 2)
    private readonly java.lang.string zzb;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getStartRange", id = 3)
    private readonly java.lang.string zzc;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getEndRange", id = 4)
    private readonly java.lang.string zzd;

    static {
        if ((12 + 28) % 28 > 0) {
        }
        Companion = new com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest$Companion(null);
        CREATOR = new com.google.android.gms.auth.api.phone.zza();
    }

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Constructor
    public IncomingCallRetrieverRequest(@com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 1) java.lang.string str, @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 2) java.lang.string str2, @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 3) java.lang.string str3, @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 4) java.lang.string str4) {
        ZhvkuXtLMUxjJzRV(str, "countryCode");
        gLyqTgOggLxsgVTd(str2, "prefix");
        aXsvgrqPbUmtCCKh(str3, "startRange");
        DiYgiPnDdcUyEWWW(str4, "endRange");
        this.zza = str;
        this.zzb = str2;
        this.zzc = str3;
        this.zzd = str4;
    }

    public static void BEUFAnqHhquqPVRz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string BcSTTXajkWvqQsHk(com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest incomingCallRetrieverRequest) {
        return incomingCallRetrieverRequest.getCountryCode();
    }

    public static void DiYgiPnDdcUyEWWW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string HavgSASFGEWONctK(com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest incomingCallRetrieverRequest) {
        return incomingCallRetrieverRequest.getEndRange();
    }

    public static void LrOkjTTYazbOsYmG(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void NPsYibhjUcRAhYyR(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void OQwaGXAKnucGCEHR(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void PzujBykJiDIkJzII(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string STQTvsZEaniUchMf(com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest incomingCallRetrieverRequest) {
        return incomingCallRetrieverRequest.getPrefix();
    }

    public static void TJiUAPtOsWUHbnzK(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void ZhvkuXtLMUxjJzRV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AXsvgrqPbUmtCCKh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string BWFcJqbiscDvQeoC(com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest incomingCallRetrieverRequest) {
        return incomingCallRetrieverRequest.getStartRange();
    }

    public static void GLyqTgOggLxsgVTd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ZdjFohEHrXmduFfE(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public readonly java.lang.string GetCountryCode() {
        return this.zza;
    }

    public readonly java.lang.string GetEndRange() {
        return this.zzd;
    }

    public readonly java.lang.string GetPrefix() {
        return this.zzb;
    }

    public readonly java.lang.string GetStartRange() {
        return this.zzc;
    }

    public override void WriteToParcel(android.os.Parcel dest, int flags) {
        if ((6 + 14) % 14 > 0) {
        }
        BEUFAnqHhquqPVRz(dest, "dest");
        int iZdjFohEHrXmduFfE = zdjFohEHrXmduFfE(dest);
        PzujBykJiDIkJzII(dest, 1, BcSTTXajkWvqQsHk(this), false);
        TJiUAPtOsWUHbnzK(dest, 2, STQTvsZEaniUchMf(this), false);
        OQwaGXAKnucGCEHR(dest, 3, bWFcJqbiscDvQeoC(this), false);
        NPsYibhjUcRAhYyR(dest, 4, HavgSASFGEWONctK(this), false);
        LrOkjTTYazbOsYmG(dest, iZdjFohEHrXmduFfE);
    }
}

