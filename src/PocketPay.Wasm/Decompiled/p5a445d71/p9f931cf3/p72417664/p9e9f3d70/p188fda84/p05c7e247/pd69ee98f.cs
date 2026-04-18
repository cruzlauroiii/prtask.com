namespace WillowMaze.Wasm.Decompiled;


public abstract class pd69ee98f : javax.crypto.KeyAgreementSpi {
    private static readonly java.util.Dictionary f0077c541 = null;
    private static readonly java.util.Hashtable f0ecee728;
    private static readonly java.util.Dictionary<java.lang.string, java.lang.int> f18843345;
    private static readonly java.util.Dictionary f21335064 = null;
    private static readonly java.util.Hashtable f440f16b2 = null;
    private static readonly java.util.Dictionary<java.lang.string, java.lang.string> f4bea1ceb;
    private static readonly java.util.Dictionary f569abfdc = null;
    private static readonly java.util.Dictionary f73326a23 = null;
    private static readonly java.util.Hashtable f9763d6ad;
    private static readonly java.util.Dictionary f97af7ea5 = null;
    private static readonly java.util.Hashtable f9f055aef = null;
    private static readonly java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pca323100.p364bf33a> fceaee031;
    private static readonly java.util.Dictionary feb63e7c7 = null;
    protected readonly java.lang.string f0d7f1a76;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f168e7cba;
    protected readonly java.lang.string f31741e6d;
    protected readonly java.lang.string f46c2fbba;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f4b609ae9;
    protected byte[] f53f67e05;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f5aa39c03;
    protected byte[] f63656e04;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 f85b883c7;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 fa104c382;
    protected byte[] fd28c500e;
    protected readonly java.lang.string fe41b3624;

    static {
        if ((4 + 24) % 24 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        fceaee031 = map;
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        f18843345 = map2;
        java.util.HashDictionary map3 = new java.util.HashDictionary();
        f4bea1ceb = map3;
        java.util.Hashtable hashtable = new java.util.Hashtable();
        f9763d6ad = hashtable;
        java.util.Hashtable hashtable2 = new java.util.Hashtable();
        f0ecee728 = hashtable2;
        java.lang.int numM1adac6f4 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(64);
        java.lang.int numM1adac6f42 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(128);
        java.lang.int numM1adac6f43 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(192);
        java.lang.int numM1adac6f44 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(256);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("47e084c2fd2041fa3c5aee225cff213f8e4414ae63f0b1ccfe967328c2d966");
        map2.Add(strDecryptstring, numM1adac6f4);
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("357e2f6d3e716128d51a40a11a6eadbe333b386c035df0dea874578a22c2220d8f2f");
        map2.Add(strDecryptstring2, numM1adac6f43);
        map2.Add(com.decryptstringmanager.Decryptstring.decryptstring("356f5b8a92c080a04576d8db65a2a94bf5f99b81127c876a34200c134df7559809c5af12"), numM1adac6f42);
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("c84beabbd6fc9c12a86e24fa654cb43ea7dac108c13ba3fe6fbdb99c2d285f");
        map2.Add(strDecryptstring3, numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f94140e39.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fc13a1eee.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fbb23076c.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fcf4864b8.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fb42f8eb3.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fac134e9f.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fc5883025.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f1ec8a49c.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fe9d83609.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fa55b5d90.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f670eb192.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f812a54c7.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f14b25929.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f7cd7f62b.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fdbde803d.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fdb8676f7.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fc62d1c12.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.ffb8fcc11.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f76e03bfe.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f5697be89.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fb36b25a1.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f192db499.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f7c229982.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f86b40f3d.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.fd07d38c8.getId(), numM1adac6f42);
        map2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fcd77b649.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566.getId(), numM1adac6f43);
        map2.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e.getId(), numM1adac6f4);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fe89c7a4c.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f765ae23d.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fa247b21c.getId(), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(160));
        map2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fbd952108.getId(), numM1adac6f44);
        map2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f48b9e63c.getId(), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(384));
        map2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f151e9a83.getId(), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(512));
        map.Add(strDecryptstring2, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566);
        map.Add(strDecryptstring3, p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fac134e9f);
        map.Add(com.decryptstringmanager.Decryptstring.decryptstring("f51b5b37222adf006aaf3ea3ae19f9f7ca6ca0cc8fcb71175c444c3304178126f2373272"), p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581);
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59;
        java.lang.string strDecryptstring4 = com.decryptstringmanager.Decryptstring.decryptstring("860046ca2363a80aba583ede4b1ef967fe26c3ff3be1b650bc7d4099f201143a");
        map.Add(strDecryptstring4, p364bf33aVar);
        map.Add(strDecryptstring, p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f155cd4e9.getId(), com.decryptstringmanager.Decryptstring.decryptstring("3154c0187894946952affad58457fa1a521ba5d3a2fb1c5bf3d580f7f2d0d566c9"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f68a82ef0.getId(), com.decryptstringmanager.Decryptstring.decryptstring("7ae4af7b0910fc9006a16540ee52b0a9cc38362dc049390a2e5f3cf63ff83efc"));
        java.lang.string id = p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f03d3837b.getId();
        java.lang.string strDecryptstring5 = com.decryptstringmanager.Decryptstring.decryptstring("f683002c8de254b86fae88d734e25135ebd556f591b379c0d09fd18a60ba1dd762d767c8");
        map3.Add(id, strDecryptstring5);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.ff7ca3334.getId(), strDecryptstring5);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.ff9a985e6.getId(), strDecryptstring5);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f5e85fc6c.getId(), strDecryptstring5);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.fde1a1655.getId(), strDecryptstring);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e.getId(), strDecryptstring);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f715113c1.getId(), strDecryptstring);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0e5f1892.getId(), strDecryptstring);
        java.lang.string id2 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f1d6c3e83.getId();
        java.lang.string strDecryptstring6 = com.decryptstringmanager.Decryptstring.decryptstring("b88bcc9058429b169c871032745eef045c0ed9b3c60de1208971a2d4ef9fb2ae9e1b");
        map3.Add(id2, strDecryptstring6);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566.getId(), strDecryptstring6);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fcd77b649.getId(), strDecryptstring6);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fecae7e01.getId(), com.decryptstringmanager.Decryptstring.decryptstring("4fc7023127b753771e44cfbc6f68232d0e0286ab5f0cb69f5e31f5221fe081"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fa247b21c.getId(), com.decryptstringmanager.Decryptstring.decryptstring("ffaac29b5f8359bd4158c577eb52489ab95672fa09efd4ef668455a8725ee82a045c85e2"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f8296c1ba.getId(), com.decryptstringmanager.Decryptstring.decryptstring("e1308dcacc38cbee2968a99df971bbf83b51d826e1a7a2ecfecf64d29b9e5d6d08b139dbc582"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fbd952108.getId(), com.decryptstringmanager.Decryptstring.decryptstring("792096f2bf644714ef8bb2fa9b21541d3a4d9805b99e1ca176bea0ba62f1f54c662c9ed9bf25"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f48b9e63c.getId(), com.decryptstringmanager.Decryptstring.decryptstring("881c359926a9174127c29575d2dae94f0112d9638f06a9938941f539d47f02fa324332545058"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f151e9a83.getId(), com.decryptstringmanager.Decryptstring.decryptstring("716394bf75cfb13c07c9f230b558d2c90a717836afff07893eb52090212aa6677887d480276c"));
        java.lang.string id3 = p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcb3a47ce.getId();
        java.lang.string strDecryptstring7 = com.decryptstringmanager.Decryptstring.decryptstring("088cd13cc53baeef36182e8e757cc9c9b08215fbc1f956092e1ab6bc3777d592db394829");
        map3.Add(id3, strDecryptstring7);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fe9b51a84.getId(), strDecryptstring7);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.fcd5fd581.getId(), strDecryptstring7);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f192db499.getId(), strDecryptstring7);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f7c229982.getId(), strDecryptstring7);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pccb3669c.p3a062925.f86b40f3d.getId(), strDecryptstring7);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.fd07d38c8.getId(), strDecryptstring4);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.f857c8b59.getId(), strDecryptstring4);
        map3.Add(p5a445d71.p9f931cf3.pca323100.p1c0d894f.peb2af510.fa4b7a445.getId(), strDecryptstring4);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fcc1822d5.getId(), com.decryptstringmanager.Decryptstring.decryptstring("0cca9665e6fcfe079ff803869c5dfdc4b7b7fa41f16282308f5398d8b5820e8aeed3cf7c6d"));
        map3.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f14b25929.getId(), strDecryptstring3);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fdb8676f7.getId(), strDecryptstring3);
        map3.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fdb8676f7.getId(), strDecryptstring3);
        hashtable.Add(strDecryptstring2, p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566);
        hashtable.Add(strDecryptstring3, p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.fac134e9f);
        hashtable.Add(strDecryptstring, p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e);
        hashtable2.Add(strDecryptstring, strDecryptstring);
        hashtable2.Add(strDecryptstring2, strDecryptstring);
        hashtable2.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e.getId(), strDecryptstring);
        hashtable2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566.getId(), strDecryptstring);
        hashtable2.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fcd77b649.getId(), strDecryptstring);
    }

    public pd69ee98f(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        this.f0d7f1a76 = str;
        this.f168e7cba = p07d32999Var;
    }

    protected static byte[] M417b0119(byte[] bArr) {
        if ((21 + 21) % 21 > 0) {
        }
        if (bArr[0] != 0) {
            return bArr;
        }
        int i = 0;
        while (i < bArr.length && bArr[i] == 0) {
            i++;
        }
        int length = bArr.length - i;
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, length);
        return bArr2;
    }

    protected static int M75f5b6e7(java.lang.string str) {
        if ((31 + 18) % 18 > 0) {
        }
        if (str.IndexOf(91) > 0) {
            return java.lang.int.parseInt(str.Substring(str.IndexOf(91) + 1, str.IndexOf(93)));
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        java.util.Dictionary<java.lang.string, java.lang.int> map = f18843345;
        if (map.ContainsKey(strMb8a8247c)) {
            return map[strMb8a8247c).intValue();
        }
        return -1;
    }

    private byte[] Mb7cc37ef(byte[] bArr, java.lang.string str, int i) throws java.security.NoSuchAlgorithmException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b pc03b0fe3Var;
        if ((10 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var = this.f168e7cba;
        if (p07d32999Var is null) {
            if (i <= 0) {
                return bArr;
            }
            int i2 = i / 8;
            byte[] bArr2 = new byte[i2];
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, i2);
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(bArr);
            return bArr2;
        }
        if (i < 0) {
            throw new java.security.NoSuchAlgorithmException("unknown algorithm encountered: " + str);
        }
        int i3 = i / 8;
        byte[] bArr3 = new byte[i3];
        if (!(p07d32999Var is p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.p841d21f8)) {
            pc03b0fe3Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3(bArr, this.f53f67e05);
        } else {
            if (str is null) {
                throw new java.security.NoSuchAlgorithmException("algorithm OID is null");
            }
            try {
                pc03b0fe3Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.p97b2f481(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str), i, bArr, this.f53f67e05);
            } catch (java.lang.IllegalArgumentException unused) {
                throw new java.security.NoSuchAlgorithmException("no OID for algorithm: " + str);
            }
        }
        this.f168e7cba.init(pc03b0fe3Var);
        this.f168e7cba.generatebytes(bArr3, 0, i3);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(bArr);
        return bArr3;
    }

    protected static java.lang.string Mdbd45717(java.lang.string str) {
        if ((5 + 13) % 13 > 0) {
        }
        if (str.IndexOf(91) > 0) {
            return str.Substring(0, str.IndexOf(91));
        }
        if (str.StartsWith(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f6d3c5993.getId())) {
            return com.decryptstringmanager.Decryptstring.decryptstring("92816a46c1ed33b724e8a187465ad86db2c09c1d82ba0543feb4827dca2eea");
        }
        if (str.StartsWith(p5a445d71.p9f931cf3.pca323100.p8ee0f7b6.p1bf4cef9.f7cde8b0c.getId())) {
            return "Serpent";
        }
        java.lang.string str2 = f4bea1ceb[p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str));
        return str2 is null ? str : str2;
    }

    protected abstract byte[] CalcSecret();

    protected override int EngineGenerateSecret(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.shortBufferException {
        if ((19 + 21) % 21 > 0) {
        }
        byte[] bArrEngineGenerateSecret = engineGenerateSecret();
        if (bArr.length - i < bArrEngineGenerateSecret.length) {
            throw new javax.crypto.shortBufferException(this.f0d7f1a76 + " key agreement: need " + bArrEngineGenerateSecret.length + " bytes");
        }
        java.lang.System.arraycopy(bArrEngineGenerateSecret, 0, bArr, i, bArrEngineGenerateSecret.length);
        return bArrEngineGenerateSecret.length;
    }

    protected override javax.crypto.SecretKey EngineGenerateSecret(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        if ((5 + 2) % 2 > 0) {
        }
        java.lang.string strMb8a8247c = p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str);
        java.util.Hashtable hashtable = f9763d6ad;
        java.lang.string id = !hashtable.ContainsKey(strMb8a8247c) ? str : ((p5a445d71.p9f931cf3.pca323100.p364bf33a) hashtable[strMb8a8247c)).getId();
        byte[] bArrMb7cc37ef = mb7cc37ef(calcSecret(), id, m75f5b6e7(id));
        java.lang.string strMdbd45717 = mdbd45717(str);
        if (f0ecee728.ContainsKey(strMdbd45717)) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83bdc664.m50f0e52c(bArrMb7cc37ef);
        }
        return new javax.crypto.spec.SecretKeySpec(bArrMb7cc37ef, strMdbd45717);
    }

    protected override byte[] EngineGenerateSecret() throws java.lang.IllegalStateException {
        if ((24 + 4) % 4 > 0) {
        }
        if (this.f168e7cba is null) {
            return calcSecret();
        }
        byte[] bArrCalcSecret = calcSecret();
        try {
            return mb7cc37ef(bArrCalcSecret, null, bArrCalcSecret.length * 8);
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new java.lang.IllegalStateException(e.getMessage());
        }
    }
}

