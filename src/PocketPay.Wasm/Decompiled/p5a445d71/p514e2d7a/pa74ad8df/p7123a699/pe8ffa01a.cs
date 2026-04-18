namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0002\u0010\u0005J\u0012\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\u0016J\b\u0010\n\u001a\u00020\u0007H\u0016J\u0015\u0010\u000b\u001a\u00028\u00002\u0006\u0010\f\u001a\u00020\rH\u0016¢\u0006\u0002\u0010\u000eJ\u0012\u0010\u000f\u001a\u00020\u00102\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0016¨\u0006\u0011"}, d2 = {"Lp5a445d71/p514e2d7a/pa74ad8df/p7123a699/pe8ffa01a;", "T", "Lp5a445d71/p514e2d7a/pa74ad8df/p7123a699/p39ffcc1e;", "beanDefinition", "Lp5a445d71/p514e2d7a/pa74ad8df/p30618b3b/p9d6556ac;", "(Lp5a445d71/p514e2d7a/pa74ad8df/p30618b3b/p9d6556ac;)V", "drop", "", "scope", "Lp5a445d71/p514e2d7a/pa74ad8df/p31a1fd14/p5d113f20;", "dropAll", "get", "context", "Lp5a445d71/p514e2d7a/pa74ad8df/p7123a699/p5aa514b0;", "(Lp5a445d71/p514e2d7a/pa74ad8df/p7123a699/p5aa514b0;)Ljava/lang/object;", "isCreated", "", "koin-core"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class pe8ffa01a<T> : org.koin.core.instance.InstanceFactory<T> {
    public pe8ffa01a(org.koin.core.definition.BeanDefinition<T> beanDefinition) {
        super(beanDefinition);
        GxoYNApZUZyRMwxP(beanDefinition, "beanDefinition");
    }

    public static kotlin.jvm.functions.Function1 ARGVuqemjiBGlLAN(p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4 p927620a4Var) {
        return p927620a4Var.getOnClose();
    }

    public static void GxoYNApZUZyRMwxP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object VkUlqejbFFSzrJRc(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.lang.object AamRApxVcmUaXRct(p5a445d71.p514e2d7a.pa74ad8df.p7123a699.pe8ffa01a pe8ffa01aVar, p5a445d71.p514e2d7a.pa74ad8df.p7123a699.p5aa514b0 p5aa514b0Var) {
        return pe8ffa01aVar.create(p5aa514b0Var);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4 HwrnZiPlSoSwVzXq(p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p9d6556ac p9d6556acVar) {
        return p9d6556acVar.getCallbacks();
    }

    public static void LmWaURhxdYhyjVYl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p9d6556ac OJwyxqEzVusNMikQ(p5a445d71.p514e2d7a.pa74ad8df.p7123a699.pe8ffa01a pe8ffa01aVar) {
        return pe8ffa01aVar.getBeanDefinition();
    }

    public void Drop(p5a445d71.p514e2d7a.pa74ad8df.p31a1fd14.p5d113f20 scope) {
        kotlin.jvm.functions.Function1 function1ARGVuqemjiBGlLAN = ARGVuqemjiBGlLAN(hwrnZiPlSoSwVzXq(oJwyxqEzVusNMikQ(this)));
        if (function1ARGVuqemjiBGlLAN is null) {
            return;
        }
        VkUlqejbFFSzrJRc(function1ARGVuqemjiBGlLAN, null);
    }

    public void DropAll() {
    }

    public T Get(p5a445d71.p514e2d7a.pa74ad8df.p7123a699.p5aa514b0 context) {
        lmWaURhxdYhyjVYl(context, "context");
        return (T) aamRApxVcmUaXRct(this, context);
    }

    public bool IsCreated(p5a445d71.p514e2d7a.pa74ad8df.p7123a699.p5aa514b0 context) {
        return false;
    }
}

