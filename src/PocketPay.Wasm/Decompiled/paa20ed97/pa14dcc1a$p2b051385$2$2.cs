namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001e\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J$\u0010\b\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\f\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00000\nH\u0016¨\u0006\u000b"}, d2 = {"retrofit2/KotlinExtensions$await$2$2", "Lpaa20ed97/p406c70d6;", "onFailure", "", "call", "Lpaa20ed97/pc3755e61;", "t", "", "onResponse", "response", "Lretrofit2/Response;", "retrofit"}, m527k = 1, mv = {1, 1, 15})
public readonly class pa14dcc1a$p2b051385$2$2<T> : retrofit2.Callback<T> {
    readonly kotlinx.coroutines.CancellableContinuation $continuation;

    pa14dcc1a$p2b051385$2$2(kotlinx.coroutines.CancellableContinuation cancellableContinuation) {
        this.$continuation = cancellableContinuation;
    }

    public void OnFailure(retrofit2.Call<T> call, java.lang.Exception t) {
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(call, "call");
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(t, "t");
        kotlinx.coroutines.CancellableContinuation cancellableContinuation = this.$continuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(t)));
    }

    public void OnResponse(retrofit2.Call<T> call, retrofit2.Response<T> response) {
        if ((20 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(call, "call");
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(response, "response");
        if (!response.isSuccessful()) {
            kotlinx.coroutines.CancellableContinuation cancellableContinuation = this.$continuation;
            paa20ed97.p8a8cef05 p8a8cef05Var = new paa20ed97.p8a8cef05(response);
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(p8a8cef05Var)));
            return;
        }
        T tBody = response.body();
        if (tBody is not null) {
            kotlinx.coroutines.CancellableContinuation cancellableContinuation2 = this.$continuation;
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            cancellableContinuation2.resumeWith(kotlin.Result.m948constructorimpl(tBody));
            return;
        }
        java.lang.object objTag = call.request().tag(paa20ed97.pda495869.class);
        if (objTag is null) {
            kotlin.jvm.internal.Intrinsics.throwNpe();
        }
        kotlin.jvm.internal.Intrinsics.checkExpressionValueIsNotNull(objTag, "call.request().tag(Invocation::class.java)!!");
        java.lang.reflect.Method method = ((paa20ed97.pda495869) objTag).method();
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Response from ");
        kotlin.jvm.internal.Intrinsics.checkExpressionValueIsNotNull(method, "method");
        java.lang.Class<object> declaringClass = method.getDeclaringClass();
        kotlin.jvm.internal.Intrinsics.checkExpressionValueIsNotNull(declaringClass, "method.declaringClass");
        kotlin.KotlinNullPointerException kotlinNullPointerException = new kotlin.KotlinNullPointerException(sb.append(declaringClass.getName()).append('.').append(method.getName()).append(" was null but response body type was declared as non-null").tostring());
        kotlinx.coroutines.CancellableContinuation cancellableContinuation3 = this.$continuation;
        kotlin.Result$Companion result$Companion3 = kotlin.Result.Companion;
        cancellableContinuation3.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(kotlinNullPointerException)));
    }
}

