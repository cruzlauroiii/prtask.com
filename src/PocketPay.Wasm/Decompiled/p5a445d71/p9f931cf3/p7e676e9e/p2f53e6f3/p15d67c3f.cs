namespace WillowMaze.Wasm.Decompiled;


public class p15d67c3f : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f0aab81de;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f9828ba15;

    public p15d67c3f(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        this.f0aab81de = m12cba3ee(p53a5793fVarArr, i, i2);
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] M12cba3ee(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i, int i2) {
        if ((24 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[i2];
        for (int i3 = 0; i3 < i2; i3++) {
            p53a5793fVarArr2[i3] = p53a5793fVarArr[i + i3];
        }
        return p53a5793fVarArr2;
    }

    public override int GetSize() {
        return this.f0aab81de.length;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        throw new java.lang.UnsupportedOperationException("Constant-time lookup not supported");
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        return this.f0aab81de[i];
    }
}

