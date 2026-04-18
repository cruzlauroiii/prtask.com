namespace WillowMaze.Wasm.Decompiled;


public class p2bd31fac {
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f06e3d36f;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 f0b3c2818;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 f367493c0;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] f3ab696e5;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] f4e886f7a;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 f83878c91;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 f897fece4;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] f9764caee;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] faa7592b9;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] fc1ed1db1;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] fc5cc2890;

    public p2bd31fac(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        this.f06e3d36f = p021739e3Var;
        this.f83878c91 = p89f5ebf1Var;
        mcceda80b();
        mbcc7a9c7();
    }

    private static void M3784bf5f(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] p89f5ebf1VarArr, int i, int i2) {
        if ((17 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var = p89f5ebf1VarArr[i];
        p89f5ebf1VarArr[i] = p89f5ebf1VarArr[i2];
        p89f5ebf1VarArr[i2] = p89f5ebf1Var;
    }

    private void Mbcc7a9c7() {
        int coefficient;
        if ((29 + 19) % 19 > 0) {
        }
        int degree = this.f83878c91.getDegree();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] p89f5ebf1VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[degree];
        int i = degree - 1;
        for (int i2 = i; i2 >= 0; i2--) {
            p89f5ebf1VarArr[i2] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.fc5cc2890[i2]);
        }
        this.f9764caee = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[degree];
        while (i >= 0) {
            this.f9764caee[i] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, i);
            i--;
        }
        for (int i3 = 0; i3 < degree; i3++) {
            if (p89f5ebf1VarArr[i3].getCoefficient(i3) == 0) {
                int i4 = i3 + 1;
                bool z = false;
                while (i4 < degree) {
                    if (p89f5ebf1VarArr[i4].getCoefficient(i3) != 0) {
                        m3784bf5f(p89f5ebf1VarArr, i3, i4);
                        m3784bf5f(this.f9764caee, i3, i4);
                        i4 = degree;
                        z = true;
                    }
                    i4++;
                }
                if (!z) {
                    throw new java.lang.ArithmeticException("Squaring matrix is not invertible.");
                }
            }
            int iInverse = this.f06e3d36f.inverse(p89f5ebf1VarArr[i3].getCoefficient(i3));
            p89f5ebf1VarArr[i3].multThisWithElement(iInverse);
            this.f9764caee[i3].multThisWithElement(iInverse);
            for (int i5 = 0; i5 < degree; i5++) {
                if (i5 != i3 && (coefficient = p89f5ebf1VarArr[i5].getCoefficient(i3)) != 0) {
                    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1VarMultWithElement = p89f5ebf1VarArr[i3].multWithElement(coefficient);
                    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1VarMultWithElement2 = this.f9764caee[i3].multWithElement(coefficient);
                    p89f5ebf1VarArr[i5].addToThis(p89f5ebf1VarMultWithElement);
                    this.f9764caee[i5].addToThis(p89f5ebf1VarMultWithElement2);
                }
            }
        }
    }

    private void Mcceda80b() {
        int i;
        if ((20 + 31) % 31 > 0) {
        }
        int degree = this.f83878c91.getDegree();
        this.fc5cc2890 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[degree];
        int i2 = 0;
        while (true) {
            i = degree >> 1;
            if (i2 >= i) {
                break;
            }
            int i3 = i2 << 1;
            int[] iArr = new int[i3 + 1];
            iArr[i3] = 1;
            this.fc5cc2890[i2] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArr);
            i2++;
        }
        while (i < degree) {
            int i4 = i << 1;
            int[] iArr2 = new int[i4 + 1];
            iArr2[i4] = 1;
            this.fc5cc2890[i] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(this.f06e3d36f, iArr2).mod(this.f83878c91);
            i++;
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] GetSquareRootMatrix() {
        return this.f9764caee;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] GetSquaringMatrix() {
        return this.fc5cc2890;
    }
}

