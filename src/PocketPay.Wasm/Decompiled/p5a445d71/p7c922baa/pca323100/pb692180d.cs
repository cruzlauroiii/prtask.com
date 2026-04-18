namespace WillowMaze.Wasm.Decompiled;


public class pb692180d : p5a445d71.p7c922baa.pca323100.p9fb62cfc {
    private p5a445d71.p7c922baa.pca323100.pe37df0f9 f262dbb57;
    private p5a445d71.p7c922baa.pca323100.pe37df0f9 f84d7321e;
    private p5a445d71.p7c922baa.pca323100.pe37df0f9 fc1a82f92;
    private p5a445d71.p7c922baa.pca323100.pe37df0f9 fd0ecb758;
    private p5a445d71.p7c922baa.pca323100.pe37df0f9 ff7b44cfa;

    pb692180d(p5a445d71.p7c922baa.pca323100.pe37df0f9 pe37df0f9Var) {
        this.ff7b44cfa = pe37df0f9Var;
    }

    public static java.lang.string CdnVuLENHVGLMExF(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.stringBuilder OxXkFRiNrytYbftf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JTsXVjpXJBONVUjF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 QxpYOntcivvSvBkP(p5a445d71.p7c922baa.pca323100.pb692180d pb692180dVar) {
        return pb692180dVar.getLoadedobject();
    }

    public static byte[] UMikIfzmMvnfKDtV(p5a445d71.p7c922baa.pca323100.pe37df0f9 pe37df0f9Var) {
        return pe37df0f9Var.tobyteArray();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return new p5a445d71.p7c922baa.pca323100.p6f0e511c(uMikIfzmMvnfKDtV(this.ff7b44cfa));
    }

    public override java.io.Stream GetOctetStream() {
        return this.ff7b44cfa;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((2 + 18) % 18 > 0) {
        }
        try {
            return qxpYOntcivvSvBkP(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(jTsXVjpXJBONVUjF(OxXkFRiNrytYbftf(new java.lang.stringBuilder("IOException converting stream to byte array: "), CdnVuLENHVGLMExF(e))), e);
        }
    }
}

