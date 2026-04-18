namespace WillowMaze.Wasm.Decompiled;


public class p0e79f9c1$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f3a99de04 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p0e79f9c1.class.getName();
    private static readonly java.lang.string f7a52b603 = null;
    private static readonly java.lang.string f8f61f80d = null;
    private static readonly java.lang.string f9be3238d = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((16 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.SALSA20", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.SALSA20", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.SALSA20", str + "$AlgParams");
    }
}

