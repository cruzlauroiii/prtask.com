namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class GetSignInobjectRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.GetSignInobjectRequest> CREATOR = new com.google.android.gms.auth.api.identity.zbi();
    private readonly java.lang.string zba;
    private readonly java.lang.string zbb;
    private readonly java.lang.string zbc;
    private readonly java.lang.string zbd;
    private readonly bool zbe;
    private readonly int zbf;

    GetSignInobjectRequest(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, bool z, int i) {
        mgVlaUfyKxqjOSly(str);
        this.zba = str;
        this.zbb = str2;
        this.zbc = str3;
        this.zbd = str4;
        this.zbe = z;
        this.zbf = i;
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder BvUAwMDSPuLodSsd(com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$Builder, int i) {
        return getSignInobjectRequest$Builder.zbb(i);
    }

    public static int CMIPvvdmBmwJiwny(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.int CduqDmFbBnXtSpsG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string HbnlYgQfjBrwWeCP(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.getServerClientId();
    }

    public static java.lang.string ITATeLYfqNiBnyEA(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.getHostedDomainFilter();
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder NKzfYDNhaCsCiHqL(com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$Builder, java.lang.string str) {
        return getSignInobjectRequest$Builder.filterByHostedDomain(str);
    }

    public static java.lang.string PiUhdnwHydTVIFno(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.getServerClientId();
    }

    public static java.lang.bool QGaJzknoPdSosTtJ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void QUymzskAweLbfRYp(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool QfdUbcRLhnrOaHtm(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void UimdHehiTdvoXQyk(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.object UvTUEEWKrqfrXsfE(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.bool XvOlmyuAuecwKWTP(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string XvlcBifJKljdnaIz(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.getHostedDomainFilter();
    }

    public static void AdjCJDRdPEExOeSK(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void BVRsatanesCRuvcq(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder builder() {
        return new com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder();
    }

    public static java.lang.string CLEPrhYBHVVpRglx(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.getNonce();
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder ePHByBDCbZDGpRwl(com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$Builder, java.lang.string str) {
        return getSignInobjectRequest$Builder.setNonce(str);
    }

    public static bool FQbWJWdAsRkYkpam(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder gUWdexxHtmwiTVLk() {
        return builder();
    }

    public static bool IqXtiVXJoTJJmCFM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder krZPIiRnnbuTxTWs(com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$Builder, java.lang.string str) {
        return getSignInobjectRequest$Builder.setServerClientId(str);
    }

    public static bool LsxBPtANALHkJtyZ(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.requestVerifiedPhoneNumber();
    }

    public static java.lang.string LuCCFwnQrrBHpaUn(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        return getSignInobjectRequest.getNonce();
    }

    public static java.lang.object MgVlaUfyKxqjOSly(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int SBAYgJAqflovFstB(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool VPpfyKWYDFkMkFxU(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder vjAdmblUiERdNgch(com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$Builder, bool z) {
        return getSignInobjectRequest$Builder.setRequestVerifiedPhoneNumber(z);
    }

    public static void VypKWhqsXTLFadGi(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void XmWiieuwzvYNmqRY(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void YlartOYxRPAcvwzK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.bool ZQMBcbGlwpBMoSre(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder zba(com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest) {
        if ((18 + 25) % 25 > 0) {
        }
        UvTUEEWKrqfrXsfE(getSignInobjectRequest);
        com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk = gUWdexxHtmwiTVLk();
        krZPIiRnnbuTxTWs(getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk, HbnlYgQfjBrwWeCP(getSignInobjectRequest));
        ePHByBDCbZDGpRwl(getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk, cLEPrhYBHVVpRglx(getSignInobjectRequest));
        NKzfYDNhaCsCiHqL(getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk, ITATeLYfqNiBnyEA(getSignInobjectRequest));
        vjAdmblUiERdNgch(getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk, getSignInobjectRequest.zbe);
        BvUAwMDSPuLodSsd(getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk, getSignInobjectRequest.zbf);
        java.lang.string str = getSignInobjectRequest.zbc;
        if (str is not null) {
            zeeLUcfMoNzTBwqO(getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk, str);
        }
        return getSignInobjectRequest$BuilderGUWdexxHtmwiTVLk;
    }

    public static com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder zeeLUcfMoNzTBwqO(com.google.android.gms.auth.api.identity.GetSignInobjectRequest$Builder getSignInobjectRequest$Builder, java.lang.string str) {
        return getSignInobjectRequest$Builder.zba(str);
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 23) % 23 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.GetSignInobjectRequest)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.GetSignInobjectRequest getSignInobjectRequest = (com.google.android.gms.auth.api.identity.GetSignInobjectRequest) obj;
        return vPpfyKWYDFkMkFxU(this.zba, getSignInobjectRequest.zba) && fQbWJWdAsRkYkpam(this.zbd, getSignInobjectRequest.zbd) && iqXtiVXJoTJJmCFM(this.zbb, getSignInobjectRequest.zbb) && QfdUbcRLhnrOaHtm(QGaJzknoPdSosTtJ(this.zbe), XvOlmyuAuecwKWTP(getSignInobjectRequest.zbe)) && this.zbf == getSignInobjectRequest.zbf;
    }

    public java.lang.string GetHostedDomainFilter() {
        return this.zbb;
    }

    public java.lang.string GetNonce() {
        return this.zbd;
    }

    public java.lang.string GetServerClientId() {
        return this.zba;
    }

    public int HashCode() {
        if ((29 + 30) % 30 > 0) {
        }
        return sBAYgJAqflovFstB(new java.lang.object[]{this.zba, this.zbb, this.zbd, zQMBcbGlwpBMoSre(this.zbe), CduqDmFbBnXtSpsG(this.zbf)});
    }

    @java.lang.Deprecated
    public bool RequestVerifiedPhoneNumber() {
        return this.zbe;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((19 + 25) % 25 > 0) {
        }
        int iCMIPvvdmBmwJiwny = CMIPvvdmBmwJiwny(parcel);
        adjCJDRdPEExOeSK(parcel, 1, PiUhdnwHydTVIFno(this), false);
        UimdHehiTdvoXQyk(parcel, 2, XvlcBifJKljdnaIz(this), false);
        QUymzskAweLbfRYp(parcel, 3, this.zbc, false);
        xmWiieuwzvYNmqRY(parcel, 4, luCCFwnQrrBHpaUn(this), false);
        vypKWhqsXTLFadGi(parcel, 5, lsxBPtANALHkJtyZ(this));
        bVRsatanesCRuvcq(parcel, 6, this.zbf);
        ylartOYxRPAcvwzK(parcel, iCMIPvvdmBmwJiwny);
    }
}

