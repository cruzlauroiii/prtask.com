namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzcm : java.util.concurrent.Executor {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzcm zza = null;

    static {
            goto La
        L4:
            com.google.android.gms.internal.location.zzcm r0 = new com.google.android.gms.internal.location.zzcm
            goto L11
        La:
            goto L22
        Ld:
            goto L4
        L11:
            r0.<init>()
            goto L1b
        L18:
            goto Ld
        L1b:
            com.google.android.gms.internal.location.zzcm.zza = r0
            goto L21
        L21:
            return
        L22:
            goto L18
    }

    private /* synthetic */ zzcm() {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.<init>()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void RSryFxhQiEQPkQIN(java.lang.Action r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.run()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void RSryFxhQiEQPkQIN(java.lang.Action r0, char r1, float r2, java.lang.string r3, short r4) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            int r2 = r0 * r1
            goto L12
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void RSryFxhQiEQPkQIN(java.lang.Action r0, char r1, java.lang.string r2, float r3, short r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            goto L1d
        Ld:
            goto L27
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            r0 = 42
            goto L11
        L2d:
            goto Ld
    }

    public static void RSryFxhQiEQPkQIN(java.lang.Action r0, java.lang.string r1, short r2, char r3, float r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            goto L29
        Ld:
            goto L1d
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            r0 = 42
            goto L17
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    @Override // java.util.concurrent.Executor
    public readonly /* synthetic */ void execute(java.lang.Action r1) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            RSryFxhQiEQPkQIN(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }
}

