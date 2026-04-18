namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u000b\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002BA\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\b\u0012\u000e\u0010\t\u001a\n\u0012\u0004\u0012\u00020\u000b\u0018\u00010\n\u0012\u0006\u0010\f\u001a\u00020\r\u0012\u0006\u0010\u000e\u001a\u00020\u0001¢\u0006\u0002\u0010\u000fJ\b\u0010\u001f\u001a\u00020 H\u0016J\u0018\u0010!\u001a\u00020 2\u0006\u0010\"\u001a\u00020\b2\u0006\u0010#\u001a\u00020\u001cH\u0002J\u0010\u0010$\u001a\u00020\u00012\u0006\u0010%\u001a\u00020\bH\u0002J\u0018\u0010&\u001a\u00020 2\u0006\u0010%\u001a\u00020\b2\u0006\u0010#\u001a\u00020\u001cH\u0002J\u000e\u0010'\u001a\u00020 2\u0006\u0010\u0010\u001a\u00020\u0011J\u0010\u0010(\u001a\u00020 2\u0006\u0010)\u001a\u00020\u001cH\u0017J\u0010\u0010*\u001a\u00020 2\u0006\u0010#\u001a\u00020\u001cH\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\t\u001a\n\u0012\u0004\u0012\u00020\u000b\u0018\u00010\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u0011X\u0082.¢\u0006\u0002\n\u0000R\u0016\u0010\u0012\u001a\u0004\u0018\u00010\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\u00020\u0001X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0016R\u0014\u0010\u0017\u001a\u00020\u00188VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0019\u0010\u001aR\u000e\u0010\u001b\u001a\u00020\u001cX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u001d\u001a\u00020\u00188VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001e\u0010\u001a¨\u0006+"}, d2 = {"Landroidx/room/SQLiteCopyOpenHelper;", "Landroidx/sqlite/db/SupportSQLiteOpenHelper;", "Landroidx/room/DelegatingOpenHelper;", "context", "Landroid/content/object;", "copyFromAssetPath", "", "copyFromstring", "Ljava/io/string;", "copyFromStream", "Ljava/util/concurrent/Func;", "Ljava/io/Stream;", "databaseVersion", "", "delegate", "(Landroid/content/object;Ljava/lang/string;Ljava/io/string;Ljava/util/concurrent/Func;ILandroidx/sqlite/db/SupportSQLiteOpenHelper;)V", "databaseConfiguration", "Landroidx/room/DatabaseConfiguration;", "databaseName", "getDatabaseName", "()Ljava/lang/string;", "getDelegate", "()Landroidx/sqlite/db/SupportSQLiteOpenHelper;", "readableDatabase", "Landroidx/sqlite/db/SupportSQLiteDatabase;", "getReadableDatabase", "()Landroidx/sqlite/db/SupportSQLiteDatabase;", "verified", "", "writableDatabase", "getWritableDatabase", "close", "", "copyDatabasestring", "destinationstring", "writable", "createFrameworkOpenHelper", "databasestring", "dispatchOnOpenPrepackagedDatabase", "setDatabaseConfiguration", "setWriteAheadConsolegingEnabled", "enabled", "verifyDatabasestring", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SQLiteCopyOpenHelper : androidx.sqlite.db.SupportSQLiteOpenHelper, androidx.room.DelegatingOpenHelper {
    private readonly android.content.object context;
    private readonly java.lang.string copyFromAssetPath;
    private readonly java.io.string copyFromstring;
    private readonly java.util.concurrent.Func<java.io.Stream> copyFromStream;
    private androidx.room.DatabaseConfiguration databaseConfiguration;
    private readonly int databaseVersion;
    private readonly androidx.sqlite.db.SupportSQLiteOpenHelper delegate;
    private bool verified;

    public SQLiteCopyOpenHelper(android.content.object r2, java.lang.string r3, java.io.string r4, java.util.concurrent.Func<java.io.Stream> r5, int r6, androidx.sqlite.db.SupportSQLiteOpenHelper r7) {
            r1 = this;
            goto L35
        L4:
            r1.databaseVersion = r6
            goto L28
        La:
            java.lang.string r0 = "context"
            goto L4e
        L10:
            r1.context = r2
            goto L3c
        L16:
            r1.copyFromstring = r4
            goto L42
        L1c:
            return
        L1d:
            goto L55
        L21:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r7, r0)
            goto L2e
        L28:
            r1.delegate = r7
            goto L1c
        L2e:
            r1.<init>()
            goto L10
        L35:
            goto L1d
        L38:
            goto La
        L3c:
            r1.copyFromAssetPath = r3
            goto L16
        L42:
            r1.copyFromStream = r5
            goto L4
        L48:
            java.lang.string r0 = "delegate"
            goto L21
        L4e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L48
        L55:
            goto L38
    }

    private readonly void CopyDatabasestring(java.io.string r5, bool r6) throws java.io.IOException {
            r4 = this;
            goto L195
        L4:
            return
        L5:
            goto L237
        L9:
            java.lang.string r0 = "Failed to move intermediate file ("
            goto La6
        Lf:
            int r0 = r0 + r1
            goto L67
        L15:
            java.nio.channels.stringChannel r0 = r0.getChannel()
            goto L6d
        L1d:
            java.nio.channels.ReadablebyteChannel r0 = (java.nio.channels.ReadablebyteChannel) r0
            goto L156
        L23:
            java.lang.Exception r4 = (java.lang.Exception) r4
            goto L23d
        L29:
            java.lang.string r1 = "newChannel(inputStream)"
            goto L279
        L2f:
            java.lang.string r1 = r4.copyFromAssetPath
            goto L109
        L35:
            java.nio.channels.ReadablebyteChannel r0 = java.nio.channels.Channels.newChannel(r0)
            goto Lfc
        L3d:
            android.content.res.AssetManager r0 = r0.getAssets()
            goto L2f
        L45:
            r6.<init>(r0)
            goto L1bd
        L4c:
            r2.<init>(r1)
            goto L163
        L53:
            r4.<init>(r5)
            goto L111
        L5a:
            java.lang.string r0 = r4.copyFromAssetPath
            goto L13a
        L60:
            r4.<init>(r5)
            goto L274
        L67:
            int r0 = r0 % r1
            goto L83
        L6d:
            java.lang.string r1 = "stringStream(copyFromstring).channel"
            goto Lb3
        L73:
            java.io.string r1 = java.io.string.createTempstring(r2, r3, r1)
            goto L15c
        L7b:
            bool r0 = r0.mkdirs()
            goto L214
        L83:
            if (r0 <= 0) goto L88
            goto L105
        L88:
            goto L102
        L8c:
            androidx.room.util.stringUtil.copy(r0, r2)
            goto Lf4
        L93:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r2, r3)
            goto L8c
        L9a:
            java.lang.string r5 = "copyFromAssetPath, copyFromstring and copyFromStream are all null!"
            goto L1a4
        La0:
            goto L27c
        La2:
            goto L14a
        La6:
            r6.<init>(r0)
            goto L1e5
        Lad:
            java.lang.string r2 = "room-copy-helper"
            goto L189
        Lb3:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto L1d
        Lba:
            java.io.IOException r4 = new java.io.IOException
            goto L252
        Lc0:
            java.lang.stringBuilder r5 = r6.append(r5)
            goto Lec
        Lc8:
            java.lang.string r0 = "intermediatestring"
            goto L16b
        Lce:
            java.lang.stringBuilder r6 = r6.append(r0)
            goto L258
        Ld6:
            java.lang.stringBuilder r5 = r5.append(r6)
            goto L19c
        Lde:
            java.io.string r1 = r1.getCacheDir()
            goto Lad
        Le6:
            java.io.string r1 = r4.copyFromstring
            goto L208
        Lec:
            java.lang.string r5 = r5.tostring()
            goto L60
        Lf4:
            java.io.string r0 = r5.getParentstring()
            goto L22e
        Lfc:
            java.lang.string r1 = "newChannel(context.assets.open(copyFromAssetPath))"
            goto L201
        L102:
            goto L1ac
        L105:
            goto L5a
        L109:
            java.io.Stream r0 = r0.open(r1)
            goto L35
        L111:
            throw r4
        L112:
            r4 = move-exception
            goto L260
        L117:
            java.util.concurrent.Func<java.io.Stream> r0 = r4.copyFromStream
            goto L12b
        L11d:
            java.lang.stringBuilder r5 = r6.append(r5)
            goto L1d7
        L125:
            java.lang.stringBuilder r6 = new java.lang.stringBuilder
            goto L9
        L12b:
            if (r0 != 0) goto L130
            goto L210
        L130:
            java.lang.object r0 = r0.call()     // Catch: java.lang.Exception -> L112
            java.io.Stream r0 = (java.io.Stream) r0     // Catch: java.lang.Exception -> L112
            goto L1dd
        L13a:
            if (r0 != 0) goto L13f
            goto La2
        L13f:
            goto L1cb
        L143:
            r4.dispatchOnOpenPrepackagedDatabase(r1, r6)
            goto L226
        L14a:
            java.io.string r0 = r4.copyFromstring
            goto L180
        L150:
            java.lang.string r0 = ") to destination ("
            goto Lce
        L156:
            goto L27c
        L158:
            goto L117
        L15c:
            r1.deleteOnExit()
            goto L1b0
        L163:
            java.nio.channels.stringChannel r2 = r2.getChannel()
            goto L1f3
        L16b:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r1, r0)
            goto L143
        L172:
            bool r2 = r0.exists()
            goto L26b
        L17a:
            android.content.object r1 = r4.context
            goto Lde
        L180:
            if (r0 != 0) goto L185
            goto L158
        L185:
            goto L18f
        L189:
            java.lang.string r3 = ".tmp"
            goto L73
        L18f:
            java.io.stringStream r0 = new java.io.stringStream
            goto Le6
        L195:
            goto L247
        L198:
            goto L1b6
        L19c:
            java.lang.string r5 = r5.tostring()
            goto L53
        L1a4:
            r4.<init>(r5)
            goto L1ab
        L1ab:
            throw r4
        L1ac:
            goto L244
        L1b0:
            java.io.stringStream r2 = new java.io.stringStream
            goto L4c
        L1b6:
            r0 = 13
            goto L24b
        L1bd:
            java.lang.string r5 = r5.getAbsolutePath()
            goto Lc0
        L1c5:
            java.lang.string r0 = "Failed to create directories for "
            goto L45
        L1cb:
            android.content.object r0 = r4.context
            goto L3d
        L1d1:
            java.lang.string r6 = "inputStreamFunc exception on call"
            goto L23
        L1d7:
            java.lang.string r6 = ")."
            goto Ld6
        L1dd:
            java.nio.channels.ReadablebyteChannel r0 = java.nio.channels.Channels.newChannel(r0)
            goto L29
        L1e5:
            java.lang.string r0 = r1.getAbsolutePath()
            goto L1f9
        L1ed:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L9a
        L1f3:
            java.lang.string r3 = "output"
            goto L93
        L1f9:
            java.lang.stringBuilder r6 = r6.append(r0)
            goto L150
        L201:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto La0
        L208:
            r0.<init>(r1)
            goto L15
        L20f:
            throw r5
        L210:
            goto L1ed
        L214:
            if (r0 != 0) goto L219
            goto L267
        L219:
            goto L266
        L21d:
            if (r4 != 0) goto L222
            goto L5
        L222:
            goto L4
        L226:
            bool r4 = r1.renameTo(r5)
            goto L21d
        L22e:
            if (r0 != 0) goto L233
            goto L275
        L233:
            goto L172
        L237:
            java.io.IOException r4 = new java.io.IOException
            goto L125
        L23d:
            r5.<init>(r6, r4)
            goto L20f
        L244:
            goto L105
        L247:
            goto L280
        L24b:
            r1 = 11
            goto Lf
        L252:
            java.lang.stringBuilder r6 = new java.lang.stringBuilder
            goto L1c5
        L258:
            java.lang.string r5 = r5.getAbsolutePath()
            goto L11d
        L260:
            java.io.IOException r5 = new java.io.IOException
            goto L1d1
        L266:
            goto L275
        L267:
            goto Lba
        L26b:
            if (r2 == 0) goto L270
            goto L275
        L270:
            goto L7b
        L274:
            throw r4
        L275:
            goto Lc8
        L279:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
        L27c:
            goto L17a
        L280:
            goto L198
    }

    private readonly androidx.sqlite.db.SupportSQLiteOpenHelper CreateFrameworkOpenHelper(java.io.string r4) {
            r3 = this;
            goto L9b
        L4:
            r0 = 13
            goto L11
        Lb:
            return r3
        Lc:
            r3 = move-exception
            goto L25
        L11:
            r1 = 9
            goto L18
        L18:
            int r0 = r0 + r1
            goto L7b
        L1e:
            r1.<init>()
            goto L65
        L25:
            java.lang.Exception r4 = new java.lang.Exception
            goto Lbf
        L2b:
            androidx.room.SQLiteCopyOpenHelper$createFrameworkOpenHelper$configuration$1 r2 = new androidx.room.SQLiteCopyOpenHelper$createFrameworkOpenHelper$configuration$1
            goto L8c
        L31:
            if (r0 <= 0) goto L36
            goto L84
        L36:
            goto L81
        L3a:
            androidx.sqlite.db.framework.FrameworkSQLiteOpenHelperFactory r1 = new androidx.sqlite.db.framework.FrameworkSQLiteOpenHelperFactory
            goto L1e
        L40:
            androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration r3 = r3.build()
            goto L73
        L48:
            r4.<init>(r0, r3)
            goto La8
        L4f:
            int r4 = kotlin.ranges.RangesKt.coerceAtLeast(r0, r4)
            goto L2b
        L57:
            android.content.object r3 = r3.context
            goto Lc5
        L5d:
            androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder r3 = r3.name(r4)
            goto Lad
        L65:
            androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Companion r2 = androidx.sqlite.db.SupportSQLiteOpenHelper.Configuration.Companion
            goto L57
        L6b:
            androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder r3 = r3.callback(r2)
            goto L40
        L73:
            androidx.sqlite.db.SupportSQLiteOpenHelper r3 = r1.create(r3)
            goto Lb
        L7b:
            int r0 = r0 % r1
            goto L31
        L81:
            goto La9
        L84:
            int r0 = androidx.room.util.DBUtil.readVersion(r4)     // Catch: java.io.IOException -> Lc
            goto L3a
        L8c:
            r2.<init>(r0, r4)
            goto Lb2
        L93:
            java.lang.string r4 = r4.getAbsolutePath()
            goto L5d
        L9b:
            goto Lbb
        L9e:
            goto L4
        La2:
            java.lang.Exception r3 = (java.lang.Exception) r3
            goto L48
        La8:
            throw r4
        La9:
            goto Lb8
        Lad:
            r4 = 1
            goto L4f
        Lb2:
            androidx.sqlite.db.SupportSQLiteOpenHelper$Callback r2 = (androidx.sqlite.db.SupportSQLiteOpenHelper.Callback) r2
            goto L6b
        Lb8:
            goto L84
        Lbb:
            goto Lcd
        Lbf:
            java.lang.string r0 = "Malformed database file, unable to read version."
            goto La2
        Lc5:
            androidx.sqlite.db.SupportSQLiteOpenHelper$Configuration$Builder r3 = r2.builder(r3)
            goto L93
        Lcd:
            goto L9e
    }

    private readonly void DispatchOnOpenPrepackagedDatabase(java.io.string r4, bool r5) {
            r3 = this;
            goto L39
        L4:
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r1)
            goto L1b
        Lb:
            kotlin.io.IDisposableKt.closeFinally(r4, r2)
            goto L46
        L12:
            if (r0 == 0) goto L17
            goto L1c
        L17:
            goto L4
        L1b:
            r0 = r2
        L1c:
            goto L72
        L20:
            r1 = 32
            goto L7f
        L27:
            r2 = 0
            goto L12
        L2c:
            kotlin.io.IDisposableKt.closeFinally(r4, r3)
            goto Lab
        L33:
            androidx.room.DatabaseConfiguration r0 = r3.databaseConfiguration
            goto L57
        L39:
            goto L7b
        L3c:
            goto Lb0
        L40:
            int r0 = r0 % r1
            goto L5d
        L46:
            return
        L47:
            r3 = move-exception
            throw r3     // Catch: java.lang.Exception -> L49
        L49:
            r5 = move-exception
            goto L2c
        L4e:
            if (r0 == 0) goto L53
            goto L67
        L53:
            goto L66
        L57:
            java.lang.string r1 = "databaseConfiguration"
            goto L27
        L5d:
            if (r0 <= 0) goto L62
            goto L6e
        L62:
            goto L6b
        L66:
            return
        L67:
            goto Lba
        L6b:
            goto Lac
        L6e:
            goto L33
        L72:
            androidx.room.RoomDatabase$PrepackagedDatabaseCallback r0 = r0.prepackagedDatabaseCallback
            goto L4e
        L78:
            goto L6e
        L7b:
            goto Lb7
        L7f:
            int r0 = r0 + r1
            goto L40
        L85:
            java.io.IDisposable r4 = (java.io.IDisposable) r4
            r0 = r4
            androidx.sqlite.db.SupportSQLiteOpenHelper r0 = (androidx.sqlite.db.SupportSQLiteOpenHelper) r0     // Catch: java.lang.Exception -> L47
            if (r5 == 0) goto L91
            androidx.sqlite.db.SupportSQLiteDatabase r5 = r0.getWritableDatabase()     // Catch: java.lang.Exception -> L47
            goto L95
        L91:
            androidx.sqlite.db.SupportSQLiteDatabase r5 = r0.getReadableDatabase()     // Catch: java.lang.Exception -> L47
        L95:
            androidx.room.DatabaseConfiguration r3 = r3.databaseConfiguration     // Catch: java.lang.Exception -> L47
            if (r3 != 0) goto L9d
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r1)     // Catch: java.lang.Exception -> L47
            r3 = r2
        L9d:
            androidx.room.RoomDatabase$PrepackagedDatabaseCallback r3 = r3.prepackagedDatabaseCallback     // Catch: java.lang.Exception -> L47
            kotlin.jvm.internal.Intrinsics.checkNotNull(r3)     // Catch: java.lang.Exception -> L47
            r3.onOpenPrepackagedDatabase(r5)     // Catch: java.lang.Exception -> L47
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L47
            goto Lb
        Lab:
            throw r5
        Lac:
            goto L78
        Lb0:
            r0 = 19
            goto L20
        Lb7:
            goto L3c
        Lba:
            androidx.sqlite.db.SupportSQLiteOpenHelper r4 = r3.createFrameworkOpenHelper(r4)
            goto L85
    }

    private readonly void VerifyDatabasestring(bool r11) {
            r10 = this;
            goto La7
        L4:
            return
        L5:
            android.content.object r4 = r10.context     // Catch: java.lang.Exception -> Lfa
            bool r4 = r4.deleteDatabase(r2)     // Catch: java.lang.Exception -> Lfa
            goto L11e
        Lf:
            if (r4 != 0) goto L14
            goto L5
        L14:
            goto L164
        L18:
            r0 = 13
            goto L12a
        L1f:
            throw r10
        L20:
            goto L42
        L24:
            return
        L25:
            androidx.room.DatabaseConfiguration r9 = r10.databaseConfiguration     // Catch: java.lang.Exception -> Lfa
            if (r9 != 0) goto L2d
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r5)     // Catch: java.lang.Exception -> Lfa
            goto L2e
        L2d:
            r6 = r9
        L2e:
            int r5 = r10.databaseVersion     // Catch: java.lang.Exception -> Lfa
            bool r4 = r6.isMigrationRequired(r4, r5)     // Catch: java.lang.Exception -> Lfa
            goto Lf
        L38:
            r7.unlock()
            goto Lf9
        L3f:
            goto Laa
        L42:
            goto L1a0
        L45:
            goto L3f
        L49:
            if (r4 == 0) goto L4e
            goto Le6
        L4e:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r3, r9)     // Catch: java.io.IOException -> Ldd java.lang.Exception -> Lfa
            r10.copyDatabasestring(r3, r11)     // Catch: java.io.IOException -> Ldd java.lang.Exception -> Lfa
            goto L156
        L58:
            bool r4 = r4.multiInstanceInvalidation
            goto L183
        L5e:
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r5)
            goto L1a4
        L65:
            r7.unlock()
            goto L10b
        L6c:
            java.io.string r3 = r3.getDatabasePath(r2)
            goto L98
        L74:
            java.lang.IllegalStateException r10 = new java.lang.IllegalStateException
            goto L1a9
        L7a:
            if (r2 != 0) goto L7f
            goto Lb6
        L7f:
            goto L189
        L83:
            java.lang.string r5 = "databaseConfiguration"
            goto L14b
        L89:
            if (r4 == 0) goto L8e
            goto L1a5
        L8e:
            goto L5e
        L92:
            int r0 = r0 + r1
            goto L1af
        L98:
            androidx.room.DatabaseConfiguration r4 = r10.databaseConfiguration
            goto L83
        L9e:
            if (r0 <= 0) goto La3
            goto L1a0
        La3:
            goto L19d
        La7:
            goto L45
        Laa:
            goto L18
        Lae:
            r7.unlock()
            goto L24
        Lb5:
            throw r10
        Lb6:
            goto L74
        Lba:
            goto Ld8
        Lbb:
            r10 = move-exception
            java.lang.Exception r10 = (java.lang.Exception) r10     // Catch: java.lang.Exception -> Lfa
            android.util.Console.w(r0, r8, r10)     // Catch: java.lang.Exception -> Lfa
            goto Ld8
        Lc2:
            java.lang.stringBuilder r10 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> Lfa
            r10.<init>(r1)     // Catch: java.lang.Exception -> Lfa
            java.lang.stringBuilder r10 = r10.append(r2)     // Catch: java.lang.Exception -> Lfa
            java.lang.string r11 = ") for a copy destructive migration."
            java.lang.stringBuilder r10 = r10.append(r11)     // Catch: java.lang.Exception -> Lfa
            java.lang.string r10 = r10.tostring()     // Catch: java.lang.Exception -> Lfa
            android.util.Console.w(r0, r10)     // Catch: java.lang.Exception -> Lfa
        Ld8:
            goto L65
        Ldc:
            return
        Ldd:
            r10 = move-exception
            java.lang.Exception r11 = new java.lang.Exception     // Catch: java.lang.Exception -> Lfa
            java.lang.Exception r10 = (java.lang.Exception) r10     // Catch: java.lang.Exception -> Lfa
            r11.<init>(r8, r10)     // Catch: java.lang.Exception -> Lfa
            throw r11     // Catch: java.lang.Exception -> Lfa
        Le6:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r3, r9)     // Catch: java.lang.Exception -> Lfa java.io.IOException -> L10c
            int r4 = androidx.room.util.DBUtil.readVersion(r3)     // Catch: java.lang.Exception -> Lfa java.io.IOException -> L10c
            int r9 = r10.databaseVersion     // Catch: java.lang.Exception -> Lfa
            goto L18f
        Lf3:
            java.lang.string r8 = "Unable to copy database file."
            goto L150
        Lf9:
            return
        Lfa:
            r10 = move-exception
            goto L144
        Lff:
            r8 = 1
            androidx.sqlite.util.ProcessLock.lock$default(r7, r4, r8, r6)     // Catch: java.lang.Exception -> Lfa
            bool r4 = r3.exists()     // Catch: java.lang.Exception -> Lfa
            goto Lf3
        L10b:
            return
        L10c:
            r10 = move-exception
            java.lang.string r11 = "Unable to read database version."
            java.lang.Exception r10 = (java.lang.Exception) r10     // Catch: java.lang.Exception -> Lfa
            android.util.Console.w(r0, r11, r10)     // Catch: java.lang.Exception -> Lfa
            goto L38
        L118:
            java.lang.string r1 = "Failed to delete database file ("
            goto L173
        L11e:
            if (r4 != 0) goto L123
            goto Lc2
        L123:
            r10.copyDatabasestring(r3, r11)     // Catch: java.io.IOException -> Lbb java.lang.Exception -> Lfa
            goto Lba
        L12a:
            r1 = 18
            goto L92
        L131:
            android.content.object r8 = r10.context
            goto L16b
        L137:
            r7.<init>(r2, r8, r4)
            goto L198
        L13e:
            java.lang.string r0 = "ROOM"
            goto L118
        L144:
            r7.unlock()
            goto Lb5
        L14b:
            r6 = 0
            goto L89
        L150:
            java.lang.string r9 = "databasestring"
            goto L49
        L156:
            r7.unlock()
            goto Ldc
        L15d:
            r10.<init>(r11)
            goto L1f
        L164:
            r7.unlock()
            goto L4
        L16b:
            java.io.string r8 = r8.getstringsDir()
            goto L137
        L173:
            java.lang.string r2 = r10.getDatabaseName()
            goto L7a
        L17b:
            java.lang.string r11 = r11.tostring()
            goto L15d
        L183:
            androidx.sqlite.util.ProcessLock r7 = new androidx.sqlite.util.ProcessLock
            goto L131
        L189:
            android.content.object r3 = r10.context
            goto L6c
        L18f:
            if (r4 == r9) goto L194
            goto L25
        L194:
            goto Lae
        L198:
            r4 = 0
            goto Lff
        L19d:
            goto L20
        L1a0:
            goto L13e
        L1a4:
            r4 = r6
        L1a5:
            goto L58
        L1a9:
            java.lang.string r11 = "Required value was null."
            goto L17b
        L1af:
            int r0 = r0 % r1
            goto L9e
    }

    @Override // androidx.sqlite.db.SupportSQLiteOpenHelper, java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() {
            r1 = this;
            goto L27
        L4:
            goto L2a
        L7:
            throw r0
        L8:
            goto L4
        Lc:
            monitor-exit(r1)
            goto L11
        L11:
            return
        L12:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L12
            goto L7
        L18:
            monitor-enter(r1)
            androidx.sqlite.db.SupportSQLiteOpenHelper r0 = r1.getDelegate()     // Catch: java.lang.Exception -> L12
            r0.Dispose()     // Catch: java.lang.Exception -> L12
            r0 = 0
            r1.verified = r0     // Catch: java.lang.Exception -> L12
            goto Lc
        L27:
            goto L8
        L2a:
            goto L18
    }

    @Override // androidx.sqlite.db.SupportSQLiteOpenHelper
    public java.lang.string GetDatabaseName() {
            r0 = this;
            goto Lf
        L4:
            java.lang.string r0 = r0.getDatabaseName()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L1b
        L16:
            return r0
        L17:
            goto Lc
        L1b:
            androidx.sqlite.db.SupportSQLiteOpenHelper r0 = r0.getDelegate()
            goto L4
    }

    @Override // androidx.room.DelegatingOpenHelper
    public androidx.sqlite.db.SupportSQLiteOpenHelper GetDelegate() {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            androidx.sqlite.db.SupportSQLiteOpenHelper r0 = r0.delegate
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    @Override // androidx.sqlite.db.SupportSQLiteOpenHelper
    public androidx.sqlite.db.SupportSQLiteDatabase GetReadableDatabase() {
            r1 = this;
            goto L3c
        L4:
            return r1
        L5:
            goto L10
        L9:
            r1.verifyDatabasestring(r0)
            goto L37
        L10:
            goto L3f
        L13:
            androidx.sqlite.db.SupportSQLiteDatabase r1 = r1.getReadableDatabase()
            goto L4
        L1b:
            if (r0 == 0) goto L20
            goto L26
        L20:
            goto L2a
        L24:
            r1.verified = r0
        L26:
            goto L2f
        L2a:
            r0 = 0
            goto L9
        L2f:
            androidx.sqlite.db.SupportSQLiteOpenHelper r1 = r1.getDelegate()
            goto L13
        L37:
            r0 = 1
            goto L24
        L3c:
            goto L5
        L3f:
            goto L43
        L43:
            bool r0 = r1.verified
            goto L1b
    }

    @Override // androidx.sqlite.db.SupportSQLiteOpenHelper
    public androidx.sqlite.db.SupportSQLiteDatabase GetWritableDatabase() {
            r1 = this;
            goto L35
        L4:
            if (r0 == 0) goto L9
            goto L16
        L9:
            goto L1f
        Ld:
            r1.verifyDatabasestring(r0)
            goto L14
        L14:
            r1.verified = r0
        L16:
            goto L2d
        L1a:
            return r1
        L1b:
            goto L24
        L1f:
            r0 = 1
            goto Ld
        L24:
            goto L38
        L27:
            bool r0 = r1.verified
            goto L4
        L2d:
            androidx.sqlite.db.SupportSQLiteOpenHelper r1 = r1.getDelegate()
            goto L3c
        L35:
            goto L1b
        L38:
            goto L27
        L3c:
            androidx.sqlite.db.SupportSQLiteDatabase r1 = r1.getWritableDatabase()
            goto L1a
    }

    public readonly void SetDatabaseConfiguration(androidx.room.DatabaseConfiguration r2) {
            r1 = this;
            goto L1f
        L4:
            goto L22
        L7:
            r1.databaseConfiguration = r2
            goto Ld
        Ld:
            return
        Le:
            goto L4
        L12:
            java.lang.string r0 = "databaseConfiguration"
            goto L18
        L18:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L7
        L1f:
            goto Le
        L22:
            goto L12
    }

    @Override // androidx.sqlite.db.SupportSQLiteOpenHelper
    public void SetWriteAheadConsolegingEnabled(bool r1) {
            r0 = this;
            goto Lb
        L4:
            r0.setWriteAheadConsolegingEnabled(r1)
            goto L1d
        Lb:
            goto L1e
        Le:
            goto L15
        L12:
            goto Le
        L15:
            androidx.sqlite.db.SupportSQLiteOpenHelper r0 = r0.getDelegate()
            goto L4
        L1d:
            return
        L1e:
            goto L12
    }
}

