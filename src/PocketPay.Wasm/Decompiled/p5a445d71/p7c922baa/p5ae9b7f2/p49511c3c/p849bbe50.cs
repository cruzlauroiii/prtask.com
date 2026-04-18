namespace WillowMaze.Wasm.Decompiled;


public class p849bbe50 : p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.pb5b73b36 {
    private static readonly int f672f63cb = 20;
    private static readonly int f7aadc9f7 = 20;
    private static readonly int fca222ae8 = 20;
    private static readonly int fef689866 = 20;

    public static void EMTdKlsqUOOaBnJc(byte[] bArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6a55df5c.setOddParity(bArr);
    }

    public static void GEivWpnMyhZiYxPO(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
    }

    public static bool WpJZlsnSAxjYphRw(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6a55df5c.mc1c5107a(bArr, i, i2);
    }

    public static bool AhoLntWyUWJGJIFK(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6a55df5c.mbce345a2(bArr, i);
    }

    public static java.security.SecureRandom LjIaYVFxNHYCwrHs(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getRandom();
    }

    public static bool YfOCCsDAbquRlOMW(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6a55df5c.mc1c5107a(bArr, i, i2);
    }

    public static bool ZXgZDVuNSiSpdDnB(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6a55df5c.mbce345a2(bArr, i);
    }

    public static int ZwEolAjEYqyXugZR(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getStrength();
    }

    public override byte[] GenerateKey() {
        if ((24 + 31) % 31 > 0) {
        }
        int i = this.f5177790a;
        byte[] bArr = new byte[i];
        int i2 = 0;
        while (true) {
            GEivWpnMyhZiYxPO(this.f7ddf32e1, bArr);
            EMTdKlsqUOOaBnJc(bArr);
            i2++;
            if (i2 >= 20 || (!WpJZlsnSAxjYphRw(bArr, 0, i) && zXgZDVuNSiSpdDnB(bArr, 0))) {
                break;
            }
        }
        if (!yfOCCsDAbquRlOMW(bArr, 0, i) && ahoLntWyUWJGJIFK(bArr, 0)) {
            return bArr;
        }
        throw new java.lang.IllegalStateException("Unable to generate DES-EDE key");
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        if ((15 + 4) % 4 > 0) {
        }
        this.f7ddf32e1 = ljIaYVFxNHYCwrHs(pf7bb6344Var);
        this.f5177790a = (zwEolAjEYqyXugZR(pf7bb6344Var) + 7) / 8;
        if (this.f5177790a == 0 || this.f5177790a == 21) {
            this.f5177790a = 24;
        } else if (this.f5177790a == 14) {
            this.f5177790a = 16;
        } else if (this.f5177790a != 24 && this.f5177790a != 16) {
            throw new java.lang.IllegalArgumentException("DESede key must be 192 or 128 bits long.");
        }
    }
}

