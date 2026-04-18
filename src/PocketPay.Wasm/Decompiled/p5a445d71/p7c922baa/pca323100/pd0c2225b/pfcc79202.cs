namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes10.dex */
public abstract class pfcc79202 {
    private p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb f21ffce5b;
    private p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb f7418ea00;
    private p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb feca84a54;
    private p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb ff4114e11;

    public pfcc79202() {
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

    public static p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb UMAkngtaQvRaiXet(p5a445d71.p7c922baa.pca323100.pd0c2225b.pfcc79202 r1) {
            goto Lf
        L4:
            p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb r0 = r1.createParameters()
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

    public static void UMAkngtaQvRaiXet(p5a445d71.p7c922baa.pca323100.pd0c2225b.pfcc79202 r0, float r1, short r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        La:
            goto L2c
        Ld:
            int r3 = r2 + r1
            goto L18
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            r0 = 42
            goto L4
        L23:
            int r2 = r0 * r1
            goto Ld
        L29:
            goto L14
        L2c:
            goto L1d
    }

    public static void UMAkngtaQvRaiXet(p5a445d71.p7c922baa.pca323100.pd0c2225b.pfcc79202 r0, java.lang.string r1, float r2, short r3, int r4) {
            goto L9
        L4:
            return
        L5:
            goto L1b
        L9:
            goto L5
        Lc:
            goto L24
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto Lc
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void UMAkngtaQvRaiXet(p5a445d71.p7c922baa.pca323100.pd0c2225b.pfcc79202 r0, short r1, float r2, java.lang.string r3, int r4) {
            goto L1e
        L4:
            goto L21
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            r0 = 42
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            goto L14
        L21:
            goto Ld
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    protected abstract p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb CreateParameters();

    public p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb GetParameters() {
            r1 = this;
            goto L1f
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L2b
        Lb:
            goto L22
        Le:
            monitor-enter(r1)
            p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb r0 = r1.f21ffce5b     // Catch: java.lang.Exception -> L5
            if (r0 != 0) goto L19
            p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb r0 = uMAkngtaQvRaiXet(r1)     // Catch: java.lang.Exception -> L5
            r1.f21ffce5b = r0     // Catch: java.lang.Exception -> L5
        L19:
            p5a445d71.p7c922baa.pca323100.pd0c2225b.p35e46fcb r0 = r1.f21ffce5b     // Catch: java.lang.Exception -> L5
            goto L26
        L1f:
            goto L2c
        L22:
            goto Le
        L26:
            monitor-exit(r1)
            goto L4
        L2b:
            throw r0
        L2c:
            goto Lb
    }
}

