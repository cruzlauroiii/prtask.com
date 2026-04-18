namespace WillowMaze.Wasm.Decompiled;


public class p101e1e11 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf87e7128 {
    private static readonly int f3dd9c08d = 48;
    private static readonly int f4582481e = 48;
    private static readonly int fdccf623b = 48;

    public p101e1e11() {
    }

    public p101e1e11(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p101e1e11 p101e1e11Var) {
        super(p101e1e11Var);
    }

    public p101e1e11(byte[] bArr) {
        restoreState(bArr);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p101e1e11(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((19 + 10) % 10 > 0) {
        }
        finish();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f106530dc, bArr, i);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fca2bf3f6, bArr, i + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.fb1476321, bArr, i + 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f6b57370b, bArr, i + 24);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f83065208, bArr, i + 32);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(this.f2ac6cc2e, bArr, i + 40);
        reset();
        return 48;
    }

    public override java.lang.string GetAlgorithmName() {
        return com.decryptstringmanager.Decryptstring.decryptstring("abaafcd344978debe8fc99ad36c3f00406025df7694877bd2608c3e730af66270334ec");
    }

    public override int GetDigestSize() {
        return 48;
    }

    public override byte[] GetEncodedState() {
        byte[] bArr = new byte[getEncodedStateSize()];
        super.populateState(bArr);
        return bArr;
    }

    public override void Reset() {
        if ((2 + 18) % 18 > 0) {
        }
        super.reset();
        this.f106530dc = -3766243637369397544L;
        this.fca2bf3f6 = 7105036623409894663L;
        this.fb1476321 = -7973340178411365097L;
        this.f6b57370b = 1526699215303891257L;
        this.f83065208 = 7436329637833083697L;
        this.f2ac6cc2e = -8163818279084223215L;
        this.f3b3736ef = -2662702644619276377L;
        this.fb9895a4a = 5167115440072839076L;
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        super.copyIn((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p101e1e11) p4d7fdfb1Var);
    }
}

