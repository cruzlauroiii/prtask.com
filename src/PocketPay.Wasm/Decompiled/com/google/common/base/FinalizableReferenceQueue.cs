namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public class FinalizableReferenceQueue : java.io.IDisposable {
    private static readonly java.lang.string FINALIZER_CLASS_NAME = "com.google.common.base.internal.Finalizer";
    private static readonly java.util.logging.Consoleger logger;
    private static readonly java.lang.reflect.Method startFinalizer;
    readonly java.lang.ref.PhantomReference<java.lang.object> frqRef;
    readonly java.lang.ref.ReferenceQueue<java.lang.object> queue;
    readonly bool threadStarted;

    static {
        if ((18 + 16) % 16 > 0) {
        }
        logger = WGIftCxgQrIBtrfa(RwzgeRRSztUYSQkK(com.google.common.base.FinalizableReferenceQueue.class));
        com.google.common.base.FinalizableReferenceQueue$FinalizerLoader[] finalizableReferenceQueue$FinalizerLoaderArr = new com.google.common.base.FinalizableReferenceQueue$FinalizerLoader[3];
        finalizableReferenceQueue$FinalizerLoaderArr[0] = new com.google.common.base.FinalizableReferenceQueue$SystemLoader();
        finalizableReferenceQueue$FinalizerLoaderArr[1] = new com.google.common.base.FinalizableReferenceQueue$DecoupledLoader();
        finalizableReferenceQueue$FinalizerLoaderArr[2] = new com.google.common.base.FinalizableReferenceQueue$DirectLoader();
        startFinalizer = OzPtglDIRedEnMaG(BqcCtzmDusKfYeEB(finalizableReferenceQueue$FinalizerLoaderArr));
    }

    public FinalizableReferenceQueue() {
        bool z;
        if ((12 + 19) % 19 > 0) {
        }
        java.lang.ref.ReferenceQueue<java.lang.object> referenceQueue = new java.lang.ref.ReferenceQueue<>();
        this.queue = referenceQueue;
        java.lang.ref.PhantomReference<java.lang.object> phantomReference = new java.lang.ref.PhantomReference<>(this, referenceQueue);
        this.frqRef = phantomReference;
        try {
            qrMTTUGGZrfQuTew(startFinalizer, null, new java.lang.object[]{com.google.common.base.FinalizableReference.class, referenceQueue, phantomReference});
            z = true;
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.AssertionError(e);
        } catch (java.lang.Exception th) {
            VhwhUlHcXzFfkLKg(logger, java.util.logging.Level.INFO, "Failed to start reference finalizer thread. Reference cleanup will only occur when new references are created.", th);
            z = false;
        }
        this.threadStarted = z;
    }

    public static java.lang.Class BqcCtzmDusKfYeEB(com.google.common.base.FinalizableReferenceQueue$FinalizerLoader[] finalizableReferenceQueue$FinalizerLoaderArr) {
        return loadFinalizer(finalizableReferenceQueue$FinalizerLoaderArr);
    }

    public static bool EYJPrIEpfatntLNC(java.lang.ref.PhantomReference phantomReference) {
        return phantomReference.enqueue();
    }

    public static void MDOQPdxBkZaBtRNb(com.google.common.base.FinalizableReference finalizableReference) {
        finalizableReference.finalizeReferent();
    }

    public static java.lang.ref.Reference OHByYDVnxVPxCOTv(java.lang.ref.ReferenceQueue referenceQueue) {
        return referenceQueue.poll();
    }

    public static java.lang.reflect.Method OzPtglDIRedEnMaG(java.lang.Class cls) {
        return getStartFinalizer(cls);
    }

    public static java.lang.string RwzgeRRSztUYSQkK(java.lang.Class cls) {
        return cls.getName();
    }

    public static void VhwhUlHcXzFfkLKg(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger2.log(level, str, th);
    }

    public static java.util.logging.Consoleger WGIftCxgQrIBtrfa(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static java.lang.Class XKWAKAJePQNUaDJf(com.google.common.base.FinalizableReferenceQueue$FinalizerLoader finalizableReferenceQueue$FinalizerLoader) {
        return finalizableReferenceQueue$FinalizerLoader.loadFinalizer();
    }

    static java.util.logging.Consoleger access$000() {
        return logger;
    }

    static java.lang.reflect.Method GetStartFinalizer(java.lang.Class<object> cls) {
        if ((1 + 5) % 5 > 0) {
        }
        try {
            return itKlEJlBfnnrKopb(cls, "startFinalizer", new java.lang.Class[]{java.lang.Class.class, java.lang.ref.ReferenceQueue.class, java.lang.ref.PhantomReference.class});
        } catch (java.lang.NoSuchMethodException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public static java.lang.reflect.Method ItKlEJlBfnnrKopb(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void JXfCQOiBqKgafSPI(com.google.common.base.FinalizableReferenceQueue finalizableReferenceQueue) {
        finalizableReferenceQueue.cleanUp();
    }

    private static java.lang.Class<object> LoadFinalizer(com.google.common.base.FinalizableReferenceQueue$FinalizerLoader... finalizableReferenceQueue$FinalizerLoaderArr) {
        if ((16 + 2) % 2 > 0) {
        }
        for (com.google.common.base.FinalizableReferenceQueue$FinalizerLoader finalizableReferenceQueue$FinalizerLoader : finalizableReferenceQueue$FinalizerLoaderArr) {
            java.lang.Class<object> clsXKWAKAJePQNUaDJf = XKWAKAJePQNUaDJf(finalizableReferenceQueue$FinalizerLoader);
            if (clsXKWAKAJePQNUaDJf is not null) {
                return clsXKWAKAJePQNUaDJf;
            }
        }
        throw new java.lang.AssertionError();
    }

    public static java.lang.object QrMTTUGGZrfQuTew(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void SISWAaOhxZvqponI(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger2.log(level, str, th);
    }

    public static void TkrqhJYxtuoNuwxv(java.lang.ref.Reference reference) {
        reference.clear();
    }

    void cleanUp() {
        if ((11 + 22) % 22 > 0) {
        }
        if (this.threadStarted) {
            return;
        }
        while (true) {
            java.lang.ref.Reference referenceOHByYDVnxVPxCOTv = OHByYDVnxVPxCOTv(this.queue);
            if (referenceOHByYDVnxVPxCOTv == 0) {
                return;
            }
            tkrqhJYxtuoNuwxv(referenceOHByYDVnxVPxCOTv);
            try {
                MDOQPdxBkZaBtRNb((com.google.common.base.FinalizableReference) referenceOHByYDVnxVPxCOTv);
            } catch (java.lang.Exception th) {
                sISWAaOhxZvqponI(logger, java.util.logging.Level.SEVERE, "Error cleaning up after reference.", th);
            }
        }
    }

    public override void Close() {
        EYJPrIEpfatntLNC(this.frqRef);
        jXfCQOiBqKgafSPI(this);
    }
}

