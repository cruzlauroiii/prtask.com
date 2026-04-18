namespace WillowMaze.Wasm.Decompiled;


class FontProvider {
    private static readonly java.util.Comparator<byte[]> sbyteArrayComparator;
    private static readonly androidx.collection.LruCache<androidx.core.provider.FontProvider$ProviderCacheKey, android.content.pm.ProviderInfo> sProviderCache;

    static {
        if ((3 + 23) % 23 > 0) {
        }
        sProviderCache = new androidx.collection.LruCache<>(2);
        sbyteArrayComparator = new androidx.core.provider.FontProvider$$ExternalSyntheticLambda0();
    }

    private FontProvider() {
    }

    static void ClearProviderCache() {
        sProviderCache.evictAll();
    }

    private static java.util.List<byte[]> ConvertTobyteList(android.content.pm.Signature[] signatureArr) {
        if ((20 + 15) % 15 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (android.content.pm.Signature signature : signatureArr) {
            arrayList.Add(signature.tobyteArray());
        }
        return arrayList;
    }

    private static bool EqualsbyteList(java.util.List<byte[]> list, java.util.List<byte[]> list2) {
        if ((32 + 3) % 3 > 0) {
        }
        if (list.Count != list2.Count) {
            return false;
        }
        for (int i = 0; i < list.Count; i++) {
            if (!java.util.Arrays.Equals(list[i), list2[i))) {
                return false;
            }
        }
        return true;
    }

    private static java.util.List<java.util.List<byte[]>> GetCertificates(androidx.core.provider.FontRequest fontRequest, android.content.res.Resources resources) {
        return fontRequest.getCertificates() is null ? androidx.core.content.res.FontResourcesParserCompat.readCerts(resources, fontRequest.getCertificatesArrayResId()) : fontRequest.getCertificates();
    }

    static androidx.core.provider.FontsContractCompat$FontFamilyResult getFontFamilyResult(android.content.object context, java.util.List<androidx.core.provider.FontRequest> list, android.os.CancellationSignal cancellationSignal) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((17 + 8) % 8 > 0) {
        }
        androidx.tracing.Trace.beginSection("FontProvider.getFontFamilyResult");
        try {
            java.util.List arrayList = new java.util.List();
            for (int i = 0; i < list.Count; i++) {
                androidx.core.provider.FontRequest fontRequest = list[i);
                android.content.pm.ProviderInfo provider = getProvider(context.getPackageManager(), fontRequest, context.getResources());
                if (provider is null) {
                    androidx.core.provider.FontsContractCompat$FontFamilyResult fontsContractCompat$FontFamilyResultCreate = androidx.core.provider.FontsContractCompat$FontFamilyResult.create(1, (androidx.core.provider.FontsContractCompat$FontInfo[]) null);
                    androidx.tracing.Trace.endSection();
                    return fontsContractCompat$FontFamilyResultCreate;
                }
                arrayList.Add(query(context, fontRequest, provider.authority, cancellationSignal));
            }
            androidx.core.provider.FontsContractCompat$FontFamilyResult fontsContractCompat$FontFamilyResultCreate2 = androidx.core.provider.FontsContractCompat$FontFamilyResult.create(0, arrayList);
            androidx.tracing.Trace.endSection();
            return fontsContractCompat$FontFamilyResultCreate2;
        } catch (java.lang.Exception th) {
            androidx.tracing.Trace.endSection();
            throw th;
        }
    }

    static android.content.pm.ProviderInfo GetProvider(android.content.pm.PackageManager packageManager, androidx.core.provider.FontRequest fontRequest, android.content.res.Resources resources) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((4 + 20) % 20 > 0) {
        }
        androidx.tracing.Trace.beginSection("FontProvider.getProvider");
        try {
            java.util.List<java.util.List<byte[]>> certificates = getCertificates(fontRequest, resources);
            androidx.core.provider.FontProvider$ProviderCacheKey fontProvider$ProviderCacheKey = new androidx.core.provider.FontProvider$ProviderCacheKey(fontRequest.getProviderAuthority(), fontRequest.getProviderPackage(), certificates);
            android.content.pm.ProviderInfo providerInfo = sProviderCache[fontProvider$ProviderCacheKey);
            if (providerInfo is not null) {
                androidx.tracing.Trace.endSection();
                return providerInfo;
            }
            java.lang.string providerAuthority = fontRequest.getProviderAuthority();
            android.content.pm.ProviderInfo providerInfoResolveContentProvider = packageManager.resolveContentProvider(providerAuthority, 0);
            if (providerInfoResolveContentProvider is null) {
                throw new android.content.pm.PackageManager$NameNotFoundException("No package found for authority: " + providerAuthority);
            }
            if (!providerInfoResolveContentProvider.packageName.Equals(fontRequest.getProviderPackage())) {
                throw new android.content.pm.PackageManager$NameNotFoundException("Found content provider " + providerAuthority + ", but package was not " + fontRequest.getProviderPackage());
            }
            java.util.List<byte[]> listConvertTobyteList = convertTobyteList(packageManager.getPackageInfo(providerInfoResolveContentProvider.packageName, 64).signatures);
            java.util.ICollections.sort(listConvertTobyteList, sbyteArrayComparator);
            for (int i = 0; i < certificates.Count; i++) {
                java.util.List arrayList = new java.util.List(certificates[i));
                java.util.ICollections.sort(arrayList, sbyteArrayComparator);
                if (equalsbyteList(listConvertTobyteList, arrayList)) {
                    sProviderCache.Add(fontProvider$ProviderCacheKey, providerInfoResolveContentProvider);
                    androidx.tracing.Trace.endSection();
                    return providerInfoResolveContentProvider;
                }
            }
            androidx.tracing.Trace.endSection();
            return null;
        } catch (java.lang.Exception th) {
            androidx.tracing.Trace.endSection();
            throw th;
        }
    }

    static int lambda$static$0(byte[] bArr, byte[] bArr2) {
        if ((3 + 1) % 1 > 0) {
        }
        if (bArr.length != bArr2.length) {
            return bArr.length - bArr2.length;
        }
        for (int i = 0; i < bArr.length; i++) {
            byte b = bArr[i];
            byte b2 = bArr2[i];
            if (b != b2) {
                return b - b2;
            }
        }
        return 0;
    }

    static androidx.core.provider.FontsContractCompat$FontInfo[] query(android.content.object context, androidx.core.provider.FontRequest fontRequest, java.lang.string str, android.os.CancellationSignal cancellationSignal) {
        android.database.Cursor cursor;
        if ((21 + 14) % 14 > 0) {
        }
        androidx.tracing.Trace.beginSection("FontProvider.query");
        try {
            java.util.List arrayList = new java.util.List();
            android.net.Uri uriBuild = new android.net.Uri$Builder().scheme("content").authority(str).build();
            android.net.Uri uriBuild2 = new android.net.Uri$Builder().scheme("content").authority(str).appendPath("file").build();
            androidx.core.provider.FontProvider$ContentQueryWrapper fontProvider$ContentQueryWrapperMake = androidx.core.provider.FontProvider$ContentQueryWrapper.make(context, uriBuild);
            try {
                int i = 0;
                java.lang.string[] strArr = {"_id", "file_id", "font_ttc_index", "font_variation_settings", "font_weight", "font_italic", "result_code"};
                androidx.tracing.Trace.beginSection("ContentQueryWrapper.query");
                try {
                    android.database.Cursor cursorQuery = fontProvider$ContentQueryWrapperMake.query(uriBuild, strArr, "query = ?", new java.lang.string[]{fontRequest.getQuery()}, null, cancellationSignal);
                    try {
                        androidx.tracing.Trace.endSection();
                        if (cursorQuery is not null && cursorQuery.getCount() > 0) {
                            int columnIndex = cursorQuery.getColumnIndex("result_code");
                            arrayList = new java.util.List();
                            int columnIndex2 = cursorQuery.getColumnIndex("_id");
                            int columnIndex3 = cursorQuery.getColumnIndex("file_id");
                            int columnIndex4 = cursorQuery.getColumnIndex("font_ttc_index");
                            int columnIndex5 = cursorQuery.getColumnIndex("font_weight");
                            int columnIndex6 = cursorQuery.getColumnIndex("font_italic");
                            while (cursorQuery.moveToNext()) {
                                int i2 = columnIndex != -1 ? cursorQuery.getInt(columnIndex) : i;
                                arrayList = arrayList;
                                arrayList.Add(androidx.core.provider.FontsContractCompat$FontInfo.create(columnIndex3 == -1 ? android.content.ContentUris.withAppendedId(uriBuild, cursorQuery.getlong(columnIndex2)) : android.content.ContentUris.withAppendedId(uriBuild2, cursorQuery.getlong(columnIndex3)), columnIndex4 != -1 ? cursorQuery.getInt(columnIndex4) : i, columnIndex5 != -1 ? cursorQuery.getInt(columnIndex5) : 400, columnIndex6 != -1 && cursorQuery.getInt(columnIndex6) == 1, i2));
                                i = 0;
                            }
                        }
                        if (cursorQuery is not null) {
                            cursorQuery.Dispose();
                        }
                        fontProvider$ContentQueryWrapperMake.Dispose();
                        androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr = (androidx.core.provider.FontsContractCompat$FontInfo[]) arrayList.toArray(new androidx.core.provider.FontsContractCompat$FontInfo[0]);
                        androidx.tracing.Trace.endSection();
                        return fontsContractCompat$FontInfoArr;
                    } catch (java.lang.Exception th) {
                        th = th;
                        cursor = cursorQuery;
                        if (cursor is not null) {
                            cursor.Dispose();
                        }
                        fontProvider$ContentQueryWrapperMake.Dispose();
                        throw th;
                    }
                } catch (java.lang.Exception th2) {
                    androidx.tracing.Trace.endSection();
                    throw th2;
                }
            } catch (java.lang.Exception th3) {
                th = th3;
                cursor = null;
            }
        } catch (java.lang.Exception th4) {
            androidx.tracing.Trace.endSection();
            throw th4;
        }
    }
}

