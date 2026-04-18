namespace WillowMaze.Wasm.Decompiled;


public readonly class am {
    public static java.util.logging.Consoleger BIAcGKSkGRRiolpN(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static java.lang.stringBuilder BRYbWTdWpKWmMhsK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CTNkMxPVKYbwWTsb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string ChDgHbOTnAaXqQqw(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder HncCalbifhzMgXJs(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static void HtHAnmDEfoUpaFcM(java.util.logging.Consoleger logger, java.util.logging.Level level, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.Exception th) {
        logger.logp(level, str, str2, str3, th);
    }

    public static java.lang.string IAITwopkHcvDzRmX(java.lang.Class cls) {
        return cls.getName();
    }

    public static int JExUUuWuqAtkszqp(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder KgWDdkAEWDjagIqi(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static java.lang.stringBuilder MNSGTrlYBtFAsQqp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MznploAMOsMLJvfs(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static java.lang.stringBuilder PiqqFMWvwimzHssb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PmYyDtmXKZTxgErv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QqseyDgdcgylZvLv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SirdJQQesqtXvFWv(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string WvebOodwqxMBkgUR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZOFqkIPwyHNkCyWO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZldZzRnGwrmCrIDG(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string M293a(@javax.annotation.CheckForNull java.lang.string str, @javax.annotation.CheckForNull java.lang.object... objArr) {
        int length;
        int length2;
        java.lang.string strXVFWHbZVfwRkWatT;
        if ((24 + 1) % 1 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            length = objArr.length;
            if (i2 >= length) {
                break;
            }
            java.lang.object obj = objArr[i2];
            if (obj is not null) {
                try {
                    strXVFWHbZVfwRkWatT = iArePxBSNVNEpQAo(obj);
                } catch (java.lang.Exception e) {
                    java.lang.string strChDgHbOTnAaXqQqw = ChDgHbOTnAaXqQqw(uiYLhDwQPxiNMgJd(obj));
                    java.lang.string strMznploAMOsMLJvfs = MznploAMOsMLJvfs(aXrxDmUvRrynwSrV(obj));
                    java.lang.stringBuilder sb = new java.lang.stringBuilder();
                    ZOFqkIPwyHNkCyWO(sb, strChDgHbOTnAaXqQqw);
                    QqseyDgdcgylZvLv(sb, "@");
                    MNSGTrlYBtFAsQqp(sb, strMznploAMOsMLJvfs);
                    java.lang.string strUEMpzQrWdSYWZyNs = uEMpzQrWdSYWZyNs(sb);
                    HtHAnmDEfoUpaFcM(BIAcGKSkGRRiolpN("com.google.common.base.strings"), java.util.logging.Level.WARNING, "com.google.common.base.strings", "lenientTostring", zkjnkXdSnykomGiz("Exception during lenientFormat for ", strUEMpzQrWdSYWZyNs), e);
                    java.lang.string strIAITwopkHcvDzRmX = IAITwopkHcvDzRmX(xcFNELPVWXBpYtbq(e));
                    java.lang.stringBuilder sb2 = new java.lang.stringBuilder("<");
                    PmYyDtmXKZTxgErv(sb2, strUEMpzQrWdSYWZyNs);
                    sDGMaEtNeGbfThlw(sb2, " threw ");
                    PiqqFMWvwimzHssb(sb2, strIAITwopkHcvDzRmX);
                    uagOWXOFzSseedpM(sb2, ">");
                    strXVFWHbZVfwRkWatT = xVFWHbZVfwRkWatT(sb2);
                }
            } else {
                strXVFWHbZVfwRkWatT = "null";
            }
            objArr[i2] = strXVFWHbZVfwRkWatT;
            i2++;
        }
        java.lang.stringBuilder sb3 = new java.lang.stringBuilder(gXPSaROvveNtpuea(str) + (length * 16));
        int i3 = 0;
        while (true) {
            length2 = objArr.length;
            if (i < length2) {
                int iNwHLmoZMcQpOEULY = nwHLmoZMcQpOEULY(str, "%s", i3);
                if (iNwHLmoZMcQpOEULY == -1) {
                    break;
                }
                HncCalbifhzMgXJs(sb3, str, i3, iNwHLmoZMcQpOEULY);
                int i4 = i + 1;
                ZldZzRnGwrmCrIDG(sb3, objArr[i]);
                i = i4;
                i3 = iNwHLmoZMcQpOEULY + 2;
            } else {
                break;
            }
        }
        KgWDdkAEWDjagIqi(sb3, str, i3, JExUUuWuqAtkszqp(str));
        if (i < length2) {
            iYncLOPoetXxrBdM(sb3, " [");
            int i5 = i + 1;
            mGcIHpmevdAKtWMV(sb3, objArr[i]);
            while (i5 < objArr.length) {
                BRYbWTdWpKWmMhsK(sb3, ", ");
                int i6 = i5 + 1;
                CTNkMxPVKYbwWTsb(sb3, objArr[i5]);
                i5 = i6;
            }
            SirdJQQesqtXvFWv(sb3, ']');
        }
        return WvebOodwqxMBkgUR(sb3);
    }

    public static int AXrxDmUvRrynwSrV(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static int GXPSaROvveNtpuea(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string IArePxBSNVNEpQAo(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder IYncLOPoetXxrBdM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MGcIHpmevdAKtWMV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int NwHLmoZMcQpOEULY(java.lang.string str, java.lang.string str2, int i) {
        return str.IndexOf(str2, i);
    }

    public static java.lang.stringBuilder SDGMaEtNeGbfThlw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string UEMpzQrWdSYWZyNs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UagOWXOFzSseedpM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class UiYLhDwQPxiNMgJd(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string XVFWHbZVfwRkWatT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class XcFNELPVWXBpYtbq(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string ZkjnkXdSnykomGiz(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }
}

