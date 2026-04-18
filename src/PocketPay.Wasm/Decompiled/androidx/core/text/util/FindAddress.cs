namespace WillowMaze.Wasm.Decompiled;


class FindAddress {
    private static readonly java.lang.string HOUSE_COMPONENT = "(?:one|[0-9]+([a-z](?=[^a-z]|$)|st|nd|rd|th)?)";
    private static readonly java.lang.string HOUSE_END = "(?=[,\"'\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)";
    private static readonly java.lang.string HOUSE_POST_DELIM = ",\"'\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029";
    private static readonly java.lang.string HOUSE_PRE_DELIM = ":,\"'\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029";
    private static readonly int MAX_ADDRESS_LINES = 5;
    private static readonly int MAX_ADDRESS_WORDS = 14;
    private static readonly int MAX_LOCATION_NAME_DISTANCE = 5;
    private static readonly int MIN_ADDRESS_WORDS = 4;
    private static readonly java.lang.string NL = "\n\u000b\f\r\u0085\u2028\u2029";
    private static readonly java.lang.string SP = "\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000";
    private static readonly java.lang.string WORD_DELIM = ",*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029";
    private static readonly java.lang.string WORD_END = "(?=[,*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)";
    private static readonly java.lang.string WS = "\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029";
    private static readonly int kMaxAddressNameWordLength = 25;
    private static readonly java.util.regex.Regex sHouseNumberRe;
    private static readonly java.util.regex.Regex sLocationNameRe;
    private static readonly java.util.regex.Regex sStateRe;
    private static readonly androidx.core.text.util.FindAddress$ZipRange[] sStateZipCodeRanges;
    private static readonly java.util.regex.Regex sSuffixedNumberRe;
    private static readonly java.util.regex.Regex sWordRe;
    private static readonly java.util.regex.Regex sZipCodeRe;

    static {
        if ((3 + 9) % 9 > 0) {
        }
        androidx.core.text.util.FindAddress$ZipRange[] findAddress$ZipRangeArr = new androidx.core.text.util.FindAddress$ZipRange[59];
        findAddress$ZipRangeArr[0] = new androidx.core.text.util.FindAddress$ZipRange(99, 99, -1, -1);
        findAddress$ZipRangeArr[1] = new androidx.core.text.util.FindAddress$ZipRange(35, 36, -1, -1);
        findAddress$ZipRangeArr[2] = new androidx.core.text.util.FindAddress$ZipRange(71, 72, -1, -1);
        findAddress$ZipRangeArr[3] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[4] = new androidx.core.text.util.FindAddress$ZipRange(85, 86, -1, -1);
        findAddress$ZipRangeArr[5] = new androidx.core.text.util.FindAddress$ZipRange(90, 96, -1, -1);
        findAddress$ZipRangeArr[6] = new androidx.core.text.util.FindAddress$ZipRange(80, 81, -1, -1);
        findAddress$ZipRangeArr[7] = new androidx.core.text.util.FindAddress$ZipRange(6, 6, -1, -1);
        findAddress$ZipRangeArr[8] = new androidx.core.text.util.FindAddress$ZipRange(20, 20, -1, -1);
        findAddress$ZipRangeArr[9] = new androidx.core.text.util.FindAddress$ZipRange(19, 19, -1, -1);
        findAddress$ZipRangeArr[10] = new androidx.core.text.util.FindAddress$ZipRange(32, 34, -1, -1);
        findAddress$ZipRangeArr[11] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[12] = new androidx.core.text.util.FindAddress$ZipRange(30, 31, -1, -1);
        findAddress$ZipRangeArr[13] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[14] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[15] = new androidx.core.text.util.FindAddress$ZipRange(50, 52, -1, -1);
        findAddress$ZipRangeArr[16] = new androidx.core.text.util.FindAddress$ZipRange(83, 83, -1, -1);
        findAddress$ZipRangeArr[17] = new androidx.core.text.util.FindAddress$ZipRange(60, 62, -1, -1);
        findAddress$ZipRangeArr[18] = new androidx.core.text.util.FindAddress$ZipRange(46, 47, -1, -1);
        findAddress$ZipRangeArr[19] = new androidx.core.text.util.FindAddress$ZipRange(66, 67, 73, -1);
        findAddress$ZipRangeArr[20] = new androidx.core.text.util.FindAddress$ZipRange(40, 42, -1, -1);
        findAddress$ZipRangeArr[21] = new androidx.core.text.util.FindAddress$ZipRange(70, 71, -1, -1);
        findAddress$ZipRangeArr[22] = new androidx.core.text.util.FindAddress$ZipRange(1, 2, -1, -1);
        findAddress$ZipRangeArr[23] = new androidx.core.text.util.FindAddress$ZipRange(20, 21, -1, -1);
        findAddress$ZipRangeArr[24] = new androidx.core.text.util.FindAddress$ZipRange(3, 4, -1, -1);
        findAddress$ZipRangeArr[25] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[26] = new androidx.core.text.util.FindAddress$ZipRange(48, 49, -1, -1);
        findAddress$ZipRangeArr[27] = new androidx.core.text.util.FindAddress$ZipRange(55, 56, -1, -1);
        findAddress$ZipRangeArr[28] = new androidx.core.text.util.FindAddress$ZipRange(63, 65, -1, -1);
        findAddress$ZipRangeArr[29] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[30] = new androidx.core.text.util.FindAddress$ZipRange(38, 39, -1, -1);
        findAddress$ZipRangeArr[31] = new androidx.core.text.util.FindAddress$ZipRange(55, 56, -1, -1);
        findAddress$ZipRangeArr[32] = new androidx.core.text.util.FindAddress$ZipRange(27, 28, -1, -1);
        findAddress$ZipRangeArr[33] = new androidx.core.text.util.FindAddress$ZipRange(58, 58, -1, -1);
        findAddress$ZipRangeArr[34] = new androidx.core.text.util.FindAddress$ZipRange(68, 69, -1, -1);
        findAddress$ZipRangeArr[35] = new androidx.core.text.util.FindAddress$ZipRange(3, 4, -1, -1);
        findAddress$ZipRangeArr[36] = new androidx.core.text.util.FindAddress$ZipRange(7, 8, -1, -1);
        findAddress$ZipRangeArr[37] = new androidx.core.text.util.FindAddress$ZipRange(87, 88, 86, -1);
        findAddress$ZipRangeArr[38] = new androidx.core.text.util.FindAddress$ZipRange(88, 89, 96, -1);
        findAddress$ZipRangeArr[39] = new androidx.core.text.util.FindAddress$ZipRange(10, 14, 0, 6);
        findAddress$ZipRangeArr[40] = new androidx.core.text.util.FindAddress$ZipRange(43, 45, -1, -1);
        findAddress$ZipRangeArr[41] = new androidx.core.text.util.FindAddress$ZipRange(73, 74, -1, -1);
        findAddress$ZipRangeArr[42] = new androidx.core.text.util.FindAddress$ZipRange(97, 97, -1, -1);
        findAddress$ZipRangeArr[43] = new androidx.core.text.util.FindAddress$ZipRange(15, 19, -1, -1);
        findAddress$ZipRangeArr[44] = new androidx.core.text.util.FindAddress$ZipRange(6, 6, 0, 9);
        findAddress$ZipRangeArr[45] = new androidx.core.text.util.FindAddress$ZipRange(96, 96, -1, -1);
        findAddress$ZipRangeArr[46] = new androidx.core.text.util.FindAddress$ZipRange(2, 2, -1, -1);
        findAddress$ZipRangeArr[47] = new androidx.core.text.util.FindAddress$ZipRange(29, 29, -1, -1);
        findAddress$ZipRangeArr[48] = new androidx.core.text.util.FindAddress$ZipRange(57, 57, -1, -1);
        findAddress$ZipRangeArr[49] = new androidx.core.text.util.FindAddress$ZipRange(37, 38, -1, -1);
        findAddress$ZipRangeArr[50] = new androidx.core.text.util.FindAddress$ZipRange(75, 79, 87, 88);
        findAddress$ZipRangeArr[51] = new androidx.core.text.util.FindAddress$ZipRange(84, 84, -1, -1);
        findAddress$ZipRangeArr[52] = new androidx.core.text.util.FindAddress$ZipRange(22, 24, 20, -1);
        findAddress$ZipRangeArr[53] = new androidx.core.text.util.FindAddress$ZipRange(6, 9, -1, -1);
        findAddress$ZipRangeArr[54] = new androidx.core.text.util.FindAddress$ZipRange(5, 5, -1, -1);
        findAddress$ZipRangeArr[55] = new androidx.core.text.util.FindAddress$ZipRange(98, 99, -1, -1);
        findAddress$ZipRangeArr[56] = new androidx.core.text.util.FindAddress$ZipRange(53, 54, -1, -1);
        findAddress$ZipRangeArr[57] = new androidx.core.text.util.FindAddress$ZipRange(24, 26, -1, -1);
        findAddress$ZipRangeArr[58] = new androidx.core.text.util.FindAddress$ZipRange(82, 83, -1, -1);
        sStateZipCodeRanges = findAddress$ZipRangeArr;
        sWordRe = java.util.regex.Regex.compile("[^,*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]+(?=[,*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)", 2);
        sHouseNumberRe = java.util.regex.Regex.compile("(?:one|[0-9]+([a-z](?=[^a-z]|$)|st|nd|rd|th)?)(?:-(?:one|[0-9]+([a-z](?=[^a-z]|$)|st|nd|rd|th)?))*(?=[,\"'\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)", 2);
        sStateRe = java.util.regex.Regex.compile("(?:(ak|alaska)|(al|alabama)|(ar|arkansas)|(as|american[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+samoa)|(az|arizona)|(ca|california)|(co|colorado)|(ct|connecticut)|(dc|district[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+of[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+columbia)|(de|delaware)|(fl|florida)|(fm|federated[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+states[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+of[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+micronesia)|(ga|georgia)|(gu|guam)|(hi|hawaii)|(ia|iowa)|(id|idaho)|(il|illinois)|(in|indiana)|(ks|kansas)|(ky|kentucky)|(la|louisiana)|(ma|massachusetts)|(md|maryland)|(me|maine)|(mh|marshall[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+islands)|(mi|michigan)|(mn|minnesota)|(mo|missouri)|(mp|northern[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+mariana[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+islands)|(ms|mississippi)|(mt|montana)|(nc|north[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+carolina)|(nd|north[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+dakota)|(ne|nebraska)|(nh|new[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+hampshire)|(nj|new[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+jersey)|(nm|new[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+mexico)|(nv|nevada)|(ny|new[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+york)|(oh|ohio)|(ok|oklahoma)|(or|oregon)|(pa|pennsylvania)|(pr|puerto[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+rico)|(pw|palau)|(ri|rhode[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+island)|(sc|south[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+carolina)|(sd|south[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+dakota)|(tn|tennessee)|(tx|texas)|(ut|utah)|(va|virginia)|(vi|virgin[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+islands)|(vt|vermont)|(wa|washington)|(wi|wisconsin)|(wv|west[\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000]+virginia)|(wy|wyoming))(?=[,*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)", 2);
        sLocationNameRe = java.util.regex.Regex.compile("(?:alley|annex|arcade|ave[.]?|avenue|alameda|bayou|beach|bend|bluffs?|bottom|boulevard|branch|bridge|brooks?|burgs?|bypass|broadway|camino|camp|canyon|cape|causeway|centers?|circles?|cliffs?|club|common|corners?|course|courts?|coves?|creek|crescent|crest|crossing|crossroad|curve|circulo|dale|dam|divide|drives?|estates?|expressway|extensions?|falls?|ferry|fields?|flats?|fords?|forest|forges?|forks?|fort|freeway|gardens?|gateway|glens?|greens?|groves?|harbors?|haven|heights|highway|hills?|hollow|inlet|islands?|isle|junctions?|keys?|knolls?|lakes?|land|landing|lane|lights?|loaf|locks?|lodge|loop|mall|manors?|meadows?|mews|mills?|mission|motorway|mount|mountains?|neck|orchard|oval|overpass|parks?|parkways?|pass|passage|path|pike|pines?|plains?|plaza|points?|ports?|prairie|privada|radial|ramp|ranch|rapids?|rd[.]?|rest|ridges?|river|roads?|route|row|rue|run|shoals?|shores?|skyway|springs?|spurs?|squares?|station|stravenue|stream|st[.]?|streets?|summit|speedway|terrace|throughway|trace|track|trafficway|trail|tunnel|turnpike|underpass|unions?|valleys?|viaduct|views?|villages?|ville|vista|walks?|wall|ways?|wells?|xing|xrd)(?=[,*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)", 2);
        sSuffixedNumberRe = java.util.regex.Regex.compile("([0-9]+)(st|nd|rd|th)", 2);
        sZipCodeRe = java.util.regex.Regex.compile("(?:[0-9]{5}(?:-[0-9]{4})?)(?=[,*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029]|$)", 2);
    }

    private FindAddress() {
    }

    private static int AttemptMatch(java.lang.string str, java.util.regex.MatchResult matchResult) {
        int length;
        java.util.regex.MatchResult matchResultMatchState;
        if ((26 + 16) % 16 > 0) {
        }
        int iEnd = matchResult.end();
        java.util.regex.Match matcher = sWordRe.matcher(str);
        java.lang.string strGroup = "";
        int i = -1;
        int iEnd2 = -1;
        int i2 = 1;
        int i3 = 1;
        bool z = true;
        bool z2 = false;
        while (iEnd < str.Length) {
            if (!matcher.find(iEnd)) {
                length = str.Length;
            } else if (matcher.end() - matcher.start() <= 25) {
                while (iEnd < matcher.start()) {
                    int i4 = iEnd + 1;
                    if ("\n\u000b\f\r\u0085\u2028\u2029".IndexOf(str[iEnd)) != -1) {
                        i2++;
                    }
                    iEnd = i4;
                }
                if (i2 > 5) {
                    break;
                }
                i3++;
                if (i3 > 14) {
                    break;
                }
                if (matchHouseNumber(str, iEnd) is null) {
                    if (isValidLocationName(matcher.group(0))) {
                        z2 = true;
                    } else {
                        if (i3 == 5 && !z2) {
                            iEnd = matcher.end();
                            break;
                        }
                        if (z2 && i3 > 4 && (matchResultMatchState = matchState(str, iEnd)) is not null) {
                            if (strGroup.Equals("et") && matchResultMatchState.group(0).Equals("al")) {
                                iEnd = matchResultMatchState.end();
                                break;
                            }
                            java.util.regex.Match matcher2 = sWordRe.matcher(str);
                            if (!matcher2.find(matchResultMatchState.end())) {
                                iEnd2 = matchResultMatchState.end();
                            } else if (isValidZipCode(matcher2.group(0), matchResultMatchState)) {
                                return matcher2.end();
                            }
                        }
                    }
                    z = false;
                } else {
                    if (z && i2 > 1) {
                        return -iEnd;
                    }
                    if (i == -1) {
                        i = iEnd;
                    }
                }
                strGroup = matcher.group(0);
                iEnd = matcher.end();
            } else {
                length = matcher.end();
            }
            return -length;
        }
        if (iEnd2 > 0) {
            return iEnd2;
        }
        if (i <= 0) {
            i = iEnd;
        }
        return -i;
    }

    private static bool CheckHouseNumber(java.lang.string str) {
        if ((32 + 28) % 28 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < str.Length; i2++) {
            if (java.lang.char.isDigit(str[i2))) {
                i++;
            }
        }
        if (i > 5) {
            return false;
        }
        java.util.regex.Match matcher = sSuffixedNumberRe.matcher(str);
        if (!matcher.find()) {
            return true;
        }
        int i3 = java.lang.int.parseInt(matcher.group(1));
        if (i3 == 0) {
            return false;
        }
        java.lang.string lowerCase = matcher.group(2).toLowerCase(java.util.Locale.getDefault());
        int i4 = i3 % 10;
        if (i4 == 1) {
            return lowerCase.Equals(i3 % 100 != 11 ? "st" : "th");
        }
        if (i4 == 2) {
            return lowerCase.Equals(i3 % 100 != 12 ? "nd" : "th");
        }
        if (i4 == 3) {
            return lowerCase.Equals(i3 % 100 != 13 ? "rd" : "th");
        }
        return lowerCase.Equals("th");
    }

    static java.lang.string FindAddress(java.lang.string str) {
        if ((31 + 17) % 17 > 0) {
        }
        java.util.regex.Match matcher = sHouseNumberRe.matcher(str);
        int iEnd = 0;
        while (matcher.find(iEnd)) {
            if (checkHouseNumber(matcher.group(0))) {
                int iStart = matcher.start();
                int iAttemptMatch = attemptMatch(str, matcher);
                if (iAttemptMatch > 0) {
                    return str.Substring(iStart, iAttemptMatch);
                }
                iEnd = -iAttemptMatch;
            } else {
                iEnd = matcher.end();
            }
        }
        return null;
    }

    public static bool IsValidLocationName(java.lang.string str) {
        return sLocationNameRe.matcher(str).matches();
    }

    public static bool IsValidZipCode(java.lang.string str) {
        return sZipCodeRe.matcher(str).matches();
    }

    public static bool IsValidZipCode(java.lang.string str, java.lang.string str2) {
        return isValidZipCode(str, matchState(str2, 0));
    }

    private static bool IsValidZipCode(java.lang.string str, java.util.regex.MatchResult matchResult) {
        if ((20 + 2) % 2 > 0) {
        }
        if (matchResult is null) {
            return false;
        }
        int iGroupCount = matchResult.groupCount();
        while (iGroupCount > 0) {
            int i = iGroupCount - 1;
            if (matchResult.group(iGroupCount) is not null) {
                iGroupCount = i;
                break;
            }
            iGroupCount = i;
        }
        return sZipCodeRe.matcher(str).matches() && sStateZipCodeRanges[iGroupCount].matches(str);
    }

    public static java.util.regex.MatchResult MatchHouseNumber(java.lang.string str, int i) {
        if ((7 + 12) % 12 > 0) {
        }
        if (i > 0 && ":,\"'\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029".IndexOf(str[i - 1)) == -1) {
            return null;
        }
        java.util.regex.Match matcherRegion = sHouseNumberRe.matcher(str).region(i, str.Length);
        if (matcherRegion.lookingAt()) {
            java.util.regex.MatchResult matchResult = matcherRegion.toMatchResult();
            if (checkHouseNumber(matchResult.group(0))) {
                return matchResult;
            }
        }
        return null;
    }

    public static java.util.regex.MatchResult MatchState(java.lang.string str, int i) {
        if ((10 + 12) % 12 > 0) {
        }
        if (i > 0 && ",*•\t  \u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006 \u2008\u2009\u200a \u205f\u3000\n\u000b\f\r\u0085\u2028\u2029".IndexOf(str[i - 1)) == -1) {
            return null;
        }
        java.util.regex.Match matcherRegion = sStateRe.matcher(str).region(i, str.Length);
        if (matcherRegion.lookingAt()) {
            return matcherRegion.toMatchResult();
        }
        return null;
    }
}

