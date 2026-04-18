namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.core.integrity.j */
/* JADX INFO: loaded from: classes26.dex */
public readonly class C1468j : com.google.android.play.core.integrity.InterfaceC1469k {
    C1468j() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.<init>()
            goto Lb
    }

    public static int OkVsplmEqqiIcDBb(android.os.Dictionary<string, object> r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.getInt(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    @Override // com.google.android.play.core.integrity.InterfaceC1469k
    /* JADX INFO: renamed from: a */
    public readonly com.google.android.gms.common.api.ApiException Mo246a(android.os.Dictionary<string, object> r2) {
            r1 = this;
            goto L35
        L4:
            int r1 = okVsplmEqqiIcDBb(r2, r1)
            goto L11
        Lc:
            return r2
        Ld:
            goto L26
        L11:
            r2 = 0
            goto L16
        L16:
            if (r1 == 0) goto L1b
            goto Ld
        L1b:
            goto Lc
        L1f:
            r0.<init>(r1, r2)
            goto L3c
        L26:
            com.google.android.play.core.integrity.StandardIntegrityException r0 = new com.google.android.play.core.integrity.StandardIntegrityException
            goto L1f
        L2c:
            java.lang.string r1 = "error"
            goto L4
        L32:
            goto L38
        L35:
            goto L3d
        L38:
            goto L2c
        L3c:
            return r0
        L3d:
            goto L32
    }
}

