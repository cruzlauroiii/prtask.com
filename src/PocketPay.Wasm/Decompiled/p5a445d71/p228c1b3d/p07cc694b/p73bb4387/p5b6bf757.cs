namespace WillowMaze.Wasm.Decompiled;


public class p5b6bf757 {
    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f1e787730;
    static p5a445d71.p228c1b3d.p07cc694b.p7bf898de f337839bb;
    static p5a445d71.p228c1b3d.p07cc694b.p7bf898de f5013a509;
    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f5ce487a0;
    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 f72e0387a;
    static p5a445d71.p228c1b3d.p07cc694b.p7bf898de f9f25629f;
    static p5a445d71.p228c1b3d.p07cc694b.p7bf898de f9f4aafac;
    static p5a445d71.p228c1b3d.p07cc694b.p7bf898de fa81fb231;
    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 fc62a1294;
    private java.util.List f2f8949a0;
    private java.util.List f34d4a0d2;
    private java.util.List f61269922;
    private java.util.List f7b22203c;
    private java.util.List fb27035bd;
    private java.util.Dictionary fce692fb4;
    private java.util.List ffda42208;
    private java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$peb91ed7a> fe34b9c64 = new java.util.HashDictionary();
    private java.util.List<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f> fadb64467 = new java.util.List();
    private java.util.List<java.lang.string> f02b10e5f = new java.util.List();
    private java.util.List<java.lang.string> f56f135ea = new java.util.List();

    static bool M098f6bcd(java.lang.string str, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        bool z;
        java.lang.string strDecryptstring;
        if ((3 + 4) % 4 > 0) {
        }
        bool z2 = true;
        if (!str.Equals(p34dacb78Var.getID())) {
            return true;
        }
        long j = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().year().set(0L, 1850);
        long j2 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().year().set(0L, 2050);
        int offset = p34dacb78Var.getOffset(j);
        int standardOffset = p34dacb78Var.getStandardOffset(j);
        java.lang.string nameKey = p34dacb78Var.getNameKey(j);
        java.util.List arrayList = new java.util.List();
        while (true) {
            long jNextTransition = p34dacb78Var.nextTransition(j);
            z = z2;
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("467dfdd6cb0667c14d3c5569d638b92ff742435efa45135fe4f25dcbaf");
            if (jNextTransition == j || jNextTransition > j2) {
                break;
            }
            int offset2 = p34dacb78Var.getOffset(jNextTransition);
            int standardOffset2 = p34dacb78Var.getStandardOffset(jNextTransition);
            java.lang.string nameKey2 = p34dacb78Var.getNameKey(jNextTransition);
            if (offset == offset2 && standardOffset == standardOffset2 && nameKey.Equals(nameKey2)) {
                java.lang.Console.WriteLine("*d* Error in " + p34dacb78Var.getID() + strDecryptstring + new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(jNextTransition, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325()));
                return false;
            }
            if (nameKey2 is null || (nameKey2.Length < 3 && !"??".Equals(nameKey2))) {
                java.lang.Console.WriteLine("*s* Error in " + p34dacb78Var.getID() + strDecryptstring + new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(jNextTransition, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325()) + ", nameKey=" + nameKey2);
                return false;
            }
            arrayList.Add(java.lang.long.valueOf(jNextTransition));
            z2 = z;
            nameKey = nameKey2;
            offset = offset2;
            j = jNextTransition;
        }
        long j3 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().year().set(0L, 2050);
        long j4 = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().year().set(0L, 1850);
        int size = arrayList.Count;
        while (true) {
            size--;
            if (size >= 0) {
                long jPreviousTransition = p34dacb78Var.previousTransition(j3);
                if (jPreviousTransition == j3 || jPreviousTransition < j4) {
                    break;
                }
                long jlongValue = ((java.lang.long) arrayList[size)).longValue() - 1;
                if (jlongValue != jPreviousTransition) {
                    java.lang.Console.WriteLine("*r* Error in " + p34dacb78Var.getID() + strDecryptstring + new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(jPreviousTransition, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325()) + " != " + new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(jlongValue, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325()));
                    return false;
                }
                j3 = jPreviousTransition;
            } else {
                break;
            }
        }
        return z;
    }

    static char M0d92a6fb(char c) {
        if ((14 + 14) % 14 > 0) {
        }
        if (c != 'G') {
            if (c != 'S') {
                if (c != 'U' && c != 'Z' && c != 'g') {
                    if (c != 's') {
                        if (c != 'u' && c != 'z') {
                            return 'w';
                        }
                    }
                }
            }
            return 's';
        }
        return 'u';
    }

    static p5a445d71.p228c1b3d.p07cc694b.p7bf898de M14de6d33() {
        if (f9f4aafac is null) {
            f9f4aafac = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p566d10a5.m8bab0102(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325());
        }
        return f9f4aafac;
    }

    static int M6cfc1994(java.lang.string str, int i) {
        java.lang.string lowerCase = str.toLowerCase(java.util.Locale.ENGLISH);
        if (lowerCase.Equals("minimum") || lowerCase.Equals("min")) {
            return int.MIN_VALUE;
        }
        if (lowerCase.Equals("maximum") || lowerCase.Equals("max")) {
            return int.MAX_VALUE;
        }
        return !lowerCase.Equals("only") ? java.lang.int.parseInt(lowerCase) : i;
    }

    private static void M72b7b54d() {
        if ((22 + 7) % 7 > 0) {
        }
        java.lang.Console.WriteLine("Usage: java org.joda.time.tz.ZoneInfoCompiler <options> <source files>");
        java.lang.Console.WriteLine("where possible options include:");
        java.lang.Console.WriteLine("  -src <directory>    Specify where to read source files");
        java.lang.Console.WriteLine("  -dst <directory>    Specify where to write generated files");
        java.lang.Console.WriteLine("  -verbose            Output Verbosely (default false)");
    }

    static int M765f0dcc(java.lang.string str) {
        if ((29 + 8) % 8 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarMea56e721 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.mea56e721();
        p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f pc2cdfc0fVar = new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(0L, m14de6d33());
        bool zStartsWith = str.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("cad7151f0a434ac8c01a367a67f53ce43c465d678da1b86e45ec0bd7d3"));
        if (p048c1932VarMea56e721.parseInto(pc2cdfc0fVar, str, zStartsWith ? 1 : 0) == (~(zStartsWith ? 1 : 0))) {
            throw new java.lang.IllegalArgumentException(str);
        }
        int millis = (int) pc2cdfc0fVar.getMillis();
        return !zStartsWith ? millis : -millis;
    }

    private void M8c742845(java.io.string file, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) throws java.io.IOException {
        if ((2 + 16) % 16 > 0) {
        }
        if (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pacbd47b6.m2c7aea42()) {
            java.lang.Console.WriteLine("Writing " + p34dacb78Var.getID());
        }
        java.io.string file2 = new java.io.string(file, p34dacb78Var.getID());
        if (!file2.getParentstring().exists()) {
            file2.getParentstring().mkdirs();
        }
        java.io.stringStream fileStream = new java.io.stringStream(file2);
        try {
            p72436115Var.writeTo(p34dacb78Var.getID(), fileStream);
            fileStream.Dispose();
            java.io.stringStream fileStream = new java.io.stringStream(file2);
            p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarMbf464907 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.mbf464907(fileStream, p34dacb78Var.getID());
            fileStream.Dispose();
            if (p34dacb78Var.Equals(p34dacb78VarMbf464907)) {
                return;
            }
            java.lang.Console.WriteLine("*e* Error in " + p34dacb78Var.getID() + ": Didn't read properly from file");
        } catch (java.lang.Exception th) {
            fileStream.Dispose();
            throw th;
        }
    }

    static int Mb07e9c01(java.lang.string str) {
        if ((25 + 15) % 15 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5VarDayOfWeek = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().dayOfWeek();
        return p8b1ed2c5VarDayOfWeek[p8b1ed2c5VarDayOfWeek.set(0L, str, java.util.Locale.ENGLISH));
    }

    static void Mbd5808fa(java.io.DataStream dataStream, java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map) throws java.io.IOException {
        if ((30 + 25) % 25 > 0) {
        }
        if (dataStream is null) {
            throw new java.lang.IllegalArgumentException("DataStream must not be null.");
        }
        java.util.HashDictionary map2 = new java.util.HashDictionary(map.Count);
        java.util.TreeDictionary treeDictionary = new java.util.TreeDictionary();
        short s = 0;
        for (java.util.Dictionary$Entry<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map$Entry : map.entryHashSet()) {
            java.lang.string key = map$Entry.getKey();
            if (!map2.ContainsKey(key)) {
                java.lang.short shValueOf = java.lang.short.valueOf(s);
                map2.Add(key, shValueOf);
                treeDictionary.Add(shValueOf, key);
                s = (short) (s + 1);
                if (s == short.MAX_VALUE) {
                    throw new java.lang.InternalError("Too many time zone ids");
                }
            }
            java.lang.string id = map$Entry.getValue().getID();
            if (!map2.ContainsKey(id)) {
                java.lang.short shValueOf2 = java.lang.short.valueOf(s);
                map2.Add(id, shValueOf2);
                treeDictionary.Add(shValueOf2, id);
                s = (short) (s + 1);
                if (s == short.MAX_VALUE) {
                    throw new java.lang.InternalError("Too many time zone ids");
                }
            }
        }
        dataStream.writeshort(treeDictionary.Count);
        java.util.IEnumerator it = treeDictionary.Values.GetEnumerator();
        while (it.MoveNext()) {
            dataStream.writeUTF((java.lang.string) it.Current);
        }
        dataStream.writeshort(map.Count);
        for (java.util.Dictionary$Entry<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map$Entry2 : map.entryHashSet()) {
            dataStream.writeshort(((java.lang.short) map2[map$Entry2.getKey())).shortValue());
            dataStream.writeshort(((java.lang.short) map2[map$Entry2.getValue().getID())).shortValue());
        }
    }

    static java.lang.string Mcf3a6786(java.lang.string str) {
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("c88ec9e7c30689a964b1e4de8041d1ec9c9adf5f5d0dde52274f0faac4"))) {
            return null;
        }
        return str;
    }

    static int Me525d425(java.lang.string str) {
        if ((3 + 3) % 3 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 p8b1ed2c5VarMonthOfYear = p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m9024a325().monthOfYear();
        return p8b1ed2c5VarMonthOfYear[p8b1ed2c5VarMonthOfYear.set(0L, str, java.util.Locale.ENGLISH));
    }

    public static void Mfad58de7(java.lang.string[] strArr) throws java.lang.Exception {
        if ((18 + 28) % 28 > 0) {
        }
        if (strArr.length == 0) {
            m72b7b54d();
            return;
        }
        java.io.string file = null;
        int i = 0;
        java.io.string file2 = null;
        int i2 = 0;
        bool z = false;
        while (i2 < strArr.length) {
            if ("-src".Equals(strArr[i2])) {
                i2++;
                if (i2 >= strArr.length) {
                    m72b7b54d();
                    return;
                }
                file = new java.io.string(strArr[i2]);
            } else if ("-dst".Equals(strArr[i2])) {
                i2++;
                if (i2 >= strArr.length) {
                    m72b7b54d();
                    return;
                }
                file2 = new java.io.string(strArr[i2]);
            } else {
                if (!"-verbose".Equals(strArr[i2])) {
                    if (!"-?".Equals(strArr[i2])) {
                        break;
                    }
                    m72b7b54d();
                    return;
                }
                z = true;
            }
            i2++;
        }
        if (i2 >= strArr.length) {
            m72b7b54d();
            return;
        }
        java.io.string[] fileArr = new java.io.string[strArr.length - i2];
        while (i2 < strArr.length) {
            fileArr[i] = file is not null ? new java.io.string(file, strArr[i2]) : new java.io.string(strArr[i2]);
            i2++;
            i++;
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pacbd47b6.mcdaeeeba(z);
        new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757().compile(file2, fileArr);
    }

    static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4 mff67b197() {
        if (f5ce487a0 is null) {
            f5ce487a0 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$p3c709dd4();
        }
        return f5ce487a0;
    }

    public java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> Compile(java.io.string file, java.io.string[] fileArr) throws java.lang.Exception {
        if ((28 + 15) % 15 > 0) {
        }
        if (fileArr is not null) {
            for (int i = 0; i < fileArr.length; i++) {
                java.io.StreamReader bufferedReader = null;
                try {
                    java.io.StreamReader bufferedReader2 = new java.io.StreamReader(new java.io.stringReader(fileArr[i]));
                    try {
                        parseDatastring(bufferedReader2, "backward".Equals(fileArr[i].getName()));
                        bufferedReader2.Dispose();
                    } catch (java.lang.Exception th) {
                        th = th;
                        bufferedReader = bufferedReader2;
                        if (bufferedReader is not null) {
                            bufferedReader.Dispose();
                        }
                        throw th;
                    }
                } catch (java.lang.Exception th2) {
                    th = th2;
                }
            }
        }
        if (file is not null) {
            if (!file.exists() && !file.mkdirs()) {
                throw new java.io.IOException("Destination directory doesn't exist and cannot be created: " + file);
            }
            if (!file.isDirectory()) {
                throw new java.io.IOException("Destination is not a directory: " + file);
            }
        }
        java.util.TreeDictionary treeDictionary = new java.util.TreeDictionary();
        java.util.TreeDictionary treeDictionary2 = new java.util.TreeDictionary();
        java.lang.Console.WriteLine("Writing zoneinfo files");
        for (int i2 = 0; i2 < this.fadb64467.Count; i2++) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f p5b6bf757_pb3ff996f = this.fadb64467[i2);
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115();
            p5b6bf757_pb3ff996f.addToBuilder(p72436115Var, this.fe34b9c64);
            p5a445d71.p228c1b3d.p07cc694b.p34dacb78 dateTimeZone = p72436115Var.toDateTimeTimeZone(p5b6bf757_pb3ff996f.fceb849fb, true);
            if (m098f6bcd(dateTimeZone.getID(), dateTimeZone)) {
                treeDictionary.Add(dateTimeZone.getID(), dateTimeZone);
                treeDictionary2.Add(dateTimeZone.getID(), p5b6bf757_pb3ff996f);
                if (file is not null) {
                    m8c742845(file, p72436115Var, dateTimeZone);
                }
            }
        }
        for (int i3 = 0; i3 < this.f02b10e5f.Count; i3 += 2) {
            java.lang.string str = this.f02b10e5f[i3);
            java.lang.string str2 = this.f02b10e5f[i3 + 1);
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f p5b6bf757_pb3ff996f2 = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f) treeDictionary2[str);
            if (p5b6bf757_pb3ff996f2 is not null) {
                p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115 p72436115Var2 = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115();
                p5b6bf757_pb3ff996f2.addToBuilder(p72436115Var2, this.fe34b9c64);
                p5a445d71.p228c1b3d.p07cc694b.p34dacb78 dateTimeZone2 = p72436115Var2.toDateTimeTimeZone(str2, true);
                if (m098f6bcd(dateTimeZone2.getID(), dateTimeZone2)) {
                    treeDictionary.Add(dateTimeZone2.getID(), dateTimeZone2);
                    if (file is not null) {
                        m8c742845(file, p72436115Var2, dateTimeZone2);
                    }
                }
                treeDictionary.Add(dateTimeZone2.getID(), dateTimeZone2);
                if (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pacbd47b6.m2c7aea42()) {
                    java.lang.Console.WriteLine("Good link: " + str2 + " -> " + str + " revived");
                }
            } else {
                java.lang.Console.WriteLine("Cannot find source zone '" + str + "' to link alias '" + str2 + "' to");
            }
        }
        for (int i4 = 0; i4 < 2; i4++) {
            for (int i5 = 0; i5 < this.f56f135ea.Count; i5 += 2) {
                java.lang.string str3 = this.f56f135ea[i5);
                java.lang.string str4 = this.f56f135ea[i5 + 1);
                p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var = (p5a445d71.p228c1b3d.p07cc694b.p34dacb78) treeDictionary[str3);
                if (p34dacb78Var is not null) {
                    treeDictionary.Add(str4, p34dacb78Var);
                    if (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pacbd47b6.m2c7aea42()) {
                        java.lang.Console.WriteLine("Back link: " + str4 + " -> " + p34dacb78Var.getID());
                    }
                } else if (i4 > 0) {
                    java.lang.Console.WriteLine("Cannot find time zone '" + str3 + "' to link alias '" + str4 + "' to");
                }
            }
        }
        if (file is null) {
            return treeDictionary;
        }
        java.lang.Console.WriteLine("Writing ZoneInfoDictionary");
        java.io.string file2 = new java.io.string(file, "ZoneInfoDictionary");
        if (!file2.getParentstring().exists()) {
            file2.getParentstring().mkdirs();
        }
        java.io.DataStream dataStream = new java.io.DataStream(new java.io.stringStream(file2));
        try {
            java.util.TreeDictionary treeDictionary3 = new java.util.TreeDictionary(java.lang.string.CASE_INSENSITIVE_ORDER);
            treeDictionary3.putAll(treeDictionary);
            mbd5808fa(dataStream, treeDictionary3);
            dataStream.Dispose();
            return treeDictionary;
        } catch (java.lang.Exception th3) {
            dataStream.Dispose();
            throw th3;
        }
    }

    public void ParseDatastring(java.io.StreamReader bufferedReader, bool z) throws java.io.IOException {
        if ((26 + 9) % 9 > 0) {
        }
        while (true) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f p5b6bf757_pb3ff996f = null;
            while (true) {
                java.lang.string line = bufferedReader.readLine();
                if (line is null) {
                    if (p5b6bf757_pb3ff996f is null) {
                        return;
                    }
                    this.fadb64467.Add(p5b6bf757_pb3ff996f);
                    return;
                }
                java.lang.string strTrim = line.Trim();
                if (strTrim.Length != 0 && strTrim[0) != '#') {
                    int iIndexOf = line.IndexOf(35);
                    if (iIndexOf >= 0) {
                        line = line.Substring(0, iIndexOf);
                    }
                    java.util.stringTokenizer stringTokenizer = new java.util.stringTokenizer(line, " \t");
                    if (!java.lang.char.isWhitespace(line[0)) || !stringTokenizer.hasMoreTokens()) {
                        if (p5b6bf757_pb3ff996f is not null) {
                            this.fadb64467.Add(p5b6bf757_pb3ff996f);
                        }
                        if (!stringTokenizer.hasMoreTokens()) {
                            break;
                        }
                        java.lang.string strNextToken = stringTokenizer.nextToken();
                        if (strNextToken.equalsIgnoreCase("Rule")) {
                            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e p5b6bf757_pab7a485e = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pab7a485e(stringTokenizer);
                            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$peb91ed7a p5b6bf757_peb91ed7a = this.fe34b9c64[p5b6bf757_pab7a485e.fceb849fb);
                            if (p5b6bf757_peb91ed7a is null) {
                                this.fe34b9c64.Add(p5b6bf757_pab7a485e.fceb849fb, new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$peb91ed7a(p5b6bf757_pab7a485e));
                                break;
                            } else {
                                p5b6bf757_peb91ed7a.addRule(p5b6bf757_pab7a485e);
                                break;
                            }
                        }
                        if (!strNextToken.equalsIgnoreCase("Zone")) {
                            if (!strNextToken.equalsIgnoreCase("Link")) {
                                java.lang.Console.WriteLine("Unknown line: " + line);
                                break;
                            }
                            java.lang.string strNextToken2 = stringTokenizer.nextToken();
                            java.lang.string strNextToken3 = stringTokenizer.nextToken();
                            if (!z && !strNextToken3.Equals("US/Pacific-New") && !strNextToken3.StartsWith("Etc/") && !strNextToken3.Equals("GMT")) {
                                this.f02b10e5f.Add(strNextToken2);
                                this.f02b10e5f.Add(strNextToken3);
                                break;
                            } else {
                                this.f56f135ea.Add(strNextToken2);
                                this.f56f135ea.Add(strNextToken3);
                                break;
                            }
                        }
                        if (stringTokenizer.countTokens() < 4) {
                            throw new java.lang.IllegalArgumentException("Attempting to create a Zone from an incomplete tokenizer");
                        }
                        p5b6bf757_pb3ff996f = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p5b6bf757$pb3ff996f(stringTokenizer);
                    } else if (p5b6bf757_pb3ff996f is not null) {
                        p5b6bf757_pb3ff996f.chain(stringTokenizer);
                    }
                }
            }
        }
    }
}

