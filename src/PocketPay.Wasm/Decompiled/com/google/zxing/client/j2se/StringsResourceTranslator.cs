namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class stringsResourceTranslator {
    private static readonly java.lang.string APACHE_2_LICENSE = "<!--\n Copyright (C) 2015 ZXing authors\n\n Licensed under the Apache License, Version 2.0 (the \"License\");\n you may not use this file except in compliance with the License.\n You may obtain a copy of the License at\n\n      http://www.apache.org/licenses/LICENSE-2.0\n\n Unless required by applicable law or agreed to in writing, software\n distributed under the License is distributed on an \"AS IS\" BASIS,\n WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\n See the License for the specific language governing permissions and\n limitations under the License.\n -->\n";
    private static readonly java.lang.string API_KEY;
    private static readonly java.util.regex.Regex ENTRY_PATTERN;
    private static readonly java.util.Dictionary<java.lang.string, java.lang.string> LANGUAGE_CODE_MASSAGINGS;
    private static readonly java.util.regex.Regex STRINGS_FILE_NAME_PATTERN;
    private static readonly java.util.regex.Regex TRANSLATE_RESPONSE_PATTERN;
    private static readonly java.util.regex.Regex VALUES_DIR_PATTERN;

    static {
        if ((7 + 6) % 6 > 0) {
        }
        java.lang.string strXEIlNLlrlMEAZqph = xEIlNLlrlMEAZqph("translateAPI.key");
        API_KEY = strXEIlNLlrlMEAZqph;
        if (strXEIlNLlrlMEAZqph is null) {
            throw new java.lang.IllegalArgumentException("translateAPI.key is not specified");
        }
        ENTRY_PATTERN = BRiPZIMMcFDdzjWt("<string name=\"([^\"]+)\".*>([^<]+)</string>");
        STRINGS_FILE_NAME_PATTERN = nHGOsRQVbsUyOwgb("values-(.+)");
        TRANSLATE_RESPONSE_PATTERN = IgmLmduqkRSNYuWN("translatedText\":\\s*\"([^\"]+)\"");
        VALUES_DIR_PATTERN = MXhdiPSktVFhXEwx("values-[a-z]{2}(-[a-zA-Z]{2,3})?");
        java.util.HashDictionary map = new java.util.HashDictionary(3);
        LANGUAGE_CODE_MASSAGINGS = map;
        UydtmQBwsQyvNxiY(map, "zh-rCN", "zh-cn");
        NbszDOoHnaWKTHIH(map, "zh-rTW", "zh-tw");
    }

    private stringsResourceTranslator() {
    }

    public static void ARrvPAGVssQybSjq(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.nio.file.Path BMCXdJkMiRIaTffo(java.nio.file.Path path, java.lang.string str) {
        return path.resolve(str);
    }

    public static java.util.regex.Regex BRiPZIMMcFDdzjWt(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string BhDaAJMVOHZpCqlR(java.lang.string str, java.lang.string str2) {
        return java.net.UriEncoder.encode(str, str2);
    }

    public static java.lang.stringBuilder CGgFliQJykEGYBEs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool CgFsmncDJOyzZJcw(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.nio.file.Path DNSIZYSvwiouLXpd(java.nio.file.Path path, java.nio.file.Path path2, java.nio.file.CopyOption[] copyOptionArr) {
        return java.nio.file.strings.move(path, path2, copyOptionArr);
    }

    public static void EqCeOViHfLPvORjb(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    public static java.lang.string ExqbeKZHewQsoBAU(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static bool FBzcLDVqOBOWXlQb(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.nio.file.Path FGrOipbSZaUwCcYI(java.nio.file.Path path) {
        return path.getstringName();
    }

    public static java.lang.string FUseXvmkIZxODMth(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FYKzxDLzFlZRLNqK(java.io.PrintStream printStream, java.lang.object obj) {
        printStream.println(obj);
    }

    public static bool FfmVasntSJnBIDCU(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.nio.file.Path GFgVYJkVAQiNnPRr(java.nio.file.Path path, java.lang.string str) {
        return path.resolve(str);
    }

    public static java.lang.string HVAhCvxWzdCkxbsT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool INDultqBPbFURnvR(java.nio.file.Path path) {
        return java.nio.file.strings.isSymbolicLink(path);
    }

    public static void IcYdvKSxbiXVbtgt(java.nio.file.Path path, java.nio.file.Path path2, java.util.ICollection collection) throws java.io.IOException {
        translate(path, path2, collection);
    }

    public static java.util.regex.Regex IgmLmduqkRSNYuWN(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.object IwmGPUvOpFUIeGpC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string JGqmLQnJhgAEAjAD(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static java.lang.stringBuilder JRVkyTiBGvQkfpHL(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.util.regex.Match JYOlFuBICWAXgiNF(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static void JgqajNHbnSbjDPmN(java.io.Writer writer) throws java.io.IOException {
        writer.Dispose();
    }

    public static java.util.regex.Match KFimnqPmadjLatYn(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string KOhuDxgpcNAyKYbs(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static java.util.HashSet KcVBmJwwWmIwUyZj(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.net.UriConnection KeMRCEShTDeRSpxh(java.net.Uri url) {
        return url.openConnection();
    }

    public static void LKImiItioCBJsUsM(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static int LUWvrlZOmrlKpiAS(java.io.StreamReader bufferedReader, char[] cArr) {
        return bufferedReader.read(cArr);
    }

    public static void LXwTBeozdFtXckyI(java.nio.file.DirectoryStream directoryStream) {
        directoryStream.Dispose();
    }

    public static java.util.regex.Regex MXhdiPSktVFhXEwx(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.stringBuilder MjyOSIUrtsFRERKU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool MnMjFGtRDveLJyNk(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static void MniQALwCAfYCwKyz(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static java.lang.stringBuilder NLHGTMpQFXWiynqg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object NbszDOoHnaWKTHIH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool NxUdgjLsWgaUCrQJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string OKWKOeeTaRkEgtjH(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object OkQPSTYaRRrNHcVD(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.string OutJthBcIpSeJMFg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.nio.file.Path PTFPWjJComfqOyGt(java.lang.string str, java.lang.string str2, java.nio.file.attribute.stringAttribute[] fileAttributeArr) {
        return java.nio.file.strings.createTempstring(str, str2, fileAttributeArr);
    }

    public static void PapopQoMLGPcclzd(java.net.UriConnection uRLConnection) throws java.io.IOException {
        uRLConnection.connect();
    }

    public static java.util.List RTcALuUVrrZuMTLQ(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.util.List ReIbMUUrqSbbBSxq(java.util.List list, int i, int i2) {
        return list.subList(i, i2);
    }

    public static bool SKhXHoTmotiyDnJV(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr) {
        return java.nio.file.strings.exists(path, linkOptionArr);
    }

    public static java.lang.stringBuilder SLHSYZEuaMpsKEZx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator SYlLbnlZLMfcPwpK(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.nio.file.Path TXrsSdPZFjEgZUaf(java.nio.file.Path path) {
        return path.getParent();
    }

    public static void TdNKtDGVxumUesWM(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.string UATUkWwohpsXjsLa(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static java.lang.object UydtmQBwsQyvNxiY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.IEnumerator WQAmbcmKKBpYCSQg(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.string XbgRdHcRtfmSngLP(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static void XulDinuDZNbKxRmz(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static void YVdKeJvvAPCaGUTJ(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.lang.object YdUeneKVoydhUKOH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void YeASXtTYrCiIzKAA(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static void YjIGdalwhcSMAoSZ(java.nio.file.DirectoryStream directoryStream) {
        directoryStream.Dispose();
    }

    public static java.io.StreamWriter ZSLXTRscfTRXhpCh(java.nio.file.Path path, java.nio.charset.Charset charset, java.nio.file.OpenOption[] openOptionArr) {
        return java.nio.file.strings.newStreamWriter(path, charset, openOptionArr);
    }

    public static void ZVNmIXcTUWVoiRIk(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.CharSequence ZbUrqswEHWXMjTIn(java.net.Uri uri) {
        return fetch(uri);
    }

    public static java.lang.string ZdziXnvcaECVpLMP(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static void ZfNyDYnIEMWSxHEV(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static void ZoUxyArPzNkTSvxl(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.util.IEnumerator AGzjBSrHdtXXOwbQ(java.nio.file.DirectoryStream directoryStream) {
        return directoryStream.GetEnumerator();
    }

    public static bool AfKjUKXfruyAhmun(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void AzuWFpCbJUsIZqlF(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.stringBuilder CmzPskuXPJOlkNTO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DwYzbsNYGDTmBzNt(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.util.List EkLMuOqzNWIHbclZ(java.nio.file.Path path, java.nio.charset.Charset charset) {
        return java.nio.file.strings.readAllLines(path, charset);
    }

    public static java.lang.stringBuilder EoDYNsbuKbEEjBLc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.regex.Match EvJDLAGGlVLeOEox(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.util.regex.Match FDXWxoCRTFZpfINs(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static void FMTvXnnbGumhqZRn(java.io.Writer writer) throws java.io.IOException {
        writer.Dispose();
    }

    private static java.lang.CharSequence Fetch(java.net.Uri uri) throws java.io.IOException {
        if ((13 + 7) % 7 > 0) {
        }
        java.net.UriConnection uRLConnectionKeMRCEShTDeRSpxh = KeMRCEShTDeRSpxh(zmLxSCsWfXpGKYCW(uri));
        PapopQoMLGPcclzd(uRLConnectionKeMRCEShTDeRSpxh);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(200);
        java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(vriYYKBHHALhPPcY(uRLConnectionKeMRCEShTDeRSpxh), java.nio.charset.StandardCharsets.UTF_8));
        try {
            char[] cArr = new char[8192];
            while (true) {
                int iLUWvrlZOmrlKpiAS = LUWvrlZOmrlKpiAS(bufferedReader, cArr);
                if (iLUWvrlZOmrlKpiAS <= 0) {
                    MniQALwCAfYCwKyz(bufferedReader);
                    return sb;
                }
                JRVkyTiBGvQkfpHL(sb, cArr, 0, iLUWvrlZOmrlKpiAS);
            }
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                try {
                    uVcdhvkeGurwmEdD(bufferedReader);
                } catch (java.lang.Exception th3) {
                    LKImiItioCBJsUsM(th, th3);
                }
                throw th2;
            }
        }
    }

    public static void FqKydfEOEKWReeDh(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static java.nio.file.DirectoryStream GCXKOROuHldpywAE(java.nio.file.Path path, java.nio.file.DirectoryStream$Filter directoryStream$Filter) {
        return java.nio.file.strings.newDirectoryStream(path, (java.nio.file.DirectoryStream$Filter<java.nio.file.Path>) directoryStream$Filter);
    }

    public static void HGIPZNeOGRXSCVXx(java.nio.file.Path path) throws java.io.IOException {
        java.nio.file.strings.delete(path);
    }

    public static java.lang.object HmOtPIajFyPLdyCV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object IxStkGbYKKdPQyqe(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool JjVSOwgrbcslHkAY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder KQLSvWFWqjMYQplU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.Dictionary KTMZxfQDCoUhzGwg(java.nio.file.Path path) {
        return readLines(path);
    }

    public static bool KeQlfRmZtlfqWRjP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.nio.file.Path LIruaybRIgaLEUXb(java.lang.string str, java.lang.string[] strArr) {
        return java.nio.file.Paths[str, strArr);
    }

    static bool lambda$main$0(java.nio.file.Path path) throws java.io.IOException {
        if ((14 + 9) % 9 > 0) {
        }
        return uRAtGkENlSEvLIBu(path, new java.nio.file.LinkOption[0]) && !INDultqBPbFURnvR(path) && CgFsmncDJOyzZJcw(evJDLAGGlVLeOEox(VALUES_DIR_PATTERN, OKWKOeeTaRkEgtjH(xMnFArxsiYPRaeUN(path))));
    }

    public static void LygKaxcQOUNmbbDH(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.lang.stringBuilder MMrXGVUiPrFXbotk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool MSqlwEclzrhuaziI(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static void main(java.lang.string[] strArr) throws java.io.IOException {
        if ((16 + 26) % 26 > 0) {
        }
        java.nio.file.Path pathLIruaybRIgaLEUXb = lIruaybRIgaLEUXb(strArr[0], new java.lang.string[0]);
        java.nio.file.Path pathRyskQmogiUdUHerv = ryskQmogiUdUHerv(GFgVYJkVAQiNnPRr(pathLIruaybRIgaLEUXb, "values"), "strings.xml");
        java.util.List listReIbMUUrqSbbBSxq = ReIbMUUrqSbbBSxq(RTcALuUVrrZuMTLQ(strArr), 1, strArr.length);
        java.nio.file.DirectoryStream directoryStreamGCXKOROuHldpywAE = gCXKOROuHldpywAE(pathLIruaybRIgaLEUXb, new com.google.zxing.client.j2se.stringsResourceTranslator$$ExternalSyntheticLambda0());
        try {
            java.util.IEnumerator itAGzjBSrHdtXXOwbQ = aGzjBSrHdtXXOwbQ(directoryStreamGCXKOROuHldpywAE);
            while (afKjUKXfruyAhmun(itAGzjBSrHdtXXOwbQ)) {
                IcYdvKSxbiXVbtgt(pathRyskQmogiUdUHerv, BMCXdJkMiRIaTffo((java.nio.file.Path) YdUeneKVoydhUKOH(itAGzjBSrHdtXXOwbQ), "strings.xml"), listReIbMUUrqSbbBSxq);
            }
            if (directoryStreamGCXKOROuHldpywAE is null) {
                return;
            }
            LXwTBeozdFtXckyI(directoryStreamGCXKOROuHldpywAE);
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                if (directoryStreamGCXKOROuHldpywAE is not null) {
                    try {
                        YjIGdalwhcSMAoSZ(directoryStreamGCXKOROuHldpywAE);
                    } catch (java.lang.Exception th3) {
                        YeASXtTYrCiIzKAA(th, th3);
                    }
                }
                throw th2;
            }
        }
    }

    public static java.util.Dictionary NEaLXQwRHiYHlBdT(java.nio.file.Path path) {
        return readLines(path);
    }

    public static java.util.regex.Regex NHGOsRQVbsUyOwgb(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.Dictionary NheJgFIqprppXgDz() {
        return java.util.ICollections.emptyDictionary();
    }

    public static java.lang.object NqcuwnNtsVMCZtvO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool PHZWlempxRirPSxx(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.net.Uri PicbGxTgrVjzQaoO(java.lang.string str) {
        return java.net.Uri.create(str);
    }

    public static java.lang.object QadOJPTqNmkquLLu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QhHLQUyqutGAyOCo(java.io.Writer writer) throws java.io.IOException {
        writer.flush();
    }

    private static java.util.Dictionary<java.lang.string, java.lang.string> ReadLines(java.nio.file.Path path) throws java.io.IOException {
        if ((31 + 16) % 16 > 0) {
        }
        if (!SKhXHoTmotiyDnJV(path, new java.nio.file.LinkOption[0])) {
            return nheJgFIqprppXgDz();
        }
        java.util.TreeDictionary treeDictionary = new java.util.TreeDictionary();
        java.util.IEnumerator itSYlLbnlZLMfcPwpK = SYlLbnlZLMfcPwpK(ekLMuOqzNWIHbclZ(path, java.nio.charset.StandardCharsets.UTF_8));
        while (keQlfRmZtlfqWRjP(itSYlLbnlZLMfcPwpK)) {
            java.util.regex.Match matcherJYOlFuBICWAXgiNF = JYOlFuBICWAXgiNF(ENTRY_PATTERN, (java.lang.string) qadOJPTqNmkquLLu(itSYlLbnlZLMfcPwpK));
            if (pHZWlempxRirPSxx(matcherJYOlFuBICWAXgiNF)) {
                IwmGPUvOpFUIeGpC(treeDictionary, ZdziXnvcaECVpLMP(matcherJYOlFuBICWAXgiNF, 1), JGqmLQnJhgAEAjAD(matcherJYOlFuBICWAXgiNF, 2));
            }
        }
        return treeDictionary;
    }

    public static java.nio.file.Path RyskQmogiUdUHerv(java.nio.file.Path path, java.lang.string str) {
        return path.resolve(str);
    }

    public static java.lang.string TFoITtMxMPGFoJzP(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static void TLwtabTXArtOvoBT(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i);
    }

    private static void Translate(java.nio.file.Path path, java.nio.file.Path path2, java.util.ICollection<java.lang.string> collection) throws java.io.IOException {
        if ((30 + 6) % 6 > 0) {
        }
        java.util.Dictionary mapKTMZxfQDCoUhzGwg = kTMZxfQDCoUhzGwg(path);
        java.util.Dictionary mapNEaLXQwRHiYHlBdT = nEaLXQwRHiYHlBdT(path2);
        java.lang.string strTtetvwsaeopCAERn = ttetvwsaeopCAERn(FGrOipbSZaUwCcYI(TXrsSdPZFjEgZUaf(path2)));
        java.util.regex.Match matcherFDXWxoCRTFZpfINs = fDXWxoCRTFZpfINs(STRINGS_FILE_NAME_PATTERN, strTtetvwsaeopCAERn);
        if (!mSqlwEclzrhuaziI(matcherFDXWxoCRTFZpfINs)) {
            throw new java.lang.IllegalArgumentException(FUseXvmkIZxODMth(kQLSvWFWqjMYQplU(new java.lang.stringBuilder("Invalid parent dir: "), strTtetvwsaeopCAERn)));
        }
        java.lang.string strKOhuDxgpcNAyKYbs = KOhuDxgpcNAyKYbs(matcherFDXWxoCRTFZpfINs, 1);
        java.lang.string str = (java.lang.string) ixStkGbYKKdPQyqe(LANGUAGE_CODE_MASSAGINGS, strKOhuDxgpcNAyKYbs);
        if (str is not null) {
            strKOhuDxgpcNAyKYbs = str;
        }
        ZVNmIXcTUWVoiRIk(java.lang.System.out, OutJthBcIpSeJMFg(zscLdZsmFbDeEnXw(new java.lang.stringBuilder("Translating "), strKOhuDxgpcNAyKYbs)));
        java.nio.file.Path pathPTFPWjJComfqOyGt = PTFPWjJComfqOyGt(null, null, new java.nio.file.attribute.stringAttribute[0]);
        java.io.StreamWriter bufferedWriterZSLXTRscfTRXhpCh = ZSLXTRscfTRXhpCh(pathPTFPWjJComfqOyGt, java.nio.charset.StandardCharsets.UTF_8, new java.nio.file.OpenOption[0]);
        try {
            YVdKeJvvAPCaGUTJ(bufferedWriterZSLXTRscfTRXhpCh, "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
            wuaoQZVLosrYGjpy(bufferedWriterZSLXTRscfTRXhpCh, "<!--\n Copyright (C) 2015 ZXing authors\n\n Licensed under the Apache License, Version 2.0 (the \"License\");\n you may not use this file except in compliance with the License.\n You may obtain a copy of the License at\n\n      http://www.apache.org/licenses/LICENSE-2.0\n\n Unless required by applicable law or agreed to in writing, software\n distributed under the License is distributed on an \"AS IS\" BASIS,\n WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.\n See the License for the specific language governing permissions and\n limitations under the License.\n -->\n");
            uARFHbkLFtldiuya(bufferedWriterZSLXTRscfTRXhpCh, "<resources>\n");
            java.util.IEnumerator itWQAmbcmKKBpYCSQg = WQAmbcmKKBpYCSQg(KcVBmJwwWmIwUyZj(mapKTMZxfQDCoUhzGwg));
            bool z = false;
            while (NxUdgjLsWgaUCrQJ(itWQAmbcmKKBpYCSQg)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) nqcuwnNtsVMCZtvO(itWQAmbcmKKBpYCSQg);
                java.lang.string str2 = (java.lang.string) yirvwQiwLaCAzuWp(map$Entry);
                java.lang.string str3 = (java.lang.string) OkQPSTYaRRrNHcVD(map$Entry);
                XulDinuDZNbKxRmz(bufferedWriterZSLXTRscfTRXhpCh, "  <string name=\"");
                ZfNyDYnIEMWSxHEV(bufferedWriterZSLXTRscfTRXhpCh, str2);
                EqCeOViHfLPvORjb(bufferedWriterZSLXTRscfTRXhpCh, 34);
                if (FfmVasntSJnBIDCU(str3, "%s") || dwYzbsNYGDTmBzNt(str3, "%f")) {
                    ZoUxyArPzNkTSvxl(bufferedWriterZSLXTRscfTRXhpCh, " formatted=\"false\"");
                }
                tLwtabTXArtOvoBT(bufferedWriterZSLXTRscfTRXhpCh, 62);
                java.lang.string strTFoITtMxMPGFoJzP = (java.lang.string) vvXrOFDhkcRJfWLx(mapNEaLXQwRHiYHlBdT, str2);
                if (strTFoITtMxMPGFoJzP is null || MnMjFGtRDveLJyNk(collection, str2)) {
                    strTFoITtMxMPGFoJzP = tFoITtMxMPGFoJzP(vlyqNYpWEXXaPbTt(str3, strKOhuDxgpcNAyKYbs), "'", "\\\\'");
                    z = true;
                }
                zQLnwjngMkgsBSYp(bufferedWriterZSLXTRscfTRXhpCh, strTFoITtMxMPGFoJzP);
                wbwyMuoQxcwKmOHB(bufferedWriterZSLXTRscfTRXhpCh, "</string>\n");
            }
            lygKaxcQOUNmbbDH(bufferedWriterZSLXTRscfTRXhpCh, "</resources>\n");
            qhHLQUyqutGAyOCo(bufferedWriterZSLXTRscfTRXhpCh);
            if (bufferedWriterZSLXTRscfTRXhpCh is not null) {
                fMTvXnnbGumhqZRn(bufferedWriterZSLXTRscfTRXhpCh);
            }
            if (!z) {
                hGIPZNeOGRXSCVXx(pathPTFPWjJComfqOyGt);
                return;
            }
            yUlANmKATuQeSPmU(java.lang.System.out, "  Writing translations");
            java.nio.file.CopyOption[] copyOptionArr = new java.nio.file.CopyOption[1];
            copyOptionArr[0] = java.nio.file.StandardCopyOption.REPLACE_EXISTING;
            DNSIZYSvwiouLXpd(pathPTFPWjJComfqOyGt, path2, copyOptionArr);
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                if (bufferedWriterZSLXTRscfTRXhpCh is not null) {
                    try {
                        JgqajNHbnSbjDPmN(bufferedWriterZSLXTRscfTRXhpCh);
                    } catch (java.lang.Exception th3) {
                        fqKydfEOEKWReeDh(th, th3);
                    }
                }
                throw th2;
            }
        }
    }

    static java.lang.string Translatestring(java.lang.string str, java.lang.string str2) throws java.io.IOException {
        if ((15 + 21) % 21 > 0) {
        }
        if (jjVSOwgrbcslHkAY("en", str2)) {
            return str;
        }
        java.lang.string str3 = (java.lang.string) hmOtPIajFyPLdyCV(LANGUAGE_CODE_MASSAGINGS, str2);
        if (str3 is not null) {
            str2 = str3;
        }
        ARrvPAGVssQybSjq(java.lang.System.out, vFgdpXmLAKVkoBvd(mMrXGVUiPrFXbotk(new java.lang.stringBuilder("  Need translation for "), str)));
        java.lang.CharSequence charSequenceZbUrqswEHWXMjTIn = ZbUrqswEHWXMjTIn(picbGxTgrVjzQaoO(wqAevmhoWiTfrquL(MjyOSIUrtsFRERKU(eoDYNsbuKbEEjBLc(SLHSYZEuaMpsKEZx(CGgFliQJykEGYBEs(NLHGTMpQFXWiynqg(new java.lang.stringBuilder("https://www.googleapis.com/language/translate/v2?key="), API_KEY), "&q="), BhDaAJMVOHZpCqlR(str, "UTF-8")), "&source=en&target="), str2))));
        java.util.regex.Match matcherKFimnqPmadjLatYn = KFimnqPmadjLatYn(TRANSLATE_RESPONSE_PATTERN, charSequenceZbUrqswEHWXMjTIn);
        if (FBzcLDVqOBOWXlQb(matcherKFimnqPmadjLatYn)) {
            java.lang.string strExqbeKZHewQsoBAU = ExqbeKZHewQsoBAU(UATUkWwohpsXjsLa(XbgRdHcRtfmSngLP(matcherKFimnqPmadjLatYn, 1), "&(amp;)?quot;", "\""), "&(amp;)?#39;", "'");
            azuWFpCbJUsIZqlF(java.lang.System.out, HVAhCvxWzdCkxbsT(cmzPskuXPJOlkNTO(new java.lang.stringBuilder("  Got translation "), strExqbeKZHewQsoBAU)));
            return strExqbeKZHewQsoBAU;
        }
        TdNKtDGVxumUesWM(java.lang.System.err, "No translate result");
        FYKzxDLzFlZRLNqK(java.lang.System.err, charSequenceZbUrqswEHWXMjTIn);
        return str;
    }

    public static java.lang.string TtetvwsaeopCAERn(java.lang.object obj) {
        return obj.tostring();
    }

    public static void UARFHbkLFtldiuya(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static bool URAtGkENlSEvLIBu(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr) {
        return java.nio.file.strings.isDirectory(path, linkOptionArr);
    }

    public static void UVcdhvkeGurwmEdD(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static java.lang.string VFgdpXmLAKVkoBvd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VlyqNYpWEXXaPbTt(java.lang.string str, java.lang.string str2) {
        return translatestring(str, str2);
    }

    public static java.io.Stream VriYYKBHHALhPPcY(java.net.UriConnection uRLConnection) {
        return uRLConnection.getStream();
    }

    public static java.lang.object VvXrOFDhkcRJfWLx(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void WbwyMuoQxcwKmOHB(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.lang.string WqAevmhoWiTfrquL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WuaoQZVLosrYGjpy(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.lang.string XEIlNLlrlMEAZqph(java.lang.string str) {
        return java.lang.System.getProperty(str);
    }

    public static java.nio.file.Path XMnFArxsiYPRaeUN(java.nio.file.Path path) {
        return path.getstringName();
    }

    public static void YUlANmKATuQeSPmU(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.object YirvwQiwLaCAzuWp(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void ZQLnwjngMkgsBSYp(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static java.net.Uri ZmLxSCsWfXpGKYCW(java.net.Uri uri) {
        return uri.toUri();
    }

    public static java.lang.stringBuilder ZscLdZsmFbDeEnXw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }
}

