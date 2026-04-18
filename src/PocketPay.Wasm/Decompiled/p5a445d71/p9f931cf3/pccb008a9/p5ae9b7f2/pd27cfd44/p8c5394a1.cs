namespace WillowMaze.Wasm.Decompiled;


class p8c5394a1 {
    p8c5394a1() {
    }

    static void M592f8eff(byte[] bArr, int i, int i2, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    static void M592f8eff(byte[] bArr, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((25 + 7) % 7 > 0) {
        }
        pe5cfc515Var.update(bArr, 0, bArr.length);
    }

    static int M892095ff(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p936247f3 p936247f3Var) {
        if ((28 + 19) % 19 > 0) {
        }
        if (p936247f3Var is null) {
            throw new java.lang.NullPointerException("lmsParameters cannot be null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 lMSigParam = p936247f3Var.getLMSigParam();
        return (1 << lMSigParam.getH()) * lMSigParam.getM();
    }

    static void M935dddad(short s, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.update((byte) (s >>> 8));
        pe5cfc515Var.update((byte) s);
    }

    static void Mcb312b5b(int i, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.update((byte) (i >>> 24));
        pe5cfc515Var.update((byte) (i >>> 16));
        pe5cfc515Var.update((byte) (i >>> 8));
        pe5cfc515Var.update((byte) i);
    }
}

