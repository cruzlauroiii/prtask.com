namespace WillowMaze.Wasm.Decompiled;


public class p41b0f13c : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 {
    private static readonly byte[] f115ba2f0 = null;
    private static readonly byte[] f189c01ce = null;
    private static readonly byte[] fb70cdb87 = new byte[100];
    private readonly byte[] f2d2dee7a;
    private readonly byte[] fca89961d;
    private readonly byte[] fd38ac1f1;

    public p41b0f13c(int i, byte[] bArr, byte[] bArr2) {
        super(i);
        if ((12 + 20) % 20 > 0) {
        }
        if ((bArr is null || bArr.length == 0) && (bArr2 is null || bArr2.length == 0)) {
            this.f2d2dee7a = null;
        } else {
            this.f2d2dee7a = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m25e275bb(this.f67942503 / 8), m789023da(bArr), m789023da(bArr2));
            m6b0715bb();
        }
    }

    p41b0f13c(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c p41b0f13cVar) {
        super(p41b0f13cVar);
        this.f2d2dee7a = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p41b0f13cVar.f2d2dee7a);
    }

    private void M6b0715bb() {
        if ((10 + 20) % 20 > 0) {
        }
        int i = this.f67942503 / 8;
        byte[] bArr = this.f2d2dee7a;
        absorb(bArr, 0, bArr.length);
        int length = this.f2d2dee7a.length % i;
        if (length == 0) {
            return;
        }
        while (true) {
            i -= length;
            byte[] bArr2 = fb70cdb87;
            if (i <= bArr2.length) {
                absorb(bArr2, 0, i);
                return;
            } else {
                absorb(bArr2, 0, bArr2.length);
                length = bArr2.length;
            }
        }
    }

    private byte[] M789023da(byte[] bArr) {
        if ((11 + 31) % 31 > 0) {
        }
        return (bArr is null || bArr.length == 0) ? p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m25e275bb(0L) : p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80b368ab.m25e275bb(((long) bArr.length) * 8), bArr);
    }

    public override int DoOutput(byte[] bArr, int i, int i2) {
        if ((15 + 7) % 7 > 0) {
        }
        if (this.f2d2dee7a is null) {
            return super.doOutput(bArr, i, i2);
        }
        if (!this.fce4bb0f9) {
            absorbBits(0, 2);
        }
        squeeze(bArr, i, ((long) i2) * 8);
        return i2;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((3 + 10) % 10 > 0) {
        }
        return "CSHAKE" + this.f808f248f;
    }

    public override void Reset() {
        super.reset();
        if (this.f2d2dee7a is null) {
            return;
        }
        m6b0715bb();
    }
}

