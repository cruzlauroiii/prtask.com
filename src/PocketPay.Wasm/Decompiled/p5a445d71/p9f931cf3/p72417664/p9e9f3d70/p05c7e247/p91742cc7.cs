namespace WillowMaze.Wasm.Decompiled;


public abstract class p91742cc7 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc {
    protected void AddSignatureAlgorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((24 + 8) % 8 > 0) {
        }
        addSignatureAlgorithm(pa80a706fVar, str, str2, str3, null);
    }

    protected void AddSignatureAlgorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, java.lang.string str3, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((22 + 27) % 27 > 0) {
        }
        java.lang.string str4 = str + "WITH" + str2;
        java.lang.string str5 = str + "with" + str2;
        java.lang.string str6 = str + "With" + str2;
        java.lang.string str7 = str + "/" + str2;
        pa80a706fVar.addAlgorithm("Signature." + str4, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str5, str4);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str6, str4);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + str7, str4);
        if (p364bf33aVar is null) {
            return;
        }
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p364bf33aVar, str4);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.OID." + p364bf33aVar, str4);
    }

    protected void AddSignatureAlgorithm(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, java.lang.string str, java.lang.string str2, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        pa80a706fVar.addAlgorithm("Signature." + str, str2);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p364bf33aVar, str);
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature.OID." + p364bf33aVar, str);
    }

    protected void RegisterOid(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 pae2f7198Var) {
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyFactory." + p364bf33aVar, str);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyValueTupleGenerator." + p364bf33aVar, str);
        pa80a706fVar.addKeyInfoConverter(p364bf33aVar, pae2f7198Var);
    }

    protected void RegisterOidAlgorithmParameterGenerator(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, java.lang.string str) {
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameterGenerator." + p364bf33aVar, str);
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p364bf33aVar, str);
    }

    protected void RegisterOidAlgorithmParameters(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, java.lang.string str) {
        pa80a706fVar.addAlgorithm("Alg.Alias.AlgorithmParameters." + p364bf33aVar, str);
    }
}

