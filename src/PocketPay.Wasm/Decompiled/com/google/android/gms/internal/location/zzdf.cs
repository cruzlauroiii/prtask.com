namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdf : com.google.android.gms.internal.location.zzaa {
    readonly /* synthetic */ com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder zza;

    zzdf(com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder r1) {
            r0 = this;
            goto L14
        L4:
            goto L17
        L7:
            r0.<init>()
            goto L1b
        Le:
            r0.zza = r1
            goto L7
        L14:
            goto L1c
        L17:
            goto Le
        L1b:
            return
        L1c:
            goto L4
    }

    public static void QmXUMUFvlZcWuukY(com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder r0, java.lang.object r1) {
            goto L13
        L4:
            r0.setResult(r1)
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

    public static void QmXUMUFvlZcWuukY(com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder r0, java.lang.object r1, int r2, char r3, byte r4, bool r5) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L15
        L12:
            goto L2c
        L15:
            goto L25
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L9
        L25:
            r0 = 42
            goto L19
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void QmXUMUFvlZcWuukY(com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder r0, java.lang.object r1, int r2, bool r3, char r4, byte r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto L21
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            return
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto Lb
        L21:
            r0 = 42
            goto L10
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void QmXUMUFvlZcWuukY(com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder r0, java.lang.object r1, bool r2, int r3, byte r4, char r5) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L17
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L17:
            r0 = 42
            goto L11
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto L7
        L25:
            int r2 = r0 * r1
            goto Lb
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    @Override // com.google.android.gms.internal.location.zzab
    public readonly void Zzb(com.google.android.gms.location.LocationHashSettingsResult r1) {
            r0 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.common.api.internal.BaseImplementation$ResultHolder r0 = r0.zza
            goto L14
        L14:
            QmXUMUFvlZcWuukY(r0, r1)
            goto L1b
        L1b:
            return
        L1c:
            goto Lb
    }
}

