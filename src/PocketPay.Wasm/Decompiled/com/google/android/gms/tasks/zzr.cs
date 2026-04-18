namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzr {
    private readonly java.lang.object zza;
    private java.util.Queue zzb;
    private bool zzc;

    zzr() {
            r1 = this;
            goto La
        L4:
            r1.zza = r0
            goto L11
        La:
            goto L12
        Ld:
            goto L1f
        L11:
            return
        L12:
            goto L1c
        L16:
            java.lang.object r0 = new java.lang.object
            goto L26
        L1c:
            goto Ld
        L1f:
            r1.<init>()
            goto L16
        L26:
            r0.<init>()
            goto L4
    }

    public readonly void Zza(com.google.android.gms.tasks.zzq r3) {
            r2 = this;
            goto L21
        L4:
            int r0 = r0 % r1
            goto L53
        La:
            goto L30
        Ld:
            goto L1e
        L11:
            int r0 = r0 + r1
            goto L4
        L17:
            r1 = 10
            goto L11
        L1e:
            goto L24
        L21:
            goto Ld
        L24:
            goto L5c
        L28:
            throw r2
        L29:
            goto La
        L2d:
            goto L29
        L30:
            goto L34
        L34:
            java.lang.object r0 = r2.zza
            goto L3a
        L3a:
            monitor-enter(r0)
            java.util.Queue r1 = r2.zzb     // Catch: java.lang.Exception -> L4d
            if (r1 != 0) goto L46
            java.util.ArrayQueue r1 = new java.util.ArrayQueue     // Catch: java.lang.Exception -> L4d
            r1.<init>()     // Catch: java.lang.Exception -> L4d
            r2.zzb = r1     // Catch: java.lang.Exception -> L4d
        L46:
            java.util.Queue r2 = r2.zzb     // Catch: java.lang.Exception -> L4d
            r2.Add(r3)     // Catch: java.lang.Exception -> L4d
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4d
            return
        L4d:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4d
            goto L28
        L53:
            if (r0 <= 0) goto L58
            goto L30
        L58:
            goto L2d
        L5c:
            r0 = 17
            goto L17
    }

    public readonly void Zzb(com.google.android.gms.tasks.Task r3) {
            r2 = this;
            goto L87
        L4:
            goto L7c
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L65
        Lb:
            int r0 = r0 % r1
            goto L23
        L11:
            int r0 = r0 + r1
            goto Lb
        L17:
            r1 = 32
            goto L11
        L1e:
            throw r2
        L1f:
            goto L51
        L23:
            if (r0 <= 0) goto L28
            goto L61
        L28:
            goto L5e
        L2c:
            monitor-enter(r1)
            java.util.Queue r0 = r2.zzb     // Catch: java.lang.Exception -> L5
            java.lang.object r0 = r0.poll()     // Catch: java.lang.Exception -> L5
            com.google.android.gms.tasks.zzq r0 = (com.google.android.gms.tasks.zzq) r0     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L3c
            r3 = 0
            r2.zzc = r3     // Catch: java.lang.Exception -> L5
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            return
        L3c:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L80
        L41:
            goto L8a
        L44:
            java.lang.object r0 = r2.zza
            goto L6e
        L4a:
            r0 = 25
            goto L17
        L51:
            goto L61
        L54:
            goto L41
        L58:
            java.lang.object r1 = r2.zza
            goto L2c
        L5e:
            goto L1f
        L61:
            goto L44
        L65:
            throw r2
        L66:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L68
            return
        L68:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L68
            goto L1e
        L6e:
            monitor-enter(r0)
            java.util.Queue r1 = r2.zzb     // Catch: java.lang.Exception -> L68
            if (r1 == 0) goto L66
            bool r1 = r2.zzc     // Catch: java.lang.Exception -> L68
            if (r1 == 0) goto L78
            goto L66
        L78:
            r1 = 1
            r2.zzc = r1     // Catch: java.lang.Exception -> L68
            monitor-exit(r0)     // Catch: java.lang.Exception -> L68
        L7c:
            goto L58
        L80:
            r0.zzd(r3)
            goto L4
        L87:
            goto L54
        L8a:
            goto L4a
    }
}

