namespace WillowMaze.Wasm.Decompiled;


public class p09a7e7ee : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private static readonly java.math.Bigint f0b12863f = null;
    private static readonly java.math.Bigint f15f05cbf = null;
    private static readonly java.math.Bigint f3707cafd = null;
    private static readonly java.math.Bigint f529e9e0b;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f015ce0f9;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f29e41022;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd f2aae9103;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd f593616de;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f65b0e288;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f939bd766;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd fdf96cd37;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fe383234c;

    static {
        if ((5 + 18) % 18 > 0) {
        }
        f529e9e0b = BfUAVxnTVWZLBbFh(0L);
    }

    private p09a7e7ee(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((7 + 25) % 25 > 0) {
        }
        this.f593616de = WUdGdOXPbiPlifxy(MvxEvLhDlNloKEkf(p80f8c729Var, 0));
        int iXYXtGAcALysSONWZ = XYXtGAcALysSONWZ(p80f8c729Var);
        if (iXYXtGAcALysSONWZ == 1) {
            return;
        }
        if (iXYXtGAcALysSONWZ == 2) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarDbwhgEMchacODwDR = DbwhgEMchacODwDR(idoAtJupVXoxFCJY(p80f8c729Var, 1));
            int iCMoYZsojQxCefFDe = cMoYZsojQxCefFDe(p582a4948VarDbwhgEMchacODwDR);
            if (iCMoYZsojQxCefFDe == 0) {
                this.fe383234c = eQBeqEamRRyrMqPm(p582a4948VarDbwhgEMchacODwDR, false);
                return;
            } else {
                if (iCMoYZsojQxCefFDe != 1) {
                    throw new java.lang.IllegalArgumentException(ZRzCFxurNNucBjhS(sVRCcDBaMDTVYQTK(new java.lang.stringBuilder("Bad tag number: "), nEIRjIMDLnQCwutV(p582a4948VarDbwhgEMchacODwDR))));
                }
                this.f65b0e288 = cyevMKrkiQIDTFjw(p582a4948VarDbwhgEMchacODwDR, false);
                return;
            }
        }
        if (iXYXtGAcALysSONWZ != 3) {
            throw new java.lang.IllegalArgumentException(UBaKZILzdqHqhnJj(VXyvLotJzAbgKeWV(new java.lang.stringBuilder("Bad sequence size: "), nvfibwkdXpTWlfyb(p80f8c729Var))));
        }
        p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarMlVjSNtXcVDfoYWT = MlVjSNtXcVDfoYWT(BZUglLHQJnkvoYWM(p80f8c729Var, 1));
        if (HgdSUPBbFFUZOeOU(p582a4948VarMlVjSNtXcVDfoYWT) != 0) {
            throw new java.lang.IllegalArgumentException(dbMIjstwvsgcSqtn(tGoencAaRPeolbOT(new java.lang.stringBuilder("Bad tag number for 'minimum': "), vfkydLEeuhbVGjJP(p582a4948VarMlVjSNtXcVDfoYWT))));
        }
        this.fe383234c = rtUaZucyApQTJTrM(p582a4948VarMlVjSNtXcVDfoYWT, false);
        p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarRCMSeSlOWivrwLru = rCMSeSlOWivrwLru(sRkryXRPCQvLDUIi(p80f8c729Var, 2));
        if (CCzQQPOMeiIfWAlt(p582a4948VarRCMSeSlOWivrwLru) != 1) {
            throw new java.lang.IllegalArgumentException(NhQluwRdjLuCtuyl(SyeUNostdOHKXMId(new java.lang.stringBuilder("Bad tag number for 'maximum': "), mZDeGNUjPDpywdWk(p582a4948VarRCMSeSlOWivrwLru))));
        }
        this.f65b0e288 = lQzWkDNqrezPkMgW(p582a4948VarRCMSeSlOWivrwLru, false);
    }

    public p09a7e7ee(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        this(pf17d2ecdVar, null, null);
    }

    public p09a7e7ee(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        this.f593616de = pf17d2ecdVar;
        if (bigint2 is not null) {
            this.f65b0e288 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint2);
        }
        this.fe383234c = bigint is not null ? new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint) : null;
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 BZUglLHQJnkvoYWM(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.math.Bigint BfUAVxnTVWZLBbFh(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static int CCzQQPOMeiIfWAlt(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 DbwhgEMchacODwDR(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static int HgdSUPBbFFUZOeOU(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static java.math.Bigint LrirzaRsRDIohOkm(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 MlVjSNtXcVDfoYWT(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 MvxEvLhDlNloKEkf(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string NhQluwRdjLuCtuyl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SyeUNostdOHKXMId(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string UBaKZILzdqHqhnJj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VSKniBXHzwVHSCdp(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.stringBuilder VXyvLotJzAbgKeWV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 WBxJilqVYpYesIVd(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd WUdGdOXPbiPlifxy(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(obj);
    }

    public static int XYXtGAcALysSONWZ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.string ZRzCFxurNNucBjhS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZtDtojWSehDHSlKs(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int CMoYZsojQxCefFDe(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d CyevMKrkiQIDTFjw(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.string DbMIjstwvsgcSqtn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d EQBeqEamRRyrMqPm(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 HGKrGLpZAjFgQRiL(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static java.math.Bigint HjoDGcFvaThrAetF(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 IdoAtJupVXoxFCJY(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d LQzWkDNqrezPkMgW(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee M8bab0102(java.lang.object obj) {
        if (obj is not null) {
            return !(obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee) ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee(WBxJilqVYpYesIVd(obj)) : (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee) obj;
        }
        return null;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee(hGKrGLpZAjFgQRiL(p582a4948Var, z));
    }

    public static int MZDeGNUjPDpywdWk(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static int NEIRjIMDLnQCwutV(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static int NvfibwkdXpTWlfyb(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 RCMSeSlOWivrwLru(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d RtUaZucyApQTJTrM(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 SRkryXRPCQvLDUIi(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.stringBuilder SVRCcDBaMDTVYQTK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TGoencAaRPeolbOT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool TJkDSngAxzkLrwiF(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar, int i) {
        return pf391b73dVar.hasValue(i);
    }

    public static int VfkydLEeuhbVGjJP(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void WOdeNCgbrwcWNPBm(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd GetBase() {
        return this.f593616de;
    }

    public java.math.Bigint GetMaximum() {
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.f65b0e288;
        if (pf391b73dVar is not null) {
            return hjoDGcFvaThrAetF(pf391b73dVar);
        }
        return null;
    }

    public java.math.Bigint GetMinimum() {
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.fe383234c;
        return pf391b73dVar is not null ? LrirzaRsRDIohOkm(pf391b73dVar) : f529e9e0b;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((29 + 28) % 28 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(3);
        ZtDtojWSehDHSlKs(pd6ccb7fcVar, this.f593616de);
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = this.fe383234c;
        if (pf391b73dVar is not null && !tJkDSngAxzkLrwiF(pf391b73dVar, 0)) {
            VSKniBXHzwVHSCdp(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fe383234c));
        }
        if (this.f65b0e288 is not null) {
            wOdeNCgbrwcWNPBm(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f65b0e288));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

