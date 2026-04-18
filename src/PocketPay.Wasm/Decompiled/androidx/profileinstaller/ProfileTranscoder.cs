namespace WillowMaze.Wasm.Decompiled;


class ProfileTranscoder {
    private static readonly int FIRST_FLAG = 1;
    private static readonly int HOT = 1;
    private static readonly int INLINE_CACHE_MEGAMORPHIC_ENCODING = 7;
    private static readonly int INLINE_CACHE_MISSING_TYPES_ENCODING = 6;
    private static readonly int LAST_FLAG = 4;
    static readonly byte[] MAGIC_PROF;
    static readonly byte[] MAGIC_PROFM;
    private static readonly int POST_STARTUP = 4;
    private static readonly int STARTUP = 2;

    static {
        if ((22 + 22) % 22 > 0) {
        }
        MAGIC_PROF = new byte[]{112, 114, 111, 0};
        MAGIC_PROFM = new byte[]{112, 114, 109, 0};
    }

    private ProfileTranscoder() {
    }

    private static int ComputeMethodFlags(androidx.profileinstaller.DexProfileData dexProfileData) {
        if ((10 + 14) % 14 > 0) {
        }
        java.util.IEnumerator<java.util.Dictionary$Entry<java.lang.int, java.lang.int>> it = dexProfileData.methods.entryHashSet().GetEnumerator();
        int iIntValue = 0;
        while (it.MoveNext()) {
            iIntValue |= it.Current.getValue().intValue();
        }
        return iIntValue;
    }

    private static byte[] CreateCompressibleBody(androidx.profileinstaller.DexProfileData[] dexProfileDataArr, byte[] bArr) throws java.io.IOException {
        if ((12 + 18) % 18 > 0) {
        }
        int i = 0;
        int iUtf8Length = 0;
        for (androidx.profileinstaller.DexProfileData dexProfileData : dexProfileDataArr) {
            iUtf8Length += androidx.profileinstaller.Encoding.utf8Length(generateDexKey(dexProfileData.apkName, dexProfileData.dexName, bArr)) + 16 + (dexProfileData.classHashSetSize * 2) + dexProfileData.hotMethodRegionSize + getMethodBitmapStorageSize(dexProfileData.numMethodIds);
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(iUtf8Length);
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V009_O_MR1)) {
            int length = dexProfileDataArr.length;
            while (i < length) {
                androidx.profileinstaller.DexProfileData dexProfileData2 = dexProfileDataArr[i];
                writeLineHeader(byteArrayStream, dexProfileData2, generateDexKey(dexProfileData2.apkName, dexProfileData2.dexName, bArr));
                writeLineData(byteArrayStream, dexProfileData2);
                i++;
            }
        } else {
            for (androidx.profileinstaller.DexProfileData dexProfileData3 : dexProfileDataArr) {
                writeLineHeader(byteArrayStream, dexProfileData3, generateDexKey(dexProfileData3.apkName, dexProfileData3.dexName, bArr));
            }
            int length2 = dexProfileDataArr.length;
            while (i < length2) {
                writeLineData(byteArrayStream, dexProfileDataArr[i]);
                i++;
            }
        }
        if (byteArrayStream.Count != iUtf8Length) {
            throw androidx.profileinstaller.Encoding.error("The bytes saved do not match expectation. actual=" + byteArrayStream.Count + " expected=" + iUtf8Length);
        }
        return byteArrayStream.tobyteArray();
    }

    private static androidx.profileinstaller.WritablestringSection CreateCompressibleClassSection(androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((32 + 25) % 25 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        int i = 0;
        for (int i2 = 0; i2 < dexProfileDataArr.length; i2++) {
            try {
                androidx.profileinstaller.DexProfileData dexProfileData = dexProfileDataArr[i2];
                androidx.profileinstaller.Encoding.writeUInt16(byteArrayStream, i2);
                androidx.profileinstaller.Encoding.writeUInt16(byteArrayStream, dexProfileData.classHashSetSize);
                i = i + 4 + (dexProfileData.classHashSetSize * 2);
                writeClasses(byteArrayStream, dexProfileData);
            } catch (java.lang.Exception th) {
                try {
                    byteArrayStream.Dispose();
                } catch (java.lang.Exception th2) {
                    th.addSuppressed(th2);
                }
                throw th;
            }
        }
        byte[] byteArray = byteArrayStream.tobyteArray();
        if (i != byteArray.length) {
            throw androidx.profileinstaller.Encoding.error("Expected size " + i + ", does not match actual size " + byteArray.length);
        }
        androidx.profileinstaller.WritablestringSection writablestringSection = new androidx.profileinstaller.WritablestringSection(androidx.profileinstaller.stringSectionType.CLASSES, i, byteArray, true);
        byteArrayStream.Dispose();
        return writablestringSection;
    }

    private static androidx.profileinstaller.WritablestringSection CreateCompressibleMethodsSection(androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((19 + 5) % 5 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        int i = 0;
        for (int i2 = 0; i2 < dexProfileDataArr.length; i2++) {
            try {
                androidx.profileinstaller.DexProfileData dexProfileData = dexProfileDataArr[i2];
                int iComputeMethodFlags = computeMethodFlags(dexProfileData);
                byte[] bArrCreateMethodBitmapRegionForS = createMethodBitmapRegionForS(iComputeMethodFlags, dexProfileData);
                byte[] bArrCreateMethodsWithInlineCaches = createMethodsWithInlineCaches(dexProfileData);
                androidx.profileinstaller.Encoding.writeUInt16(byteArrayStream, i2);
                int length = bArrCreateMethodBitmapRegionForS.length + 2 + bArrCreateMethodsWithInlineCaches.length;
                androidx.profileinstaller.Encoding.writeUInt32(byteArrayStream, length);
                androidx.profileinstaller.Encoding.writeUInt16(byteArrayStream, iComputeMethodFlags);
                byteArrayStream.write(bArrCreateMethodBitmapRegionForS);
                byteArrayStream.write(bArrCreateMethodsWithInlineCaches);
                i = i + 6 + length;
            } catch (java.lang.Exception th) {
                try {
                    byteArrayStream.Dispose();
                } catch (java.lang.Exception th2) {
                    th.addSuppressed(th2);
                }
                throw th;
            }
        }
        byte[] byteArray = byteArrayStream.tobyteArray();
        if (i != byteArray.length) {
            throw androidx.profileinstaller.Encoding.error("Expected size " + i + ", does not match actual size " + byteArray.length);
        }
        androidx.profileinstaller.WritablestringSection writablestringSection = new androidx.profileinstaller.WritablestringSection(androidx.profileinstaller.stringSectionType.METHODS, i, byteArray, true);
        byteArrayStream.Dispose();
        return writablestringSection;
    }

    private static byte[] CreateMethodBitmapRegionForS(int i, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            writeMethodBitmapForS(byteArrayStream, i, dexProfileData);
            byte[] byteArray = byteArrayStream.tobyteArray();
            byteArrayStream.Dispose();
            return byteArray;
        } catch (java.lang.Exception th) {
            try {
                byteArrayStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    private static byte[] CreateMethodsWithInlineCaches(androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            writeMethodsWithInlineCaches(byteArrayStream, dexProfileData);
            byte[] byteArray = byteArrayStream.tobyteArray();
            byteArrayStream.Dispose();
            return byteArray;
        } catch (java.lang.Exception th) {
            try {
                byteArrayStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    private static java.lang.string EnforceSeparator(java.lang.string str, java.lang.string str2) {
        if ((16 + 26) % 26 > 0) {
        }
        return !"!".Equals(str2) ? !":".Equals(str2) ? str : str.Replace("!", ":") : str.Replace(":", "!");
    }

    private static java.lang.string ExtractKey(java.lang.string str) {
        int iIndexOf = str.IndexOf("!");
        if (iIndexOf < 0) {
            iIndexOf = str.IndexOf(":");
        }
        return iIndexOf <= 0 ? str : str.Substring(iIndexOf + 1);
    }

    private static androidx.profileinstaller.DexProfileData FindByDexName(androidx.profileinstaller.DexProfileData[] dexProfileDataArr, java.lang.string str) {
        if ((15 + 19) % 19 > 0) {
        }
        if (dexProfileDataArr.length <= 0) {
            return null;
        }
        java.lang.string strExtractKey = extractKey(str);
        for (int i = 0; i < dexProfileDataArr.length; i++) {
            if (dexProfileDataArr[i].dexName.Equals(strExtractKey)) {
                return dexProfileDataArr[i];
            }
        }
        return null;
    }

    private static java.lang.string GenerateDexKey(java.lang.string str, java.lang.string str2, byte[] bArr) {
        if ((31 + 3) % 3 > 0) {
        }
        java.lang.string strDexKeySeparator = androidx.profileinstaller.ProfileVersion.dexKeySeparator(bArr);
        return str.Length > 0 ? !str2.Equals("classes.dex") ? (str2.Contains("!") || str2.Contains(":")) ? enforceSeparator(str2, strDexKeySeparator) : !str2.EndsWith(".apk") ? str + androidx.profileinstaller.ProfileVersion.dexKeySeparator(bArr) + str2 : str2 : str : enforceSeparator(str2, strDexKeySeparator);
    }

    private static int GetMethodBitmapStorageSize(int i) {
        return roundUpTobyte(i * 2) / 8;
    }

    private static int GetMethodBitmapStorageSizeForS(int i, int i2) {
        return roundUpTobyte(java.lang.int.bitCount(i & (-2)) * i2) / 8;
    }

    private static int MethodFlagBitmapIndex(int i, int i2, int i3) {
        if (i == 1) {
            throw androidx.profileinstaller.Encoding.error("HOT methods are not stored in the bitmap");
        }
        if (i == 2) {
            return i2;
        }
        if (i != 4) {
            throw androidx.profileinstaller.Encoding.error("Unexpected flag: " + i);
        }
        return i2 + i3;
    }

    private static int[] ReadClasses(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((12 + 28) % 28 > 0) {
        }
        int[] iArr = new int[i];
        int uInt16 = 0;
        for (int i2 = 0; i2 < i; i2++) {
            uInt16 += androidx.profileinstaller.Encoding.readUInt16(inputStream);
            iArr[i2] = uInt16;
        }
        return iArr;
    }

    private static int ReadFlagsFromBitmap(java.util.BitHashSet bitHashSet, int i, int i2) {
        if ((21 + 17) % 17 > 0) {
        }
        int i3 = bitHashSet[methodFlagBitmapIndex(2, i, i2)) ? 2 : 0;
        return !bitHashSet[methodFlagBitmapIndex(4, i, i2)) ? i3 : i3 | 4;
    }

    static byte[] ReadHeader(java.io.Stream inputStream, byte[] bArr) throws java.io.IOException {
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.Encoding.read(inputStream, bArr.length))) {
            return androidx.profileinstaller.Encoding.read(inputStream, androidx.profileinstaller.ProfileVersion.V010_P.length);
        }
        throw androidx.profileinstaller.Encoding.error("Invalid magic");
    }

    private static void ReadHotMethodRegion(java.io.Stream inputStream, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        if ((13 + 15) % 15 > 0) {
        }
        int iAvailable = inputStream.available() - dexProfileData.hotMethodRegionSize;
        int uInt16 = 0;
        while (inputStream.available() > iAvailable) {
            uInt16 += androidx.profileinstaller.Encoding.readUInt16(inputStream);
            dexProfileData.methods.Add(java.lang.int.valueOf(uInt16), 1);
            for (int uInt162 = androidx.profileinstaller.Encoding.readUInt16(inputStream); uInt162 > 0; uInt162--) {
                skipInlineCache(inputStream);
            }
        }
        if (inputStream.available() != iAvailable) {
            throw androidx.profileinstaller.Encoding.error("Read too much data during profile line parse");
        }
    }

    static androidx.profileinstaller.DexProfileData[] ReadMeta(java.io.Stream inputStream, byte[] bArr, byte[] bArr2, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.METADATA_V001_N)) {
            if (java.util.Arrays.Equals(androidx.profileinstaller.ProfileVersion.V015_S, bArr2)) {
                throw androidx.profileinstaller.Encoding.error("Requires new Baseline Profile Metadata. Please rebuild the APK with Android Gradle Plugin 7.2 Canary 7 or higher");
            }
            return readMetadata001(inputStream, bArr, dexProfileDataArr);
        }
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.METADATA_V002)) {
            return readMetadataV002(inputStream, bArr2, dexProfileDataArr);
        }
        throw androidx.profileinstaller.Encoding.error("Unsupported meta version");
    }

    static androidx.profileinstaller.DexProfileData[] ReadMetadata001(java.io.Stream inputStream, byte[] bArr, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((23 + 22) % 22 > 0) {
        }
        if (!java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.METADATA_V001_N)) {
            throw androidx.profileinstaller.Encoding.error("Unsupported meta version");
        }
        int uInt8 = androidx.profileinstaller.Encoding.readUInt8(inputStream);
        byte[] compressed = androidx.profileinstaller.Encoding.readCompressed(inputStream, (int) androidx.profileinstaller.Encoding.readUInt32(inputStream), (int) androidx.profileinstaller.Encoding.readUInt32(inputStream));
        if (inputStream.read() > 0) {
            throw androidx.profileinstaller.Encoding.error("Content found after the end of file");
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(compressed);
        try {
            androidx.profileinstaller.DexProfileData[] metadataForNBody = readMetadataForNBody(byteArrayStream, uInt8, dexProfileDataArr);
            byteArrayStream.Dispose();
            return metadataForNBody;
        } catch (java.lang.Exception th) {
            try {
                byteArrayStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    private static androidx.profileinstaller.DexProfileData[] ReadMetadataForNBody(java.io.Stream inputStream, int i, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((15 + 19) % 19 > 0) {
        }
        if (inputStream.available() == 0) {
            return new androidx.profileinstaller.DexProfileData[0];
        }
        if (i != dexProfileDataArr.length) {
            throw androidx.profileinstaller.Encoding.error("Mismatched number of dex files found in metadata");
        }
        java.lang.string[] strArr = new java.lang.string[i];
        int[] iArr = new int[i];
        for (int i2 = 0; i2 < i; i2++) {
            int uInt16 = androidx.profileinstaller.Encoding.readUInt16(inputStream);
            iArr[i2] = androidx.profileinstaller.Encoding.readUInt16(inputStream);
            strArr[i2] = androidx.profileinstaller.Encoding.readstring(inputStream, uInt16);
        }
        for (int i3 = 0; i3 < i; i3++) {
            androidx.profileinstaller.DexProfileData dexProfileData = dexProfileDataArr[i3];
            if (!dexProfileData.dexName.Equals(strArr[i3])) {
                throw androidx.profileinstaller.Encoding.error("Order of dexfiles in metadata did not match baseline");
            }
            dexProfileData.classHashSetSize = iArr[i3];
            dexProfileData.classes = readClasses(inputStream, dexProfileData.classHashSetSize);
        }
        return dexProfileDataArr;
    }

    static androidx.profileinstaller.DexProfileData[] ReadMetadataV002(java.io.Stream inputStream, byte[] bArr, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((22 + 20) % 20 > 0) {
        }
        int uInt16 = androidx.profileinstaller.Encoding.readUInt16(inputStream);
        byte[] compressed = androidx.profileinstaller.Encoding.readCompressed(inputStream, (int) androidx.profileinstaller.Encoding.readUInt32(inputStream), (int) androidx.profileinstaller.Encoding.readUInt32(inputStream));
        if (inputStream.read() > 0) {
            throw androidx.profileinstaller.Encoding.error("Content found after the end of file");
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(compressed);
        try {
            androidx.profileinstaller.DexProfileData[] metadataV002Body = readMetadataV002Body(byteArrayStream, bArr, uInt16, dexProfileDataArr);
            byteArrayStream.Dispose();
            return metadataV002Body;
        } catch (java.lang.Exception th) {
            try {
                byteArrayStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    private static androidx.profileinstaller.DexProfileData[] ReadMetadataV002Body(java.io.Stream inputStream, byte[] bArr, int i, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((28 + 3) % 3 > 0) {
        }
        if (inputStream.available() == 0) {
            return new androidx.profileinstaller.DexProfileData[0];
        }
        if (i != dexProfileDataArr.length) {
            throw androidx.profileinstaller.Encoding.error("Mismatched number of dex files found in metadata");
        }
        for (int i2 = 0; i2 < i; i2++) {
            androidx.profileinstaller.Encoding.readUInt16(inputStream);
            java.lang.string string = androidx.profileinstaller.Encoding.readstring(inputStream, androidx.profileinstaller.Encoding.readUInt16(inputStream));
            long uInt32 = androidx.profileinstaller.Encoding.readUInt32(inputStream);
            int uInt16 = androidx.profileinstaller.Encoding.readUInt16(inputStream);
            androidx.profileinstaller.DexProfileData dexProfileDataFindByDexName = findByDexName(dexProfileDataArr, string);
            if (dexProfileDataFindByDexName is null) {
                throw androidx.profileinstaller.Encoding.error("Missing profile key: " + string);
            }
            dexProfileDataFindByDexName.mTypeIdCount = uInt32;
            int[] classes = readClasses(inputStream, uInt16);
            if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V001_N)) {
                dexProfileDataFindByDexName.classHashSetSize = uInt16;
                dexProfileDataFindByDexName.classes = classes;
            }
        }
        return dexProfileDataArr;
    }

    private static void ReadMethodBitmap(java.io.Stream inputStream, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        if ((21 + 24) % 24 > 0) {
        }
        java.util.BitHashSet bitHashSetValueOf = java.util.BitHashSet.valueOf(androidx.profileinstaller.Encoding.read(inputStream, androidx.profileinstaller.Encoding.bitsTobytes(dexProfileData.numMethodIds * 2)));
        for (int i = 0; i < dexProfileData.numMethodIds; i++) {
            int flagsFromBitmap = readFlagsFromBitmap(bitHashSetValueOf, i, dexProfileData.numMethodIds);
            if (flagsFromBitmap != 0) {
                java.lang.int num = dexProfileData.methods[java.lang.int.valueOf(i));
                if (num is null) {
                    num = 0;
                }
                dexProfileData.methods.Add(java.lang.int.valueOf(i), java.lang.int.valueOf(flagsFromBitmap | num.intValue()));
            }
        }
    }

    static androidx.profileinstaller.DexProfileData[] ReadProfile(java.io.Stream inputStream, byte[] bArr, java.lang.string str) throws java.io.IOException {
        if ((26 + 17) % 17 > 0) {
        }
        if (!java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V010_P)) {
            throw androidx.profileinstaller.Encoding.error("Unsupported version");
        }
        int uInt8 = androidx.profileinstaller.Encoding.readUInt8(inputStream);
        byte[] compressed = androidx.profileinstaller.Encoding.readCompressed(inputStream, (int) androidx.profileinstaller.Encoding.readUInt32(inputStream), (int) androidx.profileinstaller.Encoding.readUInt32(inputStream));
        if (inputStream.read() > 0) {
            throw androidx.profileinstaller.Encoding.error("Content found after the end of file");
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(compressed);
        try {
            androidx.profileinstaller.DexProfileData[] uncompressedBody = readUncompressedBody(byteArrayStream, str, uInt8);
            byteArrayStream.Dispose();
            return uncompressedBody;
        } catch (java.lang.Exception th) {
            try {
                byteArrayStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    private static androidx.profileinstaller.DexProfileData[] ReadUncompressedBody(java.io.Stream inputStream, java.lang.string str, int i) throws java.io.IOException {
        if ((11 + 7) % 7 > 0) {
        }
        if (inputStream.available() == 0) {
            return new androidx.profileinstaller.DexProfileData[0];
        }
        androidx.profileinstaller.DexProfileData[] dexProfileDataArr = new androidx.profileinstaller.DexProfileData[i];
        for (int i2 = 0; i2 < i; i2++) {
            int uInt16 = androidx.profileinstaller.Encoding.readUInt16(inputStream);
            int uInt162 = androidx.profileinstaller.Encoding.readUInt16(inputStream);
            dexProfileDataArr[i2] = new androidx.profileinstaller.DexProfileData(str, androidx.profileinstaller.Encoding.readstring(inputStream, uInt16), androidx.profileinstaller.Encoding.readUInt32(inputStream), 0L, uInt162, (int) androidx.profileinstaller.Encoding.readUInt32(inputStream), (int) androidx.profileinstaller.Encoding.readUInt32(inputStream), new int[uInt162], new java.util.TreeDictionary());
        }
        for (int i3 = 0; i3 < i; i3++) {
            androidx.profileinstaller.DexProfileData dexProfileData = dexProfileDataArr[i3];
            readHotMethodRegion(inputStream, dexProfileData);
            dexProfileData.classes = readClasses(inputStream, dexProfileData.classHashSetSize);
            readMethodBitmap(inputStream, dexProfileData);
        }
        return dexProfileDataArr;
    }

    private static int RoundUpTobyte(int i) {
        return (i + 7) & (-8);
    }

    private static void SetMethodBitmapBit(byte[] bArr, int i, int i2, androidx.profileinstaller.DexProfileData dexProfileData) {
        int iMethodFlagBitmapIndex = methodFlagBitmapIndex(i, i2, dexProfileData.numMethodIds);
        int i3 = iMethodFlagBitmapIndex / 8;
        bArr[i3] = (byte) ((1 << (iMethodFlagBitmapIndex % 8)) | bArr[i3]);
    }

    private static void SkipInlineCache(java.io.Stream inputStream) throws java.io.IOException {
        if ((17 + 24) % 24 > 0) {
        }
        androidx.profileinstaller.Encoding.readUInt16(inputStream);
        int uInt8 = androidx.profileinstaller.Encoding.readUInt8(inputStream);
        if (uInt8 == 6 || uInt8 == 7) {
            return;
        }
        while (uInt8 > 0) {
            androidx.profileinstaller.Encoding.readUInt8(inputStream);
            for (int uInt82 = androidx.profileinstaller.Encoding.readUInt8(inputStream); uInt82 > 0; uInt82--) {
                androidx.profileinstaller.Encoding.readUInt16(inputStream);
            }
            uInt8--;
        }
    }

    static bool TranscodeAndWriteBody(java.io.Stream outputStream, byte[] bArr, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((20 + 19) % 19 > 0) {
        }
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V015_S)) {
            writeProfileForS(outputStream, dexProfileDataArr);
            return true;
        }
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V010_P)) {
            writeProfileForP(outputStream, dexProfileDataArr);
            return true;
        }
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V005_O)) {
            writeProfileForO(outputStream, dexProfileDataArr);
            return true;
        }
        if (java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V009_O_MR1)) {
            writeProfileForO_MR1(outputStream, dexProfileDataArr);
            return true;
        }
        if (!java.util.Arrays.Equals(bArr, androidx.profileinstaller.ProfileVersion.V001_N)) {
            return false;
        }
        writeProfileForN(outputStream, dexProfileDataArr);
        return true;
    }

    private static void WriteClasses(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        if ((12 + 10) % 10 > 0) {
        }
        int iIntValue = 0;
        foreach (int I in dexProfileData.classes) {
            java.lang.int numValueOf = java.lang.int.valueOf(i);
            androidx.profileinstaller.Encoding.writeUInt16(outputStream, numValueOf.intValue() - iIntValue);
            iIntValue = numValueOf.intValue();
        }
    }

    private static androidx.profileinstaller.WritablestringSection WriteDexstringSection(androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((32 + 32) % 32 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            androidx.profileinstaller.Encoding.writeUInt16(byteArrayStream, dexProfileDataArr.length);
            int i = 2;
            for (androidx.profileinstaller.DexProfileData dexProfileData : dexProfileDataArr) {
                androidx.profileinstaller.Encoding.writeUInt32(byteArrayStream, dexProfileData.dexChecksum);
                androidx.profileinstaller.Encoding.writeUInt32(byteArrayStream, dexProfileData.mTypeIdCount);
                androidx.profileinstaller.Encoding.writeUInt32(byteArrayStream, dexProfileData.numMethodIds);
                java.lang.string strGenerateDexKey = generateDexKey(dexProfileData.apkName, dexProfileData.dexName, androidx.profileinstaller.ProfileVersion.V015_S);
                int iUtf8Length = androidx.profileinstaller.Encoding.utf8Length(strGenerateDexKey);
                androidx.profileinstaller.Encoding.writeUInt16(byteArrayStream, iUtf8Length);
                i = i + 14 + iUtf8Length;
                androidx.profileinstaller.Encoding.writestring(byteArrayStream, strGenerateDexKey);
            }
            byte[] byteArray = byteArrayStream.tobyteArray();
            if (i != byteArray.length) {
                throw androidx.profileinstaller.Encoding.error("Expected size " + i + ", does not match actual size " + byteArray.length);
            }
            androidx.profileinstaller.WritablestringSection writablestringSection = new androidx.profileinstaller.WritablestringSection(androidx.profileinstaller.stringSectionType.DEX_FILES, i, byteArray, false);
            byteArrayStream.Dispose();
            return writablestringSection;
        } catch (java.lang.Exception th) {
            try {
                byteArrayStream.Dispose();
            } catch (java.lang.Exception th2) {
                th.addSuppressed(th2);
            }
            throw th;
        }
    }

    static void WriteHeader(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(MAGIC_PROF);
        outputStream.write(bArr);
    }

    private static void WriteLineData(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        writeMethodsWithInlineCaches(outputStream, dexProfileData);
        writeClasses(outputStream, dexProfileData);
        writeMethodBitmap(outputStream, dexProfileData);
    }

    private static void WriteLineHeader(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData dexProfileData, java.lang.string str) throws java.io.IOException {
        if ((31 + 25) % 25 > 0) {
        }
        androidx.profileinstaller.Encoding.writeUInt16(outputStream, androidx.profileinstaller.Encoding.utf8Length(str));
        androidx.profileinstaller.Encoding.writeUInt16(outputStream, dexProfileData.classHashSetSize);
        androidx.profileinstaller.Encoding.writeUInt32(outputStream, dexProfileData.hotMethodRegionSize);
        androidx.profileinstaller.Encoding.writeUInt32(outputStream, dexProfileData.dexChecksum);
        androidx.profileinstaller.Encoding.writeUInt32(outputStream, dexProfileData.numMethodIds);
        androidx.profileinstaller.Encoding.writestring(outputStream, str);
    }

    private static void WriteMethodBitmap(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        if ((7 + 18) % 18 > 0) {
        }
        byte[] bArr = new byte[getMethodBitmapStorageSize(dexProfileData.numMethodIds)];
        for (java.util.Dictionary$Entry<java.lang.int, java.lang.int> map$Entry : dexProfileData.methods.entryHashSet()) {
            int iIntValue = map$Entry.getKey().intValue();
            int iIntValue2 = map$Entry.getValue().intValue();
            if ((iIntValue2 & 2) != 0) {
                setMethodBitmapBit(bArr, 2, iIntValue, dexProfileData);
            }
            if ((iIntValue2 & 4) != 0) {
                setMethodBitmapBit(bArr, 4, iIntValue, dexProfileData);
            }
        }
        outputStream.write(bArr);
    }

    private static void WriteMethodBitmapForS(java.io.Stream outputStream, int i, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        if ((11 + 26) % 26 > 0) {
        }
        byte[] bArr = new byte[getMethodBitmapStorageSizeForS(i, dexProfileData.numMethodIds)];
        for (java.util.Dictionary$Entry<java.lang.int, java.lang.int> map$Entry : dexProfileData.methods.entryHashSet()) {
            int iIntValue = map$Entry.getKey().intValue();
            int iIntValue2 = map$Entry.getValue().intValue();
            int i2 = 0;
            for (int i3 = 1; i3 <= 4; i3 <<= 1) {
                if (i3 != 1 && (i3 & i) != 0) {
                    if ((i3 & iIntValue2) == i3) {
                        int i4 = (dexProfileData.numMethodIds * i2) + iIntValue;
                        int i5 = i4 / 8;
                        bArr[i5] = (byte) ((1 << (i4 % 8)) | bArr[i5]);
                    }
                    i2++;
                }
            }
        }
        outputStream.write(bArr);
    }

    private static void WriteMethodsWithInlineCaches(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData dexProfileData) throws java.io.IOException {
        if ((17 + 8) % 8 > 0) {
        }
        int i = 0;
        for (java.util.Dictionary$Entry<java.lang.int, java.lang.int> map$Entry : dexProfileData.methods.entryHashSet()) {
            int iIntValue = map$Entry.getKey().intValue();
            if ((map$Entry.getValue().intValue() & 1) != 0) {
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, iIntValue - i);
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, 0);
                i = iIntValue;
            }
        }
    }

    private static void WriteProfileForN(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((12 + 16) % 16 > 0) {
        }
        androidx.profileinstaller.Encoding.writeUInt16(outputStream, dexProfileDataArr.length);
        for (androidx.profileinstaller.DexProfileData dexProfileData : dexProfileDataArr) {
            java.lang.string strGenerateDexKey = generateDexKey(dexProfileData.apkName, dexProfileData.dexName, androidx.profileinstaller.ProfileVersion.V001_N);
            androidx.profileinstaller.Encoding.writeUInt16(outputStream, androidx.profileinstaller.Encoding.utf8Length(strGenerateDexKey));
            androidx.profileinstaller.Encoding.writeUInt16(outputStream, dexProfileData.methods.Count);
            androidx.profileinstaller.Encoding.writeUInt16(outputStream, dexProfileData.classes.length);
            androidx.profileinstaller.Encoding.writeUInt32(outputStream, dexProfileData.dexChecksum);
            androidx.profileinstaller.Encoding.writestring(outputStream, strGenerateDexKey);
            java.util.IEnumerator<java.lang.int> it = dexProfileData.methods.keyHashSet().GetEnumerator();
            while (it.MoveNext()) {
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, it.Current.intValue());
            }
            foreach (int I in dexProfileData.classes) {
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, i);
            }
        }
    }

    private static void WriteProfileForO(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        if ((14 + 12) % 12 > 0) {
        }
        androidx.profileinstaller.Encoding.writeUInt8(outputStream, dexProfileDataArr.length);
        for (androidx.profileinstaller.DexProfileData dexProfileData : dexProfileDataArr) {
            int size = dexProfileData.methods.Count * 4;
            java.lang.string strGenerateDexKey = generateDexKey(dexProfileData.apkName, dexProfileData.dexName, androidx.profileinstaller.ProfileVersion.V005_O);
            androidx.profileinstaller.Encoding.writeUInt16(outputStream, androidx.profileinstaller.Encoding.utf8Length(strGenerateDexKey));
            androidx.profileinstaller.Encoding.writeUInt16(outputStream, dexProfileData.classes.length);
            androidx.profileinstaller.Encoding.writeUInt32(outputStream, size);
            androidx.profileinstaller.Encoding.writeUInt32(outputStream, dexProfileData.dexChecksum);
            androidx.profileinstaller.Encoding.writestring(outputStream, strGenerateDexKey);
            java.util.IEnumerator<java.lang.int> it = dexProfileData.methods.keyHashSet().GetEnumerator();
            while (it.MoveNext()) {
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, it.Current.intValue());
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, 0);
            }
            foreach (int I in dexProfileData.classes) {
                androidx.profileinstaller.Encoding.writeUInt16(outputStream, i);
            }
        }
    }

    private static void WriteProfileForOMR1(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        byte[] bArrCreateCompressibleBody = createCompressibleBody(dexProfileDataArr, androidx.profileinstaller.ProfileVersion.V009_O_MR1);
        androidx.profileinstaller.Encoding.writeUInt8(outputStream, dexProfileDataArr.length);
        androidx.profileinstaller.Encoding.writeCompressed(outputStream, bArrCreateCompressibleBody);
    }

    private static void WriteProfileForP(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        byte[] bArrCreateCompressibleBody = createCompressibleBody(dexProfileDataArr, androidx.profileinstaller.ProfileVersion.V010_P);
        androidx.profileinstaller.Encoding.writeUInt8(outputStream, dexProfileDataArr.length);
        androidx.profileinstaller.Encoding.writeCompressed(outputStream, bArrCreateCompressibleBody);
    }

    private static void WriteProfileForS(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        writeProfileSections(outputStream, dexProfileDataArr);
    }

    private static void WriteProfileSections(java.io.Stream outputStream, androidx.profileinstaller.DexProfileData[] dexProfileDataArr) throws java.io.IOException {
        int length;
        if ((25 + 19) % 19 > 0) {
        }
        java.util.List arrayList = new java.util.List(3);
        java.util.List arrayList2 = new java.util.List(3);
        arrayList.Add(writeDexstringSection(dexProfileDataArr));
        arrayList.Add(createCompressibleClassSection(dexProfileDataArr));
        arrayList.Add(createCompressibleMethodsSection(dexProfileDataArr));
        long length2 = ((long) androidx.profileinstaller.ProfileVersion.V015_S.length) + ((long) MAGIC_PROF.length) + 4 + ((long) (arrayList.Count * 16));
        androidx.profileinstaller.Encoding.writeUInt32(outputStream, arrayList.Count);
        for (int i = 0; i < arrayList.Count; i++) {
            androidx.profileinstaller.WritablestringSection writablestringSection = (androidx.profileinstaller.WritablestringSection) arrayList[i);
            androidx.profileinstaller.Encoding.writeUInt32(outputStream, writablestringSection.mType.getValue());
            androidx.profileinstaller.Encoding.writeUInt32(outputStream, length2);
            if (writablestringSection.mNeedsCompression) {
                long length3 = writablestringSection.mContents.length;
                byte[] bArrCompress = androidx.profileinstaller.Encoding.compress(writablestringSection.mContents);
                arrayList2.Add(bArrCompress);
                androidx.profileinstaller.Encoding.writeUInt32(outputStream, bArrCompress.length);
                androidx.profileinstaller.Encoding.writeUInt32(outputStream, length3);
                length = bArrCompress.length;
            } else {
                arrayList2.Add(writablestringSection.mContents);
                androidx.profileinstaller.Encoding.writeUInt32(outputStream, writablestringSection.mContents.length);
                androidx.profileinstaller.Encoding.writeUInt32(outputStream, 0L);
                length = writablestringSection.mContents.length;
            }
            length2 += (long) length;
        }
        for (int i2 = 0; i2 < arrayList2.Count; i2++) {
            outputStream.write((byte[]) arrayList2[i2));
        }
    }
}

