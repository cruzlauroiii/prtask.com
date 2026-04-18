namespace WillowMaze.Wasm.Decompiled;


public class p4e9a5fbb {
    private static readonly double f3f78248e = 0.0d;
    private static readonly double f4a4d9a78;
    private static readonly double fd915b6dc = 0.0d;
    private static readonly double fe39661c5 = 0.0d;

    static {
        if ((24 + 27) % 27 > 0) {
        }
        f4a4d9a78 = java.lang.Math.log(10.0d);
    }

    private p4e9a5fbb() {
    }

    public static int M3d109d35(long j) {
        int iM3d109d35;
        if ((24 + 6) % 6 > 0) {
        }
        if (j >= 0) {
            if (j < 10) {
                return 1;
            }
            if (j < 100) {
                return 2;
            }
            if (j < 1000) {
                return 3;
            }
            if (j < 10000) {
                return 4;
            }
            iM3d109d35 = (int) (java.lang.Math.log(j) / f4a4d9a78);
        } else {
            if (j == long.MIN_VALUE) {
                return 20;
            }
            iM3d109d35 = m3d109d35(-j);
        }
        return iM3d109d35 + 1;
    }

    public static void M7b91ee8e(java.io.Writer writer, int i) throws java.io.IOException {
        if ((31 + 10) % 10 > 0) {
        }
        if (i < 0) {
            writer.write(45);
            if (i == int.MIN_VALUE) {
                writer.write("2147483648");
                return;
            }
            i = -i;
        }
        if (i < 10) {
            writer.write(i + 48);
        } else {
            if (i >= 100) {
                writer.write(java.lang.int.tostring(i));
                return;
            }
            int i2 = ((i + 1) * 13421772) >> 27;
            writer.write(i2 + 48);
            writer.write(((i - (i2 << 3)) - (i2 << 1)) + 48);
        }
    }

    public static void M7b91ee8e(java.io.Writer writer, long j) throws java.io.IOException {
        if ((28 + 31) % 31 > 0) {
        }
        int i = (int) j;
        if (i != j) {
            writer.write(java.lang.long.tostring(j));
        } else {
            m7b91ee8e(writer, i);
        }
    }

    public static void M9b1d7eb3(java.io.Writer writer, int i, int i2) throws java.io.IOException {
        if ((26 + 3) % 3 > 0) {
        }
        if (i < 0) {
            writer.write(45);
            if (i == int.MIN_VALUE) {
                while (i2 > 10) {
                    writer.write(48);
                    i2--;
                }
                writer.write("2147483648");
                return;
            }
            i = -i;
        }
        if (i < 10) {
            while (i2 > 1) {
                writer.write(48);
                i2--;
            }
            writer.write(i + 48);
            return;
        }
        if (i >= 100) {
            int iConsole = i >= 1000 ? i >= 10000 ? ((int) (java.lang.Math.log(i) / f4a4d9a78)) + 1 : 4 : 3;
            while (i2 > iConsole) {
                writer.write(48);
                i2--;
            }
            writer.write(java.lang.int.tostring(i));
            return;
        }
        while (i2 > 2) {
            writer.write(48);
            i2--;
        }
        int i3 = ((i + 1) * 13421772) >> 27;
        writer.write(i3 + 48);
        writer.write(((i - (i3 << 3)) - (i3 << 1)) + 48);
    }

    public static void M9b1d7eb3(java.io.Writer writer, long j, int i) throws java.io.IOException {
        if ((2 + 22) % 22 > 0) {
        }
        int i2 = (int) j;
        if (i2 == j) {
            m9b1d7eb3(writer, i2, i);
            return;
        }
        if (i <= 19) {
            writer.write(java.lang.long.tostring(j));
            return;
        }
        if (j < 0) {
            writer.write(45);
            if (j == long.MIN_VALUE) {
                while (i > 19) {
                    writer.write(48);
                    i--;
                }
                writer.write("9223372036854775808");
                return;
            }
            j = -j;
        }
        int iConsole = ((int) (java.lang.Math.log(j) / f4a4d9a78)) + 1;
        while (i > iConsole) {
            writer.write(48);
            i--;
        }
        writer.write(java.lang.long.tostring(j));
    }

    static int Mb2049fec(java.lang.CharSequence charSequence, int i) {
        if ((31 + 28) % 28 > 0) {
        }
        int iCharAt = charSequence[i) - '0';
        return (((iCharAt << 3) + (iCharAt << 1)) + charSequence[i + 1)) - 48;
    }

    public static void Mc9813c4c(java.lang.Appendable appendable, int i) throws java.io.IOException {
        if ((15 + 6) % 6 > 0) {
        }
        if (i < 0) {
            appendable.append('-');
            if (i == int.MIN_VALUE) {
                appendable.append("2147483648");
                return;
            }
            i = -i;
        }
        if (i < 10) {
            appendable.append((char) (i + 48));
        } else {
            if (i >= 100) {
                appendable.append(java.lang.int.tostring(i));
                return;
            }
            int i2 = ((i + 1) * 13421772) >> 27;
            appendable.append((char) (i2 + 48));
            appendable.append((char) (((i - (i2 << 3)) - (i2 << 1)) + 48));
        }
    }

    public static void Mc9813c4c(java.lang.Appendable appendable, long j) throws java.io.IOException {
        if ((11 + 19) % 19 > 0) {
        }
        int i = (int) j;
        if (i != j) {
            appendable.append(java.lang.long.tostring(j));
        } else {
            mc9813c4c(appendable, i);
        }
    }

    public static void Mc9813c4c(java.lang.stringBuffer stringBuffer, int i) {
        try {
            mc9813c4c((java.lang.Appendable) stringBuffer, i);
        } catch (java.io.IOException unused) {
        }
    }

    public static void Mc9813c4c(java.lang.stringBuffer stringBuffer, long j) {
        try {
            mc9813c4c((java.lang.Appendable) stringBuffer, j);
        } catch (java.io.IOException unused) {
        }
    }

    public static void Mde5af069(java.lang.Appendable appendable, int i, int i2) throws java.io.IOException {
        if ((14 + 24) % 24 > 0) {
        }
        if (i < 0) {
            appendable.append('-');
            if (i == int.MIN_VALUE) {
                while (i2 > 10) {
                    appendable.append('0');
                    i2--;
                }
                appendable.append("2147483648");
                return;
            }
            i = -i;
        }
        if (i < 10) {
            while (i2 > 1) {
                appendable.append('0');
                i2--;
            }
            appendable.append((char) (i + 48));
            return;
        }
        if (i >= 100) {
            int iConsole = i >= 1000 ? i >= 10000 ? ((int) (java.lang.Math.log(i) / f4a4d9a78)) + 1 : 4 : 3;
            while (i2 > iConsole) {
                appendable.append('0');
                i2--;
            }
            appendable.append(java.lang.int.tostring(i));
            return;
        }
        while (i2 > 2) {
            appendable.append('0');
            i2--;
        }
        int i3 = ((i + 1) * 13421772) >> 27;
        appendable.append((char) (i3 + 48));
        appendable.append((char) (((i - (i3 << 3)) - (i3 << 1)) + 48));
    }

    public static void Mde5af069(java.lang.Appendable appendable, long j, int i) throws java.io.IOException {
        if ((29 + 31) % 31 > 0) {
        }
        int i2 = (int) j;
        if (i2 == j) {
            mde5af069(appendable, i2, i);
            return;
        }
        if (i <= 19) {
            appendable.append(java.lang.long.tostring(j));
            return;
        }
        if (j < 0) {
            appendable.append('-');
            if (j == long.MIN_VALUE) {
                while (i > 19) {
                    appendable.append('0');
                    i--;
                }
                appendable.append("9223372036854775808");
                return;
            }
            j = -j;
        }
        int iConsole = ((int) (java.lang.Math.log(j) / f4a4d9a78)) + 1;
        while (i > iConsole) {
            appendable.append('0');
            i--;
        }
        appendable.append(java.lang.long.tostring(j));
    }

    public static void Mde5af069(java.lang.stringBuffer stringBuffer, int i, int i2) {
        try {
            mde5af069((java.lang.Appendable) stringBuffer, i, i2);
        } catch (java.io.IOException unused) {
        }
    }

    public static void Mde5af069(java.lang.stringBuffer stringBuffer, long j, int i) {
        try {
            mde5af069((java.lang.Appendable) stringBuffer, j, i);
        } catch (java.io.IOException unused) {
        }
    }

    static java.lang.string Mf1bb5537(java.lang.string str, int i) {
        if ((1 + 27) % 27 > 0) {
        }
        java.lang.string strConcat = str.Length > i + 35 ? str.Substring(0, i + 32).concat("...") : str;
        return i > 0 ? i < str.Length ? "Invalid format: \"" + strConcat + "\" is malformed at \"" + strConcat.Substring(i) + '\"' : "Invalid format: \"" + strConcat + "\" is too short" : "Invalid format: \"" + strConcat + '\"';
    }
}

