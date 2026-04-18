namespace WillowMaze.Wasm.Decompiled;


abstract class p440f7352 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    p440f7352() {
    }

    protected void AddHMACAlgorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((21 + 18) % 18 > 0) {
        }
        java.lang.string str4 = "HMAC" + str;
        pa80a706fVar.addAlgorithm("Mac." + str4, str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.HMAC-" + str, str4);
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.HMAC/" + str, str4);
        pa80a706fVar.addAlgorithm("KeyGenerator." + str4, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.HMAC-" + str, str4);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.HMAC/" + str, str4);
    }

    protected void AddHMACAlias(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        java.lang.string str2 = "HMAC" + str;
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac." + p364bf33aVar, str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator." + p364bf33aVar, str2);
    }
}

