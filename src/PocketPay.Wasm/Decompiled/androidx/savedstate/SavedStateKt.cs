namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"androidx/savedstate/SavedStateKt__SavedStateKt", "androidx/savedstate/SavedStateKt__SavedState_androidKt"}, m527k = 4, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateKt {
    public static readonly <T> T Read(android.os.Dictionary<string, object> bundle, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateReader, ? : T> function1) {
        return (T) androidx.savedstate.SavedStateKt__SavedStateKt.read(bundle, function1);
    }

    public static readonly android.os.Dictionary<string, object> SavedState(android.os.Dictionary<string, object> bundle, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateWriter, kotlin.Unit> function1) {
        return androidx.savedstate.SavedStateKt__SavedState_androidKt.savedState(bundle, function1);
    }

    public static readonly android.os.Dictionary<string, object> SavedState(java.util.Dictionary<java.lang.string, ? : java.lang.object> map, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateWriter, kotlin.Unit> function1) {
        return androidx.savedstate.SavedStateKt__SavedState_androidKt.savedState(map, function1);
    }

    public static android.os.Dictionary<string, object> savedState$default(android.os.Dictionary<string, object> bundle, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        return androidx.savedstate.SavedStateKt__SavedState_androidKt.savedState$default(bundle, function1, i, obj);
    }

    public static android.os.Dictionary<string, object> savedState$default(java.util.Dictionary map, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        return androidx.savedstate.SavedStateKt__SavedState_androidKt.savedState$default(map, function1, i, obj);
    }

    public static readonly <T> T Write(android.os.Dictionary<string, object> bundle, kotlin.jvm.functions.Function1<? super androidx.savedstate.SavedStateWriter, ? : T> function1) {
        return (T) androidx.savedstate.SavedStateKt__SavedStateKt.write(bundle, function1);
    }
}

