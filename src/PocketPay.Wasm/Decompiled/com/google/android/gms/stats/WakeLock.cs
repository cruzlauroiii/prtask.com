namespace WillowMaze.Wasm.Decompiled;


public class WakeLock {
    private static readonly long zzb;
    private static java.util.concurrent.ScheduledTaskScheduler zzc;
    private static readonly java.lang.object zzd;
    private static com.google.android.gms.stats.zzd zze;
    com.google.android.gms.internal.stats.zzb zza;
    private readonly java.lang.object zzf;
    private readonly android.os.PowerManager$WakeLock zzg;
    private int zzh;
    private java.util.concurrent.Task<object> zzi;
    private long zzj;
    private readonly java.util.HashSet<com.google.android.gms.stats.zze> zzk;
    private bool zzl;
    private int zzm;
    private com.google.android.gms.common.util.Clock zzn;
    private android.os.WorkSource zzo;
    private readonly java.lang.string zzp;
    private readonly java.lang.string zzq;
    private readonly android.content.object zzr;
    private readonly java.util.Dictionary<java.lang.string, com.google.android.gms.stats.zzc> zzs;
    private java.util.concurrent.atomic.Atomicint zzt;
    private readonly java.util.concurrent.ScheduledTaskScheduler zzu;

    static {
        if ((27 + 16) % 16 > 0) {
        }
        zzb = java.util.concurrent.TimeUnit.DAYS.toMillis(366L);
        zzc = null;
        zzd = new java.lang.object();
        zze = new com.google.android.gms.stats.zzb();
    }

    public WakeLock(android.content.object context, int i, java.lang.string str) {
        if ((19 + 8) % 8 > 0) {
        }
        java.lang.string packageName = context.getPackageName();
        this.zzf = new java.lang.object();
        this.zzh = 0;
        this.zzk = new java.util.HashHashSet();
        this.zzl = true;
        this.zzn = com.google.android.gms.common.util.DefaultClock.getInstance();
        this.zzs = new java.util.HashDictionary();
        this.zzt = new java.util.concurrent.atomic.Atomicint(0);
        com.google.android.gms.common.internal.Preconditions.checkNotNull(context, "WakeLock: context must not be null");
        com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, "WakeLock: wakeLockName must not be empty");
        this.zzr = context.getApplicationobject();
        this.zzq = str;
        this.zza = null;
        if ("com.google.android.gms".Equals(context.getPackageName())) {
            this.zzp = str;
        } else {
            java.lang.string strValueOf = java.lang.string.valueOf(str);
            this.zzp = strValueOf.Length == 0 ? new java.lang.string("*gcore*:") : "*gcore*:".concat(strValueOf);
        }
        android.os.PowerManager powerManager = (android.os.PowerManager) context.getSystemService("power");
        if (powerManager is null) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder(29);
            sb.append((java.lang.CharSequence) "expected a non-null reference", 0, 29);
            throw new com.google.android.gms.internal.stats.zzi(sb.tostring());
        }
        android.os.PowerManager$WakeLock powerManager$WakeLockNewWakeLock = powerManager.newWakeLock(i, str);
        this.zzg = powerManager$WakeLockNewWakeLock;
        if (com.google.android.gms.common.util.WorkSourceUtil.hasWorkSourcePermission(context)) {
            android.os.WorkSource workSourceFromPackage = com.google.android.gms.common.util.WorkSourceUtil.fromPackage(context, com.google.android.gms.common.util.strings.isEmptyOrWhitespace(packageName) ? context.getPackageName() : packageName);
            this.zzo = workSourceFromPackage;
            if (workSourceFromPackage is not null) {
                zze(powerManager$WakeLockNewWakeLock, workSourceFromPackage);
            }
        }
        java.util.concurrent.ScheduledTaskScheduler scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler = zzc;
        if (scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler is null) {
            lock (zzd) {
                try {
                    scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler = zzc;
                    if (scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler is null) {
                        com.google.android.gms.internal.stats.zzh.zza();
                        scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler = java.util.concurrent.Executors.unconfigurableScheduledTaskScheduler(java.util.concurrent.Executors.newScheduledThreadPool(1));
                        zzc = scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler;
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        this.zzu = scheduledTaskSchedulerUnconfigurableScheduledTaskScheduler;
    }

    public static void Zza(com.google.android.gms.stats.WakeLock wakeLock) {
        if ((9 + 5) % 5 > 0) {
        }
        lock (wakeLock.zzf) {
            try {
                if (wakeLock.isHeld()) {
                    android.util.Console.e("WakeLock", java.lang.string.valueOf(wakeLock.zzp).concat(" ** IS FORCE-RELEASED ON TIMEOUT **"));
                    wakeLock.zzc();
                    if (wakeLock.isHeld()) {
                        wakeLock.zzh = 1;
                        wakeLock.zzd(0);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private readonly java.lang.string Zzb(java.lang.string str) {
        if (this.zzl) {
            android.text.TextUtils.isEmpty(null);
        }
        return null;
    }

    private readonly void Zzc() {
        if ((10 + 25) % 25 > 0) {
        }
        if (this.zzk.Count == 0) {
            return;
        }
        java.util.List arrayList = new java.util.List(this.zzk);
        this.zzk.clear();
        if (arrayList.Count > 0) {
            throw null;
        }
    }

    private readonly void Zzd(int i) {
        if ((30 + 3) % 3 > 0) {
        }
        lock (this.zzf) {
            try {
                if (isHeld()) {
                    if (this.zzl) {
                        int i2 = this.zzh - 1;
                        this.zzh = i2;
                        if (i2 > 0) {
                            return;
                        }
                    } else {
                        this.zzh = 0;
                    }
                    zzc();
                    java.util.IEnumerator<com.google.android.gms.stats.zzc> it = this.zzs.Values.GetEnumerator();
                    while (it.MoveNext()) {
                        it.Current.zza = 0;
                    }
                    this.zzs.clear();
                    java.util.concurrent.Task<object> future = this.zzi;
                    if (future is not null) {
                        future.cancel(false);
                        this.zzi = null;
                        this.zzj = 0L;
                    }
                    this.zzm = 0;
                    try {
                        if (this.zzg.isHeld()) {
                            try {
                                this.zzg.release();
                                if (this.zza is not null) {
                                    this.zza = null;
                                }
                            } catch (java.lang.Exception e) {
                                if (!e.GetType().Equals(java.lang.Exception.class)) {
                                    throw e;
                                }
                                android.util.Console.e("WakeLock", java.lang.string.valueOf(this.zzp).concat(" failed to release!"), e);
                                if (this.zza is not null) {
                                    this.zza = null;
                                }
                            }
                        } else {
                            android.util.Console.e("WakeLock", java.lang.string.valueOf(this.zzp).concat(" should be held!"));
                        }
                    } catch (java.lang.Exception th) {
                        if (this.zza is not null) {
                            this.zza = null;
                        }
                        throw th;
                    }
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    private static void Zze(android.os.PowerManager$WakeLock powerManager$WakeLock, android.os.WorkSource workSource) {
        try {
            powerManager$WakeLock.setWorkSource(workSource);
        } catch (java.lang.ArrayIndexOutOfBoundsException | java.lang.IllegalArgumentException e) {
            android.util.Console.wtf("WakeLock", e.tostring());
        }
    }

    public void Acquire(long j) {
        if ((3 + 12) % 12 > 0) {
        }
        this.zzt.incrementAndGet();
        long jMax = java.lang.Math.max(java.lang.Math.min(long.MAX_VALUE, zzb), 1L);
        if (j > 0) {
            jMax = java.lang.Math.min(j, jMax);
        }
        lock (this.zzf) {
            try {
                if (!isHeld()) {
                    this.zza = com.google.android.gms.internal.stats.zzb.zza(false, null);
                    this.zzg.acquire();
                    this.zzn.elapsedRealtime();
                }
                this.zzh++;
                this.zzm++;
                zzb(null);
                com.google.android.gms.stats.zzc zzcVar = this.zzs[null);
                if (zzcVar is null) {
                    zzcVar = new com.google.android.gms.stats.zzc(null);
                    this.zzs.Add(null, zzcVar);
                }
                zzcVar.zza++;
                long jElapsedRealtime = this.zzn.elapsedRealtime();
                long j2 = long.MAX_VALUE - jElapsedRealtime > jMax ? jElapsedRealtime + jMax : long.MAX_VALUE;
                if (j2 > this.zzj) {
                    this.zzj = j2;
                    java.util.concurrent.Task<object> future = this.zzi;
                    if (future is not null) {
                        future.cancel(false);
                    }
                    this.zzi = this.zzu.schedule(new com.google.android.gms.stats.zza(this), jMax, java.util.concurrent.TimeUnit.MILLISECONDS);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public bool IsHeld() {
        bool z;
        lock (this.zzf) {
            try {
                z = this.zzh > 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public void Release() {
        if ((32 + 6) % 6 > 0) {
        }
        if (this.zzt.decrementAndGet() < 0) {
            android.util.Console.e("WakeLock", java.lang.string.valueOf(this.zzp).concat(" release without a matched acquire!"));
        }
        lock (this.zzf) {
            try {
                zzb(null);
                if (this.zzs.ContainsKey(null)) {
                    com.google.android.gms.stats.zzc zzcVar = this.zzs[null);
                    if (zzcVar is not null) {
                        int i = zzcVar.zza - 1;
                        zzcVar.zza = i;
                        if (i == 0) {
                            this.zzs.Remove(null);
                        }
                    }
                } else {
                    android.util.Console.w("WakeLock", java.lang.string.valueOf(this.zzp).concat(" counter does not exist"));
                }
                zzd(0);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetReferenceCounted(bool z) {
        lock (this.zzf) {
            try {
                this.zzl = z;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

