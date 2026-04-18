namespace WillowMaze.Wasm.Decompiled;


public class p80a21a73 : p5a445d71.p7c922baa.pca323100.p31e0e4c9.p17dabace {
    private static int f070feb7b = 2;
    private static int f3d999f30 = 1;
    private static int f50df227c = 1;
    private static int f65be2a78 = 2;
    private static int f88afd563 = 1;
    private static int fc0c2cd59 = 2;
    private static int fc91e271e = 2;
    private java.math.Bigint f06278455;
    private java.math.Bigint f06efba23;
    private int f1513b094;
    private java.math.Bigint f686d149a;
    private java.math.Bigint f7dc2419d;
    private java.math.Bigint f92080655;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f9366282e;
    private java.math.Bigint f9405f226;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f98d7f87c;
    private int f9f7d0ee8;
    private java.math.Bigint fa447bcbe;
    private java.math.Bigint fac0201fb;
    private java.math.Bigint ff06a3274;
    private java.math.Bigint ffacd4bc8;

    public p80a21a73(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        this.f9f7d0ee8 = 0;
        this.f9366282e = p364bf33aVar;
        this.f06efba23 = bigint;
        this.ffacd4bc8 = bigint2;
    }

    p80a21a73(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((30 + 18) % 18 > 0) {
        }
        this.f9f7d0ee8 = 0;
        java.util.Enumeration enumerationCBZwTJPkMwiANawO = cBZwTJPkMwiANawO(p80f8c729Var);
        this.f9366282e = mkHDTbBDBaAGJBjw(HeOHAxLNSsXzKTDL(enumerationCBZwTJPkMwiANawO));
        while (ZKternUaYqWchOtS(enumerationCBZwTJPkMwiANawO)) {
            p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVarGiOOvqekTBWgTciD = giOOvqekTBWgTciD(enybmQscoIPVvKRi(enumerationCBZwTJPkMwiANawO));
            int iRFeTwfRbqDIFLCNE = RFeTwfRbqDIFLCNE(p83147e7fVarGiOOvqekTBWgTciD);
            if (iRFeTwfRbqDIFLCNE == 1) {
                lTpqOhnPaebWkzkZ(this, p83147e7fVarGiOOvqekTBWgTciD);
            } else {
                if (iRFeTwfRbqDIFLCNE != 2) {
                    throw new java.lang.IllegalArgumentException(DfHsjeCXTlalxHxn(mMjxCYEjjbFaEYgE(JWtCYzOGaxtUJgTm(new java.lang.stringBuilder("Unknown DERTaggedobject :"), EVTHAxjwNOemJMdb(p83147e7fVarGiOOvqekTBWgTciD)), "-> not an Iso7816RSAPublicKeyStructure")));
                }
                EnZcgNutSMRvqDOU(this, p83147e7fVarGiOOvqekTBWgTciD);
            }
        }
        if (this.f9f7d0ee8 != 3) {
            throw new java.lang.IllegalArgumentException("missing argument -> not an Iso7816RSAPublicKeyStructure");
        }
    }

    public static void CHTGXyfiRUWWngkI(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.string DfHsjeCXTlalxHxn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int EVTHAxjwNOemJMdb(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        return p83147e7fVar.getTagNo();
    }

    public static void EirWLZONGuGZSCmP(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void EnZcgNutSMRvqDOU(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p80a21a73 p80a21a73Var, p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        p80a21a73Var.md03a58ba(p83147e7fVar);
    }

    public static java.lang.object HeOHAxLNSsXzKTDL(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.stringBuilder JWtCYzOGaxtUJgTm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int RFeTwfRbqDIFLCNE(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        return p83147e7fVar.getTagNo();
    }

    public static java.math.Bigint TXclLOVwdwnWpyzO(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        return p83147e7fVar.getValue();
    }

    public static bool ZKternUaYqWchOtS(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.util.Enumeration CBZwTJPkMwiANawO(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static java.lang.object EnybmQscoIPVvKRi(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f GiOOvqekTBWgTciD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f.m8bab0102(obj);
    }

    public static void LTpqOhnPaebWkzkZ(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p80a21a73 p80a21a73Var, p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        p80a21a73Var.ma4fdf2e1(p83147e7fVar);
    }

    public static java.lang.stringBuilder MMjxCYEjjbFaEYgE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private void Ma4fdf2e1(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        if ((11 + 16) % 16 > 0) {
        }
        int i = this.f9f7d0ee8;
        int i2 = f50df227c;
        if ((i & i2) != 0) {
            throw new java.lang.IllegalArgumentException("Modulus already set");
        }
        this.f9f7d0ee8 = i | i2;
        this.f06efba23 = TXclLOVwdwnWpyzO(p83147e7fVar);
    }

    private void Md03a58ba(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        if ((11 + 7) % 7 > 0) {
        }
        int i = this.f9f7d0ee8;
        int i2 = fc91e271e;
        if ((i & i2) != 0) {
            throw new java.lang.IllegalArgumentException("Exponent already set");
        }
        this.f9f7d0ee8 = i | i2;
        this.ffacd4bc8 = tsSOFeAkjeWSotaj(p83147e7fVar);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a MkHDTbBDBaAGJBjw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static java.math.Bigint OvFIeoVMXUfnMdQm(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p80a21a73 p80a21a73Var) {
        return p80a21a73Var.getPublicExponent();
    }

    public static java.math.Bigint TsSOFeAkjeWSotaj(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        return p83147e7fVar.getValue();
    }

    public static java.math.Bigint WgrvavKdepIlFQSp(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p80a21a73 p80a21a73Var) {
        return p80a21a73Var.getModulus();
    }

    public static void XOiGWidNckTyefVG(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public java.math.Bigint GetModulus() {
        return this.f06efba23;
    }

    public java.math.Bigint GetPublicExponent() {
        return this.ffacd4bc8;
    }

    public override p5a445d71.p7c922baa.pca323100.p364bf33a GetUsage() {
        return this.f9366282e;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((14 + 1) % 1 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        CHTGXyfiRUWWngkI(pd6ccb7fcVar, this.f9366282e);
        xOiGWidNckTyefVG(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f(1, wgrvavKdepIlFQSp(this)));
        EirWLZONGuGZSCmP(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f(2, ovFIeoVMXUfnMdQm(this)));
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

