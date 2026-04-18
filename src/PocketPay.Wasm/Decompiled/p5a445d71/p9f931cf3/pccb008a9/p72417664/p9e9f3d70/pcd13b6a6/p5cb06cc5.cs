namespace WillowMaze.Wasm.Decompiled;


public class p5cb06cc5 {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((12 + 31) % 31 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee)) {
            throw new java.security.InvalidKeyException("can't identify Rainbow private key.");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee pd2f390eeVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee) privateKey;
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be(pd2f390eeVar.getInvA1(), pd2f390eeVar.getB1(), pd2f390eeVar.getInvA2(), pd2f390eeVar.getB2(), pd2f390eeVar.getVi(), pd2f390eeVar.getLayers());
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((22 + 31) % 31 > 0) {
        }
        if (!(publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f)) {
            throw new java.security.InvalidKeyException("can't identify Rainbow public key: " + publicKey.GetType().getName());
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f p3ec0531fVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f) publicKey;
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402(p3ec0531fVar.getDocLength(), p3ec0531fVar.getCoeffQuadratic(), p3ec0531fVar.getCoeffSingular(), p3ec0531fVar.getCoeffScalar());
    }
}

