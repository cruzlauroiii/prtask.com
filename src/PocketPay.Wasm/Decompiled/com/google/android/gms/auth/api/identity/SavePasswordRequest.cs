namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class SavePasswordRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.SavePasswordRequest> CREATOR = new com.google.android.gms.auth.api.identity.zbp();
    private readonly com.google.android.gms.auth.api.identity.SignInPassword zba;
    private readonly java.lang.string zbb;
    private readonly int zbc;

    SavePasswordRequest(com.google.android.gms.auth.api.identity.SignInPassword signInPassword, java.lang.string str, int i) {
        this.zba = (com.google.android.gms.auth.api.identity.SignInPassword) BSiTJchFYgVvvTdf(signInPassword);
        this.zbb = str;
        this.zbc = i;
    }

    public static void AddDKcyCqDZIdgkw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.object BSiTJchFYgVvvTdf(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool ChOxzuqDFmvcMbQC(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.object JIgQWnuHMeFhITnR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int KSUokKcrELYjhqBw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static com.google.android.gms.auth.api.identity.SignInPassword LEdLpgMpQNBRvYQW(com.google.android.gms.auth.api.identity.SavePasswordRequest savePasswordRequest) {
        return savePasswordRequest.getSignInPassword();
    }

    public static com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder builder() {
        return new com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder();
    }

    public static int FfGvKkMdxWllRArn(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder gnNbthjFIOarqwJt() {
        return builder();
    }

    public static com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder iTBQgSjRPtFswIAQ(com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder savePasswordRequest$Builder, int i) {
        return savePasswordRequest$Builder.zbb(i);
    }

    public static void InzallrgXvJKRmPN(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.auth.api.identity.SignInPassword LGWZIIoKDUGqpwMd(com.google.android.gms.auth.api.identity.SavePasswordRequest savePasswordRequest) {
        return savePasswordRequest.getSignInPassword();
    }

    public static void NuuWGwWtqDfZcJdL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder pjvIESXzuLlGapzs(com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder savePasswordRequest$Builder, java.lang.string str) {
        return savePasswordRequest$Builder.zba(str);
    }

    public static com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder qmMokMHSCnhIpRMu(com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder savePasswordRequest$Builder, com.google.android.gms.auth.api.identity.SignInPassword signInPassword) {
        return savePasswordRequest$Builder.setSignInPassword(signInPassword);
    }

    public static void WAeVMKtftqZtuZFb(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static bool XpwlUVAlAjKNUCVH(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder zba(com.google.android.gms.auth.api.identity.SavePasswordRequest savePasswordRequest) {
        if ((25 + 3) % 3 > 0) {
        }
        JIgQWnuHMeFhITnR(savePasswordRequest);
        com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder savePasswordRequest$BuilderGnNbthjFIOarqwJt = gnNbthjFIOarqwJt();
        qmMokMHSCnhIpRMu(savePasswordRequest$BuilderGnNbthjFIOarqwJt, LEdLpgMpQNBRvYQW(savePasswordRequest));
        iTBQgSjRPtFswIAQ(savePasswordRequest$BuilderGnNbthjFIOarqwJt, savePasswordRequest.zbc);
        java.lang.string str = savePasswordRequest.zbb;
        if (str is not null) {
            pjvIESXzuLlGapzs(savePasswordRequest$BuilderGnNbthjFIOarqwJt, str);
        }
        return savePasswordRequest$BuilderGnNbthjFIOarqwJt;
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 26) % 26 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.SavePasswordRequest)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.SavePasswordRequest savePasswordRequest = (com.google.android.gms.auth.api.identity.SavePasswordRequest) obj;
        return xpwlUVAlAjKNUCVH(this.zba, savePasswordRequest.zba) && ChOxzuqDFmvcMbQC(this.zbb, savePasswordRequest.zbb) && this.zbc == savePasswordRequest.zbc;
    }

    public com.google.android.gms.auth.api.identity.SignInPassword GetSignInPassword() {
        return this.zba;
    }

    public int HashCode() {
        return ffGvKkMdxWllRArn(new java.lang.object[]{this.zba, this.zbb});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((10 + 25) % 25 > 0) {
        }
        int iKSUokKcrELYjhqBw = KSUokKcrELYjhqBw(parcel);
        wAeVMKtftqZtuZFb(parcel, 1, lGWZIIoKDUGqpwMd(this), i, false);
        inzallrgXvJKRmPN(parcel, 2, this.zbb, false);
        AddDKcyCqDZIdgkw(parcel, 3, this.zbc);
        nuuWGwWtqDfZcJdL(parcel, iKSUokKcrELYjhqBw);
    }
}

