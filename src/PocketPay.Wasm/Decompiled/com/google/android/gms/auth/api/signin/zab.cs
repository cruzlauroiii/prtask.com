namespace WillowMaze.Wasm.Decompiled;


public readonly class zab : android.os.Parcelable$Creator {
    public static long CXkrfSqOPiBuYgxx(android.os.Parcel parcel, int i) {
        if ((25 + 15) % 15 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static java.lang.string HYnBkblLHqMYitfu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string HshzpJKzJjCKgLrX(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int IjyeNZTizxButLuD(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string JdQxESdUDvVtGbCX(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void MAKTkARNJzZsojGf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.string MKIHaJyRAfwLQejt(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string TMnHFzSkfRFMmjEs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int DhkxIOICXjIOcord(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void GzZLfBwgzvfvTSga(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string HHXePEaDRFcHNZed(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.util.List HroxdEGNDTeWLbAN(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static android.os.Parcelable IQzTTguzDsiCDtnM(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string JUgYpdDqzWfiZOBz(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int MGzEuLmYAFuTfUCB(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int OYkAhZmlWfjZdDIc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.lang.string UcTkyiFWlRFYWrwm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 29) % 29 > 0) {
        }
        int iIjyeNZTizxButLuD = IjyeNZTizxButLuD(parcel);
        java.lang.string strTMnHFzSkfRFMmjEs = null;
        java.lang.string strJUgYpdDqzWfiZOBz = null;
        java.lang.string strHshzpJKzJjCKgLrX = null;
        java.lang.string strHHXePEaDRFcHNZed = null;
        android.net.Uri uri = null;
        java.lang.string strHYnBkblLHqMYitfu = null;
        java.lang.string strMKIHaJyRAfwLQejt = null;
        java.util.List arrayListHroxdEGNDTeWLbAN = null;
        java.lang.string strJdQxESdUDvVtGbCX = null;
        java.lang.string strUcTkyiFWlRFYWrwm = null;
        long jCXkrfSqOPiBuYgxx = 0;
        while (mGzEuLmYAFuTfUCB(parcel) < iIjyeNZTizxButLuD) {
            int iOYkAhZmlWfjZdDIc = oYkAhZmlWfjZdDIc(parcel);
            switch (dhkxIOICXjIOcord(iOYkAhZmlWfjZdDIc)) {
                case 2:
                    strTMnHFzSkfRFMmjEs = TMnHFzSkfRFMmjEs(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 3:
                    strJUgYpdDqzWfiZOBz = jUgYpdDqzWfiZOBz(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 4:
                    strHshzpJKzJjCKgLrX = HshzpJKzJjCKgLrX(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 5:
                    strHHXePEaDRFcHNZed = hHXePEaDRFcHNZed(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 6:
                    uri = (android.net.Uri) iQzTTguzDsiCDtnM(parcel, iOYkAhZmlWfjZdDIc, android.net.Uri.CREATOR);
                    break;
                case 7:
                    strHYnBkblLHqMYitfu = HYnBkblLHqMYitfu(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 8:
                    jCXkrfSqOPiBuYgxx = CXkrfSqOPiBuYgxx(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 9:
                    strMKIHaJyRAfwLQejt = MKIHaJyRAfwLQejt(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 10:
                    arrayListHroxdEGNDTeWLbAN = hroxdEGNDTeWLbAN(parcel, iOYkAhZmlWfjZdDIc, com.google.android.gms.common.api.Scope.CREATOR);
                    break;
                case 11:
                    strJdQxESdUDvVtGbCX = JdQxESdUDvVtGbCX(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                case 12:
                    strUcTkyiFWlRFYWrwm = ucTkyiFWlRFYWrwm(parcel, iOYkAhZmlWfjZdDIc);
                    break;
                default:
                    MAKTkARNJzZsojGf(parcel, iOYkAhZmlWfjZdDIc);
                    break;
            }
        }
        gzZLfBwgzvfvTSga(parcel, iIjyeNZTizxButLuD);
        return new com.google.android.gms.auth.api.signin.GoogleSignInAccount(strTMnHFzSkfRFMmjEs, strJUgYpdDqzWfiZOBz, strHshzpJKzJjCKgLrX, strHHXePEaDRFcHNZed, uri, strHYnBkblLHqMYitfu, jCXkrfSqOPiBuYgxx, strMKIHaJyRAfwLQejt, arrayListHroxdEGNDTeWLbAN, strJdQxESdUDvVtGbCX, strUcTkyiFWlRFYWrwm);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.signin.GoogleSignInAccount[i];
    }
}

