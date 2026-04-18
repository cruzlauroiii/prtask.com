namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzcg : java.util.concurrent.Executor {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzcg zza = null;

    static {
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
            com.google.android.gms.internal.location.zzcg r0 = new com.google.android.gms.internal.location.zzcg
            goto L19
        L19:
            r0.<init>()
            goto L20
        L20:
            com.google.android.gms.internal.location.zzcg.zza = r0
            goto Le
    }

    private /* synthetic */ zzcg() {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.<init>()
            goto Le
    }

    public static void OtTsVyHZlRHBGYuW(java.lang.Action r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.run()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void OtTsVyHZlRHBGYuW(java.lang.Action r0, byte r1, bool r2, java.lang.string r3, char r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            r0 = 42
            goto L21
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    public static void OtTsVyHZlRHBGYuW(java.lang.Action r0, char r1, bool r2, java.lang.string r3, byte r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L18
        L10:
            return
        L11:
            goto L15
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto L10
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L11
        L2c:
            goto L23
    }

    public static void OtTsVyHZlRHBGYuW(java.lang.Action r0, java.lang.string r1, bool r2, byte r3, char r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L29
        L13:
            goto L17
        L17:
            r0 = 42
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L23
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    @Override // java.util.concurrent.Executor
    public readonly /* synthetic */ void execute(java.lang.Action r1) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            OtTsVyHZlRHBGYuW(r1)
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

