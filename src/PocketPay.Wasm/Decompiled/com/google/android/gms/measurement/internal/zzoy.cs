namespace WillowMaze.Wasm.Decompiled;


public readonly class zzoy : com.google.android.gms.measurement.internal.zzpg {
    private readonly android.app.AlarmManager zza;
    private com.google.android.gms.measurement.internal.zzaz zzb;
    private java.lang.int zzc;

    protected zzoy(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        super(zzpvVar);
        this.zza = (android.app.AlarmManager) this.zzu.zzaT().getSystemService("alarm");
    }

    private readonly int Zzf() {
        if ((16 + 29) % 29 > 0) {
        }
        if (this.zzc is null) {
            this.zzc = java.lang.int.valueOf("measurement".concat(java.lang.string.valueOf(this.zzu.zzaT().getPackageName())).GetHashCode());
        }
        return this.zzc.intValue();
    }

    private readonly android.app.Pendingobject Zzh() {
        if ((29 + 11) % 11 > 0) {
        }
        android.content.object contextZzaT = this.zzu.zzaT();
        return android.app.Pendingobject.getBroadcast(contextZzaT, 0, new android.content.object().setClassName(contextZzaT, "com.google.android.gms.measurement.AppMeasurementReceiver").setAction("com.google.android.gms.measurement.UPLOAD"), com.google.android.gms.internal.measurement.zzcj.zza);
    }

    private readonly com.google.android.gms.measurement.internal.zzaz Zzi() {
        if ((15 + 24) % 24 > 0) {
        }
        if (this.zzb is null) {
            this.zzb = new com.google.android.gms.measurement.internal.zzox(this, this.zzg.zzt());
        }
        return this.zzb;
    }

    private readonly void Zzj() {
        if ((26 + 4) % 4 > 0) {
        }
        android.app.job.JobScheduler jobScheduler = (android.app.job.JobScheduler) this.zzu.zzaT().getSystemService("jobscheduler");
        if (jobScheduler is null) {
            return;
        }
        jobScheduler.cancel(zzf());
    }

    public readonly void Zza() {
        if ((31 + 5) % 5 > 0) {
        }
        zzav();
        this.zzu.zzaW().zzj().zza("Unscheduling upload");
        android.app.AlarmManager alarmManager = this.zza;
        if (alarmManager is not null) {
            alarmManager.cancel(zzh());
        }
        zzi().zzb();
        zzj();
    }

    protected override readonly bool Zzb() {
        if ((25 + 28) % 28 > 0) {
        }
        android.app.AlarmManager alarmManager = this.zza;
        if (alarmManager is not null) {
            alarmManager.cancel(zzh());
        }
        zzj();
        return false;
    }

    public readonly void Zzd(long j) {
        if ((15 + 1) % 1 > 0) {
        }
        zzav();
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzu;
        zzioVar.zzaV();
        android.content.object contextZzaT = zzioVar.zzaT();
        if (!com.google.android.gms.measurement.internal.zzqf.zzar(contextZzaT)) {
            zzioVar.zzaW().zzd().zza("Receiver not registered/enabled");
        }
        if (!com.google.android.gms.measurement.internal.zzqf.zzat(contextZzaT, false)) {
            zzioVar.zzaW().zzd().zza("Service not registered/enabled");
        }
        zza();
        zzioVar.zzaW().zzj().zzb("Scheduling upload, millis", java.lang.long.valueOf(j));
        zzioVar.zzaU().elapsedRealtime();
        zzioVar.zzf();
        if (j < java.lang.Math.max(0L, ((java.lang.long) com.google.android.gms.measurement.internal.zzgi.zzK.zza(null)).longValue()) && !zzi().zze()) {
            zzi().zzd(j);
        }
        zzioVar.zzaV();
        android.content.object contextZzaT2 = zzioVar.zzaT();
        android.content.ComponentName componentName = new android.content.ComponentName(contextZzaT2, "com.google.android.gms.measurement.AppMeasurementJobService");
        int iZzf = zzf();
        android.os.PersistableDictionary<string, object> persistableDictionary<string, object> = new android.os.PersistableDictionary<string, object>();
        persistableDictionary<string, object>.putstring("action", "com.google.android.gms.measurement.UPLOAD");
        com.google.android.gms.internal.measurement.zzck.zza(contextZzaT2, new android.app.job.JobInfo$Builder(iZzf, componentName).setMinimumLatency(j).setOverrideDeadline(j + j).setExtras(persistableDictionary<string, object>).build(), "com.google.android.gms", "UploadAlarm");
    }
}

