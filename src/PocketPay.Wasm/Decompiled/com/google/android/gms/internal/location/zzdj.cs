namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdj : com.google.android.gms.common.api.internal.IStatusCallback.Stub {
    readonly /* synthetic */ java.lang.object zza;
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zzb;

    zzdj(java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
            r0 = this;
            goto L19
        L4:
            r0.<init>()
            goto Le
        Lb:
            goto L1c
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.zza = r1
            goto L20
        L19:
            goto Lf
        L1c:
            goto L13
        L20:
            r0.zzb = r2
            goto L4
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
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
            com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(r0, r1, r2)
            goto Le
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, byte r3, char r4, bool r5, float r6) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L16
        L16:
            r0 = 42
            goto L24
        L1c:
            goto L12
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, float r3, char r4, byte r5, bool r6) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L26
        L14:
            r0 = 42
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto La
        L26:
            goto L2c
        L29:
            goto L10
        L2c:
            goto L14
    }

    public static void WaQjfRzxqXwfYdys(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, bool r3, float r4, byte r5, char r6) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L16:
            r0 = 42
            goto L10
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto Lc
    }

    @Override // com.google.android.gms.common.api.internal.IStatusCallback
    public readonly void OnResult(com.google.android.gms.common.api.Status r2) {
            r1 = this;
            goto L1f
        L4:
            goto L22
        L7:
            WaQjfRzxqXwfYdys(r2, r0, r1)
            goto L14
        Le:
            com.google.android.gms.tasks.TaskCompletionSource r1 = r1.zzb
            goto L7
        L14:
            return
        L15:
            goto L4
        L19:
            java.lang.object r0 = r1.zza
            goto Le
        L1f:
            goto L15
        L22:
            goto L19
    }
}

