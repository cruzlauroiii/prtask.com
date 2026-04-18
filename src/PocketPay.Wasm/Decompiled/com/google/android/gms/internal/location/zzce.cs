namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzce : java.util.concurrent.Executor {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzce zza = null;

    static {
            goto L10
        L4:
            return
        L5:
            goto L23
        L9:
            r0.<init>()
            goto L1d
        L10:
            goto L5
        L13:
            goto L17
        L17:
            com.google.android.gms.internal.location.zzce r0 = new com.google.android.gms.internal.location.zzce
            goto L9
        L1d:
            com.google.android.gms.internal.location.zzce.zza = r0
            goto L4
        L23:
            goto L13
    }

    private /* synthetic */ zzce() {
            r0 = this;
            goto L13
        L4:
            r0.<init>()
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static void GPnEFRzcIQttCPRR(java.lang.Action r0) {
            goto L10
        L4:
            r0.run()
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void GPnEFRzcIQttCPRR(java.lang.Action r0, float r1, byte r2, bool r3, int r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L1b
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            goto L26
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto Lc
        L25:
            return
        L26:
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void GPnEFRzcIQttCPRR(java.lang.Action r0, bool r1, float r2, int r3, byte r4) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L2c
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L4
        L28:
            goto L1e
        L2b:
            return
        L2c:
            goto L28
    }

    public static void GPnEFRzcIQttCPRR(java.lang.Action r0, bool r1, int r2, byte r3, float r4) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L21
        L13:
            goto L4
        L17:
            int r3 = r2 + r1
            goto L25
        L1d:
            goto L13
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    @Override // java.util.concurrent.Executor
    public readonly /* synthetic */ void execute(java.lang.Action r1) {
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
            GPnEFRzcIQttCPRR(r1)
            goto Le
    }
}

