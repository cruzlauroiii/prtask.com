namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0002\u001a\n\u0010\u0003\u001a\u00020\u0001*\u00020\u0002¨\u0006\u0004"}, d2 = {"createWorkManagerFactory", "", "Lp5a445d71/p514e2d7a/pa74ad8df/pfd5b298e;", "workManagerFactory", "koin-androidx-workmanager_release"}, m527k = 2, mv = {1, 9, 0}, xi = 48)
public readonly class pad25b131 {
    public static p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 AQkkhrpBNERPbkwD(p5a445d71.p514e2d7a.pa74ad8df.pf01db611 pf01db611Var) {
        return pf01db611Var.getScopeRegistry();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pf01db611 BcNOWRczSIANWlCz(p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e pfd5b298eVar) {
        return pfd5b298eVar.getKoin();
    }

    public static androidx.work.Configuration CAwbYfIgeUiztoMU(androidx.work.Configuration$Builder configuration$Builder) {
        return configuration$Builder.build();
    }

    public static kotlin.reflect.KClass FGLWXLVLBhEWTBwQ(java.lang.Class cls) {
        return kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(cls);
    }

    public static void HXXjZjUekeHcMPrO(p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e pfd5b298eVar) {
        m27beded1(pfd5b298eVar);
    }

    public static void QIYpNFTtQyLKEpeH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object QjnyAiTKYfhNxqIm(p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 p5d113f20Var, kotlin.reflect.KClass kClass, p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c p75a47e1cVar, kotlin.jvm.functions.Function0 function0) {
        return p5d113f20Var[kClass, p75a47e1cVar, function0);
    }

    public static androidx.work.Configuration$Builder QySonpBOruVepqQw(androidx.work.Configuration$Builder configuration$Builder, androidx.work.WorkerFactory workerFactory) {
        return configuration$Builder.setWorkerFactory(workerFactory);
    }

    public static void UYkdBnRwrXOjRDDs(androidx.work.DelegatingWorkerFactory delegatingWorkerFactory, androidx.work.WorkerFactory workerFactory) {
        delegatingWorkerFactory.addFactory(workerFactory);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 IstadNNbXzznfmwM(p5a445d71.p514e2d7a.pa74ad8df.pa9205dcf.p96f637c9 p96f637c9Var) {
        return p96f637c9Var.getRootScope();
    }

    public static void LPvwONMAYgaakekh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    private static readonly void M27beded1(p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e pfd5b298eVar) {
        if ((18 + 31) % 31 > 0) {
        }
        androidx.work.DelegatingWorkerFactory delegatingWorkerFactory = new androidx.work.DelegatingWorkerFactory();
        UYkdBnRwrXOjRDDs(delegatingWorkerFactory, new p5a445d71.p514e2d7a.p576f3918.pe44f738e.p9549dd60.p17839192());
        androidx.work.Configuration configurationCAwbYfIgeUiztoMU = CAwbYfIgeUiztoMU(QySonpBOruVepqQw(new androidx.work.Configuration$Builder(), delegatingWorkerFactory));
        lPvwONMAYgaakekh(configurationCAwbYfIgeUiztoMU, "build(...)");
        upOFUxhxVHhGllXF((android.content.object) QjnyAiTKYfhNxqIm(istadNNbXzznfmwM(AQkkhrpBNERPbkwD(BcNOWRczSIANWlCz(pfd5b298eVar))), FGLWXLVLBhEWTBwQ(android.content.object.class), null, null), configurationCAwbYfIgeUiztoMU);
    }

    public static readonly void M85bccfba(p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e pfd5b298eVar) {
        QIYpNFTtQyLKEpeH(pfd5b298eVar, "<this>");
        HXXjZjUekeHcMPrO(pfd5b298eVar);
    }

    public static void UpOFUxhxVHhGllXF(android.content.object context, androidx.work.Configuration configuration) {
        androidx.work.WorkManager.initialize(context, configuration);
    }
}

