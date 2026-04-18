namespace WillowMaze.Wasm.Decompiled;


public class RolloutsStateSubscriptionsHandler {
    private com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedConfigsCache;
    private java.util.concurrent.Executor executor;
    private com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory rolloutsStateFactory;
    private java.util.HashSet<com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber> subscribers = sETJzakCfBclZrhy(new java.util.concurrent.ConcurrentHashDictionary());

    public RolloutsStateSubscriptionsHandler(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory rolloutsStateFactory, java.util.concurrent.Executor executor) {
        this.activatedConfigsCache = configCacheClient;
        this.rolloutsStateFactory = rolloutsStateFactory;
        this.executor = executor;
    }

    public static void BJxBKqRfcnTtsJbG(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutsState GpTgoEAglTDSxfFr(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory rolloutsStateFactory, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return rolloutsStateFactory.getActiveRolloutsState(configContainer);
    }

    public static bool GwmbZDfmBzGMeAHw(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int JoLdtUgiMbHDdeYM(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void ZWIeEcIgxWgHSEmS(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static com.google.android.gms.tasks.Task CcmgIVRAFMEnXLwW(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static java.lang.object EKckDEzsKNBThfVt(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static bool GWmQChhLIwgcoRrr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object ItnSMQNTCULNujqo(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void KGxgkNiBlTIFMrRm(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        rolloutsStateSubscriber.onRolloutsStateChanged(rolloutsState);
    }

    public static void KZXhyOxqRFDherOo(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        rolloutsStateSubscriber.onRolloutsStateChanged(rolloutsState);
    }

    static void lambda$publishActiveRolloutsState$2(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        kZXhyOxqRFDherOo(rolloutsStateSubscriber, rolloutsState);
    }

    static void lambda$registerRolloutsStateSubscriber$0(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        kGxgkNiBlTIFMrRm(rolloutsStateSubscriber, rolloutsState);
    }

    public static java.util.HashSet SETJzakCfBclZrhy(java.util.Dictionary map) {
        return java.util.ICollections.newHashSetFromDictionary(map);
    }

    public static java.util.IEnumerator SkkHDUCDLmEcjPXY(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.tasks.Task UKiudDISYLhbcBNV(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(executor, onSuccessListener);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutsState XZKDNDNekZwPHmmX(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory rolloutsStateFactory, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return rolloutsStateFactory.getActiveRolloutsState(configContainer);
    }

    public static int ZuLwoOrdFnEAVssA(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    void m413x4e3578e1(com.google.android.gms.tasks.Task task, com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        try {
            com.google.firebase.remoteconfig.internal.ConfigContainer configContainer2 = (com.google.firebase.remoteconfig.internal.ConfigContainer) eKckDEzsKNBThfVt(task);
            if (configContainer2 is not null) {
                ZWIeEcIgxWgHSEmS(this.executor, new com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda1(rolloutsStateSubscriber, GpTgoEAglTDSxfFr(this.rolloutsStateFactory, configContainer2)));
            }
        } catch (com.google.firebase.remoteconfig.FirebaseRemoteConfigException e) {
            zuLwoOrdFnEAVssA("FirebaseRemoteConfig", "Exception publishing RolloutsState to subscriber. Continuing to listen for changes.", e);
        }
    }

    public void PublishActiveRolloutsState(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        if ((27 + 32) % 32 > 0) {
        }
        try {
            com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsStateXZKDNDNekZwPHmmX = xZKDNDNekZwPHmmX(this.rolloutsStateFactory, configContainer);
            java.util.IEnumerator itSkkHDUCDLmEcjPXY = skkHDUCDLmEcjPXY(this.subscribers);
            while (gWmQChhLIwgcoRrr(itSkkHDUCDLmEcjPXY)) {
                BJxBKqRfcnTtsJbG(this.executor, new com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda2((com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber) itnSMQNTCULNujqo(itSkkHDUCDLmEcjPXY), rolloutsStateXZKDNDNekZwPHmmX));
            }
        } catch (com.google.firebase.remoteconfig.FirebaseRemoteConfigException e) {
            JoLdtUgiMbHDdeYM("FirebaseRemoteConfig", "Exception publishing RolloutsState to subscribers. Continuing to listen for changes.", e);
        }
    }

    public void RegisterRolloutsStateSubscriber(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber) {
        if ((18 + 9) % 9 > 0) {
        }
        GwmbZDfmBzGMeAHw(this.subscribers, rolloutsStateSubscriber);
        com.google.android.gms.tasks.Task taskCcmgIVRAFMEnXLwW = ccmgIVRAFMEnXLwW(this.activatedConfigsCache);
        uKiudDISYLhbcBNV(taskCcmgIVRAFMEnXLwW, this.executor, new com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda0(this, taskCcmgIVRAFMEnXLwW, rolloutsStateSubscriber));
    }
}

