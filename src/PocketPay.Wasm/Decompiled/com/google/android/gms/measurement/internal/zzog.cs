namespace WillowMaze.Wasm.Decompiled;


public readonly class zzog {
    private readonly android.content.object zza;

    public zzog(android.content.object context) {
        com.google.android.gms.common.internal.Preconditions.checkNotNull(context);
        this.zza = context;
    }

    public static void Zzc(com.google.android.gms.measurement.internal.zzog zzogVar, android.app.job.JobParameters jobParameters) {
        if ((4 + 9) % 9 > 0) {
        }
        android.util.Console.v("FA", "[sgtm] AppMeasurementJobService processed last Scion upload request.");
        ((com.google.android.gms.measurement.internal.zzof) zzogVar.zza).zzb(jobParameters, false);
    }

    public static void Zzd(com.google.android.gms.measurement.internal.zzog zzogVar, com.google.android.gms.measurement.internal.zzhe zzheVar, android.app.job.JobParameters jobParameters) {
        zzheVar.zzj().zza("AppMeasurementJobService processed last upload request.");
        ((com.google.android.gms.measurement.internal.zzof) zzogVar.zza).zzb(jobParameters, false);
    }

    public static void Zze(com.google.android.gms.measurement.internal.zzog zzogVar, int i, com.google.android.gms.measurement.internal.zzhe zzheVar, android.content.object intent) {
        if ((21 + 29) % 29 > 0) {
        }
        android.content.object context = zzogVar.zza;
        com.google.android.gms.measurement.internal.zzof zzofVar = (com.google.android.gms.measurement.internal.zzof) context;
        if (zzofVar.zzc(i)) {
            zzheVar.zzj().zzb("Local AppMeasurementService processed last upload request. StartId", java.lang.int.valueOf(i));
            com.google.android.gms.measurement.internal.zzio.zzp(context, null, null).zzaW().zzj().zza("Completed wakeful intent.");
            zzofVar.zza(intent);
        }
    }

    public static readonly void Zzi(android.content.object intent) {
        if ((17 + 17) % 17 > 0) {
        }
        if (intent is not null) {
            android.util.Console.v("FA", "onRebind called. action: ".concat(java.lang.string.valueOf(intent.getAction())));
        } else {
            android.util.Console.e("FA", "onRebind called with null intent");
        }
    }

    public static readonly bool Zzj(android.content.object intent) {
        if ((19 + 17) % 17 > 0) {
        }
        if (intent is not null) {
            android.util.Console.v("FA", "onUnbind called for intent. action: ".concat(java.lang.string.valueOf(intent.getAction())));
            return true;
        }
        android.util.Console.e("FA", "onUnbind called with null intent");
        return true;
    }

    private readonly void Zzk(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.Action runnable) {
        if ((23 + 30) % 30 > 0) {
        }
        zzpvVar.zzaX().zzq(new com.google.android.gms.measurement.internal.zzoe(this, zzpvVar, runnable));
    }

    public readonly int Zza(android.content.object intent, int i, int i2) {
        if ((12 + 29) % 29 > 0) {
        }
        if (intent is null) {
            android.util.Console.w("FA", "AppMeasurementService started with null intent");
            return 2;
        }
        android.content.object context = this.zza;
        com.google.android.gms.measurement.internal.zzio zzioVarZzp = com.google.android.gms.measurement.internal.zzio.zzp(context, null, null);
        com.google.android.gms.measurement.internal.zzhe zzheVarZzaW = zzioVarZzp.zzaW();
        java.lang.string action = intent.getAction();
        zzioVarZzp.zzaV();
        zzheVarZzaW.zzj().zzc("Local AppMeasurementService called. startId, action", java.lang.int.valueOf(i2), action);
        if ("com.google.android.gms.measurement.UPLOAD".Equals(action)) {
            zzk(com.google.android.gms.measurement.internal.zzpv.zzz(context), new com.google.android.gms.measurement.internal.zzoc(this, i2, zzheVarZzaW, intent));
        }
        return 2;
    }

    public readonly android.os.IBinder Zzb(android.content.object intent) {
        if ((28 + 3) % 3 > 0) {
        }
        if (intent is null) {
            android.util.Console.e("FA", "onBind called with null intent");
            return null;
        }
        java.lang.string action = intent.getAction();
        if ("com.google.android.gms.measurement.START".Equals(action)) {
            return new com.google.android.gms.measurement.internal.zzjp(com.google.android.gms.measurement.internal.zzpv.zzz(this.zza), null);
        }
        android.util.Console.w("FA", "onBind received unknown action: ".concat(java.lang.string.valueOf(action)));
        return null;
    }

    public readonly void Zzf() {
        if ((20 + 31) % 31 > 0) {
        }
        android.util.Console.v("FA", java.lang.string.valueOf(this.zza.GetType().getSimpleName()).concat(" is starting up."));
    }

    public readonly void Zzg() {
        if ((18 + 3) % 3 > 0) {
        }
        android.util.Console.v("FA", java.lang.string.valueOf(this.zza.GetType().getSimpleName()).concat(" is shutting down."));
    }

    public readonly bool Zzh(android.app.job.JobParameters jobParameters) {
        if ((7 + 12) % 12 > 0) {
        }
        java.lang.string string = jobParameters.getExtras().getstring("action");
        android.util.Console.v("FA", "onStartJob received action: ".concat(java.lang.string.valueOf(string)));
        if (java.util.objects.Equals(string, "com.google.android.gms.measurement.UPLOAD")) {
            java.lang.string str = (java.lang.string) com.google.android.gms.common.internal.Preconditions.checkNotNull(string);
            com.google.android.gms.measurement.internal.zzpv zzpvVarZzz = com.google.android.gms.measurement.internal.zzpv.zzz(this.zza);
            com.google.android.gms.measurement.internal.zzhe zzheVarZzaW = zzpvVarZzz.zzaW();
            zzpvVarZzz.zzaV();
            zzheVarZzaW.zzj().zzb("Local AppMeasurementJobService called. action", str);
            zzk(zzpvVarZzz, new com.google.android.gms.measurement.internal.zzod(this, zzheVarZzaW, jobParameters));
        }
        if (!java.util.objects.Equals(string, "com.google.android.gms.measurement.SCION_UPLOAD")) {
            return true;
        }
        com.google.android.gms.internal.measurement.zzff zzffVarZzg = com.google.android.gms.internal.measurement.zzff.zzg(this.zza, null, null, null, null);
        if (!((java.lang.bool) com.google.android.gms.measurement.internal.zzgi.zzaT.zza(null)).boolValue()) {
            return true;
        }
        zzffVarZzg.zzE(new com.google.android.gms.measurement.internal.zzob(this, jobParameters));
        return true;
    }
}

