/*
 * PrtaskIoShim.c — File I/O abstraction for WASM
 *
 * Git's file I/O is redirected to File System Access API
 * via C# JSInterop callbacks. The actual POSIX calls (open/read/write)
 * are handled by the WASM runtime's virtual filesystem.
 *
 * This shim provides any additional hooks needed for FSA API integration.
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* Callback function pointers — set from C# via P/Invoke */
typedef int (*FsaReadCallback)(const char *Path, char *Buffer, int Size);
typedef int (*FsaWriteCallback)(const char *Path, const char *Buffer, int Size);
typedef int (*FsaMkdirCallback)(const char *Path);
typedef int (*FsaExistsCallback)(const char *Path);

static FsaReadCallback GFsaRead = NULL;
static FsaWriteCallback GFsaWrite = NULL;
static FsaMkdirCallback GFsaMkdir = NULL;
static FsaExistsCallback GFsaExists = NULL;

void PrtaskIoInit(FsaReadCallback ReadCb, FsaWriteCallback WriteCb,
                  FsaMkdirCallback MkdirCb, FsaExistsCallback ExistsCb) {
    GFsaRead = ReadCb;
    GFsaWrite = WriteCb;
    GFsaMkdir = MkdirCb;
    GFsaExists = ExistsCb;
}

int PrtaskIoReadFile(const char *Path, char *Buffer, int Size) {
    if (GFsaRead) return GFsaRead(Path, Buffer, Size);
    return -1;
}

int PrtaskIoWriteFile(const char *Path, const char *Buffer, int Size) {
    if (GFsaWrite) return GFsaWrite(Path, Buffer, Size);
    return -1;
}

int PrtaskIoMkdir(const char *Path) {
    if (GFsaMkdir) return GFsaMkdir(Path);
    return -1;
}

int PrtaskIoExists(const char *Path) {
    if (GFsaExists) return GFsaExists(Path);
    return 0;
}
