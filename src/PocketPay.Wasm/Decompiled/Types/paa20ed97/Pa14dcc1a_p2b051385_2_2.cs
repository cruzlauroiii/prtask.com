namespace WillowMaze.Wasm.Decompiled;

public class Pa14dcc1a_p2b051385_2_2 : P406c70d6
{
    private readonly CancellableContinuation $continuation;

    public void OnFailure(pc3755e61 P0, Exception P1)
    {
        // str: "call"
        // str: "t"
        // call: object.resumeWith
        // call: Intrinsics.checkParameterIsNotNull
        // call: Result.constructor-impl
        // call: ResultKt.createFailure
        // field: kotlin.Result.Companion
        // field: paa20ed97.pa14dcc1a$p2b051385$2$2.$continuation
    }

    public void OnResponse(pc3755e61 P0, Response P1)
    {
        // str: "call"
        // str: "response"
        // str: "call.request().tag(Invocation::class.java)!!"
        // str: "method"
        // str: "Response from "
        // str: " was null but response body type was declared as non-null"
        // str: "method.declaringClass"
        // call: StringBuilder.append
        // call: Intrinsics.throwNpe
        // call: Intrinsics.checkParameterIsNotNull
        // call: p8a8cef05.<init>
        // call: Result.constructor-impl
        // call: pda495869.method
        // call: Response.body
        // call: Type.getName
        // call: Method.getDeclaringClass
        // call: Method.getName
        // call: object.resumeWith
        // call: Intrinsics.checkExpressionValueIsNotNull
        // call: KotlinNullPointerException.<init>
        // call: p15c2d85f.tag
        // call: Response.isSuccessful
        // call: StringBuilder.toString
        // call: ResultKt.createFailure
        // call: pc3755e61.request
        // call: StringBuilder.<init>
        // field: kotlin.Result.Companion
        // field: paa20ed97.pa14dcc1a$p2b051385$2$2.$continuation
        // type: StringBuilder
        // type: KotlinNullPointerException
        // type: p8a8cef05
        // type: pda495869
    }

}
