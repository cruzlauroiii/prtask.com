namespace PrTask.Git.Generated;

internal static partial class MidxH
{
    internal const int MIDX_SIGNATURE = 0x4d494458 /* "MIDX" */;
    internal const int MIDX_VERSION = 1;
    internal const int MIDX_BYTE_FILE_VERSION = 4;
    internal const int MIDX_BYTE_HASH_VERSION = 5;
    internal const int MIDX_BYTE_NUM_CHUNKS = 6;
    internal const int MIDX_BYTE_NUM_PACKS = 8;
    internal const int MIDX_HEADER_SIZE = 12;
    internal const int MIDX_CHUNK_ALIGNMENT = 4;
    internal const int MIDX_CHUNKID_PACKNAMES = 0x504e414d /* "PNAM" */;
    internal const int MIDX_CHUNKID_BITMAPPEDPACKS = 0x42544d50 /* "BTMP" */;
    internal const int MIDX_CHUNKID_OIDFANOUT = 0x4f494446 /* "OIDF" */;
    internal const int MIDX_CHUNKID_OIDLOOKUP = 0x4f49444c /* "OIDL" */;
    internal const int MIDX_CHUNKID_OBJECTOFFSETS = 0x4f4f4646 /* "OOFF" */;
    internal const int MIDX_CHUNKID_LARGEOFFSETS = 0x4c4f4646 /* "LOFF" */;
    internal const int MIDX_CHUNKID_REVINDEX = 0x52494458 /* "RIDX" */;
    internal const int MIDX_CHUNKID_BASE = 0x42415345 /* "BASE" */;
    internal const int MIDX_LARGE_OFFSET_NEEDED = 0x80000000;
    internal const string GIT_TEST_MULTI_PACK_INDEX = "GIT_TEST_MULTI_PACK_INDEX";
    internal const string MIDX_EXT_REV = "rev";
    internal const string MIDX_EXT_BITMAP = "bitmap";
    internal const string MIDX_EXT_MIDX = "midx";
}
