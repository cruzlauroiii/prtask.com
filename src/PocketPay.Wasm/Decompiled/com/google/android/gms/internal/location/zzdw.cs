namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdw : com.google.android.gms.common.api.internal.ListenerHolder.Notifier {
    readonly /* synthetic */ android.location.Location zza;

    zzdw(com.google.android.gms.internal.location.zzdy r1, android.location.Location r2) {
            r0 = this;
            goto Lf
        L4:
            return
        L5:
            goto L1d
        L9:
            r0.zza = r2
            goto L16
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            r0.<init>()
            goto L4
        L1d:
            goto L12
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener r0, android.location.Location r1) {
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
            r0.onLocationChanged(r1)
            goto Lb
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener r0, android.location.Location r1, byte r2, float r3, java.lang.string r4, short r5) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L21
        Ld:
            int r3 = r2 + r1
            goto L19
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto L13
        L2b:
            return
        L2c:
            goto La
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener r0, android.location.Location r1, float r2, java.lang.string r3, byte r4, short r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L27
        Ld:
            int r2 = r0 * r1
            goto L13
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L2c
        L27:
            goto L1e
        L2b:
            return
        L2c:
            goto La
    }

    public static void EWusTVHcLeTUbVMj(com.google.android.gms.location.LocationListener r0, android.location.Location r1, java.lang.string r2, short r3, byte r4, float r5) {
            goto L21
        L4:
            r0 = 42
            goto L15
        La:
            return
        Lb:
            goto L28
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto Lf
        L21:
            goto Lb
        L24:
            goto L4
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto La
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly /* bridge */ /* synthetic */ void notifyListener(java.lang.object r1) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L1d
        L9:
            goto L5
        Lc:
            goto L17
        L10:
            EWusTVHcLeTUbVMj(r1, r0)
            goto L4
        L17:
            com.google.android.gms.location.LocationListener r1 = (com.google.android.gms.location.LocationListener) r1
            goto L20
        L1d:
            goto Lc
        L20:
            android.location.Location r0 = r0.zza
            goto L10
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly void OnNotifyListenerFailed() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
    }
}

