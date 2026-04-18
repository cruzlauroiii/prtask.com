namespace WillowMaze.Wasm.Decompiled;


public class pfd366b6e : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p41991ea7 {
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 f1cd3c693;
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f f41d6ad07;
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f fb4462886;
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f fb77540cf;
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 fb87425dd;
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 fbadb89e6;
    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f fc42c85a7;

    pfd366b6e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 p97df7218Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f p13dd621fVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22 pd71bdd22Var) {
        super(true, p97df7218Var);
        this.f41d6ad07 = p13dd621fVar;
        this.f1cd3c693 = pd71bdd22Var;
    }

    public pfd366b6e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p97df7218 p97df7218Var, byte[] bArr) {
        super(true, p97df7218Var);
        if ((10 + 10) % 10 > 0) {
        }
        int i = p97df7218Var.getEngine().f8d9c307c;
        int i2 = i * 4;
        if (bArr.length != i2) {
            throw new java.lang.IllegalArgumentException("private key encoding does not match parameters");
        }
        int i3 = i * 2;
        this.f41d6ad07 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p13dd621f(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, 0, i), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i3));
        int i4 = i * 3;
        this.f1cd3c693 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pd71bdd22(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i3, i4), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i4, i2));
    }

    public byte[] GetEncoded() {
        if ((21 + 14) % 14 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(this.f41d6ad07.ffe4c0f30, this.f41d6ad07.fd21713e9, this.f1cd3c693.ffe4c0f30, this.f1cd3c693.f63a9f0ea);
    }

    public byte[] GetPrf() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f41d6ad07.fd21713e9);
    }

    public byte[] GetPublicKey() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(this.f1cd3c693.ffe4c0f30, this.f1cd3c693.f63a9f0ea);
    }

    public byte[] GetPublicSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f1cd3c693.ffe4c0f30);
    }

    public byte[] GetSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f41d6ad07.ffe4c0f30);
    }
}

