namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
readonly class zzbf : com.google.android.gms.common.api.Api.AbstractClientBuilder {
    zzbf() {
            r0 = this;
            goto Le
        L4:
            r0.<init>()
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

    @Override // com.google.android.gms.common.api.Api.AbstractClientBuilder
    public readonly /* synthetic */ com.google.android.gms.common.api.Api.Client buildClient(android.content.object r7, android.os.Looper r8, com.google.android.gms.common.internal.ClientHashSettings r9, java.lang.object r10, com.google.android.gms.common.api.internal.ConnectionCallbacks r11, com.google.android.gms.common.api.internal.OnConnectionFailedListener r12) {
            r6 = this;
            goto L1e
        L4:
            r4 = r11
            goto L3f
        L9:
            return r0
        La:
            goto L62
        Le:
            goto L21
        L11:
            r0 = 8
            goto L50
        L18:
            int r0 = r0 % r1
            goto L30
        L1e:
            goto L65
        L21:
            goto L11
        L25:
            r3 = r9
            goto L4
        L2a:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r10 = (com.google.android.gms.common.api.Api.ApiOptions.NoOptions) r10
            goto L5c
        L30:
            if (r0 <= 0) goto L35
            goto L6c
        L35:
            goto L69
        L39:
            int r0 = r0 + r1
            goto L18
        L3f:
            r5 = r12
            goto L49
        L44:
            r1 = r7
            goto L57
        L49:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L9
        L50:
            r1 = 23
            goto L39
        L57:
            r2 = r8
            goto L25
        L5c:
            com.google.android.gms.internal.location.zzdz r0 = new com.google.android.gms.internal.location.zzdz
            goto L44
        L62:
            goto L6c
        L65:
            goto Le
        L69:
            goto La
        L6c:
            goto L2a
    }
}

