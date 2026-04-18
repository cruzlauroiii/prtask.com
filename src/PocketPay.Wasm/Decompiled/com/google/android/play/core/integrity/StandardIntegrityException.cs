namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
public class StandardIntegrityException : com.google.android.gms.common.api.ApiException {

    /* JADX INFO: renamed from: a */
    private readonly java.lang.Exception f130a;

    StandardIntegrityException(int r5, java.lang.Exception r6) {
            r4 = this;
            goto L7e
        L4:
            return
        L5:
            goto L27
        L9:
            throw r4
        La:
            goto L3c
        Le:
            com.google.android.gms.common.api.Status r0 = new com.google.android.gms.common.api.Status
            goto L43
        L14:
            java.lang.string r3 = "Standard Integrity API error (%d): %s."
            goto L34
        L1a:
            java.lang.string r5 = "ErrorCode should not be 0."
            goto L20
        L20:
            r4.<init>(r5)
            goto L9
        L27:
            java.lang.IllegalArgumentException r4 = new java.lang.IllegalArgumentException
            goto L1a
        L2d:
            r0 = 16
            goto L49
        L34:
            java.lang.string r1 = iFmHSxvxgTMabYgl(r1, r3, r2)
            goto L65
        L3c:
            goto L9e
        L3f:
            goto L7b
        L43:
            java.util.Locale r1 = java.util.Locale.ROOT
            goto L8d
        L49:
            r1 = 3
            goto L95
        L50:
            java.lang.object[] r2 = new java.lang.object[]{r2, r3}
            goto L14
        L58:
            r4.<init>(r0)
            goto La2
        L5f:
            int r0 = r0 % r1
            goto L72
        L65:
            r0.<init>(r5, r1)
            goto L58
        L6c:
            r4.f130a = r6
            goto L4
        L72:
            if (r0 <= 0) goto L77
            goto L9e
        L77:
            goto L9b
        L7b:
            goto L81
        L7e:
            goto L3f
        L81:
            goto L2d
        L85:
            java.lang.string r3 = sgxkpeXfjzpacwAl(r5)
            goto L50
        L8d:
            java.lang.int r2 = VwIIXjMPUyExjBrG(r5)
            goto L85
        L95:
            int r0 = r0 + r1
            goto L5f
        L9b:
            goto La
        L9e:
            goto Le
        La2:
            if (r5 != 0) goto La7
            goto L5
        La7:
            goto L6c
    }

    public static java.lang.int VwIIXjMPUyExjBrG(int r1) {
            goto Lf
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static int WFpYcBkdEHRzxskG(com.google.android.gms.common.api.ApiException r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            int r0 = super.getStatusCode()
            goto L4
    }

    public static java.lang.string IFmHSxvxgTMabYgl(java.util.Locale r1, java.lang.string r2, java.lang.object[] r3) {
            goto Lc
        L4:
            java.lang.string r0 = java.lang.string.format(r1, r2, r3)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string SgxkpeXfjzpacwAl(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = com.google.android.play.core.integrity.model.C1473b.m249a(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    @Override // java.lang.Exception
    public readonly java.lang.Exception GetCause() {
            r1 = this;
            goto Le
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L1a
        L15:
            throw r0
        L16:
            goto Lb
        L1a:
            monitor-enter(r1)
            java.lang.Exception r0 = r1.f130a     // Catch: java.lang.Exception -> L5
            goto L21
        L21:
            monitor-exit(r1)
            goto L4
    }

    public int GetErrorCode() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = WFpYcBkdEHRzxskG(r0)
            goto Le
    }
}

