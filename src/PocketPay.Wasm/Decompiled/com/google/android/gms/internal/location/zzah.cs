namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzah : com.google.android.gms.common.api.internal.IStatusCallback.Stub {
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zza;

    zzah(com.google.android.gms.internal.location.zzaj r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
            r0 = this;
            goto L10
        L4:
            r0.<init>()
            goto Lb
        Lb:
            return
        Lc:
            goto L1d
        L10:
            goto Lc
        L13:
            goto L17
        L17:
            r0.zza = r2
            goto L4
        L1d:
            goto L13
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto Lb
        L4:
            com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(r0, r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.string r2, float r3, bool r4, int r5) {
            goto L15
        L4:
            r0 = 42
            goto L1c
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            goto Lb
        L18:
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L18
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1, bool r2, float r3, java.lang.string r4, int r5) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto L20
        Ld:
            r0 = 42
            goto L1a
        L13:
            goto L2c
        L16:
            goto Ld
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void DquCwgPnuOZaaWTb(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1, bool r2, java.lang.string r3, int r4, float r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            goto L18
        Ld:
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L25
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            int r2 = r0 * r1
            goto L11
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            r0 = 42
            goto L4
    }

    @Override // com.google.android.gms.common.api.internal.IStatusCallback
    public readonly void OnResult(com.google.android.gms.common.api.Status r1) {
            r0 = this;
            goto L4
        L4:
            goto L19
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r0.zza
            goto L11
        L11:
            DquCwgPnuOZaaWTb(r1, r0)
            goto L18
        L18:
            return
        L19:
            goto L1d
        L1d:
            goto L7
    }
}

