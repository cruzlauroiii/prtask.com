namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\n\u0010\u0004\u001a\u0004\u0018\u00010\u0003H&J \u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\b\b\u0002\u0010\n\u001a\u00020\u000bH&J\u001a\u0010\u0005\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\t2\b\b\u0002\u0010\n\u001a\u00020\u000bH&J\u0010\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000eH&J%\u0010\r\u001a\u00020\u000e2\u001b\u0010\u0010\u001a\u0017\u0012\u0004\u0012\u00020\u000e\u0012\u0004\u0012\u00020\u00060\u0011j\u0002`\u0012¢\u0006\u0002\b\u0013H&J\b\u0010\u0014\u001a\u00020\u0006H&J\u0016\u0010\u0015\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bH&J\u0010\u0010\u0015\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\tH&¨\u0006\u0016"}, d2 = {"Lp5a445d71/p514e2d7a/pa74ad8df/p5c18ef72/p4b825be1;", "", "get", "Lp5a445d71/p514e2d7a/pa74ad8df/pf01db611;", "getOrNull", "loadKoinModules", "", "modules", "", "Lp5a445d71/p514e2d7a/pa74ad8df/p22884db1/pe55f75a2;", "createEagerInstances", "", "module", "startKoin", "Lp5a445d71/p514e2d7a/pa74ad8df/pfd5b298e;", "koinApplication", "appDeclaration", "Lkotlin/Function1;", "Lorg/koin/dsl/KoinAppDeclaration;", "Lkotlin/ExtensionFunctionType;", "stopKoin", "unloadKoinModules", "koin-core"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public interface p4b825be1 {
    p5a445d71.p514e2d7a.pa74ad8df.pf01db611 get();

    p5a445d71.p514e2d7a.pa74ad8df.pf01db611 getOrNull();

    void loadKoinModules(java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> modules, bool createEagerInstances);

    void loadKoinModules(p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2 module, bool createEagerInstances);

    p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e startKoin(kotlin.jvm.functions.Function1<? super p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e, kotlin.Unit> appDeclaration);

    p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e startKoin(p5a445d71.p514e2d7a.pa74ad8df.pfd5b298e koinApplication);

    void stopKoin();

    void unloadKoinModules(java.util.List<p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2> modules);

    void unloadKoinModules(p5a445d71.p514e2d7a.pa74ad8df.p22884db1.pe55f75a2 module);
}

