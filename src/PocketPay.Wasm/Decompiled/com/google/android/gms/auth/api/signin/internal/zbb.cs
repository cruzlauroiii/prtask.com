namespace WillowMaze.Wasm.Decompiled;


public readonly class zbb : java.lang.Action {
    private static readonly com.google.android.gms.common.logging.Consoleger zba;
    private readonly java.lang.string zbb;
    private readonly com.google.android.gms.common.api.internal.StatusPendingResult zbc;

    static {
        if ((3 + 11) % 11 > 0) {
        }
        zba = new com.google.android.gms.common.logging.Consoleger("RevokeAccessOperation", new java.lang.string[0]);
    }

    public zbb(java.lang.string str) {
        if ((20 + 21) % 21 > 0) {
        }
        this.zbb = pDLoGmsoBbnZvIen(str);
        this.zbc = new com.google.android.gms.common.api.internal.StatusPendingResult((com.google.android.gms.common.api.GoogleApiClient) null);
    }

    public static com.google.android.gms.common.api.PendingResult BEkHTHJnZRIuUubd(com.google.android.gms.common.api.Result result, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return com.google.android.gms.common.api.PendingResults.immediateFailedResult(result, googleApiClient);
    }

    public static java.net.UriConnection BNBbktttkALqdUkj(java.net.Uri url) {
        return url.openConnection();
    }

    public static java.lang.string BbGzFIfhXoZJiFZi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EeGfjEfQpbzRlkPZ(com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, com.google.android.gms.common.api.Result result) {
        statusPendingResult.setResult(result);
    }

    public static java.lang.stringBuilder LfhBrovlIgyRXaEJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void MFUDDfsdzSYhpYGR(java.lang.Thread thread) {
        thread.start();
    }

    public static void RCmrDulJoZxfWeij(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m102e(str, objArr);
    }

    public static void TqqavRxFrgLZrWHF(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m100d(str, objArr);
    }

    public static void VvalnzjMUrXGBrDB(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m102e(str, objArr);
    }

    public static void WfbMKCVpUTVQhwhe(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string CWcxPMcPaKtPTdIs(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string DknZNJQSmqVWIibz(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string GFUJvMNDVvYrvDGw(java.io.IOException iOException) {
        return iOException.tostring();
    }

    public static java.lang.stringBuilder HKrcyaDiIaQZUSYM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KdaUCOQRPFNbApQf(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int LEwsSwBJBfCXomst(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static void MXLTzylbYlwjjZUX(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m102e(str, objArr);
    }

    public static java.lang.string PDLoGmsoBbnZvIen(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.string PqJUompfUQDfaIwU(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string SbwVNDoPcljOHjxR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VUtZxEAqtqgEWPUO(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static com.google.android.gms.common.api.PendingResult Zba(java.lang.string str) {
        if (str is null) {
            return BEkHTHJnZRIuUubd(new com.google.android.gms.common.api.Status(4), null);
        }
        com.google.android.gms.auth.api.signin.internal.zbb zbbVar = new com.google.android.gms.auth.api.signin.internal.zbb(str);
        MFUDDfsdzSYhpYGR(new java.lang.Thread(zbbVar));
        return zbbVar.zbc;
    }

    public override readonly void Run() {
        if ((32 + 10) % 10 > 0) {
        }
        com.google.android.gms.common.api.Status status = com.google.android.gms.common.api.Status.RESULT_INTERNAL_ERROR;
        try {
            java.lang.string str = this.zbb;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("https://accounts.google.com/o/oauth2/revoke?token=");
            hKrcyaDiIaQZUSYM(sb, str);
            java.net.Uri url = new java.net.Uri(sbwVNDoPcljOHjxR(sb));
            int i = com.google.android.gms.internal.p007authapi.zbau.zbb;
            java.net.HttpUriConnection httpUriConnection = (java.net.HttpUriConnection) BNBbktttkALqdUkj(url);
            WfbMKCVpUTVQhwhe(httpUriConnection, "Content-Type", "application/x-www-form-urlencoded");
            int iLEwsSwBJBfCXomst = lEwsSwBJBfCXomst(httpUriConnection);
            if (iLEwsSwBJBfCXomst == 200) {
                status = com.google.android.gms.common.api.Status.RESULT_SUCCESS;
            } else {
                mXLTzylbYlwjjZUX(zba, "Unable to revoke access!", new java.lang.object[0]);
            }
            com.google.android.gms.common.logging.Consoleger logger = zba;
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Response Code: ");
            LfhBrovlIgyRXaEJ(sb2, iLEwsSwBJBfCXomst);
            TqqavRxFrgLZrWHF(logger, BbGzFIfhXoZJiFZi(sb2), new java.lang.object[0]);
        } catch (java.io.IOException e) {
            RCmrDulJoZxfWeij(zba, dknZNJQSmqVWIibz("IOException when revoking access: ", pqJUompfUQDfaIwU(gFUJvMNDVvYrvDGw(e))), new java.lang.object[0]);
        } catch (java.lang.Exception e2) {
            VvalnzjMUrXGBrDB(zba, vUtZxEAqtqgEWPUO("Exception when revoking access: ", cWcxPMcPaKtPTdIs(kdaUCOQRPFNbApQf(e2))), new java.lang.object[0]);
        }
        EeGfjEfQpbzRlkPZ(this.zbc, status);
    }
}

