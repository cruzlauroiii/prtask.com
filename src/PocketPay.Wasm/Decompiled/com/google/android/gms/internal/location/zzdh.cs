namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdh : com.google.android.gms.location.LocationCallback {
    readonly /* synthetic */ com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly /* synthetic */ com.google.android.gms.internal.location.zzdz zzb;

    zzdh(com.google.android.gms.internal.location.zzdz r1, com.google.android.gms.tasks.TaskCompletionSource r2) {
            r0 = this;
            goto La
        L4:
            r0.zza = r2
            goto L20
        La:
            goto L1c
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            r0.<init>()
            goto L1b
        L1b:
            return
        L1c:
            goto L11
        L20:
            r0.zzb = r1
            goto L14
    }

    public static android.location.Location XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.location.Location r0 = r1.getLastLocation()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult r0, float r1, byte r2, java.lang.string r3, bool r4) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            return
        L1d:
            goto L28
        L21:
            goto L1d
        L24:
            goto La
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L1c
    }

    public static void XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult r0, java.lang.string r1, float r2, byte r3, bool r4) {
            goto L4
        L4:
            goto L24
        L7:
            goto L1d
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            int r3 = r2 + r1
            goto L28
        L1d:
            r0 = 42
            goto L11
        L23:
            return
        L24:
            goto L2d
        L28:
            double r0 = (double) r3
            goto L23
        L2d:
            goto L7
    }

    public static void XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult r0, java.lang.string r1, float r2, bool r3, byte r4) {
            goto La
        L4:
            r0 = 42
            goto L17
        La:
            goto L1e
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L22
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto Ld
    }

    public static void YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, java.lang.string r2, char r3, float r4, bool r5) {
            goto L14
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            goto L10
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto L4
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto La
        L2d:
            goto L17
    }

    public static void YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            r0 = 42
            goto L1f
        L10:
            goto L2c
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            goto L13
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1, bool r2, java.lang.string r3, char r4, float r5) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            r0 = 42
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L21
        L18:
            int r3 = r2 + r1
            goto L10
        L1e:
            goto L26
        L21:
            goto La
        L25:
            return
        L26:
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static bool YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.tryHashSetResult(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey QaTPvzsqeyFNtsnd(java.lang.object r1, java.lang.string r2) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r0 = com.google.android.gms.common.api.internal.ListenerHolders.createListenerKey(r1, r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void QaTPvzsqeyFNtsnd(java.lang.object r0, java.lang.string r1, byte r2, int r3, short r4, float r5) {
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L24
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r0 = 42
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void QaTPvzsqeyFNtsnd(java.lang.object r0, java.lang.string r1, int r2, short r3, byte r4, float r5) {
            goto L1d
        L4:
            goto L20
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            int r3 = r2 + r1
            goto L12
        L1d:
            goto L8
        L20:
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L17
        L2a:
            r0 = 42
            goto Lc
    }

    public static void QaTPvzsqeyFNtsnd(java.lang.object r0, java.lang.string r1, short r2, byte r3, int r4, float r5) {
            goto L4
        L4:
            goto L1a
        L7:
            goto L1e
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L14
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto Lb
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, bool r2, com.google.android.gms.tasks.TaskCompletionSource r3) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zzw(r1, r2, r3)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, bool r2, com.google.android.gms.tasks.TaskCompletionSource r3, byte r4, java.lang.string r5, short r6, int r7) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L28
        L15:
            goto L29
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto La
        L22:
            int r3 = r2 + r1
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, bool r2, com.google.android.gms.tasks.TaskCompletionSource r3, byte r4, short r5, int r6, java.lang.string r7) {
            goto L7
        L4:
            goto La
        L7:
            goto L1b
        La:
            goto L1f
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L25
        L1a:
            return
        L1b:
            goto L4
        L1f:
            r0 = 42
            goto Le
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.location.zzdz r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, bool r2, com.google.android.gms.tasks.TaskCompletionSource r3, java.lang.string r4, int r5, byte r6, short r7) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            r0 = 42
            goto La
        L1c:
            double r0 = (double) r3
            goto L21
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L16
        L2d:
            goto L29
    }

    @Override // com.google.android.gms.location.LocationCallback
    public readonly void OnLocationResult(com.google.android.gms.location.LocationResult r3) {
            r2 = this;
            goto L38
        L4:
            YJipzkJvFufNsfYl(r0, r3)
            com.google.android.gms.internal.location.zzdz r3 = r2.zzb     // Catch: android.os.RemoteException -> L18
            java.lang.string r0 = "GetCurrentLocation"
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r2 = qaTPvzsqeyFNtsnd(r2, r0)     // Catch: android.os.RemoteException -> L18
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource     // Catch: android.os.RemoteException -> L18
            r0.<init>()     // Catch: android.os.RemoteException -> L18
            r1 = 0
            zbUhXPkGcZNjRBAB(r3, r2, r1, r0)     // Catch: android.os.RemoteException -> L18
        L18:
            goto L58
        L1c:
            r0 = 16
            goto L63
        L23:
            int r0 = r0 % r1
            goto L3f
        L29:
            goto L54
        L2c:
            goto L48
        L30:
            android.location.Location r3 = XDGRpYbtxmHYnUlA(r3)
            goto L4
        L38:
            goto L2c
        L3b:
            goto L1c
        L3f:
            if (r0 <= 0) goto L44
            goto L54
        L44:
            goto L51
        L48:
            goto L3b
        L4b:
            int r0 = r0 + r1
            goto L23
        L51:
            goto L59
        L54:
            goto L5d
        L58:
            return
        L59:
            goto L29
        L5d:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r2.zza
            goto L30
        L63:
            r1 = 23
            goto L4b
    }
}

