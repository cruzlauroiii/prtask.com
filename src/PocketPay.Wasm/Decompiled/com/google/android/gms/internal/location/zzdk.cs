namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdk : com.google.android.gms.internal.location.zzy {
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zza;

    zzdk(com.google.android.gms.tasks.TaskCompletionSource r1) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0.zza = r1
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            r0.<init>()
            goto L11
    }

    public static void VcwyHPhdJjLHtadp(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(r0, r1, r2)
            goto L4
    }

    public static void VcwyHPhdJjLHtadp(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, int r3, char r4, java.lang.string r5, float r6) {
            goto L26
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L20
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            return
        L17:
            goto L2d
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            int r3 = r2 + r1
            goto L1b
        L26:
            goto L17
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static void VcwyHPhdJjLHtadp(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, java.lang.string r3, float r4, int r5, char r6) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L14
        Lb:
            int r3 = r2 + r1
            goto L1f
        L11:
            goto L7
        L14:
            r0 = 42
            goto L24
        L1a:
            return
        L1b:
            goto L11
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static void VcwyHPhdJjLHtadp(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, java.lang.string r3, int r4, char r5, float r6) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L1a
        L11:
            goto L7
        L14:
            int r2 = r0 * r1
            goto Lb
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L25:
            return
        L26:
            goto L11
        L2a:
            r0 = 42
            goto L1f
    }

    @Override // com.google.android.gms.internal.location.zzz
    public readonly void Zzb(com.google.android.gms.common.api.Status r1, android.location.Location r2) {
            r0 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto L15
        Lb:
            goto L7
        Le:
            VcwyHPhdJjLHtadp(r1, r2, r0)
            goto L1b
        L15:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r0.zza
            goto Le
        L1b:
            return
        L1c:
            goto Lb
    }
}

