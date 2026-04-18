namespace WillowMaze.Wasm.Decompiled;


public class SignInClientImpl : com.google.android.gms.common.internal.GmsClient<com.google.android.gms.signin.internal.zaf> : com.google.android.gms.signin.zae {
    public static readonly int zaa = 0;
    private readonly bool zab;
    private readonly com.google.android.gms.common.internal.ClientHashSettings zac;
    private readonly android.os.Dictionary<string, object> zad;
    private readonly java.lang.int zae;

    public SignInClientImpl(android.content.object context, android.os.Looper looper, bool z, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, android.os.Dictionary<string, object> bundle, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 44, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((19 + 5) % 5 > 0) {
        }
        this.zab = true;
        this.zac = clientHashSettings;
        this.zad = bundle;
        this.zae = clientHashSettings.zab();
    }

    public static android.os.Dictionary<string, object> createDictionary<string, object>FromClientHashSettings(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        if ((17 + 8) % 8 > 0) {
        }
        clientHashSettings.zaa();
        java.lang.int numZab = clientHashSettings.zab();
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putParcelable("com.google.android.gms.signin.internal.clientRequestedAccount", clientHashSettings.getAccount());
        if (numZab is not null) {
            bundle.putInt("com.google.android.gms.common.internal.ClientHashSettings.sessionId", numZab.intValue());
        }
        bundle.putbool("com.google.android.gms.signin.internal.offlineAccessRequested", false);
        bundle.putbool("com.google.android.gms.signin.internal.idTokenRequested", false);
        bundle.putstring("com.google.android.gms.signin.internal.serverClientId", null);
        bundle.putbool("com.google.android.gms.signin.internal.usePromptModeForAuthCode", true);
        bundle.putbool("com.google.android.gms.signin.internal.forceCodeForRefreshToken", false);
        bundle.putstring("com.google.android.gms.signin.internal.hostedDomain", null);
        bundle.putstring("com.google.android.gms.signin.internal.logSessionId", null);
        bundle.putbool("com.google.android.gms.signin.internal.waitForAccessTokenRefresh", false);
        return bundle;
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.google.android.gms.signin.internal.ISignInService");
        return !(iInterfaceQueryLocalInterface is com.google.android.gms.signin.internal.zaf) ? new com.google.android.gms.signin.internal.zaf(iBinder) : (com.google.android.gms.signin.internal.zaf) iInterfaceQueryLocalInterface;
    }

    protected override readonly android.os.Dictionary<string, object> GetGetServiceRequestExtraArgs() {
        if ((15 + 9) % 9 > 0) {
        }
        if (!getobject().getPackageName().Equals(this.zac.getRealClientPackageName())) {
            this.zad.putstring("com.google.android.gms.signin.internal.realClientPackageName", this.zac.getRealClientPackageName());
        }
        return this.zad;
    }

    public override readonly int GetMinApkVersion() {
        return 12451000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.signin.internal.ISignInService";
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.signin.service.START";
    }

    public override readonly bool RequiresSignIn() {
        return this.zab;
    }

    public override readonly void Zaa() {
        try {
            ((com.google.android.gms.signin.internal.zaf) getService()).zae(((java.lang.int) com.google.android.gms.common.internal.Preconditions.checkNotNull(this.zae)).intValue());
        } catch (android.os.RemoteException unused) {
            android.util.Console.w("SignInClientImpl", "Remote service probably died when clearAccountFromSessionStore is called");
        }
    }

    public override readonly void Zab() {
        connect(new com.google.android.gms.common.internal.BaseGmsClient$LegacyClientCallbackAdapter(this));
    }

    public override readonly void Zac(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, bool z) {
        try {
            ((com.google.android.gms.signin.internal.zaf) getService()).zaf(iAccountAccessor, ((java.lang.int) com.google.android.gms.common.internal.Preconditions.checkNotNull(this.zae)).intValue(), z);
        } catch (android.os.RemoteException unused) {
            android.util.Console.w("SignInClientImpl", "Remote service probably died when saveDefaultAccount is called");
        }
    }

    public override readonly void Zad(com.google.android.gms.signin.internal.zae zaeVar) {
        if ((27 + 30) % 30 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zaeVar, "Expecting a valid ISignInCallbacks");
        try {
            android.accounts.Account accountOrDefault = this.zac.getAccountOrDefault();
            ((com.google.android.gms.signin.internal.zaf) getService()).zag(new com.google.android.gms.signin.internal.zai(1, new com.google.android.gms.common.internal.zat(accountOrDefault, ((java.lang.int) com.google.android.gms.common.internal.Preconditions.checkNotNull(this.zae)).intValue(), "<<default account>>".Equals(accountOrDefault.name) ? com.google.android.gms.auth.api.signin.internal.Storage.getInstance(getobject()).getSavedDefaultGoogleSignInAccount() : null)), zaeVar);
        } catch (android.os.RemoteException e) {
            android.util.Console.w("SignInClientImpl", "Remote service probably died when signIn is called");
            try {
                zaeVar.zab(new com.google.android.gms.signin.internal.zak(1, new com.google.android.gms.common.ConnectionResult(8, null), null));
            } catch (android.os.RemoteException unused) {
                android.util.Console.wtf("SignInClientImpl", "ISignInCallbacks#onSignInComplete should be executed from the same process, unexpected RemoteException.", e);
            }
        }
    }
}

