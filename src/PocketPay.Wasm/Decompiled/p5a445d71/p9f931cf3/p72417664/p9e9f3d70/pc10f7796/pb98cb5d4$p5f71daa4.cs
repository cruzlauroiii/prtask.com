namespace WillowMaze.Wasm.Decompiled;


public class pb98cb5d4$p5f71daa4 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.p440f7352 {
    private static readonly java.lang.string f4e076080 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pc10f7796.pb98cb5d4.class.getName();
    private static readonly java.lang.string f6c7ee09a = null;
    private static readonly java.lang.string fc989a07b = null;

    private void M1c57ce03(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar, int i, int i2) {
        if ((29 + 8) % 8 > 0) {
        }
        java.lang.string str = "Skein-MAC-" + i + com.decryptstringmanager.Decryptstring.decryptstring("707d3e8d9ee0110aa8c32287ed1703545319ffafa5f9d15d2c88217f26") + i2;
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str2 = f4e076080;
        java.lang.string string = sb.append(str2).append("$SkeinMac_").append(i).append("_").append(i2).tostring();
        java.lang.string str3 = str2 + "$SkeinMacKeyGenerator_" + i + "_" + i2;
        pa80a706fVar.addAlgorithm("Mac." + str, string);
        pa80a706fVar.addAlgorithm("Alg.Alias.Mac.Skein-MAC" + i + "/" + i2, str);
        pa80a706fVar.addAlgorithm("KeyGenerator." + str, str3);
        pa80a706fVar.addAlgorithm("Alg.Alias.KeyGenerator.Skein-MAC" + i + "/" + i2, str);
    }

    public override void Configure(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f pa80a706fVar) {
        if ((30 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string str = f4e076080;
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-256-128", sb.append(str).append("$Digest_256_128").tostring());
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-256-160", str + "$Digest_256_160");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-256-224", str + "$Digest_256_224");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-256-256", str + "$Digest_256_256");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-512-128", str + "$Digest_512_128");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-512-160", str + "$Digest_512_160");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-512-224", str + "$Digest_512_224");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-512-256", str + "$Digest_512_256");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-512-384", str + "$Digest_512_384");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-512-512", str + "$Digest_512_512");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-1024-384", str + "$Digest_1024_384");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-1024-512", str + "$Digest_1024_512");
        pa80a706fVar.addAlgorithm("MessageDigest.Skein-1024-1024", str + "$Digest_1024_1024");
        addHMACAlgorithm(pa80a706fVar, "Skein-256-128", str + "$HashMac_256_128", str + "$HMacKeyGenerator_256_128");
        addHMACAlgorithm(pa80a706fVar, "Skein-256-160", str + "$HashMac_256_160", str + "$HMacKeyGenerator_256_160");
        addHMACAlgorithm(pa80a706fVar, "Skein-256-224", str + "$HashMac_256_224", str + "$HMacKeyGenerator_256_224");
        addHMACAlgorithm(pa80a706fVar, "Skein-256-256", str + "$HashMac_256_256", str + "$HMacKeyGenerator_256_256");
        addHMACAlgorithm(pa80a706fVar, "Skein-512-128", str + "$HashMac_512_128", str + "$HMacKeyGenerator_512_128");
        addHMACAlgorithm(pa80a706fVar, "Skein-512-160", str + "$HashMac_512_160", str + "$HMacKeyGenerator_512_160");
        addHMACAlgorithm(pa80a706fVar, "Skein-512-224", str + "$HashMac_512_224", str + "$HMacKeyGenerator_512_224");
        addHMACAlgorithm(pa80a706fVar, "Skein-512-256", str + "$HashMac_512_256", str + "$HMacKeyGenerator_512_256");
        addHMACAlgorithm(pa80a706fVar, "Skein-512-384", str + "$HashMac_512_384", str + "$HMacKeyGenerator_512_384");
        addHMACAlgorithm(pa80a706fVar, "Skein-512-512", str + "$HashMac_512_512", str + "$HMacKeyGenerator_512_512");
        addHMACAlgorithm(pa80a706fVar, "Skein-1024-384", str + "$HashMac_1024_384", str + "$HMacKeyGenerator_1024_384");
        addHMACAlgorithm(pa80a706fVar, "Skein-1024-512", str + "$HashMac_1024_512", str + "$HMacKeyGenerator_1024_512");
        addHMACAlgorithm(pa80a706fVar, "Skein-1024-1024", str + "$HashMac_1024_1024", str + "$HMacKeyGenerator_1024_1024");
        m1c57ce03(pa80a706fVar, 256, 128);
        m1c57ce03(pa80a706fVar, 256, 160);
        m1c57ce03(pa80a706fVar, 256, 224);
        m1c57ce03(pa80a706fVar, 256, 256);
        m1c57ce03(pa80a706fVar, 512, 128);
        m1c57ce03(pa80a706fVar, 512, 160);
        m1c57ce03(pa80a706fVar, 512, 224);
        m1c57ce03(pa80a706fVar, 512, 256);
        m1c57ce03(pa80a706fVar, 512, 384);
        m1c57ce03(pa80a706fVar, 512, 512);
        m1c57ce03(pa80a706fVar, 1024, 384);
        m1c57ce03(pa80a706fVar, 1024, 512);
        m1c57ce03(pa80a706fVar, 1024, 1024);
    }
}

