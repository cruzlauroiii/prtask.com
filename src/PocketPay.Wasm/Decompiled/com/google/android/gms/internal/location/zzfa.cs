namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public abstract class zzfa : com.google.android.gms.internal.location.zzez : java.util.ListIEnumerator {
    protected zzfa() {
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

    @Override // java.util.ListIEnumerator
    @java.lang.Deprecated
    public readonly void Add(java.lang.object r1) {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L12
        Lb:
            goto L13
        Le:
            goto L1a
        L12:
            throw r0
        L13:
            goto L17
        L17:
            goto Le
        L1a:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L4
    }

    @Override // java.util.ListIEnumerator
    @java.lang.Deprecated
    public readonly void Set(java.lang.object r1) {
            r0 = this;
            goto L19
        L4:
            r0.<init>()
            goto L11
        Lb:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L4
        L11:
            throw r0
        L12:
            goto L16
        L16:
            goto L1c
        L19:
            goto L12
        L1c:
            goto Lb
    }
}

