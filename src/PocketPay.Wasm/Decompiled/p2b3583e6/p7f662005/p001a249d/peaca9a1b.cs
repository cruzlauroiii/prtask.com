namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u0002H\u00010\u0003B#\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00028\u00000\u0006\u0012\u0006\u0010\b\u001a\u00020\u0004¢\u0006\u0004\b\t\u0010\nJ\"\u0010\r\u001a\u00028\u00002\u0006\u0010\u000e\u001a\u00020\u00042\n\u0010\u000f\u001a\u0006\u0012\u0002\b\u00030\u0010H\u0096\u0002¢\u0006\u0002\u0010\u0011R\u001a\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u000b\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\f¨\u0006\u0012"}, d2 = {"Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "T", "Landroidx/viewbinding/objectBinding;", "Lkotlin/properties/ReadOnlyProperty;", "Landroidx/fragment/app/object;", "viewBindingFactory", "Lkotlin/Function1;", "Landroid/view/object;", "fragment", "<init>", "(Lkotlin/jvm/functions/Function1;Landroidx/fragment/app/object;)V", "binding", "Landroidx/viewbinding/objectBinding;", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "(Landroidx/fragment/app/object;Lkotlin/reflect/KProperty;)Landroidx/viewbinding/objectBinding;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peaca9a1b<T : androidx.viewbinding.objectBinding> : kotlin.properties.ReadOnlyProperty<androidx.fragment.app.object, T> {
    private T f001a249d;
    private readonly androidx.fragment.app.object f02e918fc;
    private readonly kotlin.jvm.functions.Function1<android.view.object, T> f03b7e600;
    private androidx.viewbinding.objectBinding f0af394b9;
    private readonly kotlin.jvm.functions.Function1 f0e77dec2;
    private readonly androidx.fragment.app.object f155031e4;
    private readonly androidx.fragment.app.object f6293b618;
    private readonly androidx.fragment.app.object f99530865;
    private readonly androidx.fragment.app.object fa33e8f58;
    private androidx.viewbinding.objectBinding fcbcf2b18;

    public peaca9a1b(kotlin.jvm.functions.Function1<? super android.view.object, ? : T> viewBindingFactory, androidx.fragment.app.object fragment) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewBindingFactory, "viewBindingFactory");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
        this.f03b7e600 = viewBindingFactory;
        this.f02e918fc = fragment;
        fragment.getLifecycle().addObserver(new p2b3583e6.p7f662005.p001a249d.peaca9a1b$1(this));
    }

    public static readonly androidx.fragment.app.object M7b72fb5a(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar) {
        return peaca9a1bVar.f02e918fc;
    }

    public static readonly void Mbe7fe0e0(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.viewbinding.objectBinding viewBinding) {
        peaca9a1bVar.f001a249d = viewBinding;
    }

    public T GetValue2(androidx.fragment.app.object thisRef, kotlin.reflect.KProperty<object> property) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        if (this.f001a249d is null) {
            kotlin.jvm.functions.Function1<android.view.object, T> function1 = this.f03b7e600;
            android.view.object viewRequireobject = thisRef.requireobject();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewRequireobject, "requireobject(...)");
            this.f001a249d = function1.invoke(viewRequireobject);
        }
        T t = this.f001a249d;
        kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type T of utils.delegate.binding.objectobjectBindingDelegate");
        return t;
    }

    public override java.lang.object GetValue(androidx.fragment.app.object fragment, kotlin.reflect.KProperty kProperty) {
        return getValue2(fragment, (kotlin.reflect.KProperty<object>) kProperty);
    }
}

