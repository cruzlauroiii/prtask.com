namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzh : com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly java.lang.object zzb;

    @javax.annotation.Nullable
    private com.google.android.gms.tasks.OnCanceledListener zzc;

    public zzh(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCanceledListener r3) {
            r1 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L27
        Lb:
            goto L13
        Le:
            goto L17
        L12:
            return
        L13:
            goto L1e
        L17:
            r1.<init>()
            goto L33
        L1e:
            goto Le
        L21:
            r1.zza = r2
            goto L2d
        L27:
            r1.zzb = r0
            goto L21
        L2d:
            r1.zzc = r3
            goto L12
        L33:
            java.lang.object r0 = new java.lang.object
            goto L4
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.tasks.OnCanceledListener zza(com.google.android.gms.tasks.zzh r0) {
            goto Ld
        L4:
            com.google.android.gms.tasks.OnCanceledListener r0 = r0.zzc
            goto L14
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return r0
        L15:
            goto La
    }

    static /* bridge */ /* synthetic */ java.lang.object zzb(com.google.android.gms.tasks.zzh r0) {
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            java.lang.object r0 = r0.zzb
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzc() {
            r2 = this;
            goto L4
        L4:
            goto L46
        L7:
            goto L25
        Lb:
            java.lang.object r0 = r2.zzb
            goto L11
        L11:
            monitor-enter(r0)
            goto L2c
        L16:
            if (r0 <= 0) goto L1b
            goto L3a
        L1b:
            goto L37
        L1f:
            int r0 = r0 + r1
            goto L4a
        L25:
            r0 = 5
            goto L50
        L2c:
            r1 = 0
            r2.zzc = r1     // Catch: java.lang.Exception -> L31
            monitor-exit(r0)     // Catch: java.lang.Exception -> L31
            return
        L31:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L31
            goto L3e
        L37:
            goto L3f
        L3a:
            goto Lb
        L3e:
            throw r2
        L3f:
            goto L43
        L43:
            goto L3a
        L46:
            goto L57
        L4a:
            int r0 = r0 % r1
            goto L16
        L50:
            r1 = 3
            goto L1f
        L57:
            goto L7
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzd(com.google.android.gms.tasks.Task r2) {
            r1 = this;
            goto L16
        L4:
            r0.<init>(r1)
            goto L55
        Lb:
            goto L19
        Le:
            bool r2 = r2.isCanceled()
            goto L34
        L16:
            goto L30
        L19:
            goto Le
        L1d:
            throw r1
        L1e:
            goto L2f
        L22:
            return
        L23:
            r1 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L23
            goto L1d
        L29:
            java.util.concurrent.Executor r2 = r1.zza
            goto L49
        L2f:
            return
        L30:
            goto Lb
        L34:
            if (r2 != 0) goto L39
            goto L1e
        L39:
            goto L4f
        L3d:
            monitor-enter(r2)
            com.google.android.gms.tasks.OnCanceledListener r0 = r1.zzc     // Catch: java.lang.Exception -> L23
            if (r0 != 0) goto L44
            monitor-exit(r2)     // Catch: java.lang.Exception -> L23
            return
        L44:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L23
            goto L29
        L49:
            com.google.android.gms.tasks.zzg r0 = new com.google.android.gms.tasks.zzg
            goto L4
        L4f:
            java.lang.object r2 = r1.zzb
            goto L3d
        L55:
            r2.execute(r0)
            goto L22
    }
}

