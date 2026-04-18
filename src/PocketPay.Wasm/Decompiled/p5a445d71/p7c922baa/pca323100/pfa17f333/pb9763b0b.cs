namespace WillowMaze.Wasm.Decompiled;


public class pb9763b0b : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f01dfe413;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f f23f6f53d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f290a58f1;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f4fa2f15a;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f54375826;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f596421c3;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f5cc14000;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f f7a1f44f2;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f fa9c56b6b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fb529a124;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fcbd4800b;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fd4e0184d;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f fe2b18e2e;

    private pb9763b0b(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((30 + 19) % 19 > 0) {
        }
        if (KaGNtBwoFMkQCUBG(p80f8c729Var) > 3) {
            throw new java.lang.IllegalArgumentException(VoKmAGeVavnxeZdN(MkwFRPoFbJwMgNtR(new java.lang.stringBuilder("Bad sequence size: "), sBDlxEXdGNEXapCC(p80f8c729Var))));
        }
        java.util.Enumeration enumerationPsYIMLCULrJgDMdz = PsYIMLCULrJgDMdz(p80f8c729Var);
        while (uYiGySEinqSLQFkC(enumerationPsYIMLCULrJgDMdz)) {
            p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var = (p5a445d71.p7c922baa.pca323100.p582a4948) JNKeLFtrCWyTTPOS(enumerationPsYIMLCULrJgDMdz);
            int iZKafhaefkxnIIxZT = zKafhaefkxnIIxZT(p582a4948Var);
            if (iZKafhaefkxnIIxZT == 0) {
                p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p7c922baa.pca323100.p80f8c729) cYXHhevJZTSwDXwV(p582a4948Var);
                java.util.Enumeration enumerationMkkDZZkYWdeYYOgJ = MkkDZZkYWdeYYOgJ(p80f8c729Var2);
                while (zSWPEngHhvBbESUu(enumerationMkkDZZkYWdeYYOgJ)) {
                    THjqzNsYJHSdDCov(gDAIbpdQZwZgKxJg(enumerationMkkDZZkYWdeYYOgJ));
                }
                this.f596421c3 = p80f8c729Var2;
            } else if (iZKafhaefkxnIIxZT == 1) {
                p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var3 = (p5a445d71.p7c922baa.pca323100.p80f8c729) hPSsyUECKauAzrkH(p582a4948Var);
                java.util.Enumeration enumerationDFxoMlbjNkteXPRS = DFxoMlbjNkteXPRS(p80f8c729Var3);
                while (vqdodsaqiTyKHLKr(enumerationDFxoMlbjNkteXPRS)) {
                    gfXZcOGWpSOhixux(eQiLsVVunHDhHpOj(enumerationDFxoMlbjNkteXPRS));
                }
                this.fd4e0184d = p80f8c729Var3;
            } else {
                if (iZKafhaefkxnIIxZT != 2) {
                    throw new java.lang.IllegalArgumentException(gRiBvqGwXMVlYsfJ(bjTlTUQVYcukXGmo(new java.lang.stringBuilder("invalid tag: "), vzXYVdfhjsATJaEX(p582a4948Var))));
                }
                this.f23f6f53d = GhOmzzZuTdkxYAdJ(HLbDCNUtnmXzEfiP(p582a4948Var));
            }
        }
    }

    public pb9763b0b(p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[] pe7f120eaVarArr, p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c[] p4df9607cVarArr, p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f p361b9c0fVar) {
        if (pe7f120eaVarArr is not null) {
            this.f596421c3 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pe7f120eaVarArr);
        }
        if (p4df9607cVarArr is not null) {
            this.fd4e0184d = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p4df9607cVarArr);
        }
        this.f23f6f53d = p361b9c0fVar;
    }

    public static java.util.Enumeration DFxoMlbjNkteXPRS(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea FBmXuLzWceTGPIhr(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f GhOmzzZuTdkxYAdJ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 HLbDCNUtnmXzEfiP(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static void IRLhRueYdgxoiYgT(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object JNKeLFtrCWyTTPOS(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static int KaGNtBwoFMkQCUBG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void MbzhGhfHRTwtNpHt(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration MkkDZZkYWdeYYOgJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static java.lang.stringBuilder MkwFRPoFbJwMgNtR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.util.Enumeration PsYIMLCULrJgDMdz(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void QaMMZoxagBafJxsY(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea THjqzNsYJHSdDCov(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea.m8bab0102(obj);
    }

    public static java.lang.string VoKmAGeVavnxeZdN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YfgyAfZoXccoiOIr(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c AwJYjWYvckaSiara(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c.m8bab0102(obj);
    }

    public static java.lang.stringBuilder BjTlTUQVYcukXGmo(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 CYXHhevJZTSwDXwV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static int DqPoJzAOCxqBQwuD(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.object EQiLsVVunHDhHpOj(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.object GDAIbpdQZwZgKxJg(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.string GRiBvqGwXMVlYsfJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c GfXZcOGWpSOhixux(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 HPSsyUECKauAzrkH(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KrcjrPzBVzTquDrO(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.pb9763b0b M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.pb9763b0b) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.pb9763b0b) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.pb9763b0b(vGriMdNtxWjKPDVH(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NaGBERpMAWBOZuHI(p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f p361b9c0fVar) {
        return p361b9c0fVar.toASN1Primitive();
    }

    public static int NtWVhMWvWzpKUyUU(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int SBDlxEXdGNEXapCC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static bool UYiGySEinqSLQFkC(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VGriMdNtxWjKPDVH(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static bool VqdodsaqiTyKHLKr(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static int VzXYVdfhjsATJaEX(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static int ZKafhaefkxnIIxZT(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static bool ZSWPEngHhvBbESUu(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[] GetCrlVals() {
        if ((32 + 22) % 22 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var = this.f596421c3;
        if (p80f8c729Var is null) {
            return new p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[0];
        }
        int iDqPoJzAOCxqBQwuD = dqPoJzAOCxqBQwuD(p80f8c729Var);
        p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[] pe7f120eaVarArr = new p5a445d71.p7c922baa.pca323100.pdacfecb5.pe7f120ea[iDqPoJzAOCxqBQwuD];
        for (int i = 0; i < iDqPoJzAOCxqBQwuD; i++) {
            pe7f120eaVarArr[i] = FBmXuLzWceTGPIhr(krcjrPzBVzTquDrO(this.f596421c3, i));
        }
        return pe7f120eaVarArr;
    }

    public p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c[] GetOcspVals() {
        if ((15 + 21) % 21 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var = this.fd4e0184d;
        if (p80f8c729Var is null) {
            return new p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c[0];
        }
        int iNtWVhMWvWzpKUyUU = ntWVhMWvWzpKUyUU(p80f8c729Var);
        p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c[] p4df9607cVarArr = new p5a445d71.p7c922baa.pca323100.p785c9c91.p4df9607c[iNtWVhMWvWzpKUyUU];
        for (int i = 0; i < iNtWVhMWvWzpKUyUU; i++) {
            p4df9607cVarArr[i] = awJYjWYvckaSiara(YfgyAfZoXccoiOIr(this.fd4e0184d, i));
        }
        return p4df9607cVarArr;
    }

    public p5a445d71.p7c922baa.pca323100.pfa17f333.p361b9c0f GetOtherRevVals() {
        return this.f23f6f53d;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((15 + 27) % 27 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        if (this.f596421c3 is not null) {
            MbzhGhfHRTwtNpHt(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 0, this.f596421c3));
        }
        if (this.fd4e0184d is not null) {
            QaMMZoxagBafJxsY(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 1, this.fd4e0184d));
        }
        if (this.f23f6f53d is not null) {
            IRLhRueYdgxoiYgT(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(true, 2, naGBERpMAWBOZuHI(this.f23f6f53d)));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

