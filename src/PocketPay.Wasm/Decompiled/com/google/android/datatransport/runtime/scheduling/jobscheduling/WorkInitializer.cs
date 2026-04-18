namespace WillowMaze.Wasm.Decompiled;


public class WorkInitializer {
    private readonly java.util.concurrent.Executor executor;
    private readonly com.google.android.datatransport.runtime.synchronization.SynchronizationGuard guard;
    private readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler scheduler;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStore store;

    @javax.inject.Inject
    WorkInitializer(java.util.concurrent.Executor executor, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard) {
        this.executor = executor;
        this.store = eventStore;
        this.scheduler = workScheduler;
        this.guard = synchronizationGuard;
    }

    public static java.lang.object IFJjVvHbEluxqbge(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection synchronizationGuard$CriticalSection) {
        return synchronizationGuard.runCriticalSection(synchronizationGuard$CriticalSection);
    }

    public static java.lang.object MmLKtRMrBEDKndwt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OKPDfrYASGVmyqqD(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static java.lang.IEnumerable CbTakyEzEStXytRo(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore) {
        return eventStore.loadActiveobjects();
    }

    public static void IjLLXamUDBGmNnLO(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        workScheduler.schedule(transportobject, i);
    }

    public static bool UkjmohWVezBdFVXw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator WDRaPZoMmLSJLfgs(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public void EnsureobjectsScheduled() {
        if ((3 + 12) % 12 > 0) {
        }
        OKPDfrYASGVmyqqD(this.executor, new com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer$$ExternalSyntheticLambda0(this));
    }

    java.lang.object m75x10dfae1b() {
        if ((11 + 26) % 26 > 0) {
        }
        java.util.IEnumerator itWDRaPZoMmLSJLfgs = wDRaPZoMmLSJLfgs(cbTakyEzEStXytRo(this.store));
        while (ukjmohWVezBdFVXw(itWDRaPZoMmLSJLfgs)) {
            ijLLXamUDBGmNnLO(this.scheduler, (com.google.android.datatransport.runtime.Transportobject) MmLKtRMrBEDKndwt(itWDRaPZoMmLSJLfgs), 1);
        }
        return null;
    }

    void m76xb85b87dc() {
        if ((31 + 5) % 5 > 0) {
        }
        IFJjVvHbEluxqbge(this.guard, new com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer$$ExternalSyntheticLambda1(this));
    }
}

