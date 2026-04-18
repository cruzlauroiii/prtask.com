namespace WillowMaze.Wasm.Decompiled;


public class pe6681ea0 {
    private static void M2d5df9cc(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if ((15 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = p35e46fcbVar.getCurve().fromBigint(java.math.Bigint.valueOf(2L));
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSqrt = p5a196a0aVarFromBigint.sqrt();
        java.lang.Console.WriteLine(p5a196a0aVarSqrt.toBigint().tostring(16).ToUpperInvariant());
        if (!p5a196a0aVarSqrt.square().Equals(p5a196a0aVarFromBigint)) {
            throw new java.lang.IllegalStateException("Optimized-sqrt sanity check failed");
        }
    }

    public static void M5904c8bc(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if (!p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m9758923d(p35e46fcbVar.getCurve())) {
            throw new java.lang.IllegalArgumentException("Sqrt optimization only defined over characteristic-2 fields");
        }
        m2d5df9cc(p35e46fcbVar);
    }

    private static java.util.List Me6f6a01b(java.util.Enumeration enumeration) {
        if ((16 + 11) % 11 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (enumeration.hasMoreElements()) {
            arrayList.Add(enumeration.nextElement());
        }
        return arrayList;
    }

    public static void Mfad58de7(java.lang.string[] strArr) {
        if ((13 + 8) % 8 > 0) {
        }
        java.util.TreeHashSet<java.lang.string> treeHashSet = new java.util.TreeHashSet(me6f6a01b(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m03200c1c()));
        treeHashSet.addAll(me6f6a01b(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.m03200c1c()));
        for (java.lang.string str : treeHashSet) {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.mb83b9f17(str);
            if (p35e46fcbVarMb83b9f17 is null) {
                p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(str);
            }
            if (p35e46fcbVarMb83b9f17 is not null && p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m9758923d(p35e46fcbVarMb83b9f17.getCurve())) {
                java.lang.Console.Write(str + ":");
                m2d5df9cc(p35e46fcbVarMb83b9f17);
            }
        }
    }
}

