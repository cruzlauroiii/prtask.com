namespace WillowMaze.Wasm.Decompiled;

public abstract class ByteUtility
{
    private static char A;
    private static char[] B;
    private static int D;
    private static int E;

    public static byte[] A(long P0)
    {
        // call: ByteUtility.hexStringToByteArray
        // call: ByteUtility.c
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return default!;
    }

    public static byte[] A(long P0, int P1)
    {
        // call: System.arraycopy
        // call: ByteUtility.a
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return default!;
    }

    public static byte[] AddDESPadding(byte[] P0, int P1, int P2, int P3)
    {
        // str: "b"
        // str: "a"
        // str: "e"
        // call: LibraryCheckedException.<init>
        // call: Exception.getCause
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Type.getField
        // call: System.arraycopy
        // call: int.valueOf
        // call: bool.booleanValue
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.XCE22
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.XCE21
        // field: java.lang.Integer.TYPE
        // type: LibraryCheckedException
        // type: byte[]
        return default!;
    }

    public static byte[] AsciiStringToByteArray(string P0)
    {
        // call: MemoryStream.toByteArray
        // call: MemoryStream.write
        // call: MemoryStream.<init>
        // call: string.toCharArray
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: MemoryStream
        return default!;
    }

    public static string AsciiStringToHexString(string P0)
    {
        // call: int.toHexString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: string.toCharArray
        // call: StringBuilder.toString
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        return string.Empty;
    }

    public static byte[] BitWiseAnd(byte[] P0, int P1, byte[] P2, int P3, int P4)
    {
        // call: LibraryUncheckedException.<init>
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F46
        // type: LibraryUncheckedException
        return default!;
    }

    public static byte[] BitWiseOr(byte[] P0, int P1, byte[] P2, int P3, int P4)
    {
        // call: LibraryUncheckedException.<init>
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F46
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: LibraryUncheckedException
        return default!;
    }

    public static string ByteArrayToAsciiString(byte[] P0)
    {
        // str: ""
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: StringBuilder
        return string.Empty;
    }

    public static System.Numerics.BigInteger ByteArrayToBigInteger(byte[] P0)
    {
        // str: "{{"
        // call: string.intern
        // call: StringBuilder.append
        // call: ByteUtility.byteArrayToHexString
        // call: StringBuilder.toString
        // call: System.Numerics.BigInteger.<init>
        // call: StringBuilder.<init>
        // call: ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        // type: System.Numerics.BigInteger
        return default!;
    }

    public static string ByteArrayToHexString(byte[] P0)
    {
        // str: ""
        // call: StringBuilder.append
        // call: int.toHexString
        // call: string.toUpperCase
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: StringBuilder
        return string.Empty;
    }

    public static int ByteArrayToInt(byte[] P0)
    {
        // call: byte[].wrap
        // call: LibraryUncheckedException.<init>
        // call: object.hashCode
        // call: byte[].getInt
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F46
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: LibraryUncheckedException
        return 0;
    }

    public static long ByteArrayToLong(byte[] P0)
    {
        // call: byte[].getLong
        // call: System.arraycopy
        // call: byte[].wrap
        // call: LibraryUncheckedException.<init>
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F46
        // type: LibraryUncheckedException
        return 0;
    }

    public static short ByteArrayToShort(byte[] P0)
    {
        // call: LibraryUncheckedException.<init>
        // call: byte[].getShort
        // call: System.arraycopy
        // call: byte[].wrap
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F46
        // type: LibraryUncheckedException
        return 0;
    }

    public static string ByteToHexString(byte P0)
    {
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: int.toHexString
        // call: string.toUpperCase
        // call: StringBuilder.toString
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        return string.Empty;
    }

    public static string C(long P0)
    {
        // str: "_"
        // call: string.toUpperCase
        // call: long.toHexString
        // call: string.intern
        // call: StringBuilder.append
        // call: string.length
        // call: ByteUtility.e
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        return string.Empty;
    }

    public static byte CompareValues(byte[] P0, int P1, byte[] P2, int P3, int P4)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return 0;
    }

    public static byte[] DoXOR(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "e"
        // call: LibraryCheckedException.<init>
        // call: Exception.getCause
        // call: int.valueOf
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: bool.booleanValue
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.XCE21
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: java.lang.Integer.TYPE
        // type: LibraryCheckedException
        // type: byte[]
        return default!;
    }

    private static string E(byte P0, int P1, string P2)
    {
        // call: l.c
        // call: l.d
        // call: l.e
        // call: string.toCharArray
        // call: l.a
        // call: string.<init>
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.b
        // field: com.mastercard.terminalsdk.utility.ByteUtility.a
        // type: string
        return string.Empty;
    }

    public static byte[] E(long P0)
    {
        // str: "	\n\r \n\"	\n\n\r\n	\n\n 		\n  \"\"\n \r"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: ByteUtility.a
        // call: System.arraycopy
        // call: StringBuilder.toString
        // call: ByteUtility.e
        // call: ArrayIndexOutOfBoundsException.<init>
        // call: long.toString
        // call: long.parseLong
        // call: string.intern
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        // type: ArrayIndexOutOfBoundsException
        return default!;
    }

    public static byte[] GenerateRandomBytes(int P0)
    {
        // str: "a"
        // call: object.hashCode
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: LibraryCheckedException.<init>
        // call: System.Security.Cryptography.RandomNumberGenerator.<init>
        // call: byte[].put
        // call: byte[].allocate
        // call: Exception.getCause
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: byte[].getLong
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.XCE11
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.XCE22
        // type: System.Security.Cryptography.RandomNumberGenerator
        // type: LibraryCheckedException
        return default!;
    }

    public static byte[] GetSubByteArray(byte[] P0, int P1)
    {
        // call: ByteUtility.getSubByteArray
        // call: object.hashCode
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return default!;
    }

    public static byte[] GetSubByteArray(byte[] P0, int P1, int P2)
    {
        // call: LibraryUncheckedException.<init>
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F46
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: LibraryUncheckedException
        return default!;
    }

    public static string HexStringToAsciiString(string P0)
    {
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: string.length
        // call: StringBuilder.<init>
        // call: string.substring
        // call: int.parseInt
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        return string.Empty;
    }

    public static byte[] HexStringToByteArray(string P0)
    {
        // call: string.substring
        // call: int.parseInt
        // call: ByteUtility.isHexString
        // call: string.length
        // call: LibraryUncheckedException.<init>
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F63
        // type: LibraryUncheckedException
        return default!;
    }

    public static ByteArrayWrapper IntToBerEncodedFixedLength(int P0, int P1)
    {
        // call: System.arraycopy
        // call: ByteArrayWrapper.<init>
        // call: ByteUtility.intToByteArray
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: ByteArrayWrapper
        return default!;
    }

    public static ByteArrayWrapper IntToBerEncodedLength(int P0)
    {
        // call: ByteUtility.intToByteArray
        // call: ByteArrayWrapper.<init>
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: ByteArrayWrapper
        return default!;
    }

    public static byte[] IntToByteArray(int P0)
    {
        // call: ByteUtility.hexStringToByteArray
        // call: ByteUtility.numberToHexString
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return default!;
    }

    public static bool IsBitSet(byte P0, int P1)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return false;
    }

    public static bool IsHexString(string P0)
    {
        // call: string.charAt
        // call: LibraryUncheckedException.<init>
        // call: string.toLowerCase
        // call: string.length
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F62
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F42
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F63
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: LibraryUncheckedException
        return false;
    }

    public static byte LeftShift(byte P0, byte P1)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return 0;
    }

    public static byte[] LeftShift(byte[] P0, byte P1)
    {
        // str: " 	\n\n  \r\n	\n\r\rw"
        // call: string.intern
        // call: ByteUtility.e
        // call: Exception.<init>
        // type: Exception
        return default!;
    }

    public static byte[] LongToBcd(long P0)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return default!;
    }

    public static byte[] LongToBcd(long P0, int P1)
    {
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return default!;
    }

    public static float Max(float P0, float P1)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return 0;
    }

    public static float Min(float P0, float P1)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return 0;
    }

    public static int NumberOfNonZeroBits(byte[] P0)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return 0;
    }

    public static byte[] NumberToHexFixed(int P0, int P1)
    {
        // call: ByteUtility.intToByteArray
        // call: MemoryStream.toByteArray
        // call: Arrays.copyOfRange
        // call: MemoryStream.<init>
        // call: MemoryStream.write
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: MemoryStream
        return default!;
    }

    public static string NumberToHexString(int P0)
    {
        // str: "_"
        // call: string.length
        // call: int.toHexString
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: ByteUtility.e
        // call: string.intern
        // call: string.toUpperCase
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // type: StringBuilder
        return string.Empty;
    }

    public static byte[] PadData(byte[] P0, int P1, Tag$Format P2)
    {
        // str: "e"
        // call: ByteArrayWrapper.append
        // call: do.d
        // call: ByteArrayWrapper.<init>
        // call: Tag$Format.ordinal
        // call: Type.getField
        // call: Arrays.fill
        // call: ByteArrayWrapper.getBytes
        // call: Field.get
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: ByteArrayWrapper
        return default!;
    }

    public static byte[] RemoveDESPadding(byte[] P0, int P1)
    {
        // str: "a"
        // call: Exception.getCause
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: object.hashCode
        // call: LibraryCheckedException.<init>
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.XCE21
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: LibraryCheckedException
        return default!;
    }

    public static byte RightShift(byte P0, byte P1)
    {
        // call: object.hashCode
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return 0;
    }

    public static byte[] RightShift(byte[] P0, int P1)
    {
        // call: System.arraycopy
        // call: LibraryCheckedException.<init>
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F60
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.exception.ExceptionCode.X6F61
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // type: LibraryCheckedException
        return default!;
    }

    public static byte SetBit(byte P0, int P1)
    {
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        return 0;
    }

    public static Enum[] StringArrayToEnums(string[] P0, Type P1)
    {
        // call: Enum.valueOf
        // call: Array.newInstance
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return default!;
    }

    public static byte[] TruncateData(byte[] P0, int P1, Tag$Format P2)
    {
        // str: "e"
        // call: Field.get
        // call: do.d
        // call: Tag$Format.ordinal
        // call: ByteUtility.getSubByteArray
        // call: Type.getField
        // field: com.mastercard.terminalsdk.utility.ByteUtility.e
        // field: com.mastercard.terminalsdk.utility.ByteUtility.d
        return default!;
    }

}
