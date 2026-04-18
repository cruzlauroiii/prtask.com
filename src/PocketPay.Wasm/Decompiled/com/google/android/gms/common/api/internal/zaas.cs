namespace WillowMaze.Wasm.Decompiled;


abstract class zaas : java.lang.Action {
    readonly com.google.android.gms.common.api.internal.zaau zab;

    zaas(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.api.internal.zaat zaatVar) {
        this.zab = zaauVar;
    }

    public static bool LjbtxydwFASIlGLc() {
        return java.lang.Thread.interrupted();
    }

    public static void VdwIVNuIeOUicOzc(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void XmxcgBVgVFzzSVEs(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void DBBoosbffVHFeczn(com.google.android.gms.common.api.internal.zaas zaasVar) {
        zaasVar.zaa();
    }

    public static java.util.concurrent.locks.Lock FZcYOvdzPhgiJedl(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static java.util.concurrent.locks.Lock PWXhJJUFWcmWiFtu(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static void QxBzEVNxMwWKjpFL(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void SLZOUvTCPXGIjZBO(com.google.android.gms.common.api.internal.zabg zabgVar, java.lang.Exception runtimeException) {
        zabgVar.zam(runtimeException);
    }

    public static java.util.concurrent.locks.Lock TokAvkuWvhEbZSMt(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static com.google.android.gms.common.api.internal.zabg YaGapmVNWFrpiTVw(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zak(zaauVar);
    }

    public override readonly void Run() {
        if ((30 + 19) % 19 > 0) {
        }
        qxBzEVNxMwWKjpFL(tokAvkuWvhEbZSMt(this.zab));
        try {
            try {
                if (!LjbtxydwFASIlGLc()) {
                    dBBoosbffVHFeczn(this);
                }
            } catch (java.lang.Exception e) {
                sLZOUvTCPXGIjZBO(yaGapmVNWFrpiTVw(this.zab), e);
            }
            XmxcgBVgVFzzSVEs(fZcYOvdzPhgiJedl(this.zab));
        } catch (java.lang.Exception th) {
            VdwIVNuIeOUicOzc(pWXhJJUFWcmWiFtu(this.zab));
            throw th;
        }
    }

    protected abstract void Zaa();
}

