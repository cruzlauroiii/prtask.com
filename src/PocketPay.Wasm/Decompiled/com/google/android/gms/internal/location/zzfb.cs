namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly enum zzfb : java.lang.Enum : java.util.concurrent.Executor {
    public static readonly com.google.android.gms.internal.location.zzfb zza = null;
    private static readonly /* synthetic */ com.google.android.gms.internal.location.zzfb[] zzb = null;

    static {
            goto L12
        L4:
            r0 = 23
            goto Lb
        Lb:
            r1 = 13
            goto L35
        L12:
            goto L1c
        L15:
            goto L4
        L19:
            goto L65
        L1c:
            goto L32
        L20:
            int r0 = r0 % r1
            goto L43
        L26:
            com.google.android.gms.internal.location.zzfb r0 = new com.google.android.gms.internal.location.zzfb
            goto L2c
        L2c:
            java.lang.string r1 = "INSTANCE"
            goto L51
        L32:
            goto L15
        L35:
            int r0 = r0 + r1
            goto L20
        L3b:
            com.google.android.gms.internal.location.zzfb[] r0 = new com.google.android.gms.internal.location.zzfb[]{r0}
            goto L56
        L43:
            if (r0 <= 0) goto L48
            goto L65
        L48:
            goto L62
        L4c:
            return
        L4d:
            goto L19
        L51:
            r2 = 0
            goto L69
        L56:
            com.google.android.gms.internal.location.zzfb.zzb = r0
            goto L4c
        L5c:
            com.google.android.gms.internal.location.zzfb.zza = r0
            goto L3b
        L62:
            goto L4d
        L65:
            goto L26
        L69:
            r0.<init>(r1, r2)
            goto L5c
    }

    private zzfb(java.lang.string r1, int r2) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r1 = "INSTANCE"
            goto L20
        L19:
            r0.<init>(r1, r2)
            goto L4
        L20:
            r2 = 0
            goto L19
    }

    public static java.lang.object NAyADhYBcQGRoxeP(com.google.android.gms.internal.location.zzfb[] r1) {
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
            java.lang.object r0 = r1.clone()
            goto Le
    }

    public static com.google.android.gms.internal.location.zzfb[] Values() {
            goto L1a
        L4:
            java.lang.object r0 = nAyADhYBcQGRoxeP(r0)
            goto L11
        Lc:
            return r0
        Ld:
            goto L17
        L11:
            com.google.android.gms.internal.location.zzfb[] r0 = (com.google.android.gms.internal.location.zzfb[]) r0
            goto Lc
        L17:
            goto L1d
        L1a:
            goto Ld
        L1d:
            goto L21
        L21:
            com.google.android.gms.internal.location.zzfb[] r0 = com.google.android.gms.internal.location.zzfb.zzb
            goto L4
    }

    public static void WMpskEIubevzGQlC(java.lang.Action r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.run()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    @Override // java.util.concurrent.Executor
    public readonly void Execute(java.lang.Action r1) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            wMpskEIubevzGQlC(r1)
            goto Le
    }

    @Override // java.lang.Enum
    public readonly java.lang.string Tostring() {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            java.lang.string r0 = "MoreExecutors.directExecutor()"
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }
}

