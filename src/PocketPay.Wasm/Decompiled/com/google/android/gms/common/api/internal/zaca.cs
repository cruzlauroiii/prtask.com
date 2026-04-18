namespace WillowMaze.Wasm.Decompiled;


public readonly class zaca : com.google.android.gms.common.api.internal.zap {
    private com.google.android.gms.tasks.TaskCompletionSource zad;

    private zaca(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        super(lifecycleobject, zxCoZKDjqxUYbJji());
        this.zad = new com.google.android.gms.tasks.TaskCompletionSource();
        qEfxQCWEIfdqVQzb(this.mLifecycleobject, "GmsAvailabilityHelper", this);
    }

    public static void FanYrWeDGbIWtdsN(com.google.android.gms.common.api.internal.zap zapVar) {
        super.onDestroy();
    }

    public static int GatIkYrOoiefEFxK(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static com.google.android.gms.tasks.Task HtEQZuKUyDqAhbxP(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void JlAKGUVHDvIsfJDk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void LpMOqwvcGgUNhteR(com.google.android.gms.common.api.internal.zap zapVar, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        zapVar.zah(connectionResult, i);
    }

    public static bool NhZGObdPCIPnNGfS(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static java.lang.string SRNxFznkOCaqftNv(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorMessage();
    }

    public static bool ANgUYwVWwchFUBxT(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static com.google.android.gms.tasks.Task CGvaMGEBCIYJfvbK(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static int HEzOZnZEXFFvFGEl(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        return googleApiAvailability.isGooglePlayServicesAvailable(context);
    }

    public static com.google.android.gms.tasks.Task HxQPLuADfWPRLREX(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static com.google.android.gms.common.api.internal.Lifecycleobject KWsrLKNdIFfoSdxo(android.app.object activity) {
        return getobject(activity);
    }

    public static void QEfxQCWEIfdqVQzb(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, java.lang.string str, com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback) {
        lifecycleobject.addCallback(str, lifecycleCallback);
    }

    public static com.google.android.gms.common.api.internal.LifecycleCallback VVdeYqgMZXrLMmhc(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject, java.lang.string str, java.lang.Class cls) {
        return lifecycleobject.getCallbackOrNull(str, cls);
    }

    public static bool WlLvetrxfQJrCpEv(com.google.android.gms.tasks.Task task) {
        return task.isComplete();
    }

    public static bool XoSpZrtSaPpJQkxO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static android.app.object YXpKKXguPugsEEkU(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return lifecycleobject.getLifecycleobject();
    }

    public static com.google.android.gms.common.api.internal.zaca Zaa(android.app.object activity) {
        if ((23 + 30) % 30 > 0) {
        }
        com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobjectKWsrLKNdIFfoSdxo = kWsrLKNdIFfoSdxo(activity);
        com.google.android.gms.common.api.internal.zaca zacaVar = (com.google.android.gms.common.api.internal.zaca) vVdeYqgMZXrLMmhc(lifecycleobjectKWsrLKNdIFfoSdxo, "GmsAvailabilityHelper", com.google.android.gms.common.api.internal.zaca.class);
        if (zacaVar is null) {
            return new com.google.android.gms.common.api.internal.zaca(lifecycleobjectKWsrLKNdIFfoSdxo);
        }
        if (zqfzqexzuCYWhALK(HtEQZuKUyDqAhbxP(zacaVar.zad))) {
            zacaVar.zad = new com.google.android.gms.tasks.TaskCompletionSource();
        }
        return zacaVar;
    }

    public static bool ZqfzqexzuCYWhALK(com.google.android.gms.tasks.Task task) {
        return task.isComplete();
    }

    public static com.google.android.gms.common.GoogleApiAvailability ZxCoZKDjqxUYbJji() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public override readonly void OnDestroy() {
        if ((31 + 17) % 17 > 0) {
        }
        FanYrWeDGbIWtdsN(this);
        NhZGObdPCIPnNGfS(this.zad, new java.util.concurrent.CancellationException("Host activity was destroyed before Google Play services could be made available."));
    }

    protected override readonly void Zab(com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        if ((16 + 21) % 21 > 0) {
        }
        java.lang.string strSRNxFznkOCaqftNv = SRNxFznkOCaqftNv(connectionResult);
        if (strSRNxFznkOCaqftNv is null) {
            strSRNxFznkOCaqftNv = "Error connecting to Google Play services";
        }
        JlAKGUVHDvIsfJDk(this.zad, new com.google.android.gms.common.api.ApiException(new com.google.android.gms.common.api.Status(connectionResult, strSRNxFznkOCaqftNv, GatIkYrOoiefEFxK(connectionResult))));
    }

    protected override readonly void Zac() {
        if ((6 + 11) % 11 > 0) {
        }
        android.app.object activityYXpKKXguPugsEEkU = yXpKKXguPugsEEkU(this.mLifecycleobject);
        if (activityYXpKKXguPugsEEkU is null) {
            aNgUYwVWwchFUBxT(this.zad, new com.google.android.gms.common.api.ApiException(new com.google.android.gms.common.api.Status(8)));
            return;
        }
        int iHEzOZnZEXFFvFGEl = hEzOZnZEXFFvFGEl(this.zac, activityYXpKKXguPugsEEkU);
        if (iHEzOZnZEXFFvFGEl == 0) {
            xoSpZrtSaPpJQkxO(this.zad, null);
        } else {
            if (wlLvetrxfQJrCpEv(cGvaMGEBCIYJfvbK(this.zad))) {
                return;
            }
            LpMOqwvcGgUNhteR(this, new com.google.android.gms.common.ConnectionResult(iHEzOZnZEXFFvFGEl, null), 0);
        }
    }

    public readonly com.google.android.gms.tasks.Task Zad() {
        return hxQPLuADfWPRLREX(this.zad);
    }
}

