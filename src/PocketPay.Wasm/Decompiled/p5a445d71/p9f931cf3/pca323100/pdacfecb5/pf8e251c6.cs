namespace WillowMaze.Wasm.Decompiled;


public class pf8e251c6 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private java.math.Bigint fb1bc248a;
    private java.math.Bigint fc872fd18;

    public pf8e251c6(java.math.Bigint bigint) {
        if (aiVikCXsmlAniQzj(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.f529e9e0b, bigint) > 0) {
            throw new java.lang.IllegalArgumentException("Invalid CRL number : not in (0..MAX)");
        }
        this.fb1bc248a = bigint;
    }

    public static java.math.Bigint CDVqjkXIxuleBzCz(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static java.lang.stringBuilder VrBedvUstHjCBZwJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int AiVikCXsmlAniQzj(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static java.math.Bigint BaAgusNeZwPKQEXt(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6 pf8e251c6Var) {
        return pf8e251c6Var.getCRLNumber();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d DnGGnwZYTSSbZrqy(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6(CDVqjkXIxuleBzCz(dnGGnwZYTSSbZrqy(obj)));
    }

    public static java.lang.string MjxsyiiPblWzOsTA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public java.math.Bigint GetCRLNumber() {
        return this.fb1bc248a;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fb1bc248a);
    }

    public java.lang.string Tostring() {
        if ((28 + 26) % 26 > 0) {
        }
        return mjxsyiiPblWzOsTA(VrBedvUstHjCBZwJ(new java.lang.stringBuilder("CRLNumber: "), baAgusNeZwPKQEXt(this)));
    }
}

