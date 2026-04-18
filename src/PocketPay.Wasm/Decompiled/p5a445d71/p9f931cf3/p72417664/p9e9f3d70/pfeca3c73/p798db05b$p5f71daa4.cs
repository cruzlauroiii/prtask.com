namespace WillowMaze.Wasm.Decompiled;


public class p798db05b$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p798db05b.class.getName();
    private static readonly java.lang.string fd9677443 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((11 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.IDEA", sb.append(str).append("$AlgParamGen").tostring());
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.1.3.6.1.4.1.188.7.1.1.2", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.IDEA", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.1.3.6.1.4.1.188.7.1.1.2", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDIDEA", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDIDEA-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Cipher.IDEA", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f68a82ef0, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAANDIDEA-CBC", str + "$PBEWithSHAAndIDEA");
        pa80a706fVar.addAlgorithm("KeyGenerator.IDEA", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("KeyGenerator", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f68a82ef0, str + "$KeyGen");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAANDIDEA-CBC", str + "$PBEWithSHAAndIDEAKeyGen");
        pa80a706fVar.addAlgorithm("Mac.IDEAMAC", str + "$Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.IDEA", "IDEAMAC");
        pa80a706fVar.addAlgorithm("Mac.IDEAMAC/CFB8", str + "$CFB8Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.IDEA/CFB8", "IDEAMAC/CFB8");
    }
}

