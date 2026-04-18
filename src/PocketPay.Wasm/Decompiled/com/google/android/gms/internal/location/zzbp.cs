namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly /* synthetic */ class zzbp : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly /* synthetic */ com.google.android.gms.location.CurrentLocationRequest zza;
    private readonly /* synthetic */ com.google.android.gms.tasks.CancellationToken zzb;

    /* synthetic */ zzbp(com.google.android.gms.location.CurrentLocationRequest r1, com.google.android.gms.tasks.CancellationToken r2) {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L20
        Lb:
            goto L1c
        Le:
            goto L4
        L12:
            goto Le
        L15:
            r0.zzb = r2
            goto L1b
        L1b:
            return
        L1c:
            goto L12
        L20:
            r0.zza = r1
            goto L15
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.location.CurrentLocationRequest r1, com.google.android.gms.tasks.CancellationToken r2, com.google.android.gms.tasks.TaskCompletionSource r3) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.zzr(r1, r2, r3)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.location.CurrentLocationRequest r1, com.google.android.gms.tasks.CancellationToken r2, com.google.android.gms.tasks.TaskCompletionSource r3, byte r4, bool r5, java.lang.string r6, int r7) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L1f
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            goto Lc
        L1f:
            r0 = 42
            goto L16
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.location.CurrentLocationRequest r1, com.google.android.gms.tasks.CancellationToken r2, com.google.android.gms.tasks.TaskCompletionSource r3, int r4, bool r5, java.lang.string r6, byte r7) {
            goto L19
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r0 = 42
            goto L2a
        L10:
            goto L1c
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            goto L21
        L1c:
            goto La
        L20:
            return
        L21:
            goto L10
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.location.CurrentLocationRequest r1, com.google.android.gms.tasks.CancellationToken r2, com.google.android.gms.tasks.TaskCompletionSource r3, java.lang.string r4, int r5, bool r6, byte r7) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            r0 = 42
            goto L12
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            int r2 = r0 * r1
            goto L18
        L29:
            goto L5
        L2c:
            goto Lc
    }

    @Override // com.google.android.gms.common.api.internal.RemoteCall
    public readonly /* synthetic */ void accept(java.lang.object r2, java.lang.object r3) {
            r1 = this;
            goto L19
        L4:
            com.google.android.gms.tasks.CancellationToken r1 = r1.zzb
            goto Ld
        La:
            goto L1c
        Ld:
            VwkxKeeWexaeikbS(r2, r0, r1, r3)
            goto L14
        L14:
            return
        L15:
            goto La
        L19:
            goto L15
        L1c:
            goto L26
        L20:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L2c
        L26:
            com.google.android.gms.tasks.TaskCompletionSource r3 = (com.google.android.gms.tasks.TaskCompletionSource) r3
            goto L32
        L2c:
            com.google.android.gms.location.CurrentLocationRequest r0 = r1.zza
            goto L4
        L32:
            com.google.android.gms.internal.location.zzdz r2 = (com.google.android.gms.internal.location.zzdz) r2
            goto L20
    }
}

