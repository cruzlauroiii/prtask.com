namespace WillowMaze.Wasm.Decompiled;


public class p6d187f34$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f25a37d8a = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p6d187f34.class.getName();
    private static readonly java.lang.string fcb366244 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((7 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.KECCAK-224", sb.append(str).append("$Digest224").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest.KECCAK-288", str + "$Digest288");
        pa80a706fVar.addAlgorithm("MessageDigest.KECCAK-256", str + "$Digest256");
        pa80a706fVar.addAlgorithm("MessageDigest.KECCAK-384", str + "$Digest384");
        pa80a706fVar.addAlgorithm("MessageDigest.KECCAK-512", str + "$Digest512");
        addHMACAlgorithm(pa80a706fVar, "KECCAK224", str + "$HashMac224", str + "$KeyGenerator224");
        addHMACAlgorithm(pa80a706fVar, "KECCAK256", str + "$HashMac256", str + "$KeyGenerator256");
        addHMACAlgorithm(pa80a706fVar, "KECCAK288", str + "$HashMac288", str + "$KeyGenerator288");
        addHMACAlgorithm(pa80a706fVar, "KECCAK384", str + "$HashMac384", str + "$KeyGenerator384");
        addHMACAlgorithm(pa80a706fVar, "KECCAK512", str + "$HashMac512", str + "$KeyGenerator512");
    }
}

