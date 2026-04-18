namespace WillowMaze.Wasm.Decompiled;


public class p71f9ceaa$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f04fed55e = null;
    private static readonly java.lang.string f44b24cfe = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p71f9ceaa.class.getName();
    private static readonly java.lang.string fc649d1b0 = null;
    private static readonly java.lang.string fd87b6b7f = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((3 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Mac.Shacal-2CMAC", sb.append(str).append("$CMAC").tostring());
        pa80a706fVar.addAlgorithm("Cipher.Shacal2", str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher.SHACAL-2", str + "$ECB");
        pa80a706fVar.addAlgorithm("KeyGenerator.Shacal2", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.Shacal2", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Shacal2", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("KeyGenerator.SHACAL-2", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameterGenerator.SHACAL-2", str + "$AlgParamGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.SHACAL-2", str + "$AlgParams");
    }
}

