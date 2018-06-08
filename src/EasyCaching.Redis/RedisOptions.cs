﻿namespace EasyCaching.Redis
{
    using EasyCaching.Core;
    using EasyCaching.Core.Internal;

    public class RedisOptions: BaseProviderOptions
    {
        public RedisOptions()
        {
            this.CachingProviderType = CachingProviderType.Redis;
        }

        public RedisDBOptions DBConfig { get; set; } = new RedisDBOptions();
    }
}
