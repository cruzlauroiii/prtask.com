namespace WillowMaze.Wasm.Decompiled;

public class ErrorIndication : Cloneable
{
    public static Dictionary<string, object> A;
    private ErrorIndication$L1_Error_Code B;
    private ErrorIndication$L3_Error_Code C;
    private short D;
    private ErrorIndication$L2_Error_Code E;
    private ErrorIndication$MessageId F;
    private string J;

    private byte[] C()
    {
        // call: ErrorIndication$MessageId.getMessageId
        // call: ErrorIndication$L1_Error_Code.getL1Error_Code
        // call: ErrorIndication$L3_Error_Code.getL3Error_Code
        // call: ErrorIndication$L2_Error_Code.getL2Error_Code
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.f
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.d
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.c
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.b
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.e
        return default!;
    }

    private object Clone()
    {
        // call: ErrorIndication.e
        return default!;
    }

    private ErrorIndication E()
    {
        // call: object.clone
        return default!;
    }

    public ErrorIndication$L1_Error_Code GetL1Error()
    {
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.b
        return default!;
    }

    public ErrorIndication$L2_Error_Code GetL2Error()
    {
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.e
        return default!;
    }

    public ErrorIndication$L3_Error_Code GetL3Error()
    {
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.c
        return default!;
    }

    public ErrorIndication$MessageId GetMessageId()
    {
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.f
        return default!;
    }

    public short GetStatusWord()
    {
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.d
        return 0;
    }

    public void SetL1Error(ErrorIndication$L1_Error_Code P0)
    {
        // str: "a"
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Exception.getCause
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.b
    }

    public void SetL2Error(ErrorIndication$L2_Error_Code P0)
    {
        // str: "a"
        // call: Exception.getCause
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.e
    }

    public void SetL3Error(ErrorIndication$L3_Error_Code P0)
    {
        // str: "a"
        // call: Exception.getCause
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.c
    }

    public void SetMessageId(ErrorIndication$MessageId P0)
    {
        // str: "a"
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Exception.getCause
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.f
    }

    public void SetStatusWord(short P0)
    {
        // str: "a"
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Exception.getCause
        // field: com.mastercard.terminalsdk.objects.ErrorIndication.d
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public BerTlv ToTLV()
    {
        // str: "cS"
        // str: ""
        // str: "b"
        // call: q.b
        // call: Exception.getCause
        // call: Type.getField
        // call: ErrorIndication.c
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: Tag.<init>
        // call: ByteArrayWrapper.<init>
        // call: BerTlv.<init>
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // type: Tag
        // type: BerTlv
        // type: ByteArrayWrapper
        return default!;
    }

}
