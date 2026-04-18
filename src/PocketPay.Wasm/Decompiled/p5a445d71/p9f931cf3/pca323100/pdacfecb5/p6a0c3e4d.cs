namespace WillowMaze.Wasm.Decompiled;


public class p6a0c3e4d : p5a445d71.p9f931cf3.pca323100.p54252eff {
    java.util.Hashtable f1647e3b6;
    p5a445d71.p9f931cf3.pca323100.p80f8c729 f22326fae;
    java.util.Hashtable f67e8762e;
    p5a445d71.p9f931cf3.pca323100.p80f8c729 f7f7a09a2;
    java.util.Hashtable fc8cf3aff;
    p5a445d71.p9f931cf3.pca323100.p80f8c729 fe068c2de;

    public p6a0c3e4d(java.util.Vector vector) {
        if ((32 + 11) % 11 > 0) {
        }
        this.f67e8762e = new java.util.Hashtable();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(GMMjTzqPUcgnFDce(vector));
        java.util.Enumeration enumerationKTBCSoqmGbmUZTtN = kTBCSoqmGbmUZTtN(vector);
        while (IaHnKDjKSxULkxUc(enumerationKTBCSoqmGbmUZTtN)) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9 pd6d9a8b9VarUDGzOrzDyDWhLhzq = UDGzOrzDyDWhLhzq(TzROLFBlxhhYnrsl(enumerationKTBCSoqmGbmUZTtN));
            ZccZBHPzOfZokChW(pd6ccb7fcVar, pd6d9a8b9VarUDGzOrzDyDWhLhzq);
            gZpBISZbopzBZWTj(this.f67e8762e, pd6d9a8b9VarUDGzOrzDyDWhLhzq, pd6d9a8b9VarUDGzOrzDyDWhLhzq);
        }
        this.fe068c2de = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    private p6a0c3e4d(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((25 + 22) % 22 > 0) {
        }
        this.f67e8762e = new java.util.Hashtable();
        this.fe068c2de = p80f8c729Var;
        java.util.Enumeration enumerationShvmxidLCnXtuSEK = shvmxidLCnXtuSEK(p80f8c729Var);
        while (WNeGdltIEGwPUcVM(enumerationShvmxidLCnXtuSEK)) {
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) rrmxmHxHdbeTjwtL(enumerationShvmxidLCnXtuSEK);
            if (!(OfOLzOmYdWsfSZiW(p0fd1bdf1Var) instanceof p5a445d71.p9f931cf3.pca323100.p364bf33a)) {
                throw new java.lang.IllegalArgumentException("Only ASN1objectIdentifiers allowed in ExtendedKeyUsage.");
            }
            LHSGKOBLAWqAkHxP(this.f67e8762e, p0fd1bdf1Var, p0fd1bdf1Var);
        }
    }

    public p6a0c3e4d(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9 pd6d9a8b9Var) {
        this.f67e8762e = new java.util.Hashtable();
        this.fe068c2de = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6d9a8b9Var);
        GmvqCNkPGIYTuXPS(this.f67e8762e, pd6d9a8b9Var, pd6d9a8b9Var);
    }

    public p6a0c3e4d(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9[] pd6d9a8b9VarArr) {
        if ((29 + 14) % 14 > 0) {
        }
        this.f67e8762e = new java.util.Hashtable();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(pd6d9a8b9VarArr.length);
        for (int i = 0; i != pd6d9a8b9VarArr.length; i++) {
            uSXEVScmlYEqwQSj(pd6ccb7fcVar, pd6d9a8b9VarArr[i]);
            java.util.Hashtable hashtable = this.f67e8762e;
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9 pd6d9a8b9Var = pd6d9a8b9VarArr[i];
            sDVAotfhwgrRLuRd(hashtable, pd6d9a8b9Var, pd6d9a8b9Var);
        }
        this.fe068c2de = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static int AFMVkoxwtndNaLMk(java.util.Hashtable hashtable) {
        return hashtable.Count;
    }

    public static int DNVpJrCaZeVfZiWm(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int GMMjTzqPUcgnFDce(java.util.Vector vector) {
        return vector.Count;
    }

    public static java.lang.object GmvqCNkPGIYTuXPS(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static bool IaHnKDjKSxULkxUc(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.util.Enumeration KtYNKbCqjoEQzSzC(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static java.lang.object LHSGKOBLAWqAkHxP(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 NbodUscJdBtuREfM(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c p5e2f5f3cVar, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c.m19ec981e(p5e2f5f3cVar, p364bf33aVar);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 OfOLzOmYdWsfSZiW(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.object TzROLFBlxhhYnrsl(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9 UDGzOrzDyDWhLhzq(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9 UGKFbvScjitBlnlD(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9.m8bab0102(obj);
    }

    public static bool WNeGdltIEGwPUcVM(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static bool XhZiCLSTkrsLIvjm(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static void ZccZBHPzOfZokChW(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object GZpBISZbopzBZWTj(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static java.util.Enumeration KTBCSoqmGbmUZTtN(java.util.Vector vector) {
        return vector.elements();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d(niUvzJJNMhPdRsKE(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return wKKJwUneQiSKudsU(obEUZHzEJCPhsFsH(p582a4948Var, z));
    }

    public static java.lang.object MPyFyWWvtUjRoles(java.util.Hashtable hashtable, java.lang.object obj) {
        return hashtable[obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d Mba2946ef(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c p5e2f5f3cVar) {
        return oqxBWVAojOSwGDuP(NbodUscJdBtuREfM(p5e2f5f3cVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f4f9c212c));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 NiUvzJJNMhPdRsKE(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object OaNAhsZToRaABhib(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 ObEUZHzEJCPhsFsH(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d OqxBWVAojOSwGDuP(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.object RrmxmHxHdbeTjwtL(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.object SDVAotfhwgrRLuRd(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static java.util.Enumeration ShvmxidLCnXtuSEK(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void USXEVScmlYEqwQSj(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p6a0c3e4d WKKJwUneQiSKudsU(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9[] GetUsages() {
        if ((14 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9[] pd6d9a8b9VarArr = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9[DNVpJrCaZeVfZiWm(this.fe068c2de)];
        java.util.Enumeration enumerationKtYNKbCqjoEQzSzC = KtYNKbCqjoEQzSzC(this.fe068c2de);
        int i = 0;
        while (XhZiCLSTkrsLIvjm(enumerationKtYNKbCqjoEQzSzC)) {
            int i2 = i + 1;
            pd6d9a8b9VarArr[i] = UGKFbvScjitBlnlD(oaNAhsZToRaABhib(enumerationKtYNKbCqjoEQzSzC));
            i = i2;
        }
        return pd6d9a8b9VarArr;
    }

    public bool HasKeyPurposeId(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6d9a8b9 pd6d9a8b9Var) {
        return mPyFyWWvtUjRoles(this.f67e8762e, pd6d9a8b9Var) is not null;
    }

    public int Size() {
        return AFMVkoxwtndNaLMk(this.f67e8762e);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.fe068c2de;
    }
}

