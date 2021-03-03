﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrosssCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
        void Add(string key, object value, int duration);
    }
}