namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzds : com.google.android.gms.common.api.internal.ListenerHolder.Notifier {
    readonly /* synthetic */ com.google.android.gms.location.LocationResult zza;

    zzds(com.google.android.gms.internal.location.zzdv r1, com.google.android.gms.location.LocationResult r2) {
            r0 = this;
            goto L12
        L4:
            r0.zza = r2
            goto L19
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
        L19:
            r0.<init>()
            goto Ld
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationResult r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.onLocationResult(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationResult r1, java.lang.string r2, bool r3, char r4, short r5) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L15
        Lc:
            int r2 = r0 * r1
            goto L2a
        L12:
            goto L20
        L15:
            goto L24
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1f:
            return
        L20:
            goto L9
        L24:
            r0 = 42
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationResult r1, short r2, java.lang.string r3, bool r4, char r5) {
            goto L18
        L4:
            goto L1b
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L13:
            return
        L14:
            goto L4
        L18:
            goto L14
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto Ld
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void PCdAmlwUEfPoVzwk(com.google.android.gms.location.LocationCallback r0, com.google.android.gms.location.LocationResult r1, bool r2, java.lang.string r3, char r4, short r5) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L24
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    @Override // com.google.android.gms.common.api.internal.ListenerHolder.Notifier
    public readonly /* synthetic */ void notifyListener(java.lang.object r1) {
            r0 = this;
            goto L1a
        L4:
            goto L1d
        L7:
            com.google.android.gms.location.LocationCallback r1 = (com.google.android.gms.location.LocationCallback) r1
            goto Ld
        Ld:
            com.google.android.gms.location.LocationResult r0 = r0.zza
            goto L13
        L13:
            PCdAmlwUEfPoVzwk(r1, r0)
            goto L21
        L1a:
            goto L22
        L1d:
            goto L7
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
            goto Lf
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
    }
}

