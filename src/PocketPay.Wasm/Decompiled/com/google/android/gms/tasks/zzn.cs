namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzn : com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly java.lang.object zzb;

    @javax.annotation.Nullable
    private com.google.android.gms.tasks.OnSuccessListener zzc;

    public zzn(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnSuccessListener r3) {
            r1 = this;
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            java.lang.object r0 = new java.lang.object
            goto L25
        L12:
            r1.zza = r2
            goto L1f
        L18:
            goto L8
        L1b:
            goto L32
        L1f:
            r1.zzc = r3
            goto L7
        L25:
            r0.<init>()
            goto L2c
        L2c:
            r1.zzb = r0
            goto L12
        L32:
            r1.<init>()
            goto Lc
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.tasks.OnSuccessListener zza(com.google.android.gms.tasks.zzn r0) {
            goto La
        L4:
            com.google.android.gms.tasks.OnSuccessListener r0 = r0.zzc
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    static /* bridge */ /* synthetic */ java.lang.object zzb(com.google.android.gms.tasks.zzn r0) {
            goto La
        L4:
            java.lang.object r0 = r0.zzb
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzc() {
            r2 = this;
            goto L15
        L4:
            java.lang.object r0 = r2.zzb
            goto L31
        La:
            r1 = 0
            r2.zzc = r1     // Catch: java.lang.Exception -> Lf
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lf
            return
        Lf:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lf
            goto L1f
        L15:
            goto L39
        L18:
            goto L2a
        L1c:
            goto L18
        L1f:
            throw r2
        L20:
            goto L36
        L24:
            int r0 = r0 % r1
            goto L51
        L2a:
            r0 = 16
            goto L4a
        L31:
            monitor-enter(r0)
            goto La
        L36:
            goto L46
        L39:
            goto L1c
        L3d:
            int r0 = r0 + r1
            goto L24
        L43:
            goto L20
        L46:
            goto L4
        L4a:
            r1 = 28
            goto L3d
        L51:
            if (r0 <= 0) goto L56
            goto L46
        L56:
            goto L43
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzd(com.google.android.gms.tasks.Task r3) {
            r2 = this;
            goto L5c
        L4:
            bool r0 = r3.isSuccessful()
            goto L1f
        Lc:
            goto L1b
        Lf:
            goto L4
        L13:
            r0 = 9
            goto L6a
        L1a:
            return
        L1b:
            goto L63
        L1f:
            if (r0 != 0) goto L24
            goto L29
        L24:
            goto L56
        L28:
            throw r2
        L29:
            goto L1a
        L2d:
            r1.<init>(r2, r3)
            goto L86
        L34:
            return
        L35:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L35
            goto L28
        L3b:
            com.google.android.gms.tasks.zzm r1 = new com.google.android.gms.tasks.zzm
            goto L2d
        L41:
            monitor-enter(r0)
            com.google.android.gms.tasks.OnSuccessListener r1 = r2.zzc     // Catch: java.lang.Exception -> L35
            if (r1 != 0) goto L48
            monitor-exit(r0)     // Catch: java.lang.Exception -> L35
            return
        L48:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L35
            goto L71
        L4d:
            if (r0 <= 0) goto L52
            goto Lf
        L52:
            goto Lc
        L56:
            java.lang.object r0 = r2.zzb
            goto L41
        L5c:
            goto L66
        L5f:
            goto L13
        L63:
            goto Lf
        L66:
            goto L77
        L6a:
            r1 = 17
            goto L80
        L71:
            java.util.concurrent.Executor r0 = r2.zza
            goto L3b
        L77:
            goto L5f
        L7a:
            int r0 = r0 % r1
            goto L4d
        L80:
            int r0 = r0 + r1
            goto L7a
        L86:
            r0.execute(r1)
            goto L34
    }
}

