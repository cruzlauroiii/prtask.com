namespace WillowMaze.Wasm.Decompiled;


public class p1051c8d5 : p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p8b9ea2ac {
    public p1051c8d5(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var) {
        super(p38d4f313Var, p07d32999Var, p1748c064Var);
    }

    public p1051c8d5(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        super(p38d4f313Var, p07d32999Var, p1748c064Var, p66d30ee8Var);
    }

    public static void CkVLQzTqkmHwfZqw(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static void CkVLQzTqkmHwfZqw(int i, byte[] bArr, int i2, short s, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CkVLQzTqkmHwfZqw(int i, byte[] bArr, int i2, short s, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CkVLQzTqkmHwfZqw(int i, byte[] bArr, int i2, bool z, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    protected override byte[] GetLengthTag(byte[] bArr) {
        byte[] bArr2 = new byte[4];
        if (bArr is not null) {
            ckVLQzTqkmHwfZqw(bArr.length * 8, bArr2, 0);
        }
        return bArr2;
    }
}

