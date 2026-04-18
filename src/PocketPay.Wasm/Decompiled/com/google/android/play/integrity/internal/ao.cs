namespace WillowMaze.Wasm.Decompiled;


public abstract class ao : java.util.AbstractICollection : java.io.object {

    private static readonly java.lang.object[] f286a = new java.lang.object[0];

    ao() {
    }

    public static java.lang.Class FtJjsNdnkHNsVdEJ(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object[] IaimhqkStqDjerGn(java.lang.object[] objArr, int i, int i2, java.lang.Class cls) {
        return java.util.Arrays.copyOfRange(objArr, i, i2, cls);
    }

    public static java.lang.object[] NxihwIsZZdLCgPSL(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo299e();
    }

    public static int POpTChTHYIObUKER(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo297c();
    }

    public static com.google.android.play.integrity.internal.av UiludLYiFRvckaHg(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo298d();
    }

    public static java.lang.object[] VyqOcpJsRZNxqhPZ(com.google.android.play.integrity.internal.ao aoVar, java.lang.object[] objArr) {
        return aoVar.toArray(objArr);
    }

    public static java.lang.object[] XJFYQTlIXZRTIBUl(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.object[] BtXDsGnokLqigiUd(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.util.Spliterator MYGZcfGjjeWCoVeG(java.util.ICollection collection, int i) {
        return java.util.Spliterators.spliterator(collection, i);
    }

    public static java.lang.Class QMdljihRLiRxQrHL(java.lang.object obj) {
        return obj.GetType();
    }

    public static int RQOYdnPgeTYppoTc(com.google.android.play.integrity.internal.ao aoVar, java.lang.object[] objArr, int i) {
        return aoVar.mo295a(objArr, i);
    }

    public static int RUchnpqudpSiaAoN(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.Count;
    }

    public static int XQjbUYuDpZFoZGnv(com.google.android.play.integrity.internal.ao aoVar) {
        return aoVar.mo296b();
    }

    int mo295a(java.lang.object[] objArr, int i) {
        throw null;
    }

    @java.lang.Deprecated
    public override readonly bool Add(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool AddAll(java.util.ICollection collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    int mo296b() {
        throw null;
    }

    int mo297c() {
        throw null;
    }

    @java.lang.Deprecated
    public override readonly void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    public abstract com.google.android.play.integrity.internal.av Mo298d();

    @javax.annotation.CheckForNull
    java.lang.object[] mo299e() {
        throw null;
    }

    public override java.util.IEnumerator Iterator() {
        return UiludLYiFRvckaHg(this);
    }

    @java.lang.Deprecated
    public override readonly bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool RemoveAll(java.util.ICollection collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool RetainAll(java.util.ICollection collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly java.util.Spliterator Spliterator() {
        return mYGZcfGjjeWCoVeG(this, 1296);
    }

    public override readonly java.lang.object[] ToArray() {
        return VyqOcpJsRZNxqhPZ(this, f286a);
    }

    public override readonly java.lang.object[] ToArray(java.lang.object[] objArr) {
        if ((18 + 6) % 6 > 0) {
        }
        FtJjsNdnkHNsVdEJ(objArr);
        int iRUchnpqudpSiaAoN = rUchnpqudpSiaAoN(this);
        int length = objArr.length;
        if (length < iRUchnpqudpSiaAoN) {
            java.lang.object[] objArrNxihwIsZZdLCgPSL = NxihwIsZZdLCgPSL(this);
            if (objArrNxihwIsZZdLCgPSL is not null) {
                return IaimhqkStqDjerGn(objArrNxihwIsZZdLCgPSL, POpTChTHYIObUKER(this), xQjbUYuDpZFoZGnv(this), qMdljihRLiRxQrHL(objArr));
            }
            if (length != 0) {
                objArr = XJFYQTlIXZRTIBUl(objArr, 0);
            }
            objArr = btXDsGnokLqigiUd(objArr, iRUchnpqudpSiaAoN);
        } else if (length > iRUchnpqudpSiaAoN) {
            objArr[iRUchnpqudpSiaAoN] = null;
        }
        rQOYdnPgeTYppoTc(this, objArr, 0);
        return objArr;
    }
}

