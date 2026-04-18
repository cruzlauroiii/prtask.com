namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdp : com.google.android.gms.common.api.internal.ListenerHolder.Notifier {
    readonly /* synthetic */ com.google.android.gms.location.DeviceOrientation zza;

    zzdp(com.google.android.gms.internal.location.zzdq r1, com.google.android.gms.location.DeviceOrientation r2) {
            r0 = this;
            goto L19
        L4:
            r0.<init>()
            goto L14
        Lb:
            goto L1c
        Le:
            r0.zza = r2
            goto L4
        L14:
            return
        L15:
            goto Lb
        L19:
            goto L15
        L1c:
            goto Le
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener r0, com.google.android.gms.location.DeviceOrientation r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.onDeviceOrientationChanged(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener r0, com.google.android.gms.location.DeviceOrientation r1, float r2, char r3, java.lang.string r4, short r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener r0, com.google.android.gms.location.DeviceOrientation r1, java.lang.string r2, short r3, char r4, float r5) {
            goto L24
        L4:
            r0 = 42
            goto L13
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            goto L27
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            int r2 = r0 * r1
            goto La
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L10
    }

    public static void WoXnVuPavnuKcDld(com.google.android.gms.location.DeviceOrientationListener r0, com.google.android.gms.location.DeviceOrientation r1, short r2, java.lang.string r3, float r4, char r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L2a
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            return
        L20:
            goto L16
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r0 = 42
            goto L4
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly /* bridge */ /* synthetic */ void notifyListener(java.lang.object r1) {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            com.google.android.gms.location.DeviceOrientationListener r1 = (com.google.android.gms.location.DeviceOrientationListener) r1
            goto L14
        Ld:
            goto L22
        L10:
            goto L7
        L14:
            com.google.android.gms.location.DeviceOrientation r0 = r0.zza
            goto L1a
        L1a:
            WoXnVuPavnuKcDld(r1, r0)
            goto L21
        L21:
            return
        L22:
            goto L4
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

