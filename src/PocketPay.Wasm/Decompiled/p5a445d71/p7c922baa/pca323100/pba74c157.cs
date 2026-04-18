namespace WillowMaze.Wasm.Decompiled;


public class pba74c157 : p5a445d71.p7c922baa.pca323100.p9fb62cfc {
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p7c922baa.pca323100.p8557f615 fecb5c13b;

    pba74c157(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static java.io.Stream WGjxlSkfatUVfBsl(p5a445d71.p7c922baa.pca323100.pba74c157 pba74c157Var) {
        return pba74c157Var.getOctetStream();
    }

    public static java.lang.string EpRZuFrgZYTOmsIW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LAHRsoplAUbOtvMW(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NiYQkFwwjrlMiUZK(p5a445d71.p7c922baa.pca323100.pba74c157 pba74c157Var) {
        return pba74c157Var.getLoadedobject();
    }

    public static byte[] SCLOSErHdGcqcxBH(java.io.Stream inputStream) {
        return p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(inputStream);
    }

    public static java.lang.stringBuilder XaaqyuRTjTqCmCIo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return new p5a445d71.p7c922baa.pca323100.pa1bc6907(sCLOSErHdGcqcxBH(WGjxlSkfatUVfBsl(this)));
    }

    public override java.io.Stream GetOctetStream() {
        return new p5a445d71.p7c922baa.pca323100.p445c7d72(this.f5431b8d4);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((16 + 26) % 26 > 0) {
        }
        try {
            return niYQkFwwjrlMiUZK(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(epRZuFrgZYTOmsIW(xaaqyuRTjTqCmCIo(new java.lang.stringBuilder("IOException converting stream to byte array: "), lAHRsoplAUbOtvMW(e))), e);
        }
    }
}

