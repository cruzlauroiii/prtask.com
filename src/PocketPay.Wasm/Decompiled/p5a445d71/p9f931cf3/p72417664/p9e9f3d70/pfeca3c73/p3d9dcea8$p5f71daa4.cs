namespace WillowMaze.Wasm.Decompiled;


public class p3d9dcea8$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p3d9dcea8.class.getName();
    private static readonly java.lang.string f6aa4ebec = null;
    private static readonly java.lang.string f7aa3b9df = null;
    private static readonly java.lang.string fe9986cf9 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((29 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.XTEA", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.XTEA", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.XTEA", str + "$AlgParams");
    }
}

