namespace WillowMaze.Wasm.Decompiled;


abstract class p5a48c5a3 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    p5a48c5a3() {
    }

    protected void AddCMacAlgorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((2 + 28) % 28 > 0) {
        }
        pa80a706fVar.addAlgorithm("Mac." + str + "-CMAC", str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + str + "CMAC", str + "-CMAC");
        pa80a706fVar.addAlgorithm("KeyGenerator." + str + "-CMAC", str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator." + str + "CMAC", str + "-CMAC");
    }

    protected void AddGMacAlgorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((12 + 1) % 1 > 0) {
        }
        pa80a706fVar.addAlgorithm("Mac." + str + "-GMAC", str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + str + "GMAC", str + "-GMAC");
        pa80a706fVar.addAlgorithm("KeyGenerator." + str + "-GMAC", str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator." + str + "GMAC", str + "-GMAC");
    }

    protected void AddPoly1305Algorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        pa80a706fVar.addAlgorithm("Mac.POLY1305-" + str, str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.POLY1305" + str, "POLY1305-" + str);
        pa80a706fVar.addAlgorithm("KeyGenerator.POLY1305-" + str, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.POLY1305" + str, "POLY1305-" + str);
    }
}

