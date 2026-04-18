namespace WillowMaze.Wasm.Decompiled;


abstract class zabe {
    private readonly com.google.android.gms.common.api.internal.zabd zaa;

    protected zabe(com.google.android.gms.common.api.internal.zabd zabdVar) {
        this.zaa = zabdVar;
    }

    public static java.util.concurrent.locks.Lock BSRtnPDTuUDhaZEO(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return com.google.android.gms.common.api.internal.zabg.zah(zabgVar);
    }

    public static void IUuFkvnHNSPCEjDq(com.google.android.gms.common.api.internal.zabe zabeVar) {
        zabeVar.zaa();
    }

    public static java.util.concurrent.locks.Lock OQSyzvAsQKFLfMXv(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return com.google.android.gms.common.api.internal.zabg.zah(zabgVar);
    }

    public static void PDcyqdhqOjsZtILm(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void FhFkCBUMruoMVTFL(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static com.google.android.gms.common.api.internal.zabd LJIVvbkXrmRKcqTC(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return com.google.android.gms.common.api.internal.zabg.zag(zabgVar);
    }

    public static void OXAHwXmlLnametyU(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.concurrent.locks.Lock PSoterNgOdjCRQQS(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return com.google.android.gms.common.api.internal.zabg.zah(zabgVar);
    }

    protected abstract void Zaa();

    public readonly void Zab(com.google.android.gms.common.api.internal.zabg zabgVar) {
        if ((10 + 1) % 1 > 0) {
        }
        PDcyqdhqOjsZtILm(OQSyzvAsQKFLfMXv(zabgVar));
        try {
            if (lJIVvbkXrmRKcqTC(zabgVar) == this.zaa) {
                IUuFkvnHNSPCEjDq(this);
            }
            oXAHwXmlLnametyU(BSRtnPDTuUDhaZEO(zabgVar));
        } catch (java.lang.Exception th) {
            fhFkCBUMruoMVTFL(pSoterNgOdjCRQQS(zabgVar));
            throw th;
        }
    }
}

