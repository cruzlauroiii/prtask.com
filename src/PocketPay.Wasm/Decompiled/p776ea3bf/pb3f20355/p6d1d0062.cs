namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u001c\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t2\u0006\u0010\u000b\u001a\u00020\fH\u0096@¢\u0006\u0002\u0010\rJ\u000e\u0010\u000e\u001a\u00020\u000fH\u0096@¢\u0006\u0002\u0010\u0010R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp776ea3bf/pb3f20355/p6d1d0062;", "Lp776ea3bf/pb3f20355/pda65ae8b;", "integrationApi", "Lp776ea3bf/p8a5da52e/p754de71f;", "integrationAuthRepository", "Lp776ea3bf/pb3f20355/p77e5931f;", "<init>", "(Lp776ea3bf/p8a5da52e/p754de71f;Lp776ea3bf/pb3f20355/p77e5931f;)V", "getRemoteDevices", "", "Lp776ea3bf/p07214c67/p3be9dac4;", "userId", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getSelectedDevice", "Lpe0212e54/pf5e638cc/pd77d5e50/p6285e3eb;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6d1d0062 : p776ea3bf.pb3f20355.pda65ae8b {
    private readonly p776ea3bf.pb3f20355.p77e5931f f21351939;
    private readonly p776ea3bf.p8a5da52e.p754de71f f35c01509;
    private readonly p776ea3bf.p8a5da52e.p754de71f f415b3144;
    private readonly p776ea3bf.p8a5da52e.p754de71f f43c33be6;
    private readonly p776ea3bf.pb3f20355.p77e5931f f8f2dda37;
    private readonly p776ea3bf.p8a5da52e.p754de71f fb84a1ce8;
    private readonly p776ea3bf.pb3f20355.p77e5931f fc3d7d932;
    private readonly p776ea3bf.pb3f20355.p77e5931f ffa7bc886;

    public p6d1d0062(p776ea3bf.p8a5da52e.p754de71f p754de71fVar, p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        wffWZOMNaOvDuaTL(p754de71fVar, "integrationApi");
        aIylDaAyfSleuVkT(p77e5931fVar, "integrationAuthRepository");
        this.f415b3144 = p754de71fVar;
        this.ffa7bc886 = p77e5931fVar;
    }

    public static bool APjHKigCvBBQSrjv(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.string CWnXJeWGBghlPFXJ(pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880 p13fc8880Var) {
        return p13fc8880Var.getDeviceId();
    }

    public static bool CjpIlaLAMiEXGwMM(retrofit2.Response response) {
        return response.isSuccessful();
    }

    public static java.lang.string IfANChzklFKeEcEe(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getUserId();
    }

    public static java.lang.object LVyMDhaUntGdFzFp() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void LjfOSJzaeqQAwgRL(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string NhjrqDyxmTamEzNO(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getDeviceId();
    }

    public static java.util.List NlfDClEmCEJJgwIs() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static int RQBtlJkZbjKKmNLE(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.lang.object SxGTAnwkTMRyXjsG(p776ea3bf.p8a5da52e.p754de71f p754de71fVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p754de71fVar.getDevices(str, continuation);
    }

    public static java.lang.bool YlBkOXhYsGPEiNsZ(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static void AIylDaAyfSleuVkT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string AkCOwDaawDkoIdVR(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string BhpIfDwFgvnqWADm(pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880 p13fc8880Var) {
        return p13fc8880Var.getShopId();
    }

    public static java.lang.string DHQCLJuIjJEDhrYm(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getShopId();
    }

    public static java.lang.string KIoprJBXtMMmBEGf(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getDeviceUuid();
    }

    public static void QLRfutdQeAIVaaTa(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string QwuKMwsUfLCWFpNH(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getDeviceName();
    }

    public static java.lang.object RpKpymrhXyMLGYNk(retrofit2.Response response) {
        return response.body();
    }

    public static bool SEDwbXXUXiGoIKho(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator SGrHUJxeEVkkvEIF(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static p776ea3bf.p07214c67.p908b5ff0 VpiusqYrhLhYnprt(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getAuth();
    }

    public static java.lang.object VvpwmxEJgeRpCzJX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void WffWZOMNaOvDuaTL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string XcrRumxIXgyiginP(pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880 p13fc8880Var) {
        return p13fc8880Var.getId();
    }

    public override java.lang.object GetRemoteDevices(java.lang.string str, kotlin.coroutines.Continuation<? super java.util.List<p776ea3bf.p07214c67.p3be9dac4>> continuation) throws java.lang.Exception {
        p776ea3bf.pb3f20355.p6d1d0062$p9b47ed42$1 p6d1d0062_p9b47ed42_1;
        java.util.List list;
        if ((15 + 10) % 10 > 0) {
        }
        if (continuation is p776ea3bf.pb3f20355.p6d1d0062$p9b47ed42$1) {
            p6d1d0062_p9b47ed42_1 = (p776ea3bf.pb3f20355.p6d1d0062$p9b47ed42$1) continuation;
            if ((p6d1d0062_p9b47ed42_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p6d1d0062_p9b47ed42_1 = new p776ea3bf.pb3f20355.p6d1d0062$p9b47ed42$1(this, continuation);
            } else {
                p6d1d0062_p9b47ed42_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p6d1d0062_p9b47ed42_1 = new p776ea3bf.pb3f20355.p6d1d0062$p9b47ed42$1(this, continuation);
        }
        java.lang.object objSxGTAnwkTMRyXjsG = p6d1d0062_p9b47ed42_1.fb4a88417;
        java.lang.object objLVyMDhaUntGdFzFp = LVyMDhaUntGdFzFp();
        int i = p6d1d0062_p9b47ed42_1.fd304ba20;
        if (i == 0) {
            qLRfutdQeAIVaaTa(objSxGTAnwkTMRyXjsG);
            p776ea3bf.p8a5da52e.p754de71f p754de71fVar = this.f415b3144;
            p6d1d0062_p9b47ed42_1.fd304ba20 = 1;
            objSxGTAnwkTMRyXjsG = SxGTAnwkTMRyXjsG(p754de71fVar, str, p6d1d0062_p9b47ed42_1);
            if (objSxGTAnwkTMRyXjsG == objLVyMDhaUntGdFzFp) {
                return objLVyMDhaUntGdFzFp;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            LjfOSJzaeqQAwgRL(objSxGTAnwkTMRyXjsG);
        }
        retrofit2.Response response = (retrofit2.Response) objSxGTAnwkTMRyXjsG;
        if (!CjpIlaLAMiEXGwMM(response) || (list = (java.util.List) rpKpymrhXyMLGYNk(response)) is null) {
            throw new java.lang.IllegalStateException(akCOwDaawDkoIdVR("error while loading devices"));
        }
        java.util.List list2 = list;
        java.util.List arrayList = new java.util.List(RQBtlJkZbjKKmNLE(list2, 10));
        java.util.IEnumerator itSGrHUJxeEVkkvEIF = sGrHUJxeEVkkvEIF(list2);
        while (sEDwbXXUXiGoIKho(itSGrHUJxeEVkkvEIF)) {
            pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880 p13fc8880Var = (pe0212e54.pf5e638cc.pcf1e8c14.p13fc8880) vvpwmxEJgeRpCzJX(itSGrHUJxeEVkkvEIF);
            java.lang.string strXcrRumxIXgyiginP = xcrRumxIXgyiginP(p13fc8880Var);
            if (strXcrRumxIXgyiginP is null) {
                strXcrRumxIXgyiginP = "";
            }
            java.lang.string strCWnXJeWGBghlPFXJ = CWnXJeWGBghlPFXJ(p13fc8880Var);
            if (strCWnXJeWGBghlPFXJ is null) {
                strCWnXJeWGBghlPFXJ = "";
            }
            java.lang.string strBhpIfDwFgvnqWADm = bhpIfDwFgvnqWADm(p13fc8880Var);
            APjHKigCvBBQSrjv(arrayList, new p776ea3bf.p07214c67.p3be9dac4(strXcrRumxIXgyiginP, strCWnXJeWGBghlPFXJ, strBhpIfDwFgvnqWADm is not null ? strBhpIfDwFgvnqWADm : ""));
        }
        return arrayList;
    }

    public override java.lang.object GetSelectedDevice(kotlin.coroutines.Continuation<pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb> continuation) {
        if ((7 + 21) % 21 > 0) {
        }
        p776ea3bf.p07214c67.p908b5ff0 p908b5ff0VarVpiusqYrhLhYnprt = vpiusqYrhLhYnprt(this.ffa7bc886);
        java.lang.string strKIoprJBXtMMmBEGf = kIoprJBXtMMmBEGf(p908b5ff0VarVpiusqYrhLhYnprt);
        java.lang.string str = strKIoprJBXtMMmBEGf is not null ? strKIoprJBXtMMmBEGf : "";
        java.lang.string strNhjrqDyxmTamEzNO = NhjrqDyxmTamEzNO(p908b5ff0VarVpiusqYrhLhYnprt);
        return new pe0212e54.pf5e638cc.pd77d5e50.p6285e3eb(strNhjrqDyxmTamEzNO is not null ? strNhjrqDyxmTamEzNO : "", str, IfANChzklFKeEcEe(p908b5ff0VarVpiusqYrhLhYnprt), dHQCLJuIjJEDhrYm(p908b5ff0VarVpiusqYrhLhYnprt), null, null, qwuKMwsUfLCWFpNH(p908b5ff0VarVpiusqYrhLhYnprt), pad5f82e8.p07214c67.pe0212e54.p9d21d731.f86d1debf, null, null, null, null, null, NlfDClEmCEJJgwIs(), null, pad5f82e8.p07214c67.pe0212e54.p854660d3.f54b4c407, YlBkOXhYsGPEiNsZ(true));
    }
}

