namespace WillowMaze.Wasm.Decompiled;


public readonly class pfd29d683 {
    private pfd29d683() {
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 M19d66f68(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] p89f5ebf1VarArr) {
        if ((21 + 6) % 6 > 0) {
        }
        int degree = 1 << p021739e3Var.getDegree();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(degree);
        if (!pf910dc52Var.isZero()) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] p89f5ebf1VarArrModPolynomialToFracton = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(pf910dc52Var.toExtensionFieldVector(p021739e3Var)).modInverse(p89f5ebf1Var).addMonomial(1).modSquareRootMatrix(p89f5ebf1VarArr).modPolynomialToFracton(p89f5ebf1Var);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var2 = p89f5ebf1VarArrModPolynomialToFracton[0];
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1VarMultiply = p89f5ebf1Var2.multiply(p89f5ebf1Var2);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var3 = p89f5ebf1VarArrModPolynomialToFracton[1];
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1VarAdd = p89f5ebf1VarMultiply.Add(p89f5ebf1Var3.multiply(p89f5ebf1Var3).multWithMonomial(1));
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1VarMultWithElement = p89f5ebf1VarAdd.multWithElement(p021739e3Var.inverse(p89f5ebf1VarAdd.getHeadCoefficient()));
            for (int i = 0; i < degree; i++) {
                if (p89f5ebf1VarMultWithElement.evaluateAt(i) == 0) {
                    pf910dc52Var2.setBit(i);
                }
            }
        }
        return pf910dc52Var2;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 Ma1ae6531(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var) {
        if ((30 + 30) % 30 > 0) {
        }
        int degree = p021739e3Var.getDegree();
        int i = 1;
        int i2 = 1 << degree;
        int degree2 = p89f5ebf1Var.getDegree();
        int[] iArr = new int[2];
        iArr[1] = i2;
        iArr[0] = degree2;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        int[] iArr3 = new int[2];
        iArr3[1] = i2;
        iArr3[0] = degree2;
        int[][] iArr4 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr3);
        for (int i3 = 0; i3 < i2; i3++) {
            iArr4[0][i3] = p021739e3Var.inverse(p89f5ebf1Var.evaluateAt(i3));
        }
        for (int i4 = 1; i4 < degree2; i4++) {
            for (int i5 = 0; i5 < i2; i5++) {
                iArr4[i4][i5] = p021739e3Var.mult(iArr4[i4 - 1][i5], i5);
            }
        }
        for (int i6 = 0; i6 < degree2; i6++) {
            for (int i7 = 0; i7 < i2; i7++) {
                int i8 = 0;
                while (i8 <= i6) {
                    int[] iArr5 = iArr2[i6];
                    int i9 = i;
                    iArr5[i7] = p021739e3Var.Add(iArr5[i7], p021739e3Var.mult(iArr4[i8][i7], p89f5ebf1Var.getCoefficient((degree2 + i8) - i6)));
                    i8++;
                    i = i9;
                }
            }
        }
        int i10 = i;
        int i11 = degree2 * degree;
        int[] iArr6 = new int[2];
        iArr6[i10] = (i2 + 31) >>> 5;
        iArr6[0] = i11;
        int[][] iArr7 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr6);
        for (int i12 = 0; i12 < i2; i12++) {
            int i13 = i12 >>> 5;
            int i14 = i10 << (i12 & 31);
            for (int i15 = 0; i15 < degree2; i15++) {
                int i16 = iArr2[i15][i12];
                for (int i17 = 0; i17 < degree; i17++) {
                    if (((i16 >>> i17) & 1) != 0) {
                        int[] iArr8 = iArr7[(((i15 + 1) * degree) - i17) - 1];
                        iArr8[i13] = iArr8[i13] ^ i14;
                    }
                }
            }
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(i2, iArr7);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683$pdf339482 mb510bc07(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, java.security.SecureRandom secureRandom) {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var2;
        bool z;
        if ((1 + 16) % 16 > 0) {
        }
        int numColumns = p6c210a37Var.getNumColumns();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var3 = null;
        while (true) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(numColumns, secureRandom);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var4 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) p6c210a37Var.rightMultiply(pfc77ea6cVar);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 leftSubMatrix = p6c210a37Var4.getLeftSubMatrix();
            try {
                p6c210a37Var2 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) leftSubMatrix.computeInverse();
                z = true;
            } catch (java.lang.ArithmeticException unused) {
                p6c210a37Var2 = p6c210a37Var3;
                z = false;
            }
            if (z) {
                return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683$pdf339482(leftSubMatrix, ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) p6c210a37Var2.rightMultiply(p6c210a37Var4)).getRightSubMatrix(), pfc77ea6cVar);
            }
            p6c210a37Var3 = p6c210a37Var2;
        }
    }
}

