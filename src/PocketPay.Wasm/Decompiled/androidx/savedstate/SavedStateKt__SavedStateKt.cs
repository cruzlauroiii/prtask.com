namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a8\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00060\u0002j\u0002`\u00032\u0017\u0010\u0004\u001a\u0013\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u0002H\u00010\u0005¢\u0006\u0002\b\u0007H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\b\u001a8\u0010\t\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00060\u0002j\u0002`\u00032\u0017\u0010\u0004\u001a\u0013\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u0002H\u00010\u0005¢\u0006\u0002\b\u0007H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\b\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u000b"}, d2 = {"read", "T", "Landroid/os/Dictionary<string, object>;", "Landroidx/savedstate/SavedState;", "block", "Lkotlin/Function1;", "Landroidx/savedstate/SavedStateReader;", "Lkotlin/ExtensionFunctionType;", "(Landroid/os/Dictionary<string, object>;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "write", "Landroidx/savedstate/SavedStateWriter;", "savedstate_release"}, m527k = 5, mv = {2, 0, 0}, xi = 48, xs = "androidx/savedstate/SavedStateKt")
readonly class SavedStateKt__SavedStateKt {
    public static readonly <T> T Read(android.os.Dictionary<string, object> bundle, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateReader, ? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bundle, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return block.invoke(androidx.savedstate.SavedStateReader.m720boximpl(androidx.savedstate.SavedStateReader.m721constructorimpl(bundle)));
    }

    public static readonly <T> T Write(android.os.Dictionary<string, object> bundle, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateWriter, ? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bundle, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return block.invoke(androidx.savedstate.SavedStateWriter.m805boximpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(bundle)));
    }
}

