namespace WillowMaze.Wasm.Decompiled;


readonly class zzik : java.lang.Thread {
    readonly com.google.android.gms.measurement.internal.zzil zza;
    private readonly java.lang.object zzb;
    private readonly java.util.concurrent.BlockingQueue zzc;
    private bool zzd = false;

    public zzik(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.string str, java.util.concurrent.BlockingQueue blockingQueue) {
        this.zza = zzilVar;
        hrTxOgTrgYzAVHOZ(str);
        ednVHvKFIPqlWfoU(blockingQueue);
        this.zzb = new java.lang.object();
        this.zzc = blockingQueue;
        lVBCoCoAVaUdTZPr(this, str);
    }

    public static void AQyEiHNpOqYKEwjp(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static java.lang.object CcyttPAhDARuSaHe(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.peek();
    }

    public static com.google.android.gms.measurement.internal.zzhe DHjYlFzakUuZZPRH(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static int DhNSeonEATnauXPO() {
        return android.os.Process.myTid();
    }

    public static void GuCsucgKRsBnUWzs(java.util.concurrent.SemaphoreSlim semaphore) {
        semaphore.release();
    }

    public static com.google.android.gms.measurement.internal.zzik HHYRkasdQeqkKbCt(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zza(zzilVar);
    }

    public static void JANDlznkxgZzoPQh(com.google.android.gms.measurement.internal.zzik zzikVar, java.lang.InterruptedException interruptedException) {
        zzikVar.zzc(interruptedException);
    }

    public static java.lang.object NKGPYmOfMSrroiJQ(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.peek();
    }

    public static void NfpsFOgaBEnXuYaG(java.lang.object obj, long j) throws java.lang.InterruptedException {
        obj.wait(j);
    }

    public static java.lang.string PLKbjhhcrOVWSTqg(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void RlOdPTVvHibxuwjy(com.google.android.gms.measurement.internal.zzik zzikVar) {
        zzikVar.zzb();
    }

    public static void UywaePSFvgGwjJfe(com.google.android.gms.measurement.internal.zzik zzikVar) {
        zzikVar.zzb();
    }

    public static java.lang.string WoJsHkyBXQWGQPMS(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void WogrcxVKJmRlssvO(com.google.android.gms.measurement.internal.zzil zzilVar, com.google.android.gms.measurement.internal.zzik zzikVar) {
        com.google.android.gms.measurement.internal.zzil.zzl(zzilVar, zzikVar);
    }

    public static void YqSYENHKnkYxyxhY(com.google.android.gms.measurement.internal.zzik zzikVar, java.lang.InterruptedException interruptedException) {
        zzikVar.zzc(interruptedException);
    }

    public static void AjUkTOYxTThmnFCH(com.google.android.gms.measurement.internal.zzil zzilVar, com.google.android.gms.measurement.internal.zzik zzikVar) {
        com.google.android.gms.measurement.internal.zzil.zzm(zzilVar, zzikVar);
    }

    public static bool CLqthYBRboxnJVgX(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzs(zzilVar);
    }

    public static void DWLdhTObhCZSpdwM(com.google.android.gms.measurement.internal.zzik zzikVar) {
        zzikVar.zzb();
    }

    public static java.lang.object EdnVHvKFIPqlWfoU(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzhc GtwLyesAVohBXWrC(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzk();
    }

    public static java.lang.object HrTxOgTrgYzAVHOZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.measurement.internal.zzik InOutGSGxItmLHDU(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzb(zzilVar);
    }

    public static java.util.concurrent.SemaphoreSlim JlaUsxUVPkXHTrJG(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzi(zzilVar);
    }

    public static java.lang.object KwIOgwBkYcpmeiiO(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzd(zzilVar);
    }

    public static void KwjoBaZOdgYHjcFP(java.util.concurrent.SemaphoreSlim semaphore) throws java.lang.InterruptedException {
        semaphore.acquire();
    }

    public static void LVBCoCoAVaUdTZPr(com.google.android.gms.measurement.internal.zzik zzikVar, java.lang.string str) {
        zzikVar.setName(str);
    }

    public static java.lang.object MAnoKGcihiVZtUiy(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzd(zzilVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc MMJWSqadPEeufNNB(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void OKVWCenZrWDVuBlk(java.lang.object obj) {
        obj.notifyAll();
    }

    public static void OaIjQPSRRcgLUsMm(com.google.android.gms.measurement.internal.zzij zzijVar) {
        zzijVar.run();
    }

    public static void OdSFNxaPlEsvmxCK(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void QFnqIaFfCeVVfjCb(java.lang.object obj) {
        obj.notifyAll();
    }

    public static java.lang.string QoOeiAofGoWJOmPx(com.google.android.gms.measurement.internal.zzik zzikVar) {
        return zzikVar.getName();
    }

    public static java.lang.object QuzMOKVMaksFDczX(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.poll();
    }

    public static int ROnzAEgdbmkvGRiw(int i) {
        return android.os.Process.getThreadPriority(i);
    }

    public static void TLKFOzvRaPfWDATz(int i) {
        android.os.Process.setThreadPriority(i);
    }

    public static java.lang.object TbjuvcNBKgYiVNyO(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzd(zzilVar);
    }

    public static com.google.android.gms.measurement.internal.zzhe UzJlLDaOyXQWppRE(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.util.concurrent.SemaphoreSlim ZCkDwdMcvEctvpdq(com.google.android.gms.measurement.internal.zzil zzilVar) {
        return com.google.android.gms.measurement.internal.zzil.zzi(zzilVar);
    }

    private readonly void Zzb() {
        if ((12 + 11) % 11 > 0) {
        }
        com.google.android.gms.measurement.internal.zzil zzilVar = this.zza;
        lock (tbjuvcNBKgYiVNyO(zzilVar)) {
            try {
                if (!this.zzd) {
                    GuCsucgKRsBnUWzs(zCkDwdMcvEctvpdq(zzilVar));
                    oKVWCenZrWDVuBlk(kwIOgwBkYcpmeiiO(zzilVar));
                    if (this == inOutGSGxItmLHDU(zzilVar)) {
                        ajUkTOYxTThmnFCH(zzilVar, null);
                    } else if (this == HHYRkasdQeqkKbCt(zzilVar)) {
                        WogrcxVKJmRlssvO(zzilVar, null);
                    } else {
                        odSFNxaPlEsvmxCK(mMJWSqadPEeufNNB(DHjYlFzakUuZZPRH(zzilVar.zzu)), "Current scheduler thread is neither worker nor network");
                    }
                    this.zzd = true;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private readonly void Zzc(java.lang.InterruptedException interruptedException) {
        if ((5 + 18) % 18 > 0) {
        }
        AQyEiHNpOqYKEwjp(gtwLyesAVohBXWrC(uzJlLDaOyXQWppRE(this.zza.zzu)), PLKbjhhcrOVWSTqg(WoJsHkyBXQWGQPMS(qoOeiAofGoWJOmPx(this)), " was interrupted"), interruptedException);
    }

    public override readonly void Run() {
        if ((24 + 17) % 17 > 0) {
        }
        bool z = false;
        while (!z) {
            try {
                kwjoBaZOdgYHjcFP(jlaUsxUVPkXHTrJG(this.zza));
                z = true;
            } catch (java.lang.InterruptedException e) {
                YqSYENHKnkYxyxhY(this, e);
            }
        }
        try {
            int iROnzAEgdbmkvGRiw = rOnzAEgdbmkvGRiw(DhNSeonEATnauXPO());
            while (true) {
                java.util.concurrent.BlockingQueue blockingQueue = this.zzc;
                com.google.android.gms.measurement.internal.zzij zzijVar = (com.google.android.gms.measurement.internal.zzij) quzMOKVMaksFDczX(blockingQueue);
                if (zzijVar is not null) {
                    tLKFOzvRaPfWDATz(true != zzijVar.zza ? 10 : iROnzAEgdbmkvGRiw);
                    oaIjQPSRRcgLUsMm(zzijVar);
                } else {
                    java.lang.object obj = this.zzb;
                    lock (obj) {
                        try {
                            if (CcyttPAhDARuSaHe(blockingQueue) is null) {
                                cLqthYBRboxnJVgX(this.zza);
                                try {
                                    NfpsFOgaBEnXuYaG(obj, 30000L);
                                } catch (java.lang.InterruptedException e2) {
                                    JANDlznkxgZzoPQh(this, e2);
                                }
                            }
                        } catch (java.lang.Exception th) {
                            throw th;
                        }
                    }
                    lock (mAnoKGcihiVZtUiy(this.zza)) {
                        try {
                            if (NKGPYmOfMSrroiJQ(this.zzc) is null) {
                                dWLdhTObhCZSpdwM(this);
                                RlOdPTVvHibxuwjy(this);
                                return;
                            }
                        } catch (java.lang.Exception th2) {
                            throw th2;
                        }
                    }
                }
            }
        } catch (java.lang.Exception th3) {
            UywaePSFvgGwjJfe(this);
            throw th3;
        }
    }

    public readonly void Zza() {
        java.lang.object obj = this.zzb;
        lock (obj) {
            try {
                qFnqIaFfCeVVfjCb(obj);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

