﻿using CsvHelper.Configuration;
using System.Collections.Generic;

namespace Tailwind.Traders.Product.Api2.Infrastructure
{
    public interface IProcessFile
    {
        IEnumerable<TModel> Process<TModel>(string root, string fileName, CsvConfiguration cfg = null);
    }
}
