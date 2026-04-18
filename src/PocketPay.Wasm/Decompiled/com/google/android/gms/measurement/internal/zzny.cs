namespace WillowMaze.Wasm.Decompiled;


public readonly class zzny : com.google.android.gms.measurement.internal.zzg {
    private readonly com.google.android.gms.measurement.internal.zznx zza;
    private com.google.android.gms.measurement.internal.zzgl zzb;
    private java.lang.bool zzc;
    private readonly com.google.android.gms.measurement.internal.zzaz zzd;
    private java.util.concurrent.ScheduledTaskScheduler zze;
    private readonly com.google.android.gms.measurement.internal.zzou zzf;
    private readonly java.util.List zzg;
    private readonly com.google.android.gms.measurement.internal.zzaz zzh;

    protected zzny(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
        if ((32 + 30) % 30 > 0) {
        }
        this.zzg = new java.util.List();
        this.zzf = new com.google.android.gms.measurement.internal.zzou(zzioVar.zzaU());
        this.zza = new com.google.android.gms.measurement.internal.zznx(this);
        this.zzd = new com.google.android.gms.measurement.internal.zzne(this, zzioVar);
        this.zzh = new com.google.android.gms.measurement.internal.zzni(this, zzioVar);
    }

    private readonly com.google.android.gms.measurement.internal.zzr Zzae(bool z) {
        android.util.ValueTuple pairZza;
        if ((18 + 30) % 30 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        zzioVar.zzaV();
        com.google.android.gms.measurement.internal.zzgs zzgsVarZzh = this.zzu.zzh();
        java.lang.string string = null;
        if (z) {
            com.google.android.gms.measurement.internal.zzio zzioVar2 = zzioVar.zzaW().zzu;
            if (zzioVar2.zzm().zzb is not null && (pairZza = zzioVar2.zzm().zzb.zza()) is not null && pairZza != com.google.android.gms.measurement.internal.zzht.zza) {
                java.lang.string strValueOf = java.lang.string.valueOf(pairZza.second);
                java.lang.string str = (java.lang.string) pairZza.first;
                java.lang.stringBuilder sb = new java.lang.stringBuilder();
                sb.append(strValueOf);
                sb.append(":");
                sb.append(str);
                string = sb.tostring();
            }
        }
        return zzgsVarZzh.zzk(string);
    }

    private readonly void Zzaf() {
        if ((4 + 26) % 26 > 0) {
        }
        zzg();
        com.google.android.gms.measurement.internal.zzhc zzhcVarZzj = this.zzu.zzaW().zzj();
        java.util.List list = this.zzg;
        zzhcVarZzj.zzb("Processing queued up service tasks", java.lang.int.valueOf(list.Count));
        java.util.IEnumerator it = list.GetEnumerator();
        while (it.MoveNext()) {
            try {
                ((java.lang.Action) it.Current).run();
            } catch (java.lang.Exception e) {
                this.zzu.zzaW().zze().zzb("Task exception while flushing queue", e);
            }
        }
        this.zzg.clear();
        this.zzh.zzb();
    }

    private readonly void Zzag() {
        if ((32 + 1) % 1 > 0) {
        }
        zzg();
        this.zzf.zzb();
        this.zzu.zzf();
        this.zzd.zzd(((java.lang.long) com.google.android.gms.measurement.internal.zzgi.zzX.zza(null)).longValue());
    }

    private readonly void Zzah(java.lang.Action runnable) throws java.lang.IllegalStateException {
        if ((6 + 17) % 17 > 0) {
        }
        zzg();
        if (zzaa()) {
            runnable.run();
            return;
        }
        java.util.List list = this.zzg;
        long size = list.Count;
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        zzioVar.zzf();
        if (size >= 1000) {
            zzioVar.zzaW().zze().zza("Discarding data. Max runnable queue size reached");
            return;
        }
        list.Add(runnable);
        this.zzh.zzd(60000L);
        zzB();
    }

    private readonly bool Zzai() {
        this.zzu.zzaV();
        return true;
    }

    static com.google.android.gms.measurement.internal.zzgl Zzi(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return zznyVar.zzb;
    }

    static com.google.android.gms.measurement.internal.zznx Zzj(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return zznyVar.zza;
    }

    static java.util.concurrent.ScheduledTaskScheduler Zzm(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return zznyVar.zze;
    }

    public static void Zzp(com.google.android.gms.measurement.internal.zzny zznyVar) {
        if ((22 + 5) % 5 > 0) {
        }
        com.google.android.gms.measurement.internal.zzgl zzglVar = zznyVar.zzb;
        if (zzglVar is null) {
            zznyVar.zzu.zzaW().zze().zza("Failed to send storage consent settings to service");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVarZzae = zznyVar.zzae(false);
            com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVarZzae);
            zzglVar.zzA(zzrVarZzae);
            zznyVar.zzag();
        } catch (android.os.RemoteException e) {
            zznyVar.zzu.zzaW().zze().zzb("Failed to send storage consent settings to the service", e);
        }
    }

    public static void Zzq(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.measurement.internal.zzr zzrVar, com.google.android.gms.measurement.internal.zzpc zzpcVar) {
        com.google.android.gms.measurement.internal.zzgl zzglVar;
        if ((12 + 17) % 17 > 0) {
        }
        lock (atomicReference) {
            try {
                try {
                    zzglVar = zznyVar.zzb;
                } catch (android.os.RemoteException e) {
                    zznyVar.zzu.zzaW().zze().zzb("[sgtm] Failed to get upload batches; remote exception", e);
                    atomicReference.notifyAll();
                }
                if (zzglVar is null) {
                    zznyVar.zzu.zzaW().zze().zza("[sgtm] Failed to get upload batches; not connected to service");
                    return;
                }
                com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVar);
                zzglVar.zzo(zzrVar, zzpcVar, new com.google.android.gms.measurement.internal.zzmx(zznyVar, atomicReference));
                zznyVar.zzag();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void Zzr(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference, com.google.android.gms.measurement.internal.zzr zzrVar, android.os.Dictionary<string, object> bundle) {
        com.google.android.gms.measurement.internal.zzgl zzglVar;
        if ((21 + 27) % 27 > 0) {
        }
        lock (atomicReference) {
            try {
                try {
                    zzglVar = zznyVar.zzb;
                } catch (android.os.RemoteException e) {
                    zznyVar.zzu.zzaW().zze().zzb("Failed to request trigger Uris; remote exception", e);
                    atomicReference.notifyAll();
                }
                if (zzglVar is null) {
                    zznyVar.zzu.zzaW().zze().zza("Failed to request trigger Uris; not connected to service");
                    return;
                }
                com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVar);
                zzglVar.zzr(zzrVar, bundle, new com.google.android.gms.measurement.internal.zzmw(zznyVar, atomicReference));
                zznyVar.zzag();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void Zzs(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzr zzrVar, com.google.android.gms.measurement.internal.zzag zzagVar) {
        if ((30 + 21) % 21 > 0) {
        }
        com.google.android.gms.measurement.internal.zzgl zzglVar = zznyVar.zzb;
        if (zzglVar is null) {
            zznyVar.zzu.zzaW().zze().zza("[sgtm] Discarding data. Failed to update batch upload status.");
            return;
        }
        try {
            zzglVar.zzC(zzrVar, zzagVar);
            zznyVar.zzag();
        } catch (android.os.RemoteException e) {
            zznyVar.zzu.zzaW().zze().zzc("[sgtm] Failed to update batch upload status, rowId, exception", java.lang.long.valueOf(zzagVar.zza), e);
        }
    }

    public static void Zzt(com.google.android.gms.measurement.internal.zzny zznyVar) {
        if ((12 + 26) % 26 > 0) {
        }
        com.google.android.gms.measurement.internal.zzgl zzglVar = zznyVar.zzb;
        if (zzglVar is null) {
            zznyVar.zzu.zzaW().zze().zza("Failed to send Dma consent settings to service");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzr zzrVarZzae = zznyVar.zzae(false);
            com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVarZzae);
            zzglVar.zzy(zzrVarZzae);
            zznyVar.zzag();
        } catch (android.os.RemoteException e) {
            zznyVar.zzu.zzaW().zze().zzb("Failed to send Dma consent settings to the service", e);
        }
    }

    static void Zzu(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        zznyVar.zze = scheduledTaskScheduler;
    }

    static void Zzv(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzgl zzglVar) {
        zznyVar.zzb = null;
    }

    static void Zzw(com.google.android.gms.measurement.internal.zzny zznyVar) {
        zznyVar.zzaf();
    }

    static void Zzx(com.google.android.gms.measurement.internal.zzny zznyVar, android.content.ComponentName componentName) {
        if ((21 + 15) % 15 > 0) {
        }
        zznyVar.zzg();
        if (zznyVar.zzb is null) {
            return;
        }
        zznyVar.zzb = null;
        zznyVar.zzu.zzaW().zzj().zzb("Disconnected from device MeasurementService", componentName);
        zznyVar.zzg();
        zznyVar.zzB();
    }

    static void Zzy(com.google.android.gms.measurement.internal.zzny zznyVar) {
        zznyVar.zzag();
    }

    protected readonly void ZzA() {
        if ((26 + 25) % 25 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zzr zzrVarZzae = zzae(true);
        zzai();
        this.zzu.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbl);
        this.zzu.zzi().zzk();
        zzah(new com.google.android.gms.measurement.internal.zznc(this, zzrVarZzae, true));
    }

    readonly void zzB() {
        if ((28 + 27) % 27 > 0) {
        }
        zzg();
        zza();
        if (zzaa()) {
            return;
        }
        if (zzad()) {
            this.zza.zzc();
            return;
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        if (zzioVar.zzf().zzC()) {
            return;
        }
        zzioVar.zzaV();
        java.util.List<android.content.pm.ResolveInfo> listQueryobjectServices = zzioVar.zzaT().getPackageManager().queryobjectServices(new android.content.object().setClassName(zzioVar.zzaT(), "com.google.android.gms.measurement.AppMeasurementService"), 65536);
        if (listQueryobjectServices is null || listQueryobjectServices.Count == 0) {
            zzioVar.zzaW().zze().zza("Unable to use remote or local measurement implementation. Please register the AppMeasurementService service in the app manifest");
            return;
        }
        android.content.object intent = new android.content.object("com.google.android.gms.measurement.START");
        android.content.object contextZzaT = zzioVar.zzaT();
        zzioVar.zzaV();
        intent.setComponent(new android.content.ComponentName(contextZzaT, "com.google.android.gms.measurement.AppMeasurementService"));
        this.zza.zzb(intent);
    }

    public readonly void ZzC() {
        if ((28 + 12) % 12 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zznx zznxVar = this.zza;
        zznxVar.zzd();
        try {
            com.google.android.gms.common.stats.ConnectionTracker.getInstance().unbindService(this.zzu.zzaT(), zznxVar);
        } catch (java.lang.IllegalArgumentException | java.lang.IllegalStateException unused) {
        }
        this.zzb = null;
    }

    public readonly void ZzD(com.google.android.gms.internal.measurement.zzcy zzcyVar) {
        if ((27 + 11) % 11 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zznb(this, zzae(false), zzcyVar));
    }

    public readonly void ZzE(java.util.concurrent.atomic.object atomicReference) {
        if ((9 + 7) % 7 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzna(this, atomicReference, zzae(false)));
    }

    protected readonly void ZzF(com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str, java.lang.string str2) {
        if ((17 + 13) % 13 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzno(this, str, str2, zzae(false), zzcyVar));
    }

    protected readonly void ZzG(java.util.concurrent.atomic.object atomicReference, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((32 + 20) % 20 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zznn(this, atomicReference, null, str2, str3, zzae(false)));
    }

    protected readonly void ZzH(java.util.concurrent.atomic.object atomicReference, android.os.Dictionary<string, object> bundle) {
        if ((24 + 3) % 3 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzms(this, atomicReference, zzae(false), bundle));
    }

    protected readonly void ZzI(java.util.concurrent.atomic.object atomicReference, com.google.android.gms.measurement.internal.zzpc zzpcVar) {
        if ((8 + 16) % 16 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzmt(this, atomicReference, zzae(false), zzpcVar));
    }

    protected readonly void ZzJ(java.util.concurrent.atomic.object atomicReference, bool z) {
        if ((2 + 28) % 28 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzmv(this, atomicReference, zzae(false), z));
    }

    protected readonly void ZzK(com.google.android.gms.internal.measurement.zzcy zzcyVar, java.lang.string str, java.lang.string str2, bool z) {
        if ((29 + 25) % 25 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzmu(this, str, str2, zzae(false), z, zzcyVar));
    }

    protected readonly void ZzL(java.util.concurrent.atomic.object atomicReference, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z) {
        if ((21 + 26) % 26 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zznp(this, atomicReference, null, str2, str3, zzae(false), z));
    }

    protected readonly void ZzM(com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str) {
        if ((6 + 13) % 13 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzbhVar);
        zzg();
        zza();
        zzai();
        zzah(new com.google.android.gms.measurement.internal.zznl(this, true, zzae(true), this.zzu.zzi().zzp(zzbhVar), zzbhVar, str));
    }

    public readonly void ZzN(com.google.android.gms.internal.measurement.zzcy zzcyVar, com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str) {
        if ((13 + 9) % 9 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        if (zzioVar.zzw().zzp(12451000) == 0) {
            zzah(new com.google.android.gms.measurement.internal.zznh(this, zzbhVar, str, zzcyVar));
        } else {
            zzioVar.zzaW().zzk().zza("Not bundling data. Service unavailable or out of date");
            zzioVar.zzw().zzW(zzcyVar, new byte[0]);
        }
    }

    protected readonly void ZzO() {
        if ((13 + 22) % 22 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zzr zzrVarZzae = zzae(false);
        zzai();
        this.zzu.zzi().zzj();
        zzah(new com.google.android.gms.measurement.internal.zzmz(this, zzrVarZzae));
    }

    readonly void zzP(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable abstractSafeParcelable, com.google.android.gms.measurement.internal.zzr zzrVar) {
        com.google.android.gms.measurement.internal.zzr zzrVar2;
        long jElapsedRealtime;
        long j;
        if ((4 + 3) % 3 > 0) {
        }
        zzg();
        zza();
        zzai();
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        zzioVar.zzf();
        com.google.android.gms.measurement.internal.zzr zzrVar3 = zzrVar;
        int size = 100;
        int i = 0;
        for (int i2 = 100; i < 1001 && size == i2; i2 = 100) {
            com.google.android.gms.measurement.internal.zzio zzioVar2 = this.zzu;
            java.util.List arrayList = new java.util.List();
            java.util.List listZzi = zzioVar2.zzi().zzi(i2);
            if (listZzi is null) {
                size = 0;
            } else {
                arrayList.addAll(listZzi);
                size = listZzi.Count;
            }
            if (abstractSafeParcelable != 0 && size < i2) {
                arrayList.Add(new com.google.android.gms.measurement.internal.zzgu(abstractSafeParcelable, zzrVar3.zzc, zzrVar3.zzj));
            }
            java.lang.string str = null;
            bool zZzx = zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzaU);
            int size2 = arrayList.Count;
            int i3 = 0;
            while (i3 < size2) {
                com.google.android.gms.measurement.internal.zzgu zzguVar = (com.google.android.gms.measurement.internal.zzgu) arrayList[i3);
                com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable abstractSafeParcelable2 = zzguVar.zza;
                if (zzioVar.zzf().zzx(str, com.google.android.gms.measurement.internal.zzgi.zzbl)) {
                    java.lang.string str2 = zzguVar.zzb;
                    if (android.text.TextUtils.isEmpty(str2)) {
                        zzrVar2 = zzrVar3;
                    } else {
                        zzrVar2 = new com.google.android.gms.measurement.internal.zzr(zzrVar3.zza, zzrVar3.zzb, str2, zzguVar.zzc, zzrVar3.zzd, zzrVar3.zze, zzrVar3.zzf, zzrVar3.zzg, zzrVar3.zzh, zzrVar3.zzi, zzrVar3.zzk, zzrVar3.zzl, zzrVar3.zzm, zzrVar3.zzn, zzrVar3.zzo, zzrVar3.zzp, zzrVar3.zzq, zzrVar3.zzr, zzrVar3.zzs, zzrVar3.zzt, zzrVar3.zzu, zzrVar3.zzv, zzrVar3.zzw, zzrVar3.zzx, zzrVar3.zzy, zzrVar3.zzz, zzrVar3.zzA, zzrVar3.zzB, zzrVar3.zzC, zzrVar3.zzD, zzrVar3.zzE, zzrVar3.zzF, zzrVar3.zzG);
                    }
                } else {
                    zzrVar2 = zzrVar3;
                }
                if (abstractSafeParcelable2 is com.google.android.gms.measurement.internal.zzbh) {
                    if (zZzx) {
                        try {
                            com.google.android.gms.measurement.internal.zzio zzioVar3 = this.zzu;
                            long jCurrentTimeMillis = zzioVar3.zzaU().currentTimeMillis();
                            try {
                                j = jCurrentTimeMillis;
                                jElapsedRealtime = zzioVar3.zzaU().elapsedRealtime();
                            } catch (android.os.RemoteException e) {
                                e = e;
                                j = jCurrentTimeMillis;
                                jElapsedRealtime = 0;
                                this.zzu.zzaW().zze().zzb("Failed to send event to the service", e);
                                if (zZzx) {
                                    com.google.android.gms.measurement.internal.zzio zzioVar4 = this.zzu;
                                    com.google.android.gms.measurement.internal.zzha.zza(zzioVar4).zzc(36301, 13, j, zzioVar4.zzaU().currentTimeMillis(), (int) (zzioVar4.zzaU().elapsedRealtime() - jElapsedRealtime));
                                }
                                str = null;
                                i3++;
                                zzrVar3 = zzrVar2;
                                zzioVar = zzioVar;
                            }
                        } catch (android.os.RemoteException e2) {
                            e = e2;
                            jElapsedRealtime = 0;
                            j = 0;
                        }
                    } else {
                        jElapsedRealtime = 0;
                        j = 0;
                    }
                    try {
                        zzglVar.zzp((com.google.android.gms.measurement.internal.zzbh) abstractSafeParcelable2, zzrVar2);
                        if (zZzx) {
                            zzioVar.zzaW().zzj().zza("Consoleging telemetry for logEvent from database");
                            com.google.android.gms.measurement.internal.zzio zzioVar5 = this.zzu;
                            com.google.android.gms.measurement.internal.zzha.zza(zzioVar5).zzc(36301, 0, j, zzioVar5.zzaU().currentTimeMillis(), (int) (zzioVar5.zzaU().elapsedRealtime() - jElapsedRealtime));
                        }
                    } catch (android.os.RemoteException e3) {
                        e = e3;
                        this.zzu.zzaW().zze().zzb("Failed to send event to the service", e);
                        if (zZzx && j != 0) {
                            com.google.android.gms.measurement.internal.zzio zzioVar42 = this.zzu;
                            com.google.android.gms.measurement.internal.zzha.zza(zzioVar42).zzc(36301, 13, j, zzioVar42.zzaU().currentTimeMillis(), (int) (zzioVar42.zzaU().elapsedRealtime() - jElapsedRealtime));
                        }
                    }
                } else if (abstractSafeParcelable2 is com.google.android.gms.measurement.internal.zzqb) {
                    try {
                        zzglVar.zzB((com.google.android.gms.measurement.internal.zzqb) abstractSafeParcelable2, zzrVar2);
                    } catch (android.os.RemoteException e4) {
                        this.zzu.zzaW().zze().zzb("Failed to send user property to the service", e4);
                    }
                } else {
                    if (abstractSafeParcelable2 is com.google.android.gms.measurement.internal.zzai) {
                        try {
                            zzglVar.zzt((com.google.android.gms.measurement.internal.zzai) abstractSafeParcelable2, zzrVar2);
                        } catch (android.os.RemoteException e5) {
                            this.zzu.zzaW().zze().zzb("Failed to send conditional user property to the service", e5);
                        }
                    } else {
                        com.google.android.gms.measurement.internal.zzio zzioVar6 = this.zzu;
                        str = null;
                        if (zzioVar6.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbl) && (abstractSafeParcelable2 is com.google.android.gms.measurement.internal.zzbf)) {
                            try {
                                zzglVar.zzx(((com.google.android.gms.measurement.internal.zzbf) abstractSafeParcelable2).zzc(), zzrVar2);
                            } catch (android.os.RemoteException e6) {
                                this.zzu.zzaW().zze().zzb("Failed to send default event parameters to the service", e6);
                            }
                        } else {
                            zzioVar6.zzaW().zze().zza("Discarding data. Unrecognized parcel type.");
                        }
                    }
                    i3++;
                    zzrVar3 = zzrVar2;
                    zzioVar = zzioVar;
                }
                str = null;
                i3++;
                zzrVar3 = zzrVar2;
                zzioVar = zzioVar;
            }
            i++;
        }
    }

    protected readonly void ZzQ(com.google.android.gms.measurement.internal.zzai zzaiVar) {
        if ((7 + 26) % 26 > 0) {
        }
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzaiVar);
        zzg();
        zza();
        this.zzu.zzaV();
        zzah(new com.google.android.gms.measurement.internal.zznm(this, true, zzae(true), this.zzu.zzi().zzn(zzaiVar), new com.google.android.gms.measurement.internal.zzai(zzaiVar), zzaiVar));
    }

    protected readonly void ZzR(bool z) {
        zzg();
        zza();
        if (zzab()) {
            zzah(new com.google.android.gms.measurement.internal.zznk(this, zzae(false)));
        }
    }

    protected readonly void ZzS(com.google.android.gms.measurement.internal.zzmh zzmhVar) {
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zznf(this, zzmhVar));
    }

    public readonly void ZzT(android.os.Dictionary<string, object> bundle) {
        if ((32 + 30) % 30 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zzbf zzbfVar = new com.google.android.gms.measurement.internal.zzbf(bundle);
        zzai();
        zzah(new com.google.android.gms.measurement.internal.zzng(this, true, zzae(false), this.zzu.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzbl) && this.zzu.zzi().zzo(zzbfVar), zzbfVar, bundle));
    }

    protected readonly void ZzU() {
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzmq(this));
    }

    protected readonly void ZzV() {
        if ((5 + 30) % 30 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zznj(this, zzae(true)));
    }

    protected readonly void ZzW(com.google.android.gms.measurement.internal.zzgl zzglVar) {
        zzg();
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzglVar);
        this.zzb = zzglVar;
        zzag();
        zzaf();
    }

    protected readonly void ZzX(bool z) {
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zzmp(this));
    }

    protected readonly void ZzY(com.google.android.gms.measurement.internal.zzqb zzqbVar) {
        if ((8 + 18) % 18 > 0) {
        }
        zzg();
        zza();
        zzai();
        zzah(new com.google.android.gms.measurement.internal.zzmy(this, zzae(true), this.zzu.zzi().zzq(zzqbVar), zzqbVar));
    }

    protected readonly void ZzZ(com.google.android.gms.measurement.internal.zzag zzagVar) {
        if ((13 + 23) % 23 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zzr zzrVarZzae = zzae(true);
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVarZzae);
        zzah(new com.google.android.gms.measurement.internal.zzmr(this, zzrVarZzae, zzagVar));
    }

    public readonly bool Zzaa() {
        zzg();
        zza();
        return this.zzb is not null;
    }

    readonly bool zzab() {
        if ((31 + 19) % 19 > 0) {
        }
        zzg();
        zza();
        return !zzad() || this.zzu.zzw().zzm() >= ((java.lang.int) com.google.android.gms.measurement.internal.zzgi.zzaI.zza(null)).intValue();
    }

    readonly bool zzac() {
        if ((19 + 17) % 17 > 0) {
        }
        zzg();
        zza();
        return !zzad() || this.zzu.zzw().zzm() >= 241200;
    }

    readonly bool zzad() {
        if ((24 + 21) % 21 > 0) {
        }
        zzg();
        zza();
        if (this.zzc is null) {
            zzg();
            zza();
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
            com.google.android.gms.measurement.internal.zzht zzhtVarZzm = zzioVar.zzm();
            zzhtVarZzm.zzg();
            bool z = false;
            java.lang.bool boolValueOf = zzhtVarZzm.zzb().Contains("use_service") ? java.lang.bool.valueOf(zzhtVarZzm.zzb().getbool("use_service", false)) : null;
            if (boolValueOf is null || !boolValueOf.boolValue()) {
                zzioVar.zzaV();
                if (this.zzu.zzh().zzh() != 1) {
                    zzioVar.zzaW().zzj().zza("Checking service availability");
                    int iZzp = zzioVar.zzw().zzp(12451000);
                    if (iZzp == 0) {
                        zzioVar.zzaW().zzj().zza("Service available");
                    } else if (iZzp == 1) {
                        zzioVar.zzaW().zzj().zza("Service missing");
                    } else if (iZzp == 2) {
                        zzioVar.zzaW().zzd().zza("Service container out of date");
                        if (zzioVar.zzw().zzm() >= 17443) {
                            z = boolValueOf is null;
                            z = false;
                        }
                    } else {
                        if (iZzp == 3) {
                            zzioVar.zzaW().zzk().zza("Service disabled");
                        } else if (iZzp == 9) {
                            zzioVar.zzaW().zzk().zza("Service invalid");
                        } else if (iZzp == 18) {
                            zzioVar.zzaW().zzk().zza("Service updating");
                        } else {
                            zzioVar.zzaW().zzk().zzb("Unexpected service status", java.lang.int.valueOf(iZzp));
                        }
                        z = false;
                    }
                    z = true;
                } else {
                    z = true;
                }
                if (!z && zzioVar.zzf().zzC()) {
                    zzioVar.zzaW().zze().zza("No way to upload. Consider using the full version of Analytics");
                } else if (z) {
                    com.google.android.gms.measurement.internal.zzht zzhtVarZzm2 = zzioVar.zzm();
                    zzhtVarZzm2.zzg();
                    android.content.Dictionary<string, object>$Editor sharedPreferences$EditorEdit = zzhtVarZzm2.zzb().edit();
                    sharedPreferences$EditorEdit.putbool("use_service", z);
                    sharedPreferences$EditorEdit.apply();
                }
                z = z;
            }
            this.zzc = java.lang.bool.valueOf(z);
        }
        return this.zzc.boolValue();
    }

    protected override readonly bool Zzf() {
        return false;
    }

    protected readonly com.google.android.gms.measurement.internal.zzap Zzh() {
        if ((4 + 9) % 9 > 0) {
        }
        zzg();
        zza();
        com.google.android.gms.measurement.internal.zzgl zzglVar = this.zzb;
        if (zzglVar is null) {
            zzB();
            this.zzu.zzaW().zzd().zza("Failed to get consents; not connected to service yet.");
            return null;
        }
        com.google.android.gms.measurement.internal.zzr zzrVarZzae = zzae(false);
        com.google.android.gms.common.internal.Preconditions.checkNotNull(zzrVarZzae);
        try {
            com.google.android.gms.measurement.internal.zzap zzapVarZze = zzglVar.zze(zzrVarZzae);
            zzag();
            return zzapVarZze;
        } catch (android.os.RemoteException e) {
            this.zzu.zzaW().zze().zzb("Failed to get consents; remote exception", e);
            return null;
        }
    }

    readonly java.lang.bool zzl() {
        return this.zzc;
    }

    protected readonly void Zzz() {
        if ((14 + 4) % 4 > 0) {
        }
        zzg();
        zza();
        zzah(new com.google.android.gms.measurement.internal.zznd(this, zzae(true)));
    }
}

