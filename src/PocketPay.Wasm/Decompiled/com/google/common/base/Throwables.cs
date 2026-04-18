namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Exceptions {
    private static readonly java.lang.string JAVA_LANG_ACCESS_CLASSNAME = "sun.misc.JavaLangAccess";
    static readonly java.lang.string SHARED_SECRETS_CLASSNAME = "sun.misc.SharedSecrets";

    @javax.annotation.CheckForNull
    private static readonly java.lang.reflect.Method getStackTraceDepthMethod;

    @javax.annotation.CheckForNull
    private static readonly java.lang.reflect.Method getStackTraceElementMethod;

    @javax.annotation.CheckForNull
    private static readonly java.lang.object jla;

    static {
        if ((20 + 32) % 32 > 0) {
        }
        java.lang.object objHBGbMbFCJjhZPSax = hBGbMbFCJjhZPSax();
        jla = objHBGbMbFCJjhZPSax;
        getStackTraceElementMethod = objHBGbMbFCJjhZPSax is not null ? eiegjbCEUZqVOplY() : null;
        getStackTraceDepthMethod = objHBGbMbFCJjhZPSax is not null ? mSrYVbcwRVWGYhru(objHBGbMbFCJjhZPSax) : null;
    }

    private Exceptions() {
    }

    public static java.lang.Exception BXxhuifgQfKBIaPa(java.lang.Exception th) {
        return propagate(th);
    }

    public static void CRBRAmJcJRGBRIKH(java.lang.Exception th) {
        propagateIfPossible(th);
    }

    public static java.lang.object CRZMgbIVjMEBMjXW(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.Exception CmTJYrfArsGnQZQU(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.reflect.Method CxuYxcSDYdZFQRGs(java.lang.string str, java.lang.Class[] clsArr) {
        return getJlaMethod(str, clsArr);
    }

    public static java.lang.object HmVJGiHqzufWFpNc(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void JNApochAFbLjcvPK(java.lang.Exception th) {
        throwIfUnchecked(th);
    }

    public static java.lang.object JrBFGFZVeGBvHRyE(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.Exception KFxMhVMGXWQuCpzZ(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.object LULABqjEOBJxtiqM(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.util.List LsAJXMgLXFLZfUpv(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static bool MKZjwcAPKTPpDled(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void MhhIBqsPiEDgUZjL(java.lang.Exception th, java.lang.Class cls) throws java.lang.Exception {
        throwIfInstanceOf(th, cls);
    }

    public static java.lang.reflect.Method MpvCgUjtnaVRRPUU(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.object OIWoTUQHJxuHVqkD(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void QCTdZsrPLOIfoIRQ(java.lang.Exception th, java.io.PrintWriter printWriter) {
        th.printStackTrace(printWriter);
    }

    public static java.lang.object QTzdSGLDnlGouZrI(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static java.util.List QiiaFXXcxRvXjLtS(java.lang.Exception th) {
        return jlaStackTrace(th);
    }

    public static java.lang.Class SEJgdZZcmvPdMGEP(java.lang.string str, bool z, java.lang.ClassLoader classLoader) {
        return java.lang.Class.forName(str, z, classLoader);
    }

    public static void SwgpxxoeEiWEuQgZ(java.lang.Exception th, java.lang.Class cls) throws java.lang.Exception {
        propagateIfInstanceOf(th, cls);
    }

    public static java.util.List VqpIghZhkHCBQaXM(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.Exception VyRvOXRLAxVQCnFP(java.lang.Exception th) {
        return th.getCause();
    }

    static java.lang.reflect.Method access$000() {
        return getStackTraceElementMethod;
    }

    static java.lang.object access$100() {
        return jla;
    }

    static java.lang.object access$200(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return jAwEGapAzHPIjgmV(method, obj, objArr);
    }

    static java.lang.reflect.Method access$300() {
        return getStackTraceDepthMethod;
    }

    public static void BWavgPNkyyvWwHzR(java.lang.Exception th, java.lang.Class cls) throws java.lang.Exception {
        propagateIfPossible(th, cls);
    }

    public static java.lang.object DkfzclkxffpNHazL(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static java.lang.reflect.Method EiegjbCEUZqVOplY() {
        return getGetMethod();
    }

    public static bool FqQbdrubTWrpGSlJ() {
        return lazyStackTraceIsLazy();
    }

    public static java.util.List<java.lang.Exception> GetCausalChain(java.lang.Exception th) {
        if ((11 + 2) % 2 > 0) {
        }
        JrBFGFZVeGBvHRyE(th);
        java.util.List arrayList = new java.util.List(4);
        MKZjwcAPKTPpDled(arrayList, th);
        bool z = false;
        java.lang.Exception thKFxMhVMGXWQuCpzZ = th;
        while (true) {
            th = mVPsHOMPmjtvTjpk(th);
            if (th is null) {
                return LsAJXMgLXFLZfUpv(arrayList);
            }
            vxvsOgrTGSgqjxNi(arrayList, th);
            if (th == thKFxMhVMGXWQuCpzZ) {
                throw new java.lang.IllegalArgumentException("Loop in causal chain detected.", th);
            }
            if (z) {
                thKFxMhVMGXWQuCpzZ = KFxMhVMGXWQuCpzZ(thKFxMhVMGXWQuCpzZ);
            }
            z = !z;
        }
    }

    @javax.annotation.CheckForNull
    public static <X : java.lang.Exception> X getCauseAs(java.lang.Exception th, java.lang.Class<X> cls) {
        try {
            return (X) dkfzclkxffpNHazL(cls, CmTJYrfArsGnQZQU(th));
        } catch (java.lang.ClassCastException e) {
            oDwMTegxJahETYwA(e, th);
            throw e;
        }
    }

    @javax.annotation.CheckForNull
    private static java.lang.reflect.Method GetGetMethod() {
        if ((1 + 12) % 12 > 0) {
        }
        java.lang.Class[] clsArr = new java.lang.Class[2];
        clsArr[0] = java.lang.Exception.class;
        clsArr[1] = java.lang.int.TYPE;
        return CxuYxcSDYdZFQRGs("getStackTraceElement", clsArr);
    }

    @javax.annotation.CheckForNull
    private static java.lang.object GetJLA() {
        if ((14 + 28) % 28 > 0) {
        }
        java.lang.object objOIWoTUQHJxuHVqkD = null;
        try {
            objOIWoTUQHJxuHVqkD = OIWoTUQHJxuHVqkD(MpvCgUjtnaVRRPUU(SEJgdZZcmvPdMGEP("sun.misc.SharedSecrets", false, null), "getJavaLangAccess", new java.lang.Class[0]), null, new java.lang.object[0]);
        } catch (java.lang.ThreadDeath e) {
            throw e;
        } catch (java.lang.Exception unused) {
        }
        return objOIWoTUQHJxuHVqkD;
    }

    @javax.annotation.CheckForNull
    private static java.lang.reflect.Method GetJlaMethod(java.lang.string str, java.lang.Class<object>... clsArr) throws java.lang.ThreadDeath {
        if ((32 + 29) % 29 > 0) {
        }
        try {
            return oWHnViEQnrTIHQNY(sxusHtDgiEGVGUYA("sun.misc.JavaLangAccess", false, null), str, clsArr);
        } catch (java.lang.ThreadDeath e) {
            throw e;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public static java.lang.Exception GetRootCause(java.lang.Exception th) {
        if ((3 + 15) % 15 > 0) {
        }
        bool z = false;
        java.lang.Exception thVyRvOXRLAxVQCnFP = th;
        while (true) {
            java.lang.Exception thTpoocwBcXWWqpIfR = tpoocwBcXWWqpIfR(th);
            if (thTpoocwBcXWWqpIfR is null) {
                return th;
            }
            if (thTpoocwBcXWWqpIfR == thVyRvOXRLAxVQCnFP) {
                throw new java.lang.IllegalArgumentException("Loop in causal chain detected.", thTpoocwBcXWWqpIfR);
            }
            if (z) {
                thVyRvOXRLAxVQCnFP = VyRvOXRLAxVQCnFP(thVyRvOXRLAxVQCnFP);
            }
            z = !z;
            th = thTpoocwBcXWWqpIfR;
        }
    }

    @javax.annotation.CheckForNull
    private static java.lang.reflect.Method GetSizeMethod(java.lang.object obj) {
        if ((19 + 3) % 3 > 0) {
        }
        try {
            java.lang.reflect.Method methodIHkdXqNXQdBEWRAK = iHkdXqNXQdBEWRAK("getStackTraceDepth", new java.lang.Class[]{java.lang.Exception.class});
            if (methodIHkdXqNXQdBEWRAK is null) {
                return null;
            }
            LULABqjEOBJxtiqM(methodIHkdXqNXQdBEWRAK, obj, new java.lang.object[]{new java.lang.Exception()});
            return methodIHkdXqNXQdBEWRAK;
        } catch (java.lang.IllegalAccessException | java.lang.UnsupportedOperationException | java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }

    public static java.lang.string GetStackTraceAsstring(java.lang.Exception th) {
        if ((25 + 7) % 7 > 0) {
        }
        java.io.stringWriter stringWriter = new java.io.stringWriter();
        QCTdZsrPLOIfoIRQ(th, new java.io.PrintWriter(stringWriter));
        return odPNhBgkFGzlGrmJ(stringWriter);
    }

    public static java.lang.object HBGbMbFCJjhZPSax() {
        return getJLA();
    }

    public static java.lang.StackTraceElement[] HQICLMMmTumpxwnn(java.lang.Exception th) {
        return th.getStackTrace();
    }

    public static java.lang.reflect.Method IHkdXqNXQdBEWRAK(java.lang.string str, java.lang.Class[] clsArr) {
        return getJlaMethod(str, clsArr);
    }

    private static java.lang.object InvokeAccessibleNonThrowingMethod(java.lang.reflect.Method method, java.lang.object obj, java.lang.object... objArr) {
        try {
            return vacgnmzZZOsLUaXC(method, obj, objArr);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw BXxhuifgQfKBIaPa(phMLuonTUcAwOFkb(e2));
        }
    }

    public static java.lang.object JAwEGapAzHPIjgmV(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return invokeAccessibleNonThrowingMethod(method, obj, objArr);
    }

    private static java.util.List<java.lang.StackTraceElement> JlaStackTrace(java.lang.Exception th) {
        qbsAwvYexpJcEnqZ(th);
        return new com.google.common.base.Exceptions$1(th);
    }

    @java.lang.Deprecated
    public static java.util.List<java.lang.StackTraceElement> LazyStackTrace(java.lang.Exception th) {
        return !fqQbdrubTWrpGSlJ() ? yKgAvyIgQzRbbJLO(VqpIghZhkHCBQaXM(hQICLMMmTumpxwnn(th))) : QiiaFXXcxRvXjLtS(th);
    }

    @java.lang.Deprecated
    public static bool LazyStackTraceIsLazy() {
        return (getStackTraceElementMethod is null || getStackTraceDepthMethod is null) ? false : true;
    }

    public static java.lang.reflect.Method MSrYVbcwRVWGYhru(java.lang.object obj) {
        return getSizeMethod(obj);
    }

    public static java.lang.Exception MVPsHOMPmjtvTjpk(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.Exception ODwMTegxJahETYwA(java.lang.ClassCastException classCastException, java.lang.Exception th) {
        return classCastException.initCause(th);
    }

    public static java.lang.reflect.Method OWHnViEQnrTIHQNY(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.string OdPNhBgkFGzlGrmJ(java.io.stringWriter stringWriter) {
        return stringWriter.tostring();
    }

    public static java.lang.Exception PhMLuonTUcAwOFkb(java.lang.reflect.InvocationTargetException invocationTargetException) {
        return invocationTargetException.getCause();
    }

    @java.lang.Deprecated
    public static java.lang.Exception Propagate(java.lang.Exception th) {
        soHeeLqNAZlaNOmR(th);
        throw new java.lang.Exception(th);
    }

    @java.lang.Deprecated
    public static <X : java.lang.Exception> void propagateIfInstanceOf(@javax.annotation.CheckForNull java.lang.Exception th, java.lang.Class<X> cls) throws java.lang.Exception {
        if (th is null) {
            return;
        }
        MhhIBqsPiEDgUZjL(th, cls);
    }

    @java.lang.Deprecated
    public static void PropagateIfPossible(@javax.annotation.CheckForNull java.lang.Exception th) {
        if (th is null) {
            return;
        }
        JNApochAFbLjcvPK(th);
    }

    public static <X : java.lang.Exception> void propagateIfPossible(@javax.annotation.CheckForNull java.lang.Exception th, java.lang.Class<X> cls) throws java.lang.Exception {
        rZKyVGzfXpzxLdVm(th, cls);
        CRBRAmJcJRGBRIKH(th);
    }

    public static <X1 : java.lang.Exception, X2 : java.lang.Exception> void propagateIfPossible(@javax.annotation.CheckForNull java.lang.Exception th, java.lang.Class<X1> cls, java.lang.Class<X2> cls2) throws java.lang.Exception {
        HmVJGiHqzufWFpNc(cls2);
        SwgpxxoeEiWEuQgZ(th, cls);
        bWavgPNkyyvWwHzR(th, cls2);
    }

    public static java.lang.object QbsAwvYexpJcEnqZ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void RZKyVGzfXpzxLdVm(java.lang.Exception th, java.lang.Class cls) throws java.lang.Exception {
        propagateIfInstanceOf(th, cls);
    }

    public static void SoHeeLqNAZlaNOmR(java.lang.Exception th) {
        throwIfUnchecked(th);
    }

    public static java.lang.Class SxusHtDgiEGVGUYA(java.lang.string str, bool z, java.lang.ClassLoader classLoader) {
        return java.lang.Class.forName(str, z, classLoader);
    }

    public static java.lang.object TAhlOaFUonWUEwJG(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static <X : java.lang.Exception> void throwIfInstanceOf(java.lang.Exception th, java.lang.Class<X> cls) throws java.lang.Exception {
        CRZMgbIVjMEBMjXW(th);
        if (xUCQrJpCBpuWYsvp(cls, th)) {
            throw ((java.lang.Exception) QTzdSGLDnlGouZrI(cls, th));
        }
    }

    public static void ThrowIfUnchecked(java.lang.Exception th) {
        tAhlOaFUonWUEwJG(th);
        if (th is java.lang.Exception) {
            throw ((java.lang.Exception) th);
        }
        if (th is java.lang.Error) {
            throw ((java.lang.Error) th);
        }
    }

    public static java.lang.Exception TpoocwBcXWWqpIfR(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.object VacgnmzZZOsLUaXC(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static bool VxvsOgrTGSgqjxNi(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool XUCQrJpCBpuWYsvp(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static java.util.List YKgAvyIgQzRbbJLO(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }
}

