namespace WillowMaze.Wasm.Decompiled;


public class p7cde8b0c$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p7cde8b0c.class.getName();
    private static readonly java.lang.string f71973cea = null;
    private static readonly java.lang.string fe7f1dba3 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((7 + 31) % 31 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.Serpent", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.Serpent", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Serpent", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Cipher.Tnepres", str + "$TECB");
        pa80a706fVar.addAlgorithm("KeyGenerator.Tnepres", str + "$TKeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Tnepres", str + "$TAlgParams");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f8e4b100a, str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f7e29ed70, str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.fc9d980fb, str + "$ECB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f00271f6f, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f07bc16d5, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.feea17442, str + "$CBC");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f3c947e3b, str + "$CFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f100c0139, str + "$CFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.fecd6ed99, str + "$CFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f3e2d281b, str + "$OFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.fb77d27a0, str + "$OFB");
        pa80a706fVar.addAlgorithm("Cipher", p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f7fb19d96, str + "$OFB");
        addGMacAlgorithm(pa80a706fVar, "SERPENT", str + "$SerpentGMAC", str + "$KeyGen");
        addGMacAlgorithm(pa80a706fVar, "TNEPRES", str + "$TSerpentGMAC", str + "$TKeyGen");
        addPoly1305Algorithm(pa80a706fVar, "SERPENT", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

