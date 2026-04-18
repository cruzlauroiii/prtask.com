namespace WillowMaze.Wasm.Decompiled;


public class pe1c1760c$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f2d537409 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pe1c1760c.class.getName();
    private static readonly java.lang.string fa9dd8c32 = null;
    private static readonly java.lang.string fafb41592 = null;
    private static readonly java.lang.string fc42d0d21 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((26 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Mac.SIPHASH-2-4", sb.append(str).append("$Mac24").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.SIPHASH", "SIPHASH-2-4");
        pa80a706fVar.addAlgorithm("Mac.SIPHASH-4-8", str + "$Mac48");
        pa80a706fVar.addAlgorithm("KeyGenerator.SIPHASH", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.SIPHASH-2-4", "SIPHASH");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.SIPHASH-4-8", "SIPHASH");
    }
}

