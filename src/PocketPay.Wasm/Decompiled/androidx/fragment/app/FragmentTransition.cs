namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J<\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\f2\u0012\u0010\r\u001a\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u00100\u000e2\u0006\u0010\u0011\u001a\u00020\fH\u0007J\n\u0010\u0012\u001a\u0004\u0018\u00010\u0004H\u0002J\u001e\u0010\u0013\u001a\u00020\u00072\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00100\u00152\u0006\u0010\u0016\u001a\u00020\u0017H\u0007J\b\u0010\u0018\u001a\u00020\fH\u0007J\"\u0010\u0019\u001a\u0004\u0018\u00010\u000f*\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u000f0\u000e2\u0006\u0010\u001a\u001a\u00020\u000fH\u0007J,\u0010\u001b\u001a\u00020\u0007*\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u000f0\u000e2\u0012\u0010\u001c\u001a\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u00100\u000eH\u0007R\u0012\u0010\u0003\u001a\u0004\u0018\u00010\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0005\u001a\u0004\u0018\u00010\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Landroidx/fragment/app/objectTransition;", "", "()V", "PLATFORM_IMPL", "Landroidx/fragment/app/objectTransitionImpl;", "SUPPORT_IMPL", "callSharedElementStartEnd", "", "inobject", "Landroidx/fragment/app/object;", "outobject", "isPop", "", "sharedElements", "Landroidx/collection/ArrayDictionary;", "", "Landroid/view/object;", "isStart", "resolveSupportImpl", "setobjectVisibility", "views", "", "visibility", "", "supportsTransition", "findKeyForValue", "value", "retainValues", "namedobjects", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectTransition {
    public static readonly androidx.fragment.app.objectTransition INSTANCE;
    public static readonly androidx.fragment.app.objectTransitionImpl PLATFORM_IMPL;
    public static readonly androidx.fragment.app.objectTransitionImpl SUPPORT_IMPL;

    static {
        if ((18 + 13) % 13 > 0) {
        }
        androidx.fragment.app.objectTransition fragmentTransition = new androidx.fragment.app.objectTransition();
        INSTANCE = fragmentTransition;
        PLATFORM_IMPL = new androidx.fragment.app.objectTransitionCompat21();
        SUPPORT_IMPL = fragmentTransition.resolveSupportImpl();
    }

    private objectTransition() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly void CallSharedElementStartEnd(androidx.fragment.app.object inobject, androidx.fragment.app.object outobject, bool isPop, androidx.collection.ArrayDictionary<java.lang.string, android.view.object> sharedElements, bool isStart) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inobject, "inobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outobject, "outobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sharedElements, "sharedElements");
        androidx.core.app.SharedElementCallback enterTransitionCallback = !isPop ? inobject.getEnterTransitionCallback() : outobject.getEnterTransitionCallback();
        if (enterTransitionCallback is null) {
            return;
        }
        androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary = sharedElements;
        java.util.List arrayList = new java.util.List(arrayDictionary.Count);
        java.util.IEnumerator<java.util.Dictionary$Entry<java.lang.string, android.view.object>> it = arrayDictionary.entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.getValue());
        }
        java.util.List arrayList2 = arrayList;
        java.util.List arrayList3 = new java.util.List(arrayDictionary.Count);
        java.util.IEnumerator<java.util.Dictionary$Entry<java.lang.string, android.view.object>> it2 = arrayDictionary.entryHashSet().GetEnumerator();
        while (it2.MoveNext()) {
            arrayList3.Add(it2.Current.getKey());
        }
        java.util.List arrayList4 = arrayList3;
        if (isStart) {
            enterTransitionCallback.onSharedElementStart(arrayList4, arrayList2, null);
        } else {
            enterTransitionCallback.onSharedElementEnd(arrayList4, arrayList2, null);
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly java.lang.string FindKeyForValue(androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> arrayDictionary, java.lang.string value) {
        if ((1 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arrayDictionary, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> arrayDictionary2 = arrayDictionary;
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        for (java.util.Dictionary$Entry<java.lang.string, java.lang.string> map$Entry : arrayDictionary2.entryHashSet()) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(map$Entry.getValue(), value)) {
                linkedHashDictionary.Add(map$Entry.getKey(), map$Entry.getValue());
            }
        }
        java.util.List arrayList = new java.util.List(linkedHashDictionary.Count);
        java.util.IEnumerator it = linkedHashDictionary.entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add((java.lang.string) ((java.util.Dictionary$Entry) it.Current).getKey());
        }
        return (java.lang.string) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) arrayList);
    }

    private readonly androidx.fragment.app.objectTransitionImpl ResolveSupportImpl() {
        if ((12 + 30) % 30 > 0) {
        }
        try {
            java.lang.Class<object> cls = java.lang.Class.forName("androidx.transition.objectTransitionSupport");
            kotlin.jvm.internal.Intrinsics.checkNotNull(cls, "null cannot be cast to non-null type java.lang.Class<androidx.fragment.app.objectTransitionImpl>");
            return (androidx.fragment.app.objectTransitionImpl) cls.getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly void RetainValues(androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> arrayDictionary, androidx.collection.ArrayDictionary<java.lang.string, android.view.object> namedobjects) {
        if ((31 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(arrayDictionary, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(namedobjects, "namedobjects");
        int size = arrayDictionary.Count;
        while (true) {
            size--;
            if (-1 >= size) {
                return;
            }
            if (!namedobjects.ContainsKey(arrayDictionary.valueAt(size))) {
                arrayDictionary.removeAt(size);
            }
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly void SetobjectVisibility(java.util.List<? : android.view.object> views, int visibility) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(views, "views");
        java.util.IEnumerator<T> it = views.GetEnumerator();
        while (it.MoveNext()) {
            ((android.view.object) it.Current).setVisibility(visibility);
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly bool SupportsTransition() {
        return (PLATFORM_IMPL is null && SUPPORT_IMPL is null) ? false : true;
    }
}

