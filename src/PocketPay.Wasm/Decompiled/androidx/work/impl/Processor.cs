namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
public class Processor : androidx.work.impl.foreground.ForegroundProcessor {
    private static readonly java.lang.string FOREGROUND_WAKELOCK_TAG = "ProcessorForegroundLck";
    private static readonly java.lang.string TAG = null;
    private android.content.object mAppobject;
    private java.util.HashSet<java.lang.string> mCancelledIds;
    private androidx.work.Configuration mConfiguration;
    private java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> mEnqueuedWorkDictionary;
    private android.os.PowerManager.WakeLock mForegroundLock;
    private java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> mForegroundWorkDictionary;
    private readonly java.lang.object mLock;
    private readonly java.util.List<androidx.work.impl.ExecutionListener> mOuterListeners;
    private androidx.work.impl.WorkDatabase mWorkDatabase;
    private java.util.Dictionary<java.lang.string, java.util.HashSet<androidx.work.impl.StartStopToken>> mWorkRuns;
    private androidx.work.impl.utils.taskexecutor.TaskExecutor mWorkTaskExecutor;

    static {
            goto Ld
        L4:
            goto L10
        L7:
            java.lang.string r0 = "Processor"
            goto L14
        Ld:
            goto L1d
        L10:
            goto L7
        L14:
            java.lang.string r0 = androidx.work.Consoleger.tagWithPrefix(r0)
            goto L21
        L1c:
            return
        L1d:
            goto L4
        L21:
            androidx.work.impl.Processor.TAG = r0
            goto L1c
    }

    public Processor(android.content.object r1, androidx.work.Configuration r2, androidx.work.impl.utils.taskexecutor.TaskExecutor r3, androidx.work.impl.WorkDatabase r4) {
            r0 = this;
            goto La
        L4:
            r0.mCancelledIds = r1
            goto L11
        La:
            goto L86
        Ld:
            goto L37
        L11:
            java.util.List r1 = new java.util.List
            goto L1d
        L17:
            r0.mAppobject = r1
            goto L45
        L1d:
            r1.<init>()
            goto L24
        L24:
            r0.mOuterListeners = r1
            goto L8a
        L2a:
            java.lang.object r1 = new java.lang.object
            goto L8f
        L30:
            r1.<init>()
            goto La3
        L37:
            r0.<init>()
            goto L17
        L3e:
            r1.<init>()
            goto L51
        L45:
            r0.mConfiguration = r2
            goto L96
        L4b:
            r0.mEnqueuedWorkDictionary = r1
            goto L63
        L51:
            r0.mForegroundWorkDictionary = r1
            goto L79
        L57:
            r0.mLock = r1
            goto L5d
        L5d:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L30
        L63:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L3e
        L69:
            goto Ld
        L6c:
            r1.<init>()
            goto L4b
        L73:
            r0.mWorkDatabase = r4
            goto La9
        L79:
            java.util.HashHashSet r1 = new java.util.HashHashSet
            goto L9c
        L7f:
            r0.mForegroundLock = r1
            goto L2a
        L85:
            return
        L86:
            goto L69
        L8a:
            r1 = 0
            goto L7f
        L8f:
            r1.<init>()
            goto L57
        L96:
            r0.mWorkTaskExecutor = r3
            goto L73
        L9c:
            r1.<init>()
            goto L4
        La3:
            r0.mWorkRuns = r1
            goto L85
        La9:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L6c
    }

    private androidx.work.impl.WorkerWrapper CleanUpWorkerUnsafe(java.lang.string r4) {
            r3 = this;
            goto L21
        L4:
            if (r1 != 0) goto L9
            goto L6b
        L9:
            goto L68
        Ld:
            java.lang.object r0 = r0.Remove(r4)
            goto L3b
        L15:
            goto L24
        L18:
            if (r0 <= 0) goto L1d
            goto L49
        L1d:
            goto L46
        L21:
            goto L7b
        L24:
            goto L4d
        L28:
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r0 = r3.mEnqueuedWorkDictionary
            goto L5a
        L2e:
            int r0 = r0 % r1
            goto L18
        L34:
            r2.Remove(r4)
            goto L4
        L3b:
            androidx.work.impl.WorkerWrapper r0 = (androidx.work.impl.WorkerWrapper) r0
            goto L6f
        L41:
            r1 = 1
            goto L9e
        L46:
            goto L80
        L49:
            goto L62
        L4d:
            r0 = 24
            goto La3
        L54:
            int r0 = r0 + r1
            goto L2e
        L5a:
            java.lang.object r0 = r0.Remove(r4)
            goto L8d
        L62:
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r0 = r3.mForegroundWorkDictionary
            goto Ld
        L68:
            r3.stopForegroundService()
        L6b:
            goto L7f
        L6f:
            if (r0 != 0) goto L74
            goto L9f
        L74:
            goto L41
        L78:
            goto L49
        L7b:
            goto L15
        L7f:
            return r0
        L80:
            goto L78
        L84:
            if (r1 == 0) goto L89
            goto L8f
        L89:
            goto L28
        L8d:
            androidx.work.impl.WorkerWrapper r0 = (androidx.work.impl.WorkerWrapper) r0
        L8f:
            goto L93
        L93:
            java.util.Dictionary<java.lang.string, java.util.HashSet<androidx.work.impl.StartStopToken>> r2 = r3.mWorkRuns
            goto L34
        L99:
            r1 = 0
        L9a:
            goto L84
        L9e:
            goto L9a
        L9f:
            goto L99
        La3:
            r1 = 4
            goto L54
    }

    private androidx.work.impl.WorkerWrapper GetWorkerWrapperUnsafe(java.lang.string r2) {
            r1 = this;
            goto L28
        L4:
            java.lang.object r0 = r0[r2)
            goto L22
        Lc:
            return r0
        Ld:
            goto L3e
        L11:
            return r1
        L12:
            goto Lc
        L16:
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r0 = r1.mForegroundWorkDictionary
            goto L4
        L1c:
            androidx.work.impl.WorkerWrapper r1 = (androidx.work.impl.WorkerWrapper) r1
            goto L11
        L22:
            androidx.work.impl.WorkerWrapper r0 = (androidx.work.impl.WorkerWrapper) r0
            goto L35
        L28:
            goto Ld
        L2b:
            goto L16
        L2f:
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r1 = r1.mEnqueuedWorkDictionary
            goto L41
        L35:
            if (r0 == 0) goto L3a
            goto L12
        L3a:
            goto L2f
        L3e:
            goto L2b
        L41:
            java.lang.object r1 = r1[r2)
            goto L1c
    }

    private static bool Interrupt(java.lang.string r2, androidx.work.impl.WorkerWrapper r3, int r4) {
            goto L7c
        L4:
            r0.<init>(r1)
            goto Lbc
        Lb:
            r3.debug(r4, r2)
            goto L83
        L12:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lb6
        L18:
            androidx.work.Consoleger r3 = androidx.work.Consoleger[)
            goto L2d
        L20:
            goto L34
        L23:
            goto L59
        L27:
            int r0 = r0 + r1
            goto L45
        L2d:
            java.lang.string r4 = androidx.work.impl.Processor.TAG
            goto L12
        L33:
            return r2
        L34:
            goto Lc4
        L38:
            r0.<init>(r1)
            goto La7
        L3f:
            java.lang.string r1 = "WorkerWrapper could not be found for "
            goto L4
        L45:
            int r0 = r0 % r1
            goto L50
        L4b:
            r2 = 1
            goto L8f
        L50:
            if (r0 <= 0) goto L55
            goto L23
        L55:
            goto L20
        L59:
            if (r3 != 0) goto L5e
            goto L90
        L5e:
            goto Laf
        L62:
            goto L7f
        L65:
            java.lang.string r2 = r2.tostring()
            goto L94
        L6d:
            androidx.work.Consoleger r3 = androidx.work.Consoleger[)
            goto La1
        L75:
            r1 = 5
            goto L27
        L7c:
            goto Lc7
        L7f:
            goto L88
        L83:
            r2 = 0
            goto L33
        L88:
            r0 = 29
            goto L75
        L8f:
            return r2
        L90:
            goto L6d
        L94:
            r3.debug(r4, r2)
            goto L4b
        L9b:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L3f
        La1:
            java.lang.string r4 = androidx.work.impl.Processor.TAG
            goto L9b
        La7:
            java.lang.stringBuilder r2 = r0.append(r2)
            goto L65
        Laf:
            r3.interrupt(r4)
            goto L18
        Lb6:
            java.lang.string r1 = "WorkerWrapper interrupted for "
            goto L38
        Lbc:
            java.lang.stringBuilder r2 = r0.append(r2)
            goto Lcb
        Lc4:
            goto L23
        Lc7:
            goto L62
        Lcb:
            java.lang.string r2 = r2.tostring()
            goto Lb
    }

    private void OnExecuted(androidx.work.impl.WorkerWrapper r7, bool r8) {
            r6 = this;
            goto L9
        L4:
            throw r6
        L5:
            goto L17
        L9:
            goto L1a
        Lc:
            goto L10
        L10:
            r0 = 5
            goto L9c
        L17:
            goto L92
        L1a:
            goto L1e
        L1e:
            goto Lc
        L21:
            int r0 = r0 + r1
            goto L96
        L27:
            monitor-enter(r0)
            androidx.work.impl.model.WorkGenerationalId r1 = r7.getWorkGenerationalId()     // Catch: java.lang.Exception -> L83
            java.lang.string r2 = r1.getWorkSpecId()     // Catch: java.lang.Exception -> L83
            androidx.work.impl.WorkerWrapper r3 = r6.getWorkerWrapperUnsafe(r2)     // Catch: java.lang.Exception -> L83
            if (r3 != r7) goto L39
            r6.cleanUpWorkerUnsafe(r2)     // Catch: java.lang.Exception -> L83
        L39:
            androidx.work.Consoleger r7 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> L83
            java.lang.string r3 = androidx.work.impl.Processor.TAG     // Catch: java.lang.Exception -> L83
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L83
            r4.<init>()     // Catch: java.lang.Exception -> L83
            java.lang.Class r5 = r6.GetType()     // Catch: java.lang.Exception -> L83
            java.lang.string r5 = r5.getSimpleName()     // Catch: java.lang.Exception -> L83
            java.lang.stringBuilder r4 = r4.append(r5)     // Catch: java.lang.Exception -> L83
            java.lang.string r5 = " "
            java.lang.stringBuilder r4 = r4.append(r5)     // Catch: java.lang.Exception -> L83
            java.lang.stringBuilder r2 = r4.append(r2)     // Catch: java.lang.Exception -> L83
            java.lang.string r4 = " executed; reschedule = "
            java.lang.stringBuilder r2 = r2.append(r4)     // Catch: java.lang.Exception -> L83
            java.lang.stringBuilder r2 = r2.append(r8)     // Catch: java.lang.Exception -> L83
            java.lang.string r2 = r2.tostring()     // Catch: java.lang.Exception -> L83
            r7.debug(r3, r2)     // Catch: java.lang.Exception -> L83
            java.util.List<androidx.work.impl.ExecutionListener> r6 = r6.mOuterListeners     // Catch: java.lang.Exception -> L83
            java.util.IEnumerator r6 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L83
        L71:
            bool r7 = r6.MoveNext()     // Catch: java.lang.Exception -> L83
            if (r7 == 0) goto L81
            java.lang.object r7 = r6.Current     // Catch: java.lang.Exception -> L83
            androidx.work.impl.ExecutionListener r7 = (androidx.work.impl.ExecutionListener) r7     // Catch: java.lang.Exception -> L83
            r7.onExecuted(r1, r8)     // Catch: java.lang.Exception -> L83
            goto L71
        L81:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L83
            return
        L83:
            r6 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L83
            goto L4
        L89:
            java.lang.object r0 = r6.mLock
            goto L27
        L8f:
            goto L5
        L92:
            goto L89
        L96:
            int r0 = r0 % r1
            goto La3
        L9c:
            r1 = 11
            goto L21
        La3:
            if (r0 <= 0) goto La8
            goto L92
        La8:
            goto L8f
    }

    private void RunOnExecuted(androidx.work.impl.model.WorkGenerationalId r3, bool r4) {
            r2 = this;
            goto L5f
        L4:
            r1 = 18
            goto Lb
        Lb:
            int r0 = r0 + r1
            goto L1f
        L11:
            goto L26
        L14:
            goto L52
        L18:
            goto L14
        L1b:
            goto L4f
        L1f:
            int r0 = r0 % r1
            goto L2a
        L25:
            return
        L26:
            goto L18
        L2a:
            if (r0 <= 0) goto L2f
            goto L14
        L2f:
            goto L11
        L33:
            androidx.work.impl.Processor$$ExternalSyntheticLambda0 r1 = new androidx.work.impl.Processor$$ExternalSyntheticLambda0
            goto L48
        L39:
            java.util.concurrent.Executor r0 = r0.getMainThreadExecutor()
            goto L33
        L41:
            r0 = 8
            goto L4
        L48:
            r1.<init>(r2, r3, r4)
            goto L58
        L4f:
            goto L62
        L52:
            androidx.work.impl.utils.taskexecutor.TaskExecutor r0 = r2.mWorkTaskExecutor
            goto L39
        L58:
            r0.execute(r1)
            goto L25
        L5f:
            goto L1b
        L62:
            goto L41
    }

    private void StopForegroundService() {
            r5 = this;
            goto L29
        L4:
            if (r0 <= 0) goto L9
            goto L13
        L9:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L1f
        L13:
            goto L23
        L17:
            r0 = 19
            goto L48
        L1e:
            throw r5
        L1f:
            goto L6e
        L23:
            java.lang.object r0 = r5.mLock
            goto L30
        L29:
            goto L71
        L2c:
            goto L17
        L30:
            monitor-enter(r0)
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r1 = r5.mForegroundWorkDictionary     // Catch: java.lang.Exception -> L68
            bool r1 = r1.Count == 0     // Catch: java.lang.Exception -> L68
            if (r1 == 0) goto L66
            android.content.object r1 = r5.mAppobject     // Catch: java.lang.Exception -> L68
            android.content.object r1 = androidx.work.impl.foreground.SystemForegroundDispatcher.createStopForegroundobject(r1)     // Catch: java.lang.Exception -> L68
            android.content.object r2 = r5.mAppobject     // Catch: java.lang.Exception -> L50
            r2.startService(r1)     // Catch: java.lang.Exception -> L50
            goto L4f
        L48:
            r1 = 6
            goto L75
        L4f:
            goto L5c
        L50:
            r1 = move-exception
            androidx.work.Consoleger r2 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> L68
            java.lang.string r3 = androidx.work.impl.Processor.TAG     // Catch: java.lang.Exception -> L68
            java.lang.string r4 = "Unable to stop foreground service"
            r2.error(r3, r4, r1)     // Catch: java.lang.Exception -> L68
        L5c:
            android.os.PowerManager$WakeLock r1 = r5.mForegroundLock     // Catch: java.lang.Exception -> L68
            if (r1 == 0) goto L66
            r1.release()     // Catch: java.lang.Exception -> L68
            r1 = 0
            r5.mForegroundLock = r1     // Catch: java.lang.Exception -> L68
        L66:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L68
            return
        L68:
            r5 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L68
            goto L1e
        L6e:
            goto L13
        L71:
            goto Ld
        L75:
            int r0 = r0 + r1
            goto L7b
        L7b:
            int r0 = r0 % r1
            goto L4
    }

    public void AddExecutionListener(androidx.work.impl.ExecutionListener r2) {
            r1 = this;
            goto L4
        L4:
            goto L23
        L7:
            goto L1c
        Lb:
            monitor-enter(r0)
            java.util.List<androidx.work.impl.ExecutionListener> r1 = r1.mOuterListeners     // Catch: java.lang.Exception -> L13
            r1.Add(r2)     // Catch: java.lang.Exception -> L13
            monitor-exit(r0)     // Catch: java.lang.Exception -> L13
            return
        L13:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L13
            goto L22
        L19:
            goto L7
        L1c:
            java.lang.object r0 = r1.mLock
            goto Lb
        L22:
            throw r1
        L23:
            goto L19
    }

    public androidx.work.impl.model.WorkSpec GetRunningWorkSpec(java.lang.string r2) {
            r1 = this;
            goto L22
        L4:
            throw r1
        L5:
            goto L1f
        L9:
            monitor-enter(r0)
            androidx.work.impl.WorkerWrapper r1 = r1.getWorkerWrapperUnsafe(r2)     // Catch: java.lang.Exception -> L19
            if (r1 == 0) goto L16
            androidx.work.impl.model.WorkSpec r1 = r1.getWorkSpec()     // Catch: java.lang.Exception -> L19
            monitor-exit(r0)     // Catch: java.lang.Exception -> L19
            return r1
        L16:
            r1 = 0
            monitor-exit(r0)     // Catch: java.lang.Exception -> L19
            return r1
        L19:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L19
            goto L4
        L1f:
            goto L25
        L22:
            goto L5
        L25:
            goto L29
        L29:
            java.lang.object r0 = r1.mLock
            goto L9
    }

    public bool HasWork() {
            r2 = this;
            goto L9
        L4:
            throw r2
        L5:
            goto L44
        L9:
            goto L47
        Lc:
            goto L10
        L10:
            r0 = 1
            goto L17
        L17:
            r1 = 25
            goto L5a
        L1e:
            monitor-enter(r0)
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r1 = r2.mEnqueuedWorkDictionary     // Catch: java.lang.Exception -> L35
            bool r1 = r1.Count == 0     // Catch: java.lang.Exception -> L35
            if (r1 == 0) goto L32
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r2 = r2.mForegroundWorkDictionary     // Catch: java.lang.Exception -> L35
            bool r2 = r2.Count == 0     // Catch: java.lang.Exception -> L35
            if (r2 != 0) goto L30
            goto L32
        L30:
            r2 = 0
            goto L33
        L32:
            r2 = 1
        L33:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L35
            return r2
        L35:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L35
            goto L4
        L3b:
            goto Lc
        L3e:
            java.lang.object r0 = r2.mLock
            goto L1e
        L44:
            goto L63
        L47:
            goto L3b
        L4b:
            int r0 = r0 % r1
            goto L51
        L51:
            if (r0 <= 0) goto L56
            goto L63
        L56:
            goto L60
        L5a:
            int r0 = r0 + r1
            goto L4b
        L60:
            goto L5
        L63:
            goto L3e
    }

    public bool IsCancelled(java.lang.string r2) {
            r1 = this;
            goto L21
        L4:
            monitor-enter(r0)
            java.util.HashSet<java.lang.string> r1 = r1.mCancelledIds     // Catch: java.lang.Exception -> Ld
            bool r1 = r1.Contains(r2)     // Catch: java.lang.Exception -> Ld
            monitor-exit(r0)     // Catch: java.lang.Exception -> Ld
            return r1
        Ld:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Ld
            goto L13
        L13:
            throw r1
        L14:
            goto L1e
        L18:
            java.lang.object r0 = r1.mLock
            goto L4
        L1e:
            goto L24
        L21:
            goto L14
        L24:
            goto L18
    }

    public bool IsEnqueued(java.lang.string r2) {
            r1 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            throw r1
        Lf:
            goto Lb
        L13:
            java.lang.object r0 = r1.mLock
            goto L19
        L19:
            monitor-enter(r0)
            androidx.work.impl.WorkerWrapper r1 = r1.getWorkerWrapperUnsafe(r2)     // Catch: java.lang.Exception -> L25
            if (r1 == 0) goto L22
            r1 = 1
            goto L23
        L22:
            r1 = 0
        L23:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L25
            return r1
        L25:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L25
            goto Le
    }

    /* JADX INFO: renamed from: lambda$runOnExecuted$2$androidx-work-impl-Processor, reason: not valid java name */
    /* synthetic */ void m856lambda$runOnExecuted$2$androidxworkimplProcessor(androidx.work.impl.model.WorkGenerationalId r3, bool r4) {
            r2 = this;
            goto Ld
        L4:
            if (r0 <= 0) goto L9
            goto L17
        L9:
            goto L14
        Ld:
            goto L33
        L10:
            goto L37
        L14:
            goto L23
        L17:
            goto L27
        L1b:
            r1 = 4
            goto L3e
        L22:
            throw r2
        L23:
            goto L30
        L27:
            java.lang.object r0 = r2.mLock
            goto L4a
        L2d:
            goto L10
        L30:
            goto L17
        L33:
            goto L2d
        L37:
            r0 = 8
            goto L1b
        L3e:
            int r0 = r0 + r1
            goto L44
        L44:
            int r0 = r0 % r1
            goto L4
        L4a:
            monitor-enter(r0)
            java.util.List<androidx.work.impl.ExecutionListener> r2 = r2.mOuterListeners     // Catch: java.lang.Exception -> L63
            java.util.IEnumerator r2 = r2.GetEnumerator()     // Catch: java.lang.Exception -> L63
        L51:
            bool r1 = r2.MoveNext()     // Catch: java.lang.Exception -> L63
            if (r1 == 0) goto L61
            java.lang.object r1 = r2.Current     // Catch: java.lang.Exception -> L63
            androidx.work.impl.ExecutionListener r1 = (androidx.work.impl.ExecutionListener) r1     // Catch: java.lang.Exception -> L63
            r1.onExecuted(r3, r4)     // Catch: java.lang.Exception -> L63
            goto L51
        L61:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L63
            return
        L63:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L63
            goto L22
    }

    /* JADX INFO: renamed from: lambda$startWork$0$androidx-work-impl-Processor, reason: not valid java name */
    /* synthetic */ androidx.work.impl.model.WorkSpec m857lambda$startWork$0$androidxworkimplProcessor(java.util.List r2, java.lang.string r3) throws java.lang.Exception {
            r1 = this;
            goto L27
        L4:
            goto L2a
        L7:
            r2.addAll(r0)
            goto Le
        Le:
            androidx.work.impl.WorkDatabase r1 = r1.mWorkDatabase
            goto L36
        L14:
            androidx.work.impl.WorkDatabase r0 = r1.mWorkDatabase
            goto L1f
        L1a:
            return r1
        L1b:
            goto L4
        L1f:
            androidx.work.impl.model.WorkTagDao r0 = r0.workTagDao()
            goto L2e
        L27:
            goto L1b
        L2a:
            goto L14
        L2e:
            java.util.List r0 = r0.getTagsForWorkSpecId(r3)
            goto L7
        L36:
            androidx.work.impl.model.WorkSpecDao r1 = r1.workSpecDao()
            goto L3e
        L3e:
            androidx.work.impl.model.WorkSpec r1 = r1.getWorkSpec(r3)
            goto L1a
    }

    /* JADX INFO: renamed from: lambda$startWork$1$androidx-work-impl-Processor, reason: not valid java name */
    /* synthetic */ void m858lambda$startWork$1$androidxworkimplProcessor(com.google.common.util.concurrent.ListenableTask r1, androidx.work.impl.WorkerWrapper r2) {
            r0 = this;
            goto L4
        L4:
            goto L2a
        L7:
            java.lang.object r1 = r1[)     // Catch: java.lang.Exception -> L1b
            java.lang.bool r1 = (java.lang.bool) r1     // Catch: java.lang.Exception -> L1b
            bool r1 = r1.boolValue()     // Catch: java.lang.Exception -> L1b
            goto L1a
        L15:
            r1 = 1
        L16:
            goto L1f
        L1a:
            goto L16
        L1b:
            goto L15
        L1f:
            r0.onExecuted(r2, r1)
            goto L29
        L26:
            goto L7
        L29:
            return
        L2a:
            goto L26
    }

    public void RemoveExecutionListener(androidx.work.impl.ExecutionListener r2) {
            r1 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.mLock
            goto L16
        L11:
            throw r1
        L12:
            goto L24
        L16:
            monitor-enter(r0)
            java.util.List<androidx.work.impl.ExecutionListener> r1 = r1.mOuterListeners     // Catch: java.lang.Exception -> L1e
            r1.Remove(r2)     // Catch: java.lang.Exception -> L1e
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            return
        L1e:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            goto L11
        L24:
            goto L7
    }

    @Override // androidx.work.impl.foreground.ForegroundProcessor
    public void StartForeground(java.lang.string r6, androidx.work.ForegroundInfo r7) {
            r5 = this;
            goto L9d
        L4:
            java.lang.object r1 = r5.mLock
            goto L1c
        La:
            int r0 = r0 + r1
            goto L77
        L10:
            throw r5
        L11:
            goto L15
        L15:
            goto L96
        L18:
            goto L9a
        L1c:
            monitor-enter(r1)
            androidx.work.Consoleger r2 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> L6a
            java.lang.string r3 = androidx.work.impl.Processor.TAG     // Catch: java.lang.Exception -> L6a
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L6a
            r4.<init>(r0)     // Catch: java.lang.Exception -> L6a
            java.lang.stringBuilder r0 = r4.append(r6)     // Catch: java.lang.Exception -> L6a
            java.lang.string r4 = ") to the foreground"
            java.lang.stringBuilder r0 = r0.append(r4)     // Catch: java.lang.Exception -> L6a
            java.lang.string r0 = r0.tostring()     // Catch: java.lang.Exception -> L6a
            r2.info(r3, r0)     // Catch: java.lang.Exception -> L6a
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r0 = r5.mEnqueuedWorkDictionary     // Catch: java.lang.Exception -> L6a
            java.lang.object r0 = r0.Remove(r6)     // Catch: java.lang.Exception -> L6a
            androidx.work.impl.WorkerWrapper r0 = (androidx.work.impl.WorkerWrapper) r0     // Catch: java.lang.Exception -> L6a
            if (r0 == 0) goto L68
            android.os.PowerManager$WakeLock r2 = r5.mForegroundLock     // Catch: java.lang.Exception -> L6a
            if (r2 != 0) goto L54
            android.content.object r2 = r5.mAppobject     // Catch: java.lang.Exception -> L6a
            java.lang.string r3 = "ProcessorForegroundLck"
            android.os.PowerManager$WakeLock r2 = androidx.work.impl.utils.WakeLocks.newWakeLock(r2, r3)     // Catch: java.lang.Exception -> L6a
            r5.mForegroundLock = r2     // Catch: java.lang.Exception -> L6a
            r2.acquire()     // Catch: java.lang.Exception -> L6a
        L54:
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r2 = r5.mForegroundWorkDictionary     // Catch: java.lang.Exception -> L6a
            r2.Add(r6, r0)     // Catch: java.lang.Exception -> L6a
            android.content.object r6 = r5.mAppobject     // Catch: java.lang.Exception -> L6a
            androidx.work.impl.model.WorkGenerationalId r0 = r0.getWorkGenerationalId()     // Catch: java.lang.Exception -> L6a
            android.content.object r6 = androidx.work.impl.foreground.SystemForegroundDispatcher.createStartForegroundobject(r6, r0, r7)     // Catch: java.lang.Exception -> L6a
            android.content.object r5 = r5.mAppobject     // Catch: java.lang.Exception -> L6a
            androidx.core.content.objectCompat.startForegroundService(r5, r6)     // Catch: java.lang.Exception -> L6a
        L68:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L6a
            return
        L6a:
            r5 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L6a
            goto L10
        L70:
            r1 = 10
            goto La
        L77:
            int r0 = r0 % r1
            goto L7d
        L7d:
            if (r0 <= 0) goto L82
            goto L96
        L82:
            goto L93
        L86:
            r0 = 26
            goto L70
        L8d:
            java.lang.string r0 = "Moving WorkSpec ("
            goto L4
        L93:
            goto L11
        L96:
            goto L8d
        L9a:
            goto La0
        L9d:
            goto L18
        La0:
            goto L86
    }

    public bool StartWork(androidx.work.impl.StartStopToken r2) {
            r1 = this;
            goto L11
        L4:
            r0 = 0
            goto L18
        L9:
            goto L14
        Lc:
            return r1
        Ld:
            goto L9
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            bool r1 = r1.startWork(r2, r0)
            goto Lc
    }

    public bool StartWork(androidx.work.impl.StartStopToken r13, androidx.work.WorkerParameters.RuntimeExtras r14) {
            r12 = this;
            goto Lc5
        L4:
            throw r12
        L5:
            goto L1cc
        L9:
            java.util.List r10 = new java.util.List
            goto L1af
        Lf:
            java.lang.string r2 = r1.getWorkSpecId()
            goto L9
        L17:
            r12 = r0
            monitor-exit(r11)     // Catch: java.lang.Exception -> L40
            goto L4
        L1d:
            java.lang.string r13 = androidx.work.impl.Processor.TAG
            goto L1a9
        L23:
            goto Lc8
        L26:
            androidx.work.impl.Processor$$ExternalSyntheticLambda1 r4 = new androidx.work.impl.Processor$$ExternalSyntheticLambda1
            goto L1d3
        L2c:
            java.lang.string r0 = r0.getSimpleName()
            goto La5
        L34:
            r12 = 1
            goto L3f
        L39:
            int r0 = r0 + r1
            goto L97
        L3f:
            return r12
        L40:
            r0 = move-exception
            goto L17
        L45:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L75
        L4b:
            java.lang.object r3 = r3.runInTransaction(r4)
            goto Lcc
        L53:
            r3 = 0
            goto L86
        L58:
            r1 = 32
            goto L39
        L5f:
            goto L5
        L62:
            goto L16b
        L66:
            r0.<init>(r2)
            goto L1bd
        L6d:
            java.lang.Class r0 = r7.GetType()
            goto L2c
        L75:
            java.lang.string r2 = "Didn't find WorkSpec for id "
            goto L66
        L7b:
            androidx.work.impl.model.WorkSpec r9 = (androidx.work.impl.model.WorkSpec) r9
            goto L53
        L81:
            return r3
        L82:
            goto L19c
        L86:
            if (r9 == 0) goto L8b
            goto L82
        L8b:
            goto L194
        L8f:
            java.lang.string r0 = r0.tostring()
            goto L17d
        L97:
            int r0 = r0 % r1
            goto Lb5
        L9d:
            java.lang.stringBuilder r14 = r14.append(r0)
            goto L184
        La5:
            java.lang.stringBuilder r14 = r14.append(r0)
            goto L177
        Lad:
            androidx.work.Consoleger r12 = androidx.work.Consoleger[)
            goto L1d
        Lb5:
            if (r0 <= 0) goto Lba
            goto L62
        Lba:
            goto L5f
        Lbe:
            r12.runOnExecuted(r1, r3)
            goto L81
        Lc5:
            goto L1cf
        Lc8:
            goto L1c5
        Lcc:
            r9 = r3
            goto L7b
        Ld1:
            monitor-enter(r11)
            bool r4 = r12.isEnqueued(r2)     // Catch: java.lang.Exception -> L40
            if (r4 == 0) goto L11d
            java.util.Dictionary<java.lang.string, java.util.HashSet<androidx.work.impl.StartStopToken>> r14 = r12.mWorkRuns     // Catch: java.lang.Exception -> L40
            java.lang.object r14 = r14[r2)     // Catch: java.lang.Exception -> L40
            java.util.HashSet r14 = (java.util.HashSet) r14     // Catch: java.lang.Exception -> L40
            java.util.IEnumerator r2 = r14.GetEnumerator()     // Catch: java.lang.Exception -> L40
            java.lang.object r2 = r2.Current     // Catch: java.lang.Exception -> L40
            androidx.work.impl.StartStopToken r2 = (androidx.work.impl.StartStopToken) r2     // Catch: java.lang.Exception -> L40
            androidx.work.impl.model.WorkGenerationalId r2 = r2.getId()     // Catch: java.lang.Exception -> L40
            int r2 = r2.getGeneration()     // Catch: java.lang.Exception -> L40
            int r4 = r1.getGeneration()     // Catch: java.lang.Exception -> L40
            if (r2 != r4) goto L118
            r14.Add(r13)     // Catch: java.lang.Exception -> L40
            androidx.work.Consoleger r12 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> L40
            java.lang.string r13 = androidx.work.impl.Processor.TAG     // Catch: java.lang.Exception -> L40
            java.lang.stringBuilder r14 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L40
            r14.<init>(r0)     // Catch: java.lang.Exception -> L40
            java.lang.stringBuilder r14 = r14.append(r1)     // Catch: java.lang.Exception -> L40
            java.lang.string r0 = " is already enqueued for processing"
            java.lang.stringBuilder r14 = r14.append(r0)     // Catch: java.lang.Exception -> L40
            java.lang.string r14 = r14.tostring()     // Catch: java.lang.Exception -> L40
            r12.debug(r13, r14)     // Catch: java.lang.Exception -> L40
            goto L11b
        L118:
            r12.runOnExecuted(r1, r3)     // Catch: java.lang.Exception -> L40
        L11b:
            monitor-exit(r11)     // Catch: java.lang.Exception -> L40
            return r3
        L11d:
            int r0 = r9.getGeneration()     // Catch: java.lang.Exception -> L40
            int r4 = r1.getGeneration()     // Catch: java.lang.Exception -> L40
            if (r0 == r4) goto L12c
            r12.runOnExecuted(r1, r3)     // Catch: java.lang.Exception -> L40
            monitor-exit(r11)     // Catch: java.lang.Exception -> L40
            return r3
        L12c:
            androidx.work.impl.WorkerWrapper$Builder r3 = new androidx.work.impl.WorkerWrapper$Builder     // Catch: java.lang.Exception -> L40
            android.content.object r4 = r12.mAppobject     // Catch: java.lang.Exception -> L40
            androidx.work.Configuration r5 = r12.mConfiguration     // Catch: java.lang.Exception -> L40
            androidx.work.impl.utils.taskexecutor.TaskExecutor r6 = r12.mWorkTaskExecutor     // Catch: java.lang.Exception -> L40
            androidx.work.impl.WorkDatabase r8 = r12.mWorkDatabase     // Catch: java.lang.Exception -> L40
            r7 = r12
            r3.<init>(r4, r5, r6, r7, r8, r9, r10)     // Catch: java.lang.Exception -> L40
            androidx.work.impl.WorkerWrapper$Builder r12 = r3.withRuntimeExtras(r14)     // Catch: java.lang.Exception -> L40
            androidx.work.impl.WorkerWrapper r12 = r12.build()     // Catch: java.lang.Exception -> L40
            com.google.common.util.concurrent.ListenableTask r14 = r12.launch()     // Catch: java.lang.Exception -> L40
            androidx.work.impl.Processor$$ExternalSyntheticLambda2 r0 = new androidx.work.impl.Processor$$ExternalSyntheticLambda2     // Catch: java.lang.Exception -> L40
            r0.<init>(r7, r14, r12)     // Catch: java.lang.Exception -> L40
            androidx.work.impl.utils.taskexecutor.TaskExecutor r3 = r7.mWorkTaskExecutor     // Catch: java.lang.Exception -> L40
            java.util.concurrent.Executor r3 = r3.getMainThreadExecutor()     // Catch: java.lang.Exception -> L40
            r14.addListener(r0, r3)     // Catch: java.lang.Exception -> L40
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r14 = r7.mEnqueuedWorkDictionary     // Catch: java.lang.Exception -> L40
            r14.Add(r2, r12)     // Catch: java.lang.Exception -> L40
            java.util.HashHashSet r12 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L40
            r12.<init>()     // Catch: java.lang.Exception -> L40
            r12.Add(r13)     // Catch: java.lang.Exception -> L40
            java.util.Dictionary<java.lang.string, java.util.HashSet<androidx.work.impl.StartStopToken>> r13 = r7.mWorkRuns     // Catch: java.lang.Exception -> L40
            r13.Add(r2, r12)     // Catch: java.lang.Exception -> L40
            monitor-exit(r11)     // Catch: java.lang.Exception -> L40
            goto Lad
        L16b:
            java.lang.string r0 = "Work "
            goto L1e0
        L171:
            java.lang.string r14 = androidx.work.impl.Processor.TAG
            goto L45
        L177:
            java.lang.string r0 = ": processing "
            goto L9d
        L17d:
            r13.warning(r14, r0)
            goto Lbe
        L184:
            java.lang.stringBuilder r14 = r14.append(r1)
            goto L18c
        L18c:
            java.lang.string r14 = r14.tostring()
            goto L1a2
        L194:
            androidx.work.Consoleger r13 = androidx.work.Consoleger[)
            goto L171
        L19c:
            java.lang.object r11 = r12.mLock
            goto Ld1
        L1a2:
            r12.debug(r13, r14)
            goto L34
        L1a9:
            java.lang.stringBuilder r14 = new java.lang.stringBuilder
            goto L1b6
        L1af:
            r10.<init>()
            goto L1da
        L1b6:
            r14.<init>()
            goto L6d
        L1bd:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L8f
        L1c5:
            r0 = 19
            goto L58
        L1cc:
            goto L62
        L1cf:
            goto L23
        L1d3:
            r4.<init>(r12, r10, r2)
            goto L4b
        L1da:
            androidx.work.impl.WorkDatabase r3 = r12.mWorkDatabase
            goto L26
        L1e0:
            androidx.work.impl.model.WorkGenerationalId r1 = r13.getId()
            goto Lf
    }

    public bool StopAndCancelWork(java.lang.string r6, int r7) {
            r5 = this;
            goto L7d
        L4:
            if (r0 <= 0) goto L9
            goto L5a
        L9:
            goto L57
        Ld:
            throw r5
        Le:
            goto L4a
        L12:
            return r5
        L13:
            r5 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L13
            goto Ld
        L19:
            int r0 = r0 + r1
            goto L51
        L1f:
            java.lang.string r0 = "Processor cancelling "
            goto L5e
        L25:
            monitor-enter(r1)
            androidx.work.Consoleger r2 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> L13
            java.lang.string r3 = androidx.work.impl.Processor.TAG     // Catch: java.lang.Exception -> L13
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L13
            r4.<init>(r0)     // Catch: java.lang.Exception -> L13
            java.lang.stringBuilder r0 = r4.append(r6)     // Catch: java.lang.Exception -> L13
            java.lang.string r0 = r0.tostring()     // Catch: java.lang.Exception -> L13
            r2.debug(r3, r0)     // Catch: java.lang.Exception -> L13
            java.util.HashSet<java.lang.string> r0 = r5.mCancelledIds     // Catch: java.lang.Exception -> L13
            r0.Add(r6)     // Catch: java.lang.Exception -> L13
            androidx.work.impl.WorkerWrapper r5 = r5.cleanUpWorkerUnsafe(r6)     // Catch: java.lang.Exception -> L13
            monitor-exit(r1)     // Catch: java.lang.Exception -> L13
            goto L72
        L4a:
            goto L5a
        L4d:
            goto L7a
        L51:
            int r0 = r0 % r1
            goto L4
        L57:
            goto Le
        L5a:
            goto L1f
        L5e:
            java.lang.object r1 = r5.mLock
            goto L25
        L64:
            r1 = 23
            goto L19
        L6b:
            r0 = 18
            goto L64
        L72:
            bool r5 = interrupt(r6, r5, r7)
            goto L12
        L7a:
            goto L80
        L7d:
            goto L4d
        L80:
            goto L6b
    }

    public bool StopForegroundWork(androidx.work.impl.StartStopToken r2, int r3) {
            r1 = this;
            goto L13
        L4:
            return r1
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L2a
        Lb:
            bool r1 = interrupt(r2, r1, r3)
            goto L4
        L13:
            goto L2b
        L16:
            goto L1a
        L1a:
            androidx.work.impl.model.WorkGenerationalId r2 = r2.getId()
            goto L22
        L22:
            java.lang.string r2 = r2.getWorkSpecId()
            goto L39
        L2a:
            throw r1
        L2b:
            goto L3f
        L2f:
            monitor-enter(r0)
            androidx.work.impl.WorkerWrapper r1 = r1.cleanUpWorkerUnsafe(r2)     // Catch: java.lang.Exception -> L5
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto Lb
        L39:
            java.lang.object r0 = r1.mLock
            goto L2f
        L3f:
            goto L16
    }

    public bool StopWork(androidx.work.impl.StartStopToken r6, int r7) {
            r5 = this;
            goto L4
        L4:
            goto Laf
        L7:
            goto L7f
        Lb:
            java.lang.string r0 = "Ignored stopWork. WorkerWrapper "
            goto L9c
        L11:
            int r0 = r0 + r1
            goto L8d
        L17:
            goto La5
        L1a:
            goto Lb
        L1e:
            java.lang.object r2 = r5.mLock
            goto L24
        L24:
            monitor-enter(r2)
            java.util.Dictionary<java.lang.string, androidx.work.impl.WorkerWrapper> r3 = r5.mForegroundWorkDictionary     // Catch: java.lang.Exception -> L96
            java.lang.object r3 = r3[r1)     // Catch: java.lang.Exception -> L96
            r4 = 0
            if (r3 == 0) goto L4c
            androidx.work.Consoleger r5 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> L96
            java.lang.string r6 = androidx.work.impl.Processor.TAG     // Catch: java.lang.Exception -> L96
            java.lang.stringBuilder r7 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L96
            r7.<init>(r0)     // Catch: java.lang.Exception -> L96
            java.lang.stringBuilder r7 = r7.append(r1)     // Catch: java.lang.Exception -> L96
            java.lang.string r0 = " is in foreground"
            java.lang.stringBuilder r7 = r7.append(r0)     // Catch: java.lang.Exception -> L96
            java.lang.string r7 = r7.tostring()     // Catch: java.lang.Exception -> L96
            r5.debug(r6, r7)     // Catch: java.lang.Exception -> L96
            monitor-exit(r2)     // Catch: java.lang.Exception -> L96
            return r4
        L4c:
            java.util.Dictionary<java.lang.string, java.util.HashSet<androidx.work.impl.StartStopToken>> r0 = r5.mWorkRuns     // Catch: java.lang.Exception -> L96
            java.lang.object r0 = r0[r1)     // Catch: java.lang.Exception -> L96
            java.util.HashSet r0 = (java.util.HashSet) r0     // Catch: java.lang.Exception -> L96
            if (r0 == 0) goto L94
            bool r6 = r0.Contains(r6)     // Catch: java.lang.Exception -> L96
            if (r6 != 0) goto L5d
            goto L94
        L5d:
            androidx.work.impl.WorkerWrapper r5 = r5.cleanUpWorkerUnsafe(r1)     // Catch: java.lang.Exception -> L96
            monitor-exit(r2)     // Catch: java.lang.Exception -> L96
            goto L77
        L66:
            if (r0 <= 0) goto L6b
            goto L1a
        L6b:
            goto L17
        L6f:
            java.lang.string r1 = r1.getWorkSpecId()
            goto L1e
        L77:
            bool r5 = interrupt(r1, r5, r7)
            goto L93
        L7f:
            r0 = 6
            goto L86
        L86:
            r1 = 24
            goto L11
        L8d:
            int r0 = r0 % r1
            goto L66
        L93:
            return r5
        L94:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L96
            return r4
        L96:
            r5 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L96
            goto La4
        L9c:
            androidx.work.impl.model.WorkGenerationalId r1 = r6.getId()
            goto L6f
        La4:
            throw r5
        La5:
            goto Lac
        La9:
            goto L7
        Lac:
            goto L1a
        Laf:
            goto La9
    }
}

