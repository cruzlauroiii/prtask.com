namespace WillowMaze.Wasm.Decompiled;


public class p62135cae$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f2f4438b6 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p62135cae.class.getName();
    private static readonly java.lang.string f57372115 = null;
    private static readonly java.lang.string f840ce4f8 = null;
    private static readonly java.lang.string f8e688d0e = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((2 + 23) % 23 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.RC5", sb.append(str).append("$ECB32").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.RC5-32", "RC5");
        pa80a706fVar.addAlgorithm("Cipher.RC5-64", str + "$ECB64");
        pa80a706fVar.addAlgorithm("KeyGenerator.RC5", str + "$KeyGen32");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.RC5-32", "RC5");
        pa80a706fVar.addAlgorithm("KeyGenerator.RC5-64", str + "$KeyGen64");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.RC5", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.RC5-64", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Mac.RC5MAC", str + "$Mac32");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.RC5", "RC5MAC");
        pa80a706fVar.addAlgorithm("Mac.RC5MAC/CFB8", str + "$CFB8Mac32");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.RC5/CFB8", "RC5MAC/CFB8");
    }
}

