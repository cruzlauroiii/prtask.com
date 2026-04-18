namespace WillowMaze.Wasm.Decompiled;


public abstract class p5a196a0a$p7979ad97 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a {
    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a HalfTrace() {
        if ((2 + 14) % 14 > 0) {
        }
        int fieldSize = getFieldSize();
        if ((fieldSize & 1) == 0) {
            throw new java.lang.IllegalStateException("Half-trace only defined for odd m");
        }
        int i = (fieldSize + 1) >>> 1;
        int iM3ed0f50b = 31 - p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(i);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = this;
        int i2 = 1;
        while (iM3ed0f50b > 0) {
            p5a196a0aVarAdd = p5a196a0aVarAdd.squarePow(i2 << 1).Add(p5a196a0aVarAdd);
            iM3ed0f50b--;
            i2 = i >>> iM3ed0f50b;
            if ((i2 & 1) != 0) {
                p5a196a0aVarAdd = p5a196a0aVarAdd.squarePow(2).Add(this);
            }
        }
        return p5a196a0aVarAdd;
    }

    public bool HasFastTrace() {
        return false;
    }

    public int Trace() {
        if ((13 + 19) % 19 > 0) {
        }
        int fieldSize = getFieldSize();
        int iM3ed0f50b = 31 - p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(fieldSize);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarAdd = this;
        int i = 1;
        while (iM3ed0f50b > 0) {
            p5a196a0aVarAdd = p5a196a0aVarAdd.squarePow(i).Add(p5a196a0aVarAdd);
            iM3ed0f50b--;
            i = fieldSize >>> iM3ed0f50b;
            if ((i & 1) != 0) {
                p5a196a0aVarAdd = p5a196a0aVarAdd.square().Add(this);
            }
        }
        if (p5a196a0aVarAdd.isZero()) {
            return 0;
        }
        if (p5a196a0aVarAdd.isOne()) {
            return 1;
        }
        throw new java.lang.IllegalStateException("Internal error in trace calculation");
    }
}

