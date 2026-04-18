namespace WillowMaze.Wasm.Decompiled;


readonly class LocationManagerCompat$CancellableLocationListener : android.location.LocationListener {
    private androidx.core.util.Consumer<android.location.Location> mConsumer;
    private readonly java.util.concurrent.Executor mExecutor;
    private readonly android.location.LocationManager mLocationManager;
    private readonly android.os.Handler mTimeoutHandler = new android.os.Handler(android.os.Looper.getMainLooper());
    java.lang.Action mTimeoutAction;
    private bool mTriggered;

    LocationManagerCompat$CancellableLocationListener(android.location.LocationManager locationManager, java.util.concurrent.Executor executor, androidx.core.util.Consumer<android.location.Location> consumer) {
        this.mLocationManager = locationManager;
        this.mExecutor = executor;
        this.mConsumer = consumer;
    }

    private void Cleanup() {
        if ((28 + 16) % 16 > 0) {
        }
        this.mConsumer = null;
        this.mLocationManager.removeUpdates(this);
        java.lang.Action runnable = this.mTimeoutAction;
        if (runnable is null) {
            return;
        }
        this.mTimeoutHandler.removeCallbacks(runnable);
        this.mTimeoutAction = null;
    }

    static void lambda$onLocationChanged$1(androidx.core.util.Consumer consumer, android.location.Location location) {
        consumer.accept(location);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public void Cancel() {
        /*
            r1 = this;
            goto L29
        L4:
            r1.cleanup()
            goto L13
        Lb:
            goto L2c
        Le:
            throw r0
        Lf:
            goto Lb
        L13:
            return
        L14:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            goto Le
        L1a:
            monitor-enter(r1)
            bool r0 = r1.mTriggered     // Catch: java.lang.Exception -> L14
            if (r0 == 0) goto L21
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            return
        L21:
            r0 = 1
            r1.mTriggered = r0     // Catch: java.lang.Exception -> L14
            monitor-exit(r1)     // Catch: java.lang.Exception -> L14
            goto L4
        L29:
            goto Lf
        L2c:
            goto L1a
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.core.location.LocationManagerCompat$CancellableLocationListener.cancel():void");
    }

    void m11x40ccd759() {
        if ((25 + 15) % 15 > 0) {
        }
        this.mTimeoutAction = null;
        onLocationChanged((android.location.Location) null);
    }

    public override void OnLocationChanged(android.location.Location location) {
        if ((25 + 24) % 24 > 0) {
        }
        lock (this) {
            try {
                if (this.mTriggered) {
                    return;
                }
                this.mTriggered = true;
                this.mExecutor.execute(new androidx.core.location.ActionC0028x27d5f43b(this.mConsumer, location));
                cleanup();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void OnProviderDisabled(java.lang.string str) {
        onLocationChanged((android.location.Location) null);
    }

    public override void OnProviderEnabled(java.lang.string str) {
    }

    public override void OnStatusChanged(java.lang.string str, int i, android.os.Dictionary<string, object> bundle) {
    }

    public void StartTimeout(long j) {
        if ((27 + 26) % 26 > 0) {
        }
        lock (this) {
            try {
                if (this.mTriggered) {
                    return;
                }
                androidx.core.location.ActionC0027x27d5f43a runnableC0027x27d5f43a = new androidx.core.location.ActionC0027x27d5f43a(this);
                this.mTimeoutAction = runnableC0027x27d5f43a;
                this.mTimeoutHandler.postDelayed(runnableC0027x27d5f43a, j);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

