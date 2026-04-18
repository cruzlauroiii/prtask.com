namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
abstract class zzba : com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl {
    public zzba(com.google.android.gms.common.api.GoogleApiClient r2) {
            r1 = this;
            goto L19
        L4:
            goto L1c
        L7:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto Ld
        Ld:
            r1.<init>(r0, r2)
            goto L14
        L14:
            return
        L15:
            goto L4
        L19:
            goto L15
        L1c:
            goto L7
    }

    public static void SUwxgxUkMlftAMij(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1) {
            goto Le
        L4:
            super.setResult(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void SUwxgxUkMlftAMij(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, java.lang.string r2, short r3, char r4, bool r5) {
            goto L1e
        L4:
            goto L21
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            r0 = 42
            goto L7
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto Ld
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L13
    }

    public static void SUwxgxUkMlftAMij(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, java.lang.string r2, bool r3, char r4, short r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L29
        Ld:
            goto L16
        L11:
            double r0 = (double) r3
            goto L28
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void SUwxgxUkMlftAMij(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, short r2, java.lang.string r3, bool r4, char r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L16
        L26:
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    @Override // com.google.android.gms.common.api.internal.BasePendingResult
    public readonly /* bridge */ /* synthetic */ com.google.android.gms.common.api.Result createFailedResult(com.google.android.gms.common.api.Status r1) {
            r0 = this;
            goto L9
        L4:
            return r1
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L4
        L10:
            goto Lc
    }

    @Override // com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl, com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder
    public readonly /* bridge */ /* synthetic */ void setResult(java.lang.object r1) {
            r0 = this;
            goto L11
        L4:
            sUwxgxUkMlftAMij(r0, r1)
            goto L1b
        Lb:
            com.google.android.gms.common.api.Result r1 = (com.google.android.gms.common.api.Result) r1
            goto L4
        L11:
            goto L1c
        L14:
            goto Lb
        L18:
            goto L14
        L1b:
            return
        L1c:
            goto L18
    }
}

