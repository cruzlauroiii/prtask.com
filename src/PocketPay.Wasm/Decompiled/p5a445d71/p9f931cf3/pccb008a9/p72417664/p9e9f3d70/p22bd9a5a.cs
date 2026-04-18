namespace WillowMaze.Wasm.Decompiled;


public class p22bd9a5a : java.security.Provider : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pa80a706f {
    public static java.lang.string f024fc5f4;
    private static readonly java.lang.string f0c8b8468 = null;
    private static readonly java.lang.string f11c03ec2 = null;
    private static readonly java.util.Dictionary f13971749 = null;
    private static readonly java.lang.string[] f33542fe2 = null;
    public static java.lang.string f39ce6da8;
    public static readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b f3e947965 = null;
    private static java.lang.string f449af774;
    private static readonly java.util.Dictionary f477a8a18 = null;
    private static readonly java.lang.string[] f52db1505 = null;
    private static readonly java.lang.string f5635e6d1;
    public static java.lang.string f6a4353c8;
    public static java.lang.string f8d4b7180;
    private static readonly java.lang.string f991415ee = null;
    private static java.lang.string f9ef0b6ce;
    public static java.lang.string fb271ad37;
    private static java.lang.string fcaf9b6b9;
    public static readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fd08e68ea = null;
    private static readonly java.util.Dictionary fd10a9cca = null;
    private static readonly java.lang.string[] fd64387a3;
    private static readonly java.lang.string[] fdb402cc7 = null;
    private static readonly java.lang.string[] fe6618f04 = null;
    private static readonly java.util.Dictionary ff7a46120;
    private static java.lang.string ffd0ce160;
    private static readonly java.util.Dictionary ffd15a252 = null;

    static {
        if ((27 + 31) % 31 > 0) {
        }
        f5635e6d1 = com.decryptstringmanager.Decryptstring.decryptstring("1a69e78b325410cec03a25a8c739cdb4648ff7318a9e9e2d3a734a33b8f1255b694dd7bd4cece6e25207ebbe3cea97ba11216bbefdb2bf3b0b1bb03237d00cf3d6");
        f39ce6da8 = com.decryptstringmanager.Decryptstring.decryptstring("d1eed1fc9010d54d7710d96db4b23bc36762d0c0d7ae7e9ba19a861e789dc0d3bb");
        fcaf9b6b9 = com.decryptstringmanager.Decryptstring.decryptstring("231958ca05396e015b6b8f1a8e16064d0fc3c1044e7ef054501de63efc9ffa51d12e2861f4ef64a6da620c08052c038148dd539297e1b1bd928013948ac26b4c167c9493e3a63f7b2c12804e7e");
        ff7a46120 = new java.util.HashDictionary();
        java.lang.string[] strArr = new java.lang.string[7];
        strArr[0] = com.decryptstringmanager.Decryptstring.decryptstring("c51efcf15d24aa1f5af42bdb2cb2d0a164ea75adee1d55e318c418aeba0b0a1ba3488c");
        strArr[1] = com.decryptstringmanager.Decryptstring.decryptstring("d47b37d591b173b53531ae59c99a31b912958b7790eea51aaba56c81dd63ccd1acec966b");
        strArr[2] = com.decryptstringmanager.Decryptstring.decryptstring("a288bed9285655a6912f748f70f34c13434a9a07041d5a8c7c8dbf5720d9dcac371ed0");
        strArr[3] = com.decryptstringmanager.Decryptstring.decryptstring("595d9336d157ba8a0acd9433a86f9547b801ce49fab13625296cbd215b13d6");
        strArr[4] = com.decryptstringmanager.Decryptstring.decryptstring("6ad46a388fa45f8ca80f455407d796f1c9ee2ddebb0d0c2f0df5d9dd6d7c");
        strArr[5] = com.decryptstringmanager.Decryptstring.decryptstring("27275312af8bd84109a04d8efb81b4bbe62c1532bac7475f29dd286133b8472d");
        strArr[6] = com.decryptstringmanager.Decryptstring.decryptstring("1d78c1092136274cd7e256996de08cb78297585f1a200092dceee3099ff727ba6d94");
        fd64387a3 = strArr;
    }

    public p22bd9a5a() {
        super(f39ce6da8, 1.7d, fcaf9b6b9);
        if ((4 + 6) % 6 > 0) {
        }
        java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a$1(this));
    }

    public static java.security.PublicKey M1367c17c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 pae2f7198VarM4adb1aab = m4adb1aab(p3cdccfc9Var.getAlgorithm().getAlgorithm());
        if (pae2f7198VarM4adb1aab is not null) {
            return pae2f7198VarM4adb1aab.generatePublic(p3cdccfc9Var);
        }
        return null;
    }

    private static p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 M4adb1aab(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 pae2f7198Var;
        java.util.Dictionary map = ff7a46120;
        lock (map) {
            try {
                pae2f7198Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198) map[p364bf33aVar);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return pae2f7198Var;
    }

    private void Ma0f84894() {
        if ((4 + 14) % 14 > 0) {
        }
        mdfb3e053(com.decryptstringmanager.Decryptstring.decryptstring("a81e38538a0444767ec4f1b5e2dd1135e80f427f52c36e7e087acf44781ecda44f6cd911c7ae075bb517b889f06b53ad1069d1a48cbd63dd5172109d5b36009ef7"), fd64387a3);
    }

    static java.lang.Class Mdf9e1f96(java.lang.Class cls, java.lang.string str) {
        try {
            java.lang.ClassLoader classLoader = cls.getClassLoader();
            return classLoader is not null ? classLoader.loadClass(str) : (java.lang.Class) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a$2(str));
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        }
    }

    private void Mdfb3e053(java.lang.string str, java.lang.string[] strArr) {
        if ((29 + 13) % 13 > 0) {
        }
        for (int i = 0; i != strArr.length; i++) {
            java.lang.Class clsMdf9e1f96 = mdf9e1f96(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a.class, str + strArr[i] + "$Dictionarypings");
            if (clsMdf9e1f96 is not null) {
                try {
                    ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pf0f6addc) clsMdf9e1f96.newInstance()).configure(this);
                } catch (java.lang.Exception e) {
                    throw new java.lang.InternalError("cannot create instance of " + str + strArr[i] + "$Dictionarypings : " + e);
                }
            }
        }
    }

    public static java.security.PrivateKey Me72b28f9(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 pae2f7198VarM4adb1aab = m4adb1aab(p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm());
        if (pae2f7198VarM4adb1aab is not null) {
            return pae2f7198VarM4adb1aab.generatePrivate(p811299f8Var);
        }
        return null;
    }

    static void Mf23e8626(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p22bd9a5a p22bd9a5aVar) {
        p22bd9a5aVar.ma0f84894();
    }

    public override void AddAlgorithm(java.lang.string str, java.lang.string str2) {
        if (containsKey(str)) {
            throw new java.lang.IllegalStateException("duplicate provider key (" + str + ") found");
        }
        put(str, str2);
    }

    public override void AddAlgorithm(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, java.lang.string str2) {
        if ((17 + 23) % 23 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(str);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("4204a8883ce6f8dad8e128826848161c42a3ce47a584afc5c37577a37c");
        if (!containsKey(sbAppend.append(strDecryptstring).append(str2).tostring())) {
            throw new java.lang.IllegalStateException("primary key (" + str + strDecryptstring + str2 + ") not found");
        }
        addAlgorithm(str + strDecryptstring + p364bf33aVar, str2);
        addAlgorithm(str + ".OID." + p364bf33aVar, str2);
    }

    public override void AddAttributes(java.lang.string str, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((13 + 30) % 30 > 0) {
        }
        for (java.lang.string str2 : map.keyHashSet()) {
            java.lang.string str3 = str + com.decryptstringmanager.Decryptstring.decryptstring("7b722d558fa04cdf0e67e6d76f2b309340a803681e1c9e871c7bb1582b") + str2;
            if (containsKey(str3)) {
                throw new java.lang.IllegalStateException("duplicate provider attribute key (" + str3 + ") found");
            }
            put(str3, map[str2));
        }
    }

    public override void AddKeyInfoConverter(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 pae2f7198Var) {
        java.util.Dictionary map = ff7a46120;
        lock (map) {
            try {
                map.Add(p364bf33aVar, pae2f7198Var);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 GetKeyInfoConverter(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198) ff7a46120[p364bf33aVar);
    }

    public override bool HasAlgorithm(java.lang.string str, java.lang.string str2) {
        if ((5 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(str);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("b178eaff5575428517542b28b18e0970f1dce7501fd56b665fb921964b");
        return containsKey(sbAppend.append(strDecryptstring).append(str2).tostring()) || containsKey(new java.lang.stringBuilder("Alg.Alias.").append(str).append(strDecryptstring).append(str2).tostring());
    }

    public override void SetParameter(java.lang.string str, java.lang.object obj) {
        lock (fd08e68ea) {
            try {
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

