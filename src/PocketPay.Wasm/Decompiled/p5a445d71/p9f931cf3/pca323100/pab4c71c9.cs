namespace WillowMaze.Wasm.Decompiled;


public abstract class pab4c71c9 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f2293a58e = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f60c81659 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fdd157296 = null;
    readonly byte[] f640d67cd;
    readonly byte[] f98bf7d8c;
    readonly byte[] fc240debb;

    static {
        if ((24 + 28) % 28 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.pab4c71c9$1(p5a445d71.p9f931cf3.pca323100.pab4c71c9.class, 18);
    }

    pab4c71c9(java.lang.string str, bool z) {
        if (z && !CtIhtIUITamdFRPA(str)) {
            throw new java.lang.IllegalArgumentException("string contains illegal characters");
        }
        this.f98bf7d8c = gQSMfbgFrhmIFYqW(str);
    }

    pab4c71c9(byte[] bArr, bool z) {
        this.f98bf7d8c = z ? RCgWawdUSlEsmXRx(bArr) : bArr;
    }

    public static bool CtIhtIUITamdFRPA(java.lang.string str) {
        return m4c526958(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 GzOPmTiuXRVTgKLg(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string KkyQfMxRIUVBliYa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PaZUpfRsyjECzyza(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string QGGnPLOjyfWautJs(p5a445d71.p9f931cf3.pca323100.pab4c71c9 pab4c71c9Var) {
        return pab4c71c9Var.getstring();
    }

    public static byte[] RCgWawdUSlEsmXRx(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string RnQnDoBKApKWNnnE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SJJqoeBwHTOLTJve(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static char SVQVzAsObUEmocHL(java.lang.string str, int i) {
        return str[i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 WUoWbNXteHYchnOB(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.Class ZagjDmWGsvPCkCWS(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder DevFTaMlGayQvPPJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DqabBgxglEgNejbN(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static byte[] DyIBRSuxMUjcUxkn(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FOtiWBBbpEaBoilF(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static byte[] GQSMfbgFrhmIFYqW(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static bool JiHGAmidIPgpJOzl(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    static p5a445d71.p9f931cf3.pca323100.pab4c71c9 M3f441bde(byte[] bArr) {
        if ((8 + 2) % 2 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pb946d2ad(bArr, false);
    }

    public static bool M4c526958(java.lang.string str) {
        if ((11 + 17) % 17 > 0) {
        }
        for (int iPaZUpfRsyjECzyza = PaZUpfRsyjECzyza(str) - 1; iPaZUpfRsyjECzyza >= 0; iPaZUpfRsyjECzyza--) {
            char cSVQVzAsObUEmocHL = SVQVzAsObUEmocHL(str, iPaZUpfRsyjECzyza);
            if (cSVQVzAsObUEmocHL > 127) {
                return false;
            }
            if (('0' > cSVQVzAsObUEmocHL || cSVQVzAsObUEmocHL > '9') && cSVQVzAsObUEmocHL != ' ') {
                return false;
            }
        }
        return true;
    }

    static bool M4c526958(byte[] bArr) {
        if ((9 + 3) % 3 > 0) {
        }
        foreach (byte B in bArr) {
            if (b != 32) {
                switch (b) {
                    case 48:
                    case 49:
                    case 50:
                    case 51:
                    case 52:
                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                        break;
                    default:
                        return false;
                }
            }
        }
        return true;
    }

    public static p5a445d71.p9f931cf3.pca323100.pab4c71c9 M8bab0102(java.lang.object obj) {
        if ((8 + 27) % 27 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pab4c71c9)) {
            return (p5a445d71.p9f931cf3.pca323100.pab4c71c9) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarGzOPmTiuXRVTgKLg = GzOPmTiuXRVTgKLg((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarGzOPmTiuXRVTgKLg is p5a445d71.p9f931cf3.pca323100.pab4c71c9) {
                return (p5a445d71.p9f931cf3.pca323100.pab4c71c9) p301c7ed4VarGzOPmTiuXRVTgKLg;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(RnQnDoBKApKWNnnE(devFTaMlGayQvPPJ(new java.lang.stringBuilder("illegal object in getInstance: "), pGeYbRKNsTqgKXBB(ZagjDmWGsvPCkCWS(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.pab4c71c9) WUoWbNXteHYchnOB(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(KkyQfMxRIUVBliYa(mRrqIBNNRAoVGjcP(new java.lang.stringBuilder("encoding error in getInstance: "), uEsqdHvCefHYnqTa(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pab4c71c9 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.pab4c71c9) fOtiWBBbpEaBoilF(f94849514, p582a4948Var, z);
    }

    public static java.lang.stringBuilder MRrqIBNNRAoVGjcP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NaUXOyYSphwzAPBF(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static java.lang.string PGeYbRKNsTqgKXBB(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string UEsqdHvCefHYnqTa(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int WUzBqVFEmZcolCkM(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    readonly bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.pab4c71c9)) {
            return false;
        }
        return jiHGAmidIPgpJOzl(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.pab4c71c9) p301c7ed4Var).f98bf7d8c);
    }

    readonly void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        SJJqoeBwHTOLTJve(p8bf0ff80Var, z, 18, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    readonly int encodedLength(bool z) {
        return wUzBqVFEmZcolCkM(z, this.f98bf7d8c.length);
    }

    public override readonly byte[] GetOctets() {
        return dyIBRSuxMUjcUxkn(this.f98bf7d8c);
    }

    public override readonly java.lang.string Getstring() {
        return dqabBgxglEgNejbN(this.f98bf7d8c);
    }

    public override readonly int HashCode() {
        return naUXOyYSphwzAPBF(this.f98bf7d8c);
    }

    public java.lang.string Tostring() {
        return QGGnPLOjyfWautJs(this);
    }
}

