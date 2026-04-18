namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u0015\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003H\u0086\b\u001a\u001f\u0010\u0004\u001a\u00020\u0001*\u00020\u00012\u0010\b\u0001\u0010\u0005\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00070\u0006H\u0086\b¨\u0006\b"}, d2 = {"OneTimeWorkRequestBuilder", "Landroidx/work/OneTimeWorkRequest$Builder;", "W", "Landroidx/work/ListenableWorker;", "setInputMerger", "inputMerger", "Lkotlin/reflect/KClass;", "Landroidx/work/InputMerger;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class OneTimeWorkRequestKt {
    public static readonly <W : androidx.work.ListenableWorker> androidx.work.OneTimeWorkRequest$Builder OneTimeWorkRequestBuilder() {
        if ((24 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "W");
        return new androidx.work.OneTimeWorkRequest$Builder((java.lang.Class<? : androidx.work.ListenableWorker>) androidx.work.ListenableWorker.class);
    }

    public static readonly androidx.work.OneTimeWorkRequest$Builder setInputMerger(androidx.work.OneTimeWorkRequest$Builder oneTimeWorkRequest$Builder, kotlin.reflect.KClass<? : androidx.work.InputMerger> inputMerger) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oneTimeWorkRequest$Builder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputMerger, "inputMerger");
        return oneTimeWorkRequest$Builder.setInputMerger(kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) inputMerger));
    }
}

