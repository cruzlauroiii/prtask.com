namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
public readonly class LocalBroadcastManager {
    private static readonly bool DEBUG = false;
    static readonly int MSG_EXEC_PENDING_BROADCASTS = 1;
    private static readonly java.lang.string TAG = "LocalBroadcastManager";
    private static androidx.localbroadcastmanager.content.LocalBroadcastManager mInstance;
    private static readonly java.lang.object mLock = null;
    private readonly java.util.HashDictionary<java.lang.string, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord>> mActions;
    private readonly android.content.object mAppobject;
    private readonly android.os.Handler mHandler;
    private readonly java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager.BroadcastRecord> mPendingBroadcasts;
    private readonly java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord>> mReceivers;


    private static readonly class BroadcastRecord {
        readonly android.content.object intent;
        readonly java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord> receivers;

        BroadcastRecord(android.content.object r1, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord> r2) {
                r0 = this;
                goto L1f
            L4:
                goto L22
            L7:
                r0.intent = r1
                goto Ld
            Ld:
                r0.receivers = r2
                goto L1a
            L13:
                r0.<init>()
                goto L7
            L1a:
                return
            L1b:
                goto L4
            L1f:
                goto L1b
            L22:
                goto L13
        }
    }

    private static readonly class ReceiverRecord {
        bool broadcasting;
        bool dead;
        readonly android.content.objectFilter filter;
        readonly android.content.BroadcastReceiver receiver;

        ReceiverRecord(android.content.objectFilter r1, android.content.BroadcastReceiver r2) {
                r0 = this;
                goto L16
            L4:
                r0.<init>()
                goto Lb
            Lb:
                r0.filter = r1
                goto L1d
            L11:
                return
            L12:
                goto L23
            L16:
                goto L12
            L19:
                goto L4
            L1d:
                r0.receiver = r2
                goto L11
            L23:
                goto L19
        }

        public java.lang.string Tostring() {
                r2 = this;
                goto L5f
            L4:
                if (r0 <= 0) goto L9
                goto La5
            L9:
                goto La2
            Ld:
                goto L62
            L10:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L66
            L16:
                int r0 = r0 + r1
                goto L3e
            L1c:
                java.lang.string r1 = "Receiver{"
                goto L95
            L22:
                java.lang.string r2 = r0.tostring()
                goto Lb2
            L2a:
                goto La5
            L2d:
                goto Ld
            L31:
                android.content.objectFilter r1 = r2.filter
                goto L37
            L37:
                r0.append(r1)
                goto L9c
            L3e:
                int r0 = r0 % r1
                goto L4
            L44:
                r0 = 11
                goto L58
            L4b:
                r0.append(r2)
                goto L22
            L52:
                java.lang.string r1 = " filter="
                goto L73
            L58:
                r1 = 27
                goto L16
            L5f:
                goto L2d
            L62:
                goto L44
            L66:
                r1 = 128(0x80, float:1.8E-43)
                goto L87
            L6c:
                r0.append(r2)
            L6f:
                goto L80
            L73:
                r0.append(r1)
                goto L31
            L7a:
                java.lang.string r2 = " DEAD"
                goto L6c
            L80:
                java.lang.string r2 = "}"
                goto L4b
            L87:
                r0.<init>(r1)
                goto L1c
            L8e:
                r0.append(r1)
                goto L52
            L95:
                r0.append(r1)
                goto Lb7
            L9c:
                bool r2 = r2.dead
                goto La9
            La2:
                goto Lb3
            La5:
                goto L10
            La9:
                if (r2 != 0) goto Lae
                goto L6f
            Lae:
                goto L7a
            Lb2:
                return r2
            Lb3:
                goto L2a
            Lb7:
                android.content.BroadcastReceiver r1 = r2.receiver
                goto L8e
        }
    }

    static {
            goto L1f
        L4:
            goto L22
        L7:
            java.lang.object r0 = new java.lang.object
            goto Ld
        Ld:
            r0.<init>()
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            androidx.localbroadcastmanager.content.LocalBroadcastManager.mLock = r0
            goto L14
        L1f:
            goto L15
        L22:
            goto L7
    }

    private LocalBroadcastManager(android.content.object r2) {
            r1 = this;
            goto L2e
        L4:
            r1.<init>()
            goto L55
        Lb:
            android.os.Looper r2 = r2.getMainLooper()
            goto L13
        L13:
            r0.<init>(r1, r2)
            goto L62
        L1a:
            r0.<init>()
            goto L21
        L21:
            r1.mPendingBroadcasts = r0
            goto L68
        L27:
            r0.<init>()
            goto L4c
        L2e:
            goto L48
        L31:
            goto L4
        L35:
            java.util.List r0 = new java.util.List
            goto L1a
        L3b:
            r1.mActions = r0
            goto L35
        L41:
            androidx.localbroadcastmanager.content.LocalBroadcastManager$1 r0 = new androidx.localbroadcastmanager.content.LocalBroadcastManager$1
            goto Lb
        L47:
            return
        L48:
            goto L52
        L4c:
            r1.mReceivers = r0
            goto L6e
        L52:
            goto L31
        L55:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L27
        L5b:
            r0.<init>()
            goto L3b
        L62:
            r1.mHandler = r0
            goto L47
        L68:
            r1.mAppobject = r2
            goto L41
        L6e:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L5b
    }

    public static androidx.localbroadcastmanager.content.LocalBroadcastManager GetInstance(android.content.object r2) {
            goto L55
        L4:
            java.lang.object r0 = androidx.localbroadcastmanager.content.LocalBroadcastManager.mLock
            goto L1e
        La:
            r1 = 4
            goto L11
        L11:
            int r0 = r0 + r1
            goto L48
        L17:
            goto L60
        L1a:
            goto L4
        L1e:
            monitor-enter(r0)
            androidx.localbroadcastmanager.content.LocalBroadcastManager r1 = androidx.localbroadcastmanager.content.LocalBroadcastManager.mInstance     // Catch: java.lang.Exception -> L32
            if (r1 != 0) goto L2e
            androidx.localbroadcastmanager.content.LocalBroadcastManager r1 = new androidx.localbroadcastmanager.content.LocalBroadcastManager     // Catch: java.lang.Exception -> L32
            android.content.object r2 = r2.getApplicationobject()     // Catch: java.lang.Exception -> L32
            r1.<init>(r2)     // Catch: java.lang.Exception -> L32
            androidx.localbroadcastmanager.content.LocalBroadcastManager.mInstance = r1     // Catch: java.lang.Exception -> L32
        L2e:
            androidx.localbroadcastmanager.content.LocalBroadcastManager r2 = androidx.localbroadcastmanager.content.LocalBroadcastManager.mInstance     // Catch: java.lang.Exception -> L32
            monitor-exit(r0)     // Catch: java.lang.Exception -> L32
            return r2
        L32:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L32
            goto L5f
        L38:
            if (r0 <= 0) goto L3d
            goto L1a
        L3d:
            goto L17
        L41:
            goto L1a
        L44:
            goto L5c
        L48:
            int r0 = r0 % r1
            goto L38
        L4e:
            r0 = 8
            goto La
        L55:
            goto L44
        L58:
            goto L4e
        L5c:
            goto L58
        L5f:
            throw r2
        L60:
            goto L41
    }

    void executePendingBroadcasts() {
            r10 = this;
            goto La1
        L4:
            if (r3 < r1) goto L9
            goto Leb
        L9:
            goto L1b
        Ld:
            throw r10
        Le:
            goto L7e
        L12:
            if (r0 <= 0) goto L17
            goto Leb
        L17:
            goto Le8
        L1b:
            r4 = r2[r3]
            goto Lae
        L21:
            if (r6 < r5) goto L26
            goto L4f
        L26:
            goto Lcd
        L2a:
            java.lang.object r7 = r7[r6)
            goto Ldc
        L32:
            int r3 = r3 + 1
            goto L77
        L38:
            bool r8 = r7.dead
            goto Ld3
        L3e:
            goto La4
        L41:
            r7.onReceive(r8, r9)
        L44:
            goto L5a
        L48:
            int r0 = r0 + r1
            goto Le2
        L4e:
            goto Lc4
        L4f:
            goto L32
        L53:
            r0 = 13
            goto Lb4
        L5a:
            int r6 = r6 + 1
            goto L4e
        L60:
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r0 = r10.mReceivers
            goto L85
        L66:
            android.content.object r8 = r10.mAppobject
            goto L71
        L6c:
            r0 = 0
            goto Lc8
        L71:
            android.content.object r9 = r4.intent
            goto L41
        L77:
            goto Lc9
        L78:
            r10 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L78
            goto Ld
        L7e:
            goto Leb
        L81:
            goto L3e
        L85:
            monitor-enter(r0)
            java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord> r1 = r10.mPendingBroadcasts     // Catch: java.lang.Exception -> L78
            int r1 = r1.Count     // Catch: java.lang.Exception -> L78
            if (r1 > 0) goto L90
            monitor-exit(r0)     // Catch: java.lang.Exception -> L78
            return
        L90:
            androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord[] r2 = new androidx.localbroadcastmanager.content.LocalBroadcastManager.BroadcastRecord[r1]     // Catch: java.lang.Exception -> L78
            java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord> r3 = r10.mPendingBroadcasts     // Catch: java.lang.Exception -> L78
            r3.toArray(r2)     // Catch: java.lang.Exception -> L78
            java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord> r3 = r10.mPendingBroadcasts     // Catch: java.lang.Exception -> L78
            r3.clear()     // Catch: java.lang.Exception -> L78
            monitor-exit(r0)     // Catch: java.lang.Exception -> L78
            goto L6c
        La1:
            goto L81
        La4:
            goto L53
        La8:
            android.content.BroadcastReceiver r7 = r7.receiver
            goto L66
        Lae:
            java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord> r5 = r4.receivers
            goto Lbb
        Lb4:
            r1 = 9
            goto L48
        Lbb:
            int r5 = r5.Count
            goto Lc3
        Lc3:
            r6 = r0
        Lc4:
            goto L21
        Lc8:
            r3 = r0
        Lc9:
            goto L4
        Lcd:
            java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord> r7 = r4.receivers
            goto L2a
        Ld3:
            if (r8 == 0) goto Ld8
            goto L44
        Ld8:
            goto La8
        Ldc:
            androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord r7 = (androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord) r7
            goto L38
        Le2:
            int r0 = r0 % r1
            goto L12
        Le8:
            goto Le
        Leb:
            goto L60
    }

    public void RegisterReceiver(android.content.BroadcastReceiver r7, android.content.objectFilter r8) {
            r6 = this;
            goto L8e
        L4:
            goto L36
        L7:
            goto L1c
        Lb:
            r1 = 32
            goto L29
        L12:
            goto L7
        L15:
            goto L19
        L19:
            goto L91
        L1c:
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r0 = r6.mReceivers
            goto L3a
        L22:
            r0 = 24
            goto Lb
        L29:
            int r0 = r0 + r1
            goto L2f
        L2f:
            int r0 = r0 % r1
            goto L85
        L35:
            throw r6
        L36:
            goto L12
        L3a:
            monitor-enter(r0)
            androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord r1 = new androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord     // Catch: java.lang.Exception -> L7f
            r1.<init>(r8, r7)     // Catch: java.lang.Exception -> L7f
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r2 = r6.mReceivers     // Catch: java.lang.Exception -> L7f
            java.lang.object r2 = r2[r7)     // Catch: java.lang.Exception -> L7f
            java.util.List r2 = (java.util.List) r2     // Catch: java.lang.Exception -> L7f
            r3 = 1
            if (r2 != 0) goto L55
            java.util.List r2 = new java.util.List     // Catch: java.lang.Exception -> L7f
            r2.<init>(r3)     // Catch: java.lang.Exception -> L7f
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r4 = r6.mReceivers     // Catch: java.lang.Exception -> L7f
            r4.Add(r7, r2)     // Catch: java.lang.Exception -> L7f
        L55:
            r2.Add(r1)     // Catch: java.lang.Exception -> L7f
            r7 = 0
        L59:
            int r2 = r8.countActions()     // Catch: java.lang.Exception -> L7f
            if (r7 >= r2) goto L7d
            java.lang.string r2 = r8.getAction(r7)     // Catch: java.lang.Exception -> L7f
            java.util.HashDictionary<java.lang.string, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r4 = r6.mActions     // Catch: java.lang.Exception -> L7f
            java.lang.object r4 = r4[r2)     // Catch: java.lang.Exception -> L7f
            java.util.List r4 = (java.util.List) r4     // Catch: java.lang.Exception -> L7f
            if (r4 != 0) goto L77
            java.util.List r4 = new java.util.List     // Catch: java.lang.Exception -> L7f
            r4.<init>(r3)     // Catch: java.lang.Exception -> L7f
            java.util.HashDictionary<java.lang.string, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r5 = r6.mActions     // Catch: java.lang.Exception -> L7f
            r5.Add(r2, r4)     // Catch: java.lang.Exception -> L7f
        L77:
            r4.Add(r1)     // Catch: java.lang.Exception -> L7f
            int r7 = r7 + 1
            goto L59
        L7d:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L7f
            return
        L7f:
            r6 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L7f
            goto L35
        L85:
            if (r0 <= 0) goto L8a
            goto L7
        L8a:
            goto L4
        L8e:
            goto L15
        L91:
            goto L22
    }

    public bool SendBroadcast(android.content.object r19) {
            r18 = this;
            goto L1ba
        L4:
            java.lang.string r2 = "Action list: "
            goto L10
        La:
            int r0 = r0 + r1
            goto L34
        L10:
            java.lang.string r3 = "Resolving type "
            goto L2b
        L16:
            r0 = 31
            goto L1d
        L1d:
            r1 = 15
            goto La
        L24:
            goto L3b
        L27:
            goto L1b4
        L2b:
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r4 = r0.mReceivers
            goto L4f
        L31:
            goto L1bd
        L34:
            int r0 = r0 % r1
            goto L3f
        L3a:
            throw r0
        L3b:
            goto L48
        L3f:
            if (r0 <= 0) goto L44
            goto L27
        L44:
            goto L24
        L48:
            goto L27
        L4b:
            goto L31
        L4f:
            monitor-enter(r4)
            java.lang.string r6 = r1.getAction()     // Catch: java.lang.Exception -> L1a8
            android.content.object r5 = r0.mAppobject     // Catch: java.lang.Exception -> L1a8
            android.content.ContentResolver r5 = r5.getContentResolver()     // Catch: java.lang.Exception -> L1a8
            java.lang.string r7 = r1.resolveTypeIfNeeded(r5)     // Catch: java.lang.Exception -> L1a8
            android.net.Uri r9 = r1.getData()     // Catch: java.lang.Exception -> L1a8
            java.lang.string r8 = r1.getScheme()     // Catch: java.lang.Exception -> L1a8
            java.util.HashSet r10 = r1.getCategories()     // Catch: java.lang.Exception -> L1a8
            int r5 = r1.getFlags()     // Catch: java.lang.Exception -> L1a8
            r5 = r5 & 8
            if (r5 == 0) goto L74
            r14 = 1
            goto L75
        L74:
            r14 = 0
        L75:
            if (r14 == 0) goto L9d
            java.lang.string r5 = "LocalBroadcastManager"
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1a8
            r11.<init>(r3)     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r3 = r11.append(r7)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r11 = " scheme "
            java.lang.stringBuilder r3 = r3.append(r11)     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r3 = r3.append(r8)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r11 = " of intent "
            java.lang.stringBuilder r3 = r3.append(r11)     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r3 = r3.append(r1)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r3 = r3.tostring()     // Catch: java.lang.Exception -> L1a8
            android.util.Console.v(r5, r3)     // Catch: java.lang.Exception -> L1a8
        L9d:
            java.util.HashDictionary<java.lang.string, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r3 = r0.mActions     // Catch: java.lang.Exception -> L1a8
            java.lang.string r5 = r1.getAction()     // Catch: java.lang.Exception -> L1a8
            java.lang.object r3 = r3[r5)     // Catch: java.lang.Exception -> L1a8
            java.util.List r3 = (java.util.List) r3     // Catch: java.lang.Exception -> L1a8
            if (r3 == 0) goto L1a4
            if (r14 == 0) goto Lbf
            java.lang.string r5 = "LocalBroadcastManager"
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1a8
            r11.<init>(r2)     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r2 = r11.append(r3)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r2 = r2.tostring()     // Catch: java.lang.Exception -> L1a8
            android.util.Console.v(r5, r2)     // Catch: java.lang.Exception -> L1a8
        Lbf:
            r2 = 0
            r15 = 0
        Lc1:
            int r5 = r3.Count     // Catch: java.lang.Exception -> L1a8
            if (r15 >= r5) goto L175
            java.lang.object r5 = r3[r15)     // Catch: java.lang.Exception -> L1a8
            androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord r5 = (androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord) r5     // Catch: java.lang.Exception -> L1a8
            if (r14 == 0) goto Le9
            java.lang.string r11 = "LocalBroadcastManager"
            java.lang.stringBuilder r12 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1a8
            r12.<init>()     // Catch: java.lang.Exception -> L1a8
            java.lang.string r13 = "Matching against filter "
            java.lang.stringBuilder r12 = r12.append(r13)     // Catch: java.lang.Exception -> L1a8
            android.content.objectFilter r13 = r5.filter     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r12 = r12.append(r13)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r12 = r12.tostring()     // Catch: java.lang.Exception -> L1a8
            android.util.Console.v(r11, r12)     // Catch: java.lang.Exception -> L1a8
        Le9:
            bool r11 = r5.broadcasting     // Catch: java.lang.Exception -> L1a8
            if (r11 == 0) goto Lfa
            if (r14 == 0) goto Lf6
            java.lang.string r5 = "LocalBroadcastManager"
            java.lang.string r11 = "  Filter's target already added"
            android.util.Console.v(r5, r11)     // Catch: java.lang.Exception -> L1a8
        Lf6:
            r17 = r3
            goto L16f
        Lfa:
            r11 = r5
            android.content.objectFilter r5 = r11.filter     // Catch: java.lang.Exception -> L1a8
            r12 = r11
            java.lang.string r11 = "LocalBroadcastManager"
            int r5 = r5.match(r6, r7, r8, r9, r10, r11)     // Catch: java.lang.Exception -> L1a8
            if (r5 < 0) goto L137
            if (r14 == 0) goto L127
            java.lang.string r11 = "LocalBroadcastManager"
            java.lang.stringBuilder r13 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1a8
            r13.<init>()     // Catch: java.lang.Exception -> L1a8
            r17 = r3
            java.lang.string r3 = "  Filter matched!  match=0x"
            java.lang.stringBuilder r3 = r13.append(r3)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r5 = java.lang.int.toHexstring(r5)     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r3 = r3.append(r5)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r3 = r3.tostring()     // Catch: java.lang.Exception -> L1a8
            android.util.Console.v(r11, r3)     // Catch: java.lang.Exception -> L1a8
            goto L129
        L127:
            r17 = r3
        L129:
            if (r2 != 0) goto L130
            java.util.List r2 = new java.util.List     // Catch: java.lang.Exception -> L1a8
            r2.<init>()     // Catch: java.lang.Exception -> L1a8
        L130:
            r2.Add(r12)     // Catch: java.lang.Exception -> L1a8
            r3 = 1
            r12.broadcasting = r3     // Catch: java.lang.Exception -> L1a8
            goto L16f
        L137:
            r17 = r3
            if (r14 == 0) goto L16f
            r3 = -4
            if (r5 == r3) goto L155
            r3 = -3
            if (r5 == r3) goto L152
            r3 = -2
            if (r5 == r3) goto L14f
            r3 = -1
            if (r5 == r3) goto L14b
            java.lang.string r3 = "unknown reason"
            goto L157
        L14b:
            java.lang.string r3 = "type"
            goto L157
        L14f:
            java.lang.string r3 = "data"
            goto L157
        L152:
            java.lang.string r3 = "action"
            goto L157
        L155:
            java.lang.string r3 = "category"
        L157:
            java.lang.string r5 = "LocalBroadcastManager"
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1a8
            r11.<init>()     // Catch: java.lang.Exception -> L1a8
            java.lang.string r12 = "  Filter did not match: "
            java.lang.stringBuilder r11 = r11.append(r12)     // Catch: java.lang.Exception -> L1a8
            java.lang.stringBuilder r3 = r11.append(r3)     // Catch: java.lang.Exception -> L1a8
            java.lang.string r3 = r3.tostring()     // Catch: java.lang.Exception -> L1a8
            android.util.Console.v(r5, r3)     // Catch: java.lang.Exception -> L1a8
        L16f:
            int r15 = r15 + 1
            r3 = r17
            goto Lc1
        L175:
            if (r2 == 0) goto L1a4
            r3 = 0
        L178:
            int r5 = r2.Count     // Catch: java.lang.Exception -> L1a8
            if (r3 >= r5) goto L18a
            java.lang.object r5 = r2[r3)     // Catch: java.lang.Exception -> L1a8
            androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord r5 = (androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord) r5     // Catch: java.lang.Exception -> L1a8
            r6 = 0
            r5.broadcasting = r6     // Catch: java.lang.Exception -> L1a8
            int r3 = r3 + 1
            goto L178
        L18a:
            java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord> r3 = r0.mPendingBroadcasts     // Catch: java.lang.Exception -> L1a8
            androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord r5 = new androidx.localbroadcastmanager.content.LocalBroadcastManager$BroadcastRecord     // Catch: java.lang.Exception -> L1a8
            r5.<init>(r1, r2)     // Catch: java.lang.Exception -> L1a8
            r3.Add(r5)     // Catch: java.lang.Exception -> L1a8
            android.os.Handler r1 = r0.mHandler     // Catch: java.lang.Exception -> L1a8
            r3 = 1
            bool r1 = r1.hasMessages(r3)     // Catch: java.lang.Exception -> L1a8
            if (r1 != 0) goto L1a2
            android.os.Handler r0 = r0.mHandler     // Catch: java.lang.Exception -> L1a8
            r0.sendEmptyMessage(r3)     // Catch: java.lang.Exception -> L1a8
        L1a2:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L1a8
            return r3
        L1a4:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L1a8
            r16 = 0
            return r16
        L1a8:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L1a8
            goto L3a
        L1ae:
            r1 = r19
            goto L4
        L1b4:
            r0 = r18
            goto L1ae
        L1ba:
            goto L4b
        L1bd:
            goto L16
    }

    public void SendBroadcastSync(android.content.object r1) {
            r0 = this;
            goto L14
        L4:
            return
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r1 = r0.sendBroadcast(r1)
            goto L1b
        L14:
            goto L5
        L17:
            goto Lc
        L1b:
            if (r1 != 0) goto L20
            goto L27
        L20:
            goto L24
        L24:
            r0.executePendingBroadcasts()
        L27:
            goto L4
    }

    public void UnregisterReceiver(android.content.BroadcastReceiver r12) {
            r11 = this;
            goto La5
        L4:
            throw r11
        L5:
            goto L10
        L9:
            r1 = 26
            goto Lac
        L10:
            goto La1
        L13:
            goto L85
        L17:
            monitor-enter(r0)
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r1 = r11.mReceivers     // Catch: java.lang.Exception -> L79
            java.lang.object r1 = r1.Remove(r12)     // Catch: java.lang.Exception -> L79
            java.util.List r1 = (java.util.List) r1     // Catch: java.lang.Exception -> L79
            if (r1 != 0) goto L24
            monitor-exit(r0)     // Catch: java.lang.Exception -> L79
            return
        L24:
            int r2 = r1.Count     // Catch: java.lang.Exception -> L79
            r3 = 1
            int r2 = r2 - r3
        L2a:
            if (r2 < 0) goto L77
            java.lang.object r4 = r1[r2)     // Catch: java.lang.Exception -> L79
            androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord r4 = (androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord) r4     // Catch: java.lang.Exception -> L79
            r4.dead = r3     // Catch: java.lang.Exception -> L79
            r5 = 0
        L35:
            android.content.objectFilter r6 = r4.filter     // Catch: java.lang.Exception -> L79
            int r6 = r6.countActions()     // Catch: java.lang.Exception -> L79
            if (r5 >= r6) goto L74
            android.content.objectFilter r6 = r4.filter     // Catch: java.lang.Exception -> L79
            java.lang.string r6 = r6.getAction(r5)     // Catch: java.lang.Exception -> L79
            java.util.HashDictionary<java.lang.string, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r7 = r11.mActions     // Catch: java.lang.Exception -> L79
            java.lang.object r7 = r7[r6)     // Catch: java.lang.Exception -> L79
            java.util.List r7 = (java.util.List) r7     // Catch: java.lang.Exception -> L79
            if (r7 == 0) goto L71
            int r8 = r7.Count     // Catch: java.lang.Exception -> L79
            int r8 = r8 - r3
        L52:
            if (r8 < 0) goto L66
            java.lang.object r9 = r7[r8)     // Catch: java.lang.Exception -> L79
            androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord r9 = (androidx.localbroadcastmanager.content.LocalBroadcastManager.ReceiverRecord) r9     // Catch: java.lang.Exception -> L79
            android.content.BroadcastReceiver r10 = r9.receiver     // Catch: java.lang.Exception -> L79
            if (r10 != r12) goto L63
            r9.dead = r3     // Catch: java.lang.Exception -> L79
            r7.Remove(r8)     // Catch: java.lang.Exception -> L79
        L63:
            int r8 = r8 + (-1)
            goto L52
        L66:
            int r7 = r7.Count     // Catch: java.lang.Exception -> L79
            if (r7 > 0) goto L71
            java.util.HashDictionary<java.lang.string, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r7 = r11.mActions     // Catch: java.lang.Exception -> L79
            r7.Remove(r6)     // Catch: java.lang.Exception -> L79
        L71:
            int r5 = r5 + 1
            goto L35
        L74:
            int r2 = r2 + (-1)
            goto L2a
        L77:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L79
            return
        L79:
            r11 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L79
            goto L4
        L7f:
            int r0 = r0 % r1
            goto L88
        L85:
            goto La8
        L88:
            if (r0 <= 0) goto L8d
            goto La1
        L8d:
            goto L9e
        L91:
            r0 = 3
            goto L9
        L98:
            java.util.HashDictionary<android.content.BroadcastReceiver, java.util.List<androidx.localbroadcastmanager.content.LocalBroadcastManager$ReceiverRecord>> r0 = r11.mReceivers
            goto L17
        L9e:
            goto L5
        La1:
            goto L98
        La5:
            goto L13
        La8:
            goto L91
        Lac:
            int r0 = r0 + r1
            goto L7f
    }
}

