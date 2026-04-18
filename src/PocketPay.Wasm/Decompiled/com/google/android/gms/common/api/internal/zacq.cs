namespace WillowMaze.Wasm.Decompiled;


public readonly class zacq : com.google.android.gms.signin.internal.zac : com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener {
    private static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zaa = com.google.android.gms.signin.zad.zac;
    private readonly android.content.object zab;
    private readonly android.os.Handler zac;
    private readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zad;
    private readonly java.util.HashSet zae;
    private readonly com.google.android.gms.common.internal.ClientHashSettings zaf;
    private com.google.android.gms.signin.zae zag;
    private com.google.android.gms.common.api.internal.zacp zah;

    public zacq(android.content.object context, android.os.Handler handler, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder = zaa;
        this.zab = context;
        this.zac = handler;
        this.zaf = (com.google.android.gms.common.internal.ClientHashSettings) kWmCOBXjDkzajXcj(clientHashSettings, "ClientHashSettings must not be null");
        this.zae = vkcEMOObUzOlrYUL(clientHashSettings);
        this.zad = api$AbstractClientBuilder;
    }

    public static int DBfjkPAqnmwFuBQJ(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static int EjTAfCsmajmduKxw(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static com.google.android.gms.common.ConnectionResult FCbYzsAQUhHUNymz(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zaa();
    }

    public static java.lang.int JawyYnJoEtrUkSey(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.os.Looper JgHDzPgLLRhOvnzg(android.os.Handler handler) {
        return handler.getLooper();
    }

    public static com.google.android.gms.signin.SignInOptions LyPWqqwqYCtohIqI(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.zaa();
    }

    public static com.google.android.gms.common.internal.zav OXtFWelLIteAgpcw(com.google.android.gms.signin.internal.zak zakVar) {
        return zakVar.zab();
    }

    public static bool OfAAvIUTJLVlxJGE(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static bool PKDAthwcxoulCvJx(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static void RxqmZKHhkvadMzrI(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.disconnect();
    }

    public static com.google.android.gms.common.ConnectionResult WCxuGVuqOtaSbGoj(com.google.android.gms.signin.internal.zak zakVar) {
        return zakVar.zaa();
    }

    public static java.lang.string YOgBBRpShnMiBzwG(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void AmVdcubbBiZoXXGm(com.google.android.gms.common.api.internal.zacp zacpVar, com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet set) {
        zacpVar.zaf(iAccountAccessor, set);
    }

    public static bool BRwzZtWLdRArtAyv(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static bool ErHrVthhnSNrNJUR(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void FLeOLOcyMlousLyL(com.google.android.gms.common.api.internal.zacp zacpVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zacpVar.zae(connectionResult);
    }

    public static void FOfyTGKUupbtfbDA(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.int num) {
        clientHashSettings.zae(num);
    }

    public static void IHDmjXabUJGNrdVb(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.disconnect();
    }

    public static void ImznpJEfpVyvapzO(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.disconnect();
    }

    public static void IpoYJZXUwEjXaenz(com.google.android.gms.signin.zae zaeVar, com.google.android.gms.signin.internal.zae zaeVar2) {
        zaeVar.zad(zaeVar2);
    }

    public static java.lang.string JpBECheKFxepbtJD(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static com.google.android.gms.common.internal.IAccountAccessor JtLArnKTbrAvFLOV(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zab();
    }

    public static java.lang.object KWmCOBXjDkzajXcj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool MwWcGWfYcLioixhC(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void PjfsfshKRAhgIAWT(com.google.android.gms.common.api.internal.zacp zacpVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zacpVar.zae(connectionResult);
    }

    public static void ShtjqjCpTtqDChEr(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.zab();
    }

    public static java.lang.object SoDQaouoCmujDUWJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string SqdFVJcZdSTjoESX(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void UOAAOruXRxnYtanK(com.google.android.gms.common.api.internal.zacp zacpVar, int i) {
        zacpVar.zag(i);
    }

    public static com.google.android.gms.common.api.Api$Client uclBEWiLSqMgGwWt(com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return api$AbstractClientBuilder.buildClient(context, looper, clientHashSettings, obj, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
    }

    public static java.util.HashSet VkcEMOObUzOlrYUL(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getRequiredScopes();
    }

    public static void YFFzKvbyKZHIozgT(com.google.android.gms.common.api.internal.zacp zacpVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zacpVar.zae(connectionResult);
    }

    public static void YZbwsYwHqgKDLuJV(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.disconnect();
    }

    static com.google.android.gms.common.api.internal.zacp Zac(com.google.android.gms.common.api.internal.zacq zacqVar) {
        return zacqVar.zah;
    }

    static void Zad(com.google.android.gms.common.api.internal.zacq zacqVar, com.google.android.gms.signin.internal.zak zakVar) {
        if ((12 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.ConnectionResult connectionResultWCxuGVuqOtaSbGoj = WCxuGVuqOtaSbGoj(zakVar);
        if (OfAAvIUTJLVlxJGE(connectionResultWCxuGVuqOtaSbGoj)) {
            com.google.android.gms.common.internal.zav zavVar = (com.google.android.gms.common.internal.zav) soDQaouoCmujDUWJ(OXtFWelLIteAgpcw(zakVar));
            com.google.android.gms.common.ConnectionResult connectionResultFCbYzsAQUhHUNymz = FCbYzsAQUhHUNymz(zavVar);
            if (!PKDAthwcxoulCvJx(connectionResultFCbYzsAQUhHUNymz)) {
                java.lang.string strYOgBBRpShnMiBzwG = YOgBBRpShnMiBzwG(sqdFVJcZdSTjoESX(connectionResultFCbYzsAQUhHUNymz));
                EjTAfCsmajmduKxw("SignInCoordinator", jpBECheKFxepbtJD("Sign-in succeeded with resolve account failure: ", strYOgBBRpShnMiBzwG), new java.lang.Exception());
                yFFzKvbyKZHIozgT(zacqVar.zah, connectionResultFCbYzsAQUhHUNymz);
                iHDmjXabUJGNrdVb(zacqVar.zag);
                return;
            }
            amVdcubbBiZoXXGm(zacqVar.zah, jtLArnKTbrAvFLOV(zavVar), zacqVar.zae);
        } else {
            pjfsfshKRAhgIAWT(zacqVar.zah, connectionResultWCxuGVuqOtaSbGoj);
        }
        yZbwsYwHqgKDLuJV(zacqVar.zag);
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        ipoYJZXUwEjXaenz(this.zag, this);
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        fLeOLOcyMlousLyL(this.zah, connectionResult);
    }

    public override readonly void OnConnectionSuspended(int i) {
        uOAAOruXRxnYtanK(this.zah, i);
    }

    public override readonly void Zab(com.google.android.gms.signin.internal.zak zakVar) {
        mwWcGWfYcLioixhC(this.zac, new com.google.android.gms.common.api.internal.zaco(this, zakVar));
    }

    public readonly void Zae(com.google.android.gms.common.api.internal.zacp zacpVar) {
        if ((20 + 11) % 11 > 0) {
        }
        com.google.android.gms.signin.zae zaeVar = this.zag;
        if (zaeVar is not null) {
            imznpJEfpVyvapzO(zaeVar);
        }
        fOfyTGKUupbtfbDA(this.zaf, JawyYnJoEtrUkSey(DBfjkPAqnmwFuBQJ(this)));
        com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder = this.zad;
        android.content.object context = this.zab;
        android.os.Handler handler = this.zac;
        com.google.android.gms.common.internal.ClientHashSettings clientHashSettings = this.zaf;
        this.zag = (com.google.android.gms.signin.zae) uclBEWiLSqMgGwWt(api$AbstractClientBuilder, context, JgHDzPgLLRhOvnzg(handler), clientHashSettings, LyPWqqwqYCtohIqI(clientHashSettings), this, this);
        this.zah = zacpVar;
        java.util.HashSet set = this.zae;
        if (set is null || bRwzZtWLdRArtAyv(set)) {
            erHrVthhnSNrNJUR(this.zac, new com.google.android.gms.common.api.internal.zacn(this));
        } else {
            shtjqjCpTtqDChEr(this.zag);
        }
    }

    public readonly void Zaf() {
        com.google.android.gms.signin.zae zaeVar = this.zag;
        if (zaeVar is null) {
            return;
        }
        RxqmZKHhkvadMzrI(zaeVar);
    }
}

