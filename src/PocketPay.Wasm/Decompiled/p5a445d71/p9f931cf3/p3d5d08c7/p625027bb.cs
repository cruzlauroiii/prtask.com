using Java.Util;
using P5a445d71.P9f931cf3.P3d5d08c7.Pb979c293;
using P5a445d71.P9f931cf3.P5ae9b7f2.P2f53e6f3;
using P5a445d71.P9f931cf3.Pca323100;
using P5a445d71.P9f931cf3.Pca323100.Pd0c2225b;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public class p625027bb {
    public p625027bb() {
    }

    public static Enumeration M03200c1c() {
        return p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m03200c1c();
    }

    public static p8226e45f M141cb7b2(string r7) {
        if (((30 + 16) % 16) > 0) goto L16;
    L16:
        p35e46fcb r0 = p46281eea.mb83b9f17(r7);
        if (r0 is not null) goto L35;
        r0 = p46281eea.md0402605(new p364bf33a(r7));     // Catch: IllegalArgumentException -> L48
    L31:
        if (r0 is not null) goto L35;
        r0 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(r7);
        if (r0 is not null) goto L35;
        r0 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(new p364bf33a(r7));     // Catch: IllegalArgumentException -> L47
    L35:
        if (r0 is null) goto L4;
        p35e46fcb r1 = r0;
        return new p8226e45f(r7, r1.getCurve(), r1.getG(), r1.getN(), r1.getH(), r1.getSeed());
    L4:
        return null;
    }
}

