namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzcf : java.util.concurrent.Executor {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzcf zza = null;

    static {
            goto Lb
        L4:
            r0.<init>()
            goto L17
        Lb:
            goto L13
        Le:
            goto L20
        L12:
            return
        L13:
            goto L1d
        L17:
            com.google.android.gms.internal.location.zzcf.zza = r0
            goto L12
        L1d:
            goto Le
        L20:
            com.google.android.gms.internal.location.zzcf r0 = new com.google.android.gms.internal.location.zzcf
            goto L4
    }

    private /* synthetic */ zzcf() {
            r0 = this;
            goto Le
        L4:
            r0.<init>()
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void WVvlOFASDGVTCXFy(java.lang.Action r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.run()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void WVvlOFASDGVTCXFy(java.lang.Action r0, byte r1, java.lang.string r2, short r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            int r2 = r0 * r1
            goto L16
        Lf:
            goto L5
        L12:
            goto L1f
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            goto L12
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void WVvlOFASDGVTCXFy(java.lang.Action r0, byte r1, short r2, java.lang.string r3, bool r4) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L21
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L10
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto La
        L2d:
            goto L29
    }

    public static void WVvlOFASDGVTCXFy(java.lang.Action r0, short r1, byte r2, java.lang.string r3, bool r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            r0 = 42
            goto L2a
        L16:
            goto L26
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L16
        L23:
            goto L1f
        L26:
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    @Override // java.util.concurrent.Executor
    public readonly /* synthetic */ void execute(java.lang.Action r1) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            wVvlOFASDGVTCXFy(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }
}

