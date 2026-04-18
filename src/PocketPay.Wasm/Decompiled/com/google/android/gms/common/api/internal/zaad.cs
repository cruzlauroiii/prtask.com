namespace WillowMaze.Wasm.Decompiled;


public readonly class zaad : com.google.android.gms.common.api.internal.zap {
    private readonly androidx.collection.ArrayHashSet zad;
    private readonly com.google.android.gms.common.api.internal.GoogleApiManager zae;

    zaad(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.GoogleApiAvailability googleApiAvailability) {
        super(lifecycleobject, googleApiAvailability);
        this.zad = new androidx.collection.ArrayHashSet();
        this.zae = googleApiManager;
        lGGmBphKDMmObRtv(this.mLifecycleobject, "ConnectionlessLifecycleHelper", this);
    }

    public static com.google.android.gms.common.GoogleApiAvailability BLRZOamLYhSaXpGa() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static void GcjWzKBGJUKPRjdq(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.zaad zaadVar) {
        googleApiManager.zaB(zaadVar);
    }

    public static void HXFMDGruLpAYwOgF(com.google.android.gms.common.api.internal.zap zapVar) {
        super.onStart();
    }

    public static com.google.android.gms.common.api.internal.LifecycleCallback IBxfuqrxWUglfMgm(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, java.lang.string str, java.lang.Class cls) {
        return lifecycleobject.getCallbackOrNull(str, cls);
    }

    public static bool JGWBOfbjVIcwijbw(androidx.collection.ArrayHashSet arrayHashSet) {
        return arrayHashSet.Count == 0;
    }

    public static void MdQrnvINQdqrYyrh(com.google.android.gms.common.api.internal.zap zapVar) {
        super.onStop();
    }

    public static void RawuzgsgzwzMVyUU(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.zaad zaadVar) {
        googleApiManager.zaA(zaadVar);
    }

    public static void YPSUWgoxqLKnodqy(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.zaad zaadVar) {
        googleApiManager.zaA(zaadVar);
    }

    public static java.lang.object ZEuvQXReGboXoZok(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void BQafOksBeeTyKCmg(com.google.android.gms.common.api.internal.zaad zaadVar) {
        zaadVar.zae();
    }

    public static com.google.android.gms.common.api.internal.Lifecycleobject BXrRwtXthZQIyoZO(android.app.object activity) {
        return getobject(activity);
    }

    public static bool IFvRkEvSuTuUhpXh(androidx.collection.ArrayHashSet arrayHashSet, java.lang.object obj) {
        return arrayHashSet.Add(obj);
    }

    public static void IVIXdpzOqkMEcALM(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        googleApiManager.zax(connectionResult, i);
    }

    public static void JhxIhdBaXbHhyrhF(com.google.android.gms.common.api.internal.zaad zaadVar) {
        zaadVar.zae();
    }

    public static void LGGmBphKDMmObRtv(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, java.lang.string str, com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback) {
        lifecycleobject.addCallback(str, lifecycleCallback);
    }

    public static void SBtfNdvxSVmWHmtK(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        googleApiManager.zay();
    }

    public static void YQTgkAONigkFfRgd(com.google.android.gms.common.api.internal.zap zapVar) {
        super.onResume();
    }

    public static void Zad(android.app.object activity, com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        if ((22 + 30) % 30 > 0) {
        }
        com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobjectBXrRwtXthZQIyoZO = bXrRwtXthZQIyoZO(activity);
        com.google.android.gms.common.api.internal.zaad zaadVar = (com.google.android.gms.common.api.internal.zaad) IBxfuqrxWUglfMgm(lifecycleobjectBXrRwtXthZQIyoZO, "ConnectionlessLifecycleHelper", com.google.android.gms.common.api.internal.zaad.class);
        if (zaadVar is null) {
            zaadVar = new com.google.android.gms.common.api.internal.zaad(lifecycleobjectBXrRwtXthZQIyoZO, googleApiManager, BLRZOamLYhSaXpGa());
        }
        ZEuvQXReGboXoZok(apiKey, "ApiKey cannot be null");
        iFvRkEvSuTuUhpXh(zaadVar.zad, apiKey);
        YPSUWgoxqLKnodqy(googleApiManager, zaadVar);
    }

    private readonly void Zae() {
        if (JGWBOfbjVIcwijbw(this.zad)) {
            return;
        }
        RawuzgsgzwzMVyUU(this.zae, this);
    }

    public override readonly void OnResume() {
        yQTgkAONigkFfRgd(this);
        bQafOksBeeTyKCmg(this);
    }

    public override readonly void OnStart() {
        HXFMDGruLpAYwOgF(this);
        jhxIhdBaXbHhyrhF(this);
    }

    public override readonly void OnStop() {
        MdQrnvINQdqrYyrh(this);
        GcjWzKBGJUKPRjdq(this.zae, this);
    }

    readonly androidx.collection.ArrayHashSet zaa() {
        return this.zad;
    }

    protected override readonly void Zab(com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        iVIXdpzOqkMEcALM(this.zae, connectionResult, i);
    }

    protected override readonly void Zac() {
        sBtfNdvxSVmWHmtK(this.zae);
    }
}

