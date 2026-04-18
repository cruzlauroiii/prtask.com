namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class SignInCredential : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.SignInCredential> CREATOR = new com.google.android.gms.auth.api.identity.zbr();
    private readonly java.lang.string zba;
    private readonly java.lang.string zbb;
    private readonly java.lang.string zbc;
    private readonly java.lang.string zbd;
    private readonly android.net.Uri zbe;
    private readonly java.lang.string zbf;
    private readonly java.lang.string zbg;
    private readonly java.lang.string zbh;
    private readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredential zbi;

    SignInCredential(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, android.net.Uri uri, java.lang.string str5, java.lang.string str6, java.lang.string str7, com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential) {
        this.zba = (java.lang.string) gmfbEMYUYgmIZpSa(str);
        this.zbb = str2;
        this.zbc = str3;
        this.zbd = str4;
        this.zbe = uri;
        this.zbf = str5;
        this.zbg = str6;
        this.zbh = str7;
        this.zbi = publicKeyCredential;
    }

    public static java.lang.string CJdZBcfGZOFeuAee(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getFamilyName();
    }

    public static int CXCAxrhYHIhUKPbZ(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.string GYApnQueTIFzpGgR(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getGivenName();
    }

    public static bool IhdBVdvkiiHOawHv(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string ImzMBkrYCytbLWfg(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getPassword();
    }

    public static void LcfochAbvFOMripp(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredential OkuWnduhFLfvwVmP(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getPublicKeyCredential();
    }

    public static java.lang.string PptBnGsjaifFiRun(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getPhoneNumber();
    }

    public static bool QfQExoCaMjiougEp(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void SRuQSyZVrbrCQZEc(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string VJJULyVYdDstWODP(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getGoogleIdToken();
    }

    public static void ZKjJSJjooDJWeOut(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string CRkXyYrgJFevBZYi(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getDisplayName();
    }

    public static void CdjTXfcWEJLlSUHw(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void FABbanJfDPLCrnjx(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool FLPqNKkdWkmmBAYj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool FieJGqAwLUteaIqt(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.object GmfbEMYUYgmIZpSa(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool HZFmuxGnHXYuxyOg(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool JdikaWZnrjRIidiB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool KniDBxoBxkRAbath(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int NQeoOBKTSRJFPTGL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void NvkmHNMRsLDsJABm(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool QCYGhftJpSGTAvRK(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void QQBmzNdKETFNYFed(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void SajaVXhrWqDYYsmd(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void SyzLsprFWuojeosm(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool UHDJHFwVvHEEcyTj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void UtAagmIwdhfohiCr(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static android.net.Uri XCRQalhFKkZKRWUz(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getProfilePictureUri();
    }

    public static java.lang.string XPEjDkgBSKLYiMmC(com.google.android.gms.auth.api.identity.SignInCredential signInCredential) {
        return signInCredential.getId();
    }

    public bool Equals(java.lang.object obj) {
        if ((7 + 8) % 8 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.SignInCredential)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.SignInCredential signInCredential = (com.google.android.gms.auth.api.identity.SignInCredential) obj;
        return fLPqNKkdWkmmBAYj(this.zba, signInCredential.zba) && fieJGqAwLUteaIqt(this.zbb, signInCredential.zbb) && jdikaWZnrjRIidiB(this.zbc, signInCredential.zbc) && QfQExoCaMjiougEp(this.zbd, signInCredential.zbd) && hZFmuxGnHXYuxyOg(this.zbe, signInCredential.zbe) && uHDJHFwVvHEEcyTj(this.zbf, signInCredential.zbf) && IhdBVdvkiiHOawHv(this.zbg, signInCredential.zbg) && qCYGhftJpSGTAvRK(this.zbh, signInCredential.zbh) && kniDBxoBxkRAbath(this.zbi, signInCredential.zbi);
    }

    public java.lang.string GetDisplayName() {
        return this.zbb;
    }

    public java.lang.string GetFamilyName() {
        return this.zbd;
    }

    public java.lang.string GetGivenName() {
        return this.zbc;
    }

    public java.lang.string GetGoogleIdToken() {
        return this.zbg;
    }

    public java.lang.string GetId() {
        return this.zba;
    }

    public java.lang.string GetPassword() {
        return this.zbf;
    }

    @java.lang.Deprecated
    public java.lang.string GetPhoneNumber() {
        return this.zbh;
    }

    public android.net.Uri GetProfilePictureUri() {
        return this.zbe;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredential GetPublicKeyCredential() {
        return this.zbi;
    }

    public int HashCode() {
        if ((9 + 2) % 2 > 0) {
        }
        return CXCAxrhYHIhUKPbZ(new java.lang.object[]{this.zba, this.zbb, this.zbc, this.zbd, this.zbe, this.zbf, this.zbg, this.zbh, this.zbi});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((31 + 26) % 26 > 0) {
        }
        int iNQeoOBKTSRJFPTGL = nQeoOBKTSRJFPTGL(parcel);
        sajaVXhrWqDYYsmd(parcel, 1, xPEjDkgBSKLYiMmC(this), false);
        qQBmzNdKETFNYFed(parcel, 2, cRkXyYrgJFevBZYi(this), false);
        fABbanJfDPLCrnjx(parcel, 3, GYApnQueTIFzpGgR(this), false);
        nvkmHNMRsLDsJABm(parcel, 4, CJdZBcfGZOFeuAee(this), false);
        cdjTXfcWEJLlSUHw(parcel, 5, xCRQalhFKkZKRWUz(this), i, false);
        LcfochAbvFOMripp(parcel, 6, ImzMBkrYCytbLWfg(this), false);
        ZKjJSJjooDJWeOut(parcel, 7, VJJULyVYdDstWODP(this), false);
        SRuQSyZVrbrCQZEc(parcel, 8, PptBnGsjaifFiRun(this), false);
        utAagmIwdhfohiCr(parcel, 9, OkuWnduhFLfvwVmP(this), i, false);
        syzLsprFWuojeosm(parcel, iNQeoOBKTSRJFPTGL);
    }
}

