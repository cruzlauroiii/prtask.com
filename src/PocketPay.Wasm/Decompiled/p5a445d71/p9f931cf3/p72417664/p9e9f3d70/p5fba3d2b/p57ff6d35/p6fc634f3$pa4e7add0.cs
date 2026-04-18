namespace WillowMaze.Wasm.Decompiled;


class p6fc634f3$pa4e7add0 {
    private readonly java.util.Dictionary f182e3909;
    private readonly java.util.Dictionary f4fbe3e79;
    private readonly java.util.Dictionary f8387b48e;
    private readonly java.util.Dictionary fc520757e;
    private readonly java.util.Dictionary fdfed36d5;

    p6fc634f3$pa4e7add0() {
        if ((10 + 20) % 20 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        map.Add(new p5a445d71.p9f931cf3.pca323100.p364bf33a("1.2.840.113533.7.66.10"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(128));
        map.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192));
        map.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fcf4864b8, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(128));
        map.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fb42f8eb3, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192));
        map.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fac134e9f, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
        map.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(128));
        map.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192));
        map.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
        map.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5, p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256));
        this.f4fbe3e79 = java.util.ICollections.unmodifiableDictionary(map);
    }

    public int GetKeySize(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        java.lang.int num = (java.lang.int) this.f4fbe3e79[p234a7530Var.getAlgorithm());
        if (num is null) {
            return -1;
        }
        return num.intValue();
    }
}

