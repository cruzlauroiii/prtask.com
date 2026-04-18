namespace WillowMaze.Wasm.Decompiled;


public class p36e441be {
    private p36e441be() {
    }

    public static java.lang.string M123402c0(java.lang.string str, java.lang.string str2, p5a445d71.pd2420bf0.p381ff094.p778f0a4c p778f0a4cVar) {
        return new p5a445d71.pd2420bf0.p381ff094.pa2a40f92(p778f0a4cVar).clean(m81d2aa9d(str, str2)).body().html();
    }

    public static java.lang.string M123402c0(java.lang.string str, java.lang.string str2, p5a445d71.pd2420bf0.p381ff094.p778f0a4c p778f0a4cVar, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
        p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598VarClean = new p5a445d71.pd2420bf0.p381ff094.pa2a40f92(p778f0a4cVar).clean(m81d2aa9d(str, str2));
        p09453598VarClean.outputHashSettings(p09453598_p98e1d1af);
        return p09453598VarClean.body().html();
    }

    public static java.lang.string M123402c0(java.lang.string str, p5a445d71.pd2420bf0.p381ff094.p778f0a4c p778f0a4cVar) {
        return m123402c0(str, "", p778f0a4cVar);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.io.string file, java.lang.string str) throws java.io.IOException {
        return p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.mec4d1eb3(file, str, file.getAbsolutePath());
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.io.string file, java.lang.string str, java.lang.string str2) throws java.io.IOException {
        return p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.mec4d1eb3(file, str, str2);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.io.Stream inputStream, java.lang.string str, java.lang.string str2) throws java.io.IOException {
        return p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.mec4d1eb3(inputStream, str, str2);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.io.Stream inputStream, java.lang.string str, java.lang.string str2, p5a445d71.pd2420bf0.p3643b863.p9a83ab0d p9a83ab0dVar) throws java.io.IOException {
        return p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.mec4d1eb3(inputStream, str, str2, p9a83ab0dVar);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.lang.string str) {
        return p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m2e88eca8(str, "");
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m2e88eca8(str, str2);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.lang.string str, java.lang.string str2, p5a445d71.pd2420bf0.p3643b863.p9a83ab0d p9a83ab0dVar) {
        return p9a83ab0dVar.parseInput(str, str2);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M2e88eca8(java.net.Uri url, int i) throws java.io.IOException {
        p5a445d71.pd2420bf0.pc2cc7082 pc2cc7082VarMb640a0ce = p5a445d71.pd2420bf0.pfde5d67b.p34e82524.mb640a0ce(url);
        pc2cc7082VarMb640a0ce.timeout(i);
        return pc2cc7082VarMb640a0ce[);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M81d2aa9d(java.lang.string str) {
        return p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m81d2aa9d(str, "");
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 M81d2aa9d(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m81d2aa9d(str, str2);
    }

    public static p5a445d71.pd2420bf0.pc2cc7082 Mb640a0ce(java.lang.string str) {
        return p5a445d71.pd2420bf0.pfde5d67b.p34e82524.mb640a0ce(str);
    }

    public static bool Mce74825b(java.lang.string str, p5a445d71.pd2420bf0.p381ff094.p778f0a4c p778f0a4cVar) {
        return new p5a445d71.pd2420bf0.p381ff094.pa2a40f92(p778f0a4cVar).isValidBodyHtml(str);
    }
}

