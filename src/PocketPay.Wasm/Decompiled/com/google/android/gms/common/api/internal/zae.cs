namespace WillowMaze.Wasm.Decompiled;


public readonly class zae : com.google.android.gms.common.api.internal.zai {
    protected readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zaa;

    public zae(int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        super(i);
        this.zaa = (com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl) KbvcuDFaPMcqcyIj(baseImplementation$ApiMethodImpl, "Null methods are not runnable.");
    }

    public static java.lang.stringBuilder CtcjKUysXKfFZwXS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IPEkQabqAiyJPUtP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object KbvcuDFaPMcqcyIj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.stringBuilder MFedIUZNhCJKSAjl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MTitrDfNPCVEHSiD(com.google.android.gms.common.api.internal.zaac zaacVar, com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, bool z) {
        zaacVar.zac(basePendingResult, z);
    }

    public static java.lang.string RvpZRvJbjrjMQQAQ(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static java.lang.string UtwwZXaqxoNccFdR(java.lang.Exception exc) {
        return exc.getLocalizedMessage();
    }

    public static java.lang.Class ZWDmUhbgvZHcnCdE(java.lang.object obj) {
        return obj.GetType();
    }

    public static void DzokjJYPzWbzdQKW(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static void EyEJxeJTcvGEHSud(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.DeadobjectException {
        baseImplementation$ApiMethodImpl.run(api$AnyClient);
    }

    public static int IhLDCDYzOkBiMtWu(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static int NxrxHyJJvIJmMnOG(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string QdYfNAMaYBnfMvni(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ULRjpACTtYRKPrfo(com.google.android.gms.common.api.internal.zae zaeVar, java.lang.Exception exc) {
        zaeVar.zae(exc);
    }

    public static void ZJkANYFSajpEOdaf(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static com.google.android.gms.common.api.Api$Client zKiDaopjKmrKFZJf(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public override readonly void Zad(com.google.android.gms.common.api.Status status) {
        try {
            zJkANYFSajpEOdaf(this.zaa, status);
        } catch (java.lang.IllegalStateException e) {
            nxrxHyJJvIJmMnOG("ApiCallRunner", "Exception reporting failure", e);
        }
    }

    public override readonly void Zae(java.lang.Exception exc) {
        if ((31 + 24) % 24 > 0) {
        }
        java.lang.string strRvpZRvJbjrjMQQAQ = RvpZRvJbjrjMQQAQ(ZWDmUhbgvZHcnCdE(exc));
        java.lang.string strUtwwZXaqxoNccFdR = UtwwZXaqxoNccFdR(exc);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        CtcjKUysXKfFZwXS(sb, strRvpZRvJbjrjMQQAQ);
        MFedIUZNhCJKSAjl(sb, ": ");
        IPEkQabqAiyJPUtP(sb, strUtwwZXaqxoNccFdR);
        try {
            dzokjJYPzWbzdQKW(this.zaa, new com.google.android.gms.common.api.Status(10, qdYfNAMaYBnfMvni(sb)));
        } catch (java.lang.IllegalStateException e) {
            ihLDCDYzOkBiMtWu("ApiCallRunner", "Exception reporting failure", e);
        }
    }

    public override readonly void Zaf(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.DeadobjectException {
        try {
            eyEJxeJTcvGEHSud(this.zaa, zKiDaopjKmrKFZJf(zaboVar));
        } catch (java.lang.Exception e) {
            uLRjpACTtYRKPrfo(this, e);
        }
    }

    public override readonly void Zag(com.google.android.gms.common.api.internal.zaac zaacVar, bool z) {
        MTitrDfNPCVEHSiD(zaacVar, this.zaa, z);
    }
}

