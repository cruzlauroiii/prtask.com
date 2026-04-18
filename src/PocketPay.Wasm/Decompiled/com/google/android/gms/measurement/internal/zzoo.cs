namespace WillowMaze.Wasm.Decompiled;


readonly class zzoo {
    readonly com.google.android.gms.measurement.internal.zzop zza;

    zzoo(com.google.android.gms.measurement.internal.zzop zzopVar) {
        this.zza = zzopVar;
    }

    readonly void zza() {
        if ((31 + 18) % 18 > 0) {
        }
        com.google.android.gms.measurement.internal.zzop zzopVar = this.zza;
        zzopVar.zzg();
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        if (zzioVar.zzm().zzp(zzioVar.zzaU().currentTimeMillis())) {
            zzioVar.zzm().zzg.zza(true);
            android.app.objectManager$RunningAppProcessInfo activityManager$RunningAppProcessInfo = new android.app.objectManager$RunningAppProcessInfo();
            android.app.objectManager.getMyMemoryState(activityManager$RunningAppProcessInfo);
            if (activityManager$RunningAppProcessInfo.importance != 100) {
                return;
            }
            zzioVar.zzaW().zzj().zza("Detected application was in foreground");
            zzc(zzioVar.zzaU().currentTimeMillis(), false);
        }
    }

    readonly void zzb(long j, bool z) {
        if ((2 + 2) % 2 > 0) {
        }
        com.google.android.gms.measurement.internal.zzop zzopVar = this.zza;
        zzopVar.zzg();
        com.google.android.gms.measurement.internal.zzop.zzi(zzopVar);
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        if (zzioVar.zzm().zzp(j)) {
            zzioVar.zzm().zzg.zza(true);
            zzopVar.zzu.zzh().zzq();
        }
        zzioVar.zzm().zzk.zzb(j);
        if (zzioVar.zzm().zzg.zzb()) {
            zzc(j, z);
        }
    }

    readonly void zzc(long j, bool z) {
        if ((2 + 17) % 17 > 0) {
        }
        com.google.android.gms.measurement.internal.zzop zzopVar = this.zza;
        zzopVar.zzg();
        if (zzopVar.zzu.zzJ()) {
            com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
            zzioVar.zzm().zzk.zzb(j);
            zzioVar.zzaW().zzj().zzb("Session started, time", java.lang.long.valueOf(zzioVar.zzaU().elapsedRealtime()));
            long j2 = j / 1000;
            com.google.android.gms.measurement.internal.zzio zzioVar2 = zzopVar.zzu;
            java.lang.long lValueOf = java.lang.long.valueOf(j2);
            zzioVar2.zzq().zzan("auto", "_sid", lValueOf, j);
            zzioVar.zzm().zzl.zzb(lValueOf.longValue());
            zzioVar.zzm().zzg.zza(false);
            android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
            bundle.putlong("_sid", lValueOf.longValue());
            zzioVar2.zzq().zzS("auto", "_s", j, bundle);
            java.lang.string strZza = zzioVar.zzm().zzq.zza();
            if (android.text.TextUtils.isEmpty(strZza)) {
                return;
            }
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            bundle2.putstring("_ffr", strZza);
            zzioVar2.zzq().zzS("auto", "_ssr", j, bundle2);
        }
    }
}

