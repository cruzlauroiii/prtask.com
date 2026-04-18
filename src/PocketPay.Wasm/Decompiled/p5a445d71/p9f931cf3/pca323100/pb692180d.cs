namespace WillowMaze.Wasm.Decompiled;


public class pb692180d : p5a445d71.p9f931cf3.pca323100.p9fb62cfc {
    private p5a445d71.p9f931cf3.pca323100.pe37df0f9 f5bc24c07;
    private p5a445d71.p9f931cf3.pca323100.pe37df0f9 f8f721b97;
    private p5a445d71.p9f931cf3.pca323100.pe37df0f9 fab3e70dc;
    private p5a445d71.p9f931cf3.pca323100.pe37df0f9 ff67d8239;
    private p5a445d71.p9f931cf3.pca323100.pe37df0f9 ff7b44cfa;

    pb692180d(p5a445d71.p9f931cf3.pca323100.pe37df0f9 pe37df0f9Var) {
        this.ff7b44cfa = pe37df0f9Var;
    }

    public static java.lang.stringBuilder KQHUTxHgnFcCVnaN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] TfiqmzANBkCvlmkn(p5a445d71.p9f931cf3.pca323100.pe37df0f9 pe37df0f9Var) {
        return pe37df0f9Var.tobyteArray();
    }

    public static java.lang.string IRQmhWAkIARlFsEu(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 RSAnhrFBWwgPrqib(p5a445d71.p9f931cf3.pca323100.pb692180d pb692180dVar) {
        return pb692180dVar.getLoadedobject();
    }

    public static java.lang.string TYOhgReUodsRbflb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(TfiqmzANBkCvlmkn(this.ff7b44cfa));
    }

    public override java.io.Stream GetOctetStream() {
        return this.ff7b44cfa;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 13) % 13 > 0) {
        }
        try {
            return rSAnhrFBWwgPrqib(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(tYOhgReUodsRbflb(KQHUTxHgnFcCVnaN(new java.lang.stringBuilder("IOException converting stream to byte array: "), iRQmhWAkIARlFsEu(e))), e);
        }
    }
}

