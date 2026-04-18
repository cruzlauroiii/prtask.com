namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzl : com.google.android.gms.tasks.zzq {
    private readonly java.util.concurrent.Executor zza;
    private readonly java.lang.object zzb;

    @javax.annotation.Nullable
    private com.google.android.gms.tasks.OnFailureListener zzc;

    public zzl(java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnFailureListener r3) {
            r1 = this;
            goto L25
        L4:
            r1.zzb = r0
            goto L2c
        La:
            goto L28
        Ld:
            java.lang.object r0 = new java.lang.object
            goto L19
        L13:
            r1.zzc = r3
            goto L20
        L19:
            r0.<init>()
            goto L4
        L20:
            return
        L21:
            goto La
        L25:
            goto L21
        L28:
            goto L32
        L2c:
            r1.zza = r2
            goto L13
        L32:
            r1.<init>()
            goto Ld
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.tasks.OnFailureListener zza(com.google.android.gms.tasks.zzl r0) {
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            com.google.android.gms.tasks.OnFailureListener r0 = r0.zzc
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    static /* bridge */ /* synthetic */ java.lang.object zzb(com.google.android.gms.tasks.zzl r0) {
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
            goto L43
        L4:
            r1 = 10
            goto L3a
        Lb:
            goto L1e
        Le:
            goto L40
        L12:
            if (r0 <= 0) goto L17
            goto L1e
        L17:
            goto L1b
        L1b:
            goto L2a
        L1e:
            goto L2e
        L22:
            r0 = 32
            goto L4
        L29:
            throw r2
        L2a:
            goto Lb
        L2e:
            java.lang.object r0 = r2.zzb
            goto L55
        L34:
            int r0 = r0 % r1
            goto L12
        L3a:
            int r0 = r0 + r1
            goto L34
        L40:
            goto L46
        L43:
            goto Le
        L46:
            goto L22
        L4a:
            r1 = 0
            r2.zzc = r1     // Catch: java.lang.Exception -> L4f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4f
            return
        L4f:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4f
            goto L29
        L55:
            monitor-enter(r0)
            goto L4a
    }

    @Override // com.google.android.gms.tasks.zzq
    public readonly void Zzd(com.google.android.gms.tasks.Task r3) {
            r2 = this;
            goto L37
        L4:
            java.util.concurrent.Executor r0 = r2.zza
            goto L75
        La:
            r0.execute(r1)
            goto L1d
        L11:
            int r0 = r0 % r1
            goto L57
        L17:
            int r0 = r0 + r1
            goto L11
        L1d:
            return
        L1e:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            goto L24
        L24:
            throw r2
        L25:
            goto L86
        L29:
            r1.<init>(r2, r3)
            goto La
        L30:
            goto L87
        L33:
            goto L7b
        L37:
            goto L9a
        L3a:
            goto L50
        L3e:
            if (r0 == 0) goto L43
            goto L25
        L43:
            goto L6f
        L47:
            if (r0 == 0) goto L4c
            goto L25
        L4c:
            goto L60
        L50:
            r0 = 2
            goto L68
        L57:
            if (r0 <= 0) goto L5c
            goto L33
        L5c:
            goto L30
        L60:
            bool r0 = r3.isCanceled()
            goto L3e
        L68:
            r1 = 25
            goto L17
        L6f:
            java.lang.object r0 = r2.zzb
            goto L8b
        L75:
            com.google.android.gms.tasks.zzk r1 = new com.google.android.gms.tasks.zzk
            goto L29
        L7b:
            bool r0 = r3.isSuccessful()
            goto L47
        L83:
            goto L3a
        L86:
            return
        L87:
            goto L97
        L8b:
            monitor-enter(r0)
            com.google.android.gms.tasks.OnFailureListener r1 = r2.zzc     // Catch: java.lang.Exception -> L1e
            if (r1 != 0) goto L92
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            return
        L92:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            goto L4
        L97:
            goto L33
        L9a:
            goto L83
    }
}

