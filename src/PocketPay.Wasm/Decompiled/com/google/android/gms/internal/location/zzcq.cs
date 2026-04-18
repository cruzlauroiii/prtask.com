namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
abstract class zzcq : com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl {
    public zzcq(com.google.android.gms.common.api.GoogleApiClient r2) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L1d
        L10:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L16
        L16:
            r1.<init>(r0, r2)
            goto Lb
        L1d:
            goto L7
    }

    public static void HVQhmZqLOwNMXRLB(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1) {
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
            super.setResult(r1)
            goto Le
    }

    public static void HVQhmZqLOwNMXRLB(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, float r2, char r3, bool r4, java.lang.string r5) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L13:
            goto L1b
        L16:
            goto L2a
        L1a:
            return
        L1b:
            goto La
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto Ld
    }

    public static void HVQhmZqLOwNMXRLB(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, bool r2, char r3, java.lang.string r4, float r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L20
        L1a:
            r0 = 42
            goto L2a
        L20:
            goto L26
        L23:
            goto L16
        L26:
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void HVQhmZqLOwNMXRLB(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, bool r2, float r3, java.lang.string r4, char r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L22
        L10:
            int r2 = r0 * r1
            goto L1c
        L16:
            r0 = 42
            goto L25
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            goto L7
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2b:
            double r0 = (double) r3
            goto Lb
    }

    @Override // com.google.android.gms.common.api.internal.BasePendingResult
    public readonly /* bridge */ /* synthetic */ com.google.android.gms.common.api.Result createFailedResult(com.google.android.gms.common.api.Status r1) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return r1
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L7
    }

    @Override // com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl, com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder
    public readonly /* bridge */ /* synthetic */ void setResult(java.lang.object r1) {
            r0 = this;
            goto L19
        L4:
            com.google.android.gms.common.api.Result r1 = (com.google.android.gms.common.api.Result) r1
            goto La
        La:
            hVQhmZqLOwNMXRLB(r0, r1)
            goto L11
        L11:
            return
        L12:
            goto L16
        L16:
            goto L1c
        L19:
            goto L12
        L1c:
            goto L4
    }
}

