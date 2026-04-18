namespace WillowMaze.Wasm.Decompiled;

public abstract class Pe55c687b : P4e021fbd
{
    private readonly pc7611810 F22c692d6;
    private readonly p60ad5b1d F5237a940;
    private readonly pc7611810 F621aba59;
    private readonly pc7611810 F634a462e;
    private readonly pc7611810 F78f2c019;
    private readonly pc7611810 F98cf05cd;
    private readonly p60ad5b1d Fc215d3d0;
    private readonly pc3755e61$p1c6e980e Fc9e298d7;
    private readonly pc3755e61$p1c6e980e Fce0cefb5;
    private readonly pc3755e61$p1c6e980e Fdd45daeb;

    private static pdb8ce672 CreateCallAdapter(pb9794896 P0, Method P1, Type P2, Annotation[] P3)
    {
        // str: "Unable to create call adapter for %s"
        // call: pb9794896.callAdapter
        // call: pa470a233.methodError
        return default!;
    }

    private static p60ad5b1d CreateResponseConverter(pb9794896 P0, Method P1, Type P2)
    {
        // str: "Unable to create converter for %s"
        // call: Method.getAnnotations
        // call: pb9794896.responseBodyConverter
        // call: pa470a233.methodError
        return default!;
    }

    private static pe55c687b ParseAnnotations(pb9794896 P0, Method P1, pc7611810 P2)
    {
        // str: "'"
        // str: "Response must include generic type (e.g., Response<String>)"
        // str: "HEAD method must use Void as response type."
        // str: "HEAD"
        // str: "' is not a valid response body type. Did you mean ResponseBody?"
        // call: pa470a233.getParameterLowerBound
        // call: pa470a233.getRawType
        // call: StringBuilder.toString
        // call: pa470a233.getParameterUpperBound
        // call: Method.getGenericReturnType
        // call: Method.getGenericParameterTypes
        // call: StringBuilder.append
        // call: Method.getAnnotations
        // call: pa470a233.methodError
        // call: string.equals
        // call: pdb8ce672.responseType
        // call: pe55c687b$p4f599cd0.<init>
        // call: StringBuilder.<init>
        // call: object.equals
        // call: pe55c687b$p66d94cd6.<init>
        // call: p8527ecfc.ensurePresent
        // call: pe55c687b$paf73347f.<init>
        // call: pe55c687b.createCallAdapter
        // call: pa470a233$p080d319d.<init>
        // call: pe55c687b.createResponseConverter
        // field: paa20ed97.pc7611810.fcb23fab7
        // field: paa20ed97.pc7611810.fdb9c30d5
        // field: paa20ed97.pb9794896.fc9e298d7
        // type: pc3755e61
        // type: Response
        // type: StringBuilder
        // type: void
        // type: pe55c687b$paf73347f
        // type: pd64ed3e9
        // type: pa470a233$p080d319d
        // type: pe55c687b$p4f599cd0
        // type: pe55c687b$p66d94cd6
        return default!;
    }

    private object Adapt(pc3755e61 P0, object[] P1)
    {
        return default!;
    }

    private object Invoke(object[] P0)
    {
        // call: pf83fabfe.<init>
        // call: pe55c687b.adapt
        // field: paa20ed97.pe55c687b.fc9e298d7
        // field: paa20ed97.pe55c687b.f22c692d6
        // field: paa20ed97.pe55c687b.f5237a940
        // type: pf83fabfe
        return default!;
    }

}
