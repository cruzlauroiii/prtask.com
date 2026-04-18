namespace WillowMaze.Wasm.Decompiled;


public class pac40920a$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pac40920a.class.getName();
    private static readonly java.lang.string f97c203b7 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((10 + 17) % 17 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.SKIPJACK", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.SKIPJACK", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.SKIPJACK", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Mac.SKIPJACKMAC", str + "$Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.SKIPJACK", "SKIPJACKMAC");
        pa80a706fVar.addAlgorithm("Mac.SKIPJACKMAC/CFB8", str + "$MacCFB8");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.SKIPJACK/CFB8", "SKIPJACKMAC/CFB8");
    }
}

