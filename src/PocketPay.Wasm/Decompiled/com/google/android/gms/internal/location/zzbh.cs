namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzbh : com.google.android.gms.common.api.internal.RemoteCall, com.google.android.gms.internal.location.zzdr {
    readonly /* synthetic */ com.google.android.gms.internal.location.zzbi zza;
    private readonly com.google.android.gms.internal.location.zzbg zzb;
    private com.google.android.gms.common.api.internal.ListenerHolder zzc;
    private bool zzd;

    zzbh(com.google.android.gms.internal.location.zzbi r1, com.google.android.gms.common.api.internal.ListenerHolder r2, com.google.android.gms.internal.location.zzbg r3) {
            r0 = this;
            goto L10
        L4:
            r0.zzc = r2
            goto L1a
        La:
            r0.zza = r1
            goto L20
        L10:
            goto L28
        L13:
            goto La
        L17:
            goto L13
        L1a:
            r0.zzb = r3
            goto L27
        L20:
            r0.<init>()
            goto L32
        L27:
            return
        L28:
            goto L17
        L2c:
            r0.zzd = r1
            goto L4
        L32:
            r1 = 1
            goto L2c
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey EbgvNdhnlSppdwGO(com.google.android.gms.common.api.internal.ListenerHolder r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r0 = r1.getListenerKey()
            goto Lb
    }

    public static void EbgvNdhnlSppdwGO(com.google.android.gms.common.api.internal.ListenerHolder r0, byte r1, java.lang.string r2, int r3, short r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1a:
            r0 = 42
            goto L14
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto La
    }

    public static void EbgvNdhnlSppdwGO(com.google.android.gms.common.api.internal.ListenerHolder r0, int r1, java.lang.string r2, short r3, byte r4) {
            goto L19
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            r0 = 42
            goto L4
        L16:
            goto L1c
        L19:
            goto L21
        L1c:
            goto L10
        L20:
            return
        L21:
            goto L16
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void EbgvNdhnlSppdwGO(com.google.android.gms.common.api.internal.ListenerHolder r0, int r1, short r2, byte r3, java.lang.string r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L19
        Lb:
            double r0 = (double) r3
            goto L1f
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            goto L7
        L19:
            r0 = 42
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2a:
            int r3 = r2 + r1
            goto Lb
    }

    public static void FoyemRTqQKDXOtOf(com.google.android.gms.common.api.internal.ListenerHolder r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.clear()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void FoyemRTqQKDXOtOf(com.google.android.gms.common.api.internal.ListenerHolder r0, java.lang.string r1, float r2, bool r3, byte r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            r0 = 42
            goto L17
        L10:
            goto L2c
        L13:
            goto La
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            goto L13
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void FoyemRTqQKDXOtOf(com.google.android.gms.common.api.internal.ListenerHolder r0, java.lang.string r1, bool r2, byte r3, float r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L20
        L12:
            goto L19
        L16:
            goto L12
        L19:
            r0 = 42
            goto L9
        L1f:
            return
        L20:
            goto L16
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void FoyemRTqQKDXOtOf(com.google.android.gms.common.api.internal.ListenerHolder r0, java.lang.string r1, bool r2, float r3, byte r4) {
            goto L24
        L4:
            r0 = 42
            goto L19
        La:
            goto L27
        Ld:
            int r2 = r0 * r1
            goto L13
        L13:
            int r3 = r2 + r1
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto La
    }

    public static java.lang.bool HIMdsXCTRowqrZzY(bool r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void HIMdsXCTRowqrZzY(bool r0, char r1, int r2, java.lang.string r3, short r4) {
            goto L23
        L4:
            r0 = 42
            goto L1d
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L23:
            goto Le
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void HIMdsXCTRowqrZzY(bool r0, int r1, short r2, char r3, java.lang.string r4) {
            goto L18
        L4:
            return
        L5:
            goto L15
        L9:
            int r3 = r2 + r1
            goto L1f
        Lf:
            r0 = 42
            goto L24
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto Lf
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void HIMdsXCTRowqrZzY(bool r0, java.lang.string r1, short r2, int r3, char r4) {
            goto L1a
        L4:
            r0 = 42
            goto L24
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L21
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            goto L10
        L1d:
            goto L4
        L21:
            goto L1d
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void HJyhTbsDbReOFQel(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.setResult(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void HJyhTbsDbReOFQel(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, int r2, byte r3, short r4, java.lang.string r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L27
        L10:
            int r2 = r0 * r1
            goto L21
        L16:
            r0 = 42
            goto L2a
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void HJyhTbsDbReOFQel(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, java.lang.string r2, byte r3, int r4, short r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L27
        Lb:
            return
        Lc:
            goto L2d
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            int r2 = r0 * r1
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            int r3 = r2 + r1
            goto L10
        L27:
            r0 = 42
            goto L1b
        L2d:
            goto L7
    }

    public static void HJyhTbsDbReOFQel(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, short r2, byte r3, int r4, java.lang.string r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            double r0 = (double) r3
            goto L25
        L1b:
            goto L26
        L1e:
            goto L2a
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L4
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey HxmlEBRiJrncBvwt(com.google.android.gms.common.api.internal.ListenerHolder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r0 = r1.getListenerKey()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void HxmlEBRiJrncBvwt(com.google.android.gms.common.api.internal.ListenerHolder r0, byte r1, short r2, char r3, bool r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L26
        L1e:
            goto L2a
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L15
    }

    public static void HxmlEBRiJrncBvwt(com.google.android.gms.common.api.internal.ListenerHolder r0, char r1, bool r2, short r3, byte r4) {
            goto L15
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L10:
            return
        L11:
            goto L2d
        L15:
            goto L11
        L18:
            goto L4
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L18
    }

    public static void HxmlEBRiJrncBvwt(com.google.android.gms.common.api.internal.ListenerHolder r0, bool r1, short r2, byte r3, char r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L25
        L11:
            return
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            r0 = 42
            goto L16
    }

    public static com.google.android.gms.tasks.Task FtTdUJgdlkhniSEI(com.google.android.gms.internal.location.zzbi r1, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r2, int r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.tasks.Task r0 = r1.doUnregisterEventListener(r2, r3)
            goto Lb
    }

    public static void FtTdUJgdlkhniSEI(com.google.android.gms.internal.location.zzbi r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, int r2, byte r3, float r4, char r5, bool r6) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            r0 = 42
            goto L10
        L1c:
            goto L2c
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L1c
        L29:
            goto L25
        L2c:
            goto L16
    }

    public static void FtTdUJgdlkhniSEI(com.google.android.gms.internal.location.zzbi r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, int r2, byte r3, float r4, bool r5, char r6) {
            goto L4
        L4:
            goto L17
        L7:
            goto L27
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto Lb
        L27:
            r0 = 42
            goto L10
        L2d:
            goto L7
    }

    public static void FtTdUJgdlkhniSEI(com.google.android.gms.internal.location.zzbi r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, int r2, bool r3, byte r4, char r5, float r6) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            int r2 = r0 * r1
            goto L1d
        L12:
            return
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1d:
            int r3 = r2 + r1
            goto L7
        L23:
            r0 = 42
            goto L17
        L29:
            goto L13
        L2c:
            goto L23
    }

    public static void RiTjOCKMOKJJpmey(com.google.android.gms.internal.location.zzbg r0, com.google.android.gms.internal.location.zzdz r1, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r2, bool r3, com.google.android.gms.tasks.TaskCompletionSource r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.zza(r1, r2, r3, r4)
            goto Lb
    }

    public static void RiTjOCKMOKJJpmey(com.google.android.gms.internal.location.zzbg r0, com.google.android.gms.internal.location.zzdz r1, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r2, bool r3, com.google.android.gms.tasks.TaskCompletionSource r4, byte r5, java.lang.string r6, bool r7, float r8) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L25
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto Le
        L21:
            goto L12
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void RiTjOCKMOKJJpmey(com.google.android.gms.internal.location.zzbg r0, com.google.android.gms.internal.location.zzdz r1, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r2, bool r3, com.google.android.gms.tasks.TaskCompletionSource r4, java.lang.string r5, byte r6, float r7, bool r8) {
            goto L1e
        L4:
            r0 = 42
            goto L13
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            goto L21
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void RiTjOCKMOKJJpmey(com.google.android.gms.internal.location.zzbg r0, com.google.android.gms.internal.location.zzdz r1, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r2, bool r3, com.google.android.gms.tasks.TaskCompletionSource r4, bool r5, byte r6, java.lang.string r7, float r8) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L1a
        L14:
            r0 = 42
            goto L24
        L1a:
            goto L20
        L1d:
            goto L10
        L20:
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void UxEeWoZvWKsMsnxD(com.google.android.gms.common.api.internal.ListenerHolder r0) {
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
            r0.clear()
            goto Le
    }

    public static void UxEeWoZvWKsMsnxD(com.google.android.gms.common.api.internal.ListenerHolder r0, float r1, char r2, short r3, int r4) {
            goto L13
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L16
        L13:
            goto L26
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L1a
        L25:
            return
        L26:
            goto L10
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void UxEeWoZvWKsMsnxD(com.google.android.gms.common.api.internal.ListenerHolder r0, float r1, int r2, short r3, char r4) {
            goto L16
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L1e
        L19:
            goto L27
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r0 = 42
            goto La
        L2d:
            goto L19
    }

    public static void UxEeWoZvWKsMsnxD(com.google.android.gms.common.api.internal.ListenerHolder r0, short r1, char r2, int r3, float r4) {
            goto L1e
        L4:
            r0 = 42
            goto L15
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    @Override // com.google.android.gms.common.api.internal.RemoteCall
    public readonly /* bridge */ /* synthetic */ void accept(java.lang.object r4, java.lang.object r5) throws android.os.RemoteException {
            r3 = this;
            goto L67
        L4:
            goto L36
        L7:
            goto L7b
        Lb:
            return
        Lc:
            goto L8d
        L10:
            return
        L11:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L11
            goto L35
        L17:
            java.lang.bool r3 = HIMdsXCTRowqrZzY(r3)
            goto L81
        L1f:
            int r0 = r0 % r1
            goto L3a
        L25:
            riTjOCKMOKJJpmey(r3, r4, r0, r1, r5)
            goto L10
        L2c:
            if (r0 == 0) goto L31
            goto Lc
        L31:
            goto L88
        L35:
            throw r4
        L36:
            goto L4a
        L3a:
            if (r0 <= 0) goto L3f
            goto L7
        L3f:
            goto L4
        L43:
            r0 = 1
            goto L6e
        L4a:
            goto L7
        L4d:
            goto L51
        L51:
            goto L6a
        L54:
            monitor-enter(r3)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r3.zzc     // Catch: java.lang.Exception -> L11
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r0 = HxmlEBRiJrncBvwt(r0)     // Catch: java.lang.Exception -> L11
            bool r1 = r3.zzd     // Catch: java.lang.Exception -> L11
            com.google.android.gms.common.api.internal.ListenerHolder r2 = r3.zzc     // Catch: java.lang.Exception -> L11
            FoyemRTqQKDXOtOf(r2)     // Catch: java.lang.Exception -> L11
            monitor-exit(r3)     // Catch: java.lang.Exception -> L11
            goto L2c
        L67:
            goto L4d
        L6a:
            goto L43
        L6e:
            r1 = 9
            goto L75
        L75:
            int r0 = r0 + r1
            goto L1f
        L7b:
            com.google.android.gms.internal.location.zzdz r4 = (com.google.android.gms.internal.location.zzdz) r4
            goto L93
        L81:
            HJyhTbsDbReOFQel(r5, r3)
            goto Lb
        L88:
            r3 = 0
            goto L17
        L8d:
            com.google.android.gms.internal.location.zzbg r3 = r3.zzb
            goto L25
        L93:
            com.google.android.gms.tasks.TaskCompletionSource r5 = (com.google.android.gms.tasks.TaskCompletionSource) r5
            goto L54
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly com.google.android.gms.common.api.internal.ListenerHolder Zza() {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L17
        Lb:
            throw r0
        Lc:
            goto L23
        L10:
            return r0
        L11:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L11
            goto Lb
        L17:
            monitor-enter(r1)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r1.zzc     // Catch: java.lang.Exception -> L11
            goto L1e
        L1e:
            monitor-exit(r1)
            goto L10
        L23:
            goto L7
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly void Zzb(com.google.android.gms.common.api.internal.ListenerHolder r2) {
            r1 = this;
            goto L1a
        L4:
            monitor-exit(r1)
            goto L13
        L9:
            return
        La:
            goto L4
        Le:
            throw r2
        Lf:
            goto L2f
        L13:
            return
        L14:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            goto Le
        L1a:
            goto Lf
        L1d:
            goto L21
        L21:
            monitor-enter(r1)
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r1.zzc     // Catch: java.lang.Exception -> L14
            if (r0 == r2) goto La
            uxEeWoZvWKsMsnxD(r0)     // Catch: java.lang.Exception -> L14
            r1.zzc = r2     // Catch: java.lang.Exception -> L14
            goto L32
        L2f:
            goto L1d
        L32:
            monitor-exit(r1)
            goto L9
    }

    @Override // com.google.android.gms.internal.location.zzdr
    public readonly void Zzc() {
            r2 = this;
            goto L1d
        L4:
            if (r0 <= 0) goto L9
            goto L3b
        L9:
            goto L38
        Ld:
            goto L20
        L10:
            int r0 = r0 % r1
            goto L4
        L16:
            r1 = 23
            goto L32
        L1d:
            goto L42
        L20:
            goto L63
        L24:
            r0 = 0
            r2.zzd = r0     // Catch: java.lang.Exception -> L74
            com.google.android.gms.common.api.internal.ListenerHolder r0 = r2.zzc     // Catch: java.lang.Exception -> L74
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r0 = EbgvNdhnlSppdwGO(r0)     // Catch: java.lang.Exception -> L74
            monitor-exit(r2)     // Catch: java.lang.Exception -> L74
            goto L6a
        L32:
            int r0 = r0 + r1
            goto L10
        L38:
            goto L5f
        L3b:
            goto L46
        L3f:
            goto L3b
        L42:
            goto Ld
        L46:
            monitor-enter(r2)
            goto L24
        L4b:
            r1 = 2441(0x989, float:3.42E-42)
            goto L51
        L51:
            ftTdUJgdlkhniSEI(r2, r0, r1)
        L54:
            goto L73
        L58:
            com.google.android.gms.internal.location.zzbi r2 = r2.zza
            goto L4b
        L5e:
            throw r0
        L5f:
            goto L3f
        L63:
            r0 = 24
            goto L16
        L6a:
            if (r0 != 0) goto L6f
            goto L54
        L6f:
            goto L58
        L73:
            return
        L74:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L74
            goto L5e
    }
}

