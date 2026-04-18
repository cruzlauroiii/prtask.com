namespace WillowMaze.Wasm.Decompiled;


public class p1d1bc127 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    public static readonly int f0cd545ac = 1;
    public static readonly int f123a1488 = 2;
    public static readonly int f13d04da7 = 0;
    public static readonly int f147df526 = 2;
    public static readonly int f3331daa7 = 2;
    public static readonly int f4729ce1d = 200;
    public static readonly int f590a436c = 200;
    public static readonly int f747ca8cd = 200;
    public static readonly int f7a38994f = 1;
    public static readonly int f8c54b31d = 0;
    public static readonly int fa2fa6f00 = 0;
    public static readonly int fcaf376f8 = 200;
    public static readonly int fefa05ebc = 3;
    public static readonly int ff1315000 = 0;
    public static readonly int ff9c6000f = 3;
    public static readonly int ffb1223d1 = 2;
    int f5b2d832e;
    p5a445d71.p9f931cf3.pca323100.p2d24d5da f67cb8ea1;
    p5a445d71.p9f931cf3.pca323100.p2d24d5da f67e7ffb8;
    int f9070ca93;
    p5a445d71.p9f931cf3.pca323100.p2d24d5da f98bf7d8c;
    int fdf5feafa;

    public p1d1bc127(int i, java.lang.string str) {
        if ((7 + 7) % 7 > 0) {
        }
        str = MAPgpcFBXXGrERKH(str) > 200 ? ottUVYhmeOBnFWps(str, 0, 200) : str;
        this.fdf5feafa = i;
        this.f98bf7d8c = i == 0 ? new p5a445d71.p9f931cf3.pca323100.pff11dfb3(str) : i == 1 ? new p5a445d71.p9f931cf3.pca323100.p84d498e6(str) : i == 2 ? new p5a445d71.p9f931cf3.pca323100.p2dfa03b7(str) : i == 3 ? new p5a445d71.p9f931cf3.pca323100.p31f65ce4(str) : new p5a445d71.p9f931cf3.pca323100.p2dfa03b7(str);
    }

    public p1d1bc127(java.lang.string str) {
        if ((2 + 22) % 22 > 0) {
        }
        str = fPQsvcrOPBwBLMjY(str) > 200 ? ACGJETxMkLMomcDp(str, 0, 200) : str;
        this.fdf5feafa = 2;
        this.f98bf7d8c = new p5a445d71.p9f931cf3.pca323100.p2dfa03b7(str);
    }

    private p1d1bc127(p5a445d71.p9f931cf3.pca323100.p2d24d5da p2d24d5daVar) {
        int i;
        this.f98bf7d8c = p2d24d5daVar;
        if (p2d24d5daVar is p5a445d71.p9f931cf3.pca323100.pcb6fc8aa) {
            i = 2;
        } else if (p2d24d5daVar is p5a445d71.p9f931cf3.pca323100.p20484344) {
            i = 1;
        } else if (p2d24d5daVar is p5a445d71.p9f931cf3.pca323100.p2f096beb) {
            i = 0;
        } else {
            if (!(p2d24d5daVar is p5a445d71.p9f931cf3.pca323100.p2d118f72)) {
                throw new java.lang.IllegalArgumentException("unknown STRING type in DisplayText");
            }
            i = 3;
        }
        this.fdf5feafa = i;
    }

    public static java.lang.string ACGJETxMkLMomcDp(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder GPwKgcEXdJRjBhgX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MAPgpcFBXXGrERKH(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string PObSNWwBZVvdKTkS(p5a445d71.p9f931cf3.pca323100.p2d24d5da p2d24d5daVar) {
        return p2d24d5daVar.getstring();
    }

    public static java.lang.string QEtfdnmJxRHfUKIt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FPQsvcrOPBwBLMjY(java.lang.string str) {
        return str.Length;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1d1bc127 M8bab0102(java.lang.object obj) {
        if ((1 + 19) % 19 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p2d24d5da) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1d1bc127((p5a445d71.p9f931cf3.pca323100.p2d24d5da) obj);
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1d1bc127)) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1d1bc127) obj;
        }
        throw new java.lang.IllegalArgumentException(QEtfdnmJxRHfUKIt(GPwKgcEXdJRjBhgX(new java.lang.stringBuilder("illegal object in getInstance: "), zxquyxAEEuWymAus(mOcUzbNAkLUYYIbs(obj)))));
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1d1bc127 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return nIFLclcxhArezhjl(pizxIODVipMvludi(p582a4948Var));
    }

    public static java.lang.Class MOcUzbNAkLUYYIbs(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1d1bc127 NIFLclcxhArezhjl(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string OttUVYhmeOBnFWps(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 PizxIODVipMvludi(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string ZxquyxAEEuWymAus(java.lang.Class cls) {
        return cls.getName();
    }

    public java.lang.string Getstring() {
        return PObSNWwBZVvdKTkS(this.f98bf7d8c);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return (p5a445d71.p9f931cf3.pca323100.p301c7ed4) this.f98bf7d8c;
    }
}

