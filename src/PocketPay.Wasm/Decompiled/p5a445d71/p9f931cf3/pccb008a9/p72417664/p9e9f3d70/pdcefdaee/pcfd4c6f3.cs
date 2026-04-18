namespace WillowMaze.Wasm.Decompiled;


public class pcfd4c6f3 {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((12 + 32) % 32 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9)) {
            throw new java.security.InvalidKeyException("can't identify McEliece private key.");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9 pace116e9Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9) privateKey;
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93(pace116e9Var.getN(), pace116e9Var.getK(), pace116e9Var.getField(), pace116e9Var.getGoppaPoly(), pace116e9Var.getP1(), pace116e9Var.getP2(), pace116e9Var.getSInv());
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((11 + 11) % 11 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc) publicKey).getKeyParams();
        }
        throw new java.security.InvalidKeyException("can't identify McEliece public key: " + publicKey.GetType().getName());
    }
}

