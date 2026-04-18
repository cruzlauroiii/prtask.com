namespace WillowMaze.Wasm.Decompiled;


abstract class p7083ab56 : p5a445d71.p9f931cf3.pca323100.pa9927241 {
    readonly p5a445d71.p9f931cf3.pca323100.p07eba420 f2a55a2f4;
    readonly p5a445d71.p9f931cf3.pca323100.p07eba420 fe4d23e84;
    readonly p5a445d71.p9f931cf3.pca323100.p07eba420 ff9344a0f;

    p7083ab56(java.lang.Class cls, int i) {
        super(cls);
        this.fe4d23e84 = NRSBXMbixkpfdzlK(0, i);
    }

    public static java.lang.Class BMHscYGDuBTRPgOI(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p07eba420 NRSBXMbixkpfdzlK(int i, int i2) {
        return p5a445d71.p9f931cf3.pca323100.p07eba420.m76ea0beb(i, i2);
    }

    public static java.lang.stringBuilder UVozIIbtncAQVNvU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VwiHCEQVIFUTeRCC(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static int AChZWbrEDraCavhk(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagClass();
    }

    public static java.lang.string ARytLxZJIqznMxaS(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string CfFkhnKXgGOHLRTd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 EiaftTIUjTBJnpQn(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p7083ab56Var.checkedCast(p301c7ed4Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 SZFrTkNLtCtbkywL(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 VrDAycBUVzTzLLCH(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z, p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var) {
        return p582a4948Var.getBaseUniversal(z, p7083ab56Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 YVocuNLLaYZKxQjn(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p7083ab56Var.checkedCast(p301c7ed4Var);
    }

    readonly p5a445d71.p9f931cf3.pca323100.p301c7ed4 checkedCast(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if ((8 + 24) % 24 > 0) {
        }
        if (VwiHCEQVIFUTeRCC(this.fcccb538e, p301c7ed4Var)) {
            return p301c7ed4Var;
        }
        throw new java.lang.IllegalStateException(cfFkhnKXgGOHLRTd(UVozIIbtncAQVNvU(new java.lang.stringBuilder("unexpected object: "), aRytLxZJIqznMxaS(BMHscYGDuBTRPgOI(p301c7ed4Var)))));
    }

    readonly p5a445d71.p9f931cf3.pca323100.p301c7ed4 frombyteArray(byte[] bArr) throws java.io.IOException {
        return eiaftTIUjTBJnpQn(this, sZFrTkNLtCtbkywL(bArr));
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 fromImplicitConstructed(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        throw new java.lang.IllegalStateException("unexpected implicit constructed encoding");
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 fromImplicitPrimitive(p5a445d71.p9f931cf3.pca323100.p6f0e511c p6f0e511cVar) {
        throw new java.lang.IllegalStateException("unexpected implicit primitive encoding");
    }

    readonly p5a445d71.p9f931cf3.pca323100.p301c7ed4 getobjectInstance(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        if ((8 + 11) % 11 > 0) {
        }
        if (128 != aChZWbrEDraCavhk(p582a4948Var)) {
            throw new java.lang.IllegalStateException("this method only valid for CONTEXT_SPECIFIC tags");
        }
        return yVocuNLLaYZKxQjn(this, vrDAycBUVzTzLLCH(p582a4948Var, z, this));
    }

    readonly p5a445d71.p9f931cf3.pca323100.p07eba420 getTag() {
        return this.fe4d23e84;
    }
}

