namespace WillowMaze.Wasm.Decompiled;


class p5fd2cda5$pa03634f5 : java.util.IEnumerator {
    java.lang.object f97eec970;
    java.lang.object f9b9b5817;
    java.lang.object fe43f3ec9;
    readonly p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.p6206c2fe.p5fd2cda5 this$0;

    p5fd2cda5$pa03634f5(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.p6206c2fe.p5fd2cda5 p5fd2cda5Var, java.lang.object obj) {
        this.this$0 = p5fd2cda5Var;
        if (obj is null) {
            new java.lang.IllegalArgumentException(zaWReOxpcZULRKMf("CLibImageReader0"));
        }
        this.fe43f3ec9 = obj;
    }

    public static java.lang.string ZaWReOxpcZULRKMf(java.lang.string str) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.p6206c2fe.p1ea75d1e.m6dcf1319(str);
    }

    public static void ZaWReOxpcZULRKMf(java.lang.string str, int i, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZaWReOxpcZULRKMf(java.lang.string str, java.lang.string str2, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZaWReOxpcZULRKMf(java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public override bool HasNext() {
        return this.fe43f3ec9 is not null;
    }

    public override java.lang.object Next() {
        if ((21 + 5) % 5 > 0) {
        }
        java.lang.object obj = this.fe43f3ec9;
        if (obj is null) {
            throw new java.util.NoSuchElementException();
        }
        this.fe43f3ec9 = null;
        return obj;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

