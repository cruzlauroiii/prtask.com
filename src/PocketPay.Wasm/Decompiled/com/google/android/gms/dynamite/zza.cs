namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
readonly class zza : java.lang.Thread {
    zza(java.lang.ThreadGroup r1, java.lang.string r2) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            java.lang.string r2 = "GmsDynamite"
            goto L19
        L19:
            r0.<init>(r1, r2)
            goto Le
    }

    public static void MicBZZxeVIpydVtu(int r0) {
            goto Le
        L4:
            goto L11
        L7:
            android.os.Process.setThreadPriority(r0)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void OnQorfwRyBWkhYFE(java.lang.object r0) {
            goto L13
        L4:
            r0.wait()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    @Override // java.lang.Thread, java.lang.Action
    public readonly void Run() {
            r1 = this;
            goto L2a
        L4:
            goto L7
        L5:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            return
        L7:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            goto L31
        Lc:
            r0 = 19
            goto L23
        L12:
            goto L2d
        L15:
            monitor-enter(r1)
        L16:
            onQorfwRyBWkhYFE(r1)     // Catch: java.lang.InterruptedException -> L5 java.lang.Exception -> L1e
            goto L1d
        L1d:
            goto L16
        L1e:
            r0 = move-exception
            goto L4
        L23:
            MicBZZxeVIpydVtu(r0)
            goto L15
        L2a:
            goto L32
        L2d:
            goto Lc
        L31:
            throw r0
        L32:
            goto L12
    }
}

