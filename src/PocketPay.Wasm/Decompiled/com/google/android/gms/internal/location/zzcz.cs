namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzcz : com.google.android.gms.location.HashSettingsApi {
    public zzcz() {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.<init>()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl WSApmYFriwvBaBcW(com.google.android.gms.common.api.GoogleApiClient r1, com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl r0 = r1.enqueue(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void WSApmYFriwvBaBcW(com.google.android.gms.common.api.GoogleApiClient r0, com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r1, byte r2, bool r3, short r4, java.lang.string r5) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            goto L26
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto Ld
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static void WSApmYFriwvBaBcW(com.google.android.gms.common.api.GoogleApiClient r0, com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r1, short r2, byte r3, bool r4, java.lang.string r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L1f
        L16:
            goto L2c
        L19:
            r0 = 42
            goto L4
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L16
        L29:
            goto L25
        L2c:
            goto L19
    }

    public static void WSApmYFriwvBaBcW(com.google.android.gms.common.api.GoogleApiClient r0, com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r1, bool r2, byte r3, java.lang.string r4, short r5) {
            goto L29
        L4:
            r0 = 42
            goto L1d
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1a
        L14:
            int r3 = r2 + r1
            goto La
        L1a:
            goto L2c
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L14
        L29:
            goto L10
        L2c:
            goto L4
    }

    @Override // com.google.android.gms.location.HashSettingsApi
    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.location.LocationHashSettingsResult> CheckLocationHashSettings(com.google.android.gms.common.api.GoogleApiClient r3, com.google.android.gms.location.LocationHashSettingsRequest r4) {
            r2 = this;
            goto L9
        L4:
            r1 = 0
            goto L4b
        L9:
            goto L3f
        Lc:
            goto L25
        L10:
            goto Lc
        L13:
            r1 = 13
            goto L1a
        L1a:
            int r0 = r0 + r1
            goto L58
        L20:
            return r2
        L21:
            goto L3c
        L25:
            r0 = 22
            goto L13
        L2c:
            if (r0 <= 0) goto L31
            goto L38
        L31:
            goto L35
        L35:
            goto L21
        L38:
            goto L52
        L3c:
            goto L38
        L3f:
            goto L10
        L43:
            com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl r2 = WSApmYFriwvBaBcW(r3, r0)
            goto L20
        L4b:
            r0.<init>(r2, r3, r4, r1)
            goto L43
        L52:
            com.google.android.gms.internal.location.zzcx r0 = new com.google.android.gms.internal.location.zzcx
            goto L4
        L58:
            int r0 = r0 % r1
            goto L2c
    }
}

