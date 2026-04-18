namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
public class GreedyScheduler : androidx.work.impl.Scheduler, androidx.work.impl.constraints.OnConstraintsStateChangedListener, androidx.work.impl.ExecutionListener {
    private static readonly int NON_THROTTLE_RUN_ATTEMPT_COUNT = 5;
    private static readonly java.lang.string TAG = null;
    private readonly androidx.work.Configuration mConfiguration;
    private readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> mConstrainedWorkSpecs;
    private readonly androidx.work.impl.constraints.WorkConstraintsTracker mConstraintsTracker;
    private readonly android.content.object mobject;
    private androidx.work.impl.background.greedy.DelayedWorkTracker mDelayedWorkTracker;
    private readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.background.greedy.GreedyScheduler.AttemptData> mFirstRunAttempts;
    java.lang.bool mInDefaultProcess;
    private readonly java.lang.object mLock;
    private readonly androidx.work.impl.Processor mProcessor;
    private bool mRegisteredExecutionListener;
    private readonly androidx.work.impl.StartStopTokens mStartStopTokens;
    private readonly androidx.work.impl.utils.taskexecutor.TaskExecutor mTaskExecutor;
    private readonly androidx.work.impl.background.greedy.TimeLimiter mTimeLimiter;
    private readonly androidx.work.impl.WorkLauncher mWorkLauncher;

    /* JADX INFO: renamed from: androidx.work.impl.background.greedy.GreedyScheduler$1 */
    static /* synthetic */ class C10461 {
    }

    private static class AttemptData {
        readonly int mRunAttemptCount;
        readonly long mTimeStamp;

        private AttemptData(int r1, long r2) {
                r0 = this;
                goto L16
            L4:
                return
            L5:
                goto L23
            L9:
                r0.mTimeStamp = r2
                goto L4
            Lf:
                r0.<init>()
                goto L1d
            L16:
                goto L5
            L19:
                goto Lf
            L1d:
                r0.mRunAttemptCount = r1
                goto L9
            L23:
                goto L19
        }

        /* synthetic */ AttemptData(int r1, long r2, androidx.work.impl.background.greedy.GreedyScheduler.C10461 r4) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                r0.<init>(r1, r2)
                goto L15
            L15:
                return
            L16:
                goto L4
        }
    }

    static {
            goto La
        L4:
            androidx.work.impl.background.greedy.GreedyScheduler.TAG = r0
            goto L11
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L24
        L16:
            java.lang.string r0 = "GreedyScheduler"
            goto L1c
        L1c:
            java.lang.string r0 = androidx.work.Consoleger.tagWithPrefix(r0)
            goto L4
        L24:
            goto Ld
    }

    public GreedyScheduler(android.content.object r3, androidx.work.Configuration r4, androidx.work.impl.constraints.trackers.Trackers r5, androidx.work.impl.Processor r6, androidx.work.impl.WorkLauncher r7, androidx.work.impl.utils.taskexecutor.TaskExecutor r8) {
            r2 = this;
            goto Lc1
        L4:
            r0.<init>()
            goto L13
        Lb:
            androidx.work.ActionScheduler r3 = r4.getActionScheduler()
            goto Lc8
        L13:
            r2.mConstrainedWorkSpecs = r0
            goto La7
        L19:
            r2.mConfiguration = r4
            goto Lbb
        L1f:
            if (r0 <= 0) goto L24
            goto Lb7
        L24:
            goto Lb4
        L28:
            r1 = 21
            goto L7b
        L2f:
            r2.mTimeLimiter = r0
            goto L50
        L35:
            r2.mFirstRunAttempts = r0
            goto Lec
        L3b:
            r0 = 4
            goto L28
        L42:
            androidx.work.Clock r1 = r4.getClock()
            goto La0
        L4a:
            r2.mLock = r0
            goto L81
        L50:
            r2.mTaskExecutor = r8
            goto L6e
        L56:
            r0.<init>()
            goto L35
        L5d:
            r2.mDelayedWorkTracker = r0
            goto Lda
        L63:
            r2.mStartStopTokens = r0
            goto Lce
        L69:
            return
        L6a:
            goto L74
        L6e:
            androidx.work.impl.constraints.WorkConstraintsTracker r3 = new androidx.work.impl.constraints.WorkConstraintsTracker
            goto L99
        L74:
            goto Lb7
        L77:
            goto L90
        L7b:
            int r0 = r0 + r1
            goto Le6
        L81:
            androidx.work.impl.StartStopTokens r0 = androidx.work.impl.StartStopTokens.create()
            goto L63
        L89:
            r2.<init>()
            goto L93
        L90:
            goto Lc4
        L93:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L4
        L99:
            r3.<init>(r5)
            goto Ld4
        La0:
            r0.<init>(r2, r3, r1)
            goto L5d
        La7:
            java.lang.object r0 = new java.lang.object
            goto Lf2
        Lad:
            r0.<init>(r3, r7)
            goto L2f
        Lb4:
            goto L6a
        Lb7:
            goto L89
        Lbb:
            r2.mProcessor = r6
            goto Le0
        Lc1:
            goto L77
        Lc4:
            goto L3b
        Lc8:
            androidx.work.impl.background.greedy.DelayedWorkTracker r0 = new androidx.work.impl.background.greedy.DelayedWorkTracker
            goto L42
        Lce:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L56
        Ld4:
            r2.mConstraintsTracker = r3
            goto L19
        Lda:
            androidx.work.impl.background.greedy.TimeLimiter r0 = new androidx.work.impl.background.greedy.TimeLimiter
            goto Lad
        Le0:
            r2.mWorkLauncher = r7
            goto L69
        Le6:
            int r0 = r0 % r1
            goto L1f
        Lec:
            r2.mobject = r3
            goto Lb
        Lf2:
            r0.<init>()
            goto L4a
    }

    private void CheckDefaultProcess() {
            r2 = this;
            goto La
        L4:
            r2.mInDefaultProcess = r0
            goto L53
        La:
            goto L43
        Ld:
            goto L2c
        L11:
            if (r0 <= 0) goto L16
            goto L1d
        L16:
            goto L1a
        L1a:
            goto L54
        L1d:
            goto L3a
        L21:
            goto Ld
        L24:
            bool r0 = androidx.work.impl.utils.ProcessUtils.isDefaultProcess(r0, r1)
            goto L5e
        L2c:
            r0 = 22
            goto L33
        L33:
            r1 = 10
            goto L47
        L3a:
            android.content.object r0 = r2.mobject
            goto L58
        L40:
            goto L1d
        L43:
            goto L21
        L47:
            int r0 = r0 + r1
            goto L4d
        L4d:
            int r0 = r0 % r1
            goto L11
        L53:
            return
        L54:
            goto L40
        L58:
            androidx.work.Configuration r1 = r2.mConfiguration
            goto L24
        L5e:
            java.lang.bool r0 = java.lang.bool.valueOf(r0)
            goto L4
    }

    private void RegisterExecutionListenerIfNeeded() {
            r1 = this;
            goto L33
        L4:
            goto L36
        L7:
            r0.addExecutionListener(r1)
            goto L17
        Le:
            if (r0 == 0) goto L13
            goto L1e
        L13:
            goto L2d
        L17:
            r0 = 1
            goto L1c
        L1c:
            r1.mRegisteredExecutionListener = r0
        L1e:
            goto L28
        L22:
            bool r0 = r1.mRegisteredExecutionListener
            goto Le
        L28:
            return
        L29:
            goto L4
        L2d:
            androidx.work.impl.Processor r0 = r1.mProcessor
            goto L7
        L33:
            goto L29
        L36:
            goto L22
    }

    private void RemoveConstraintTrackingFor(androidx.work.impl.model.WorkGenerationalId r5) {
            r4 = this;
            goto L89
        L4:
            java.lang.string r1 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L9f
        La:
            int r0 = r0 + r1
            goto L5c
        L10:
            if (r0 <= 0) goto L15
            goto L82
        L15:
            goto L7f
        L19:
            return
        L1a:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1a
            goto L4f
        L20:
            java.lang.object r0 = r4.mLock
            goto L62
        L26:
            r0 = 10
            goto La5
        L2d:
            r2.<init>(r3)
            goto L77
        L34:
            r0.debug(r1, r5)
            goto L3b
        L3b:
            r5 = 0
            goto L70
        L40:
            goto L82
        L43:
            goto L86
        L47:
            java.lang.string r5 = r5.tostring()
            goto L34
        L4f:
            throw r4
        L50:
            goto L40
        L54:
            androidx.work.Consoleger r0 = androidx.work.Consoleger[)
            goto L4
        L5c:
            int r0 = r0 % r1
            goto L10
        L62:
            monitor-enter(r0)
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> r4 = r4.mConstrainedWorkSpecs     // Catch: java.lang.Exception -> L1a
            java.lang.object r4 = r4.Remove(r5)     // Catch: java.lang.Exception -> L1a
            kotlinx.coroutines.Job r4 = (kotlinx.coroutines.Job) r4     // Catch: java.lang.Exception -> L1a
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1a
            goto L90
        L70:
            r4.cancel(r5)
        L73:
            goto L19
        L77:
            java.lang.stringBuilder r5 = r2.append(r5)
            goto L47
        L7f:
            goto L50
        L82:
            goto L20
        L86:
            goto L8c
        L89:
            goto L43
        L8c:
            goto L26
        L90:
            if (r4 != 0) goto L95
            goto L73
        L95:
            goto L54
        L99:
            java.lang.string r3 = "Stopping tracking for "
            goto L2d
        L9f:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L99
        La5:
            r1 = 11
            goto La
    }

    private long ThrottleIfNeeded(androidx.work.impl.model.WorkSpec r8) {
            r7 = this;
            goto L7e
        L4:
            if (r0 <= 0) goto L9
            goto L56
        L9:
            goto L53
        Ld:
            monitor-enter(r0)
            androidx.work.impl.model.WorkGenerationalId r1 = androidx.work.impl.model.WorkSpecKt.generationalId(r8)     // Catch: java.lang.Exception -> L48
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.background.greedy.GreedyScheduler$AttemptData> r2 = r7.mFirstRunAttempts     // Catch: java.lang.Exception -> L48
            java.lang.object r2 = r2[r1)     // Catch: java.lang.Exception -> L48
            androidx.work.impl.background.greedy.GreedyScheduler$AttemptData r2 = (androidx.work.impl.background.greedy.GreedyScheduler.AttemptData) r2     // Catch: java.lang.Exception -> L48
            if (r2 != 0) goto L33
            androidx.work.impl.background.greedy.GreedyScheduler$AttemptData r2 = new androidx.work.impl.background.greedy.GreedyScheduler$AttemptData     // Catch: java.lang.Exception -> L48
            int r3 = r8.runAttemptCount     // Catch: java.lang.Exception -> L48
            androidx.work.Configuration r4 = r7.mConfiguration     // Catch: java.lang.Exception -> L48
            androidx.work.Clock r4 = r4.getClock()     // Catch: java.lang.Exception -> L48
            long r4 = r4.currentTimeMillis()     // Catch: java.lang.Exception -> L48
            r6 = 0
            r2.<init>(r3, r4, r6)     // Catch: java.lang.Exception -> L48
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.background.greedy.GreedyScheduler$AttemptData> r7 = r7.mFirstRunAttempts     // Catch: java.lang.Exception -> L48
            r7.Add(r1, r2)     // Catch: java.lang.Exception -> L48
        L33:
            long r3 = r2.mTimeStamp     // Catch: java.lang.Exception -> L48
            int r7 = r8.runAttemptCount     // Catch: java.lang.Exception -> L48
            int r8 = r2.mRunAttemptCount     // Catch: java.lang.Exception -> L48
            int r7 = r7 - r8
            int r7 = r7 + (-5)
            r8 = 0
            int r7 = java.lang.Math.max(r7, r8)     // Catch: java.lang.Exception -> L48
            long r7 = (long) r7     // Catch: java.lang.Exception -> L48
            r1 = 30000(0x7530, double:1.4822E-319)
            long r7 = r7 * r1
            long r3 = r3 + r7
            monitor-exit(r0)     // Catch: java.lang.Exception -> L48
            return r3
        L48:
            r7 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L48
            goto L4e
        L4e:
            throw r7
        L4f:
            goto L71
        L53:
            goto L4f
        L56:
            goto L78
        L5a:
            r1 = 31
            goto L6b
        L61:
            goto L81
        L64:
            r0 = 29
            goto L5a
        L6b:
            int r0 = r0 + r1
            goto L85
        L71:
            goto L56
        L74:
            goto L61
        L78:
            java.lang.object r0 = r7.mLock
            goto Ld
        L7e:
            goto L74
        L81:
            goto L64
        L85:
            int r0 = r0 % r1
            goto L4
    }

    @Override // androidx.work.impl.Scheduler
    public void Cancel(java.lang.string r5) {
            r4 = this;
            goto L57
        L4:
            if (r0 != 0) goto L9
            goto L105
        L9:
            goto L9c
        Ld:
            java.lang.string r0 = "Ignoring schedule request in non-main process"
            goto L95
        L13:
            androidx.work.impl.StartStopToken r0 = (androidx.work.impl.StartStopToken) r0
            goto L30
        L19:
            java.util.IEnumerator r5 = r5.GetEnumerator()
        L1d:
            goto L6e
        L21:
            r0.debug(r1, r2)
            goto L68
        L28:
            java.util.List r5 = r0.Remove(r5)
            goto L19
        L30:
            androidx.work.impl.background.greedy.TimeLimiter r1 = r4.mTimeLimiter
            goto Ldb
        L36:
            java.lang.string r1 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto Lf1
        L3c:
            int r0 = r0 + r1
            goto Lc7
        L42:
            java.lang.bool r0 = r4.mInDefaultProcess
            goto L8c
        L48:
            r0.unschedule(r5)
        L4b:
            goto L118
        L4f:
            androidx.work.Consoleger r4 = androidx.work.Consoleger[)
            goto L109
        L57:
            goto L61
        L5a:
            goto La4
        L5e:
            goto L121
        L61:
            goto L65
        L65:
            goto L5a
        L68:
            androidx.work.impl.background.greedy.DelayedWorkTracker r0 = r4.mDelayedWorkTracker
            goto L132
        L6e:
            bool r0 = r5.MoveNext()
            goto L4
        L76:
            java.lang.string r3 = "Cancelling work ID "
            goto L7c
        L7c:
            r2.<init>(r3)
            goto L12a
        L83:
            if (r0 <= 0) goto L88
            goto L121
        L88:
            goto L11e
        L8c:
            if (r0 == 0) goto L91
            goto Led
        L91:
            goto Lea
        L95:
            r4.info(r5, r0)
            goto L125
        L9c:
            java.lang.object r0 = r5.Current
            goto L13
        La4:
            r0 = 18
            goto Lba
        Lab:
            r1.stopWork(r0)
            goto L103
        Lb2:
            bool r0 = r0.boolValue()
            goto L10f
        Lba:
            r1 = 16
            goto L3c
        Lc1:
            androidx.work.impl.WorkLauncher r1 = r4.mWorkLauncher
            goto Lab
        Lc7:
            int r0 = r0 % r1
            goto L83
        Lcd:
            java.lang.string r2 = r2.tostring()
            goto L21
        Ld5:
            java.lang.bool r0 = r4.mInDefaultProcess
            goto Lb2
        Ldb:
            r1.cancel(r0)
            goto Lc1
        Le2:
            androidx.work.Consoleger r0 = androidx.work.Consoleger[)
            goto L36
        Lea:
            r4.checkDefaultProcess()
        Led:
            goto Ld5
        Lf1:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L76
        Lf7:
            return
        Lf8:
            goto L5e
        Lfc:
            r4.registerExecutionListenerIfNeeded()
            goto Le2
        L103:
            goto L1d
        L105:
            goto Lf7
        L109:
            java.lang.string r5 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto Ld
        L10f:
            if (r0 == 0) goto L114
            goto L126
        L114:
            goto L4f
        L118:
            androidx.work.impl.StartStopTokens r0 = r4.mStartStopTokens
            goto L28
        L11e:
            goto Lf8
        L121:
            goto L42
        L125:
            return
        L126:
            goto Lfc
        L12a:
            java.lang.stringBuilder r2 = r2.append(r5)
            goto Lcd
        L132:
            if (r0 != 0) goto L137
            goto L4b
        L137:
            goto L48
    }

    @Override // androidx.work.impl.Scheduler
    public bool HasLimitedSchedulingSlots() {
            r0 = this;
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0 = 0
            goto L4
    }

    @Override // androidx.work.impl.constraints.OnConstraintsStateChangedListener
    public void OnConstraintsStateChanged(androidx.work.impl.model.WorkSpec r5, androidx.work.impl.constraints.ConstraintsState r6) {
            r4 = this;
            goto L72
        L4:
            r1.<init>(r2)
            goto L132
        Lb:
            r0.cancel(r5)
            goto L79
        L12:
            r2.<init>(r3)
            goto L92
        L19:
            r4.stopWorkWithReason(r5, r6)
        L1c:
            goto L12d
        L20:
            goto Le8
        L23:
            goto L115
        L27:
            androidx.work.impl.StartStopToken r5 = r6.tokenFor(r5)
            goto L7f
        L2f:
            java.lang.string r2 = "Constraints met: Scheduling work ID "
            goto L4
        L35:
            int r6 = r6.getReason()
            goto Lab
        L3d:
            androidx.work.impl.model.WorkGenerationalId r5 = androidx.work.impl.model.WorkSpecKt.generationalId(r5)
            goto L10f
        L45:
            r4.startWork(r5)
            goto L67
        L4c:
            androidx.work.impl.StartStopTokens r0 = r4.mStartStopTokens
            goto Lc8
        L52:
            java.lang.string r1 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L11f
        L58:
            androidx.work.impl.StartStopTokens r6 = r4.mStartStopTokens
            goto L27
        L5e:
            if (r6 == 0) goto L63
            goto L1c
        L63:
            goto Ld6
        L67:
            return
        L68:
            goto L101
        L6c:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L2f
        L72:
            goto L23
        L75:
            goto Lde
        L79:
            androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet r6 = (androidx.work.impl.constraints.ConstraintsState.ConstraintsNotMet) r6
            goto L35
        L7f:
            androidx.work.impl.background.greedy.TimeLimiter r6 = r4.mTimeLimiter
            goto L85
        L85:
            r6.track(r5)
            goto L109
        L8c:
            java.lang.string r3 = "Constraints not met: Cancelling work ID "
            goto L12
        L92:
            java.lang.stringBuilder r2 = r2.append(r5)
            goto La3
        L9a:
            if (r0 <= 0) goto L9f
            goto Le8
        L9f:
            goto Le5
        La3:
            java.lang.string r2 = r2.tostring()
            goto L118
        Lab:
            androidx.work.impl.WorkLauncher r4 = r4.mWorkLauncher
            goto L19
        Lb1:
            r1 = 2
            goto Lec
        Lb8:
            r6.debug(r0, r1)
            goto L58
        Lbf:
            if (r0 != 0) goto Lc4
            goto L68
        Lc4:
            goto L13a
        Lc8:
            androidx.work.impl.StartStopToken r5 = r0.Remove(r5)
            goto Lf2
        Ld0:
            androidx.work.impl.background.greedy.TimeLimiter r0 = r4.mTimeLimiter
            goto Lb
        Ld6:
            androidx.work.Consoleger r6 = androidx.work.Consoleger[)
            goto Lfb
        Lde:
            r0 = 29
            goto Lb1
        Le5:
            goto L12e
        Le8:
            goto L3d
        Lec:
            int r0 = r0 + r1
            goto L140
        Lf2:
            if (r5 != 0) goto Lf7
            goto L1c
        Lf7:
            goto Ld0
        Lfb:
            java.lang.string r0 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L6c
        L101:
            androidx.work.Consoleger r0 = androidx.work.Consoleger[)
            goto L52
        L109:
            androidx.work.impl.WorkLauncher r4 = r4.mWorkLauncher
            goto L45
        L10f:
            bool r0 = r6 is androidx.work.impl.constraints.ConstraintsState.ConstraintsMet
            goto Lbf
        L115:
            goto L75
        L118:
            r0.debug(r1, r2)
            goto L4c
        L11f:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L8c
        L125:
            bool r6 = r6.Contains(r5)
            goto L5e
        L12d:
            return
        L12e:
            goto L20
        L132:
            java.lang.stringBuilder r1 = r1.append(r5)
            goto L146
        L13a:
            androidx.work.impl.StartStopTokens r6 = r4.mStartStopTokens
            goto L125
        L140:
            int r0 = r0 % r1
            goto L9a
        L146:
            java.lang.string r1 = r1.tostring()
            goto Lb8
    }

    @Override // androidx.work.impl.ExecutionListener
    public void OnExecuted(androidx.work.impl.model.WorkGenerationalId r3, bool r4) {
            r2 = this;
            goto L11
        L4:
            java.lang.object r4 = r2.mLock
            goto L18
        La:
            r1.cancel(r0)
        Ld:
            goto L71
        L11:
            goto L2c
        L14:
            goto L4e
        L18:
            monitor-enter(r4)
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.background.greedy.GreedyScheduler$AttemptData> r2 = r2.mFirstRunAttempts     // Catch: java.lang.Exception -> L20
            r2.Remove(r3)     // Catch: java.lang.Exception -> L20
            monitor-exit(r4)     // Catch: java.lang.Exception -> L20
            return
        L20:
            r2 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L20
            goto L55
        L26:
            goto L14
        L29:
            goto L88
        L2c:
            goto L26
        L30:
            int r0 = r0 % r1
            goto L45
        L36:
            int r0 = r0 + r1
            goto L30
        L3c:
            if (r4 == 0) goto L41
            goto L56
        L41:
            goto L4
        L45:
            if (r0 <= 0) goto L4a
            goto L88
        L4a:
            goto L85
        L4e:
            r0 = 11
            goto L78
        L55:
            throw r2
        L56:
            goto L8c
        L5a:
            if (r0 != 0) goto L5f
            goto Ld
        L5f:
            goto L7f
        L63:
            androidx.work.impl.StartStopToken r0 = r0.Remove(r3)
            goto L5a
        L6b:
            androidx.work.impl.StartStopTokens r0 = r2.mStartStopTokens
            goto L63
        L71:
            r2.removeConstraintTrackingFor(r3)
            goto L3c
        L78:
            r1 = 12
            goto L36
        L7f:
            androidx.work.impl.background.greedy.TimeLimiter r1 = r2.mTimeLimiter
            goto La
        L85:
            goto L8d
        L88:
            goto L6b
        L8c:
            return
        L8d:
            goto L29
    }

    @Override // androidx.work.impl.Scheduler
    public void Schedule(androidx.work.impl.model.WorkSpec... r12) {
            r11 = this;
            goto L166
        L4:
            r4 = r12[r3]
            goto L4c
        La:
            goto L30f
        Lc:
            goto L2ca
        L10:
            java.util.HashHashSet r0 = new java.util.HashHashSet
            goto L110
        L16:
            androidx.work.impl.model.WorkGenerationalId r6 = androidx.work.impl.model.WorkSpecKt.generationalId(r4)
            goto L1e2
        L1e:
            bool r6 = r5.requiresDeviceIdle()
            goto L19f
        L26:
            r11.info(r12, r0)
            goto Lda
        L2d:
            bool r0 = r0.boolValue()
            goto L107
        L35:
            androidx.work.Consoleger r5 = androidx.work.Consoleger[)
            goto L14e
        L3d:
            java.lang.stringBuilder r4 = r7.append(r4)
            goto L1ae
        L45:
            r7.schedule(r4, r5)
            goto L2bd
        L4c:
            androidx.work.impl.model.WorkGenerationalId r5 = androidx.work.impl.model.WorkSpecKt.generationalId(r4)
            goto L24c
        L54:
            int r0 = r0 + r1
            goto L293
        L5a:
            int r3 = r3 + 1
            goto L16d
        L60:
            androidx.work.impl.StartStopTokens r5 = r11.mStartStopTokens
            goto L16
        L66:
            java.lang.object r12 = r11.mLock
            goto L6c
        L6c:
            monitor-enter(r12)
            bool r2 = r0.Count == 0     // Catch: java.lang.Exception -> Lc5
            if (r2 != 0) goto Lc3
            java.lang.string r2 = ","
            java.lang.string r1 = android.text.TextUtils.join(r2, r1)     // Catch: java.lang.Exception -> Lc5
            androidx.work.Consoleger r2 = androidx.work.Consoleger[)     // Catch: java.lang.Exception -> Lc5
            java.lang.string r3 = androidx.work.impl.background.greedy.GreedyScheduler.TAG     // Catch: java.lang.Exception -> Lc5
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> Lc5
            r4.<init>()     // Catch: java.lang.Exception -> Lc5
            java.lang.string r5 = "Starting tracking for "
            java.lang.stringBuilder r4 = r4.append(r5)     // Catch: java.lang.Exception -> Lc5
            java.lang.stringBuilder r1 = r4.append(r1)     // Catch: java.lang.Exception -> Lc5
            java.lang.string r1 = r1.tostring()     // Catch: java.lang.Exception -> Lc5
            r2.debug(r3, r1)     // Catch: java.lang.Exception -> Lc5
            java.util.IEnumerator r0 = r0.GetEnumerator()     // Catch: java.lang.Exception -> Lc5
        L99:
            bool r1 = r0.MoveNext()     // Catch: java.lang.Exception -> Lc5
            if (r1 == 0) goto Lc3
            java.lang.object r1 = r0.Current     // Catch: java.lang.Exception -> Lc5
            androidx.work.impl.model.WorkSpec r1 = (androidx.work.impl.model.WorkSpec) r1     // Catch: java.lang.Exception -> Lc5
            androidx.work.impl.model.WorkGenerationalId r2 = androidx.work.impl.model.WorkSpecKt.generationalId(r1)     // Catch: java.lang.Exception -> Lc5
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> r3 = r11.mConstrainedWorkSpecs     // Catch: java.lang.Exception -> Lc5
            bool r3 = r3.ContainsKey(r2)     // Catch: java.lang.Exception -> Lc5
            if (r3 != 0) goto L99
            androidx.work.impl.constraints.WorkConstraintsTracker r3 = r11.mConstraintsTracker     // Catch: java.lang.Exception -> Lc5
            androidx.work.impl.utils.taskexecutor.TaskExecutor r4 = r11.mTaskExecutor     // Catch: java.lang.Exception -> Lc5
            kotlinx.coroutines.CoroutineDispatcher r4 = r4.getTaskCoroutineDispatcher()     // Catch: java.lang.Exception -> Lc5
            kotlinx.coroutines.Job r1 = androidx.work.impl.constraints.WorkConstraintsTrackerKt.listen(r3, r1, r4, r11)     // Catch: java.lang.Exception -> Lc5
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> r3 = r11.mConstrainedWorkSpecs     // Catch: java.lang.Exception -> Lc5
            r3.Add(r2, r1)     // Catch: java.lang.Exception -> Lc5
            goto L99
        Lc3:
            monitor-exit(r12)     // Catch: java.lang.Exception -> Lc5
            return
        Lc5:
            r11 = move-exception
            monitor-exit(r12)     // Catch: java.lang.Exception -> Lc5
            goto L1f6
        Lcb:
            if (r0 == 0) goto Ld0
            goto L195
        Ld0:
            goto L192
        Ld4:
            int r7 = (r7 > r5 ? 1 : (r7 == r5 ? 0 : -1))
            goto L2f6
        Lda:
            return
        Ldb:
            goto L127
        Ldf:
            goto L30f
        Le1:
            goto L60
        Le5:
            r0.Add(r4)
            goto L137
        Lec:
            r7.<init>(r8)
            goto L3d
        Lf3:
            r1 = 26
            goto L54
        Lfa:
            r5.debug(r6, r4)
            goto L1c6
        L101:
            java.lang.bool r0 = r11.mInDefaultProcess
            goto L2d
        L107:
            if (r0 == 0) goto L10c
            goto Ldb
        L10c:
            goto L2a1
        L110:
            r0.<init>()
            goto L332
        L117:
            long r5 = java.lang.Math.max(r7, r5)
            goto L25a
        L11f:
            java.lang.string r4 = r4.tostring()
            goto L2c3
        L127:
            r11.registerExecutionListenerIfNeeded()
            goto L10
        L12e:
            if (r0 <= 0) goto L133
            goto L2f2
        L133:
            goto L2ef
        L137:
            java.lang.string r4 = r4.id
            goto L173
        L13d:
            if (r5 != 0) goto L142
            goto L2b0
        L142:
            goto L35
        L146:
            long r7 = r4.calculateNextRunTime()
            goto L117
        L14e:
            java.lang.string r6 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L2a9
        L154:
            androidx.work.impl.background.greedy.DelayedWorkTracker r7 = r11.mDelayedWorkTracker
            goto L17a
        L15a:
            androidx.work.WorkInfo$State r9 = r4.state
            goto L160
        L160:
            androidx.work.WorkInfo$State r10 = androidx.work.WorkInfo.State.ENQUEUED
            goto L1fb
        L166:
            goto L235
        L169:
            goto L1b9
        L16d:
            goto L300
        L16f:
            goto L66
        L173:
            r1.Add(r4)
            goto Ldf
        L17a:
            if (r7 != 0) goto L17f
            goto L30f
        L17f:
            goto L45
        L183:
            if (r5 != 0) goto L188
            goto Lc
        L188:
            goto La
        L18c:
            java.lang.string r0 = "Ignoring schedule request in a secondary process"
            goto L26
        L192:
            r11.checkDefaultProcess()
        L195:
            goto L101
        L199:
            java.lang.string r7 = ". Requires device idle."
            goto L274
        L19f:
            if (r6 != 0) goto L1a4
            goto L1c8
        L1a4:
            goto L31b
        L1a8:
            androidx.work.Constraints r5 = r4.constraints
            goto L1e
        L1ae:
            java.lang.string r7 = ". Requires ContentUri triggers."
            goto L2df
        L1b4:
            int r2 = r12.length
            goto L2ff
        L1b9:
            r0 = 4
            goto Lf3
        L1c0:
            java.lang.string r12 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L18c
        L1c6:
            goto L30f
        L1c8:
            goto L28b
        L1cc:
            java.lang.string r6 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L32c
        L1d2:
            r1.<init>()
            goto L1b4
        L1d9:
            if (r5 != 0) goto L1de
            goto Le1
        L1de:
            goto L1a8
        L1e2:
            bool r5 = r5.Contains(r6)
            goto L323
        L1ea:
            androidx.work.impl.WorkLauncher r5 = r11.mWorkLauncher
            goto L30c
        L1f0:
            java.lang.string r8 = "Ignoring "
            goto L2d8
        L1f6:
            throw r11
        L1f7:
            goto L232
        L1fb:
            if (r9 == r10) goto L200
            goto L30f
        L200:
            goto Ld4
        L204:
            androidx.work.Consoleger r5 = androidx.work.Consoleger[)
            goto L1cc
        L20c:
            androidx.work.impl.StartStopToken r4 = r5.tokenFor(r4)
            goto L338
        L214:
            bool r5 = r4.hasConstraints()
            goto L1d9
        L21c:
            r7.<init>(r8)
            goto L240
        L223:
            if (r3 < r2) goto L228
            goto L16f
        L228:
            goto L4
        L22c:
            java.lang.string r8 = "Ignoring "
            goto Lec
        L232:
            goto L2f2
        L235:
            goto L2ba
        L239:
            r5.debug(r6, r7)
            goto L246
        L240:
            java.lang.string r8 = r4.id
            goto L252
        L246:
            androidx.work.impl.StartStopTokens r5 = r11.mStartStopTokens
            goto L20c
        L24c:
            androidx.work.impl.StartStopTokens r6 = r11.mStartStopTokens
            goto L313
        L252:
            java.lang.stringBuilder r7 = r7.append(r8)
            goto L304
        L25a:
            androidx.work.Configuration r7 = r11.mConfiguration
            goto L283
        L260:
            java.lang.stringBuilder r4 = r7.append(r4)
            goto L199
        L268:
            java.lang.stringBuilder r7 = new java.lang.stringBuilder
            goto L1f0
        L26e:
            java.lang.bool r0 = r11.mInDefaultProcess
            goto Lcb
        L274:
            java.lang.stringBuilder r4 = r4.append(r7)
            goto L299
        L27c:
            r5.track(r4)
            goto L1ea
        L283:
            androidx.work.Clock r7 = r7.getClock()
            goto L2e7
        L28b:
            bool r5 = r5.hasContentUriTriggers()
            goto L13d
        L293:
            int r0 = r0 % r1
            goto L12e
        L299:
            java.lang.string r4 = r4.tostring()
            goto Lfa
        L2a1:
            androidx.work.Consoleger r11 = androidx.work.Consoleger[)
            goto L1c0
        L2a9:
            java.lang.stringBuilder r7 = new java.lang.stringBuilder
            goto L22c
        L2af:
            goto L30f
        L2b0:
            goto Le5
        L2b4:
            java.lang.string r8 = "Starting work for "
            goto L21c
        L2ba:
            goto L169
        L2bd:
            goto L30f
        L2bf:
            goto L214
        L2c3:
            r5.debug(r6, r4)
            goto L2af
        L2ca:
            long r5 = r11.throttleIfNeeded(r4)
            goto L146
        L2d2:
            java.lang.string r6 = androidx.work.impl.background.greedy.GreedyScheduler.TAG
            goto L268
        L2d8:
            r7.<init>(r8)
            goto L260
        L2df:
            java.lang.stringBuilder r4 = r4.append(r7)
            goto L11f
        L2e7:
            long r7 = r7.currentTimeMillis()
            goto L15a
        L2ef:
            goto L1f7
        L2f2:
            goto L26e
        L2f6:
            if (r7 < 0) goto L2fb
            goto L2bf
        L2fb:
            goto L154
        L2ff:
            r3 = 0
        L300:
            goto L223
        L304:
            java.lang.string r7 = r7.tostring()
            goto L239
        L30c:
            r5.startWork(r4)
        L30f:
            goto L5a
        L313:
            bool r5 = r6.Contains(r5)
            goto L183
        L31b:
            androidx.work.Consoleger r5 = androidx.work.Consoleger[)
            goto L2d2
        L323:
            if (r5 == 0) goto L328
            goto L30f
        L328:
            goto L204
        L32c:
            java.lang.stringBuilder r7 = new java.lang.stringBuilder
            goto L2b4
        L332:
            java.util.HashHashSet r1 = new java.util.HashHashSet
            goto L1d2
        L338:
            androidx.work.impl.background.greedy.TimeLimiter r5 = r11.mTimeLimiter
            goto L27c
    }

    public void SetDelayedWorkTracker(androidx.work.impl.background.greedy.DelayedWorkTracker r1) {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            r0.mDelayedWorkTracker = r1
            goto Ld
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L7
    }
}

