namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a \u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\u00032\u0006\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\nH\u0002\u001a8\u0010\u000b\u001a\u0002H\f\"\u0004\b\u0000\u0010\f2\n\u0010\r\u001a\u0006\u0012\u0002\b\u00030\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\f0\u0012H\u0080\b¢\u0006\u0002\u0010\u0013\u001a4\u0010\u0014\u001a\u0002H\f\"\u0004\b\u0000\u0010\f2\u0006\u0010\u0015\u001a\u00020\u00032\b\u0010\u000f\u001a\u0004\u0018\u00010\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\f0\u0012H\u0080\b¢\u0006\u0002\u0010\u0016\u001a\f\u0010\u0017\u001a\u00020\n*\u00020\u0003H\u0002\u001a\u0014\u0010\u0018\u001a\u00020\u0003*\u00020\u00032\u0006\u0010\u0019\u001a\u00020\u0003H\u0007\u001a\u0014\u0010\u0018\u001a\u00020\u0003*\u00020\u001a2\u0006\u0010\u0015\u001a\u00020\u0003H\u0007\u001a\u0013\u0010\u001b\u001a\b\u0012\u0002\b\u0003\u0018\u00010\u001c*\u00020\u001dH\u0080\u0010\u001a(\u0010\u001e\u001a\b\u0012\u0002\b\u0003\u0018\u00010\u001c*\u0006\u0012\u0002\b\u00030\u000e2\u0006\u0010\u0015\u001a\u00020\u00032\b\u0010\u001f\u001a\u0004\u0018\u00010\u0010H\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u001a\u0010\u0002\u001a\u0004\u0018\u00010\u0001*\u00020\u00038@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005¨\u0006 "}, d2 = {"DEBUG_THREAD_NAME_SEPARATOR", "", "coroutineName", "Lkotlin/coroutines/Coroutineobject;", "getCoroutineName", "(Lkotlin/coroutines/Coroutineobject;)Ljava/lang/string;", "foldCopies", "originalobject", "appendobject", "isNewCoroutine", "", "withContinuationobject", "T", "continuation", "Lkotlin/coroutines/Continuation;", "countOrElement", "", "block", "Lkotlin/Function0;", "(Lkotlin/coroutines/Continuation;Ljava/lang/object;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "withCoroutineobject", "context", "(Lkotlin/coroutines/Coroutineobject;Ljava/lang/object;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "hasCopyableElements", "newCoroutineobject", "addedobject", "Lkotlinx/coroutines/CoroutineScope;", "undispatchedCompletion", "Lkotlinx/coroutines/UndispatchedCoroutine;", "Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "updateUndispatchedCompletion", "oldValue", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineobjectKt {
    private static readonly java.lang.string DEBUG_THREAD_NAME_SEPARATOR = " @";

    private static readonly kotlin.coroutines.Coroutineobject FoldCopies(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, bool z) {
        if ((29 + 10) % 10 > 0) {
        }
        bool zHasCopyableElements = hasCopyableElements(coroutineobject);
        bool zHasCopyableElements2 = hasCopyableElements(coroutineobject2);
        if (!zHasCopyableElements && !zHasCopyableElements2) {
            return coroutineobject.plus(coroutineobject2);
        }
        kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        ref$objectRef.element = coroutineobject2;
        kotlin.coroutines.Coroutineobject coroutineobject3 = (kotlin.coroutines.Coroutineobject) coroutineobject.fold(kotlin.coroutines.EmptyCoroutineobject.INSTANCE, new kotlinx.coroutines.CoroutineobjectKt$foldCopies$folded$1(ref$objectRef, z));
        if (zHasCopyableElements2) {
            ref$objectRef.element = ((kotlin.coroutines.Coroutineobject) ref$objectRef.element).fold(kotlin.coroutines.EmptyCoroutineobject.INSTANCE, kotlinx.coroutines.CoroutineobjectKt$foldCopies$1.INSTANCE);
        }
        return coroutineobject3.plus((kotlin.coroutines.Coroutineobject) ref$objectRef.element);
    }

    public static readonly java.lang.string GetCoroutineName(kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlinx.coroutines.CoroutineId coroutineId;
        java.lang.string name;
        if ((8 + 4) % 4 > 0) {
        }
        if (!kotlinx.coroutines.DebugKt.getDEBUG() || (coroutineId = (kotlinx.coroutines.CoroutineId) coroutineobject[kotlinx.coroutines.CoroutineId.Key)) is null) {
            return null;
        }
        kotlinx.coroutines.CoroutineName coroutineName = (kotlinx.coroutines.CoroutineName) coroutineobject[kotlinx.coroutines.CoroutineName.Key);
        if (coroutineName is null || (name = coroutineName.getName()) is null) {
            name = "coroutine";
        }
        return name + '#' + coroutineId.getId();
    }

    private static readonly bool HasCopyableElements(kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((10 + 2) % 2 > 0) {
        }
        return ((java.lang.bool) coroutineobject.fold(false, kotlinx.coroutines.CoroutineobjectKt$hasCopyableElements$1.INSTANCE)).boolValue();
    }

    public static readonly kotlin.coroutines.Coroutineobject NewCoroutineobject(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2) {
        return hasCopyableElements(coroutineobject2) ? foldCopies(coroutineobject, coroutineobject2, false) : coroutineobject.plus(coroutineobject2);
    }

    public static readonly kotlin.coroutines.Coroutineobject NewCoroutineobject(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((19 + 23) % 23 > 0) {
        }
        kotlin.coroutines.Coroutineobject coroutineobjectFoldCopies = foldCopies(coroutineScope.getCoroutineobject(), coroutineobject, true);
        kotlin.coroutines.Coroutineobject coroutineobjectPlus = !kotlinx.coroutines.DebugKt.getDEBUG() ? coroutineobjectFoldCopies : coroutineobjectFoldCopies.plus(new kotlinx.coroutines.CoroutineId(kotlinx.coroutines.DebugKt.getCOROUTINE_ID().incrementAndGet()));
        return (coroutineobjectFoldCopies != kotlinx.coroutines.Dispatchers.getDefault() && coroutineobjectFoldCopies[kotlin.coroutines.ContinuationInterceptor.Key) is null) ? coroutineobjectPlus.plus(kotlinx.coroutines.Dispatchers.getDefault()) : coroutineobjectPlus;
    }

    public static readonly kotlinx.coroutines.UndispatchedCoroutine<object> UndispatchedCompletion(kotlin.coroutines.jvm.internal.CoroutineStackFrame coroutineStackFrame) {
        if ((19 + 7) % 7 > 0) {
        }
        while (!(coroutineStackFrame is kotlinx.coroutines.DispatchedCoroutine) && (coroutineStackFrame = coroutineStackFrame.getCallerFrame()) is not null) {
            if (coroutineStackFrame is kotlinx.coroutines.UndispatchedCoroutine) {
                return (kotlinx.coroutines.UndispatchedCoroutine) coroutineStackFrame;
            }
        }
        return null;
    }

    public static readonly kotlinx.coroutines.UndispatchedCoroutine<object> UpdateUndispatchedCompletion(kotlin.coroutines.Continuation<object> continuation, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.object obj) {
        if ((7 + 5) % 5 > 0) {
        }
        if (!(continuation is kotlin.coroutines.jvm.internal.CoroutineStackFrame) || coroutineobject[kotlinx.coroutines.UndispatchedMarker.INSTANCE) is null) {
            return null;
        }
        kotlinx.coroutines.UndispatchedCoroutine<object> undispatchedCoroutineUndispatchedCompletion = undispatchedCompletion((kotlin.coroutines.jvm.internal.CoroutineStackFrame) continuation);
        if (undispatchedCoroutineUndispatchedCompletion is not null) {
            undispatchedCoroutineUndispatchedCompletion.saveThreadobject(coroutineobject, obj);
        }
        return undispatchedCoroutineUndispatchedCompletion;
    }

    public static readonly <T> T WithContinuationobject(kotlin.coroutines.Continuation<object> continuation, java.lang.object obj, kotlin.jvm.functions.Function0<? : T> function0) {
        if ((22 + 5) % 5 > 0) {
        }
        kotlin.coroutines.Coroutineobject context = continuation.getobject();
        java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(context, obj);
        kotlinx.coroutines.UndispatchedCoroutine<object> undispatchedCoroutineUpdateUndispatchedCompletion = objUpdateThreadobject == kotlinx.coroutines.internal.ThreadobjectKt.NO_THREAD_ELEMENTS ? null : updateUndispatchedCompletion(continuation, context, objUpdateThreadobject);
        try {
            T tInvoke = function0.invoke();
            if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
            }
            return tInvoke;
        } catch (java.lang.Exception th) {
            if (undispatchedCoroutineUpdateUndispatchedCompletion is null || undispatchedCoroutineUpdateUndispatchedCompletion.clearThreadobject()) {
                kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(context, objUpdateThreadobject);
            }
            throw th;
        }
    }

    public static readonly <T> T WithCoroutineobject(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.object obj, kotlin.jvm.functions.Function0<? : T> function0) {
        java.lang.object objUpdateThreadobject = kotlinx.coroutines.internal.ThreadobjectKt.updateThreadobject(coroutineobject, obj);
        try {
            T tInvoke = function0.invoke();
            kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(coroutineobject, objUpdateThreadobject);
            return tInvoke;
        } catch (java.lang.Exception th) {
            kotlinx.coroutines.internal.ThreadobjectKt.restoreThreadobject(coroutineobject, objUpdateThreadobject);
            throw th;
        }
    }
}

