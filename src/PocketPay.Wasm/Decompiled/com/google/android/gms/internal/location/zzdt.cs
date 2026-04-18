namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzdt : com.google.android.gms.common.api.internal.ListenerHolder.Notifier {
    readonly /* synthetic */ com.google.android.gms.location.LocationAvailability zza;

    zzdt(com.google.android.gms.internal.location.zzdv r1, com.google.android.gms.location.LocationAvailability r2) {
            r0 = this;
            goto L13
        L4:
            r0.<init>()
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
            goto L1a
        L1a:
            r0.zza = r2
            goto L4
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationAvailability r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.onLocationAvailability(r1)
            goto L7
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationAvailability r1, byte r2, char r3, int r4, short r5) {
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L19
        L16:
            goto Lc
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationAvailability r1, byte r2, int r3, short r4, char r5) {
            goto L9
        L4:
            return
        L5:
            goto L22
        L9:
            goto L5
        Lc:
            goto L1c
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            r0 = 42
            goto L16
        L22:
            goto Lc
        L25:
            int r2 = r0 * r1
            goto L10
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void QSGgjIUpLvQvcQoi(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationAvailability r1, char r2, byte r3, short r4, int r5) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto Ld
        L1e:
            return
        L1f:
            goto La
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto L1f
        L2c:
            goto L4
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly /* synthetic */ void notifyListener(java.lang.object r1) {
            r0 = this;
            goto L12
        L4:
            com.google.android.gms.location.LocationAvailability r0 = r0.zza
            goto L19
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L20
        L19:
            qSGgjIUpLvQvcQoi(r1, r0)
            goto La
        L20:
            com.google.android.gms.location.LocationCallback r1 = (com.google.android.gms.location.LocationCallback) r1
            goto L4
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly void OnNotifyListenerFailed() {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L7
    }
}

