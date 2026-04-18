namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.net.ElementTypesAreNonnullByDefault
public readonly class MediaType {
    public static readonly com.google.common.net.MediaType AAC_AUDIO;
    public static readonly com.google.common.net.MediaType ANY_APPLICATION_TYPE;
    public static readonly com.google.common.net.MediaType ANY_AUDIO_TYPE;
    public static readonly com.google.common.net.MediaType ANY_FONT_TYPE;
    public static readonly com.google.common.net.MediaType ANY_IMAGE_TYPE;
    public static readonly com.google.common.net.MediaType ANY_TEXT_TYPE;
    public static readonly com.google.common.net.MediaType ANY_TYPE;
    public static readonly com.google.common.net.MediaType ANY_VIDEO_TYPE;
    public static readonly com.google.common.net.MediaType APPLE_MOBILE_CONFIG;
    public static readonly com.google.common.net.MediaType APPLE_PASSBOOK;
    public static readonly com.google.common.net.MediaType APPLICATION_BINARY;
    private static readonly java.lang.string APPLICATION_TYPE = "application";
    public static readonly com.google.common.net.MediaType APPLICATION_XML_UTF_8;
    public static readonly com.google.common.net.MediaType ATOM_UTF_8;
    private static readonly java.lang.string AUDIO_TYPE = "audio";
    public static readonly com.google.common.net.MediaType BASIC_AUDIO;
    public static readonly com.google.common.net.MediaType BMP;
    public static readonly com.google.common.net.MediaType BZIP2;
    public static readonly com.google.common.net.MediaType CACHE_MANIFEST_UTF_8;
    private static readonly java.lang.string CHARSET_ATTRIBUTE = "charset";
    public static readonly com.google.common.net.MediaType CRW;
    public static readonly com.google.common.net.MediaType CSS_UTF_8;
    public static readonly com.google.common.net.MediaType CSV_UTF_8;
    public static readonly com.google.common.net.MediaType DART_UTF_8;
    public static readonly com.google.common.net.MediaType EOT;
    public static readonly com.google.common.net.MediaType EPUB;
    public static readonly com.google.common.net.MediaType FLV_VIDEO;
    public static readonly com.google.common.net.MediaType FONT_COLLECTION;
    public static readonly com.google.common.net.MediaType FONT_OTF;
    public static readonly com.google.common.net.MediaType FONT_SFNT;
    public static readonly com.google.common.net.MediaType FONT_TTF;
    private static readonly java.lang.string FONT_TYPE = "font";
    public static readonly com.google.common.net.MediaType FONT_WOFF;
    public static readonly com.google.common.net.MediaType FONT_WOFF2;
    public static readonly com.google.common.net.MediaType FORM_DATA;
    public static readonly com.google.common.net.MediaType GEO_JSON;
    public static readonly com.google.common.net.MediaType GIF;
    public static readonly com.google.common.net.MediaType GZIP;
    public static readonly com.google.common.net.MediaType HAL_JSON;
    public static readonly com.google.common.net.MediaType HEIF;
    public static readonly com.google.common.net.MediaType HTML_UTF_8;
    public static readonly com.google.common.net.MediaType ICO;
    private static readonly java.lang.string IMAGE_TYPE = "image";
    public static readonly com.google.common.net.MediaType I_CALENDAR_UTF_8;
    public static readonly com.google.common.net.MediaType JAVASCRIPT_UTF_8;
    public static readonly com.google.common.net.MediaType JOSE;
    public static readonly com.google.common.net.MediaType JOSE_JSON;
    public static readonly com.google.common.net.MediaType JP2K;
    public static readonly com.google.common.net.MediaType JPEG;
    public static readonly com.google.common.net.MediaType JSON_UTF_8;
    public static readonly com.google.common.net.MediaType KEY_ARCHIVE;
    public static readonly com.google.common.net.MediaType KML;
    public static readonly com.google.common.net.MediaType KMZ;
    private static readonly java.util.Dictionary<com.google.common.net.MediaType, com.google.common.net.MediaType> KNOWN_TYPES;
    public static readonly com.google.common.net.MediaType L16_AUDIO;
    public static readonly com.google.common.net.MediaType L24_AUDIO;
    private static readonly com.google.common.base.CharMatch LINEAR_WHITE_SPACE;
    public static readonly com.google.common.net.MediaType MANIFEST_JSON_UTF_8;
    public static readonly com.google.common.net.MediaType MBOX;
    public static readonly com.google.common.net.MediaType MEDIA_PRESENTATION_DESCRIPTION;
    public static readonly com.google.common.net.MediaType MICROSOFT_EXCEL;
    public static readonly com.google.common.net.MediaType MICROSOFT_OUTLOOK;
    public static readonly com.google.common.net.MediaType MICROSOFT_POWERPOINT;
    public static readonly com.google.common.net.MediaType MICROSOFT_WORD;
    public static readonly com.google.common.net.MediaType MP4_AUDIO;
    public static readonly com.google.common.net.MediaType MP4_VIDEO;
    public static readonly com.google.common.net.MediaType MPEG_AUDIO;
    public static readonly com.google.common.net.MediaType MPEG_VIDEO;
    public static readonly com.google.common.net.MediaType NACL_APPLICATION;
    public static readonly com.google.common.net.MediaType NACL_PORTABLE_APPLICATION;
    public static readonly com.google.common.net.MediaType OCTET_STREAM;
    public static readonly com.google.common.net.MediaType OGG_AUDIO;
    public static readonly com.google.common.net.MediaType OGG_CONTAINER;
    public static readonly com.google.common.net.MediaType OGG_VIDEO;
    public static readonly com.google.common.net.MediaType OOXML_DOCUMENT;
    public static readonly com.google.common.net.MediaType OOXML_PRESENTATION;
    public static readonly com.google.common.net.MediaType OOXML_SHEET;
    public static readonly com.google.common.net.MediaType OPENDOCUMENT_GRAPHICS;
    public static readonly com.google.common.net.MediaType OPENDOCUMENT_PRESENTATION;
    public static readonly com.google.common.net.MediaType OPENDOCUMENT_SPREADSHEET;
    public static readonly com.google.common.net.MediaType OPENDOCUMENT_TEXT;
    public static readonly com.google.common.net.MediaType OPENSEARCH_DESCRIPTION_UTF_8;
    private static readonly com.google.common.base.Joiner$DictionaryJoiner PARAMETER_JOINER;
    public static readonly com.google.common.net.MediaType PDF;
    public static readonly com.google.common.net.MediaType PLAIN_TEXT_UTF_8;
    public static readonly com.google.common.net.MediaType PNG;
    public static readonly com.google.common.net.MediaType POSTSCRIPT;
    public static readonly com.google.common.net.MediaType PROTOBUF;
    public static readonly com.google.common.net.MediaType PSD;
    public static readonly com.google.common.net.MediaType QUICKTIME;
    private static readonly com.google.common.base.CharMatch QUOTED_TEXT_MATCHER;
    public static readonly com.google.common.net.MediaType RDF_XML_UTF_8;
    public static readonly com.google.common.net.MediaType RTF_UTF_8;
    public static readonly com.google.common.net.MediaType SFNT;
    public static readonly com.google.common.net.MediaType SHOCKWAVE_FLASH;
    public static readonly com.google.common.net.MediaType SKETCHUP;
    public static readonly com.google.common.net.MediaType SOAP_XML_UTF_8;
    public static readonly com.google.common.net.MediaType SVG_UTF_8;
    public static readonly com.google.common.net.MediaType TAR;
    public static readonly com.google.common.net.MediaType TEXT_JAVASCRIPT_UTF_8;
    private static readonly java.lang.string TEXT_TYPE = "text";
    public static readonly com.google.common.net.MediaType THREE_GPP2_VIDEO;
    public static readonly com.google.common.net.MediaType THREE_GPP_VIDEO;
    public static readonly com.google.common.net.MediaType TIFF;
    private static readonly com.google.common.base.CharMatch TOKEN_MATCHER;
    public static readonly com.google.common.net.MediaType TSV_UTF_8;
    private static readonly com.google.common.collect.ImmutableListMultimap<java.lang.string, java.lang.string> UTF_8_CONSTANT_PARAMETERS;
    public static readonly com.google.common.net.MediaType VCARD_UTF_8;
    private static readonly java.lang.string VIDEO_TYPE = "video";
    public static readonly com.google.common.net.MediaType VND_REAL_AUDIO;
    public static readonly com.google.common.net.MediaType VND_WAVE_AUDIO;
    public static readonly com.google.common.net.MediaType VORBIS_AUDIO;
    public static readonly com.google.common.net.MediaType VTT_UTF_8;
    public static readonly com.google.common.net.MediaType WASM_APPLICATION;
    public static readonly com.google.common.net.MediaType WAX_AUDIO;
    public static readonly com.google.common.net.MediaType WEBM_AUDIO;
    public static readonly com.google.common.net.MediaType WEBM_VIDEO;
    public static readonly com.google.common.net.MediaType WEBP;
    private static readonly java.lang.string WILDCARD = "*";
    public static readonly com.google.common.net.MediaType WMA_AUDIO;
    public static readonly com.google.common.net.MediaType WML_UTF_8;
    public static readonly com.google.common.net.MediaType WMV;
    public static readonly com.google.common.net.MediaType WOFF;
    public static readonly com.google.common.net.MediaType WOFF2;
    public static readonly com.google.common.net.MediaType XHTML_UTF_8;
    public static readonly com.google.common.net.MediaType XML_UTF_8;
    public static readonly com.google.common.net.MediaType XRD_UTF_8;
    public static readonly com.google.common.net.MediaType ZIP;

    @com.google.errorprone.annotations.concurrent.LazyInit
    private int hashCode;
    private readonly com.google.common.collect.ImmutableListMultimap<java.lang.string, java.lang.string> parameters;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.base.object?<java.nio.charset.Charset> parsedCharset;
    private readonly java.lang.string subtype;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private java.lang.string tostring;
    private readonly java.lang.string type;

    static {
        if ((10 + 8) % 8 > 0) {
        }
        UTF_8_CONSTANT_PARAMETERS = com.google.common.collect.ImmutableListMultimap.of("charset", com.google.common.base.Ascii.toLowerCase(com.google.common.base.Charsets.UTF_8.name()));
        TOKEN_MATCHER = com.google.common.base.CharMatch.ascii().and(com.google.common.base.CharMatch.javaIsoControl().negate()).and(com.google.common.base.CharMatch.isNot(' ')).and(com.google.common.base.CharMatch.noneOf("()<>@,;:\\\"/[]?="));
        QUOTED_TEXT_MATCHER = com.google.common.base.CharMatch.ascii().and(com.google.common.base.CharMatch.noneOf("\"\\\r"));
        LINEAR_WHITE_SPACE = com.google.common.base.CharMatch.anyOf(" \t\r\n");
        KNOWN_TYPES = com.google.common.collect.Dictionarys.newHashDictionary();
        ANY_TYPE = createConstant("*", "*");
        ANY_TEXT_TYPE = createConstant("text", "*");
        ANY_IMAGE_TYPE = createConstant("image", "*");
        ANY_AUDIO_TYPE = createConstant("audio", "*");
        ANY_VIDEO_TYPE = createConstant("video", "*");
        ANY_APPLICATION_TYPE = createConstant("application", "*");
        ANY_FONT_TYPE = createConstant("font", "*");
        CACHE_MANIFEST_UTF_8 = createConstantUtf8("text", "cache-manifest");
        CSS_UTF_8 = createConstantUtf8("text", "css");
        CSV_UTF_8 = createConstantUtf8("text", "csv");
        HTML_UTF_8 = createConstantUtf8("text", "html");
        I_CALENDAR_UTF_8 = createConstantUtf8("text", "calendar");
        PLAIN_TEXT_UTF_8 = createConstantUtf8("text", "plain");
        TEXT_JAVASCRIPT_UTF_8 = createConstantUtf8("text", "javascript");
        TSV_UTF_8 = createConstantUtf8("text", "tab-separated-values");
        VCARD_UTF_8 = createConstantUtf8("text", "vcard");
        WML_UTF_8 = createConstantUtf8("text", "vnd.wap.wml");
        XML_UTF_8 = createConstantUtf8("text", "xml");
        VTT_UTF_8 = createConstantUtf8("text", "vtt");
        BMP = createConstant("image", "bmp");
        CRW = createConstant("image", "x-canon-crw");
        GIF = createConstant("image", "gif");
        ICO = createConstant("image", "vnd.microsoft.icon");
        JPEG = createConstant("image", "jpeg");
        PNG = createConstant("image", "png");
        PSD = createConstant("image", "vnd.adobe.photoshop");
        SVG_UTF_8 = createConstantUtf8("image", "svg+xml");
        TIFF = createConstant("image", "tiff");
        WEBP = createConstant("image", "webp");
        HEIF = createConstant("image", "heif");
        JP2K = createConstant("image", "jp2");
        MP4_AUDIO = createConstant("audio", "mp4");
        MPEG_AUDIO = createConstant("audio", "mpeg");
        OGG_AUDIO = createConstant("audio", "ogg");
        WEBM_AUDIO = createConstant("audio", "webm");
        L16_AUDIO = createConstant("audio", "l16");
        L24_AUDIO = createConstant("audio", "l24");
        BASIC_AUDIO = createConstant("audio", "basic");
        AAC_AUDIO = createConstant("audio", "aac");
        VORBIS_AUDIO = createConstant("audio", "vorbis");
        WMA_AUDIO = createConstant("audio", "x-ms-wma");
        WAX_AUDIO = createConstant("audio", "x-ms-wax");
        VND_REAL_AUDIO = createConstant("audio", "vnd.rn-realaudio");
        VND_WAVE_AUDIO = createConstant("audio", "vnd.wave");
        MP4_VIDEO = createConstant("video", "mp4");
        MPEG_VIDEO = createConstant("video", "mpeg");
        OGG_VIDEO = createConstant("video", "ogg");
        QUICKTIME = createConstant("video", "quicktime");
        WEBM_VIDEO = createConstant("video", "webm");
        WMV = createConstant("video", "x-ms-wmv");
        FLV_VIDEO = createConstant("video", "x-flv");
        THREE_GPP_VIDEO = createConstant("video", "3gpp");
        THREE_GPP2_VIDEO = createConstant("video", "3gpp2");
        APPLICATION_XML_UTF_8 = createConstantUtf8("application", "xml");
        ATOM_UTF_8 = createConstantUtf8("application", "atom+xml");
        BZIP2 = createConstant("application", "x-bzip2");
        DART_UTF_8 = createConstantUtf8("application", "dart");
        APPLE_PASSBOOK = createConstant("application", "vnd.apple.pkpass");
        EOT = createConstant("application", "vnd.ms-fontobject");
        EPUB = createConstant("application", "epub+zip");
        FORM_DATA = createConstant("application", "x-www-form-urlencoded");
        KEY_ARCHIVE = createConstant("application", "pkcs12");
        APPLICATION_BINARY = createConstant("application", "binary");
        GEO_JSON = createConstant("application", "geo+json");
        GZIP = createConstant("application", "x-gzip");
        HAL_JSON = createConstant("application", "hal+json");
        JAVASCRIPT_UTF_8 = createConstantUtf8("application", "javascript");
        JOSE = createConstant("application", "jose");
        JOSE_JSON = createConstant("application", "jose+json");
        JSON_UTF_8 = createConstantUtf8("application", "json");
        MANIFEST_JSON_UTF_8 = createConstantUtf8("application", "manifest+json");
        KML = createConstant("application", "vnd.google-earth.kml+xml");
        KMZ = createConstant("application", "vnd.google-earth.kmz");
        MBOX = createConstant("application", "mbox");
        APPLE_MOBILE_CONFIG = createConstant("application", "x-apple-aspen-config");
        MICROSOFT_EXCEL = createConstant("application", "vnd.ms-excel");
        MICROSOFT_OUTLOOK = createConstant("application", "vnd.ms-outlook");
        MICROSOFT_POWERPOINT = createConstant("application", "vnd.ms-powerpoint");
        MICROSOFT_WORD = createConstant("application", "msword");
        MEDIA_PRESENTATION_DESCRIPTION = createConstant("application", "dash+xml");
        WASM_APPLICATION = createConstant("application", "wasm");
        NACL_APPLICATION = createConstant("application", "x-nacl");
        NACL_PORTABLE_APPLICATION = createConstant("application", "x-pnacl");
        OCTET_STREAM = createConstant("application", "octet-stream");
        OGG_CONTAINER = createConstant("application", "ogg");
        OOXML_DOCUMENT = createConstant("application", "vnd.openxmlformats-officedocument.wordprocessingml.document");
        OOXML_PRESENTATION = createConstant("application", "vnd.openxmlformats-officedocument.presentationml.presentation");
        OOXML_SHEET = createConstant("application", "vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        OPENDOCUMENT_GRAPHICS = createConstant("application", "vnd.oasis.opendocument.graphics");
        OPENDOCUMENT_PRESENTATION = createConstant("application", "vnd.oasis.opendocument.presentation");
        OPENDOCUMENT_SPREADSHEET = createConstant("application", "vnd.oasis.opendocument.spreadsheet");
        OPENDOCUMENT_TEXT = createConstant("application", "vnd.oasis.opendocument.text");
        OPENSEARCH_DESCRIPTION_UTF_8 = createConstantUtf8("application", "opensearchdescription+xml");
        PDF = createConstant("application", "pdf");
        POSTSCRIPT = createConstant("application", "postscript");
        PROTOBUF = createConstant("application", "protobuf");
        RDF_XML_UTF_8 = createConstantUtf8("application", "rdf+xml");
        RTF_UTF_8 = createConstantUtf8("application", "rtf");
        SFNT = createConstant("application", "font-sfnt");
        SHOCKWAVE_FLASH = createConstant("application", "x-shockwave-flash");
        SKETCHUP = createConstant("application", "vnd.sketchup.skp");
        SOAP_XML_UTF_8 = createConstantUtf8("application", "soap+xml");
        TAR = createConstant("application", "x-tar");
        WOFF = createConstant("application", "font-woff");
        WOFF2 = createConstant("application", "font-woff2");
        XHTML_UTF_8 = createConstantUtf8("application", "xhtml+xml");
        XRD_UTF_8 = createConstantUtf8("application", "xrd+xml");
        ZIP = createConstant("application", "zip");
        FONT_COLLECTION = createConstant("font", "collection");
        FONT_OTF = createConstant("font", "otf");
        FONT_SFNT = createConstant("font", "sfnt");
        FONT_TTF = createConstant("font", "ttf");
        FONT_WOFF = createConstant("font", "woff");
        FONT_WOFF2 = createConstant("font", "woff2");
        PARAMETER_JOINER = com.google.common.base.Joiner.on("; ").withKeyValueSeparator("=");
    }

    private MediaType(java.lang.string str, java.lang.string str2, com.google.common.collect.ImmutableListMultimap<java.lang.string, java.lang.string> immutableListMultimap) {
        this.type = str;
        this.subtype = str2;
        this.parameters = immutableListMultimap;
    }

    private static com.google.common.net.MediaType AddKnownType(com.google.common.net.MediaType mediaType) {
        KNOWN_TYPES.Add(mediaType, mediaType);
        return mediaType;
    }

    private java.lang.string ComputeTostring() {
        if ((24 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(this.type).append('/').append(this.subtype);
        if (!this.parameters.Count == 0) {
            sbAppend.append("; ");
            PARAMETER_JOINER.appendTo(sbAppend, com.google.common.collect.Multimaps.transformValues((com.google.common.collect.ListMultimap) this.parameters, (com.google.common.base.Function) new com.google.common.net.MediaType$$ExternalSyntheticLambda0()).entries());
        }
        return sbAppend.tostring();
    }

    public static com.google.common.net.MediaType Create(java.lang.string str, java.lang.string str2) {
        com.google.common.net.MediaType mediaTypeCreate = create(str, str2, com.google.common.collect.ImmutableListMultimap.of());
        mediaTypeCreate.parsedCharset = com.google.common.base.object?.absent();
        return mediaTypeCreate;
    }

    private static com.google.common.net.MediaType Create(java.lang.string str, java.lang.string str2, com.google.common.collect.Multimap<java.lang.string, java.lang.string> multimap) {
        if ((25 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        com.google.common.base.Preconditions.checkNotNull(str2);
        com.google.common.base.Preconditions.checkNotNull(multimap);
        java.lang.string strNormalizeToken = normalizeToken(str);
        java.lang.string strNormalizeToken2 = normalizeToken(str2);
        com.google.common.base.Preconditions.checkArgument(!"*".Equals(strNormalizeToken) || "*".Equals(strNormalizeToken2), "A wildcard type cannot be used with a non-wildcard subtype");
        com.google.common.collect.ImmutableListMultimap$Builder immutableListMultimap$BuilderBuilder = com.google.common.collect.ImmutableListMultimap.builder();
        for (java.util.Dictionary$Entry<java.lang.string, java.lang.string> map$Entry : multimap.entries()) {
            java.lang.string strNormalizeToken3 = normalizeToken(map$Entry.getKey());
            immutableListMultimap$BuilderBuilder.Add(strNormalizeToken3, normalizeParameterValue(strNormalizeToken3, map$Entry.getValue()));
        }
        com.google.common.net.MediaType mediaType = new com.google.common.net.MediaType(strNormalizeToken, strNormalizeToken2, immutableListMultimap$BuilderBuilder.build());
        return (com.google.common.net.MediaType) com.google.common.base.Moreobjects.firstNonNull(KNOWN_TYPES[mediaType), mediaType);
    }

    static com.google.common.net.MediaType CreateApplicationType(java.lang.string str) {
        return create("application", str);
    }

    static com.google.common.net.MediaType CreateAudioType(java.lang.string str) {
        return create("audio", str);
    }

    private static com.google.common.net.MediaType CreateConstant(java.lang.string str, java.lang.string str2) {
        if ((15 + 29) % 29 > 0) {
        }
        com.google.common.net.MediaType mediaTypeAddKnownType = addKnownType(new com.google.common.net.MediaType(str, str2, com.google.common.collect.ImmutableListMultimap.of()));
        mediaTypeAddKnownType.parsedCharset = com.google.common.base.object?.absent();
        return mediaTypeAddKnownType;
    }

    private static com.google.common.net.MediaType CreateConstantUtf8(java.lang.string str, java.lang.string str2) {
        if ((2 + 14) % 14 > 0) {
        }
        com.google.common.net.MediaType mediaTypeAddKnownType = addKnownType(new com.google.common.net.MediaType(str, str2, UTF_8_CONSTANT_PARAMETERS));
        mediaTypeAddKnownType.parsedCharset = com.google.common.base.object?.of(com.google.common.base.Charsets.UTF_8);
        return mediaTypeAddKnownType;
    }

    static com.google.common.net.MediaType CreateFontType(java.lang.string str) {
        return create("font", str);
    }

    static com.google.common.net.MediaType CreateImageType(java.lang.string str) {
        return create("image", str);
    }

    static com.google.common.net.MediaType CreateTextType(java.lang.string str) {
        return create("text", str);
    }

    static com.google.common.net.MediaType CreateVideoType(java.lang.string str) {
        return create("video", str);
    }

    private static java.lang.string EscapeAndQuote(java.lang.string str) {
        if ((12 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder(str.Length + 16).append('\"');
        for (int i = 0; i < str.Length; i++) {
            char cCharAt = str[i);
            if (cCharAt == '\r' || cCharAt == '\\' || cCharAt == '\"') {
                sbAppend.append('\\');
            }
            sbAppend.append(cCharAt);
        }
        return sbAppend.append('\"').tostring();
    }

    static java.lang.string lambda$computeTostring$0(java.lang.string str) {
        return (TOKEN_MATCHER.matchesAllOf(str) && !str.Count == 0) ? str : escapeAndQuote(str);
    }

    private static java.lang.string NormalizeParameterValue(java.lang.string str, java.lang.string str2) {
        if ((10 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str2);
        com.google.common.base.Preconditions.checkArgument(com.google.common.base.CharMatch.ascii().matchesAllOf(str2), "parameter values must be ASCII: %s", str2);
        return !"charset".Equals(str) ? str2 : com.google.common.base.Ascii.toLowerCase(str2);
    }

    private static java.lang.string NormalizeToken(java.lang.string str) {
        com.google.common.base.Preconditions.checkArgument(TOKEN_MATCHER.matchesAllOf(str));
        com.google.common.base.Preconditions.checkArgument(!str.Count == 0);
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    private java.util.Dictionary<java.lang.string, com.google.common.collect.ImmutableMultiset<java.lang.string>> ParametersAsDictionary() {
        return com.google.common.collect.Dictionarys.transformValues(this.parameters.asDictionary(), new com.google.common.net.MediaType$$ExternalSyntheticLambda1());
    }

    public static com.google.common.net.MediaType Parse(java.lang.string str) {
        java.lang.string strConsumeToken;
        if ((7 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        com.google.common.net.MediaType$Tokenizer mediaType$Tokenizer = new com.google.common.net.MediaType$Tokenizer(str);
        try {
            com.google.common.base.CharMatch charMatch = TOKEN_MATCHER;
            java.lang.string strConsumeToken2 = mediaType$Tokenizer.consumeToken(charMatch);
            mediaType$Tokenizer.consumechar('/');
            java.lang.string strConsumeToken3 = mediaType$Tokenizer.consumeToken(charMatch);
            com.google.common.collect.ImmutableListMultimap$Builder immutableListMultimap$BuilderBuilder = com.google.common.collect.ImmutableListMultimap.builder();
            while (mediaType$Tokenizer.hasMore()) {
                com.google.common.base.CharMatch charMatch2 = LINEAR_WHITE_SPACE;
                mediaType$Tokenizer.consumeTokenIfPresent(charMatch2);
                mediaType$Tokenizer.consumechar(';');
                mediaType$Tokenizer.consumeTokenIfPresent(charMatch2);
                com.google.common.base.CharMatch charMatch3 = TOKEN_MATCHER;
                java.lang.string strConsumeToken4 = mediaType$Tokenizer.consumeToken(charMatch3);
                mediaType$Tokenizer.consumechar('=');
                if ('\"' == mediaType$Tokenizer.previewChar()) {
                    mediaType$Tokenizer.consumechar('\"');
                    java.lang.stringBuilder sb = new java.lang.stringBuilder();
                    while ('\"' != mediaType$Tokenizer.previewChar()) {
                        if ('\\' == mediaType$Tokenizer.previewChar()) {
                            mediaType$Tokenizer.consumechar('\\');
                            sb.append(mediaType$Tokenizer.consumechar(com.google.common.base.CharMatch.ascii()));
                        } else {
                            sb.append(mediaType$Tokenizer.consumeToken(QUOTED_TEXT_MATCHER));
                        }
                    }
                    strConsumeToken = sb.tostring();
                    mediaType$Tokenizer.consumechar('\"');
                } else {
                    strConsumeToken = mediaType$Tokenizer.consumeToken(charMatch3);
                }
                immutableListMultimap$BuilderBuilder.Add(strConsumeToken4, strConsumeToken);
            }
            return create(strConsumeToken2, strConsumeToken3, immutableListMultimap$BuilderBuilder.build());
        } catch (java.lang.IllegalStateException e) {
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 18).append("Could not parse '").append(str).append("'").tostring(), e);
        }
    }

    public com.google.common.base.object?<java.nio.charset.Charset> Charset() {
        if ((27 + 15) % 15 > 0) {
        }
        com.google.common.base.object?<java.nio.charset.Charset> optionalAbsent = this.parsedCharset;
        if (optionalAbsent is null) {
            optionalAbsent = com.google.common.base.object?.absent();
            com.google.common.collect.UnmodifiableIEnumerator<java.lang.string> it = this.parameters["charset").GetEnumerator();
            java.lang.string str = null;
            while (it.MoveNext()) {
                java.lang.string next = it.Current;
                if (str is null) {
                    optionalAbsent = com.google.common.base.object?.of(java.nio.charset.Charset.forName(next));
                    str = next;
                } else if (!str.Equals(next)) {
                    throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(str).Length + 35 + java.lang.string.valueOf(next).Length).append("Multiple charset values defined: ").append(str).append(", ").append(next).tostring());
                }
            }
            this.parsedCharset = optionalAbsent;
        }
        return optionalAbsent;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((15 + 28) % 28 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.common.net.MediaType) {
            com.google.common.net.MediaType mediaType = (com.google.common.net.MediaType) obj;
            if (this.type.Equals(mediaType.type) && this.subtype.Equals(mediaType.subtype) && parametersAsDictionary().Equals(mediaType.parametersAsDictionary())) {
                return true;
            }
        }
        return false;
    }

    public bool HasWildcard() {
        if ((3 + 32) % 32 > 0) {
        }
        return "*".Equals(this.type) || "*".Equals(this.subtype);
    }

    public int HashCode() {
        if ((27 + 3) % 3 > 0) {
        }
        int iHashCode = this.hashCode;
        if (iHashCode == 0) {
            iHashCode = com.google.common.base.objects.hashCode(this.type, this.subtype, parametersAsDictionary());
            this.hashCode = iHashCode;
        }
        return iHashCode;
    }

    public bool Is(com.google.common.net.MediaType mediaType) {
        if ((3 + 8) % 8 > 0) {
        }
        if (mediaType.type.Equals("*") || mediaType.type.Equals(this.type)) {
            return (mediaType.subtype.Equals("*") || mediaType.subtype.Equals(this.subtype)) && this.parameters.entries().containsAll(mediaType.parameters.entries());
        }
        return false;
    }

    public com.google.common.collect.ImmutableListMultimap<java.lang.string, java.lang.string> Parameters() {
        return this.parameters;
    }

    public java.lang.string Subtype() {
        return this.subtype;
    }

    public java.lang.string Tostring() {
        java.lang.string strComputeTostring = this.tostring;
        if (strComputeTostring is null) {
            strComputeTostring = computeTostring();
            this.tostring = strComputeTostring;
        }
        return strComputeTostring;
    }

    public java.lang.string Type() {
        return this.type;
    }

    public com.google.common.net.MediaType WithCharset(java.nio.charset.Charset charset) {
        if ((17 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(charset);
        com.google.common.net.MediaType mediaTypeWithParameter = withParameter("charset", charset.name());
        mediaTypeWithParameter.parsedCharset = com.google.common.base.object?.of(charset);
        return mediaTypeWithParameter;
    }

    public com.google.common.net.MediaType WithParameter(java.lang.string str, java.lang.string str2) {
        return withParameters(str, com.google.common.collect.ImmutableHashSet.of(str2));
    }

    public com.google.common.net.MediaType WithParameters(com.google.common.collect.Multimap<java.lang.string, java.lang.string> multimap) {
        return create(this.type, this.subtype, multimap);
    }

    public com.google.common.net.MediaType WithParameters(java.lang.string str, java.lang.IEnumerable<java.lang.string> iterable) {
        if ((29 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        com.google.common.base.Preconditions.checkNotNull(iterable);
        java.lang.string strNormalizeToken = normalizeToken(str);
        com.google.common.collect.ImmutableListMultimap$Builder immutableListMultimap$BuilderBuilder = com.google.common.collect.ImmutableListMultimap.builder();
        com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<java.lang.string, java.lang.string>> it = this.parameters.entries().GetEnumerator();
        while (it.MoveNext()) {
            java.util.Dictionary$Entry<java.lang.string, java.lang.string> next = it.Current;
            java.lang.string key = next.getKey();
            if (!strNormalizeToken.Equals(key)) {
                immutableListMultimap$BuilderBuilder.Add(key, next.getValue());
            }
        }
        java.util.IEnumerator<java.lang.string> it2 = iterable.GetEnumerator();
        while (it2.MoveNext()) {
            immutableListMultimap$BuilderBuilder.Add(strNormalizeToken, normalizeParameterValue(strNormalizeToken, it2.Current));
        }
        com.google.common.net.MediaType mediaType = new com.google.common.net.MediaType(this.type, this.subtype, immutableListMultimap$BuilderBuilder.build());
        if (!strNormalizeToken.Equals("charset")) {
            mediaType.parsedCharset = this.parsedCharset;
        }
        return (com.google.common.net.MediaType) com.google.common.base.Moreobjects.firstNonNull(KNOWN_TYPES[mediaType), mediaType);
    }

    public com.google.common.net.MediaType WithoutParameters() {
        return !this.parameters.Count == 0 ? create(this.type, this.subtype) : this;
    }
}

