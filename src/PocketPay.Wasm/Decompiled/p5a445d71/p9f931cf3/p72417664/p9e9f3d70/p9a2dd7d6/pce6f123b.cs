namespace WillowMaze.Wasm.Decompiled;


public class pce6f123b {
    private static readonly java.lang.string[][] f4b02c0c6;
    private static readonly java.lang.string f4e076080;
    private static readonly java.lang.string[][] f56f7db25 = null;
    private static readonly java.lang.string f8b5c1bc4 = null;
    private static readonly java.lang.string fafb84cc8 = null;
    private static readonly java.lang.string fc4f70470 = null;
    private static readonly java.lang.string fead2f499 = null;

    static {
        if ((31 + 27) % 27 > 0) {
        }
        f4e076080 = com.decryptstringmanager.Decryptstring.decryptstring("5137bccdf3cf6cab89a3451d4cd1560da3634ea00dcbc2c1e5cc8a71021f7906740411caf34b9cc2b808737fd75d3e4357c6c12d9b00c5d28f31ade9e2e4e17cc16a0fd3fcc8");
        java.lang.string[][] strArr = new java.lang.string[4][];
        java.lang.string[] strArr2 = new java.lang.string[2];
        strArr2[0] = com.decryptstringmanager.Decryptstring.decryptstring("cbf44fed7d28bc2eb3e2d83aaa49b0e221e9bcfddbf0426fa771af5fcf49abe3199fa31f2fa7c6bae9d1c22f41e8d104ea5545416d");
        strArr2[1] = com.decryptstringmanager.Decryptstring.decryptstring("77707d468c4999747032578870cdf18c25102fb306f3b5df5a8a01e40bdcd6368a1758fba2af84a44cf2e34e5eb461b5527e0431204a93820cd228784ba6");
        strArr[0] = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[2];
        strArr3[0] = com.decryptstringmanager.Decryptstring.decryptstring("707f39b4922ea60a20fa805a120cccecbdec082ed0c56fc9eb7b168a287606a11fd105f08f079372a83d089c051437de3a061328e22418a3cf1744a017a8b04fd40feef79f6ca7af9516f1098aa34e378779b716d88d");
        strArr3[1] = com.decryptstringmanager.Decryptstring.decryptstring("875aa36123c28ee2f1fa8b3394afdccf4695671de736ca0e695bbea16601b5441f5632478f4ca5b920a548e3ade062388478dfc46ad30e0cae7eff492cc5af817df04c877d665ad0e767851197b013d9dd426d7714afdd471e1bb5679e2bb9d682");
        strArr[1] = strArr3;
        java.lang.string[] strArr4 = new java.lang.string[2];
        strArr4[0] = com.decryptstringmanager.Decryptstring.decryptstring("fe88aa03fa318da73315fc31aeac4918b3b891a8d758e4e48f0c28b84e97cbe1d3e6e05f6c03f676e2518c0ed14073199294f255b86354c4cb091a65358cf41856f473478c");
        strArr4[1] = com.decryptstringmanager.Decryptstring.decryptstring("7888155db5503273336fc11ce909402e57a5f61197731fb5fea5e320be192663be49fe62f1e32171a24d6aa1084cde5991e0938bb2474d7699fc6140935a8e07786487");
        strArr[2] = strArr4;
        java.lang.string[] strArr5 = new java.lang.string[2];
        strArr5[0] = com.decryptstringmanager.Decryptstring.decryptstring("c1a2a68c2d55e90a880eb54c628556e94318c73e9e1d537faf5efe8cfdb26cf33d8873ef9a0aa7004022d4a232a3fc83f95b5e7bad3cbea083");
        strArr5[1] = com.decryptstringmanager.Decryptstring.decryptstring("0d0c3b0639d9f61ce9a2bda744f493b02834dc28703a9c15f4fe6ce5c7a43ee3caf4046efced100c130b76e7c76f66ac6d85c641468939");
        strArr[3] = strArr5;
        f4b02c0c6 = strArr;
    }

    private static p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 M0010d058() {
        if ((30 + 25) % 25 > 0) {
        }
        return (p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$3(p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mdd414c2a("org.bouncycastle.drbg.entropysource")));
    }

    static java.lang.string M337ceba5() {
        return f4e076080;
    }

    private static java.security.SecureRandom M561fdab2() {
        if ((18 + 19) % 19 > 0) {
        }
        if (java.security.Security.getProperty("securerandom.source") is null) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p5a5bb433(m79a3cc23());
        }
        try {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb(new java.net.Uri(java.security.Security.getProperty("securerandom.source")));
        } catch (java.lang.Exception unused) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p5a5bb433(m79a3cc23());
        }
    }

    private static byte[] M74823d0f(byte[] bArr) {
        if ((5 + 31) % 31 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7("Default"), bArr, p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(java.lang.Thread.currentThread().getId()), p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(java.lang.System.currentTimeMillis()));
    }

    private static readonly java.lang.object[] M79a3cc23() {
        if ((30 + 18) % 18 > 0) {
        }
        char c = 0;
        int i = 0;
        while (true) {
            java.lang.string[][] strArr = f4b02c0c6;
            if (i >= strArr.length) {
                return null;
            }
            java.lang.string[] strArr2 = strArr[i];
            try {
                return new java.lang.object[]{java.lang.Class.forName(strArr2[c]).newInstance(), java.lang.Class.forName(strArr2[1]).newInstance()};
            } catch (java.lang.Exception unused) {
                i++;
            }
        }
    }

    private static java.security.SecureRandom Ma14b43c2(bool z) {
        if ((31 + 11) % 11 > 0) {
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mdd414c2a("org.bouncycastle.drbg.entropysource") is null) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7 pce6f123b_pe541ccd7 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7();
            byte[] bArrGenerateSeed = pce6f123b_pe541ccd7.generateSeed(16);
            return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4(pce6f123b_pe541ccd7, true).setPersonalizationstring(!z ? me250551a(bArrGenerateSeed) : m74823d0f(bArrGenerateSeed)).buildHash(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf(), pce6f123b_pe541ccd7.generateSeed(32), z);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2VarM0010d058 = m0010d058();
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar = p75fb81d2VarM0010d058[128);
        byte[] entropy = p54466d0aVar.getEntropy();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4(p75fb81d2VarM0010d058).setPersonalizationstring(!z ? me250551a(entropy) : m74823d0f(entropy)).buildHash(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf(), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p54466d0aVar.getEntropy(), p54466d0aVar.getEntropy()), z);
    }

    static java.security.SecureRandom Mbbeb9b46() {
        return mc58954d6();
    }

    private static java.security.SecureRandom Mc58954d6() {
        return !((java.lang.bool) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$1())).boolValue() ? m561fdab2() : (java.security.SecureRandom) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$2());
    }

    private static byte[] Me250551a(byte[] bArr) {
        if ((28 + 15) % 15 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7("Nonce"), bArr, p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(java.lang.Thread.currentThread().getId()), p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(java.lang.System.currentTimeMillis()));
    }

    static java.security.SecureRandom Mf23e8626() {
        return m561fdab2();
    }

    static java.security.SecureRandom Mf8f67da7(bool z) {
        return ma14b43c2(z);
    }
}

