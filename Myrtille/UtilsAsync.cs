using System.Collections.Generic;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;
using System;

namespace Myrtille
{

    public class UtilsAsync
    {
        async Task<List<byte>> ReadByteArrayAsync(string filePath)
        {
            var sourceStream =
                new FileStream(
                    filePath,
                    FileMode.Open, FileAccess.Read, FileShare.Read,
                    bufferSize: 4096, useAsync: true);

            byte[] buffer = new byte[0x1000];
            List<byte> bufferedStream = new List<byte>();
            int numRead;
            while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                bufferedStream.AddRange(buffer);
            }
            return bufferedStream;
        }

        public async Task<ExcelPackage> LoadExcelFromFile(string filePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            List<byte> buffer = await ReadByteArrayAsync(filePath);

            MemoryStream stream = new MemoryStream();
            foreach (byte b in buffer)
            {
                stream.WriteByte((byte)b);
            }
            ExcelPackage excelPackage = new ExcelPackage(stream);

            buffer = null;
            stream = null;

            return excelPackage;
        }

    }

}
