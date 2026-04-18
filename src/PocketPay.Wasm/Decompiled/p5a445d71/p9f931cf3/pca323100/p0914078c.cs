namespace WillowMaze.Wasm.Decompiled;


public class p0914078c : p5a445d71.p9f931cf3.pca323100.pbd2da871 {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f1ac54d52;
    private p5a445d71.p9f931cf3.pca323100.p2a78b0bd f2ceb457a;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5115be0c;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f6f5bd0ba;
    private p5a445d71.p9f931cf3.pca323100.p2a78b0bd f6f84124b;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f7731ed76;
    private p5a445d71.p9f931cf3.pca323100.p2a78b0bd feb8df152;

    p0914078c(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p70a46e21 FrhjCRPigWrRcHDW(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return m2e88eca8(p8557f615Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 RtxrqbtCKBWzvruZ(p5a445d71.p9f931cf3.pca323100.p0914078c p0914078cVar) {
        return p0914078cVar.getLoadedobject();
    }

    public static int SZFwbgLBSHfnCMdc(p5a445d71.p9f931cf3.pca323100.p2a78b0bd p2a78b0bdVar) {
        return p2a78b0bdVar.getPadBits();
    }

    public static java.lang.stringBuilder VEKWrNmeNdfgeGnc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p9f931cf3.pca323100.p70a46e21 M2e88eca8(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) throws java.io.IOException {
        if ((26 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p2a78b0bd p2a78b0bdVar = new p5a445d71.p9f931cf3.pca323100.p2a78b0bd(p8557f615Var, false);
        return new p5a445d71.p9f931cf3.pca323100.p70a46e21(qPxwVjEtAGbcjlkO(p2a78b0bdVar), oJmIiOcqeaTdLzvM(p2a78b0bdVar));
    }

    public static java.lang.string ODRBTcTvfrBIQFFS(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static int OJmIiOcqeaTdLzvM(p5a445d71.p9f931cf3.pca323100.p2a78b0bd p2a78b0bdVar) {
        return p2a78b0bdVar.getPadBits();
    }

    public static byte[] QPxwVjEtAGbcjlkO(java.io.Stream inputStream) {
        return p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(inputStream);
    }

    public static java.lang.string WfnSjshALrgsjQST(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.io.Stream GetBitStream() throws java.io.IOException {
        if ((22 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p2a78b0bd p2a78b0bdVar = new p5a445d71.p9f931cf3.pca323100.p2a78b0bd(this.f5431b8d4, false);
        this.f2ceb457a = p2a78b0bdVar;
        return p2a78b0bdVar;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return FrhjCRPigWrRcHDW(this.f5431b8d4);
    }

    public override java.io.Stream GetOctetStream() throws java.io.IOException {
        if ((31 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p2a78b0bd p2a78b0bdVar = new p5a445d71.p9f931cf3.pca323100.p2a78b0bd(this.f5431b8d4, true);
        this.f2ceb457a = p2a78b0bdVar;
        return p2a78b0bdVar;
    }

    public override int GetPadBits() {
        return SZFwbgLBSHfnCMdc(this.f2ceb457a);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 2) % 2 > 0) {
        }
        try {
            return RtxrqbtCKBWzvruZ(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(wfnSjshALrgsjQST(VEKWrNmeNdfgeGnc(new java.lang.stringBuilder("IOException converting stream to byte array: "), oDRBTcTvfrBIQFFS(e))), e);
        }
    }
}

