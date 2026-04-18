namespace WillowMaze.Wasm.Decompiled;


public class pa203bca4$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f1af56a23 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa203bca4.class.getName();
    private static readonly java.lang.string fd209ae31 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((13 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.XSALSA20", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.XSALSA20", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.XSALSA20", str + "$AlgParams");
    }
}

