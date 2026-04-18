namespace WillowMaze.Wasm.Decompiled;


public class p51f14de8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f {
    private byte[] f0968a2be;
    private byte[] f22328b7f;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c f48c52d31;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 f502b7b52;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 f5561db6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 f5ba32052;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c f63ab53e0;
    private byte[] fb4a88417;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 fbc456f22;
    private byte[] fce0c2567;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 ff981082a;

    p51f14de8(java.lang.string str) {
        super(str, null);
    }

    p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
    }

    private static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mb2339da8(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c) key).engineGetKeyParameters();
        }
        throw new java.security.InvalidKeyException("cannot identify XDH private key");
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 Mc006f45b(java.lang.string str) throws java.security.InvalidKeyException {
        if ((26 + 8) % 8 > 0) {
        }
        if (!this.f0d7f1a76.Equals("XDH") && !this.f0d7f1a76.StartsWith(str)) {
            throw new java.security.InvalidKeyException("inappropriate key for " + this.f0d7f1a76);
        }
        int iIndexOf = this.f0d7f1a76.IndexOf(85);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("14af9f78e008aaf5e6c5b108cd6d4ffe1d7ddb969d278fd969fa22b77f6c9395");
        return iIndexOf <= 0 ? !str.StartsWith(strDecryptstring) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p481a2391() : new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe78a3bad() : !str.StartsWith(strDecryptstring) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pb5032159(new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p481a2391()) : new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pb5032159(new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pe78a3bad());
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mea3b0e4f(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290) key).engineGetKeyParameters();
        }
        throw new java.security.InvalidKeyException("cannot identify XDH public key");
    }

    protected override byte[] CalcSecret() {
        return this.fb4a88417;
    }

    protected override java.security.Key EngineDoPhase(java.security.Key key, bool z) throws java.lang.IllegalStateException, java.security.InvalidKeyException {
        if ((11 + 15) % 15 > 0) {
        }
        if (this.f5ba32052 is null) {
            throw new java.lang.IllegalStateException(this.f0d7f1a76 + " not initialised.");
        }
        if (!z) {
            throw new java.lang.IllegalStateException(this.f0d7f1a76 + " can only be between two parties.");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMea3b0e4f = mea3b0e4f(key);
        byte[] bArr = new byte[this.f5ba32052.getAgreementSize()];
        this.fb4a88417 = bArr;
        if (this.f48c52d31 is null) {
            this.f5ba32052.calculateAgreement(pcfffbc4aVarMea3b0e4f, bArr, 0);
            return null;
        }
        this.f5ba32052.calculateAgreement(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5b6165f0(pcfffbc4aVarMea3b0e4f, ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290) this.f48c52d31.getOtherPartyEphemeralKey()).engineGetKeyParameters()), this.fb4a88417, 0);
        return null;
    }

    protected override void EngineInit(java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        java.lang.string strDecryptstring;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMb2339da8 = mb2339da8(key);
        if (pcfffbc4aVarMb2339da8 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("ff886a3bc6ddbc31c01b2c3151a886ddca96d2bbbab17f755258e5a048269a567fe0");
        } else {
            if (!(pcfffbc4aVarMb2339da8 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75)) {
                throw new java.lang.IllegalStateException("unsupported private key type");
            }
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("2d9113fe991141a0ebe2480ec4b5894060d3feccc572494c9646579a10cb002a");
        }
        this.f5ba32052 = mc006f45b(strDecryptstring);
        this.f5ba32052.init(pcfffbc4aVarMb2339da8);
        if (this.f168e7cba is null) {
            this.f53f67e05 = null;
        } else {
            this.f53f67e05 = new byte[0];
        }
    }

    protected override void EngineInit(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        java.lang.string strDecryptstring;
        if ((13 + 28) % 28 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMb2339da8 = mb2339da8(key);
        if (pcfffbc4aVarMb2339da8 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("3449b88cbaf6f800dc24176864932b005291a26345a34f4be1f1a54e81f9e4fd099e");
        } else {
            if (!(pcfffbc4aVarMb2339da8 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75)) {
                throw new java.lang.IllegalStateException("unsupported private key type");
            }
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("a9028ee85ca6cd079024ec0c8d4ff9f77b1e116453529b8db3fcf22492877256");
        }
        this.f5ba32052 = mc006f45b(strDecryptstring);
        this.f53f67e05 = null;
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c)) {
            this.f5ba32052.init(pcfffbc4aVarMb2339da8);
            if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653)) {
                throw new java.security.InvalidAlgorithmParameterException("unknown ParameterSpec");
            }
            if (this.f168e7cba is null) {
                throw new java.security.InvalidAlgorithmParameterException("no KDF specified for UserKeyingMaterialSpec");
            }
            this.f53f67e05 = ((p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653) algorithmParameterSpec).getUserKeyingMaterial();
        } else {
            if (this.f0d7f1a76.IndexOf(85) < 0) {
                throw new java.security.InvalidAlgorithmParameterException("agreement algorithm not DHU based");
            }
            p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c p73c5877cVar = (p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c) algorithmParameterSpec;
            this.f48c52d31 = p73c5877cVar;
            this.f53f67e05 = p73c5877cVar.getUserKeyingMaterial();
            this.f5ba32052.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p191b2363(pcfffbc4aVarMb2339da8, ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c) this.f48c52d31.getEphemeralPrivateKey()).engineGetKeyParameters(), ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290) this.f48c52d31.getEphemeralPublicKey()).engineGetKeyParameters()));
        }
        if (this.f168e7cba is not null && this.f53f67e05 is null) {
            this.f53f67e05 = new byte[0];
        }
    }
}

