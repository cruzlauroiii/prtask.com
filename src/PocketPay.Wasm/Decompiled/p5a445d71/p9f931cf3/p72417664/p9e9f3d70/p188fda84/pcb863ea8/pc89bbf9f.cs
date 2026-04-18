namespace WillowMaze.Wasm.Decompiled;


public class pc89bbf9f {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((3 + 20) % 20 > 0) {
        }
        if (privateKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55) {
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55 ped942c55Var = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55) privateKey;
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4(ped942c55Var.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(ped942c55Var.getParameters().getP(), ped942c55Var.getParameters().getG()));
        }
        if (!(privateKey is javax.crypto.interfaces.DHPrivateKey)) {
            throw new java.security.InvalidKeyException("can't identify private key for El Gamal.");
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) privateKey;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4(dHPrivateKey.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(dHPrivateKey.getParams().getP(), dHPrivateKey.getParams().getG()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((4 + 13) % 13 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7) {
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7 pd9fd0eb7Var = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pd9fd0eb7) publicKey;
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0(pd9fd0eb7Var.getY(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(pd9fd0eb7Var.getParameters().getP(), pd9fd0eb7Var.getParameters().getG()));
        }
        if (!(publicKey is javax.crypto.interfaces.DHPublicKey)) {
            throw new java.security.InvalidKeyException("can't identify public key for El Gamal.");
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) publicKey;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0(dHPublicKey.getY(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(dHPublicKey.getParams().getP(), dHPublicKey.getParams().getG()));
    }
}

