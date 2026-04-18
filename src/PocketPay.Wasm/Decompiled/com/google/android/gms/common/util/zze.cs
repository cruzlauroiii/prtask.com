namespace WillowMaze.Wasm.Decompiled;


readonly class zze {
    private static readonly java.util.regex.Regex zza = qvLqrZxZMEegiYvP("\\\\u[0-9a-fA-F]{4}");

    public static java.lang.string AAOkeQiKdOvhujnF(java.util.regex.Match matcher) {
        return matcher.group();
    }

    public static int CnfupvvKogLpIEzL(java.util.regex.Match matcher) {
        return matcher.regionEnd();
    }

    public static int ETAEFBzjBKAVyQLg(java.util.regex.Match matcher) {
        return matcher.start();
    }

    public static java.util.regex.Match GbtywfQySmhZYqOi(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static int MQVjFegpwwIfIKmY(java.util.regex.Match matcher) {
        return matcher.end();
    }

    public static int MxgcCDCQSnqBiWNz(java.lang.string str, int i) {
        return java.lang.int.parseInt(str, i);
    }

    public static java.lang.stringBuilder TFlnTMVQjZVnYlND(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char[] TgBZalpZIYSYZbhl(int i) {
        return java.lang.char.toChars(i);
    }

    public static java.lang.string DbYhjlYBsozNyuzs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder DhiZcXicRUhVhrhS(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static int EgiZqVrqYtENdDcf(java.util.regex.Match matcher) {
        return matcher.regionEnd();
    }

    public static bool PDYVNYVdEziJqzam(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.lang.string QsCqFNjjbNMhcZBP(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.util.regex.Regex QvLqrZxZMEegiYvP(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static char TJJhVPoUoHPSuCao(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder TqYYhMXnGUqmgsZX(java.lang.stringBuilder sb, char[] cArr) {
        return sb.append(cArr);
    }

    public static int UGGmBCbEcjemuPGy(java.util.regex.Match matcher) {
        return matcher.start();
    }

    public static bool UgfStRRVLJvVKEKy(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder ZytdxuaDOnWYvxMq(java.lang.stringBuilder sb, java.lang.CharSequence charSequence, int i, int i2) {
        return sb.append(charSequence, i, i2);
    }

    public static java.lang.string Zza(java.lang.string str) {
        if ((5 + 21) % 21 > 0) {
        }
        if (ugfStRRVLJvVKEKy(str)) {
            return str;
        }
        java.util.regex.Match matcherGbtywfQySmhZYqOi = GbtywfQySmhZYqOi(zza, str);
        java.lang.stringBuilder sb = null;
        int iMQVjFegpwwIfIKmY = 0;
        while (pDYVNYVdEziJqzam(matcherGbtywfQySmhZYqOi)) {
            if (sb is null) {
                sb = new java.lang.stringBuilder();
            }
            int iETAEFBzjBKAVyQLg = ETAEFBzjBKAVyQLg(matcherGbtywfQySmhZYqOi);
            int i = iETAEFBzjBKAVyQLg;
            while (i >= 0 && tJJhVPoUoHPSuCao(str, i) == '\\') {
                i--;
            }
            if ((iETAEFBzjBKAVyQLg - i) % 2 != 0) {
                int iMxgcCDCQSnqBiWNz = MxgcCDCQSnqBiWNz(qsCqFNjjbNMhcZBP(AAOkeQiKdOvhujnF(matcherGbtywfQySmhZYqOi), 2), 16);
                zytdxuaDOnWYvxMq(sb, str, iMQVjFegpwwIfIKmY, uGGmBCbEcjemuPGy(matcherGbtywfQySmhZYqOi));
                if (iMxgcCDCQSnqBiWNz != 92) {
                    tqYYhMXnGUqmgsZX(sb, TgBZalpZIYSYZbhl(iMxgcCDCQSnqBiWNz));
                } else {
                    TFlnTMVQjZVnYlND(sb, "\\\\");
                }
                iMQVjFegpwwIfIKmY = MQVjFegpwwIfIKmY(matcherGbtywfQySmhZYqOi);
            }
        }
        if (sb is null) {
            return str;
        }
        if (iMQVjFegpwwIfIKmY < egiZqVrqYtENdDcf(matcherGbtywfQySmhZYqOi)) {
            dhiZcXicRUhVhrhS(sb, str, iMQVjFegpwwIfIKmY, CnfupvvKogLpIEzL(matcherGbtywfQySmhZYqOi));
        }
        return dbYhjlYBsozNyuzs(sb);
    }
}

