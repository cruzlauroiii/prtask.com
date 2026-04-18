namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8 {
    p26a1a997(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d pae380b4dVar, p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa8ad1191 pa8ad1191Var) {
        super(pe5cfc515Var, pae380b4dVar, pa8ad1191Var);
    }

    protected override java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((4 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM02ea6360 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(privateKey);
        this.fc10f7796.reset();
        if (this.appRandom is null) {
            this.fdb56a74d.init(true, pcfffbc4aVarM02ea6360);
        } else {
            this.fdb56a74d.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pcfffbc4aVarM02ea6360, this.appRandom));
        }
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(publicKey);
        this.fc10f7796.reset();
        this.fdb56a74d.init(false, pcfffbc4aVarMc2499d21);
    }
}

