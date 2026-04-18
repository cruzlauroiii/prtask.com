namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public abstract class zzez : java.util.IEnumerator {
    protected zzez() {
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

    @Override // java.util.IEnumerator
    @java.lang.Deprecated
    public readonly void Remove() {
            r0 = this;
            goto La
        L4:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L11
        La:
            goto L1c
        Ld:
            goto L4
        L11:
            r0.<init>()
            goto L1b
        L18:
            goto Ld
        L1b:
            throw r0
        L1c:
            goto L18
    }
}

