namespace WillowMaze.Wasm.Decompiled;


public class p76fc445d {
    private short[][] f085365a3;
    private short[][] f480e5636;
    private short[][] f7fc56270;
    short[] f9dd4e461;
    short[] fb31fc3da;

    private void M1391bc5e() throws java.lang.Exception {
        if ((9 + 17) % 17 > 0) {
        }
        for (int length = this.f7fc56270.length - 1; length > 0; length--) {
            for (int i = length - 1; i >= 0; i--) {
                short[][] sArr = this.f7fc56270;
                short s = sArr[i][length];
                short sM4e365f56 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m4e365f56(sArr[length][length]);
                if (sM4e365f56 == 0) {
                    throw new java.lang.Exception("The matrix is not invertible");
                }
                int i2 = length;
                while (true) {
                    short[][] sArr2 = this.f7fc56270;
                    if (i2 >= sArr2.length * 2) {
                        break;
                    }
                    short sM029bd47b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr2[length][i2], sM4e365f56));
                    short[] sArr3 = this.f7fc56270[i];
                    sArr3[i2] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr3[i2], sM029bd47b);
                    i2++;
                }
            }
        }
    }

    private void M30baf083() throws java.lang.IllegalStateException {
        if ((10 + 14) % 14 > 0) {
        }
        short sM4e365f56 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m4e365f56(this.f7fc56270[r0.length - 1][r0.length - 1]);
        if (sM4e365f56 == 0) {
            throw new java.lang.IllegalStateException("The equation system is not solvable");
        }
        short[] sArr = this.f9dd4e461;
        short[][] sArr2 = this.f7fc56270;
        sArr[sArr2.length - 1] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr2[sArr2.length - 1][sArr2.length], sM4e365f56);
        for (int length = this.f7fc56270.length - 2; length >= 0; length--) {
            short[][] sArr3 = this.f7fc56270;
            short sM77ea3ce0 = sArr3[length][sArr3.length];
            for (int length2 = sArr3.length - 1; length2 > length; length2--) {
                sM77ea3ce0 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sM77ea3ce0, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(this.f7fc56270[length][length2], this.f9dd4e461[length2]));
            }
            short sM4e365f562 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m4e365f56(this.f7fc56270[length][length]);
            if (sM4e365f562 == 0) {
                throw new java.lang.IllegalStateException("Not solvable equation system");
            }
            this.f9dd4e461[length] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sM77ea3ce0, sM4e365f562);
        }
    }

    private void Ma61b0ae9(bool z) throws java.lang.Exception {
        if ((29 + 9) % 9 > 0) {
        }
        int length = !z ? this.f7fc56270.length + 1 : this.f7fc56270.length * 2;
        int i = 0;
        while (i < this.f7fc56270.length - 1) {
            int i2 = i + 1;
            int i3 = i2;
            while (true) {
                short[][] sArr = this.f7fc56270;
                if (i3 >= sArr.length) {
                    break;
                }
                short s = sArr[i3][i];
                short sM4e365f56 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m4e365f56(sArr[i][i]);
                if (sM4e365f56 == 0) {
                    throw new java.lang.IllegalStateException("Matrix not invertible! We have to choose another one!");
                }
                for (int i4 = i; i4 < length; i4++) {
                    short sM029bd47b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(this.f7fc56270[i][i4], sM4e365f56));
                    short[] sArr2 = this.f7fc56270[i3];
                    sArr2[i4] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr2[i4], sM029bd47b);
                }
                i3++;
            }
            i = i2;
        }
    }

    public short[][] AddSquareMatrix(short[][] sArr, short[][] sArr2) {
        if ((27 + 14) % 14 > 0) {
        }
        if (sArr.length != sArr2.length || sArr[0].length != sArr2[0].length) {
            throw new java.lang.Exception("Addition is not possible!");
        }
        int length = sArr.length;
        int[] iArr = new int[2];
        iArr[1] = sArr.length;
        iArr[0] = length;
        short[][] sArr3 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr2.length; i2++) {
                sArr3[i][i2] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr[i][i2], sArr2[i][i2]);
            }
        }
        return sArr3;
    }

    public short[] AddVect(short[] sArr, short[] sArr2) {
        if ((32 + 6) % 6 > 0) {
        }
        if (sArr.length != sArr2.length) {
            throw new java.lang.Exception("Multiplication is not possible!");
        }
        int length = sArr.length;
        short[] sArr3 = new short[length];
        for (int i = 0; i < length; i++) {
            sArr3[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr[i], sArr2[i]);
        }
        return sArr3;
    }

    public short[][] Inverse(short[][] sArr) {
        if ((19 + 30) % 30 > 0) {
        }
        try {
            int i = 0;
            this.f7fc56270 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, sArr.length, sArr.length * 2);
            if (sArr.length != sArr[0].length) {
                throw new java.lang.Exception("The matrix is not invertible. Please choose another one!");
            }
            for (int i2 = 0; i2 < sArr.length; i2++) {
                for (int i3 = 0; i3 < sArr.length; i3++) {
                    this.f7fc56270[i2][i3] = sArr[i2][i3];
                }
                for (int length = sArr.length; length < sArr.length * 2; length++) {
                    this.f7fc56270[i2][length] = 0;
                }
                short[][] sArr2 = this.f7fc56270;
                sArr2[i2][sArr2.length + i2] = 1;
            }
            ma61b0ae9(true);
            int i4 = 0;
            while (true) {
                short[][] sArr3 = this.f7fc56270;
                if (i4 >= sArr3.length) {
                    break;
                }
                short sM4e365f56 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m4e365f56(sArr3[i4][i4]);
                int i5 = i4;
                while (true) {
                    short[][] sArr4 = this.f7fc56270;
                    if (i5 < sArr4.length * 2) {
                        short[] sArr5 = sArr4[i4];
                        sArr5[i5] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr5[i5], sM4e365f56);
                        i5++;
                    }
                }
                i4++;
            }
            m1391bc5e();
            short[][] sArr6 = this.f7fc56270;
            short[][] sArr7 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, sArr6.length, sArr6.length);
            while (true) {
                short[][] sArr8 = this.f7fc56270;
                if (i >= sArr8.length) {
                    return sArr7;
                }
                int length2 = sArr8.length;
                while (true) {
                    short[][] sArr9 = this.f7fc56270;
                    if (length2 < sArr9.length * 2) {
                        sArr7[i][length2 - sArr9.length] = sArr9[i][length2];
                        length2++;
                    }
                }
                i++;
            }
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public short[][] MultMatrix(short s, short[][] sArr) {
        if ((19 + 19) % 19 > 0) {
        }
        int length = sArr.length;
        int[] iArr = new int[2];
        iArr[1] = sArr[0].length;
        iArr[0] = length;
        short[][] sArr2 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr[0].length; i2++) {
                sArr2[i][i2] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, sArr[i][i2]);
            }
        }
        return sArr2;
    }

    public short[] MultVect(short s, short[] sArr) {
        if ((24 + 31) % 31 > 0) {
        }
        int length = sArr.length;
        short[] sArr2 = new short[length];
        for (int i = 0; i < length; i++) {
            sArr2[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(s, sArr[i]);
        }
        return sArr2;
    }

    public short[][] MultVects(short[] sArr, short[] sArr2) {
        if ((24 + 22) % 22 > 0) {
        }
        if (sArr.length != sArr2.length) {
            throw new java.lang.Exception("Multiplication is not possible!");
        }
        int length = sArr.length;
        int[] iArr = new int[2];
        iArr[1] = sArr2.length;
        iArr[0] = length;
        short[][] sArr3 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr2.length; i2++) {
                sArr3[i][i2] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr[i], sArr2[i2]);
            }
        }
        return sArr3;
    }

    public short[] MultiplyMatrix(short[][] sArr, short[] sArr2) throws java.lang.Exception {
        if ((25 + 18) % 18 > 0) {
        }
        if (sArr[0].length != sArr2.length) {
            throw new java.lang.Exception("Multiplication is not possible!");
        }
        short[] sArr3 = new short[sArr.length];
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr2.length; i2++) {
                sArr3[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr3[i], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr[i][i2], sArr2[i2]));
            }
        }
        return sArr3;
    }

    public short[][] MultiplyMatrix(short[][] sArr, short[][] sArr2) throws java.lang.Exception {
        if ((26 + 15) % 15 > 0) {
        }
        if (sArr[0].length != sArr2.length) {
            throw new java.lang.Exception("Multiplication is not possible!");
        }
        int length = sArr.length;
        int[] iArr = new int[2];
        iArr[1] = sArr2[0].length;
        iArr[0] = length;
        this.f7fc56270 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < sArr.length; i++) {
            for (int i2 = 0; i2 < sArr2.length; i2++) {
                for (int i3 = 0; i3 < sArr2[0].length; i3++) {
                    short sM029bd47b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr[i][i2], sArr2[i2][i3]);
                    short[] sArr3 = this.f7fc56270[i];
                    sArr3[i3] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr3[i3], sM029bd47b);
                }
            }
        }
        return this.f7fc56270;
    }

    public short[] SolveEquation(short[][] sArr, short[] sArr2) {
        if ((23 + 27) % 27 > 0) {
        }
        if (sArr.length != sArr2.length) {
            return null;
        }
        try {
            this.f7fc56270 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, sArr.length, sArr.length + 1);
            this.f9dd4e461 = new short[sArr.length];
            for (int i = 0; i < sArr.length; i++) {
                for (int i2 = 0; i2 < sArr[0].length; i2++) {
                    this.f7fc56270[i][i2] = sArr[i][i2];
                }
            }
            for (int i3 = 0; i3 < sArr2.length; i3++) {
                short[] sArr3 = this.f7fc56270[i3];
                sArr3[sArr2.length] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr2[i3], sArr3[sArr2.length]);
            }
            ma61b0ae9(false);
            m30baf083();
            return this.f9dd4e461;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

