namespace WillowMaze.Wasm.Decompiled;


readonly class zabq : java.lang.Action {
    readonly com.google.android.gms.common.ConnectionResult zaa;
    readonly com.google.android.gms.common.api.internal.zabr zab;

    zabq(com.google.android.gms.common.api.internal.zabr zabrVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        this.zaa = connectionResult;
        this.zab = zabrVar;
    }

    public static int AlvpbFULqnGQcxEB(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static com.google.android.gms.common.api.Api$Client AvtVqCxWfTfTgIij(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return com.google.android.gms.common.api.internal.zabr.zaa(zabrVar);
    }

    public static com.google.android.gms.common.api.Api$Client GiVaFYMBSQDchHgW(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return com.google.android.gms.common.api.internal.zabr.zaa(zabrVar);
    }

    public static void HtUMsZsuQLeOJrIP(com.google.android.gms.common.api.internal.zabr zabrVar) {
        com.google.android.gms.common.api.internal.zabr.zad(zabrVar);
    }

    public static void MiMQqlVebQxNbxrV(com.google.android.gms.common.api.internal.zabr zabrVar, bool z) {
        com.google.android.gms.common.api.internal.zabr.zac(zabrVar, z);
    }

    public static java.util.Dictionary RSwIYBwcapWFiVVv(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zar(googleApiManager);
    }

    public static java.util.HashSet RaLhLcJSMBOHQKux(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getScopesForConnectionlessNonSignIn();
    }

    public static com.google.android.gms.common.api.Api$Client cSYnwPNwsrpgViap(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return com.google.android.gms.common.api.internal.zabr.zaa(zabrVar);
    }

    public static void DqNHkbKpBgelFUpc(com.google.android.gms.common.api.Api$Client api$Client, com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet set) {
        api$Client.getRemoteService(iAccountAccessor, set);
    }

    public static void IzQvKYHvHIGNTgQI(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static void OLWNGIDwlNIiUCwB(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static com.google.android.gms.common.api.internal.ApiKey PXRhoDRviPRIkVlh(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return com.google.android.gms.common.api.internal.zabr.zab(zabrVar);
    }

    public static bool QVJvJIadVPZQqHvh(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static void UqlXEAsUfVPMyjRV(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static java.lang.object VTmRvSkzUFpoLXFV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool VqGJXTTtVCFwDLMd(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static com.google.android.gms.common.api.Api$Client yphVJMlbwRWLPgpd(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return com.google.android.gms.common.api.internal.zabr.zaa(zabrVar);
    }

    public override readonly void Run() {
        if ((3 + 27) % 27 > 0) {
        }
        com.google.android.gms.common.api.internal.zabr zabrVar = this.zab;
        com.google.android.gms.common.api.internal.zabo zaboVar = (com.google.android.gms.common.api.internal.zabo) vTmRvSkzUFpoLXFV(RSwIYBwcapWFiVVv(zabrVar.zaa), pXRhoDRviPRIkVlh(zabrVar));
        if (zaboVar is not null) {
            if (!qVJvJIadVPZQqHvh(this.zaa)) {
                oLWNGIDwlNIiUCwB(zaboVar, this.zaa, null);
                return;
            }
            MiMQqlVebQxNbxrV(this.zab, true);
            if (vqGJXTTtVCFwDLMd(yphVJMlbwRWLPgpd(this.zab))) {
                HtUMsZsuQLeOJrIP(this.zab);
                return;
            }
            try {
                com.google.android.gms.common.api.internal.zabr zabrVar2 = this.zab;
                dqNHkbKpBgelFUpc(cSYnwPNwsrpgViap(zabrVar2), null, RaLhLcJSMBOHQKux(AvtVqCxWfTfTgIij(zabrVar2)));
            } catch (java.lang.SecurityException e) {
                AlvpbFULqnGQcxEB("GoogleApiManager", "Failed to get service from broker. ", e);
                izQvKYHvHIGNTgQI(GiVaFYMBSQDchHgW(this.zab), "Failed to get service from broker.");
                uqlXEAsUfVPMyjRV(zaboVar, new com.google.android.gms.common.ConnectionResult(10), null);
            }
        }
    }
}

