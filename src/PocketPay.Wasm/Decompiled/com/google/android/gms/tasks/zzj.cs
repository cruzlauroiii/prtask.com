namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzj : com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly java.lang.object zzb;

    @javax.annotation.Nullable
    private com.google.android.gms.tasks.OnCompleteListener zzc;

    public zzj(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCompleteListener r3) {
            r1 = this;
            goto L4
        L4:
            goto L35
        L7:
            goto L11
        Lb:
            r1.zzc = r3
            goto L34
        L11:
            r1.<init>()
            goto L2e
        L18:
            r1.zzb = r0
            goto L21
        L1e:
            goto L7
        L21:
            r1.zza = r2
            goto Lb
        L27:
            r0.<init>()
            goto L18
        L2e:
            java.lang.object r0 = new java.lang.object
            goto L27
        L34:
            return
        L35:
            goto L1e
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.tasks.OnCompleteListener zza(com.google.android.gms.tasks.zzj r0) {
            goto L12
        L4:
            com.google.android.gms.tasks.OnCompleteListener r0 = r0.zzc
            goto Ld
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
    }

    static /* bridge */ /* synthetic */ java.lang.object zzb(com.google.android.gms.tasks.zzj r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            java.lang.object r0 = r0.zzb
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzc() {
            r2 = this;
            goto L10
        L4:
            throw r2
        L5:
            goto L9
        L9:
            goto L56
        Lc:
            goto L20
        L10:
            goto Lc
        L13:
            goto L40
        L17:
            if (r0 <= 0) goto L1c
            goto L56
        L1c:
            goto L53
        L20:
            goto L13
        L23:
            r1 = 0
            r2.zzc = r1     // Catch: java.lang.Exception -> L28
            monitor-exit(r0)     // Catch: java.lang.Exception -> L28
            return
        L28:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L28
            goto L4
        L2e:
            monitor-enter(r0)
            goto L23
        L33:
            r1 = 25
            goto L47
        L3a:
            int r0 = r0 % r1
            goto L17
        L40:
            r0 = 14
            goto L33
        L47:
            int r0 = r0 + r1
            goto L3a
        L4d:
            java.lang.object r0 = r2.zzb
            goto L2e
        L53:
            goto L5
        L56:
            goto L4d
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzd(com.google.android.gms.tasks.Task r3) {
            r2 = this;
            goto L64
        L4:
            java.util.concurrent.Executor r0 = r2.zza
            goto La
        La:
            com.google.android.gms.tasks.zzi r1 = new com.google.android.gms.tasks.zzi
            goto L51
        L10:
            r1 = 2
            goto L5e
        L17:
            goto L48
        L1a:
            goto L42
        L1e:
            int r0 = r0 % r1
            goto L39
        L24:
            r0 = 18
            goto L10
        L2b:
            r0.execute(r1)
            goto L32
        L32:
            return
        L33:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            goto L4c
        L39:
            if (r0 <= 0) goto L3e
            goto L48
        L3e:
            goto L45
        L42:
            goto L67
        L45:
            goto L4d
        L48:
            goto L58
        L4c:
            throw r2
        L4d:
            goto L17
        L51:
            r1.<init>(r2, r3)
            goto L2b
        L58:
            java.lang.object r0 = r2.zzb
            goto L6b
        L5e:
            int r0 = r0 + r1
            goto L1e
        L64:
            goto L1a
        L67:
            goto L24
        L6b:
            monitor-enter(r0)
            com.google.android.gms.tasks.OnCompleteListener r1 = r2.zzc     // Catch: java.lang.Exception -> L33
            if (r1 != 0) goto L72
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            return
        L72:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            goto L4
    }
}

