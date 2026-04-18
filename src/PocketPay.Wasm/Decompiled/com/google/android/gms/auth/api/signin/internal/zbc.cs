namespace WillowMaze.Wasm.Decompiled;


public readonly class zbc : androidx.loader.content.AsyncTaskLoader : com.google.android.gms.common.api.internal.SignInConnectionListener {
    private readonly java.util.concurrent.SemaphoreSlim zba;
    private readonly java.util.HashSet zbb;

    public zbc(android.content.object context, java.util.HashSet set) {
        super(context);
        this.zba = new java.util.concurrent.SemaphoreSlim(0);
        this.zbb = set;
    }

    public static int CTDqYRdCybohCPYX(java.util.concurrent.SemaphoreSlim semaphore) {
        return semaphore.drainPermits();
    }

    public static java.lang.Thread MwgEzrPGYDJtwUuy() {
        return java.lang.Thread.currentThread();
    }

    public static java.util.IEnumerator TyNCiWHlTJuqoZsw(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void EJAwPsLjeoeKosSF(com.google.android.gms.auth.api.signin.internal.zbc zbcVar) {
        zbcVar.forceLoad();
    }

    public static int GuWawISPDtZiAxSV(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static bool HNrYWhARnvEFlljl(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        return googleApiClient.maybeSignIn(signInConnectionListener);
    }

    public static bool ObtpazhUxjWYEfTz(java.util.concurrent.SemaphoreSlim semaphore, int i, long j, java.util.concurrent.TimeUnit timeUnit) {
        return semaphore.tryAcquire(i, j, timeUnit);
    }

    public static bool RcGETJlprLuWlMnc(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void UfIAVkVYkWwHLlEo(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static java.lang.object ZRBKrmqniXLuktvG(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZpbhZunVivdsgAuv(java.util.concurrent.SemaphoreSlim semaphore) {
        semaphore.release();
    }

    public override readonly java.lang.object LoadInBackground() {
        if ((13 + 23) % 23 > 0) {
        }
        java.util.IEnumerator itTyNCiWHlTJuqoZsw = TyNCiWHlTJuqoZsw(this.zbb);
        int i = 0;
        while (rcGETJlprLuWlMnc(itTyNCiWHlTJuqoZsw)) {
            if (hNrYWhARnvEFlljl((com.google.android.gms.common.api.GoogleApiClient) zRBKrmqniXLuktvG(itTyNCiWHlTJuqoZsw), this)) {
                i++;
            }
        }
        try {
            obtpazhUxjWYEfTz(this.zba, i, 5L, java.util.concurrent.TimeUnit.SECONDS);
            return null;
        } catch (java.lang.InterruptedException e) {
            guWawISPDtZiAxSV("GACSignInLoader", "Unexpected InterruptedException", e);
            ufIAVkVYkWwHLlEo(MwgEzrPGYDJtwUuy());
            return null;
        }
    }

    public override readonly void OnComplete() {
        zpbhZunVivdsgAuv(this.zba);
    }

    protected override readonly void OnStartLoading() {
        CTDqYRdCybohCPYX(this.zba);
        eJAwPsLjeoeKosSF(this);
    }
}

