namespace RSRD251;

file class StreamReads
{
    public byte[] ReadLengthPrefixedByteArray(Stream stream)
    {
        var length = stream.ReadByte();
        var buffer = new byte[length];
        stream.Read(buffer);
        return buffer;
    }
}
