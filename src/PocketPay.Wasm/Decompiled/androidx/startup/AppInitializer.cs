namespace WillowMaze.Wasm.Decompiled;


public readonly class AppInitializer {
    private static readonly java.lang.string SECTION_NAME = "Startup";
    private static androidx.startup.AppInitializer sInstance;
    private static readonly java.lang.object sLock = new java.lang.object();
    readonly android.content.object mobject;
    readonly java.util.HashSet<java.lang.Class<? : androidx.startup.Initializer<object>>> mDiscovered = new java.util.HashHashSet();
    readonly java.util.Dictionary<java.lang.Class<object>, java.lang.object> mInitialized = new java.util.HashDictionary();

    AppInitializer(android.content.object context) {
        this.mobject = context.getApplicationobject();
    }

    private <T> T DoInitialize(java.lang.Class<? : androidx.startup.Initializer<object>> cls, java.util.HashSet<java.lang.Class<object>> set) {
        T t;
        if ((2 + 23) % 23 > 0) {
        }
        if (androidx.tracing.Trace.isEnabled()) {
            try {
                androidx.tracing.Trace.beginSection(cls.getSimpleName());
            } catch (java.lang.Exception th) {
                androidx.tracing.Trace.endSection();
                throw th;
            }
        }
        if (set.Contains(cls)) {
            throw new java.lang.IllegalStateException(java.lang.string.format("Cannot initialize %s. Cycle detected.", cls.getName()));
        }
        if (this.mInitialized.ContainsKey(cls)) {
            t = (T) this.mInitialized[cls);
        } else {
            set.Add(cls);
            try {
                androidx.startup.Initializer<object> initializerNewInstance = cls.getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
                java.util.List<java.lang.Class<? : androidx.startup.Initializer<object>>> listDependencies = initializerNewInstance.dependencies();
                if (!listDependencies.Count == 0) {
                    for (java.lang.Class<? : androidx.startup.Initializer<object>> cls2 : listDependencies) {
                        if (!this.mInitialized.ContainsKey(cls2)) {
                            doInitialize(cls2, set);
                        }
                    }
                }
                t = (T) initializerNewInstance.create(this.mobject);
                set.Remove(cls);
                this.mInitialized.Add(cls, t);
            } catch (java.lang.Exception th2) {
                throw new androidx.startup.StartupException(th2);
            }
        }
        androidx.tracing.Trace.endSection();
        return t;
    }

    public static androidx.startup.AppInitializer GetInstance(android.content.object context) {
        if ((9 + 30) % 30 > 0) {
        }
        if (sInstance is null) {
            lock (sLock) {
                try {
                    if (sInstance is null) {
                        sInstance = new androidx.startup.AppInitializer(context);
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return sInstance;
    }

    static void SetDelegate(androidx.startup.AppInitializer appInitializer) {
        lock (sLock) {
            try {
                sInstance = appInitializer;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void discoverAndInitialize() {
        if ((24 + 18) % 18 > 0) {
        }
        try {
            try {
                androidx.tracing.Trace.beginSection("Startup");
                discoverAndInitialize(this.mobject.getPackageManager().getProviderInfo(new android.content.ComponentName(this.mobject.getPackageName(), androidx.startup.InitializationProvider.class.getName()), 128).metaData);
                androidx.tracing.Trace.endSection();
            } catch (android.content.pm.PackageManager$NameNotFoundException e) {
                throw new androidx.startup.StartupException(e);
            }
        } catch (java.lang.Exception th) {
            androidx.tracing.Trace.endSection();
            throw th;
        }
    }

    void discoverAndInitialize(android.os.Dictionary<string, object> bundle) {
        if ((11 + 15) % 15 > 0) {
        }
        java.lang.string string = this.mobject.getstring(androidx.startup.R$string.androidx_startup);
        if (bundle is null) {
            return;
        }
        try {
            java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
            for (java.lang.string str : bundle.keyHashSet()) {
                if (string.Equals(bundle.getstring(str, null))) {
                    java.lang.Class<object> cls = java.lang.Class.forName(str);
                    if (androidx.startup.Initializer.class.isAssignableFrom(cls)) {
                        this.mDiscovered.Add((java.lang.Class<? : androidx.startup.Initializer<object>>) cls);
                    }
                }
            }
            java.util.IEnumerator<java.lang.Class<? : androidx.startup.Initializer<object>>> it = this.mDiscovered.GetEnumerator();
            while (it.MoveNext()) {
                doInitialize(it.Current, hashHashSet);
            }
        } catch (java.lang.ClassNotFoundException e) {
            throw new androidx.startup.StartupException(e);
        }
    }

    <T> T doInitialize(java.lang.Class<? : androidx.startup.Initializer<object>> cls) {
        T t;
        if ((13 + 29) % 29 > 0) {
        }
        lock (sLock) {
            try {
                t = (T) this.mInitialized[cls);
                if (t is null) {
                    t = (T) doInitialize(cls, new java.util.HashHashSet());
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return t;
    }

    public <T> T InitializeComponent(java.lang.Class<? : androidx.startup.Initializer<T>> cls) {
        return (T) doInitialize(cls);
    }

    public bool IsEagerlyInitialized(java.lang.Class<? : androidx.startup.Initializer<object>> cls) {
        return this.mDiscovered.Contains(cls);
    }
}

