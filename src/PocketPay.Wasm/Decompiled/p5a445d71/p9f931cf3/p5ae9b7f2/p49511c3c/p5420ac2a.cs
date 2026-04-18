namespace WillowMaze.Wasm.Decompiled;


public class p5420ac2a : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f112cdbc0;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1a0eb48c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f447db78d;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe223d1e8;

    public p5420ac2a() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.ma500566e());
    }

    public p5420ac2a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    private byte[] Mde3e38ba(int i) {
        if ((32 + 25) % 25 > 0) {
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr = new byte[digestSize];
        byte[] bArr2 = new byte[i];
        int i2 = 0;
        while (true) {
            this.fc10f7796.update(this.f5f4dcc3b, 0, this.f5f4dcc3b.length);
            this.fc10f7796.update(this.fceb20772, 0, this.fceb20772.length);
            this.fc10f7796.doFinal(bArr, 0);
            int i3 = i <= digestSize ? i : digestSize;
            java.lang.System.arraycopy(bArr, 0, bArr2, i2, i3);
            i2 += i3;
            i -= i3;
            if (i == 0) {
                return bArr2;
            }
            this.fc10f7796.reset();
            this.fc10f7796.update(bArr, 0, digestSize);
        }
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        return generateDerivedParameters(i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((16 + 9) % 9 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(i2), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((28 + 22) % 22 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        byte[] bArrMde3e38ba = mde3e38ba(i3 + i4);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArrMde3e38ba, 0, i3), bArrMde3e38ba, i3, i4);
    }

    public void Init(byte[] bArr, byte[] bArr2) {
        super.init(bArr, bArr2, 1);
    }
}

