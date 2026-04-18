namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
public abstract class LiveData<T> {
    static readonly java.lang.object NOT_SET = null;
    static readonly int START_VERSION = -1;
    int mActiveCount;
    private bool mChangingActiveState;
    private java.lang.object mData;
    readonly java.lang.object mDataLock;
    private bool mDispatchInvalidated;
    private bool mDispatchingValue;
    private androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>.ObserverWrapper> mObservers;
    volatile java.lang.object mPendingData;
    private readonly java.lang.Action mPostValueAction;
    private int mVersion;


    private class AlwaysActiveObserver : androidx.lifecycle.LiveData<T>.ObserverWrapper {
        readonly /* synthetic */ androidx.lifecycle.LiveData this$0;

        AlwaysActiveObserver(androidx.lifecycle.LiveData r1, androidx.lifecycle.Observer<T> r2) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L1c
            La:
                goto L15
            Le:
                r0.<init>(r1, r2)
                goto L1b
            L15:
                r0.this$0 = r1
                goto Le
            L1b:
                return
            L1c:
                goto L4
        }

        @Override // androidx.lifecycle.LiveData.ObserverWrapper
        bool shouldBeActive() {
                r0 = this;
                goto Le
            L4:
                return r0
            L5:
                goto L15
            L9:
                r0 = 1
                goto L4
            Le:
                goto L5
            L11:
                goto L9
            L15:
                goto L11
        }
    }

    class LifecycleBoundObserver : androidx.lifecycle.LiveData<T>.ObserverWrapper : androidx.lifecycle.LifecycleEventObserver {
        readonly androidx.lifecycle.LifecycleOwner mOwner;
        readonly /* synthetic */ androidx.lifecycle.LiveData this$0;

        LifecycleBoundObserver(androidx.lifecycle.LiveData r1, androidx.lifecycle.LifecycleOwner r2, androidx.lifecycle.Observer<T> r3) {
                r0 = this;
                goto La
            L4:
                r0.this$0 = r1
                goto L19
            La:
                goto L12
            Ld:
                goto L4
            L11:
                return
            L12:
                goto L16
            L16:
                goto Ld
            L19:
                r0.<init>(r1, r3)
                goto L20
            L20:
                r0.mOwner = r2
                goto L11
        }

        @Override // androidx.lifecycle.LiveData.ObserverWrapper
        void detachObserver() {
                r1 = this;
                goto L16
            L4:
                androidx.lifecycle.Lifecycle r0 = r0.getLifecycle()
                goto Lc
            Lc:
                r0.removeObserver(r1)
                goto L23
            L13:
                goto L19
            L16:
                goto L24
            L19:
                goto L1d
            L1d:
                androidx.lifecycle.LifecycleOwner r0 = r1.mOwner
                goto L4
            L23:
                return
            L24:
                goto L13
        }

        @Override // androidx.lifecycle.LiveData.ObserverWrapper
        bool isAttachedTo(androidx.lifecycle.LifecycleOwner r1) {
                r0 = this;
                goto L14
            L4:
                return r0
            L5:
                goto L2c
            L9:
                r0 = 1
                goto L4
            Le:
                androidx.lifecycle.LifecycleOwner r0 = r0.mOwner
                goto L23
            L14:
                goto L1c
            L17:
                goto Le
            L1b:
                return r0
            L1c:
                goto L20
            L20:
                goto L17
            L23:
                if (r0 == r1) goto L28
                goto L5
            L28:
                goto L9
            L2c:
                r0 = 0
                goto L1b
        }

        @Override // androidx.lifecycle.LifecycleEventObserver
        public void OnStateChanged(androidx.lifecycle.LifecycleOwner r2, androidx.lifecycle.Lifecycle.Event r3) {
                r1 = this;
                goto La
            L4:
                androidx.lifecycle.Lifecycle$State r3 = androidx.lifecycle.Lifecycle.State.DESTROYED
                goto L1c
            La:
                goto L3a
            Ld:
                goto L8c
            L11:
                r3 = 0
            L12:
                goto L7b
            L16:
                androidx.lifecycle.LiveData r2 = r1.this$0
                goto L75
            L1c:
                if (r2 == r3) goto L21
                goto L54
            L21:
                goto L16
            L25:
                r0 = r3
                goto L3e
            L2a:
                r2.removeObserver(r1)
                goto L53
            L31:
                bool r3 = r1.shouldBeActive()
                goto L58
            L39:
                return
            L3a:
                goto L89
            L3e:
                r3 = r2
                goto L92
            L43:
                androidx.lifecycle.Lifecycle r2 = r2.getLifecycle()
                goto L6d
            L4b:
                androidx.lifecycle.Lifecycle$State r3 = r3.getCurrentState()
                goto L25
            L53:
                return
            L54:
                goto L11
            L58:
                r1.activeStateChanged(r3)
                goto L5f
            L5f:
                androidx.lifecycle.LifecycleOwner r3 = r1.mOwner
                goto L65
            L65:
                androidx.lifecycle.Lifecycle r3 = r3.getLifecycle()
                goto L4b
            L6d:
                androidx.lifecycle.Lifecycle$State r2 = r2.getCurrentState()
                goto L4
            L75:
                androidx.lifecycle.Observer<T> r1 = r1.mObserver
                goto L2a
            L7b:
                if (r3 != r2) goto L80
                goto L85
            L80:
                goto L31
            L84:
                goto L12
            L85:
                goto L39
            L89:
                goto Ld
            L8c:
                androidx.lifecycle.LifecycleOwner r2 = r1.mOwner
                goto L43
            L92:
                r2 = r0
                goto L84
        }

        @Override // androidx.lifecycle.LiveData.ObserverWrapper
        bool shouldBeActive() {
                r1 = this;
                goto L17
            L4:
                bool r1 = r1.isAtLeast(r0)
                goto L2c
            Lc:
                goto L1a
            Lf:
                androidx.lifecycle.Lifecycle$State r1 = r1.getCurrentState()
                goto L31
            L17:
                goto L2d
            L1a:
                goto L1e
            L1e:
                androidx.lifecycle.LifecycleOwner r1 = r1.mOwner
                goto L24
            L24:
                androidx.lifecycle.Lifecycle r1 = r1.getLifecycle()
                goto Lf
            L2c:
                return r1
            L2d:
                goto Lc
            L31:
                androidx.lifecycle.Lifecycle$State r0 = androidx.lifecycle.Lifecycle.State.STARTED
                goto L4
        }
    }

    private abstract class ObserverWrapper {
        bool mActive;
        int mLastVersion;
        readonly androidx.lifecycle.Observer<T> mObserver;
        readonly /* synthetic */ androidx.lifecycle.LiveData this$0;

        ObserverWrapper(androidx.lifecycle.LiveData r1, androidx.lifecycle.Observer<T> r2) {
                r0 = this;
                goto L15
            L4:
                r1 = -1
                goto Lf
            L9:
                r0.mObserver = r2
                goto L1c
            Lf:
                r0.mLastVersion = r1
                goto L9
            L15:
                goto L1d
            L18:
                goto L21
            L1c:
                return
            L1d:
                goto L27
            L21:
                r0.this$0 = r1
                goto L2a
            L27:
                goto L18
            L2a:
                r0.<init>()
                goto L4
        }

        void activeStateChanged(bool r2) {
                r1 = this;
                goto L67
            L4:
                goto L11
            L5:
                goto L3e
            L9:
                r2 = -1
            La:
                goto L28
            Le:
                r2.dispatchingValue(r1)
            L11:
                goto L4a
            L15:
                goto La
            L16:
                goto L9
            L1a:
                r2 = 1
                goto L15
            L1f:
                goto L6a
            L22:
                androidx.lifecycle.LiveData r2 = r1.this$0
                goto Le
            L28:
                r0.changeActiveCounter(r2)
                goto L44
            L2f:
                if (r2 != 0) goto L34
                goto L16
            L34:
                goto L1a
            L38:
                bool r0 = r1.mActive
                goto L58
            L3e:
                r1.mActive = r2
                goto L61
            L44:
                bool r2 = r1.mActive
                goto L4f
            L4a:
                return
            L4b:
                goto L1f
            L4f:
                if (r2 != 0) goto L54
                goto L11
            L54:
                goto L22
            L58:
                if (r2 == r0) goto L5d
                goto L5
            L5d:
                goto L4
            L61:
                androidx.lifecycle.LiveData r0 = r1.this$0
                goto L2f
            L67:
                goto L4b
            L6a:
                goto L38
        }

        void detachObserver() {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto Lf
            La:
                goto Le
            Le:
                return
            Lf:
                goto L4
        }

        bool isAttachedTo(androidx.lifecycle.LifecycleOwner r1) {
                r0 = this;
                goto L4
            L4:
                goto Lf
            L7:
                goto L13
            Lb:
                goto L7
            Le:
                return r0
            Lf:
                goto Lb
            L13:
                r0 = 0
                goto Le
        }

        abstract bool ShouldBeActive();
    }

    static {
            goto L18
        L4:
            java.lang.object r0 = new java.lang.object
            goto L1f
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            androidx.lifecycle.LiveData.NOT_SET = r0
            goto La
        L18:
            goto Lb
        L1b:
            goto L4
        L1f:
            r0.<init>()
            goto L12
    }

    public LiveData() {
            r2 = this;
            goto L40
        L4:
            r2.mPendingData = r0
            goto L3a
        La:
            goto L43
        Ld:
            r2.mData = r0
            goto L5d
        L13:
            r2.<init>()
            goto L7b
        L1a:
            int r0 = r0 + r1
            goto L69
        L20:
            r2.mVersion = r0
            goto La1
        L26:
            r2.mObservers = r0
            goto L96
        L2c:
            r1.<init>(r2)
            goto L9b
        L33:
            r1 = 11
            goto L1a
        L3a:
            androidx.lifecycle.LiveData$1 r1 = new androidx.lifecycle.LiveData$1
            goto L2c
        L40:
            goto L65
        L43:
            goto L81
        L47:
            goto La2
        L4a:
            goto L13
        L4e:
            androidx.arch.core.internal.SafeIEnumerableDictionary r0 = new androidx.arch.core.internal.SafeIEnumerableDictionary
            goto L88
        L54:
            if (r0 <= 0) goto L59
            goto L4a
        L59:
            goto L47
        L5d:
            r0 = -1
            goto L20
        L62:
            goto L4a
        L65:
            goto La
        L69:
            int r0 = r0 % r1
            goto L54
        L6f:
            r2.mDataLock = r0
            goto L4e
        L75:
            r2.mActiveCount = r0
            goto La6
        L7b:
            java.lang.object r0 = new java.lang.object
            goto L8f
        L81:
            r0 = 28
            goto L33
        L88:
            r0.<init>()
            goto L26
        L8f:
            r0.<init>()
            goto L6f
        L96:
            r0 = 0
            goto L75
        L9b:
            r2.mPostValueAction = r1
            goto Ld
        La1:
            return
        La2:
            goto L62
        La6:
            java.lang.object r0 = androidx.lifecycle.LiveData.NOT_SET
            goto L4
    }

    public LiveData(T r3) {
            r2 = this;
            goto L4
        L4:
            goto L68
        L7:
            goto L79
        Lb:
            r2.mVersion = r0
            goto L8f
        L11:
            androidx.lifecycle.LiveData$1 r1 = new androidx.lifecycle.LiveData$1
            goto L49
        L17:
            r0 = 0
            goto L50
        L1c:
            r0.<init>()
            goto L2a
        L23:
            r1 = 2
            goto L3d
        L2a:
            r2.mObservers = r0
            goto L17
        L30:
            goto L90
        L33:
            goto L72
        L37:
            r2.mDataLock = r0
            goto L80
        L3d:
            int r0 = r0 + r1
            goto La1
        L43:
            r2.mPendingData = r1
            goto L11
        L49:
            r1.<init>(r2)
            goto L94
        L50:
            r2.mActiveCount = r0
            goto L5f
        L56:
            r2.mData = r3
            goto Lb
        L5c:
            goto L7
        L5f:
            java.lang.object r1 = androidx.lifecycle.LiveData.NOT_SET
            goto L43
        L65:
            goto L33
        L68:
            goto L5c
        L6c:
            java.lang.object r0 = new java.lang.object
            goto L9a
        L72:
            r2.<init>()
            goto L6c
        L79:
            r0 = 11
            goto L23
        L80:
            androidx.arch.core.internal.SafeIEnumerableDictionary r0 = new androidx.arch.core.internal.SafeIEnumerableDictionary
            goto L1c
        L86:
            if (r0 <= 0) goto L8b
            goto L33
        L8b:
            goto L30
        L8f:
            return
        L90:
            goto L65
        L94:
            r2.mPostValueAction = r1
            goto L56
        L9a:
            r0.<init>()
            goto L37
        La1:
            int r0 = r0 % r1
            goto L86
    }

    static void AssertMainThread(java.lang.string r3) {
            goto L8b
        L4:
            if (r0 <= 0) goto L9
            goto L95
        L9:
            goto L92
        Ld:
            r1.<init>(r2)
            goto L48
        L14:
            if (r0 != 0) goto L19
            goto L51
        L19:
            goto L50
        L1d:
            int r0 = r0 + r1
            goto L77
        L23:
            bool r0 = r0.isMainThread()
            goto L14
        L2b:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L31
        L31:
            java.lang.string r2 = "Cannot invoke "
            goto Ld
        L37:
            java.lang.stringBuilder r3 = r3.append(r1)
            goto L83
        L3f:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L2b
        L45:
            goto L8e
        L48:
            java.lang.stringBuilder r3 = r1.append(r3)
            goto L7d
        L50:
            return
        L51:
            goto L3f
        L55:
            r0.<init>(r3)
            goto L72
        L5c:
            androidx.arch.core.executor.ArchTaskExecutor r0 = androidx.arch.core.executor.ArchTaskExecutor.getInstance()
            goto L23
        L64:
            r0 = 29
            goto L6b
        L6b:
            r1 = 18
            goto L1d
        L72:
            throw r0
        L73:
            goto L99
        L77:
            int r0 = r0 % r1
            goto L4
        L7d:
            java.lang.string r1 = " on a background thread"
            goto L37
        L83:
            java.lang.string r3 = r3.tostring()
            goto L55
        L8b:
            goto L9c
        L8e:
            goto L64
        L92:
            goto L73
        L95:
            goto L5c
        L99:
            goto L95
        L9c:
            goto L45
    }

    private void ConsiderNotify(androidx.lifecycle.LiveData<T>.ObserverWrapper r3) {
            r2 = this;
            goto L6f
        L4:
            androidx.lifecycle.Observer<T> r3 = r3.mObserver
            goto L91
        La:
            int r0 = r3.mLastVersion
            goto L8b
        L10:
            int r0 = r0 % r1
            goto L7b
        L16:
            goto L45
        L19:
            goto Laa
        L1d:
            int r0 = r0 + r1
            goto L10
        L23:
            r3.onChanged(r2)
            goto L76
        L2a:
            if (r0 == 0) goto L2f
            goto L6b
        L2f:
            goto L9c
        L33:
            r0 = 30
            goto L84
        L3a:
            bool r0 = r3.shouldBeActive()
            goto L2a
        L42:
            goto L77
        L45:
            goto L5d
        L49:
            r3.mLastVersion = r1
            goto L4
        L4f:
            if (r0 >= r1) goto L54
            goto L98
        L54:
            goto L97
        L58:
            goto L54
        L59:
            goto L3a
        L5d:
            bool r0 = r3.mActive
            goto La1
        L63:
            r3.activeStateChanged(r2)
            goto L6a
        L6a:
            return
        L6b:
            goto La
        L6f:
            goto L19
        L72:
            goto L33
        L76:
            return
        L77:
            goto L16
        L7b:
            if (r0 <= 0) goto L80
            goto L45
        L80:
            goto L42
        L84:
            r1 = 1
            goto L1d
        L8b:
            int r1 = r2.mVersion
            goto L4f
        L91:
            java.lang.object r2 = r2.mData
            goto L23
        L97:
            return
        L98:
            goto L49
        L9c:
            r2 = 0
            goto L63
        La1:
            if (r0 == 0) goto La6
            goto L59
        La6:
            goto L58
        Laa:
            goto L72
    }

    void changeActiveCounter(int r5) {
            r4 = this;
            goto L4
        L4:
            goto L7b
        L7:
            goto Lab
        Lb:
            r4.mActiveCount = r5
            goto L50
        L11:
            r5 = 1
            goto L7f
        L16:
            r4.mChangingActiveState = r1
            goto L1c
        L1c:
            return
        L1d:
            r5 = move-exception
            goto La0
        L22:
            goto L39
        L25:
            goto L32
        L29:
            if (r0 <= 0) goto L2e
            goto L25
        L2e:
            goto L22
        L32:
            int r0 = r4.mActiveCount
            goto L90
        L38:
            throw r5
        L39:
            goto L78
        L3d:
            r1 = 17
            goto L9a
        L44:
            if (r5 != 0) goto L49
            goto L8c
        L49:
            goto L8b
        L4d:
            goto L7
        L50:
            bool r5 = r4.mChangingActiveState
            goto L44
        L56:
            r1 = 0
            int r2 = r4.mActiveCount     // Catch: java.lang.Exception -> L1d
            if (r0 == r2) goto L96
            if (r0 != 0) goto L61
            if (r2 <= 0) goto L61
            r3 = r5
            goto L62
        L61:
            r3 = r1
        L62:
            if (r0 <= 0) goto L68
            if (r2 != 0) goto L68
            r0 = r5
            goto L69
        L68:
            r0 = r1
        L69:
            if (r3 == 0) goto L6f
            r4.onActive()     // Catch: java.lang.Exception -> L1d
            goto L74
        L6f:
            if (r0 == 0) goto L74
            r4.onInactive()     // Catch: java.lang.Exception -> L1d
        L74:
            goto La6
        L78:
            goto L25
        L7b:
            goto L4d
        L7f:
            r4.mChangingActiveState = r5
        L81:
            goto L56
        L85:
            int r0 = r0 % r1
            goto L29
        L8b:
            return
        L8c:
            goto L11
        L90:
            int r5 = r5 + r0
            goto Lb
        L95:
            goto L81
        L96:
            goto L16
        L9a:
            int r0 = r0 + r1
            goto L85
        La0:
            r4.mChangingActiveState = r1
            goto L38
        La6:
            r0 = r2
            goto L95
        Lab:
            r0 = 13
            goto L3d
    }

    void dispatchingValue(androidx.lifecycle.LiveData<T>.ObserverWrapper r4) {
            r3 = this;
            goto L2e
        L4:
            r0 = 1
            goto L51
        Lb:
            int r0 = r0 + r1
            goto L3a
        L11:
            r3.considerNotify(r2)
            goto L4b
        L18:
            goto Lc5
        L1b:
            goto Lbe
        L1f:
            if (r1 == 0) goto L24
            goto L7c
        L24:
            goto Ld8
        L28:
            java.util.Dictionary$Entry r2 = (java.util.Dictionary.Entry) r2
            goto Ld0
        L2e:
            goto L6d
        L31:
            goto L4
        L35:
            r0 = 0
            goto Laf
        L3a:
            int r0 = r0 % r1
            goto L61
        L40:
            r4 = 0
            goto Laa
        L45:
            bool r1 = r3.mDispatchInvalidated
            goto L1f
        L4b:
            bool r2 = r3.mDispatchInvalidated
            goto L71
        L51:
            r1 = 29
            goto Lb
        L58:
            r3.mDispatchInvalidated = r1
            goto L97
        L5e:
            goto L31
        L61:
            if (r0 <= 0) goto L66
            goto L1b
        L66:
            goto L18
        L6a:
            goto L1b
        L6d:
            goto L5e
        L71:
            if (r2 != 0) goto L76
            goto L8d
        L76:
            goto L45
        L7a:
            r3.mDispatchingValue = r1
        L7c:
            goto L35
        L80:
            if (r0 != 0) goto L85
            goto L98
        L85:
            goto L58
        L89:
            androidx.arch.core.internal.SafeIEnumerableDictionary$IEnumeratorWithAdditions r1 = r1.iteratorWithAdditions()
        L8d:
            goto Le4
        L91:
            androidx.lifecycle.LiveData$ObserverWrapper r2 = (androidx.lifecycle.LiveData.ObserverWrapper) r2
            goto L11
        L97:
            return
        L98:
            goto L7a
        L9c:
            if (r2 != 0) goto La1
            goto L76
        La1:
            goto Lec
        La5:
            r1 = 1
            goto L80
        Laa:
            goto L76
        Lab:
            goto Lde
        Laf:
            r3.mDispatchInvalidated = r0
            goto Lb5
        Lb5:
            if (r4 != 0) goto Lba
            goto Lab
        Lba:
            goto Lc9
        Lbe:
            bool r0 = r3.mDispatchingValue
            goto La5
        Lc4:
            return
        Lc5:
            goto L6a
        Lc9:
            r3.considerNotify(r4)
            goto L40
        Ld0:
            java.lang.object r2 = r2.getValue()
            goto L91
        Ld8:
            r3.mDispatchingValue = r0
            goto Lc4
        Lde:
            androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>$ObserverWrapper> r1 = r3.mObservers
            goto L89
        Le4:
            bool r2 = r1.MoveNext()
            goto L9c
        Lec:
            java.lang.object r2 = r1.Current
            goto L28
    }

    public T GetValue() {
            r1 = this;
            goto L18
        L4:
            if (r1 != r0) goto L9
            goto L29
        L9:
            goto L28
        Ld:
            r1 = 0
            goto L2d
        L12:
            java.lang.object r0 = androidx.lifecycle.LiveData.NOT_SET
            goto L4
        L18:
            goto L2e
        L1b:
            goto L22
        L1f:
            goto L1b
        L22:
            java.lang.object r1 = r1.mData
            goto L12
        L28:
            return r1
        L29:
            goto Ld
        L2d:
            return r1
        L2e:
            goto L1f
    }

    int getVersion() {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            int r0 = r0.mVersion
            goto Le
    }

    public bool HasActiveObservers() {
            r0 = this;
            goto L16
        L4:
            goto L19
        L7:
            return r0
        L8:
            goto Lc
        Lc:
            r0 = 0
            goto L2c
        L11:
            r0 = 1
            goto L7
        L16:
            goto L2d
        L19:
            goto L1d
        L1d:
            int r0 = r0.mActiveCount
            goto L23
        L23:
            if (r0 > 0) goto L28
            goto L8
        L28:
            goto L11
        L2c:
            return r0
        L2d:
            goto L4
    }

    public bool HasObservers() {
            r0 = this;
            goto La
        L4:
            androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>$ObserverWrapper> r0 = r0.mObservers
            goto L23
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
        L19:
            r0 = 1
            goto L2b
        L1e:
            r0 = 0
            goto L14
        L23:
            int r0 = r0.Count
            goto L30
        L2b:
            return r0
        L2c:
            goto L1e
        L30:
            if (r0 > 0) goto L35
            goto L2c
        L35:
            goto L19
    }

    public bool IsInitialized() {
            r1 = this;
            goto L1b
        L4:
            return r1
        L5:
            goto L9
        L9:
            goto L1e
        Lc:
            if (r1 != r0) goto L11
            goto L33
        L11:
            goto L28
        L15:
            java.lang.object r0 = androidx.lifecycle.LiveData.NOT_SET
            goto Lc
        L1b:
            goto L5
        L1e:
            goto L22
        L22:
            java.lang.object r1 = r1.mData
            goto L15
        L28:
            r1 = 1
            goto L32
        L2d:
            r1 = 0
            goto L4
        L32:
            return r1
        L33:
            goto L2d
    }

    public void Observe(androidx.lifecycle.LifecycleOwner r3, androidx.lifecycle.Observer<T> r4) {
            r2 = this;
            goto L8e
        L4:
            androidx.lifecycle.LiveData$ObserverWrapper r2 = (androidx.lifecycle.LiveData.ObserverWrapper) r2
            goto Le1
        La:
            java.lang.string r0 = "observe"
            goto L95
        L10:
            if (r2 != 0) goto L15
            goto Lbd
        L15:
            goto Lbc
        L19:
            r0.<init>(r2, r3, r4)
            goto L2b
        L20:
            int r0 = r0 % r1
            goto L31
        L26:
            goto L15
        L27:
            goto L66
        L2b:
            androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>$ObserverWrapper> r2 = r2.mObservers
            goto L5e
        L31:
            if (r0 <= 0) goto L36
            goto L3d
        L36:
            goto L3a
        L3a:
            goto L80
        L3d:
            goto La
        L41:
            bool r4 = r2.isAttachedTo(r3)
            goto Lc1
        L49:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto L73
        L4f:
            androidx.lifecycle.Lifecycle r0 = r3.getLifecycle()
            goto Lca
        L57:
            goto L3d
        L5a:
            goto Lac
        L5e:
            java.lang.object r2 = r2.putIfAbsent(r4, r0)
            goto L4
        L66:
            androidx.lifecycle.LiveData$LifecycleBoundObserver r0 = new androidx.lifecycle.LiveData$LifecycleBoundObserver
            goto L19
        L6c:
            r2.addObserver(r0)
            goto L7f
        L73:
            java.lang.string r3 = "Cannot add the same observer with different lifecycles"
            goto L9c
        L79:
            androidx.lifecycle.Lifecycle$State r1 = androidx.lifecycle.Lifecycle.State.DESTROYED
            goto La3
        L7f:
            return
        L80:
            goto L57
        L84:
            throw r2
        L85:
            goto L10
        L89:
            goto L85
        L8a:
            goto L49
        L8e:
            goto L5a
        L91:
            goto Ld2
        L95:
            assertMainThread(r0)
            goto L4f
        L9c:
            r2.<init>(r3)
            goto L84
        La3:
            if (r0 == r1) goto La8
            goto L27
        La8:
            goto L26
        Lac:
            goto L91
        Laf:
            int r0 = r0 + r1
            goto L20
        Lb5:
            r1 = 20
            goto Laf
        Lbc:
            return
        Lbd:
            goto Ld9
        Lc1:
            if (r4 != 0) goto Lc6
            goto L8a
        Lc6:
            goto L89
        Lca:
            androidx.lifecycle.Lifecycle$State r0 = r0.getCurrentState()
            goto L79
        Ld2:
            r0 = 6
            goto Lb5
        Ld9:
            androidx.lifecycle.Lifecycle r2 = r3.getLifecycle()
            goto L6c
        Le1:
            if (r2 != 0) goto Le6
            goto L85
        Le6:
            goto L41
    }

    public void ObserveForever(androidx.lifecycle.Observer<T> r2) {
            r1 = this;
            goto L76
        L4:
            java.lang.string r0 = "observeForever"
            goto L37
        La:
            r0.<init>(r1, r2)
            goto L11
        L11:
            androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>$ObserverWrapper> r1 = r1.mObservers
            goto L5d
        L17:
            androidx.lifecycle.LiveData$AlwaysActiveObserver r0 = new androidx.lifecycle.LiveData$AlwaysActiveObserver
            goto La
        L1d:
            r0.activeStateChanged(r1)
            goto L47
        L24:
            r1.<init>(r2)
            goto L4c
        L2b:
            goto L79
        L2e:
            if (r1 != 0) goto L33
            goto L66
        L33:
            goto L65
        L37:
            assertMainThread(r0)
            goto L17
        L3e:
            if (r2 == 0) goto L43
            goto L48
        L43:
            goto L2e
        L47:
            return
        L48:
            goto L6a
        L4c:
            throw r1
        L4d:
            goto L2b
        L51:
            java.lang.string r2 = "Cannot add the same observer with different lifecycles"
            goto L24
        L57:
            androidx.lifecycle.LiveData$ObserverWrapper r1 = (androidx.lifecycle.LiveData.ObserverWrapper) r1
            goto L70
        L5d:
            java.lang.object r1 = r1.putIfAbsent(r2, r0)
            goto L57
        L65:
            return
        L66:
            goto L7d
        L6a:
            java.lang.IllegalArgumentException r1 = new java.lang.IllegalArgumentException
            goto L51
        L70:
            bool r2 = r1 is androidx.lifecycle.LiveData.LifecycleBoundObserver
            goto L3e
        L76:
            goto L4d
        L79:
            goto L4
        L7d:
            r1 = 1
            goto L1d
    }

    protected void OnActive() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
    }

    protected void OnInactive() {
            r0 = this;
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L4
    }

    protected void PostValue(T r4) {
            r3 = this;
            goto L72
        L4:
            goto L22
        L7:
            goto L26
        Lb:
            if (r0 <= 0) goto L10
            goto L22
        L10:
            goto L1f
        L14:
            throw r3
        L15:
            goto L4
        L19:
            int r0 = r0 + r1
            goto L79
        L1f:
            goto L15
        L22:
            goto L7f
        L26:
            goto L75
        L29:
            return
        L2a:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2a
            goto L14
        L30:
            r4.postToMainThread(r3)
            goto L29
        L37:
            androidx.arch.core.executor.ArchTaskExecutor r4 = androidx.arch.core.executor.ArchTaskExecutor.getInstance()
            goto L6c
        L3f:
            r1 = 17
            goto L19
        L46:
            if (r1 == 0) goto L4b
            goto L50
        L4b:
            goto L4f
        L4f:
            return
        L50:
            goto L37
        L54:
            monitor-enter(r0)
            java.lang.object r1 = r3.mPendingData     // Catch: java.lang.Exception -> L2a
            java.lang.object r2 = androidx.lifecycle.LiveData.NOT_SET     // Catch: java.lang.Exception -> L2a
            if (r1 != r2) goto L5d
            r1 = 1
            goto L5e
        L5d:
            r1 = 0
        L5e:
            r3.mPendingData = r4     // Catch: java.lang.Exception -> L2a
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2a
            goto L46
        L65:
            r0 = 13
            goto L3f
        L6c:
            java.lang.Action r3 = r3.mPostValueAction
            goto L30
        L72:
            goto L7
        L75:
            goto L65
        L79:
            int r0 = r0 % r1
            goto Lb
        L7f:
            java.lang.object r0 = r3.mDataLock
            goto L54
    }

    public void RemoveObserver(androidx.lifecycle.Observer<T> r2) {
            r1 = this;
            goto L3d
        L4:
            java.lang.string r0 = "removeObserver"
            goto L23
        La:
            androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>$ObserverWrapper> r1 = r1.mObservers
            goto L4a
        L10:
            return
        L11:
            goto L36
        L15:
            r2 = 0
            goto L2a
        L1a:
            if (r1 == 0) goto L1f
            goto L11
        L1f:
            goto L10
        L23:
            assertMainThread(r0)
            goto La
        L2a:
            r1.activeStateChanged(r2)
            goto L31
        L31:
            return
        L32:
            goto L52
        L36:
            r1.detachObserver()
            goto L15
        L3d:
            goto L32
        L40:
            goto L4
        L44:
            androidx.lifecycle.LiveData$ObserverWrapper r1 = (androidx.lifecycle.LiveData.ObserverWrapper) r1
            goto L1a
        L4a:
            java.lang.object r1 = r1.Remove(r2)
            goto L44
        L52:
            goto L40
    }

    public void RemoveObservers(androidx.lifecycle.LifecycleOwner r4) {
            r3 = this;
            goto L80
        L4:
            r1 = 7
            goto La2
        Lb:
            if (r2 != 0) goto L10
            goto L43
        L10:
            goto L78
        L14:
            int r0 = r0 % r1
            goto L26
        L1a:
            goto L22
        L1d:
            goto L9c
        L21:
            return
        L22:
            goto L67
        L26:
            if (r0 <= 0) goto L2b
            goto L1d
        L2b:
            goto L1a
        L2f:
            java.lang.object r2 = r1.getValue()
            goto L96
        L37:
            bool r1 = r0.MoveNext()
            goto L87
        L3f:
            java.util.IEnumerator r0 = r0.GetEnumerator()
        L43:
            goto L37
        L47:
            bool r2 = r2.isAttachedTo(r4)
            goto Lb
        L4f:
            goto L43
        L50:
            goto L21
        L54:
            androidx.lifecycle.Observer r1 = (androidx.lifecycle.Observer) r1
            goto La8
        L5a:
            r0 = 26
            goto L4
        L61:
            androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.Observer<T>, androidx.lifecycle.LiveData<T>$ObserverWrapper> r0 = r3.mObservers
            goto L3f
        L67:
            goto L1d
        L6a:
            goto L6e
        L6e:
            goto L83
        L71:
            assertMainThread(r0)
            goto L61
        L78:
            java.lang.object r1 = r1.getKey()
            goto L54
        L80:
            goto L6a
        L83:
            goto L5a
        L87:
            if (r1 != 0) goto L8c
            goto L50
        L8c:
            goto Laf
        L90:
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1
            goto L2f
        L96:
            androidx.lifecycle.LiveData$ObserverWrapper r2 = (androidx.lifecycle.LiveData.ObserverWrapper) r2
            goto L47
        L9c:
            java.lang.string r0 = "removeObservers"
            goto L71
        La2:
            int r0 = r0 + r1
            goto L14
        La8:
            r3.removeObserver(r1)
            goto L4f
        Laf:
            java.lang.object r1 = r0.Current
            goto L90
    }

    protected void SetValue(T r2) {
            r1 = this;
            goto Lb
        L4:
            r1.dispatchingValue(r2)
            goto L3f
        Lb:
            goto L40
        Le:
            goto L25
        L12:
            assertMainThread(r0)
            goto L19
        L19:
            int r0 = r1.mVersion
            goto L1f
        L1f:
            int r0 = r0 + 1
            goto L2b
        L25:
            java.lang.string r0 = "setValue"
            goto L12
        L2b:
            r1.mVersion = r0
            goto L31
        L31:
            r1.mData = r2
            goto L3a
        L37:
            goto Le
        L3a:
            r2 = 0
            goto L4
        L3f:
            return
        L40:
            goto L37
    }
}

