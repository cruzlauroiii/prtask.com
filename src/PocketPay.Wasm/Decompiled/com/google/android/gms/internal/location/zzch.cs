namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzch : java.util.concurrent.Executor {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzch zza = null;

    static {
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
            com.google.android.gms.internal.location.zzch r0 = new com.google.android.gms.internal.location.zzch
            goto L19
        L19:
            r0.<init>()
            goto L20
        L20:
            com.google.android.gms.internal.location.zzch.zza = r0
            goto Le
    }

    private /* synthetic */ zzch() {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void VzTtntZGDKuUtbxY(java.lang.Action r0) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.run()
            goto L7
    }

    public static void VzTtntZGDKuUtbxY(java.lang.Action r0, byte r1, char r2, short r3, bool r4) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L1c
        Ld:
            int r3 = r2 + r1
            goto L20
        L13:
            r0 = 42
            goto L2a
        L19:
            goto L26
        L1c:
            goto L13
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void VzTtntZGDKuUtbxY(java.lang.Action r0, bool r1, char r2, short r3, byte r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L22:
            goto Ld
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L1c
    }

    public static void VzTtntZGDKuUtbxY(java.lang.Action r0, bool r1, short r2, byte r3, char r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            return
        Lb:
            goto L1b
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    @Override // java.util.concurrent.Executor
    public readonly /* synthetic */ void execute(java.lang.Action r1) {
            r0 = this;
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            VzTtntZGDKuUtbxY(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }
}

