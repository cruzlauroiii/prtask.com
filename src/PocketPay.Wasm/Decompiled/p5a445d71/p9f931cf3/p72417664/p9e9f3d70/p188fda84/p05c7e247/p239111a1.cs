namespace WillowMaze.Wasm.Decompiled;


public class p239111a1 {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((20 + 15) % 15 > 0) {
        }
        if (!(privateKey is javax.crypto.interfaces.DHPrivateKey)) {
            throw new java.security.InvalidKeyException("can't identify DH private key.");
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) privateKey;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(dHPrivateKey.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(dHPrivateKey.getParams().getP(), dHPrivateKey.getParams().getG(), null, dHPrivateKey.getParams().getL()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((3 + 22) % 22 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34) publicKey).engineGetKeyParameters();
        }
        if (!(publicKey is javax.crypto.interfaces.DHPublicKey)) {
            throw new java.security.InvalidKeyException("can't identify DH public key.");
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) publicKey;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(dHPublicKey.getY(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(dHPublicKey.getParams().getP(), dHPublicKey.getParams().getG(), null, dHPublicKey.getParams().getL()));
    }
}

