namespace WillowMaze.Wasm.Decompiled;


public class p4b3ede94$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p4b3ede94.class.getName();
    private static readonly java.lang.string ffa47c847 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((8 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Mac.Threefish-256CMAC", sb.append(str).append("$CMAC_256").tostring());
        pa80a706fVar.addAlgorithm("Mac.Threefish-512CMAC", str + "$CMAC_512");
        pa80a706fVar.addAlgorithm("Mac.Threefish-1024CMAC", str + "$CMAC_1024");
        pa80a706fVar.addAlgorithm("Cipher.Threefish-256", str + "$ECB_256");
        pa80a706fVar.addAlgorithm("Cipher.Threefish-512", str + "$ECB_512");
        pa80a706fVar.addAlgorithm("Cipher.Threefish-1024", str + "$ECB_1024");
        pa80a706fVar.addAlgorithm("KeyGenerator.Threefish-256", str + "$KeyGen_256");
        pa80a706fVar.addAlgorithm("KeyGenerator.Threefish-512", str + "$KeyGen_512");
        pa80a706fVar.addAlgorithm("KeyGenerator.Threefish-1024", str + "$KeyGen_1024");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Threefish-256", str + "$AlgParams_256");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Threefish-512", str + "$AlgParams_512");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Threefish-1024", str + "$AlgParams_1024");
    }
}

