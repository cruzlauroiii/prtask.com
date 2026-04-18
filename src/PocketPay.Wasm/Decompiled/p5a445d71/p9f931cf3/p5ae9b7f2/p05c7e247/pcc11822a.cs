namespace WillowMaze.Wasm.Decompiled;


public class pcc11822a {
    private static readonly java.lang.string f0199ded6 = null;
    private static readonly java.lang.string f391b2370 = null;
    private static readonly java.lang.string f5e5616c8 = null;
    private static readonly java.lang.string f608f82c5 = null;
    private static readonly java.lang.string f9dc27954 = null;
    private static readonly java.lang.string fa3c5b285 = null;
    private static readonly java.lang.string fc82cb104 = null;
    private static readonly java.lang.string fe558b7b9 = null;
    private static readonly java.lang.string fe71f0182 = com.decryptstringmanager.Decryptstring.decryptstring("2c105bbb2985f745f7c2242c0e92d8ccce16f4125831d7d729a7ca11cb129bcee6011b");
    private static readonly java.lang.string fb1870fa8 = com.decryptstringmanager.Decryptstring.decryptstring("026c1fc7a60419c140f471f242519dbdbfc6f85b589f548bc4c6e9ae8488df4177");
    private static readonly java.lang.string fb067cde4 = com.decryptstringmanager.Decryptstring.decryptstring("01fbd3c22cd6bf806cfdd084beee0a4c98d4044f956039c69f5191a33b8de41f528c603a4bed34");
    private static readonly java.lang.string f445d0434 = com.decryptstringmanager.Decryptstring.decryptstring("15ff1ad7d229a34d4ee8d84361bcdc9e2ee99e9ac3b5a35a1c6c701783fd7719f93100");

    private pcc11822a() {
    }

    public static byte[] M092fb0ff(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) throws java.io.IOException {
        if ((6 + 26) % 26 > 0) {
        }
        if (pcfffbc4aVar is null) {
            throw new java.lang.IllegalArgumentException("cipherParameters was null.");
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) {
            if (pcfffbc4aVar.isPrivate()) {
                throw new java.lang.IllegalArgumentException("RSAKeyParamaters was for encryption");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pcfffbc4aVar;
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06 paeb89c06Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06();
            paeb89c06Var.writestring(com.decryptstringmanager.Decryptstring.decryptstring("62f77f0235552c25d7fa3d912c555159ff7fd758e0ed3be7867788b6d8245d8d061b4e"));
            paeb89c06Var.writeBigNum(p753eae39Var.getExponent());
            paeb89c06Var.writeBigNum(p753eae39Var.getModulus());
            return paeb89c06Var.getbytes();
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06 paeb89c06Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06();
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pcfffbc4aVar;
            java.lang.string strM8bb214c8 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pae8830f7.m8bb214c8(pd16c2d8eVar.getParameters());
            if (strM8bb214c8 is null) {
                throw new java.lang.IllegalArgumentException("unable to derive ssh curve name for " + pd16c2d8eVar.getParameters().getCurve().GetType().getName());
            }
            paeb89c06Var2.writestring("ecdsa-sha2-" + strM8bb214c8);
            paeb89c06Var2.writestring(strM8bb214c8);
            paeb89c06Var2.writeBlock(pd16c2d8eVar.getQ().getEncoded(false));
            return paeb89c06Var2.getbytes();
        }
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a)) {
            if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1)) {
                throw new java.lang.IllegalArgumentException("unable to convert " + pcfffbc4aVar.GetType().getName() + " to private key");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06 paeb89c06Var3 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06();
            paeb89c06Var3.writestring(com.decryptstringmanager.Decryptstring.decryptstring("0ba6483476779c3b7b0df3f5f8cb2df3a55f8967e7cdd10c713086268a385e91a035f94fa726a7"));
            paeb89c06Var3.writeBlock(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) pcfffbc4aVar).getEncoded());
            return paeb89c06Var3.getbytes();
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a pf574193aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a) pcfffbc4aVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd parameters = pf574193aVar.getParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06 paeb89c06Var4 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06();
        paeb89c06Var4.writestring(com.decryptstringmanager.Decryptstring.decryptstring("2cc380c9ef9a48bac07a4d19ee931217a7e9276072ca6d2b5224546c7d038e73fabf0d"));
        paeb89c06Var4.writeBigNum(parameters.getP());
        paeb89c06Var4.writeBigNum(parameters.getQ());
        paeb89c06Var4.writeBigNum(parameters.getG());
        paeb89c06Var4.writeBigNum(pf574193aVar.getY());
        return paeb89c06Var4.getbytes();
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M5355d3b5(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594 p0402a594Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a p753eae39Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pf574193aVar;
        if ((30 + 21) % 21 > 0) {
        }
        java.lang.string string = p0402a594Var.readstring();
        if (com.decryptstringmanager.Decryptstring.decryptstring("8d9bfe6e89c48c0b8c0fdb3802cab8e70bb0104b2d0d4e98eaab8bfd5fa1c257f7bfc5").Equals(string)) {
            p753eae39Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, p0402a594Var.readBigNumPositive(), p0402a594Var.readBigNumPositive());
        } else {
            if (com.decryptstringmanager.Decryptstring.decryptstring("a27e24e845260105cf6e23aef5c7f86df21f60f01f928e8e6aba6fcabe245c19f6f6c2").Equals(string)) {
                pf574193aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(p0402a594Var.readBigNumPositive(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(p0402a594Var.readBigNumPositive(), p0402a594Var.readBigNumPositive(), p0402a594Var.readBigNumPositive()));
            } else if (string.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("260e3e94828f088b7a2a733af90cbcd6903066bafd68b93123be08af383669d9fd"))) {
                java.lang.string string2 = p0402a594Var.readstring();
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarMb83b9f17 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pae8830f7.mb83b9f17(string2);
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM2ac01a69 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pae8830f7.m2ac01a69(p364bf33aVarMb83b9f17);
                if (p35e46fcbVarM2ac01a69 is null) {
                    throw new java.lang.IllegalStateException("unable to find curve for " + string + " using curve name " + string2);
                }
                pf574193aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p35e46fcbVarM2ac01a69.getCurve().decodePoint(p0402a594Var.readBlock()), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVarMb83b9f17, p35e46fcbVarM2ac01a69));
            } else if (com.decryptstringmanager.Decryptstring.decryptstring("b1dfdb11dd2835f2e635774c1f1e840eaea307f974dc9cca32a4fb0219071793f1bd98779e6368").Equals(string)) {
                byte[] block = p0402a594Var.readBlock();
                if (block.length != 32) {
                    throw new java.lang.IllegalStateException("public key value of wrong length");
                }
                p753eae39Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1(block, 0);
            } else {
                p753eae39Var = null;
            }
            p753eae39Var = pf574193aVar;
        }
        if (p753eae39Var is null) {
            throw new java.lang.IllegalArgumentException("unable to parse key");
        }
        if (p0402a594Var.hasRemaining()) {
            throw new java.lang.IllegalArgumentException("decoded key has trailing data");
        }
        return p753eae39Var;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M5355d3b5(byte[] bArr) {
        return m5355d3b5(new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594(bArr));
    }
}

