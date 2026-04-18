namespace WillowMaze.Wasm.Decompiled;


public class pdf77e51f$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f0b8b3fdf = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pdf77e51f.class.getName();
    private static readonly java.lang.string fafb13a29 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((2 + 18) % 18 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.RC6", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.RC6", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.RC6", str + "$AlgParams");
        addGMacAlgorithm(pa80a706fVar, "RC6", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "RC6", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

