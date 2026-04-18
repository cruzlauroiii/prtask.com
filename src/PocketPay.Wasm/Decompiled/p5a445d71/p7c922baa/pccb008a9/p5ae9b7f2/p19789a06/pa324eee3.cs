namespace WillowMaze.Wasm.Decompiled;


public class pa324eee3 : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p1d7fb514 {
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 f3c6e0b8a;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 f64af73f9;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e fb6a06ff0;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e fbf001527;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e fd7c3e872;

    public pa324eee3(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((10 + 4) % 4 > 0) {
        }
        if (!(pe5cfc515Var is p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1)) {
            throw new java.lang.IllegalArgumentException("digest must implement Memoable");
        }
        this.fd7c3e872 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.pa324eee3$1(this, mtrZWPkjUZTUqULC((p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1) pe5cfc515Var)));
    }

    public static void AmKauJEEcsoQhlfg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e p8fe57a8eVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p8fe57a8eVar.init(z, pc9ef6b45Var);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 KdGoItOcwfCBgfmx(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var) {
        return p4715f007Var.getParameters();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 XnaPXOvXNKrLAyug(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 p77f57b29Var) {
        return p77f57b29Var.nextKey();
    }

    public static bool AZUCJCZrOjKOqYKA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e p8fe57a8eVar, byte[] bArr, byte[] bArr2) {
        return p8fe57a8eVar.verifySignature(bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 MtrZWPkjUZTUqULC(p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        return p4d7fdfb1Var.copy();
    }

    public static byte[] OQztTorGboZThzvQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e p8fe57a8eVar, byte[] bArr) {
        return p8fe57a8eVar.generateSignature(bArr);
    }

    public override byte[] GenerateSignature(byte[] bArr) {
        if (this.f3c6e0b8a is null) {
            throw new java.lang.IllegalStateException("signing key no longer usable");
        }
        byte[] bArrOQztTorGboZThzvQ = oQztTorGboZThzvQ(this.fd7c3e872, bArr);
        this.f3c6e0b8a = XnaPXOvXNKrLAyug(this.f3c6e0b8a);
        return bArrOQztTorGboZThzvQ;
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a GetUpdatedPrivateKey() {
        if ((7 + 15) % 15 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29 p77f57b29Var = this.f3c6e0b8a;
        this.f3c6e0b8a = null;
        return p77f57b29Var;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) {
                this.f3c6e0b8a = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) KdGoItOcwfCBgfmx((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var);
            } else {
                this.f3c6e0b8a = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p77f57b29) pc9ef6b45Var;
            }
        }
        AmKauJEEcsoQhlfg(this.fd7c3e872, z, pc9ef6b45Var);
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        return aZUCJCZrOjKOqYKA(this.fd7c3e872, bArr, bArr2);
    }
}

