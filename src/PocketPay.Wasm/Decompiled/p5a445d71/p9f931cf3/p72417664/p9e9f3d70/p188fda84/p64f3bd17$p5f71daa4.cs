namespace WillowMaze.Wasm.Decompiled;


public class p64f3bd17$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p91742cc7 {
    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((19 + 32) % 32 > 0) {
        }
        pa80a706fVar.addAlgorithm("Signature.SHA256WITHSM2", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMSignatureSpi$sha256WithSM2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f5c245682, "SHA256WITHSM2");
        pa80a706fVar.addAlgorithm("Signature.SM3WITHSM2", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMSignatureSpi$sm3WithSM2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Signature." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f14dae1fb, "SM3WITHSM2");
        pa80a706fVar.addAlgorithm("Cipher.SM2", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher.SM2WITHSM3", "SM2");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f629f8415, "SM2");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHBLAKE2B", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withBlake2b");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f923062cd, "SM2WITHBLAKE2B");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHBLAKE2S", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withBlake2s");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.fd03121c1, "SM2WITHBLAKE2S");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHWHIRLPOOL", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withWhirlpool");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f8ae905aa, "SM2WITHWHIRLPOOL");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHMD5", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withMD5");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.fa742fd85, "SM2WITHMD5");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHRIPEMD160", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withRMD");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f00baca83, "SM2WITHRIPEMD160");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHSHA1", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withSha1");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f039fb293, "SM2WITHSHA1");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHSHA224", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withSha224");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.ff322c06f, "SM2WITHSHA224");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHSHA256", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withSha256");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f25232d80, "SM2WITHSHA256");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHSHA384", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withSha384");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.fe55227a0, "SM2WITHSHA384");
        pa80a706fVar.addAlgorithm("Cipher.SM2WITHSHA512", "org.bouncycastle.jcajce.provider.asymmetric.ec.GMCipherSpi$SM2withSha512");
        pa80a706fVar.addAlgorithm("Alg.Alias.Cipher." + p5a445d71.p9f931cf3.pca323100.p92073d2f.p18022a8b.f0a6f2778, "SM2WITHSHA512");
    }
}

