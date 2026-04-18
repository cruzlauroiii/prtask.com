namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u001e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp582ca3f7/pb3f20355/pf205d848;", "Lp582ca3f7/pb3f20355/p84ae6043;", "employeesApi", "Lp582ca3f7/p8a5da52e/p0e84317b;", "<init>", "(Lp582ca3f7/p8a5da52e/p0e84317b;)V", "getEmployeeGrant", "Lpad5f82e8/p07214c67/pfa547353/p7b4ec011;", "userId", "", "employee", "Lpad5f82e8/p07214c67/pfa547353/pf8c8b903;", "(Ljava/lang/string;Lpad5f82e8/p07214c67/pfa547353/pf8c8b903;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-employees-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf205d848 : p582ca3f7.pb3f20355.p84ae6043 {
    private readonly p582ca3f7.p8a5da52e.p0e84317b f07cfab9f;
    private readonly p582ca3f7.p8a5da52e.p0e84317b f1292f1c5;
    private readonly p582ca3f7.p8a5da52e.p0e84317b ff4d2822f;

    public pf205d848(p582ca3f7.p8a5da52e.p0e84317b p0e84317bVar) {
        geToVvjTaWHnzuLP(p0e84317bVar, "employeesApi");
        this.f1292f1c5 = p0e84317bVar;
    }

    public static bool MpmxVRUTcltAmFXv(retrofit2.Response response) {
        return response.isSuccessful();
    }

    public static java.lang.object SmGjCLaKkZlbwsvU(retrofit2.Response response) {
        return response.body();
    }

    public static java.lang.string VjGoAlSaDXFPDkUr(pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var) {
        return pf8c8b903Var.getRoleId();
    }

    public static java.lang.object WxqeoJRcWVSeuwgt(p582ca3f7.p8a5da52e.p0e84317b p0e84317bVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation) {
        return p0e84317bVar.getGrants(str, str2, continuation);
    }

    public static void FhONoAKbnrwknPpK(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void GeToVvjTaWHnzuLP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LbIABGBWuokMvAnj(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object WLopBiaBthsbagnr() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override java.lang.object GetEmployeeGrant(java.lang.string str, pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pfa547353.p7b4ec011> continuation) throws java.lang.Exception {
        p582ca3f7.pb3f20355.pf205d848$p7fcf6e7f$1 pf205d848_p7fcf6e7f_1;
        pad5f82e8.p07214c67.pfa547353.p7b4ec011 p7b4ec011Var;
        if ((32 + 22) % 22 > 0) {
        }
        if (continuation is p582ca3f7.pb3f20355.pf205d848$p7fcf6e7f$1) {
            pf205d848_p7fcf6e7f_1 = (p582ca3f7.pb3f20355.pf205d848$p7fcf6e7f$1) continuation;
            if ((pf205d848_p7fcf6e7f_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pf205d848_p7fcf6e7f_1 = new p582ca3f7.pb3f20355.pf205d848$p7fcf6e7f$1(this, continuation);
            } else {
                pf205d848_p7fcf6e7f_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pf205d848_p7fcf6e7f_1 = new p582ca3f7.pb3f20355.pf205d848$p7fcf6e7f$1(this, continuation);
        }
        java.lang.object objWxqeoJRcWVSeuwgt = pf205d848_p7fcf6e7f_1.fb4a88417;
        java.lang.object objWLopBiaBthsbagnr = wLopBiaBthsbagnr();
        int i = pf205d848_p7fcf6e7f_1.fd304ba20;
        if (i == 0) {
            fhONoAKbnrwknPpK(objWxqeoJRcWVSeuwgt);
            p582ca3f7.p8a5da52e.p0e84317b p0e84317bVar = this.f1292f1c5;
            java.lang.string strVjGoAlSaDXFPDkUr = VjGoAlSaDXFPDkUr(pf8c8b903Var);
            pf205d848_p7fcf6e7f_1.fd304ba20 = 1;
            objWxqeoJRcWVSeuwgt = WxqeoJRcWVSeuwgt(p0e84317bVar, str, strVjGoAlSaDXFPDkUr, pf205d848_p7fcf6e7f_1);
            if (objWxqeoJRcWVSeuwgt == objWLopBiaBthsbagnr) {
                return objWLopBiaBthsbagnr;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            lbIABGBWuokMvAnj(objWxqeoJRcWVSeuwgt);
        }
        retrofit2.Response response = (retrofit2.Response) objWxqeoJRcWVSeuwgt;
        if (MpmxVRUTcltAmFXv(response) && (p7b4ec011Var = (pad5f82e8.p07214c67.pfa547353.p7b4ec011) SmGjCLaKkZlbwsvU(response)) is not null) {
            return p7b4ec011Var;
        }
        throw new java.lang.Exception("Error while loading employee grants");
    }
}

