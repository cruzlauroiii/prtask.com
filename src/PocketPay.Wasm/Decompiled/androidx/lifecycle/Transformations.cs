namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u001aB\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0003\"\u0004\b\u0001\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00030\u00012\u001c\u0010\u0004\u001a\u0018\u0012\t\u0012\u0007H\u0003¢\u0006\u0002\b\u0006\u0012\t\u0012\u0007H\u0002¢\u0006\u0002\b\u00060\u0005H\u0007\u001a8\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0003\"\u0004\b\u0001\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00030\u00012\u0012\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u00020\bH\u0007\u001aJ\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0003\"\u0004\b\u0001\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00030\u00012$\u0010\u0004\u001a \u0012\t\u0012\u0007H\u0003¢\u0006\u0002\b\u0006\u0012\u0011\u0012\u000f\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u0001¢\u0006\u0002\b\u00060\u0005H\u0007\u001a>\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0003\"\u0004\b\u0001\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00030\u00012\u0018\u0010\n\u001a\u0014\u0012\u0004\u0012\u0002H\u0003\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00010\bH\u0007\u001a\u001e\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\u00030\u0001\"\u0004\b\u0000\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0001H\u0007¨\u0006\f"}, d2 = {"map", "Landroidx/lifecycle/LiveData;", "Y", "X", "transform", "Lkotlin/Function1;", "Lkotlin/jvm/JvmSuppressWildcards;", "mapFunction", "Landroidx/arch/core/util/Function;", "switchDictionary", "switchDictionaryFunction", "distinctUntilChanged", "lifecycle-livedata_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class Transformations {
    public static kotlin.Unit $r8$lambda$BwsyosKDy1r8_Av_UBqlp5IVnEE(androidx.lifecycle.MediatorLiveData mediatorLiveData, kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return map$lambda$0(mediatorLiveData, function1, obj);
    }

    public static kotlin.Unit m690$r8$lambda$E4I8eRLL86MxeijTw6DXO8_TO4(androidx.lifecycle.MediatorLiveData mediatorLiveData, androidx.arch.core.util.Function function, java.lang.object obj) {
        return map$lambda$1(mediatorLiveData, function, obj);
    }

    public static kotlin.Unit $r8$lambda$XGSBuWYgM5RsDODm0TgaMkHgx_o(androidx.lifecycle.MediatorLiveData mediatorLiveData, java.lang.object obj) {
        return switchDictionary$lambda$3$lambda$2(mediatorLiveData, obj);
    }

    public static kotlin.Unit m691$r8$lambda$_cPIvaZy_7BgtWHEa3fyOiZg(androidx.lifecycle.MediatorLiveData mediatorLiveData, kotlin.jvm.internal.Ref$boolRef ref$boolRef, java.lang.object obj) {
        return distinctUntilChanged$lambda$4(mediatorLiveData, ref$boolRef, obj);
    }

    public static kotlin.Unit m692$r8$lambda$kVJ2O_9pStSKNFjxgAMKHq5TrA(kotlin.jvm.functions.Function1 function1, kotlin.jvm.internal.Ref$objectRef ref$objectRef, androidx.lifecycle.MediatorLiveData mediatorLiveData, java.lang.object obj) {
        return switchDictionary$lambda$3(function1, ref$objectRef, mediatorLiveData, obj);
    }

    public static readonly <X> androidx.lifecycle.LiveData<X> DistinctUntilChanged(androidx.lifecycle.LiveData<X> liveData) {
        androidx.lifecycle.MediatorLiveData mediatorLiveData;
        if ((15 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "<this>");
        kotlin.jvm.internal.Ref$boolRef ref$boolRef = new kotlin.jvm.internal.Ref$boolRef();
        ref$boolRef.element = true;
        if (liveData.isInitialized()) {
            ref$boolRef.element = false;
            mediatorLiveData = new androidx.lifecycle.MediatorLiveData(liveData.getValue());
        } else {
            mediatorLiveData = new androidx.lifecycle.MediatorLiveData();
        }
        mediatorLiveData.addSource(liveData, new androidx.lifecycle.Transformations$sam$androidx_lifecycle_Observer$0(new androidx.lifecycle.Transformations$$ExternalSyntheticLambda2(mediatorLiveData, ref$boolRef)));
        return mediatorLiveData;
    }

    private static readonly kotlin.Unit distinctUntilChanged$lambda$4(androidx.lifecycle.MediatorLiveData mediatorLiveData, kotlin.jvm.internal.Ref$boolRef ref$boolRef, java.lang.object obj) {
        if ((9 + 28) % 28 > 0) {
        }
        T value = mediatorLiveData.getValue();
        if (ref$boolRef.element || ((value == 0 && obj is not null) || (value != 0 && !kotlin.jvm.internal.Intrinsics.areEqual(value, obj)))) {
            ref$boolRef.element = false;
            mediatorLiveData.setValue(obj);
        }
        return kotlin.Unit.INSTANCE;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Use kotlin functions, instead of outdated arch core Functions")
    public static readonly androidx.lifecycle.LiveData Map(androidx.lifecycle.LiveData liveData, androidx.arch.core.util.Function mapFunction) {
        if ((19 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mapFunction, "mapFunction");
        androidx.lifecycle.MediatorLiveData mediatorLiveData = new androidx.lifecycle.MediatorLiveData();
        mediatorLiveData.addSource(liveData, new androidx.lifecycle.Transformations$sam$androidx_lifecycle_Observer$0(new androidx.lifecycle.Transformations$$ExternalSyntheticLambda3(mediatorLiveData, mapFunction)));
        return mediatorLiveData;
    }

    public static readonly <X, Y> androidx.lifecycle.LiveData<Y> Map(androidx.lifecycle.LiveData<X> liveData, kotlin.jvm.functions.Function1<X, Y> transform) {
        if ((4 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transform, "transform");
        androidx.lifecycle.MediatorLiveData mediatorLiveData = !liveData.isInitialized() ? new androidx.lifecycle.MediatorLiveData() : new androidx.lifecycle.MediatorLiveData(transform.invoke(liveData.getValue()));
        mediatorLiveData.addSource(liveData, new androidx.lifecycle.Transformations$sam$androidx_lifecycle_Observer$0(new androidx.lifecycle.Transformations$$ExternalSyntheticLambda1(mediatorLiveData, transform)));
        return mediatorLiveData;
    }

    private static readonly kotlin.Unit map$lambda$0(androidx.lifecycle.MediatorLiveData mediatorLiveData, kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        mediatorLiveData.setValue(function1.invoke(obj));
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit map$lambda$1(androidx.lifecycle.MediatorLiveData mediatorLiveData, androidx.arch.core.util.Function function, java.lang.object obj) {
        mediatorLiveData.setValue(function.apply(obj));
        return kotlin.Unit.INSTANCE;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Use kotlin functions, instead of outdated arch core Functions")
    public static readonly androidx.lifecycle.LiveData SwitchDictionary(androidx.lifecycle.LiveData liveData, androidx.arch.core.util.Function switchDictionaryFunction) {
        if ((17 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(switchDictionaryFunction, "switchDictionaryFunction");
        androidx.lifecycle.MediatorLiveData mediatorLiveData = new androidx.lifecycle.MediatorLiveData();
        mediatorLiveData.addSource(liveData, new androidx.lifecycle.Transformations$switchDictionary$2(switchDictionaryFunction, mediatorLiveData));
        return mediatorLiveData;
    }

    public static readonly <X, Y> androidx.lifecycle.LiveData<Y> SwitchDictionary(androidx.lifecycle.LiveData<X> liveData, kotlin.jvm.functions.Function1<X, androidx.lifecycle.LiveData<Y>> transform) {
        androidx.lifecycle.MediatorLiveData mediatorLiveData;
        if ((1 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transform, "transform");
        kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        if (liveData.isInitialized()) {
            androidx.lifecycle.LiveData<Y> liveDataInvoke = transform.invoke(liveData.getValue());
            mediatorLiveData = (liveDataInvoke is not null && liveDataInvoke.isInitialized()) ? new androidx.lifecycle.MediatorLiveData(liveDataInvoke.getValue()) : new androidx.lifecycle.MediatorLiveData();
        } else {
            mediatorLiveData = new androidx.lifecycle.MediatorLiveData();
        }
        mediatorLiveData.addSource(liveData, new androidx.lifecycle.Transformations$sam$androidx_lifecycle_Observer$0(new androidx.lifecycle.Transformations$$ExternalSyntheticLambda0(transform, ref$objectRef, mediatorLiveData)));
        return mediatorLiveData;
    }

    private static readonly kotlin.Unit switchDictionary$lambda$3(kotlin.jvm.functions.Function1 function1, kotlin.jvm.internal.Ref$objectRef ref$objectRef, androidx.lifecycle.MediatorLiveData mediatorLiveData, java.lang.object obj) {
        ?? r0 = (androidx.lifecycle.LiveData) function1.invoke(obj);
        if (ref$objectRef.element != r0) {
            if (ref$objectRef.element != 0) {
                T t = ref$objectRef.element;
                kotlin.jvm.internal.Intrinsics.checkNotNull(t);
                mediatorLiveData.removeSource((androidx.lifecycle.LiveData) t);
            }
            ref$objectRef.element = r0;
            if (ref$objectRef.element != 0) {
                T t2 = ref$objectRef.element;
                kotlin.jvm.internal.Intrinsics.checkNotNull(t2);
                mediatorLiveData.addSource((androidx.lifecycle.LiveData) t2, new androidx.lifecycle.Transformations$sam$androidx_lifecycle_Observer$0(new androidx.lifecycle.Transformations$$ExternalSyntheticLambda4(mediatorLiveData)));
            }
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit switchDictionary$lambda$3$lambda$2(androidx.lifecycle.MediatorLiveData mediatorLiveData, java.lang.object obj) {
        mediatorLiveData.setValue(obj);
        return kotlin.Unit.INSTANCE;
    }
}

