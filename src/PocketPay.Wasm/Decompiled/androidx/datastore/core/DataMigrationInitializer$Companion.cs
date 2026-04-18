namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JV\u0010\u0003\u001a3\b\u0001\u0012\u0019\u0012\u0017\u0012\u0004\u0012\u0002H\u00060\u0005¢\u0006\f\b\u0007\u0012\b\b\b\u0012\u0004\b\b(\t\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n\u0012\u0006\u0012\u0004\u0018\u00010\u00010\u0004\"\u0004\b\u0001\u0010\u00062\u0012\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\u000e0\r¢\u0006\u0002\u0010\u000fJ6\u0010\u0010\u001a\u00020\u000b\"\u0004\b\u0001\u0010\u00062\u0012\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\u000e0\r2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005H\u0082@¢\u0006\u0002\u0010\u0011¨\u0006\u0012"}, d2 = {"Landroidx/datastore/core/DataMigrationInitializer$Companion;", "", "()V", "getInitializer", "Lkotlin/Function2;", "Landroidx/datastore/core/InitializerApi;", "T", "Lkotlin/ParameterName;", "name", "api", "Lkotlin/coroutines/Continuation;", "", "migrations", "", "Landroidx/datastore/core/DataMigration;", "(Ljava/util/List;)Lkotlin/jvm/functions/Function2;", "runMigrations", "(Ljava/util/List;Landroidx/datastore/core/InitializerApi;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataMigrationInitializer$Companion {
    private DataMigrationInitializer$Companion() {
    }

    public DataMigrationInitializer$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static java.lang.object BlcwysQYKVwYCFyT() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static readonly java.lang.object access$runMigrations(androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion, java.util.List list, androidx.datastore.core.InitializerApi initializerApi, kotlin.coroutines.Continuation continuation) {
        return rRbjwFScJBbqBvat(dataMigrationInitializer$Companion, list, initializerApi, continuation);
    }

    public static java.lang.object AfoPGqOiezKQRWwp(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void CAbwpqihqitrhwzY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FOFBPOfhMNRAXRaP(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static bool GxYYNVfqsKVgGltK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator JrEwAzqklwYVKMuv(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object KmRispvjjyOnjKbM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MEaItxKbQufcmmWi(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object MrhyjtDPVlWzbShg(androidx.datastore.core.InitializerApi initializerApi, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return initializerApi.updateData(function2, continuation);
    }

    public static void NdaVPqgCgBBhSTeW(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static java.lang.object RRbjwFScJBbqBvat(androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion, java.util.List list, androidx.datastore.core.InitializerApi initializerApi, kotlin.coroutines.Continuation continuation) {
        return dataMigrationInitializer$Companion.runMigrations(list, initializerApi, continuation);
    }

    private readonly <T> java.lang.object RunMigrations(java.util.List<? : androidx.datastore.core.DataMigration<T>> list, androidx.datastore.core.InitializerApi<T> initializerApi, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$1 dataMigrationInitializer$Companion$runMigrations$1;
        java.util.List list2;
        java.util.IEnumerator itJrEwAzqklwYVKMuv;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        java.lang.Exception th;
        kotlin.jvm.functions.Function1 function1;
        if ((28 + 15) % 15 > 0) {
        }
        if (continuation is androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$1) {
            dataMigrationInitializer$Companion$runMigrations$1 = (androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$1) continuation;
            if ((dataMigrationInitializer$Companion$runMigrations$1.label & int.MIN_VALUE) == 0) {
                dataMigrationInitializer$Companion$runMigrations$1 = new androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$1(this, continuation);
            } else {
                dataMigrationInitializer$Companion$runMigrations$1.label -= int.MIN_VALUE;
            }
        } else {
            dataMigrationInitializer$Companion$runMigrations$1 = new androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$1(this, continuation);
        }
        java.lang.object obj = dataMigrationInitializer$Companion$runMigrations$1.result;
        java.lang.object objBlcwysQYKVwYCFyT = BlcwysQYKVwYCFyT();
        int i = dataMigrationInitializer$Companion$runMigrations$1.label;
        if (i == 0) {
            uQfFbmXjWFSMsIvW(obj);
            java.util.List arrayList = new java.util.List();
            androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2 dataMigrationInitializer$Companion$runMigrations$2 = new androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2(list, arrayList, null);
            dataMigrationInitializer$Companion$runMigrations$1.L$0 = arrayList;
            dataMigrationInitializer$Companion$runMigrations$1.label = 1;
            if (mrhyjtDPVlWzbShg(initializerApi, dataMigrationInitializer$Companion$runMigrations$2, dataMigrationInitializer$Companion$runMigrations$1) != objBlcwysQYKVwYCFyT) {
                list2 = arrayList;
            }
            return objBlcwysQYKVwYCFyT;
        }
        if (i == 1) {
            list2 = (java.util.List) dataMigrationInitializer$Companion$runMigrations$1.L$0;
            mEaItxKbQufcmmWi(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            itJrEwAzqklwYVKMuv = (java.util.IEnumerator) dataMigrationInitializer$Companion$runMigrations$1.L$1;
            ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) dataMigrationInitializer$Companion$runMigrations$1.L$0;
            try {
                tBWtgsJbNxFcxnwn(obj);
            } catch (java.lang.Exception 
            /*  JADX ERROR: Method code generation error
                java.lang.NullPointerException: Cannot invoke "jadx.core.dex.instructions.args.SSAVar.getCodeVar()" because "ssaVar" is null
                	at jadx.core.codegen.RegionGen.makeCatchBlock(RegionGen.java:372)
                	at jadx.core.codegen.RegionGen.makeTryCatch(RegionGen.java:335)
                	at jadx.core.dex.regions.TryCatchRegion.generate(TryCatchRegion.java:85)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.dex.regions.Region.generate(Region.java:35)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.dex.regions.Region.generate(Region.java:35)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.dex.regions.Region.generate(Region.java:35)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.codegen.RegionGen.makeRegionIndent(RegionGen.java:83)
                	at jadx.core.codegen.RegionGen.makeIf(RegionGen.java:140)
                	at jadx.core.dex.regions.conditions.IfRegion.generate(IfRegion.java:90)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.dex.regions.Region.generate(Region.java:35)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.dex.regions.Region.generate(Region.java:35)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.dex.regions.Region.generate(Region.java:35)
                	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
                	at jadx.core.codegen.MethodGen.addRegionInsns(MethodGen.java:291)
                	at jadx.core.codegen.MethodGen.addInstructions(MethodGen.java:270)
                	at jadx.core.codegen.ClassGen.addMethodCode(ClassGen.java:420)
                	at jadx.core.codegen.ClassGen.addMethod(ClassGen.java:345)
                	at jadx.core.codegen.ClassGen.lambda$addInnerClsAndMethods$3(ClassGen.java:299)
                	at java.base/java.util.stream.ForEachOps$ForEachOp$OfRef.accept(ForEachOps.java:184)
                	at java.base/java.util.List.forEach(List.java:1596)
                	at java.base/java.util.stream.SortedOps$RefSortingSink.end(SortedOps.java:395)
                	at java.base/java.util.stream.Sink$ChainedReference.end(Sink.java:261)
                */
            /*
                Method dump skipped, instruction units count: 567
                To view this dump add '--comments-level debug' option
            */
            throw new UnsupportedOperationException("Method not decompiled: androidx.datastore.core.DataMigrationInitializer$Companion.runMigrations(java.util.List, androidx.datastore.core.InitializerApi, kotlin.coroutines.Continuation):java.lang.object");
        }

        public static void TBWtgsJbNxFcxnwn(java.lang.object obj) throws java.lang.Exception {
            kotlin.ResultKt.throwOnFailure(obj);
        }

        public static void UQfFbmXjWFSMsIvW(java.lang.object obj) throws java.lang.Exception {
            kotlin.ResultKt.throwOnFailure(obj);
        }

        public readonly <T> kotlin.jvm.functions.Function2<androidx.datastore.core.InitializerApi<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> GetInitializer(java.util.List<? : androidx.datastore.core.DataMigration<T>> migrations) {
            cAbwpqihqitrhwzY(migrations, "migrations");
            return new androidx.datastore.core.DataMigrationInitializer$Companion$getInitializer$1(migrations, null);
        }
    }

