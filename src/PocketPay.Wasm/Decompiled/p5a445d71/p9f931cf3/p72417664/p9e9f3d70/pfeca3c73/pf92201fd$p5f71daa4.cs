namespace WillowMaze.Wasm.Decompiled;


public class pf92201fd$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f1ca862ed = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pf92201fd.class.getName();
    private static readonly java.lang.string facc03c70 = null;
    private static readonly java.lang.string fe9553fc3 = null;
    private static readonly java.lang.string fff50efff = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((29 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.RIJNDAEL", sb.append(str).append("$ECB").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.RIJNDAEL", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("AlgorithmParameters.RIJNDAEL", str + "$AlgParams");
    }
}

