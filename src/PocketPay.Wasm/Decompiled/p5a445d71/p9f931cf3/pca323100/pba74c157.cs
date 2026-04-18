namespace WillowMaze.Wasm.Decompiled;


public class pba74c157 : p5a445d71.p9f931cf3.pca323100.p9fb62cfc {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f1b78941a;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f30426a38;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 ffcca80e6;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 ffe21ca63;

    pba74c157(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.pa1bc6907 BSInvgPKkoRZyQSR(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return m2e88eca8(p8557f615Var);
    }

    public static java.lang.string OgsAkXImvMLizRbj(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.string PXccLSoyvIXvBUpE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 GpjAURYWNMRLnnaz(p5a445d71.p9f931cf3.pca323100.pba74c157 pba74c157Var) {
        return pba74c157Var.getLoadedobject();
    }

    static p5a445d71.p9f931cf3.pca323100.pa1bc6907 M2e88eca8(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) throws java.io.IOException {
        if ((21 + 9) % 9 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pa1bc6907(qirZduytLejpPuuz(new p5a445d71.p9f931cf3.pca323100.p445c7d72(p8557f615Var)));
    }

    public static byte[] QirZduytLejpPuuz(java.io.Stream inputStream) {
        return p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(inputStream);
    }

    public static java.lang.stringBuilder ZktJLvOUasQrlLmA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return BSInvgPKkoRZyQSR(this.f5431b8d4);
    }

    public override java.io.Stream GetOctetStream() {
        return new p5a445d71.p9f931cf3.pca323100.p445c7d72(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((11 + 6) % 6 > 0) {
        }
        try {
            return gpjAURYWNMRLnnaz(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(PXccLSoyvIXvBUpE(zktJLvOUasQrlLmA(new java.lang.stringBuilder("IOException converting stream to byte array: "), OgsAkXImvMLizRbj(e))), e);
        }
    }
}

