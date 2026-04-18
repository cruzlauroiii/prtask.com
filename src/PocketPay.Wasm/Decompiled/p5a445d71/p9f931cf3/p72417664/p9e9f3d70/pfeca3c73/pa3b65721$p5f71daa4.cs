namespace WillowMaze.Wasm.Decompiled;


public class pa3b65721$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa3b65721.class.getName();
    private static readonly java.lang.string fc91ef676 = null;
    private static readonly java.lang.string ff77d1322 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((10 + 29) % 29 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.GOST3412-2015", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("Cipher.GOST3412-2015/CFB", str + "$GCFB");
        pa80a706fVar.addAlgorithm("Cipher.GOST3412-2015/CFB8", str + "$GCFB8");
        pa80a706fVar.addAlgorithm("Cipher.GOST3412-2015/OFB", str + "$OFB");
        pa80a706fVar.addAlgorithm("Cipher.GOST3412-2015/CBC", str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher.GOST3412-2015/CTR", str + "$CTR");
        pa80a706fVar.addAlgorithm("KeyGenerator.GOST3412-2015", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Mac.GOST3412MAC", str + "$Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.GOST3412-2015", "GOST3412MAC");
    }
}

