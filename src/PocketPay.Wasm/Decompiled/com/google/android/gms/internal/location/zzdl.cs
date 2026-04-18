namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdl : com.google.android.gms.internal.location.zzw {
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zza;

    zzdl(com.google.android.gms.tasks.TaskCompletionSource r1) {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L12
        Lb:
            goto L13
        Le:
            goto L1a
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
        L1a:
            r0.zza = r1
            goto L4
    }

    public static void EIzRPvnNOEAKDzFz(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
            goto L13
        L4:
            com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(r0, r1, r2)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void EIzRPvnNOEAKDzFz(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, char r3, short r4, bool r5, int r6) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L24
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L7
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            r0 = 42
            goto L18
        L24:
            double r0 = (double) r3
            goto Ld
        L29:
            goto Le
        L2c:
            goto L1e
    }

    public static void EIzRPvnNOEAKDzFz(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, bool r3, int r4, char r5, short r6) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            int r2 = r0 * r1
            goto Lf
        L20:
            goto L5
        L23:
            goto L9
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void EIzRPvnNOEAKDzFz(com.google.android.gms.common.api.Status r0, java.lang.object r1, com.google.android.gms.tasks.TaskCompletionSource r2, bool r3, short r4, char r5, int r6) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto L19
        Lf:
            goto L2c
        L12:
            goto L25
        L16:
            goto L12
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L16
    }

    @Override // com.google.android.gms.internal.location.zzx
    public readonly void Zzb(com.google.android.gms.common.api.Status r1, com.google.android.gms.location.LocationAvailability r2) {
            r0 = this;
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
            goto L1a
        L13:
            eIzRPvnNOEAKDzFz(r1, r2, r0)
            goto L4
        L1a:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r0.zza
            goto L13
    }
}

