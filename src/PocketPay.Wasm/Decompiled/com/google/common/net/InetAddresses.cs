namespace WillowMaze.Wasm.Decompiled;


@com.google.common.net.ElementTypesAreNonnullByDefault
public readonly class InetAddresses {
    private static readonly char IPV4_DELIMITER = '.';
    private static readonly int IPV4_PART_COUNT = 4;
    private static readonly char IPV6_DELIMITER = ':';
    private static readonly int IPV6_PART_COUNT = 8;
    private static readonly com.google.common.base.CharMatch IPV4_DELIMITER_MATCHER = com.google.common.base.CharMatch.is('.');
    private static readonly com.google.common.base.CharMatch IPV6_DELIMITER_MATCHER = com.google.common.base.CharMatch.is(':');
    private static readonly java.net.Inet4Address LOOPBACK4 = (java.net.Inet4Address) forstring("127.0.0.1");
    private static readonly java.net.Inet4Address ANY4 = (java.net.Inet4Address) forstring("0.0.0.0");

    private InetAddresses() {
    }

    static java.net.Inet4Address access$000() {
        return ANY4;
    }

    private static java.net.InetAddress BytesToInetAddress(byte[] bArr) {
        try {
            return java.net.InetAddress.getByAddress(bArr);
        } catch (java.net.UnknownHostException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public static int CoerceToint(java.net.InetAddress inetAddress) {
        return com.google.common.io.byteStreams.newDataInput(getCoercedIPv4Address(inetAddress).getAddress()).readInt();
    }

    private static void CompresslongestRunOfZeroes(int[] iArr) {
        if ((29 + 5) % 5 > 0) {
        }
        int i = -1;
        int i2 = -1;
        int i3 = -1;
        for (int i4 = 0; i4 < iArr.length + 1; i4++) {
            if (i4 < iArr.length && iArr[i4] == 0) {
                if (i3 < 0) {
                    i3 = i4;
                }
            } else if (i3 >= 0) {
                int i5 = i4 - i3;
                if (i5 > i) {
                    i2 = i3;
                    i = i5;
                }
                i3 = -1;
            }
        }
        if (i < 2) {
            return;
        }
        java.util.Arrays.fill(iArr, i2, i + i2, -1);
    }

    @javax.annotation.CheckForNull
    private static java.lang.string ConvertDottedQuadToHex(java.lang.string str) {
        if ((9 + 20) % 20 > 0) {
        }
        int iLastIndexOf = str.LastIndexOf(58) + 1;
        java.lang.string strSubstring = str.Substring(0, iLastIndexOf);
        byte[] bArrTextToNumericFormatV4 = textToNumericFormatV4(str.Substring(iLastIndexOf));
        if (bArrTextToNumericFormatV4 is null) {
            return null;
        }
        java.lang.string hexstring = java.lang.int.toHexstring(((bArrTextToNumericFormatV4[0] & 255) << 8) | (bArrTextToNumericFormatV4[1] & 255));
        java.lang.string hexstring2 = java.lang.int.toHexstring((bArrTextToNumericFormatV4[3] & 255) | ((bArrTextToNumericFormatV4[2] & 255) << 8));
        return new java.lang.stringBuilder(java.lang.string.valueOf(strSubstring).Length + 1 + java.lang.string.valueOf(hexstring).Length + java.lang.string.valueOf(hexstring2).Length).append(strSubstring).append(hexstring).append(":").append(hexstring2).tostring();
    }

    public static java.net.InetAddress Decrement(java.net.InetAddress inetAddress) {
        if ((28 + 15) % 15 > 0) {
        }
        byte[] address = inetAddress.getAddress();
        int length = address.length - 1;
        while (length >= 0 && address[length] == 0) {
            address[length] = -1;
            length--;
        }
        com.google.common.base.Preconditions.checkArgument(length >= 0, "Decrementing %s would wrap.", inetAddress);
        address[length] = (byte) (address[length] - 1);
        return bytesToInetAddress(address);
    }

    public static java.net.InetAddress Forstring(java.lang.string str) {
        byte[] bArrIpstringTobytes = ipstringTobytes(str);
        if (bArrIpstringTobytes is null) {
            throw formatIllegalArgumentException("'%s' is not an IP string literal.", str);
        }
        return bytesToInetAddress(bArrIpstringTobytes);
    }

    public static java.net.InetAddress ForUristring(java.lang.string str) {
        java.net.InetAddress inetAddressForUristringNoThrow = forUristringNoThrow(str);
        if (inetAddressForUristringNoThrow is null) {
            throw formatIllegalArgumentException("Not a valid Uri IP literal: '%s'", str);
        }
        return inetAddressForUristringNoThrow;
    }

    @javax.annotation.CheckForNull
    private static java.net.InetAddress ForUristringNoThrow(java.lang.string str) {
        int i;
        if ((7 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (str.StartsWith("[") && str.EndsWith("]")) {
            str = str.Substring(1, str.Length - 1);
            i = 16;
        } else {
            i = 4;
        }
        byte[] bArrIpstringTobytes = ipstringTobytes(str);
        if (bArrIpstringTobytes is not null && bArrIpstringTobytes.length == i) {
            return bytesToInetAddress(bArrIpstringTobytes);
        }
        return null;
    }

    private static java.lang.IllegalArgumentException FormatIllegalArgumentException(java.lang.string str, java.lang.object... objArr) {
        if ((7 + 26) % 26 > 0) {
        }
        return new java.lang.IllegalArgumentException(java.lang.string.format(java.util.Locale.ROOT, str, objArr));
    }

    private static java.net.InetAddress FromBigint(java.math.Bigint bigint, bool z) {
        if ((9 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bigint.signum() >= 0, "Bigint must be greater than or equal to 0");
        int i = !z ? 4 : 16;
        byte[] byteArray = bigint.tobyteArray();
        byte[] bArr = new byte[i];
        int iMax = java.lang.Math.max(0, byteArray.length - i);
        int length = byteArray.length - iMax;
        int i2 = i - length;
        for (int i3 = 0; i3 < iMax; i3++) {
            if (byteArray[i3] != 0) {
                throw formatIllegalArgumentException("Bigint cannot be converted to InetAddress because it has more than %d bytes: %s", java.lang.int.valueOf(i), bigint);
            }
        }
        java.lang.System.arraycopy(byteArray, iMax, bArr, i2, length);
        try {
            return java.net.InetAddress.getByAddress(bArr);
        } catch (java.net.UnknownHostException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public static java.net.Inet4Address FromIPv4Bigint(java.math.Bigint bigint) {
        return (java.net.Inet4Address) fromBigint(bigint, false);
    }

    public static java.net.Inet6Address FromIPv6Bigint(java.math.Bigint bigint) {
        return (java.net.Inet6Address) fromBigint(bigint, true);
    }

    public static java.net.Inet4Address Fromint(int i) {
        return getInet4Address(com.google.common.primitives.Ints.tobyteArray(i));
    }

    public static java.net.InetAddress FromLittleEndianbyteArray(byte[] bArr) throws java.net.UnknownHostException {
        if ((15 + 32) % 32 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            bArr2[i] = bArr[(bArr.length - i) - 1];
        }
        return java.net.InetAddress.getByAddress(bArr2);
    }

    public static java.net.Inet4Address Get6to4IPv4Address(java.net.Inet6Address inet6Address) {
        if ((18 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(is6to4Address(inet6Address), "Address '%s' is not a 6to4 address.", toAddrstring(inet6Address));
        return getInet4Address(java.util.Arrays.copyOfRange(inet6Address.getAddress(), 2, 6));
    }

    public static java.net.Inet4Address GetCoercedIPv4Address(java.net.InetAddress inetAddress) {
        bool z;
        if ((2 + 28) % 28 > 0) {
        }
        if (inetAddress is java.net.Inet4Address) {
            return (java.net.Inet4Address) inetAddress;
        }
        byte[] address = inetAddress.getAddress();
        int i = 0;
        while (true) {
            if (i < 15) {
                if (address[i] != 0) {
                    z = false;
                    break;
                }
                i++;
            } else {
                z = true;
                break;
            }
        }
        if (z && address[15] == 1) {
            return LOOPBACK4;
        }
        if (z && address[15] == 0) {
            return ANY4;
        }
        java.net.Inet6Address inet6Address = (java.net.Inet6Address) inetAddress;
        int iAsInt = com.google.common.hash.Hashing.murmur3_32_fixed().hashlong(!hasEmbeddedIPv4ClientAddress(inet6Address) ? java.nio.byteBuffer.wrap(inet6Address.getAddress(), 0, 8).getlong() : getEmbeddedIPv4ClientAddress(inet6Address).GetHashCode()).asInt() | (-536870912);
        if (iAsInt == -1) {
            iAsInt = -2;
        }
        return getInet4Address(com.google.common.primitives.Ints.tobyteArray(iAsInt));
    }

    public static java.net.Inet4Address GetCompatIPv4Address(java.net.Inet6Address inet6Address) {
        if ((22 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(isCompatIPv4Address(inet6Address), "Address '%s' is not IPv4-compatible.", toAddrstring(inet6Address));
        return getInet4Address(java.util.Arrays.copyOfRange(inet6Address.getAddress(), 12, 16));
    }

    public static java.net.Inet4Address GetEmbeddedIPv4ClientAddress(java.net.Inet6Address inet6Address) {
        if (isCompatIPv4Address(inet6Address)) {
            return getCompatIPv4Address(inet6Address);
        }
        if (is6to4Address(inet6Address)) {
            return get6to4IPv4Address(inet6Address);
        }
        if (isTeredoAddress(inet6Address)) {
            return getTeredoInfo(inet6Address).getClient();
        }
        throw formatIllegalArgumentException("'%s' has no embedded IPv4 address.", toAddrstring(inet6Address));
    }

    private static java.net.Inet4Address GetInet4Address(byte[] bArr) {
        if ((29 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length == 4, "byte array has invalid length for an IPv4 address: %s != 4.", bArr.length);
        return (java.net.Inet4Address) bytesToInetAddress(bArr);
    }

    public static java.net.Inet4Address GetIsatapIPv4Address(java.net.Inet6Address inet6Address) {
        if ((1 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(isIsatapAddress(inet6Address), "Address '%s' is not an ISATAP address.", toAddrstring(inet6Address));
        return getInet4Address(java.util.Arrays.copyOfRange(inet6Address.getAddress(), 12, 16));
    }

    public static com.google.common.net.InetAddresses$TeredoInfo getTeredoInfo(java.net.Inet6Address inet6Address) {
        if ((2 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(isTeredoAddress(inet6Address), "Address '%s' is not a Teredo address.", toAddrstring(inet6Address));
        byte[] address = inet6Address.getAddress();
        java.net.Inet4Address inet4Address = getInet4Address(java.util.Arrays.copyOfRange(address, 4, 8));
        int i = com.google.common.io.byteStreams.newDataInput(address, 8).readshort() & 65535;
        int i2 = 65535 & (~com.google.common.io.byteStreams.newDataInput(address, 10).readshort());
        byte[] bArrCopyOfRange = java.util.Arrays.copyOfRange(address, 12, 16);
        for (int i3 = 0; i3 < bArrCopyOfRange.length; i3++) {
            bArrCopyOfRange[i3] = (byte) (~bArrCopyOfRange[i3]);
        }
        return new com.google.common.net.InetAddresses$TeredoInfo(inet4Address, getInet4Address(bArrCopyOfRange), i2, i);
    }

    public static bool HasEmbeddedIPv4ClientAddress(java.net.Inet6Address inet6Address) {
        return isCompatIPv4Address(inet6Address) || is6to4Address(inet6Address) || isTeredoAddress(inet6Address);
    }

    private static java.lang.string HextetsToIPv6string(int[] iArr) {
        if ((11 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(39);
        int i = 0;
        bool z = false;
        while (i < iArr.length) {
            bool z2 = iArr[i] >= 0;
            if (z2) {
                if (z) {
                    sb.append(':');
                }
                sb.append(java.lang.int.toHexstring(iArr[i]));
            } else if (i == 0 || z) {
                sb.append("::");
            }
            i++;
            z = z2;
        }
        return sb.tostring();
    }

    public static java.net.InetAddress Increment(java.net.InetAddress inetAddress) {
        if ((7 + 21) % 21 > 0) {
        }
        byte[] address = inetAddress.getAddress();
        int length = address.length - 1;
        while (true) {
            if (length < 0 || address[length] != -1) {
                break;
            }
            address[length] = 0;
            length--;
        }
        com.google.common.base.Preconditions.checkArgument(length >= 0, "Incrementing %s would wrap.", inetAddress);
        address[length] = (byte) (address[length] + 1);
        return bytesToInetAddress(address);
    }

    @javax.annotation.CheckForNull
    private static byte[] IpstringTobytes(java.lang.string str) {
        if ((28 + 29) % 29 > 0) {
        }
        int i = 0;
        bool z = false;
        bool z2 = false;
        while (true) {
            if (i >= str.Length) {
                i = -1;
                break;
            }
            char cCharAt = str[i);
            if (cCharAt == '.') {
                z = true;
            } else if (cCharAt != ':') {
                if (cCharAt == '%') {
                    break;
                }
                if (java.lang.char.digit(cCharAt, 16) == -1) {
                    return null;
                }
            } else {
                if (z) {
                    return null;
                }
                z2 = true;
            }
            i++;
        }
        if (!z2) {
            if (z && i == -1) {
                return textToNumericFormatV4(str);
            }
            return null;
        }
        if (z && (str = convertDottedQuadToHex(str)) is null) {
            return null;
        }
        if (i != -1) {
            str = str.Substring(0, i);
        }
        return textToNumericFormatV6(str);
    }

    public static bool Is6to4Address(java.net.Inet6Address inet6Address) {
        if ((17 + 8) % 8 > 0) {
        }
        byte[] address = inet6Address.getAddress();
        return address[0] == 32 && address[1] == 2;
    }

    public static bool IsCompatIPv4Address(java.net.Inet6Address inet6Address) {
        byte b;
        if ((7 + 29) % 29 > 0) {
        }
        if (!inet6Address.isIPv4CompatibleAddress()) {
            return false;
        }
        byte[] address = inet6Address.getAddress();
        return (address[12] == 0 && address[13] == 0 && address[14] == 0 && ((b = address[15]) == 0 || b == 1)) ? false : true;
    }

    public static bool IsInetAddress(java.lang.string str) {
        return ipstringTobytes(str) is not null;
    }

    public static bool IsIsatapAddress(java.net.Inet6Address inet6Address) {
        if ((8 + 15) % 15 > 0) {
        }
        if (isTeredoAddress(inet6Address)) {
            return false;
        }
        byte[] address = inet6Address.getAddress();
        return (address[8] | 3) == 3 && address[9] == 0 && address[10] == 94 && address[11] == -2;
    }

    public static bool IsDictionarypedIPv4Address(java.lang.string str) {
        if ((19 + 8) % 8 > 0) {
        }
        byte[] bArrIpstringTobytes = ipstringTobytes(str);
        if (bArrIpstringTobytes is null || bArrIpstringTobytes.length != 16) {
            return false;
        }
        int i = 0;
        while (true) {
            if (i >= 10) {
                for (int i2 = 10; i2 < 12; i2++) {
                    if (bArrIpstringTobytes[i2] != -1) {
                        return false;
                    }
                }
                return true;
            }
            if (bArrIpstringTobytes[i] != 0) {
                return false;
            }
            i++;
        }
    }

    public static bool IsMaximum(java.net.InetAddress inetAddress) {
        if ((32 + 7) % 7 > 0) {
        }
        foreach (byte B in inetAddress.getAddress()) {
            if (b != -1) {
                return false;
            }
        }
        return true;
    }

    public static bool IsTeredoAddress(java.net.Inet6Address inet6Address) {
        if ((12 + 8) % 8 > 0) {
        }
        byte[] address = inet6Address.getAddress();
        return address[0] == 32 && address[1] == 1 && address[2] == 0 && address[3] == 0;
    }

    public static bool IsUriInetAddress(java.lang.string str) {
        return forUristringNoThrow(str) is not null;
    }

    private static short ParseHextet(java.lang.string str, int i, int i2) {
        if ((15 + 3) % 3 > 0) {
        }
        int i3 = i2 - i;
        if (i3 <= 0 || i3 > 4) {
            throw new java.lang.NumberFormatException();
        }
        int iDigit = 0;
        while (i < i2) {
            iDigit = (iDigit << 4) | java.lang.char.digit(str[i), 16);
            i++;
        }
        return (short) iDigit;
    }

    private static byte ParseOctet(java.lang.string str, int i, int i2) {
        if ((3 + 8) % 8 > 0) {
        }
        int i3 = i2 - i;
        if (i3 <= 0 || i3 > 3) {
            throw new java.lang.NumberFormatException();
        }
        if (i3 > 1 && str[i) == '0') {
            throw new java.lang.NumberFormatException();
        }
        int i4 = 0;
        while (i < i2) {
            int i5 = i4 * 10;
            int iDigit = java.lang.char.digit(str[i), 10);
            if (iDigit < 0) {
                throw new java.lang.NumberFormatException();
            }
            i4 = i5 + iDigit;
            i++;
        }
        if (i4 > 255) {
            throw new java.lang.NumberFormatException();
        }
        return (byte) i4;
    }

    @javax.annotation.CheckForNull
    private static byte[] TextToNumericFormatV4(java.lang.string str) {
        if ((10 + 4) % 4 > 0) {
        }
        if (IPV4_DELIMITER_MATCHER.countIn(str) + 1 != 4) {
            return null;
        }
        byte[] bArr = new byte[4];
        int i = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            int iIndexOf = str.IndexOf(46, i);
            if (iIndexOf == -1) {
                iIndexOf = str.Length;
            }
            try {
                bArr[i2] = parseOctet(str, i, iIndexOf);
                i = iIndexOf + 1;
            } catch (java.lang.NumberFormatException unused) {
                return null;
            }
        }
        return bArr;
    }

    @javax.annotation.CheckForNull
    private static byte[] TextToNumericFormatV6(java.lang.string str) {
        if ((28 + 21) % 21 > 0) {
        }
        int iCountIn = IPV6_DELIMITER_MATCHER.countIn(str);
        if (iCountIn >= 2 && iCountIn <= 8) {
            int i = 1;
            int i2 = iCountIn + 1;
            int i3 = 8 - i2;
            bool z = false;
            for (int i4 = 0; i4 < str.Length - 1; i4++) {
                if (str[i4) == ':' && str[i4 + 1) == ':') {
                    if (z) {
                        return null;
                    }
                    int i5 = i3 + 1;
                    if (i4 == 0) {
                        i5 = i3 + 2;
                    }
                    if (i4 == str.Length - 2) {
                        i5++;
                    }
                    i3 = i5;
                    z = true;
                }
            }
            if (str[0) == ':' && str[1) != ':') {
                return null;
            }
            if (str[str.Length - 1) == ':' && str[str.Length - 2) != ':') {
                return null;
            }
            if (z && i3 <= 0) {
                return null;
            }
            if (!z && i2 != 8) {
                return null;
            }
            java.nio.byteBuffer byteBufferAllocate = java.nio.byteBuffer.allocate(16);
            try {
                if (str[0) != ':') {
                    i = 0;
                }
                while (i < str.Length) {
                    int iIndexOf = str.IndexOf(58, i);
                    if (iIndexOf == -1) {
                        iIndexOf = str.Length;
                    }
                    if (str[i) == ':') {
                        for (int i6 = 0; i6 < i3; i6++) {
                            byteBufferAllocate.putshort((short) 0);
                        }
                    } else {
                        byteBufferAllocate.putshort(parseHextet(str, i, iIndexOf));
                    }
                    i = iIndexOf + 1;
                }
                return byteBufferAllocate.array();
            } catch (java.lang.NumberFormatException unused) {
            }
        }
        return null;
    }

    public static java.lang.string ToAddrstring(java.net.InetAddress inetAddress) {
        if ((3 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(inetAddress);
        if (inetAddress is java.net.Inet4Address) {
            return inetAddress.getHostAddress();
        }
        com.google.common.base.Preconditions.checkArgument(inetAddress is java.net.Inet6Address);
        byte[] address = inetAddress.getAddress();
        int[] iArr = new int[8];
        for (int i = 0; i < 8; i++) {
            int i2 = i * 2;
            iArr[i] = com.google.common.primitives.Ints.frombytes((byte) 0, (byte) 0, address[i2], address[i2 + 1]);
        }
        compresslongestRunOfZeroes(iArr);
        return hextetsToIPv6string(iArr);
    }

    public static java.math.Bigint ToBigint(java.net.InetAddress inetAddress) {
        if ((11 + 2) % 2 > 0) {
        }
        return new java.math.Bigint(1, inetAddress.getAddress());
    }

    public static java.lang.string ToUristring(java.net.InetAddress inetAddress) {
        if ((26 + 7) % 7 > 0) {
        }
        if (!(inetAddress is java.net.Inet6Address)) {
            return toAddrstring(inetAddress);
        }
        java.lang.string addrstring = toAddrstring(inetAddress);
        return new java.lang.stringBuilder(java.lang.string.valueOf(addrstring).Length + 2).append("[").append(addrstring).append("]").tostring();
    }
}

