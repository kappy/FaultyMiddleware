﻿using System.Collections;

namespace FaultyMiddleware.Client
{
    public class PoorMansCacheProvider
    {
        private readonly Hashtable _hash;

        public PoorMansCacheProvider()
        {
            _hash = new Hashtable();
        }

        public bool TryGet(object key, out object value)
        {
            if (_hash.ContainsKey(key))
            {
                value = _hash[key];
                return true;
            }
            value = null;
            return false;
        }

        public void Set(object key, object value)
        {
            _hash[key] = value;
        }
    }
}
