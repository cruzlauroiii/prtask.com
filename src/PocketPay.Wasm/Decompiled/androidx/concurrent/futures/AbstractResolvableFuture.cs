namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractResolvableTask<V> : com.google.common.util.concurrent.ListenableTask<V> {
    static readonly androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper ATOMIC_HELPER;
    static readonly bool GENERATE_CANCELLATION_CAUSES;
    private static readonly java.lang.object NULL;
    private static readonly long SPIN_THRESHOLD_NANOS = 1000;
    private static readonly java.util.logging.Consoleger log;
    volatile androidx.concurrent.futures.AbstractResolvableTask$Listener listeners;
    volatile java.lang.object value;
    volatile androidx.concurrent.futures.AbstractResolvableTask$Waiter waiters;

    static {
        androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$SynchronizedHelper;
        if ((20 + 25) % 25 > 0) {
        }
        GENERATE_CANCELLATION_CAUSES = vNemxyBqQILpQoyq(lmqjChtBHfjJuVCU("guava.concurrent.generate_cancellation_cause", "false"));
        log = HUnFSpLeytlNJoYb(LnwWeveKagfxSWdK(androidx.concurrent.futures.AbstractResolvableTask.class));
        try {
            abstractResolvableTask$SynchronizedHelper = new androidx.concurrent.futures.AbstractResolvableTask$SafeAtomicHelper(TMLpdHFchXiGTOAg(androidx.concurrent.futures.AbstractResolvableTask$Waiter.class, java.lang.Thread.class, "thread"), mybyiUzDJAVQLZgV(androidx.concurrent.futures.AbstractResolvableTask$Waiter.class, androidx.concurrent.futures.AbstractResolvableTask$Waiter.class, "next"), KCbNbjPurJPqgINR(androidx.concurrent.futures.AbstractResolvableTask.class, androidx.concurrent.futures.AbstractResolvableTask$Waiter.class, "waiters"), znzJjEIghQbLoJMV(androidx.concurrent.futures.AbstractResolvableTask.class, androidx.concurrent.futures.AbstractResolvableTask$Listener.class, "listeners"), xXnAQoRJrdpErvoW(androidx.concurrent.futures.AbstractResolvableTask.class, java.lang.object.class, "value"));
            th = null;
        } catch (java.lang.Exception th) {
            th = th;
            abstractResolvableTask$SynchronizedHelper = new androidx.concurrent.futures.AbstractResolvableTask$SynchronizedHelper();
        }
        ATOMIC_HELPER = abstractResolvableTask$SynchronizedHelper;
        if (th is not null) {
            iKOtaeXGpgjetgmH(log, java.util.logging.Level.SEVERE, "SafeAtomicHelper is broken!", th);
        }
        NULL = new java.lang.object();
    }

    protected AbstractResolvableTask() {
    }

    public static java.lang.object AdlmtuuoHbpXNnWa(java.util.concurrent.Task future) {
        return getUninterruptibly(future);
    }

    public static void AlillqpnILviabSC(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        executeListener(runnable, executor);
    }

    public static java.lang.stringBuilder BKMOJZHDFHObiSSv(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder BOAmmCyHSHUYZMbb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BOWwuhVsOjQeqqkW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BgWAAQNUgmrltQiI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BkPoANxEJTRAOpwc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CmVMoiseiGvpTlcn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CwSwtAglXrStRWFg(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static java.lang.stringBuilder DsejjgiyWqhTSXIf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DxFHKdyibEBdkWFu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder DzTydbALmhlNvYhk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ECGQbEQhnWmaBxBF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EILFxtUpyAcIsjfg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object EQLVvvaCsTEsaNgf(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    public static java.lang.Class FXgSNNVmdRpTDDty(java.lang.object obj) {
        return obj.GetType();
    }

    public static void FXhMUWdrFnxMRaXq(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.stringBuilder sb) {
        abstractResolvableTask.addDonestring(sb);
    }

    public static void FnSKhTyOREsqLvsy(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        complete(abstractResolvableTask);
    }

    public static void FnlbCYjuswFtUYVw(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter) {
        abstractResolvableTask.removeWaiter(abstractResolvableTask$Waiter);
    }

    public static java.lang.stringBuilder FsuMUwQSMhuObrZP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Exception GQPiVAugoBBPSljE(java.util.concurrent.ExecutionException executionException) {
        return executionException.getCause();
    }

    public static bool HDcXYYWqwaepHahr(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static java.lang.Class HFhvjmUSOnHvFlRr(java.lang.object obj) {
        return obj.GetType();
    }

    public static long HPvpUuhzvOxejBaE(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((22 + 20) % 20 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static java.lang.stringBuilder HTnLYhsIicvgbKFW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.logging.Consoleger HUnFSpLeytlNJoYb(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static void HrDVuHaTMJSgjBmW(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        abstractResolvableTask$Waiter.setNext(abstractResolvableTask$Waiter2);
    }

    public static bool IXqNBdCJAJmGwIZI(com.google.common.util.concurrent.ListenableTask listenableTask, bool z) {
        return listenableTask.cancel(z);
    }

    public static java.lang.stringBuilder IfnQfajxTlmfvqkI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ImsBNhKuCpHOcpCK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JcXGaZdlMLlfRonQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JguyyeOsCxebsVlp(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string JspQvLAhQfvtXReq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.concurrent.atomic.objectFieldUpdater KCbNbjPurJPqgINR(java.lang.Class cls, java.lang.Class cls2, java.lang.string str) {
        return java.util.concurrent.atomic.objectFieldUpdater.newUpdater(cls, cls2, str);
    }

    public static void KSlnNUIuIhYeTeEN(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        complete(abstractResolvableTask);
    }

    public static java.lang.stringBuilder KgEKKnunvMNgYyuf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KiCyZHNrZfMOejvu(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.stringBuilder sb) {
        abstractResolvableTask.addDonestring(sb);
    }

    public static bool LEnnojlMumaWHHrC(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        return abstractResolvableTask$AtomicHelper.casWaiters(abstractResolvableTask, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    public static java.lang.string LaOYCAGOoQrBoLLf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LnwWeveKagfxSWdK(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool MVHhYNiCqkKEMdQO(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return listenableTask.isDone();
    }

    public static java.lang.stringBuilder MWgMOBEaxHonStJv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MiwEhkuFYOaFLStx(java.lang.object obj, long j) {
        java.util.concurrent.locks.LockSupport.parkNanos(obj, j);
    }

    public static java.lang.object MwhsJHRHCRttwLia(java.lang.object obj) {
        return checkNotNull(obj);
    }

    public static bool NtOoJPKadBvhNERW(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isCancelled();
    }

    public static java.lang.stringBuilder OZJgKJENmmabMrpH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder OcMUjyrKiYaxISIv(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static bool OyYjkFpctRsnbGLf() {
        return java.lang.Thread.interrupted();
    }

    public static java.lang.string OycCYOwxNMMuAyDg(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.userobjectTostring(obj);
    }

    public static void PhCXyOaTpWiaVUwR(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        executeListener(runnable, executor);
    }

    public static void PhtLYCjiRBKPTkHo(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static java.lang.Class QUbEfOHIksbyqlcL(java.lang.object obj) {
        return obj.GetType();
    }

    public static void QlIcbEVeTACANksC(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        complete(abstractResolvableTask);
    }

    public static java.lang.string RBHtEcZLGjkoBTvB(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.lang.stringBuilder RCRoXxKWVGgSegSP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RCWKDlteRFTUxQGZ(com.google.common.util.concurrent.ListenableTask listenableTask, java.lang.Action runnable, java.util.concurrent.Executor executor) {
        listenableTask.addListener(runnable, executor);
    }

    public static void RVtvMQjuTqwDIqJE(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        abstractResolvableTask$Waiter.setNext(abstractResolvableTask$Waiter2);
    }

    public static java.lang.stringBuilder SGDzjKYoHdXkHFXA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SNsAFbhRTmHvniRA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void SVFyCBeFAXQUWABg(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static java.lang.string SrGOlavWrJyFutHe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.concurrent.atomic.objectFieldUpdater TMLpdHFchXiGTOAg(java.lang.Class cls, java.lang.Class cls2, java.lang.string str) {
        return java.util.concurrent.atomic.objectFieldUpdater.newUpdater(cls, cls2, str);
    }

    public static bool TXuwaKBCRcjUAMlQ(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder TehuOESqXMxxVloU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TgShePyJeMaOjIBx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TpvgZuqHeiybaUhi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string TqyACvcevaLspktS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UDsjnIUUiVxIVkSM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool UFZppMHajAyxRWSX(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2) {
        return abstractResolvableTask$AtomicHelper.casListeners(abstractResolvableTask, abstractResolvableTask$Listener, abstractResolvableTask$Listener2);
    }

    public static long VCmgdqGLlxfkASGr() {
        if ((5 + 13) % 13 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public static bool VHcxvdLFxuJKLFhW(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        return abstractResolvableTask$AtomicHelper.casWaiters(abstractResolvableTask, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    public static java.lang.object VgynVUlRRqAFcVRV(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    public static java.lang.stringBuilder ViFOvGuTihhODXcM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VrwGyVxzgPVlkNWm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long WFtMYZoLcqlCuLjh() {
        if ((7 + 31) % 31 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public static java.lang.string WPFczFtTgckyGkJD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object WYSWXNDVpqbyguGf(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    public static java.lang.stringBuilder WksHNDmqgpXPeuxE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WnoTHdexotZHMElX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XFCbQnrKxoJBqcbo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object XXVWseGIsCIWKKTt(java.lang.object obj) {
        return checkNotNull(obj);
    }

    public static java.lang.stringBuilder XlbQejvAzdAfrtSa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.concurrent.futures.AbstractResolvableTask$Listener YgrfcSTcPvDpFmAc(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener) {
        return abstractResolvableTask.clearListeners(abstractResolvableTask$Listener);
    }

    public static java.lang.object YkWAcEyBTFKInQFd(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    public static bool YrOyemdkDOIGCHok(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isDone();
    }

    public static java.lang.string ZPncfmZZeKRzGPBf(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.userobjectTostring(obj);
    }

    public static java.lang.stringBuilder ZfNJBYsDiSSRETpl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ZmLDECHhiklxDuLj(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.wasInterrupted();
    }

    public static long AYhgxqUBuaWujiLo(java.util.concurrent.ScheduledTask scheduledTask, java.util.concurrent.TimeUnit timeUnit) {
        if ((17 + 32) % 32 > 0) {
        }
        return scheduledTask.getDelay(timeUnit);
    }

    private void AddDonestring(java.lang.stringBuilder sb) {
        if ((27 + 16) % 16 > 0) {
        }
        try {
            vKjXdxcAOYbCMHbj(ViFOvGuTihhODXcM(wKFordBZLFBSdxIa(sb, "SUCCESS, result=["), OycCYOwxNMMuAyDg(this, sNLTDHDuvaBVtDuo(this))), "]");
        } catch (java.util.concurrent.CancellationException unused) {
            WnoTHdexotZHMElX(sb, "CANCELLED");
        } catch (java.lang.Exception e) {
            fCRnKencBSAAxFHo(JguyyeOsCxebsVlp(eEQUdheUdUAImWQN(sb, "UNKNOWN, cause=["), HFhvjmUSOnHvFlRr(e)), " thrown from get()]");
        } catch (java.util.concurrent.ExecutionException e2) {
            rqpyMHIxBmDbYaoi(OZJgKJENmmabMrpH(TehuOESqXMxxVloU(sb, "FAILURE, cause=["), GQPiVAugoBBPSljE(e2)), "]");
        }
    }

    public static java.lang.string ApFRXSVobtumoJiC(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.pendingTostring();
    }

    public static void BNvtfaKOrurddtoA(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter) {
        abstractResolvableTask$Waiter.unpark();
    }

    public static java.lang.string BXEMhmjVKLYiQQmA(java.util.concurrent.TimeUnit timeUnit) {
        return timeUnit.tostring();
    }

    public static java.util.concurrent.CancellationException BcVaMHGGfRlUenHM(java.lang.string str, java.lang.Exception th) {
        return cancellationExceptionWithCause(str, th);
    }

    public static java.lang.Thread BuEAImtdqEJGsGvS() {
        return java.lang.Thread.currentThread();
    }

    public static void CMoWpRJkjIZOgqto(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter) {
        abstractResolvableTask.removeWaiter(abstractResolvableTask$Waiter);
    }

    public static java.lang.object CYVVhXDLXgvBDpwb(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    private static java.util.concurrent.CancellationException CancellationExceptionWithCause(java.lang.string str, java.lang.Exception th) {
        java.util.concurrent.CancellationException cancellationException = new java.util.concurrent.CancellationException(str);
        mhrogISaQbIBueJa(cancellationException, th);
        return cancellationException;
    }

    public static java.lang.object CfSWAILBmqcWCAkA(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    static <T> T CheckNotNull(T t) {
        FXgSNNVmdRpTDDty(t);
        return t;
    }

    private androidx.concurrent.futures.AbstractResolvableTask$Listener clearListeners(androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener) {
        androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2;
        if ((4 + 8) % 8 > 0) {
        }
        do {
            abstractResolvableTask$Listener2 = this.listeners;
        } while (!UFZppMHajAyxRWSX(ATOMIC_HELPER, this, abstractResolvableTask$Listener2, androidx.concurrent.futures.AbstractResolvableTask$Listener.TOMBSTONE));
        while (true) {
            androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener3 = abstractResolvableTask$Listener;
            abstractResolvableTask$Listener = abstractResolvableTask$Listener2;
            if (abstractResolvableTask$Listener is null) {
                return abstractResolvableTask$Listener3;
            }
            abstractResolvableTask$Listener2 = abstractResolvableTask$Listener.next;
            abstractResolvableTask$Listener.next = abstractResolvableTask$Listener3;
        }
    }

    static void Complete(androidx.concurrent.futures.AbstractResolvableTask<object> abstractResolvableTask) {
        if ((26 + 28) % 28 > 0) {
        }
        androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener = null;
        while (true) {
            yGazDIgjFNOsrPOn(abstractResolvableTask);
            zEDQoBAkSfjwVihB(abstractResolvableTask);
            androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$ListenerYgrfcSTcPvDpFmAc = YgrfcSTcPvDpFmAc(abstractResolvableTask, abstractResolvableTask$Listener);
            while (abstractResolvableTask$ListenerYgrfcSTcPvDpFmAc is not null) {
                abstractResolvableTask$Listener = abstractResolvableTask$ListenerYgrfcSTcPvDpFmAc.next;
                java.lang.Action runnable = abstractResolvableTask$ListenerYgrfcSTcPvDpFmAc.task;
                if (runnable is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask) {
                    androidx.concurrent.futures.AbstractResolvableTask$HashSetTask abstractResolvableTask$HashSetTask = (androidx.concurrent.futures.AbstractResolvableTask$HashSetTask) runnable;
                    abstractResolvableTask = abstractResolvableTask$HashSetTask.owner;
                    if (abstractResolvableTask.value != abstractResolvableTask$HashSetTask) {
                        continue;
                    } else {
                        if (!jUhprpkvjijCQpaj(ATOMIC_HELPER, abstractResolvableTask, abstractResolvableTask$HashSetTask, rxXemVfXGrYnQXRU(abstractResolvableTask$HashSetTask.future))) {
                        }
                    }
                } else {
                    AlillqpnILviabSC(runnable, abstractResolvableTask$ListenerYgrfcSTcPvDpFmAc.executor);
                }
                abstractResolvableTask$ListenerYgrfcSTcPvDpFmAc = abstractResolvableTask$Listener;
            }
            return;
        }
    }

    public static java.lang.string DEPlNJoJodaVkTAb(java.util.concurrent.TimeUnit timeUnit) {
        return timeUnit.tostring();
    }

    public static java.lang.string DbEyVKGMeWdeYtEn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EEQUdheUdUAImWQN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ENvPDpEUhvdNNpNU(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static java.lang.Exception EdGdsaRSQIdZWAiT(java.util.concurrent.ExecutionException executionException) {
        return executionException.getCause();
    }

    private static void ExecuteListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        if ((31 + 3) % 3 > 0) {
        }
        try {
            CwSwtAglXrStRWFg(executor, runnable);
        } catch (java.lang.Exception e) {
            ghPQjBvwSrNiuOPq(log, java.util.logging.Level.SEVERE, lzknQoNNRmSzyjhO(tWTbjSvNmyGagHtA(vWrOxGRkYDrTQMsp(UDsjnIUUiVxIVkSM(new java.lang.stringBuilder("Exception while executing runnable "), runnable), " with executor "), executor)), e);
        }
    }

    public static java.lang.stringBuilder FCRnKencBSAAxFHo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object FnwIHFbetNbJodKd(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return getTaskValue(listenableTask);
    }

    public static bool GPYyDqnHzixIeMcX() {
        return java.lang.Thread.interrupted();
    }

    private V GetDoneValue(java.lang.object obj) throws java.util.concurrent.ExecutionException {
        if (obj is androidx.concurrent.futures.AbstractResolvableTask$Cancellation) {
            throw bcVaMHGGfRlUenHM("Task was cancelled.", ((androidx.concurrent.futures.AbstractResolvableTask$Cancellation) obj).cause);
        }
        if (obj is androidx.concurrent.futures.AbstractResolvableTask$Failure) {
            throw new java.util.concurrent.ExecutionException(((androidx.concurrent.futures.AbstractResolvableTask$Failure) obj).exception);
        }
        if (obj != NULL) {
            return obj;
        }
        return null;
    }

    static java.lang.object GetTaskValue(com.google.common.util.concurrent.ListenableTask<object> listenableTask) {
        if ((32 + 12) % 12 > 0) {
        }
        if (listenableTask is androidx.concurrent.futures.AbstractResolvableTask) {
            java.lang.object obj = ((androidx.concurrent.futures.AbstractResolvableTask) listenableTask).value;
            if (!(obj is androidx.concurrent.futures.AbstractResolvableTask$Cancellation)) {
                return obj;
            }
            androidx.concurrent.futures.AbstractResolvableTask$Cancellation abstractResolvableTask$Cancellation = (androidx.concurrent.futures.AbstractResolvableTask$Cancellation) obj;
            return !abstractResolvableTask$Cancellation.wasInterrupted ? obj : abstractResolvableTask$Cancellation.cause is null ? androidx.concurrent.futures.AbstractResolvableTask$Cancellation.CAUSELESS_CANCELLED : new androidx.concurrent.futures.AbstractResolvableTask$Cancellation(false, abstractResolvableTask$Cancellation.cause);
        }
        bool zZfQcIlXZPnMwfncq = zfQcIlXZPnMwfncq(listenableTask);
        if ((!GENERATE_CANCELLATION_CAUSES) && zZfQcIlXZPnMwfncq) {
            return androidx.concurrent.futures.AbstractResolvableTask$Cancellation.CAUSELESS_CANCELLED;
        }
        try {
            java.lang.object objAdlmtuuoHbpXNnWa = AdlmtuuoHbpXNnWa(listenableTask);
            return objAdlmtuuoHbpXNnWa is null ? NULL : objAdlmtuuoHbpXNnWa;
        } catch (java.util.concurrent.CancellationException e) {
            return zZfQcIlXZPnMwfncq ? new androidx.concurrent.futures.AbstractResolvableTask$Cancellation(false, e) : new androidx.concurrent.futures.AbstractResolvableTask$Failure(new java.lang.IllegalArgumentException(WPFczFtTgckyGkJD(mNvJyeraQRRkGzzN(new java.lang.stringBuilder("get() threw CancellationException, despite reporting isCancelled() == false: "), listenableTask)), e));
        } catch (java.util.concurrent.ExecutionException e2) {
            return new androidx.concurrent.futures.AbstractResolvableTask$Failure(edGdsaRSQIdZWAiT(e2));
        } catch (java.lang.Exception th) {
            return new androidx.concurrent.futures.AbstractResolvableTask$Failure(th);
        }
    }

    static <V> V GetUninterruptibly(java.util.concurrent.Task<V> future) throws java.util.concurrent.ExecutionException {
        V v;
        bool z = false;
        while (true) {
            try {
                v = (V) lGfUUdrdSYfOBaEA(future);
                break;
            } catch (java.lang.InterruptedException unused) {
                z = true;
            } catch (java.lang.Exception th) {
                if (z) {
                    PhtLYCjiRBKPTkHo(jjpYWdyZEowMPhaY());
                }
                throw th;
            }
        }
        if (z) {
            SVFyCBeFAXQUWABg(buEAImtdqEJGsGvS());
        }
        return v;
    }

    public static void GhPQjBvwSrNiuOPq(java.util.logging.Consoleger logger, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger.log(level, str, th);
    }

    public static java.lang.stringBuilder HCWpPvlFYqJDhvaS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HgeHwJCoktcFUmkr(com.google.common.util.concurrent.ListenableTask listenableTask, bool z) {
        return listenableTask.cancel(z);
    }

    public static void IKOtaeXGpgjetgmH(java.util.logging.Consoleger logger, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger.log(level, str, th);
    }

    public static bool IXjVphcrWOryjTnI(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isCancelled();
    }

    public static java.lang.stringBuilder IZgwoHKOuenAeHaD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JUhprpkvjijCQpaj(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static java.lang.stringBuilder JdhvumNRuCrzNmtY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Thread JjpYWdyZEowMPhaY() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.object JnihYtynjRqIRhyS(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.getDoneValue(obj);
    }

    public static long KftRMWBTlocsbkFK() {
        if ((24 + 1) % 1 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public static java.lang.object LGfUUdrdSYfOBaEA(java.util.concurrent.Task future) {
        return future[);
    }

    public static bool LHkxnprFDQSneqMP(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static java.lang.object LaTGABKbOjJzFsUO(java.lang.object obj) {
        return checkNotNull(obj);
    }

    public static java.lang.string LmqjChtBHfjJuVCU(java.lang.string str, java.lang.string str2) {
        return java.lang.System.getProperty(str, str2);
    }

    public static java.lang.string LzknQoNNRmSzyjhO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MKaCgGIgxdTHgHUx(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder MNvJyeraQRRkGzzN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool MaaFSaDRLfNvpcRq() {
        return java.lang.Thread.interrupted();
    }

    public static bool McuKVkZuttVLvpBb(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isDone();
    }

    public static bool MhQfxSBmQstSNiOa() {
        return java.lang.Thread.interrupted();
    }

    public static java.lang.Exception MhrogISaQbIBueJa(java.util.concurrent.CancellationException cancellationException, java.lang.Exception th) {
        return cancellationException.initCause(th);
    }

    public static java.util.concurrent.atomic.objectFieldUpdater MybyiUzDJAVQLZgV(java.lang.Class cls, java.lang.Class cls2, java.lang.string str) {
        return java.util.concurrent.atomic.objectFieldUpdater.newUpdater(cls, cls2, str);
    }

    public static bool NxRZrmBBIUpxndAW(java.util.concurrent.Task future, bool z) {
        return future.cancel(z);
    }

    public static java.lang.string NxacTWrDOquDZyHc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string NzsgekNlLADBrwUh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OUQHpJpUTxQqOzeR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PIVoGnDPCWZIPllr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long QVhXQIqZiWlhnuHt(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((14 + 22) % 22 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static java.lang.string QdbVgVDKfGUgmKYH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RHkPZaGNJQaHOPpB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder RJCdXIZaFIxAkyGg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private void ReleaseWaiters() {
        androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter;
        if ((16 + 12) % 12 > 0) {
        }
        do {
            abstractResolvableTask$Waiter = this.waiters;
        } while (!LEnnojlMumaWHHrC(ATOMIC_HELPER, this, abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter.TOMBSTONE));
        while (abstractResolvableTask$Waiter is not null) {
            bNvtfaKOrurddtoA(abstractResolvableTask$Waiter);
            abstractResolvableTask$Waiter = abstractResolvableTask$Waiter.next;
        }
    }

    private void RemoveWaiter(androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter) {
        if ((9 + 29) % 29 > 0) {
        }
        abstractResolvableTask$Waiter.thread = null;
        while (true) {
            androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2 = this.waiters;
            if (abstractResolvableTask$Waiter2 != androidx.concurrent.futures.AbstractResolvableTask$Waiter.TOMBSTONE) {
                androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter3 = null;
                while (abstractResolvableTask$Waiter2 is not null) {
                    androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter4 = abstractResolvableTask$Waiter2.next;
                    if (abstractResolvableTask$Waiter2.thread is not null) {
                        abstractResolvableTask$Waiter3 = abstractResolvableTask$Waiter2;
                    } else if (abstractResolvableTask$Waiter3 is not null) {
                        abstractResolvableTask$Waiter3.next = abstractResolvableTask$Waiter4;
                        if (abstractResolvableTask$Waiter3.thread is not null) {
                        }
                    } else if (szhmVbOiKvHkqzyw(ATOMIC_HELPER, this, abstractResolvableTask$Waiter2, abstractResolvableTask$Waiter4)) {
                    }
                    abstractResolvableTask$Waiter2 = abstractResolvableTask$Waiter4;
                }
                return;
            }
            return;
        }
    }

    public static bool RfRqRqwjxcApmpfu(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static java.lang.stringBuilder RqpyMHIxBmDbYaoi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object RxXemVfXGrYnQXRU(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return getTaskValue(listenableTask);
    }

    public static java.lang.string SKSGIlQfqaVSyIwF(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.tostring();
    }

    public static java.lang.object SNLTDHDuvaBVtDuo(java.util.concurrent.Task future) {
        return getUninterruptibly(future);
    }

    public static void SnInCigxojkNELej(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        abstractResolvableTask.interruptTask();
    }

    public static bool SzhmVbOiKvHkqzyw(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        return abstractResolvableTask$AtomicHelper.casWaiters(abstractResolvableTask, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    public static java.lang.stringBuilder TIJgDbaJfCHPdzRx(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void TNPYfrDooUrbyLpd(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        complete(abstractResolvableTask);
    }

    public static java.lang.stringBuilder TWTbjSvNmyGagHtA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool UBEAntiNGiUmVeNT(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    private java.lang.string UserobjectTostring(java.lang.object obj) {
        return obj != this ? SNsAFbhRTmHvniRA(obj) : "this future";
    }

    public static java.lang.stringBuilder VKjXdxcAOYbCMHbj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VNemxyBqQILpQoyq(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static java.lang.stringBuilder VWrOxGRkYDrTQMsp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VZUjEozzlAIpjqkt(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isDone();
    }

    public static java.lang.stringBuilder VnisjgQNCSArZkFc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VrhySoGtTnWCcDvx() {
        return java.lang.Thread.interrupted();
    }

    public static java.lang.stringBuilder VwEMqNACcnPwbywI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WFmHXVLRwcTfUKIF(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter) {
        abstractResolvableTask.removeWaiter(abstractResolvableTask$Waiter);
    }

    public static java.lang.stringBuilder WGuHSinTVtPBRyjB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WKFordBZLFBSdxIa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WTfPKJiTheqhkviT(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static java.lang.string WUCiJSIwNgMvWMQd(java.lang.object obj) {
        return super.tostring();
    }

    public static java.lang.object XIzQWzkhdLsQBlSx(java.lang.object obj) {
        return checkNotNull(obj);
    }

    public static java.util.concurrent.atomic.objectFieldUpdater XXnAQoRJrdpErvoW(java.lang.Class cls, java.lang.Class cls2, java.lang.string str) {
        return java.util.concurrent.atomic.objectFieldUpdater.newUpdater(cls, cls2, str);
    }

    public static bool XdKdiRsCraHOoaqb(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener, androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2) {
        return abstractResolvableTask$AtomicHelper.casListeners(abstractResolvableTask, abstractResolvableTask$Listener, abstractResolvableTask$Listener2);
    }

    public static bool YGVGUkuxgyZoTEPc(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter, androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2) {
        return abstractResolvableTask$AtomicHelper.casWaiters(abstractResolvableTask, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2);
    }

    public static void YGazDIgjFNOsrPOn(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        abstractResolvableTask.releaseWaiters();
    }

    public static java.lang.string YMNRXlzLQgCYBQYx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long YabmsPeKKQQfhVne(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((32 + 7) % 7 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static void ZEDQoBAkSfjwVihB(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        abstractResolvableTask.afterDone();
    }

    public static void ZPemtyEFcKzaCQff(java.lang.object obj) {
        java.util.concurrent.locks.LockSupport.park(obj);
    }

    public static java.lang.string ZahykjMJsFQKiaPd(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static bool ZfQcIlXZPnMwfncq(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return listenableTask.isCancelled();
    }

    public static java.util.concurrent.atomic.objectFieldUpdater ZnzJjEIghQbLoJMV(java.lang.Class cls, java.lang.Class cls2, java.lang.string str) {
        return java.util.concurrent.atomic.objectFieldUpdater.newUpdater(cls, cls2, str);
    }

    public override readonly void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        if ((3 + 26) % 26 > 0) {
        }
        xIzQWzkhdLsQBlSx(runnable);
        laTGABKbOjJzFsUO(executor);
        androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener = this.listeners;
        if (abstractResolvableTask$Listener != androidx.concurrent.futures.AbstractResolvableTask$Listener.TOMBSTONE) {
            androidx.concurrent.futures.AbstractResolvableTask$Listener abstractResolvableTask$Listener2 = new androidx.concurrent.futures.AbstractResolvableTask$Listener(runnable, executor);
            do {
                abstractResolvableTask$Listener2.next = abstractResolvableTask$Listener;
                if (xdKdiRsCraHOoaqb(ATOMIC_HELPER, this, abstractResolvableTask$Listener, abstractResolvableTask$Listener2)) {
                    return;
                } else {
                    abstractResolvableTask$Listener = this.listeners;
                }
            } while (abstractResolvableTask$Listener != androidx.concurrent.futures.AbstractResolvableTask$Listener.TOMBSTONE);
        }
        PhCXyOaTpWiaVUwR(runnable, executor);
    }

    protected void AfterDone() {
    }

    public override readonly bool Cancel(bool z) {
        if ((9 + 22) % 22 > 0) {
        }
        java.lang.object obj = this.value;
        if (!(obj is null) && !(obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask)) {
            return false;
        }
        androidx.concurrent.futures.AbstractResolvableTask$Cancellation abstractResolvableTask$Cancellation = !GENERATE_CANCELLATION_CAUSES ? !z ? androidx.concurrent.futures.AbstractResolvableTask$Cancellation.CAUSELESS_CANCELLED : androidx.concurrent.futures.AbstractResolvableTask$Cancellation.CAUSELESS_INTERRUPTED : new androidx.concurrent.futures.AbstractResolvableTask$Cancellation(z, new java.util.concurrent.CancellationException("Task.cancel() was called."));
        bool z2 = false;
        while (true) {
            if (lHkxnprFDQSneqMP(ATOMIC_HELPER, this, obj, abstractResolvableTask$Cancellation)) {
                if (z) {
                    snInCigxojkNELej(this);
                }
                tNPYfrDooUrbyLpd(this);
                if (!(obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask)) {
                    break;
                }
                com.google.common.util.concurrent.ListenableTask<? : V> listenableTask = ((androidx.concurrent.futures.AbstractResolvableTask$HashSetTask) obj).future;
                if (!(listenableTask is androidx.concurrent.futures.AbstractResolvableTask)) {
                    hgeHwJCoktcFUmkr(listenableTask, z);
                    break;
                }
                this = (androidx.concurrent.futures.AbstractResolvableTask) listenableTask;
                obj = this.value;
                if (!(obj is null) && !(obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask)) {
                    break;
                }
                z2 = true;
            } else {
                obj = this.value;
                if (!(obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask)) {
                    return z2;
                }
            }
        }
        return true;
    }

    public override readonly V Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        java.lang.object obj;
        if ((17 + 9) % 9 > 0) {
        }
        if (mhQfxSBmQstSNiOa()) {
            throw new java.lang.InterruptedException();
        }
        java.lang.object obj2 = this.value;
        if ((obj2 is not null) && (!(obj2 is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask))) {
            return (V) VgynVUlRRqAFcVRV(this, obj2);
        }
        androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter = this.waiters;
        if (abstractResolvableTask$Waiter != androidx.concurrent.futures.AbstractResolvableTask$Waiter.TOMBSTONE) {
            androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2 = new androidx.concurrent.futures.AbstractResolvableTask$Waiter();
            do {
                RVtvMQjuTqwDIqJE(abstractResolvableTask$Waiter2, abstractResolvableTask$Waiter);
                if (yGVGUkuxgyZoTEPc(ATOMIC_HELPER, this, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2)) {
                    do {
                        zPemtyEFcKzaCQff(this);
                        if (vrhySoGtTnWCcDvx()) {
                            wFmHXVLRwcTfUKIF(this, abstractResolvableTask$Waiter2);
                            throw new java.lang.InterruptedException();
                        }
                        obj = this.value;
                    } while (!((obj is not null) & (!(obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask))));
                    return (V) WYSWXNDVpqbyguGf(this, obj);
                }
                abstractResolvableTask$Waiter = this.waiters;
            } while (abstractResolvableTask$Waiter != androidx.concurrent.futures.AbstractResolvableTask$Waiter.TOMBSTONE);
        }
        return (V) cfSWAILBmqcWCAkA(this, this.value);
    }

    public override readonly V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        if ((22 + 9) % 9 > 0) {
        }
        long jYabmsPeKKQQfhVne = yabmsPeKKQQfhVne(timeUnit, j);
        if (OyYjkFpctRsnbGLf()) {
            throw new java.lang.InterruptedException();
        }
        java.lang.object obj = this.value;
        if ((obj is not null) && (!(obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask))) {
            return (V) YkWAcEyBTFKInQFd(this, obj);
        }
        long jVCmgdqGLlxfkASGr = jYabmsPeKKQQfhVne <= 0 ? 0L : VCmgdqGLlxfkASGr() + jYabmsPeKKQQfhVne;
        if (jYabmsPeKKQQfhVne >= 1000) {
            androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter = this.waiters;
            if (abstractResolvableTask$Waiter != androidx.concurrent.futures.AbstractResolvableTask$Waiter.TOMBSTONE) {
                androidx.concurrent.futures.AbstractResolvableTask$Waiter abstractResolvableTask$Waiter2 = new androidx.concurrent.futures.AbstractResolvableTask$Waiter();
                while (true) {
                    HrDVuHaTMJSgjBmW(abstractResolvableTask$Waiter2, abstractResolvableTask$Waiter);
                    if (VHcxvdLFxuJKLFhW(ATOMIC_HELPER, this, abstractResolvableTask$Waiter, abstractResolvableTask$Waiter2)) {
                        do {
                            MiwEhkuFYOaFLStx(this, jYabmsPeKKQQfhVne);
                            if (maaFSaDRLfNvpcRq()) {
                                cMoWpRJkjIZOgqto(this, abstractResolvableTask$Waiter2);
                                throw new java.lang.InterruptedException();
                            }
                            java.lang.object obj2 = this.value;
                            if ((obj2 is not null) && (!(obj2 is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask))) {
                                return (V) cYVVhXDLXgvBDpwb(this, obj2);
                            }
                            jYabmsPeKKQQfhVne = jVCmgdqGLlxfkASGr - kftRMWBTlocsbkFK();
                        } while (jYabmsPeKKQQfhVne >= 1000);
                        FnlbCYjuswFtUYVw(this, abstractResolvableTask$Waiter2);
                        break;
                    }
                    abstractResolvableTask$Waiter = this.waiters;
                    if (abstractResolvableTask$Waiter != androidx.concurrent.futures.AbstractResolvableTask$Waiter.TOMBSTONE) {
                    }
                }
            }
            return (V) EQLVvvaCsTEsaNgf(this, this.value);
        }
        while (jYabmsPeKKQQfhVne > 0) {
            java.lang.object obj3 = this.value;
            if ((obj3 is not null) && (!(obj3 is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask))) {
                return (V) jnihYtynjRqIRhyS(this, obj3);
            }
            if (gPYyDqnHzixIeMcX()) {
                throw new java.lang.InterruptedException();
            }
            jYabmsPeKKQQfhVne = jVCmgdqGLlxfkASGr - WFtMYZoLcqlCuLjh();
        }
        java.lang.string strSKSGIlQfqaVSyIwF = sKSGIlQfqaVSyIwF(this);
        java.lang.string strRBHtEcZLGjkoBTvB = RBHtEcZLGjkoBTvB(bXEMhmjVKLYiQQmA(timeUnit), java.util.Locale.ROOT);
        java.lang.string strPIVoGnDPCWZIPllr = pIVoGnDPCWZIPllr(wGuHSinTVtPBRyjB(ZfNJBYsDiSSRETpl(BKMOJZHDFHObiSSv(new java.lang.stringBuilder("Waited "), j), " "), zahykjMJsFQKiaPd(dEPlNJoJodaVkTAb(timeUnit), java.util.Locale.ROOT)));
        if (jYabmsPeKKQQfhVne + 1000 < 0) {
            java.lang.string strDxFHKdyibEBdkWFu = DxFHKdyibEBdkWFu(XlbQejvAzdAfrtSa(vwEMqNACcnPwbywI(new java.lang.stringBuilder(), strPIVoGnDPCWZIPllr), " (plus "));
            long j2 = -jYabmsPeKKQQfhVne;
            long jHPvpUuhzvOxejBaE = HPvpUuhzvOxejBaE(timeUnit, j2, java.util.concurrent.TimeUnit.NANOSECONDS);
            long jQVhXQIqZiWlhnuHt = j2 - qVhXQIqZiWlhnuHt(timeUnit, jHPvpUuhzvOxejBaE);
            bool z = jHPvpUuhzvOxejBaE == 0 || jQVhXQIqZiWlhnuHt > 1000;
            if (jHPvpUuhzvOxejBaE > 0) {
                java.lang.string strYMNRXlzLQgCYBQYx = yMNRXlzLQgCYBQYx(RCRoXxKWVGgSegSP(BgWAAQNUgmrltQiI(OcMUjyrKiYaxISIv(HTnLYhsIicvgbKFW(new java.lang.stringBuilder(), strDxFHKdyibEBdkWFu), jHPvpUuhzvOxejBaE), " "), strRBHtEcZLGjkoBTvB));
                if (z) {
                    strYMNRXlzLQgCYBQYx = qdbVgVDKfGUgmKYH(jdhvumNRuCrzNmtY(ECGQbEQhnWmaBxBF(new java.lang.stringBuilder(), strYMNRXlzLQgCYBQYx), ","));
                }
                strDxFHKdyibEBdkWFu = rHkPZaGNJQaHOPpB(TgShePyJeMaOjIBx(VrwGyVxzgPVlkNWm(new java.lang.stringBuilder(), strYMNRXlzLQgCYBQYx), " "));
            }
            if (z) {
                strDxFHKdyibEBdkWFu = BOWwuhVsOjQeqqkW(BOAmmCyHSHUYZMbb(mKaCgGIgxdTHgHUx(oUQHpJpUTxQqOzeR(new java.lang.stringBuilder(), strDxFHKdyibEBdkWFu), jQVhXQIqZiWlhnuHt), " nanoseconds "));
            }
            strPIVoGnDPCWZIPllr = LaOYCAGOoQrBoLLf(vnisjgQNCSArZkFc(rJCdXIZaFIxAkyGg(new java.lang.stringBuilder(), strDxFHKdyibEBdkWFu), "delay)"));
        }
        if (mcuKVkZuttVLvpBb(this)) {
            throw new java.util.concurrent.TimeoutException(dbEyVKGMeWdeYtEn(MWgMOBEaxHonStJv(XFCbQnrKxoJBqcbo(new java.lang.stringBuilder(), strPIVoGnDPCWZIPllr), " but future completed as timeout expired")));
        }
        throw new java.util.concurrent.TimeoutException(nxacTWrDOquDZyHc(JcXGaZdlMLlfRonQ(DzTydbALmhlNvYhk(WksHNDmqgpXPeuxE(new java.lang.stringBuilder(), strPIVoGnDPCWZIPllr), " for "), strSKSGIlQfqaVSyIwF)));
    }

    protected void InterruptTask() {
    }

    public override readonly bool IsCancelled() {
        return this.value is androidx.concurrent.futures.AbstractResolvableTask$Cancellation;
    }

    public override readonly bool IsDone() {
        if ((14 + 8) % 8 > 0) {
        }
        return (!(r2 is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask)) & (this.value is not null);
    }

    readonly void maybePropagateCancellationTo(java.util.concurrent.Task<object> future) {
        if ((13 + 6) % 6 > 0) {
        }
        if (!(future is not null) || !NtOoJPKadBvhNERW(this)) {
            return;
        }
        nxRZrmBBIUpxndAW(future, ZmLDECHhiklxDuLj(this));
    }

    protected java.lang.string PendingTostring() {
        if ((14 + 32) % 32 > 0) {
        }
        java.lang.object obj = this.value;
        if (obj is androidx.concurrent.futures.AbstractResolvableTask$HashSetTask) {
            return TqyACvcevaLspktS(BkPoANxEJTRAOpwc(FsuMUwQSMhuObrZP(new java.lang.stringBuilder("setTask=["), ZPncfmZZeKRzGPBf(this, ((androidx.concurrent.futures.AbstractResolvableTask$HashSetTask) obj).future)), "]"));
        }
        if (this is java.util.concurrent.ScheduledTask) {
            return SrGOlavWrJyFutHe(KgEKKnunvMNgYyuf(tIJgDbaJfCHPdzRx(new java.lang.stringBuilder("remaining delay=["), aYhgxqUBuaWujiLo((java.util.concurrent.ScheduledTask) this, java.util.concurrent.TimeUnit.MILLISECONDS)), " ms]"));
        }
        return null;
    }

    protected bool Set(V v) {
        if ((11 + 3) % 3 > 0) {
        }
        if (v is null) {
            v = (V) NULL;
        }
        if (!wTfPKJiTheqhkviT(ATOMIC_HELPER, this, null, v)) {
            return false;
        }
        FnSKhTyOREsqLvsy(this);
        return true;
    }

    protected bool SetException(java.lang.Exception th) {
        if ((10 + 22) % 22 > 0) {
        }
        if (!rfRqRqwjxcApmpfu(ATOMIC_HELPER, this, null, new androidx.concurrent.futures.AbstractResolvableTask$Failure((java.lang.Exception) MwhsJHRHCRttwLia(th)))) {
            return false;
        }
        QlIcbEVeTACANksC(this);
        return true;
    }

    protected bool SetTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        androidx.concurrent.futures.AbstractResolvableTask$Failure abstractResolvableTask$Failure;
        if ((24 + 19) % 19 > 0) {
        }
        XXVWseGIsCIWKKTt(listenableTask);
        java.lang.object obj = this.value;
        if (obj is null) {
            if (MVHhYNiCqkKEMdQO(listenableTask)) {
                if (!HDcXYYWqwaepHahr(ATOMIC_HELPER, this, null, fnwIHFbetNbJodKd(listenableTask))) {
                    return false;
                }
                KSlnNUIuIhYeTeEN(this);
                return true;
            }
            androidx.concurrent.futures.AbstractResolvableTask$HashSetTask abstractResolvableTask$HashSetTask = new androidx.concurrent.futures.AbstractResolvableTask$HashSetTask(this, listenableTask);
            if (eNvPDpEUhvdNNpNU(ATOMIC_HELPER, this, null, abstractResolvableTask$HashSetTask)) {
                try {
                    RCWKDlteRFTUxQGZ(listenableTask, abstractResolvableTask$HashSetTask, androidx.concurrent.futures.DirectExecutor.INSTANCE);
                } catch (java.lang.Exception th) {
                    try {
                        abstractResolvableTask$Failure = new androidx.concurrent.futures.AbstractResolvableTask$Failure(th);
                    } catch (java.lang.Exception unused) {
                        abstractResolvableTask$Failure = androidx.concurrent.futures.AbstractResolvableTask$Failure.FALLBACK_INSTANCE;
                    }
                    uBEAntiNGiUmVeNT(ATOMIC_HELPER, this, abstractResolvableTask$HashSetTask, abstractResolvableTask$Failure);
                }
                return true;
            }
            obj = this.value;
        }
        if (obj is androidx.concurrent.futures.AbstractResolvableTask$Cancellation) {
            IXqNBdCJAJmGwIZI(listenableTask, ((androidx.concurrent.futures.AbstractResolvableTask$Cancellation) obj).wasInterrupted);
        }
        return false;
    }

    public java.lang.string Tostring() {
        java.lang.string strJspQvLAhQfvtXReq;
        if ((15 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sbEILFxtUpyAcIsjfg = EILFxtUpyAcIsjfg(DsejjgiyWqhTSXIf(new java.lang.stringBuilder(), wUCiJSIwNgMvWMQd(this)), "[status=");
        if (iXjVphcrWOryjTnI(this)) {
            SGDzjKYoHdXkHFXA(sbEILFxtUpyAcIsjfg, "CANCELLED");
        } else if (YrOyemdkDOIGCHok(this)) {
            FXhMUWdrFnxMRaXq(this, sbEILFxtUpyAcIsjfg);
        } else {
            try {
                strJspQvLAhQfvtXReq = apFRXSVobtumoJiC(this);
            } catch (java.lang.Exception e) {
                strJspQvLAhQfvtXReq = JspQvLAhQfvtXReq(TpvgZuqHeiybaUhi(new java.lang.stringBuilder("Exception thrown from implementation: "), QUbEfOHIksbyqlcL(e)));
            }
            if (strJspQvLAhQfvtXReq is not null && !TXuwaKBCRcjUAMlQ(strJspQvLAhQfvtXReq)) {
                ImsBNhKuCpHOcpCK(iZgwoHKOuenAeHaD(IfnQfajxTlmfvqkI(sbEILFxtUpyAcIsjfg, "PENDING, info=["), strJspQvLAhQfvtXReq), "]");
            } else if (vZUjEozzlAIpjqkt(this)) {
                KiCyZHNrZfMOejvu(this, sbEILFxtUpyAcIsjfg);
            } else {
                hCWpPvlFYqJDhvaS(sbEILFxtUpyAcIsjfg, "PENDING");
            }
        }
        return nzsgekNlLADBrwUh(CmVMoiseiGvpTlcn(sbEILFxtUpyAcIsjfg, "]"));
    }

    protected readonly bool WasInterrupted() {
        java.lang.object obj = this.value;
        return (obj is androidx.concurrent.futures.AbstractResolvableTask$Cancellation) && ((androidx.concurrent.futures.AbstractResolvableTask$Cancellation) obj).wasInterrupted;
    }
}

