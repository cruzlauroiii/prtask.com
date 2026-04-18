namespace WillowMaze.Wasm.Decompiled;


public readonly class AppMeasurementJobService : android.app.job.JobService : com.google.android.gms.measurement.internal.zzof {
    private com.google.android.gms.measurement.internal.zzog zza;

    public static com.google.android.gms.measurement.internal.zzog CvqqxNsRbwFPdQdN(com.google.android.gms.measurement.AppMeasurementJobService appMeasurementJobService) {
        return appMeasurementJobService.zzd();
    }

    public static bool DMnjmaSohoxWdPkg(android.content.object intent) {
        return com.google.android.gms.measurement.internal.zzog.zzj(intent);
    }

    public static com.google.android.gms.measurement.internal.zzog ECOiAEHEbihdOHvN(com.google.android.gms.measurement.AppMeasurementJobService appMeasurementJobService) {
        return appMeasurementJobService.zzd();
    }

    public static void ESCXsuxorHgAOVZH(com.google.android.gms.measurement.AppMeasurementJobService appMeasurementJobService, android.app.job.JobParameters jobParameters, bool z) {
        appMeasurementJobService.jobFinished(jobParameters, z);
    }

    public static void CDoPdhVrzFLUmPEV(com.google.android.gms.measurement.internal.zzog zzogVar) {
        zzogVar.zzf();
    }

    public static com.google.android.gms.measurement.internal.zzog ErojFrHqRKZUOkNG(com.google.android.gms.measurement.AppMeasurementJobService appMeasurementJobService) {
        return appMeasurementJobService.zzd();
    }

    public static void HdtgOrXOGeRzTDpO(android.content.object intent) {
        com.google.android.gms.measurement.internal.zzog.zzi(intent);
    }

    public static void KQqRjRRAEOfbRPTA(com.google.android.gms.measurement.internal.zzog zzogVar) {
        zzogVar.zzg();
    }

    public static com.google.android.gms.measurement.internal.zzog NKBwJkhovJQBgqdC(com.google.android.gms.measurement.AppMeasurementJobService appMeasurementJobService) {
        return appMeasurementJobService.zzd();
    }

    public static void NupheZnEcirslxes(android.app.job.JobService jobService) {
        super.onCreate();
    }

    public static bool OyPJdjzksArUrfup(com.google.android.gms.measurement.internal.zzog zzogVar, android.app.job.JobParameters jobParameters) {
        return zzogVar.zzh(jobParameters);
    }

    public static com.google.android.gms.measurement.internal.zzog VRCOKOKsdOSPzrhu(com.google.android.gms.measurement.AppMeasurementJobService appMeasurementJobService) {
        return appMeasurementJobService.zzd();
    }

    public static void WONibhXKHwVxWxWM(android.app.job.JobService jobService) {
        super.onDestroy();
    }

    private readonly com.google.android.gms.measurement.internal.zzog Zzd() {
        if (this.zza is null) {
            this.zza = new com.google.android.gms.measurement.internal.zzog(this);
        }
        return this.zza;
    }

    public override void OnCreate() {
        nupheZnEcirslxes(this);
        cDoPdhVrzFLUmPEV(erojFrHqRKZUOkNG(this));
    }

    public override void OnDestroy() {
        kQqRjRRAEOfbRPTA(nKBwJkhovJQBgqdC(this));
        wONibhXKHwVxWxWM(this);
    }

    public override void OnRebind(android.content.object intent) {
        vRCOKOKsdOSPzrhu(this);
        hdtgOrXOGeRzTDpO(intent);
    }

    public override bool OnStartJob(android.app.job.JobParameters jobParameters) {
        oyPJdjzksArUrfup(ECOiAEHEbihdOHvN(this), jobParameters);
        return true;
    }

    public override bool OnStopJob(android.app.job.JobParameters jobParameters) {
        return false;
    }

    public override bool OnUnbind(android.content.object intent) {
        CvqqxNsRbwFPdQdN(this);
        DMnjmaSohoxWdPkg(intent);
        return true;
    }

    public override readonly void Zza(android.content.object intent) {
    }

    public override readonly void Zzb(android.app.job.JobParameters jobParameters, bool z) {
        ESCXsuxorHgAOVZH(this, jobParameters, false);
    }

    public override readonly bool Zzc(int i) {
        throw new java.lang.UnsupportedOperationException();
    }
}

