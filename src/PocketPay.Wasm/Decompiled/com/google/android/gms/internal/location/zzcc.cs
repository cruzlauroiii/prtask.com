namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzcc : com.google.android.gms.common.api.internal.RemoteCall {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzcc zza = null;

    static {
            goto L16
        L4:
            com.google.android.gms.internal.location.zzcc.zza = r0
            goto La
        La:
            return
        Lb:
            goto L23
        Lf:
            r0.<init>()
            goto L4
        L16:
            goto Lb
        L19:
            goto L1d
        L1d:
            com.google.android.gms.internal.location.zzcc r0 = new com.google.android.gms.internal.location.zzcc
            goto Lf
        L23:
            goto L19
    }

    private /* synthetic */ zzcc() {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            r0.<init>()
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

    public static void TcMGTslZdsIufElx(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1) {
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
            r0.zzz(r1)
            goto Le
    }

    public static void TcMGTslZdsIufElx(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1, float r2, java.lang.string r3, int r4, short r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L27
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L4
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto Le
        L27:
            goto L12
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void TcMGTslZdsIufElx(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1, int r2, java.lang.string r3, short r4, float r5) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L2a
        Le:
            return
        Lf:
            goto L4
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L1f:
            double r0 = (double) r3
            goto Le
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L19
    }

    public static void TcMGTslZdsIufElx(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.string r2, short r3, int r4, float r5) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            r0 = 42
            goto L12
        Lf:
            goto L20
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L9
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    @Override // com.google.android.gms.common.api.internal.RemoteCall
    public readonly /* synthetic */ void accept(java.lang.object r1, java.lang.object r2) {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto L1a
        Lb:
            TcMGTslZdsIufElx(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
        L1a:
            com.google.android.gms.tasks.TaskCompletionSource r2 = (com.google.android.gms.tasks.TaskCompletionSource) r2
            goto L20
        L20:
            com.google.android.gms.internal.location.zzdz r1 = (com.google.android.gms.internal.location.zzdz) r1
            goto Lb
    }
}

