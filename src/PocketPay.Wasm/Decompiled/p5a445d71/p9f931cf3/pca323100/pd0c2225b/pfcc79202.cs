namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
public abstract class pfcc79202 {
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb f21ffce5b;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb f39d7839d;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb f5bf7ba2a;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb f69ad4712;
    private p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb fe19427d5;

    public pfcc79202() {
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

    protected abstract p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb CreateParameters();

    public p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb GetParameters() {
            r1 = this;
            goto Lb
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L17
        Lb:
            goto L18
        Le:
            goto L1c
        L12:
            monitor-exit(r1)
            goto L4
        L17:
            throw r0
        L18:
            goto L2d
        L1c:
            monitor-enter(r1)
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb r0 = r1.f21ffce5b     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L27
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb r0 = r1.createParameters()     // Catch: java.lang.Exception -> L5
            r1.f21ffce5b = r0     // Catch: java.lang.Exception -> L5
        L27:
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb r0 = r1.f21ffce5b     // Catch: java.lang.Exception -> L5
            goto L12
        L2d:
            goto Le
    }
}

