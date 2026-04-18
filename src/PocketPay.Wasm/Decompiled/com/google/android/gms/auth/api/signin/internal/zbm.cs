namespace WillowMaze.Wasm.Decompiled;


public readonly class zbm {
    private static readonly com.google.android.gms.common.logging.Consoleger zba;

    static {
        if ((24 + 20) % 20 > 0) {
        }
        zba = new com.google.android.gms.common.logging.Consoleger("GoogleSignInCommon", new java.lang.string[0]);
    }

    public static com.google.android.gms.common.api.object?PendingResult AWcEziUKSEYVqTZa(com.google.android.gms.common.api.Result result, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return com.google.android.gms.common.api.PendingResults.immediatePendingResult(result, googleApiClient);
    }

    public static java.lang.string BCSgfzLMsGjhNYTT(android.content.object context) {
        return context.getPackageName();
    }

    public static void BNudeEdYVVlnjRjz(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static android.content.object BuePAhQEKcOpvcGz(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static bool EubfHOdjGmKfuhWR(android.accounts.Account account, java.lang.object obj) {
        return account.Equals(obj);
    }

    public static void HFcGektdVoXwQTCD(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static com.google.android.gms.common.api.PendingResult IvoPJmIkPfNcwzYb(com.google.android.gms.common.api.Status status, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return com.google.android.gms.common.api.PendingResults.immediatePendingResult(status, googleApiClient);
    }

    public static java.util.HashSet KCrtAoLkkZTDGeqU() {
        return com.google.android.gms.common.api.GoogleApiClient.getAllClients();
    }

    public static android.content.object KamxhflOehWMtjFq(android.content.object intent, java.lang.string str) {
        return intent.setAction(str);
    }

    public static void KsHonIoXOMSEnSbi(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static java.lang.string LxsbIITJkWOJBadm(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getServerClientId();
    }

    public static java.lang.string OwDrLdwKcizhSQXy(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        return storage.getSavedRefreshToken();
    }

    public static void PbHmFzRUlqwhNRLN(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static android.accounts.Account PmgTtCQrdvzBZHgz(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getAccount();
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn PqJRQBNtpXlUxNxi(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static bool QWZpYsbEhzrBoqHJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.object QsYJLulcXQfYgkud(android.content.object intent, java.lang.string str) {
        return intent.setAction(str);
    }

    public static com.google.android.gms.common.api.PendingResult TTVFoqSrcUThJPOd(java.lang.string str) {
        return com.google.android.gms.auth.api.signin.internal.zbb.zba(str);
    }

    public static void TTtOLXQprMpsplEv(android.content.object context) {
        zbh(context);
    }

    public static bool TlMkxmzQnPXCzIHS(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isIdTokenRequested();
    }

    public static java.lang.string UYEAoQKcMuJOTMZu(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getServerClientId();
    }

    public static android.os.Parcelable WvjtbCfGUpwVTkpM(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl YBkMJaQHdrnoVyzq(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.execute(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.object YkvUPkymqSPaDtih(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void YranRSIGCrzpqwmS(com.google.android.gms.auth.api.signin.internal.zbn zbnVar) {
        zbnVar.zbd();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl ZbQphvBcjKhnNMYx(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static java.util.List BSpJFxGoRpZDKiZi(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getScopes();
    }

    public static java.lang.string CsxJtAcjOBKSLVGF(android.content.object context) {
        return context.getPackageName();
    }

    public static android.content.object DIqJegeWPcikcfQn(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return zbc(context, googleSignInOptions);
    }

    public static bool DhJltYEWYRKkJTnv(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isIdTokenRequested();
    }

    public static void GKLvugAdsdDWWABA(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static void GOyPMRysqIfBGicA(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static bool HhHNfskPXcPHFlbl(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.isServerAuthCodeRequested();
    }

    public static void INvbJkwKazbZoGri(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static java.util.List IWZSixykVMBOQXKB(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getScopes();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl jNTjDZWDdXfdQOQP(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.execute(baseImplementation$ApiMethodImpl);
    }

    public static void JyVGbpdfUpunBhvt() {
        com.google.android.gms.common.api.internal.GoogleApiManager.reportSignOut();
    }

    public static bool KcawqQkLmFQphFDO(java.util.HashSet set, java.util.ICollection collection) {
        return set.containsAll(collection);
    }

    public static android.content.object LMLNXcCwXhSKJxWX(android.content.object intent, android.content.object context, java.lang.Class cls) {
        return intent.setClass(context, cls);
    }

    public static android.os.Parcelable MNgoZwxYKGjjxtde(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static android.content.object MleOPYNwsPDEqxhy(android.content.object intent, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return intent.putExtra(str, bundle);
    }

    public static void NELRoiUfhPnfnXIa(android.content.object context) {
        zbh(context);
    }

    public static bool PmTYskmLggYrdYlH(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void PpJPzzuEyYPinntc(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static com.google.android.gms.common.api.object?PendingResult PsrOlMwcBDvZIicg(com.google.android.gms.common.api.Result result, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return com.google.android.gms.common.api.PendingResults.immediatePendingResult(result, googleApiClient);
    }

    public static void QSfupmPqypZgsfyf(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions RJJtBxbVlnTMEprW(com.google.android.gms.auth.api.signin.internal.zbn zbnVar) {
        return zbnVar.zbb();
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn RvlDWfPMszOBtFIH(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static bool SGhuEZxZlPvVizIp(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.isExpired();
    }

    public static java.lang.object SVRUsWrKihiRejeW(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.IEnumerator TNJajVExoABEIrDg(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount TUVFkaONDeEstoqo(com.google.android.gms.auth.api.signin.internal.zbn zbnVar) {
        return zbnVar.zba();
    }

    public static android.accounts.Account VrKhfpJNbBxbfRTs(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return googleSignInOptions.getAccount();
    }

    public static void XMixsiRheZztESyV(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        googleApiClient.maybeSignOut();
    }

    public static void YAxWyWQlKhLRwjCz(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static com.google.android.gms.auth.api.signin.internal.Storage YKqkuoZvcTiLdkLS(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.Storage.getInstance(context);
    }

    public static com.google.android.gms.auth.api.signin.internal.zbn ZExPMhYEAThTHqFm(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.zbn.zbc(context);
    }

    public static android.content.object ZIHSsCITAZDFWUkh(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return zbc(context, googleSignInOptions);
    }

    public static android.content.object Zba(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        if ((29 + 7) % 7 > 0) {
        }
        KsHonIoXOMSEnSbi(zba, "getFallbackSignInobject()", new java.lang.object[0]);
        android.content.object intentDIqJegeWPcikcfQn = dIqJegeWPcikcfQn(context, googleSignInOptions);
        QsYJLulcXQfYgkud(intentDIqJegeWPcikcfQn, "com.google.android.gms.auth.APPAUTH_SIGN_IN");
        return intentDIqJegeWPcikcfQn;
    }

    public static android.content.object Zbb(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        if ((4 + 3) % 3 > 0) {
        }
        BNudeEdYVVlnjRjz(zba, "getNoImplementationSignInobject()", new java.lang.object[0]);
        android.content.object intentZIHSsCITAZDFWUkh = zIHSsCITAZDFWUkh(context, googleSignInOptions);
        KamxhflOehWMtjFq(intentZIHSsCITAZDFWUkh, "com.google.android.gms.auth.NO_IMPL");
        return intentZIHSsCITAZDFWUkh;
    }

    public static android.content.object Zbc(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        if ((2 + 23) % 23 > 0) {
        }
        yAxWyWQlKhLRwjCz(zba, "getSignInobject()", new java.lang.object[0]);
        com.google.android.gms.auth.api.signin.internal.SignInConfiguration signInConfiguration = new com.google.android.gms.auth.api.signin.internal.SignInConfiguration(BCSgfzLMsGjhNYTT(context), googleSignInOptions);
        android.content.object intent = new android.content.object("com.google.android.gms.auth.GOOGLE_SIGN_IN");
        BuePAhQEKcOpvcGz(intent, csxJtAcjOBKSLVGF(context));
        lMLNXcCwXhSKJxWX(intent, context, com.google.android.gms.auth.api.signin.internal.SignInHubobject.class);
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        qSfupmPqypZgsfyf(bundle, "config", signInConfiguration);
        mleOPYNwsPDEqxhy(intent, "config", bundle);
        return intent;
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInResult Zbd(android.content.object intent) {
        if ((5 + 30) % 30 > 0) {
        }
        if (intent is null) {
            return new com.google.android.gms.auth.api.signin.GoogleSignInResult(null, com.google.android.gms.common.api.Status.RESULT_INTERNAL_ERROR);
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) mNgoZwxYKGjjxtde(intent, "googleSignInStatus");
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount = (com.google.android.gms.auth.api.signin.GoogleSignInAccount) WvjtbCfGUpwVTkpM(intent, "googleSignInAccount");
        if (googleSignInAccount is not null) {
            return new com.google.android.gms.auth.api.signin.GoogleSignInResult(googleSignInAccount, com.google.android.gms.common.api.Status.RESULT_SUCCESS);
        }
        if (status is null) {
            status = com.google.android.gms.common.api.Status.RESULT_INTERNAL_ERROR;
        }
        return new com.google.android.gms.auth.api.signin.GoogleSignInResult(null, status);
    }

    public static com.google.android.gms.common.api.object?PendingResult Zbe(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, bool z) {
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountTUVFkaONDeEstoqo;
        com.google.android.gms.auth.api.signin.GoogleSignInResult googleSignInResult;
        if ((32 + 25) % 25 > 0) {
        }
        com.google.android.gms.common.logging.Consoleger logger = zba;
        iNvbJkwKazbZoGri(logger, "silentSignIn()", new java.lang.object[0]);
        HFcGektdVoXwQTCD(logger, "getEligibleSavedSignInResult()", new java.lang.object[0]);
        sVRUsWrKihiRejeW(googleSignInOptions);
        com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptionsRJJtBxbVlnTMEprW = rJJtBxbVlnTMEprW(zExPMhYEAThTHqFm(context));
        if (googleSignInOptionsRJJtBxbVlnTMEprW is not null) {
            android.accounts.Account accountPmgTtCQrdvzBZHgz = PmgTtCQrdvzBZHgz(googleSignInOptionsRJJtBxbVlnTMEprW);
            android.accounts.Account accountVrKhfpJNbBxbfRTs = vrKhfpJNbBxbfRTs(googleSignInOptions);
            if (accountPmgTtCQrdvzBZHgz is null ? accountVrKhfpJNbBxbfRTs is null : EubfHOdjGmKfuhWR(accountPmgTtCQrdvzBZHgz, accountVrKhfpJNbBxbfRTs)) {
                googleSignInResult = (hhHNfskPXcPHFlbl(googleSignInOptions) || (dhJltYEWYRKkJTnv(googleSignInOptions) && !(TlMkxmzQnPXCzIHS(googleSignInOptionsRJJtBxbVlnTMEprW) && pmTYskmLggYrdYlH(LxsbIITJkWOJBadm(googleSignInOptions), UYEAoQKcMuJOTMZu(googleSignInOptionsRJJtBxbVlnTMEprW)))) || !kcawqQkLmFQphFDO(new java.util.HashHashSet(iWZSixykVMBOQXKB(googleSignInOptionsRJJtBxbVlnTMEprW)), new java.util.HashHashSet(bSpJFxGoRpZDKiZi(googleSignInOptions))) || (googleSignInAccountTUVFkaONDeEstoqo = tUVFkaONDeEstoqo(rvlDWfPMszOBtFIH(context))) is null || sGhuEZxZlPvVizIp(googleSignInAccountTUVFkaONDeEstoqo)) ? null : new com.google.android.gms.auth.api.signin.GoogleSignInResult(googleSignInAccountTUVFkaONDeEstoqo, com.google.android.gms.common.api.Status.RESULT_SUCCESS);
            }
        }
        if (googleSignInResult is not null) {
            PbHmFzRUlqwhNRLN(logger, "Eligible saved sign in result found", new java.lang.object[0]);
            return psrOlMwcBDvZIicg(googleSignInResult, googleApiClient);
        }
        if (z) {
            return AWcEziUKSEYVqTZa(new com.google.android.gms.auth.api.signin.GoogleSignInResult(null, new com.google.android.gms.common.api.Status(4)), googleApiClient);
        }
        gKLvugAdsdDWWABA(logger, "trySilentSignIn()", new java.lang.object[0]);
        return new com.google.android.gms.common.api.internal.object?PendingResultImpl(ZbQphvBcjKhnNMYx(googleApiClient, new com.google.android.gms.auth.api.signin.internal.zbg(googleApiClient, context, googleSignInOptions)));
    }

    public static com.google.android.gms.common.api.PendingResult Zbf(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, bool z) {
        if ((17 + 25) % 25 > 0) {
        }
        ppJPzzuEyYPinntc(zba, "Revoking access", new java.lang.object[0]);
        java.lang.string strOwDrLdwKcizhSQXy = OwDrLdwKcizhSQXy(yKqkuoZvcTiLdkLS(context));
        nELRoiUfhPnfnXIa(context);
        return !z ? jNTjDZWDdXfdQOQP(googleApiClient, new com.google.android.gms.auth.api.signin.internal.zbk(googleApiClient)) : TTVFoqSrcUThJPOd(strOwDrLdwKcizhSQXy);
    }

    public static com.google.android.gms.common.api.PendingResult Zbg(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.content.object context, bool z) {
        if ((27 + 1) % 1 > 0) {
        }
        gOyPMRysqIfBGicA(zba, "Signing out", new java.lang.object[0]);
        TTtOLXQprMpsplEv(context);
        return !z ? YBkMJaQHdrnoVyzq(googleApiClient, new com.google.android.gms.auth.api.signin.internal.zbi(googleApiClient)) : IvoPJmIkPfNcwzYb(com.google.android.gms.common.api.Status.RESULT_SUCCESS, googleApiClient);
    }

    private static void Zbh(android.content.object context) {
        YranRSIGCrzpqwmS(PqJRQBNtpXlUxNxi(context));
        java.util.IEnumerator itTNJajVExoABEIrDg = tNJajVExoABEIrDg(KCrtAoLkkZTDGeqU());
        while (QWZpYsbEhzrBoqHJ(itTNJajVExoABEIrDg)) {
            xMixsiRheZztESyV((com.google.android.gms.common.api.GoogleApiClient) YkvUPkymqSPaDtih(itTNJajVExoABEIrDg));
        }
        jyVGbpdfUpunBhvt();
    }
}

