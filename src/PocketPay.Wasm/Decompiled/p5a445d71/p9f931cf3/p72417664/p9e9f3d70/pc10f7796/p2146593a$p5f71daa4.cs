namespace WillowMaze.Wasm.Decompiled;


public class p2146593a$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f036c7700 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p2146593a.class.getName();
    private static readonly java.lang.string fc31ef442 = null;
    private static readonly java.lang.string fd72eb903 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((16 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.HARAKA-256", sb.append(str).append("$Digest256").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest.HARAKA-512", str + "$Digest512");
    }
}

