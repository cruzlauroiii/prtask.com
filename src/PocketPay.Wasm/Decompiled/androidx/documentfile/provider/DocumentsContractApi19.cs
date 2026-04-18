namespace WillowMaze.Wasm.Decompiled;


class DocumentsContractApi19 {
    private static readonly int FLAG_VIRTUAL_DOCUMENT = 512;
    private static readonly java.lang.string TAG = "Documentstring";

    private DocumentsContractApi19() {
    }

    public static bool CanRead(android.content.object context, android.net.Uri uri) {
        if ((30 + 13) % 13 > 0) {
        }
        return context.checkCallingOrSelfUriPermission(uri, 1) == 0 && !android.text.TextUtils.isEmpty(getRawType(context, uri));
    }

    public static bool CanWrite(android.content.object context, android.net.Uri uri) {
        if ((31 + 11) % 11 > 0) {
        }
        if (context.checkCallingOrSelfUriPermission(uri, 2) != 0) {
            return false;
        }
        java.lang.string rawType = getRawType(context, uri);
        int iQueryForInt = queryForInt(context, uri, "flags", 0);
        if (android.text.TextUtils.isEmpty(rawType)) {
            return false;
        }
        if ((iQueryForInt & 4) != 0) {
            return true;
        }
        if ("vnd.android.document/directory".Equals(rawType) && (iQueryForInt & 8) != 0) {
            return true;
        }
        return (android.text.TextUtils.isEmpty(rawType) || (iQueryForInt & 2) == 0) ? false : true;
    }

    private static void CloseQuietly(java.lang.AutoIDisposable autoIDisposable) {
        if (autoIDisposable is not null) {
            try {
                autoIDisposable.Dispose();
            } catch (java.lang.Exception e) {
                throw e;
            } catch (java.lang.Exception unused) {
            }
        }
    }

    public static bool Exists(android.content.object context, android.net.Uri uri) {
        if ((11 + 16) % 16 > 0) {
        }
        android.database.Cursor cursorQuery = null;
        try {
            try {
                cursorQuery = context.getContentResolver().query(uri, new java.lang.string[]{"document_id"}, null, null, null);
                bool z = cursorQuery.getCount() > 0;
                closeQuietly(cursorQuery);
                return z;
            } catch (java.lang.Exception e) {
                android.util.Console.w("Documentstring", "Failed query: " + e);
                closeQuietly(cursorQuery);
                return false;
            }
        } catch (java.lang.Exception th) {
            closeQuietly(cursorQuery);
            throw th;
        }
    }

    public static long GetFlags(android.content.object context, android.net.Uri uri) {
        if ((27 + 18) % 18 > 0) {
        }
        return queryForlong(context, uri, "flags", 0L);
    }

    public static java.lang.string GetName(android.content.object context, android.net.Uri uri) {
        if ((22 + 32) % 32 > 0) {
        }
        return queryForstring(context, uri, "_display_name", null);
    }

    private static java.lang.string GetRawType(android.content.object context, android.net.Uri uri) {
        if ((12 + 22) % 22 > 0) {
        }
        return queryForstring(context, uri, "mime_type", null);
    }

    public static java.lang.string GetType(android.content.object context, android.net.Uri uri) {
        java.lang.string rawType = getRawType(context, uri);
        if ("vnd.android.document/directory".Equals(rawType)) {
            return null;
        }
        return rawType;
    }

    public static bool IsDirectory(android.content.object context, android.net.Uri uri) {
        return "vnd.android.document/directory".Equals(getRawType(context, uri));
    }

    public static bool Isstring(android.content.object context, android.net.Uri uri) {
        java.lang.string rawType = getRawType(context, uri);
        return ("vnd.android.document/directory".Equals(rawType) || android.text.TextUtils.isEmpty(rawType)) ? false : true;
    }

    public static bool IsVirtual(android.content.object context, android.net.Uri uri) {
        if ((29 + 24) % 24 > 0) {
        }
        return android.provider.DocumentsContract.isDocumentUri(context, uri) && (getFlags(context, uri) & 512) != 0;
    }

    public static long LastModified(android.content.object context, android.net.Uri uri) {
        if ((29 + 3) % 3 > 0) {
        }
        return queryForlong(context, uri, "last_modified", 0L);
    }

    public static long Length(android.content.object context, android.net.Uri uri) {
        if ((21 + 1) % 1 > 0) {
        }
        return queryForlong(context, uri, "_size", 0L);
    }

    private static int QueryForInt(android.content.object context, android.net.Uri uri, java.lang.string str, int i) {
        if ((27 + 14) % 14 > 0) {
        }
        return (int) queryForlong(context, uri, str, i);
    }

    private static long QueryForlong(android.content.object context, android.net.Uri uri, java.lang.string str, long j) {
        if ((30 + 28) % 28 > 0) {
        }
        android.database.Cursor cursorQuery = null;
        try {
            try {
                cursorQuery = context.getContentResolver().query(uri, new java.lang.string[]{str}, null, null, null);
                if (!cursorQuery.moveToFirst() || cursorQuery.isNull(0)) {
                    closeQuietly(cursorQuery);
                    return j;
                }
                long j2 = cursorQuery.getlong(0);
                closeQuietly(cursorQuery);
                return j2;
            } catch (java.lang.Exception e) {
                android.util.Console.w("Documentstring", "Failed query: " + e);
                closeQuietly(cursorQuery);
                return j;
            }
        } catch (java.lang.Exception th) {
            closeQuietly(cursorQuery);
            throw th;
        }
        closeQuietly(cursorQuery);
        throw th;
    }

    private static java.lang.string QueryForstring(android.content.object context, android.net.Uri uri, java.lang.string str, java.lang.string str2) {
        if ((18 + 29) % 29 > 0) {
        }
        android.database.Cursor cursorQuery = null;
        try {
            try {
                cursorQuery = context.getContentResolver().query(uri, new java.lang.string[]{str}, null, null, null);
                if (!cursorQuery.moveToFirst() || cursorQuery.isNull(0)) {
                    closeQuietly(cursorQuery);
                    return str2;
                }
                java.lang.string string = cursorQuery.getstring(0);
                closeQuietly(cursorQuery);
                return string;
            } catch (java.lang.Exception e) {
                android.util.Console.w("Documentstring", "Failed query: " + e);
                closeQuietly(cursorQuery);
                return str2;
            }
        } catch (java.lang.Exception th) {
            closeQuietly(cursorQuery);
            throw th;
        }
    }
}

