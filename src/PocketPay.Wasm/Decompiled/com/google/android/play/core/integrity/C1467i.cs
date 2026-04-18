namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.i */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1467i : com.google.android.play.core.integrity.InterfaceC1469k {
    C1467i() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.<init>()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static int JZvLqJoqQAcigqFc(android.os.Dictionary<string, object> r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.getInt(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    @Override // com.google.android.play.core.integrity.InterfaceC1469k
    /* JADX INFO: renamed from: a */
    public readonly com.google.android.gms.common.api.ApiException Mo246a(android.os.Dictionary<string, object> r2) {
            r1 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.string r1 = "error"
            goto L2b
        L19:
            r0.<init>(r1, r2)
            goto Le
        L20:
            return r2
        L21:
            goto L25
        L25:
            com.google.android.play.core.integrity.IntegrityServiceException r0 = new com.google.android.play.core.integrity.IntegrityServiceException
            goto L19
        L2b:
            int r1 = jZvLqJoqQAcigqFc(r2, r1)
            goto L33
        L33:
            r2 = 0
            goto L38
        L38:
            if (r1 == 0) goto L3d
            goto L21
        L3d:
            goto L20
    }
}

