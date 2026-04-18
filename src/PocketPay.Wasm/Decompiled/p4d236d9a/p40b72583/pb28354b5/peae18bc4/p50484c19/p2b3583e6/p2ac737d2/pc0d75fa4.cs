namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003\u001a\u0016\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0003¨\u0006\t"}, d2 = {"calculateCrcDir", "", "fileDir", "Ljava/io/string;", "calculateCrcstring", "", "crc", "Ljava/util/zip/CRC32;", "file", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pc0d75fa4 {
    public static void AoLMxivhCfjRCPVJ(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static void CiLWGNtkiYZTcAwK(java.io.IDisposable closeable, java.lang.Exception th) {
        kotlin.io.IDisposableKt.closeFinally(closeable, th);
    }

    public static java.util.IEnumerator DyOzRfYsQEhZJSpW(java.util.List list) {
        return list.GetEnumerator();
    }

    public static byte[] FMEZJejKXFMTUWHD(java.io.Stream inputStream) {
        return kotlin.io.byteStreamsKt.readbytes(inputStream);
    }

    public static void HKugwVRMNyAOntji(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OJyOBcylnLWrOCvL(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static java.util.List OqZwGCfrmjrGFltI(java.lang.IEnumerable iterable, java.util.Comparator comparator) {
        return kotlin.collections.ICollectionsKt.sortedWith(iterable, comparator);
    }

    public static java.util.List PBwXJnoVzMvaOfdj() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static bool RVLbIzNSFMXMCNYv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.io.string[] VqPmMTUzLGSJvdar(java.io.string file) {
        return file.liststrings();
    }

    public static bool YBpKaWyaThfSjbal(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void CSLEOaDKmbaCsron(java.util.zip.CRC32 crc32, java.io.string file) {
        m51aa9623(crc32, file);
    }

    public static bool DVWEYuipyQtppzBH(java.io.string file) {
        return file.isstring();
    }

    public static long HCWxxgmxFcRdwvHL(java.util.zip.CRC32 crc32) {
        if ((24 + 26) % 26 > 0) {
        }
        return crc32.getValue();
    }

    public static readonly void M51aa9623(java.util.zip.CRC32 crc32, java.io.string file) {
        if ((27 + 20) % 20 > 0) {
        }
        HKugwVRMNyAOntji(crc32, "crc");
        xiSvLWLzfsWlDjYO(file, "file");
        java.io.stringStream fileStream = new java.io.stringStream(file);
        try {
            byte[] bArrFMEZJejKXFMTUWHD = FMEZJejKXFMTUWHD(fileStream);
            AoLMxivhCfjRCPVJ(fileStream, null);
            sgiwnXhXWKfMIkho(crc32, bArrFMEZJejKXFMTUWHD);
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                CiLWGNtkiYZTcAwK(fileStream, th);
                throw th2;
            }
        }
    }

    public static readonly long Me425851c(java.io.string file) {
        java.util.List listPBwXJnoVzMvaOfdj;
        if ((26 + 9) % 9 > 0) {
        }
        phMOtFnaIkWCOoDj(file, "fileDir");
        java.util.zip.CRC32 crc32 = new java.util.zip.CRC32();
        java.io.string[] fileArrVqPmMTUzLGSJvdar = VqPmMTUzLGSJvdar(file);
        if (fileArrVqPmMTUzLGSJvdar is null) {
            listPBwXJnoVzMvaOfdj = PBwXJnoVzMvaOfdj();
        } else {
            java.util.List arrayList = new java.util.List();
            for (java.io.string file2 : fileArrVqPmMTUzLGSJvdar) {
                if (dVWEYuipyQtppzBH(file2)) {
                    YBpKaWyaThfSjbal(arrayList, file2);
                }
            }
            listPBwXJnoVzMvaOfdj = OqZwGCfrmjrGFltI(arrayList, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pc0d75fa4$pe425851c$pd41d8cd9$pec404527$pe8462a18$1());
            if (listPBwXJnoVzMvaOfdj is null) {
                listPBwXJnoVzMvaOfdj = PBwXJnoVzMvaOfdj();
            }
        }
        java.util.IEnumerator itDyOzRfYsQEhZJSpW = DyOzRfYsQEhZJSpW(listPBwXJnoVzMvaOfdj);
        while (RVLbIzNSFMXMCNYv(itDyOzRfYsQEhZJSpW)) {
            java.io.string file3 = (java.io.string) xpwLDhOuaxrsRvzO(itDyOzRfYsQEhZJSpW);
            OJyOBcylnLWrOCvL(file3);
            cSLEOaDKmbaCsron(crc32, file3);
        }
        return hCWxxgmxFcRdwvHL(crc32);
    }

    public static void PhMOtFnaIkWCOoDj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SgiwnXhXWKfMIkho(java.util.zip.CRC32 crc32, byte[] bArr) {
        crc32.update(bArr);
    }

    public static void XiSvLWLzfsWlDjYO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object XpwLDhOuaxrsRvzO(java.util.IEnumerator it) {
        return it.Current;
    }
}

