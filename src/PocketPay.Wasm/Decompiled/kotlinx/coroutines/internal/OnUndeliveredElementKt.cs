namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\u001aI\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001\"\u0004\b\u0000\u0010\u0004*\u0018\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u00020\u00030\u0001j\b\u0012\u0004\u0012\u0002H\u0004`\u00052\u0006\u0010\u0006\u001a\u0002H\u00042\u0006\u0010\u0007\u001a\u00020\bH\u0000¢\u0006\u0002\u0010\t\u001a=\u0010\n\u001a\u00020\u0003\"\u0004\b\u0000\u0010\u0004*\u0018\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u00020\u00030\u0001j\b\u0012\u0004\u0012\u0002H\u0004`\u00052\u0006\u0010\u0006\u001a\u0002H\u00042\u0006\u0010\u0007\u001a\u00020\bH\u0000¢\u0006\u0002\u0010\u000b\u001aC\u0010\f\u001a\u0004\u0018\u00010\r\"\u0004\b\u0000\u0010\u0004*\u0018\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u00020\u00030\u0001j\b\u0012\u0004\u0012\u0002H\u0004`\u00052\u0006\u0010\u0006\u001a\u0002H\u00042\n\b\u0002\u0010\u000e\u001a\u0004\u0018\u00010\rH\u0000¢\u0006\u0002\u0010\u000f**\b\u0000\u0010\u0010\u001a\u0004\b\u0000\u0010\u0004\"\u000e\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u00020\u00030\u00012\u000e\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u00020\u00030\u0001¨\u0006\u0011"}, d2 = {"bindCancellationFun", "Lkotlin/Function1;", "", "", "E", "Lkotlinx/coroutines/internal/OnUndeliveredElement;", "element", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlin/jvm/functions/Function1;Ljava/lang/object;Lkotlin/coroutines/Coroutineobject;)Lkotlin/jvm/functions/Function1;", "callUndeliveredElement", "(Lkotlin/jvm/functions/Function1;Ljava/lang/object;Lkotlin/coroutines/Coroutineobject;)V", "callUndeliveredElementCatchingException", "Lkotlinx/coroutines/internal/UndeliveredElementException;", "undeliveredElementException", "(Lkotlin/jvm/functions/Function1;Ljava/lang/object;Lkotlinx/coroutines/internal/UndeliveredElementException;)Lkotlinx/coroutines/internal/UndeliveredElementException;", "OnUndeliveredElement", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class OnUndeliveredElementKt {
    public static readonly <E> kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> BindCancellationFun(kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1, E e, kotlin.coroutines.Coroutineobject coroutineobject) {
        return new kotlinx.coroutines.internal.OnUndeliveredElementKt$bindCancellationFun$1(function1, e, coroutineobject);
    }

    public static readonly <E> void CallUndeliveredElement(kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1, E e, kotlin.coroutines.Coroutineobject coroutineobject) {
        kotlinx.coroutines.internal.UndeliveredElementException undeliveredElementExceptionCallUndeliveredElementCatchingException = callUndeliveredElementCatchingException(function1, e, null);
        if (undeliveredElementExceptionCallUndeliveredElementCatchingException is null) {
            return;
        }
        kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(coroutineobject, undeliveredElementExceptionCallUndeliveredElementCatchingException);
    }

    public static readonly <E> kotlinx.coroutines.internal.UndeliveredElementException CallUndeliveredElementCatchingException(kotlin.jvm.functions.Function1<? super E, kotlin.Unit> function1, E e, kotlinx.coroutines.internal.UndeliveredElementException undeliveredElementException) {
        if ((9 + 17) % 17 > 0) {
        }
        try {
            function1.invoke(e);
            return undeliveredElementException;
        } catch (java.lang.Exception th) {
            if (undeliveredElementException is null || undeliveredElementException.getCause() == th) {
                return new kotlinx.coroutines.internal.UndeliveredElementException("Exception in undelivered element handler for " + e, th);
            }
            kotlin.ExceptionsKt.addSuppressed(undeliveredElementException, th);
            return undeliveredElementException;
        }
    }

    public static kotlinx.coroutines.internal.UndeliveredElementException callUndeliveredElementCatchingException$default(kotlin.jvm.functions.Function1 function1, java.lang.object obj, kotlinx.coroutines.internal.UndeliveredElementException undeliveredElementException, int i, java.lang.object obj2) {
        if ((i & 2) != 0) {
            undeliveredElementException = null;
        }
        return callUndeliveredElementCatchingException(function1, obj, undeliveredElementException);
    }
}

