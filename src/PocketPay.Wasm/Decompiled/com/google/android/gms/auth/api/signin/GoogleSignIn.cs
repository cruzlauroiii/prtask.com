namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class GoogleSignIn {
    private GoogleSignIn() {
    }

    public static void AadRMDMciGSnYaPJ(androidx.fragment.app.object fragment, android.content.object intent, int i) {
        fragment.startobjectForResult(intent, i);
    }

    public static com.google.android.gms.common.api.ApiException BXjMOfiiGsrgEAZv(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions EPNPFvdUWWMiMqvB(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.build();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount EWagAIIikshbkNBf(com.google.android.gms.auth.api.signin.GoogleSignInResult googleSignInResult) {
        return googleSignInResult.getSignInAccount();
    }

    public static java.lang.string FgJHnYuKUTnGZgzh(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getEmail();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder HTeJUjiOvXQsJjHl(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, java.lang.string str) {
        return googleSignInOptions$Builder.setAccountName(str);
    }

    public static java.util.List ItpIapjERVuhEHgA(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getImpliedScopes();
    }

    public static void IxBaEgASMeriscHP(androidx.fragment.app.object fragment, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        requestPermissions(fragment, i, googleSignInAccount, scopeArr);
    }

    public static int LSxFFngqKZkxKVNI(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object OlGSUlDsuyBlawNO(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.tasks.Task PCOkuoHOGrIwFLeS(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount PGcOsxOnQTxOpjGr(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        return googleSignInAccount.requestExtraScopes(scopeArr);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount PNnlBvSJoDlrWcPn() {
        return com.google.android.gms.auth.api.signin.GoogleSignInAccount.createDefault();
    }

    public static android.content.object PtXSjrudIehTrzqR(android.app.object activity, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        return zba(activity, googleSignInAccount, scopeArr);
    }

    public static java.util.HashSet QEraCQSjQdjoZzzM(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getGrantedScopes();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount QYbbpooLitofPtIX(android.content.object context) {
        return getLastSignedInAccount(context);
    }

    public static com.google.android.gms.common.api.Scope[] ThJilgnrTeqKgbac(java.util.List list) {
        return zbb(list);
    }

    public static com.google.android.gms.tasks.Task UGfzGAydUfKgfIcE(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static java.lang.object VCqZSAaFGwowmkGO(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static androidx.fragment.app.objectobject VryeiMPrmpAWyZTS(androidx.fragment.app.object fragment) {
        return fragment.getobject();
    }

    public static bool WHzqcvrxvLymfRJU(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        return hasPermissions(googleSignInAccount, scopeArr);
    }

    public static bool XjQpVTKauQBCHkhW(java.util.HashSet set, java.util.ICollection collection) {
        return set.containsAll(collection);
    }

    public static java.lang.object XsVtvGLZGFpcXRnl(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.Status YhKlgDESSnmrpDua(com.google.android.gms.auth.api.signin.GoogleSignInResult googleSignInResult) {
        return googleSignInResult.getStatus();
    }

    public static com.google.android.gms.common.api.Scope[] YszrfrqgjBpwwpIG(java.util.List list) {
        return zbb(list);
    }

    public static java.lang.object ZkIUHMBDXDUhgVpg(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool ZvJhuTIBKzvgAXQO(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static java.lang.object AdVsNsTrxKCISuGz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object ArQCxfRLIWBZhxsF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string AsgEKrSVbXPckTcd(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getEmail();
    }

    public static java.lang.object BORouOjOwbfyKeOX(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount BwOlTlDYkRoBeuso(com.google.android.gms.auth.api.signin.internal.zbn zbnVar) {
        return zbnVar.zba();
    }

    public static java.util.List CnKwFtjCeWmMARVU(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getImpliedScopes();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder ejrehkvuUPUFIlWX(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, com.google.android.gms.common.api.Scope scope, com.google.android.gms.common.api.Scope[] scopeArr) {
        return googleSignInOptions$Builder.requestScopes(scope, scopeArr);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount GetAccountForExtension(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        OlGSUlDsuyBlawNO(context, "please provide a valid object object");
        iSZvcAiKHQsMOJWo(googleSignInOptionsExtension, "please provide valid GoogleSignInOptionsExtension");
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountJOmLsngJBpBDCFDg = jOmLsngJBpBDCFDg(context);
        if (googleSignInAccountJOmLsngJBpBDCFDg is null) {
            googleSignInAccountJOmLsngJBpBDCFDg = PNnlBvSJoDlrWcPn();
        }
        return kunmgxNteCvHVPwF(googleSignInAccountJOmLsngJBpBDCFDg, saxRBcKwSBKrIHVQ(ItpIapjERVuhEHgA(googleSignInOptionsExtension)));
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount GetAccountForScopes(android.content.object context, com.google.android.gms.common.api.Scope scope, com.google.android.gms.common.api.Scope... scopeArr) {
        if ((17 + 26) % 26 > 0) {
        }
        XsVtvGLZGFpcXRnl(context, "please provide a valid object object");
        bORouOjOwbfyKeOX(scope, "please provide at least one valid scope");
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountQYbbpooLitofPtIX = QYbbpooLitofPtIX(context);
        if (googleSignInAccountQYbbpooLitofPtIX is null) {
            googleSignInAccountQYbbpooLitofPtIX = hVvhQIEACcTSOQHF();
        }
        com.google.android.gms.common.api.Scope[] scopeArr2 = new com.google.android.gms.common.api.Scope[1];
        scopeArr2[0] = scope;
        qeulCONAocROAyoJ(googleSignInAccountQYbbpooLitofPtIX, scopeArr2);
        PGcOsxOnQTxOpjGr(googleSignInAccountQYbbpooLitofPtIX, scopeArr);
        return googleSignInAccountQYbbpooLitofPtIX;
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInClient GetClient(android.app.object activity, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return new com.google.android.gms.auth.api.signin.GoogleSignInClient(activity, (com.google.android.gms.auth.api.signin.GoogleSignInOptions) yrGhlULXYtCGsRyK(googleSignInOptions));
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInClient GetClient(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return new com.google.android.gms.auth.api.signin.GoogleSignInClient(context, (com.google.android.gms.auth.api.signin.GoogleSignInOptions) rtootwxCmPcsNXuw(googleSignInOptions));
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount GetLastSignedInAccount(android.content.object context) {
        return bwOlTlDYkRoBeuso(saEptfErmtfLUawM(context));
    }

    public static com.google.android.gms.tasks.Task<com.google.android.gms.auth.api.signin.GoogleSignInAccount> GetSignedInAccountFromobject(android.content.object intent) {
        if ((1 + 31) % 31 > 0) {
        }
        com.google.android.gms.auth.api.signin.GoogleSignInResult googleSignInResultXXaOnGewzXiTGVxh = xXaOnGewzXiTGVxh(intent);
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountEWagAIIikshbkNBf = EWagAIIikshbkNBf(googleSignInResultXXaOnGewzXiTGVxh);
        return (ZvJhuTIBKzvgAXQO(YhKlgDESSnmrpDua(googleSignInResultXXaOnGewzXiTGVxh)) && googleSignInAccountEWagAIIikshbkNBf is not null) ? UGfzGAydUfKgfIcE(googleSignInAccountEWagAIIikshbkNBf) : PCOkuoHOGrIwFLeS(BXjMOfiiGsrgEAZv(jfYlPlkqjerjoFRF(googleSignInResultXXaOnGewzXiTGVxh)));
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount HVvhQIEACcTSOQHF() {
        return com.google.android.gms.auth.api.signin.GoogleSignInAccount.createDefault();
    }

    public static bool HasPermissions(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        wsybIhzpXPefjmJF(googleSignInOptionsExtension, "Please provide a non-null GoogleSignInOptionsExtension");
        return WHzqcvrxvLymfRJU(googleSignInAccount, ThJilgnrTeqKgbac(cnKwFtjCeWmMARVU(googleSignInOptionsExtension)));
    }

    public static bool HasPermissions(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope... scopeArr) {
        if (googleSignInAccount is null) {
            return false;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        oHUwBQugGvvVthKA(hashHashSet, scopeArr);
        return XjQpVTKauQBCHkhW(QEraCQSjQdjoZzzM(googleSignInAccount), hashHashSet);
    }

    public static java.lang.object ISLBeHGIyOezbNtm(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object ISZvcAiKHQsMOJWo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.util.List JGXPHaMsysXCrmRb(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getImpliedScopes();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount JOmLsngJBpBDCFDg(android.content.object context) {
        return getLastSignedInAccount(context);
    }

    public static java.lang.object JTHJAQMaBSXkmisl(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.Status JfYlPlkqjerjoFRF(com.google.android.gms.auth.api.signin.GoogleSignInResult googleSignInResult) {
        return googleSignInResult.getStatus();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount KunmgxNteCvHVPwF(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        return googleSignInAccount.requestExtraScopes(scopeArr);
    }

    public static android.content.object KwjMjdxIEMPsqEKO(com.google.android.gms.auth.api.signin.GoogleSignInClient googleSignInClient) {
        return googleSignInClient.getSignInobject();
    }

    public static com.google.android.gms.common.api.Scope[] MFFPqMeFiWsBGomt(java.util.List list) {
        return zbb(list);
    }

    public static void MJyrVEXtcxkuBkIY(android.app.object activity, android.content.object intent, int i) {
        activity.startobjectForResult(intent, i);
    }

    public static void NhuvvXiOefwSzODL(android.app.object activity, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        requestPermissions(activity, i, googleSignInAccount, scopeArr);
    }

    public static bool OHUwBQugGvvVthKA(java.util.ICollection collection, java.lang.object[] objArr) {
        return java.util.ICollections.addAll(collection, objArr);
    }

    public static java.util.List OfRYbVjuxVqsaqZF(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getImpliedScopes();
    }

    public static java.lang.object[] PfTgmyPmzraRzZCz(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount QeulCONAocROAyoJ(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        return googleSignInAccount.requestExtraScopes(scopeArr);
    }

    public static void RequestPermissions(android.app.object activity, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        xCHcadguShoYkiWM(activity, "Please provide a non-null object");
        jTHJAQMaBSXkmisl(googleSignInOptionsExtension, "Please provide a non-null GoogleSignInOptionsExtension");
        nhuvvXiOefwSzODL(activity, i, googleSignInAccount, mFFPqMeFiWsBGomt(jGXPHaMsysXCrmRb(googleSignInOptionsExtension)));
    }

    public static void RequestPermissions(android.app.object activity, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope... scopeArr) {
        iSLBeHGIyOezbNtm(activity, "Please provide a non-null object");
        adVsNsTrxKCISuGz(scopeArr, "Please provide at least one scope");
        mJyrVEXtcxkuBkIY(activity, PtXSjrudIehTrzqR(activity, googleSignInAccount, scopeArr), i);
    }

    public static void RequestPermissions(androidx.fragment.app.object fragment, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        VCqZSAaFGwowmkGO(fragment, "Please provide a non-null object");
        ZkIUHMBDXDUhgVpg(googleSignInOptionsExtension, "Please provide a non-null GoogleSignInOptionsExtension");
        IxBaEgASMeriscHP(fragment, i, googleSignInAccount, YszrfrqgjBpwwpIG(ofRYbVjuxVqsaqZF(googleSignInOptionsExtension)));
    }

    public static void RequestPermissions(androidx.fragment.app.object fragment, int i, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope... scopeArr) {
        veWbRGWKZVBfhrkO(fragment, "Please provide a non-null object");
        sZyPbKLJOHSmnANf(scopeArr, "Please provide at least one scope");
        AadRMDMciGSnYaPJ(fragment, rwHWQszpHmqJaeDF(VryeiMPrmpAWyZTS(fragment), googleSignInAccount, scopeArr), i);
    }

    public static java.lang.object RtootwxCmPcsNXuw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.content.object RwHWQszpHmqJaeDF(android.app.object activity, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope[] scopeArr) {
        return zba(activity, googleSignInAccount, scopeArr);
    }

    public static java.lang.object SZyPbKLJOHSmnANf(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn SaEptfErmtfLUawM(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static com.google.android.gms.common.api.Scope[] SaxRBcKwSBKrIHVQ(java.util.List list) {
        return zbb(list);
    }

    public static java.lang.object VeWbRGWKZVBfhrkO(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool VtvsPOQHKebgNFzO(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object WsybIhzpXPefjmJF(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object XCHcadguShoYkiWM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInResult XXaOnGewzXiTGVxh(android.content.object intent) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbd(intent);
    }

    public static java.lang.object YrGhlULXYtCGsRyK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    private static android.content.object Zba(android.app.object activity, com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Scope... scopeArr) {
        if ((27 + 21) % 21 > 0) {
        }
        com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder = new com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder();
        if (scopeArr.length > 0) {
            ejrehkvuUPUFIlWX(googleSignInOptions$Builder, scopeArr[0], scopeArr);
        }
        if (googleSignInAccount is not null && !vtvsPOQHKebgNFzO(asgEKrSVbXPckTcd(googleSignInAccount))) {
            HTeJUjiOvXQsJjHl(googleSignInOptions$Builder, (java.lang.string) arQCxfRLIWBZhxsF(FgJHnYuKUTnGZgzh(googleSignInAccount)));
        }
        return kwjMjdxIEMPsqEKO(new com.google.android.gms.auth.api.signin.GoogleSignInClient(activity, EPNPFvdUWWMiMqvB(googleSignInOptions$Builder)));
    }

    private static com.google.android.gms.common.api.Scope[] Zbb(java.util.List list) {
        return list is not null ? (com.google.android.gms.common.api.Scope[]) pfTgmyPmzraRzZCz(list, new com.google.android.gms.common.api.Scope[LSxFFngqKZkxKVNI(list)]) : new com.google.android.gms.common.api.Scope[0];
    }
}

