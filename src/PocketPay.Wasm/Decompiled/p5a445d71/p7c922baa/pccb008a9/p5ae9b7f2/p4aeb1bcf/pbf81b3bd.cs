namespace WillowMaze.Wasm.Decompiled;


public readonly class pbf81b3bd : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3a1edd0a {
    private readonly byte[] f0663c51f;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f06acae72;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 f246658d0;
    private readonly byte[] f2692010d;
    private readonly byte[] f2fe6a34f;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 f4887329e;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f4e4a9644;
    private readonly byte[] f529a2433;
    private readonly byte[] f63a9f0ea;
    private readonly long f6a992d55;
    private readonly byte[] f714a93eb;
    private readonly byte[] f78fb95e5;
    private readonly byte[] f96486d20;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f9c05b849;
    private readonly byte[] fa1456aff;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fb056f6c6;
    private readonly byte[] fb3a0a7bb;
    private readonly byte[] fc9466eea;
    private readonly byte[] fd0639700;
    private readonly long fd502351e;
    private readonly byte[] fd516a066;
    private readonly byte[] fd70b5bc6;
    private readonly byte[] ff01ab484;

    private pbf81b3bd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var;
        super(true);
        if ((21 + 12) % 12 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194VarXUqMmFbqHJgCwPJa = xUqMmFbqHJgCwPJa(pbf81b3bd_p2bd4a59b);
        this.f21ffce5b = pe6015194VarXUqMmFbqHJgCwPJa;
        if (pe6015194VarXUqMmFbqHJgCwPJa is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        int iWKAXrcNmsGUTgabB = wKAXrcNmsGUTgabB(pe6015194VarXUqMmFbqHJgCwPJa);
        byte[] bArrZfsCrhoQJnGOhVZC = ZfsCrhoQJnGOhVZC(pbf81b3bd_p2bd4a59b);
        if (bArrZfsCrhoQJnGOhVZC is not null) {
            if (ywvPgXGjYHvzsjTu(pbf81b3bd_p2bd4a59b) is null) {
                throw new java.lang.NullPointerException("xmss is null");
            }
            int iCTFHVdkwrlBwJRjb = CTFHVdkwrlBwJRjb(pe6015194VarXUqMmFbqHJgCwPJa);
            int i = (iCTFHVdkwrlBwJRjb + 7) / 8;
            long jCSPagCGhfjMbemvi = CSPagCGhfjMbemvi(bArrZfsCrhoQJnGOhVZC, 0, i);
            this.f6a992d55 = jCSPagCGhfjMbemvi;
            if (!HTXteFZIgFYFcKzU(iCTFHVdkwrlBwJRjb, jCSPagCGhfjMbemvi)) {
                throw new java.lang.IllegalArgumentException("index out of bounds");
            }
            this.fd70b5bc6 = eVIGaGUVnktnihvc(bArrZfsCrhoQJnGOhVZC, i, iWKAXrcNmsGUTgabB);
            int i2 = i + iWKAXrcNmsGUTgabB;
            this.fb3a0a7bb = isoRiDIVhRrwrqiL(bArrZfsCrhoQJnGOhVZC, i2, iWKAXrcNmsGUTgabB);
            int i3 = i2 + iWKAXrcNmsGUTgabB;
            this.f529a2433 = bPEEVydsaRyGrnYe(bArrZfsCrhoQJnGOhVZC, i3, iWKAXrcNmsGUTgabB);
            int i4 = i3 + iWKAXrcNmsGUTgabB;
            this.f63a9f0ea = jAAjUSocMXqbiRhL(bArrZfsCrhoQJnGOhVZC, i4, iWKAXrcNmsGUTgabB);
            int i5 = i4 + iWKAXrcNmsGUTgabB;
            try {
                p8fc89a90Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90) gubkRzyJXaeDxFCs(juxOwFqgRduGMyQq(bArrZfsCrhoQJnGOhVZC, i5, bArrZfsCrhoQJnGOhVZC.length - i5));
            } catch (java.io.IOException e) {
                IkSBuvvOfVEsrymE(e);
                p8fc89a90Var = null;
            } catch (java.lang.ClassNotFoundException e2) {
                VQpmwQicKGQIprdr(e2);
                p8fc89a90Var = null;
            }
            rVzNVafJwWoxKVAU(p8fc89a90Var, BgZqAuVLgMTOuiVM(pbf81b3bd_p2bd4a59b));
            this.f246658d0 = p8fc89a90Var;
            return;
        }
        this.f6a992d55 = jDrqiioENNDhyuro(pbf81b3bd_p2bd4a59b);
        byte[] bArrOdGBXZGerHmGsjZf = odGBXZGerHmGsjZf(pbf81b3bd_p2bd4a59b);
        if (bArrOdGBXZGerHmGsjZf is null) {
            this.fd70b5bc6 = new byte[iWKAXrcNmsGUTgabB];
        } else {
            if (bArrOdGBXZGerHmGsjZf.length != iWKAXrcNmsGUTgabB) {
                throw new java.lang.IllegalArgumentException("size of secretKeySeed needs to be equal size of digest");
            }
            this.fd70b5bc6 = bArrOdGBXZGerHmGsjZf;
        }
        byte[] bArrLmqCrcwzERhWpGGo = LmqCrcwzERhWpGGo(pbf81b3bd_p2bd4a59b);
        if (bArrLmqCrcwzERhWpGGo is null) {
            this.fb3a0a7bb = new byte[iWKAXrcNmsGUTgabB];
        } else {
            if (bArrLmqCrcwzERhWpGGo.length != iWKAXrcNmsGUTgabB) {
                throw new java.lang.IllegalArgumentException("size of secretKeyPRF needs to be equal size of digest");
            }
            this.fb3a0a7bb = bArrLmqCrcwzERhWpGGo;
        }
        byte[] bArrJciOKUbDlROmCrcP = JciOKUbDlROmCrcP(pbf81b3bd_p2bd4a59b);
        if (bArrJciOKUbDlROmCrcP is null) {
            this.f529a2433 = new byte[iWKAXrcNmsGUTgabB];
        } else {
            if (bArrJciOKUbDlROmCrcP.length != iWKAXrcNmsGUTgabB) {
                throw new java.lang.IllegalArgumentException("size of publicSeed needs to be equal size of digest");
            }
            this.f529a2433 = bArrJciOKUbDlROmCrcP;
        }
        byte[] bArrZfmaoiUcvpUThVgg = zfmaoiUcvpUThVgg(pbf81b3bd_p2bd4a59b);
        if (bArrZfmaoiUcvpUThVgg is null) {
            this.f63a9f0ea = new byte[iWKAXrcNmsGUTgabB];
        } else {
            if (bArrZfmaoiUcvpUThVgg.length != iWKAXrcNmsGUTgabB) {
                throw new java.lang.IllegalArgumentException("size of root needs to be equal size of digest");
            }
            this.f63a9f0ea = bArrZfmaoiUcvpUThVgg;
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90VarJxtCFotInLuMZUDv = JxtCFotInLuMZUDv(pbf81b3bd_p2bd4a59b);
        if (p8fc89a90VarJxtCFotInLuMZUDv is not null) {
            this.f246658d0 = p8fc89a90VarJxtCFotInLuMZUDv;
            return;
        }
        if (!LmCOYGHfpFsawodl(KasULJumySLNAmTO(pe6015194VarXUqMmFbqHJgCwPJa), jYWnNhqJWFvrgMMS(pbf81b3bd_p2bd4a59b)) || bArrJciOKUbDlROmCrcP is null || bArrOdGBXZGerHmGsjZf is null) {
            this.f246658d0 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90();
        } else {
            this.f246658d0 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(pe6015194VarXUqMmFbqHJgCwPJa, mgRQESgkkGDyKnxu(pbf81b3bd_p2bd4a59b), bArrJciOKUbDlROmCrcP, bArrOdGBXZGerHmGsjZf);
        }
    }

    pbf81b3bd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$1 pbf81b3bd_1) {
        this(pbf81b3bd_p2bd4a59b);
    }

    public static void AVkMtxNHIgGfPume(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 BgZqAuVLgMTOuiVM(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m337ceba5(pbf81b3bd_p2bd4a59b);
    }

    public static byte[] CLuYOnXulOqkQhYj(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2);
    }

    public static long CSPagCGhfjMbemvi(byte[] bArr, int i, int i2) {
        if ((21 + 7) % 7 > 0) {
        }
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m98ffcd8c(bArr, i, i2);
    }

    public static int CTFHVdkwrlBwJRjb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static void CiqobKXgVadIKcAF(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b CyQMHztvyhHwgHXo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, byte[] bArr) {
        return pbf81b3bd_p2bd4a59b.withRoot(bArr);
    }

    public static byte[] DuadjWTlqrMRxWcS(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static bool HTXteFZIgFYFcKzU(int i, long j) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(i, j);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b IHMXGGnelgPSCywJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, long j) {
        return pbf81b3bd_p2bd4a59b.withIndex(j);
    }

    public static long IcBOUILhKoCwybXC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar) {
        if ((14 + 9) % 9 > 0) {
        }
        return pbf81b3bdVar.getIndex();
    }

    public static void IkSBuvvOfVEsrymE(java.io.IOException iOException) {
        iOException.printStackTrace();
    }

    public static byte[] JciOKUbDlROmCrcP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m429f062d(pbf81b3bd_p2bd4a59b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 JxtCFotInLuMZUDv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m0dc0a6ea(pbf81b3bd_p2bd4a59b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b KQiIylcXbpseRdBm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var) {
        return pbf81b3bd_p2bd4a59b.withBDSState(p8fc89a90Var);
    }

    public static int KasULJumySLNAmTO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static bool LmCOYGHfpFsawodl(int i, long j) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(i, j);
    }

    public static byte[] LmqCrcwzERhWpGGo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m89082e03(pbf81b3bd_p2bd4a59b);
    }

    public static byte[] MFNBspEDVBYINzBy(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd NDSgVtRyLVeRiIxI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return pbf81b3bd_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b OBNVfzGpFexqMdRg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, byte[] bArr) {
        return pbf81b3bd_p2bd4a59b.withSecretKeySeed(bArr);
    }

    public static int SKHUtITzYgXotNNH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b SvqGtlSRUHynLqTi(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, byte[] bArr) {
        return pbf81b3bd_p2bd4a59b.withSecretKeyPRF(bArr);
    }

    public static void VQpmwQicKGQIprdr(java.lang.ClassNotFoundException classNotFoundException) {
        classNotFoundException.printStackTrace();
    }

    public static void WeiQHyLQxeeobAiK(java.io.IOException iOException) {
        iOException.printStackTrace();
    }

    public static byte[] YoCXSgWUyZeDPptn(long j, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(j, i);
    }

    public static byte[] ZfsCrhoQJnGOhVZC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mf8f67da7(pbf81b3bd_p2bd4a59b);
    }

    public static byte[] BPEEVydsaRyGrnYe(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static byte[] EVIGaGUVnktnihvc(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static void FIwZtvAKmtvIdBdu(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static void FZLASihECVCwmFoB(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static java.lang.object GubkRzyJXaeDxFCs(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(bArr);
    }

    public static byte[] HAhERJEqthWjGtgZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m235cdd01(obj);
    }

    public static byte[] IsoRiDIVhRrwrqiL(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static byte[] JAAjUSocMXqbiRhL(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static long JDrqiioENNDhyuro(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        if ((28 + 9) % 9 > 0) {
        }
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m5ec06fdf(pbf81b3bd_p2bd4a59b);
    }

    public static long JYWnNhqJWFvrgMMS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        if ((27 + 18) % 18 > 0) {
        }
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m5ec06fdf(pbf81b3bd_p2bd4a59b);
    }

    public static byte[] JuxOwFqgRduGMyQq(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(bArr, i, i2);
    }

    public static long MgRQESgkkGDyKnxu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        if ((26 + 16) % 16 > 0) {
        }
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m5ec06fdf(pbf81b3bd_p2bd4a59b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b moSJRDbQmONMZBws(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b, byte[] bArr) {
        return pbf81b3bd_p2bd4a59b.withPublicSeed(bArr);
    }

    public static void NyjZxQbMZDMjiJva(byte[] bArr, byte[] bArr2, int i) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7d427729(bArr, bArr2, i);
    }

    public static byte[] OdGBXZGerHmGsjZf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mbbeb9b46(pbf81b3bd_p2bd4a59b);
    }

    public static void RVzNVafJwWoxKVAU(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        p8fc89a90Var.setXMSS(pf62ef2d9Var);
    }

    public static byte[] UbtODgaNLoJDEBTs(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static byte[] VVtNgxKMOgQXptDS(byte[] bArr) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20260f59(bArr);
    }

    public static int WKAXrcNmsGUTgabB(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 XUqMmFbqHJgCwPJa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.mf23e8626(pbf81b3bd_p2bd4a59b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 YwvPgXGjYHvzsjTu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m337ceba5(pbf81b3bd_p2bd4a59b);
    }

    public static int ZeeWOjwLIIzMJbvn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var) {
        return pe6015194Var.getHeight();
    }

    public static byte[] ZfmaoiUcvpUThVgg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59b) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b.m13fe7af4(pbf81b3bd_p2bd4a59b);
    }

    p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 getBDSState() {
        return this.f246658d0;
    }

    public long GetIndex() {
        if ((12 + 32) % 32 > 0) {
        }
        return this.f6a992d55;
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd GetNextKey() {
        if ((2 + 30) % 30 > 0) {
        }
        return NDSgVtRyLVeRiIxI(KQiIylcXbpseRdBm(CyQMHztvyhHwgHXo(moSJRDbQmONMZBws(SvqGtlSRUHynLqTi(OBNVfzGpFexqMdRg(IHMXGGnelgPSCywJ(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(this.f21ffce5b), this.f6a992d55 + 1), this.fd70b5bc6), this.fb3a0a7bb), this.f529a2433), this.f63a9f0ea), new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(this.f246658d0, this.f21ffce5b, IcBOUILhKoCwybXC(this), this.f529a2433, this.fd70b5bc6)));
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 GetParameters() {
        return this.f21ffce5b;
    }

    public byte[] GetPublicSeed() {
        return vVtNgxKMOgQXptDS(this.f529a2433);
    }

    public byte[] GetRoot() {
        return ubtODgaNLoJDEBTs(this.f63a9f0ea);
    }

    public byte[] GetSecretKeyPRF() {
        return DuadjWTlqrMRxWcS(this.fb3a0a7bb);
    }

    public byte[] GetSecretKeySeed() {
        return MFNBspEDVBYINzBy(this.fd70b5bc6);
    }

    public override byte[] TobyteArray() {
        if ((15 + 10) % 10 > 0) {
        }
        int iSKHUtITzYgXotNNH = SKHUtITzYgXotNNH(this.f21ffce5b);
        int iZeeWOjwLIIzMJbvn = (zeeWOjwLIIzMJbvn(this.f21ffce5b) + 7) / 8;
        byte[] bArr = new byte[iZeeWOjwLIIzMJbvn + iSKHUtITzYgXotNNH + iSKHUtITzYgXotNNH + iSKHUtITzYgXotNNH + iSKHUtITzYgXotNNH];
        fZLASihECVCwmFoB(bArr, YoCXSgWUyZeDPptn(this.f6a992d55, iZeeWOjwLIIzMJbvn), 0);
        CiqobKXgVadIKcAF(bArr, this.fd70b5bc6, iZeeWOjwLIIzMJbvn);
        int i = iZeeWOjwLIIzMJbvn + iSKHUtITzYgXotNNH;
        fIwZtvAKmtvIdBdu(bArr, this.fb3a0a7bb, i);
        int i2 = i + iSKHUtITzYgXotNNH;
        AVkMtxNHIgGfPume(bArr, this.f529a2433, i2);
        nyjZxQbMZDMjiJva(bArr, this.f63a9f0ea, i2 + iSKHUtITzYgXotNNH);
        try {
            return CLuYOnXulOqkQhYj(bArr, hAhERJEqthWjGtgZ(this.f246658d0));
        } catch (java.io.IOException e) {
            WeiQHyLQxeeobAiK(e);
            throw new java.lang.Exception("error serializing bds state");
        }
    }
}

