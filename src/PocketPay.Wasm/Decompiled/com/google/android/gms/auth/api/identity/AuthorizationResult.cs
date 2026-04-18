namespace WillowMaze.Wasm.Decompiled;


public readonly class AuthorizationResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.AuthorizationResult> CREATOR = new com.google.android.gms.auth.api.identity.zbc();
    private readonly java.lang.string zba;
    private readonly java.lang.string zbb;
    private readonly java.lang.string zbc;
    private readonly java.util.List zbd;
    private readonly com.google.android.gms.auth.api.signin.GoogleSignInAccount zbe;
    private readonly android.app.Pendingobject zbf;

    public AuthorizationResult(java.lang.string str, java.lang.string str2, java.lang.string str3, java.util.List<java.lang.string> list, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, android.app.Pendingobject pendingobject) {
        this.zba = str;
        this.zbb = str2;
        this.zbc = str3;
        this.zbd = (java.util.List) MHyFKfgMpQgOmxQQ(list);
        this.zbf = pendingobject;
        this.zbe = googleSignInAccount;
    }

    public static int BaqmUfEhhZoKueOa(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static bool EmqJiOCFCTjbcGPr(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool EuMffxbCqKBVwcLF(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static android.app.Pendingobject KSzfZdVboIdjjjND(com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) {
        return authorizationResult.getPendingobject();
    }

    public static java.util.List LKiIczeffEROSyTY(com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) {
        return authorizationResult.getGrantedScopes();
    }

    public static java.lang.object MHyFKfgMpQgOmxQQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int QlWvQLhdaofvzTxE(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool SMnKQNeUpnmmxBXV(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool TzfmPIbMeHXAiOyk(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void XWVbkUYPAmUGAsgY(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.string ZRFTlOokNZQaflZx(com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) {
        return authorizationResult.getServerAuthCode();
    }

    public static bool AmobRbNattxUlNxf(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void BQAbRvDQlbtXXzMI(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void CKCYJzUdnXHIxsWK(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string DMlVTQMmMbfuqRqU(com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) {
        return authorizationResult.getAccessToken();
    }

    public static void EcRdhGpEOPSmDYIo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool ErfTckUDNgksYfnm(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void KEkHZCYhOVKkvhIc(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount OpigZnsbGCEFGLLc(com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult) {
        return authorizationResult.toGoogleSignInAccount();
    }

    public static void UBqgrPoovaoHisFQ(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void VSnisHyzrAoZUMcu(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 22) % 22 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.AuthorizationResult)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.AuthorizationResult authorizationResult = (com.google.android.gms.auth.api.identity.AuthorizationResult) obj;
        return erfTckUDNgksYfnm(this.zba, authorizationResult.zba) && SMnKQNeUpnmmxBXV(this.zbb, authorizationResult.zbb) && amobRbNattxUlNxf(this.zbc, authorizationResult.zbc) && EmqJiOCFCTjbcGPr(this.zbd, authorizationResult.zbd) && TzfmPIbMeHXAiOyk(this.zbf, authorizationResult.zbf) && EuMffxbCqKBVwcLF(this.zbe, authorizationResult.zbe);
    }

    public java.lang.string GetAccessToken() {
        return this.zbb;
    }

    public java.util.List<java.lang.string> GetGrantedScopes() {
        return this.zbd;
    }

    public android.app.Pendingobject GetPendingobject() {
        return this.zbf;
    }

    public java.lang.string GetServerAuthCode() {
        return this.zba;
    }

    public bool HasResolution() {
        return this.zbf is not null;
    }

    public int HashCode() {
        if ((20 + 15) % 15 > 0) {
        }
        return QlWvQLhdaofvzTxE(new java.lang.object[]{this.zba, this.zbb, this.zbc, this.zbd, this.zbf, this.zbe});
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInAccount ToGoogleSignInAccount() {
        return this.zbe;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 24) % 24 > 0) {
        }
        int iBaqmUfEhhZoKueOa = BaqmUfEhhZoKueOa(parcel);
        vSnisHyzrAoZUMcu(parcel, 1, ZRFTlOokNZQaflZx(this), false);
        uBqgrPoovaoHisFQ(parcel, 2, dMlVTQMmMbfuqRqU(this), false);
        cKCYJzUdnXHIxsWK(parcel, 3, this.zbc, false);
        kEkHZCYhOVKkvhIc(parcel, 4, LKiIczeffEROSyTY(this), false);
        bQAbRvDQlbtXXzMI(parcel, 5, opigZnsbGCEFGLLc(this), i, false);
        XWVbkUYPAmUGAsgY(parcel, 6, KSzfZdVboIdjjjND(this), i, false);
        ecRdhGpEOPSmDYIo(parcel, iBaqmUfEhhZoKueOa);
    }
}

