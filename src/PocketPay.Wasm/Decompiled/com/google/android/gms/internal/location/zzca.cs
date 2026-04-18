namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzca : com.google.android.gms.common.api.internal.RemoteCall {
    static readonly /* synthetic */ com.google.android.gms.internal.location.zzca zza = null;

    static {
            goto L18
        L4:
            return
        L5:
            goto Lf
        L9:
            com.google.android.gms.internal.location.zzca.zza = r0
            goto L4
        Lf:
            goto L1b
        L12:
            com.google.android.gms.internal.location.zzca r0 = new com.google.android.gms.internal.location.zzca
            goto L1f
        L18:
            goto L5
        L1b:
            goto L12
        L1f:
            r0.<init>()
            goto L9
    }

    private /* synthetic */ zzca() {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.<init>()
            goto L4
    }

    public static void UFBWHAvixqxObuGi(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1) {
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
            r0.zzB(r1)
            goto Le
    }

    public static void UFBWHAvixqxObuGi(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.string r2, short r3, int r4, bool r5) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L16
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            goto L27
        L1f:
            return
        L20:
            goto L1c
        L24:
            goto L20
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void UFBWHAvixqxObuGi(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1, short r2, bool r3, java.lang.string r4, int r5) {
            goto L18
        L4:
            r0 = 42
            goto L1f
        La:
            goto L1b
        Ld:
            int r2 = r0 * r1
            goto L25
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            goto L2c
        L1b:
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L25:
            int r3 = r2 + r1
            goto L13
        L2b:
            return
        L2c:
            goto La
    }

    public static void UFBWHAvixqxObuGi(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.tasks.TaskCompletionSource r1, bool r2, java.lang.string r3, short r4, int r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            goto Lc
        L25:
            r0 = 42
            goto L10
        L2b:
            return
        L2c:
            goto L22
    }

    @Override // com.google.android.gms.common.api.internal.RemoteCall
    public readonly /* synthetic */ void accept(java.lang.object r1, java.lang.object r2) {
            r0 = this;
            goto L1f
        L4:
            com.google.android.gms.tasks.TaskCompletionSource r2 = (com.google.android.gms.tasks.TaskCompletionSource) r2
            goto L19
        La:
            UFBWHAvixqxObuGi(r1, r2)
            goto L14
        L11:
            goto L22
        L14:
            return
        L15:
            goto L11
        L19:
            com.google.android.gms.internal.location.zzdz r1 = (com.google.android.gms.internal.location.zzdz) r1
            goto La
        L1f:
            goto L15
        L22:
            goto L4
    }
}

