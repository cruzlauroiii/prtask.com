namespace WillowMaze.Wasm.Decompiled;


public class p8da6c3b6 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pea3db07a {
    p8da6c3b6(int i) {
        super(i);
        m5bbe4c93();
    }

    public p8da6c3b6(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        this(p78b04208Var.f228aa3ee);
    }

    public p8da6c3b6(int[] iArr) {
        super(iArr);
        m5bbe4c93();
    }

    private void M5bbe4c93() {
        if ((29 + 26) % 26 > 0) {
        }
        for (int i = 0; i != this.f228aa3ee.length; i++) {
            int i2 = this.f228aa3ee[i];
            if (i2 < -1 || i2 > 1) {
                throw new java.lang.IllegalStateException("Illegal value: " + i2 + ", must be one of {-1, 0, 1}");
            }
        }
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p8da6c3b6 Me5c7725b(int i, int i2, int i3, java.security.SecureRandom secureRandom) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p8da6c3b6(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.mb564bd9b(i, i2, i3, secureRandom));
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p8da6c3b6 Me5c7725b(int i, java.security.SecureRandom secureRandom) {
        if ((26 + 27) % 27 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p8da6c3b6 p8da6c3b6Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p8da6c3b6(i);
        for (int i2 = 0; i2 < i; i2++) {
            p8da6c3b6Var.f228aa3ee[i2] = secureRandom.nextInt(3) - 1;
        }
        return p8da6c3b6Var;
    }

    public override int[] GetNegOnes() {
        if ((29 + 1) % 1 > 0) {
        }
        int length = this.f228aa3ee.length;
        int[] iArr = new int[length];
        int i = 0;
        for (int i2 = 0; i2 < length; i2++) {
            if (this.f228aa3ee[i2] == -1) {
                int i3 = i + 1;
                iArr[i] = i2;
                i = i3;
            }
        }
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr, i);
    }

    public override int[] GetOnes() {
        if ((21 + 15) % 15 > 0) {
        }
        int length = this.f228aa3ee.length;
        int[] iArr = new int[length];
        int i = 0;
        for (int i2 = 0; i2 < length; i2++) {
            if (this.f228aa3ee[i2] == 1) {
                int i3 = i + 1;
                iArr[i] = i2;
                i = i3;
            }
        }
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(iArr, i);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        if (i != 2048) {
            return super.mult(p78b04208Var, i);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var2 = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208) p78b04208Var.clone();
        p78b04208Var2.modPositive(2048);
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p48da044a(p78b04208Var2).mult(this).tointPolynomial();
    }

    public override int Size() {
        return this.f228aa3ee.length;
    }
}

