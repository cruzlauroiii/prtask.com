namespace WillowMaze.Wasm.Decompiled;

public class ByteArrayWrapper : Cloneable
{
    private static int A;
    private static int B;
    private static long C;
    private byte[] D;
    private bool E;

    private static string A(string P0)
    {
        // call: string.toCharArray
        // call: string.<init>
        // call: m.c
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.c
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // type: string
        return string.Empty;
    }

    public void Append(byte[] P0)
    {
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.d
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
    }

    public ByteArrayWrapper Clone()
    {
        // str: "a"
        // str: "䊴畇槨㭚鷲켓悇킼䮴多蛊뛤궜缻ꜵ鐛蹷鶩앍稥큁뎔ﭻ塋㉕톭ᥒ㦂ᒽ㾐ᾮ盕ᐜ巿﷒墨⨿"
        // call: StringBuilder.append
        // call: string.intern
        // call: CloneNotSupportedException.getMessage
        // call: object.clone
        // call: Exception.getCause
        // call: ByteArrayWrapper.a
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        // type: StringBuilder
        // type: string
        return default!;
    }

    public object Clone()
    {
        // call: ByteArrayWrapper.clone
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: ByteArrayWrapper.getBytes
        // call: Arrays.equals
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        return false;
    }

    public byte[] GetBytes()
    {
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.d
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        return default!;
    }

    public int HashCode()
    {
        // call: Arrays.hashCode
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.d
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        return 0;
    }

    public bool IsEmpty()
    {
        // call: object.hashCode
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.e
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        return false;
    }

    public int Length()
    {
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.d
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        return 0;
    }

    public string ToHexString()
    {
        // call: ByteArrayWrapper.getBytes
        // call: object.hashCode
        // call: ByteUtility.byteArrayToHexString
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        return string.Empty;
    }

    public string ToString()
    {
        // call: object.toString
        // call: object.hashCode
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.a
        // field: com.mastercard.terminalsdk.utility.ByteArrayWrapper.b
        return string.Empty;
    }

}
