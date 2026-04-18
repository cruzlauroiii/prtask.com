namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdx : com.google.android.gms.common.api.internal.ListenerHolder.Notifier {
    readonly /* synthetic */ com.google.android.gms.internal.location.zzdy zza;

    zzdx(com.google.android.gms.internal.location.zzdy r1) {
            r0 = this;
            goto Ld
        L4:
            r0.zza = r1
            goto L14
        La:
            goto L10
        Ld:
            goto L1c
        L10:
            goto L4
        L14:
            r0.<init>()
            goto L1b
        L1b:
            return
        L1c:
            goto La
    }

    public static com.google.android.gms.internal.location.zzdr KgebtVnDIvtvJeOD(com.google.android.gms.internal.location.zzdy r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            com.google.android.gms.internal.location.zzdr r0 = r1.zzg()
            goto Le
    }

    public static void KgebtVnDIvtvJeOD(com.google.android.gms.internal.location.zzdy r0, int r1, bool r2, byte r3, java.lang.string r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1c
        Lb:
            int r2 = r0 * r1
            goto L16
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            r0 = 42
            goto L2a
        L22:
            goto L7
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void KgebtVnDIvtvJeOD(com.google.android.gms.internal.location.zzdy r0, java.lang.string r1, byte r2, int r3, bool r4) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L27
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            r0 = 42
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            goto L2c
        L27:
            goto L12
        L2b:
            return
        L2c:
            goto L9
    }

    public static void KgebtVnDIvtvJeOD(com.google.android.gms.internal.location.zzdy r0, bool r1, java.lang.string r2, byte r3, int r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1e
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            goto L26
        L1e:
            return
        L1f:
            goto L1b
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void YBnlfaLaMckPjXKv(com.google.android.gms.internal.location.zzdr r0) {
            goto Lb
        L4:
            r0.zzc()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void YBnlfaLaMckPjXKv(com.google.android.gms.internal.location.zzdr r0, byte r1, short r2, char r3, java.lang.string r4) {
            goto L17
        L4:
            return
        L5:
            goto L14
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L1a
        L17:
            goto L5
        L1a:
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L9
        L2a:
            r0 = 42
            goto L1e
    }

    public static void YBnlfaLaMckPjXKv(com.google.android.gms.internal.location.zzdr r0, char r1, byte r2, short r3, java.lang.string r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L21
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L10
        L2a:
            r0 = 42
            goto La
    }

    public static void YBnlfaLaMckPjXKv(com.google.android.gms.internal.location.zzdr r0, char r1, java.lang.string r2, short r3, byte r4) {
            goto L23
        L4:
            return
        L5:
            goto L1a
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            r0 = 42
            goto L9
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L26
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            goto L5
        L26:
            goto Lf
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly /* bridge */ /* synthetic */ void notifyListener(java.lang.object r1) {
            r0 = this;
            goto L18
        L4:
            com.google.android.gms.internal.location.zzdy r0 = r0.zza
            goto L10
        La:
            com.google.android.gms.location.LocationListener r1 = (com.google.android.gms.location.LocationListener) r1
            goto L4
        L10:
            com.google.android.gms.internal.location.zzdr r0 = KgebtVnDIvtvJeOD(r0)
            goto L22
        L18:
            goto L2a
        L1b:
            goto La
        L1f:
            goto L1b
        L22:
            YBnlfaLaMckPjXKv(r0)
            goto L29
        L29:
            return
        L2a:
            goto L1f
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly void OnNotifyListenerFailed() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto Le
        Le:
            return
        Lf:
            goto L4
    }
}

