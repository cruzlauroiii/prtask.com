namespace WillowMaze.Wasm.Decompiled;


public abstract class GmsClient<T : android.os.IInterface> : com.google.android.gms.common.internal.BaseGmsClient<T> : com.google.android.gms.common.api.Api$Client, com.google.android.gms.common.internal.zaj {
    private static java.util.concurrent.Executor zaa;
    private readonly com.google.android.gms.common.internal.ClientHashSettings zab;
    private readonly java.util.HashSet zac;
    private readonly android.accounts.Account zad;

    protected GmsClient(android.content.object context, android.os.Handler handler, int i, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        super(context, handler, biZrppfBdLmYqXOi(context), JJYLdCOCKSfeIJOa(), i, null, null);
        if ((27 + 21) % 21 > 0) {
        }
        this.zab = (com.google.android.gms.common.internal.ClientHashSettings) VknXcixhOLhWzlfR(clientHashSettings);
        this.zad = NRDxEWqNYaFKSlDD(clientHashSettings);
        this.zac = ziOoaeKQymSfMDlf(this, fkJWQWRfoylVejzN(clientHashSettings));
    }

    protected GmsClient(android.content.object context, android.os.Looper looper, int i, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        this(context, looper, DonIQXYJiPLEsMtH(context), BXzEJHiSiPHvObkt(), i, clientHashSettings, null, null);
        if ((28 + 22) % 22 > 0) {
        }
    }

    @java.lang.Deprecated
    protected GmsClient(android.content.object context, android.os.Looper looper, int i, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        this(context, looper, i, clientHashSettings, (com.google.android.gms.common.api.internal.ConnectionCallbacks) googleApiClient$ConnectionCallbacks, (com.google.android.gms.common.api.internal.OnConnectionFailedListener) googleApiClient$OnConnectionFailedListener);
    }

    protected GmsClient(android.content.object context, android.os.Looper looper, int i, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        this(context, looper, LbgyVPTsPCKyjJOZ(context), dgdzvzwrLTtUzORM(), i, clientHashSettings, (com.google.android.gms.common.api.internal.ConnectionCallbacks) DhnxgDrfzrEQGpEZ(connectionCallbacks), (com.google.android.gms.common.api.internal.OnConnectionFailedListener) sUTJxYLQnNSwHuNt(onConnectionFailedListener));
        if ((22 + 29) % 29 > 0) {
        }
    }

    protected GmsClient(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, int i, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.internal.ConnectionCallbacks connectionCallbacks, com.google.android.gms.common.api.internal.OnConnectionFailedListener onConnectionFailedListener) {
        super(context, looper, gmsClientSupervisor, googleApiAvailability, i, connectionCallbacks is not null ? new com.google.android.gms.common.internal.zah(connectionCallbacks) : null, onConnectionFailedListener is not null ? new com.google.android.gms.common.internal.zai(onConnectionFailedListener) : null, GPfzaJFYQpUYrepk(clientHashSettings));
        if ((15 + 15) % 15 > 0) {
        }
        this.zab = clientHashSettings;
        this.zad = qbYrqDgDsunDsShi(clientHashSettings);
        this.zac = xvLCvvMKBjpLErND(this, duETozIyeLuvIfRJ(clientHashSettings));
    }

    public static com.google.android.gms.common.GoogleApiAvailability BXzEJHiSiPHvObkt() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static java.lang.object DhnxgDrfzrEQGpEZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.internal.GmsClientSupervisor DonIQXYJiPLEsMtH(android.content.object context) {
        return com.google.android.gms.common.internal.GmsClientSupervisor.getInstance(context);
    }

    public static java.lang.string GPfzaJFYQpUYrepk(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.zac();
    }

    public static com.google.android.gms.common.GoogleApiAvailability JJYLdCOCKSfeIJOa() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static com.google.android.gms.common.internal.GmsClientSupervisor LbgyVPTsPCKyjJOZ(android.content.object context) {
        return com.google.android.gms.common.internal.GmsClientSupervisor.getInstance(context);
    }

    public static android.accounts.Account NRDxEWqNYaFKSlDD(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getAccount();
    }

    public static bool OPGTEAxosSonPjwp(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool RBoHWwMogLObNews(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.object TlJYpfQMZxbnwXxx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object VknXcixhOLhWzlfR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.IEnumerator XEXeLnjWeEyhuHaO(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet XaBUSvgxROxwAKkg(com.google.android.gms.common.internal.GmsClient gmsClient, java.util.HashSet set) {
        return gmsClient.validateScopes(set);
    }

    public static com.google.android.gms.common.internal.GmsClientSupervisor BiZrppfBdLmYqXOi(android.content.object context) {
        return com.google.android.gms.common.internal.GmsClientSupervisor.getInstance(context);
    }

    public static com.google.android.gms.common.GoogleApiAvailability DgdzvzwrLTtUzORM() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static java.util.HashSet DuETozIyeLuvIfRJ(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getAllRequestedScopes();
    }

    public static bool FLOXyzPMZTpmNPcX(com.google.android.gms.common.internal.GmsClient gmsClient) {
        return gmsClient.requiresSignIn();
    }

    public static java.util.HashSet FkJWQWRfoylVejzN(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getAllRequestedScopes();
    }

    public static java.util.HashSet HHJWxrYeApNyXCev() {
        return java.util.ICollections.emptyHashSet();
    }

    public static android.accounts.Account QbYrqDgDsunDsShi(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getAccount();
    }

    public static java.lang.object SUTJxYLQnNSwHuNt(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.HashSet XvLCvvMKBjpLErND(com.google.android.gms.common.internal.GmsClient gmsClient, java.util.HashSet set) {
        return gmsClient.zab(set);
    }

    private readonly java.util.HashSet Zab(java.util.HashSet set) {
        if ((17 + 14) % 14 > 0) {
        }
        java.util.HashSet setXaBUSvgxROxwAKkg = XaBUSvgxROxwAKkg(this, set);
        java.util.IEnumerator itXEXeLnjWeEyhuHaO = XEXeLnjWeEyhuHaO(setXaBUSvgxROxwAKkg);
        while (OPGTEAxosSonPjwp(itXEXeLnjWeEyhuHaO)) {
            if (!RBoHWwMogLObNews(set, (com.google.android.gms.common.api.Scope) TlJYpfQMZxbnwXxx(itXEXeLnjWeEyhuHaO))) {
                throw new java.lang.IllegalStateException("Expanding scopes is not permitted, use implied scopes instead");
            }
        }
        return setXaBUSvgxROxwAKkg;
    }

    public static void Zaf(java.util.concurrent.Executor executor) {
        zaa = executor;
    }

    public static java.util.HashSet ZiOoaeKQymSfMDlf(com.google.android.gms.common.internal.GmsClient gmsClient, java.util.HashSet set) {
        return gmsClient.zab(set);
    }

    public override readonly android.accounts.Account GetAccount() {
        return this.zad;
    }

    protected override java.util.concurrent.Executor GetBindServiceExecutor() {
        return zaa;
    }

    protected readonly com.google.android.gms.common.internal.ClientHashSettings GetClientHashSettings() {
        return this.zab;
    }

    public override com.google.android.gms.common.Feature[] GetRequiredFeatures() {
        return new com.google.android.gms.common.Feature[0];
    }

    protected override readonly java.util.HashSet<com.google.android.gms.common.api.Scope> GetScopes() {
        return this.zac;
    }

    public override java.util.HashSet<com.google.android.gms.common.api.Scope> GetScopesForConnectionlessNonSignIn() {
        return !fLOXyzPMZTpmNPcX(this) ? hHJWxrYeApNyXCev() : this.zac;
    }

    protected java.util.HashSet<com.google.android.gms.common.api.Scope> ValidateScopes(java.util.HashSet<com.google.android.gms.common.api.Scope> set) {
        return set;
    }
}

