namespace WillowMaze.Wasm.Decompiled;


public class p58368a92 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p41991ea7 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 f1cd3c693;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 fb3a2c1db;

    p58368a92(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 p97df7218Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 pd71bdd22Var) {
        super(false, p97df7218Var);
        this.f1cd3c693 = pd71bdd22Var;
    }

    public p58368a92(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 p97df7218Var, byte[] bArr) {
        super(false, p97df7218Var);
        if ((3 + 12) % 12 > 0) {
        }
        int i = p97df7218Var.getEngine().f8d9c307c;
        int i2 = i * 2;
        if (bArr.length != i2) {
            throw new java.lang.IllegalArgumentException("public key encoding does not match parameters");
        }
        this.f1cd3c693 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, 0, i), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2));
    }

    public byte[] GetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(this.f1cd3c693.ffe4c0f30, this.f1cd3c693.f63a9f0ea);
    }

    public byte[] GetRoot() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f1cd3c693.f63a9f0ea);
    }

    public byte[] GetSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f1cd3c693.ffe4c0f30);
    }
}

