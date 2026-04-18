namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzag : com.google.android.gms.common.api.Api.AbstractClientBuilder {
    zzag() {
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
            goto L13
        L13:
            r0.<init>()
            goto L7
    }

    @Override // com.google.android.gms.common.api.Api.AbstractClientBuilder
    public readonly /* synthetic */ com.google.android.gms.common.api.Api.Client buildClient(android.content.object r7, android.os.Looper r8, com.google.android.gms.common.internal.ClientHashSettings r9, java.lang.object r10, com.google.android.gms.common.api.internal.ConnectionCallbacks r11, com.google.android.gms.common.api.internal.OnConnectionFailedListener r12) {
            r6 = this;
            goto L4d
        L4:
            int r0 = r0 + r1
            goto La
        La:
            int r0 = r0 % r1
            goto L10
        L10:
            if (r0 <= 0) goto L15
            goto L3f
        L15:
            goto L3c
        L19:
            goto L50
        L1c:
            r0 = 20
            goto L2e
        L23:
            com.google.android.gms.internal.location.zzg r0 = new com.google.android.gms.internal.location.zzg
            goto L29
        L29:
            r1 = r7
            goto L59
        L2e:
            r1 = 26
            goto L4
        L35:
            goto L3f
        L38:
            goto L19
        L3c:
            goto L49
        L3f:
            goto L5e
        L43:
            r3 = r9
            goto L54
        L48:
            return r0
        L49:
            goto L35
        L4d:
            goto L38
        L50:
            goto L1c
        L54:
            r4 = r11
            goto L6b
        L59:
            r2 = r8
            goto L43
        L5e:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r10 = (com.google.android.gms.common.api.Api.ApiOptions.NoOptions) r10
            goto L23
        L64:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L48
        L6b:
            r5 = r12
            goto L64
    }
}

