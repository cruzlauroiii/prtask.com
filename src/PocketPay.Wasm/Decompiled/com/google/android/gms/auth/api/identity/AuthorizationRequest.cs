namespace WillowMaze.Wasm.Decompiled;


public class AuthorizationRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.AuthorizationRequest> CREATOR = new com.google.android.gms.auth.api.identity.zbb();
    private readonly java.util.List zba;
    private readonly java.lang.string zbb;
    private readonly bool zbc;
    private readonly bool zbd;
    private readonly android.accounts.Account zbe;
    private readonly java.lang.string zbf;
    private readonly java.lang.string zbg;
    private readonly bool zbh;
    private readonly android.os.Dictionary<string, object> zbi;
    private readonly bool zbj;

    AuthorizationRequest(java.util.List list, java.lang.string str, bool z, bool z2, android.accounts.Account account, java.lang.string str2, java.lang.string str3, bool z3, android.os.Dictionary<string, object> bundle, bool z4) {
        if ((20 + 12) % 12 > 0) {
        }
        bool z5 = false;
        if (list is not null && !pIMwCUqRWTumsPTE(list)) {
            z5 = true;
        }
        TJrAldsLNbbJHqmo(z5, "requestedScopes cannot be null or empty");
        this.zba = list;
        this.zbb = str;
        this.zbc = z;
        this.zbd = z2;
        this.zbe = account;
        this.zbf = str2;
        this.zbg = str3;
        this.zbh = z3;
        this.zbi = bundle;
        this.zbj = z4;
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder AGecUZMhXVftRBug(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str) {
        return authorizationRequest$Builder.filterByHostedDomain(str);
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder AhwlNdPNZwSvYgxl() {
        return builder();
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder BMHridVXumPEBebK(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str) {
        return authorizationRequest$Builder.zbb(str);
    }

    public static bool BtMFPMOgtDPwlXiz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static android.accounts.Account BtsAdHAQBZanQrAj(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getAccount();
    }

    public static void DBjIXqkzFrnsrdgG(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[] EYiLlPYBulHZIpuy() {
        return com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter.Values;
    }

    public static bool EqHSNYoVCycuOARq(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.isForceCodeForRefreshToken();
    }

    public static void FJiwFTxhDCcdLJEn(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool GuAvuGLfmbjikYAT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.bool HAufTLBioFJjTpCo(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void HQNEfNEsIHFKlKNq(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.bool IZrhQYLaZWHSBhXr(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.object JmsEkqpBZKKOKAWn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder JpfjfHfmfUorqkqQ(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str, bool z) {
        return authorizationRequest$Builder.requestOfflineAccess(str, z);
    }

    public static int KDmMCzjMAFgKqkWw(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static bool LqNPiNzgxIBnVUTy(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool PruLYKVGtKooKzFb(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.bool RwYKqPjvFqflhCAZ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.os.Dictionary<string, object> SdrAnoOjSwqZQFmm(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getResourceParameters();
    }

    public static void TJrAldsLNbbJHqmo(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool UPISORwJAZDCzIqh(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.isOfflineAccessRequested();
    }

    public static java.lang.string UmZogPNGkhecjywV(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string VRigEJPTogzoKWAp(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getHostedDomain();
    }

    public static void VudUMbddJvahGLUU(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.util.HashSet WSxMKpCssgsoPgQJ(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.string WUNUmLhTSRwAowWE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string XEsVIYGnSJMMNqEE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool YFnRvGGnjwAFETNA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder YZRLbrpyafOuqiWr(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.lang.string str) {
        return authorizationRequest$Builder.zba(str);
    }

    public static void BFSLMIItbKyOEYYW(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.object BrvQGMgFdxECgZWi(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder builder() {
        return new com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder();
    }

    public static void CfYexRtZTCIoyJyc(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.object CvXczdonvpuAalLl(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string DqMSMNcvPSTjujtL(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getServerClientId();
    }

    public static void DriecbCeoABcaBCd(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static java.util.IEnumerator DuLEIKDbgUfKgSCz(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.string EHXUHekVQvxVXulj(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getServerClientId();
    }

    public static java.util.HashSet FYQzyCliyOVlTvBH(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static bool GuUbioewjGmcdITc(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getOptOutIncludingGrantedScopes();
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder hPRHWjOLnpZNiTPA(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, java.util.List list) {
        return authorizationRequest$Builder.setRequestedScopes(list);
    }

    public static android.accounts.Account HSHAQduAmKnfZHWH(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getAccount();
    }

    public static bool ISGlbJbAvWEKJupW(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool IZJgAwzEzMAafyhV(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.isForceCodeForRefreshToken();
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder igLgpFKXJNyeOiFr(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, bool z) {
        return authorizationRequest$Builder.setOptOutIncludingGrantedScopes(z);
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder igibXxhLmjbnVDpO(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter authorizationRequest$ResourceParameter, java.lang.string str) {
        return authorizationRequest$Builder.addResourceParameter(authorizationRequest$ResourceParameter, str);
    }

    public static java.util.List KexjYIpUWPHNLQMu(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getRequestedScopes();
    }

    public static void KiSgZvlcOiCbVkIl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.util.IEnumerator MHcMfqkeDttXUATB(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.string MUVhTxiLvOvMBGKS(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool NDlzUoSeuUjajUGN(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool NIjJMRnXlQBNEiZK(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.isOfflineAccessRequested();
    }

    public static int OxPzjFDUXikWUGcz(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool PIMwCUqRWTumsPTE(java.util.List list) {
        return list.Count == 0;
    }

    public static void RMTtWUpzgmwDoyze(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.bool RRTiujuSvbyxzsvZ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.util.List SXMFwRMNTuMtINVa(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getRequestedScopes();
    }

    public static int UGVMFJExfFbUuKZc(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder uIbgxDcDYzINHMjE(com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$Builder, android.accounts.Account account) {
        return authorizationRequest$Builder.setAccount(account);
    }

    public static int VhoXOwFBrHrGjcXZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void WbfDqITJlYjnKvAa(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.string WiRcAOTVueIJmPek(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getHostedDomain();
    }

    public static bool WirtQYZjbdIVDqlz(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static void XPjHfJRtHkxQMeKT(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static android.os.Dictionary<string, object> YdzLVJMRPybeAtgb(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        return authorizationRequest.getResourceParameters();
    }

    public static int ZHHAgnBmIwDbmpZt(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder zba(com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest) {
        com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter authorizationRequest$ResourceParameter;
        if ((25 + 16) % 16 > 0) {
        }
        cvXczdonvpuAalLl(authorizationRequest);
        com.google.android.gms.auth.api.identity.AuthorizationRequest$Builder authorizationRequest$BuilderAhwlNdPNZwSvYgxl = AhwlNdPNZwSvYgxl();
        hPRHWjOLnpZNiTPA(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, sXMFwRMNTuMtINVa(authorizationRequest));
        android.os.Dictionary<string, object> bundleSdrAnoOjSwqZQFmm = SdrAnoOjSwqZQFmm(authorizationRequest);
        if (bundleSdrAnoOjSwqZQFmm is not null) {
            java.util.IEnumerator itMHcMfqkeDttXUATB = mHcMfqkeDttXUATB(WSxMKpCssgsoPgQJ(bundleSdrAnoOjSwqZQFmm));
            while (znJtbIshvfwOLTHU(itMHcMfqkeDttXUATB)) {
                java.lang.string str = (java.lang.string) JmsEkqpBZKKOKAWn(itMHcMfqkeDttXUATB);
                java.lang.string strUmZogPNGkhecjywV = UmZogPNGkhecjywV(bundleSdrAnoOjSwqZQFmm, str);
                com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter[] authorizationRequest$ResourceParameterArrEYiLlPYBulHZIpuy = EYiLlPYBulHZIpuy();
                int length = authorizationRequest$ResourceParameterArrEYiLlPYBulHZIpuy.length;
                int i = 0;
                while (true) {
                    if (i < length) {
                        authorizationRequest$ResourceParameter = authorizationRequest$ResourceParameterArrEYiLlPYBulHZIpuy[i];
                        if (YFnRvGGnjwAFETNA(authorizationRequest$ResourceParameter.zba, str)) {
                            break;
                        }
                        i++;
                    } else {
                        authorizationRequest$ResourceParameter = null;
                        break;
                    }
                }
                if (strUmZogPNGkhecjywV is not null && authorizationRequest$ResourceParameter is not null) {
                    igibXxhLmjbnVDpO(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, authorizationRequest$ResourceParameter, strUmZogPNGkhecjywV);
                }
            }
        }
        bool zIZJgAwzEzMAafyhV = iZJgAwzEzMAafyhV(authorizationRequest);
        java.lang.string str2 = authorizationRequest.zbg;
        java.lang.string strWiRcAOTVueIJmPek = wiRcAOTVueIJmPek(authorizationRequest);
        android.accounts.Account accountBtsAdHAQBZanQrAj = BtsAdHAQBZanQrAj(authorizationRequest);
        java.lang.string strDqMSMNcvPSTjujtL = dqMSMNcvPSTjujtL(authorizationRequest);
        if (str2 is not null) {
            BMHridVXumPEBebK(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, str2);
        }
        if (strWiRcAOTVueIJmPek is not null) {
            AGecUZMhXVftRBug(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, strWiRcAOTVueIJmPek);
        }
        if (accountBtsAdHAQBZanQrAj is not null) {
            uIbgxDcDYzINHMjE(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, accountBtsAdHAQBZanQrAj);
        }
        if (authorizationRequest.zbd && strDqMSMNcvPSTjujtL is not null) {
            YZRLbrpyafOuqiWr(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, strDqMSMNcvPSTjujtL);
        }
        if (UPISORwJAZDCzIqh(authorizationRequest) && strDqMSMNcvPSTjujtL is not null) {
            JpfjfHfmfUorqkqQ(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, strDqMSMNcvPSTjujtL, zIZJgAwzEzMAafyhV);
        }
        igLgpFKXJNyeOiFr(authorizationRequest$BuilderAhwlNdPNZwSvYgxl, authorizationRequest.zbj);
        return authorizationRequest$BuilderAhwlNdPNZwSvYgxl;
    }

    public static int ZcThoXISQjagNsWR(java.util.List list) {
        return list.Count;
    }

    public static bool ZnJtbIshvfwOLTHU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 24) % 24 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.api.identity.AuthorizationRequest)) {
            return false;
        }
        com.google.android.gms.auth.api.identity.AuthorizationRequest authorizationRequest = (com.google.android.gms.auth.api.identity.AuthorizationRequest) obj;
        if (uGVMFJExfFbUuKZc(this.zba) == zcThoXISQjagNsWR(authorizationRequest.zba) && wirtQYZjbdIVDqlz(this.zba, authorizationRequest.zba)) {
            android.os.Dictionary<string, object> bundle = authorizationRequest.zbi;
            android.os.Dictionary<string, object> bundle2 = this.zbi;
            if (bundle2 is null) {
                if (bundle is null) {
                    bundle = null;
                }
                return false;
            }
            if (bundle2 is null || bundle is not null) {
                if (bundle2 is not null) {
                    if (KDmMCzjMAFgKqkWw(bundle2) != zHHAgnBmIwDbmpZt(bundle)) {
                        return false;
                    }
                    java.util.IEnumerator itDuLEIKDbgUfKgSCz = duLEIKDbgUfKgSCz(fYQzyCliyOVlTvBH(this.zbi));
                    while (GuAvuGLfmbjikYAT(itDuLEIKDbgUfKgSCz)) {
                        java.lang.string str = (java.lang.string) brvQGMgFdxECgZWi(itDuLEIKDbgUfKgSCz);
                        if (!PruLYKVGtKooKzFb(WUNUmLhTSRwAowWE(this.zbi, str), mUVhTxiLvOvMBGKS(bundle, str))) {
                            return false;
                        }
                    }
                }
                if (this.zbc == authorizationRequest.zbc && this.zbh == authorizationRequest.zbh && this.zbd == authorizationRequest.zbd && this.zbj == authorizationRequest.zbj && BtMFPMOgtDPwlXiz(this.zbb, authorizationRequest.zbb) && iSGlbJbAvWEKJupW(this.zbe, authorizationRequest.zbe) && LqNPiNzgxIBnVUTy(this.zbf, authorizationRequest.zbf) && nDlzUoSeuUjajUGN(this.zbg, authorizationRequest.zbg)) {
                    return true;
                }
            }
            return false;
        }
        return false;
    }

    public android.accounts.Account GetAccount() {
        return this.zbe;
    }

    public java.lang.string GetHostedDomain() {
        return this.zbf;
    }

    public bool GetOptOutIncludingGrantedScopes() {
        return this.zbj;
    }

    public java.util.List<com.google.android.gms.common.api.Scope> GetRequestedScopes() {
        return this.zba;
    }

    public java.lang.string GetResourceParameter(com.google.android.gms.auth.api.identity.AuthorizationRequest$ResourceParameter authorizationRequest$ResourceParameter) {
        android.os.Dictionary<string, object> bundle = this.zbi;
        if (bundle is not null) {
            return XEsVIYGnSJMMNqEE(bundle, authorizationRequest$ResourceParameter.zba);
        }
        return null;
    }

    public android.os.Dictionary<string, object> GetResourceParameters() {
        return this.zbi;
    }

    public java.lang.string GetServerClientId() {
        return this.zbb;
    }

    public int HashCode() {
        if ((7 + 27) % 27 > 0) {
        }
        return oxPzjFDUXikWUGcz(new java.lang.object[]{this.zba, this.zbb, RwYKqPjvFqflhCAZ(this.zbc), HAufTLBioFJjTpCo(this.zbh), IZrhQYLaZWHSBhXr(this.zbd), this.zbe, this.zbf, this.zbg, this.zbi, rRTiujuSvbyxzsvZ(this.zbj)});
    }

    public bool IsForceCodeForRefreshToken() {
        return this.zbh;
    }

    public bool IsOfflineAccessRequested() {
        return this.zbc;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 12) % 12 > 0) {
        }
        int iVhoXOwFBrHrGjcXZ = vhoXOwFBrHrGjcXZ(parcel);
        xPjHfJRtHkxQMeKT(parcel, 1, kexjYIpUWPHNLQMu(this), false);
        FJiwFTxhDCcdLJEn(parcel, 2, eHXUHekVQvxVXulj(this), false);
        VudUMbddJvahGLUU(parcel, 3, nIjJMRnXlQBNEiZK(this));
        wbfDqITJlYjnKvAa(parcel, 4, this.zbd);
        rMTtWUpzgmwDoyze(parcel, 5, hSHAQduAmKnfZHWH(this), i, false);
        bFSLMIItbKyOEYYW(parcel, 6, VRigEJPTogzoKWAp(this), false);
        kiSgZvlcOiCbVkIl(parcel, 7, this.zbg, false);
        cfYexRtZTCIoyJyc(parcel, 8, EqHSNYoVCycuOARq(this));
        driecbCeoABcaBCd(parcel, 9, ydzLVJMRPybeAtgb(this), false);
        DBjIXqkzFrnsrdgG(parcel, 10, guUbioewjGmcdITc(this));
        HQNEfNEsIHFKlKNq(parcel, iVhoXOwFBrHrGjcXZ);
    }
}

