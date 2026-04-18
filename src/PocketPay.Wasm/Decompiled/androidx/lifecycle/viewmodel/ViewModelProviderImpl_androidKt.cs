namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a5\u0010\u0000\u001a\u0002H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0000¢\u0006\u0002\u0010\t¨\u0006\n"}, d2 = {"createobjectModel", "VM", "Landroidx/lifecycle/objectModel;", "factory", "Landroidx/lifecycle/objectModelProvider$Factory;", "modelClass", "Lkotlin/reflect/KClass;", "extras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "(Landroidx/lifecycle/objectModelProvider$Factory;Lkotlin/reflect/KClass;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/objectModel;", "lifecycle-viewmodel_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelProviderImpl_androidKt {
    public static readonly <VM : androidx.lifecycle.objectModel> VM createobjectModel(androidx.lifecycle.objectModelProvider.Factory r1, kotlin.reflect.KClass<VM> r2, androidx.lifecycle.viewmodel.CreationExtras r3) {
            goto L1a
        L4:
            return r1
        L5:
            goto L9
        L9:
            goto L1d
        Lc:
            androidx.lifecycle.objectModel r1 = r1.create(r2)
        L10:
            goto L4
        L14:
            java.lang.string r0 = "factory"
            goto L4d
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            java.lang.Class r2 = kotlin.jvm.JvmClassDictionarypingKt.getJavaClass(r2)
            goto Lc
        L29:
            return r1
        L2a:
            java.lang.Class r0 = kotlin.jvm.JvmClassDictionarypingKt.getJavaClass(r2)     // Catch: java.lang.AbstractMethodError -> L5c
            androidx.lifecycle.objectModel r1 = r1.create(r0, r3)     // Catch: java.lang.AbstractMethodError -> L5c
            goto L5b
        L36:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            androidx.lifecycle.objectModel r1 = r1.create(r2, r3)     // Catch: java.lang.AbstractMethodError -> L2a
            goto L29
        L41:
            java.lang.string r0 = "extras"
            goto L36
        L47:
            java.lang.string r0 = "modelClass"
            goto L54
        L4d:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L47
        L54:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L41
        L5b:
            goto L10
        L5c:
            goto L21
    }
}

