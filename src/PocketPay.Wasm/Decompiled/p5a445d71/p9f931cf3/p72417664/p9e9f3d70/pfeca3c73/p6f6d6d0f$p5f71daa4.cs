namespace WillowMaze.Wasm.Decompiled;


public class p6f6d6d0f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f17fc0e03 = null;
    private static readonly java.lang.string f3f541c36 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p6f6d6d0f.class.getName();
    private static readonly java.lang.string f8d53d3c0 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((1 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Mac.SIPHASH128-2-4", sb.append(str).append("$Mac24").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.SIPHASH128", "SIPHASH128-2-4");
        pa80a706fVar.addAlgorithm("Mac.SIPHASH128-4-8", str + "$Mac48");
        pa80a706fVar.addAlgorithm("KeyGenerator.SIPHASH128", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.SIPHASH128-2-4", "SIPHASH128");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.SIPHASH128-4-8", "SIPHASH128");
    }
}

