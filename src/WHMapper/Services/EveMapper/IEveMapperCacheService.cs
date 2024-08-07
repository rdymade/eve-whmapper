﻿using WHMapper.Models.DTO.EveMapper.EveEntity;

namespace WHMapper.Services.EveMapper
{
    public interface IEveMapperCacheService
    {
        const string REDIS_ALLIANCE_KEY = "alliance:list";
        const string REDIS_COORPORATION_KEY = "coorporation:list";
        const string REDIS_CHARACTER_KEY = "charactere:list";
        const string REDIS_SHIP_KEY = "ship:list";
        const string REDIS_SYSTEM_KEY = "system:list";
        const string REDIS_CONSTELLATION_KEY = "constellation:list";
        const string REDIS_REGION_KEY = "region:list";
        const string REDIS_STARTGATE_KEY = "stargate:list";
        const string REDIS_GROUP_KEY = "group:list";
        const string REDIS_WORMHOLE_KEY = "wormhole:list";
        const string REDIS_SUN_KEY = "sun:list";
        
        Task<TEntity> GetAsync<TEntity>(int key)
            where TEntity : AEveEntity;

        Task<bool> AddAsync<TEntity>(TEntity entity)
            where TEntity : AEveEntity;

        Task<bool> ClearCacheAsync<TEntity>()
            where TEntity : AEveEntity;
    }
}
