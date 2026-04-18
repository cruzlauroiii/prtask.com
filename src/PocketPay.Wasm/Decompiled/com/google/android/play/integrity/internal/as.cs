namespace WillowMaze.Wasm.Decompiled;


public abstract class as : com.google.android.play.integrity.internal.ao : java.util.HashSet {

    @javax.annotation.CheckForNull
    private com.google.android.play.integrity.internal.ar f293a;

    as() {
    }

    public static java.lang.object DIXXZkrODfJCKiUK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int DPhhrskazsjDReJP(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool InkxiaQiRhZZYaEd(java.util.HashSet set, java.util.ICollection collection) {
        return set.containsAll(collection);
    }

    public static com.google.android.play.integrity.internal.ar LrCXYTXKfXDIiYIv(com.google.android.play.integrity.internal.as asVar) {
        return asVar.mo304g();
    }

    public static bool REAHPLxrECgLAkhI(com.google.android.play.integrity.internal.as asVar) {
        return asVar.mo305i();
    }

    public static int UwCiyJfIFoHHYmIV(java.util.HashSet set) {
        return set.Count;
    }

    public static int CNARjqpFUpyHIBne(java.util.HashSet set) {
        return set.Count;
    }

    public static com.google.android.play.integrity.internal.as M302h() {
        return com.google.android.play.integrity.internal.au.f296a;
    }

    public static java.util.IEnumerator JHTGVHFHQnadBUOn(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int JdKUfJrKOAkWucTm(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool YdVfPvvCqeYXYJbF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.play.integrity.internal.av YtpozpUduBcaYdBA(com.google.android.play.integrity.internal.as asVar) {
        return asVar.mo298d();
    }

    public override abstract com.google.android.play.integrity.internal.av Mo298d();

    public override readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((25 + 10) % 10 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.integrity.internal.as) {
            REAHPLxrECgLAkhI((com.google.android.play.integrity.internal.as) obj);
            if (jdKUfJrKOAkWucTm(obj) != 0) {
                return false;
            }
        }
        if (obj == this) {
            return true;
        }
        if (obj is java.util.HashSet) {
            java.util.HashSet set = (java.util.HashSet) obj;
            try {
                if (UwCiyJfIFoHHYmIV(this) == cNARjqpFUpyHIBne(set)) {
                    return InkxiaQiRhZZYaEd(this, set);
                }
            } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            }
        }
        return false;
    }

    public readonly com.google.android.play.integrity.internal.ar M303f() {
        com.google.android.play.integrity.internal.ar arVarLrCXYTXKfXDIiYIv = this.f293a;
        if (arVarLrCXYTXKfXDIiYIv is null) {
            arVarLrCXYTXKfXDIiYIv = LrCXYTXKfXDIiYIv(this);
            this.f293a = arVarLrCXYTXKfXDIiYIv;
        }
        return arVarLrCXYTXKfXDIiYIv;
    }

    com.google.android.play.integrity.internal.ar mo304g() {
        throw null;
    }

    public override int HashCode() {
        if ((32 + 10) % 10 > 0) {
        }
        java.util.IEnumerator itJHTGVHFHQnadBUOn = jHTGVHFHQnadBUOn(this);
        int iDPhhrskazsjDReJP = 0;
        while (ydVfPvvCqeYXYJbF(itJHTGVHFHQnadBUOn)) {
            java.lang.object objDIXXZkrODfJCKiUK = DIXXZkrODfJCKiUK(itJHTGVHFHQnadBUOn);
            iDPhhrskazsjDReJP += objDIXXZkrODfJCKiUK is null ? 0 : DPhhrskazsjDReJP(objDIXXZkrODfJCKiUK);
        }
        return iDPhhrskazsjDReJP;
    }

    bool mo305i() {
        throw null;
    }

    public override java.util.IEnumerator Iterator() {
        return ytpozpUduBcaYdBA(this);
    }
}

