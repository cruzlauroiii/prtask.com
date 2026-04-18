namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdi : com.google.android.gms.internal.location.zzdr {
    readonly /* synthetic */ com.google.android.gms.common.api.internal.ListenerHolder zza;
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zzb;

    zzdi(com.google.android.gms.internal.location.zzdz r1, com.google.android.gms.common.api.internal.ListenerHolder r2, com.google.android.gms.tasks.TaskCompletionSource r3) {
            r0 = this;
            goto L19
        L4:
            goto L1c
        L7:
            r0.zzb = r3
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            r0.<init>()
            goto Ld
        L19:
            goto Le
        L1c:
            goto L20
        L20:
            r0.zza = r2
            goto L7
    }

    public static void OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, float r2, java.lang.string r3, bool r4, int r5) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            r0 = 42
            goto Lf
        L21:
            goto L27
        L24:
            goto L2c
        L27:
            goto L1b
        L2b:
            return
        L2c:
            goto L21
    }

    public static void OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, int r2, float r3, bool r4, java.lang.string r5) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L5
        L18:
            goto Lf
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L1c
    }

    public static void OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, bool r2, java.lang.string r3, float r4, int r5) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            int r2 = r0 * r1
            goto L1d
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static bool OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.object r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.tryHashSetResult(r2)
            goto L4
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly com.google.android.gms.common.api.internal.ListenerHolder Zza() {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r0.zza
            goto L14
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return r0
        L15:
            goto L4
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly void Zzb(com.google.android.gms.common.api.internal.ListenerHolder r1) {
            r0 = this;
            goto L16
        L4:
            r0.<init>()
            goto Lb
        Lb:
            throw r0
        Lc:
            goto L1d
        L10:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L4
        L16:
            goto Lc
        L19:
            goto L10
        L1d:
            goto L19
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly void Zzc() {
            r1 = this;
            goto L10
        L4:
            r0 = 0
            goto L9
        L9:
            OqyMIJZkXLXthEoD(r1, r0)
            goto L1d
        L10:
            goto L1e
        L13:
            goto L17
        L17:
            com.google.android.gms.tasks.TaskCompletionSource r1 = r1.zzb
            goto L4
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto L13
    }
}

