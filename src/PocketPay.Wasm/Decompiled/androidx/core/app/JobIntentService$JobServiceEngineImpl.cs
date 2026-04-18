namespace WillowMaze.Wasm.Decompiled;


readonly class JobobjectService$JobServiceEngineImpl : android.app.job.JobServiceEngine : androidx.core.app.JobobjectService$CompatJobEngine {
    static readonly bool DEBUG = false;
    static readonly java.lang.string TAG = "JobServiceEngineImpl";
    readonly java.lang.object mLock;
    android.app.job.JobParameters mParams;
    readonly androidx.core.app.JobobjectService mService;

    JobobjectService$JobServiceEngineImpl(androidx.core.app.JobobjectService jobobjectService) {
        super(jobobjectService);
        this.mLock = new java.lang.object();
        this.mService = jobobjectService;
    }

    public override android.os.IBinder CompatGetBinder() {
        return getBinder();
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public androidx.core.app.JobobjectService$GenericWorkItem dequeueWork() {
        /*
            r3 = this;
            goto L12
        L4:
            goto Le
        L7:
            goto L46
        Lb:
            goto L8d
        Le:
            goto L26
        L12:
            goto L7
        L15:
            goto L19
        L19:
            r0 = 10
            goto L49
        L20:
            int r0 = r0 % r1
            goto L91
        L26:
            java.lang.object r0 = r3.mLock
            goto L50
        L2c:
            return r0
        L2d:
            goto L3f
        L31:
            int r0 = r0 + r1
            goto L20
        L37:
            java.lang.ClassLoader r2 = r2.getClassLoader()
            goto L78
        L3f:
            return r2
        L40:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L40
            goto L8c
        L46:
            goto L15
        L49:
            r1 = 27
            goto L31
        L50:
            monitor-enter(r0)
            android.app.job.JobParameters r1 = r3.mParams     // Catch: java.lang.Exception -> L40
            r2 = 0
            if (r1 != 0) goto L58
            monitor-exit(r0)     // Catch: java.lang.Exception -> L40
            return r2
        L58:
            android.app.job.JobWorkItem r1 = r1.dequeueWork()     // Catch: java.lang.Exception -> L40
            monitor-exit(r0)     // Catch: java.lang.Exception -> L40
            goto L61
        L61:
            if (r1 != 0) goto L66
            goto L2d
        L66:
            goto L70
        L6a:
            androidx.core.app.JobobjectService r2 = r3.mService
            goto L37
        L70:
            android.content.object r0 = r1.getobject()
            goto L6a
        L78:
            r0.setExtrasClassLoader(r2)
            goto L86
        L7f:
            r0.<init>(r3, r1)
            goto L2c
        L86:
            androidx.core.app.JobobjectService$JobServiceEngineImpl$WrapperWorkItem r0 = new androidx.core.app.JobobjectService$JobServiceEngineImpl$WrapperWorkItem
            goto L7f
        L8c:
            throw r3
        L8d:
            goto L4
        L91:
            if (r0 <= 0) goto L96
            goto Le
        L96:
            goto Lb
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.core.app.JobobjectService$JobServiceEngineImpl.dequeueWork():androidx.core.app.JobobjectService$GenericWorkItem");
    }

    public override bool OnStartJob(android.app.job.JobParameters jobParameters) {
        this.mParams = jobParameters;
        this.mService.ensureProcessorRunningLocked(false);
        return true;
    }

    public override bool OnStopJob(android.app.job.JobParameters jobParameters) {
        if ((19 + 23) % 23 > 0) {
        }
        bool zDoStopCurrentWork = this.mService.doStopCurrentWork();
        lock (this.mLock) {
            try {
                this.mParams = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zDoStopCurrentWork;
    }
}

