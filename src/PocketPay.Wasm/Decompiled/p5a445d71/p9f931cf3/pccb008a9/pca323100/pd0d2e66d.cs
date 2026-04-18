namespace WillowMaze.Wasm.Decompiled;


public class pd0d2e66d : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 f069c5b4f;
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 fa8a0bc7e;

    private pd0d2e66d(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((25 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(0);
        int[] iArr = new int[p80f8c729Var2.Count];
        for (int i = 0; i < p80f8c729Var2.Count; i++) {
            iArr[i] = m01ed5e53(p80f8c729Var2.getobjectAt(i));
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var3 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(1);
        int size = p80f8c729Var3.Count;
        byte[][] bArr = new byte[size][];
        for (int i2 = 0; i2 < size; i2++) {
            bArr[i2] = ((p5a445d71.p9f931cf3.pca323100.p6f0e511c) p80f8c729Var3.getobjectAt(i2)).getOctets();
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var4 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(2);
        int size2 = p80f8c729Var4.Count;
        byte[][] bArr2 = new byte[size2][];
        for (int i3 = 0; i3 < size2; i3++) {
            bArr2[i3] = ((p5a445d71.p9f931cf3.pca323100.p6f0e511c) p80f8c729Var4.getobjectAt(i3)).getOctets();
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var5 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(3);
        int size3 = p80f8c729Var5.Count;
        byte[][][] bArr3 = new byte[size3][][];
        for (int i4 = 0; i4 < size3; i4++) {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var6 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var5.getobjectAt(i4);
            bArr3[i4] = new byte[p80f8c729Var6.Count][];
            int i5 = 0;
            while (true) {
                byte[][] bArr4 = bArr3[i4];
                if (i5 >= bArr4.length) {
                    break;
                }
                bArr4[i5] = ((p5a445d71.p9f931cf3.pca323100.p6f0e511c) p80f8c729Var6.getobjectAt(i5)).getOctets();
                i5++;
            }
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var7 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(4);
        int size4 = p80f8c729Var7.Count;
        byte[][][] bArr5 = new byte[size4][][];
        for (int i6 = 0; i6 < size4; i6++) {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var8 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var7.getobjectAt(i6);
            bArr5[i6] = new byte[p80f8c729Var8.Count][];
            int i7 = 0;
            while (true) {
                byte[][] bArr6 = bArr5[i6];
                if (i7 >= bArr6.length) {
                    break;
                }
                bArr6[i7] = ((p5a445d71.p9f931cf3.pca323100.p6f0e511c) p80f8c729Var8.getobjectAt(i7)).getOctets();
                i7++;
            }
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[][] p123e73f3VarArr = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[((p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(5)).Count][];
    }

    public pd0d2e66d(int[] iArr, byte[][] bArr, byte[][] bArr2, byte[][][] bArr3, byte[][][] bArr4, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[][] p123e73f3VarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[][] p123e73f3VarArr2, java.util.Vector[] vectorArr, java.util.Vector[] vectorArr2, java.util.Vector[][] vectorArr3, java.util.Vector[][] vectorArr4, byte[][][] bArr5, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391[] p6b572391VarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391[] p6b572391VarArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391[] p6b572391VarArr3, int[] iArr2, byte[][] bArr6, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pa60ad8c0[] pa60ad8c0VarArr, byte[][] bArr7, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pac08aae5[] pac08aae5VarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((16 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530[] p234a7530VarArr = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530[1];
        p234a7530VarArr[0] = p234a7530Var;
        this.f069c5b4f = m97a57645(iArr, bArr, bArr2, bArr3, bArr4, bArr5, p123e73f3VarArr, p123e73f3VarArr2, vectorArr, vectorArr2, vectorArr3, vectorArr4, p6b572391VarArr, p6b572391VarArr2, p6b572391VarArr3, iArr2, bArr6, pa60ad8c0VarArr, bArr7, pac08aae5VarArr, p2ffd3a5dVar, p234a7530VarArr);
    }

    private static int M01ed5e53(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p0fd1bdf1Var).intValueExact();
    }

    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 M97a57645(int[] iArr, byte[][] bArr, byte[][] bArr2, byte[][][] bArr3, byte[][][] bArr4, byte[][][] bArr5, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[][] p123e73f3VarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3[][] p123e73f3VarArr2, java.util.Vector[] vectorArr, java.util.Vector[] vectorArr2, java.util.Vector[][] vectorArr3, java.util.Vector[][] vectorArr4, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391[] p6b572391VarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391[] p6b572391VarArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p6b572391[] p6b572391VarArr3, int[] iArr2, byte[][] bArr6, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pa60ad8c0[] pa60ad8c0VarArr, byte[][] bArr7, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.pac08aae5[] pac08aae5VarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530[] p234a7530VarArr) {
        if ((11 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        int i = 0;
        while (i < iArr.length) {
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(iArr[i]));
            i++;
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar3 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        foreach (byte[] BArr8 in bArr) {
            pd6ccb7fcVar3.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr8));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar3));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar4 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        foreach (byte[] BArr9 in bArr2) {
            pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr9));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar4));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar5 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar6 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i2 = 0; i2 < bArr3.length; i2++) {
            for (int i3 = 0; i3 < bArr3[i2].length; i3++) {
                pd6ccb7fcVar5.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr3[i2][i3]));
            }
            pd6ccb7fcVar6.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar5));
            pd6ccb7fcVar5 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar6));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar7 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar8 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i4 = 0; i4 < bArr4.length; i4++) {
            for (int i5 = 0; i5 < bArr4[i4].length; i5++) {
                pd6ccb7fcVar7.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr4[i4][i5]));
            }
            pd6ccb7fcVar8.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar7));
            pd6ccb7fcVar7 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar8));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar9 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar10 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar11 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar12 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar13 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        int i6 = 0;
        while (i6 < p123e73f3VarArr.length) {
            int i7 = 0;
            while (i7 < p123e73f3VarArr[i6].length) {
                pd6ccb7fcVar11.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
                int i8 = p123e73f3VarArr[i6][i7].getStatInt()[1];
                pd6ccb7fcVar12.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr[i6][i7].getStatbyte()[0]));
                pd6ccb7fcVar12.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr[i6][i7].getStatbyte()[1]));
                pd6ccb7fcVar12.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr[i6][i7].getStatbyte()[2]));
                int i9 = 0;
                while (i9 < i8) {
                    pd6ccb7fcVar12.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr[i6][i7].getStatbyte()[i9 + 3]));
                    i9++;
                    p123e73f3VarArr = p123e73f3VarArr;
                }
                pd6ccb7fcVar11.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar12));
                pd6ccb7fcVar12 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr[i6][i7].getStatInt()[0]));
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i8));
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr[i6][i7].getStatInt()[2]));
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr[i6][i7].getStatInt()[3]));
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr[i6][i7].getStatInt()[4]));
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr[i6][i7].getStatInt()[5]));
                int i10 = 0;
                while (i10 < i8) {
                    int i11 = i6;
                    int i12 = i7;
                    pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr[i6][i7].getStatInt()[i10 + 6]));
                    i10++;
                    i6 = i11;
                    i7 = i12;
                }
                int i13 = i7;
                pd6ccb7fcVar11.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar13));
                pd6ccb7fcVar13 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                pd6ccb7fcVar10.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar11));
                pd6ccb7fcVar11 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                i7 = i13 + 1;
                p123e73f3VarArr = p123e73f3VarArr;
            }
            int i14 = i6;
            pd6ccb7fcVar9.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar10));
            pd6ccb7fcVar10 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            i6 = i14 + 1;
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar9));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar14 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar15 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar16 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar17 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar18 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        int i15 = 0;
        while (i15 < p123e73f3VarArr2.length) {
            int i16 = 0;
            while (i16 < p123e73f3VarArr2[i15].length) {
                pd6ccb7fcVar16.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
                int i17 = p123e73f3VarArr2[i15][i16].getStatInt()[1];
                pd6ccb7fcVar17.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr2[i15][i16].getStatbyte()[0]));
                pd6ccb7fcVar17.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr2[i15][i16].getStatbyte()[1]));
                pd6ccb7fcVar17.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr2[i15][i16].getStatbyte()[2]));
                for (int i18 = 0; i18 < i17; i18++) {
                    pd6ccb7fcVar17.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p123e73f3VarArr2[i15][i16].getStatbyte()[i18 + 3]));
                }
                pd6ccb7fcVar16.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar17));
                pd6ccb7fcVar17 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr2[i15][i16].getStatInt()[0]));
                pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i17));
                pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr2[i15][i16].getStatInt()[2]));
                pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr2[i15][i16].getStatInt()[3]));
                pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr2[i15][i16].getStatInt()[4]));
                pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr2[i15][i16].getStatInt()[5]));
                int i19 = 0;
                while (i19 < i17) {
                    int i20 = i15;
                    pd6ccb7fcVar18.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p123e73f3VarArr2[i15][i16].getStatInt()[i19 + 6]));
                    i19++;
                    p123e73f3VarArr2 = p123e73f3VarArr2;
                    i15 = i20;
                }
                int i21 = i15;
                pd6ccb7fcVar16.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar18));
                pd6ccb7fcVar18 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                pd6ccb7fcVar15.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar16));
                pd6ccb7fcVar16 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                i16++;
                p123e73f3VarArr2 = p123e73f3VarArr2;
                i15 = i21;
            }
            int i22 = i15;
            pd6ccb7fcVar14.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar15)));
            pd6ccb7fcVar15 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            i15 = i22 + 1;
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar14));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar19 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar20 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i23 = 0; i23 < bArr5.length; i23++) {
            for (int i24 = 0; i24 < bArr5[i23].length; i24++) {
                pd6ccb7fcVar19.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr5[i23][i24]));
            }
            pd6ccb7fcVar20.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar19));
            pd6ccb7fcVar19 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar20));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar21 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar22 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i25 = 0; i25 < vectorArr.length; i25++) {
            for (int i26 = 0; i26 < vectorArr[i25].Count; i26++) {
                pd6ccb7fcVar21.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c((byte[]) vectorArr[i25].elementAt(i26)));
            }
            pd6ccb7fcVar22.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar21));
            pd6ccb7fcVar21 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar22));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar23 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar24 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i27 = 0; i27 < vectorArr2.length; i27++) {
            for (int i28 = 0; i28 < vectorArr2[i27].Count; i28++) {
                pd6ccb7fcVar23.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c((byte[]) vectorArr2[i27].elementAt(i28)));
            }
            pd6ccb7fcVar24.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar23));
            pd6ccb7fcVar23 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar24));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar25 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar26 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar27 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i29 = 0; i29 < vectorArr3.length; i29++) {
            for (int i30 = 0; i30 < vectorArr3[i29].length; i30++) {
                for (int i31 = 0; i31 < vectorArr3[i29][i30].Count; i31++) {
                    pd6ccb7fcVar25.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c((byte[]) vectorArr3[i29][i30].elementAt(i31)));
                }
                pd6ccb7fcVar26.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar25));
                pd6ccb7fcVar25 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            }
            pd6ccb7fcVar27.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar26));
            pd6ccb7fcVar26 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar27));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar28 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar29 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar30 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i32 = 0; i32 < vectorArr4.length; i32++) {
            for (int i33 = 0; i33 < vectorArr4[i32].length; i33++) {
                for (int i34 = 0; i34 < vectorArr4[i32][i33].Count; i34++) {
                    pd6ccb7fcVar28.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c((byte[]) vectorArr4[i32][i33].elementAt(i34)));
                }
                pd6ccb7fcVar29.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar28));
                pd6ccb7fcVar28 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            }
            pd6ccb7fcVar30.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar29));
            pd6ccb7fcVar29 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar30));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar31 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar32 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar33 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar34 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i35 = 0; i35 < p6b572391VarArr.length; i35++) {
            pd6ccb7fcVar32.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
            byte[][] statbyte = p6b572391VarArr[i35].getStatbyte();
            pd6ccb7fcVar33.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte[0]));
            pd6ccb7fcVar33.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte[1]));
            pd6ccb7fcVar33.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte[2]));
            pd6ccb7fcVar33.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte[3]));
            pd6ccb7fcVar32.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar33));
            pd6ccb7fcVar33 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            int[] statInt = p6b572391VarArr[i35].getStatInt();
            pd6ccb7fcVar34.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt[0]));
            pd6ccb7fcVar34.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt[1]));
            pd6ccb7fcVar34.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt[2]));
            pd6ccb7fcVar34.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt[3]));
            pd6ccb7fcVar32.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar34));
            pd6ccb7fcVar34 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar31.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar32));
            pd6ccb7fcVar32 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar31));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar35 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar36 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar37 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar38 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i36 = 0; i36 < p6b572391VarArr2.length; i36++) {
            pd6ccb7fcVar36.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
            byte[][] statbyte2 = p6b572391VarArr2[i36].getStatbyte();
            pd6ccb7fcVar37.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte2[0]));
            pd6ccb7fcVar37.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte2[1]));
            pd6ccb7fcVar37.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte2[2]));
            pd6ccb7fcVar37.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte2[3]));
            pd6ccb7fcVar36.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar37));
            pd6ccb7fcVar37 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            int[] statInt2 = p6b572391VarArr2[i36].getStatInt();
            pd6ccb7fcVar38.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt2[0]));
            pd6ccb7fcVar38.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt2[1]));
            pd6ccb7fcVar38.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt2[2]));
            pd6ccb7fcVar38.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt2[3]));
            pd6ccb7fcVar36.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar38));
            pd6ccb7fcVar38 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar35.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar36));
            pd6ccb7fcVar36 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar35));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar39 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar40 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar41 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar42 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i37 = 0; i37 < p6b572391VarArr3.length; i37++) {
            pd6ccb7fcVar40.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
            byte[][] statbyte3 = p6b572391VarArr3[i37].getStatbyte();
            pd6ccb7fcVar41.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte3[0]));
            pd6ccb7fcVar41.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte3[1]));
            pd6ccb7fcVar41.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte3[2]));
            pd6ccb7fcVar41.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(statbyte3[3]));
            pd6ccb7fcVar40.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar41));
            pd6ccb7fcVar41 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            int[] statInt3 = p6b572391VarArr3[i37].getStatInt();
            pd6ccb7fcVar42.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt3[0]));
            pd6ccb7fcVar42.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt3[1]));
            pd6ccb7fcVar42.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt3[2]));
            pd6ccb7fcVar42.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(statInt3[3]));
            pd6ccb7fcVar40.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar42));
            pd6ccb7fcVar42 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar39.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar40));
            pd6ccb7fcVar40 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar39));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar43 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        foreach (int I38 in iArr2) {
            pd6ccb7fcVar43.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i38));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar43));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar44 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        foreach (byte[] BArr10 in bArr6) {
            pd6ccb7fcVar44.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr10));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar44));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar45 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar46 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar47 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar48 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar49 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar50 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        int i39 = 0;
        while (i39 < pa60ad8c0VarArr.length) {
            pd6ccb7fcVar46.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
            new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            int i40 = pa60ad8c0VarArr[i39].getStatInt()[0];
            int i41 = pa60ad8c0VarArr[i39].getStatInt()[7];
            pd6ccb7fcVar47.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getStatbyte()[0]));
            int i42 = 0;
            while (i42 < i40) {
                i42++;
                pd6ccb7fcVar47.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getStatbyte()[i42]));
            }
            for (int i43 = 0; i43 < i41; i43++) {
                pd6ccb7fcVar47.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getStatbyte()[i40 + 1 + i43]));
            }
            pd6ccb7fcVar46.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar47));
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar51 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i40));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[1]));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[2]));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[3]));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[4]));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[5]));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[6]));
            pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i41));
            for (int i44 = 0; i44 < i40; i44++) {
                pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[i44 + 8]));
            }
            for (int i45 = 0; i45 < i41; i45++) {
                pd6ccb7fcVar48.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getStatInt()[i40 + 8 + i45]));
            }
            pd6ccb7fcVar46.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar48));
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar52 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar53 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar54 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar55 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            if (pa60ad8c0VarArr[i39].getTreehash() is not null) {
                int i46 = 0;
                while (i46 < pa60ad8c0VarArr[i39].getTreehash().length) {
                    pd6ccb7fcVar53.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
                    int i47 = pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[1];
                    pd6ccb7fcVar54.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatbyte()[0]));
                    pd6ccb7fcVar54.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatbyte()[1]));
                    pd6ccb7fcVar54.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatbyte()[2]));
                    int i48 = 0;
                    while (i48 < i47) {
                        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar56 = pd6ccb7fcVar51;
                        pd6ccb7fcVar54.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatbyte()[i48 + 3]));
                        i48++;
                        pd6ccb7fcVar51 = pd6ccb7fcVar56;
                    }
                    p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar57 = pd6ccb7fcVar51;
                    pd6ccb7fcVar53.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar54));
                    pd6ccb7fcVar54 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                    pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[0]));
                    pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i47));
                    pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[2]));
                    pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[3]));
                    pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[4]));
                    pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[5]));
                    int i49 = 0;
                    while (i49 < i47) {
                        int i50 = i49;
                        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar58 = pd6ccb7fcVar52;
                        pd6ccb7fcVar55.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pa60ad8c0VarArr[i39].getTreehash()[i46].getStatInt()[i49 + 6]));
                        i49 = i50 + 1;
                        pd6ccb7fcVar52 = pd6ccb7fcVar58;
                    }
                    pd6ccb7fcVar53.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar55));
                    pd6ccb7fcVar55 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                    pd6ccb7fcVar49.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar53));
                    pd6ccb7fcVar53 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                    i46++;
                    pd6ccb7fcVar51 = pd6ccb7fcVar57;
                }
            }
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar59 = pd6ccb7fcVar51;
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar60 = pd6ccb7fcVar52;
            pd6ccb7fcVar46.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar49));
            pd6ccb7fcVar49 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar61 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            if (pa60ad8c0VarArr[i39].getRetain() is not null) {
                for (int i51 = 0; i51 < pa60ad8c0VarArr[i39].getRetain().length; i51++) {
                    for (int i52 = 0; i52 < pa60ad8c0VarArr[i39].getRetain()[i51].Count; i52++) {
                        pd6ccb7fcVar61.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c((byte[]) pa60ad8c0VarArr[i39].getRetain()[i51].elementAt(i52)));
                    }
                    pd6ccb7fcVar50.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar61));
                    pd6ccb7fcVar61 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                }
            }
            pd6ccb7fcVar46.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar50));
            pd6ccb7fcVar50 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar45.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar46));
            pd6ccb7fcVar46 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            i39++;
            pd6ccb7fcVar47 = pd6ccb7fcVar59;
            pd6ccb7fcVar48 = pd6ccb7fcVar60;
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar45));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar62 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        foreach (byte[] BArr11 in bArr7) {
            pd6ccb7fcVar62.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr11));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar62));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar63 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar64 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar65 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar66 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i53 = 0; i53 < pac08aae5VarArr.length; i53++) {
            pd6ccb7fcVar64.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p234a7530VarArr[0]));
            new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar65.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pac08aae5VarArr[i53].getStatbyte()[0]));
            pd6ccb7fcVar65.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pac08aae5VarArr[i53].getStatbyte()[1]));
            pd6ccb7fcVar65.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pac08aae5VarArr[i53].getStatbyte()[2]));
            pd6ccb7fcVar65.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pac08aae5VarArr[i53].getStatbyte()[3]));
            pd6ccb7fcVar65.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pac08aae5VarArr[i53].getStatbyte()[4]));
            pd6ccb7fcVar64.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar65));
            pd6ccb7fcVar65 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[0]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[1]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[2]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[3]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[4]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[5]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[6]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[7]));
            pd6ccb7fcVar66.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pac08aae5VarArr[i53].getStatInt()[8]));
            pd6ccb7fcVar64.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar66));
            pd6ccb7fcVar66 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar63.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar64));
            pd6ccb7fcVar64 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar63));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar67 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar68 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar69 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar70 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i54 = 0; i54 < p2ffd3a5dVar.getHeightOfTrees().length; i54++) {
            pd6ccb7fcVar68.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p2ffd3a5dVar.getHeightOfTrees()[i54]));
            pd6ccb7fcVar69.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p2ffd3a5dVar.getWinternitzParameter()[i54]));
            pd6ccb7fcVar70.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p2ffd3a5dVar.getK()[i54]));
        }
        pd6ccb7fcVar67.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(p2ffd3a5dVar.getNumOfLayers()));
        pd6ccb7fcVar67.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar68));
        pd6ccb7fcVar67.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar69));
        pd6ccb7fcVar67.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar70));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar67));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar71 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var : p234a7530VarArr) {
            pd6ccb7fcVar71.Add(p234a7530Var);
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar71));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f069c5b4f;
    }
}

