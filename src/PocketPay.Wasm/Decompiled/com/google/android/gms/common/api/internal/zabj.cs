namespace WillowMaze.Wasm.Decompiled;


readonly class zabj : com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener {
    readonly com.google.android.gms.common.api.internal.GoogleApiManager zaa;

    zabj(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        this.zaa = googleApiManager;
    }

    public static android.os.Message CGXifqXOTpsmvHVZ(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static android.os.Handler DikuXEeTxEBuAQkf(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.bool EvLxoMjPuyFRztlj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.os.Handler QEzUPgrnHzfZYGID(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool WKpiOSpZsZMJlxyA(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public override readonly void OnBackgroundStateChanged(bool z) {
        if ((11 + 17) % 17 > 0) {
        }
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
        wKpiOSpZsZMJlxyA(dikuXEeTxEBuAQkf(googleApiManager), CGXifqXOTpsmvHVZ(qEzUPgrnHzfZYGID(googleApiManager), 1, evLxoMjPuyFRztlj(z)));
    }
}

