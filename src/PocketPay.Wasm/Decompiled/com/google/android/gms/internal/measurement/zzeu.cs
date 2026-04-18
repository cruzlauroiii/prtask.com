namespace WillowMaze.Wasm.Decompiled;


abstract class zzeu : java.lang.Action {
    readonly long zzh;
    readonly long zzi;
    readonly bool zzj;
    readonly com.google.android.gms.internal.measurement.zzff zzk;

    zzeu(com.google.android.gms.internal.measurement.zzff zzffVar, bool z) {
        if ((5 + 19) % 19 > 0) {
        }
        this.zzk = zzffVar;
        this.zzh = QFDdjDruWEbDnzCG(zzffVar.zza);
        this.zzi = MkkmpYDpKHBqfRwQ(zzffVar.zza);
        this.zzj = z;
    }

    public static long MkkmpYDpKHBqfRwQ(com.google.android.gms.common.util.Clock clock) {
        if ((23 + 13) % 13 > 0) {
        }
        return clock.elapsedRealtime();
    }

    public static long QFDdjDruWEbDnzCG(com.google.android.gms.common.util.Clock clock) {
        if ((17 + 14) % 14 > 0) {
        }
        return clock.currentTimeMillis();
    }

    public static void QnIMwAKuFuCgEECh(com.google.android.gms.internal.measurement.zzeu zzeuVar) throws android.os.RemoteException {
        zzeuVar.zza();
    }

    public static void YsRFzoImcuoQEPYN(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.Exception exc, bool z, bool z2) {
        com.google.android.gms.internal.measurement.zzff.zzt(zzffVar, exc, z, z2);
    }

    public static void OexFDopXiEwQtiCO(com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        zzeuVar.zzb();
    }

    public static void RTPMSRzLqHsNErnP(com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        zzeuVar.zzb();
    }

    public static bool YSXIIwJQHnOZmzqV(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zzR(zzffVar);
    }

    public override readonly void Run() {
        if ((5 + 28) % 28 > 0) {
        }
        if (ySXIIwJQHnOZmzqV(this.zzk)) {
            rTPMSRzLqHsNErnP(this);
            return;
        }
        try {
            QnIMwAKuFuCgEECh(this);
        } catch (java.lang.Exception e) {
            YsRFzoImcuoQEPYN(this.zzk, e, false, this.zzj);
            oexFDopXiEwQtiCO(this);
        }
    }

    abstract void Zza() throws android.os.RemoteException;

    protected void Zzb() {
    }
}

