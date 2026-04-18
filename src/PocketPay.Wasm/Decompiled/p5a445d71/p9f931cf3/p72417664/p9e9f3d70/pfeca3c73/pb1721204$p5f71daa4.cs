namespace WillowMaze.Wasm.Decompiled;


public class pb1721204$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    private static readonly java.lang.string f0eb6d52a = null;
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pb1721204.class.getName();
    private static readonly java.lang.string fee4a1e55 = null;

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((31 + 8) % 8 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("SecretKeyFactory.SCRYPT", sb.append(str).append("$ScryptWithUTF8").tostring());
        pa80a706fVar.addAlgorithm("SecretKeyFactory", p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f145838c9, str + "$ScryptWithUTF8");
    }
}

