namespace WillowMaze.Wasm.Decompiled;


public class p7a5dfe3f {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((14 + 10) % 10 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f)) {
            throw new java.security.InvalidKeyException("can't identify GOST3410 private key.");
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f p5b96aa5fVar = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f) privateKey;
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 publicKeyParameters = p5b96aa5fVar.getParameters().getPublicKeyParameters();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf(p5b96aa5fVar.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05(publicKeyParameters.getP(), publicKeyParameters.getQ(), publicKeyParameters.getA()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((26 + 28) % 28 > 0) {
        }
        if (!(publicKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739)) {
            throw new java.security.InvalidKeyException("can't identify GOST3410 public key: " + publicKey.GetType().getName());
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739 p66990739Var = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739) publicKey;
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 publicKeyParameters = p66990739Var.getParameters().getPublicKeyParameters();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8(p66990739Var.getY(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05(publicKeyParameters.getP(), publicKeyParameters.getQ(), publicKeyParameters.getA()));
    }
}

