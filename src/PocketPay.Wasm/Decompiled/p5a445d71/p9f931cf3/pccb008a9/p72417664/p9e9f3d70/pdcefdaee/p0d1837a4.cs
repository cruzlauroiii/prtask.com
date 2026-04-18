namespace WillowMaze.Wasm.Decompiled;


public class p0d1837a4 {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if (privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2) privateKey).getKeyParams();
        }
        throw new java.security.InvalidKeyException("can't identify McElieceCCA2 private key.");
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((31 + 27) % 27 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb) {
            return ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb) publicKey).getKeyParams();
        }
        throw new java.security.InvalidKeyException("can't identify McElieceCCA2 public key: " + publicKey.GetType().getName());
    }
}

