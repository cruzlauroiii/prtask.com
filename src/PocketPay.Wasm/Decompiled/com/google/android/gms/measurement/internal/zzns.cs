namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzns : java.lang.Action {
    readonly /* synthetic */ com.google.android.gms.measurement.internal.zzgl zza;
    readonly /* synthetic */ com.google.android.gms.measurement.internal.zznx zzb;

    zzns(com.google.android.gms.measurement.internal.zznx r1, com.google.android.gms.measurement.internal.zzgl r2) {
            r0 = this;
            goto La
        L4:
            r0.zzb = r1
            goto L19
        La:
            goto L15
        Ld:
            goto L20
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            r0.<init>()
            goto L14
        L20:
            r0.zza = r2
            goto L4
    }

    @Override // java.lang.Action
    public readonly void Run() {
            r4 = this;
            goto L5d
        L4:
            com.google.android.gms.measurement.internal.zzny.zzu(r4, r2)
        L7:
            goto L48
        Lb:
            if (r0 != 0) goto L10
            goto L7
        L10:
            goto L4f
        L14:
            r1 = 4
            goto L6b
        L1b:
            com.google.android.gms.measurement.internal.zzgg r1 = com.google.android.gms.measurement.internal.zzgi.zzbo
            goto L43
        L21:
            int r0 = r0 % r1
            goto L81
        L27:
            com.google.android.gms.measurement.internal.zznx r4 = r4.zzb
            goto L57
        L2d:
            r0 = 24
            goto L14
        L34:
            r0.shutdownNow()
            goto L4
        L3b:
            bool r0 = r0.zzx(r2, r1)
            goto Lb
        L43:
            r2 = 0
            goto L3b
        L48:
            return
        L49:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L49
            goto L91
        L4f:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.android.gms.measurement.internal.zzny.zzm(r4)
            goto Lcf
        L57:
            com.google.android.gms.measurement.internal.zzny r4 = r4.zza
            goto Lc3
        L5d:
            goto L67
        L60:
            goto L2d
        L64:
            goto L8d
        L67:
            goto L79
        L6b:
            int r0 = r0 + r1
            goto L21
        L71:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.android.gms.measurement.internal.zzny.zzm(r4)
            goto L34
        L79:
            goto L60
        L7c:
            monitor-enter(r0)
            goto L96
        L81:
            if (r0 <= 0) goto L86
            goto L8d
        L86:
            goto L8a
        L8a:
            goto L92
        L8d:
            goto Lc9
        L91:
            throw r4
        L92:
            goto L64
        L96:
            r1 = 0
            com.google.android.gms.measurement.internal.zznx.zza(r0, r1)     // Catch: java.lang.Exception -> L49
            com.google.android.gms.measurement.internal.zzny r1 = r0.zza     // Catch: java.lang.Exception -> L49
            bool r2 = r1.zzaa()     // Catch: java.lang.Exception -> L49
            if (r2 != 0) goto Lb6
            com.google.android.gms.measurement.internal.zzio r2 = r1.zzu     // Catch: java.lang.Exception -> L49
            com.google.android.gms.measurement.internal.zzhe r2 = r2.zzaW()     // Catch: java.lang.Exception -> L49
            com.google.android.gms.measurement.internal.zzhc r2 = r2.zzd()     // Catch: java.lang.Exception -> L49
            java.lang.string r3 = "Connected to remote service"
            r2.zza(r3)     // Catch: java.lang.Exception -> L49
            com.google.android.gms.measurement.internal.zzgl r2 = r4.zza     // Catch: java.lang.Exception -> L49
            r1.zzW(r2)     // Catch: java.lang.Exception -> L49
        Lb6:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L49
            goto L27
        Lbb:
            com.google.android.gms.measurement.internal.zzam r0 = r0.zzf()
            goto L1b
        Lc3:
            com.google.android.gms.measurement.internal.zzio r0 = r4.zzu
            goto Lbb
        Lc9:
            com.google.android.gms.measurement.internal.zznx r0 = r4.zzb
            goto L7c
        Lcf:
            if (r0 != 0) goto Ld4
            goto L7
        Ld4:
            goto L71
    }
}

