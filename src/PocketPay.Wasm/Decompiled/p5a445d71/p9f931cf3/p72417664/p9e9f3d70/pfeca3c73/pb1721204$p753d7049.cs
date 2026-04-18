namespace WillowMaze.Wasm.Decompiled;


public class pb1721204$p753d7049 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7a260613 {
    private int f17c4f0be;
    private int f39b84bb8;
    private int f41323917;
    private int fb84cdbda;

    public pb1721204$p753d7049(java.lang.string str, int i) {
        super(str, p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f145838c9);
        this.f41323917 = i;
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((2 + 17) % 17 > 0) {
        }
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc438e8e5)) {
            throw new java.security.spec.InvalidKeySpecException("Invalid KeySpec");
        }
        p5a445d71.p9f931cf3.p72417664.pb979c293.pc438e8e5 pc438e8e5Var = (p5a445d71.p9f931cf3.p72417664.pb979c293.pc438e8e5) keySpec;
        if (pc438e8e5Var.getSalt() is null) {
            throw new java.lang.IllegalArgumentException("Salt S must be provided.");
        }
        if (pc438e8e5Var.getCostParameter() <= 1) {
            throw new java.lang.IllegalArgumentException("Cost parameter N must be > 1.");
        }
        if (pc438e8e5Var.getKeyLength() <= 0) {
            throw new java.security.spec.InvalidKeySpecException("positive key length required: " + pc438e8e5Var.getKeyLength());
        }
        if (pc438e8e5Var.getPassword().length == 0) {
            throw new java.lang.IllegalArgumentException("password empty");
        }
        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd(this.fcde54e56, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p6c0d87f6.m15117b28(p5a445d71.p9f931cf3.p5ae9b7f2.p3d454bee.feb7ee0fb.convert(pc438e8e5Var.getPassword()), pc438e8e5Var.getSalt(), pc438e8e5Var.getCostParameter(), pc438e8e5Var.getBlockSize(), pc438e8e5Var.getParallelizationParameter(), pc438e8e5Var.getKeyLength() / 8)));
    }
}

