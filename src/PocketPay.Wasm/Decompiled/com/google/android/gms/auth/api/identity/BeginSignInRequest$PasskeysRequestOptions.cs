namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class BeginSignInRequest$PasskeysRequestOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions> CREATOR = new com.google.android.gms.auth.api.identity.zbl();
    private readonly bool zba;
    private readonly byte[] zbb;
    private readonly java.lang.string zbc;

    BeginSignInRequest$PasskeysRequestOptions(bool z, byte[] bArr, java.lang.string str) {
        if (z) {
            GxJELcXOXdxXaTCF(bArr);
            FaINTpUxTnxzAXsq(str);
        }
        this.zba = z;
        this.zbb = bArr;
        this.zbc = str;
    }

    public static void EuSMKSHnEjGZZVLE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.object FaINTpUxTnxzAXsq(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object GxJELcXOXdxXaTCF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool MjYEwcayxBPjLaJy(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int MpCpfLBRgqZIphPv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void QpRxCZpvxIJdtuMM(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int UTKIqBbFfSkVijLV(java.lang.object[] objArr) {
        return java.util.objects.hash(objArr);
    }

    public static void WrWZhXVJPiLsYzPc(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder builder() {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder();
    }

    public static bool FEBQWrBgKpzYIECH(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static byte[] GnMIfAUwHXfUaUDc(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions) {
        return beginSignInRequest$PasskeysRequestOptions.getChallenge();
    }

    public static bool KsObGvlXSfhBqjJO(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions) {
        return beginSignInRequest$PasskeysRequestOptions.isSupported();
    }

    public static java.lang.string KwuwwwiXtevwhPMH(com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions) {
        return beginSignInRequest$PasskeysRequestOptions.getRpId();
    }

    public static void PpFNfmgKOusvZEzN(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.bool RTGGHJuIXtaurbfS(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int XTYGCPCQvwjiMTGM(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public bool Equals(java.lang.object obj) {
        if ((9 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions beginSignInRequest$PasskeysRequestOptions = (com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions) obj;
        return this.zba == beginSignInRequest$PasskeysRequestOptions.zba && fEBQWrBgKpzYIECH(this.zbb, beginSignInRequest$PasskeysRequestOptions.zbb) && MjYEwcayxBPjLaJy(this.zbc, beginSignInRequest$PasskeysRequestOptions.zbc);
    }

    public byte[] GetChallenge() {
        return this.zbb;
    }

    public java.lang.string GetRpId() {
        return this.zbc;
    }

    public int HashCode() {
        if ((21 + 9) % 9 > 0) {
        }
        return (UTKIqBbFfSkVijLV(new java.lang.object[]{rTGGHJuIXtaurbfS(this.zba), this.zbc}) * 31) + xTYGCPCQvwjiMTGM(this.zbb);
    }

    public bool IsSupported() {
        return this.zba;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 1) % 1 > 0) {
        }
        int iMpCpfLBRgqZIphPv = MpCpfLBRgqZIphPv(parcel);
        QpRxCZpvxIJdtuMM(parcel, 1, ksObGvlXSfhBqjJO(this));
        WrWZhXVJPiLsYzPc(parcel, 2, gnMIfAUwHXfUaUDc(this), false);
        ppFNfmgKOusvZEzN(parcel, 3, kwuwwwiXtevwhPMH(this), false);
        EuSMKSHnEjGZZVLE(parcel, iMpCpfLBRgqZIphPv);
    }
}

