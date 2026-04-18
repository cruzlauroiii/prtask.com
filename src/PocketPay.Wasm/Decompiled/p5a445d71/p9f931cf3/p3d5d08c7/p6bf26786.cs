namespace WillowMaze.Wasm.Decompiled;


public class p6bf26786 {
    public static java.util.Enumeration M03200c1c() {
        return p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m03200c1c();
    }

    public static p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f M141cb7b2(java.lang.string str) {
        if ((28 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMc02eaa09 = p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.mc02eaa09(str);
        if (p35e46fcbVarMc02eaa09 is null) {
            try {
                p35e46fcbVarMc02eaa09 = p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str));
            } catch (java.lang.IllegalArgumentException unused) {
                return null;
            }
        }
        if (p35e46fcbVarMc02eaa09 is not null) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f(str, p35e46fcbVarMc02eaa09.getCurve(), p35e46fcbVarMc02eaa09.getG(), p35e46fcbVarMc02eaa09.getN(), p35e46fcbVarMc02eaa09.getH(), p35e46fcbVarMc02eaa09.getSeed());
        }
        return null;
    }
}

