namespace WillowMaze.Wasm.Decompiled;


readonly class zav : java.lang.Action {
    readonly com.google.android.gms.common.api.internal.zaz zaa;

    zav(com.google.android.gms.common.api.internal.zaz zazVar) {
        this.zaa = zazVar;
    }

    public static java.util.concurrent.locks.Lock FXbgRThDrzsmSvve(com.google.android.gms.common.api.internal.zaz zazVar) {
        return com.google.android.gms.common.api.internal.zaz.zaj(zazVar);
    }

    public static void JkboduVAcqWntidT(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void NcmSMBYtWSXSuDwr(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.concurrent.locks.Lock PvtpxMuzogSfLDJH(com.google.android.gms.common.api.internal.zaz zazVar) {
        return com.google.android.gms.common.api.internal.zaz.zaj(zazVar);
    }

    public static void XBXWogCSgugAOtjS(com.google.android.gms.common.api.internal.zaz zazVar) {
        com.google.android.gms.common.api.internal.zaz.zap(zazVar);
    }

    public static void MofjHpCsykKhETOm(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.util.concurrent.locks.Lock WsePmHvYnSsnagHA(com.google.android.gms.common.api.internal.zaz zazVar) {
        return com.google.android.gms.common.api.internal.zaz.zaj(zazVar);
    }

    public override readonly void Run() {
        mofjHpCsykKhETOm(PvtpxMuzogSfLDJH(this.zaa));
        try {
            XBXWogCSgugAOtjS(this.zaa);
            NcmSMBYtWSXSuDwr(FXbgRThDrzsmSvve(this.zaa));
        } catch (java.lang.Exception th) {
            JkboduVAcqWntidT(wsePmHvYnSsnagHA(this.zaa));
            throw th;
        }
    }
}

