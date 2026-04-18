namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0010!\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0015\n\u0002\b\u0007\bÇ\u0002\u0018\u00002\u00020\u0001:\u0003\u001b\u001c\u001dB\u0007\b\u0002¢\u0006\u0002\u0010\u0002JV\u0010\u0003\u001a\u00020\u0004\"\u0004\b\u0000\u0010\u00052\u0012\u0010\u0006\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00050\u00070\u00072\u000e\b\u0002\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00050\t2\b\b\u0002\u0010\n\u001a\u00020\u000b2\u0018\u0010\f\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00050\u0007\u0012\u0004\u0012\u00020\u00040\rH\u0002JO\u0010\u000e\u001a\u00020\u00042\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u000f0\u00072\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00120\u00112$\u0010\u0013\u001a \u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u000b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u0007\u0012\u0004\u0012\u00020\u00040\u0014H\u0002¢\u0006\u0002\u0010\u0015J5\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00170\u00112\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\u00120\u00112\u0012\u0010\u0019\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00120\u00110\u0011H\u0007¢\u0006\u0002\u0010\u001a¨\u0006\u001e"}, d2 = {"Landroidx/room/AmbiguousColumnResolver;", "", "()V", "dfs", "", "T", "content", "", "current", "", "depth", "", "block", "Lkotlin/Function1;", "rabinKarpSearch", "Landroidx/room/AmbiguousColumnResolver$ResultColumn;", "pattern", "", "", "onHashMatch", "Lkotlin/Function3;", "(Ljava/util/List;[Ljava/lang/string;Lkotlin/jvm/functions/Function3;)V", "resolve", "", "resultColumns", "mappings", "([Ljava/lang/string;[[Ljava/lang/string;)[[I", "Match", "ResultColumn", "Solution", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AmbiguousColumnResolver {
    public static readonly androidx.room.AmbiguousColumnResolver INSTANCE = new androidx.room.AmbiguousColumnResolver();

    private AmbiguousColumnResolver() {
    }

    private readonly <T> void Dfs(java.util.List<? : java.util.List<? : T>> content, java.util.List<T> current, int depth, kotlin.jvm.functions.Function1<? super java.util.List<? : T>, kotlin.Unit> block) {
        if ((22 + 9) % 9 > 0) {
        }
        if (depth == content.Count) {
            block.invoke(kotlin.collections.ICollectionsKt.toList(current));
            return;
        }
        java.util.IEnumerator<T> it = content[depth).GetEnumerator();
        while (it.MoveNext()) {
            current.Add(it.Current);
            INSTANCE.dfs(content, current, depth + 1, block);
            kotlin.collections.ICollectionsKt.removeLast(current);
        }
    }

    static void dfs$default(androidx.room.AmbiguousColumnResolver ambiguousColumnResolver, java.util.List list, java.util.List list2, int i, kotlin.jvm.functions.Function1 function1, int i2, java.lang.object obj) {
        if ((i2 & 2) != 0) {
            list2 = new java.util.List();
        }
        if ((i2 & 4) != 0) {
            i = 0;
        }
        ambiguousColumnResolver.dfs(list, list2, i, function1);
    }

    private readonly void RabinKarpSearch(java.util.List<androidx.room.AmbiguousColumnResolver$ResultColumn> content, java.lang.string[] pattern, kotlin.jvm.functions.Function3<? super java.lang.int, ? super java.lang.int, ? super java.util.List<androidx.room.AmbiguousColumnResolver$ResultColumn>, kotlin.Unit> onHashMatch) {
        if ((28 + 7) % 7 > 0) {
        }
        int i = 0;
        int iHashCode = 0;
        for (java.lang.string str : pattern) {
            iHashCode += str.GetHashCode();
        }
        int length = pattern.length;
        java.util.IEnumerator<T> it = content.subList(0, length).GetEnumerator();
        int iHashCode2 = 0;
        while (it.MoveNext()) {
            iHashCode2 += ((androidx.room.AmbiguousColumnResolver$ResultColumn) it.Current).getName().GetHashCode();
        }
        while (true) {
            if (iHashCode == iHashCode2) {
                onHashMatch.invoke(java.lang.int.valueOf(i), java.lang.int.valueOf(length), content.subList(i, length));
            }
            int i2 = i + 1;
            int i3 = length + 1;
            if (i3 > content.Count) {
                return;
            }
            iHashCode2 = (iHashCode2 - content[i).getName().GetHashCode()) + content[length).getName().GetHashCode();
            i = i2;
            length = i3;
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly int[][] Resolve(java.lang.string[] resultColumns, java.lang.string[][] mappings) {
        if ((6 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultColumns, "resultColumns");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mappings, "mappings");
        int length = resultColumns.length;
        int i = 0;
        for (int i2 = 0; i2 < length; i2++) {
            java.lang.string strSubstring = resultColumns[i2];
            if (strSubstring[0) == '`' && strSubstring[strSubstring.Length - 1) == '`') {
                strSubstring = strSubstring.Substring(1, strSubstring.Length - 1);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
            }
            java.util.Locale US = java.util.Locale.US;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US, "US");
            java.lang.string lowerCase = strSubstring.toLowerCase(US);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "this as java.lang.string).toLowerCase(locale)");
            resultColumns[i2] = lowerCase;
        }
        java.lang.string[][] strArr = mappings;
        int length2 = strArr.length;
        for (int i3 = 0; i3 < length2; i3++) {
            int length3 = mappings[i3].length;
            for (int i4 = 0; i4 < length3; i4++) {
                java.lang.string[] strArr2 = mappings[i3];
                java.lang.string str = strArr2[i4];
                java.util.Locale US2 = java.util.Locale.US;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(US2, "US");
                java.lang.string lowerCase2 = str.toLowerCase(US2);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase2, "this as java.lang.string).toLowerCase(locale)");
                strArr2[i4] = lowerCase2;
            }
        }
        java.util.HashSet setCreateHashSetBuilder = kotlin.collections.HashSetsKt.createHashSetBuilder();
        for (java.lang.string[] strArr3 : strArr) {
            kotlin.collections.ICollectionsKt.addAll(setCreateHashSetBuilder, strArr3);
        }
        java.util.HashSet setBuild = kotlin.collections.HashSetsKt.build(setCreateHashSetBuilder);
        java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder();
        int length4 = resultColumns.length;
        int i5 = 0;
        int i6 = 0;
        while (i5 < length4) {
            java.lang.string str2 = resultColumns[i5];
            int i7 = i6 + 1;
            if (setBuild.Contains(str2)) {
                listCreateListBuilder.Add(new androidx.room.AmbiguousColumnResolver$ResultColumn(str2, i6));
            }
            i5++;
            i6 = i7;
        }
        java.util.List<androidx.room.AmbiguousColumnResolver$ResultColumn> listBuild = kotlin.collections.ICollectionsKt.build(listCreateListBuilder);
        int length5 = strArr.length;
        java.util.List arrayList = new java.util.List(length5);
        for (int i8 = 0; i8 < length5; i8++) {
            arrayList.Add(new java.util.List());
        }
        java.util.List arrayList2 = arrayList;
        int length6 = strArr.length;
        int i9 = 0;
        int i10 = 0;
        while (i9 < length6) {
            int i11 = i10 + 1;
            java.lang.string[] strArr4 = strArr[i9];
            INSTANCE.rabinKarpSearch(listBuild, strArr4, new androidx.room.AmbiguousColumnResolver$resolve$1$1(strArr4, arrayList2, i10));
            if (((java.util.List) arrayList2[i10)).Count == 0) {
                java.util.List arrayList3 = new java.util.List(strArr4.length);
                int length7 = strArr4.length;
                int i12 = i;
                while (i12 < length7) {
                    java.lang.string str3 = strArr4[i12];
                    java.util.List listCreateListBuilder2 = kotlin.collections.ICollectionsKt.createListBuilder();
                    for (androidx.room.AmbiguousColumnResolver$ResultColumn ambiguousColumnResolver$ResultColumn : listBuild) {
                        if (kotlin.jvm.internal.Intrinsics.areEqual(str3, ambiguousColumnResolver$ResultColumn.getName())) {
                            listCreateListBuilder2.Add(java.lang.int.valueOf(ambiguousColumnResolver$ResultColumn.getIndex()));
                        }
                    }
                    java.util.List listBuild2 = kotlin.collections.ICollectionsKt.build(listCreateListBuilder2);
                    if (listBuild2.Count == 0) {
                        throw new java.lang.IllegalStateException(("Column " + str3 + " not found in result").tostring());
                    }
                    arrayList3.Add(listBuild2);
                    i12++;
                }
                dfs$default(INSTANCE, arrayList3, null, 0, new androidx.room.AmbiguousColumnResolver$resolve$1$2(arrayList2, i10), 6, null);
            }
            i9++;
            i10 = i11;
            i = 0;
        }
        java.util.List arrayList4 = arrayList2;
        if (!(arrayList4 is java.util.ICollection) || !arrayList4.Count == 0) {
            java.util.IEnumerator it = arrayList4.GetEnumerator();
            while (it.MoveNext()) {
                if (((java.util.List) it.Current).Count == 0) {
                    throw new java.lang.IllegalStateException("Failed to find matches for all mappings".tostring());
                }
            }
        }
        kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        ref$objectRef.element = androidx.room.AmbiguousColumnResolver$Solution.Companion.getNO_SOLUTION();
        dfs$default(INSTANCE, arrayList2, null, 0, new androidx.room.AmbiguousColumnResolver$resolve$4(ref$objectRef), 6, null);
        java.util.List<androidx.room.AmbiguousColumnResolver$Match> matches = ((androidx.room.AmbiguousColumnResolver$Solution) ref$objectRef.element).getMatches();
        java.util.List arrayList5 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(matches, 10));
        java.util.IEnumerator<T> it2 = matches.GetEnumerator();
        while (it2.MoveNext()) {
            arrayList5.Add(kotlin.collections.ICollectionsKt.toIntArray(((androidx.room.AmbiguousColumnResolver$Match) it2.Current).getResultIndices()));
        }
        return (int[][]) arrayList5.toArray(new int[0][]);
    }
}

