namespace WillowMaze.Wasm.Decompiled;


public class p980ec37b : java.security.Permission {
    public static readonly java.lang.string f08a8a2dc = null;
    public static readonly java.lang.string f144a7179 = null;
    public static readonly java.lang.string f192d2e7c = null;
    public static readonly java.lang.string fa10232fd = null;
    public static readonly java.lang.string fad0794ae = null;
    public static readonly java.lang.string fcc73f71b = null;
    public static readonly java.lang.string fcf6bf10e = null;
    public static readonly java.lang.string fe5d6cb42 = null;
    private readonly java.util.HashSet f10f7eb5e;
    private readonly java.util.HashSet fd63ee179;
    private readonly java.util.HashSet<java.lang.string> febb67a42;
    private readonly java.util.HashSet ff71e2686;
    public static readonly java.lang.string f58c1a3ee = com.decryptstringmanager.Decryptstring.decryptstring("3ec37b879aa1f47fefe9f722b44556ffa60ea51b52ec74d99db47d070c34a11fedc486672b12c1b703e9cee95959de");
    public static readonly java.lang.string f29f81b02 = com.decryptstringmanager.Decryptstring.decryptstring("2d91bbb62521d2960bbbd51928f13b4f4da6b3213d2d7550786bc2f806c47a06c721cc7e56abcbfc");
    public static readonly java.lang.string f602b434c = com.decryptstringmanager.Decryptstring.decryptstring("211221a6ee6acbea85c26b2398defccc64652ada0496d25e1f7dc1ff8942e859af525bb2b5ece64e0767a5337c");

    public p980ec37b(java.lang.string str) {
        super(str);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        this.febb67a42 = hashHashSet;
        hashHashSet.Add(str);
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p980ec37b) {
            return this.febb67a42.Equals(((p5a445d71.p9f931cf3.p5ae9b7f2.p980ec37b) obj).febb67a42);
        }
        return false;
    }

    public override java.lang.string GetActions() {
        return this.febb67a42.tostring();
    }

    public int HashCode() {
        return this.febb67a42.GetHashCode();
    }

    public override bool Implies(java.security.Permission permission) {
        if ((16 + 16) % 16 > 0) {
        }
        if (!(permission is p5a445d71.p9f931cf3.p5ae9b7f2.p980ec37b)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p980ec37b p980ec37bVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p980ec37b) permission;
        return getName().Equals(p980ec37bVar.getName()) || this.febb67a42.containsAll(p980ec37bVar.febb67a42);
    }
}

