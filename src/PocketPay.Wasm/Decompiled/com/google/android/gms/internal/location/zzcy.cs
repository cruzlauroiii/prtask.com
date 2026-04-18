namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
abstract class zzcy : com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl {
    public zzcy(com.google.android.gms.common.api.GoogleApiClient r2) {
            r1 = this;
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
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L19
        L16:
            goto Lc
        L19:
            r1.<init>(r0, r2)
            goto L4
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            super.setResult(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, float r2, bool r3, int r4, short r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            double r0 = (double) r3
            goto L1f
        L10:
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            return
        L20:
            goto L10
        L24:
            r0 = 42
            goto L13
        L2a:
            int r3 = r2 + r1
            goto Lb
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, short r2, float r3, int r4, bool r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            r0 = 42
            goto L10
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L1b
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, bool r2, short r3, float r4, int r5) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L18
        L13:
            goto L25
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto La
        L2b:
            double r0 = (double) r3
            goto L17
    }

    @Override // com.google.android.gms.common.api.internal.BasePendingResult
    public readonly /* synthetic */ com.google.android.gms.common.api.Result createFailedResult(com.google.android.gms.common.api.Status r2) {
            r1 = this;
            goto L12
        L4:
            com.google.android.gms.location.LocationHashSettingsResult r1 = new com.google.android.gms.location.LocationHashSettingsResult
            goto L19
        La:
            goto L15
        Ld:
            return r1
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
        L19:
            r0 = 0
            goto L1e
        L1e:
            r1.<init>(r2, r0)
            goto Ld
    }

    @Override // com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl, com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder
    public readonly /* bridge */ /* synthetic */ void setResult(java.lang.object r1) {
            r0 = this;
            goto Lb
        L4:
            bbAbyxhqshbNmuuF(r0, r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L17
        L12:
            return
        L13:
            goto L1d
        L17:
            com.google.android.gms.common.api.Result r1 = (com.google.android.gms.common.api.Result) r1
            goto L4
        L1d:
            goto Le
    }
}

