namespace WillowMaze.Wasm.Decompiled;


public readonly class p72b0865a : p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p2ff1fd7f {
    private static readonly byte[] f0487f08d = null;
    private static readonly byte[] f0e8694bf = null;
    private static readonly byte[] f275330f8 = null;
    private static readonly byte[] fbb5ca23c = null;
    private static readonly byte[] fcf482c58 = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

    public p72b0865a() {
        super(fcf482c58);
    }

    public p72b0865a(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p72b0865a p72b0865aVar) {
        super(fcf482c58);
        YOkMFyaJorJeGkkQ(this, p72b0865aVar);
    }

    public static void YOkMFyaJorJeGkkQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p72b0865a p72b0865aVar, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        p72b0865aVar.reset(p4d7fdfb1Var);
    }

    public static void YOkMFyaJorJeGkkQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p72b0865a p72b0865aVar, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YOkMFyaJorJeGkkQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p72b0865a p72b0865aVar, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YOkMFyaJorJeGkkQ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p72b0865a p72b0865aVar, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IKVCkPIFjJXZYaeK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p2ff1fd7f p2ff1fd7fVar, byte[] bArr, int i) {
        return super.doFinal(bArr, i);
    }

    public static void IKVCkPIFjJXZYaeK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p2ff1fd7f p2ff1fd7fVar, byte[] bArr, int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKVCkPIFjJXZYaeK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p2ff1fd7f p2ff1fd7fVar, byte[] bArr, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKVCkPIFjJXZYaeK(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p2ff1fd7f p2ff1fd7fVar, byte[] bArr, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XeeOqPzsnAtOqTyJ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XeeOqPzsnAtOqTyJ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XeeOqPzsnAtOqTyJ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XeeOqPzsnAtOqTyJ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p72b0865a(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((29 + 2) % 2 > 0) {
        }
        byte[] bArr2 = new byte[64];
        iKVCkPIFjJXZYaeK(this, bArr2, 0);
        xeeOqPzsnAtOqTyJ(bArr2, 32, bArr, i, 32);
        return 32;
    }

    public override java.lang.string GetAlgorithmName() {
        return "GOST3411-2012-256";
    }

    public override int GetDigestSize() {
        return 32;
    }
}

