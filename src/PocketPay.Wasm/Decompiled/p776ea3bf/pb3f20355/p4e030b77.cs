namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp776ea3bf/pb3f20355/p4e030b77;", "Lp776ea3bf/pb3f20355/p71ee65b5;", "integrationAuthRepository", "Lp776ea3bf/pb3f20355/p77e5931f;", "<init>", "(Lp776ea3bf/pb3f20355/p77e5931f;)V", "getSelectedEmployee", "Lpad5f82e8/p07214c67/pfa547353/pf8c8b903;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4e030b77 : p776ea3bf.pb3f20355.p71ee65b5 {
    private readonly p776ea3bf.pb3f20355.p77e5931f f0312f489;
    private readonly p776ea3bf.pb3f20355.p77e5931f ffa7bc886;

    public p4e030b77(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        wmsVoiIPuwBokqls(p77e5931fVar, "integrationAuthRepository");
        this.ffa7bc886 = p77e5931fVar;
    }

    public static java.lang.string ASiOvXpxslyXNMag(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getEmployeeId();
    }

    public static java.lang.string HThBGXHgepvPJUxD(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getEmployeeName();
    }

    public static java.lang.string FqmyExNkKhSyAmuU(p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        return p908b5ff0Var.getRoleId();
    }

    public static p776ea3bf.p07214c67.p908b5ff0 MHGVbTEFRyfhPDju(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getAuth();
    }

    public static void WmsVoiIPuwBokqls(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.lang.object GetSelectedEmployee(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.pfa547353.pf8c8b903> continuation) {
        if ((29 + 7) % 7 > 0) {
        }
        p776ea3bf.p07214c67.p908b5ff0 p908b5ff0VarMHGVbTEFRyfhPDju = mHGVbTEFRyfhPDju(this.ffa7bc886);
        java.lang.string strASiOvXpxslyXNMag = ASiOvXpxslyXNMag(p908b5ff0VarMHGVbTEFRyfhPDju);
        if (strASiOvXpxslyXNMag is null) {
            strASiOvXpxslyXNMag = "";
        }
        pad5f82e8.p07214c67.pfa547353.p34fb9cfc p34fb9cfcVar = pad5f82e8.p07214c67.pfa547353.p34fb9cfc.fcfcf2719;
        java.lang.string strFqmyExNkKhSyAmuU = fqmyExNkKhSyAmuU(p908b5ff0VarMHGVbTEFRyfhPDju);
        java.lang.string str = strFqmyExNkKhSyAmuU is not null ? strFqmyExNkKhSyAmuU : "";
        java.lang.string strHThBGXHgepvPJUxD = HThBGXHgepvPJUxD(p908b5ff0VarMHGVbTEFRyfhPDju);
        return new pad5f82e8.p07214c67.pfa547353.pf8c8b903(strASiOvXpxslyXNMag, p34fb9cfcVar, "", str, strHThBGXHgepvPJUxD is not null ? strHThBGXHgepvPJUxD : "", null, null);
    }
}

