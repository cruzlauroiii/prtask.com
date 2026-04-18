namespace WillowMaze.Wasm.Decompiled;


public class p51848bb7$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f024cfa82 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p51848bb7.class.getName();

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((14 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.ZUC-128", sb.append(str).append("$Zuc128").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.ZUC-128", str + "$KeyGen128");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ZUC-128", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Cipher.ZUC-256", str + "$Zuc256");
        pa80a706fVar.addAlgorithm("KeyGenerator.ZUC-256", str + "$KeyGen256");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.ZUC-256", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Mac.ZUC-128", str + "$ZucMac128");
        pa80a706fVar.addAlgorithm("Mac.ZUC-256", str + "$ZucMac256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.ZUC-256-128", "ZUC-256");
        pa80a706fVar.addAlgorithm("Mac.ZUC-256-64", str + "$ZucMac256_64");
        pa80a706fVar.addAlgorithm("Mac.ZUC-256-32", str + "$ZucMac256_32");
    }
}

