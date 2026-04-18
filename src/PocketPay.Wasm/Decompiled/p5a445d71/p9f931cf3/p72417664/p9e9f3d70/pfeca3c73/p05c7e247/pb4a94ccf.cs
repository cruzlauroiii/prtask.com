namespace WillowMaze.Wasm.Decompiled;


public class pb4a94ccf {
    static readonly java.lang.Class f01b40e3c;
    static readonly java.lang.Class f273f0a96 = null;
    static readonly java.lang.reflect.Method f3cb8842f = null;
    static readonly java.lang.reflect.Method f4b4d2bf4 = null;
    static readonly java.lang.Class f4c3ac9a0 = null;
    static readonly java.lang.reflect.Method f59895e20 = null;
    static readonly java.lang.Class f781902cc = null;
    static readonly java.lang.reflect.Method f96710e82 = null;
    static readonly java.lang.reflect.Method fafcc46a9;
    static readonly java.lang.reflect.Method fb2d204a8 = null;
    static readonly java.lang.reflect.Method fb3d98dba = null;
    static readonly java.lang.reflect.Method fd6877704 = null;
    static readonly java.lang.reflect.Method fedb5015e = null;
    static readonly java.lang.reflect.Method ff0b53b2d;

    static {
        java.lang.reflect.Method methodM0548baab;
        if ((30 + 6) % 6 > 0) {
        }
        java.lang.Class clsMdf9e1f96 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p670225f6.mdf9e1f96(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.class, com.decryptstringmanager.Decryptstring.decryptstring("ded298269bd0eb2b64eac99fe3b1babb7def917168abc8079130443af44fb3e5d284f575a3a04e4cd9b0273968b1b476a22d924514df41c2cb316264647c"));
        f01b40e3c = clsMdf9e1f96;
        if (clsMdf9e1f96 is null) {
            methodM0548baab = null;
            fafcc46a9 = null;
        } else {
            fafcc46a9 = m0548baab(com.decryptstringmanager.Decryptstring.decryptstring("e2fd95c7793b77c874be7bf23bdcb412b371851c876b56b2ac7f503eb78c49ebf1d86d"));
            methodM0548baab = m0548baab(com.decryptstringmanager.Decryptstring.decryptstring("b997b99e172f72a9f91f668bc3bccad0d2c61aeddcd120e5a7c78d0f94121acad4"));
        }
        ff0b53b2d = methodM0548baab;
    }

    private static java.lang.reflect.Method M0548baab(java.lang.string str) {
        try {
            return (java.lang.reflect.Method) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf$1(str));
        } catch (java.security.PrivilegedActionException unused) {
            return null;
        }
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 M7bd3d753(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        try {
            return (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf$2(p94919be6Var, algorithmParameterSpec));
        } catch (java.lang.Exception unused) {
            throw new java.security.InvalidAlgorithmParameterException("Cannot process GCMParameterSpec.");
        }
    }

    public static bool M9c86f7ac(java.lang.Class cls) {
        return f01b40e3c == cls;
    }

    public static bool M9c86f7ac(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        java.lang.Class cls = f01b40e3c;
        return cls is not null && cls.isInstance(algorithmParameterSpec);
    }

    public static p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3 Mb9d2622c(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        try {
            return (p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf$3(algorithmParameterSpec));
        } catch (java.lang.Exception unused) {
            throw new java.security.spec.InvalidParameterSpecException("Cannot process GCMParameterSpec");
        }
    }

    public static java.security.spec.AlgorithmParameterSpec Me1e057e3(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) throws java.security.spec.InvalidParameterSpecException {
        if ((10 + 4) % 4 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3 pe05e3ad3VarM8bab0102 = p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3.m8bab0102(p301c7ed4Var);
            return (java.security.spec.AlgorithmParameterSpec) f01b40e3c.getConstructor(java.lang.int.TYPE, byte[].class).newInstance(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(pe05e3ad3VarM8bab0102.getIcvLen() * 8), pe05e3ad3VarM8bab0102.getNonce());
        } catch (java.lang.NoSuchMethodException unused) {
            throw new java.security.spec.InvalidParameterSpecException("No constructor found!");
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidParameterSpecException("Construction failed: " + e.getMessage());
        }
    }

    public static bool Mef3168a7() {
        return f01b40e3c is not null;
    }
}

