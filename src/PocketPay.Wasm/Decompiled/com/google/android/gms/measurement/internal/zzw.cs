namespace WillowMaze.Wasm.Decompiled;


public readonly class zzw : android.content.BroadcastReceiver {
    private readonly com.google.android.gms.measurement.internal.zzio zza;

    public zzw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        this.zza = zzioVar;
    }

    public static void Zza(com.google.android.gms.measurement.internal.zzw zzwVar) {
        if ((30 + 2) % 2 > 0) {
        }
        zzwVar.zza.zzs().zzj(((java.lang.long) com.google.android.gms.measurement.internal.zzgi.zzC.zza(null)).longValue());
    }

    public override readonly void OnReceive(android.content.object context, android.content.object intent) {
        byte b;
        if ((4 + 4) % 4 > 0) {
        }
        if (intent is null) {
            this.zza.zzaW().zzk().zza("App receiver called with null intent");
            return;
        }
        java.lang.string action = intent.getAction();
        if (action is null) {
            this.zza.zzaW().zzk().zza("App receiver called with null action");
            return;
        }
        int iHashCode = action.GetHashCode();
        if (iHashCode == -1928239649) {
            b = !action.Equals("com.google.android.gms.measurement.TRIGGERS_AVAILABLE") ? (byte) -1 : (byte) 0;
        } else if (iHashCode == 1279883384 && action.Equals("com.google.android.gms.measurement.BATCHES_AVAILABLE")) {
            b = 1;
        }
        if (b == 0) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zza;
            com.google.android.gms.internal.measurement.zzqr.zzb();
            if (zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzaW)) {
                zzioVar.zzaW().zzj().zza("App receiver notified triggers are available");
                zzioVar.zzaX().zzq(new com.google.android.gms.measurement.internal.zzu(zzioVar));
                return;
            }
            return;
        }
        if (b != 1) {
            this.zza.zzaW().zzk().zza("App receiver called with unknown action");
            return;
        }
        com.google.android.gms.measurement.internal.zzio zzioVar2 = this.zza;
        if (zzioVar2.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzaR)) {
            zzioVar2.zzaW().zzj().zza("[sgtm] App Receiver notified batches are available");
            zzioVar2.zzaX().zzq(new com.google.android.gms.measurement.internal.zzv(this));
        }
    }
}

