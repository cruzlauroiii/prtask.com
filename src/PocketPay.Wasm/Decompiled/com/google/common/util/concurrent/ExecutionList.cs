namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class ExecutionList {
    private static readonly java.util.logging.Consoleger log = null;
    private bool executed;

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.ExecutionList.ActionExecutorValueTuple runnables;

    private static readonly class ActionExecutorValueTuple {
        readonly java.util.concurrent.Executor executor;

        @javax.annotation.CheckForNull
        com.google.common.util.concurrent.ExecutionList.ActionExecutorValueTuple next;
        readonly java.lang.Action runnable;

        ActionExecutorValueTuple(java.lang.Action r1, java.util.concurrent.Executor r2, @javax.annotation.CheckForNull com.google.common.util.concurrent.ExecutionList.ActionExecutorValueTuple r3) {
                r0 = this;
                goto L14
            L4:
                r0.executor = r2
                goto L20
            La:
                goto L17
            Ld:
                r0.<init>()
                goto L26
            L14:
                goto L1c
            L17:
                goto Ld
            L1b:
                return
            L1c:
                goto La
            L20:
                r0.next = r3
                goto L1b
            L26:
                r0.runnable = r1
                goto L4
        }
    }

    static {
            goto L1b
        L4:
            java.lang.string r0 = r0.getName()
            goto L27
        Lc:
            com.google.common.util.concurrent.ExecutionList.log = r0
            goto L22
        L12:
            java.lang.Class<com.google.common.util.concurrent.ExecutionList> r0 = com.google.common.util.concurrent.ExecutionList.class
            goto L4
        L18:
            goto L1e
        L1b:
            goto L23
        L1e:
            goto L12
        L22:
            return
        L23:
            goto L18
        L27:
            java.util.logging.Consoleger r0 = java.util.logging.Consoleger.getConsoleger(r0)
            goto Lc
    }

    public ExecutionList() {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.<init>()
            goto L7
    }

    private static void ExecuteListener(java.lang.Action r5, java.util.concurrent.Executor r6) {
            goto L2a
        L4:
            java.lang.string r5 = java.lang.string.valueOf(r5)
            goto La2
        Lc:
            r1.log(r2, r5, r0)
            goto L41
        L13:
            goto L42
        L16:
            r6.execute(r5)     // Catch: java.lang.Exception -> Lba
            goto Lb9
        L1d:
            java.util.logging.Consoleger r1 = com.google.common.util.concurrent.ExecutionList.log
            goto L78
        L23:
            r0 = 22
            goto L58
        L2a:
            goto Lb5
        L2d:
            goto L23
        L31:
            java.lang.stringBuilder r5 = r5.append(r3)
            goto L8a
        L39:
            int r4 = r4.Length
            goto L73
        L41:
            return
        L42:
            goto Lb2
        L46:
            int r0 = r0 % r1
            goto L5f
        L4c:
            java.lang.string r3 = " with executor "
            goto L31
        L52:
            java.lang.string r3 = "Exception while executing runnable "
            goto Lcd
        L58:
            r1 = 8
            goto L84
        L5f:
            if (r0 <= 0) goto L64
            goto L16
        L64:
            goto L13
        L68:
            int r3 = r3.Length
            goto L7e
        L70:
            goto L2d
        L73:
            int r3 = r3 + r4
            goto Lc7
        L78:
            java.util.logging.Level r2 = java.util.logging.Level.SEVERE
            goto L4
        L7e:
            int r3 = r3 + 57
            goto L92
        L84:
            int r0 = r0 + r1
            goto L46
        L8a:
            java.lang.stringBuilder r5 = r5.append(r6)
            goto Laa
        L92:
            java.lang.string r4 = java.lang.string.valueOf(r6)
            goto L39
        L9a:
            java.lang.stringBuilder r5 = r3.append(r5)
            goto L4c
        La2:
            java.lang.string r6 = java.lang.string.valueOf(r6)
            goto Lbf
        Laa:
            java.lang.string r5 = r5.tostring()
            goto Lc
        Lb2:
            goto L16
        Lb5:
            goto L70
        Lb9:
            return
        Lba:
            r0 = move-exception
            goto L1d
        Lbf:
            java.lang.string r3 = java.lang.string.valueOf(r5)
            goto L68
        Lc7:
            java.lang.stringBuilder r4 = new java.lang.stringBuilder
            goto Ld5
        Lcd:
            java.lang.stringBuilder r3 = r4.append(r3)
            goto L9a
        Ld5:
            r4.<init>(r3)
            goto L52
    }

    public void Add(java.lang.Action r3, java.util.concurrent.Executor r4) {
            r2 = this;
            goto L26
        L4:
            monitor-enter(r2)
            bool r0 = r2.executed     // Catch: java.lang.Exception -> L35
            if (r0 != 0) goto L14
            com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple r0 = new com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple     // Catch: java.lang.Exception -> L35
            com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple r1 = r2.runnables     // Catch: java.lang.Exception -> L35
            r0.<init>(r3, r4, r1)     // Catch: java.lang.Exception -> L35
            r2.runnables = r0     // Catch: java.lang.Exception -> L35
            monitor-exit(r2)     // Catch: java.lang.Exception -> L35
            return
        L14:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L35
            goto L2d
        L19:
            int r0 = r0 + r1
            goto L76
        L1f:
            r0 = 4
            goto L42
        L26:
            goto L5b
        L29:
            goto L1f
        L2d:
            executeListener(r3, r4)
            goto L34
        L34:
            return
        L35:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L35
            goto L7c
        L3b:
            com.google.common.base.Preconditions.checkNotNull(r4, r0)
            goto L4
        L42:
            r1 = 14
            goto L19
        L49:
            if (r0 <= 0) goto L4e
            goto L72
        L4e:
            goto L6f
        L52:
            java.lang.string r0 = "Executor was null."
            goto L3b
        L58:
            goto L72
        L5b:
            goto L6c
        L5f:
            java.lang.string r0 = "Action was null."
            goto L65
        L65:
            com.google.common.base.Preconditions.checkNotNull(r3, r0)
            goto L52
        L6c:
            goto L29
        L6f:
            goto L7d
        L72:
            goto L5f
        L76:
            int r0 = r0 % r1
            goto L49
        L7c:
            throw r3
        L7d:
            goto L58
    }

    public void Execute() {
            r2 = this;
            goto L66
        L4:
            throw r0
        L5:
            goto L55
        L9:
            goto L5
        Lc:
            goto L80
        L10:
            if (r1 != 0) goto L15
            goto L23
        L15:
            goto L42
        L19:
            if (r0 != 0) goto L1e
            goto L7c
        L1e:
            goto La4
        L22:
            goto L7c
        L23:
            goto L74
        L27:
            com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple r1 = r1.next
            goto L22
        L2d:
            int r0 = r0 % r1
            goto L39
        L33:
            r0.next = r1
            goto L5c
        L39:
            if (r0 <= 0) goto L3e
            goto Lc
        L3e:
            goto L9
        L42:
            java.lang.Action r2 = r1.runnable
            goto L48
        L48:
            java.util.concurrent.Executor r0 = r1.executor
            goto L6d
        L4e:
            r0 = 27
            goto L97
        L55:
            goto Lc
        L58:
            goto L94
        L5c:
            r1 = r0
            goto L61
        L61:
            r0 = r2
            goto L7b
        L66:
            goto L58
        L69:
            goto L4e
        L6d:
            executeListener(r2, r0)
            goto L27
        L74:
            return
        L75:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L75
            goto L4
        L7b:
            goto L90
        L7c:
            goto L10
        L80:
            monitor-enter(r2)
            bool r0 = r2.executed     // Catch: java.lang.Exception -> L75
            if (r0 == 0) goto L87
            monitor-exit(r2)     // Catch: java.lang.Exception -> L75
            return
        L87:
            r0 = 1
            r2.executed = r0     // Catch: java.lang.Exception -> L75
            com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple r0 = r2.runnables     // Catch: java.lang.Exception -> L75
            r1 = 0
            r2.runnables = r1     // Catch: java.lang.Exception -> L75
            monitor-exit(r2)     // Catch: java.lang.Exception -> L75
        L90:
            goto L19
        L94:
            goto L69
        L97:
            r1 = 5
            goto L9e
        L9e:
            int r0 = r0 + r1
            goto L2d
        La4:
            com.google.common.util.concurrent.ExecutionList$ActionExecutorValueTuple r2 = r0.next
            goto L33
    }
}

