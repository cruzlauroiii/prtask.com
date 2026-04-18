namespace WillowMaze.Wasm.Decompiled;


public class p1d664bb4$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p5a48c5a3 {
    private static readonly java.lang.string f018da6b6 = null;
    private static readonly java.lang.string f2a5073c4 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p1d664bb4.class.getName();
    private static readonly java.lang.string f8e7b8bb3 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((24 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.Twofish", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.Twofish", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.Twofish", str + "$AlgParams");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDTWOFISH", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters.PBEWITHSHAANDTWOFISH-CBC", "PKCS12PBE");
        pa80a706fVar.addAlgorithm("Cipher.PBEWITHSHAANDTWOFISH-CBC", str + "$PBEWithSHA");
        pa80a706fVar.addAlgorithm("SecretKeyFactory.PBEWITHSHAANDTWOFISH-CBC", str + "$PBEWithSHAKeyFactory");
        addGMacAlgorithm(pa80a706fVar, "Twofish", str + "$GMAC", str + "$KeyGen");
        addPoly1305Algorithm(pa80a706fVar, "Twofish", str + "$Poly1305", str + "$Poly1305KeyGen");
    }
}

