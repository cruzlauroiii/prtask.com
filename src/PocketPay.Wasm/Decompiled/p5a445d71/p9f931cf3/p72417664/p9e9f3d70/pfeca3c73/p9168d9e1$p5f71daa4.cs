namespace WillowMaze.Wasm.Decompiled;


public class p9168d9e1$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p9168d9e1.class.getName();
    private static readonly java.lang.string f91c40931 = null;
    private static readonly java.lang.string fb3bcee30 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((3 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.HC256", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.HC256", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.HC256", str + "$AlgParams");
    }
}

