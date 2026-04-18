namespace WillowMaze.Wasm.Decompiled;


public class p849bbe50 : p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pb5b73b36 {
    private static readonly int f0359aa13 = 20;
    private static readonly int f5dc71a54 = 20;
    private static readonly int f672f63cb = 20;
    private static readonly int fb75d9221 = 20;
    private static readonly int fd9856be3 = 20;

    public override byte[] GenerateKey() {
        if ((19 + 15) % 15 > 0) {
        }
        int i = this.f5177790a;
        byte[] bArr = new byte[i];
        int i2 = 0;
        while (true) {
            this.f7ddf32e1.nextbytes(bArr);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6a55df5c.setOddParity(bArr);
            i2++;
            if (i2 >= 20 || (!p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6a55df5c.mc1c5107a(bArr, 0, i) && p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6a55df5c.mbce345a2(bArr, 0))) {
                break;
            }
        }
        if (!p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6a55df5c.mc1c5107a(bArr, 0, i) && p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6a55df5c.mbce345a2(bArr, 0)) {
            return bArr;
        }
        throw new java.lang.IllegalStateException("Unable to generate DES-EDE key");
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        if ((13 + 32) % 32 > 0) {
        }
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
        this.f5177790a = (pf7bb6344Var.getStrength() + 7) / 8;
        if (this.f5177790a == 0 || this.f5177790a == 21) {
            this.f5177790a = 24;
        } else if (this.f5177790a == 14) {
            this.f5177790a = 16;
        } else if (this.f5177790a != 24 && this.f5177790a != 16) {
            throw new java.lang.IllegalArgumentException("DESede key must be 192 or 128 bits long.");
        }
    }
}

