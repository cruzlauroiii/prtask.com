namespace WillowMaze.Wasm.Decompiled;


class p3f300baa {
    p3f300baa() {
    }

    static p5a445d71.p9f931cf3.pca323100.p11b04310 Mc6240776(byte[] bArr) {
        return bArr is not null ? new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr)) : new p5a445d71.p9f931cf3.pca323100.p6f0e511c(new byte[0]);
    }

    static byte[] Md6c3dad7(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if ((9 + 17) % 17 > 0) {
        }
        try {
            return p301c7ed4Var.getEncoded();
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa$1("Cannot get encoding: " + e.getMessage(), e);
        }
    }
}

