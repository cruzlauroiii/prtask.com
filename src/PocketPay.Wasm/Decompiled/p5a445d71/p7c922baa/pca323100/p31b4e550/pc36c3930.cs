namespace WillowMaze.Wasm.Decompiled;


public class pc36c3930 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 f392e7866;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef f5c81a27e;
    private p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 f6ad87afe;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef f79874df9;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef fb9c0b4aa;
    private p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 fbd5eeb01;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef fdc15156b;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef fe0d30cef;
    private p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 fe48aa67c;

    public pc36c3930(p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef p86a3f8efVar) {
        if (p86a3f8efVar is null) {
            throw new java.lang.IllegalArgumentException("'certificate' cannot be null");
        }
        this.fe0d30cef = p86a3f8efVar;
    }

    private pc36c3930(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((31 + 13) % 13 > 0) {
        }
        if (NMyTZQKgSSZXnBAV(p582a4948Var) == 0) {
            this.fe0d30cef = TPiQFsiehFUgfJDA(XKqGxnAKUWoYAjyv(p582a4948Var));
        } else {
            if (UepUZnPejkDnbbeY(p582a4948Var) != 1) {
                throw new java.lang.IllegalArgumentException(YXYTiRdvONPrFYJH(qQCikmvZDolhLfYi(new java.lang.stringBuilder("unknown tag: "), iTuiWAuFgfRPcXqU(p582a4948Var))));
            }
            this.f392e7866 = kdrMwjPJOayvTPbw(INcgUhqkeaBfYaqD(p582a4948Var));
        }
    }

    public pc36c3930(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 pab655e66Var) {
        if (pab655e66Var is null) {
            throw new java.lang.IllegalArgumentException("'encryptedCert' cannot be null");
        }
        this.f392e7866 = pab655e66Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 INcgUhqkeaBfYaqD(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static int NMyTZQKgSSZXnBAV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef TPiQFsiehFUgfJDA(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef.m8bab0102(obj);
    }

    public static int UepUZnPejkDnbbeY(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 XKqGxnAKUWoYAjyv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string YXYTiRdvONPrFYJH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ITuiWAuFgfRPcXqU(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 KdrMwjPJOayvTPbw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pc36c3930 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.pc36c3930) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.pc36c3930) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p582a4948) {
            return new p5a445d71.p7c922baa.pca323100.p31b4e550.pc36c3930((p5a445d71.p7c922baa.pca323100.p582a4948) obj);
        }
        return null;
    }

    public static java.lang.stringBuilder QQCikmvZDolhLfYi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.p86a3f8ef GetCertificate() {
        return this.fe0d30cef;
    }

    public p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 GetEncryptedCert() {
        return this.f392e7866;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((14 + 23) % 23 > 0) {
        }
        return this.fe0d30cef is null ? new p5a445d71.p7c922baa.pca323100.p87af127c(true, 1, this.f392e7866) : new p5a445d71.p7c922baa.pca323100.p87af127c(true, 0, this.fe0d30cef);
    }
}

