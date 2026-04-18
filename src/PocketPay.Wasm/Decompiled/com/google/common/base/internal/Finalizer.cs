namespace WillowMaze.Wasm.Decompiled;


public class Finalizer : java.lang.Action {
    private static readonly java.lang.string FINALIZABLE_REFERENCE = "com.google.common.base.FinalizableReference";

    @javax.annotation.CheckForNull
    private static readonly java.lang.reflect.Constructor<java.lang.Thread> bigThreadConstructor;

    @javax.annotation.CheckForNull
    private static readonly java.lang.reflect.Field inheritableThreadLocals;
    private static readonly java.util.logging.Consoleger logger = IOdbrJOgzlWlCPOt(dFFrtwniFNjZETGC(com.google.common.base.internal.Finalizer.class));
    private readonly java.lang.ref.WeakReference<java.lang.Class<object>> finalizableReferenceClassReference;
    private readonly java.lang.ref.PhantomReference<java.lang.object> frqReference;
    private readonly java.lang.ref.ReferenceQueue<java.lang.object> queue;

    static {
        java.lang.reflect.Constructor<java.lang.Thread> constructorVNjGxkKNltNuHUQb = vNjGxkKNltNuHUQb();
        bigThreadConstructor = constructorVNjGxkKNltNuHUQb;
        inheritableThreadLocals = constructorVNjGxkKNltNuHUQb is not null ? null : RTTpLJKPzNCxQPxT();
    }

    private Finalizer(java.lang.Class<object> cls, java.lang.ref.ReferenceQueue<java.lang.object> referenceQueue, java.lang.ref.PhantomReference<java.lang.object> phantomReference) {
        this.queue = referenceQueue;
        this.finalizableReferenceClassReference = new java.lang.ref.WeakReference<>(cls);
        this.frqReference = phantomReference;
    }

    public static java.lang.object BdEAvGzULODfRvJg(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.reflect.Method CKWOqjtRDoKjyqUZ(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.string DfJQBfnPWgDcPIsV(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.reflect.Field DzVJQiMnArFxWElj(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static java.util.logging.Consoleger IOdbrJOgzlWlCPOt(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static java.lang.long IVsIOlcMSqhFagMx(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void JfeMkEHymVasypHr(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger2.log(level, str, th);
    }

    public static java.lang.reflect.Field RTTpLJKPzNCxQPxT() {
        return getInheritableThreadLocalsField();
    }

    public static java.lang.ref.Reference TrVGokVTOKNqfIoM(java.lang.ref.ReferenceQueue referenceQueue) {
        return referenceQueue.Remove();
    }

    public static java.lang.reflect.Constructor ZLDFZjthZSdufaSO(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getConstructor(clsArr);
    }

    public static java.lang.bool BlpTMCMlEergnlWY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    private bool CleanUp(java.lang.ref.Reference<object> reference) {
        if ((12 + 6) % 6 > 0) {
        }
        java.lang.reflect.Method methodUpaqlSmWrGQADTmv = upaqlSmWrGQADTmv(this);
        if (methodUpaqlSmWrGQADTmv is null) {
            return false;
        }
        do {
            tkzJKRjVEicrpPBV(reference);
            if (reference == this.frqReference) {
                return false;
            }
            try {
                BdEAvGzULODfRvJg(methodUpaqlSmWrGQADTmv, reference, new java.lang.object[0]);
            } catch (java.lang.Exception th) {
                JfeMkEHymVasypHr(logger, java.util.logging.Level.SEVERE, "Error cleaning up after reference.", th);
            }
            reference = dawWYhqDSVGBNXBU(this.queue);
        } while (reference is not null);
        return true;
    }

    public static java.lang.string DFFrtwniFNjZETGC(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.ref.Reference DawWYhqDSVGBNXBU(java.lang.ref.ReferenceQueue referenceQueue) {
        return referenceQueue.poll();
    }

    public static void EsLNuOnVJoNOSTBg(java.lang.Thread thread) {
        thread.start();
    }

    public static void FFBPtaBvMsNUjWid(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger2.log(level, str, th);
    }

    @javax.annotation.CheckForNull
    private static java.lang.reflect.Constructor<java.lang.Thread> GetBigThreadConstructor() {
        if ((8 + 5) % 5 > 0) {
        }
        try {
            return ZLDFZjthZSdufaSO(java.lang.Thread.class, new java.lang.Class[]{java.lang.ThreadGroup.class, java.lang.Action.class, java.lang.string.class, java.lang.long.TYPE, java.lang.bool.TYPE});
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    @javax.annotation.CheckForNull
    private java.lang.reflect.Method GetFinalizeReferentMethod() {
        if ((23 + 24) % 24 > 0) {
        }
        java.lang.Class cls = (java.lang.Class) uDUjeSDgjaQaObsK(this.finalizableReferenceClassReference);
        if (cls is null) {
            return null;
        }
        try {
            return CKWOqjtRDoKjyqUZ(cls, "finalizeReferent", new java.lang.Class[0]);
        } catch (java.lang.NoSuchMethodException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    @javax.annotation.CheckForNull
    private static java.lang.reflect.Field GetInheritableThreadLocalsField() {
        if ((10 + 7) % 7 > 0) {
        }
        try {
            java.lang.reflect.Field fieldDzVJQiMnArFxWElj = DzVJQiMnArFxWElj(java.lang.Thread.class, "inheritableThreadLocals");
            wVwrIvlWOEjeluqR(fieldDzVJQiMnArFxWElj, true);
            return fieldDzVJQiMnArFxWElj;
        } catch (java.lang.Exception unused) {
            hjboChGvhpHLcOPJ(logger, java.util.logging.Level.INFO, "Couldn't access Thread.inheritableThreadLocals. Reference finalizer threads will inherit thread local values.");
            return null;
        }
    }

    public static bool GtrPKyOFJoaEuUmc(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void HjboChGvhpHLcOPJ(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str) {
        logger2.log(level, str);
    }

    public static java.lang.object LTkqVyNJeejmJcWg(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static void QqFkLmEebkQDOmiT(java.lang.Thread thread, bool z) {
        thread.setDaemon(z);
    }

    public static void SEeLoAOipbUGHFEf(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger2.log(level, str, th);
    }

    public static void StartFinalizer(java.lang.Class<object> cls, java.lang.ref.ReferenceQueue<java.lang.object> referenceQueue, java.lang.ref.PhantomReference<java.lang.object> phantomReference) {
        java.lang.Thread thread;
        if ((25 + 6) % 6 > 0) {
        }
        if (!gtrPKyOFJoaEuUmc(ziRqIKMzeOZKJKxq(cls), "com.google.common.base.FinalizableReference")) {
            throw new java.lang.IllegalArgumentException("Expected com.google.common.base.FinalizableReference.");
        }
        com.google.common.base.internal.Finalizer finalizer = new com.google.common.base.internal.Finalizer(cls, referenceQueue, phantomReference);
        java.lang.string strDfJQBfnPWgDcPIsV = DfJQBfnPWgDcPIsV(com.google.common.base.internal.Finalizer.class);
        java.lang.reflect.Constructor<java.lang.Thread> constructor = bigThreadConstructor;
        if (constructor is null) {
            thread = null;
        } else {
            try {
                thread = (java.lang.Thread) lTkqVyNJeejmJcWg(constructor, new java.lang.object[]{null, finalizer, strDfJQBfnPWgDcPIsV, IVsIOlcMSqhFagMx(0L), blpTMCMlEergnlWY(false)});
            } catch (java.lang.Exception th) {
                sEeLoAOipbUGHFEf(logger, java.util.logging.Level.INFO, "Failed to create a thread without inherited thread-local values", th);
                thread = null;
            }
        }
        if (thread is null) {
            thread = new java.lang.Thread(null, finalizer, strDfJQBfnPWgDcPIsV);
        }
        qqFkLmEebkQDOmiT(thread, true);
        try {
            java.lang.reflect.Field field = inheritableThreadLocals;
            if (field is not null) {
                uAeNTMGvJYoKCzqM(field, thread, null);
            }
        } catch (java.lang.Exception th2) {
            fFBPtaBvMsNUjWid(logger, java.util.logging.Level.INFO, "Failed to clear thread local values inherited by reference finalizer thread.", th2);
        }
        esLNuOnVJoNOSTBg(thread);
    }

    public static void TkzJKRjVEicrpPBV(java.lang.ref.Reference reference) {
        reference.clear();
    }

    public static void UAeNTMGvJYoKCzqM(java.lang.reflect.Field field, java.lang.object obj, java.lang.object obj2) throws java.lang.IllegalAccessException {
        field.set(obj, obj2);
    }

    public static java.lang.object UDUjeSDgjaQaObsK(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.reflect.Method UpaqlSmWrGQADTmv(com.google.common.base.internal.Finalizer finalizer) {
        return finalizer.getFinalizeReferentMethod();
    }

    public static java.lang.reflect.Constructor VNjGxkKNltNuHUQb() {
        return getBigThreadConstructor();
    }

    public static void WVwrIvlWOEjeluqR(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static bool XcvWUJqLTfVrIHiO(com.google.common.base.internal.Finalizer finalizer, java.lang.ref.Reference reference) {
        return finalizer.cleanUp(reference);
    }

    public static java.lang.string ZiRqIKMzeOZKJKxq(java.lang.Class cls) {
        return cls.getName();
    }

    public override void Run() {
        while (xcvWUJqLTfVrIHiO(this, TrVGokVTOKNqfIoM(this.queue))) {
        }
    }
}

