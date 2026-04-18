namespace WillowMaze.Wasm.Decompiled;


public class pf85b7b37$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        pa80a706fVar.addAlgorithm("KeyStore.BKS", "org.bouncycastle.jcajce.provider.keystore.bc.BcKeyStoreSpi$Std");
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.bks.enable_v1")) {
            pa80a706fVar.addAlgorithm("KeyStore.BKS-V1", "org.bouncycastle.jcajce.provider.keystore.bc.BcKeyStoreSpi$Version1");
        }
        pa80a706fVar.addAlgorithm("KeyStore.BouncyCastle", "org.bouncycastle.jcajce.provider.keystore.bc.BcKeyStoreSpi$BouncyCastleStore");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyStore.UBER", "BouncyCastle");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyStore.BOUNCYCASTLE", "BouncyCastle");
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyStore.bouncycastle", "BouncyCastle");
    }
}

