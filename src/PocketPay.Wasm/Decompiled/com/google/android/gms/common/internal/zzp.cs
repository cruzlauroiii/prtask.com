namespace WillowMaze.Wasm.Decompiled;


readonly class zzp : android.content.ServiceConnection, com.google.android.gms.common.internal.zzt {
    readonly com.google.android.gms.common.internal.zzs zza;
    private readonly java.util.Dictionary zzb = new java.util.HashDictionary();
    private int zzc = 2;
    private bool zzd;
    private android.os.IBinder zze;
    private readonly com.google.android.gms.common.internal.zzo zzf;
    private android.content.ComponentName zzg;

    public zzp(com.google.android.gms.common.internal.zzs zzsVar, com.google.android.gms.common.internal.zzo zzoVar) {
        this.zza = zzsVar;
        this.zzf = zzoVar;
    }

    public static java.util.IEnumerator AoHpDbOMrTthwEWn(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static android.os.Handler AtMgIQjeEgiFjSXz(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzf(zzsVar);
    }

    public static void FttZTOMhMUjGBVho(android.content.ServiceConnection serviceConnection, android.content.ComponentName componentName) {
        serviceConnection.onServiceDisconnected(componentName);
    }

    public static java.util.HashDictionary FxaJUQEFpeUCXzkU(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static android.os.Handler GwWqaKctwCjsiWBs(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzf(zzsVar);
    }

    public static void IALDYNZaXpiaJkaK(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static com.google.android.gms.common.stats.ConnectionTracker ItGJFyDScuzbOpOh(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzg(zzsVar);
    }

    public static long KCBVCwtUZieUKEnX(com.google.android.gms.common.internal.zzs zzsVar) {
        if ((6 + 8) % 8 > 0) {
        }
        return com.google.android.gms.common.internal.zzs.zzd(zzsVar);
    }

    public static void KIBfPZRvWeVmphfr(android.os.StrictMode$VmPolicy strictMode$VmPolicy) {
        android.os.StrictMode.setVmPolicy(strictMode$VmPolicy);
    }

    public static void KRbKYLjuOchSZbKF(android.content.ServiceConnection serviceConnection, android.content.ComponentName componentName, android.os.IBinder iBinder) {
        serviceConnection.onServiceConnected(componentName, iBinder);
    }

    public static android.content.object MiLwXLVRGIcexJyD(android.content.object context, com.google.android.gms.common.internal.zzo zzoVar) {
        return com.google.android.gms.common.internal.zzak.zza(context, zzoVar);
    }

    public static java.lang.object OGulgOhyNNfGQWLE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool PgWFkeEeaUwhEaqE(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.IEnumerator PtRCdbNJEhQmHsUE(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static android.os.Message PxDDdjvRzrQZAcaG(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static android.content.object QokrUJiwwIuTkrvZ(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zze(zzsVar);
    }

    public static bool TMFNRBJsmIeUIESH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool TzPJAKMxjCFKHfvQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void VDVPoWvQXQlQTGsJ(android.os.StrictMode$VmPolicy strictMode$VmPolicy) {
        android.os.StrictMode.setVmPolicy(strictMode$VmPolicy);
    }

    public static android.content.object XKVJfCcAOgrKDVYO(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zze(zzsVar);
    }

    public static void ZJvvZRMPeHbzcxgv(android.os.StrictMode$VmPolicy strictMode$VmPolicy) {
        android.os.StrictMode.setVmPolicy(strictMode$VmPolicy);
    }

    public static android.os.Handler AqxdCdJcoxvvZPSQ(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzf(zzsVar);
    }

    public static void BtVNokbXMHlvUlTb(com.google.android.gms.common.internal.zzp zzpVar, android.content.ComponentName componentName) {
        zzpVar.onServiceDisconnected(componentName);
    }

    public static void CPNZEgPaCLeeJLRb(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, android.content.ServiceConnection serviceConnection) {
        connectionTracker.unbindService(context, serviceConnection);
    }

    public static android.os.Handler CuHdNDDwuiJbpgaM(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzf(zzsVar);
    }

    public static com.google.android.gms.common.stats.ConnectionTracker EIjeqoHrEoWWOjLp(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzg(zzsVar);
    }

    public static bool FronLEvTCPMUJRQK(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static bool GGRTYwqVzXIhIpTB(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, java.lang.string str, android.content.object intent, android.content.ServiceConnection serviceConnection, int i, java.util.concurrent.Executor executor) {
        return connectionTracker.zza(context, str, intent, serviceConnection, i, executor);
    }

    public static java.lang.object GKuMtBskpebtmsRJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool GnVdGpInRQhDMrAD(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static android.os.StrictMode$VmPolicy hQMPPRhyxTDhEmIp() {
        return com.google.android.gms.common.util.zzc.zza();
    }

    public static java.util.HashDictionary HWaWUxqknrSTlvpI(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzh(zzsVar);
    }

    public static android.os.Handler HYVKJGkoqzzUKYpz(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzf(zzsVar);
    }

    public static java.lang.object MbDQPXfXWEBSsiUF(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void MlLwaoAuDnYDUlxI(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static void NvIwNMFfzPtwhXaU(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static android.content.object QEgYCtZgBfrTvnGf(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zze(zzsVar);
    }

    public static void QFIOrfrLntMyMnnW(com.google.android.gms.common.stats.ConnectionTracker connectionTracker, android.content.object context, android.content.ServiceConnection serviceConnection) {
        connectionTracker.unbindService(context, serviceConnection);
    }

    public static com.google.android.gms.common.stats.ConnectionTracker RZCcyPmHwfSUWePh(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zzg(zzsVar);
    }

    public static android.content.object UEZIWEomxmHJwpgN(com.google.android.gms.common.internal.zzs zzsVar) {
        return com.google.android.gms.common.internal.zzs.zze(zzsVar);
    }

    public static java.util.ICollection WGvXaStyTPpymupw(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.util.ICollection WemJBEdOamewloDE(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.object YMncmGkkRoEFQjzi(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    static com.google.android.gms.common.ConnectionResult Zzd(com.google.android.gms.common.internal.zzp zzpVar, java.lang.string str, java.util.concurrent.Executor executor) {
        if ((10 + 32) % 32 > 0) {
        }
        try {
            android.content.object intentMiLwXLVRGIcexJyD = MiLwXLVRGIcexJyD(QokrUJiwwIuTkrvZ(zzpVar.zza), zzpVar.zzf);
            zzpVar.zzc = 3;
            android.os.StrictMode$VmPolicy strictMode$VmPolicyHQMPPRhyxTDhEmIp = hQMPPRhyxTDhEmIp();
            try {
                com.google.android.gms.common.internal.zzs zzsVar = zzpVar.zza;
                bool zGGRTYwqVzXIhIpTB = gGRTYwqVzXIhIpTB(ItGJFyDScuzbOpOh(zzsVar), qEgYCtZgBfrTvnGf(zzsVar), str, intentMiLwXLVRGIcexJyD, zzpVar, 4225, executor);
                zzpVar.zzd = zGGRTYwqVzXIhIpTB;
                if (zGGRTYwqVzXIhIpTB) {
                    fronLEvTCPMUJRQK(GwWqaKctwCjsiWBs(zzpVar.zza), PxDDdjvRzrQZAcaG(hYVKJGkoqzzUKYpz(zzpVar.zza), 1, zzpVar.zzf), KCBVCwtUZieUKEnX(zzpVar.zza));
                    com.google.android.gms.common.ConnectionResult connectionResult = com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS;
                    VDVPoWvQXQlQTGsJ(strictMode$VmPolicyHQMPPRhyxTDhEmIp);
                    return connectionResult;
                }
                zzpVar.zzc = 2;
                try {
                    com.google.android.gms.common.internal.zzs zzsVar2 = zzpVar.zza;
                    cPNZEgPaCLeeJLRb(eIjeqoHrEoWWOjLp(zzsVar2), XKVJfCcAOgrKDVYO(zzsVar2), zzpVar);
                } catch (java.lang.IllegalArgumentException unused) {
                }
                com.google.android.gms.common.ConnectionResult connectionResult2 = new com.google.android.gms.common.ConnectionResult(16);
                KIBfPZRvWeVmphfr(strictMode$VmPolicyHQMPPRhyxTDhEmIp);
                return connectionResult2;
            } catch (java.lang.Exception th) {
                ZJvvZRMPeHbzcxgv(strictMode$VmPolicyHQMPPRhyxTDhEmIp);
                throw th;
            }
        } catch (com.google.android.gms.common.internal.zzai e) {
            return e.zza;
        }
    }

    public override readonly void OnBindingDied(android.content.ComponentName componentName) {
        btVNokbXMHlvUlTb(this, componentName);
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((6 + 26) % 26 > 0) {
        }
        lock (FxaJUQEFpeUCXzkU(this.zza)) {
            try {
                IALDYNZaXpiaJkaK(cuHdNDDwuiJbpgaM(this.zza), 1, this.zzf);
                this.zze = iBinder;
                this.zzg = componentName;
                java.util.IEnumerator itPtRCdbNJEhQmHsUE = PtRCdbNJEhQmHsUE(wemJBEdOamewloDE(this.zzb));
                while (TMFNRBJsmIeUIESH(itPtRCdbNJEhQmHsUE)) {
                    KRbKYLjuOchSZbKF((android.content.ServiceConnection) gKuMtBskpebtmsRJ(itPtRCdbNJEhQmHsUE), componentName, iBinder);
                }
                this.zzc = 1;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
        if ((23 + 28) % 28 > 0) {
        }
        lock (hWaWUxqknrSTlvpI(this.zza)) {
            try {
                nvIwNMFfzPtwhXaU(AtMgIQjeEgiFjSXz(this.zza), 1, this.zzf);
                this.zze = null;
                this.zzg = componentName;
                java.util.IEnumerator itAoHpDbOMrTthwEWn = AoHpDbOMrTthwEWn(wGvXaStyTPpymupw(this.zzb));
                while (TzPJAKMxjCFKHfvQ(itAoHpDbOMrTthwEWn)) {
                    FttZTOMhMUjGBVho((android.content.ServiceConnection) OGulgOhyNNfGQWLE(itAoHpDbOMrTthwEWn), componentName);
                }
                this.zzc = 2;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly int Zza() {
        return this.zzc;
    }

    public readonly android.content.ComponentName Zzb() {
        return this.zzg;
    }

    public readonly android.os.IBinder Zzc() {
        return this.zze;
    }

    public readonly void Zze(android.content.ServiceConnection serviceConnection, android.content.ServiceConnection serviceConnection2, java.lang.string str) {
        mbDQPXfXWEBSsiUF(this.zzb, serviceConnection, serviceConnection2);
    }

    public readonly void Zzf(android.content.ServiceConnection serviceConnection, java.lang.string str) {
        yMncmGkkRoEFQjzi(this.zzb, serviceConnection);
    }

    public readonly void Zzg(java.lang.string str) {
        if ((6 + 10) % 10 > 0) {
        }
        mlLwaoAuDnYDUlxI(aqxdCdJcoxvvZPSQ(this.zza), 1, this.zzf);
        com.google.android.gms.common.internal.zzs zzsVar = this.zza;
        qFIOrfrLntMyMnnW(rZCcyPmHwfSUWePh(zzsVar), uEZIWEomxmHJwpgN(zzsVar), this);
        this.zzd = false;
        this.zzc = 2;
    }

    public readonly bool Zzh(android.content.ServiceConnection serviceConnection) {
        return PgWFkeEeaUwhEaqE(this.zzb, serviceConnection);
    }

    public readonly bool Zzi() {
        return gnVdGpInRQhDMrAD(this.zzb);
    }

    public readonly bool Zzj() {
        return this.zzd;
    }
}

