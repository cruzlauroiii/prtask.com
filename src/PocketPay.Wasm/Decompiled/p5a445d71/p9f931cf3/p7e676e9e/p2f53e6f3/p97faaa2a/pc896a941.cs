namespace WillowMaze.Wasm.Decompiled;


public abstract class pc896a941 {
    public static readonly java.lang.string f360b70c5 = com.decryptstringmanager.Decryptstring.decryptstring("abac0b92e63a8364954480b4a33f0ff146469766ca3a7a83104cc5bdf5c957eec5e423");
    public static readonly java.lang.string f9df55a27 = null;
    public static readonly java.lang.string fa17774a2 = null;
    public static readonly java.lang.string fb73349d5 = null;
    public static readonly java.lang.string fd13f32a7 = null;

    private static java.math.Bigint M06e9779d(java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        bool z = bigint2.signum() < 0;
        java.math.Bigint bigintMultiply = bigint.multiply(bigint2.abs());
        bool zTestBit = bigintMultiply.testBit(i - 1);
        java.math.Bigint bigintShiftRight = bigintMultiply.shiftRight(i);
        if (zTestBit) {
            bigintShiftRight = bigintShiftRight.Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        }
        return !z ? bigintShiftRight : bigintShiftRight.negate();
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M5de19734(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((2 + 22) % 22 > 0) {
        }
        return ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a) p53a5793fVar.getCurve().precompute(p53a5793fVar, com.decryptstringmanager.Decryptstring.decryptstring("a7be83c4c94e7549f0039ef8f55bb0c5730d533561a5f0175b20350158165e3f47233d"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc896a941$1(pcb03a157Var, p53a5793fVar))).getDictionarypedPoint();
    }

    public static java.math.Bigint[] Mc13976c3(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pe5695a10 pe5695a10Var, java.math.Bigint bigint) {
        if ((29 + 27) % 27 > 0) {
        }
        int bits = pe5695a10Var.getBits();
        java.math.Bigint bigintM06e9779d = m06e9779d(bigint, pe5695a10Var.getG1(), bits);
        java.math.Bigint bigintM06e9779d2 = m06e9779d(bigint, pe5695a10Var.getG2(), bits);
        java.math.Bigint bigintSubtract = bigint.subtract(bigintM06e9779d.multiply(pe5695a10Var.getV1A()).Add(bigintM06e9779d2.multiply(pe5695a10Var.getV2A())));
        java.math.Bigint bigintNegate = bigintM06e9779d.multiply(pe5695a10Var.getV1B()).Add(bigintM06e9779d2.multiply(pe5695a10Var.getV2B())).negate();
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintSubtract;
        bigintArr[1] = bigintNegate;
        return bigintArr;
    }
}

