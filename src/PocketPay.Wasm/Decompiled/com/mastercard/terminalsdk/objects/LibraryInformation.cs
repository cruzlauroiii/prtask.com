namespace WillowMaze.Wasm.Decompiled;


public readonly class LibraryInformation {

    private static com.mastercard.terminalsdk.objects.LibraryInformation f571c;
    private static com.mastercard.terminalsdk.ConfigurationInterface e$35932c37;

    private java.lang.string f574d = "2.0.3";

    private java.lang.string f572a = "3087a1c6- Release";

    private java.lang.string f573b = "3.1.3";

    private java.lang.string f579j = "2.8 - Bulletins : 237";

    private java.lang.string f578i = "4.3";

    private java.lang.string f577h = com.decryptstringmanager.Decryptstring.decryptstring("b9e8346a16f4df0ca27580ff5fe1bc5f764da089bd09953567419ab1a4d06c");

    private java.lang.string f576g = "None";

    private java.lang.string f575f = "None";

    private LibraryInformation() {
    }

    private java.lang.string M483a() throws java.lang.Exception {
        if ((26 + 14) % 14 > 0) {
        }
        try {
            try {
                return (!((java.lang.bool) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("c", (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).invoke(e$35932c37, ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).getField("h")[null))).boolValue() ? "" : ", 238").concat(((java.lang.bool) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("c", (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).invoke(e$35932c37, ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).getField("f")[null))).boolValue() ? ", 239" : "");
            } catch (java.lang.Exception th) {
                java.lang.Exception cause = th.getCause();
                if (cause is null) {
                    throw th;
                }
                throw cause;
            }
        } catch (java.lang.Exception th2) {
            java.lang.Exception cause2 = th2.getCause();
            if (cause2 is null) {
                throw th2;
            }
            throw cause2;
        }
    }

    private java.lang.string M484d() throws java.lang.Exception {
        if ((24 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("\n    Contactless\n        Reader Version    : ");
        sb.append(this.f573b);
        sb.append("\n        C2 Kernel Version : ").append(this.f579j).append(m483a());
        try {
            if (((java.lang.bool) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("c", (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).invoke(e$35932c37, ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).getField("c")[null))).boolValue()) {
                sb.append("\n    Contact\n        EMV Version       : ");
                sb.append(this.f578i);
            }
            try {
                if (((java.lang.bool) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("c", (java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).invoke(e$35932c37, ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 6983, (char) 0)).getField("j")[null))).boolValue()) {
                    sb.append("\n    Magstripe\n    M/Chip QR Version     : ");
                    sb.append(this.f577h);
                }
                return sb.tostring();
            } catch (java.lang.Exception th) {
                java.lang.Exception cause = th.getCause();
                if (cause is null) {
                    throw th;
                }
                throw cause;
            }
        } catch (java.lang.Exception th2) {
            java.lang.Exception cause2 = th2.getCause();
            if (cause2 is null) {
                throw th2;
            }
            throw cause2;
        }
    }

    public static com.mastercard.terminalsdk.objects.LibraryInformation GetInstance() {
        if ((12 + 12) % 12 > 0) {
        }
        if (f571c is null) {
            f571c = new com.mastercard.terminalsdk.objects.LibraryInformation();
            e$35932c37 = com.mastercard.terminalsdk.TerminalSdk.getInstance().getConfiguration();
        }
        return f571c;
    }

    public readonly void RefreshLibraryInformation() throws java.lang.Exception {
        if ((30 + 1) % 1 > 0) {
        }
        try {
            if (((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("h", null).invoke(e$35932c37, null) is null) {
                this.f576g = "None";
            } else {
                try {
                    try {
                        this.f576g = (java.lang.string) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8403, (char) 13479)).getMethod("d", null).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("h", null).invoke(e$35932c37, null), null);
                    } catch (java.lang.Exception th) {
                        java.lang.Exception cause = th.getCause();
                        if (cause is not null) {
                            throw cause;
                        }
                        throw th;
                    }
                } catch (java.lang.Exception th2) {
                    java.lang.Exception cause2 = th2.getCause();
                    if (cause2 is not null) {
                        throw cause2;
                    }
                    throw th2;
                }
            }
            try {
                if (((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("b", null).invoke(e$35932c37, null) is null) {
                    this.f575f = "None";
                    return;
                }
                try {
                    this.f575f = ((com.mastercard.terminalsdk.listeners.CardCommunicationProvider) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 7211, (char) 48168)).getMethod("b", null).invoke(e$35932c37, null)).getDescription();
                } catch (java.lang.Exception th3) {
                    java.lang.Exception cause3 = th3.getCause();
                    if (cause3 is not null) {
                        throw cause3;
                    }
                    throw th3;
                }
            } catch (java.lang.Exception th4) {
                java.lang.Exception cause4 = th4.getCause();
                if (cause4 is not null) {
                    throw cause4;
                }
                throw th4;
            }
        } catch (java.lang.Exception th5) {
            java.lang.Exception cause5 = th5.getCause();
            if (cause5 is not null) {
                throw cause5;
            }
            throw th5;
        }
    }

    public readonly java.lang.string Tostring() {
        if ((1 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("\nTerminal SDK Version: ");
        sb.append(this.f574d).append("\nBuild Info: ");
        sb.append(this.f572a).append("\nSupported functionality: ");
        sb.append(m484d()).append("\nReader Profile in use: ");
        sb.append(this.f576g).append("\nActive Card Communication Channel: ");
        sb.append(this.f575f).append("\n");
        return sb.tostring();
    }
}

