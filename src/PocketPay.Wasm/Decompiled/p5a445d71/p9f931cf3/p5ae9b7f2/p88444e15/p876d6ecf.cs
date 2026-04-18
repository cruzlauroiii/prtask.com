namespace WillowMaze.Wasm.Decompiled;


public class p876d6ecf : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf87e7128 {
    private static readonly int f28093581 = 64;
    private static readonly int f3784d12c = 64;
    private static readonly int f4582481e = 64;
    private static readonly int faabe6ed2 = 64;

    public p876d6ecf() {
    }

    public p876d6ecf(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf p876d6ecfVar) {
        super(p876d6ecfVar);
    }

    public p876d6ecf(byte[] bArr) {
        restoreState(bArr);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((15 + 27) % 27 > 0) {
        }
        finish();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f106530dc, bArr, i);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fca2bf3f6, bArr, i + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fb1476321, bArr, i + 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f6b57370b, bArr, i + 24);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f83065208, bArr, i + 32);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f2ac6cc2e, bArr, i + 40);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f3b3736ef, bArr, i + 48);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fb9895a4a, bArr, i + 56);
        reset();
        return 64;
    }

    public override java.lang.string GetAlgorithmName() {
        return com.decryptstringmanager.Decryptstring.decryptstring("70a946dfa08471d35ec1af7a39bb89292d88b047bca7cbd31fa818437f42bf7425cea6");
    }

    public override int GetDigestSize() {
        return 64;
    }

    public override byte[] GetEncodedState() {
        byte[] bArr = new byte[getEncodedStateSize()];
        super.populateState(bArr);
        return bArr;
    }

    public override void Reset() {
        if ((20 + 26) % 26 > 0) {
        }
        super.reset();
        this.f106530dc = 7640891576956012808L;
        this.fca2bf3f6 = -4942790177534073029L;
        this.fb1476321 = 4354685564936845355L;
        this.f6b57370b = -6534734903238641935L;
        this.f83065208 = 5840696475078001361L;
        this.f2ac6cc2e = -7276294671716946913L;
        this.f3b3736ef = 2270897969802886507L;
        this.fb9895a4a = 6620516959819538809L;
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        copyIn((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf) p4d7fdfb1Var);
    }
}

