namespace WillowMaze.Wasm.Decompiled;


public class p6c9f745f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p6c9f745f.class.getName();
    private static readonly java.lang.string f931819fe = null;
    private static readonly java.lang.string fe504c69a = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((13 + 5) % 5 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2B-512", sb.append(str).append("$Blake2b512").tostring());
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f53f06052, "BLAKE2B-512");
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2B-384", str + "$Blake2b384");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f40791d07, "BLAKE2B-384");
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2B-256", str + "$Blake2b256");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f834fe9fc, "BLAKE2B-256");
        pa80a706fVar.addAlgorithm("MessageDigest.BLAKE2B-160", str + "$Blake2b160");
        pa80a706fVar.addAlgorithm("Alg.Alias.MessageDigest." + p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f98ba7fb6, "BLAKE2B-160");
    }
}

