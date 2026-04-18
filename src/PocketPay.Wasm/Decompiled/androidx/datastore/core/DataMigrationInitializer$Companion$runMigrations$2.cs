namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u0004\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001\"\u0004\b\u0001\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u0001H\u008a@"}, d2 = {"<anonymous>", "T", "startingData"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2", m533f = "DataMigrationInitializer.kt", m534i = {0, 0}, m535l = {44, 46}, m536m = "invokeSuspend", m537n = {"migration", "data"}, m538s = {"L$2", "L$3"})
readonly class DataMigrationInitializer$Companion$runMigrations$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly /* synthetic */ java.util.List<kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>> $cleanUps;
    readonly /* synthetic */ java.util.List<androidx.datastore.core.DataMigration<T>> $migrations;
    /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;

    DataMigrationInitializer$Companion$runMigrations$2(java.util.List<? : androidx.datastore.core.DataMigration<T>> r1, java.util.List<kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>> r2, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2> r3) {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto L1c
        Lb:
            r0.<init>(r1, r3)
            goto L12
        L12:
            return
        L13:
            goto L22
        L17:
            r1 = 2
            goto Lb
        L1c:
            r0.$migrations = r1
            goto L25
        L22:
            goto L7
        L25:
            r0.$cleanUps = r2
            goto L17
    }

    public static java.lang.object ApuElNkfFodKBZpc(androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2 r1, java.lang.object r2, kotlin.coroutines.Continuation r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.object r0 = r1.invoke(r2, r3)
            goto Lb
    }

    public static bool KipQyWbNiLkgPlsH(java.util.IEnumerator r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.MoveNext()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.util.IEnumerator QNVBjPlefTCpnnul(java.lang.IEnumerable r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Lb
    }

    public static java.lang.object UpObqAqpjXjDsTDa() {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void ZOkQQZfRlDpUsRMm(java.lang.object r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            kotlin.ResultKt.throwOnFailure(r0)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.object EFcWSqzJWnQpkAzI(androidx.datastore.core.DataMigration r1, java.lang.object r2, kotlin.coroutines.Continuation r3) {
            goto Lf
        L4:
            java.lang.object r0 = r1.shouldMigrate(r2, r3)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.lang.object GPFBSlsLIzfrMHJk(androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2 r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.invokeSuspend(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static kotlin.coroutines.Continuation IrKpPlSNnhAeEgvG(androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2 r1, java.lang.object r2, kotlin.coroutines.Continuation r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            kotlin.coroutines.Continuation r0 = r1.create(r2, r3)
            goto L7
    }

    public static void MwdHFZbFZjheThVl(java.lang.object r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            kotlin.ResultKt.throwOnFailure(r0)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.object PFZKTAmcZgTXsMLb(androidx.datastore.core.DataMigration r1, java.lang.object r2, kotlin.coroutines.Continuation r3) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.object r0 = r1.migrate(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static bool USOHXiGIIgGYreOr(java.lang.bool r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.boolValue()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool XdtDxmGPPdNkUbxw(java.util.List r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Add(r2)
            goto L4
        L18:
            goto Lc
    }

    public static void ZbJVzVkFOLDVIfPA(java.lang.object r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            kotlin.ResultKt.throwOnFailure(r0)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.object ZyKEopatURgmVFVw(java.util.IEnumerator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.object r0 = r1.Current
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L31
        L4:
            androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2 r0 = new androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2
            goto L55
        La:
            return r0
        Lb:
            goto L1b
        Lf:
            java.util.List<kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>> r2 = r2.$cleanUps
            goto L5b
        L15:
            r0.L$0 = r3
            goto L49
        L1b:
            goto L3e
        L1e:
            goto L38
        L22:
            int r0 = r0 % r1
            goto L28
        L28:
            if (r0 <= 0) goto L2d
            goto L3e
        L2d:
            goto L3b
        L31:
            goto L1e
        L34:
            goto L62
        L38:
            goto L34
        L3b:
            goto Lb
        L3e:
            goto L4
        L42:
            r1 = 1
            goto L4f
        L49:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto La
        L4f:
            int r0 = r0 + r1
            goto L22
        L55:
            java.util.List<androidx.datastore.core.DataMigration<T>> r1 = r2.$migrations
            goto Lf
        L5b:
            r0.<init>(r1, r2, r4)
            goto L15
        L62:
            r0 = 9
            goto L42
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object r2) {
            r0 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            goto L7
        Le:
            java.lang.object r0 = ApuElNkfFodKBZpc(r0, r1, r2)
            goto L1c
        L16:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto Le
        L1c:
            return r0
        L1d:
            goto Lb
    }

    public readonly java.lang.object Invoke(T r1, kotlin.coroutines.Continuation<T> r2) {
            r0 = this;
            goto L11
        L4:
            kotlin.coroutines.Continuation r0 = irKpPlSNnhAeEgvG(r0, r1, r2)
            goto L26
        Lc:
            return r0
        Ld:
            goto L2c
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L1e
        L1e:
            java.lang.object r0 = gPFBSlsLIzfrMHJk(r0, r1)
            goto Lc
        L26:
            androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2 r0 = (androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2) r0
            goto L18
        L2c:
            goto L14
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r10) {
            r9 = this;
            goto L1f3
        L4:
            r9.L$2 = r7
            goto L174
        La:
            java.util.List r6 = (java.util.List) r6
            goto L2f
        L10:
            goto L1b7
        L12:
            goto Lf5
        L16:
            if (r5 != 0) goto L1b
            goto L20
        L1b:
            goto Lfa
        L1f:
            goto L57
        L20:
            goto Lf0
        L24:
            r6 = r4
            goto L63
        L29:
            java.lang.IllegalStateException r9 = new java.lang.IllegalStateException
            goto L86
        L2f:
            zbJVzVkFOLDVIfPA(r10)
            goto L187
        L36:
            androidx.datastore.core.DataMigration r5 = (androidx.datastore.core.DataMigration) r5
            goto L10e
        L3c:
            r10.<init>(r6, r7)
            goto Lc3
        L43:
            goto L1b7
        L45:
            goto L29
        L49:
            r9.L$1 = r1
            goto L18c
        L4f:
            r0 = 26
            goto L1bb
        L56:
            return r0
        L57:
            goto Leb
        L5b:
            java.lang.object r10 = pFZKTAmcZgTXsMLb(r6, r1, r9)
            goto L1c2
        L63:
            r4 = r8
            goto L131
        L68:
            r8 = r1
            goto L11b
        L6d:
            throw r9
        L6e:
            goto L1ed
        L72:
            bool r10 = uSOHXiGIIgGYreOr(r10)
            goto L1e4
        L7a:
            r9.label = r3
            goto L1d1
        L80:
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1
            goto L198
        L86:
            java.lang.string r10 = "call to 'resume' before 'invoke' with coroutine"
            goto Ld2
        L8c:
            bool r5 = KipQyWbNiLkgPlsH(r1)
            goto L16
        L94:
            java.lang.object r6 = r9.L$0
            goto La
        L9a:
            ZOkQQZfRlDpUsRMm(r10)
            goto L43
        La1:
            java.lang.object r4 = r9.L$0
            goto L126
        La7:
            mwdHFZbFZjheThVl(r10)
            goto Lbd
        Lae:
            if (r1 != 0) goto Lb3
            goto L132
        Lb3:
            goto L136
        Lb7:
            java.util.IEnumerator r5 = (java.util.IEnumerator) r5
            goto L94
        Lbd:
            java.lang.object r10 = r9.L$0
            goto L17a
        Lc3:
            xdtDxmGPPdNkUbxw(r4, r10)
            goto L120
        Lca:
            java.lang.object r0 = UpObqAqpjXjDsTDa()
            goto L1fa
        Ld2:
            r9.<init>(r10)
            goto L6d
        Ld9:
            if (r6 == r0) goto Lde
            goto L1e0
        Lde:
            goto L1df
        Le2:
            goto L1f6
        Le5:
            java.lang.object r5 = r9.L$1
            goto Lb7
        Leb:
            r1 = r5
            goto L10
        Lf0:
            return r10
        Lf1:
            goto L114
        Lf5:
            r10 = r1
            goto L1f
        Lfa:
            java.lang.object r5 = zyKEopatURgmVFVw(r1)
            goto L36
        L102:
            r9.label = r2
            goto L5b
        L108:
            androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1 r10 = new androidx.datastore.core.DataMigrationInitializer$Companion$runMigrations$2$1$1
            goto L12c
        L10e:
            r9.L$0 = r4
            goto L49
        L114:
            goto L183
        L117:
            goto Le2
        L11b:
            r1 = r10
            goto L1ae
        L120:
            r9.L$0 = r4
            goto L192
        L126:
            java.util.List r4 = (java.util.List) r4
            goto L9a
        L12c:
            r7 = 0
            goto L3c
        L131:
            goto L1aa
        L132:
            goto La7
        L136:
            if (r1 != r3) goto L13b
            goto L6e
        L13b:
            goto L151
        L13f:
            int r0 = r0 % r1
            goto L160
        L145:
            int r0 = r0 + r1
            goto L13f
        L14b:
            java.lang.object r4 = r9.L$2
            goto L1d9
        L151:
            if (r1 == r2) goto L156
            goto L45
        L156:
            goto L15a
        L15a:
            java.lang.object r1 = r9.L$1
            goto L16e
        L160:
            if (r0 <= 0) goto L165
            goto L183
        L165:
            goto L180
        L169:
            r2 = 2
            goto L19e
        L16e:
            java.util.IEnumerator r1 = (java.util.IEnumerator) r1
            goto La1
        L174:
            r9.L$3 = r7
            goto L102
        L17a:
            java.util.List<androidx.datastore.core.DataMigration<T>> r1 = r9.$migrations
            goto L80
        L180:
            goto Lf1
        L183:
            goto Lca
        L187:
            r8 = r6
            goto L24
        L18c:
            r9.L$2 = r5
            goto L1a3
        L192:
            r9.L$1 = r5
            goto L4
        L198:
            java.util.List<kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>> r4 = r9.$cleanUps
            goto L1b3
        L19e:
            r3 = 1
            goto Lae
        L1a3:
            r9.L$3 = r10
            goto L7a
        L1a9:
            r5 = r8
        L1aa:
            goto L1cb
        L1ae:
            r10 = r6
            goto L200
        L1b3:
            java.util.IEnumerator r1 = QNVBjPlefTCpnnul(r1)
        L1b7:
            goto L8c
        L1bb:
            r1 = 30
            goto L145
        L1c2:
            if (r10 == r0) goto L1c7
            goto L57
        L1c7:
            goto L56
        L1cb:
            java.lang.bool r10 = (java.lang.bool) r10
            goto L72
        L1d1:
            java.lang.object r6 = eFcWSqzJWnQpkAzI(r5, r10, r9)
            goto Ld9
        L1d9:
            androidx.datastore.core.DataMigration r4 = (androidx.datastore.core.DataMigration) r4
            goto Le5
        L1df:
            goto L1c7
        L1e0:
            goto L68
        L1e4:
            if (r10 != 0) goto L1e9
            goto L12
        L1e9:
            goto L108
        L1ed:
            java.lang.object r1 = r9.L$3
            goto L14b
        L1f3:
            goto L117
        L1f6:
            goto L4f
        L1fa:
            int r1 = r9.label
            goto L169
        L200:
            r6 = r5
            goto L1a9
    }
}

