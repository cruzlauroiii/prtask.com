namespace WillowMaze.Wasm.Decompiled;


public class p2f98f454 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private byte[] f067ed318;
    private byte[][] f07d13b6c;
    private byte[][] f090cd106;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f1012c78b;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f130f4311;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f15bafd18;
    private byte[] f19fb91bc;
    private byte[][] f27577a4d;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] f2c357868;
    private byte[] f35b36b28;
    private byte[] f3a8002c0;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f3bdf2214;
    private byte[] f3dadff8c;
    private byte[] f3e469952;
    private byte[][] f3f0d0dfd;
    private byte[] f45efe902;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f46d891b9;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f4a0cbb45;
    private byte[][] f62115af0;
    private byte[] f63f6199b;
    private byte[] f68239f00;
    private byte[][] f8ca7959b;
    private byte[][] f93d3a6e2;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f96ac01ec;
    private byte[][] f9dc0424f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] faa292f2a;
    private byte[][] faa68b758;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] fb9f20407;
    private byte[] fbf474120;
    private byte[] fc2c3a875;
    private byte[] fedbab455;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a ff9bc2d84;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] ffa0ff0c5;
    private byte[] ffbfba2e4;

    private p2f98f454(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((8 + 18) % 18 > 0) {
        }
        int i = 0;
        if (p80f8c729Var.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            this.f2af72f10 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        } else {
            this.f130f4311 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p80f8c729Var.getobjectAt(0));
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(1);
        this.f62115af0 = new byte[p80f8c729Var2.Count][];
        for (int i2 = 0; i2 < p80f8c729Var2.Count; i2++) {
            this.f62115af0[i2] = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var2.getobjectAt(i2)).getOctets();
        }
        this.fedbab455 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) ((p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(2)).getobjectAt(0)).getOctets();
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var3 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(3);
        this.f090cd106 = new byte[p80f8c729Var3.Count][];
        for (int i3 = 0; i3 < p80f8c729Var3.Count; i3++) {
            this.f090cd106[i3] = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var3.getobjectAt(i3)).getOctets();
        }
        this.ffbfba2e4 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) ((p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(4)).getobjectAt(0)).getOctets();
        this.f35b36b28 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) ((p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(5)).getobjectAt(0)).getOctets();
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var4 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(6);
        byte[][][][] bArr = new byte[p80f8c729Var4.Count][][][];
        byte[][][][] bArr2 = new byte[p80f8c729Var4.Count][][][];
        byte[][][] bArr3 = new byte[p80f8c729Var4.Count][][];
        byte[][] bArr4 = new byte[p80f8c729Var4.Count][];
        int i4 = 0;
        while (i4 < p80f8c729Var4.Count) {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var5 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var4.getobjectAt(i4);
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var6 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var5.getobjectAt(i);
            bArr[i4] = new byte[p80f8c729Var6.Count][][];
            int i5 = i;
            while (i5 < p80f8c729Var6.Count) {
                p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var7 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var6.getobjectAt(i5);
                bArr[i4][i5] = new byte[p80f8c729Var7.Count][];
                for (int i6 = 0; i6 < p80f8c729Var7.Count; i6++) {
                    bArr[i4][i5][i6] = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var7.getobjectAt(i6)).getOctets();
                }
                i5++;
            }
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var8 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var5.getobjectAt(1);
            bArr2[i4] = new byte[p80f8c729Var8.Count][][];
            for (int i7 = 0; i7 < p80f8c729Var8.Count; i7++) {
                p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var9 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var8.getobjectAt(i7);
                bArr2[i4][i7] = new byte[p80f8c729Var9.Count][];
                for (int i8 = 0; i8 < p80f8c729Var9.Count; i8++) {
                    bArr2[i4][i7][i8] = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var9.getobjectAt(i8)).getOctets();
                }
            }
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var10 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var5.getobjectAt(2);
            bArr3[i4] = new byte[p80f8c729Var10.Count][];
            for (int i9 = 0; i9 < p80f8c729Var10.Count; i9++) {
                bArr3[i4][i9] = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var10.getobjectAt(i9)).getOctets();
            }
            bArr4[i4] = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var5.getobjectAt(3)).getOctets();
            i4++;
            i = 0;
        }
        int length = this.f35b36b28.length - 1;
        this.faa292f2a = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[length];
        int i10 = 0;
        while (i10 < length) {
            byte[] bArr5 = this.f35b36b28;
            int i11 = i10 + 1;
            this.faa292f2a[i10] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8(bArr5[i10], bArr5[i11], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(bArr[i10]), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(bArr2[i10]), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(bArr3[i10]), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(bArr4[i10]));
            i10 = i11;
        }
    }

    public p2f98f454(short[][] sArr, short[] sArr2, short[][] sArr3, short[] sArr4, int[] iArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] p359b71e8VarArr) {
        if ((25 + 32) % 32 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(1L);
        this.f62115af0 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr);
        this.fedbab455 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr2);
        this.f090cd106 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr3);
        this.ffbfba2e4 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr4);
        this.f35b36b28 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m6aceb6ef(iArr);
        this.faa292f2a = p359b71e8VarArr;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public short[] GetB1() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.fedbab455);
    }

    public short[] GetB2() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.ffbfba2e4);
    }

    public short[][] GetInvA1() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.f62115af0);
    }

    public short[][] GetInvA2() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.f090cd106);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] GetLayers() {
        return this.faa292f2a;
    }

    public p5a445d71.p9f931cf3.pca323100.pf391b73d GetVersion() {
        return this.f2af72f10;
    }

    public int[] GetVi() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.m85a9e095(this.f35b36b28);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((29 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f2af72f10;
        if (p0fd1bdf1Var is null) {
            p0fd1bdf1Var = this.f130f4311;
        }
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i = 0; i < this.f62115af0.length; i++) {
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f62115af0[i]));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar3 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar3.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fedbab455));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar3));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar4 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i2 = 0; i2 < this.f090cd106.length; i2++) {
            pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f090cd106[i2]));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar4));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar5 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar5.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.ffbfba2e4));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar5));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar6 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar6.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f35b36b28));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar6));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar7 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i3 = 0; i3 < this.faa292f2a.length; i3++) {
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar8 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            byte[][][] bArrMe2d26373 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.faa292f2a[i3].getCoeffAlpha());
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar9 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            for (int i4 = 0; i4 < bArrMe2d26373.length; i4++) {
                p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar10 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                for (int i5 = 0; i5 < bArrMe2d26373[i4].length; i5++) {
                    pd6ccb7fcVar10.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArrMe2d26373[i4][i5]));
                }
                pd6ccb7fcVar9.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar10));
            }
            pd6ccb7fcVar8.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar9));
            byte[][][] bArrMe2d263732 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.faa292f2a[i3].getCoeffBeta());
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar11 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            for (int i6 = 0; i6 < bArrMe2d263732.length; i6++) {
                p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar12 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                for (int i7 = 0; i7 < bArrMe2d263732[i6].length; i7++) {
                    pd6ccb7fcVar12.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArrMe2d263732[i6][i7]));
                }
                pd6ccb7fcVar11.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar12));
            }
            pd6ccb7fcVar8.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar11));
            byte[][] bArrMe2d263733 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.faa292f2a[i3].getCoeffGamma());
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar13 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            foreach (byte[] BArr in bArrMe2d263733) {
                pd6ccb7fcVar13.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr));
            }
            pd6ccb7fcVar8.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar13));
            pd6ccb7fcVar8.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.faa292f2a[i3].getCoeffEta())));
            pd6ccb7fcVar7.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar8));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar7));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

