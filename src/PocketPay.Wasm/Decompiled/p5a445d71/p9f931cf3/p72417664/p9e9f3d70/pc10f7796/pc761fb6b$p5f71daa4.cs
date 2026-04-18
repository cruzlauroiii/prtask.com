namespace WillowMaze.Wasm.Decompiled;


public class pc761fb6b$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f094a4603 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pc761fb6b.class.getName();
    private static readonly java.lang.string f5c09c6ac = null;
    private static readonly java.lang.string f9e587b4f = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((7 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.RIPEMD320", sb.append(str).append("$Digest").tostring());
        addHMACAlgorithm(pa80a706fVar, "RIPEMD320", str + "$HashMac", str + "$KeyGenerator");
    }
}

