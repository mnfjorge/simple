﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Simple.IO.Excel
{
    public class WorkbookReader
    {
        public static WorkbookReader<T> Create<T>(HeaderDefinition<T> header)
        {
            return new WorkbookReader<T>(
                new SheetReader<T>(
                    new RowReader<T>(header)));
        }
    }

    public class WorkbookReader<T>
    {
        protected SheetReader<T> Reader { get; set; }

        public WorkbookReader(SheetReader<T> reader)
        {
            Reader = reader;
        }

        public SheetResultCollection<T> Read(Workbook workbook)
        {
            return new SheetResultCollection<T>(ReadInternal(workbook));
        }

        private IEnumerable<SheetResult<T>> ReadInternal(Workbook workbook)
        {
            for (int i = 0; i < workbook.NumberOfSheets; i++)
            {
                var sheet = workbook.GetSheetAt(i);

                yield return Reader.Read(sheet);
            }

        }

    }
}