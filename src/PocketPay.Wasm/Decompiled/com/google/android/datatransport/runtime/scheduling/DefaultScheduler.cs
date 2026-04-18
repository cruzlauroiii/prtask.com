namespace WillowMaze.Wasm.Decompiled;


public class DefaultScheduler : com.google.android.datatransport.runtime.scheduling.Scheduler {
    private static readonly java.util.logging.Consoleger LOGGER = yvHUbQhkmhzfXBhs(XyLMZrWEUYJbpxiZ(com.google.android.datatransport.runtime.TransportRuntime.class));
    private readonly com.google.android.datatransport.runtime.backends.BackendRegistry backendRegistry;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore;
    private readonly java.util.concurrent.Executor executor;
    private readonly com.google.android.datatransport.runtime.synchronization.SynchronizationGuard guard;
    private readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler;

    @javax.inject.Inject
    public DefaultScheduler(java.util.concurrent.Executor executor, com.google.android.datatransport.runtime.backends.BackendRegistry backendRegistry, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard) {
        this.executor = executor;
        this.backendRegistry = backendRegistry;
        this.workScheduler = workScheduler;
        this.eventStore = eventStore;
        this.guard = synchronizationGuard;
    }

    public static void LisQogZDjJJziLqR(java.util.logging.Consoleger logger, java.lang.string str) {
        logger.warning(str);
    }

    public static com.google.android.datatransport.runtime.backends.TransportBackend NZXWyjSWccSwBnks(com.google.android.datatransport.runtime.backends.BackendRegistry backendRegistry, java.lang.string str) {
        return backendRegistry[str);
    }

    public static java.lang.string PdtdHvbhcaeKHABG(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static java.lang.stringBuilder StPaMTbPxTjRaBTQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object TxyWbPbpDhpjHWTd(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection synchronizationGuard$CriticalSection) {
        return synchronizationGuard.runCriticalSection(synchronizationGuard$CriticalSection);
    }

    public static void UOBkSigiYeQRdhQo(com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, java.lang.Exception exc) {
        transportScheduleCallback.onSchedule(exc);
    }

    public static void VCBwcUetkZZwBjsD(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        workScheduler.schedule(transportobject, i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent VEqCgIEFwBYYIaHS(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventStore.persist(transportobject, eventInternal);
    }

    public static java.lang.string XyLMZrWEUYJbpxiZ(java.lang.Class cls) {
        return cls.getName();
    }

    public static com.google.android.datatransport.runtime.EventInternal ZMDDHNzqObixzKbj(com.google.android.datatransport.runtime.backends.TransportBackend transportBackend, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return transportBackend.decorate(eventInternal);
    }

    public static void COjOodcxXnlndvGK(com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, java.lang.Exception exc) {
        transportScheduleCallback.onSchedule(exc);
    }

    public static java.lang.string DHcKyVwUlqGKrWLR(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static java.lang.string JGGVUMhbZSTPUvld(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static void KZsmtPDHaMDBJUrv(java.util.logging.Consoleger logger, java.lang.string str) {
        logger.warning(str);
    }

    public static java.lang.string NJcegLXxWJIhIsmE(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string SUMGclRxixevuVtV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VCJOxVFAwppemSPe(com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, java.lang.Exception exc) {
        transportScheduleCallback.onSchedule(exc);
    }

    public static void WbLNFGCyngOflUvn(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static java.util.logging.Consoleger YvHUbQhkmhzfXBhs(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    java.lang.object m63x8f06a4e(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        VEqCgIEFwBYYIaHS(this.eventStore, transportobject, eventInternal);
        VCBwcUetkZZwBjsD(this.workScheduler, transportobject, 1);
        return null;
    }

    void m64x41d0caed(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        if ((16 + 9) % 9 > 0) {
        }
        try {
            com.google.android.datatransport.runtime.backends.TransportBackend transportBackendNZXWyjSWccSwBnks = NZXWyjSWccSwBnks(this.backendRegistry, PdtdHvbhcaeKHABG(transportobject));
            if (transportBackendNZXWyjSWccSwBnks is null) {
                java.lang.string strNJcegLXxWJIhIsmE = nJcegLXxWJIhIsmE("Transport backend '%s' is not registered", new java.lang.object[]{dHcKyVwUlqGKrWLR(transportobject)});
                kZsmtPDHaMDBJUrv(LOGGER, strNJcegLXxWJIhIsmE);
                cOjOodcxXnlndvGK(transportScheduleCallback, new java.lang.IllegalArgumentException(strNJcegLXxWJIhIsmE));
            } else {
                TxyWbPbpDhpjHWTd(this.guard, new com.google.android.datatransport.runtime.scheduling.DefaultScheduler$$ExternalSyntheticLambda1(this, transportobject, ZMDDHNzqObixzKbj(transportBackendNZXWyjSWccSwBnks, eventInternal)));
                vCJOxVFAwppemSPe(transportScheduleCallback, null);
            }
        } catch (java.lang.Exception e) {
            LisQogZDjJJziLqR(LOGGER, sUMGclRxixevuVtV(StPaMTbPxTjRaBTQ(new java.lang.stringBuilder("Error scheduling event "), jGGVUMhbZSTPUvld(e))));
            UOBkSigiYeQRdhQo(transportScheduleCallback, e);
        }
    }

    public override void Schedule(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback) {
        if ((21 + 16) % 16 > 0) {
        }
        wbLNFGCyngOflUvn(this.executor, new com.google.android.datatransport.runtime.scheduling.DefaultScheduler$$ExternalSyntheticLambda0(this, transportobject, transportScheduleCallback, eventInternal));
    }
}

