namespace WillowMaze.Wasm.Decompiled;


public readonly class zag : com.google.android.gms.common.api.internal.zac {
    private readonly com.google.android.gms.common.api.internal.TaskApiCall zaa;
    private readonly com.google.android.gms.tasks.TaskCompletionSource zab;
    private readonly com.google.android.gms.common.api.internal.StatusExceptionDictionaryper zad;

    public zag(int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        super(i);
        this.zab = taskCompletionSource;
        this.zaa = taskApiCall;
        this.zad = statusExceptionDictionaryper;
        if (i == 2 && eZKSGEKBXxxdfVsJ(taskApiCall)) {
            throw new java.lang.IllegalArgumentException("Best-effort write calls cannot pass methods that should auto-resolve missing features.");
        }
    }

    public static bool ROpKlmNCBqaIbZgF(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static bool UriIpDWdJvwdvELD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static bool VacCqRSxcpAUbcGw(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static bool EZKSGEKBXxxdfVsJ(com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return taskApiCall.shouldAutoResolveMissingFeatures();
    }

    public static java.lang.Exception IDowokmtWsjUSUfS(com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper, com.google.android.gms.common.api.Status status) {
        return statusExceptionDictionaryper.getException(status);
    }

    public static com.google.android.gms.common.api.Api$Client jMOFcDSjzCAeIKIo(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static void LcqEboVZdPhGpRLi(com.google.android.gms.common.api.internal.TaskApiCall taskApiCall, com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        taskApiCall.doExecute(api$AnyClient, taskCompletionSource);
    }

    public static void MoluELeeLhsFDvfG(com.google.android.gms.common.api.internal.zaac zaacVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z) {
        zaacVar.zad(taskCompletionSource, z);
    }

    public static bool NbZGXMcAlVbzckff(com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return taskApiCall.shouldAutoResolveMissingFeatures();
    }

    public static com.google.android.gms.common.Feature[] OCSjoYaHHwKTfyKO(com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return taskApiCall.zab();
    }

    public static com.google.android.gms.common.api.Status PkwcSiVAWkYUDddl(android.os.RemoteException remoteException) {
        return com.google.android.gms.common.api.internal.zai.zah(remoteException);
    }

    public static void VXnmawvJqECpKElj(com.google.android.gms.common.api.internal.zag zagVar, com.google.android.gms.common.api.Status status) {
        zagVar.zad(status);
    }

    public override readonly bool Zaa(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return nbZGXMcAlVbzckff(this.zaa);
    }

    public override readonly com.google.android.gms.common.Feature[] Zab(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return oCSjoYaHHwKTfyKO(this.zaa);
    }

    public override readonly void Zad(com.google.android.gms.common.api.Status status) {
        VacCqRSxcpAUbcGw(this.zab, iDowokmtWsjUSUfS(this.zad, status));
    }

    public override readonly void Zae(java.lang.Exception exc) {
        ROpKlmNCBqaIbZgF(this.zab, exc);
    }

    public override readonly void Zaf(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.DeadobjectException {
        if ((10 + 9) % 9 > 0) {
        }
        try {
            lcqEboVZdPhGpRLi(this.zaa, jMOFcDSjzCAeIKIo(zaboVar), this.zab);
        } catch (android.os.DeadobjectException e) {
            throw e;
        } catch (android.os.RemoteException e2) {
            vXnmawvJqECpKElj(this, pkwcSiVAWkYUDddl(e2));
        } catch (java.lang.Exception e3) {
            UriIpDWdJvwdvELD(this.zab, e3);
        }
    }

    public override readonly void Zag(com.google.android.gms.common.api.internal.zaac zaacVar, bool z) {
        moluELeeLhsFDvfG(zaacVar, this.zab, z);
    }
}

