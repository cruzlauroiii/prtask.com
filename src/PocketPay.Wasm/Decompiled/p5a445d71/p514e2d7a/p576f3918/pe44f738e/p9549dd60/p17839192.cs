namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\"\u0010\u0004\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\f"}, d2 = {"Lp5a445d71/p514e2d7a/p576f3918/pe44f738e/p9549dd60/p17839192;", "Landroidx/work/WorkerFactory;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "()V", "createWorker", "Landroidx/work/ListenableWorker;", "appobject", "Landroid/content/object;", "workerClassName", "", "workerParameters", "Landroidx/work/WorkerParameters;", "koin-androidx-workmanager_release"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class p17839192 : androidx.work.WorkerFactory : p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {
    public static void LTSrjpeLHqTNueMz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OeUYTjfPzQApsRyu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.reflect.KClass PAlbRTZHfYrtwgxV(java.lang.Class cls) {
        return kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(cls);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pf01db611 TEbkivsViUytgwdy(p5a445d71.p514e2d7a.p576f3918.pe44f738e.p9549dd60.p17839192 p17839192Var) {
        return p17839192Var.getKoin();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pf01db611 YbWQAbhTcWaOiTES(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar) {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(pcf4be4dfVar);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 ZTEyPiWZfavfSAUf(p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 p96f637c9Var) {
        return p96f637c9Var.getRootScope();
    }

    public static void BnQOjwbQCuCJSuzn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object IBYfVIsSzTXvlEcb(p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 p5d113f20Var, kotlin.reflect.KClass kClass, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0) {
        return p5d113f20Var.getOrNull(kClass, p75a47e1cVar, function0);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 NmkqotYMckWqAmvN(p5a445d71.p514e2d7a.pa74ad8df.pf01db611 pf01db611Var) {
        return pf01db611Var.getScopeRegistry();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 QeuOCRPsqEoPPuYm(java.lang.string str) {
        return p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.pe4fa47c2.m72b49a24(str);
    }

    public override androidx.work.ListenableWorker CreateWorker(android.content.object appobject, java.lang.string workerClassName, androidx.work.WorkerParameters workerParameters) {
        LTSrjpeLHqTNueMz(appobject, "appobject");
        OeUYTjfPzQApsRyu(workerClassName, "workerClassName");
        bnQOjwbQCuCJSuzn(workerParameters, "workerParameters");
        p5a445d71.p514e2d7a.pa74ad8df.pf01db611 pf01db611VarTEbkivsViUytgwdy = TEbkivsViUytgwdy(this);
        return (androidx.work.ListenableWorker) iBYfVIsSzTXvlEcb(ZTEyPiWZfavfSAUf(nmkqotYMckWqAmvN(pf01db611VarTEbkivsViUytgwdy)), PAlbRTZHfYrtwgxV(androidx.work.ListenableWorker.class), qeuOCRPsqEoPPuYm(workerClassName), new p5a445d71.p514e2d7a.p576f3918.pe44f738e.p9549dd60.p17839192$p41382424$1(workerParameters));
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return YbWQAbhTcWaOiTES(this);
    }
}

