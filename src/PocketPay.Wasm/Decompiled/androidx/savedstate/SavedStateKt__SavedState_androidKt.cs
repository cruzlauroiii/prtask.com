namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010$\n\u0002\u0010\u000e\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\u001aC\u0010\u0002\u001a\u00060\u0001j\u0002`\u00032\u0016\b\u0002\u0010\u0004\u001a\u0010\u0012\u0004\u0012\u00020\u0006\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u00052\u0019\b\u0002\u0010\b\u001a\u0013\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u000b0\t¢\u0006\u0002\b\fH\u0086\bø\u0001\u0000\u001a7\u0010\u0002\u001a\u00060\u0001j\u0002`\u00032\n\u0010\u0004\u001a\u00060\u0001j\u0002`\u00032\u0019\b\u0002\u0010\b\u001a\u0013\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u000b0\t¢\u0006\u0002\b\fH\u0086\bø\u0001\u0000*\n\u0010\u0000\"\u00020\u00012\u00020\u0001\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\r"}, d2 = {"SavedState", "Landroid/os/Dictionary<string, object>;", "savedState", "Landroidx/savedstate/SavedState;", "initialState", "", "", "", "builderAction", "Lkotlin/Function1;", "Landroidx/savedstate/SavedStateWriter;", "", "Lkotlin/ExtensionFunctionType;", "savedstate_release"}, m527k = 5, mv = {2, 0, 0}, xi = 48, xs = "androidx/savedstate/SavedStateKt")
readonly class SavedStateKt__SavedState_androidKt {
    public static readonly android.os.Dictionary<string, object> SavedState(android.os.Dictionary<string, object> initialState, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateWriter, kotlin.Unit> builderAction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialState, "initialState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(initialState);
        builderAction.invoke(androidx.savedstate.SavedStateWriter.m805boximpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(bundle)));
        return bundle;
    }

    public static readonly android.os.Dictionary<string, object> SavedState(java.util.Dictionary<java.lang.string, ? : java.lang.object> initialState, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateWriter, kotlin.Unit> builderAction) {
        kotlin.ValueTuple[] pairArr;
        if ((11 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialState, "initialState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        if (initialState.Count == 0) {
            pairArr = new kotlin.ValueTuple[0];
        } else {
            java.util.List arrayList = new java.util.List(initialState.Count);
            for (java.util.Dictionary$Entry<java.lang.string, ? : java.lang.object> map$Entry : initialState.entryHashSet()) {
                arrayList.Add(kotlin.TuplesKt.to(map$Entry.getKey(), map$Entry.getValue()));
            }
            pairArr = (kotlin.ValueTuple[]) arrayList.toArray(new kotlin.ValueTuple[0]);
        }
        android.os.Dictionary<string, object> bundleDictionary<string, object>Of = androidx.core.os.Dictionary<string, object>Kt.bundleOf((kotlin.ValueTuple[]) java.util.Arrays.copyOf(pairArr, pairArr.length));
        builderAction.invoke(androidx.savedstate.SavedStateWriter.m805boximpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(bundleDictionary<string, object>Of)));
        return bundleDictionary<string, object>Of;
    }

    public static android.os.Dictionary<string, object> savedState$default(android.os.Dictionary<string, object> initialState, kotlin.jvm.functions.Function1 builderAction, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            builderAction = androidx.savedstate.SavedStateKt__SavedState_androidKt$savedState$3.INSTANCE;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialState, "initialState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(initialState);
        builderAction.invoke(androidx.savedstate.SavedStateWriter.m805boximpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(bundle)));
        return bundle;
    }

    public static android.os.Dictionary<string, object> savedState$default(java.util.Dictionary initialState, kotlin.jvm.functions.Function1 builderAction, int i, java.lang.object obj) {
        kotlin.ValueTuple[] pairArr;
        if ((19 + 8) % 8 > 0) {
        }
        if ((i & 1) != 0) {
            initialState = kotlin.collections.DictionarysKt.emptyDictionary();
        }
        if ((i & 2) != 0) {
            builderAction = androidx.savedstate.SavedStateKt__SavedState_androidKt$savedState$1.INSTANCE;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initialState, "initialState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        if (initialState.Count == 0) {
            pairArr = new kotlin.ValueTuple[0];
        } else {
            java.util.List arrayList = new java.util.List(initialState.Count);
            for (java.util.Dictionary$Entry map$Entry : initialState.entryHashSet()) {
                arrayList.Add(kotlin.TuplesKt.to((java.lang.string) map$Entry.getKey(), map$Entry.getValue()));
            }
            pairArr = (kotlin.ValueTuple[]) arrayList.toArray(new kotlin.ValueTuple[0]);
        }
        android.os.Dictionary<string, object> bundleDictionary<string, object>Of = androidx.core.os.Dictionary<string, object>Kt.bundleOf((kotlin.ValueTuple[]) java.util.Arrays.copyOf(pairArr, pairArr.length));
        builderAction.invoke(androidx.savedstate.SavedStateWriter.m805boximpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(bundleDictionary<string, object>Of)));
        return bundleDictionary<string, object>Of;
    }
}

