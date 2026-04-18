namespace WillowMaze.Wasm.Decompiled;


public class p26e0d3f1 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 {
    private static readonly int f306914f4 = 64;
    private static readonly int f593a6355 = 64;
    private static readonly int f5ec79cae = 64;
    private static readonly int feeecd029 = 64;
    private int f05290373;
    private int f2616d3e7;
    private int f3233855d;
    private int f3462a1a1;
    private int f36b3d662;
    private int f429f431e;
    int[][] f5191b40e;
    int[][] f9895cd91;
    private int fa0d4d1b6;
    private int fa48de4c6;
    private int fa6b7e2b1;
    private int fadf8a243;
    int[][] fb8b29d1e;
    int[][] fcd082061;
    private int fd7ce1748;

    public p26e0d3f1(int i, java.security.SecureRandom secureRandom) throws java.lang.Exception {
        super(secureRandom);
        if ((23 + 23) % 23 > 0) {
        }
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("k must be at least 3");
        }
        this.f91243d4a = i;
        this.f429f431e = this.f91243d4a / 64;
        int i2 = this.f91243d4a & 63;
        this.fa0d4d1b6 = i2;
        if (i2 != 0) {
            this.f429f431e++;
        } else {
            this.fa0d4d1b6 = 64;
        }
        dvaeskXsxZSljEZj(this);
        if (this.f3462a1a1 >= 3) {
            throw new java.lang.Exception(XHlSTYHggncrtYhX(bIKoaIrFbCEFjgsW(new java.lang.stringBuilder("\nThe type of this field is "), this.f3462a1a1)));
        }
        int i3 = this.f91243d4a;
        int[] iArr = new int[2];
        iArr[1] = 2;
        iArr[0] = i3;
        this.f9895cd91 = (int[][]) akcvbdsNWAERpHUH(java.lang.int.TYPE, iArr);
        for (int i4 = 0; i4 < this.f91243d4a; i4++) {
            int[] iArr2 = this.f9895cd91[i4];
            iArr2[0] = -1;
            iArr2[1] = -1;
        }
        BeuUsDTZQcUFIiEB(this);
        qMoFMWLBURPRDyhs(this);
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    public static void BLbByezfucvTNnvO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static void BeuUsDTZQcUFIiEB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        p26e0d3f1Var.m5b9d2502();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 DDBkictDFPbYSXlS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.Add(p7a2a4026Var2);
    }

    public static int DESqaFGeexDUFKEK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, int i, int i2) {
        return p26e0d3f1Var.m2793b87f(i, i2);
    }

    public static int FKVpXHvkjXXCwTnS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static int GQyYgADrhlGTBADi(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(i, i2);
    }

    public static int HlOHApieoGxpgEbX(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m331a5d7e(i, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 IMNSGyHIqESSKNbz(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.gcd(p7a2a4026Var2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 KBgfxStCopzhHmVj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return paf03ad66Var.getRandomRoot(p31c30ba9Var);
    }

    public static int KzLbBEJGwwihKWol(java.util.Random random) {
        return random.nextInt();
    }

    public static java.lang.object MMAgbMzNiCpyowRr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.clone();
    }

    public static void MSWehUxMfcIXcSVo(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static bool NPLnmWbLPaPjdYeU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.isZero();
    }

    public static bool PSaFGxVyFghoQRmy(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.mfc2723c4(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] UEjCRwGcxBQzVjGA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr) {
        return p26e0d3f1Var.invertMatrix(p31c30ba9VarArr);
    }

    public static int WxaWHaVfBwZSfFkr(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(i, i2);
    }

    public static java.lang.string XHlSTYHggncrtYhX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 XKeaRnmJwEWaBpuh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.shiftLeft();
    }

    public static int ZCYaZgRTinfJNvmD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static java.lang.object ZRpJBYfHqFxfRpUM(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.object AkcvbdsNWAERpHUH(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.stringBuilder BIKoaIrFbCEFjgsW(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 CucEbCKRntpVFztZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, int i) {
        return p7a2a4026Var.at(i);
    }

    public static void DvaeskXsxZSljEZj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        p26e0d3f1Var.m0b239f04();
    }

    public static void EjieGftMdXyyulFK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static int EmkvNsxjaCofYAxT(java.util.Random random) {
        return random.nextInt();
    }

    public static bool FGdtLDVwQeWCpIBk(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, int i) {
        return p1bf4f0f9Var.testBit(i);
    }

    public static java.lang.string FeSuSrQvkaARhyYP(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int FgRWlYvMyCXYXSxt(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(i, i2);
    }

    public static void GAKKBdUJFeoncvQL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, int i, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        p7a2a4026Var.set(i, p1bf4f0f9Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 GHCXtEdDGKRiWWmI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3) {
        return p7a2a4026Var.multiplyAndReduce(p7a2a4026Var2, p7a2a4026Var3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c HaKZvYtlyZTeDEcO(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b(p26e0d3f1Var);
    }

    public static int HvXGWzyvWFpSzcoL(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(i, i2);
    }

    public static void JSgtiSIqyIBeiGfE(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static int JUuICetNNFoOmCsL(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m331a5d7e(i, i2);
    }

    public static void JoNmdulYaXAIFIgk(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static java.lang.object KhNCAmdKPaKPQOYr(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    private void M0b239f04() throws java.lang.Exception {
        if ((18 + 9) % 9 > 0) {
        }
        if ((this.f91243d4a & 7) == 0) {
            throw new java.lang.Exception("The extension degree is divisible by 8!");
        }
        this.f3462a1a1 = 1;
        int iJUuICetNNFoOmCsL = 0;
        while (iJUuICetNNFoOmCsL != 1) {
            int i = (this.f3462a1a1 * this.f91243d4a) + 1;
            if (rYhnmOeeenUQEKnM(i)) {
                iJUuICetNNFoOmCsL = jUuICetNNFoOmCsL((this.f3462a1a1 * this.f91243d4a) / WxaWHaVfBwZSfFkr(2, i), this.f91243d4a);
            }
            this.f3462a1a1++;
        }
        int i2 = this.f3462a1a1 - 1;
        this.f3462a1a1 = i2;
        if (i2 != 1) {
            return;
        }
        int i3 = (this.f91243d4a << 1) + 1;
        if (PSaFGxVyFghoQRmy(i3)) {
            if (HlOHApieoGxpgEbX((this.f91243d4a << 1) / fgRWlYvMyCXYXSxt(2, i3), this.f91243d4a) != 1) {
                return;
            }
            this.f3462a1a1++;
        }
    }

    private int M2793b87f(int i, int i2) {
        if ((29 + 24) % 24 > 0) {
        }
        java.util.Random random = new java.util.Random();
        int iEmkvNsxjaCofYAxT = 0;
        while (iEmkvNsxjaCofYAxT == 0) {
            int i3 = i2 - 1;
            iEmkvNsxjaCofYAxT = KzLbBEJGwwihKWol(random) % i3;
            if (iEmkvNsxjaCofYAxT < 0) {
                iEmkvNsxjaCofYAxT += i3;
            }
        }
        int iHvXGWzyvWFpSzcoL = hvXGWzyvWFpSzcoL(iEmkvNsxjaCofYAxT, i2);
        while (true) {
            if (iHvXGWzyvWFpSzcoL % i == 0 && iHvXGWzyvWFpSzcoL != 0) {
                break;
            }
            while (iEmkvNsxjaCofYAxT == 0) {
                int i4 = i2 - 1;
                iEmkvNsxjaCofYAxT = emkvNsxjaCofYAxT(random) % i4;
                if (iEmkvNsxjaCofYAxT < 0) {
                    iEmkvNsxjaCofYAxT += i4;
                }
            }
            iHvXGWzyvWFpSzcoL = GQyYgADrhlGTBADi(iEmkvNsxjaCofYAxT, i2);
        }
        int i5 = iEmkvNsxjaCofYAxT;
        for (int i6 = 2; i6 <= i / iHvXGWzyvWFpSzcoL; i6++) {
            i5 *= iEmkvNsxjaCofYAxT;
        }
        return i5;
    }

    private void M5b9d2502() {
        int i;
        if ((29 + 30) % 30 > 0) {
        }
        int i2 = this.f3462a1a1;
        if ((i2 & 7) == 0) {
            throw new java.lang.Exception("bisher nur fuer Gausssche Normalbasen implementiert");
        }
        int i3 = i2 * this.f91243d4a;
        int i4 = i3 + 1;
        int[] iArr = new int[i4];
        int i5 = this.f3462a1a1;
        int iDESqaFGeexDUFKEK = i5 != 1 ? i5 != 2 ? DESqaFGeexDUFKEK(this, i5, i4) : i3 : 1;
        int i6 = 1;
        int i7 = 0;
        while (true) {
            i = this.f3462a1a1;
            if (i7 >= i) {
                break;
            }
            int i8 = i6;
            for (int i9 = 0; i9 < this.f91243d4a; i9++) {
                iArr[i8] = i9;
                i8 = (i8 << 1) % i4;
                if (i8 < 0) {
                    i8 += i4;
                }
            }
            i6 = (i6 * iDESqaFGeexDUFKEK) % i4;
            if (i6 < 0) {
                i6 += i4;
            }
            i7++;
        }
        if (i != 1) {
            if (i != 2) {
                throw new java.lang.Exception("only type 1 or type 2 implemented");
            }
            int i10 = 1;
            while (i10 < i3) {
                int i11 = i10 + 1;
                int[] iArr2 = this.f9895cd91[iArr[i11]];
                if (iArr2[0] != -1) {
                    iArr2[1] = iArr[i4 - i10];
                } else {
                    iArr2[0] = iArr[i4 - i10];
                }
                i10 = i11;
            }
            return;
        }
        int i12 = 1;
        while (i12 < i3) {
            int i13 = i12 + 1;
            int[] iArr3 = this.f9895cd91[iArr[i13]];
            if (iArr3[0] != -1) {
                iArr3[1] = iArr[i4 - i12];
            } else {
                iArr3[0] = iArr[i4 - i12];
            }
            i12 = i13;
        }
        int i14 = this.f91243d4a >> 1;
        for (int i15 = 1; i15 <= i14; i15++) {
            int[][] iArr4 = this.f9895cd91;
            int i16 = i15 - 1;
            int[] iArr5 = iArr4[i16];
            if (iArr5[0] != -1) {
                iArr5[1] = (i14 + i15) - 1;
            } else {
                iArr5[0] = (i14 + i15) - 1;
            }
            int[] iArr6 = iArr4[(i14 + i15) - 1];
            if (iArr6[0] != -1) {
                iArr6[1] = i16;
            } else {
                iArr6[0] = i16;
            }
        }
    }

    public static int NyyHQKluEuogsucL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    public static void OrdGIVaMSQjSOxZG(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static void QMoFMWLBURPRDyhs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1 p26e0d3f1Var) {
        p26e0d3f1Var.computeFieldPolynomial();
    }

    public static bool RYhnmOeeenUQEKnM(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.mfc2723c4(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 UvpXXxYMAMhUCCSm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return p7a2a4026Var.quotient(p7a2a4026Var2);
    }

    public static void VkwONbaHnyCxDfKm(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 WhkSRvMJCBSDIjNq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        return p1bf4f0f9Var.square();
    }

    public static int ZkwMFklXAutiPTqt(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        return p7a2a4026Var.getDegree();
    }

    protected override void ComputeCOBMatrix(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9VarKBgfxStCopzhHmVj;
        if ((4 + 9) % 9 > 0) {
        }
        if (this.f91243d4a != paf03ad66Var.f91243d4a) {
            throw new java.lang.IllegalArgumentException("GF2nField.computeCOBMatrix: B1 has a different degree and thus cannot be coverted to!");
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a];
        for (int i = 0; i < this.f91243d4a; i++) {
            p31c30ba9VarArr[i] = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        }
        do {
            p1bf4f0f9VarKBgfxStCopzhHmVj = KBgfxStCopzhHmVj(paf03ad66Var, this.fb774cd5f);
        } while (NPLnmWbLPaPjdYeU(p1bf4f0f9VarKBgfxStCopzhHmVj));
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661[this.f91243d4a];
        p1bf4f0f9VarArr[0] = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) MMAgbMzNiCpyowRr(p1bf4f0f9VarKBgfxStCopzhHmVj);
        for (int i2 = 1; i2 < this.f91243d4a; i2++) {
            p1bf4f0f9VarArr[i2] = whkSRvMJCBSDIjNq(p1bf4f0f9VarArr[i2 - 1]);
        }
        for (int i3 = 0; i3 < this.f91243d4a; i3++) {
            for (int i4 = 0; i4 < this.f91243d4a; i4++) {
                if (fGdtLDVwQeWCpIBk(p1bf4f0f9VarArr[i3], i4)) {
                    ordGIVaMSQjSOxZG(p31c30ba9VarArr[(this.f91243d4a - i4) - 1], (this.f91243d4a - i3) - 1);
                }
            }
        }
        MSWehUxMfcIXcSVo(this.fd05b6ed7, paf03ad66Var);
        joNmdulYaXAIFIgk(this.f25b24abe, p31c30ba9VarArr);
        jSgtiSIqyIBeiGfE(paf03ad66Var.fd05b6ed7, this);
        vkwONbaHnyCxDfKm(paf03ad66Var.f25b24abe, UEjCRwGcxBQzVjGA(this, p31c30ba9VarArr));
    }

    protected override void ComputeFieldPolynomial() {
        if ((30 + 15) % 15 > 0) {
        }
        int i = this.f3462a1a1;
        if (i == 1) {
            this.fb774cd5f = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1, "ALL");
            return;
        }
        if (i != 2) {
            return;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1, "ONE");
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1, feSuSrQvkaARhyYP("0a76621ffcc0ebd478db7e15f537b823cc2b209a9d746b6665996b790c"));
        ejieGftMdXyyulFK(p31c30ba9Var2, p31c30ba9Var);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9Var;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = p31c30ba9Var2;
        int i2 = 1;
        while (i2 < this.f91243d4a) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarXKeaRnmJwEWaBpuh = XKeaRnmJwEWaBpuh(p31c30ba9Var4);
            BLbByezfucvTNnvO(p31c30ba9VarXKeaRnmJwEWaBpuh, p31c30ba9Var3);
            i2++;
            p31c30ba9Var3 = p31c30ba9Var4;
            p31c30ba9Var4 = p31c30ba9VarXKeaRnmJwEWaBpuh;
        }
        this.fb774cd5f = p31c30ba9Var4;
    }

    int getONBBit() {
        return this.fa0d4d1b6;
    }

    int getONBLength() {
        return this.f429f431e;
    }

    protected override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 GetRandomRoot(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026VarIMNSGyHIqESSKNbz;
        int iZkwMFklXAutiPTqt;
        int iZCYaZgRTinfJNvmD;
        if ((5 + 28) % 28 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p31c30ba9Var, this);
        int iNyyHQKluEuogsucL = nyyHQKluEuogsucL(p7a2a4026Var);
        while (iNyyHQKluEuogsucL > 1) {
            while (true) {
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this, this.f7ddf32e1);
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(2, haKZvYtlyZTeDEcO(this));
                gAKKBdUJFeoncvQL(p7a2a4026Var2, 1, p2939c56cVar);
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026Var2);
                for (int i = 1; i <= this.f91243d4a - 1; i++) {
                    p7a2a4026Var3 = DDBkictDFPbYSXlS(gHCXtEdDGKRiWWmI(p7a2a4026Var3, p7a2a4026Var3, p7a2a4026Var), p7a2a4026Var2);
                }
                p7a2a4026VarIMNSGyHIqESSKNbz = IMNSGyHIqESSKNbz(p7a2a4026Var3, p7a2a4026Var);
                iZkwMFklXAutiPTqt = zkwMFklXAutiPTqt(p7a2a4026VarIMNSGyHIqESSKNbz);
                iZCYaZgRTinfJNvmD = ZCYaZgRTinfJNvmD(p7a2a4026Var);
                if (iZkwMFklXAutiPTqt != 0 && iZkwMFklXAutiPTqt != iZCYaZgRTinfJNvmD) {
                    break;
                }
            }
            p7a2a4026Var = (iZkwMFklXAutiPTqt << 1) <= iZCYaZgRTinfJNvmD ? new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026VarIMNSGyHIqESSKNbz) : uvpXXxYMAMhUCCSm(p7a2a4026Var, p7a2a4026VarIMNSGyHIqESSKNbz);
            iNyyHQKluEuogsucL = FKVpXHvkjXXCwTnS(p7a2a4026Var);
        }
        return cucEbCKRntpVFztZ(p7a2a4026Var, 0);
    }

    int[][] invMatrix(int[][] iArr) {
        if ((12 + 13) % 13 > 0) {
        }
        int i = this.f91243d4a;
        int[] iArr2 = new int[2];
        iArr2[1] = this.f91243d4a;
        iArr2[0] = i;
        int i2 = this.f91243d4a;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f91243d4a;
        iArr3[0] = i2;
        int[][] iArr4 = (int[][]) ZRpJBYfHqFxfRpUM(java.lang.int.TYPE, iArr3);
        for (int i3 = 0; i3 < this.f91243d4a; i3++) {
            iArr4[i3][i3] = 1;
        }
        for (int i4 = 0; i4 < this.f91243d4a; i4++) {
            for (int i5 = i4; i5 < this.f91243d4a; i5++) {
                iArr[(this.f91243d4a - 1) - i4][i5] = iArr[i4][i4];
            }
        }
        return null;
    }
}

