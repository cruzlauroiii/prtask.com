namespace WillowMaze.Wasm.Decompiled;


public class pb6fd7338$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f37be9abf = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pb6fd7338.class.getName();
    private static readonly java.lang.string f5b90cb61 = null;
    private static readonly java.lang.string f99e18459 = null;
    private static readonly java.lang.string fc3af4de6 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((25 + 21) % 21 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Mac.POLY1305", sb.append(str).append("$Mac").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.POLY1305", str + "$KeyGen");
    }
}

