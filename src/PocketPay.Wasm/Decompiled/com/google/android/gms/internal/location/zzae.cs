namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
abstract class zzae : com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl {
    public zzae(com.google.android.gms.common.api.GoogleApiClient r2) {
            r1 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1a
        L10:
            goto Lc
        L13:
            r1.<init>(r0, r2)
            goto L4
        L1a:
            com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> r0 = com.google.android.gms.location.objectRecognition.API
            goto L13
    }

    public static void TSaGtBEKDlqvjfrd(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            super.setResult(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void TSaGtBEKDlqvjfrd(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, byte r2, int r3, bool r4, short r5) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto Lc
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void TSaGtBEKDlqvjfrd(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, short r2, int r3, byte r4, bool r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            r0 = 42
            goto L1f
        L10:
            goto L2c
        L13:
            goto La
        L17:
            goto L13
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L17
    }

    public static void TSaGtBEKDlqvjfrd(com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl r0, com.google.android.gms.common.api.Result r1, short r2, int r3, bool r4, byte r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1e:
            goto L14
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r0 = 42
            goto L18
    }

    @Override // com.google.android.gms.common.api.internal.BasePendingResult
    public readonly /* bridge */ /* synthetic */ com.google.android.gms.common.api.Result createFailedResult(com.google.android.gms.common.api.Status r1) {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            return r1
        Lf:
            goto Lb
    }

    @Override // com.google.android.gms.common.api.internal.BaseImplementation.ApiMethodImpl, com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder
    public readonly /* bridge */ /* synthetic */ void setResult(java.lang.object r1) {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            tSaGtBEKDlqvjfrd(r0, r1)
            goto Le
        L1a:
            com.google.android.gms.common.api.Result r1 = (com.google.android.gms.common.api.Result) r1
            goto L13
    }
}

