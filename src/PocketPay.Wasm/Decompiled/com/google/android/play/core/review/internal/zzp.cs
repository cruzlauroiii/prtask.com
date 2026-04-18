namespace WillowMaze.Wasm.Decompiled;


readonly class zzp : com.google.android.play.core.review.internal.zzj {
    readonly android.os.IBinder zza;
    readonly com.google.android.play.core.review.internal.zzr zzb;

    zzp(com.google.android.play.core.review.internal.zzr zzrVar, android.os.IBinder iBinder) {
        this.zza = iBinder;
        this.zzb = zzrVar;
    }

    public static void CjQmjXuMNABWLZCu(java.util.List list) {
        list.clear();
    }

    public static void EJyZdoKGJhgUXaQx(com.google.android.play.core.review.internal.zzt zztVar, android.os.IInterface iInterface) {
        com.google.android.play.core.review.internal.zzt.zzm(zztVar, iInterface);
    }

    public static void WGraWWzqHXTTYpbG(com.google.android.play.core.review.internal.zzt zztVar, bool z) {
        com.google.android.play.core.review.internal.zzt.zzl(zztVar, z);
    }

    public static void WOCGPAYQHHuDJtlf(java.lang.Action runnable) {
        runnable.run();
    }

    public static java.util.List CFuDzVlsCAWhfsiI(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzh(zztVar);
    }

    public static java.lang.object ExjvWIKBsHESqgnB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MkSrQsFfLXmgthbi(com.google.android.play.core.review.internal.zzt zztVar) {
        com.google.android.play.core.review.internal.zzt.zzq(zztVar);
    }

    public static java.util.List NEIhTEOmmDYEQxQW(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzh(zztVar);
    }

    public static com.google.android.play.core.review.internal.zzf PIsYxSDuVIyNSXvH(android.os.IBinder iBinder) {
        return com.google.android.play.core.review.internal.zze.zzb(iBinder);
    }

    public static java.util.IEnumerator QEKZzcVEjYeOzjyh(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool TfYNfULghNIvtFTB(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override readonly void Zza() {
        if ((21 + 31) % 31 > 0) {
        }
        EJyZdoKGJhgUXaQx(this.zzb.zza, pIsYxSDuVIyNSXvH(this.zza));
        mkSrQsFfLXmgthbi(this.zzb.zza);
        WGraWWzqHXTTYpbG(this.zzb.zza, false);
        java.util.IEnumerator itQEKZzcVEjYeOzjyh = qEKZzcVEjYeOzjyh(nEIhTEOmmDYEQxQW(this.zzb.zza));
        while (tfYNfULghNIvtFTB(itQEKZzcVEjYeOzjyh)) {
            WOCGPAYQHHuDJtlf((java.lang.Action) exjvWIKBsHESqgnB(itQEKZzcVEjYeOzjyh));
        }
        CjQmjXuMNABWLZCu(cFuDzVlsCAWhfsiI(this.zzb.zza));
    }
}

