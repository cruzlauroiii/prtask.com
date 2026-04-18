namespace WillowMaze.Wasm.Decompiled;

public class Pa14dcc1a_p2b051385_4_2 : P406c70d6
{
    private readonly CancellableContinuation $continuation;

    public void OnFailure(pc3755e61 P0, Exception P1)
    {
        // str: "t"
        // str: "call"
        // call: object.resumeWith
        // call: ResultKt.createFailure
        // call: Intrinsics.checkParameterIsNotNull
        // call: Result.constructor-impl
        // field: kotlin.Result.Companion
        // field: paa20ed97.pa14dcc1a$p2b051385$4$2.$continuation
    }

    public void OnResponse(pc3755e61 P0, Response P1)
    {
        // str: "response"
        // str: "call"
        // call: Response.body
        // call: Result.constructor-impl
        // call: object.resumeWith
        // call: ResultKt.createFailure
        // call: Response.isSuccessful
        // call: p8a8cef05.<init>
        // call: Intrinsics.checkParameterIsNotNull
        // field: paa20ed97.pa14dcc1a$p2b051385$4$2.$continuation
        // field: kotlin.Result.Companion
        // type: p8a8cef05
    }

}
