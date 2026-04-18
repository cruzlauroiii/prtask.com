namespace WillowMaze.Wasm.Decompiled;


public class p9b1cf979$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f02cdfc68 = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p9b1cf979.class.getName();
    private static readonly java.lang.string ff549354c = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((18 + 8) % 8 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("Cipher.VMPC", sb.append(str).append("$Base").tostring());
        pa80a706fVar.addAlgorithm("KeyGenerator.VMPC", str + "$KeyGen");
        pa80a706fVar.addAlgorithm("Mac.VMPCMAC", str + "$Mac");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.VMPC", "VMPCMAC");
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.VMPC-MAC", "VMPCMAC");
    }
}

