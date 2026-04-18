namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdo : com.google.android.gms.internal.location.zzq {
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly /* synthetic */ com.google.android.gms.location.zzz zzb;

    zzdo(com.google.android.gms.tasks.TaskCompletionSource r1, com.google.android.gms.location.zzz r2) {
            r0 = this;
            goto L16
        L4:
            r0.zza = r1
            goto L20
        La:
            r0.<init>()
            goto L11
        L11:
            return
        L12:
            goto L1d
        L16:
            goto L12
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            r0.zzb = r2
            goto La
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L13
        L4:
            com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(r0, r1)
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

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1, byte r2, float r3, java.lang.string r4, int r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L1c
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto La
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1, byte r2, int r3, float r4, java.lang.string r5) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L9
        L1a:
            r0 = 42
            goto L2a
        L20:
            goto L5
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void VdxlUCmMMopTeFey(com.google.android.gms.common.api.Status r0, com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.string r2, int r3, float r4, byte r5) {
            goto L1e
        L4:
            goto L21
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            r0 = 42
            goto L2a
        L1e:
            goto L8
        L21:
            goto L18
        L25:
            double r0 = (double) r3
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static com.google.android.gms.common.api.Status DJFGBoANARuODcMG(com.google.android.gms.internal.location.zzl r1) {
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
            com.google.android.gms.common.api.Status r0 = r1.getStatus()
            goto L4
    }

    public static void DJFGBoANARuODcMG(com.google.android.gms.internal.location.zzl r0, char r1, bool r2, byte r3, short r4) {
            goto L23
        L4:
            goto L26
        L7:
            double r0 = (double) r3
            goto L1e
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L7
        L18:
            r0 = 42
            goto L2a
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static void DJFGBoANARuODcMG(com.google.android.gms.internal.location.zzl r0, short r1, bool r2, char r3, byte r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            goto L26
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            return
        L19:
            goto L9
        L1d:
            r0 = 42
            goto Lc
        L23:
            goto L19
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void DJFGBoANARuODcMG(com.google.android.gms.internal.location.zzl r0, bool r1, short r2, byte r3, char r4) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            r0 = 42
            goto L14
        L20:
            goto Lb
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz r0) {
            goto L13
        L4:
            r0.zze()
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

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz r0, java.lang.string r1, char r2, bool r3, short r4) {
            goto L1b
        L4:
            return
        L5:
            goto L28
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L9
        L1b:
            goto L5
        L1e:
            goto L22
        L22:
            r0 = 42
            goto Lf
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz r0, short r1, char r2, bool r3, java.lang.string r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L27
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L11:
            return
        L12:
            goto L2d
        L16:
            int r3 = r2 + r1
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            r0 = 42
            goto Lb
        L2d:
            goto L7
    }

    public static void RENPiLOHlYCCDxny(com.google.android.gms.location.zzz r0, short r1, bool r2, java.lang.string r3, char r4) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto Lf
        Lc:
            goto L26
        Lf:
            goto L2a
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            return
        L26:
            goto L9
        L2a:
            r0 = 42
            goto L13
    }

    @Override // com.google.android.gms.internal.location.zzr
    public readonly void Zzd(com.google.android.gms.internal.location.zzl r1) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L24
        La:
            goto Le
        Le:
            com.google.android.gms.common.api.Status r1 = dJFGBoANARuODcMG(r1)
            goto L1d
        L16:
            VdxlUCmMMopTeFey(r1, r0)
            goto L23
        L1d:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r0.zza
            goto L16
        L23:
            return
        L24:
            goto L4
    }

    @Override // com.google.android.gms.internal.location.zzr
    public readonly void Zze() throws android.os.RemoteException {
            r0 = this;
            goto L10
        L4:
            rENPiLOHlYCCDxny(r0)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L1a
        L17:
            goto L13
        L1a:
            com.google.android.gms.location.zzz r0 = r0.zzb
            goto L4
    }
}

