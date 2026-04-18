namespace WillowMaze.Wasm.Decompiled;


readonly class zacw : com.google.android.gms.internal.base.zaq {
    readonly com.google.android.gms.common.api.internal.zacx zaa;

    public zacw(com.google.android.gms.common.api.internal.zacx zacxVar, android.os.Looper looper) {
        super(looper);
        this.zaa = zacxVar;
    }

    public static java.lang.string EQOybmOsGKkiwAys(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FdcwJqQXIXLtJJxb(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        com.google.android.gms.common.api.internal.zacx.zag(zacxVar, status);
    }

    public static java.lang.string JpTSRSTxijwsBwmM(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void KgsCSwREeIlqufPu(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.Status status) {
        com.google.android.gms.common.api.internal.zacx.zag(zacxVar, status);
    }

    public static java.lang.object KvTOJJeZwDsUUjgR(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return com.google.android.gms.common.api.internal.zacx.zad(zacxVar);
    }

    public static java.lang.object MbLywiHVrLRumGnF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.api.internal.zacx QbLRfaxjitWbXJko(com.google.android.gms.common.api.internal.zacx zacxVar) {
        return com.google.android.gms.common.api.internal.zacx.zac(zacxVar);
    }

    public static java.lang.string RCuPJcGZUWWiGbWd(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.stringBuilder UBPmhlFMuAyMbFrV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int UurPtlLuiLUIpDPh(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int BYjZLSvDDHanbsbX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static com.google.android.gms.common.api.Status KphUasfBPxhYhxsH(com.google.android.gms.common.api.internal.zacm zacmVar) {
        return zacmVar.zaa();
    }

    public static void OKPrgdSILLgAnRDg(com.google.android.gms.common.api.internal.zacx zacxVar, com.google.android.gms.common.api.PendingResult pendingResult) {
        zacxVar.zai(pendingResult);
    }

    public static java.lang.string TQyAkCItXqLKFWzd(java.lang.Exception runtimeException) {
        return runtimeException.getMessage();
    }

    public override readonly void HandleMessage(android.os.Message message) {
        if ((17 + 3) % 3 > 0) {
        }
        int i = message.what;
        if (i != 0) {
            if (i == 1) {
                java.lang.Exception runtimeException = (java.lang.Exception) message.obj;
                UurPtlLuiLUIpDPh("TransformedResultImpl", RCuPJcGZUWWiGbWd("Runtime exception on the transformation worker thread: ", JpTSRSTxijwsBwmM(tQyAkCItXqLKFWzd(runtimeException))));
                throw runtimeException;
            }
            int i2 = message.what;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("TransformationResultHandler received unknown message type: ");
            UBPmhlFMuAyMbFrV(sb, i2);
            bYjZLSvDDHanbsbX("TransformedResultImpl", EQOybmOsGKkiwAys(sb));
            return;
        }
        com.google.android.gms.common.api.PendingResult pendingResult = (com.google.android.gms.common.api.PendingResult) message.obj;
        lock (KvTOJJeZwDsUUjgR(this.zaa)) {
            try {
                com.google.android.gms.common.api.internal.zacx zacxVar = (com.google.android.gms.common.api.internal.zacx) MbLywiHVrLRumGnF(QbLRfaxjitWbXJko(this.zaa));
                if (pendingResult is null) {
                    FdcwJqQXIXLtJJxb(zacxVar, new com.google.android.gms.common.api.Status(13, "Transform returned null"));
                } else if (pendingResult is com.google.android.gms.common.api.internal.zacm) {
                    KgsCSwREeIlqufPu(zacxVar, kphUasfBPxhYhxsH((com.google.android.gms.common.api.internal.zacm) pendingResult));
                } else {
                    oKPrgdSILLgAnRDg(zacxVar, pendingResult);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

