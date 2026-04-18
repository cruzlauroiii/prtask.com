namespace WillowMaze.Wasm.Decompiled;


abstract class zad : com.google.android.gms.common.api.internal.zac {
    protected readonly com.google.android.gms.tasks.TaskCompletionSource zaa;

    public zad(int i, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(i);
        this.zaa = taskCompletionSource;
    }

    public static com.google.android.gms.common.api.Status DoFbKaoEOITqeZXs(android.os.RemoteException remoteException) {
        return com.google.android.gms.common.api.internal.zai.zah(remoteException);
    }

    public static bool HtfpCcMRFmpVLCvo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void SgwUHiLeuhyvSnWX(com.google.android.gms.common.api.internal.zad zadVar, com.google.android.gms.common.api.Status status) {
        zadVar.zad(status);
    }

    public static void YgBLEaBotRoCSVny(com.google.android.gms.common.api.internal.zad zadVar, com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.RemoteException {
        zadVar.zac(zaboVar);
    }

    public static com.google.android.gms.common.api.Status HvJRubyhgTVwyNxO(android.os.RemoteException remoteException) {
        return com.google.android.gms.common.api.internal.zai.zah(remoteException);
    }

    public static bool JmSQxBtjAjxMIxrY(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static bool SdTgaIdiZenxTHGH(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void YBzOyqAviYvmHkVQ(com.google.android.gms.common.api.internal.zad zadVar, com.google.android.gms.common.api.Status status) {
        zadVar.zad(status);
    }

    protected abstract void Zac(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.RemoteException;

    public override readonly void Zad(com.google.android.gms.common.api.Status status) {
        HtfpCcMRFmpVLCvo(this.zaa, new com.google.android.gms.common.api.ApiException(status));
    }

    public override readonly void Zae(java.lang.Exception exc) {
        sdTgaIdiZenxTHGH(this.zaa, exc);
    }

    public override readonly void Zaf(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.DeadobjectException {
        try {
            YgBLEaBotRoCSVny(this, zaboVar);
        } catch (android.os.DeadobjectException e) {
            SgwUHiLeuhyvSnWX(this, hvJRubyhgTVwyNxO(e));
            throw e;
        } catch (android.os.RemoteException e2) {
            yBzOyqAviYvmHkVQ(this, DoFbKaoEOITqeZXs(e2));
        } catch (java.lang.Exception e3) {
            jmSQxBtjAjxMIxrY(this.zaa, e3);
        }
    }

    public override void Zag(com.google.android.gms.common.api.internal.zaac zaacVar, bool z) {
    }
}

