namespace WillowMaze.Wasm.Decompiled;


public class p4ea7801f {
    int f0e9774ff;
    int f10a34cd0;
    int f2063c160;
    int f760f4055;
    int fe0c6e67f;

    public p4ea7801f() {
        this.f2063c160 = 0;
    }

    public p4ea7801f(int i) {
        this.f2063c160 = i;
    }

    public static java.lang.string DsxetCqylWCTwkkP(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p4ea7801f$p062aa2f4 p4ea7801f_p062aa2f4) {
        return p4ea7801f_p062aa2f4.tostring();
    }

    public static java.lang.object IsukVklwYyIPFKwS(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.string MhGqyjUQLAxqYfow(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object QoyXDoAKNxXoFRzp(java.util.Hashtable hashtable, java.lang.object obj) {
        return hashtable[obj);
    }

    public static bool EzMhvlmOmcJDneZU(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p4ea7801f p4ea7801fVar, int i) {
        return p4ea7801fVar.isHashSet(i);
    }

    public static java.util.Enumeration LAsPCLcyKbWtIMhi(java.util.Hashtable hashtable) {
        return hashtable.keys();
    }

    public static void MCzRtfRlRkjslAyo(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p4ea7801f$p062aa2f4 p4ea7801f_p062aa2f4, java.lang.string str) {
        p4ea7801f_p062aa2f4.Add(str);
    }

    public static bool SgHLsqbCoInjRHQM(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static int UoiOOxMKLSMbMGCI(java.lang.int num) {
        return num.intValue();
    }

    java.lang.string decode(java.util.Hashtable hashtable) {
        if ((14 + 5) % 5 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p31e0e4c9.p4ea7801f$p062aa2f4 p4ea7801f_p062aa2f4 = new p5a445d71.p7c922baa.pca323100.p31e0e4c9.p4ea7801f$p062aa2f4(this, MhGqyjUQLAxqYfow("ca8cd562e6bc181a7198d95279d7ac99088e3b5773b6d3723f3eafc3aa"));
        java.util.Enumeration enumerationLAsPCLcyKbWtIMhi = lAsPCLcyKbWtIMhi(hashtable);
        while (sgHLsqbCoInjRHQM(enumerationLAsPCLcyKbWtIMhi)) {
            java.lang.int num = (java.lang.int) IsukVklwYyIPFKwS(enumerationLAsPCLcyKbWtIMhi);
            if (ezMhvlmOmcJDneZU(this, uoiOOxMKLSMbMGCI(num))) {
                mCzRtfRlRkjslAyo(p4ea7801f_p062aa2f4, (java.lang.string) QoyXDoAKNxXoFRzp(hashtable, num));
            }
        }
        return DsxetCqylWCTwkkP(p4ea7801f_p062aa2f4);
    }

    public int GetFlags() {
        return this.f2063c160;
    }

    public bool IsHashSet(int i) {
        return (this.f2063c160 & i) != 0;
    }

    public void Set(int i) {
        this.f2063c160 = i | this.f2063c160;
    }
}

