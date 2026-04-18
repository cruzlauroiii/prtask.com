namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
public class SystemForegroundDispatcher : androidx.work.impl.constraints.OnConstraintsStateChangedListener, androidx.work.impl.ExecutionListener {
    private static readonly java.lang.string ACTION_CANCEL_WORK = "ACTION_CANCEL_WORK";
    private static readonly java.lang.string ACTION_NOTIFY = "ACTION_NOTIFY";
    private static readonly java.lang.string ACTION_START_FOREGROUND = "ACTION_START_FOREGROUND";
    private static readonly java.lang.string ACTION_STOP_FOREGROUND = "ACTION_STOP_FOREGROUND";
    private static readonly java.lang.string KEY_FOREGROUND_SERVICE_TYPE = "KEY_FOREGROUND_SERVICE_TYPE";
    private static readonly java.lang.string KEY_GENERATION = "KEY_GENERATION";
    private static readonly java.lang.string KEY_NOTIFICATION = "KEY_NOTIFICATION";
    private static readonly java.lang.string KEY_NOTIFICATION_ID = "KEY_NOTIFICATION_ID";
    private static readonly java.lang.string KEY_WORKSPEC_ID = "KEY_WORKSPEC_ID";
    static readonly java.lang.string TAG = null;
    private androidx.work.impl.foreground.SystemForegroundDispatcher.Callback mCallback;
    readonly androidx.work.impl.constraints.WorkConstraintsTracker mConstraintsTracker;
    private android.content.object mobject;
    androidx.work.impl.model.WorkGenerationalId mCurrentForegroundId;
    readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> mForegroundInfoById;
    readonly java.lang.object mLock;
    private readonly androidx.work.impl.utils.taskexecutor.TaskExecutor mTaskExecutor;
    readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> mTrackedWorkSpecs;
    private androidx.work.impl.WorkManagerImpl mWorkManagerImpl;
    readonly java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.model.WorkSpec> mWorkSpecById;


    interface Callback {
        void cancelNotification(int r1);

        void notify(int r1, android.app.Notification r2);

        void startForeground(int r1, int r2, android.app.Notification r3);

        void stop();
    }

    static {
            goto La
        L4:
            java.lang.string r0 = "SystemFgDispatcher"
            goto L1f
        La:
            goto L18
        Ld:
            goto L4
        L11:
            androidx.work.impl.foreground.SystemForegroundDispatcher.TAG = r0
            goto L17
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            java.lang.string r0 = androidx.work.Consoleger.tagWithPrefix(r0)
            goto L11
    }

    SystemForegroundDispatcher(android.content.object r2) {
            r1 = this;
            goto L63
        L4:
            r2.<init>()
            goto L6a
        Lb:
            r1.mTrackedWorkSpecs = r2
            goto L2e
        L11:
            return
        L12:
            goto L34
        L16:
            r2.<init>()
            goto Lb
        L1d:
            java.util.HashDictionary r2 = new java.util.HashDictionary
            goto L16
        L23:
            r2 = 0
            goto Lbb
        L28:
            java.lang.object r2 = new java.lang.object
            goto L4
        L2e:
            java.util.HashDictionary r2 = new java.util.HashDictionary
            goto L5c
        L34:
            goto L66
        L37:
            r1.mobject = r2
            goto L28
        L3d:
            androidx.work.impl.WorkManagerImpl r2 = r1.mWorkManagerImpl
            goto L70
        L43:
            r1.mWorkManagerImpl = r2
            goto Lc1
        L49:
            androidx.work.impl.constraints.WorkConstraintsTracker r2 = new androidx.work.impl.constraints.WorkConstraintsTracker
            goto L56
        L4f:
            r1.<init>()
            goto L37
        L56:
            androidx.work.impl.WorkManagerImpl r0 = r1.mWorkManagerImpl
            goto L7e
        L5c:
            r2.<init>()
            goto La7
        L63:
            goto L12
        L66:
            goto L4f
        L6a:
            r1.mLock = r2
            goto L8d
        L70:
            androidx.work.impl.Processor r2 = r2.getProcessor()
            goto La0
        L78:
            r1.mForegroundInfoById = r2
            goto L1d
        L7e:
            androidx.work.impl.constraints.trackers.Trackers r0 = r0.getTrackers()
            goto L86
        L86:
            r2.<init>(r0)
            goto L9a
        L8d:
            android.content.object r2 = r1.mobject
            goto Lb3
        L93:
            r2.<init>()
            goto L78
        L9a:
            r1.mConstraintsTracker = r2
            goto L3d
        La0:
            r2.addExecutionListener(r1)
            goto L11
        La7:
            r1.mWorkSpecById = r2
            goto L49
        Lad:
            java.util.LinkedHashDictionary r2 = new java.util.LinkedHashDictionary
            goto L93
        Lb3:
            androidx.work.impl.WorkManagerImpl r2 = androidx.work.impl.WorkManagerImpl.getInstance(r2)
            goto L43
        Lbb:
            r1.mCurrentForegroundId = r2
            goto Lad
        Lc1:
            androidx.work.impl.utils.taskexecutor.TaskExecutor r2 = r2.getWorkTaskExecutor()
            goto Lc9
        Lc9:
            r1.mTaskExecutor = r2
            goto L23
    }

    SystemForegroundDispatcher(android.content.object r1, androidx.work.impl.WorkManagerImpl r2, androidx.work.impl.constraints.WorkConstraintsTracker r3) {
            r0 = this;
            goto L55
        L4:
            r0.mTaskExecutor = r1
            goto L73
        La:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L3b
        L10:
            java.util.LinkedHashDictionary r1 = new java.util.LinkedHashDictionary
            goto L9f
        L16:
            androidx.work.impl.Processor r1 = r1.getProcessor()
            goto L27
        L1e:
            goto L58
        L21:
            java.lang.object r1 = new java.lang.object
            goto L98
        L27:
            r1.addExecutionListener(r0)
            goto L5c
        L2e:
            androidx.work.impl.WorkManagerImpl r1 = r0.mWorkManagerImpl
            goto L16
        L34:
            r1.<init>()
            goto L48
        L3b:
            r1.<init>()
            goto L6d
        L42:
            r0.mobject = r1
            goto L21
        L48:
            r0.mTrackedWorkSpecs = r1
            goto La
        L4e:
            r0.<init>()
            goto L42
        L55:
            goto L5d
        L58:
            goto L4e
        L5c:
            return
        L5d:
            goto L1e
        L61:
            r0.mLock = r1
            goto L67
        L67:
            r0.mWorkManagerImpl = r2
            goto L90
        L6d:
            r0.mWorkSpecById = r1
            goto L84
        L73:
            r1 = 0
            goto L78
        L78:
            r0.mCurrentForegroundId = r1
            goto L10
        L7e:
            r0.mForegroundInfoById = r1
            goto L8a
        L84:
            r0.mConstraintsTracker = r3
            goto L2e
        L8a:
            java.util.HashDictionary r1 = new java.util.HashDictionary
            goto L34
        L90:
            androidx.work.impl.utils.taskexecutor.TaskExecutor r1 = r2.getWorkTaskExecutor()
            goto L4
        L98:
            r1.<init>()
            goto L61
        L9f:
            r1.<init>()
            goto L7e
    }

    static /* synthetic */ androidx.work.impl.WorkManagerImpl access$000(androidx.work.impl.foreground.SystemForegroundDispatcher r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            androidx.work.impl.WorkManagerImpl r0 = r0.mWorkManagerImpl
            goto Lb
    }

    static /* synthetic */ androidx.work.impl.utils.taskexecutor.TaskExecutor access$100(androidx.work.impl.foreground.SystemForegroundDispatcher r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            androidx.work.impl.utils.taskexecutor.TaskExecutor r0 = r0.mTaskExecutor
            goto Lb
        L16:
            goto L7
    }

    public static android.content.object CreateCancelWorkobject(android.content.object r2, java.lang.string r3) {
            goto L97
        L4:
            r0.setData(r2)
            goto L48
        Lb:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L3b
        L11:
            r2.<init>(r1)
            goto L6e
        L18:
            r0 = 29
            goto L1f
        L1f:
            r1 = 30
            goto L91
        L26:
            r0.setAction(r2)
            goto Lb
        L2d:
            java.lang.Class<androidx.work.impl.foreground.SystemForegroundService> r1 = androidx.work.impl.foreground.SystemForegroundService.class
            goto L5c
        L33:
            java.lang.string r2 = r2.tostring()
            goto L82
        L3b:
            java.lang.string r1 = "workspec://"
            goto L11
        L42:
            int r0 = r0 % r1
            goto L79
        L48:
            java.lang.string r2 = "KEY_WORKSPEC_ID"
            goto L4e
        L4e:
            r0.putExtra(r2, r3)
            goto L63
        L55:
            goto L64
        L58:
            goto L68
        L5c:
            r0.<init>(r2, r1)
            goto L9e
        L63:
            return r0
        L64:
            goto L8a
        L68:
            android.content.object r0 = new android.content.object
            goto L2d
        L6e:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto L33
        L76:
            goto L9a
        L79:
            if (r0 <= 0) goto L7e
            goto L58
        L7e:
            goto L55
        L82:
            android.net.Uri r2 = android.net.Uri.parse(r2)
            goto L4
        L8a:
            goto L58
        L8d:
            goto L76
        L91:
            int r0 = r0 + r1
            goto L42
        L97:
            goto L8d
        L9a:
            goto L18
        L9e:
            java.lang.string r2 = "ACTION_CANCEL_WORK"
            goto L26
    }

    public static android.content.object CreateNotifyobject(android.content.object r2, androidx.work.impl.model.WorkGenerationalId r3, androidx.work.ForegroundInfo r4) {
            goto L64
        L4:
            android.app.Notification r4 = r4.getNotification()
            goto L6b
        Lc:
            java.lang.Class<androidx.work.impl.foreground.SystemForegroundService> r1 = androidx.work.impl.foreground.SystemForegroundService.class
            goto Lb8
        L12:
            goto Lb4
        L15:
            goto L5e
        L19:
            r1 = 2
            goto L89
        L20:
            java.lang.string r2 = "KEY_WORKSPEC_ID"
            goto L72
        L26:
            goto L67
        L29:
            r0.setAction(r2)
            goto L8f
        L30:
            java.lang.string r2 = "ACTION_NOTIFY"
            goto L29
        L36:
            r0 = 19
            goto L19
        L3d:
            java.lang.string r2 = "KEY_FOREGROUND_SERVICE_TYPE"
            goto L49
        L43:
            int r0 = r0 % r1
            goto L9c
        L49:
            int r1 = r4.getForegroundServiceType()
            goto L82
        L51:
            java.lang.string r2 = "KEY_GENERATION"
            goto Lab
        L57:
            goto L15
        L5a:
            goto L26
        L5e:
            android.content.object r0 = new android.content.object
            goto Lc
        L64:
            goto L5a
        L67:
            goto L36
        L6b:
            r0.putExtra(r2, r4)
            goto L20
        L72:
            java.lang.string r4 = r3.getWorkSpecId()
            goto Lbf
        L7a:
            int r1 = r4.getNotificationId()
            goto L95
        L82:
            r0.putExtra(r2, r1)
            goto La5
        L89:
            int r0 = r0 + r1
            goto L43
        L8f:
            java.lang.string r2 = "KEY_NOTIFICATION_ID"
            goto L7a
        L95:
            r0.putExtra(r2, r1)
            goto L3d
        L9c:
            if (r0 <= 0) goto La1
            goto L15
        La1:
            goto L12
        La5:
            java.lang.string r2 = "KEY_NOTIFICATION"
            goto L4
        Lab:
            int r3 = r3.getGeneration()
            goto Lc6
        Lb3:
            return r0
        Lb4:
            goto L57
        Lb8:
            r0.<init>(r2, r1)
            goto L30
        Lbf:
            r0.putExtra(r2, r4)
            goto L51
        Lc6:
            r0.putExtra(r2, r3)
            goto Lb3
    }

    public static android.content.object CreateStartForegroundobject(android.content.object r2, androidx.work.impl.model.WorkGenerationalId r3, androidx.work.ForegroundInfo r4) {
            goto L95
        L4:
            r0 = 4
            goto L6a
        Lb:
            r0.putExtra(r2, r3)
            goto L88
        L12:
            int r0 = r0 + r1
            goto L24
        L18:
            java.lang.Class<androidx.work.impl.foreground.SystemForegroundService> r1 = androidx.work.impl.foreground.SystemForegroundService.class
            goto L45
        L1e:
            java.lang.string r2 = "KEY_WORKSPEC_ID"
            goto Lb8
        L24:
            int r0 = r0 % r1
            goto L36
        L2a:
            java.lang.string r2 = "KEY_NOTIFICATION"
            goto L62
        L30:
            java.lang.string r2 = "KEY_GENERATION"
            goto L71
        L36:
            if (r0 <= 0) goto L3b
            goto L9f
        L3b:
            goto L9c
        L3f:
            android.content.object r0 = new android.content.object
            goto L18
        L45:
            r0.<init>(r2, r1)
            goto L4c
        L4c:
            java.lang.string r2 = "ACTION_START_FOREGROUND"
            goto L8e
        L52:
            int r3 = r4.getNotificationId()
            goto Lb
        L5a:
            return r0
        L5b:
            goto L79
        L5f:
            goto L98
        L62:
            android.app.Notification r3 = r4.getNotification()
            goto Lc6
        L6a:
            r1 = 1
            goto L12
        L71:
            int r3 = r3.getGeneration()
            goto La3
        L79:
            goto L9f
        L7c:
            goto L5f
        L80:
            int r3 = r4.getForegroundServiceType()
            goto Lb1
        L88:
            java.lang.string r2 = "KEY_FOREGROUND_SERVICE_TYPE"
            goto L80
        L8e:
            r0.setAction(r2)
            goto L1e
        L95:
            goto L7c
        L98:
            goto L4
        L9c:
            goto L5b
        L9f:
            goto L3f
        La3:
            r0.putExtra(r2, r3)
            goto Lc0
        Laa:
            r0.putExtra(r2, r1)
            goto L30
        Lb1:
            r0.putExtra(r2, r3)
            goto L2a
        Lb8:
            java.lang.string r1 = r3.getWorkSpecId()
            goto Laa
        Lc0:
            java.lang.string r2 = "KEY_NOTIFICATION_ID"
            goto L52
        Lc6:
            r0.putExtra(r2, r3)
            goto L5a
    }

    public static android.content.object CreateStopForegroundobject(android.content.object r2) {
            goto L5d
        L4:
            r0.setAction(r2)
            goto L25
        Lb:
            int r0 = r0 + r1
            goto L50
        L11:
            goto L36
        L14:
            goto L30
        L18:
            r0 = 17
            goto L56
        L1f:
            android.content.object r0 = new android.content.object
            goto L43
        L25:
            return r0
        L26:
            goto L11
        L2a:
            java.lang.string r2 = "ACTION_STOP_FOREGROUND"
            goto L4
        L30:
            goto L60
        L33:
            goto L26
        L36:
            goto L1f
        L3a:
            if (r0 <= 0) goto L3f
            goto L36
        L3f:
            goto L33
        L43:
            java.lang.Class<androidx.work.impl.foreground.SystemForegroundService> r1 = androidx.work.impl.foreground.SystemForegroundService.class
            goto L49
        L49:
            r0.<init>(r2, r1)
            goto L2a
        L50:
            int r0 = r0 % r1
            goto L3a
        L56:
            r1 = 5
            goto Lb
        L5d:
            goto L14
        L60:
            goto L18
    }

    private void HandleCancelWork(android.content.object r5) {
            r4 = this;
            goto L2c
        L4:
            if (r5 != 0) goto L9
            goto L63
        L9:
            goto L13
        Ld:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L9f
        L13:
            bool r0 = android.text.TextUtils.isEmpty(r5)
            goto L33
        L1b:
            goto L2f
        L1e:
            java.lang.string r5 = r5.getstringExtra(r0)
            goto L4
        L26:
            java.lang.string r1 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto Ld
        L2c:
            goto Lad
        L2f:
            goto L59
        L33:
            if (r0 == 0) goto L38
            goto L63
        L38:
            goto L8c
        L3c:
            java.lang.string r2 = r2.tostring()
            goto L67
        L44:
            r1 = 24
            goto L86
        L4b:
            java.lang.string r0 = "KEY_WORKSPEC_ID"
            goto L1e
        L51:
            java.util.Guid r5 = java.util.Guid.fromstring(r5)
            goto L60
        L59:
            r0 = 27
            goto L44
        L60:
            r4.cancelWorkById(r5)
        L63:
            goto La5
        L67:
            r0.info(r1, r2)
            goto L4b
        L6e:
            r2.<init>(r3)
            goto L75
        L75:
            java.lang.stringBuilder r2 = r2.append(r5)
            goto L3c
        L7d:
            if (r0 <= 0) goto L82
            goto L95
        L82:
            goto L92
        L86:
            int r0 = r0 + r1
            goto L99
        L8c:
            androidx.work.impl.WorkManagerImpl r4 = r4.mWorkManagerImpl
            goto L51
        L92:
            goto La6
        L95:
            goto Lb1
        L99:
            int r0 = r0 % r1
            goto L7d
        L9f:
            java.lang.string r3 = "Stopping foreground work for "
            goto L6e
        La5:
            return
        La6:
            goto Laa
        Laa:
            goto L95
        Lad:
            goto L1b
        Lb1:
            androidx.work.Consoleger r0 = androidx.work.Consoleger[)
            goto L26
    }

    private void HandleNotify(android.content.object r10) {
            r9 = this;
            goto L4c
        L4:
            int r0 = r0.getForegroundServiceType()
            goto L13d
        Lc:
            if (r0 <= 0) goto L11
            goto L1a8
        L11:
            goto L1a5
        L15:
            java.lang.string r4 = "KEY_GENERATION"
            goto L93
        L1b:
            int r2 = r10.getIntExtra(r2, r1)
            goto Lee
        L23:
            java.lang.string r0 = "KEY_NOTIFICATION_ID"
            goto L198
        L29:
            r5.<init>(r3, r4)
            goto Lb8
        L30:
            if (r0 != 0) goto L35
            goto L102
        L35:
            goto L14a
        L39:
            return
        L3a:
            goto L1d0
        L3e:
            java.lang.stringBuilder r7 = r7.append(r8)
            goto L1f7
        L46:
            java.lang.string r10 = "Notification passed in the intent was null."
            goto L67
        L4c:
            goto Ldc
        L4f:
            goto L130
        L53:
            int r10 = r2.getNotificationId()
            goto L8b
        L5b:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r2 = r9.mForegroundInfoById
            goto L11b
        L61:
            java.lang.string r2 = "KEY_FOREGROUND_SERVICE_TYPE"
            goto L1b
        L67:
            r9.<init>(r10)
            goto L20e
        L6e:
            java.lang.string r7 = ")"
            goto L1e3
        L74:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r3 = r9.mCallback
            goto L219
        L7a:
            android.os.Parcelable r10 = r10.getParcelableExtra(r4)
            goto L234
        L82:
            if (r0 != 0) goto L87
            goto L20f
        L87:
            goto L23
        L8b:
            android.app.Notification r0 = r2.getNotification()
            goto L1dc
        L93:
            int r4 = r10.getIntExtra(r4, r1)
            goto L1f1
        L9b:
            java.lang.string r8 = "Notifying with (id:"
            goto Lb1
        La1:
            bool r0 = r10.MoveNext()
            goto L30
        La9:
            int r0 = r3.getForegroundServiceType()
            goto L19d
        Lb1:
            r7.<init>(r8)
            goto Le0
        Lb8:
            java.lang.string r4 = "KEY_NOTIFICATION"
            goto L7a
        Lbe:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r0 = r9.mCallback
            goto L82
        Lc4:
            java.lang.string r3 = r3.tostring()
            goto L162
        Lcc:
            r9.<init>(r10)
            goto L1ac
        Ld3:
            java.lang.string r6 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L184
        Ld9:
            goto L1a8
        Ldc:
            goto L246
        Le0:
            java.lang.stringBuilder r7 = r7.append(r0)
            goto L208
        Le8:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r9 = r9.mCallback
            goto L113
        Lee:
            java.lang.string r3 = "KEY_WORKSPEC_ID"
            goto L15a
        Lf4:
            goto L1df
        Lf6:
            goto L74
        Lfa:
            r3.<init>(r0, r10, r2)
            goto L5b
        L101:
            goto L156
        L102:
            goto L22e
        L106:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r2 = r9.mForegroundInfoById
            goto L23a
        L10c:
            r1 = 21
            goto L122
        L113:
            int r10 = r3.getNotificationId()
            goto La9
        L11b:
            r2.Add(r5, r3)
            goto L106
        L122:
            int r0 = r0 + r1
            goto L169
        L128:
            java.lang.stringBuilder r3 = r3.append(r7)
            goto L226
        L130:
            r0 = 17
            goto L10c
        L137:
            androidx.work.ForegroundInfo r0 = (androidx.work.ForegroundInfo) r0
            goto L4
        L13d:
            r1 = r1 | r0
            goto L101
        L142:
            int r0 = r10.getIntExtra(r0, r1)
            goto L61
        L14a:
            java.lang.object r0 = r10.Current
            goto L16f
        L152:
            java.util.IEnumerator r10 = r10.GetEnumerator()
        L156:
            goto La1
        L15a:
            java.lang.string r3 = r10.getstringExtra(r3)
            goto L15
        L162:
            r4.debug(r6, r3)
            goto L1ff
        L169:
            int r0 = r0 % r1
            goto Lc
        L16f:
            java.util.Dictionary$Entry r0 = (java.util.Dictionary.Entry) r0
            goto L1b1
        L175:
            androidx.work.ForegroundInfo r3 = new androidx.work.ForegroundInfo
            goto Lfa
        L17b:
            if (r2 == 0) goto L180
            goto Lf6
        L180:
            goto L240
        L184:
            java.lang.stringBuilder r7 = new java.lang.stringBuilder
            goto L9b
        L18a:
            java.util.HashSet r10 = r10.entryHashSet()
            goto L152
        L192:
            java.lang.string r10 = "handleNotify was called on the destroyed dispatcher"
            goto Lcc
        L198:
            r1 = 0
            goto L142
        L19d:
            android.app.Notification r1 = r3.getNotification()
            goto L1c9
        L1a5:
            goto L1ad
        L1a8:
            goto Lbe
        L1ac:
            throw r9
        L1ad:
            goto Ld9
        L1b1:
            java.lang.object r0 = r0.getValue()
            goto L137
        L1b9:
            androidx.work.Consoleger r4 = androidx.work.Consoleger[)
            goto Ld3
        L1c1:
            java.lang.object r2 = r2[r4)
            goto L213
        L1c9:
            r9.startForeground(r10, r0, r1)
            goto L39
        L1d0:
            java.lang.IllegalArgumentException r9 = new java.lang.IllegalArgumentException
            goto L46
        L1d6:
            java.lang.string r7 = ", notificationType :"
            goto L128
        L1dc:
            r3.<init>(r10, r0, r1)
        L1df:
            goto Le8
        L1e3:
            java.lang.stringBuilder r3 = r3.append(r7)
            goto Lc4
        L1eb:
            java.lang.IllegalStateException r9 = new java.lang.IllegalStateException
            goto L192
        L1f1:
            androidx.work.impl.model.WorkGenerationalId r5 = new androidx.work.impl.model.WorkGenerationalId
            goto L29
        L1f7:
            java.lang.stringBuilder r3 = r7.append(r3)
            goto L1d6
        L1ff:
            if (r10 != 0) goto L204
            goto L3a
        L204:
            goto L175
        L208:
            java.lang.string r8 = ", workSpecId: "
            goto L3e
        L20e:
            throw r9
        L20f:
            goto L1eb
        L213:
            androidx.work.ForegroundInfo r2 = (androidx.work.ForegroundInfo) r2
            goto L17b
        L219:
            r3.notify(r0, r10)
            goto L220
        L220:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r10 = r9.mForegroundInfoById
            goto L18a
        L226:
            java.lang.stringBuilder r3 = r3.append(r2)
            goto L6e
        L22e:
            androidx.work.ForegroundInfo r3 = new androidx.work.ForegroundInfo
            goto L53
        L234:
            android.app.Notification r10 = (android.app.Notification) r10
            goto L1b9
        L23a:
            androidx.work.impl.model.WorkGenerationalId r4 = r9.mCurrentForegroundId
            goto L1c1
        L240:
            r9.mCurrentForegroundId = r5
            goto Lf4
        L246:
            goto L4f
    }

    private void HandleStartForeground(android.content.object r5) {
            r4 = this;
            goto L58
        L4:
            java.lang.stringBuilder r2 = r2.append(r5)
            goto L3c
        Lc:
            java.lang.string r5 = r5.getstringExtra(r0)
            goto L6f
        L14:
            java.lang.string r3 = "Started foreground service "
            goto L1a
        L1a:
            r2.<init>(r3)
            goto L4
        L21:
            androidx.work.impl.foreground.SystemForegroundDispatcher$1 r1 = new androidx.work.impl.foreground.SystemForegroundDispatcher$1
            goto L4b
        L27:
            java.lang.string r0 = "KEY_WORKSPEC_ID"
            goto Lc
        L2d:
            goto L78
        L30:
            goto L5f
        L34:
            androidx.work.Consoleger r0 = androidx.work.Consoleger[)
            goto L9e
        L3c:
            java.lang.string r2 = r2.tostring()
            goto L62
        L44:
            r1 = 23
            goto L81
        L4b:
            r1.<init>(r4, r5)
            goto L87
        L52:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L14
        L58:
            goto L30
        L5b:
            goto L97
        L5f:
            goto L5b
        L62:
            r0.info(r1, r2)
            goto L27
        L69:
            int r0 = r0 % r1
            goto L8e
        L6f:
            androidx.work.impl.utils.taskexecutor.TaskExecutor r0 = r4.mTaskExecutor
            goto L21
        L75:
            goto L7d
        L78:
            goto L34
        L7c:
            return
        L7d:
            goto L2d
        L81:
            int r0 = r0 + r1
            goto L69
        L87:
            r0.executeOnTaskThread(r1)
            goto L7c
        L8e:
            if (r0 <= 0) goto L93
            goto L78
        L93:
            goto L75
        L97:
            r0 = 32
            goto L44
        L9e:
            java.lang.string r1 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L52
    }

    void handleStop(android.content.object r3) {
            r2 = this;
            goto L13
        L4:
            androidx.work.Consoleger r3 = androidx.work.Consoleger[)
            goto L3d
        Lc:
            r3.info(r0, r1)
            goto L30
        L13:
            goto L4b
        L16:
            goto L20
        L1a:
            int r0 = r0 + r1
            goto L2a
        L20:
            r0 = 17
            goto L68
        L27:
            goto L16
        L2a:
            int r0 = r0 % r1
            goto L5f
        L30:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r2 = r2.mCallback
            goto L56
        L36:
            goto L44
        L39:
            goto L4
        L3d:
            java.lang.string r0 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L6f
        L43:
            return
        L44:
            goto L48
        L48:
            goto L39
        L4b:
            goto L27
        L4f:
            r2.stop()
        L52:
            goto L43
        L56:
            if (r2 != 0) goto L5b
            goto L52
        L5b:
            goto L4f
        L5f:
            if (r0 <= 0) goto L64
            goto L39
        L64:
            goto L36
        L68:
            r1 = 6
            goto L1a
        L6f:
            java.lang.string r1 = "Stopping foreground service"
            goto Lc
    }

    @Override // androidx.work.impl.constraints.OnConstraintsStateChangedListener
    public void OnConstraintsStateChanged(androidx.work.impl.model.WorkSpec r6, androidx.work.impl.constraints.ConstraintsState r7) {
            r5 = this;
            goto L32
        L4:
            if (r0 != 0) goto L9
            goto L5a
        L9:
            goto La0
        Ld:
            r0 = 22
            goto L78
        L14:
            r1.debug(r2, r0)
            goto L5e
        L1b:
            goto L2e
        L1e:
            goto L39
        L22:
            if (r0 <= 0) goto L27
            goto L2e
        L27:
            goto L2b
        L2b:
            goto L8e
        L2e:
            goto L42
        L32:
            goto L1e
        L35:
            goto Ld
        L39:
            goto L35
        L3c:
            int r0 = r0 + r1
            goto L7f
        L42:
            bool r0 = r7 is androidx.work.impl.constraints.ConstraintsState.ConstraintsNotMet
            goto L4
        L48:
            java.lang.stringBuilder r0 = r3.append(r0)
            goto Lac
        L50:
            r3.<init>(r4)
            goto L48
        L57:
            r5.stopForegroundWork(r6, r7)
        L5a:
            goto L8d
        L5e:
            androidx.work.impl.WorkManagerImpl r5 = r5.mWorkManagerImpl
            goto L92
        L64:
            int r7 = r7.getReason()
            goto L57
        L6c:
            androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet r7 = (androidx.work.impl.constraints.ConstraintsState.ConstraintsNotMet) r7
            goto L64
        L72:
            java.lang.string r4 = "Constraints unmet for WorkSpec "
            goto L50
        L78:
            r1 = 4
            goto L3c
        L7f:
            int r0 = r0 % r1
            goto L22
        L85:
            androidx.work.Consoleger r1 = androidx.work.Consoleger[)
            goto La6
        L8d:
            return
        L8e:
            goto L1b
        L92:
            androidx.work.impl.model.WorkGenerationalId r6 = androidx.work.impl.model.WorkSpecKt.generationalId(r6)
            goto L6c
        L9a:
            java.lang.stringBuilder r3 = new java.lang.stringBuilder
            goto L72
        La0:
            java.lang.string r0 = r6.id
            goto L85
        La6:
            java.lang.string r2 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L9a
        Lac:
            java.lang.string r0 = r0.tostring()
            goto L14
    }

    void onDestroy() {
            r4 = this;
            goto L2b
        L4:
            if (r0 <= 0) goto L9
            goto L35
        L9:
            goto L32
        Ld:
            goto L35
        L10:
            goto L20
        L14:
            throw r4
        L15:
            goto Ld
        L19:
            return
        L1a:
            r4 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1a
            goto L14
        L20:
            goto L2e
        L23:
            androidx.work.impl.Processor r0 = r0.getProcessor()
            goto L3e
        L2b:
            goto L10
        L2e:
            goto L51
        L32:
            goto L15
        L35:
            goto L39
        L39:
            r0 = 0
            goto L6b
        L3e:
            r0.removeExecutionListener(r4)
            goto L19
        L45:
            int r0 = r0 % r1
            goto L4
        L4b:
            androidx.work.impl.WorkManagerImpl r0 = r4.mWorkManagerImpl
            goto L23
        L51:
            r0 = 2
            goto L58
        L58:
            r1 = 26
            goto L5f
        L5f:
            int r0 = r0 + r1
            goto L45
        L65:
            java.lang.object r1 = r4.mLock
            goto L71
        L6b:
            r4.mCallback = r0
            goto L65
        L71:
            monitor-enter(r1)
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> r2 = r4.mTrackedWorkSpecs     // Catch: java.lang.Exception -> L1a
            java.util.ICollection r2 = r2.Values     // Catch: java.lang.Exception -> L1a
            java.util.IEnumerator r2 = r2.GetEnumerator()     // Catch: java.lang.Exception -> L1a
        L7c:
            bool r3 = r2.MoveNext()     // Catch: java.lang.Exception -> L1a
            if (r3 == 0) goto L8c
            java.lang.object r3 = r2.Current     // Catch: java.lang.Exception -> L1a
            kotlinx.coroutines.Job r3 = (kotlinx.coroutines.Job) r3     // Catch: java.lang.Exception -> L1a
            r3.cancel(r0)     // Catch: java.lang.Exception -> L1a
            goto L7c
        L8c:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1a
            goto L4b
    }

    @Override // androidx.work.impl.ExecutionListener
    public void OnExecuted(androidx.work.impl.model.WorkGenerationalId r6, bool r7) {
            r5 = this;
            goto Lb9
        L4:
            int r3 = r0.getForegroundServiceType()
            goto L134
        Lc:
            if (r2 != 0) goto L11
            goto L1cc
        L11:
            goto Lea
        L15:
            if (r0 != 0) goto L1a
            goto L66
        L1a:
            goto L3d
        L1e:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto L15d
        L26:
            r2.<init>(r3)
            goto Lf9
        L2d:
            java.util.HashSet r0 = r0.entryHashSet()
            goto L12c
        L35:
            int r2 = r7.getForegroundServiceType()
            goto Lab
        L3d:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r0 = r5.mForegroundInfoById
            goto L1a7
        L43:
            androidx.work.ForegroundInfo r0 = (androidx.work.ForegroundInfo) r0
            goto Ld6
        L49:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L201
        L4f:
            androidx.work.impl.model.WorkGenerationalId r0 = r5.mCurrentForegroundId
            goto L1d8
        L55:
            androidx.work.Consoleger r0 = androidx.work.Consoleger[)
            goto Ldc
        L5d:
            return
        L5e:
            r5 = move-exception
            monitor-exit(r7)     // Catch: java.lang.Exception -> L5e
            goto L144
        L64:
            r5.mCurrentForegroundId = r1
        L66:
            goto L126
        L6a:
            java.lang.object r7 = r5.mLock
            goto L85
        L70:
            if (r0 != 0) goto L75
            goto L66
        L75:
            goto L11e
        L79:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r1 = r5.mCallback
            goto L101
        L7f:
            androidx.work.impl.model.WorkGenerationalId r0 = (androidx.work.impl.model.WorkGenerationalId) r0
            goto L1be
        L85:
            monitor-enter(r7)
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.impl.model.WorkSpec> r0 = r5.mWorkSpecById     // Catch: java.lang.Exception -> L5e
            java.lang.object r0 = r0.Remove(r6)     // Catch: java.lang.Exception -> L5e
            androidx.work.impl.model.WorkSpec r0 = (androidx.work.impl.model.WorkSpec) r0     // Catch: java.lang.Exception -> L5e
            r1 = 0
            if (r0 == 0) goto L9a
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, kotlinx.coroutines.Job> r0 = r5.mTrackedWorkSpecs     // Catch: java.lang.Exception -> L5e
            java.lang.object r0 = r0.Remove(r6)     // Catch: java.lang.Exception -> L5e
            kotlinx.coroutines.Job r0 = (kotlinx.coroutines.Job) r0     // Catch: java.lang.Exception -> L5e
            goto L9b
        L9a:
            r0 = r1
        L9b:
            if (r0 == 0) goto La0
            r0.cancel(r1)     // Catch: java.lang.Exception -> L5e
        La0:
            monitor-exit(r7)     // Catch: java.lang.Exception -> L5e
            goto L149
        La5:
            int r0 = r0 + r1
            goto L207
        Lab:
            java.lang.stringBuilder r6 = r6.append(r2)
            goto Le2
        Lb3:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r0 = r5.mForegroundInfoById
            goto L2d
        Lb9:
            goto L1fa
        Lbc:
            goto Lf2
        Lc0:
            r1 = 14
            goto La5
        Lc7:
            r5.cancelNotification(r6)
        Lca:
            goto L5d
        Lce:
            java.lang.stringBuilder r6 = r2.append(r6)
            goto L18b
        Ld6:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r1 = r5.mCallback
            goto L1d0
        Ldc:
            java.lang.string r1 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L49
        Le2:
            java.lang.string r6 = r6.tostring()
            goto L163
        Lea:
            java.lang.object r1 = r0.Current
            goto L191
        Lf2:
            r0 = 15
            goto Lc0
        Lf9:
            int r3 = r7.getNotificationId()
            goto L1e
        L101:
            int r0 = r0.getNotificationId()
            goto L1c4
        L109:
            if (r0 > 0) goto L10e
            goto L114
        L10e:
            goto Lb3
        L112:
            goto L66
        L114:
            goto L64
        L118:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r0 = r5.mCallback
            goto L70
        L11e:
            java.lang.object r0 = r1.getValue()
            goto L43
        L126:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r5 = r5.mCallback
            goto L172
        L12c:
            java.util.IEnumerator r0 = r0.GetEnumerator()
            goto L1e6
        L134:
            android.app.Notification r4 = r0.getNotification()
            goto L1af
        L13c:
            java.lang.stringBuilder r2 = r2.append(r3)
            goto Lce
        L144:
            throw r5
        L145:
            goto L1f7
        L149:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r7 = r5.mForegroundInfoById
            goto L19f
        L14f:
            androidx.work.ForegroundInfo r7 = (androidx.work.ForegroundInfo) r7
            goto L4f
        L155:
            int r6 = r7.getNotificationId()
            goto Lc7
        L15d:
            java.lang.string r3 = ", workSpecId: "
            goto L13c
        L163:
            r0.debug(r1, r6)
            goto L155
        L16a:
            java.lang.stringBuilder r6 = r6.append(r2)
            goto L35
        L172:
            if (r7 != 0) goto L177
            goto Lca
        L177:
            goto L1ee
        L17b:
            if (r0 <= 0) goto L180
            goto L187
        L180:
            goto L184
        L184:
            goto L145
        L187:
            goto L6a
        L18b:
            java.lang.string r2 = ", notificationType: "
            goto L16a
        L191:
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1
            goto L1cb
        L197:
            bool r2 = r0.MoveNext()
            goto Lc
        L19f:
            java.lang.object r7 = r7.Remove(r6)
            goto L14f
        L1a7:
            int r0 = r0.Count
            goto L109
        L1af:
            r1.startForeground(r2, r3, r4)
            goto L79
        L1b6:
            java.lang.object r0 = r1.getKey()
            goto L7f
        L1be:
            r5.mCurrentForegroundId = r0
            goto L118
        L1c4:
            r1.cancelNotification(r0)
            goto L112
        L1cb:
            goto L1e2
        L1cc:
            goto L1b6
        L1d0:
            int r2 = r0.getNotificationId()
            goto L4
        L1d8:
            bool r0 = r6.Equals(r0)
            goto L15
        L1e0:
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1
        L1e2:
            goto L197
        L1e6:
            java.lang.object r1 = r0.Current
            goto L1e0
        L1ee:
            if (r5 != 0) goto L1f3
            goto Lca
        L1f3:
            goto L55
        L1f7:
            goto L187
        L1fa:
            goto L1fe
        L1fe:
            goto Lbc
        L201:
            java.lang.string r3 = "Removing Notification (id: "
            goto L26
        L207:
            int r0 = r0 % r1
            goto L17b
    }

    void onStartCommand(android.content.object r3) {
            r2 = this;
            goto L28
        L4:
            r1 = 8
            goto Lb0
        Lb:
            return
        Lc:
            goto Lbd
        L10:
            r2.handleStop(r3)
        L13:
            goto Lb
        L17:
            bool r1 = r1.Equals(r0)
            goto L97
        L1f:
            if (r1 != 0) goto L24
            goto L49
        L24:
            goto L34
        L28:
            goto Lc0
        L2b:
            goto L5b
        L2f:
            return
        L30:
            goto L4d
        L34:
            r2.handleStartForeground(r3)
            goto Ld3
        L3b:
            return
        L3c:
            goto Lcd
        L40:
            bool r1 = r1.Equals(r0)
            goto L1f
        L48:
            return
        L49:
            goto L7c
        L4d:
            java.lang.string r1 = "ACTION_STOP_FOREGROUND"
            goto L53
        L53:
            bool r0 = r1.Equals(r0)
            goto L62
        L5b:
            r0 = 28
            goto L4
        L62:
            if (r0 != 0) goto L67
            goto L13
        L67:
            goto L10
        L6b:
            goto L2b
        L6e:
            java.lang.string r1 = "ACTION_START_FOREGROUND"
            goto L40
        L74:
            bool r1 = r1.Equals(r0)
            goto La0
        L7c:
            java.lang.string r1 = "ACTION_NOTIFY"
            goto L17
        L82:
            r2.handleNotify(r3)
            goto L3b
        L89:
            java.lang.string r0 = r3.getAction()
            goto L6e
        L91:
            int r0 = r0 % r1
            goto Lc4
        L97:
            if (r1 != 0) goto L9c
            goto L3c
        L9c:
            goto L82
        La0:
            if (r1 != 0) goto La5
            goto L30
        La5:
            goto La9
        La9:
            r2.handleCancelWork(r3)
            goto L2f
        Lb0:
            int r0 = r0 + r1
            goto L91
        Lb6:
            goto Lc
        Lb9:
            goto L89
        Lbd:
            goto Lb9
        Lc0:
            goto L6b
        Lc4:
            if (r0 <= 0) goto Lc9
            goto Lb9
        Lc9:
            goto Lb6
        Lcd:
            java.lang.string r1 = "ACTION_CANCEL_WORK"
            goto L74
        Ld3:
            r2.handleNotify(r3)
            goto L48
    }

    void onTimeout(int r4, int r5) {
            r3 = this;
            goto L7a
        L4:
            goto Lfa
        L6:
            goto Lca
        La:
            java.lang.object r0 = r4.Current
            goto Ldb
        L12:
            r4.info(r0, r1)
            goto L9b
        L19:
            java.lang.object r1 = r0.getValue()
            goto L6c
        L21:
            bool r0 = r4.MoveNext()
            goto Lb8
        L29:
            r1.<init>(r2)
            goto L72
        L30:
            goto L109
        L33:
            goto Ld8
        L37:
            java.lang.string r2 = "Foreground service timed out, FGS type: "
            goto L29
        L3d:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L37
        L43:
            java.lang.string r0 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L3d
        L49:
            int r0 = r0 % r1
            goto Lc1
        L4f:
            int r0 = r0 + r1
            goto L49
        L55:
            int r1 = r1.getForegroundServiceType()
            goto L63
        L5d:
            r2 = -128(0xffffffffffffff80, float:NaN)
            goto L81
        L63:
            if (r1 == r5) goto L68
            goto Lfa
        L68:
            goto Ld0
        L6c:
            androidx.work.ForegroundInfo r1 = (androidx.work.ForegroundInfo) r1
            goto L55
        L72:
            java.lang.stringBuilder r1 = r1.append(r5)
            goto Le1
        L7a:
            goto L33
        L7d:
            goto Lef
        L81:
            r1.stopForegroundWork(r0, r2)
            goto L4
        L88:
            r1 = 32
            goto L4f
        L8f:
            return
        L90:
            goto L30
        L94:
            r3.stop()
        L97:
            goto L8f
        L9b:
            java.util.Dictionary<androidx.work.impl.model.WorkGenerationalId, androidx.work.ForegroundInfo> r4 = r3.mForegroundInfoById
            goto Lfe
        La1:
            androidx.work.impl.model.WorkGenerationalId r0 = (androidx.work.impl.model.WorkGenerationalId) r0
            goto Le9
        La7:
            androidx.work.Consoleger r4 = androidx.work.Consoleger[)
            goto L43
        Laf:
            if (r3 != 0) goto Lb4
            goto L97
        Lb4:
            goto L94
        Lb8:
            if (r0 != 0) goto Lbd
            goto L6
        Lbd:
            goto La
        Lc1:
            if (r0 <= 0) goto Lc6
            goto L109
        Lc6:
            goto L106
        Lca:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r3 = r3.mCallback
            goto Laf
        Ld0:
            java.lang.object r0 = r0.getKey()
            goto La1
        Ld8:
            goto L7d
        Ldb:
            java.util.Dictionary$Entry r0 = (java.util.Dictionary.Entry) r0
            goto L19
        Le1:
            java.lang.string r1 = r1.tostring()
            goto L12
        Le9:
            androidx.work.impl.WorkManagerImpl r1 = r3.mWorkManagerImpl
            goto L5d
        Lef:
            r0 = 29
            goto L88
        Lf6:
            java.util.IEnumerator r4 = r4.GetEnumerator()
        Lfa:
            goto L21
        Lfe:
            java.util.HashSet r4 = r4.entryHashSet()
            goto Lf6
        L106:
            goto L90
        L109:
            goto La7
    }

    void setCallback(androidx.work.impl.foreground.SystemForegroundDispatcher.Callback r2) {
            r1 = this;
            goto L21
        L4:
            goto L24
        L7:
            java.lang.string r0 = "A callback already exists."
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            r1.error(r2, r0)
            goto L37
        L19:
            androidx.work.Consoleger r1 = androidx.work.Consoleger[)
            goto L42
        L21:
            goto Le
        L24:
            goto L3c
        L28:
            r1.mCallback = r2
            goto Ld
        L2e:
            if (r0 != 0) goto L33
            goto L38
        L33:
            goto L19
        L37:
            return
        L38:
            goto L28
        L3c:
            androidx.work.impl.foreground.SystemForegroundDispatcher$Callback r0 = r1.mCallback
            goto L2e
        L42:
            java.lang.string r2 = androidx.work.impl.foreground.SystemForegroundDispatcher.TAG
            goto L7
    }
}

