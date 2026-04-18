namespace WillowMaze.Wasm.Decompiled;


public class p7b5e7930$p85889fd1 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p7b5e7930$pfe43b677 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fd21713e9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fde4310ad;

    protected p7b5e7930$p85889fd1(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        super(str);
        this.fd21713e9 = p1748c064Var;
    }

    private byte[] M11885b3d(p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4 p6672a3b4Var, p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(p6672a3b4Var.getLabel()), p6672a3b4Var.getSeed());
        byte[] secret = p6672a3b4Var.getSecret();
        byte[] bArr = new byte[p6672a3b4Var.getLength()];
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p7b5e7930.mf8f67da7(p1748c064Var, secret, bArrMd844b504, bArr);
        return bArr;
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((24 + 22) % 22 > 0) {
        }
        if (keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4) {
            return new javax.crypto.spec.SecretKeySpec(m11885b3d((p5a445d71.p9f931cf3.p72417664.pb979c293.p6672a3b4) keySpec, this.fd21713e9), this.fcde54e56);
        }
        throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
    }
}

