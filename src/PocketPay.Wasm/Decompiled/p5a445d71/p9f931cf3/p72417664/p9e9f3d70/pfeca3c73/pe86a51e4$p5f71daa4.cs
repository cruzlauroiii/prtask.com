namespace WillowMaze.Wasm.Decompiled;


public class pe86a51e4$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f11a41c7f = null;
    private static readonly java.lang.string f26f329f0 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pe86a51e4.class.getName();
    private static readonly java.lang.string fd30e7201 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((12 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.HC128", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.HC128", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.HC128", str + "$AlgParams");
    }
}

