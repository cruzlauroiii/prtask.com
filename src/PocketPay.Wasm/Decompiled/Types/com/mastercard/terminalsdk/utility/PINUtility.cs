namespace WillowMaze.Wasm.Decompiled;

public abstract class PINUtility
{
    private static int[] A;
    private static int C;
    private static int E;

    private static byte[] B(StringBuilder P0)
    {
        // str: ""
        // call: string.length
        // call: string.concat
        // call: System.arraycopy
        // call: StringBuilder.toString
        // call: PINUtility.isPinValid
        // call: Random.nextInt
        // call: StringBuilder.length
        // call: ByteUtility.hexStringToByteArray
        // call: int.toHexString
        // call: StringBuilder.append
        // call: Random.<init>
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // type: Random
        return default!;
    }

    private static byte[] B(byte[] P0, byte[] P1, int P2)
    {
        // call: System.arraycopy
        // call: ByteUtility.generateRandomBytes
        // call: LibraryCheckedException.<init>
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F42
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F48
        // type: LibraryCheckedException
        return default!;
    }

    private static byte[] C(ByteArrayWrapper P0)
    {
        // str: ""
        // call: string.intern
        // call: StringBuilder.length
        // call: PINUtility.d
        // call: StringBuilder.insert
        // call: StringBuilder.substring
        // call: StringBuilder.delete
        // call: string.replaceAll
        // call: System.arraycopy
        // call: StringBuilder.<init>
        // call: ByteArrayWrapper.toHexString
        // call: ByteUtility.hexStringToByteArray
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // type: StringBuilder
        return default!;
    }

    private static string D(int[] P0, int P1)
    {
        // call: j.c
        // call: int[].clone
        // call: string.<init>
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: com.mastercard.terminalsdk.utility.PINUtility.a
        // type: string
        return string.Empty;
    }

    public static byte[] EncryptOnlinePIN(byte[] P0, byte[] P1, byte[] P2)
    {
        // str: "d"
        // str: "b"
        // call: object.hashCode
        // call: ByteArrayWrapper.getBytes
        // call: LibraryCheckedException.<init>
        // call: Exception.getCause
        // call: ByteUtility.doXOR
        // call: ByteArrayWrapper.<init>
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: PINUtility.c
        // call: int.valueOf
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F42
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: java.lang.Integer.TYPE
        // type: ByteArrayWrapper
        // type: byte[]
        // type: LibraryCheckedException
        return default!;
    }

    public static byte[] EncryptPIN(StringBuilder P0, PublicKey P1, PINUtility$PINFormat P2, byte[] P3, int P4)
    {
        // str: "e"
        // str: "c"
        // call: int.valueOf
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: PINUtility.b
        // call: Exception.getCause
        // call: PINUtility.makePINBlock
        // call: LibraryCheckedException.<init>
        // field: java.lang.Integer.TYPE
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F42
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // type: Key
        // type: byte[]
        // type: LibraryCheckedException
        return default!;
    }

    public static byte[] FormatPINtoFormat0or2(StringBuilder P0, PINUtility$PINFormat P1)
    {
        // call: StringBuilder.append
        // call: PINUtility.isPinValid
        // call: ByteUtility.hexStringToByteArray
        // call: System.arraycopy
        // call: StringBuilder.length
        // call: object.hashCode
        // call: StringBuilder.toString
        // call: PINUtility.d
        // call: string.intern
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility$PINFormat.ISO_Format0
        // field: com.mastercard.terminalsdk.utility.PINUtility$PINFormat.ISO_Format2
        return default!;
    }

    public static byte[] FormatPINtoFormat3(StringBuilder P0, Random P1)
    {
        // str: ""
        // call: System.arraycopy
        // call: PINUtility.isPinValid
        // call: Random.nextInt
        // call: ByteUtility.hexStringToByteArray
        // call: string.concat
        // call: int.toHexString
        // call: StringBuilder.length
        // call: string.length
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        return default!;
    }

    public static PublicKey GetICCPINPublicKey(byte[] P0, byte[] P1, byte[] P2)
    {
        // str: "b"
        // call: object.hashCode
        // call: Exception.getCause
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // type: byte[]
        return default!;
    }

    public static bool IsPinValid(StringBuilder P0)
    {
        // call: StringBuilder.toString
        // call: string.matches
        // call: StringBuilder.length
        // call: LibraryCheckedException.<init>
        // call: PINUtility.d
        // call: string.intern
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F48
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F42
        // type: LibraryCheckedException
        return false;
    }

    public static byte[] MakePINBlock(StringBuilder P0, PINUtility$PINFormat P1)
    {
        // str: "e"
        // call: PINUtility.formatPINtoFormat3
        // call: PINUtility.formatPINtoFormat0or2
        // call: Random.<init>
        // call: do.d
        // call: Field.get
        // call: Type.getField
        // call: PINUtility.b
        // call: PINUtility$PINFormat.ordinal
        // call: ByteUtility.generateRandomBytes
        // field: com.mastercard.terminalsdk.utility.PINUtility.c
        // field: com.mastercard.terminalsdk.utility.PINUtility.e
        // type: Random
        return default!;
    }

}
