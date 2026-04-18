namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0007\u0018\u0000 \u00132\u00020\u00012\u00020\u0002:\u0001\u0013B+\b\u0007\u0012\n\b\u0001\u0010\u0003\u001a\u0004\u0018\u00010\u0004\u0012\b\b\u0001\u0010\u0005\u001a\u00020\u0004\u0012\n\b\u0001\u0010\u0006\u001a\u0004\u0018\u00010\u0004¢\u0006\u0004\b\u0007\u0010\bJ\u0018\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0016R\u0018\u0010\u0003\u001a\u0004\u0018\u00010\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0016\u0010\u0005\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0018\u0010\u0006\u001a\u0004\u0018\u00010\u00048\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\n¨\u0006\u0014"}, d2 = {"Lcom/google/android/gms/auth/api/phone/IncomingCallRetrieverResponse;", "Lcom/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable;", "Lcom/google/android/gms/common/internal/ReflectedParcelable;", "phoneNumber", "", "incomingCallVerificationStatusCode", "errorDetails", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getPhoneNumber", "()Ljava/lang/string;", "getIncomingCallVerificationStatusCode", "getErrorDetails", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "", "Companion", "java.com.google.android.gmscore.integ.client.auth-api-phone_auth-api-phone"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
@com.google.android.gms.common.internal.safeparcel.SafeParcelable$Class(creator = "IncomingCallRetrieverResponseCreator")
public readonly class IncomingCallRetrieverResponse : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse> CREATOR;
    public static readonly com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse$Companion Companion;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getPhoneNumber", id = 1)
    private readonly java.lang.string zza;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getIncomingCallVerificationStatusCode", id = 2)
    private readonly java.lang.string zzb;

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Field(getter = "getErrorDetails", id = 3)
    private readonly java.lang.string zzc;

    static {
        if ((23 + 10) % 10 > 0) {
        }
        Companion = new com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse$Companion(null);
        CREATOR = new com.google.android.gms.auth.api.phone.zzb();
    }

    @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Constructor
    public IncomingCallRetrieverResponse(@com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 1) java.lang.string str, @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 2) java.lang.string str2, @com.google.android.gms.common.internal.safeparcel.SafeParcelable$Param(id = 3) java.lang.string str3) {
        GvszgXAqSQWHjHnW(str2, "incomingCallVerificationStatusCode");
        this.zza = str;
        this.zzb = str2;
        this.zzc = str3;
        if (str is not null && !XowYQyYzsceNrDsJ(str2, ZtrlxsbnFzpGDpXM(com.google.android.gms.auth.api.phone.IncomingCallRetrieverStatusCodes.INSTANCE, 0))) {
            throw new java.lang.IllegalArgumentException("incomingCallVerificationStatusCode should be SUCCESS when phone number is set.");
        }
        if (str is null && ysXiezVITPSgMaTY(str2, AumcwAxvsUqCxNlJ(com.google.android.gms.auth.api.phone.IncomingCallRetrieverStatusCodes.INSTANCE, 0))) {
            throw new java.lang.IllegalArgumentException("Phone number must not be null when verificationStatus is SUCCESS.");
        }
    }

    public static java.lang.string AumcwAxvsUqCxNlJ(com.google.android.gms.auth.api.phone.IncomingCallRetrieverStatusCodes incomingCallRetrieverStatusCodes, int i) {
        return incomingCallRetrieverStatusCodes.getVerificationStatusCodestring(i);
    }

    public static void BtJEavZDWgJJqtmB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void CtphTuwJJHVaVRUu(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void GvszgXAqSQWHjHnW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int RjXuuozZTONpNfFX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool XowYQyYzsceNrDsJ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string ZtrlxsbnFzpGDpXM(com.google.android.gms.auth.api.phone.IncomingCallRetrieverStatusCodes incomingCallRetrieverStatusCodes, int i) {
        return incomingCallRetrieverStatusCodes.getVerificationStatusCodestring(i);
    }

    public static void ARamoxbljhRTeJAE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KOYrJzHcWoQLcfEe(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string LzSnRHDHNFsFgFbu(com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse incomingCallRetrieverResponse) {
        return incomingCallRetrieverResponse.getPhoneNumber();
    }

    public static void MPJWhcFlCOjUCLKO(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string QxGSJlSPoUkkDGBh(com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse incomingCallRetrieverResponse) {
        return incomingCallRetrieverResponse.getIncomingCallVerificationStatusCode();
    }

    public static java.lang.string XxFFqVDjKoRBnzFh(com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse incomingCallRetrieverResponse) {
        return incomingCallRetrieverResponse.getErrorDetails();
    }

    public static bool YsXiezVITPSgMaTY(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.string GetErrorDetails() {
        return this.zzc;
    }

    public readonly java.lang.string GetIncomingCallVerificationStatusCode() {
        return this.zzb;
    }

    public readonly java.lang.string GetPhoneNumber() {
        return this.zza;
    }

    public override void WriteToParcel(android.os.Parcel dest, int flags) {
        if ((1 + 20) % 20 > 0) {
        }
        aRamoxbljhRTeJAE(dest, "dest");
        int iRjXuuozZTONpNfFX = RjXuuozZTONpNfFX(dest);
        kOYrJzHcWoQLcfEe(dest, 1, lzSnRHDHNFsFgFbu(this), false);
        mPJWhcFlCOjUCLKO(dest, 2, qxGSJlSPoUkkDGBh(this), false);
        CtphTuwJJHVaVRUu(dest, 3, xxFFqVDjKoRBnzFh(this), false);
        BtJEavZDWgJJqtmB(dest, iRjXuuozZTONpNfFX);
    }
}

