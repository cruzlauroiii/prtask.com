namespace WillowMaze.Wasm.Decompiled;


public readonly class p1a8a272a : java.io.object {
    private static readonly long fc6e1e520 = 1;
    private static readonly long fd19ab02c = 1;
    private static readonly long fdfcf7d5a = 1;
    private java.util.Stack f04d28426;
    private java.util.Dictionary<java.lang.int, java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f>> f16d79ff8;
    private java.util.Dictionary f180315db;
    private java.util.Dictionary<java.lang.int, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> f18ccf61d;
    private java.util.Dictionary f1927bcf4;
    private bool f1aec9c5d;
    private int f2419e443;
    private java.util.Dictionary f2ba45a7d;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f f3ec4eb8b;
    private int f45f0be5f;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f f4c03519a;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f4e53eebb;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f f63a9f0ea;
    private int f6a992d55;
    private readonly int f71a91324;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f f75335a5c;
    private java.util.Dictionary f7dc41a29;
    private java.util.Dictionary f7f280c89;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f7f9b4886;
    private java.util.Dictionary f81572c0b;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f8b8bc6f2;
    private int f8ce4b16b;
    private java.util.List f9567a46d;
    private java.util.Dictionary f9e65d34a;
    private readonly int fa3c1eb3e;
    private readonly java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa> fabda931c;
    private java.util.List fb5172b04;
    private int fbd65ee34;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f fcdbffa94;
    private readonly int fcfb32d9a;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b fd948d68a;
    private int fd97e83b4;
    private int fdbec8bd9;
    private readonly java.util.List fe6289e69;
    private java.util.Dictionary feb0d28d6;
    private readonly int feb11f0b8;
    private java.util.Stack fedf6cae9;
    private bool fee7124cf;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b ff0b3b586;
    private int ff1adb837;
    private int ff9f5d623;
    private java.util.Stack<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> ffac2a47a;
    private java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> fff15c910;

    private p1a8a272a(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((11 + 30) % 30 > 0) {
        }
        this.f8b8bc6f2 = p1a8a272aVar.f8b8bc6f2;
        this.f71a91324 = p1a8a272aVar.f71a91324;
        this.f8ce4b16b = p1a8a272aVar.f8ce4b16b;
        this.f63a9f0ea = p1a8a272aVar.f63a9f0ea;
        this.fff15c910 = new java.util.List(p1a8a272aVar.fff15c910);
        this.f16d79ff8 = p1a8a272aVar.f16d79ff8;
        this.ffac2a47a = (java.util.Stack) naJimDjfDyyJFLTv(p1a8a272aVar.ffac2a47a);
        this.fabda931c = p1a8a272aVar.fabda931c;
        this.f18ccf61d = new java.util.TreeDictionary(p1a8a272aVar.f18ccf61d);
        this.f6a992d55 = p1a8a272aVar.f6a992d55;
        RONDSpeuCFKaYJsJ(this, bArr, bArr2, pd57771baVar);
        p1a8a272aVar.f1aec9c5d = true;
    }

    private p1a8a272a(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, int i, int i2) {
        if ((11 + 13) % 13 > 0) {
        }
        this.f8b8bc6f2 = p893af95bVar;
        this.f71a91324 = i;
        this.f8ce4b16b = i2;
        if (i2 <= i && i2 >= 2) {
            int i3 = i - i2;
            if (i3 % 2 == 0) {
                this.fff15c910 = new java.util.List();
                this.f16d79ff8 = new java.util.TreeDictionary();
                this.ffac2a47a = new java.util.Stack<>();
                this.fabda931c = new java.util.List();
                for (int i4 = 0; i4 < i3; i4++) {
                    HQkMDZCuIOGlSCHz(this.fabda931c, new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa(i4));
                }
                this.f18ccf61d = new java.util.TreeDictionary();
                this.f6a992d55 = 0;
                this.f1aec9c5d = false;
                return;
            }
        }
        throw new java.lang.IllegalArgumentException("illegal value for BDS parameter k");
    }

    p1a8a272a(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var, int i) {
        this(HXLpwEBbgqGRVRTo(pf62ef2d9Var), myBaasoqeWuyLJqD(pf62ef2d9Var), vONSAnsENqEIiKiO(pf62ef2d9Var));
        if ((32 + 30) % 30 > 0) {
        }
        this.f6a992d55 = i;
        this.f1aec9c5d = true;
    }

    p1a8a272a(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        this(GTsYdlTGrPgiaWZX(pf62ef2d9Var), ZTwTGdjEYNwOHtNP(pf62ef2d9Var), jJVNvBLOrKAUJWBP(pf62ef2d9Var));
        if ((9 + 20) % 20 > 0) {
        }
        fLAiyXiUCBEiVFKg(this, bArr, bArr2, pd57771baVar);
    }

    p1a8a272a(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar, int i) {
        this(ZqNljzCzhNklFjHa(pf62ef2d9Var), idQijPHuEUGSpPnz(pf62ef2d9Var), rJzVyRROkzpXJfxJ(pf62ef2d9Var));
        if ((15 + 18) % 18 > 0) {
        }
        CauUwoNezlvjIsuV(this, bArr, bArr2, pd57771baVar);
        while (this.f6a992d55 < i) {
            TjfgylwdcFvtmACi(this, bArr, bArr2, pd57771baVar);
            this.f1aec9c5d = false;
        }
    }

    public static java.lang.int AFsKdiclSbdtseLx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object AMVMVMyBxzGdorNT(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static long AOAoPbFdDnOEpzng(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((16 + 32) % 32 > 0) {
        }
        return pd57771baVar.getTreeAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa AQspDIFpdgNhyEaS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar) {
        return p1a8a272aVar.m4e9dac23();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b AWpYlMstfIQGVHjS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withLayerAddress(i);
    }

    public static void AXZJVfJJsdOvZmNI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        p46a7b4aaVar.setNode(p1fc1317fVar);
    }

    public static java.lang.object BAHRjLZXfHyvZLzB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void BDvuMHCRFzLwGGDx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static int BHwywKdREmGpGePx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static bool BLQtKAMSAfZjNeZP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object BaBpEvyNXZYblJHA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int BuaNsHMOgJHogmin(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getKeyAndMask();
    }

    public static java.lang.object BwiJnMecTsKotWSC(java.util.Stack stack) {
        return stack.peek();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b BxvzCnaojEcXzMTr(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withLayerAddress(i);
    }

    public static int CExQNnqDpiqatMXR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getChainAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b COdWFFPFZwbShGEX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withLayerAddress(i);
    }

    public static void CauUwoNezlvjIsuV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        p1a8a272aVar.m30db5978(bArr, bArr2, pd57771baVar);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f CerywBTXbQeEpoGd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static long CtosxramkdltIFRt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        if ((30 + 17) % 17 > 0) {
        }
        return p8e77ec20Var.getTreeAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 CyvKVenDCDUOevET(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b) {
        return pd57771ba_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b DTlXpdMaUbEaGXNP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeIndex(i);
    }

    public static int DhvGjMVXQarVZFNR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static java.util.IEnumerator DvcHDbsajOStQdDR(java.util.List list) {
        return list.GetEnumerator();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 ERaFdIihHJyTyiHh(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b) {
        return p47010d60_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b EklxGsfHFUzIhRhj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, long j) {
        return p8e77ec20_p2bd4a59b.withTreeAddress(j);
    }

    public static java.lang.int EwMbzWDBgikcYNTG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int FCSCFXFsPTghHnWq(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getTreeHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f FIUaeQqEZMejqbHu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b FQUjLqdlDlevURhX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withTreeIndex(i);
    }

    public static int FdAmIdAdILVxEwJl(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getTreeIndex();
    }

    public static java.lang.object FjLBOwtVOFFDFyEz(java.util.Stack stack, java.lang.object obj) {
        return stack.push(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f GAxBwbepmVJrDFDz(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static int GFsAkQTsWowzqejv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getKeyAndMask();
    }

    public static java.lang.object GPHhYVwuoLKEkRRD(java.util.List list, int i) {
        return list[i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b GTsYdlTGrPgiaWZX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static void GdBadaHiCADTjFfK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2) {
        p893af95bVar.importKeys(bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b GqnztPaFBkwShMNj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, long j) {
        return pd57771ba_p2bd4a59b.withTreeAddress(j);
    }

    public static java.lang.object GtpvYxzpTwNlYTkt(java.util.List list, int i) {
        return list[i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 HFwWwgtMLVkAIsYB(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.build();
    }

    public static bool HQkMDZCuIOGlSCHz(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b HThkWYNMZnvGiwBZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withHashAddress(i);
    }

    public static int HUXVVylkwNGLuLVG(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b HXLpwEBbgqGRVRTo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f HhsUAkZNHsIELTVN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getTailNode();
    }

    public static int HlmmPHBCJTjwjFLE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getLayerAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b ICikYmNvzhWyVVyx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withLayerAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b ICzJOVrBjDKkFsUS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeHeight(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b IErmdAKJaFTaZaXZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withLayerAddress(i);
    }

    public static int IXrrOlnnInpJYarW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getTreeHeight();
    }

    public static int IgBvCrYhewaLcFVr(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getKeyAndMask();
    }

    public static int IiwrwdyaBWicHIjk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getHeight();
    }

    public static int IkTgnVtbMSPkmSzp(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 JVeZqFCZrEexkymw(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return p893af95bVar.getPublicKey(pd57771baVar);
    }

    public static int JqjqNbgkKEwlTJBp(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getKeyAndMask();
    }

    public static int JuQnzUjDcqSOzeQs(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getTreeIndex();
    }

    public static void KMyAiVEIwLjuRCNk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar, int i) {
        p46a7b4aaVar.initialize(i);
    }

    public static int KcyZYEWhsVqJirsa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getLayerAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f KjwLgdzgmOnPaGlX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static int LACXYkdNoCXTWtnl(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getLayerAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b LBAyYTlyrBtNAGCJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeHeight(i);
    }

    public static int LHaYehJjSgYuHuKb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static byte[] LLuklAANIREKSYPG(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return p893af95bVar.getWOTSPlusSecretKey(bArr, pd57771baVar);
    }

    public static byte[] LecnuBQXyJqqUrjM(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getValue();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b MBGesWIsnDHNhNTV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withChainAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b MKapTMRtptcACZBT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withLayerAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b MMWcSPIgnCFlluah(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withLayerAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b MaAPHEoreyclCkPm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, long j) {
        return p8e77ec20_p2bd4a59b.withTreeAddress(j);
    }

    public static java.lang.int MrlAjKPreeNLObNb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int NNCLpnrWcGbsmfuC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static bool NkWiVspNyumMurMj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.int OAdaJJUMQvGWPQiU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OSDrnzfeHSULzdXh(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getLayerAddress();
    }

    public static java.lang.object PLaeuKAEZbZiuUQh(java.util.List linkedList) {
        return linkedList.removeFirst();
    }

    public static bool PVniPIBrhTgxBRwv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 PaIYcgttHPGLgNQK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return p893af95bVar.getPublicKey(pd57771baVar);
    }

    public static int PpaBbqkqotUTzGWW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getIndexLeaf();
    }

    public static java.lang.object PsHmgsxXgFwZsMad(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static java.lang.object QIHUYgcFFhXurvwB(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b QnvZzhXPYJGYsbfa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withLTreeAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 RIZMbGEDNhTUFpah(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.build();
    }

    public static void RONDSpeuCFKaYJsJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        p1a8a272aVar.m8657c66d(bArr, bArr2, pd57771baVar);
    }

    public static int RRUVwschDwcybjYb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 RiEOBylObrYoehGd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.build();
    }

    public static long SLGWLvoaiWSrRNFd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        if ((19 + 18) % 18 > 0) {
        }
        return p47010d60Var.getTreeAddress();
    }

    public static bool SNcusZZCaUxxCYOs(int i, long j) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(i, j);
    }

    public static int SYXinRKmMLohrvFc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getLayerAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b SlGctLfhgGruQsBa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withTreeIndex(i);
    }

    public static int SzqchkONDtKhWrLE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getKeyAndMask();
    }

    public static bool TGOCpkAOUetJskTv(java.util.List linkedList, java.lang.object obj) {
        return linkedList.Add(obj);
    }

    public static int TidebtZlZKujJSPQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static void TjfgylwdcFvtmACi(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        p1a8a272aVar.m8657c66d(bArr, bArr2, pd57771baVar);
    }

    public static int UCYWmVmcNUckKvCB(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getTreeHeight();
    }

    public static java.lang.object UHWVuYHVHMwqazfo(java.util.List list, int i) {
        return list[i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b UexKvQcLxQKuzkdj(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, long j) {
        return pd57771ba_p2bd4a59b.withTreeAddress(j);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b UuebVkhJnwsdNYBK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withKeyAndMask(i);
    }

    public static int UyGqdzkCNUhhvoUA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getLayerAddress();
    }

    public static int VkzbTjZeXsGtniHi(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getHeight();
    }

    public static bool WNiCfaekhjichAsJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.isFinished();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b WShUladpJTucKTrn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withKeyAndMask(i);
    }

    public static int WkGyyiYYpPMUBSuF(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int WtAzfxeheDnOTREv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getIndexLeaf();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f WvCRvLdiiXJKbnmw(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static int XDFfhayxgGtvzNdw(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getLayerAddress();
    }

    public static int XWygckVUNRgrrFUk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getLayerAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b XnbgdkmnfRDLxnDN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, long j) {
        return p47010d60_p2bd4a59b.withTreeAddress(j);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b XncOwFRTfQJZttJb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withOTSAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f XxZXhOucbHwtKyhu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static java.lang.object YYKyePXlVGIpwurE(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b YfYFpwhWEdWsUFem(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b YfzbqpsmiliBDSWL(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withKeyAndMask(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f YsdwMHnvvtUxnMXN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 p6f7f1de0Var) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mf5f9638e(p893af95bVar, p1fc1317fVar, p1fc1317fVar2, p6f7f1de0Var);
    }

    public static byte[] YtuIGOSssERfDqCp(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return p893af95bVar.getWOTSPlusSecretKey(bArr, pd57771baVar);
    }

    public static int YuUbOpfZiQheCoTG(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getLayerAddress();
    }

    public static java.util.IEnumerator ZBJrgOYgBDhIJuVS(java.util.List list) {
        return list.GetEnumerator();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b ZQvjRDSyelDENEyk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, long j) {
        return p8e77ec20_p2bd4a59b.withTreeAddress(j);
    }

    public static java.lang.int ZRbBEzrkcWHViOVr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ZTwTGdjEYNwOHtNP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b ZiRzjlibvkbICIQc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeIndex(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f ZnBCYSSeZkmzCsId(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 p1c819941Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mb26c5a9b(p893af95bVar, p1c819941Var, p47010d60Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b ZqNljzCzhNklFjHa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getWOTSPlus();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b aCCXlQpJdApQnmWt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withOTSAddress(i);
    }

    public static bool AEczxCDxESENKDNM(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.isInitialized();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b aPlJHWNalyOrTudT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, long j) {
        return p47010d60_p2bd4a59b.withTreeAddress(j);
    }

    public static java.lang.int BNfFgEGumlZCHmVY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long BXMRlNWxKwLpNpUh(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        if ((27 + 4) % 4 > 0) {
        }
        return p8e77ec20Var.getTreeAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 BYNkpwoOCRwCNUpo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b) {
        return pd57771ba_p2bd4a59b.build();
    }

    public static int BZUjNycwsdmOjbrJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static java.lang.object CGSJUIqNIlYArnhr(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool DIkVJJGCHvdsPpRb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b dWEBhJwZENLrhVCw(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, long j) {
        return p8e77ec20_p2bd4a59b.withTreeAddress(j);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 DniLytqctofSdFjt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b) {
        return p47010d60_p2bd4a59b.build();
    }

    public static java.lang.object EVyvmwFgFCUkpleE(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b eXWNpJWqOFyipunf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withLayerAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 EZiMkdeUBEveyauH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b eeeEjLZhPJhSnVjd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withTreeHeight(i);
    }

    public static java.lang.object EfBjYMquxrTHUFUH(java.util.List list, int i) {
        return list[i);
    }

    public static byte[] EgEqnIzbVMEhaeCK(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getValue();
    }

    public static int EymwTyLtBDLeQnqa(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getTreeIndex();
    }

    public static void FLAiyXiUCBEiVFKg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        p1a8a272aVar.m30db5978(bArr, bArr2, pd57771baVar);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b fPoSMpDFjPjXhyrH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeIndex(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b fUFSOKfxtDCyZQle(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withChainAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b fkiyaPGjTSwUDMeI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withLTreeAddress(i);
    }

    public static int HMoWyiDkHcSNWtzg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getTreeHeight();
    }

    public static int IDQfyaVwXXTreUNl(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getLayerAddress();
    }

    public static int IVVyauXHFURvCqSN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getLayerAddress();
    }

    public static int IdQijPHuEUGSpPnz(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getHeight();
    }

    public static int JBngQXYCtPUmBmOb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getHeight();
    }

    public static int JJVNvBLOrKAUJWBP(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getK();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b jvzDEcQGRoIhBYtg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withKeyAndMask(i);
    }

    public static long KJCgBdTzTgrZTVLX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        if ((24 + 15) % 15 > 0) {
        }
        return p8e77ec20Var.getTreeAddress();
    }

    public static int KZezjKYFCMkvdJmk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getLayerAddress();
    }

    public static int KeWrKPtFFDkhTqRm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static java.lang.object KhyFTpycsWhgcOOH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b kotYQXVfmnESQhiF(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, long j) {
        return p47010d60_p2bd4a59b.withTreeAddress(j);
    }

    public static java.lang.object LEYJEjJeyfUanHSv(java.util.List list, int i) {
        return list[i);
    }

    public static int LUpQQdtqULmlSEds(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p47010d60Var.getTreeIndex();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b lfWGhKUrihHuWSvV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withTreeHeight(i);
    }

    public static long LuoKInHaubZBXsgd(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((11 + 9) % 9 > 0) {
        }
        return pd57771baVar.getTreeAddress();
    }

    private void M30db5978(byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((31 + 24) % 24 > 0) {
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ozkoLjIDYIisRpMY((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) XnbgdkmnfRDLxnDN((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ICikYmNvzhWyVVyx(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b(), iDQfyaVwXXTreUNl(pd57771baVar)), luoKInHaubZBXsgd(pd57771baVar)));
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) eZiMkdeUBEveyauH((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) EklxGsfHFUzIhRhj((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) oOvgPPNvgiaVDOTB(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b(), SYXinRKmMLohrvFc(pd57771baVar)), rpNstbgVtuGOHOzt(pd57771baVar)));
        for (int i = 0; i < (1 << this.f71a91324); i++) {
            pd57771baVar = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) CyvKVenDCDUOevET((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) pgPdIwMtMZEmudDx(HThkWYNMZnvGiwBZ(fUFSOKfxtDCyZQle(aCCXlQpJdApQnmWt((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) GqnztPaFBkwShMNj((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) MKapTMRtptcACZBT(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b(), XDFfhayxgGtvzNdw(pd57771baVar)), AOAoPbFdDnOEpzng(pd57771baVar)), i), CExQNnqDpiqatMXR(pd57771baVar)), sGOznMqzrtEsrsjJ(pd57771baVar)), IgBvCrYhewaLcFVr(pd57771baVar)));
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar = this.f8b8bc6f2;
            GdBadaHiCADTjFfK(p893af95bVar, YtuIGOSssERfDqCp(p893af95bVar, bArr2, pd57771baVar), bArr);
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 p1c819941VarJVeZqFCZrEexkymw = JVeZqFCZrEexkymw(this.f8b8bc6f2, pd57771baVar);
            p47010d60Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) dniLytqctofSdFjt((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) WShUladpJTucKTrn(SlGctLfhgGruQsBa(eeeEjLZhPJhSnVjd(QnvZzhXPYJGYsbfa((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) kotYQXVfmnESQhiF((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) MMWcSPIgnCFlluah(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b(), iVVyauXHFURvCqSN(p47010d60Var)), qYJHGTVSzOcQfQWV(p47010d60Var)), i), UCYWmVmcNUckKvCB(p47010d60Var)), lUpQQdtqULmlSEds(p47010d60Var)), GFsAkQTsWowzqejv(p47010d60Var)));
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVarUZbrCxbTBSlSSDfT = uZbrCxbTBSlSSDfT(this.f8b8bc6f2, p1c819941VarJVeZqFCZrEexkymw, p47010d60Var);
            p8e77ec20Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) wEbAaXfmgSZqqNbY((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) jvzDEcQGRoIhBYtg(DTlXpdMaUbEaGXNP((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) dWEBhJwZENLrhVCw((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) AWpYlMstfIQGVHjS(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b(), XWygckVUNRgrrFUk(p8e77ec20Var)), bXMRlNWxKwLpNpUh(p8e77ec20Var)), i), spKnkNfXWOBwmiVN(p8e77ec20Var)));
            while (!qmdwzisoeDtMSiCl(this.ffac2a47a) && TidebtZlZKujJSPQ((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) BwiJnMecTsKotWSC(this.ffac2a47a)) == BHwywKdREmGpGePx(p1fc1317fVarUZbrCxbTBSlSSDfT)) {
                int iPqaKImaLGafzXVDd = (int) pqaKImaLGafzXVDd(i / (1 << LHaYehJjSgYuHuKb(p1fc1317fVarUZbrCxbTBSlSSDfT)));
                if (iPqaKImaLGafzXVDd == 1) {
                    dIkVJJGCHvdsPpRb(this.fff15c910, GAxBwbepmVJrDFDz(p1fc1317fVarUZbrCxbTBSlSSDfT));
                }
                if (iPqaKImaLGafzXVDd == 3 && snBEkYVvVlULYIXp(p1fc1317fVarUZbrCxbTBSlSSDfT) < this.f71a91324 - this.f8ce4b16b) {
                    AXZJVfJJsdOvZmNI((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa) lEYJEjJeyfUanHSv(this.fabda931c, bZUjNycwsdmOjbrJ(p1fc1317fVarUZbrCxbTBSlSSDfT)), CerywBTXbQeEpoGd(p1fc1317fVarUZbrCxbTBSlSSDfT));
                }
                if (iPqaKImaLGafzXVDd >= 3 && (iPqaKImaLGafzXVDd & 1) == 1 && keWrKPtFFDkhTqRm(p1fc1317fVarUZbrCxbTBSlSSDfT) >= this.f71a91324 - this.f8ce4b16b && DhvGjMVXQarVZFNR(p1fc1317fVarUZbrCxbTBSlSSDfT) <= this.f71a91324 - 2) {
                    if (wgtCadLWUxZSxxQO(this.f16d79ff8, bNfFgEGumlZCHmVY(smRLaGeLEBNsaKDS(p1fc1317fVarUZbrCxbTBSlSSDfT))) is not null) {
                        maBPwZtVEMpHoKVy((java.util.List) cGSJUIqNIlYArnhr(this.f16d79ff8, wYSdNqjsEskfADzv(RRUVwschDwcybjYb(p1fc1317fVarUZbrCxbTBSlSSDfT))), WvCRvLdiiXJKbnmw(p1fc1317fVarUZbrCxbTBSlSSDfT));
                    } else {
                        java.util.List linkedList = new java.util.List();
                        TGOCpkAOUetJskTv(linkedList, nwceUBmHqpsmWotm(p1fc1317fVarUZbrCxbTBSlSSDfT));
                        khyFTpycsWhgcOOH(this.f16d79ff8, AFsKdiclSbdtseLx(NNCLpnrWcGbsmfuC(p1fc1317fVarUZbrCxbTBSlSSDfT)), linkedList);
                    }
                }
                p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var2 = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) RiEOBylObrYoehGd((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) yomQbQRMNvXLqwVn(fPoSMpDFjPjXhyrH(rnZPQmTHArAWdxqx((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) MaAPHEoreyclCkPm((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) eXWNpJWqOFyipunf(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b(), kZezjKYFCMkvdJmk(p8e77ec20Var)), CtosxramkdltIFRt(p8e77ec20Var)), IXrrOlnnInpJYarW(p8e77ec20Var)), (FdAmIdAdILVxEwJl(p8e77ec20Var) - 1) / 2), SzqchkONDtKhWrLE(p8e77ec20Var)));
                p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVarYsdwMHnvvtUxnMXN = YsdwMHnvvtUxnMXN(this.f8b8bc6f2, (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) nOAyjHpRXCXsRXIM(this.ffac2a47a), p1fc1317fVarUZbrCxbTBSlSSDfT, p8e77ec20Var2);
                p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(wGIjpqrpVGWwYxPs(p1fc1317fVarYsdwMHnvvtUxnMXN) + 1, egEqnIzbVMEhaeCK(p1fc1317fVarYsdwMHnvvtUxnMXN));
                p8e77ec20Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ubLSiGiMtQIReWMZ((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) pQqYSWJKzTKknAXC(ZiRzjlibvkbICIQc(ICzJOVrBjDKkFsUS((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ZQvjRDSyelDENEyk((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ugfjNFfHdOPHyMVN(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b(), OSDrnzfeHSULzdXh(p8e77ec20Var2)), kJCgBdTzTgrZTVLX(p8e77ec20Var2)), FCSCFXFsPTghHnWq(p8e77ec20Var2) + 1), eymwTyLtBDLeQnqa(p8e77ec20Var2)), oSzZYjrBaOSwvkGx(p8e77ec20Var2)));
                p1fc1317fVarUZbrCxbTBSlSSDfT = p1fc1317fVar;
            }
            FjLBOwtVOFFDFyEz(this.ffac2a47a, p1fc1317fVarUZbrCxbTBSlSSDfT);
        }
        this.f63a9f0ea = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) zBxVgHgWLJggrrez(this.ffac2a47a);
    }

    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa M4e9dac23() {
        if ((19 + 11) % 11 > 0) {
        }
        java.util.IEnumerator itDvcHDbsajOStQdDR = DvcHDbsajOStQdDR(this.fabda931c);
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar = null;
        while (PVniPIBrhTgxBRwv(itDvcHDbsajOStQdDR)) {
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar2 = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa) BaBpEvyNXZYblJHA(itDvcHDbsajOStQdDR);
            if (!WNiCfaekhjichAsJ(p46a7b4aaVar2) && aEczxCDxESENKDNM(p46a7b4aaVar2) && (p46a7b4aaVar is null || omdGnRhlzJdiOMHY(p46a7b4aaVar2) < HUXVVylkwNGLuLVG(p46a7b4aaVar) || (jBngQXYCtPUmBmOb(p46a7b4aaVar2) == IiwrwdyaBWicHIjk(p46a7b4aaVar) && WtAzfxeheDnOTREv(p46a7b4aaVar2) < PpaBbqkqotUTzGWW(p46a7b4aaVar)))) {
                p46a7b4aaVar = p46a7b4aaVar2;
            }
        }
        return p46a7b4aaVar;
    }

    private void M8657c66d(byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        byte[] bArr3;
        byte[] bArr4;
        if ((26 + 19) % 19 > 0) {
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        if (this.f1aec9c5d) {
            throw new java.lang.IllegalStateException("index already used");
        }
        if (this.f6a992d55 > (1 << this.f71a91324) - 2) {
            throw new java.lang.IllegalStateException("index out of bounds");
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) yfVtyqpwzccihynw((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) qyUfBvhqOStPfpbl((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) moXcQllXbYWyJNHH(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b(), YuUbOpfZiQheCoTG(pd57771baVar)), wDmQpDMNXsbTFqga(pd57771baVar)));
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) RIZMbGEDNhTUFpah((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) pkotdZaQQJhKgQpE((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) IErmdAKJaFTaZaXZ(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b(), LACXYkdNoCXTWtnl(pd57771baVar)), swQDxIIbNFhjaLOO(pd57771baVar)));
        int iWZycnkiEnbgpLNzf = wZycnkiEnbgpLNzf(this.f6a992d55, this.f71a91324);
        if (((this.f6a992d55 >> (iWZycnkiEnbgpLNzf + 1)) & 1) == 0 && iWZycnkiEnbgpLNzf < this.f71a91324 - 1) {
            wYijFrVBMlqmsbBz(this.f18ccf61d, OAdaJJUMQvGWPQiU(iWZycnkiEnbgpLNzf), XxZXhOucbHwtKyhu((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) GtpvYxzpTwNlYTkt(this.fff15c910, iWZycnkiEnbgpLNzf)));
        }
        int i = 0;
        if (iWZycnkiEnbgpLNzf != 0) {
            int i2 = iWZycnkiEnbgpLNzf - 1;
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVarRssdrwnDPiuuHAFt = rssdrwnDPiuuHAFt(this.f8b8bc6f2, (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) UHWVuYHVHMwqazfo(this.fff15c910, i2), (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) wFvjnRAzPecVFxTL(this.f18ccf61d, EwMbzWDBgikcYNTG(i2)), (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) HFwWwgtMLVkAIsYB((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) UuebVkhJnwsdNYBK(rtIDFSVLSoVEZmUe(LBAyYTlyrBtNAGCJ((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) pcLlZQbjCtjKwvBn((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) skKmVThwLKMUUdfY(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b(), HlmmPHBCJTjwjFLE(p8e77ec20Var)), uzIxUjsxZHoUcAbY(p8e77ec20Var)), i2), this.f6a992d55 >> iWZycnkiEnbgpLNzf), pUZJERUSwdUbwgvC(p8e77ec20Var))));
            AMVMVMyBxzGdorNT(this.fff15c910, iWZycnkiEnbgpLNzf, new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(IkTgnVtbMSPkmSzp(p1fc1317fVarRssdrwnDPiuuHAFt) + 1, LecnuBQXyJqqUrjM(p1fc1317fVarRssdrwnDPiuuHAFt)));
            YYKyePXlVGIpwurE(this.f18ccf61d, ZRbBEzrkcWHViOVr(i2));
            for (int i3 = 0; i3 < iWZycnkiEnbgpLNzf; i3++) {
                if (i3 >= this.f71a91324 - this.f8ce4b16b) {
                    PsHmgsxXgFwZsMad(this.fff15c910, i3, PLaeuKAEZbZiuUQh((java.util.List) QIHUYgcFFhXurvwB(this.f16d79ff8, MrlAjKPreeNLObNb(i3))));
                } else {
                    pCaWUgvNEEgspuHr(this.fff15c910, i3, HhsUAkZNHsIELTVN((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa) GPHhYVwuoLKEkRRD(this.fabda931c, i3)));
                }
            }
            int iWkGyyiYYpPMUBSuF = WkGyyiYYpPMUBSuF(iWZycnkiEnbgpLNzf, this.f71a91324 - this.f8ce4b16b);
            for (int i4 = 0; i4 < iWkGyyiYYpPMUBSuF; i4++) {
                int i5 = this.f6a992d55 + 1 + ((1 << i4) * 3);
                if (i5 < (1 << this.f71a91324)) {
                    KMyAiVEIwLjuRCNk((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa) efBjYMquxrTHUFUH(this.fabda931c, i4), i5);
                }
            }
        } else {
            pd57771baVar = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) bYNkpwoOCRwCNUpo((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) qsagHsBkxfRqjWuC(ucmdmqbqEgdouwUF(MBGesWIsnDHNhNTV(XncOwFRTfQJZttJb((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) UexKvQcLxQKuzkdj((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) BxvzCnaojEcXzMTr(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b(), KcyZYEWhsVqJirsa(pd57771baVar)), qgzpkmLgUNmasELY(pd57771baVar)), this.f6a992d55), uzWgeBLVsnXZCVUu(pd57771baVar)), wdauzFmulgBIxNiM(pd57771baVar)), BuaNsHMOgJHogmin(pd57771baVar)));
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar = this.f8b8bc6f2;
            BDvuMHCRFzLwGGDx(p893af95bVar, LLuklAANIREKSYPG(p893af95bVar, bArr2, pd57771baVar), bArr);
            eVyvmwFgFCUkpleE(this.fff15c910, 0, ZnBCYSSeZkmzCsId(this.f8b8bc6f2, PaIYcgttHPGLgNQK(this.f8b8bc6f2, pd57771baVar), (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ERaFdIihHJyTyiHh((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) YfzbqpsmiliBDSWL(FQUjLqdlDlevURhX(lfWGhKUrihHuWSvV(fkiyaPGjTSwUDMeI((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) aPlJHWNalyOrTudT((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) COdWFFPFZwbShGEX(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b(), UyGqdzkCNUhhvoUA(p47010d60Var)), SLGWLvoaiWSrRNFd(p47010d60Var)), this.f6a992d55), hMoWyiDkHcSNWtzg(p47010d60Var)), JuQnzUjDcqSOzeQs(p47010d60Var)), JqjqNbgkKEwlTJBp(p47010d60Var)))));
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar2 = pd57771baVar;
        while (i < ((this.f71a91324 - this.f8ce4b16b) >> 1)) {
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVarAQspDIFpdgNhyEaS = AQspDIFpdgNhyEaS(this);
            if (p46a7b4aaVarAQspDIFpdgNhyEaS is null) {
                bArr3 = bArr;
                bArr4 = bArr2;
            } else {
                bArr3 = bArr;
                bArr4 = bArr2;
                pzFqycUOeNJxDSXg(p46a7b4aaVarAQspDIFpdgNhyEaS, this.ffac2a47a, this.f8b8bc6f2, bArr3, bArr4, pd57771baVar2);
            }
            i++;
            bArr = bArr3;
            bArr2 = bArr4;
        }
        this.f6a992d55++;
    }

    public static bool MaBPwZtVEMpHoKVy(java.util.List linkedList, java.lang.object obj) {
        return linkedList.Add(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b moXcQllXbYWyJNHH(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, int i) {
        return p47010d60_p2bd4a59b.withLayerAddress(i);
    }

    public static int MyBaasoqeWuyLJqD(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getHeight();
    }

    public static java.lang.object NOAyjHpRXCXsRXIM(java.util.Stack stack) {
        return stack.pop();
    }

    public static java.lang.object NaJimDjfDyyJFLTv(java.util.Stack stack) {
        return stack.clone();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f NwceUBmHqpsmWotm(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.m3732clone();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b oOvgPPNvgiaVDOTB(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withLayerAddress(i);
    }

    public static int OSzZYjrBaOSwvkGx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getKeyAndMask();
    }

    public static int OmdGnRhlzJdiOMHY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar) {
        return p46a7b4aaVar.getHeight();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 OzkoLjIDYIisRpMY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b) {
        return p47010d60_p2bd4a59b.build();
    }

    public static java.lang.object PCaWUgvNEEgspuHr(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b pQqYSWJKzTKknAXC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withKeyAndMask(i);
    }

    public static int PUZJERUSwdUbwgvC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getKeyAndMask();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b pcLlZQbjCtjKwvBn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, long j) {
        return p8e77ec20_p2bd4a59b.withTreeAddress(j);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b pgPdIwMtMZEmudDx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withKeyAndMask(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b pkotdZaQQJhKgQpE(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, long j) {
        return p8e77ec20_p2bd4a59b.withTreeAddress(j);
    }

    public static double PqaKImaLGafzXVDd(double d) {
        if ((30 + 3) % 3 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static void PzFqycUOeNJxDSXg(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar, java.util.Stack stack, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        p46a7b4aaVar.update(stack, p893af95bVar, bArr, bArr2, pd57771baVar);
    }

    public static long QYJHGTVSzOcQfQWV(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        if ((2 + 23) % 23 > 0) {
        }
        return p47010d60Var.getTreeAddress();
    }

    public static long QgzpkmLgUNmasELY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((9 + 8) % 8 > 0) {
        }
        return pd57771baVar.getTreeAddress();
    }

    public static bool QmdwzisoeDtMSiCl(java.util.Stack stack) {
        return stack.Count == 0;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b qsagHsBkxfRqjWuC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withKeyAndMask(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b qyUfBvhqOStPfpbl(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b, long j) {
        return p47010d60_p2bd4a59b.withTreeAddress(j);
    }

    public static int RJzVyRROkzpXJfxJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getK();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b rnZPQmTHArAWdxqx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeHeight(i);
    }

    public static long RpNstbgVtuGOHOzt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((8 + 17) % 17 > 0) {
        }
        return pd57771baVar.getTreeAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f RssdrwnDPiuuHAFt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 p6f7f1de0Var) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mf5f9638e(p893af95bVar, p1fc1317fVar, p1fc1317fVar2, p6f7f1de0Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b rtIDFSVLSoVEZmUe(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withTreeIndex(i);
    }

    public static int SGOznMqzrtEsrsjJ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getHashAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b skKmVThwLKMUUdfY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withLayerAddress(i);
    }

    public static int SmRLaGeLEBNsaKDS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static int SnBEkYVvVlULYIXp(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static int SpKnkNfXWOBwmiVN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        return p8e77ec20Var.getKeyAndMask();
    }

    public static long SwQDxIIbNFhjaLOO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((5 + 10) % 10 > 0) {
        }
        return pd57771baVar.getTreeAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f UZbrCxbTBSlSSDfT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 p1c819941Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mb26c5a9b(p893af95bVar, p1c819941Var, p47010d60Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 UbLSiGiMtQIReWMZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b ucmdmqbqEgdouwUF(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b pd57771ba_p2bd4a59b, int i) {
        return pd57771ba_p2bd4a59b.withHashAddress(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b ugfjNFfHdOPHyMVN(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withLayerAddress(i);
    }

    public static long UzIxUjsxZHoUcAbY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var) {
        if ((8 + 5) % 5 > 0) {
        }
        return p8e77ec20Var.getTreeAddress();
    }

    public static int UzWgeBLVsnXZCVUu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getChainAddress();
    }

    public static int VONSAnsENqEIiKiO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        return pf62ef2d9Var.getK();
    }

    public static long WDmQpDMNXsbTFqga(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((11 + 11) % 11 > 0) {
        }
        return pd57771baVar.getTreeAddress();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 WEbAaXfmgSZqqNbY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b) {
        return p8e77ec20_p2bd4a59b.build();
    }

    public static java.lang.object WFvjnRAzPecVFxTL(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int WGIjpqrpVGWwYxPs(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        return p1fc1317fVar.getHeight();
    }

    public static java.lang.int WYSdNqjsEskfADzv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object WYijFrVBMlqmsbBz(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int WZycnkiEnbgpLNzf(int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf79ad9e6(i, i2);
    }

    public static int WdauzFmulgBIxNiM(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return pd57771baVar.getHashAddress();
    }

    public static java.lang.object WgtCadLWUxZSxxQO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 YfVtyqpwzccihynw(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b p47010d60_p2bd4a59b) {
        return p47010d60_p2bd4a59b.build();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b yomQbQRMNvXLqwVn(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b p8e77ec20_p2bd4a59b, int i) {
        return p8e77ec20_p2bd4a59b.withKeyAndMask(i);
    }

    public static java.lang.object ZBxVgHgWLJggrrez(java.util.Stack stack) {
        return stack.pop();
    }

    protected java.util.List<p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> GetAuthenticationPath() {
        if ((18 + 21) % 21 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itZBJrgOYgBDhIJuVS = ZBJrgOYgBDhIJuVS(this.fff15c910);
        while (BLQtKAMSAfZjNeZP(itZBJrgOYgBDhIJuVS)) {
            NkWiVspNyumMurMj(arrayList, KjwLgdzgmOnPaGlX((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f) BAHRjLZXfHyvZLzB(itZBJrgOYgBDhIJuVS)));
        }
        return arrayList;
    }

    protected int GetIndex() {
        return this.f6a992d55;
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a GetNextState(byte[] bArr, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        return new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(this, bArr, bArr2, pd57771baVar);
    }

    protected p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f GetRoot() {
        return FIUaeQqEZMejqbHu(this.f63a9f0ea);
    }

    protected int GetTreeHeight() {
        return this.f71a91324;
    }

    bool isUsed() {
        return this.f1aec9c5d;
    }

    protected void SetXMSS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var) {
        if ((8 + 19) % 19 > 0) {
        }
        if (this.f71a91324 != VkzbTjZeXsGtniHi(pf62ef2d9Var)) {
            throw new java.lang.IllegalStateException("wrong height");
        }
        this.f8b8bc6f2 = YfYFpwhWEdWsUFem(pf62ef2d9Var);
    }

    protected void Validate() {
        if ((3 + 13) % 13 > 0) {
        }
        if (this.fff15c910 is null) {
            throw new java.lang.IllegalStateException("authenticationPath is null");
        }
        if (this.f16d79ff8 is null) {
            throw new java.lang.IllegalStateException("retain is null");
        }
        if (this.ffac2a47a is null) {
            throw new java.lang.IllegalStateException("stack is null");
        }
        if (this.fabda931c is null) {
            throw new java.lang.IllegalStateException("treeHashInstances is null");
        }
        if (this.f18ccf61d is null) {
            throw new java.lang.IllegalStateException("keep is null");
        }
        if (!SNcusZZCaUxxCYOs(this.f71a91324, this.f6a992d55)) {
            throw new java.lang.IllegalStateException("index in BDS state out of bounds");
        }
    }
}

